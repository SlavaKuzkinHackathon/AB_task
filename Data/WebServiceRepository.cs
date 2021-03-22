using System;
using System.Collections.Generic;
using System.Linq;
using AB.Models;

namespace AB.Data {
    public class WebServiceRepository : IWebServiceRepository {
        private readonly DataContext _context;

        public WebServiceRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateUser(User usr)
        {
            if(usr == null)
            {
                throw new ArgumentNullException(nameof(usr));
            }

            _context.Users.Add(usr);
        }

        public void DeleteUser(User usr)
        {
            if(usr == null)
            {
                throw new ArgumentNullException(nameof(usr));
            }
            _context.Users.Remove(usr);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateUser( User usr)
        {
            //This does nothing
        }
    }
}
