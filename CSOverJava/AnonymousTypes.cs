using System;
using MbUnit.Framework;

namespace CSOverJava
{
    [TestFixture]
    public class AnonymousTypes
    {
        [Test]
        public void should_store_mixed_types_in_an_anonymous_type()
        {
            var v = new { Amount = 108, Message = "Hello" };
            Console.WriteLine(v.Amount+1);
            Console.WriteLine(v.Message);
        }
    }
}