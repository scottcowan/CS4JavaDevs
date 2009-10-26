using System;
using System.Collections;
using System.Collections.Generic;
using MbUnit.Framework;

namespace CSOverJava
{
    [TestFixture]
    public class When_creating_objects
    {
        [Test]
        public void should_be_able_to_use_an_object_I_created()
        {
            var list = Activator.CreateInstance<List<string>>();

            list.Add("Hello");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void should_be_able_to_create_a_generic()
        {            
            string t = "System.Collections.Generic.List" + "`" + 1;
            Type generic = Type.GetType(t).MakeGenericType(typeof(string));
            var list = (IList)Activator.CreateInstance(generic);

            list.Add("Hello");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }    
}