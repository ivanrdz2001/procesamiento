using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProcesamientoCorrecto
{
    class VideoManipulation
    {


        private static object control = new object();

        public class ImageEventArgs : EventArgs
        {
            public Bitmap bmap { get; set; }
        }

        public class HistogramEventArgs : EventArgs
        {
            public Dictionary<int, int> histo { get; set; }
            public char channel { get; set; }
            public int display { get; set; }
        }

        //Define the Event Handler Delegates
        public event EventHandler<ImageEventArgs> ImageFinished;

        public event EventHandler<HistogramEventArgs> HistogramFinished;

        //Histogram methods
        public void getHistogram(Bitmap bmp, char channel, int display)
        {
            if (bmp == null)
                OnHistogramFinished(new Dictionary<int, int>(), channel, display);

            Dictionary<int, int> histo = new Dictionary<int, int>();

            for (int i = 1; i <= 255; i++)
            {
                histo.Add(i, 1);
            }

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    // Get pixel color 
                    Color c = bmp.GetPixel(x, y);
                    // If it exists in our 'histogram' increment the corresponding value, or add new

                    int colorValue = 0;

                    switch (channel)
                    {
                        case 'R':
                        case 'r':
                            {
                                colorValue = c.R;
                                break;
                            }

                        case 'G':
                        case 'g':
                            {
                                colorValue = c.G;
                                break;
                            }

                        case 'B':
                        case 'b':
                            {
                                colorValue = c.B;
                                break;
                            }
                    }

                    if (histo.ContainsKey(colorValue))
                        histo[colorValue] = histo[colorValue] + 1;

                }
            }

            OnHistogramFinished(histo, channel, display);
        }

        public void getLockBitsHistogram(Bitmap bmp, char channel, int display)
        {
            if (bmp == null)
                OnHistogramFinished(new Dictionary<int, int>(), channel, display);

            Dictionary<int, int> histo = new Dictionary<int, int>();

            for (int i = 1; i <= 255; i++)
            {
                histo.Add(i, 1);
            }

            Bitmap bmap = new Bitmap(bmp);

            unsafe
            {
                BitmapData bitmapData = bmap.LockBits(new Rectangle(0, 0, bmap.Width, bmap.Height), ImageLockMode.ReadWrite, bmap.PixelFormat);

                //Define Variables for bytes per pixel, as ewll as Image Widht and Height
                int bytesPerPixel = Bitmap.GetPixelFormatSize(bmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                //Define a pointer to the first in the locked image.
                //Scan0 gets or sets the address of the first pixel data in the bitmap
                //This can also be thought of as the first scan line in the bitmap
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

                //Step thru each pixel in the image using pointers
                //Parallel.For executes a 'for' lopp in which iterations may run in parallel
                Parallel.For(0, heightInPixels, y =>
                {
                    //Use the 'stride' (scanline width) property to step line by line thru the image
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        //GET each pixel color
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x + 1];
                        int oldRed = currentLine[x + 2];

                        int colorValue = 0;

                        switch (channel)
                        {
                            case 'R':
                            case 'r':
                                {
                                    colorValue = oldRed;
                                    break;
                                }

                            case 'G':
                            case 'g':
                                {
                                    colorValue = oldGreen;
                                    break;
                                }

                            case 'B':
                            case 'b':
                                {
                                    colorValue = oldBlue;
                                    break;
                                }
                        }

                        if (histo.ContainsKey(colorValue))
                            histo[colorValue] = histo[colorValue] + 1;
                    }
                });
                //bmp.UnlockBits(bitmapData);

            }

            OnHistogramFinished(histo, channel, display);
        }

        public Bitmap mirrorImage(Bitmap bmap)
        {
            int width, height;

            width = bmap.Width;
            height = bmap.Height;

            Bitmap mBmap = new Bitmap(width * 2, height);

            for (int y = 0; y < height; y++)
            {
                for (int lx = 0, rx = width * 2 - 1; lx < width; lx++, rx--)
                {
                    //Get source pixel value
                    Color p = bmap.GetPixel(lx, y);

                    //Set mirror pixel value
                    mBmap.SetPixel(lx, y, p);
                    mBmap.SetPixel(rx, y, p);
                }
            }

            return mBmap;
        }
        public Bitmap escaladegrises(Bitmap inputImage)
        {

            Bitmap result = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    Color pixelColor = inputImage.GetPixel(x, y);

                    int average = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color grayColor = Color.FromArgb(pixelColor.A, average, average, average);

                    result.SetPixel(x, y, grayColor);
                }
            }

            return result;
        }

        private Bitmap RELIEVE(Bitmap inputImage, double factor = 1)
        {
            Bitmap result = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 1; y < inputImage.Height - 1; y++)
            {
                for (int x = 1; x < inputImage.Width - 1; x++)
                {
                    Color currentPixel = inputImage.GetPixel(x, y);
                    Color previousPixel = inputImage.GetPixel(x - 1, y - 1);

                    int r = Clamp((int)(currentPixel.R - previousPixel.R * factor + 128));
                    int g = Clamp((int)(currentPixel.G - previousPixel.G * factor + 128));
                    int b = Clamp((int)(currentPixel.B - previousPixel.B * factor + 128));

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return result;


        }

        private Bitmap glitch(Bitmap inputImage)
        {
            int a = 15;
            Bitmap result = new Bitmap(inputImage.Width, inputImage.Height);

            BitmapData inputImageData = inputImage.LockBits(new Rectangle(0, 0, inputImage.Width, inputImage.Height), ImageLockMode.ReadOnly, inputImage.PixelFormat);
            BitmapData resultImageData = result.LockBits(new Rectangle(0, 0, result.Width, result.Height), ImageLockMode.WriteOnly, result.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(inputImage.PixelFormat) / 8;
            int widthInBytes = inputImageData.Width * bytesPerPixel;

            unsafe
            {
                byte* inputPtr = (byte*)inputImageData.Scan0;
                byte* resultPtr = (byte*)resultImageData.Scan0;

                for (int y = 0; y < inputImageData.Height; y++)
                {
                    byte* inputLinePtr = inputPtr + (y * inputImageData.Stride);
                    byte* resultLinePtr = resultPtr + (y * resultImageData.Stride);

                    for (int x = 0; x < widthInBytes; x += bytesPerPixel)
                    {
                        int g = inputLinePtr[x + 1];

                        int r, b;
                        if (x + (a * bytesPerPixel) < widthInBytes)
                        {
                            r = inputLinePtr[x + (a * bytesPerPixel) + 2];
                        }
                        else
                        {
                            r = 0;
                        }

                        if (x - (a * bytesPerPixel) >= 0)
                        {
                            b = inputLinePtr[x - (a * bytesPerPixel)];
                        }
                        else
                        {
                            b = 0;
                        }

                        resultLinePtr[x] = (byte)b;
                        resultLinePtr[x + 1] = (byte)g;
                        resultLinePtr[x + 2] = (byte)r;
                    }
                }
            }

            inputImage.UnlockBits(inputImageData);
            result.UnlockBits(resultImageData);
            return result;
        }


        private int Clamp(int value, int min = 0, int max = 255)
        {
            return Math.Max(min, Math.Min(value, max));
        }
        private Bitmap SOLARIZAR(Bitmap inputImage, int threshold = 128)
        {
            Bitmap result = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    Color originalColor = inputImage.GetPixel(x, y);

                    int r = originalColor.R;
                    int g = originalColor.G;
                    int b = originalColor.B;

                    r = r < threshold ? r : 255 - r;
                    g = g < threshold ? g : 255 - g;
                    b = b < threshold ? b : 255 - b;

                    result.SetPixel(x, y, Color.FromArgb(originalColor.A, r, g, b));
                }
            }

            return result;
        }
        private Bitmap PIXEL(Bitmap inputImage, int pixelSize = 10)
        {
            Bitmap result = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y += pixelSize)
            {
                for (int x = 0; x < inputImage.Width; x += pixelSize)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int pixelCount = 0;

                    for (int blockY = y; blockY < y + pixelSize && blockY < inputImage.Height; blockY++)
                    {
                        for (int blockX = x; blockX < x + pixelSize && blockX < inputImage.Width; blockX++)
                        {
                            Color pixelColor = inputImage.GetPixel(blockX, blockY);
                            avgR += pixelColor.R;
                            avgG += pixelColor.G;
                            avgB += pixelColor.B;
                            pixelCount++;
                        }
                    }

                    avgR /= pixelCount;
                    avgG /= pixelCount;
                    avgB /= pixelCount;

                    Color blockColor = Color.FromArgb(avgR, avgG, avgB);

                    for (int blockY = y; blockY < y + pixelSize && blockY < inputImage.Height; blockY++)
                    {
                        for (int blockX = x; blockX < x + pixelSize && blockX < inputImage.Width; blockX++)
                        {
                            result.SetPixel(blockX, blockY, blockColor);
                        }
                    }
                }
            }

            return result;
        }

        public Bitmap INVERTIR(Bitmap inputImage)
        {

            Bitmap invertedImage = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    Color originalColor = inputImage.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(
                        originalColor.A,
                        255 - originalColor.R,
                        255 - originalColor.G,
                        255 - originalColor.B
                    );

                    invertedImage.SetPixel(x, y, invertedColor);
                }
            }

            return invertedImage;
        }

        public void ManipulateLockBits(object bmp, int selectedFilter, int extra = 127)
        {
            Bitmap bmap = (Bitmap)bmp;

            if (selectedFilter == 1)
            {
                Bitmap mBmap = SOLARIZAR(bmap);
                OnImageFinished(mBmap);
                bmap = mBmap;
                return;
            }

            if (selectedFilter == 2)
            {
                Bitmap mBmap = escaladegrises(bmap);
                OnImageFinished(mBmap);
                bmap = mBmap;
                return;
            }

            if (selectedFilter == 3)
            {
                Bitmap mBmap = INVERTIR(bmap);
                OnImageFinished(mBmap);
                bmap = mBmap;
                return;
            }
            if (selectedFilter == 4)
            {
                Bitmap mBmap = mirrorImage(bmap);
                OnImageFinished(mBmap);
                bmap = mBmap;
                return;
            }

            if (selectedFilter == 5)
            {
                Bitmap mBmap = RELIEVE(bmap);
                OnImageFinished(mBmap);
                bmap = mBmap;
                return;
            }

            if (selectedFilter == 6)
            {
                Bitmap mBmap = glitch(bmap);
                OnImageFinished(mBmap);
                bmap = mBmap;
                return;
            }

            if(selectedFilter== 7)
            {
                Bitmap mBmap = PIXEL(bmap);
                OnImageFinished(mBmap);
                bmap = mBmap;
                return;
            }
            unsafe
            {
                BitmapData bitmapData = bmap.LockBits(new Rectangle(0, 0, bmap.Width, bmap.Height), ImageLockMode.ReadWrite, bmap.PixelFormat);


                //Define Variables for bytes per pixel, as ewll as Image Widht and Height
                int bytesPerPixel = Bitmap.GetPixelFormatSize(bmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                //Define a pointer to the first in the locked image.
                //Scan0 gets or sets the address of the first pixel data in the bitmap
                //This can also be thought of as the first scan line in the bitmap
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;
                Color theNewColor;

                //Step thru each pixel in the image using pointers
                //Parallel.For executes a 'for' lopp in which iterations may run in parallel
                Parallel.For(0, heightInPixels, y =>
                {
                    //Use the 'stride' (scanline width) property to step line by line thru the image
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        //GET each pixel color
                        int oldRed = currentLine[x + 2];
                        int oldGreen = currentLine[x + 1];
                        int oldBlue = currentLine[x];

                        Color theColor = Color.FromArgb(255, oldRed, oldGreen, oldBlue);

                        lock (control)
                        {
                            //Change the color of the pixel
                            switch (selectedFilter)
                            {
                                //case 1:
                                //    {
                                //        theNewColor = turnSepia(theColor);
                                //        break;
                                //    }

                                //case 3:
                                //    {
                                //        theNewColor = INVERTIR(theColor);
                                //        break;
                                //    }

                                //case 4:
                                //    {
                                //        bmap.UnlockBits(bitmapData);
                                //        Bitmap mBmap = mirrorImage(bmap);
                                //        OnImageFinished(mBmap);
                                //        bmap = mBmap;
                                //        return;
                                //    }

                               default:
                                    {
                                        theNewColor = theColor;
                                        break;
                                    }
                            }

                            currentLine[x] = theNewColor.B;
                            currentLine[x + 1] = theNewColor.G;
                            currentLine[x + 2] = theNewColor.R;
                        }


                        //currentLine[x] = 0;
                        //currentLine[x + 1] = (byte)oldGreen;
                        //currentLine[x + 2] = (byte)oldRed;
                    }
                });

                bmap.UnlockBits(bitmapData);
            }

            OnImageFinished(bmap);
        }


        //Add Event methods
        protected virtual void OnImageFinished(Bitmap bmap)
        {
            ImageFinished?.Invoke(this, new ImageEventArgs() { bmap = bmap });
        }

        protected virtual void OnHistogramFinished(Dictionary<int, int> histo, char channel, int display)
        {
            HistogramFinished?.Invoke(this, new HistogramEventArgs() { histo = histo, channel = channel, display = display });
        }
    }

}
