﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02代理模式
{
    /// <summary>
    /// 业务接口
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// get
        /// </summary>
        /// <returns></returns>
        bool GetSomething();
        /// <summary>
        /// do
        /// </summary>
        void DoSomething();
    }
}
