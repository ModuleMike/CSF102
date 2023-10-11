string input;

int num;
double val;

do
{
    Console.Write("Enter a value: ");
    input = Console.ReadLine();


    if (double.TryParse(input, out val))
    {
        break;
    }
    Console.WriteLine("That was not a valid value!");

} while (true);

