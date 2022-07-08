// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//static int squareroot(int y)
//{
//    return  y*y*y;
//}

//Console.WriteLine(squareroot(20));

//static void now(string day, double time, int year)
//{
//    Console.WriteLine("today is" + day);
//    Console.WriteLine("the time is " + time);
//    Console.WriteLine("The year is " + year );
//}
//now(" wednessday",  11.45, 2022);

static int highestnum(int y, int x)
{
    return y & x;
}

Console.WriteLine(highestnum(20,10));

static int highest(int y, int x)
{
    if (y > x)
    {
        return y;
    }
    else if (y < x)
    { 
         return x;
    }
    else
    {
        return 0;
    }
}
highest(0, 90);


static void ans(string first , string second, string third)
{
    //if (!first.Equals(second))
    fi
    if(first != second)
    {
        Console.WriteLine("correct");
    }
    else
    {
        Console.WriteLine("wrong");
    }
}
ans("microsoft", "soft", "micro");


string[] answers =

//DateTime GetTime = DateTime.Now;
//Console.WriteLine(GetTime.ToString());

//DateOnly Date = DateOnly.Now;
//Console.WriteLine(Date.ToString());

//TimeZoneInfo time = TimeZoneInfo.Local;
//Console.WriteLine(time.ToString());

//TimeOnly Time = new TimeOnly();
//Console.WriteLine(time.ToString());

//static void method()
//{
//    DateTime now = DateTime.Now;
//    Console.WriteLine("Today is " + now.ToString("ddd") + " the time is" + now.ToString("hh:mm:ss") + " the year is  " + now.ToString("yyyy"));
//}
//method();

static void method()
{ 
    DateTimeOffset dateTime = DateTimeOffset.Now;
    Console.WriteLine("Today is " + dateTime.ToString("dddd") + " the time is " + dateTime.ToString("hh:mm:ss:tt") + " the year is  " + dateTime.ToString("yyyy"));
}
method();