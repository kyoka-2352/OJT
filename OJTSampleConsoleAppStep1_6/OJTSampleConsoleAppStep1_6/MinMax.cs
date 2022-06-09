using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJTSampleConsoleAppStep1_6
{
    //最大値、最小値を求めるクラス
    class MinMax
    {
        //最大値を取得するメソッド
        public int Max(int[] n)
        {
            int max = 0; //最大値格納用の変数

            for(int i=0; i < n.Length; i++)
            {
                //配列[i]に入っている値が、そのときのmaxより大きければmaxを更新する
                if (n[i] > max)
                {
                    max = n[i];
                }

            }

            return max; //最大値を返す

        }

        //最小値を取得するメソッド
        public int Min(int[] n)
        {
            int min = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (i == 0)
                {
                    min = n[i]; //最初に入ってる値をminの初期値とする
                }
                else if (n[i] < min)
                {
                    min = n[i];
                }

            }

            return min; //最小値を返す

        }
    }
}
