﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Person
    {
        string _name;
        string _email;
        List<Bog> _boger;
        public string Name
        {
            get
            { 
                return _name; 
            }
            set
            { 
                _name = value;
            }
        }
        public string Email
        {
            get
            { 
                return _email;
            }
            set
            { 
                _email = value; 
            }
        }
        public List<Bog> Boger
        {
            get
            {
                return _boger;
            }
            set
            {
                _boger = value;
            }
        }

    }
}