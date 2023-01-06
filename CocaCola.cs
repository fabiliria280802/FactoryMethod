using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class CocaCola : BebidaGaseosa
    {
        public override string name()
        {
            return "Coca Cola";
        }
        public override double cantidadAzucar()
        {
            //Segun google una coca cola de 330ml contien 35.1gramos de azúcar
            return 35.1;
        }
    }
}
