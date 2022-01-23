using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<int> bank1 = new Bank<int>();
            bank1.Input();
            Console.WriteLine(bank1.Print());
            Bank<string> bank2 = new Bank<string>();
            bank2.Input();
            Console.WriteLine(bank2.Print());
            Console.ReadKey();
        }
    }
    public class Bank<T>
    {
        private T Number { get; set; }
        private double Summ { get; set; }
        private string Name { get; set; }
        public string Print()
        {
            return $"{Number} {Summ} {Name}" ;
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс");
            Summ = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
        }
    }
}
