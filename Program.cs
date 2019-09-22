using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n2 = 5;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            displayArray(r5);


        }

        public static void printSelfDividingNumbers(int a, int b)
        {
            try
            {
                /*creating a list named 'checkdivisibility' to store the integer values from 'a' to 'b' 
                which are selfdivisible*/
                var checkthedivisibility = new List<int>();
                for (int i = a; i <= b; i++)
                {
                    /*the below if condition will be executed only when an integer returns true in the method 'isselfdividing*/
                    if (isselfdividing(i))
                    {
                        /*adding the self divisible integers to the variable list "checkdivisibility" 
                        using for loop to parse from 'a' to 'b'*/
                        checkthedivisibility.Add(i);

                    }

                }
                for (int i = 0; i < checkthedivisibility.Count; i++)
                {
                    //printing the values from the "checkdivisibility" using for loop and checkdivisibility count as its size
                    Console.Write(checkthedivisibility[i]);
                    //the below if block code will add a comma uptill count-1 to the self divisible numbers
                    if (i < checkthedivisibility.Count - 1)
                    {
                        Console.Write(",");
                    }


                }
                Console.WriteLine("\n");

                //logic to check if the number is self divisible or not
                bool isselfdividing(int z)
                {
                    //take the numbers from z into the temporary variable
                    int temp = z;
                    //check the number is not zero and enter the while loop if not zero
                    while (z != 0)
                    {
                        //remider of 'z' when divided by ten should be added to an integer variable 'rem'
                        int rem = z % 10;
                        /*if the 'rem' is zero 'or' if the reminder is not zero when the actual number placed in 'temp' variable 
                        divided by 'rem'-->then the number is not self divisible and it will not return the number*/
                        /*if the number is self divisible then the below if statement does not execute*/
                        /*example of the logic: 
                         n=128
                         temp=128
                         the condition "128%10==0 or 128%8!=0" is false
                         the condition "12%10==0 or 128%2!=0" is false
                         the condition "1%10==0 or 128%1!=0"  is false
                         Hence 128 is self divisible
                         */
                        if (rem == 0 || temp % rem != 0)
                            return false;
                        //Place the quotient value in z again and go through the while loop untill z not 0
                        z /= 10;

                    }
                    return true;
                }
            }
            catch
            {
                Console.WriteLine("Exception while computing selfdevidingnumbers()");
            }




        }
        public static void printSeries(int n)
        {
            try
            {

                //creating a list "numberinseries" 
                var numbersinseries = new List<int>();
                // the first for loop will run uptill i<=5
                //in the first iteration :i =1 and 1<=5 and it will enter the loop.
                //in the second iteration :i=2 and 2<=5 and it will enter the loop.
                //in the third iteration :i=3 and 3<=5 and it will enter the loop.
                //in the forth iteration :i=4 and 4<=5 and it will enter the loop.
                //in the fifth iteration :i=5 and 5<=5 and it will enter the loop.
                for (int i = 1; i <= n; i++)
                {

                    for (int k = 1; k <= i; k++)
                    {
                        //Adding the number series to the list using the above for loop .
                        //in the first iteration: k=1 and i=1 and it will add the value '1' one time.
                        //in the second iteration:k=1 and i=2 and it will add the value '2' two times.(k=1,2)
                        //in the third iteration:k=1 and i=3 and it will add the value '3' three times.(k=1,2,3)
                        //in the forth iteration:k=1 and i=4 and it will add the value '4' four times.(k=1,2,3,4)
                        //in the fifth iteration:k=1 and i=5 and it will add the value '5' five times.(k=1,2,3,4,5)
                        numbersinseries.Add(i);

                    }


                }

                //Printing the values in the numberseries list using the for loop and the loop is repeated only uptill
                //n-1 i.e.. from i=0 to i=4.
                for (int i = 0; i < n; i++)
                {
                    /*only 5 values from the "numbersinseries" array gets printed even though their are many values in the
                    numberinseries list because n=5*/
                    Console.Write(+numbersinseries[i]);
                    if (i < n - 1)
                    {
                        //Comma will be appended after each number uptill the last but one integer
                        Console.Write(",");
                    }

                }
                Console.WriteLine("\n");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }

        }

        public static void printTriangle(int n)
        {
            try
            {
                //we do not return anything when the value of n <0
                if (n < 0)
                    return;
                //We create an inverted  triangle using the below for loop  and printit.
                //the first for loop will be iterated 5 times from i=5 to i=1
                for (int i = n; i >= 1; i--)
                {
                    //the second for loop block is going to print the spaces
                    //in the first iteration no spaces will get printed as 5>5 is false
                    //in the second iteration one space will get created as 5>4 is true and it will come out of loop
                    //in the third iteration two spaces will get created as 5>3 and 4>3 is true and it will come out of loop
                    //in the forth iteration three spaces will get created as 5>2 and 4>2 and 3>2 is true and it will come out of loop
                    //in the fifvth iteration four spaces will get created as 5>1 and 4>1 and 3>1 and 2>1 is true and it will come out of loop
                    for (int j = n; j > i; j--)
                    {

                        Console.Write("  ");
                    }
                    //the third for loop block is going to print the '*' in inverted triangle shape
                    //in the first iteration the k=1 and i=5 and nine stars will get printed
                    //in the second interation the k=1 and i=4 and seven stars will get printed
                    //in the third interation the k=1 and i=3 and five stars will get printed
                    //in the forth interation the k=1 and i=2 and 3 stars will get printed
                    //in the fifth interation the k=1 and i=1 and 1 star will get printed
                    for (int k = 1; k < 2 * i; k++)
                    {

                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

            }
            catch
            {

                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                //iniatializing the count of stones which are jewels to zero
                int numstonesasjewels = 0;
                //creating a for loop to count the stones which are also jewels.

                for (int i = 0; i < J.Length; i++)
                {
                    for (int j = 0; j < S.Length; j++)
                    {
                        if (J[i] == S[j])
                        {
                            //in the first iteration J[i] is 1 gets compared to all the stones and count increments by 1
                            //in the second iteration j[i] is 3 gets compared to all the stones and count increments by 2
                            //in the third iteration i exceeds the Jewel length and comes out of the loops.
                            //the count gets incremented 3 times as 3 stones are also jewels.
                            numstonesasjewels++;
                        }

                    }
                }
                return numstonesasjewels;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static void displayArray(int[] a)
        {
            /*displayarray method will store all the value of the 'alpha' array stored  in the variable r5
             in main method which contains the common sub array*/
            int i = 0;
            Console.Write("\n[");
            foreach (var commonsubarray in a)
            {
                Console.Write(a[i]);
                if (i < a.Length - 1)
                {
                    //comma gets printed only uptill last but one element in the list 'alpha'
                    Console.Write(",");
                }
                i++;
            }
            Console.Write("]\n");


        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {

            try
            {

                int counter1 = 0, counter2 = 0, i = 0, j = 0, l = 0, m = 0;
                /*the while loop will parse untill either i or j value is less than the length of the arrays.
                The while loop will terminate once i or j value is more  than array length*/
                while (true)
                {
                    //if the element in arr1 and arr2 are equal then
                    if (a[i] == b[j])
                    {
                        //if the 'm' value is zero then the counter2 value should be the value of i else increment i,j,m
                        if (m == 0)
                            counter2 = i;
                        i++;
                        j++;
                        m++;


                    }
                    else

                    {

                        /*if the value of the element in 'a' is lesser than 'b' then 
                         * increment the i value
                         * else increment the j value*/
                        if (a[i] < b[j])

                            i++;
                        else
                            j++;

                        if (counter1 <= counter2 && m >= l)
                        {
                            
                            counter1 = counter2;
                            l = m;
                        }
                        m = 0;
                        
                    }
                    //break the while loop when below condition is satisfied of the 'i' and 'j' values.
                    //The loop will break when j=6 which is greater than array 'b' length
                    if (i >= a.Length || j >= b.Length)
                        break;
                }
                /*the below if condition check for the greatest subarray and initilizes the value of counter1 and l*/
                if (counter1 <= counter2 && m >= l)
                {

                    counter1 = counter2;
                    l = m;
                }



                /*for the arrays given in the main method .the value of l,m,i,j,counter1,counter2 will 
                be as below after going through the above while loop:
                l=2,m=0,i=2,j=6,counter1=0,counter2=2*/

                while (l > 0)
                {
                    /*creating a integer list which can store the values of a sub array using the foreach loop 
                    and returning the array alpha to the method .And the values in alpha gets printed using 
                    the displayarray method*/
                    int[] alpha = new int[l];
                    int z = 0;
                    foreach (var item in a)
                    {
                        if (z < l)
                        {
                            alpha[z] = a[counter1 + z];
                            z++;
                        }
                    }
                    return alpha;

                }

            }
            catch (Exception)
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
            return null;
        }


    }
}
