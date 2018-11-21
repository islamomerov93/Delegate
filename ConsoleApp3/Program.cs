using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            var str = Console.ReadLine();
            MyClass cls = new MyClass(str);
            Func funcDell = new Func(cls.Space);
            funcDell += cls.Reverse;
            Run run = new Run();
            run.runFunc(funcDell, str);
        }
    }
    delegate void Func(string str);
    class MyClass
    {
        public string str { get; set; }
        public MyClass(string str)
        {
            this.str = str;
        }
        public void Space(string str)
        {
            char[] tmp = new char[str.Length * 2 - 1];
            for (int i = 0, j = 0; i < tmp.Length; i++)
            {
                if (i % 2 == 1) tmp[i] = '_';
                else tmp[i] = str[j++];
            }
            Console.WriteLine(tmp);
        }
        public void Reverse(string str)
        {
            char[] tmp = new char[str.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length;)
            {
                tmp[i++] = str[j--];
            }
            Console.WriteLine(tmp);
        }
    }
    class Run
    {
        public void runFunc(Func func, string str) => func(str);
    }
}
