using Golf.Entites;
using Golf.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf.ListRepositories
{
    class UserListRepository : IDbManager<User>
    {
        public static List<User> users = new List<User>
        {
            new User("Mario", "Rossi", new DateTime(1985, 05, 06), GenderEnum.Male, true, null),
            new User("Lucia", "Bianchi", new DateTime(1990, 07, 03), GenderEnum.Female, false, null),
            new User("Sara", "Gialli", new DateTime(1970, 03, 10), GenderEnum.Female, true, null),
            new User("Paolo", "Marroni", new DateTime(1980, 02, 8), GenderEnum.Male, false, null),
            new User("Luca", "Blu", new DateTime(1960, 03, 10), GenderEnum.Male, true, null),
            new User("Paola", "Rosi", new DateTime(1968, 08, 05), GenderEnum.Female, false, null),
        };

        public void Delete(User user)
        {
            users.Remove(user);
        }

        public List<User> Fetch()
        {
            return users;
        }

        public User GetById(int? id)
        {
            return users.Find(u => u.Id == id);
        }

        public void Insert(User user)
        {
            users.Add(user);
        }

        public void Update(User user)
        {            
            var userToDelete = GetById(user.Id);

            Delete(userToDelete);
                        
            Insert(user);
        }
    }
}
