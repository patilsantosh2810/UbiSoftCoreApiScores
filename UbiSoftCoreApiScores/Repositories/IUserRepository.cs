using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UbiSoftCoreApiScores.Models;

namespace UbiSoftCoreApiScores.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        IEnumerable<User> GetAll();

    }
}
