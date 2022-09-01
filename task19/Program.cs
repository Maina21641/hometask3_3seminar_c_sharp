// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number){
//   if (number[0]/number[4]==1 && number[1]/number[3]==1){
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");

bool Palindrome (int num){
    int a = num / 10000;
    int b = num % 10;
    int c = (num / 1000) % 10;
    int d = (num % 100) /10;
    if (a ==b && c == d){
        return true;
    }
    else 
        return false;
    
}
System.Console.WriteLine(Palindrome(12322));