// See https://aka.ms/new-console-template for more information

using System;
using System.Text.RegularExpressions;

// ---------function HomeWork---------
void hw_01()
{
    /*
        寫一個function 可以把一般對話框的文字轉成HTML。
        > 轉成 &gt; < 轉成 &lt; \r\n 轉成 <br> | 轉成 &brvbar; 空白 轉成 &nbsp;
    */

    string ConvertText(string outputString)
    {
        outputString = outputString.Replace(">", "&gt;")
                                                 .Replace("<", "&lt;")
                                                 .Replace("\r\n", "<br>")
                                                 .Replace("|", "&brvbar;")
                                                 .Replace(" ", "&nbsp;");

        return outputString;
    }

    void InputString()
    {
        string inputString = string.Empty;

        while (true)
        {
            Console.WriteLine("輸入文字或stop停止程式");
            inputString = Console.ReadLine();

            if (inputString.ToLower() == "stop")
            {
                Console.WriteLine("程式結束");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine(ConvertText(inputString));
            }
            Console.WriteLine();
        }
    }

    InputString();
}
void hw_02()
{
    // 寫一個function，回傳輸入的值是否數字
    bool IsNumber(string input)
    {
        if (double.TryParse(input, out double result))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void InputString()
    {
        string userInput = string.Empty;

        while (true)
        {
            Console.WriteLine("輸入文字或數字，輸入stop程式結束");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "stop")
            {
                Console.WriteLine("程式結束");
                Console.ReadKey();
                break;
            }
            else if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("請重新輸入值");
                continue;
            }
            else
            {
                Console.WriteLine(IsNumber(userInput));
            }
            Console.WriteLine();
        }
    }

    InputString();
}
void hw_03()
{
    // 寫一個function，回傳輸入的值是否符合E-mail格式
    bool IsEmail(string email)
    {
        // 開頭使用@是因為後面有 "\." ，避免轉義字符作用
        Regex regex = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9]+\.[a-zA-Z0-9-.]$");
        return regex.IsMatch(email);
    }

    void InputEmail()
    {
        string userInput = string.Empty;

        while (true) 
        {
            Console.WriteLine("請輸入Email，輸入stop程式結束");
            userInput = Console.ReadLine();

            if (IsEmail(userInput))
            {
                Console.WriteLine($"{userInput}，格式正確");
                Console.WriteLine();
            }
            else if (userInput.ToLower() == "stop")
            {
                Console.WriteLine("程式結束");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("格式錯誤，請重新輸入");
                Console.WriteLine();
                continue;
            }
        }
    }

    InputEmail();
}
void hw_04()
{
    // 寫一個function，回傳輸入的值是否符合手機格式
    bool IsPhoneNumber(string phoneNumber)
    {
        // 定義號碼格式可以為09xxxxxxxx或09xx-xxx-xxx，?表示可選值
        Regex regex = new Regex(@"^09\d{2}-?\d{3}-?\d{3}$");
        return regex.IsMatch(phoneNumber);
    }

    void InputPhoneNumber()
    {
        string userInput = string.Empty;

        while (true)
        {
            Console.WriteLine("請輸入手機號碼，輸入stop程式結束");
            userInput = Console.ReadLine();

            if (IsPhoneNumber(userInput))
            {
                Console.WriteLine($"{userInput}，格式正確");
                Console.WriteLine();
            }
            else if (userInput.ToLower() == "stop")
            {
                Console.WriteLine("程式結束");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("格式錯誤，請重新輸入");
                Console.WriteLine();
                continue;
            }
        }
    }

    InputPhoneNumber();
}
void hw_05()
{
    // 寫一個function，回傳輸入的值是否符合身分證字號格式
    bool IsCorrectID(string ID)
    {
        Regex regex = new Regex(@"^[a-zA-Z]\d{9}$");
        return regex.IsMatch(ID);
    }

    void InputID()
    {
        while (true)
        {
            Console.WriteLine("輸入身分證字號，輸入stop程式結束");
            string userInput = Console.ReadLine();

            if (IsCorrectID(userInput))
            {
                Console.WriteLine($"{userInput}，格式正確");
                Console.WriteLine();
            }
            else if (userInput.ToLower() == "stop")
            {
                Console.WriteLine("程式結束");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("格式錯誤，請重新輸入");
                Console.WriteLine();
                continue;
            }
        }
    }

    InputID();
}
void hw_06()
{
    // 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
    string Text()
    {
        Console.WriteLine("輸入文字");
        string userInput = Console.ReadLine();
        Console.WriteLine();
        return userInput;
    }

    void OverFlow(string replaceString)
    {
            Console.WriteLine("輸入字串上限");
            int limitNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (limitNum >= replaceString.Length)
            {
                Console.WriteLine($"輸出結果為 : {replaceString}");
            }
            else
            {
                replaceString = replaceString.Substring(0, limitNum) + "...";
                Console.WriteLine($"輸出結果為 : {replaceString}");
            }
    }

    string userInput;
    while (true)
    {
        userInput = Text();
        OverFlow(userInput);
        Console.WriteLine();

        if (userInput == "stop")
        {
            Console.WriteLine("程式結束");
            Console.ReadKey();
            break;
        }
    }
}
void hw_07()
{
    // 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式
    void OutputDate()
    {
        while (true)
        {
            Console.WriteLine("輸入西元日期，格式為 : xxxx/xx/xx，輸入stop後程式結束");
            string inputDate = Console.ReadLine();
            Regex regex = new Regex(@"^\d{4}/\d{2}/\d{2}");
            string outputDate = AD_Date(inputDate);
            Console.WriteLine();

            if (regex.IsMatch(inputDate))
            {
                Console.WriteLine($"輸入的日期為 : {inputDate}");
                Console.WriteLine();
                Console.WriteLine($"轉換後日期為 : {outputDate}");
            }
            else if (inputDate.ToLower() == "stop")
            {
                Console.WriteLine("程式結束");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("格式錯誤，請重新輸入");
                Console.WriteLine();
                continue;
            }
            Console.WriteLine();
        }
    }

    string AD_Date(string inputDate)
    {
        DateTime.TryParse(inputDate, out DateTime date);
        int rocYear = date.Year - 1911;
        string rocYearString = $"{rocYear}/{date.Month:D2}/{date.Day:D2}";
        return rocYearString;
    }

    OutputDate();
}
void hw_08()
{
    // 寫一個function，輸入一個日期，把該日期轉成民國年.月.日 星期X 格式
    void OutputDate()
    {
        while (true)
        {
            Console.WriteLine("輸入西元日期，格式為 : xxxx/xx/xx，輸入stop後程式結束");
            string inputDate = Console.ReadLine();
            Regex regex = new Regex(@"^\d{4}/\d{2}/\d{2}");
            string outputDate = AD_Date(inputDate);
            Console.WriteLine();

            if (regex.IsMatch(inputDate))
            {
                Console.WriteLine($"輸入的日期為 : {inputDate}");
                Console.WriteLine();
                Console.WriteLine($"轉換後日期為 : {outputDate}");
            }
            else if (inputDate.ToLower() == "stop")
            {
                Console.WriteLine("程式結束");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("格式錯誤，請重新輸入");
                Console.WriteLine();
                continue;
            }
            Console.WriteLine();
        }
    }

    string AD_Date(string inputDate)
    {
        DateTime.TryParse(inputDate, out DateTime date);
        int rocYear = date.Year - 1911;
        string rocYearString = $"{rocYear}/{date.Month:D2}/{date.Day:D2}";
        string dayOfWeek = date.DayOfWeek.ToString(); // 取得星期幾
        rocYearString += $" ({dayOfWeek})"; // 加入星期幾到轉換後的日期
        return rocYearString;
    }

    OutputDate();
}
void hw_09()
{
    // 寫一個function，回傳輸入的年是否閏年
    void LeapYear()
    {
        while(true) 
        {
            Console.WriteLine("輸入年份或輸入stop停止程式");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int year))
            {
                Console.WriteLine($"{IsLeapYear(year)}");
            }
            else if (input.ToLower() == "stop")
            {
                Console.WriteLine("程式結束");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("請輸入數字");
            }
            Console.WriteLine();
        }
     }

    bool IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    LeapYear();
}
void hw_10()
{ 
    void UserInput()
    {
        Console.WriteLine("輸入手機號碼的最後四位數：");
        string phoneNumber = Console.ReadLine();

        if (phoneNumber.Length >= 4 && int.TryParse(phoneNumber.Substring(phoneNumber.Length - 4), out int lastFourDigits))
        {
            double fortune = CalculateFortune(lastFourDigits);
            Console.WriteLine($"今天的運勢是：{fortune}");
        }
        else
        {
            Console.WriteLine("輸入的手機號碼不符合格式要求（需至少四位數字），請重新輸入。");
        }
    }

    double CalculateFortune(int lastFourDigits)
    {
        double fortune = ((double)lastFourDigits / 80 - Math.Truncate((double)lastFourDigits / 80)) * 80;
        return fortune;
    }

    UserInput();
}


// ---------string HomeWork---------
void hw_11()
{
    // 輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
    while (true) 
    {
        Console.WriteLine("請輸入姓名");
        string userName = Console.ReadLine();
        Console.WriteLine();
        if (userName == "stop")
        {
            Console.WriteLine("程式結束");
            Console.ReadKey();
            break;
        }
        else
        {
            Console.WriteLine($"Hi~{userName}");
        }
        Console.WriteLine();
    }
}
void hw_12()
{
    // 請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。
    string newString = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
    Console.WriteLine("任意輸入文字");
    string userInput = Console.ReadLine();
    bool contains = newString.Contains(userInput);
    Console.WriteLine(contains);
}
void hw_13()
{
    // 輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。
    Console.WriteLine("輸入一段string");
    string input = Console.ReadLine();
    string output = string.Join("-", input.ToCharArray());
    Console.WriteLine(output);
}
void hw_14()
{
    Console.WriteLine("請輸入檔名 : ");
    string input = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("轉換後檔名為  : ");
    string output = input.Insert(input.Length, ".jpg");
    Console.WriteLine(output);
}
void hw_15()
{
    /*
        輸入一個大於五個字的單字，若小於五個字輸出長度不夠
        若大於五個字，則輸出前三個字。Length  Substring()
    */
    Console.WriteLine("輸入大於五個字的單字");
    string input = Console.ReadLine();

    while (input.Length < 5)
    {
        Console.WriteLine("長度不夠，請重新輸入");
        input = Console.ReadLine();
    }

    string output = input.Substring(0, 3);
    Console.WriteLine(output);
}
void hw_16()
{
    /*
        輸入一段字，輸出把輸入的一段字裡面的我，
        改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()
    */
    Console.WriteLine("輸入一段文字 : ");
    string input = Console.ReadLine();
    Console.WriteLine("轉換後為 : ");
    string output = input.Replace("我", "小明");
    Console.WriteLine(output);
}
void hw_17()
{
    // 輸入一串字，顯示輸入幾個字。Length
    Console.WriteLine("輸入一段文字");
    string input = Console.ReadLine();
    Console.WriteLine($"總共輸入了{input.Length}個字");
}
void hw_18()
{
    //連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。
    Console.WriteLine("請輸入十組文字");
    Console.WriteLine();
    string[] input = new string[10];

    for (int i = 0; i < input.Length; i++)
    {
        Console.WriteLine($"第{i + 1}組為 : ");
        string words = Console.ReadLine();

        if (Array.IndexOf(input, words) != -1)
        {
            Console.WriteLine($"{words}已經輸入過了");
        }
        else 
        {
            Console.WriteLine($"{words} 還沒輸入過");
            input[i] = words;
        }
    }

}
void hw_19()
{
    /*
        用字母大小寫來模擬波浪舞的動作後輸出
        比如輸入FiFa，輸出Fifa、fIfa、fiFa、fifA
    */
    Console.WriteLine("請輸入一個單字：");
    string inputWord = Console.ReadLine();

    for (int i = 0; i < inputWord.Length; i++)
    {
        for (int j = 0; j < inputWord.Length; j++)
        {
            if (j == i)
            {
                Console.Write(char.ToUpper(inputWord[j]));
            }
            else
            {
                Console.Write(char.ToLower(inputWord[j]));
            }
        }
        Console.WriteLine();
    }
}
void hw_20()
{
    // 輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。
    Console.WriteLine("請輸入時間 (HH:mm)：");
    string inputTime = Console.ReadLine();

    string[] timeParts = inputTime.Split(':'); // 將輸入的時間按冒號分割成時和分
    if (timeParts.Length == 2 && int.TryParse(timeParts[0], out int hour) && int.TryParse(timeParts[1], out int minute))
    {
        string hourString = (hour % 12 == 0) ? "12" : (hour % 12).ToString(); // 將24小時制轉換為12小時制
        string period = (hour < 12) ? "上午" : "下午"; // 判斷上午或下午

        Console.WriteLine($"輸出結果為：{period}{hourString}點{minute}分");
    }
    else
    {
        Console.WriteLine("輸入的時間格式不正確。");
    }
}
void hw_21()
{
    Console.WriteLine("請輸入要轉換成HTML的字串，以逗號分隔：");
    string input = Console.ReadLine();

    string[] names = input.Split(',');
    string htmlOutput = "<ul>\n";

    foreach (string name in names)
    {
        htmlOutput += $"\t<li>{name}</li>\n";
    }

    htmlOutput += "</ul>";
    Console.WriteLine(htmlOutput);
}
void hw_22()
{
    Console.WriteLine("請輸入5個數字，用空格隔開：");
    string input = Console.ReadLine();

    string[] numbers = input.Split(' ');
    int sum = 0;

    foreach (string numStr in numbers)
    {
        if (int.TryParse(numStr, out int num))
        {
            sum += num;
        }
        else
        {
            Console.WriteLine($"無法將 '{numStr}' 轉換為數字。");
            return;
        }
    }

    Console.WriteLine($"輸入的數字總和是 {sum}");
}
void hw_23()
{
    // 輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
    Console.WriteLine("輸入一段文字");
    string input = Console.ReadLine();
    char[] output = input.ToCharArray(0, input.Length);
    Array.Reverse(output);

    foreach (char reverse in output)
    {
        Console.Write(reverse);
    }
}

hw_01();
hw_02();
hw_03();
hw_04();
hw_05();
hw_06();
hw_07();
hw_08();
hw_09();
hw_10();
hw_11();
hw_12();
hw_13();
hw_14();
hw_15();
hw_16();
hw_17();
hw_18();
hw_19();
hw_20();
hw_21();
hw_22();
hw_23();