using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4PRN.Entity
{
    public class Account
    {
        private int id;
        private String username;
        private String password;
        private Passanger user;
        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Passanger User { get => user; set => user = value; }
       
    }
}