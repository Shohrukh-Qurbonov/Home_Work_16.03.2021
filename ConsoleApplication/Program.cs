using System;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //ДЗ №1
            string Text = "This free online English language course will teach you about gerunds and infinitives." +
                            "In this course you will learn how to identify gerunds in a sentence, and study important" +
                            " vocabulary, adjectives, and phrases that will help you to describe people, places, and things in English.";

            string code = string.Join("", Text.Select(t => (t == 'a') ? '1' : (t == 'e') ? '2' : (t == 'i') ? '3' : (t == 'o') ? '4' :
            (t == 'u') ? '5' : (t == 'y') ? '6': t));

            string decode = string.Join("", Text.Select(t => (t == '1') ? 'a' : (t == '2') ? 'e' : (t == '3') ? 'i' : (t == '4') ? 'o' :
            (t == '5') ? 'u' : (t == '6') ? 'y' : t));
            
            //ДЗ №2
            string dirtyText = "gdfgdf234dg54gf*23oP42";
            int leftNumber = 0;
            int rightNumber = 0;
            double leftSide =  Convert.ToDouble(string.Join("", dirtyText.TakeWhile(t => t != '*' && t != '/' && t != '+' && t != '-').Where(t => int.TryParse(t.ToString(), out leftNumber)).ToArray()));
            double rightSide = Convert.ToDouble(string.Join("", dirtyText.SkipWhile(t => t != '*' && t != '/' && t != '+' && t != '-').Where(t => int.TryParse(t.ToString(), out rightNumber)).ToArray()));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выберите свою команду:");
            Console.ResetColor();
            Console.Write(" 1 --> *\n 2 --> /\n 3 --> +\n 4 --> - \n");
            int operation = int.Parse(Console.ReadLine());
                double result = operation switch
                {
                    1 => leftSide * rightSide,
                    2 => leftSide / rightSide,
                    3 => leftSide + rightSide,
                    4 => leftSide - rightSide,
                    _ => throw new ArgumentException("incorrect command!")
                };

            //ДЗ №3
            string camelCase = "loremIpsumDolorSitAmetConsecteturAdipisicingElitNequeCorruptiSintAccusantium" +
                               "AsperioresCulpaTotamAssumendaDictNatusIlloRemOfficiaSimiliquePossimusNullaAssumendaAd" +
                               "IsteOdioQuiaDolorAsperioresDolorumExpeditaIdEosLiberoEiusMinusBeataeLabordadfgeumExRepellat?";

            string camelCaseText = string.Join("", camelCase.Select(x => (x.ToString() == x.ToString().ToUpper()) ? " " + x.ToString() : x.ToString()));
            
            Console.WriteLine(code);
            Console.WriteLine(decode);
            Console.WriteLine(result);
            Console.WriteLine(camelCaseText);
        }
    }
}
