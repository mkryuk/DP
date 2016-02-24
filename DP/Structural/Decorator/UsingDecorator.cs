using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Decorator
{
    public class UsingDecorator
    {
        public static void Run()
        {
            var KlarkDracula = new Human {Name = "Klark Dracula"};
            var SuperKlarkDracula = new Superman(KlarkDracula);
            var SuperVampireKlarkDracula = new Vampire(SuperKlarkDracula);

            SuperVampireKlarkDracula.WhoAmI();
        }
    }
}
