using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Until_07._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.");
            Console.Write("Мир ");
            Console.Write("Труд");
            Console.Write(" Май");

            Console.WriteLine();

            Console.WriteLine("Мир");
            Console.WriteLine("  Труд");
            Console.WriteLine("     Май");

            Console.WriteLine("Задание 2.Программа просит пользователя ввести 2 числовые переменные. А после она меняет их местами и выводит результат на экран.");
            Console.WriteLine("Введите переменную:");
            string v1 = Console.ReadLine();
            Console.WriteLine("Введите еще одну переменную");
            string v2 = Console.ReadLine();
            Console.WriteLine(v2+v1);

            Console.WriteLine("Задание 3. Длина окружности и площадь круга.");
            const double pi = 3.1415926535;
            Console.WriteLine("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double L = 2 * pi * r ;
            double S = pi * r * r ;
            Console.WriteLine("Длина окружности:" + L);
            Console.WriteLine("Площадь круга: " + S);

            Console.WriteLine("Задание 4. Найти значение y=cos(x)");
            Console.WriteLine("Введите угол в градусах: ");
            double angle = ((Convert.ToDouble(Console.ReadLine()) * pi) / 180) ;    
            double y = Math.Round( Math.Cos(angle), 6);
            Console.WriteLine(y);

            Console.WriteLine("Задание 5. Найти корни квадратного уравнения");
            Console.WriteLine("Введите коэффиценты a,b,c кв. уравнения");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double D = Math.Sqrt(b * b - 4 * a * c);
            double x1, x2;
            if (D >= 0)
            {
                x1 = (-b - D) / (2 * a);
                x2 = (-b + D) / (2 * a);
                Console.WriteLine($"Ответ: x1 = {x1}, x2 = {x2}") ;
            }
            else
            {
                Console.WriteLine("Нет действительных корней");
            }

            Console.WriteLine("Задание 6. Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:");
            Console.WriteLine("a) Введите 3 переменные a, b, c");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double window1 = a;
            a = b;
            b = c;
            double с = window1; // ?????
            Console.WriteLine($"a={a}, b={b}, c={c}");
            Console.WriteLine("б) Введите 3 переменные a, b, c");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double window2 = c;
            c=b;
            b=a; 
            a=window2;
            Console.WriteLine($"a={a}, b={b}, c={c}");

            Console.WriteLine("Задание 7. Составить программу вывода на экран «столбиком» четырех случайных чисел. ");
            Random rnd1 = new Random(); // Объект класса
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            Random rnd4 = new Random();
            int random1 = rnd1.Next(); // Генерация
            int random2 = rnd2.Next();
            int random3 = rnd3.Next();
            int random4 = rnd4.Next();
            Console.WriteLine(random1);
            Console.WriteLine(random2);
            Console.WriteLine(random3);
            Console.WriteLine(random4);

            Console.WriteLine("Задание 8. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале.");
            Console.WriteLine("Введите 3-ех значное число");
            int N = Convert.ToInt32(Console.ReadLine());
            int Number = N % 10 * 100 + N/10;   
            Console.WriteLine(Number);

            Console.WriteLine("Задание 9. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.");
            Console.WriteLine("Напишите сколько купили кг. конфет, печенья, яблок(в таком же порядке): ");
            double candy = Convert.ToDouble(Console.ReadLine());
            double cookie = Convert.ToDouble(Console.ReadLine());
            double apple = Convert.ToDouble(Console.ReadLine());
            int ca = 110;
            int co = 90;
            int ap = 70;
            double sum = candy*ca + cookie*co + apple*ap;
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
