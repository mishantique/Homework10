using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("Введите градусы");
                int gradus_ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты");
                int min_ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите секунды");
                int sec_ = Convert.ToInt32(Console.ReadLine());

                angle = new Angle(gradus_, min_, sec_);
            } 
            while (angle.IsCorrect == false);
            Console.WriteLine("В переводе в радианы вы ввели: {0}", angle.GetRadians());
            Console.ReadKey();
        }
    }
}
