using System.Text;

TextReader reader = new StreamReader("c:\\temp\\222.txt");
string line;
//Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Привіт");
while ((line = reader.ReadLine()) != null)
{
   Console.WriteLine(line);
}
reader.Close();