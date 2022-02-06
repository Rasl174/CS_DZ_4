using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string job;
            string age;
            string hobby;
            string weight;

            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            age = Console.ReadLine();
            Console.WriteLine("Введите ваш вес: ");
            weight = Console.ReadLine();
            Console.WriteLine("Введите место работы: ");
            job = Console.ReadLine();
            Console.WriteLine("Введите ваше хобби: ");
            hobby = Console.ReadLine();

            Console.Write("Вас зовут " + name + ". Ваш возраст " + age + ", ваш вес " + weight + ", ваше место работы "
                + job + ", ваше хобби " + hobby + ". ");

        }
    }
}
