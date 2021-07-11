using System;
namespace StringApplication {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Enter a String");
            var stringPhrase = Console.ReadLine ();
            Console.WriteLine ($"Entered String : {stringPhrase}");
            Console.WriteLine ("");
            Console.WriteLine ("Following are the permutation values");
            Console.WriteLine ("------------------------------------");

            
            Permute(stringPhrase);
            Console.ReadLine ();
        }

        private void Permute (string phrase) {
            var length = stringPhrase.Length;
            for (int i = 0; i < length; i++) {
                var firstLetter = phrase[i];
                Console.WriteLine (firstLetter);
            }
        }
    }
}