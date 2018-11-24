class ArrayExample
            {

                public void ExpressionOfArray()
                {
                    Console.WriteLine("Enter the number of array needed.");
                    int arrayNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("The elements in the array are:");
                    int[] arr = new int[arrayNumber];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = i;
                        Console.Write("{0} ", arr[i]);
                    }
                }

                public void GetElementsOfArrayInReversedForm()
                {
                    int[] array = { 1, 2, 3, 4, 5 };
                    // Get array size
                    int length = array.Length;
                    // Declare and create the reversed array
                    int[] reversed = new int[length];
                    // Initialize the reversed array
                    for (int index = 0; index < length; index++)
                    {
                        reversed[length - index - 1] = array[index];
                    }
                    // Print the reversed array
                    for (int index = 0; index < length; index++)
                    {
                        Console.Write(reversed[index] + " ");
                    }
                }

                public void SymmetricArray()
                {
                    Console.Write("Enter a positive integer: ");
                    int n = int.Parse(Console.ReadLine());
                    int[] array = new int[n];
                    Console.WriteLine("Enter the values of the array:");
                    for (int i = 0; i < n; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    bool symmetric = true;
                    for (int i = 0; i < array.Length / 2; i++)
                    {
                        if (array[i] != array[n - i - 1])
                        {
                            symmetric = false;
                            break;
                        }
                    }
                    Console.WriteLine("Is symmetric? {0}", symmetric);
                }

                public void MultiDimesionalArraysample()
                {
                    int[,] matrix =
                            {
                                {1, 2, 3, 4}, // row 0 values
                                {5, 6, 7, 8}, // row 1 value
                            };
                    // Print the matrix on the console
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                }

                public void MultiDimensionalArrayWithDynamicInput()
                {
                    Console.Write("Enter the number of the rows: ");
                    int rows = int.Parse(Console.ReadLine());
                    Console.Write("Enter the number of the columns: ");
                    int cols = int.Parse(Console.ReadLine());

                    int[,] matrix = new int[rows, cols];
                    Console.WriteLine("Enter the cells of the matrix:");

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write("matrix[{0},{1}] = ", row, col);
                            matrix[row, col] = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("The matrix is:");
                    Console.WriteLine();
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(" " + matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                }

                public void SumOf2By2InLargeArray()
                {
                    // Declare and initialize the matrix
                    int[,] matrix = {
                                        { 0, 2, 4, 10, 9, 5 },
                                        { 7, 1, 3, 17, 20, 1 },
                                        { 1, 3, 9, 8, 5, 6 },
                                        { 4, 6, 7, 9, 1, 0 }
                                     };
                    // Find the maximal sum platform of size 2 x 2
                    long bestSum = long.MinValue;
                    int bestRow = 0;
                    int bestCol = 0;
                    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                        {
                            long sum = matrix[row, col] + matrix[row, col + 1] +
                                        matrix[row + 1, col] + matrix[row + 1, col + 1];
                            if (sum > bestSum)
                            {
                                bestSum = sum;
                                bestRow = row;
                                bestCol = col;
                            }
                        }
                    }
                    // Print the result
                    Console.WriteLine("The best platform is:");
                    Console.WriteLine(" {0} {1}",
                    matrix[bestRow, bestCol],
                    matrix[bestRow, bestCol + 1]);
                    Console.WriteLine(" {0} {1}",
                    matrix[bestRow + 1, bestCol],
                    matrix[bestRow + 1, bestCol + 1]);
                    Console.WriteLine("The maximal sum is: {0}", bestSum);
                }

                public void PascalTheoremUsingJaggedArray()
                {
                    Console.Write("Enter the number of height and get the height of the Pascal's Theorem: ");
                    int HEIGHT = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    
                    // Allocate the array in a triangle form
                    long[][] triangle = new long[HEIGHT + 1][];
                    for (int row = 0; row < HEIGHT; row++)
                    {
                        triangle[row] = new long[row + 1];
                    }
                    // Calculate the Pascal's triangle
                    triangle[0][0] = 1;
                    for (int row = 0; row < HEIGHT - 1; row++)
                    {
                        for (int col = 0; col <= row; col++)
                        {
                            triangle[row + 1][col] += triangle[row][col];
                            triangle[row + 1][col + 1] += triangle[row][col];
                        }
                    }
                    // Print the Pascal's triangle
                    for (int row = 0; row < HEIGHT; row++)
                    {
                        Console.Write("".PadLeft((HEIGHT - row) * 2));
                        for (int col = 0; col <= row; col++)
                        {
                            Console.Write("{0,3} ", triangle[row][col]);
                        }
                        Console.WriteLine();
                    }
                }
            }
