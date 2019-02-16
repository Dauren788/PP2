using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace A
{
    class Program
    {
        static bool IsPrime(int n) //булева функция
        {
            if (n == 1) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false; 
            }
            return true; 
        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int s = int.Parse(n); 
            string k = Console.ReadLine();
            string[] arr = k.Split(); 
            int cnt = 0; //создаем счетчик
            for (int i = 0; i < arr.Length; i++)
            {
                int num = int.Parse(arr[i]);
                if (IsPrime(num)) //юз функция 
                {
                    cnt++; 
                }
            }
            Console.WriteLine(cnt); 
            for (int i = 0; i < arr.Length; i++) 
            {
                int num = int.Parse(arr[i]); 
                if (IsPrime(num)) 
                {
                    Console.Write(num);//show the prime number
                    Console.Write(' ');
                }
            }
        }
    }
}