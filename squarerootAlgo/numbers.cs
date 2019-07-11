using System;
using System.Collections.Generic;
using System.Text;

namespace squarerootAlgo
{

    public class numbers
    {

        public void SquareRoot(int number)
        {

            if ((number % 1) == 0)
            {
                Double temp = (Math.Sqrt(number));


                if ((temp % 1) == 0)
                {
                    Console.WriteLine("the square root of the number " + number + " is " + temp);
                }
                else
                {
                    Console.WriteLine("not a whole number");

                }

            }

            else
            {
                Console.WriteLine("banana");
            }
        }


        public void ContinuesSquareRoot(int number)
        {
            Double temp = number;
            if ((temp % 1) == 0)

            {
                do
                {
                    if ((temp % 1) == 0)
                    {
                        temp = Math.Sqrt(temp);

                        if ((temp % 1) == 0)
                        {
                            Console.WriteLine(temp);
                        }
                        else
                        {

                            break;

                        }


                    }
                    else
                    {
                        break;
                    }


                }
                while()
                
                else
                    {

                        Console.WriteLine("not a whole number");
                    }
                
                
               
            }
        }
    }
}
        
    









           




        
    

        

      
    

