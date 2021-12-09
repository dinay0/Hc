
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCat
{
    enum Color
    {
        Green, Yellow, Red
    }
    class Cat
    {
        private string _name;
        private int _health;
        private Color _catColor;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(_name), "Имя не может быть пустым, попробуйте снова");
                }
            }
        }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value > 0 || value <= 100)
                {
                    _health = value;
                }
            }
        }
        public Color CatColor
        {
            get
            {
                return _catColor;
            }
            set
            {

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int act;

            Cat n = new Cat();
            Cat h = new Cat();
            Color а = new Color();

            Console.Write("Введите имя вашего питомца:");
            n.Name = Console.ReadLine();
            Console.WriteLine();

            h.Health = 10;

            for (; h.Health != 0;)
            {
                Console.WriteLine("Вы хотите покормить питомца или оставить голодным?");
                Console.WriteLine("Введите \"1\" и нажмите Enter, чтобы покормить, или \"2\" и нажмите Enter, чтобы не кормить");

                act = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (act == 1)
                {
                    h.Health++;

                    if (h.Health > 10)
                    {
                        h.Health = 10;
                    }

                    Console.WriteLine("Здоровье кошки увеличилось, теперь оно равно {0}\n", h.Health); Console.WriteLine("мяу!");
                }
                if (act == 2)
                {
                    h.Health--;
                    Console.WriteLine("Здоровье кошки уменьшилось, теперь оно равно {0}\n", h.Health);
                }
                if (h.Health == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Кошка умерла, вы слишком жестоко обращались со своим питомцем :((\n");

                    break;
                }
            }

            Console.WriteLine("Нажмите любую клавишу, чтобы закончить программу");
            Console.ReadKey();
        }
    }
}2