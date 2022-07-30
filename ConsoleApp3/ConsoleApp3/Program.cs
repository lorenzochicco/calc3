decimal num1 = 0; decimal num2 = 0; string operator_ = ""; decimal result = 0; string cycle = "true"; bool cyclel = true; string newcycle = "";
Console.WriteLine("This is a calculator in c#\r");
Console.WriteLine("--------------------------\n");
Console.WriteLine("Do you want to perform a calculus? Type 'yes' or 'no'");
cycle = Console.ReadLine();

do {
    {
        switch (cycle)
        {
            case "no":
                Environment.Exit(0);
                break;
            case "yes":
                Console.WriteLine("Insert a number and press enter");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Insert the numerical operator and press enter ");
                operator_ = Console.ReadLine();
                Console.WriteLine("Insert another number and press enter");
                num2 = Convert.ToDecimal(Console.ReadLine());
                switch (operator_)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result is: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result is: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result is: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result is: {num1} / {num2} = " + result);
                        break;

                }
                break;
        }
        Console.WriteLine("Do you want to perform another calculus? Type 'no' if you want to leave or 'yes' to keep calculating: ");
        cycle = Console.ReadLine();
    }  
} while (cycle == "yes");

Environment.Exit(0);