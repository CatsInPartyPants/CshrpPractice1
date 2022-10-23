using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityName
{
    internal class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public long CountPeople { get; set; }
        public int CodeCity { get; set; }

        public void InputCity()
        {
            Console.Write("Введите имя города: ");
            Name = Console.ReadLine();
            Console.Write("Введите имя страны: ");
            Country = Console.ReadLine();
            Console.Write("Введите население: ");
            //первый вариант перевода из стринг в инт64
            CountPeople = Int64.Parse(Console.ReadLine());
            Console.Write("Введите код города: ");
            //второй вариант перевода из стринг в инт32
            CodeCity = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Имя города: {Name}, имя страны: {Country}," +
                $"население: {CountPeople}, код города: {CodeCity}";
        }

        public static void Print()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
