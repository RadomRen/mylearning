using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_多线程
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //线程
            //Thread t = Thread.CurrentThread;        //获取当前的线程
            //t.Name = "MainThread";          //设置主线程的名字
            //Console.WriteLine(t.Name);

            ThreadStart start = new ThreadStart(ChildThreadMethod);
            Thread thread = new Thread(start);          //创建一个新的线程

            thread.Start();//开启线程

            //Console.WriteLine("Main Method");

            Thread.Sleep(1000);

            //while (true)
            //{
            //    Console.WriteLine("MainThread - 聊天中....");
            //    Thread.Sleep(1000);//1s = 1000ms
            //}

            thread.Abort();//中断线程

        }

        private static void ChildThreadMethod()
        {
            while (true)
            {
                Console.WriteLine("ChildThread - 听歌中....");
                Thread.Sleep(1000);
            }
        }
    }
}
