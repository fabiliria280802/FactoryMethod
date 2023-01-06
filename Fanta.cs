using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Fanta : BebidaGaseosa
    {
        public override string name()
        {
            return "Fanta";
        }
        public override double cantidadAzucar()
        {
            //Segun google una lata de fanta de 330ml tiene 28gramos de azúcar
            return 28.0;
        }
    }
}
