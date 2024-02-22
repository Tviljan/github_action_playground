using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    [TestClass()]
    public class RunnerTests
    {
        [TestMethod()]
        public void IsPalindrome_given_palindrome_returns_true()
        {
           Assert.IsTrue(Runner.IsPalindrome("racecar"));
        }

        
        [TestMethod()]
        public void IsPalindrome_not_given_palindrome_returns_false()
        {
           Assert.IsFalse(Runner.IsPalindrome("this is not a palindrome"));
        }
    }
}