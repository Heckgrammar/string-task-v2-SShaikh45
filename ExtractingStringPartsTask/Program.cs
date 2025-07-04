﻿namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";
            // output the length of state
            Console.WriteLine(state.Length);

            // Concatenate the contents of city and landmark * don't forget to add a space
            Console.WriteLine(city+ " "+landmark);

            // output the first character of county
            Console.WriteLine(country[0]);

            // output a concatenation of the first and last characters of city
		    string two_string = Convert.ToString(city[0]);
			string three_string = Convert.ToString(city[12]);
            Console.WriteLine(two_string+three_string);

            // output the substring of landmark starting at c and outputting to the end
            Console.WriteLine(landmark.Substring(2));

            // output the substring of country starting at the first S and ending at the first A
            Console.WriteLine(country.Substring(6,17));

            // output the position of f in California
            Console.WriteLine(state.IndexOf("f"));

            //************CHALLENGE****************//
            
            // Output how many vowels are in each of the strings in the format
            Console.WriteLine("What is the string you want to know the number of vowels for?");
            string my_string = Console.ReadLine();
            int vowel = 0;
		int i=0;
             for(i =0; i < my_string.Length ; i++)
             {
                
                if (my_string[i] == 'a' || my_string[i] == 'e' || 
                my_string[i] == 'i' ||my_string[i] == 'o' || 
                my_string[i] == 'u' || my_string[i] == 'A' || 
               my_string[i] == 'E' || my_string[i] == 'I' || 
                my_string[i] == 'O' ||my_string[i] == 'U')
               {
               vowel = vowel + 1;
                }
             }
            Console.WriteLine("There are "+ vowel + " vowels in "+ my_string);
        }
    }
}
