using System;
using System.Text.RegularExpressions;
using MbUnit.Framework;

namespace CSOverJava
{
    public class When_looking_behind_on_a_string
    {
        [Test]
        public void should_find_a_match()
        {
            var input = "I went and bought a car123 1 time but I returned it and bought 2 van456";
            var pattern = "\\w{3}(?=\\d{3})";

            foreach(var match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match);
            }
        }
    }
}