string cycle = "true";
Console.WriteLine("This is a calculator in c#\r");
Console.WriteLine("--------------------------\n");
do {
    decimal num1 = 0; decimal num2 = 0; string operator_ = "";  
        
                Console.WriteLine("Insert a number and press enter");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Insert the numerical operator and press enter ");
                operator_ = Console.ReadLine();
                Console.WriteLine("Insert another number and press enter");
                num2 = Convert.ToDecimal(Console.ReadLine());
                switch (operator_)
                {
                    case "+":                       
                        Console.WriteLine($"Your result is: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "-":                 
                        Console.WriteLine($"Your result is: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "*":                      
                        Console.WriteLine($"Your result is: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "/":              
                        Console.WriteLine($"Your result is: {num1} / {num2} = " + (num1 / num2));
                        break;
                }
        Console.WriteLine("Do you want to perform another calculus? Type 'no' if you want to leave or 'yes' to keep calculating: ");
        cycle = Console.ReadLine();
} while (cycle == "yes");
Environment.Exit(0);