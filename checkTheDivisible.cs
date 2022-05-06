using System;

namespace CheckTheDivisible
{
    class Program{
        static Boolean is_divisible(long number){
            long temp;
            int sum = 0;
            int digits;
            temp = number;
            while (number != 0){
                digits = (int) number % 10; // convert long to int and take digits
                sum += digits; // add the per digits end of the while
                number /= 10; // than divide by 10 cause we already take the last digit 
            }
            if (temp % sum == 0){ // Check the temp is divide by sum or not
                return true;
            }else{
                return false;
            }
        }
        public static void Main(){
            long number;
            Console.WriteLine("Please Eneter A number"); 
            number = Convert.ToInt32(Console.ReadLine()); // take a number from user
            if (is_divisible(number) == true){ // If is_divisible returns true Write the Yes else Write NO
                Console.WriteLine("Yes");
            }
            else{
                Console.WriteLine("No");
            }
            
        }
    }
}
