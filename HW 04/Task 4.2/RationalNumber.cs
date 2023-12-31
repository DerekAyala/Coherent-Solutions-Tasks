﻿using System;
namespace Task_4._2
{
    public sealed class RationalNumber : IComparable<RationalNumber>
    {
        private int _numerator;
        private int _denominator;

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            int gcd = MaxCommonDivisor(Math.Abs(numerator), Math.Abs(denominator));
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;

            if (denominator < 0)
            {
                _numerator = -Numerator;
                _denominator = -Denominator;
            }
        }

        public RationalNumber(int numerator) : this(numerator, 1)
        {
        }

        public int Numerator
        {
            get { return _numerator; }
        }

        public int Denominator
        {
            get { return _denominator; }
        }

        private static int MaxCommonDivisor(int a, int b)
        {
            // Euclides Algorithm
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is RationalNumber))
            {
                return false;
            }

            RationalNumber other = obj as RationalNumber;

            return Numerator == other?.Numerator && Denominator == other?.Denominator;
        }


        public int CompareTo(RationalNumber other)
        {
            long thisNumerator = (long)Numerator * other.Denominator;
            long otherNumerator = (long)other.Numerator * Denominator;

            return thisNumerator.CompareTo(otherNumerator);
        }

        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            ArgumentNullException.ThrowIfNull(r1, nameof(r1));
            ArgumentNullException.ThrowIfNull(r2, nameof(r2));

            int newNumerator = (r1.Numerator * r2.Denominator) + (r2.Numerator * r1.Denominator);
            int newDenominator = r1.Denominator * r2.Denominator;

            return new RationalNumber(newNumerator, newDenominator);
        }

        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            ArgumentNullException.ThrowIfNull(r1, nameof(r1));
            ArgumentNullException.ThrowIfNull(r2, nameof(r2));

            int newNumerator = (r1.Numerator * r2.Denominator) - (r2.Numerator * r1.Denominator);
            int newDenominator = r1.Denominator * r2.Denominator;

            return new RationalNumber(newNumerator, newDenominator);
        }

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            ArgumentNullException.ThrowIfNull(r1, nameof(r1));
            ArgumentNullException.ThrowIfNull(r2, nameof(r2));

            int newNumerator = r1.Numerator * r2.Numerator;
            int newDenominator = r1.Denominator * r2.Denominator;

            return new RationalNumber(newNumerator, newDenominator);
        }

        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            ArgumentNullException.ThrowIfNull(r1, nameof(r1));
            ArgumentNullException.ThrowIfNull(r2, nameof(r2));

            if (r2.Numerator == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            int newNumerator = r1.Numerator * r2.Denominator;
            int newDenominator = r1.Denominator * r2.Numerator;

            return new RationalNumber(newNumerator, newDenominator);
        }

        public static explicit operator double(RationalNumber rationalNumber)
        {
            return (double)rationalNumber.Numerator / rationalNumber.Denominator;
        }

        public static implicit operator RationalNumber(int integerValue)
        {
            return new RationalNumber(integerValue, 1);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}

