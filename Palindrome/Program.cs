using Utility;

Console.WriteLine("Введите данные:");
var input = Console.ReadLine();
Console.WriteLine($"Вы ввели: {input}");
var result = new PalindromeUtility().CheckIsPalindrome(input);
Console.WriteLine(result ? "палиндром" : "не палиндром");

