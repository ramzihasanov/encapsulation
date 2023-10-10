namespace ConsoleApp1
{
    internal class Program
    {
        static string Capitalize(string word)
        {
            char uperchar;
           
                if (word[0] <= 'z' && word[0] >= 'a')
                {
                    uperchar = (char)(word[0] - 32);
                }

                else uperchar = word[0];
            
            return uperchar + word[1..];
        }





        static void Main(string[] args)
        {
            person person = new person("Remzi Hesenov", 19, "0602646414");
            person.ShowFullName();

            Console.WriteLine("==============2ci task=========================");
            Console.WriteLine(Capitalize("mellim"));

            
        }
    }
}