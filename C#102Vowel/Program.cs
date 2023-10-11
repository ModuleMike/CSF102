string key;

Console.Write("Press Any Key: ");
key = Console.ReadLine().ToUpper();

//if (key == "A" || key == "E" || key == "I" || key == "O" || key == "U")
//{
//    Console.WriteLine("It's A Vowel!");
//}
//else
//{
//    Console.WriteLine("It's Not A Vowel!!");
//}


switch (key)
{
    case "A":
    case "E":
    case "I":
    case "O":
    case "U":
        Console.WriteLine("It's A Vowel!!");
            break;
    case "Y":
        Console.WriteLine("Some Times A Vowel?!?");
        break;
    default:
        Console.WriteLine("Not A Vowel!!");
        break;

}