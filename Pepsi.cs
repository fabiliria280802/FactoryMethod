using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Pepsi : BebidaGaseosa
    {
        public override string name()
        {
            return "Pepsi";
        }
        public override double cantidadAzucar()
        {
            //Segun google una lata de Pepsi de 330ml tiene 36.6gramos de azúcar
            return 36.6;
        }
    }
}
