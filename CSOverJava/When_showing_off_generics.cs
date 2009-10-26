using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;

namespace CSOverJava
{
    [TestFixture]
    public class When_showing_off_generics
    {
        [Test]
        public void should_tell_me_the_generic_type()
        {
            new MyGeneric().foo<int>();
        }
    }

    public class MyGeneric
    {
        public void foo<bar>()
        {
            Console.WriteLine(typeof (bar).Name);
        }
    }
}
