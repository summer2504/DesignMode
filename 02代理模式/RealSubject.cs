﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02代理模式
{
    public class RealSubject : ISubject
    {
        /// <summary>
        /// 一个耗时耗资源的对象方法
        /// </summary>
        public RealSubject()
        {
            Thread.Sleep(2000);
            long lResult = 0;
            for (int i = 0; i < 100000000; i++)
            {
                lResult += i;
            }
            Console.WriteLine("RealSubject被构造。。。");
        }
        /// <summary>
        /// 火车站买票
        /// </summary>
        public void DoSomething()
        {
            Console.WriteLine("开始排队。。。");
            Thread.Sleep(2000);
            Console.WriteLine("终于买到票了。。。");
        }

        /// <summary>
        /// 火车站查询火车票
        /// </summary>
        /// <returns></returns>
        public bool GetSomething()
        {
            Console.WriteLine("坐车去火车站看看余票信息。。。");
            Thread.Sleep(3000);
            Console.WriteLine("到火车站，看到是有余票的");
            return true;
        }
    }
}
