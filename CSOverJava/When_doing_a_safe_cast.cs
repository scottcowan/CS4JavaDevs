using System;
using System.Collections.Generic;
using MbUnit.Framework;

namespace CSOverJava
{
    [TestFixture]
    public class When_doing_a_cast
    {
        [Test]
        public void should_assign_a_null()
        {
            object town = new Town {name = "london"};
            var mine = town as Person;
            Assert.IsNull(mine);
        }

        [Test]
        public void should_assing_a_person()
        {
            object town = new Person { name = "joe" };
            var mine = town as Person;
        }
    }

    public class Person
    {
        public Person() : this("london")
        {
        }

        Person(string london)
        {
            throw new NotImplementedException();
        }

        public string name { get; set; }
    }

    public class Town
    {
        public string name { get; set; }
    }
}