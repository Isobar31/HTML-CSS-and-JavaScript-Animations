class Exercise3
            {
                public void ThirdDigitOfNumber()
                {
                    int number, firstDigit, secondDigit, thirdDigit;

                    Console.WriteLine("Enter a number");
                    number = Convert.ToInt32(Console.ReadLine());

                    firstDigit = number % 10;
                    secondDigit = (number / 10) % 10;
                    thirdDigit = (number / 100) % 10;

                    if (thirdDigit == 7)
                    {
                        Console.WriteLine("The thrid digit is " + thirdDigit);
                    }
                    else
                    {
                        Console.WriteLine("The thrid digit is not 7 but " + thirdDigit);
                    }
                }

                public void ThirdBitOfNumber()
                {
                    int number;
                    bool thirdBit;

                    Console.WriteLine("Enter a number");
                    number = Convert.ToInt32(Console.ReadLine());

                    thirdBit = (number & 8) != 0;

                    Console.WriteLine(thirdBit);
                }

                public void WeightOfManOnTheMoon()
                {
                    double gEarth, massOfMan, earthWeight, gMoon, moonWeight;

                    Console.WriteLine("Enter weight of man on earth");
                    earthWeight = Convert.ToDouble(Console.ReadLine());

                    gEarth = 9.8;
                    gMoon = 0.17 * gEarth;
                    massOfMan = earthWeight / gEarth;
                    moonWeight = massOfMan * gMoon;

                    Console.WriteLine("The weight of man on the moon is " + moonWeight);
                }

                public void PositionOfPointInACircle(double x, double y, double r)
                {
                    if ((x * x) + (y * y) <= (r * r))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("The point P{" + x + ", " + y + "} is within the circle and \"" + r + "\" is the radius");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("The point P{" + x + ", " + y + "} is not within the circle and \"" + r + "\" is the radius");
                    }
                }

                public void ChangingFourDigitNumber()
                {
                    int number, a, b, c, d, sum;

                    Console.WriteLine("Enter four digit number");
                    number = Convert.ToInt32(Console.ReadLine());

                    a = number % 10;
                    b = (number / 10) % 10;
                    c = (number / 100) % 10;
                    d = (number / 1000) % 10;

                    sum = a + b + c + d;

                    Console.WriteLine("");
                    Console.WriteLine("Sum of the digits = " + sum);
                    Console.WriteLine("Reverse form of the digits is " + a + "" + b + "" + c + "" + d);
                    Console.WriteLine("The last digit in the first " + a + "" + d + "" + c + "" + b);
                    Console.WriteLine("Exchaning the b and c numbers " + d + "" + b + "" + c + "" + a);
                }
            }
