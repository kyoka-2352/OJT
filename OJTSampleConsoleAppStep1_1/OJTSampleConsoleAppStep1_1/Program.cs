using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJTSampleConsoleAppStep1_1
{
    //【初めの一歩】
    class Program
    {
        static void Main(string[] args)
        {
            // 1-1 コンソール画面に「HelloWorld.」という文字列を表示する。
            Console.WriteLine("HelloWorld.");

            /* 1-2 
             * コンソール画面に文字列「HelloWorld.」と文字列「自分の名前」を改行しないで表示する
             */
            Console.Write("HelloWorld.");
            Console.WriteLine("構研 太郎");

            // キーが押されるまで待機する
            Console.WriteLine("続行するには何かキーを押してください . . .");
            Console.ReadKey();
        }
    }
}
