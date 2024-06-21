using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //入力する数の最大値
            const int MAX_CARD = 4;
            //カードの配列
            int[] cards = new int[MAX_CARD];
            //何回一致したか
            int pair = 0;

            //4回カードの値を入力
            for (int i = 0; i < MAX_CARD; i++)
            {
                Console.Write("{0}番目のカードを入力(1～4)＞",i + 1);
                int.TryParse(Console.ReadLine(), out cards[i]);
            }

            Console.WriteLine();

            //入力された値を表示
            Console.WriteLine("入力した数字");
            Console.WriteLine("----------------------------------");
            for (int i = 0;i < cards.Length; i++)
            {
                Console.Write(cards[i]);
            }

            //ペア数を求める
            for (int i = 0; i < cards.Length; i++)
            {//２重ループでcard配列のi番目とn番目(i+1)を比べてペアを探す
                for (int n = i + 1; n < cards.Length; n++)
                {
                    if (cards[i] == cards[n])
                    {//ペアだったらペア数+1する
                        pair++;
                    }
                }
            }

            Console.WriteLine();

            //pairの数によって表示する文章を変える
            if (pair == 0)
            {
                Console.WriteLine("ノーペア");
            }
            else if (pair == 1)
            {
                Console.WriteLine("ワンペア");
            }
            else if (pair == 2)
            {
                Console.WriteLine("ツーペア");
            }
            else if (pair == 3)
            {
                Console.WriteLine("スリーカード");
            }
            else if (pair == 4)
            {
                Console.WriteLine("フォーカード");
            }
            else
            {
                //エラーメッセージ
                Console.WriteLine("もうロイヤルストレートフラッシュでいいよ");
            }

            //キー入力待ち
            Console.WriteLine("ENTERを押して終了");
            Console.ReadLine();
        }
    }
}
