using System;

namespace Please_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            string general = "Hello Wor1{ld";
            string[] cut = general.Split(" ");
            foreach (var word in cut) //тут мы в цикле перебираем все слова
            {
                char[] reverse = word.ToCharArray();
                for (int i = 0, j = word.Length - 1; i < j;)//тут мы в цикле перебираем все СИМВОЛЫ слова (буквы)
                {
                    if (char.IsLetter(word[i]) && char.IsLetter(word[j]))
                    {
                        char mediator = reverse[j];
                        reverse[j] = reverse[i];
                        reverse[i] = mediator;
                        i++;
                        j--;
                    }
                    else if (char.IsLetter(word[i]) && !char.IsLetter(word[j]))
                    {
                        i++;
                    }
                    else if (!char.IsLetter(word[i]) && char.IsLetter(word[j]))
                    {
                        j--;
                    }
                    else
                    {
                        i++;
                        j--;
                    }
                }
                Console.Write(reverse);
                Console.Write(" ");
            }
        }
    }
}
//Если i-й элемент - буква и j-й элемент буква - меняй их местами.
//Если i-й элемент - не буква а j-й элемент-буква - то указатель на i должен сместиться (i++), а указатель на j - остается на месте.
//Если i-й элемент - буква а j-й элемент - не буква - то указатель на j должен сместиться (j--), а указатель на i - остается на месте.