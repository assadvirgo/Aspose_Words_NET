﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.LINQ
{
    public class Manager
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public byte[] Photo { get; set; }
        public IEnumerable<Contract> Contracts { get; set; }
    }   
}
