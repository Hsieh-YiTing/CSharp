namespace HomeWork_0327
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // 習題1-1
            Console.WriteLine("輸入數字a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字d");
            double d = Convert.ToDouble(Console.ReadLine());

            double sum = ((a + b)) / ((c - d)) * d;
            Console.WriteLine("總合為 = " + sum);


            // 習題1-2
            Console.WriteLine("輸入數字a1");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字b1");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字c1");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("輸入數字a2");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字b2");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字c2");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double x_sum = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 *b1) ;
            Console.WriteLine("x的總合為 = " + x_sum);

            double y_sum = (c1 * a1 - c2 * a1) / (b1 * a2 - a1 * b2);
            Console.WriteLine("y的總合為 = " + y_sum);


            // 習題1-3
            Console.WriteLine("輸入數字a3");
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字b3");
            double b3 = Convert.ToDouble(Console.ReadLine());

            double c3_sum = (Math.Pow(a3, 1) + Math.Pow(b3, 2)) / (Math.Pow(a3, 2) - Math.Pow(b3, 2));
            Console.WriteLine("c3總合為 = " + c3_sum);


            // 習題1-4
            Console.WriteLine("輸入數字a4");
            double a4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字b4");
            double b4 = Convert.ToDouble(Console.ReadLine());

            double c4_sum = Math.Sqrt((Math.Pow(a4, 2) + Math.Pow(b4, 2)));
            Console.WriteLine("c4總合為 = " + c4_sum);


            // 習題1-5
            Console.WriteLine("輸入數字a5");
            double a5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字b5");
            double b5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字c5");
            double c5 = Convert.ToDouble(Console.ReadLine());

            double c5_sum = a5 - (b5 + c5) * (3 * a5 - c5);
            Console.WriteLine("c5的總和為" + c5_sum);


            // 習題1-6
            Console.WriteLine("輸入數字a6");
            double a6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入數字b6(負數)");
            double b6 = Convert.ToDouble(Console.ReadLine());

            double c6_sum = Convert.ToDouble((Math.Abs(a6 + b6)));
            Console.WriteLine("c6計算後的絕對值為" + c6_sum);


            // 習題1-7
            Console.WriteLine("輸入要轉換的西元年份");
            int a7 = Convert.ToInt32(Console.ReadLine());
            int b7 = a7 - 1911;
            Console.WriteLine("轉換後年份為民國" + b7 + "年");


            // 習題1-8
            Console.WriteLine("輸入身高(公尺)");
            double a8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("輸入體重(公斤)");
            double b8 = Convert.ToDouble(Console.ReadLine());

            double BMI = b8 / (Math.Pow( a8, 2 ));
            Console.WriteLine("計算後的BMI值為" + BMI);
        }
    }
}