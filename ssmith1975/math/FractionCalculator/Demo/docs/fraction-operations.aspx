﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fraction-operations.aspx.cs" Inherits="Demo.docs.fraction_operations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
     <title>Fraction Operations API - Fraction Calculator</title>
    <link type="text/css" rel="stylesheet" href="../_css/styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            <div id="header">
                <div class="topnav clearfix">
                    <ul>
                        <li><a href="../default.aspx">Home</a></li>
                        <li><a href="../demo.aspx">Demo</a></li>
                        <li><a href="/default.aspx">Docs</a></li>                   
                    </ul>
                </div>
                <h1>Fraction Calculator Demo</h1>

            </div><!-- // End Header -->
        
            <div id="content">
                <h2>Fraction Operations API Documentation</h2>
                <div class="menu">
                    <ul>
                        <li><a href="factors.aspx">Factor Calculations API</a>
                            <ul>
                                <li><a href="factors.aspx#">method</a></li>
                                <li><a href="factors.aspx#">method</a></li>
                                <li><a href="factors.aspx#">method</a></li>
                            </ul>
                        </li>
                        <li><a href="factors.aspx">Fraction Operations API</a>
                            <ul>
                                <li><a href="fraction-operations.aspx#">method</a></li>
                                <li><a href="fraction-operations.aspx#">method</a></li>
                                <li><a href="fraction-operations.aspx#">method</a></li>
                            </ul>
                        </li>
                        <li><a href="factors.aspx">Fraction Object API</a>
                            <ul>
                                <li><a href="fraction-object.aspx#">method</a></li>
                                <li><a href="fraction-object.aspx#">method</a></li>
                                <li><a href="fraction-object.aspx#">method</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
                <h3>Purpose</h3>
                <p>Various fraction calculations.</p>
                <h3>For use in C# projects</h3>
                <p>Add a reference to <code>FractionCalculator</code> in your project(s) and <code>using FractionCalculator</code> in your C# file(s).</p>
                <h3>API</h3>




            <div class="class-member">       
                <h3>Add<a id="Add"></a></h3>
                <p>Calculates the sum of two fractions. Accepts two fractionsobjects in the parameters and returns a single fraction object,
                 if applicable, in improper format. </p>
                
                <div class="code">
<pre>
Fraction fraction1 = new Fraction(1, 5);
Fraction fraction2 = new Fraction(2, 5);

Fraction fractionResult = FractionOperations.Add(fraction1, fraction2);

Console.WriteLine(fractionResult.ToString());
</pre>
                <p><strong>Output:</strong><br />
                    3/5
                </p>                 </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>Compare<a id="Compare"></a></h3>
                <p>Method compares the value of one fraction to another. Accepts two fractions objects in the parameters and 
                returns a -1, 0, or 1 for less than, equal to, or less than, respectively. 
                </p>
                <div class="code">
<pre>
Fraction fraction1 = new Fraction(-1, 5);
Fraction fraction2 = new Fraction(1, 5);
Fraction fraction3 = new Fraction(1, 5);
Fraction fraction4 = new Fraction(2, 5);

int result1 = FractionOperations.Compare(fraction1, fraction2);
int result2 = FractionOperations.Compare(fraction2, fraction3);
int result3 = FractionOperations.Compare(fraction4, fraction2);

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);
</pre>
                <p><strong>Output:</strong><br />
                   -1<br />
                   0<br />
                   1
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>Divide<a id="Divide"></a></h3>
                <p>Method performs division between two fractions. Divisors must be non-zero.  Accepts two fraction objects in the parameters and returns another fraction object.
                </p>
                <div class="code">
<pre>
Fraction fraction1 = new Fraction(1, 5);
Fraction fraction2 = new Fraction(2, 5);

Fraction fractionResult = FractionOperations.Divide(fraction1, fraction2);

Console.WriteLine(fractionResult.ToString());
</pre>
                <p><strong>Output:</strong><br />
                   1/2
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>FindReciprocal<a id="FindReciprocal"></a></h3>
                <p>Method calculates the reciprocal of a non-zero fraction. Accepts a fraction object and returns another fraction object.
                </p>
                <div class="code">
<pre>
Fraction fraction = new Fraction(2, 5);

Fraction fractionResult = FractionOperations.FindReciprocal(fraction);

Console.WriteLine(fractionResult.ToString());
</pre>
                <p><strong>Output:</strong><br />
                   5/2
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->


            <div class="class-member">       
                <h3>FindReduced<a id="FindReduced"></a></h3>
                <p>Method calculates a fraction in reduced form. Accepts a fraction object in the parameter,
                    and returns another fraction object.
                </p>
                <div class="code">
<pre>
Fraction fraction = new Fraction(4, 8);

Fraction fractionResult = FractionOperations.FindReduced(fraction);

Console.WriteLine(fractionResult.ToString());
</pre>
                <p><strong>Output:</strong><br />
                   1/2
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>IsEquivalent<a id="IsEquivalent"></a></h3>
                <p>Method determines whether or not two fractions are equivalent. Accepts to fraction objects in the parameters, 
                    and returns a boolean.
                </p>
                <div class="code">
<pre>
Fraction fraction1 = new Fraction(1, 5);
Fraction fraction2 = new Fraction(2, 10);

Boolean result = FractionOperations.IsEquivalent(fraction1, fraction2);

Console.WriteLine(result);
</pre>
                <p><strong>Output:</strong><br />
                   true
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>MakeDecimal<a id="MakeDecimal"></a></h3>
                <p>Method calculatesa floating decimal number from a fraction. Accepts a fraction object in the parameter,
                    returns a value of type decimal.
                </p>
                <div class="code">
<pre>
Fraction fraction = new Fraction(4, 8);

Decimal result = FractionOperations.MakeDecimal(fraction);

Console.WriteLine(result);
</pre>
                <p><strong>Output:</strong><br />
                   0.50000
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>MakeEquivalent<a id="MakeEquivalent"></a></h3>
                <p>Method calculates an equivalent fraction by multiplying numerator and denominator of one fraction by a positive, non-zero integer.
                    Accepts a fraction object and positive integer in the parameters, returns a fraction object.
                </p>
                <div class="code">
<pre>
Fraction fraction1 = new Fraction(1, 5);
int factor = 5;

Fraction fractionResult = FractionOperations.MakeEquivalent(fraction1, factor);

Console.WriteLine(fractionResult.ToString());
</pre>
                <p><strong>Output:</strong><br />
                   5/25
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->


            <div class="class-member">       
                <h3>MakeImproper<a id="MakeImproper"></a></h3>
                <p>Method takes a fraction, if mixed number fraction or whole number, and creates an improper fraction.
                Proper and improper fractors  returns itself. Accepts a fraction object in the parameter, and 
                returns another fraction object.
                </p>
                <div class="code">
<pre>
Fraction fraction = new Fraction(1, 1, 3);


Fraction fractionResult = FractionOperations.MakeImproper(fraction);

Console.WriteLine(fractionResult.ToString());
</pre>
                <p><strong>Output:</strong><br />
                   4/3
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>MakeMxedNumber<a id="MakeMxedNumber"></a></h3>
                <p>Method takes an improper fraction and creates mixed number fraction from it. Accepts a fraction object in the 
                parameter, and returns another fraction object.
                </p>
                <div class="code">
<pre>
Fraction fraction = new Fraction(4, 3);

Fraction fractionResult = FractionOperations.MakeMxedNumber(fraction);

Console.WriteLine(fractionResult.ToString());
</pre>
                <p><strong>Output:</strong><br />
                   1 1/3
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>Multiply<a id="Multiply"></a></h3>
                <p>Method calculates the product of two fractions. Accepts two fractions objects in the parameter,
                    and returns another fraction object.
                </p>
                <div class="code">
<pre>
Fraction fraction1 = new Fraction(2, 5);
Fraction fraction2 = new Fraction(7, 5);

Fraction fractionResult = FractionOperations.Multiply(fraction1, fraction2);

Console.WriteLine(fractionResult.ToString());
</pre>
                <p><strong>Output:</strong><br />
                   14/25
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>Subtract<a id="Subtract"></a></h3>
                <p>Method calculates the difference of two fractions. Accepts two fractions objects in the parameter,
                    and returns another fraction object.
                </p>
                <div class="code">
<pre>
Fraction fraction1 = new Fraction(4, 5);
Fraction fraction2 = new Fraction(2, 5);

Fraction fractionResult = FractionOperations.Subtract(fraction1, fraction2);

Console.WriteLine(fractionResult.ToString());
</pre>
                <p><strong>Output:</strong><br />
                   2/5
                </p>
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->


            </div><!-- // End Content -->
        </div><!-- // End Wrapper -->
    </form>
</body>
</html>
