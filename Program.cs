// 1. Kalkulyator.
System.Console.WriteLine("Salom, men barcha arifmetik amallarni hisoblab bera olaman! Xohlasangiz sinab ko'ramiz....");
System.Console.WriteLine("Misol:");
string misol1 = Console.ReadLine();
string misol2 = Console.ReadLine();
string amal = Console.ReadLine();
decimal misoll1 = Convert.ToInt32(misol1);
decimal misoll2 = Convert.ToInt32(misol2);
decimal amall = Convert.ToInt32(amal);
decimal yechim = misoll1 amall misoll2; 

System.Console.WriteLine($"Javob: {yechim}");
