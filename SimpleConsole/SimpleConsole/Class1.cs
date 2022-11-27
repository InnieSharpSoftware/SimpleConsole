/*
 * Сделано в Visual Studio 2010
 * .NET FrameWork 4.0
 * C#
 * Ver. 0.3
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SimpleConsole
{
    public class SimpleColors
    {
        public static ConsoleColor ParseByName(string color)
        {
            // no comments
            string clr = color.ToLower();
            if(clr == "white")
                return ConsoleColor.White;
            else if (clr == "black")
                return ConsoleColor.Black;
            else if (clr == "red")
                return ConsoleColor.Red;
            else if (clr == "green")
                return ConsoleColor.Green;
            else if (clr == "blue")
                return ConsoleColor.Blue;
            else if (clr == "yellow")
                return ConsoleColor.Yellow;
            else if (clr == "cyan")
                return ConsoleColor.Cyan;
            else if (clr == "gray")
                return ConsoleColor.Gray;
            else if (clr == "magenta")
                return ConsoleColor.Magenta;
            else if (clr == "darkblue")
                return ConsoleColor.DarkBlue;
            else if (clr == "darkcyan")
                return ConsoleColor.DarkCyan;
            else if (clr == "darkgray")
                return ConsoleColor.DarkGray;
            else if (clr == "darkgreen")
                return ConsoleColor.DarkGreen;
            else if (clr == "darkmagenta")
                return ConsoleColor.DarkMagenta;
            else if (clr == "darkred")
                return ConsoleColor.DarkRed;
            else if (clr == "darkyellow")
                return ConsoleColor.DarkYellow;
            return ConsoleColor.White;
        }
        public static bool IsColor(string color)
        {
            // no comments
            string clr = color.ToLower();
            if (clr == "white")
                return true;
            else if (clr == "black")
                return true;
            else if (clr == "red")
                return true;
            else if (clr == "green")
                return true;
            else if (clr == "blue")
                return true;
            else if (clr == "yellow")
                return true;
            else if (clr == "cyan")
                return true;
            else if (clr == "gray")
                return true;
            else if (clr == "magenta")
                return true;
            else if (clr == "darkblue")
                return true;
            else if (clr == "darkcyan")
                return true;
            else if (clr == "darkgray")
                return true;
            else if (clr == "darkgreen")
                return true;
            else if (clr == "darkmagenta")
                return true;
            else if (clr == "darkred")
                return true;
            else if (clr == "darkyellow")
                return true;
            return false;
        }
        public static ConsoleColor RandomColor()
        {
            // no comments
            var r = new Random();
            return (ConsoleColor)r.Next(16);
        }
    }

    public class SimpleText
    {
        public static string Choose(string[] array)
        {
            int index = 0; // The index of the selected item.
            bool nonchoosed = true;
            while (nonchoosed) // Cycle
            {
                Console.Clear(); // Clear text
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == index) // Checking if a Row is Selected
                        Console.WriteLine("->" + array[i]);
                    else
                        Console.WriteLine(array[i]);
                }
                ConsoleKeyInfo key = Console.ReadKey(true); // Asking for input
                if (key.Key == ConsoleKey.UpArrow) // If UpArrow - Index += 1
                {
                    if (index == 0)
                        index = array.Length - 1;
                    else
                        index--;
                }
                else if (key.Key == ConsoleKey.DownArrow) // If DownArrow - Index -= 1
                {
                    if (index == array.Length - 1)
                        index = 0;
                    else
                        index++;
                }
                else if (key.Key == ConsoleKey.W) // If W - Index += 1
                {
                    if (index == 0)
                        index = array.Length - 1;
                    else
                        index--;
                }
                else if (key.Key == ConsoleKey.S) // If S - Index -= 1
                {
                    if (index == array.Length - 1)
                        index = 0;
                    else
                        index++;
                }
                else if (key.Key == ConsoleKey.Enter) // If Enter - returning the selected item
                {
                    return array[index];
                }
            }
            return null;
        }
        public static void RainbowText(string text)
        {
            // no comments
            var r = new Random();
            foreach (char letter in text)
            {
                Console.ForegroundColor = (ConsoleColor)r.Next(16);
                Console.Write(letter);
            }
            Console.Write('\r');
        }
    }

    public class SimpleIO
    {
        public static int FindLineInFile(string path, string line)
        {
            if (File.Exists(path))
            {
                string[] text = File.ReadAllLines(path);
                for (int i = 0; i < text.Length; i++)
                    if (text[i] == line)
                        return i;
            }
            return 0;
        }
        public static int[] FindWordInFile(string path, string word)
        {
            if (File.Exists(path))
            {
                string[] text = File.ReadAllLines(path);
                for (int i = 0; i < text.Length; i++)
                {
                    string[] splitoption = { " " }; string[] lines = text[i].Split(splitoption, StringSplitOptions.None);
                    for (int j = 0; j < lines.Length; j++)
                        if (lines[j].ToLower() == word.ToLower())
                            return new int[] { i, j };
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
