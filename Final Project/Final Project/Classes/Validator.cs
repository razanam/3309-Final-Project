using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
 * Rawnaz Anam & Wilson Diaz
 * CIS 3309
 * Final Project
 * Stage 1
 * 11/23/2019
 */
namespace Final_Project.Classes
{
    static class Validator
    {
        //input must be a 5-digit long positive integer
        public static bool validateUPC(string upc)
        {
            Regex regex = new Regex("^(\\d){5}$");
            return regex.IsMatch(upc);
        }

        //use for title, label
        //accepts words and numbers separated by spaces. No trailing spaces.
        public static bool validateTitle(string title)
        {
            //Regex regex = new Regex("^([\\w]*(\\s)?)+([\\w])$");
            Regex regex = new Regex("^([\\S]+[\\w]*(\\s)?)*([\\w])$");
            return regex.IsMatch(title);
        }

        //must be a positive decimal value
        public static bool validatePrice(string price)
        {
            bool tempBool=false;
            try
            {
                tempBool = Convert.ToDecimal(price) > 0.0m;

            }
            catch
            {
                return false;
            }
            return tempBool;
        }

        //must be a positive integer
        //use for quantity, pages
        //called in validateRunTime
        public static bool validateIntNumber(string num)
        {
            bool tempBool=false;
            try
            {
                tempBool = Convert.ToInt32(num) > 0;
            }
            catch
            {
                return false;
            }
            return tempBool;
        }

        //must be a string of 3 integers. no spaces.
        //this will get called on left and right separately before concatenating them
        public static bool validateISBN(string isbn)
        {
            Regex regex = new Regex("^(\\d){3}$");
            return regex.IsMatch(isbn);
        }

        //use for author, lead actor, conductor
        //allows for as many names as needed and lets the last one be hyphenated
        //no punctuation allowed, numbers are ok except at the end
        public static bool validateName(string name)
        {
            //regex = new Regex("^([a-zA-Z]+)$|^(([a-zA-Z]+)(\\s))+([a-zA-Z]+-?[a-zA-Z]+)?[^\\W0-9]$");
            //Regex regex = new Regex("^([a-zA-Z]+)$|^(([a-zA-Z]*)(\\s))+([a-zA-Z]*-?[a-zA-Z]*)?[^\\W0-9]$");
            Regex regex = new Regex("^([\\Sa-zA-Z]+)$|^(\\S([a-zA-Z]*)(\\s)?)+([a-zA-Z]*-?[a-zA-Z]*)?[^\\W0-9]$");
            return regex.IsMatch(name);
        }

        //between 11/01/1996 and 12/31/2019
        //use DateTimePicker on form so input will be valid - just check logic
        public static bool validateReleaseDate(DateTime releaseDate)
        {
            DateTime start = DateTime.Parse("11/01/1996");
            DateTime stop = DateTime.Parse("12/31/2019");

            return (releaseDate.Date >= start.Date) && (releaseDate.Date <= stop.Date);
            //instance is later than start date and earlier than end date
        }

        //first check that it's a valid positive int, then check logic
        public static bool validateRunTime(string runtime)
        {
            return validateIntNumber(runtime) && Convert.ToInt32(runtime) <= 240;
        }

        //just use validateName multiple times for each of the comma-separated values
        public static bool validateArtists(string artists)
        {
            bool tempBool = true;
            string[] artistArr = artists.Split(',');
            foreach (string artist in artistArr)
            {
                tempBool = validateName(artist.Trim(' '));

                if (tempBool == false)
                {
                    break;
                }
            }

            return tempBool;
        }

        //just make sure they are comma-separated values
        public static bool validateInstruments(string instruments)
        {
            Regex regex = new Regex("^[^\\W0-9][\\w+\\s,-]+[^\\W0-9]$");
            return regex.IsMatch(instruments);
        }


    }
}
