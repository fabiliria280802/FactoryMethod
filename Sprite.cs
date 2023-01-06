using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Sprite : BebidaGaseosa
    {
        public override string name()
        {
            return "Sprite";
        }
        public override double cantidadAzucar()
        {
            //Segun google una lata de Sprite de 330ml tiene 34.8gramos de azúcar
            return 34.8;
        }
    }
}
