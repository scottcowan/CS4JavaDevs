using System;
using System.Collections.Generic;
using MbUnit.Framework;

namespace CSOverJava
{
    [TestFixture]
    public class When_I_want_to_do_a_mixin_like_ruby
    {
        [Test]
        public void should_run_a_method_that_doesnt_exist()
        {
            var list = new List<string> { "foo", "bar", "bar" };
            list.PrintAll();  // <---- implicit generics            
        }
    }

    public static class ListExtensions
    {
        public static void PrintAll<T>(this List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}