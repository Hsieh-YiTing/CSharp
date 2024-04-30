// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

// ----------File HomeWork
void hw_01()
{
    // 寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。
    string path = @"C:\Users\tnsgr\OneDrive\C#課程\hw_0424\hw_0424.txt";
    string createLyrics = "你的心 不曾 被我攻佔\r\n什麽 你說你愛我\r\n你說你愛我自信中帶有瘋狂的火焰\r\n卻時而羞怯的迷人臉龐\r\n不 那不是我\r\n我只是個愛情的騙徒";

    File.WriteAllText(path, createLyrics, Encoding.UTF8);
    Console.ReadKey();
}
void hw_02()
{
    // 讀取1.txt 顯示在畫面上。
    string path = @"C:\Users\tnsgr\OneDrive\C#課程\hw_0424\1.txt";
    string createText = "123";

    File.WriteAllText(path, createText);

    string reader = File.ReadAllText(path);
    Console.WriteLine(reader);
    Console.ReadKey();
}
void hw_03()
{
    // 寫入九九乘法表資料到一個文字檔到自己指定的文字檔。
    string path = @"C:\Users\tnsgr\OneDrive\C#課程\hw_0424\九九乘法表.txt";
    int result;

    using (StreamWriter writer = new StreamWriter(path))
    {
        for (int i = 1; i <= 9; i += 3)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    result = (i + k) * j;
                    string line = $"{(i + k)} * {j} = {result,-10}";
                    writer.Write(line);
                }
                writer.WriteLine();
            }
            writer.WriteLine();
        }
    }
}
void hw_04()
{
    // 讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)

    // 轉換方法
    string ConvertNum(string text)
    {
        string[] arabicNum = { "1", "2", "3", "4", "5" };
        string[] chineseNum = { "壹", "貳", "參", "肆", "伍" };

        for (int i = 0; i < arabicNum.Length; i++)
        {
            text = text.Replace(arabicNum[i], chineseNum[i]);
        }
        return text;
    }

    // 轉換後儲存在指定記事本，讀取後輸出在控制台
    void ChineseNum()
    { 
        string path = @"C:\Users\tnsgr\OneDrive\C#課程\hw_0424\1.txt";
        string reader = File.ReadAllText(path);
        Console.WriteLine($"轉換前為 : {reader}");

        string convertPath = @"C:\Users\tnsgr\OneDrive\C#課程\hw_0424\chineseNum.txt";
        string convertNum = ConvertNum(reader);
        File.WriteAllText(convertPath, convertNum, Encoding.UTF8);
        string readChineseNum = File.ReadAllText(convertPath);
        Console.WriteLine($"轉換後為 : {readChineseNum}");
    }

    ChineseNum();
}
void hw_05()
{
    // 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。

    // 表格格式 : 
    /*
        <table>
            <tr>
                <td>
                <td>
                <td>
            </tr>
        </table>
    */

    // 轉換為HTML Table的方法
    string ConvertToHTML(string csvContent)
    {
        string tableList = "<table>";
        string[] rows = csvContent.Split("\n");

        foreach (string row in rows)
        {
            if (!string.IsNullOrEmpty(row))
            { 
                tableList += "<tr>";
                string[] cols = row.Split(",");

                foreach (string col in cols)
                {
                    tableList += $"<td> {col} </td>";
                }
                tableList += "</tr>";
            }
        }
        tableList += "</table>";
        return tableList;
    }

    // 將.csv轉換為html並寫入到指定路徑
    void HTML_Table()
    {
        string csvPath = @"C:\Users\tnsgr\OneDrive\C#課程\hw_0424\fc4bb.csv";
        string reader = File.ReadAllText(csvPath);
        string htmlPath = @"C:\Users\tnsgr\OneDrive\C#課程\hw_0424\fc4bb_table.html";
        string convertText = ConvertToHTML(reader);
        File.WriteAllText(htmlPath, convertText);
    }

    HTML_Table();
}

// ----------Random HomeWork
void hw_06()
{
    // 請隨機由0~99產生一個數字輸出。
    Random random = new Random();
    Console.WriteLine(random.Next(0, 99));
}
void hw_07()
{
    //請隨機由0~99產生10個數字輸出。

    // 宣告長度為10的random陣列，但並沒有初始化值，所以預設值皆為null
    Random[] randoms = new Random[10];

    // 將每個元素初始化為Random的實例
    for (int i = 0; i < randoms.Length; i++)
    {
        randoms[i] = new Random();
    }

    foreach (Random random in randoms)
    {
        Console.WriteLine(random.Next(0, 99));
    }
}
void hw_08()
{
    // 隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。
    Console.WriteLine("輸入學生人數");
    int studentNum = Convert.ToInt32(Console.ReadLine());
    Random[] randomScore = new Random[studentNum];

    string path = @"C:\Users\tnsgr\OneDrive\C#課程\hw_0424\studentScore.txt";

    for (int i = 0; i < randomScore.Length; i++)
    { 
        randomScore[i] = new Random();
        int score = randomScore[i].Next(1, 101);
        string outputScore = $"第{i + 1}位學生，成績為{score}分";
        File.AppendAllText(path, outputScore + Environment.NewLine);
    }
}
void hw_09()
{
    // 請設計樂透開獎程式。
    List<int> lottoNums = new List<int>();
    Random randomNum = new Random();

    Console.WriteLine("六個號碼為 :");
    while (lottoNums.Count < 6)
    {
        int lottoNum = randomNum.Next(1, 50);
        if (!lottoNums.Contains(lottoNum))
        {
            lottoNums.Add(lottoNum);
        }
    }
    foreach (int num in lottoNums)
    {
        Console.Write($"{num, -5}");
    }

    Console.WriteLine();
    Console.WriteLine("特別號為 : ");

    int specialNum = randomNum.Next(1, 50);
    bool notRepeat = false;

    for (int i = 0; i < lottoNums.Count; i++)
    {
        if (specialNum != lottoNums[i])
        {
            notRepeat = true;
            Console.WriteLine(specialNum);
            break;
        }
    }
    Console.ReadKey();
}
void hw_10()
{
    // 請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。
    string path = @"C:\Users\tnsgr\OneDrive\C#課程\hw_0424\lunch.txt";
    string[] restaurantArray = { "麥當勞", "肯德基", "丹丹漢堡", "樂檸漢堡" };

    File.WriteAllLines(path, restaurantArray);
    string[] restaurantName = File.ReadAllLines(path);
    Console.WriteLine($"餐廳選項 : ");
    foreach (string name in restaurantName)
    {
        Console.Write($"{name, -6}");
    }

    Console.WriteLine();

    Random random = new Random();
    int chooseNum = random.Next(0, 4);
    for (int i = 0; i < restaurantArray.Length; i++)
    {
        if (chooseNum == i)
        {
            Console.WriteLine($"抽到的餐廳為 : {restaurantArray[i]}");
            break;
        }
    }
    Console.ReadKey();
}
void hw_11()
{
    /*
        請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生
        抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
    */
    string path = @"C:\Users\tnsgr\OneDrive\C#課程\hw_0424\rotation.txt";
    List<string> studentNameArray = new List<string> { "郭聰盟", "蔡宛珊", "楊詠丞", "謝易庭", "詹子霆" };
    List<string> selectStudentArray = new List<string>();

    File.WriteAllLines(path, studentNameArray);
    string[] studentName = File.ReadAllLines(path);

    Console.WriteLine($"值日生有 : ");
    foreach (string output in studentName)
    {
        Console.Write($"{output,-6}");
    }

    Console.WriteLine();

    Random random = new Random();

    Console.WriteLine("值日生排序為 : ");
    while (studentNameArray.Count > selectStudentArray.Count)
    {
        int studentIndex = random.Next(0, studentNameArray.Count);
        string drawStudent = studentNameArray[studentIndex];

        if (!selectStudentArray.Contains(drawStudent))
        {
            selectStudentArray.Add(drawStudent);
            Console.Write($"{drawStudent,-5}");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"今日值日生為 : {selectStudentArray[0]}");
    Console.ReadKey();
}

// ----------DateTime HomeWork
void hw_12()
{
    // 顯示現在日期與時間。
    DateTime now = DateTime.Now;
    Console.WriteLine($"現在時間為 : {now}");
    Console.ReadKey();
}
void hw_13()
{
    // 顯示再過30天為哪一天。
    DateTime today = DateTime.Today;
    DateTime futureDay = today.AddDays(30);
    Console.WriteLine($"30天後為 : {futureDay}");
    Console.ReadKey();
}
void hw_14()
{
    // 顯示24小時前的年月日時分秒。
    DateTime now = DateTime.Now;
    DateTime pastDay = now.AddDays(-1);
    Console.WriteLine($"24小時前為 : {pastDay}");
    Console.ReadKey();
}
void hw_15()
{
    // 取得目前是幾月。
    DateTime today = DateTime.Today;
    int month = today.Month;
    Console.WriteLine($"目前是{month}月");
    Console.ReadKey();
}
void hw_16()
{
    // 取得明年是否為閏年。(可以試試民國)
    DateTime today = DateTime.Today;
    DateTime nextYear = today.AddYears(1);
    int nextYearInt = nextYear.Year;
    bool isLeap = DateTime.IsLeapYear(nextYearInt);

    if (isLeap)
    {
        Console.WriteLine("明年是閏年");
    }
    else
    {
        Console.WriteLine("明年不是閏年");
    }
    Console.ReadKey();
}
void hw_17()
{
    // 取得離2025年1月1日還有幾天。
    DateTime today = DateTime.Today;
    DateTime futureDay = new DateTime(2025, 1, 1);

    double dayDifference = (futureDay - today).TotalDays;
    Console.WriteLine($"與{futureDay}還差{dayDifference}天");
    Console.ReadKey();
}
void hw_18()
{
    /*
        星期一，猴子穿新衣，
        星期二，猴子肚子餓，
        星期三，猴子去爬山，
        星期四，猴子看電視，
        呈期五，猴子去跳舞，
        星期六，猴子去斗六，
        星期日，猴子過生日。
        請顯示今天猴子做甚麼事。 
    */
    DateTime today = DateTime.Today;
    DayOfWeek todayWeek = today.DayOfWeek;
    int todayWeekInt = (int)todayWeek;

    switch (todayWeekInt)
    { 
        case 0:
            Console.WriteLine("星期日，猴子過生日");
            break;
        case 1:
            Console.WriteLine("星期一，猴子穿新衣");
            break;
        case 2:
            Console.WriteLine("星期二，猴子肚子餓");
            break;
        case 3:
            Console.WriteLine("星期三，猴子去爬山");
            break;
        case 4:
            Console.WriteLine("星期四，猴子看電視");
            break;
        case 5:
            Console.WriteLine("呈期五，猴子去跳舞");
            break;
        case 6:
            Console.WriteLine("星期六，猴子去斗六");
            break;
    }
    Console.ReadKey();
}
void hw_19()
{
    // 輸入兩個日期，輸出兩個日期相差幾天。
    DateTime firstDay = new DateTime();
    DateTime secondDay = new DateTime();

    int inputCount = 0;

    while (inputCount < 2)
    {
        Console.WriteLine($"請輸入第{inputCount + 1}個日期，格式為(yyyy/mm/dd)");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime parseDay))
        {
            if (inputCount == 0)
            {
                firstDay = parseDay;
                Console.WriteLine($"格式正確，第一個日期為{firstDay}\n");
            }
            else
            {
                secondDay = parseDay;
                Console.WriteLine($"格式正確，第二個日期為{secondDay}\n");
            }
            inputCount++;
        }
        else
        {
            Console.WriteLine("格式錯誤，請重新輸入\n");
            continue;
        }
    }
    double dayDifference = Math.Abs((secondDay - firstDay).TotalDays);
    Console.WriteLine($"相差{dayDifference}天");
    Console.ReadKey();
}
void hw_20()
{
    /*
       兩光法師時常替人占卜，由於他算得又快有便宜，因此生意源源不絕，時常大排長龍，他想算得更快一點
       因此找了你這位電腦高手幫他用電腦來加快算命的速度。
       他的占卜規則很簡單，規則是這樣的，隨機產生一個今年日期，然後依照下面的公式：
        M=月
        D=日
        S=(M*2+D)%3
        得到 S 的值，再依照 S 的值從 0 到 2 分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢。
    */
    Random random = new Random();
    int month = random.Next(1, 13);
    int day;

    if (month == 4 || month == 6 || month == 9 || month == 11)
    {
        day = random.Next(1, 31);
    }
    else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
    {
        day = random.Next(1, 32);
    }
    else
    { 
        day = random.Next(1, 29);
    }

    Console.WriteLine($"日期為{month}月{day}日\n");

    int S = ((month * 2) + day) % 3;
    if (S == 0)
    {
        Console.WriteLine("運勢 : 普通");
    }
    else if (S == 1)
    {
        Console.WriteLine("運勢 : 吉");
    }
    else
    {
        Console.WriteLine("運勢 : 大吉");
    }
    Console.ReadKey();
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