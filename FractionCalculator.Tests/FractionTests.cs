using ConsoleApp1;

namespace FractionCalculator.Tests_
{
    public class FractionTests
    {
        [Fact]
        public void Addition_Works_Correctly()
        {
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(1, 3);
            var result = f1 + f2;

            Assert.Equal(5, result.Numerator);
            Assert.Equal(6, result.Denominator);
        }

        [Fact]
        public void Subtraction_Works_Correctly()
        {
            var f1 = new Fraction(3, 4);
            var f2 = new Fraction(1, 2);
            var result = f1 - f2;

            Assert.Equal(1, result.Numerator);
            Assert.Equal(4, result.Denominator);
        }

        [Fact]
        public void Division_Works_Correctly()
        {
            var f1 = new Fraction(3, 5);
            var f2 = new Fraction(2, 7);
            var result = f1 / f2;

            Assert.Equal(21, result.Numerator);
            Assert.Equal(10, result.Denominator);
        }

        [Fact]
        public void Division_By_Zero_Throws_Exception()
        {
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(0, 1);

            DivideByZeroException divideByZeroException = Assert.Throws<DivideByZeroException>(() => f1 / f2);
        }

        [Fact]
        public void Fraction_Simplifies_Correctly()
        {
            var fraction = new Fraction(4, 8);
            Assert.Equal(1, fraction.Numerator);
            Assert.Equal(2, fraction.Denominator);
        }

        [Fact]
        public void Negative_Fractions_Are_Normalized()
        {
            var fraction = new Fraction(-3, -4);
            Assert.Equal(3, fraction.Numerator);
            Assert.Equal(4, fraction.Denominator);
        }

        [Fact]
        public void Fraction_With_Negative_Denominator_Is_Normalized()
        {
            var fraction = new Fraction(5, -10);
            Assert.Equal(-1, fraction.Numerator);
            Assert.Equal(2, fraction.Denominator);
        }
    }
}
