// See https://aka.ms/new-console-template for more information
//Nota: se sobre escribio la solución original para hacer un ejemplo.
using FactoryMethod;
int aux = 0;
bool aux3 = false;
do
{
    Console.Clear();
    string soda = "";
    do
    {
        Console.Clear();
        Console.WriteLine("Bienvenidx a la consultoria de azucares en las gaseosas. \n Seleccione la gaseosa de la que desea saber la cantidad de azucar: \n\t1.Pepsi \n\t2.Coca cola \n\t3.Fanta \n\t4.Sprite \n La opción escogida es: ");
        soda = Console.ReadLine();
        bool isNumeric = int.TryParse(soda, out _);
        if (string.IsNullOrEmpty(soda) == true | !isNumeric)
        {
            Console.WriteLine("\t< ALERTA > \n\tDebe ingresar un valor númerico. \n\tIntente nuevamente");
            aux3 = true;
            System.Threading.Thread.Sleep(10000);
        }
    } while (aux3 == true);
    aux = Int32.Parse(soda);
    BebidaGaseosa gaseosa = Creador.CreadorBebida(aux);
    if (gaseosa != null)
    {
        Console.WriteLine("\nUna " + gaseosa.name() + " de 330ml tiene " + gaseosa.cantidadAzucar() + "gramos de azúcar.");
    }
    else if (aux > 4 | aux < 1)
    {
        Console.WriteLine("\t< ALERTA > \n\tNo se puede ingresar números negativos o mayores a 4 dentro de las opciones. \n\tIntente nuevamente.");
        aux = 0;
        System.Threading.Thread.Sleep(10000);
    }
}
while (aux == 0);

