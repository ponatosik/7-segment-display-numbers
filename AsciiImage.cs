namespace ConsoleNumberPrinter
{
    class AsciiImage
    {
        private char[,] _data;
        public int Width
        { get => _data.GetLength(1); }

        public int Height
        { get => _data.GetLength(0); }

        public char this[int i, int j]
        {
            get => _data[i, j];
            set => _data[i, j] = value;
        }

        public AsciiImage() => _data = new char[0, 0];
        public AsciiImage(AsciiImage otherImage) => _data = (char[,])otherImage._data.Clone();
        public AsciiImage(string[] imageLines, char backgroundCharacter = ' ')
        {
            int imageWidht = imageLines.Max(line => line.Length);
            int imageHight = imageLines.Length;

            _data = new char[imageHight, imageWidht];
            Fill(backgroundCharacter);

            // Copy image 
            for (int i = 0; i < imageHight; i++)
                for (int j = 0; j < imageLines[i].Length; j++)
                    _data[i, j] = imageLines[i][j];
        }

        public void CombineWith(AsciiImage otherImage, char backgroundCharacter = ' ')
        {
            int imageWidht = Width + otherImage.Width;
            int imageHight = Math.Max(Height, otherImage.Height);
            int otherXOffset = this.Width;

            char[,] tempData = new char[imageHight, imageWidht];
            for (int i = 0; i < imageHight; i++)
                for (int j = 0; j < imageWidht; j++)
                    tempData[i, j] = backgroundCharacter;

            // Copy this image
            for (int i = 0; i < this.Height; i++)
                for (int j = 0; j < this.Width; j++)
                    tempData[i, j] = _data[i, j];

            // Copy other image
            for (int i = 0; i < otherImage.Height; i++)
                for (int j = 0; j < otherImage.Width; j++)
                    tempData[i, j + otherXOffset] = otherImage._data[i, j];

            _data = tempData;
        }

        public static AsciiImage operator +(AsciiImage image1, AsciiImage image2)
        {
            AsciiImage newImage = new AsciiImage(image1);
            newImage.CombineWith(image2);
            return newImage;
        }
        public void Fill(char character)
        {
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    _data[i, j] = character;
        }
    }
}