using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractionCalculator
{
   
    public class Fraction
    {
        private int _numerator;
        private int _denominator;
        private int _wholePart;
   


        #region Class Contructors

        /// <summary>
        /// Constructor for instantiating Whole Numbers.
        /// </summary>
        /// <param name="wholePart">Whole number</param>
        public Fraction(int wholePart):this(wholePart, 0, 0)
        {
            // Code handled by Fraction(int wholePart, int numerator, int denominator)
        }

        /// <summary>
        /// Constructor for instantiating a fraction with a numerator and denominator component
        /// </summary>
        /// <param name="numerator">Top part of a fraction.</param>
        /// <param name="denominator">Bottom part of a fraction.</param>
        public Fraction(int numerator, int denominator):this(0, numerator, denominator)
        {
            // Code handled by Fraction(int wholePart, int numerator, int denominator)
           
        }

        /// <summary>
        /// Constructor for instantiating a fraction with a mixed fraction
        /// </summary>
        /// <param name="wholePart">Whole number</param>
        /// <param name="numerator">Top part of a fraction.</param>
        /// <param name="denominator">Bottom part of a fraction.</param>
        public Fraction(int wholePart, int numerator, int denominator)
        {

            // Initialize fraction fields
            Init(wholePart, numerator, denominator);
                      
        }
        #endregion

        #region Class Properties

        /// <summary>
        /// Accessor for the wholepart.
        /// </summary>
        public int WholePart
        {
            get
            {
                return this._wholePart;
            }

            set
            {
                // Initialize fraction parameters
                Init(value, this._numerator, this._denominator);
            }
        }

        /// <summary>
        /// Accessor for the numerator.
        /// </summary>
        public int Numerator 
        {
            get {
                return this._numerator;
            }

            set {
                // Initialize fraction parameters
                Init(this._wholePart, value, this._denominator);
            }
        }

        /// <summary>
        /// Accessor for the denominator.
        /// </summary>
        public int Denominator
        {
            get {
                return this._denominator;
            }

            set {

                // Initialize fraction fields
                Init(this._wholePart, this._numerator, value);
            }
        }

        #endregion

        #region Class Methods
         
         /// <summary>
         /// Checks whether or not a fraction is improper. A fraction  is improper when
         /// its denominator is greater than its numerator.
         /// </summary>
         /// <returns>boolean</returns>
         public Boolean IsImproper()
         {
            return ((Math.Abs(this._denominator) <= Math.Abs(this._numerator)) && !( (this._numerator == 0) || (this._denominator == 0)) );
         }


         /// <summary>
         /// Checks whether or not a fraction is a mixed number. A fraction is as mixed number
         /// when its whole part is non-zero.
         /// </summary>
         /// <returns>Boolean</returns>
         public Boolean IsMixedNumber()
         {
            return ( (this._wholePart != 0) && (this._numerator != 0) && (this._denominator != 0) );
         }


         /// <summary>
         /// IsWholeNumber - determines whether or not a fraction is just a simple whole number
         /// </summary>
         /// <param name="fraction"></param>
         /// <returns>Boolean</returns>
         public Boolean IsWholeNumber()
         {
             return ((this._wholePart != 0) && (this._numerator == 0) && (this._denominator == 0));
         }

         /// <summary>
         /// Checks whether or not a fraction is a unit fraction. A unit fraction has a 
         /// numerator of 1.
         /// </summary>
         /// <returns>Boolean</returns>
         public Boolean IsUnit()
         {
          
                return ( !(this.IsMixedNumber() || this.IsWholeNumber()) && (Math.Abs(this._numerator) == 1 ) );           
         }

        
         public override string ToString()
         {
         
            if( this.IsMixedNumber() )
            {
                return String.Format("{0} {1}/{2}", this._wholePart, this._numerator, this._denominator);
            }
            else if(this.IsWholeNumber())
            {
                return  String.Format("{0}", this._wholePart);
            }
            else
            {
                return String.Format("{0}/{1}", this._numerator, this._denominator);
            }
            

            // return base.ToString();
         }
         /**/

         /// <summary>
         /// Overrides the Equal method 
         /// </summary>
         /// <param name="obj"></param>
         /// <returns></returns>
         public override bool Equals(object obj)
         {
             Fraction other = obj as Fraction;
             if (other == null)
             {
                 return false;
             }
             return ( (this.WholePart == other.WholePart)
                && (this.Numerator == other.Numerator)
                && (this.Denominator == other.Denominator) );
         }

         /// <summary>
         /// Overrides the GetHashCode method
         /// </summary>
         /// <returns></returns>
         public override int GetHashCode()
         {
             return string.Format("{0}{1}{2}", this.WholePart, this.Numerator, this.Denominator).GetHashCode();
         }        


         /// <summary>
         /// Sets whole part, numerator, and denominator with negative sign placement and "zero" parts.
         /// </summary>
         /// <param name="whole">Whole numer</param>
         /// <param name="num">Numerator</param>
         /// <param name="den">Denominator</param>
         private void Init(int whole, int num, int den){

            // Check for negative arguments
            if(num * den < 0)
            { // Either numerator or denominator is negative

                // Convert denominator to a positive integer
                this._denominator = Math.Abs(den);

                // Set negative sign
                if(whole != 0)
                {  
                   // Change state of negative sign of whole part
                   this._wholePart = -1 * whole;
                   
                   // Make numerator positive
                   this._numerator = Math.Abs(num); 
                }
                else
                {
                    // Set whole part
                    this._wholePart = whole;

                    // Attach negative sign to numerator
                    this._numerator = -1 * Math.Abs(num);
                }                
            }
            else if(num * den > 0)
            { // Either both numerator and denominator are positive or both are negative

                // Set whole part
                this._wholePart = whole;

                // Absorb the negative signs
                this._numerator = Math.Abs(num);
                this._denominator = Math.Abs(den);

            }
            else
            { // At least one argument is zero, make both numerator and denominator zero

                // Set whole part
                this._wholePart = whole;

                // Set both numerator and denominator to zero
                this._numerator = 0;
                this._denominator = 0;
            }
         }

        #endregion

    } // end class
} // end namespace
