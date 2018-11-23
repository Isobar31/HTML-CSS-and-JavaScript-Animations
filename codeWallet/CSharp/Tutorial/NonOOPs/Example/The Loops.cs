class TheLoops
            {
                public void SumOfnNmubersInWhileLoop()
                {
                    Console.Write("n = ");
                    int n = int.Parse(Console.ReadLine());
                    int num = 1;
                    int sum = 1;
                    Console.Write("The sum 1");
                    while (num < n)
                    {
                        num++;
                        sum += num;
                        Console.Write(" + " + num);
                    }
                    Console.WriteLine(" = " + sum);
                }

                public void IsPrime()
                {
                    Console.Write("Enter a positive number: ");
                    int num = int.Parse(Console.ReadLine());
                    int divider = 2;
                    int maxDivider = (int)Math.Sqrt(num);
                    bool prime = true;
                    while (prime && (divider <= maxDivider))
                    {
                        if (num % divider == 0)
                        {
                            prime = false;
                        }
                        divider++;
                    }
                    Console.WriteLine("Prime? " + prime);
                }

                public void NFactorial()
                {
                    Console.WriteLine("Enter a positive integer number and get its factorial");
                    long n = long.Parse(Console.ReadLine());
                    Console.Write("The factorial of \"{0}\" is ", n);
                    //"decimal" is the biggest C# type that can hold integer values
                    BigInteger factorial = 1;

                    // Perform an "infinite loop"
                    while (true)
                    {
                        if (n <= 1)
                        {
                            break;
                        }
                        factorial *= n;
                        n--;
                    }
                    Console.WriteLine(factorial);
                }

                public void DoWhileFactprial() //This method is not so correct as the while loop because when n = 0 it gives zero result due to the type of loop.
                {
                    Console.Write("n = ");
                    int n = int.Parse(Console.ReadLine());
                    decimal factorial = 1;
                    do
                    {
                        factorial *= n;
                        n--;
                    } while (n > 0);
                    Console.WriteLine("n! = " + factorial);
                }

                public void ForLoopWithTwoInitials()
                {
                    Console.WriteLine("Enter length of the \"i\"");
                    int length = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("\"i\" must not go more than {0}", length);
                    Console.WriteLine();

                    for (int i = 1, sum = 1; i <= length; i = i * 2, sum += i)
                    {
                        Console.WriteLine("i={0}, sum={1}", i, sum);
                    }
                }

                public void Power()
                {
                    Console.Write("Whole number = ");
                    int numner = int.Parse(Console.ReadLine());
                    Console.Write("Power = ");
                    int power = int.Parse(Console.ReadLine());
                    BigInteger result = 1;
                    for (int i = 0; i < power; i++)
                    {
                        result *= numner;
                    }
                    Console.WriteLine();
                    Console.WriteLine("{0}^{1} is = {2:N2}", numner, power, result);
                }

                public void ForLoopWithSeveralVariables()
                {
                    int x, y;
                    Console.Write("Small = ");
                    int small = int.Parse(Console.ReadLine());
                    Console.Write("Large = ");
                    int large = int.Parse(Console.ReadLine());

                    for (x = small, y = large; x < y; x++, y--)
                    {                       
                        Console.WriteLine("Small: {0};    Large: {1}", x, y);
                    }
                }

                public void SumOfOddNumbersNotDivisibleBy7WithOperatorContinue()
                {                    
                    Console.WriteLine("Enter the upper limit of a number and get the sum of the odd numbers not divisible by 7 from 1 to entered number");
                    int n = int.Parse(Console.ReadLine());
                    int sum = 0;
                    int sum2 = 0;
                    int totalSum = 0;

                    Console.Write("Odd numbers not divisible by 7 are: ");
                    for (int i = 1; i <= (n-2); i += 2)
                    {                        
                        if (i % 7 == 0)
                        {                                             
                            continue;                         
                        }
                        Console.Write("{0}, ", i);
                        sum += i;
                    }

                    if (((n-1) % 2 != 0) && ((n - 1) % 7 != 0))
                    {
                        Console.Write("{0}. ", (n - 1));
                        sum2 += (n - 1);
                    }

                    else if ((n % 2 != 0) && (n % 7 != 0))
                    {
                        Console.Write("{0}. ", n);
                        sum2 += n;
                    }

                    else
                    {
                        Console.Write(".");                        
                    }

                    totalSum = sum + sum2;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Their sum is = " + totalSum);                    
                }

                public void ForeachLoopsExamples()
                {
                    //The foreach loop is used in array.
                    int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };

                    Console.WriteLine("  Array of numbers");
                    foreach (int i in numbers)
                    {
                        Console.Write(" " + i);
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("  Array of cities");
                    Console.WriteLine();

                    string[] towns = {"London", "Paris", "Milan", "New York"};
                    foreach (string town in towns)
                    {
                        Console.Write(" " + town);
                    }
                }

                public void NestedLoopsExample()
                {
                    Console.WriteLine("Enter the number of rows");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int row = 1; row <= n; row++)
                    {
                        for (int col = 1; col <= row; col++)
                        {
                            Console.Write(col + " ");
                        }
                        Console.WriteLine();
                    }
                }

                public void PrimeWithForAndWhileLoops()
                {
                    Console.WriteLine("Enter the lower and upper limits to obtain the prime numbers with the range.");
                    Console.WriteLine();
                    Console.WriteLine("Lower limit");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Upper limit");
                    int m = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("The prime numbers within {0} and {1} are:", n, m);                   

                    for (int num = n; num <= m; num++)
                    {
                        bool prime = true;
                        int divider = 2;
                        int maxDivider = (int)Math.Sqrt(num);
                        while (divider <= maxDivider)
                        {
                            if (num % divider == 0)
                            {
                                prime = false;
                                break;
                            }
                            divider++;
                        }
                        if (prime)
                        {
                            Console.Write(" " + num);
                        }
                    }                    
                }

                public void MultiForLoop()
                {
                    Console.WriteLine("Enter the number of rows needed.");                  
                    int iteration = int.Parse(Console.ReadLine());

                    for (int a = 1; a <= iteration; a++)
                    {
                        for (int b = 0; b <= iteration; b++)
                        {
                            for (int c = 0; c <= iteration; c++)
                            {
                                for (int d = 0; d <= iteration; d++)
                                {
                                    if ((a + b) == (c + d))
                                    {
                                        Console.WriteLine(
                                        " " + a + " " + b + " " + c + " " + d);
                                    }
                                }
                            }
                        }
                    }
                }

                public void Lottery6By49UsingMultipleForLoop()
                {
                    for (int i1 = 1; i1 <= 44; i1++)
                    {
                        for (int i2 = i1 + 1; i2 <= 45; i2++)
                        {
                            for (int i3 = i2 + 1; i3 <= 46; i3++)
                            {
                                for (int i4 = i3 + 1; i4 <= 47; i4++)
                                {
                                    for (int i5 = i4 + 1; i5 <= 48; i5++)
                                    {
                                        for (int i6 = i5 + 1; i6 <= 49; i6++)
                                        {
                                            Console.WriteLine(i1 + " " + i2 + " " +
                                            i3 + " " + i4 + " " + i5 + " " + i6);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
