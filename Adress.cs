﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsontry
{
    internal class Adress
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        
        public string ZipCode { get; set; }

        public Geo geo { get; set; }

    }
}
