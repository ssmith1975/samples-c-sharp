<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fraction-object.aspx.cs" Inherits="Demo.docs.fraction_object" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fraction Object API - Fraction Calculator</title>
    <link type="text/css" rel="stylesheet" href="../_css/styles.css" />
</head>
<body>
    <form id="form1" runat="server">
<div id="wrapper">
        <div id="header">
            <h1>Fraction Calculator Demo</h1>
        </div>
        
        <div id="content">
            <h2>Fraction Object API Documentation</h2>
            <h3>Purpose</h3>
            <p>Defining an object for holding fraction values</p>
            <h3>For use in C# projects</h3>
            <p>Add a reference to <code>FractionCalculator</code> in your project(s) and <code>using FractionCalculator</code> in your C# file(s).</p>
            <h3>API</h3>
            <div class="class-member">       
                <h3>Fraction<a id="Fraction"></a></h3>
                <p>Initializes a fraction object using three signatures: whole number only (ie 3), fractional parts only (ie. (1/2), and whole with fraction parts (ie. 3 1/2). Parameters allows all integers,
                    though a zero for either numerator and/or denominator will set the fraction up as a whole number.
                </p>
                <div class="code">
<pre>
Fraction fraction1 = new Fraction(3);
Fraction fraction2 = new Fraction(1, 2);
Fraction fraction3 = new Fraction(3, 1, 2);
</pre>
                </div><!-- //End Code -->
                <p class="top"><a href="#top">To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>WholePart<a id="WholePart"></a></h3>
                <p>Property for getting and setting a value of type integer for the whole part of a fraction.</p>
                <div class="code">
<pre>
int whole;

// Instantiate a Fraction object...
Fraction fraction = new Fraction(3, 1, 2);
whole = fraction.WholePart;
Console.WriteLine(whole);

// Set whole part to 4...
fraction.WholePart = 4;
whole = fraction.WholePart;
Console.WriteLine(whole);
</pre>  
                <p><strong>Output:</strong><br />
                3<br />
                4
                </p>                                
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>Numerator<a id="Numerator"></a></h3>
                <p>Property for getting and setting a value of type integer for the numerator of a fraction. Setting this value automatically
                sets the denominator to zero.
                </p>
                <div class="code">
<pre>
int num;

// Instantiate a Fraction object...
Fraction fraction = new Fraction(3, 1, 2);
num = fraction.Numerator;
Console.WriteLine(num);

// Set nmerator part to 3...
fraction.Numerator = 3;
num = fraction.Numerator;
Console.WriteLine(num);
</pre>  
                <p><strong>Output:</strong><br />
                    1<br />
                    3<br />
                </p>                                  
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>Denominator<a id="Denominator"></a></h3>
                <p>Property for getting and setting a value of type integer for the numerator of a fraction. Setting this value automatically
                sets the denominator to zero.</p>
                <div class="code">
<pre>
int den;

// Instantiate a Fraction object...
Fraction fraction = new Fraction(3, 1, 2);
den = fraction.Denominator;
Console.WriteLine(den);

// Set denominator part to 5...
fraction.Denominator = 5;
den = fraction.Denominator;
Console.WriteLine(den);
</pre>
                 <p><strong>Output:</strong><br />
                    2<br />
                    5
                </p>                                   
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>IsImproper<a id="IsImproper"></a></h3>
                <p>Method that determines whether or not a fraction is improper. A fraction is improper if its numerator is greater than 
                or equal to its denominator and its whole part is zero. Returns a boolean.</p>
                <div class="code">
<pre>
Boolean result;

// Instantiate a Fraction object...
Fraction fraction = new Fraction(3, 2);
result = fraction.IsImproper();

Console.WriteLine(result);
</pre>  
                  <p><strong>Output:</strong><br />
                    true                    
                </p>                                  
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>IsMixedNumber<a id="IsMixedNumber"></a></h3>
                <p>Method determines whether or not a fraction is a mixed number fraction. Returns a boolean.</p>
                <div class="code">
<pre>
Boolean result;

// Instantiate a Fraction object...
Fraction fraction = new Fraction(3, 2);
result = fraction.IsMixedNumber();

Console.WriteLine(result);
</pre> 
                  <p><strong>Output:</strong><br />
                    false
                </p>                                  
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>IsUnit<a id="IsUnit"></a></h3>
                <p>Method determines whether or not a fraction is a unit fraction. Returns a boolean.</p>
                <div class="code">
<pre>
Boolean result;

// Instantiate a Fraction object...
Fraction fraction = new Fraction(1, 2);
result = fraction.IsUnit();

Console.WriteLine(result);
</pre>  
                 <p><strong>Output:</strong><br />
                   true
                </p>                                  
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

   
              <div class="class-member">       
                <h3>IsWholeNumber<a id="IsWholeNumber"></a></h3>
                <p>Method determines whether or not a fraction is a whole number fraction. Returns a boolean.</p>
                <div class="code">
<pre>
Boolean result;

// Instantiate a Fraction object...
Fraction fraction = new Fraction(1, 2);
result = fraction.IsWholeNumber();

Console.WriteLine(result);
</pre>  
                 <p><strong>Output:</strong><br />
                   false
                </p>                                  
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->
            
             <div class="class-member">       
                <h3>ToString<a id="ToString"></a></h3>
                <p>Overrides the default ToString() method. Prints fractions in the format of <i>1 1/2</i>, <i>1/2</i>, and <i>1</i></p>
                <div class="code">
<pre>
string fractionString;

// Instantiate a Fraction object...
Fraction fraction = new Fraction(3, 1, 2);
fractionString = fraction.ToString();

Console.WriteLine(result);
</pre>  
                 <p><strong>Output:</strong><br />
                   3 1/2
                </p>                                  
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->            
   
             
          </div><!-- // End content -->
      </div><!-- // End wrapper -->
    </form>
</body>
</html>
