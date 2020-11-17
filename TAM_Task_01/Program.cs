using System;

namespace TAM_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {  

            int coins;
            int crystalPrice = 15;
            int buyCrystal;
            bool Purchase;

            Console.Write("_________________________________________________________________________");
            Console.Write("\n=========================================================================");
            Console.Write("\nВведите количество имеющихся монет - ");
            coins = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Цена кристалла {crystalPrice} монет. Сколько вы желаете приобрести кристаллов? - ");
            buyCrystal = Convert.ToInt32(Console.ReadLine());

            Purchase = coins >= crystalPrice * buyCrystal;
            buyCrystal *= Convert.ToInt32(Purchase);
            coins -= crystalPrice * buyCrystal;

            Console.WriteLine($"У вас в осталось {coins} монет и появилось {buyCrystal} кристаллов.");
            Console.Write("=========================================================================");
            Console.Write("\n_________________________________________________________________________");

        }
    }

}
