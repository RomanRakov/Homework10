using System;
namespace lab12
{
    class RationalNumber
    {
        private int numerator;
        private int denominator;
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
            }
            else
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
        public int ToInt()
        {
            return numerator / denominator;
        }
        public float ToFloat()
        {
            return (float)numerator / denominator;
        }
        public static explicit operator int(RationalNumber rational)
        {
            return rational.ToInt();
        }
        public static explicit operator float(RationalNumber rational)
        {
            return rational.ToFloat();
        }
        public static bool operator ==(RationalNumber rational1, RationalNumber rational2)
        {
            return rational1.Equals(rational2);
        }
        public static bool operator !=(RationalNumber rational1, RationalNumber rational2)
        {
            return !rational1.Equals(rational2);
        }
        public static bool operator <(RationalNumber rational1, RationalNumber rational2)
        {
            return rational1.ToFloat() < rational2.ToFloat();
        }
        public static bool operator >(RationalNumber rational1, RationalNumber rational2)
        {
            return rational1.ToFloat() > rational2.ToFloat();
        }
        public static bool operator <=(RationalNumber rational1, RationalNumber rational2)
        {
            return rational1.ToFloat() <= rational2.ToFloat();
        }
        public static bool operator >=(RationalNumber rational1, RationalNumber rational2)
        {
            return rational1.ToFloat() >= rational2.ToFloat();
        }
        public static RationalNumber operator +(RationalNumber rational1, RationalNumber rational2)
        {
            int numerator = rational1.numerator * rational2.denominator + rational2.numerator * rational1.denominator;
            int denominator = rational1.denominator * rational2.denominator;
            return new RationalNumber(numerator, denominator);
        }
        public static RationalNumber operator -(RationalNumber rational1, RationalNumber rational2)
        {
            int numerator = rational1.numerator * rational2.denominator - rational2.numerator * rational1.denominator;
            int denominator = rational1.denominator * rational2.denominator;
            return new RationalNumber(numerator, denominator);
        }
        public static RationalNumber operator ++(RationalNumber rational1)
        {
            int numerator = rational1.numerator + rational1.denominator;
            int denominator = rational1.denominator;
            return new RationalNumber(numerator, denominator);
        }
        public static RationalNumber operator --(RationalNumber rational1)
        {
            int numerator = rational1.numerator - rational1.denominator;
            int denominator = rational1.denominator;
            return new RationalNumber(numerator, denominator);
        }
        public static RationalNumber operator *(RationalNumber rational1, RationalNumber rational2)
        {
            int numerator = rational1.numerator * rational2.numerator;
            int denominator = rational1.denominator * rational2.denominator;
            return new RationalNumber(numerator, denominator);
        }
        public static RationalNumber operator /(RationalNumber rational1, RationalNumber rational2)
        {
            int numerator = rational1.numerator * rational2.denominator;
            int denominator = rational1.denominator * rational2.numerator;
            return new RationalNumber(numerator, denominator);
        }
        public static RationalNumber operator %(RationalNumber rational1, RationalNumber rational2)
        {
            int numerator = rational1.numerator * rational2.denominator % (rational1.denominator * rational2.numerator);
            int denominator = rational1.denominator * rational2.denominator;
            return new RationalNumber(numerator, denominator);
        }
    }
}
