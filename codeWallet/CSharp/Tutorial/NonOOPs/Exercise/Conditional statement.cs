class ConditionalStatements
            {
                public void SignOfProductOfThreeRealNumbers()
                {
                    double firstNumber, secondNumber, thirdNumber, product;

                    Console.WriteLine("Enter The first number.");
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter The second number.");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter The third number.");
                    thirdNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    product = firstNumber * secondNumber * thirdNumber;

                    if(product < 0)
                    {
                        Console.WriteLine("The sign is  -");
                    }
                    else
                    {
                        Console.WriteLine("The sign is  +");
                    }
                }

                public void QuaraticEquation()
                {
                    double coeffA, coeffB, constantC, root1, root2;
                    double discriminant, detValue;

                    Console.WriteLine("Enter the coefficient A.");
                    coeffA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the coefficient B.");
                    coeffB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the constant C.");
                    constantC = Convert.ToDouble(Console.ReadLine());

                    detValue = ((coeffB * coeffB) - (4 * coeffA * constantC));
                    discriminant = Math.Sqrt(detValue);

                    if(discriminant < 0)
                    {
                        Console.WriteLine("The equation has no root");
                    }
                    else if(discriminant == 0)
                    {
                        root1 = ((-coeffB) / (2 * coeffA));
                        Console.WriteLine("The root is {0}", root1);
                    }
                    else
                    {
                        root1 = (((-coeffB) + discriminant) / (2 * coeffA));
                        root2 = (((-coeffB) - discriminant) / (2 * coeffA));

                        Console.WriteLine("Root1: {0} and Root2: {1}", root1, root2);
                    }                    
                }
            }
