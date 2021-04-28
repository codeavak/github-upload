using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace TestProject
{
    // TODO: Implement Code
    /*
     * In this section, we explore .NET regex class, operations and purpose
     */

    [TestClass]
    public class RegularExpressionOperationsShell
    {        
        [TestMethod]
        public void PatternRepresentation()
        {
            // Always use a literal string for regex pattern

            // Literal String and Regular String
            // regular string 
            //  -> embedded special characters are interpreted to escape, 
            //     you need add a backslash "\"
        }

        [TestMethod]
        public void IsMatch()
        {
            // Regex.IsMatch - Check if there is a match
            string pattern = @"\d+";
            string text = "42 is my lucky number";
            Assert.IsTrue(Regex.IsMatch(text, pattern));
        }

        // Input Validation - Check if a text is integer
        // Write Unit Tests with positive and negative test cases
        public bool IsInteger(string text)
        {
            // Using regex,  implement logic to check if the 
            // given text is an integer
            // use Regex.IsMatch
            string pattern = @"^\d+$";
            return Regex.IsMatch(text, pattern);
            
        }

        [TestMethod]
        public void IsIntegerTest()
        {
            string numStr = "1234";
            Assert.IsTrue(IsInteger(numStr));
            string notnumStr = "ababababa";
            Assert.IsFalse(IsInteger(notnumStr));
        }

        [TestMethod]
        public void IntegerUnitTest()
        {
            string[] passList = { "123", "456", "900", "0900" };
            string[] failList = { "abc", "", ":", "ab92", "92ab","1 2 3",@"1\t2"};

            //integers misclassified as non-integer
            List<string> falseNegative = new List<string>();
            //non-integers classified as integer
            List<string> falsePositive = new List<string>();

            foreach(string s in passList)
            {
                if (!IsInteger(s))
                    falseNegative.Add(s);
            }
            foreach(string s in failList)
            {
                if (IsInteger(s))
                    falsePositive.Add(s);
            }

            Assert.AreEqual(falseNegative.Count, 0);
            Assert.AreEqual(falsePositive.Count, 0);

            
        }

            [TestMethod]
        public void FirstMatch()
        {
            // Use Regex.Match to retrieve matching substring
        }

        [TestMethod]
        public void IterateMatch()
        {
            // Use Regex.Match to iterate all matches
        }

        [TestMethod]
        public void IterateMatches()
        {
            // Use Regex.Matches to iterate all matches
        }

        [TestMethod]
        public void GroupsIndexed()
        {
            // Access Group using index
            string pattern=@"(?<year>\d{4})(?<month>\d{2})(?<day>\d{2})";
            string text="your last visit date: 20210217";
            var matches = Regex.Match(text,pattern);
            var namesGroups = new string[] { "year", "month", "day" };
            foreach(var name in namesGroups)
            {
                
                
                    Console.WriteLine($"{matches.Groups[name].Value}");
                }
            
        }

        [TestMethod]
        public void GroupsNamed()
        {
            // Access Group using name
        }

        [TestMethod]
        public void Replace()
        {
            // Use Regex.Replace method to find and replace
            // Reformat date YYYYMMDD => MM-DD-YYYY

            string pattern = @"(?<year>\d{4})(?<month>\d{2})(?<day>\d{2})";
            string text = "your last visit date: 20210217";

            string replacePattern = @"${month}-${day}-${year}";
            var replaced=Regex.Replace(text, pattern, replacePattern);
            Console.WriteLine(replaced);
        }

        [TestMethod]
        public void ReplaceCustom()
        {
            // Use Regex.Replace method and custom function 
            // To find and replace
            // Reformat date YYYYMMDD => MMM-DD-YYYY
        }


        [TestMethod]
        public void SplitExample()
        {
            // Use Regex.Split method to split text based on regex pattern
        }
    }
}
