Console.Clear();
Console.WriteLine("--- Soletrar ---");

Console.Write(" Digite uma palavra a ser soletrada ");
string palavra = Console.ReadLine()!;

var caracteres = palavra.ToCharArray ();
string palavraSoletrada = string.Join('-', caracteres) . ToUpper();

Console.WriteLine($"\nSoletrando \" {palavra.ToUpper()}\": {palavraSoletrada} ");
