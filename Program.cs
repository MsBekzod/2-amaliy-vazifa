// 1. Kalkulyator.
    
System.Console.Write("Enter first number:");
double n1=Convert.ToDouble(Console.ReadLine());

System.Console.Write("Enter the Operator:");
string Operator=Console.ReadLine();

System.Console.Write("Enter the second number:");
double n2=Convert.ToDouble(Console.ReadLine());
    switch (Operator)
    {
        case "+":
        Console.Write($"Answer:{n1}+{n2}={n1+n2}");
        break;

         case "-":
        Console.Write($"Answer:{n1}-{n2}={n1-n2}");
        break;

         case "*":
        Console.Write($"Answer:{n1}*{n2}={n1*n2}");
        break;

         case "/":
        Console.Write($"Answer:{n1}/{n2}={n1/n2}");
        break;
        };

    