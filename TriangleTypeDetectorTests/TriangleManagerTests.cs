using FluentAssertions;
using TriangleTypeDetector;

namespace TriangleTypeDetectorTests
{
    public class TriangleManagerTests
    {
        [Fact]
        public void Validate_When_LengthsAreValid_Return_True()
        {
            var result = TriangleManager.Validate(2.1, 3.6, 5);

            result.Should().BeTrue("Sum of 2 shorter sides lengths is more than longer side length");
        }

        [Theory]
        [InlineData(1, 7, 4)]
        [InlineData(2, 2, 5)]
        public void Validate_When_LengthsAreInvalid_Return_False(double firstSide, double secondSide, double thirdSide)
        {
            var result = TriangleManager.Validate(firstSide, secondSide, thirdSide);

            result.Should().BeFalse("Sum of 2 shorter sides lengths is equal to longer side length");
        }

        [Fact]
        public void Validate_When_ShorterLengthsSumIsLessThanLonger_Return_False()
        {
            var result = TriangleManager.Validate(2, 2, 5);

            result.Should().BeFalse("Sum of 2 shorter sides lengths is less than longer side length");
        }

        [Fact]
        public void DetectTriangleType_When_AllSidesAreDifferent_Return_Scalene()
        {
            var result = TriangleManager.DetectTriangleType(2.1, 3.6, 5);

            result.Should().Be(TriangleType.Scalene, "All sides have different length");
        }

        [Fact]
        public void DetectTriangleType_When_TwoSidesAreTheSame_Return_Isosceles()
        {
            var result = TriangleManager.DetectTriangleType(3, 3, 5);

            result.Should().Be(TriangleType.Isosceles, "2 sides have same length");
        }

        [Fact]
        public void DetectTriangleType_When_AllSidesAreTheSame_Return_Equilateral()
        {
            var result = TriangleManager.DetectTriangleType(10, 10, 10);

            result.Should().Be(TriangleType.Equilateral, "All sides have same length");
        }
    }
}