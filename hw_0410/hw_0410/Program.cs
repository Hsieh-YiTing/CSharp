namespace hw_0410
{
    internal class Program
    {
        public static void ex_0501()
        {
            // 利用一維陣列求10個數字的計算平均值。
            int num = 10;
            int[] inputNum = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"輸入第{i + 1}個值");
                inputNum[i] = Convert.ToInt32( Console.ReadLine() );
            }
            Console.WriteLine($"平均值為 : {inputNum.Average()}");
        }
        public static void ex_0502()
        {
            // 利用一維陣列求10個數字的最大值。
            int num = 10;
            int[] inputNum = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"輸入第{i + 1}個值");
                inputNum[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"最大值為 : {inputNum.Max()}");
        }
        public static void ex_0503()
        {
            /* 
             搜尋問題：輸入10個數字至A[ ]，再輸入x
             判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值
             若不存在，則告知不存在。
            */
            int num = 10;
            int[] inputNum = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"輸入第{i + 1}個值");
                inputNum[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("輸入要搜尋的數字");
            int searchNum = Convert.ToInt32( Console.ReadLine() );
            bool notFound = true;

            for (int i = 0; i < num; i++)
            {
                if (searchNum == inputNum[i])
                {
                    notFound = false;
                    Console.WriteLine($"與第{i + 1}的值相同");
                }
            }

             if (notFound)
            {
                Console.WriteLine("搜尋的值不相符");
            }
        }
        public static void ex_0504()
        {
            /*
             兩個二維矩陣相加。以陣列模擬矩陣，求兩個2乘3的二維矩陣相加之結果
             第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣
             最後將C矩陣內容顯示出來。
            */

            // 宣告並輸入A矩陣的值
            Console.WriteLine("輸入A矩陣的值(2x3)");
            int[,] matrixA = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"輸入第{i + 1}行的值");
                for (int j = 0; j < 3; j++)
                {
                    matrixA[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //宣告並輸入B矩陣的值
            Console.WriteLine("輸入B矩陣的值(2x3)");
            int[,] matrixB = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"輸入第{i + 1}行的值");
                for (int j = 0; j < 3; j++)
                {
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //將A、B矩陣相加，並賦值給C
            int[,] matrixC = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            // 輸出matrixC
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"matrixC第{i + 1}行的值為 :");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrixC[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static void ex_0505()
        {
            /*
             兩個矩陣相乘。求2乘3的A矩陣乘以3乘1的B矩陣，
             結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來。
             */

            // 宣告A矩陣(2x3)
            Console.WriteLine("輸入A矩陣的值(2x3)");
            int[,] matrixA = new int[2, 3];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                Console.WriteLine($"輸入第{i + 1}行的值");
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // 宣告B矩陣(3x1)
            Console.WriteLine("輸入B矩陣的值(3x1)");
            int[,] matrixB = new int[3, 1];

            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                Console.WriteLine($"輸入第{i + 1}的值");
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // 宣告C矩陣(2x1)
            int[,] matrixC = new int[2,1];
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                Console.WriteLine($"matrixC第{i + 1}的值為");
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    matrixC[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            foreach (int outputNum in matrixC)
            {
                Console.WriteLine($"matrixC的值為{outputNum}");
            }
        }
        public static void hw_0501()
        {
            /* 
                將10個數字讀入A陣列，逐一檢查此陣列
                如A[i] > 5，令A[i] = A[i] - 5，否則A[i] = A[i] + 5
            */
            int num = 10;
            int[] inputNum = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"輸入第{i + 1}的值");
                inputNum[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("輸入的值分別為 : ");
            foreach (int outputNum in inputNum)
            {
                Console.Write($"{outputNum, -4}");
            }
            Console.WriteLine();

            Console.WriteLine("運算後值為 : ");
            for (int i = 0; i < num; i++)
            {
                if (inputNum[i] > 5)
                {
                    inputNum[i] -= 5;
                }
                else 
                {
                    inputNum[i] += 5;
                }
            }
            foreach (int outputNum in inputNum)
            {
                Console.Write($"{outputNum,-4}");
            }
        }
        public static void hw_0502()
        {
            /* 
                將10個數字讀入A陣列，令A[i] = A[i] + i
            */
            int num = 10;
            int[] inputNum = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"輸入第{i + 1}的值");
                inputNum[i] = Convert.ToInt32(Console.ReadLine());
                inputNum[i] += (i + 1);
            }
            Console.WriteLine("inputNum的值分別為 : ");
            foreach (int outputNum in inputNum)
            {
                Console.Write($"{outputNum, -4}");
            }
        }
        public static void hw_0503()
        {
            /* 
                將10個數字讀入A陣列，並建立B陣列
                如果 A[i] >= 0，B[i] = 1，否則B[i] = 0
            */

            int num = 10;
            int[] matrixA = new int[num];
            int[] matrixB = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"輸入matrixA第{i + 1}個值");
                matrixA[i] = Convert.ToInt32(Console.ReadLine());
                if (matrixA[i] >= 0)
                {
                    matrixB[i] = 1;
                }
                else
                {
                    matrixB[i] = 0;
                }
            }

            Console.WriteLine();
            Console.WriteLine("輸出matrixA與B的值");
            Console.WriteLine();
            Console.WriteLine($"matrixA的值為 : ");
            foreach (int outputNum in matrixA)
            {
                Console.Write($"{outputNum,-4}");
            }
            Console.WriteLine();
            Console.WriteLine($"matrixB的值為 : ");
            foreach (int outputNum in matrixB)
            {
                Console.Write($"{outputNum,-4}");
            }
        }
        public static void hw_0504()
        {
            /* 
                將15個數字存入3x5的二維陣列中，
                求每一行及每列數字的和
            */
            int[,] matrixA = new int[3, 5];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                Console.WriteLine($"輸入第{i + 1}行的值");
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    rowSum += matrixA[i, j];
                }
                Console.WriteLine($"第{i + 1}行的和為{rowSum}");
            }

            Console.WriteLine();

            for (int i = 0; i < matrixA.GetLength(1); i++)
            {
                int colSum = 0;
                for (int j = 0; j < matrixA.GetLength(0); j++)
                {
                    colSum += matrixA[j, i];
                }
                Console.WriteLine($"第{i + 1}列的和為{colSum}");
            }
        }
        public static void hw_0505()
        {
            /* 
                將15個數字存入3x5的二維陣列中，
                求每一行及每列數字的最小值
            */
            int[,] matrixA = new int[3, 5];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                Console.WriteLine($"輸入第{i + 1}行的值");
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                int rowMin = int.MaxValue;
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    if (matrixA[i, j] < rowMin)
                    { 
                        rowMin = matrixA[i, j];
                    }
                }
                Console.WriteLine($"第{i + 1}行的最小值為{rowMin}");
            }

            Console.WriteLine();

            for (int i = 0; i < matrixA.GetLength(1); i++)
            {
                int colMin = int.MaxValue;
                for (int j = 0; j < matrixA.GetLength(0); j++)
                {
                    if (matrixA[j, i] < colMin)
                    {
                        colMin = matrixA[j, i];
                    }
                }
                Console.WriteLine($"第{i + 1}列的最小值為{colMin}");
            }
        }
        public static void hw_0506()
        {
            /* 
                輸入兩組數字a1~a5與b1~b5
                求ai + bi
            */
            int num = 5;
            double[] aNum = new double[num];
            double[] bNum = new double[num];

            Console.WriteLine("輸入a1~a5的值");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"a{i + 1}的值為 : ");
                aNum[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("輸入b1~b5的值");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"b{i + 1}的值為 : ");
                bNum[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < num; i++)
            {
                double result = 0;
                result += aNum[i] + bNum[i];
                Console.WriteLine($"aNum{i + 1}與bNum{i + 1}的值為{result}");
            }
        }
        public static void hw_0507() 
        {
            /*
                 輸入兩組數字a1~a5與b1~b5，
                 設x為a的最大值，y為b的最大值，
                 求x、y中最小值
            */

            int num = 5;
            double[] aNum = new double[num];
            double[] bNum = new double[num];

            Console.WriteLine("輸入a1~a5的值");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"a{i + 1}的值為 : ");
                aNum[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("輸入b1~b5的值");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"b{i + 1}的值為 : ");
                bNum[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            double x = aNum.Max();
            double y = bNum.Max();
            double min = Math.Min(x, y);
            Console.WriteLine($"x為{string.Join(", ", aNum)}的最大值, y為{string.Join(", ", bNum)}的最大值");
            Console.WriteLine($"x,y最小值為{min}");
        }
        static void Main(string[] args)
        {
            ex_0501();
            ex_0502();
            ex_0503();
            ex_0504();
            ex_0505();

            hw_0501();
            hw_0502();
            hw_0503();
            hw_0504();
            hw_0505();
            hw_0506();
            hw_0507();
        }
    }
}
