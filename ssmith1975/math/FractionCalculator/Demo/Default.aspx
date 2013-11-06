<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demo</title>
    <link type="text/css" rel="stylesheet" href="_css/styles.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper">
        <div id="header">
            <h1>Fraction Calculator Demo</h1>
        </div>
        
        <div id="content">
            <h2>Factors<a id="top"></a></h2>
            <h3>Purpose</h3>
            <p>Multiplying numbers together.</p>
            <h3>For use in C# projects</h3>
            <p>Add a reference to <code>FactorCalculator</code> in your project(s) and <code>using FactorCalculator</code> in your C# file(s).</p>
            <h3>API</h3>
            <div class="class-member">       
                <h3>FindGCF<a id="FindGCF"></h3>
                <p>Greatest common factor. Method accepts two non-zero positive integers and returns one positive integer.</p>
                <div class="code">
<pre>
int gcf = Factors.FindGCF(6, 9);
Console.WriteLine(gcf);
</pre>
                <p><strong>Output:</strong><br />
                3
                </p> 
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>FindLCM<a id="FindLCM"></a></h3>
                <p>Least common multiple. Method accepts two non-zero positive integers and returns one positive integer</p>
                <div class="code">
<pre>
int lcm = Factors.FindLCM(6, 9);
Console.WriteLine(lcm);
</pre>  
                <p><strong>Output:</strong><br />
                18
                </p>                                
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>FindPrimeFactors<a id="FindPrimeFactors"></a></h3>
                <p>Factors an integer into its prime factors. Method accepts an integer and returns a Hashtable 
                with the factors as key and their corresponding multiplicities as value.</p>
                <div class="code">
<pre>
Hashtable primefactors = Factors.PrimeFactors(12);
foreach(DictionaryEntry prime in primefactors){
    Console.WriteLine("{0}^{1}", prime.Key, prime.Value);
}
</pre>  
                <p><strong>Output:</strong><br />
                    2^2<br />
                    3^1<br />
                </p>                                  
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>IsPrime<a id="IsPrime"></a></h3>
                <p>Determine whether or not a positive integer is a prime number. Returns a boolean.</p>
                <div class="code">
<pre>
Boolean checkNum1 = Factors.IsPrime(5);
Boolean checkNum2 = Factors.IsPrime(6);

Console.WriteLine(checkNum1);
Console.WriteLine(checkNum2);
</pre>
                 <p><strong>Output:</strong><br />
                    true<br />
                    false
                </p>                                   
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>ListCommonFactors<a id="ListCommonFactors"></a></h3>
                <p>List of factors shared between two positive integers. Returns a list of type <code>IEnumerable&lt;int&gt;</code>.</p>
                <div class="code">
<pre>
IEnumerable&lt;int&gt; commonFactors = Factors.ListCommonFactors(12, 8); 
foraeach(int factor as commonFactors){
    Console.WriteLine(factor);
}
</pre>  
                  <p><strong>Output:</strong><br />
                    2<br />
                    4
                </p>                                  
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>ListCommonMultiples<a id="ListCommonMultiples"></a></h3>
                <p>List of multiples divisible by each of integers. Returns a lis of type <code>IEnumerable&lt;int&gt;</code></p>
                <div class="code">
<pre>
IEnumerable&lt;int&gt; commonMultiples = Factors.ListCommonFactors(4, 6); 
foraeach(int multiple as commonFactors){
    Console.WriteLine(multiple);
}
</pre> 
                  <p><strong>Output:</strong><br />
                    12<br />
                    24<br />
                </p>                                  
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

            <div class="class-member">       
                <h3>ListMultiples<a id="ListMultiples"></a></h3>
                <p>List multiples of an integer. Returns a list of of type <code>IEnumerable&lt;int&gt;</code></p>
                <div class="code">
<pre>
IEnumerable&lt;int&gt; multiples = Factors.ListMultiples(3, 4);
foreach(factor in multiples){
    Console.WriteLine(factor);
}
</pre>  
                 <p><strong>Output:</strong><br />
                   3<br />
                   6<br />
                   9<br />
                   12
                </p>                                  
                </div><!-- //End Code -->
                <p class="top"><a href="#top" >To top of page</a></p>
            </div> <!-- //End Class Member -->

        <asp:Label ID="lblResult" runat="server"></asp:Label>            
        </div>

    </div>
    </form>
</body>
</html>
