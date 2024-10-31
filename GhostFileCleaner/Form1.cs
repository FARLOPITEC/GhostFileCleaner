using System.IO;
using System.Security.Cryptography;

namespace GhostFileCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox_all.CheckedChanged += checkBox_all_CheckedChanged;
            button_delete.Click += button_delete_Click;
            button_autodelete.Click += button_autodelete_Click; // Agrega el evento para el botón autodelete
        }

        // Marca todos los demás CheckBoxes
        private void checkBox_all_CheckedChanged(object? sender, EventArgs e)
        {
            bool isChecked = checkBox_all.Checked;
            checkBox_doxc.Checked = isChecked;
            checkBox_xslx.Checked = isChecked;
            checkBox_pdf.Checked = isChecked;
            checkBox_avi.Checked = isChecked;
            checkBox_xvid.Checked = isChecked;
            checkBox_csv.Checked = isChecked;
            checkBox_pptx.Checked = isChecked;
            checkBox_jpg.Checked = isChecked;
            checkBox_jpeg.Checked = isChecked;
            checkBox_png.Checked = isChecked;
            checkBox_mp4.Checked = isChecked;
            checkBox_odt.Checked = isChecked;
        }

        // Botón para seleccionar un directorio
        private void button_directory_Click(object? sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new())
            {
                folderDialog.Description = "Selecciona una carpeta";
                folderDialog.UseDescriptionForTitle = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    this.textBox1.Text = folderPath; // Mostrar la ruta de la carpeta en textBox1
                }
            }
        }

        // Botón para borrar ficheros
        private void button_delete_Click(object? sender, EventArgs e)
        {
            string folderPath = textBox1.Text;
            if (Directory.Exists(folderPath))
            {
                if (checkBox_all.Checked)
                {
                    // Eliminar todos los archivos en la carpeta
                    var allFiles = Directory.GetFiles(folderPath);
                    foreach (var file in allFiles)
                    {
                        File.Delete(file);
                    }
                }
                else
                {
                    var extensionsToDelete = new List<string>();
                    if (checkBox_doxc.Checked) extensionsToDelete.Add(".doxc");
                    if (checkBox_xslx.Checked) extensionsToDelete.Add(".xslx");
                    if (checkBox_pdf.Checked) extensionsToDelete.Add(".pdf");
                    if (checkBox_avi.Checked) extensionsToDelete.Add(".avi");
                    if (checkBox_xvid.Checked) extensionsToDelete.Add(".xvid");
                    if (checkBox_csv.Checked) extensionsToDelete.Add(".csv");
                    if (checkBox_pptx.Checked) extensionsToDelete.Add(".pptx");
                    if (checkBox_jpg.Checked) extensionsToDelete.Add(".jpg");
                    if (checkBox_jpeg.Checked) extensionsToDelete.Add(".jpeg");
                    if (checkBox_png.Checked) extensionsToDelete.Add(".png");
                    if (checkBox_mp4.Checked) extensionsToDelete.Add(".mp4");
                    if (checkBox_odt.Checked) extensionsToDelete.Add(".odt");

                    foreach (var extension in extensionsToDelete)
                    {
                        var files = Directory.GetFiles(folderPath, $"*{extension}");
                        foreach (var file in files)
                        {
                            File.Delete(file);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("La carpeta especificada no existe.");
            }
        }

        // Botón para autodestruir el script
        private void button_autodelete_Click(object? sender, EventArgs e)
        {
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Form1.cs");
            if (File.Exists(scriptPath))
            {
                File.Delete(scriptPath);
                MessageBox.Show("El script ha sido eliminado.");
            }
            else
            {
                MessageBox.Show("El script no se encontró.");
            }
        }
    }
}
