using System;

namespace ExeterBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Deck deck = new Deck();

            Hand hand1 = new Hand(deck.DealCards(2));
            Console.WriteLine(hand1.ToString());
            Console.WriteLine(hand1.Value);
            Console.WriteLine("WHY IS IT DEALING SO MANY CARDS?");
            Console.ReadLine();
        }
    }
}