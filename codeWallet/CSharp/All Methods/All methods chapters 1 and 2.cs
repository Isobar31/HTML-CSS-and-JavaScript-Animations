public void NumberCount()
        {
            int i;
            int totalNumber = 1001;
            for (i = 1; i <= totalNumber; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void DateAndTime()
        {
            DateTime showMeDate = DateTime.Now;
            Console.WriteLine("The time is " + showMeDate.ToString("hh:mm:ss") + "\nAnd the date is " + showMeDate.ToString("dd:MMMM:yyyy"));
        }

        public void SquareRoot()
        {
            double b;
            string a;
            Console.WriteLine("You are finding the squre root of?");
            a = Console.ReadLine();
            b = Convert.ToInt32(a);
            Console.WriteLine("The square root of " + a + " is " + Math.Sqrt(b));
        }

        public void ShowOddAndEvenNumbers()
        {
            int initial, final;
            final = 101;

            for (initial = 0; initial <= final; initial++)
            {
                if (initial % 2 == 0)
                {
                    Console.Write(initial + " ");
                }
                else
                {
                    Console.Write(" " + -initial + " ");
                }
            }
        }

        public void ShowMinAndMaxValuesOfIntTypes()
        {
            Console.WriteLine(" ");
            Console.WriteLine("******************* The sbyte and byte types ************************************ ");

            Console.WriteLine(" The minimum value that can be stored in sbyte is '" + SByte.MinValue + "' i.e. (-2)^7.");
            Console.WriteLine(" ");
            Console.WriteLine(" The maximum value that can be stored in sbyte is '" + SByte.MaxValue + "' i.e. ((2)^7) - 1).");

            Console.WriteLine(" ");

            Console.WriteLine(" The minimum value that can be stored in byte is " + Byte.MinValue);
            Console.WriteLine(" ");
            Console.WriteLine(" The maximum value that can be stored in byte is '" + Byte.MaxValue + "' i.e. ((2)^8) - 1).");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("******************* The short and ushort types ************************************ ");
            Console.WriteLine(" ");
            Console.WriteLine(" The minimum value that can be stored in short is '" + Int16.MinValue + "' i.e. ((-2)^15).");
            Console.WriteLine(" ");
            Console.WriteLine(" The maximum value that can be stored in short is '" + Int16.MaxValue + "' i.e. ((2)^15) - 1).");

            Console.WriteLine(" ");

            Console.WriteLine(" The minimum value that can be stored in ushort is " + UInt16.MinValue);
            Console.WriteLine(" ");
            Console.WriteLine(" The maximum value that can be stored in ushort is '" + UInt16.MaxValue + "' i.e. ((2)^16) - 1).");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("******************* The int and uint types ************************************ ");
            Console.WriteLine(" ");
            Console.WriteLine(" The minimum value that can be stored in int is '" + Int32.MinValue + "' i.e. ((-2)^31).");
            Console.WriteLine(" ");
            Console.WriteLine(" The maximum value that can be stored in int is '" + Int32.MaxValue + "' i.e. ((2)^31) - 1.");

            Console.WriteLine(" ");

            Console.WriteLine(" The minimum value that can be stored in uint is " + UInt32.MinValue);
            Console.WriteLine(" ");
            Console.WriteLine(" The maximum value that can be stored in uint is '" + UInt32.MaxValue + "' i.e. ((2)^32) - 1).");
            Console.WriteLine(" The default value is 'u0' or 'U0' ");

            Console.WriteLine("******************* The long and ulong types ************************************ ");
            Console.WriteLine(" ");
            Console.WriteLine(" The minimum value that can be stored in long is '" + Int64.MinValue + "' i.e. ((-2)^63).");
            Console.WriteLine(" ");
            Console.WriteLine(" The maximum value that can be stored in long is '" + Int64.MaxValue + "' i.e. ((2)^63) - 1).");
            Console.WriteLine(" The default value is '0l' or '0L' ");

            Console.WriteLine(" ");

            Console.WriteLine(" The minimum value that can be stored in ulong is " + UInt64.MinValue);
            Console.WriteLine(" ");
            Console.WriteLine(" The maximum value that can be stored in ulong is '" + UInt64.MaxValue + "' i.e. ((2)^64) - 1). The BIGGEST int value");
            Console.WriteLine(" The default value is 'u0' or 'U0' ");
        }

        public void ShowMinAndMaxValuesOfRealFloatingTypes()
        {
            Console.WriteLine("******************* The Real floating-point types ************************************ ");
            Console.WriteLine(" ");
            Console.WriteLine(" The minimum value that can be stored in double is '" + Double.MinValue + "'");
            Console.WriteLine(" ");
            Console.WriteLine(" The maximum value that can be stored in double is '" + Double.MaxValue + "'");
            Console.WriteLine(" The default value is '0d' or '0D' ");

            Console.WriteLine(" ");

            Console.WriteLine(" Negative infinity " + Double.NegativeInfinity);
            Console.WriteLine(" Positive infinity " + Double.PositiveInfinity);
            Console.WriteLine(" Invalid values " + Double.NaN);
            Console.WriteLine(" ");

            Console.WriteLine(" Others not real types but included are:");
            Console.WriteLine(" ");
            Console.WriteLine(" Negative infinity " + Single.NegativeInfinity);
            Console.WriteLine(" Positive infinity " + Single.PositiveInfinity);
            Console.WriteLine(" Invalid values " + Single.NaN);
        }

        public void CompareGender()
        {
            bool isMale;           
            string gender;

            Console.WriteLine("You are a male. \"true\" or \"false\"?");
            gender = Console.ReadLine();

            isMale = Convert.ToBoolean(gender);
                     
            if (isMale == true)
            {
                Console.WriteLine("Good! Here comes a male!");
            }           
            
            else
            {
                Console.WriteLine("Goosh! You are a female");
            }
        }

        public void StringToObject()
        {
            string firstName, lastName;
            object fullName;

            Console.WriteLine("Your first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Your last name");
            lastName = Console.ReadLine();

            fullName = firstName + " " + lastName;

            Console.WriteLine();
            Console.WriteLine(fullName);
        }

        public void ObjectToString()
        {
            string firstName, lastName, fullName;
             object name;

            Console.WriteLine("Your first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Your last name");
            lastName = Console.ReadLine();

            fullName = firstName + " " + lastName;

            name = (object)fullName;

            Console.WriteLine();
            Console.WriteLine(name);
        }

        public void HeartShape()
        {
            Console.WriteLine("         oo          oo");
            Console.WriteLine("      o    o        o    o");
            Console.WriteLine("    o        o    o        o");
            Console.WriteLine("  o            oo            o");
            Console.WriteLine(" o                            o");
            Console.WriteLine(" o                            o");
            Console.WriteLine(" o                            o");
            Console.WriteLine("  o                           o");
            Console.WriteLine("   o                         o");
            Console.WriteLine("    o                       o");
            Console.WriteLine("     o                     o");
            Console.WriteLine("      o                   o");
            Console.WriteLine("       o                 o");
            Console.WriteLine("        o               o");
            Console.WriteLine("         o             o");
            Console.WriteLine("          o           o");
            Console.WriteLine("           o         o");
            Console.WriteLine("            o       o");
            Console.WriteLine("             o     o");
            Console.WriteLine("              o   o");
            Console.WriteLine("               o o");
            Console.WriteLine("                o");
        }

        public void IsoscelesTriangle()
        {            
            Console.WriteLine("©");
            ///Since the symbol does not show rather showing c there is notheing
            ///I can do because this version of Visual studio does not support 
            ///such.
        }

        public void SwapTwoValues()
        {
            int firstNumber, secondNumber;

            Console.WriteLine("Enter first number");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------ Before swapping ---------");
            Console.WriteLine();
            Console.WriteLine(" First number is " + firstNumber + " and second number is " + secondNumber);
            Console.WriteLine();
            Console.WriteLine();


            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("------------ After swapping ---------");
            Console.WriteLine();
            Console.WriteLine(" First number is " + firstNumber + " and second number is " + secondNumber);
        
