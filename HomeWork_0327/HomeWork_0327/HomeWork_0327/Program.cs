// See https://aka.ms/new-console-template for more information

// 習題2-1
Console.WriteLine("輸入x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入y");
double y = Convert.ToDouble(Console.ReadLine());

if (x > y)
{
    Console.WriteLine(x);
}
else {
    Console.WriteLine(y);
}

// 習題2-2
Console.WriteLine("輸入x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入y2");
double y2 = Convert.ToDouble(Console.ReadLine());

if (x2 > 0 && y2 > 0)
{
    double z2 = 1;
    Console.WriteLine($"z2為{z2}");
}
else if (x2 < 0 && y2 < 0)
{
    double z2 = -1;
    Console.WriteLine($"z2為{z2}");
}
else { 
    double z2 = 0;
    Console.WriteLine($"z2為{z2}");
}

// 習題2-3
Console.WriteLine("輸入x3");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入y3");
double y3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入u3");
double u3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入v3");
double v3 = Convert.ToDouble(Console.ReadLine());

if ((x3 + y3) > (u3 + v3))
{
    double z3 = (x3 - y3);
    Console.WriteLine($"z3為{z3}");
}
else {
    double z3 = (u3 - v3);
    Console.WriteLine($"z3為{z3}");
}

// 習題2-4
Console.WriteLine("輸入x4");
double x4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入y4");
double y4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入u4");
double u4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入v4");
double v4 = Convert.ToDouble(Console.ReadLine());

if ((x4 + y4) / (u4 - v4) >= 2)
{
    double z4 = x4 - y4;
    Console.WriteLine($"z4為{z4}");
}
else {
    double z4 = u4 - v4;
    Console.WriteLine($"z4為{z4}");
}

// 習題2-5
Console.WriteLine("輸入x5");
double x5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入y5");
double y5 = Convert.ToDouble(Console.ReadLine());

if (x5 >= y5)
{
    double z5 = Math.Pow(x5, 2);
    Console.WriteLine($"z5為{z5}");
}
else {
    double z5 = Math.Pow(y5, 2);
    Console.WriteLine($"z5為{z5}");
}

// 習題2-6
Console.WriteLine("輸入數值");
double income = Convert.ToDouble(Console.ReadLine());
double rate, difference;

if (income > 4090000)
{
     rate = 0.4;
     difference = 721100;
}
else if (income > 2180000 && income < 4090000)
{
     rate = 0.3;
     difference = 312100;
}
else if (income > 1090000 && income < 2180000)
{
     rate = 0.21;
     difference = 115900;
}
else if (income > 410000 && income < 1090000)
{
     rate = 0.13;
     difference = 28700;
}
else {
     rate = 0.06;
     difference = 0;
}

double tax = (income * rate) - difference;
Console.WriteLine($"tax為{tax}");

// 習題2-7
Console.WriteLine("輸入x7");
double x7 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入y7");
double y7 = Convert.ToDouble(Console.ReadLine());

if (x7 > 0 && y7 > 0)
{
    Console.WriteLine("1st quadrant\n");
}
else if (x7 > 0 && y7 == 0)
{
    Console.WriteLine("X-axis\n");
}
else if (x7 > 0 && y7 < 0)
{
    Console.WriteLine("4th quadrant\n");
}
else if (x7 == 0 && y7 == 0)
{
    Console.WriteLine("Origin\n");
}
else if (x7 == 0 && y7 != 0)
{
    Console.WriteLine("Y-axis\n");
}
else if (x7 < 0 && y7 > 0) {
    Console.WriteLine("2nd quadrant\n");
}
else if (x7 < 0 && y7 == 0)
{
    Console.WriteLine("X-axis\n");
}
else if (x7 < 0 && y7 < 0)
{
    Console.WriteLine("3th quadrant\n");
}

// 補充習題1
Console.WriteLine("輸入答對題數");
int correctNumber = Convert.ToInt32(Console.ReadLine());
int score;

if (correctNumber > 0 && correctNumber <= 10)
{
    score = correctNumber * 6;
}
else if (correctNumber >= 11 && correctNumber <= 20)
{
    score = 60 + (correctNumber - 10) * 2;
}
else if (correctNumber >= 21 && correctNumber <= 40)
{
    score = 80 + (correctNumber - 20) * 1;
}
else {
    score = 100;
}

Console.WriteLine($"分數為{score}");

// 補充習題2-1
Console.WriteLine("輸入身高(m)");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入體重(kg)");
double weight =  Convert.ToDouble(Console.ReadLine());

double BMI = weight / Math.Pow(height, 2);

if (BMI >= 18.5 && BMI <= 24)
{
    Console.WriteLine("正常");
}
else if (BMI > 24)
{
    Console.WriteLine("過重");
}
else {
    Console.WriteLine("過輕");
}

// 補充習題2-2
Console.WriteLine("輸入x8");
double x8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入y8");
double y8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("輸入z8");
double z8 = Convert.ToDouble(Console.ReadLine());

if (x8 > y8 && y8 > z8) {
    Console.WriteLine($"x8 : {x8} > y8 : {y8} > z8 : {z8}");
}
else if (x8 > y8 && z8 > y8)
{
    Console.WriteLine($"x8 : {x8} > z8 : {z8} > y8 : {y8}");
}
else if (y8 > x8 && x8 > z8)
{
    Console.WriteLine($"y8 : {y8} > x8 : {x8} > z8 : {z8}");
}
else if (y8 > x8 && z8 >x8)
{
    Console.WriteLine($"y8 : {y8} > z8 : {z8} > x8 : {x8}");
}
else if (z8 > x8 && x8 > y8)
{
    Console.WriteLine($"z8 : {z8} > x8 : {x8} > y8 : {y8}");
}
else
{
    Console.WriteLine($"z8 : {z8} > y8 : {y8} > x8 : {x8}");
}

// 補充習題2-3
Console.WriteLine("輸入當月利潤");
double profit = Convert.ToDouble(Console.ReadLine());
double bonus;

if (profit <= 100000)
{
    bonus = profit * 0.1;
}
else if (profit > 1000000 && profit <= 200000)
{
    bonus = 100000 * 0.1 + (profit - 100000) * 0.075;
}
else if (profit > 200000 && profit <= 400000)
{
    bonus = 100000 * 0.1 + 100000 * 0.075 + (profit - 200000) * 0.05;
}
else if (profit > 400000 && profit <= 600000)
{
    bonus = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.05 + (profit - 400000) * 0.03;
}
else if (profit > 600000 && profit <= 1000000)
{
    bonus = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.05 + 200000 * 0.03 + (profit - 600000) * 0.015;
}
else {
    bonus = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.05 + 200000 * 0.03 + 400000 * 0.015 + (profit - 1000000) * 0.01;

}

Console.WriteLine($"發放獎金總數為{bonus}");