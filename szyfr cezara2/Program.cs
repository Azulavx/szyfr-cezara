Console.WriteLine("podaj literke do zakodowania");
string litera = Console.ReadLine();
char[] character = litera.ToCharArray();
int b;
Console.WriteLine("napisz klucz");
b = Int32.Parse(Console.ReadLine());
for (int i = 0; i < character.Length; i++)
{
    character[i] = (char)((character[i] + b));
    if (character[i] > 90)
    {
        character[i] = (char)((char)character[i] - 26);
    }
}
string litera2 = new string(character);
Console.WriteLine("zakodowana wiadomosc to:");
Console.WriteLine(litera2);
