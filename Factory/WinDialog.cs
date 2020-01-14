using FactoryMethod.Class;
using FactoryMethod.Class.Interfaces;
using FactoryMethod.Factory.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class WinDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
