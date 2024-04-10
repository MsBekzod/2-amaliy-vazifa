// 1. Kalkulyator.
    
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

        

// 2. Raqamlar qatorining yig'indisini  hisoblash.

System.Console.Write("Salom, ixtiyoriy natural son yozing:");
int son =Convert.ToInt32(Console.ReadLine());
int misol = (son*(son-1)/2)+son;
System.Console.WriteLine($"1 dan {son} songacha bo'lgan raqamlar yig'indisi {misol} ");



// 3. Paritet tekshiruvi.

System.Console.Write("Salom bu yana men, Ixtiyoriy natural sonni kiriting:");
int sonn = Convert.ToInt32(Console.ReadLine());
if (sonn%2 == 0)
{
System.Console.WriteLine("Kiritgan soningiz Juft");
}
else 
{
System.Console.WriteLine("Kiritgan soningiz Toq");
}
            
 