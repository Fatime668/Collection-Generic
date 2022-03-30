using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Lemon<string> lemon = new Lemon<string>("A , B , C");
            Apple<char> apple = new Apple<char>('D');
            Pineapple<string> pineapple = new Pineapple<string>("B,C");
            BasketList<string> basketList = new BasketList<string>();
            Console.WriteLine("**********Fruits**********");
            basketList.Add("Lemon");
            basketList.Add("Apple");
            basketList.Add("Pinaple");
            basketList.Add("Orange");
            basketList.Add("Banana");
            foreach (var item in basketList.GetVitamins())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Fruits count: " + basketList.Count);

        }
    }
}
