using FactoryMethod.Factory;
using FactoryMethod.Factory.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the WinDialog.");
            ClientCode(new WinDialog());

            Console.WriteLine();

            Console.WriteLine("App: Launched with the WebDialog.");
            ClientCode(new WebDialog());

            Console.ReadLine();
        }

        private void ClientCode(Dialog _Dialog)
        {
            Console.WriteLine("Client: I´m not aware of the Dialog's class, but it still works\n" + _Dialog.Render());
        }
    }
}
