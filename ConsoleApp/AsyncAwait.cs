using System;
using System.Threading;
using System.Threading.Tasks;
public class AsyncAwait {
    public static void Main (string[] args) {
        Console.WriteLine ("Welcome to Async Await program");

        Task task1 =  PrintNumbersAsync();
        Task t2 = SendEmailAsync();

        Console.WriteLine ("Application Terminates");

        Console.ReadLine ();
    }

    public static async Task PrintNumbersAsync() {
        Console.WriteLine ("Printing Started");
        Console.WriteLine ("----------------------------------");
        await Task.Run (() => {
            for (int i = 0; i < 100; i++) {
                Console.WriteLine ("Printing Number: " + i);
                Thread.Sleep (100);
            }
        });
        Console.WriteLine ("Printing Ended");
    }

    public static async Task SendEmailAsync() {
        Console.WriteLine ("Sending Email Started");
        Console.WriteLine ("----------------------------------");
        await Task.Run (() => {
            for (int i = 0; i < 100; i++) {
                Console.WriteLine ("Sending Email: " + i);
                Thread.Sleep (100);
            }
        });
        Console.WriteLine ("Sending Email Ended");
    }
}