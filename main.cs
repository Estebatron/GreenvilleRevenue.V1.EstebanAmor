using System;
using System.Linq;
using System.Collections;
using System.Text;

class Program
{
  static void Main (string[] args)
    {
      
      do
      {

         Console.WriteLine("*************************************");
         Console.WriteLine("*   The Stars Shine In Greenville   *");
         Console.WriteLine("*************************************\n");
         Console.WriteLine("Please enter the following number below from the following menu:\n");
         Console.WriteLine("1.  CALCULATE Greenville Revenue Year-Over-Year");
         Console.WriteLine("2.  Exit");
   
         int input = Convert.ToInt32(Console.ReadLine());
          if (input == 1)
            {
              Console.WriteLine("\nLast years competition has 122 contestants, and this year's has 426 contestants");
              Console.WriteLine("Revenue expected this year is $10,650");
              Console.WriteLine("It is True that this year's competition is bigger than last years\n");
              continue;
            }
          else if (input == 2)
            {
              Console.WriteLine("\nThank you for using the Greenville Revenue App. Goodbye!");
                break;
                 
              }
         else
          {
           Console.WriteLine("\nInvalid input. Please try again.");
            continue;
           }
      }while(true);
    }
  }
    
  
 





  