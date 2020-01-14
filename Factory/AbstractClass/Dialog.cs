using FactoryMethod.Class.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory.AbstractClass
{
    public abstract class Dialog
    {
        public abstract IButton CreateButton();

        public string Render()
        {
            var button = CreateButton();

            var result = "Rendering object: " + button.Render();

            return result;
        }
    }
}
