﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// 懒汉，线程不安全
    /// </summary>
    public class Singleton1
    {
        private static Singleton1 _singleton = null;//私有静态变量

        private Singleton1() { }//私有化构造函数

        public static Singleton1 GetSingleton()//静态的对象获取方法
        {
            if (_singleton == null)//保证为空才创建
            {
                _singleton = new Singleton1();
            }
            return _singleton;
        }
    }

    /// <summary>
    /// 懒汉，线程安全
    /// </summary>
    public class Singleton2
    {
        private static Singleton2 _singleton = null;
        private static object _lock = new object();

        private Singleton2() { }

        public static Singleton2 GetSingleton()
        {
            lock (_lock)//保证线程安全
            {
                if (_singleton == null)//保证为空才创建
                {
                    _singleton = new Singleton2();
                }
                return _singleton;
            }

        }
    }

    /// <summary>
    /// 懒汉优化，线程安全（双检锁/双重校验锁（double-checked locking））
    /// </summary>
    public class Singleton3
    {
        private static Singleton3 _singleton = null;
        private static object _lock = new object();

        private Singleton3() { }

        public static Singleton3 GetSingleton()
        {
            if (_singleton == null)//保证对象初始化之后，线程不需要等待锁
            {
                lock (_lock)//保证线程安全
                {
                    if (_singleton == null)//保证为空才创建
                    {
                        _singleton = new Singleton3();
                    }
                }
            }
            return _singleton;
        }
    }

    /// <summary>
    /// 饿汉模式1
    /// </summary>
    public class Singleton4
    {
        private static Singleton4 _singleton = null;

        private Singleton4()
        {

        }

        /// <summary>
        /// 静态构造函数，由CLR调用，在使用之前被调用，而且之调用一次
        /// </summary>
        static Singleton4()
        {
            _singleton = new Singleton4();
        }

        public static Singleton4 GetSingleton()
        {
            return _singleton;
        }

      
    }

    /// <summary>
    /// 饿汉模式2
    /// </summary>
    public class Singleton5
    {
        /// <summary>
        /// 静态变量：会在类型第一次使用的时候初始化，而且只初始化一次
        /// </summary>
        private static Singleton5 _singleton = new Singleton5();

        private Singleton5()
        {

        }

        public static Singleton5 GetSingleton()
        {
            return _singleton;
        }      
    }

    /// <summary>
    /// 登记模式（静态内部类）
    /// </summary>
    public class Singleton6
    {
        private static class SingletonHolder
        {
            internal static Singleton6 _singleton = new Singleton6();
        }

        private Singleton6() { }

        public static Singleton6 GetSingleton()
        {
            return SingletonHolder._singleton;
        }
    }
}
