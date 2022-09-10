namespace ConsoleNumberPrinter
{
    static class ConsolePrinter
    {
        public static void Print(AsciiImage image)
        {
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                    Console.Write(image[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void PrintNumber(int number)
        {
            string numberStr = number.ToString();
            AsciiImage numberImage = new AsciiImage();
            foreach (char digit in numberStr)
                numberImage += DigitToImage(digit);
            Print(numberImage);
        }

        private static AsciiImage DigitToImage(char digit) => new AsciiImage(digitImages[digit]);
        
        private static Dictionary<char, string[]> digitImages = new Dictionary<char, string[]>
        {
            {
            '1', new string[]{  "█    ",
                                "█    ",
                                "█    ",
                                "█    ",
                                "█    "}
            },
            {
            '2', new string[]{  "████ ",
                                "   █ ",
                                "████ ",
                                "█    ",
                                "████ "}
            },
            {
            '3', new string[]{  "████ ",
                                "   █ ",
                                "████ ",
                                "   █ ",
                                "████ "}
            },
            {
            '4', new string[]{  "█  █ ",
                                "█  █ ",
                                "████ ",
                                "   █ ",
                                "   █ "}
            },
            {
            '5', new string[]{  "████ ",
                                "█    ",
                                "████ ",
                                "   █ ",
                                "████ "}
            },
            {
            '6', new string[]{  "████ ",
                                "█    ",
                                "████ ",
                                "█  █ ",
                                "████ "}
            },
            {
            '7', new string[]{  "████ ",
                                "   █ ",
                                "   █ ",
                                "   █ ",
                                "   █ "}
            },
            {
            '8', new string[]{  "████ ",
                                "█  █ ",
                                "████ ",
                                "█  █ ",
                                "████ "}
            },
            {
            '9', new string[]{  "████ ",
                                "█  █ ",
                                "████ ",
                                "   █ ",
                                "████ "}
            },             
            {
            '0', new string[]{  "████ ",
                                "█  █ ",
                                "█  █ ",
                                "█  █ ",
                                "████ "}
            },
            {
            '-', new string[]{  "     ",
                                "     ",
                                "████ ",
                                "     ",
                                "     "}
            }
        };
    }
}