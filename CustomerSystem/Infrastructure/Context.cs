using CustomerSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerSystem.Infrastructure
{
    public class Context : IContext
    {
        private List<User> users;
        private List<Region> regions;
        private List<City> cities;
        private List<Customer> customers;

        private User userLogged;

        public User GetUserLogged()
        {
            return userLogged;
        }

        public void SetUserLogged(User usr)
        {
            userLogged = usr;
        }



        public Context()
        {
            users = new List<User>
             {
                new User
                {
                    ID = 1,
                    Email = "admin@sellseverything.com",
                    Name = "User1",
                    Password = "admin123",
                    Role = Enum.Enum.Role.Administrator
                },
                new User
                {
                    ID = 2,
                    Email = "seller1@sellseverything.com",
                    Name = "User2",
                    Password = "seller1123",
                    Role = Enum.Enum.Role.Seller
                },
                new User
                {
                    ID = 3,
                    Email = "seller2@sellseverything.com",
                    Name = "User3",
                    Password = "seller2123",
                    Role = Enum.Enum.Role.Seller
                }
            };

            regions = new List<Region>
            {
                new Region
                {
                    Name = "California"
                },
                new Region
                {
                    Name = "Florida"
                },
                new Region
                {
                    Name = "Texas"
                }
            };

            cities = new List<City>
            {
                new City
                {
                    Name = "Dallas",
                    Region = regions.FirstOrDefault(x => x.Name.Equals("Texas"))
                },
                new City
                {
                    Name = "San Diego",
                    Region = regions.FirstOrDefault(x => x.Name.Equals("California"))
                },
                new City
                {
                    Name = "New York",
                    Region = regions.FirstOrDefault(x => x.Name.Equals("Florida"))
                },
                new City
                {
                    Name = "Ohio",
                    Region = regions.FirstOrDefault(x => x.Name.Equals("Texas"))
                }
            };

            customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Customer-1",
                    City = cities.FirstOrDefault(x => x.Name.Equals("Dallas")),
                    Classification = Enum.Enum.Classification.Classification1,
                    Gender = Enum.Enum.Gender.Female,
                    LastPurchase = DateTime.Now.AddMonths(-3),
                    Phone = "555555555",
                    Seller = users.Single(x => x.Name.Equals("User1"))
                },
                new Customer
                {
                    Name = "Customer-2",
                    City = cities.FirstOrDefault(x => x.Name.Equals("Ohio")),
                    Classification = Enum.Enum.Classification.Classification2,
                    Gender = Enum.Enum.Gender.Male,
                    LastPurchase = DateTime.Now.AddMonths(-2),
                    Phone = "555555555",
                    Seller = users.Single(x => x.Name.Equals("User2"))
                },
                new Customer
                {
                    Name = "Customer-3",
                    City = cities.FirstOrDefault(x => x.Name.Equals("San Diego")),
                    Classification = Enum.Enum.Classification.Classification3,
                    Gender = Enum.Enum.Gender.Female,
                    LastPurchase = DateTime.Now.AddMonths(-1),
                    Phone = "555555555",
                    Seller = users.Single(x => x.Name.Equals("User3"))
                }
            };
        }

        public bool Login(string login, string password)
        {
            return users.Any(x => x.Email == login && x.Password == password);
        }

        public User getUser(string email)
        {
            return users.FirstOrDefault(x => x.Email == email);
        }

        public List<User> ReturnUsers()
        {
            return users;
        }

        public List<Customer> GetCustomersList(string email)
        {
            var user = getUser(email);

            if (user.Role.Equals(Enum.Enum.Role.Seller))
                return customers.Where(x => x.Seller.Email.ToUpper().Equals(user.Email.ToUpper())).ToList();
            else
                return customers.ToList();
        }
    }
}
