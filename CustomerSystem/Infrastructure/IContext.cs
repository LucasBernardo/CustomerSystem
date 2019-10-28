using CustomerSystem.Models;
using System.Collections.Generic;

namespace CustomerSystem.Infrastructure
{
    public interface IContext
    {
        public bool Login(string login, string password);
        public List<User> ReturnUsers();
        public void SetUserLogged(User usr);
        public User GetUserLogged();
        public User getUser(string email);
        public List<Customer> GetCustomersList(string email);
    }
}