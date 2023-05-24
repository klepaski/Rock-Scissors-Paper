using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Linq;
using task3;
using HMAC = task3.HMAC;

int N = args.Length;
Validation.ValidateArguments(args, N);

while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nLet's start the game!");
    Console.ResetColor();
    var key = HMAC.GenerateSecureKey();
    var computerMove = args[new Random().Next(0, N)];
    var hmac = HMAC.ComputeHMAC(key, computerMove);
    Console.WriteLine("HMAC: " + BitConverter.ToString(hmac));
    PrintMenu(args);
    var userMove = Console.ReadLine();
    if(!Game.HandleMove(args, N, userMove, computerMove, key)) break;
}

// Menu
void PrintMenu(string[] arr)
{
    Console.WriteLine("Available moves:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(i + 1 + " - " + arr[i]);
    }
    Console.WriteLine("0 - Exit \n-1 - Help\n");
    Console.WriteLine("Enter your move: ");
}