decimal amount, tip;

do
{
    Console.Clear();
    Console.WriteLine("Tip Calculator");
    Console.WriteLine("==============");

    Console.Write("Enter Amount: ");
    amount = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Enter Tip %: ");
    tip = Convert.ToDecimal(Console.ReadLine());

    Console.Clear();
    Console.Write($"A {tip:p0} tip on {amount:c} is ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{(tip * amount):c}");
    Console.ResetColor();
    Console.Write("Go again? (Y/N): ");
    if (Console.ReadLine().ToUpper() != "Y")
    {
        break;
    }
} while (true);