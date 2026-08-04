namespace UltraPrinter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            OpenFileButt = new Button();
            OpenFolderButt = new Button();
            labelFile = new Label();
            textBoxFile = new TextBox();
            textBoxFolder = new TextBox();
            labelFolder = new Label();
            MatrixPictureButt = new Button();
            panel1 = new Panel();
            PicturePictButt = new Button();
            textBoxPict = new TextBox();
            labelPict = new Label();
            OpenPictButt = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            Author = new Label();
            RusBut = new Button();
            EngBut = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OpenFileButt
            // 
            OpenFileButt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpenFileButt.Location = new Point(4, 3);
            OpenFileButt.Name = "OpenFileButt";
            OpenFileButt.Size = new Size(377, 41);
            OpenFileButt.TabIndex = 0;
            OpenFileButt.Text = "Выбрать файл для чтения (матрица, формат .txt)";
            OpenFileButt.UseVisualStyleBackColor = true;
            OpenFileButt.Click += OpenFileButt_Click;
            // 
            // OpenFolderButt
            // 
            OpenFolderButt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpenFolderButt.Location = new Point(4, 88);
            OpenFolderButt.Name = "OpenFolderButt";
            OpenFolderButt.Size = new Size(377, 41);
            OpenFolderButt.TabIndex = 1;
            OpenFolderButt.Text = "Выбрать папку для сохранения карт";
            OpenFolderButt.UseVisualStyleBackColor = true;
            OpenFolderButt.Click += OpenFolderButt_Click;
            // 
            // labelFile
            // 
            labelFile.AutoSize = true;
            labelFile.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFile.Location = new Point(4, 56);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(135, 20);
            labelFile.TabIndex = 2;
            labelFile.Text = "Выбранный файл:";
            // 
            // textBoxFile
            // 
            textBoxFile.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFile.Location = new Point(145, 50);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.ReadOnly = true;
            textBoxFile.Size = new Size(236, 27);
            textBoxFile.TabIndex = 3;
            // 
            // textBoxFolder
            // 
            textBoxFolder.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFolder.Location = new Point(145, 136);
            textBoxFolder.Name = "textBoxFolder";
            textBoxFolder.ReadOnly = true;
            textBoxFolder.Size = new Size(236, 27);
            textBoxFolder.TabIndex = 5;
            // 
            // labelFolder
            // 
            labelFolder.AutoSize = true;
            labelFolder.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFolder.Location = new Point(4, 142);
            labelFolder.Name = "labelFolder";
            labelFolder.Size = new Size(135, 20);
            labelFolder.TabIndex = 4;
            labelFolder.Text = "Выбранный файл:";
            // 
            // MatrixPictureButt
            // 
            MatrixPictureButt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MatrixPictureButt.Location = new Point(4, 268);
            MatrixPictureButt.Name = "MatrixPictureButt";
            MatrixPictureButt.Size = new Size(377, 41);
            MatrixPictureButt.TabIndex = 6;
            MatrixPictureButt.Text = "Коневертировать матрицу в карту";
            MatrixPictureButt.UseVisualStyleBackColor = true;
            MatrixPictureButt.Click += MatrixPictureButt_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(PicturePictButt);
            panel1.Controls.Add(textBoxPict);
            panel1.Controls.Add(labelPict);
            panel1.Controls.Add(OpenPictButt);
            panel1.Controls.Add(MatrixPictureButt);
            panel1.Controls.Add(textBoxFolder);
            panel1.Controls.Add(labelFolder);
            panel1.Controls.Add(textBoxFile);
            panel1.Controls.Add(labelFile);
            panel1.Controls.Add(OpenFolderButt);
            panel1.Controls.Add(OpenFileButt);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 426);
            panel1.TabIndex = 7;
            // 
            // PicturePictButt
            // 
            PicturePictButt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PicturePictButt.Location = new Point(4, 315);
            PicturePictButt.Name = "PicturePictButt";
            PicturePictButt.Size = new Size(377, 41);
            PicturePictButt.TabIndex = 10;
            PicturePictButt.Text = "Коневертировать изображение в карту";
            PicturePictButt.UseVisualStyleBackColor = true;
            PicturePictButt.Click += PicturePictButt_Click;
            // 
            // textBoxPict
            // 
            textBoxPict.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPict.Location = new Point(145, 226);
            textBoxPict.Name = "textBoxPict";
            textBoxPict.ReadOnly = true;
            textBoxPict.Size = new Size(236, 27);
            textBoxPict.TabIndex = 9;
            // 
            // labelPict
            // 
            labelPict.AutoSize = true;
            labelPict.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPict.Location = new Point(4, 232);
            labelPict.Name = "labelPict";
            labelPict.Size = new Size(135, 20);
            labelPict.TabIndex = 8;
            labelPict.Text = "Выбранный файл:";
            // 
            // OpenPictButt
            // 
            OpenPictButt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpenPictButt.Location = new Point(6, 179);
            OpenPictButt.Name = "OpenPictButt";
            OpenPictButt.Size = new Size(377, 41);
            OpenPictButt.TabIndex = 7;
            OpenPictButt.Text = "Выбрать изображение для чтения";
            OpenPictButt.UseVisualStyleBackColor = true;
            OpenPictButt.Click += OpenPictButt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(404, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 321);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(404, 15);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 9;
            label1.Text = "Миниатюра изображения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(404, 371);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 10;
            label2.Text = "Размер принтинга:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(404, 394);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(321, 29);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(404, 426);
            label3.Name = "label3";
            label3.Size = new Size(290, 45);
            label3.TabIndex = 12;
            label3.Text = "Внимание! Выбор 256x256 сильно нагружает\r\nUltrakill. Выбор 512x512 и 1024х1024 потенциально\r\nмогут привести к зависанию игры";
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Author.Location = new Point(12, 453);
            Author.Name = "Author";
            Author.Size = new Size(182, 20);
            Author.TabIndex = 13;
            Author.Text = "UltraPrinter by Superkotek";
            // 
            // RusBut
            // 
            RusBut.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RusBut.Location = new Point(211, 444);
            RusBut.Name = "RusBut";
            RusBut.Size = new Size(80, 32);
            RusBut.TabIndex = 14;
            RusBut.Text = "Русский";
            RusBut.UseVisualStyleBackColor = true;
            RusBut.Click += RusBut_Click;
            // 
            // EngBut
            // 
            EngBut.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EngBut.Location = new Point(297, 444);
            EngBut.Name = "EngBut";
            EngBut.Size = new Size(80, 32);
            EngBut.TabIndex = 15;
            EngBut.Text = "English";
            EngBut.UseVisualStyleBackColor = true;
            EngBut.Click += EngBut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 482);
            Controls.Add(EngBut);
            Controls.Add(RusBut);
            Controls.Add(Author);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "UltraPrinter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenFileButt;
        private Button OpenFolderButt;
        private Label labelFile;
        private TextBox textBoxFile;
        private TextBox textBoxFolder;
        private Label labelFolder;
        private Button MatrixPictureButt;
        private Panel panel1;
        private Button OpenPictButt;
        private TextBox textBoxPict;
        private Label labelPict;
        private PictureBox pictureBox1;
        private Label label1;
        private Button PicturePictButt;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label Author;
        private Button RusBut;
        private Button EngBut;
    }
}
