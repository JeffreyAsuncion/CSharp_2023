using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string randString = "This is a string";
            Console.WriteLine("String Length : {0}",
                randString.Length);
            Console.WriteLine("String Contains is : {0}",
                randString.Contains("is"));
            Console.WriteLine("Index of is : {0}",
                randString.IndexOf("is"));
            Console.WriteLine("Remove String  : {0}",
                randString.Remove(10, 6));
            Console.WriteLine("Insert String  : {0}",
                randString.Insert(10, "short "));
            Console.WriteLine("Replace String  : {0}",
                randString.Replace("string", "sentence"));
            Console.WriteLine("Compare A to B  : {0}",
                String.Compare("A", "B,",
                StringComparison.OrdinalIgnoreCase));
            // Compare strings and ignore case
            // < 0 : str1 preceeds str2
            // = : Zero
            // > 0 : str2 preceeds str1

            Console.WriteLine("--------------------------");

            Console.WriteLine("A = a : {0}", 
                String.Equals("A","a",
                StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad Left : {0}",
                randString.PadLeft(20, '.'));
            Console.WriteLine("Pad Right : {0}",
                randString.PadRight(20, '.'));
            Console.WriteLine("Trim : {0}",
                randString.Trim());
            Console.WriteLine("Uppercase : {0}",
                randString.ToUpper());
            Console.WriteLine("Lowercase : {0}",
                randString.ToLower());
            String newString = String.Format("{0} saw a {1} {2} in the {3}", 
                "Paul","rabbit", "eatting", "field");
            Console.Write(newString + "\n");
            // Escape Characters
            // \' \" \\ \t \a \n
            // @ verbatum string, gives literal \n
            Console.WriteLine(@"Exactly what I typed\n");



            Console.Read();
        }
    }
}