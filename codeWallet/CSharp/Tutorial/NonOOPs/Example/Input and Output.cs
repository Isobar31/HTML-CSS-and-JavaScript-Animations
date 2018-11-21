class ConsoleInputAndOutput
            {
                public void StandardNumericFormats()
                {
                    //The output is based on the location of this OS. E.g now I am in Ukraine.

                    Console.WriteLine("{0:C2}", 123.456);
                    Console.WriteLine("{0:D6}", -1234);
                    Console.WriteLine("{0:E2}", 123);
                    Console.WriteLine("{0:F2}", -123.456);
                    Console.WriteLine("{0:N2} and {1:N2}", 1234567.8, 2785445718227.2);
                    Console.WriteLine("{0:P}", 0.456);
                    Console.WriteLine("{0:X}", 254);
                }

                public void CustomNumericFormats()
                {
                    Console.WriteLine("{0:0.000}", 1.567);
                    Console.WriteLine("{0:#.####}", 0.2348);
                    Console.WriteLine("{0:#####}", 12345.67);
                    Console.WriteLine("{0:(0#) ### ## ##}", 12345456);
                    Console.WriteLine("{0:##%}", 0.234);

                    //These are few. The rest can be easily checked on MSDN.
                }

                public void CustomDateFormats()
                {
                    DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);

                    //Using the English American standard.
                    Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
                    Console.WriteLine("{0:d.MM.yy}", d);

                    //These are few. The rest can be easily checked on MSDN.
                }

                public void FormatStringEnumeration()
                {
                    Console.WriteLine("{0:G}", DayOfWeek.Wednesday);
                    Console.WriteLine("{0:D}", DayOfWeek.Wednesday);
                    Console.WriteLine("{0:X}", DayOfWeek.Wednesday);
                }

                public void ChangingLocalization()
                {
                    DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);

                    //The Us culture
                    Console.WriteLine("**************** The US culture ************");
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");

                    Console.WriteLine("{0:N}", 1234.56);
                    Console.WriteLine("{0:D}", d);
                    Console.WriteLine();
                    Console.WriteLine();

                    //The bulgarian culture
                    Console.WriteLine("***************** The Bulgarian culture ***********");
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("bg-BG");

                    Console.WriteLine("{0:N}", 1234.56);
                    Console.WriteLine("{0:D}", d);
                    Console.WriteLine();
                    Console.WriteLine();

                    //The ukrainian culture
                    Console.WriteLine("***************** The Ukrainian culture ***********");
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ua-UA");

                    Console.WriteLine("{0:N}", 1234.56);
                    Console.WriteLine("{0:D}", d);
                    Console.WriteLine();
                    Console.WriteLine();

                    //The Nigerian culture
                    Console.WriteLine("***************** The Nigerian culture ***********");
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ng-NG");

                    Console.WriteLine("{0:N}", 1234.56);
                    Console.WriteLine("{0:D}", d);

                    //In further studies I need to find out why the localization does not change.
                }

                public void ParsingDataTypes()
                {
                    Console.WriteLine("a = ");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("b = ");
                    int b = int.Parse(Console.ReadLine());

                    // Double
                    Console.WriteLine("c = ");
                    double c = double.Parse(Console.ReadLine());

                    Console.WriteLine("d = ");
                    double d = double.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("The sumation of {0} and {1} = {2}", a, b, (a + b));

                    Console.WriteLine();
                    Console.WriteLine("The sumation of the values {0} and {1} = {2}", c, d, (c / d));
                }

                public void TheTryParse()
                {
                    string str = Console.ReadLine();
                    int intValue;
                    bool parseSuccess = Int32.TryParse(str, out intValue); //The TryParse method of parsing uses multiple parameters.
                    Console.WriteLine(parseSuccess ?
                    "The square of the number is " + intValue * intValue + "."
                    : "Invalid number!");
                }

                public void KeyInfo()
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine("Character entered: " + key.KeyChar);
                    Console.WriteLine("Special keys: " + key.Modifiers);
                }
            }
