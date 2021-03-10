using System;

namespace GamblerStake
{
    class Program
    {
        static void Main(string[] args)
        {
            int Stake_Everyday = 100;
            int Stake_bet = 1;
            int Gambler = 0;
            int win = 1;
            int loose = 0;
            Random random = new Random();
            int GamblerCheck = random.Next(0, 2);
            switch (GamblerCheck)
            {
                case win:
                    Gambler = 1;
                    break;
                case loose:
                    Gambler = 0;
                    break;
            }
            Console.WriteLine("Gambler has: " + Gambler);
            Console.ReadKey();
        }
    }
}
