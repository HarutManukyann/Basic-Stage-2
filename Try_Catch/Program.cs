using System;

namespace Try_Catch
{
    class Program
    {
        static void OutOfRange() //TASK 1 (IndexOutOfRangeException)
        {
            int[] arr = new int[3] { 1, 2, 3 };
            try
            {
                Console.Write(arr[0] + " ");
                Console.Write(arr[1] + " ");
                Console.Write(arr[2] + " ");
                Console.Write(arr[5] + " ");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Error:{0}", ex.Message);
            }

        }
        static void NullException() //TASK 2 (NullReferenceException)
        {
            UserModel user = null;
            try
            {
                user.FirstName = "Styopa";

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error:{0}", ex.Message);

            }

        }
        static void CombineExceptions()//TASK 3 (Combine exception)
        {
            try
            {
                // array index out of range
                int[] arr = new int[3] { 5, 6, 13 };
                Console.Write(arr[5] + " ");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error:{0}", ex.Message);
            }
            finally
            {
                try
                {
                    // Null reference Exception
                    UserModel user = null;
                    user.FirstName = "Mamikon";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:{0}", ex.Message);
                }
            }

        }
       static void Calc()
        {
            double result;
            double num;

            Console.Write("Enter Number ");
            try
            {
                num = Convert.ToSingle(Console.ReadLine());

                result = (double)Math.Sqrt(num);
                Console.WriteLine("The result is: {0}", result);
            }
            catch (Exception)
            {
                Console.WriteLine("Error, I cannot calculate the Square Root");
            }

        }


        static void Main(string[] args)
        {
            //OutOfRange(); //TASK 1 (IndexOutOfRangeException)
            // NullException();  //TASK 2 (NullReferenceException)
            // CombineExceptions(); //TASK 3 (Combine exception)
            //Calc(); //TASK 4 (Calculation Exeption)
        }
    }
}
