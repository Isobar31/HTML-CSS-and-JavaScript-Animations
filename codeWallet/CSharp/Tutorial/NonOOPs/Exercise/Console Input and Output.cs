class Exercise4
            {
                public void LimitIntervals()
                {
                    int lowLimit, highLimit, divisor, x;

                    Console.WriteLine("Enter an integer lower limit value");
                    lowLimit = Cin.NextInt();
                    Console.WriteLine("Enter an integer higher limit value");
                    highLimit = Cin.NextInt();
                    Console.WriteLine("Enter an integer divisor value");
                    divisor = Cin.NextInt();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("The lower limit is {0}", lowLimit);
                    Console.WriteLine("The higher limit is {0}", highLimit);
                    Console.WriteLine("The divisor is {0}", divisor);
                    Console.WriteLine();
                    Console.WriteLine("The intervals are:");

                    for (x = lowLimit; x <= highLimit; x++)
                    {
                        if (x % divisor == 0)
                        {
                            Console.Write(x + " ");
                        }
                    }
                }

                public void GreaterNumber()
                {
                    double firstNumber;
                    double secondNumber;

                    Console.WriteLine("Enter first number");
                    firstNumber = Cin.NextDouble();
                    Console.WriteLine("Enter second number");
                    secondNumber = Cin.NextDouble();

                    double result = firstNumber > secondNumber ? firstNumber : secondNumber;

                    Console.WriteLine();
                    Console.WriteLine("The greatest number is {0}", result);
                }

                public void GreaterAndSmallerNumbers1()
                {
                    double firstNumber;
                    double secondNumber;

                    Console.WriteLine("Enter first number");
                    firstNumber = Cin.NextDouble();
                    Console.WriteLine("Enter second number");
                    secondNumber = Cin.NextDouble();

                    Console.WriteLine("Greater: {0}", (firstNumber + secondNumber + Math.Abs(firstNumber - secondNumber)) / 2);
                    Console.WriteLine("Smaller: {0}", (firstNumber + secondNumber - Math.Abs(firstNumber - secondNumber)) / 2);
                }

                public void GreaterAndSmallerNumbers2()
                {
                    double firstNumber, secondNumber;

                    Console.WriteLine("Enter 1st number");
                    firstNumber = Cin.NextDouble();
                    Console.WriteLine("Enter 2nd number");
                    secondNumber = Cin.NextDouble();

                    Console.WriteLine();
                    Console.WriteLine("The greatest number is " + Math.Max(firstNumber, secondNumber));
                    Console.WriteLine("The smallest number is " + Math.Min(firstNumber, secondNumber));
                }

                public void GreaterAndSmallerNumbers3()
                {
                    int firstNumber;
                    int secondNumber;

                    Console.WriteLine("Enter first integer number");
                    firstNumber = Cin.NextInt();
                    Console.WriteLine("Enter second integer number");
                    secondNumber = Cin.NextInt();

                    int max = firstNumber - ((firstNumber - secondNumber) & ((firstNumber - secondNumber) >> 31));

                    Console.WriteLine();
                    Console.WriteLine("The greatest number is " + Math.Max(firstNumber, secondNumber));
                    Console.WriteLine("The smallest number is " + Math.Min(firstNumber, secondNumber));
                }

                public void SumofFiveNumbersAndCorrectingWrongInput()
                {
                    int firstNumber, secondNumber, thirdNubmer, fourthNumber, fifthNumber, sum;
                    try
                    {
                        Console.WriteLine("Enter first number");
                        firstNumber = Cin.NextInt();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong entered number. Please, enter an integer number");
                        try
                        {
                            firstNumber = Cin.NextInt();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong entered number. Please, enter an integer number!!!");
                            firstNumber = Cin.NextInt();
                        }
                    }

                    try
                    {
                        Console.WriteLine("Enter second number");
                        secondNumber = Cin.NextInt();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong entered number. Please, enter an integer number");
                        try
                        {
                            secondNumber = Cin.NextInt();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong entered number. Please, enter an integer number!!!");
                            secondNumber = Cin.NextInt();
                        }
                    }

                    try
                    {
                        Console.WriteLine("Enter third number");
                        thirdNubmer = Cin.NextInt();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong entered number. Please, enter an integer number");
                        try
                        {
                            thirdNubmer = Cin.NextInt();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong entered number. Please, enter an integer number!!!");
                            thirdNubmer = Cin.NextInt();
                        }
                    }

                    try
                    {
                        Console.WriteLine("Enter fourth number");
                        fourthNumber = Cin.NextInt();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong entered number. Please, enter an integer number");
                        try
                        {
                            fourthNumber = Cin.NextInt();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong entered number. Please, enter an integer number!!!");
                            fourthNumber = Cin.NextInt();
                        }
                    }
                    try
                    {
                        Console.WriteLine("Enter fifth number");
                        fifthNumber = Cin.NextInt();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong entered number. Please, enter an integer number");
                        try
                        {
                            fifthNumber = Cin.NextInt();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong entered number. Please, enter an integer number!!!");
                            fifthNumber = Cin.NextInt();
                        }
                    }

                    sum = firstNumber + secondNumber + thirdNubmer + fourthNumber + fifthNumber;

                    Console.WriteLine();
                    Console.WriteLine("The entered numbers are: {0}, {1}, {2}, {3} and {4}. Their sum is {5:N2}", firstNumber, secondNumber, thirdNubmer, fourthNumber, fifthNumber, sum);
                }

                public void SumOfnNumbers()
                {
                    int x;
                    double totalNumber, addNumber, sum;
                    sum = 0.0;

                    Console.WriteLine("How many numbers do you want to add?");
                    totalNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    for (x = 1; x <= totalNumber; x++)
                    {
                        try
                        {
                            Console.WriteLine("Add number {0}", x);
                            addNumber = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter number type");
                            try
                            {
                                Console.WriteLine("Add number {0}", x);
                                addNumber = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please enter number type!!!");
                                Console.WriteLine("Add number {0}", x);
                                addNumber = Convert.ToDouble(Console.ReadLine());
                            }
                        }

                        sum = sum + addNumber;
                    }

                    Console.WriteLine();
                    Console.Write("The sum of the numbers is {0:N2}", sum);
                }

                public void GreatestOfFiveNumbers()
                {
                    double firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber;

                    Console.WriteLine("This program compare 5 numbers and prints the greatest of them all");
                    Console.WriteLine();

                    Console.WriteLine("Add number 1");
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Add number 2");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Add number 3");
                    thirdNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Add number 4");
                    fourthNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Add number 5");
                    fifthNumber = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Among the numbers {0}, {1}, {2}, {3}, {4}", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);

                    if ((firstNumber > secondNumber) && (firstNumber > thirdNumber) && (firstNumber > fourthNumber) && (firstNumber > fifthNumber))
                    {
                        Console.WriteLine();
                        Console.WriteLine("The greatest number among them is {0}", firstNumber);
                    }
                    else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber) && (secondNumber > fourthNumber) && (secondNumber > fifthNumber))
                    {
                        Console.WriteLine();
                        Console.WriteLine("The greatest number among them is {0}", secondNumber);
                    }
                    else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber) && (thirdNumber > fourthNumber) && (thirdNumber > fifthNumber))
                    {
                        Console.WriteLine();
                        Console.WriteLine("The greatest number among them is {0}", thirdNumber);
                    }
                    else if ((fourthNumber > firstNumber) && (fourthNumber > secondNumber) && (fourthNumber > thirdNumber) && (fourthNumber > fifthNumber))
                    {
                        Console.WriteLine();
                        Console.WriteLine("The greatest number among them is {0}", fourthNumber);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("The greatest number among them is {0}", fifthNumber);
                    }
                }

                public void FibonacciSequence()
                {
                    Console.WriteLine("Enter a number to get its Fibonacci iterative values");
                    int number = Convert.ToInt32(Console.ReadLine());

                    Fibonacci_Iterative(number);
                }

                private void Fibonacci_Iterative(int len)
                {
                    int a = 0, b = 1, c = 0;

                    Console.Write("{0} {1}", a, b);
                    for (int i = 2; i < len; i++)
                    {
                        c = a + b;
                        Console.Write(" {0}", c);
                        a = b;
                        b = c;
                    }
                }

                public void SumOfFractionalSequence()
                {
                    Console.WriteLine("Enter a number to get the sum of the fraction sequence.");
                    int number = Convert.ToInt32(Console.ReadLine());

                    FractionalSequence(number);
                }

                private void FractionalSequence(int length)
                {
                    int firstNumber, numerator, counter;
                    double fraction, fractionLength;
                    double totalSum = 0.0;
                    double sumOfFraction = 0.0;

                    firstNumber = 1;
                    numerator = 1;

                    Console.Write("The sequence is {0}, ", firstNumber);
                    for (counter = 2; counter <= (length - 1); counter++)
                    {
                        if (counter % 2 == 0)
                        {
                            fraction = ((double)numerator / (double)counter);
                        }
                        else
                        {
                            fraction = -((double)numerator / (double)counter);
                        }

                        sumOfFraction += fraction;

                        Console.Write("{0:0.000}, ", fraction);
                    }

                    if (length % 2 == 0)
                    {
                        fractionLength = ((double)numerator / (double)counter);
                    }
                    else
                    {
                        fractionLength = -((double)numerator / (double)counter);
                    }
                    Console.WriteLine("{0}.", fractionLength);

                    totalSum = firstNumber + sumOfFraction + fractionLength;

                    Console.WriteLine();
                    Console.WriteLine("The sum of the sequence is {0:0.000}", totalSum);
                }
            }
