﻿using RealEstate.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Entities
{
    public class Partner:BaseEntity<int>
    {
        public string Name { get; set; }
        public string LogoPath { get; set; }

    }
}
