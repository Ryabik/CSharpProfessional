﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ClassInfo : Attribute
    {
        public int Importance { get; set; } = 0;

        public string Description { get; set; }

        public ClassInfo()
        {
        }

        public ClassInfo(int importance)
        {
            Importance = importance;
        }
    }
}
