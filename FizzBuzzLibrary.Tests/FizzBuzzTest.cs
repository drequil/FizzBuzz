using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace FizzBuzzLibrary.Tests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void ManualTest()
        {
            Assert.That("a", Does.Contain("a"));
            Assert.That("a", Is.StringContaining("a"));
        }

        [Test]
        public void ManualTestCheck()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass();
            fbList = myFizzBuzz.FizzBuzz(256, 2, 4, "myFizz", "myBuzz");

            Assert.That(fbList.ElementAt(1 - 1), Does.Contain("1"));
            Assert.That(fbList.ElementAt(2 - 1), Does.Contain("myFizz"));
            Assert.That(fbList.ElementAt(4 - 1), Does.Contain("myFizz"));
            Assert.That(fbList.ElementAt(4 - 1), Does.Contain("myBuzz"));
            Assert.That(fbList.ElementAt(8 - 1), Does.Contain("myFizz"));
            Assert.That(fbList.ElementAt(8 - 1), Does.Contain("myBuzz"));
            Assert.That(fbList.ElementAt(256 - 1), Does.Contain("myFizz"));
            Assert.That(fbList.ElementAt(256 - 1), Does.Contain("myBuzz"));

            Assert.That(fbList.Count, Is.EqualTo(256));
        }
    

        [Test]
        public void Can_ConstructWith0_CallWith0()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass();

            /* Test constructor/default values */
            fbList = myFizzBuzz.FizzBuzz();
            TestCore(fbList, FizzBuzzClass.default_upperBound, 
                             FizzBuzzClass.default_value1, FizzBuzzClass.default_value2,
                             FizzBuzzClass.default_string1, FizzBuzzClass.default_string2);
        }

        [Test]
        public void Can_ConstructWith0_CallWith3AndMultiples()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass();

            /* Test constructor/default values */
            fbList = myFizzBuzz.FizzBuzz(20, 2, 4);
            TestCore(fbList, 20, 2, 4, FizzBuzzClass.default_string1, FizzBuzzClass.default_string2);
        }

        [Test]
        public void Can_ConstructWith0_CallWith3_CallWith0again()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass();

            /* Test constructor/default values */
            fbList = myFizzBuzz.FizzBuzz(20, 2, 4);
            fbList = myFizzBuzz.FizzBuzz();
            TestCore(fbList, 20, 2, 4, FizzBuzzClass.default_string1, FizzBuzzClass.default_string2);
        }



        [Test]
        public void Can_ConstructWith3_CallWith0()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass(20, 2, 4);

            /* Test constructor/default values */
            fbList = myFizzBuzz.FizzBuzz();
            TestCore(fbList, 20, 2, 4, FizzBuzzClass.default_string1, FizzBuzzClass.default_string2);
        }

        [Test]
        public void Can_ConstructWith3_CallWith3()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass(20, 2, 4);

            /* Test constructor/default values */
            fbList = myFizzBuzz.FizzBuzz(50, 5, 10);
            TestCore(fbList, 50, 5, 10, FizzBuzzClass.default_string1, FizzBuzzClass.default_string2);
        }

        [Test]
        public void Can_ConstructWith5_CallWith0()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass(20, 2, 4, "Mod2", "Mod4");

            /* Test constructor/default values */
            fbList = myFizzBuzz.FizzBuzz();
            TestCore(fbList, 20, 2, 4, "Mod2", "Mod4");
        }

        [Test]
        public void Can_ConstructWith5_CallWith5()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass(20, 2, 4, "Mod2", "Mod4");

            /* Test constructor/default values */
            fbList = myFizzBuzz.FizzBuzz(50, 5, 11, "Mod5", "Mod11");
            TestCore(fbList, 50, 5, 11, "Mod5", "Mod11");
        }

        [Test]
        public void Can_ConstructWith5_CallWith5_CallWith0again()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass(20, 2, 4, "Mod2", "Mod4");

            /* Test constructor/default values */
            fbList = myFizzBuzz.FizzBuzz(50, 5, 11, "Mod5", "Mod11");
            fbList = myFizzBuzz.FizzBuzz();
            TestCore(fbList, 50, 5, 11, "Mod5", "Mod11");
        }

        [Test]
        public void CanSuriveZeroValues()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass();

            /* Test edge cases */
            fbList = myFizzBuzz.FizzBuzz(0, 1, 1, "X", "Y");
            TestCore(fbList, 0, 1, 1, "X", "Y");

            fbList = myFizzBuzz.FizzBuzz(1, 0, 1, "X", "Y");
            TestCore(fbList, 1, 0, 1, "X", "Y");

            fbList = myFizzBuzz.FizzBuzz(1, 1, 0, "X", "Y");
            TestCore(fbList, 1, 1, 0, "X", "Y");
        }

        [Test]
        public void CanSuriveNegValues()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass();

            /* Test edge cases */
            fbList = myFizzBuzz.FizzBuzz(-1, 1, 0, "X", "Y");
            TestCore(fbList, 1, 1, 0, "X", "Y");
        }

        [Test]
        public void CanHandleLargerValues()
        {
            var fbList = new List<string>();
            var myFizzBuzz = new FizzBuzzClass(549100, 17, 323, "Mod333", "Mod500");

            /* Test edge cases */
            fbList = myFizzBuzz.FizzBuzz();
            TestCore(fbList, 549100, 17, 323, "Mod333", "Mod500");
        }

        private void TestCore(List<string> inputList, 
                              int upperBound, int value1, int value2, 
                              string string1, string string2)
        {
            if ((upperBound < 1) || (value1 < 1) || (value2 < 1))
            {
                Assert.That(inputList, Is.Null);
            }
            else
            {
                // Assert
                Assert.That(inputList.Count, Is.EqualTo(upperBound));

                var temp = inputList.ElementAt(value1 * 1 - 1);

                if (value1 * 1 < upperBound) Assert.That(inputList.ElementAt(value1 * 1 - 1), Is.StringContaining(string1));
                if (value1 * 2 < upperBound) Assert.That(inputList.ElementAt(value1 * 2 - 1), Does.Contain(string1));
                if (value1 * 10 < upperBound) Assert.That(inputList.ElementAt(value1 * 10 - 1), Does.Contain(string1));

                if (value2 * 1 < upperBound) Assert.That(inputList.ElementAt(value2 * 1 - 1), Is.StringContaining(string2));
                if (value2 * 2 < upperBound) Assert.That(inputList.ElementAt(value2 * 2 - 1), Does.Contain(string2));
                if (value2 * 10 < upperBound) Assert.That(inputList.ElementAt(value2 * 10 - 1), Does.Contain(string2));
            }
        }
    }
}
