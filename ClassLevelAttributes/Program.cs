﻿using System;

namespace ClassLevelAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAttribute(typeof(Example));
        }

        public static void GetAttribute(Type t)
        {
            UsefulClassMessageAttribute theAttribute = (UsefulClassMessageAttribute)Attribute.GetCustomAttribute(t, typeof(UsefulClassMessageAttribute));

            if(theAttribute == null)
            {
                Console.WriteLine("The attribute was not found");
            }
            else
            {
                Console.WriteLine($"The attribute value is: {theAttribute.S}");
            }

        }

    }
}
