using System;
using System.Reflection;
using MbUnit.Framework;

namespace CSOverJava
{
    [MyAttribute("hello")]
    public class MyClass
    {
        public void run()
        {
            MemberInfo info = GetType();
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(((MyAttribute)attributes[i]).name);
            }
        }
    }

    public class MyAttribute : Attribute
    {
        public string name {get;set;}

        public MyAttribute(string name)
        {
            this.name = name;
        }
    }

    [TestFixture]
    public class when_using_a_custom_attribute
    {
        [Test]
        public void should_say_hello()
        {
            new MyClass().run();
        }
    }
}