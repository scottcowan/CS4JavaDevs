using System;
using System.Collections.Generic;
using System.Linq;
using MbUnit.Framework;

namespace CSOverJava
{
    [TestFixture]
    public class When_filtering_a_listiltering_a_list
    {
        public void should_remove_foo()
        {
            var list = new List<string> {"foo", "bar", "bar"};

            var actual = list.Where(x => x == "bar");

            foreach(var item in actual)
            {
                Console.WriteLine(item);
            }
        }
    }
}