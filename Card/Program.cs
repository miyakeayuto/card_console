using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Program
    {
        const int MAX_CARD = 4;

        static void Main(string[] args)
        {
            int[] cards = new int[MAX_CARD];

            for (int i = 0; i < MAX_CARD; i++)
            {
                Console.Write("{0}番目のカードを入力(1～4)＞",i + 1);
                int.TryParse(Console.ReadLine(), out cards[i]);
            }

            //キー入力待ち
            Console.WriteLine("ENTERを押して終了");
            Console.ReadLine();
        }
    }
}
