using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SosninFM.Sprint0.Task6.V0.Lib;

namespace Tyuiu.SosninFM.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arraynums = new int[] { 1, 2, 3, 4, 5};

            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(Arraynums));

            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(Arraynums));

            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(Arraynums));

            Console.ReadKey();
        }
    }
}
