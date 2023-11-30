using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class ComplexNumber
    {
        public double Real { get; private set; }
        public double Imaginary { get; private set; }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public ComplexNumber Sum(ComplexNumber complex1, ComplexNumber complex2)
        {
            double real = complex1.Real + complex2.Real;
            double imaginary = complex1.Imaginary + complex2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }
        public ComplexNumber Multiplication(ComplexNumber complex1, ComplexNumber complex2)
        {
            double real = complex1.Real * complex2.Real - Imaginary * complex2.Imaginary;
            double imaginary = complex1.Real * complex2.Imaginary + Imaginary * complex2.Real;
            return new ComplexNumber(real, imaginary);
        }
        public ComplexNumber Subtraction(ComplexNumber complex1, ComplexNumber complex2)
        {
            double real = complex1.Real - complex2.Real;
            double imaginary = complex1.Imaginary - complex2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }
        public bool Equals(ComplexNumber complex1, ComplexNumber complex2)
        {
            if (complex1.Real == complex2.Real && complex1.Imaginary == complex2.Imaginary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
