using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_基础知识_类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //double b = a;           //自动类型转换

            //double c = 10.0;
            //a = (int)c;         //强制类型转换

            //Father f = new Son();
            //Son s = (Son)f;         //强制类型转换
            //s.SonMethod();

            //Father f = new Father();
            //Son s = (Son)f;         //报错
            //s.SonMethod();

            //Father f = new Son();
            //Son s = f as Son;         //强制类型转换
            //s.SonMethod();

            Father f = new Father();
            Son s = f as Son;         //不会报错， 返回null
            Console.WriteLine(s == null);
        }
    }

    class Father
    {

    }

    class Son:Father
    {
        public void SonMethod()
        {

        }
    }
}
