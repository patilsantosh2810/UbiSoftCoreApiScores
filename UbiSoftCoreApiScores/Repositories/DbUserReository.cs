using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UbiSoftCoreApiScores.Models;
using UbiSoftCoreApiScores.Data;


namespace UbiSoftCoreApiScores.Repositories
{
    public class DbUserReository : IUserRepository
    {
        ServiceContext _ServiceContext;
        public DbUserReository(ServiceContext serviceContext)
        {
            _ServiceContext = serviceContext;
        }

        public void Add(User item)
        {
            lock (_ServiceContext)
            {
                _ServiceContext.users.Add(item);
                _ServiceContext.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            lock (_ServiceContext)
            {
                var users = _ServiceContext.users.ToList();
                return users;
            }
        }
    }
}
