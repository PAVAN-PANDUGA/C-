// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the upper limit: ");
//         int limit = int.Parse(Console.ReadLine());
        
//         List<int> primes = GetPrimes(limit);
        
//         Console.WriteLine($"\nPrime numbers up to {limit}:");
//         foreach (int prime in primes)
//         {
//             Console.Write(prime + " ");
//         }
//     }
    
//     static List<int> GetPrimes(int limit)
//     {
//         List<int> primes = new List<int>();
        
//         for (int num = 2; num <= limit; num++)
//         {
//             if (IsPrime(num))
//                 primes.Add(num);
//         }
        
//         return primes;
//     }
    
//     static bool IsPrime(int number)
//     {
//         if (number < 2) return false;
        
//         for (int i = 2; i * i <= number; i++)
//         {
//             if (number % i == 0)
//                 return false;
//         }
        
//         return true;
//     }
// }