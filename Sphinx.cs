using System;
using System.Collections.Generic;

class Sphinx
{
    static void Main()
    {
        Dictionary<string, string> riddles = new Dictionary<string, string>();
        riddles.Add("What gets wet as its drying", "a towel");
        riddles.Add("What has to be broken before you can use it?", "An egg");
        riddles.Add("What month of the year has 28 days?","All of them");
        foreach(KeyValuePair<string, string> riddle in riddles)
        {   
            Console.WriteLine(riddle.Key);
            string response1 = Console.ReadLine();
            if (response1.Equals(riddle.Value))
            {
                Console.WriteLine("This is correct");
            }
            else
            {
                Console.WriteLine("This is incorrect");
                break;
            }
        }
    }
};