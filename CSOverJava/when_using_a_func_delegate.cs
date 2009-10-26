using System;
using System.Linq.Expressions;
using MbUnit.Framework;

namespace CSOverJava
{
    [TestFixture]
    public class when_using_a_func_delegate_delegate
    {
        [Test]
        public void should_find_a_property()
        {
            Func<Foo, string> property_accessor = x => x.Bar;

            Action a = ()=>{};

            Expression<Func<Foo, string>> exp = x => x.Bar;

            Console.WriteLine(exp.Body.ToString().Replace(exp.Parameters[0].Name + ".", ""));
            var foo = new Foo {Bar = "bam"};

            Console.WriteLine(property_accessor(foo));
        }
    }

    public class Foo
    {
        public string Bar { get; set; }
    }
}