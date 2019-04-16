using System;
using System.Collections.Generic;
using System.Text;

namespace first_console_app
{
    public class Rabbit
    {
        public int age;

        public Rabbit(int _age)
        {
            age = _age;
        }

        public long[] MakeFiboList(int len)
        {
            long[] list = new long[len];
            long lastItem = 1;
            long newItem = 1;
            long temp;
            list[0] = 1;
            for (int i = 1; i < len; i++)
            {
                list[i] = newItem;
                temp = newItem;
                newItem = lastItem + newItem;
                lastItem = temp;
            }

            return list;
        }
    }
}
