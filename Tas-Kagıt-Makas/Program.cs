using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Taş-Kağıt-Makas oyununa hoş geldiniz!");
            Console.Write("Seçiminizi yapın (taş, kağıt, makas): ");
            string userChoice = Console.ReadLine().ToLower();

            Random random = new Random();
            int computerChoice = random.Next(1, 4); // 1: Taş, 2: Kağıt, 3: Makas

            string computerChoiceStr = (computerChoice == 1) ? "taş" : (computerChoice == 2) ? "kağıt" : "makas";
            Console.WriteLine($"Bilgisayarın seçimi: {computerChoiceStr}");

            if (userChoice == "taş" && computerChoice == 3 ||
                userChoice == "kağıt" && computerChoice == 1 ||
                userChoice == "makas" && computerChoice == 2)
            {
                Console.WriteLine("Kazandınız!");
            }
            else if (userChoice == computerChoiceStr)
            {
                Console.WriteLine("Berabere!");
            }
            else
            {
                Console.WriteLine("Bilgisayar kazandı!");
            }

            Console.Write("Oyuna devam etmek istiyor musunuz? (e/h): ");
            if (Console.ReadLine().ToLower() != "e")
            {
                break;
            }
        }
    }
}
