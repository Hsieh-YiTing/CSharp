
using System.Runtime.InteropServices;

namespace class_0403
{
    internal class Program
    {
        public static void ex_3_1_for()
        {
            // 輸入五個整數，求五個整數和，使用for
            Console.WriteLine("輸入五個值");
            int sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"第{i}個數值為");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"答案是{sum}");
            Console.ReadKey();
        }
        public static void ex_3_1_while()
        {
            // 3-1 輸入五個整數，求五個整數和，使用while
            Console.WriteLine("輸入五個值");
            int sum = 0;
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine($"第{i}的數值為");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                i++;
            }
            Console.WriteLine($"答案是{sum}");
            Console.ReadKey();
        }
        public static void ex_3_2_for()
        {
            // 3-2 輸入n個整數，求n個整數和，使用for
            Console.WriteLine("輸入要計算的數值");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"第{i}個數值");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"答案為{sum}");
            Console.ReadKey();
        }
        public static void ex_3_2_while()
        {
            // 3-2 輸入n個整數，求n個整數和，使用while
            Console.WriteLine("輸入要計算的數值");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 0;

            while (i < n)
            {
                Console.WriteLine($"第{i + 1}個數值");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                i++;
            }
            Console.WriteLine($"答案為{sum}");
            Console.ReadKey();
        }
        public static void ex_3_3_for()
        {
            // 3-3 輸入n個正整數後求其中最大值，使用for
            Console.WriteLine("請輸入要比較的數量");
            int compareNum = Convert.ToInt32(Console.ReadLine());
            int maxNum = 0;

            for (int i = 1; i <= compareNum; i++)
            {
                Console.WriteLine($"輸入第{i}個值");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            Console.WriteLine($"最大值為{maxNum}");
            Console.ReadKey();
        }
        public static void ex_3_3_while()
        {
            // 3-3 輸入n個正整數後求其中最大值，使用while
            Console.WriteLine("請輸入要比較的數量");
            int compareNum = Convert.ToInt32(Console.ReadLine());
            int maxNum = 0;
            int i = 0;

            while (i < compareNum)
            {
                Console.WriteLine($"輸入第{i + 1}個值");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > maxNum)
                {
                    maxNum = num;
                }
                i++;
            }
            Console.WriteLine($"最大值為{maxNum}");
            Console.ReadKey();
        }
        public static void ex_3_4_for()
        {
            // 3-4 有N個正整數，求最大奇數值，使用for
            Console.WriteLine("輸入正整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int maxNum = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"輸入第{i}的值");
                int input_3_4 = Convert.ToInt32(Console.ReadLine());

                if (input_3_4 % 2 != 0 && input_3_4 > maxNum)
                {
                    maxNum = input_3_4;
                }
                else if (input_3_4 % 2 == 0)
                {
                    Console.WriteLine("輸入的值為偶數，請重新輸入");
                    i--;
                    continue;
                }
            }
            Console.WriteLine($"最大值為{maxNum}");
            Console.ReadKey();
        }
        public static void ex_3_4_while()
        {
            // 3-4 有N個正整數，求最大奇數值，使用while
            Console.WriteLine("輸入正整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int maxNum = 0;
            int i = 1;

            while (i <= num)
            {
                Console.WriteLine($"輸入第{i}的值");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input % 2 != 0 && input > maxNum)
                {
                    maxNum = input;
                }
                else if (input % 2 == 0)
                {
                    Console.WriteLine("輸入的值為偶數，請重新輸入");
                    continue;
                }
                i++;
            }
            Console.WriteLine($"最大值為{maxNum}");
            Console.ReadKey();
        }
        public static void ex_3_5_for()
        {
            // 3-5 求N階乘(N!)，由2依序乘到N，使用for
            Console.WriteLine("輸入要計算的階乘");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 2; i <= inputNum; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"{inputNum}的乘積為{factorial}");
            Console.ReadKey();
        }
        public static void ex_3_5_while() 
        {
            // 3-5 求N階乘(N!)，由2依序乘到N，使用while
            Console.WriteLine("輸入要計算的階乘");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            int i = 2;

            while (i <= inputNum)
            {
                factorial *= i;
                i++;
            }
            Console.WriteLine($"{inputNum}的乘積為{factorial}");
            Console.ReadKey();
        }
        public static void ex_3_6_for() 
        {
            //3-6 九九乘法表，使用for
            for (int x = 1; x <= 9; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    int result = x * y;
                    Console.WriteLine($"{x} * {y} = {result}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static void ex_3_6_while()
        {
            // 3-6 九九乘法表，使用while
            int x = 1;
            while (x <= 9)
            {
                int y = 1;
                while (y <= 9)
                {
                    int result = x * y;
                    Console.WriteLine($"{x} * {y} = {result}");
                    y++;
                }
                Console.WriteLine();
                x++;
            }
            Console.ReadKey();
        }
        public static void ex_3_7_for()
        {
            // 3-7 將乘法表改為3x3格式，使用for
            for (int i = 1; i <= 9; i += 3)
            {
                for (int j = 1; j <= 9; j++)
                {
                    int result_1 = i * j;
                    int result_2 = (i + 1) * j;
                    int result_3 = (i + 2) * j;

                    Console.Write($"{i} * {j} = {result_1,-10}");
                    Console.Write($"{i + 1} * {j} = {result_2,-10}");
                    Console.Write($"{i + 2} * {j} = {result_3,-10}");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static void ex_3_7_while()
        {
            // 3-7 將乘法表改為3x3格式，使用while
            int i = 1;
            while (i <= 9)
            {
                int j = 1;
                while (j <= 9)
                {
                    int result_1 = i * j;
                    int result_2 = (i + 1) * j;
                    int result_3 = (i + 2) * j;

                    Console.Write($"{i} * {j} = {result_1,-10}");
                    Console.Write($"{i + 1} * {j} = {result_2,-10}");
                    Console.Write($"{i + 2} * {j} = {result_3,-10}");
                    Console.WriteLine();
                    j++;
                }
                Console.WriteLine();
                i += 3;
            }
            Console.ReadKey();
        }
        public static void hw_3_1_for() 
        {
            //  3-1 寫一程式，輸入10個整數，求其最小值，使用for
            int num = 10;
            int minNum = int.MaxValue;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum < minNum)
                {
                    minNum = inputNum;
                }
            }
            Console.WriteLine($"最小值為{minNum}");
            Console.ReadKey();
        }
        public static void hw_3_1_while() 
        {
            //  3-1 寫一程式，輸入10個整數，求其最小值，使用while
            int num = 10;
            int minNum = int.MaxValue;
            int i = 1;

            while (i <= num)
            {
                Console.WriteLine($"第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum < minNum)
                {
                    minNum = inputNum;
                }
                i++;
            }
            Console.WriteLine($"最小值為{minNum}");
            Console.ReadKey();
        }
        public static void hw_3_2_for()
        {
            // 寫一程式，輸入N個整數，求其最小值，使用for
            Console.WriteLine("輸入正整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int minNum = int.MaxValue;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum < minNum)
                { 
                    minNum= inputNum;
                }
            }
            Console.WriteLine($"最小值為{minNum}");
            Console.ReadKey();
        }
        public static void hw_3_2_while() 
        {
            // 寫一程式，輸入N個整數，求其最小值，使用while
            Console.WriteLine("輸入正整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int minNum = int.MaxValue;
            int i = 1;

            while (i <= minNum)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum < minNum)
                {
                    minNum = inputNum;
                }
                i++;
            }
            Console.WriteLine($"最小值為{minNum}");
            Console.ReadKey();
        }
        public static void hw_3_3_for()
        {
            // 寫一程式，輸入10個整數，列出其中所有大於12的數字，使用for
            int num = 10;
            List<int> outputNum = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum > 12)
                {
                    outputNum.Add(inputNum);
                }
            }
            Console.WriteLine("大於12的值有");
            foreach (int conformNum in outputNum)
            {
                Console.Write($"{conformNum, -4}");
            }
            Console.ReadKey();
        }
        public static void hw_3_3_while() 
        {
            // 寫一程式，輸入10個整數，列出其中所有大於12的數字，使用while
            int num = 10;
            int i = 1;
            List<int> outputNum = new List<int>();


            while (i <= 10)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum > 12)
                {
                    outputNum.Add(inputNum);
                }
                i++;
            }
            Console.WriteLine("大於12的值有");
            foreach (int conformNum in outputNum)
            {
                Console.Write($"{conformNum,-4}");
            }

            Console.ReadKey();
        }
        public static void hw_3_4_for()
        {
            // 寫一程式，輸入10個整數，列出其中所有大於12的數字的總和，使用for
            int num = 10;
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum > 12)
                { 
                    sum += inputNum;
                }
            }
            Console.WriteLine($"大於12的值總和為{sum}");
            Console.ReadKey();
        }
        public static void hw_3_4_while()
        {
            // 寫一程式，輸入10個整數，列出其中所有大於12的數字的總和，使用while
            int num = 10;
            int sum = 0;
            int i = 1;

            while (i <= num)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum > 12)
                {
                    sum += inputNum;
                }
                i++;
            }
            Console.WriteLine($"大於12的值總和為{sum}");
            Console.ReadKey();
        }
        public static void hw_3_5_for()
        {
            // 3-5 寫一程式，輸入N個數字，求其所有奇數中的最大值，使用for
            Console.WriteLine("輸入整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int maxNum = int.MinValue;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"輸入第{i}個數字");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum % 2 != 0 && inputNum > maxNum) 
                {
                    maxNum = inputNum;
                }
            }
            Console.WriteLine($"最大奇數值為{maxNum}");
            Console.ReadKey();
        }
        public static void hw_3_5_while()
        {
            // 3-5 寫一程式，輸入N個數字，求其所有奇數中的最大值，使用while
            Console.WriteLine("輸入整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int maxNum = int.MinValue;
            int i = 1;

            while (i <= num)
            {
                Console.WriteLine($"輸入第{i}個數字");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum % 2 != 0 && inputNum > maxNum)
                {
                    maxNum = inputNum;
                }
                i++;
            }
            Console.WriteLine($"最大奇數值為{maxNum}");
            Console.ReadKey();
        }
        public static void hw_3_6_for()
        {
            // 寫一程式，輸入N個數字，求其所有正數之平方的加總，使用for
            Console.WriteLine("輸入整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum > 0)
                {
                    sum += (int)Math.Pow(inputNum, 2);
                }
            }
            Console.WriteLine($"正整數的平方總合為{sum}");
            Console.ReadKey();
        }
        public static void hw_3_6_while()
        {
            // 寫一程式，輸入N個數字，求其所有正數之平方的加總，使用while
            Console.WriteLine("輸入整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 1;

            while (i <= num)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum > 0)
                {
                    sum += (int)Math.Pow(inputNum, 2);
                }
                i++;
            }
            Console.WriteLine($"正整數的平方總合為{sum}");
            Console.ReadKey();
        }
        public static void hw_3_7_for()
        {
            // 寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，使用for
            Console.WriteLine("輸入整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            List<int> outputNum = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum < 0)
                {
                    inputNum = Math.Abs(inputNum);
                }
                outputNum.Add(inputNum);
            }
            Console.Write("全部整數(包含轉換後) : ");
            foreach (int value in outputNum)
            {
                Console.Write($"{value, -2}");
            }
            Console.ReadKey();
        }
        public static void hw_3_7_while()
        {
            // 寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，使用while
            Console.WriteLine("輸入整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            List<int> outputNum = new List<int>();

            while (i <= num)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum < 0)
                {
                    inputNum = Math.Abs(inputNum);
                }
                outputNum.Add(inputNum);
                i++;
            }
            Console.Write("全部整數(包含轉換後) : ");
            foreach (int value in outputNum)
            {
                Console.Write($"{value,-2}");
            }
            Console.ReadKey();
        }
        public static void extra_3_1_for()
        {
            // 判斷101-200之間有多少個質數，並輸出所有質數，使用for
            int count = 0;

            for (int num = 101; num <= 200; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    { 
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                { 
                    count++;
                    Console.WriteLine($"{num}為質數");
                }
            }
            Console.WriteLine($"總共有{count}個質數");
        }
        public static void extra_3_1_while()
        {
            // 判斷101-200之間有多少個質數，並輸出所有質數，使用while
            int num = 101;
            int count = 0;

            while (num <= 200)
            {
                bool isPrime = true;
                int i = 2;
                while (i <= Math.Sqrt(num))
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    i++;
                }
                if (isPrime)
                {
                    count++;
                    Console.WriteLine($"{num}為質數");
                }
                num++;
            }
            Console.WriteLine($"總共有{count}個質數");

        }
        public static void extra_3_2_for()
        {
            // 輸入一個數，輸出其質因數，使用for
            Console.WriteLine("輸入一個數字");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{i}為{num}的質因數");
                }
            }
        }
        public static void extra_3_2_while()
        {
            // 輸入一個數，輸出其質因數，使用while
            Console.WriteLine("輸入一個數字");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;

            while (i <= num)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{i}為{num}的質因數");
                }
                i++;
            }
        }
        public static void extra_3_3_for()
        {
            // 求100到300中可以被3與7整除的個數，使用for
            for (int i = 100; i <= 300; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine($"{i}可以被3、7整除");
                }
            }
        }
        public static void extra_3_3_while()
        {
            // 求100到300中可以被3與7整除的個數，使用while
            int i = 100;

            while (i <= 300)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine($"{i}可以被3、7整除");
                }
                i++;
            }
        }
        public static void ex_4_1()
        {
            // 求最大公約數
            Console.WriteLine("輸入第一個整數");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入第二個整數");
            int j = Convert.ToInt32(Console.ReadLine());

            while (j != 0)
            {
                int temp = j;
                j = i % j;
                i = temp;
            }
            Console.WriteLine($"最大公因數為{i}");
        }
        public static void ex_4_2()
        {
            // 計算N個數字的和，檢查i有沒有超過N，超過就不做了
            Console.WriteLine("輸入數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int sum = 0;

            while (i <= num)
            {
                Console.WriteLine($"輸入第{i}個數字");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                sum += inputNum;
                i++;
            }
            Console.WriteLine($"總和為{sum}");
        }
        public static void hw_4_1()
        {
            // 利用while寫一程式求N個數字的最大值
            Console.WriteLine("輸入需求數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int maxNum = int.MinValue;

            while (i <= num)
            {
                Console.WriteLine($"輸入第{i}個值");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum > maxNum)
                { 
                    maxNum = inputNum;
                }
                i++;
            }
            Console.WriteLine($"最大值為{maxNum}");
        }
        public static void hw_4_2()
        {
            // 利用while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。
            Console.WriteLine("輸入數量"); //3
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入起始值"); // 5
            int startNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入間隔"); // 2
            int interval = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int sum = 0;

            while (i <= num)
            {
                sum += startNum;
                startNum += interval;
                i++;
            }
            Console.WriteLine($"等差級數的總合為{sum}");
        }
        public static void hw_4_3()
        {
            // 利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和
            Console.WriteLine("輸入整數數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int sum = 0;
            List<int> minNum = new List<int>();

            while (i <= num)
            {
                Console.WriteLine($"輸入第{i}個數字");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum < 13)
                { 
                    minNum.Add(inputNum);
                    sum += inputNum;
                }
                i++;
            }
            Console.Write("小於13的值有 : ");
            foreach (int value in minNum)
            {
                Console.Write($"{value, -4}");
            }
            Console.WriteLine($"總和為{sum}");
        }
        public static void hw_4_4()
        {
            // 利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字
            Console.WriteLine("輸入數字數量");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while (i <= num)
            {
                Console.WriteLine($"輸入第{i}個數字");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum > 7 && inputNum < 10)
                {
                    Console.WriteLine($"第{i}個值為{inputNum}，符合條件，中止迴圈");
                    break;
                }
                i++;
            }
        }
        public static void hw_4_5()
        {
            // 利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai > bi，即停止，並列印出ai及bi。
            int[ ] a = new int[5];
            int[ ] b = new int[5];
            int i = 0;

            while (i < 5)
            {
                Console.WriteLine($"輸入a{i + 1}的數值");
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"輸入b{i + 1}的數值");
                b[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] > b[i])
                {
                    Console.WriteLine($"a{i + 1}與b{i + 1}的值為{a[i]}與{b[i]}");
                    break;
                }
                else if (i ==4)
                {
                    Console.WriteLine("皆無符合條件");
                }
                i++;
            }
        }
        public static void extra_4_1()
        {
            //Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。
            //假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。
            Console.WriteLine("輸入時間(分鐘)");
            int times = Convert.ToInt32(Console.ReadLine());
            int eaten = 0;
            int minutes = 5;

            while (minutes < times)
            {
                eaten++;
                minutes += 5;
            }
            Console.WriteLine($"Eric總共吃了{eaten}個漢堡");
        }
        public static void extra_4_2()
        {
            // 小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。
            int loan = 5600000;
            int payment = 40000;
            int bonus = 10000; 
            int month = 0;

            while (loan > 0) 
            {
                loan -= payment;
                month++;
                if (month % 12 == 0)
                { 
                    loan -= bonus;
                }
            }
            Console.WriteLine($"需還{month}個月");
        }
        public static void extra_4_3()
        {
            // 系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！猜錯時，要提示是比較大還是比較小。
            Random randomNum = new Random();
            int targetNum = randomNum.Next(1, 101);

            Console.WriteLine("請輸入數字，需猜中數字才會成功");
            int guessNum;
            do
            { 
                guessNum = Convert.ToInt32(Console.ReadLine());
                if (guessNum > targetNum)
                {
                    Console.WriteLine("大於目標值");
                }
                else if (guessNum < targetNum)
                {
                    Console.WriteLine("小於目標值");
                }
                else
                {
                    Console.WriteLine("猜中目標值");
                }
            }
            while (guessNum != targetNum);
        }
        public static void Main(string[] args)
        {
            ex_3_1_for();
            ex_3_1_while();
            ex_3_2_for();
            ex_3_2_while();
            ex_3_3_for();
            ex_3_3_while();
            ex_3_4_for();
            ex_3_4_while();
            ex_3_5_for();
            ex_3_5_while();
            ex_3_6_for();
            ex_3_6_while();
            ex_3_7_for();
            ex_3_7_while();

            hw_3_1_for();
            hw_3_1_while();
            hw_3_2_for();
            hw_3_2_while();
            hw_3_3_for();
            hw_3_3_while();
            hw_3_4_for();
            hw_3_4_while();
            hw_3_5_for();
            hw_3_5_while();
            hw_3_6_for();
            hw_3_6_while();
            hw_3_7_for();
            hw_3_7_while();
            extra_3_1_for();
            extra_3_1_while();
            extra_3_2_for();
            extra_3_2_while();
            extra_3_3_for();
            extra_3_3_while();

            ex_4_1();
            ex_4_2();

            hw_4_1();
            hw_4_2();
            hw_4_3();
            hw_4_4();
            hw_4_5();
            extra_4_1();
            extra_4_2();
            extra_4_3();
        }

    }
}
