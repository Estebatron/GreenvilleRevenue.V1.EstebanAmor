using System;


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
              Console.WriteLine("Input number of contestants at last year's competition");
              int lastYear = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Input number of contestants at this year's competition");
              int thisYear = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("\nLast years competition had " + lastYear +" contestants, and this year's has " + thisYear + " contestants");
              Console.WriteLine("Revenue expected this year is $10,650");
              Console.WriteLine("It is " + (thisYear > lastYear) + " that this year's competition is bigger than last years\n");
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
    
  
 





  