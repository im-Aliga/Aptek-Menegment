using Aptek_Management.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptek_Management.Database.Reposity
{
    internal class UserReposity
    {
        private static int _idCounter;
        public static int IdCounter
        {
            get
            {
                _idCounter++;
                return _idCounter;
            }
        }

        public static List<User> Users { get; set; } = new List<User>()
        {
            new User ("Ali","Aliyev","Ali@gmail.com","123321"),
            new Admin("Super","Admin","admin@gmail.com","321123")

        };


        public static User AddUser(User user)
        {
            Users.Add(user);
            return user;
        }
        public static List<Owner> GetAllOwners()
        {
            List<Owner> owners = new List<Owner>();
            foreach (User user in Users)
            {
                if (user is Owner)
                {
                    owners.Add((Owner)user);

                }
            }
            return owners;
        }
        public static List<Drugist> GetAllDrugists()
        {
            List<Drugist> owners = new List<Drugist>();
            foreach (User user in Users)
            {
                if (user is Drugist)
                {
                    owners.Add((Drugist)user);

                }
            }
            return owners;

        }





        public static List<User> GetAll()
        {
            return Users;
        }
        public static void ShowAdmin()
        {
            List<User> users = GetAll();
            foreach (User user in users)
            {
                if (user is Admin)
                {
                    Console.WriteLine(user.GetUserInfoForAdmin());
                }


            }

        }


        public static void Delete(User user)
        {
            Users.Remove(user);
        }


    }
}
}
