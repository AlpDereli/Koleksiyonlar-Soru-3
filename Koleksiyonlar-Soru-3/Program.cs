// See https://aka.ms/new-console-template for more information
List<char> sesliler = new List<char>();
Console.WriteLine("Bir cumle giriniz: ");
string s = Console.ReadLine();
string vowels = "AEIOUaeiou";
foreach (char c in s)
{
    if (vowels.Contains(c))
    {
        sesliler.Add(c);
    }
}
foreach(char c in sesliler)
{ Console.WriteLine(c); }

