using System;
using System.Threading;

namespace HappyBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "С Днём Рождения!";
            Action act = PlayMelody;
            act.BeginInvoke(null, null);
            CoolPrint("Никита, от лица нашего коллектива (комната 332) поздравляем тебя с Днём Рождения! Желаем крепкого здоровья, счастья. Пусть преграды, которые возникнут на твоём пути, никогда тебя не остановят и ты преодолеешь их, становясь ещё сильнее, ведь как говорится \"Что нас не убивает - делает только сильнее!\", чего мы тебе и желаем. Иди к своей мечте, оставайся таким же весёлым и классным парнем какой ты есть и никогда не меняйся. С Днём Рождения, Никита!");
            Console.ReadLine();
        }
        static void CoolPrint(string message)
        {
            Random random = new Random();
            foreach (char symbol in message)
            {
                SetRandomColor(random.Next(1, 9));
                Console.Write(symbol);
                Thread.Sleep(50);
                switch(symbol)
                {
                    case ',':
                        Thread.Sleep(50);
                        break;
                    case '-':
                        Thread.Sleep(50);
                        break;
                    case '!':
                        Thread.Sleep(80);
                        break;
                    case '.':
                        Thread.Sleep(100);
                        break;
                }
            }
            Console.ResetColor();
        }
        static void SetRandomColor(int number)
        {
            switch(number)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
        }
        static void PlayMelody()
        {
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
    }
}
