namespace TriangleTypeDetector
{
    public static class TriangleManager
    {
        public static bool Validate(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide + secondSide <= thirdSide)
                return false;

            if (firstSide + thirdSide <= secondSide)
                return false;

            if (secondSide + thirdSide <= firstSide)
                return false;

            return true;
        }

        public static TriangleType DetectTriangleType(double firstSide, double secondSide, double thirdSide)
        {
            var equalSidesCount = 1;

            if (firstSide == secondSide || firstSide == thirdSide)
                equalSidesCount++;

            if (secondSide == thirdSide)
                equalSidesCount++;

            switch (equalSidesCount)
            {
                case 1:
                    return TriangleType.Scalene;
                case 2:
                    return TriangleType.Isosceles;
                case 3:
                    return TriangleType.Equilateral;
                default:
                    return TriangleType.Scalene;
            }
        }
    }
}
