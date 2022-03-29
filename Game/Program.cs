// See https://aka.ms/new-console-template for more information

namespace RPS
{
    internal class Program
    {
        enum RPS
        {
            Ножницы = 1,
            Камень = 2,
            Бумага = 3
        }
        static void Main(string[] args)
        {
            string choice;
            int player1;
            int player2;
            string victory = string.Empty;
            Console.WriteLine("Камень-ножницы-бумага! Ходит Игрок 1");
            Console.WriteLine($"{RPS.Ножницы} {(int)RPS.Ножницы}");
            Console.WriteLine($"{RPS.Камень} {(int) RPS.Камень}");
            Console.WriteLine($"{RPS.Бумага} {(int) RPS.Бумага}");
            choice = Console.ReadLine();
            player1 = int.Parse(choice);
            Console.Clear();
            Console.WriteLine("Камень-ножницы-бумага! Ходит Игрок 2");
            Console.WriteLine($"{RPS.Ножницы} {(int)RPS.Ножницы}");
            Console.WriteLine($"{RPS.Камень} {(int)RPS.Камень}");
            Console.WriteLine($"{RPS.Бумага} {(int)RPS.Бумага}");
            choice = Console.ReadLine();
            player2 = int.Parse(choice);

            if (player1 == player2)
            {
                victory = "Ничья";
                Console.WriteLine(victory);
            }
            else
            {
                if ((player1 == 2 && player2 < 2) || (player1 == 1 && player2 == 3) || (player1 == 3 && player2 == 2))
                    victory = "Игрок 1";
                else
                    victory = "Игрок 2";
                Console.WriteLine($"Победил {victory}");
            }
           
        }

    }
}

