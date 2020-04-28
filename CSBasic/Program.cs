using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "정" + "민" + "지";
            int add = 2;
            int Alpha;

            //한 줄 주석
            /*
             * 
             * 여러줄 주석
             * 
             */

            Console.WriteLine("Hello, World!");
            Console.Write("Hello");
            Console.Write("World");

            Console.WriteLine(52);
            Console.WriteLine(7%3);
            Console.WriteLine('A');
            Console.WriteLine("A");

            Console.WriteLine("한빛\t미디어 아카데미");
            Console.WriteLine("한빛\n미디어 아카데미");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("가" + "나" + "다");
            Console.WriteLine("안녕"[0]);
            //Console.WriteLine("안녕"[100]); //에러 발생

            Console.WriteLine(true);
            Console.WriteLine(52 < 273);
            Console.WriteLine(52 > 273);

        }
    }
}
