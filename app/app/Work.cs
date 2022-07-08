using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    //static class Puzzle
    //{
    //    private static string[] answers = { "egg", "sleeping", "cat", "addiction" };
    //    private static string[] secrethints =
    //    {
    //    "have you had breafast today",
    //    "jfdikikikikikfjodff",
    //    "lkfdjfdfjsdfj",
    //    "dhjdlfjoidfjs",
    //    };
    //    private static string[,] hints = {
    //    {"jkdl;a ksdjfo"},
    //    {"djlfksjdl;dk lkjl"},
    //    {"dfjskl;djf;s kldjf"} };

    //    private static int answer = 0;
    //    private static int hint = 0;

    //    private static string GiveHint()
    //    {
    //        if (answer <= 2)
    //        {
    //            answer++;
    //            if (answer == 3)
    //            {
    //                Console.WriteLine("its your last hint");
    //            }
    //            return "your hint:" + hints[answer, hint - 1];

    //        }
    //        else
    //        {
    //            return "no attempt left just take a nap";
    //        }
    //    }
    //    public static string givesecrethint()
    //    {
    //        if (secrethints[answer] != "")
    //        {
    //            string secrethint = "wild secret hint apperead:0" + secrethints[answer];
    //            secrethints[answer] = "";
    //            return secrethint;
    //        }
    //        else
    //        { 
    //         return GiveHint();
    //        }
    //    }

    //    public static int checkplayerguess(string playerguess)
    //    { 
    //        string currentanswer = answers[answer];

    //        if (currentanswer == playerguess)
    //        {
    //            answer++;
    //            hint = 0;
    //            return -1;

    //        }
    //        int validcharcounter =0;
    //        for (int i = 0; i < playerguess.Length - 1; i++)
    //        {
    //            try
    //            {
    //                if (currentanswer[i] == playerguess[i]) { validcharcounter++; }
    //            }
    //            catch ( IndexOutOfRangeException )
    //            {
    //                break;
    //            }
    //        }
    //        return validcharcounter;
    //    }
    //    public static int Giveanswerlenght()
    //    { 
    //    return answers[answer].Length;
    //    }
    //    public static int Answer
    //    {
    //        get { return answer; }
    //    }

    //}
}
