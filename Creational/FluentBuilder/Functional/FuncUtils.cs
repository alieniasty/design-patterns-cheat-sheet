using System;

namespace FluentBuilder.Functional
{
    public static class FuncUtils
    {
        /// <summary>
        /// <returns> This returns a new function which receives an argument and whose body is f2(f1(a)) </returns>
        /// </summary>
        public static Func<T1, T3> Compose<T1, T2, T3> (Func<T1, T2> f1, Func<T2, T3> f2)
        {
            return a => f2(f1(a));
        }
    }
}
