using FactoryMethod.Class.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Class
{
    public class WindowsButton : IButton
    {
        public string Render()
        {
            return "{Result of Windows Button}";
        }
    }
}
