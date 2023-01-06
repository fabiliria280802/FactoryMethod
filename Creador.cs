using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Creador // Esta clase crea objetos
    {
        public static BebidaGaseosa CreadorBebida(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return new Pepsi();
                case 2:
                    return new CocaCola();
                case 3:
                    return new Fanta();
                case 4:
                    return new Sprite();
                default:
                    return null;
            }


        }

    }
}
