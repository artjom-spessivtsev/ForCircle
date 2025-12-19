namespace ForCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int height = 12;
            Random random = new Random();
            ConsoleColor[] garlandColors =
            {
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Cyan,
            ConsoleColor.Magenta,
            ConsoleColor.Green
        };

            while (true)
            {
                Console.Clear();

                // Рисуем ёлку
                for (int i = 0; i < height; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    // Отступы
                    Console.Write(new string(' ', height - i));

                    for (int j = 0; j < i * 2 + 1; j++)
                    {
                        // Гирлянда
                        if (i > 2 && j % 4 == 0)
                        {
                            Console.ForegroundColor =
                                garlandColors[random.Next(garlandColors.Length)];
                            Console.Write("o");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }

                // Ствол
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(new string(' ', height) + "|||");

                // Задержка для мигания
                Thread.Sleep(500);
            }
        }
    }
}
