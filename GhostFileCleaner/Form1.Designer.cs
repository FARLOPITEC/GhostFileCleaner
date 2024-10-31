namespace GhostFileCleaner
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
            button_directory = new Button();
            textBox1 = new TextBox();
            button_delete = new Button();
            button_metadata = new Button();
            checkBox_doxc = new CheckBox();
            checkBox_odt = new CheckBox();
            checkBox_pdf = new CheckBox();
            checkBox_xslx = new CheckBox();
            checkBox_csv = new CheckBox();
            checkBox_pptx = new CheckBox();
            checkBox_jpg = new CheckBox();
            checkBox_jpeg = new CheckBox();
            checkBox_png = new CheckBox();
            checkBox_xvid = new CheckBox();
            checkBox_mp4 = new CheckBox();
            checkBox_avi = new CheckBox();
            checkBox_all = new CheckBox();
            button_autodelete = new Button();
            SuspendLayout();
            // 
            // button_directory
            // 
            button_directory.Location = new Point(31, 45);
            button_directory.Name = "button_directory";
            button_directory.Size = new Size(81, 23);
            button_directory.TabIndex = 0;
            button_directory.Text = "Examine...";
            button_directory.UseVisualStyleBackColor = true;
            button_directory.Click += button_directory_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 23);
            textBox1.TabIndex = 1;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(330, 176);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(146, 65);
            button_delete.TabIndex = 7;
            button_delete.Text = "Delete file/directory";
            button_delete.UseVisualStyleBackColor = true;
            // 
            // button_metadata
            // 
            button_metadata.Location = new Point(178, 176);
            button_metadata.Name = "button_metadata";
            button_metadata.Size = new Size(146, 65);
            button_metadata.TabIndex = 17;
            button_metadata.Text = "Modifi metadata";
            button_metadata.UseVisualStyleBackColor = true;
            // 
            // checkBox_doxc
            // 
            checkBox_doxc.AutoSize = true;
            checkBox_doxc.Location = new Point(141, 100);
            checkBox_doxc.Name = "checkBox_doxc";
            checkBox_doxc.Size = new Size(55, 19);
            checkBox_doxc.TabIndex = 18;
            checkBox_doxc.Text = ".doxc";
            checkBox_doxc.UseVisualStyleBackColor = true;
            // 
            // checkBox_odt
            // 
            checkBox_odt.AutoSize = true;
            checkBox_odt.Location = new Point(202, 100);
            checkBox_odt.Name = "checkBox_odt";
            checkBox_odt.Size = new Size(47, 19);
            checkBox_odt.TabIndex = 19;
            checkBox_odt.Text = ".odt";
            checkBox_odt.UseVisualStyleBackColor = true;
            // 
            // checkBox_pdf
            // 
            checkBox_pdf.AutoSize = true;
            checkBox_pdf.Location = new Point(260, 100);
            checkBox_pdf.Name = "checkBox_pdf";
            checkBox_pdf.Size = new Size(47, 19);
            checkBox_pdf.TabIndex = 20;
            checkBox_pdf.Text = ".pdf";
            checkBox_pdf.UseVisualStyleBackColor = true;
            // 
            // checkBox_xslx
            // 
            checkBox_xslx.AutoSize = true;
            checkBox_xslx.Location = new Point(316, 100);
            checkBox_xslx.Name = "checkBox_xslx";
            checkBox_xslx.Size = new Size(49, 19);
            checkBox_xslx.TabIndex = 21;
            checkBox_xslx.Text = ".xslx";
            checkBox_xslx.UseVisualStyleBackColor = true;
            // 
            // checkBox_csv
            // 
            checkBox_csv.AutoSize = true;
            checkBox_csv.Location = new Point(373, 100);
            checkBox_csv.Name = "checkBox_csv";
            checkBox_csv.Size = new Size(46, 19);
            checkBox_csv.TabIndex = 23;
            checkBox_csv.Text = ".csv";
            checkBox_csv.UseVisualStyleBackColor = true;
            // 
            // checkBox_pptx
            // 
            checkBox_pptx.AutoSize = true;
            checkBox_pptx.Location = new Point(432, 100);
            checkBox_pptx.Name = "checkBox_pptx";
            checkBox_pptx.Size = new Size(53, 19);
            checkBox_pptx.TabIndex = 24;
            checkBox_pptx.Text = ".pptx";
            checkBox_pptx.UseVisualStyleBackColor = true;
            // 
            // checkBox_jpg
            // 
            checkBox_jpg.AutoSize = true;
            checkBox_jpg.Location = new Point(141, 137);
            checkBox_jpg.Name = "checkBox_jpg";
            checkBox_jpg.Size = new Size(46, 19);
            checkBox_jpg.TabIndex = 25;
            checkBox_jpg.Text = ".jpg";
            checkBox_jpg.UseVisualStyleBackColor = true;
            // 
            // checkBox_jpeg
            // 
            checkBox_jpeg.AutoSize = true;
            checkBox_jpeg.Location = new Point(202, 137);
            checkBox_jpeg.Name = "checkBox_jpeg";
            checkBox_jpeg.Size = new Size(52, 19);
            checkBox_jpeg.TabIndex = 26;
            checkBox_jpeg.Text = ".jpeg";
            checkBox_jpeg.UseVisualStyleBackColor = true;
            // 
            // checkBox_png
            // 
            checkBox_png.AutoSize = true;
            checkBox_png.Location = new Point(260, 137);
            checkBox_png.Name = "checkBox_png";
            checkBox_png.Size = new Size(50, 19);
            checkBox_png.TabIndex = 27;
            checkBox_png.Text = ".png";
            checkBox_png.UseVisualStyleBackColor = true;
            // 
            // checkBox_xvid
            // 
            checkBox_xvid.AutoSize = true;
            checkBox_xvid.Location = new Point(316, 137);
            checkBox_xvid.Name = "checkBox_xvid";
            checkBox_xvid.Size = new Size(51, 19);
            checkBox_xvid.TabIndex = 28;
            checkBox_xvid.Text = ".xvid";
            checkBox_xvid.UseVisualStyleBackColor = true;
            // 
            // checkBox_mp4
            // 
            checkBox_mp4.AutoSize = true;
            checkBox_mp4.Location = new Point(373, 137);
            checkBox_mp4.Name = "checkBox_mp4";
            checkBox_mp4.Size = new Size(53, 19);
            checkBox_mp4.TabIndex = 29;
            checkBox_mp4.Text = ".mp4";
            checkBox_mp4.UseVisualStyleBackColor = true;
            // 
            // checkBox_avi
            // 
            checkBox_avi.AutoSize = true;
            checkBox_avi.Location = new Point(432, 137);
            checkBox_avi.Name = "checkBox_avi";
            checkBox_avi.Size = new Size(44, 19);
            checkBox_avi.TabIndex = 30;
            checkBox_avi.Text = ".avi";
            checkBox_avi.UseVisualStyleBackColor = true;
            // 
            // checkBox_all
            // 
            checkBox_all.AutoSize = true;
            checkBox_all.Location = new Point(31, 115);
            checkBox_all.Name = "checkBox_all";
            checkBox_all.Size = new Size(113, 19);
            checkBox_all.TabIndex = 31;
            checkBox_all.Text = "all file/dfirectory";
            checkBox_all.UseVisualStyleBackColor = true;
            // 
            // button_autodelete
            // 
            button_autodelete.Location = new Point(26, 176);
            button_autodelete.Name = "button_autodelete";
            button_autodelete.Size = new Size(146, 65);
            button_autodelete.TabIndex = 32;
            button_autodelete.Text = "Auto Delete";
            button_autodelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 264);
            Controls.Add(button_autodelete);
            Controls.Add(checkBox_all);
            Controls.Add(checkBox_avi);
            Controls.Add(checkBox_mp4);
            Controls.Add(checkBox_xvid);
            Controls.Add(checkBox_png);
            Controls.Add(checkBox_jpeg);
            Controls.Add(checkBox_jpg);
            Controls.Add(checkBox_pptx);
            Controls.Add(checkBox_csv);
            Controls.Add(checkBox_xslx);
            Controls.Add(checkBox_pdf);
            Controls.Add(checkBox_odt);
            Controls.Add(checkBox_doxc);
            Controls.Add(button_metadata);
            Controls.Add(button_delete);
            Controls.Add(textBox1);
            Controls.Add(button_directory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_directory;
        private TextBox textBox1;
        private Button button_delete;
        private Button button_metadata;
        private CheckBox checkBox_doxc;
        private CheckBox checkBox_odt;
        private CheckBox checkBox_pdf;
        private CheckBox checkBox_xslx;
        private CheckBox checkBox_csv;
        private CheckBox checkBox_pptx;
        private CheckBox checkBox_jpg;
        private CheckBox checkBox_jpeg;
        private CheckBox checkBox_png;
        private CheckBox checkBox_xvid;
        private CheckBox checkBox_mp4;
        private CheckBox checkBox_avi;
        private CheckBox checkBox_all;
        private Button button_autodelete;
    }
}
