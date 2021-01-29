using System.Text;
using System;
namespace string_function
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string firstname;
                string lastname;


                firstname = "Steven";
                lastname = "Clark";

                

                string nameClone;
                nameClone = firstname.Clone().ToString() + lastname.Clone().ToString();
                Console.WriteLine(nameClone);
                // Make String Clone
                Console.WriteLine("Compareto : " + firstname.CompareTo(lastname));
                //Compare two string value and returns 0 for true and 1 for false

                Console.WriteLine("Contains: " + firstname.Contains("ven")); //Check whether specified value exists or not in string

                Console.WriteLine("EndsWith: " + firstname.EndsWith("n")); //Check whether specified value is the last character of string
                Console.WriteLine("Equals: " + firstname.Equals(lastname));
                //Compare two string and returns true and false

                string fname = firstname;
                Console.WriteLine(fname == firstname);
                Console.WriteLine("Equals(): " + fname.Equals(firstname));

                object A = "Test";
                char[] values = { 'T', 'e', 's', 't' };
                object B = new string(values);
                Console.WriteLine(A == B);
                Console.WriteLine("Equals(): " + A.Equals(B));


                Console.WriteLine("Hashcode: " + firstname.GetHashCode());
                //Returns HashCode of String

                int a = 5;

                Console.WriteLine("GetType(): " + firstname.GetType() + " " + a.GetType());
                //Returns type of string

                Console.WriteLine("GetTypeCode(): " + firstname.GetTypeCode() + " " + a.GetTypeCode());
                //Returns type of string

                Console.WriteLine(firstname.IndexOf("e")); //Returns the first index position of specified value the first index position of specified value

                Console.WriteLine(firstname.ToLower())`;
                //Covert string into lower case

                Console.WriteLine(firstname.ToUpper());
                //Convert string into Upper case

                Console.WriteLine(firstname.Insert(0, "Hello ")); //Insert substring into string

                Console.WriteLine(firstname.IsNormalized());
                //Check Whether string is in Unicode normalization from C


                Console.WriteLine(firstname.LastIndexOf("e")); //Returns the last index position of specified value

                Console.WriteLine(firstname.Length);
                //Returns the Length of String

                Console.WriteLine(firstname.Remove(4));
                //Deletes all the characters from begining to specified index.

                Console.WriteLine(firstname.Replace('e', 'i')); // Replace the character

                string[] split = firstname.Split(new char[] { 'e' }); //Split the string based on specified value
                foreach (var i in split)
                {
                    Console.WriteLine(i);

                }

                Console.WriteLine(firstname.StartsWith("S")); //Check whether first character of string is same as specified value

                Console.WriteLine(firstname.Substring(2, 4));
                //Returns substring

                Console.WriteLine(firstname.ToCharArray());
                //Converts an string into char array.

                Console.WriteLine(firstname.Trim());
                //It removes starting and ending white spaces from string.

                Console.WriteLine("test" == "Test");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.StackTrace);

            }
        }
    }
}