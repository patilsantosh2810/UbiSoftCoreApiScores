using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UbiSoftCoreApiScores.Models
{
    public class User
    {
      
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Rank { get; set; }
        public int Kills { get; set; }
        public int Score { get; set; }
        public string Match { get; set; }
    }
}
