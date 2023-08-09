using System;
namespace LoggingWrapper
{
    public class GenericLogger
    {
        public static void LogEntryAndExit(Action action)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            action();

            Console.WriteLine("Function Exit"); // AI Logging complete
        }

        public static void LogEntryAndExit<T>(Action<T> action, T arg)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            action(arg);

            Console.WriteLine("Function Exit"); // AI Logging complete
        }

        public static void LogEnryAndExit<T1, T2>(Action<T1, T2> action, T1 arg1,T2 arg2)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            action(arg1, arg2);

            Console.WriteLine("Function Exit"); // AI Logging complete
        }

        public static async Task LogEntryAndExit(Func<Task> func)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            await func();

            Console.WriteLine("Function Exit"); // AI Logging complete
        }

        public static TResult LogEntryAndExit<TResult>(Func<TResult> func)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            var result = func();

            Console.WriteLine("Function Exit"); // AI Logging complete

            return result;
        }

        public static async Task<TResult> LogEntryAndExitAsync<TResult>(Func<Task<TResult>> func)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            var result = await func();

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

        public static async Task<TResult> LogEntryAndExitAsync<T, TResult>(Func<T, Task<TResult>> func, T arg)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            var result = await func(arg);

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

        public static async Task<TResult> LogEntryAndExitAsync<T1, T2, TResult>(Func<T1, T2, Task<TResult>> func, T1 arg1, T2 arg2)
        {
            Console.WriteLine("Function Entry"); // Call to begin invokation of AI Logging

            var result = await func(arg1, arg2);

            Console.WriteLine("Function Exit"); // AI Logging complete

            return result;
        }
    }
}

