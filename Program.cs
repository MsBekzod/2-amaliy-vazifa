// // 1. Kalkulyator.
    
    System.Console.Write("Enter first Number:");
    double n1= Convert.ToDouble(Console.ReadLine());

    System.Console.Write("Enter the Operation:");
    string Operation= Console.ReadLine();

    System.Console.Write("Enter the second Number:");
    double n2= Convert.ToDouble(Console.ReadLine());

        switch (Operation){

            case "+":
            System.Console.WriteLine($"Answer: {n1}+{n2}={n1+n2}");
            break;

            case "-":
            System.Console.WriteLine($"Answer: {n1}-{n2}={n1-n2}");
            break;

            case "*":
            System.Console.WriteLine($"Answer: {n1}*{n2}={n1*n2}");
            break;

            case "/":
            System.Console.WriteLine($"Answer: {n1}/{n2}={n1/n2}");
            break;
        };