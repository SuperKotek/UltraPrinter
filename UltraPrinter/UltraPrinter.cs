using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraPrinter
{
    public class UltraPrinter
    {
        private static string ConvertZapToDot(double number)
        {
            string[] a = number.ToString().Split(',');
            string res = a[0];
            if (a.Length > 1)
            { res = a[0] + "." + a[1]; }
            return res;
        }
        public static double SizePrintComboBoxin(ComboBox comboBox)
        {
            int index = comboBox.SelectedIndex;
            double sizeprintin = Math.Pow(2, (3+index));
            return sizeprintin;
        }
        public static ((int, int), int[,], bool) UltraPrinterPrintImage(Bitmap image)
        {
            int[,] matrix = new int[image.Width, image.Height];
            int countWhite = 0; int countBlack = 0; bool ecoColor = false;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    if (pixel.R == 255)
                    { matrix[i, j] = 0; countWhite++; }
                    else
                    { matrix[i, j] = 1; countBlack++; }
                }
            }
            if (countWhite >= countBlack)
            { ecoColor = true; }
            return ((image.Width, image.Height), matrix, ecoColor);
        }
        public static Bitmap FloydSteinbergDithering(Bitmap original)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);
            float[,] error = new float[original.Width, original.Height];

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);
                    float gray = 0.299f * pixel.R + 0.587f * pixel.G + 0.114f * pixel.B;
                    gray += error[x, y];

                    Color newColor = (gray > 128) ? Color.White : Color.Black;
                    result.SetPixel(x, y, newColor);

                    float quantError = gray - ((newColor.R > 0) ? 255 : 0);

                    // Распространение ошибки
                    if (x + 1 < original.Width)
                        error[x + 1, y] += quantError * 7 / 16;
                    if (x > 0 && y + 1 < original.Height)
                        error[x - 1, y + 1] += quantError * 3 / 16;
                    if (y + 1 < original.Height)
                        error[x, y + 1] += quantError * 5 / 16;
                    if (x + 1 < original.Width && y + 1 < original.Height)
                        error[x + 1, y + 1] += quantError * 1 / 16;
                }
            }
            return result;
        }
        // Чтение текстового файла UltraPrinter.txt, для генерации с помощью матрицы
        public static ((int, int), int[,], bool) ReadFile(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            try
            {
                int numberpixel = int.Parse(reader.ReadLine());
                int[,] matrix = new int[numberpixel, numberpixel];
                for (int i = 0; i < numberpixel; i++)
                {
                    string[] p = reader.ReadLine().Split(' ');
                    for (int j = 0; j < numberpixel; j++)
                    { matrix[i, j] = int.Parse(p[j]); }
                }
                reader.Close();
                return ((numberpixel, numberpixel), matrix, true);
            }
            catch
            {
                reader.Close();
                throw new Exception("Ошибка получения файла / Error retrieving file");
            }
        }
        // Генерация карты с изображением с помощью матрицы
        public static void UltrakillMapGeneration((int,int) imagecont, int[,] matrix, bool ecoColor, string folderPath)
        {
            StreamWriter writer = new StreamWriter(folderPath);
            writer.Write("{\"MapName\":\"7b3cb6a0a342eb54dafe5552d4820eeb\",\"MapIdentifier\":null,\"SaveVersion\":2,\"GameVersion\":\"4.0\",\"Blocks\":[");
            string zlong = "";
            string xlong = "";
            int numberpixel = Math.Max(imagecont.Item1, imagecont.Item2);
            if (numberpixel == imagecont.Item2)
            {
                xlong = "100.0";
                double popr = Math.Min(imagecont.Item1, imagecont.Item2) * (100.0 / numberpixel);
                zlong = ConvertZapToDot(popr);
            }
            else
            {
                zlong = "100.0";
                double popr = Math.Min(imagecont.Item1, imagecont.Item2) * (100.0 / numberpixel);
                xlong = ConvertZapToDot(popr);
            }
            if (ecoColor == true)
            {
                for (int i = 0; i < imagecont.Item1; i++)
                {
                    for (int j = 0; j < imagecont.Item2; j++)
                    {
                        double sizeN = Math.Round((100.0 / numberpixel), 6);
                        double xN = Math.Round((-100.0 + ((100.0 / numberpixel) * j)), 6);
                        double zN = Math.Round((100.0 + ((100.0 / numberpixel) * i)), 6);
                        string x = ConvertZapToDot(xN);
                        string z = ConvertZapToDot(zN);
                        int countOptimizm = 0;
                        while (j < imagecont.Item2 && matrix[i, j] == 1)
                        {
                            countOptimizm++; j++;
                        }
                        if (countOptimizm > 0)
                        {
                            j--;
                            double sizeMod = sizeN * countOptimizm;
                            string size = ConvertZapToDot(sizeN);
                            string sizeM = ConvertZapToDot(sizeMod);
                            writer.Write("{\"BlockSize\":{\"x\":" + sizeM + ",\"y\":2.0,\"z\":" + size + "}," +
                            "\"BlockType\":2,\"Kinematic\":true,\"ObjectIdentifier\":\"ultrakill.brush-metal\",\"" +
                            "Position\":{\"x\":" + x + ",\"y\":11.5,\"z\":" + z + "}," +
                            "\"Rotation\":{\"x\":0.0,\"y\":0.0,\"z\":0.0,\"w\":1.0},\"Scale\":{\"x\":1.0,\"y\":1.0,\"z\":1.0},\"Data\":[{\"Key\":\"block\",\"Options\":[]}]},");
                        }
                    }
                }
                double poprav = 100 + (100.0 / numberpixel);
                string popravka = ConvertZapToDot(poprav);
                writer.Write("{\"BlockSize\":{\"x\":" + xlong + ",\"y\":1.95,\"z\":" + zlong + "}," +
                "\"BlockType\":0,\"Kinematic\":true,\"ObjectIdentifier\":\"ultrakill.brush-plastic\",\"" +
                "Position\":{\"x\":-100.0,\"y\":11.5,\"z\":100.0}," +
                "\"Rotation\":{\"x\":0.0,\"y\":0.0,\"z\":0.0,\"w\":1.0},\"Scale\":{\"x\":1.0,\"y\":1.0,\"z\":1.0},\"Data\":[{\"Key\":\"block\",\"Options\":[]}]}");
                writer.Write("],\"Props\":[],\"Enemies\":[]}");
            }
            else
            {
                for (int i = 0; i < imagecont.Item1; i++)
                {
                    for (int j = 0; j < imagecont.Item2; j++)
                    {
                        double sizeN = Math.Round((100.0 / numberpixel), 6);
                        double xN = Math.Round((-100.0 + ((100.0 / numberpixel) * j)), 6);
                        double zN = Math.Round((100.0 + ((100.0 / numberpixel) * i)), 6);
                        string x = ConvertZapToDot(xN);
                        string z = ConvertZapToDot(zN);
                        int countOptimizm = 0;
                        while (j < imagecont.Item2 && matrix[i, j] == 0)
                        {
                            countOptimizm++; j++;
                        }
                        if (countOptimizm > 0)
                        {
                            j--;
                            double sizeMod = sizeN * countOptimizm;
                            string size = ConvertZapToDot(sizeN);
                            string sizeM = ConvertZapToDot(sizeMod);
                            writer.Write("{\"BlockSize\":{\"x\":" + sizeM + ",\"y\":2.0,\"z\":" + size + "}," +
                            "\"BlockType\":0,\"Kinematic\":true,\"ObjectIdentifier\":\"ultrakill.brush-plastic\",\"" +
                            "Position\":{\"x\":" + x + ",\"y\":11.5,\"z\":" + z + "}," +
                            "\"Rotation\":{\"x\":0.0,\"y\":0.0,\"z\":0.0,\"w\":1.0},\"Scale\":{\"x\":1.0,\"y\":1.0,\"z\":1.0},\"Data\":[{\"Key\":\"block\",\"Options\":[]}]},");
                        }
                    }
                }
                writer.Write("{\"BlockSize\":{\"x\":" + xlong + ",\"y\":1.95,\"z\":" + zlong + "}," +
                "\"BlockType\":2,\"Kinematic\":true,\"ObjectIdentifier\":\"ultrakill.brush-metal\",\"" +
                "Position\":{\"x\":-100.0,\"y\":11.5,\"z\":100.0}," +
                "\"Rotation\":{\"x\":0.0,\"y\":0.0,\"z\":0.0,\"w\":1.0},\"Scale\":{\"x\":1.0,\"y\":1.0,\"z\":1.0},\"Data\":[{\"Key\":\"block\",\"Options\":[]}]}");
                writer.Write("],\"Props\":[],\"Enemies\":[]}");
            }
            writer.Close();
        }
    }
}
