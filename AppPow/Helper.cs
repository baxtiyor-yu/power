
namespace AppPow
{
    internal class Helper
    {
        public static void DisplayMessage(string msg)
        {
            if (msg == "pow")
            {
                string str = @"
  ____   _____        __
 |  _ \ / _ \ \      / /
 | |_) | | | \ \ /\ / / 
 |  __/| |_| |\ V  V /  
 |_|    \___/  \_/\_/   
";
                ShowWithPrefix(str);
            }
            else
            {
                Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, (Console.WindowHeight) / 2 + 2);
                Console.WriteLine(msg);
                Console.CursorVisible = false;
            }
        }

        private static void ShowWithPrefix(string inComingStr)
        {
            Console.Clear();
            Console.CursorVisible = false;
            string[] arr = inComingStr.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            int strMax = arr.Max(x => x.Length);
            int horizStart = (Console.WindowWidth - strMax) / 2;
            string prefix = new(' ', horizStart);
            Console.SetCursorPosition(horizStart, Console.WindowHeight / 2 - 7);
            var FinalStr = arr.Select(el => prefix + el + "\r\n").ToArray();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Concat(FinalStr));
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static int CheckForNumber(string str)
        {
            string _val = "";
            ConsoleKeyInfo key;
            Console.CursorVisible = true;

            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    if (str.Contains(key.KeyChar.ToString()) && _val.Length < 7)
                    {
                        _val += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                    {
                        _val = _val.Substring(0, (_val.Length - 1));
                        Console.Write("\b \b");
                    }
                }
                if (key.Key == ConsoleKey.Enter && _val.Length > 0)
                {
                    break;
                }
            } while (true);

            Console.WriteLine();

            return int.Parse(_val);
        }

        public static bool CheckForYESorNO(string str)
        {
            ConsoleKeyInfo key;

            while (true)
            {
                key = Console.ReadKey(true);
                if (str.Contains(key.KeyChar.ToString().ToLower()))
                {
                    Console.WriteLine(key.KeyChar);
                    if (Char.ToLower(key.KeyChar) == 'x')
                    {
                        return true;
                    }
                    if (Char.ToLower(key.KeyChar) == 'y')
                    {
                        return false;
                    }
                }
            }
        }
    }
}
