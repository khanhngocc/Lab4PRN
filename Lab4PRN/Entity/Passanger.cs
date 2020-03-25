using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4PRN.Entity
{
    public class Passanger
    {
        private int id;
        private String lname;
        private String fname;
        private String dob;
        private String email;
        private int phone;
        public string Lname { get => lname; set => lname = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Email { get => email; set => email = value; }
        public int Phone { get => phone; set => phone = value; }
        public int Id { get => id; set => id = value; }
    }
}