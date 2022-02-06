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

            Console.WriteLine("Как вас зовут: ");
            name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет: ");
            age = Console.ReadLine();
            Console.WriteLine("Сколько вы весите: ");
            weight = Console.ReadLine();
            Console.WriteLine("Где вы работаете: ");
            job = Console.ReadLine();
            Console.WriteLine("Какое ваше хобби: ");
            hobby = Console.ReadLine();

            Console.Write("Вас зовут " + name + ". Ваш возраст " + age + ", ваш вес " + weight + ", ваше место работы "
                + job + ", ваше хобби " + hobby + ". ");

        }
    }
}
