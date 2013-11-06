using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FactorCalculator;
using FractionCalculator;


namespace Demo
{
    public partial class Default : System.Web.UI.Page
    {
       string strList = String.Empty;
       

   
        protected void Page_Load(object sender, EventArgs e)
        {


            try {
            /*
                int num1 = 4, num2 = 0;           
                strList = String.Format("Common Multiples of {0} and {1}: ", num1, num2);

                IEnumerable<int> factorList = Factors.Factors.ListCommonMultiples(num1,num2);

                foreach(int i in factorList){
                    strList += String.Format("{0}  ", i);
                }
            */
                Fraction fraction1 = new Fraction(3, 2);
                Fraction fraction2 = new Fraction(4, 2);

                Fraction total = FractionOperations.Add(fraction1, fraction2);
                lblResult.Text = String.Format("{0}/{1} ", fraction1.Numerator, fraction1.Denominator);
                lblResult.Text += String.Format("+ {0}/{1} ", fraction2.Numerator, fraction2.Denominator);

                lblResult.Text += String.Format("= {0}/{1} ", total.Numerator, total.Denominator);
                lblResult.Text += "<br />" ;
                IEnumerable someList = Factors.FindPrimeFactors(24);
                foreach (DictionaryEntry item in someList){
                    lblResult.Text +=  item.Key +"^" + item.Value + " ";
                }
                //lblResult.Text = String.Format("{0}/{1} + {2}/{3} = {4}/{5}", fraction1.Numerator.ToString(), fraction1.Denominator.ToString(), fraction2.Numerator.ToString(), fraction2.Denominator.ToString());

            } catch(ArgumentException ex) {
                lblResult.Text  = "Argument exception: " + ex.Message;
            } catch(Exception ex) {
                lblResult.Text = "General exception: " + ex.Message;
            }
        }
    }
}