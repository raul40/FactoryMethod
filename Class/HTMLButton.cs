﻿using FactoryMethod.Class.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Class
{
    public class HTMLButton : IButton
    {
        public string Render()
        {
            return "{Result of HTML Button}";
        }
    }
}
