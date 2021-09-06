﻿using System;

namespace Singleton.ThreadSafe
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
