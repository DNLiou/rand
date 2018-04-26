using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入身高(cm): ");
            string height = Console.ReadLine();
            float h = float.Parse(height) / 100;
            Console.Write("請輸入體重(kg): ");
            string weight = Console.ReadLine();
            float w = float.Parse(weight);
            float BMI = (w / (h * h));
            if (BMI < 16.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 超輕");
                Console.ReadLine();
            }
            if (16.5 <= BMI && BMI < 18.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 過輕");
                Console.ReadLine();
            }
            if (18.5 <= BMI && BMI < 24)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 正常");
                Console.ReadLine();
            }
            if (24 <= BMI && BMI < 28)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 超重.");
                Console.ReadLine();
            }
            if (28 <= BMI && BMI <= 31.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 過重");
                Console.ReadLine();
            }
            if (BMI > 31.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 重爆");
                Console.ReadLine();
            }
        }
    }
}
