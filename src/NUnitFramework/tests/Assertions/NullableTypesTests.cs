// Copyright (c) Charlie Poole, Rob Prouse and Contributors. MIT License - see LICENSE.txt

namespace NUnit.Framework.Tests.Assertions
{
    [TestFixture, Category("Generics")]
    public class NullableTypesTests
    {
        [Test]
        public void CanTestForNull()
        {
            int? nullInt = null;
            int? five = 5;

            Classic.Assert.IsNull(nullInt);
            Classic.Assert.IsNotNull(five);
            Assert.That(nullInt, Is.Null);
            Assert.That(five, Is.Not.Null);
        }

        [Test]
        public void CanCompareNullableInts()
        {
            int? five = 5;
            int? answer = 2 + 3;

            Classic.Assert.AreEqual(five, answer);
            Classic.Assert.AreEqual(five, 5);
            Classic.Assert.AreEqual(5, five);

            Assert.That(five, Is.EqualTo(answer));
            Assert.That(five, Is.EqualTo(5));
            Assert.That(5, Is.EqualTo(five));

            //            Assert.Greater(five, 3);
            //            Assert.GreaterOrEqual(five, 5);
            //            Assert.Less(3, five);
            //            Assert.LessOrEqual(5, five);

            Assert.That(five, Is.GreaterThan(3));
            Assert.That(five, Is.GreaterThanOrEqualTo(5));
            //Assert.That(3, Is.LessThan(five));
            //Assert.That(5, Is.LessThanOrEqualTo(five));
        }

        [Test]
        public void CanCompareNullableDoubles()
        {
            double? five = 5.0;
            double? answer = 2.0 + 3.0;

            Classic.Assert.AreEqual(five, answer);
            Classic.Assert.AreEqual(five, 5.0);
            Classic.Assert.AreEqual(5.0, five);

            Assert.That(five, Is.EqualTo(answer));
            Assert.That(five, Is.EqualTo(5.0));
            Assert.That(5.0, Is.EqualTo(five));

            //            Assert.Greater(five, 3.0);
            //            Assert.GreaterOrEqual(five, 5.0);
            //            Assert.Less(3.0, five);
            //            Assert.LessOrEqual(5.0, five);

            Assert.That(five, Is.GreaterThan(3.0));
            Assert.That(five, Is.GreaterThanOrEqualTo(5.0));
            //Assert.That(3.0, Is.LessThan(five));
            //Assert.That(5.0, Is.LessThanOrEqualTo(five));
        }

        [Test]
        public void CanTestForNaN()
        {
            double? anNaN = double.NaN;
            Assert.That(anNaN, Is.Not.Null);
            Assert.That(anNaN, Is.NaN);
        }

        [Test]
        public void CanCompareNullableDecimals()
        {
            decimal? five = 5m;
            decimal? answer = 2m + 3m;

            Classic.Assert.AreEqual(five, answer);
            Classic.Assert.AreEqual(five, 5m);
            Classic.Assert.AreEqual(5m, five);

            Assert.That(five, Is.EqualTo(answer));
            Assert.That(five, Is.EqualTo(5m));
            Assert.That(5m, Is.EqualTo(five));

            //            Assert.Greater(five, 3m);
            //            Assert.GreaterOrEqual(five, 5m);
            //            Assert.Less(3m, five);
            //            Assert.LessOrEqual(5m, five);

            Assert.That(five, Is.GreaterThan(3m));
            Assert.That(five, Is.GreaterThanOrEqualTo(5m));
            //Assert.That(3m, Is.LessThan(five));
            //Assert.That(5m, Is.LessThanOrEqualTo(five));
        }

        private enum Colors
        {
            Red,
            Blue,
            Green
        }

        [Test]
        public void CanCompareNullableEnums()
        {
            Colors? color = Colors.Red;
            Colors? other = Colors.Red;

            Classic.Assert.AreEqual(color, other);
            Classic.Assert.AreEqual(color, Colors.Red);
            Classic.Assert.AreEqual(Colors.Red, color);
        }

        [Test]
        public void CanCompareNullableMixedNumerics()
        {
            int? int5 = 5;
            double? double5 = 5.0;
            decimal? decimal5 = 5.00m;

            Classic.Assert.AreEqual(int5, double5);
            Classic.Assert.AreEqual(int5, decimal5);
            Classic.Assert.AreEqual(double5, int5);
            Classic.Assert.AreEqual(double5, decimal5);
            Classic.Assert.AreEqual(decimal5, int5);
            Classic.Assert.AreEqual(decimal5, double5);

            Assert.That(int5, Is.EqualTo(double5));
            Assert.That(int5, Is.EqualTo(decimal5));
            Assert.That(double5, Is.EqualTo(int5));
            Assert.That(double5, Is.EqualTo(decimal5));
            Assert.That(decimal5, Is.EqualTo(int5));
            Assert.That(decimal5, Is.EqualTo(double5));

            Classic.Assert.AreEqual(5, double5);
            Classic.Assert.AreEqual(5, decimal5);
            Classic.Assert.AreEqual(5.0, int5);
            Classic.Assert.AreEqual(5.0, decimal5);
            Classic.Assert.AreEqual(5m, int5);
            Classic.Assert.AreEqual(5m, double5);

            Assert.That(5, Is.EqualTo(double5));
            Assert.That(5, Is.EqualTo(decimal5));
            Assert.That(5.0, Is.EqualTo(int5));
            Assert.That(5.0, Is.EqualTo(decimal5));
            Assert.That(5m, Is.EqualTo(int5));
            Assert.That(5m, Is.EqualTo(double5));

            Classic.Assert.AreEqual(double5, 5);
            Classic.Assert.AreEqual(decimal5, 5);
            Classic.Assert.AreEqual(int5, 5.0);
            Classic.Assert.AreEqual(decimal5, 5.0);
            Classic.Assert.AreEqual(int5, 5m);
            Classic.Assert.AreEqual(double5, 5m);

            Assert.That(double5, Is.EqualTo(5));
            Assert.That(decimal5, Is.EqualTo(5));
            Assert.That(int5, Is.EqualTo(5.0));
            Assert.That(decimal5, Is.EqualTo(5.0));
            Assert.That(int5, Is.EqualTo(5m));
            Assert.That(double5, Is.EqualTo(5m));

            //            Assert.Greater(int5, 3.0);
            //            Assert.Greater(int5, 3m);
            //            Assert.Greater(double5, 3);
            //            Assert.Greater(double5, 3m);
            //            Assert.Greater(decimal5, 3);
            //            Assert.Greater(decimal5, 3.0);

            Assert.That(int5, Is.GreaterThan(3.0));
            Assert.That(int5, Is.GreaterThan(3m));
            Assert.That(double5, Is.GreaterThan(3));
            Assert.That(double5, Is.GreaterThan(3m));
            Assert.That(decimal5, Is.GreaterThan(3));
            Assert.That(decimal5, Is.GreaterThan(3.0));

            //            Assert.Less(3.0, int5);
            //            Assert.Less(3m, int5);
            //            Assert.Less(3, double5);
            //            Assert.Less(3m, double5);
            //            Assert.Less(3, decimal5);
            //            Assert.Less(3.0, decimal5);

            //Assert.That(3.0, Is.LessThan(int5));
            //Assert.That(3m, Is.LessThan(int5));
            //Assert.That(3, Is.LessThan(double5));
            //Assert.That(3m, Is.LessThan(double5));
            //Assert.That(3, Is.LessThan(decimal5));
            //Assert.That(3.0, Is.LessThan(decimal5));
        }

        private readonly struct MyStruct
        {
#pragma warning disable IDE0052 // Remove unread private members
            private readonly int _i;
            private readonly string _s;
#pragma warning restore IDE0052 // Remove unread private members

            public MyStruct(int i, string s)
            {
                _i = i;
                _s = s;
            }
        }

        [Test]
        public void CanCompareNullableStructs()
        {
            MyStruct struct1 = new MyStruct(5, "Hello");
            MyStruct struct2 = new MyStruct(5, "Hello");
            MyStruct? one = new MyStruct(5, "Hello");
            MyStruct? two = new MyStruct(5, "Hello");

            Classic.Assert.AreEqual(struct1, struct2); // Control
            Classic.Assert.AreEqual(one, two);
            Classic.Assert.AreEqual(one, struct1);
            Classic.Assert.AreEqual(struct2, two);
        }
    }
}
