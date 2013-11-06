using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactorCalculator;

namespace FractionCalculator
{
    public class FractionOperations
    {
        /// <summary>
        /// Add - add two fractions
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns>Proper or Improper Fraction.</returns>
        public static Fraction Add(Fraction fraction1, Fraction fraction2)
        {
            Fraction prepFraction1;
            Fraction prepFraction2;

            // Test arguments for 0 0/0
            if (FractionOperations.Compare(fraction1, new Fraction(0)) == 0)
            {
                // Return identical fraction
                return new Fraction(fraction2.WholePart, fraction2.Numerator, fraction2.Denominator);
            }
            else if (FractionOperations.Compare(fraction2, new Fraction(0)) == 0)
            {
                // Return identical fraction
                return new Fraction(fraction1.WholePart, fraction1.Numerator, fraction1.Denominator);
            }
            else 
            { // Two non-zero aguments

                // Convert fractions to improper fraction format (returns the same fraction if it's not improper)
                prepFraction1 = FractionOperations.MakeImproper(fraction1);
                prepFraction2 = FractionOperations.MakeImproper(fraction2);

                // Check denominators
                if(prepFraction1.Denominator == prepFraction2.Denominator) 
                { // add like fractions
                    return new Fraction(prepFraction1.Numerator + prepFraction2.Numerator, prepFraction1.Denominator);
                } 
                else 
                { // add unlike fractions

                    // Find the Least Common Multiple (LCM).
                    int lcm = Factors.FindLCM(Math.Abs(prepFraction1.Denominator), Math.Abs(prepFraction2.Denominator));

                    // Create equivalent fractions using the Least Common Multiple as a factor divided by the fraction's denominator
                    Fraction equivFraction1 = FractionOperations.MakeEquivalent(prepFraction1, lcm / prepFraction1.Denominator);
                    Fraction equivFraction2 = FractionOperations.MakeEquivalent(prepFraction2, lcm / prepFraction2.Denominator);

                    // Return the sum of the numerators in equivalent form for the numerator component, 
                    // and the Least Common Multiple (LCM) for the denominator.
                    return new Fraction(equivFraction1.Numerator + equivFraction2.Numerator, lcm);

                }
            }

        }

        /// <summary>
        /// Subtract - subtract two fractions
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns>Proper or Improper Fraction</returns>
        public static Fraction Subtract(Fraction fraction1, Fraction fraction2)
        {
            Fraction prepFraction1;
            Fraction prepFraction2;
            /*
            // Check whether or not first fraction is smaller than the second fraction
            if (FractionOperations.Compare(fraction1, fraction2) == -1)
            { 
                // Abort operation
                throw new ArgumentException("Error: Cannot subtract a large fraction from a smaller fraction.");
            }
            */
            // Test arguments for 0 0/0
            if( FractionOperations.Compare(fraction1, new Fraction(0)) == 0 ) 
            {
                // Return identical fraction
                return new Fraction(fraction2.WholePart, fraction2.Numerator, fraction2.Denominator);
            }
            else if (FractionOperations.Compare(fraction2, new Fraction(0)) == 0)
            {
                // Return identical fraction
                return new Fraction(fraction1.WholePart, fraction1.Numerator, fraction1.Denominator);
            }
            else
            { // Two non-zero arguments
                // Convert fractions to improper fraction format (returns the same fraction if it's not improper)
                prepFraction1 = FractionOperations.MakeImproper(fraction1);
                prepFraction2 = FractionOperations.MakeImproper(fraction2);

                // Find the Least Common Multiple (LCM).
                int lcm = Factors.FindLCM(Math.Abs(prepFraction1.Denominator), Math.Abs(prepFraction2.Denominator));

                // Create equivalent fractions using the Least Common Multiple as a factor divided by the fraction's denominator
                Fraction equivFraction1 = FractionOperations.MakeEquivalent(prepFraction1, lcm / prepFraction1.Denominator);
                Fraction equivFraction2 = FractionOperations.MakeEquivalent(prepFraction2, lcm / prepFraction2.Denominator);

                // Return the subtraction of the numerators in equivalent form for the numerator component, 
                // and the Least Common Multiple (LCM) for the denominator.
                return new Fraction(equivFraction1.Numerator - equivFraction2.Numerator, lcm);
            }
        }

        
        /// <summary>
        /// Multiply - multiply two fractions together.
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns>Proper or Improper Fraction.</returns>
        public static Fraction Multiply(Fraction fraction1, Fraction fraction2)
        {
            Fraction prepFraction1;
            Fraction prepFraction2;

            // Test arguments for 0 0/0
            if (FractionOperations.Compare(fraction1, new Fraction(0)) == 0)
            {
                // Return identical fraction
                return new Fraction(0, 0, 0);
            }
            else if (FractionOperations.Compare(fraction2, new Fraction(0)) == 0)
            {
                // Return identical fraction
                return new Fraction(0, 0, 0);
            }
            else 
            {

                // Convert fractions to improper fraction format (returns the same fraction if it's not improper)
                prepFraction1 = FractionOperations.MakeImproper(fraction1);
                prepFraction2 = FractionOperations.MakeImproper(fraction2);
                
                // Generate a new fraction using the product of numerators and the product of the denominators
                return new Fraction(prepFraction1.Numerator * prepFraction2.Numerator,
                    prepFraction1.Denominator * prepFraction2.Denominator);

            }
        }

        /// <summary>
        /// Divide - divide two fractions
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns>Proper or Improper Fraction.</returns>
        public static Fraction Divide(Fraction fraction1, Fraction fraction2)
        {
            Fraction prepFraction1;
            Fraction prepFraction2;

            // Check second argument for 0
            if (FractionOperations.Compare(fraction2, new Fraction(0)) == 0)
            {
                // Throw error
                throw new ArgumentException("Error: cannot divide a fraction by 0");
            }

            // If first argument is 0
            if (FractionOperations.Compare(fraction1, new Fraction(0)) == 0)
            {
                // Return identical fraction
                return new Fraction(0, 0, 0);
            }
            else
            { // For non-zero arugments

                // Convert fractions to improper fraction format (returns the same fraction if it's proper fraction.)
                prepFraction1 = FractionOperations.MakeImproper(fraction1);
                prepFraction2 = FractionOperations.MakeImproper(fraction2);

                // Multiply the fraction1 with the reciprocal of fraction2, in improper format
                return FractionOperations.Multiply(prepFraction1, FractionOperations.FindReciprocal(prepFraction2));
            }
        }



        /// <summary>
        /// FindReciprocal - create a reciprocal fraction by flipping numerator and denominator components.
        /// </summary>
        /// <param name="fraction">Fraction to flip.</param>
        /// <returns>Proper or Improper Fraction</returns>
        public static Fraction FindReciprocal(Fraction fraction)
        {

            Fraction prepFraction;

            // Test argument for 0 0/0
            if (FractionOperations.Compare(fraction, new Fraction(0)) == 0)
            {
                // Throw an error
                throw new ArgumentException("Error: Cannot find a reciprocal for zero.");
            }

            // Convert fractions to improper fraction format (returns the same fraction if it's proper fraction.)
            prepFraction = FractionOperations.MakeImproper(fraction);

            // Interchange numerator and fraction
            return new Fraction(prepFraction.Denominator, prepFraction.Numerator);
        }


        /// <summary>
        /// FindReduced - create a reduced fraction
        /// </summary>
        /// <param name="fraction">Fraction to reduce.</param>
        /// <returns>Proper or Improper Fraction.</returns>
        public static Fraction FindReduced(Fraction fraction)
        {
            Fraction prepFraction;

            // Convert fractions to improper fraction format (returns the same fraction if it's proper fraction.)
            prepFraction = FractionOperations.MakeImproper(fraction);

            // Get the Greatest Common Factor (GCF)
            int gcf = Factors.FindGCF(Math.Abs(prepFraction.Numerator), Math.Abs(prepFraction.Denominator));

            // Divide both numerator and denominator by the GCF and return it as a fraction
            return new Fraction((int)(prepFraction.Numerator / gcf), (int)(prepFraction.Denominator / gcf));
        }


        /// <summary>
        /// Compare - Determines if two fractions are greater than, less than, or equal.
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns>Integer value of -1, 0, or 1</returns>
        public static int Compare(Fraction fraction1, Fraction fraction2)
        {

            Fraction prepFraction1;
            Fraction prepFraction2;

            // Test arguments for 0 0/0
            if ( ((fraction1.WholePart == 0) && (fraction1.Numerator == 0)) &&
                ((fraction2.WholePart == 0) && (fraction2.Numerator == 0)) )
            { // When both arguments are 0...
                return 0;
            }
            else if ( ((fraction1.WholePart == 0) && (fraction1.Numerator == 0)) 
                )
            { // If first argument is 0...  

                // Convert to improper fraction
                prepFraction2 = FractionOperations.MakeImproper(fraction2);

                if (prepFraction2.Numerator > 0)
                {
                    return 1;
                } 
                else
                {
                    return -1;
                }
                 
            }
            else if(((fraction2.WholePart == 0) && (fraction2.Numerator == 0)) )
            { // If second argument is 0...

                // Convert to improper fraction
                prepFraction1 = FractionOperations.MakeImproper(fraction1);

                if (prepFraction1.Numerator > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            { // For non-zero arguments...
                // Convert fractions to improper fraction format (returns the same fraction if it's proper fraction.)
                prepFraction1 = FractionOperations.MakeImproper(fraction1);
                prepFraction2 = FractionOperations.MakeImproper(fraction2);


                // Find the Least Common Multiple (LCM).
                int lcm = Factors.FindLCM(prepFraction1.Denominator, prepFraction2.Denominator);

                // Create equivalent fractions using the Least Common Multiple as a factor divided by the fraction's denominator
                Fraction equivFraction1 = FractionOperations.MakeEquivalent(prepFraction1, lcm / prepFraction1.Denominator);
                Fraction equivFraction2 = FractionOperations.MakeEquivalent(prepFraction2, lcm / prepFraction2.Denominator);

                // Compare the numerators of the equivalent fractions
                if(equivFraction1.Numerator < equivFraction2.Numerator) {
                    return -1;
                } else if (equivFraction1.Numerator > equivFraction2.Numerator)  {
                    return 1;
                } else {
                    return 0;
                }

            }
        }



        /// <summary>
        /// MakeImproper - converts a mixed fraction or whole number to an improper fraction.
        /// </summary>
        /// <param name="fraction">Fraction to to convert.</param>
        /// <returns>Proper or Improper Fraction.</returns>
        public static Fraction MakeImproper(Fraction fraction)
        {
            // Check for mixed number fractions
            if (fraction.IsMixedNumber()){

                // Check whole part for negative sign
                if(fraction.WholePart < 0) 
                {

                    // Convert a mixed number fraction to an improper fraction
                    return new Fraction( -1 *  (fraction.Denominator * Math.Abs(fraction.WholePart) + fraction.Numerator), fraction.Denominator);
                }
                else
                {
                    // Convert a mixed number fraction to an improper fraction
                    return new Fraction((fraction.Denominator * fraction.WholePart) + fraction.Numerator, fraction.Denominator);
                }

                
            } else if (fraction.IsWholeNumber()) {
                // Convert a whole number to an improper fraction
                return new Fraction(fraction.WholePart, 1);
            } else {

                // If not improper fraction, return original fraction
                return new Fraction(fraction.Numerator, fraction.Denominator);
            }
        }

        /// <summary>
        /// MAkeEquivalent - Generatean equilvalent fraction by multiplying an integer to a fraction's numerator and denominator 
        /// </summary>
        /// <param name="fraction"></param>
        /// <param name="factor"></param>
        /// <returns>Proper or Improper Fraction.</returns>
        public static Fraction MakeEquivalent(Fraction fraction, int factor) 
        {
            Fraction prepFraction;
            
            // Throw an error if the factor is zero
            if( factor <= 0 ) {
                throw new ArgumentException("Error: Cannot create an equivalent fraction with a factor of zero.");
            }

            // Convert fractions to improper fraction format (returns the same fraction if it's proper fraction.)
            prepFraction = FractionOperations.MakeImproper(fraction);

            return FractionOperations.Multiply(prepFraction, new Fraction(factor, factor));
           
        }

        /// <summary>
        /// MakeMixedNumber - Essentially calculates a Mixed Number Fraction.
        /// </summary>
        /// <param name="fraction"></param>
        /// <returns>Mixed Number Fraction.</returns>
        public static Fraction MakeMixedNumber(Fraction fraction)
        {
            // Calculate WholePart, Numerator, and Denominator for Improper Fractions
            if (fraction.IsImproper())
            { // Improper fraction
                if (fraction.Numerator % fraction.Denominator == 0) 
                {  // When the numerator is divisible by the denominator
                    return new Fraction ((int)fraction.Numerator/fraction.Denominator);
                } 
                else 
                {

                    if( fraction.Numerator < 0 ) 
                    { // Apply negative sign to numerator
                        return new Fraction((int)((-1) * fraction.Numerator / fraction.Denominator),
                            (fraction.Numerator % fraction.Denominator), fraction.Denominator);
                    } 
                    else{
                        return new Fraction((int)(fraction.Numerator / fraction.Denominator),
                            (fraction.Numerator % fraction.Denominator), fraction.Denominator);
                    }
                }
            }
            else
            {
                // Return regular fraction if it's a Proper Fraction or a Mixed Number Fraction
                return new Fraction(fraction.WholePart, fraction.Numerator, fraction.Denominator);
            }
        }

        /// <summary>
        /// MakeDecimal - provides the "decimal" version of a fraction.
        /// </summary>
        /// <param name="fraction"></param>
        /// <returns>Decimal</returns>
        public static decimal MakeDecimal(Fraction fraction)
        {
            Fraction prepFraction;
            if(fraction.IsWholeNumber()) 
            { // whole number
                return (decimal)fraction.WholePart;
            }
            else 
            { // fractions
                // Convert fractions to improper fraction format (returns the same fraction if it's proper fraction.)
                prepFraction = FractionOperations.MakeImproper(fraction);
                return ((decimal)prepFraction.Numerator / (decimal)prepFraction.Denominator);   
            }   
        }

        /// <summary>
        /// IsEquivalent - Determine whether or not two fractions are equivalent.
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns>Boolean (true or false)</returns>
        public static Boolean IsEquivalent(Fraction fraction1, Fraction fraction2)
        {
            // Compare fractions
            if (FractionOperations.Compare(fraction1, fraction2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    } // end class






} // end namespace

