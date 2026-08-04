using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace UltraPrinter
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Label[] UIlabel;
        Button[] UIbutton;
        string[] UIAnswers;
        string filePath = "";
        string folderPath = "";
        Bitmap originalImage;
        Bitmap original;

        public Form1()
        {
            InitializeComponent();
            string[] strings = { "8x8", "16x16", "32x32", "64x64", "128x128", "256x256", "512x512", "1024x1024", };
            UIlabel = new System.Windows.Forms.Label[]{ labelFile, labelFolder, labelPict, label1, label2, label3 };
            UIbutton = new Button[]{ OpenFileButt, OpenFolderButt, OpenPictButt, MatrixPictureButt, PicturePictButt };
            UIAnswers = new string[] { "", "", "", "", "", "", ""};
            Translation.TranslateUI(UIlabel, UIbutton, UIAnswers, true);
            comboBox1.Items.AddRange(strings);
            comboBox1.SelectedIndex = 0;
        }

        private void OpenFileButt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = UIAnswers[0];
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { filePath = openFileDialog.FileName; }
            }
            textBoxFile.Text = filePath;
        }

        private void OpenFolderButt_Click(object sender, EventArgs e)
        {
            // Создаем диалог выбора папки
            FolderBrowserDialog folderDialog = new FolderBrowserDialog
            { Description = UIAnswers[1], ShowNewFolderButton = true };
            // Показываем диалог и проверяем, что пользователь нажал "OK"
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderDialog.SelectedPath;
                string fileName = "UltraPrint.pitr"; // Имя файла, который создаст программа
                folderPath = Path.Combine(selectedFolder, fileName); // Полный путь
            }
            textBoxFolder.Text = folderPath;
        }
        private void MatrixPictureButt_Click(object sender, EventArgs e)
        {
            if (filePath != "" && folderPath != "")
            {
                try
                {
                    ((int, int), int[,], bool) a = UltraPrinter.ReadFile(filePath);
                    UltraPrinter.UltrakillMapGeneration(a.Item1, a.Item2, a.Item3, folderPath);
                    MessageBox.Show(UIAnswers[2]);
                }
                catch (Exception)
                {
                    MessageBox.Show(UIAnswers[3]);
                }
            }
            else
            {
                MessageBox.Show(UIAnswers[4]);
            }
        }

        private void OpenPictButt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = UIAnswers[5];
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    original = new Bitmap(openFileDialog.FileName);
                    double sizePrintin = UltraPrinter.SizePrintComboBoxin(comboBox1);
                    double scale = Math.Min((double)sizePrintin / original.Width, (double)sizePrintin / original.Height);
                    int scaledWidth = (int)(original.Width * scale);
                    int scaledHeight = (int)(original.Height * scale);
                    originalImage = new Bitmap(original, scaledWidth, scaledHeight);
                    originalImage = UltraPrinter.FloydSteinbergDithering(originalImage);
                    pictureBox1.Image = originalImage;
                    textBoxPict.Text = openFileDialog.FileName;
                }
            }
        }

        private void PicturePictButt_Click(object sender, EventArgs e)
        {
            if (originalImage != null && folderPath != "")
            {
                try
                {
                    ((int, int), int[,], bool) a = UltraPrinter.UltraPrinterPrintImage(originalImage);
                    UltraPrinter.UltrakillMapGeneration(a.Item1, a.Item2, a.Item3, folderPath);
                    MessageBox.Show(UIAnswers[2]);
                }
                catch (Exception)
                {
                    MessageBox.Show(UIAnswers[3]);
                }
            }
            else
            {
                MessageBox.Show(UIAnswers[6]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 5)
            { label3.Show(); }
            else
            { label3.Hide(); }
            if (originalImage != null)
            {
                double sizePrintin = UltraPrinter.SizePrintComboBoxin(comboBox1);
                double scale = Math.Min((double)sizePrintin / original.Width, (double)sizePrintin / original.Height);
                int scaledWidth = (int)(original.Width * scale);
                int scaledHeight = (int)(original.Height * scale);
                originalImage = new Bitmap(original, scaledWidth, scaledHeight);
                originalImage = UltraPrinter.FloydSteinbergDithering(originalImage);
                pictureBox1.Image = originalImage;
            }
        }

        private void RusBut_Click(object sender, EventArgs e)
        {
            Translation.TranslateUI(UIlabel, UIbutton, UIAnswers, true);
        }

        private void EngBut_Click(object sender, EventArgs e)
        {
            Translation.TranslateUI(UIlabel, UIbutton, UIAnswers, false);
        }
    }
}
