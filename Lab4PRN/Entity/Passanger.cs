using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4PRN.Entity
{
    public class Passanger
    {
        private String lname;
        private String fname;

        public string Lname { get => lname; set => lname = value; }
        public string Fname { get => fname; set => fname = value; }
    }
}