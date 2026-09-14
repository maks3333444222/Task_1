using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество секунд : ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            int hours = seconds / 3600;
            int ostatok = seconds - hours * 3600;
            int minutes = ostatok / 60;
            int seconds2 = ostatok % 60;

            Console.WriteLine($"Итог: {hours}ч, {minutes}мин, {seconds2} сек");
            Console.ReadLine();


        }
    }
}
