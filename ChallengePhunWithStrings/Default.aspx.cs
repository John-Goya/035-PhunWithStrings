using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            // 1.  Reverse your name
            string name = "Darth Vader";
            // In my case, the result would be:
            // robaT boB
            for (int backwards = name.Length - 1; backwards >= 0; backwards--)
            {
                name += "</br>";
                resultLabel.Text += name[backwards];
            }

            

            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            string[] fabFour = names.Split(','); //create array, items separated by ','
            string turnaround = ""; //create end result string
            //int number = names.Length - 1;
            //for (int i = 0; i <= number; i++)
            for (int i = fabFour.Length - 1; i >= 0; i--) //looping over string array backwards
            {
                turnaround += fabFour[i] + ","; //adding each item in the string array to the string
            }
            turnaround = turnaround.Remove(turnaround.Length - 1, 1); //remove comma after Luke
            //fabFour[i] = fabFour[number - i];
            resultLabel0.Text = turnaround; //fabFour.ToString();

            
            

            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            string[] fabFour2 = names.Split(','); //create array, items separated by ','
            string artCanvas = ""; //create final string
            for (int i = 0; i < fabFour2.Length; i++) //going through string array
            {
                int padleft = (14 - fabFour2[i].Length) / 2; //set length of string(number asteriks needed)
                string spacing = fabFour2[i].PadLeft(fabFour2[i].Length + padleft, '*'); //calculate number needed for left side
                artCanvas += spacing.PadRight(14, '*'); //set padding on right side of string
                artCanvas += "<br />";
            }
            resultLabel1.Text = artCanvas;
            /*
              
            for (int i = fabFour2.Length - 1; i >= 0; i++); //going through string array
            {
                int length = 14;
                int spaces =  length - fabFour.Length;
                int padLeft = spaces / 2 + fabFour.Length;
                fabFour.PadLeft(padLeft, '*').PadRight(length, '*');
                artCanvas += "<br />";
                resultLabel.Text = artCanvas;
            }
            
            string linebreak = "</br>";
            resultLabel.Text = names.Replace(",", linebreak);
            
            //resultLabel.Text = names.PadLeft(50, '*');
            */



            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            puzzle = puzzle.Replace("remove-me", "");// delete "remove-me"
            puzzle = puzzle.Replace("Z", "T"); // replace Z with T
            puzzle = puzzle.ToLower(); // lowercase all
            puzzle = char.ToUpper(puzzle[0]) + puzzle.Substring(1); //capitalize 1st letter + rest of string
            resultLabel2.Text = puzzle;

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

        }
    }
}