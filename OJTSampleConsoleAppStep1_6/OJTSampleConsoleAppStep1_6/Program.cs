using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJTSampleConsoleAppStep1_6
{
    //【クラスとオブジェクト】
    class Program
    {
        static void Main(string[] args)
        {
            /* 6-1
             * 最大値と最小値を求めるクラス「MinMax」を作成し、5つの数の最大値・最小値を出力する。
             */

            MinMax minMax = new MinMax(); //クラス

            int[] num = { 58, 67, 89, 74, 13 }; //数値が入った配列　→　MinMaxクラスの引数

            Console.WriteLine("問6-1");
            Console.WriteLine("最大値：" + minMax.Max(num)); //MinMaxクラスのMaxメソッドを使って最大値を得る
            Console.WriteLine("最小値：" + minMax.Min(num)); //MinMaxクラスのMaxメソッドを使って最小値を得る

            Console.WriteLine("続行するには何かキーを押してください . . .");
            Console.ReadKey();
        }
    }
}
