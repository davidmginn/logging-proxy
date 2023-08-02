using System;
namespace LoggingWrapper
{
    public class GenericLogger
    {
        public static TResult LogEntryAndExit<TResult>(Func<TResult> func)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            var result = func();

            Console.WriteLine("Function Exit"); // AI Logging complete

            return result;
        }

        public static TResult LogEntryAndExit<T, TResult>(Func<T, TResult> func, T arg)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            var result = func(arg);

            Console.WriteLine("Function Exit"); // AI Logging complete

            return result;
        }

        public static TResult LogEntryAndExit<T1, T2, TResult>(Func<T1, T2, TResult> func, T1 arg1, T2 arg2)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            var result = func(arg1, arg2);

            Console.WriteLine("Function Exit"); // AI Logging complete

            return result;
        }
    }
}

