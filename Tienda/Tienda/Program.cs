using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("Bienvenido a la tienda de camisas");

            Console.WriteLine("Ingrese la cantidad de camisas que desea comprar:");
            int cantidadCamisas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio por camisa:");
            double precioPorCamisa = double.Parse(Console.ReadLine());

            double costoTotal = CalcularCostoTotal(cantidadCamisas, precioPorCamisa);

            Console.WriteLine($"El costo total de las camisas es: {costoTotal:C}");
            Console.ReadLine();
        }

        static double CalcularCostoTotal(int cantidadCamisas, double precioPorCamisa)
        {
            double costoTotal = 0;

            if (cantidadCamisas == 1)
            {
                costoTotal = cantidadCamisas * precioPorCamisa;
            }
            else if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
            {
                double descuento = 0.15; // 15%
                costoTotal = (cantidadCamisas * precioPorCamisa) * 0.85; 
            }
            else if (cantidadCamisas > 5)
            {
                double descuento = 0.20; // 20%
                costoTotal = (cantidadCamisas * precioPorCamisa) *0.80;
            }

            return costoTotal;
        }
    }
}
