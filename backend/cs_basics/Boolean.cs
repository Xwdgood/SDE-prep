using System;

namespace Boolean{
    public static class Boolean{
        static void Main(string[] args){
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18){
                Console.WriteLine("not old enough to vote...");
            }
            else{
                Console.WriteLine("You are old enough to vote!");
            }
        }
    }
}