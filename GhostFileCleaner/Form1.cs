using System.Diagnostics;

namespace GhostFileCleaner
{
    public partial class Form1 : Form
    {
        private ListBox listBox_deletedFiles;

        public Form1()
        {
            InitializeComponent();
            checkBox_all.CheckedChanged += checkBox_all_CheckedChanged;
            button_delete.Click += button_delete_Click;
            button_autodelete.Click += button_autodelete_Click;

            // Inicializar el ListBox
            listBox_deletedFiles = new ListBox
            {
                Location = new Point(500, 45),
                Size = new Size(250, 196),
                Name = "listBox_deletedFiles"
            };
            Controls.Add(listBox_deletedFiles);
            listBox_deletedFiles.SelectedIndexChanged += listBox_deletefile_SelectedIndexChanged;
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
            using (OpenFileDialog folderDialog = new OpenFileDialog())
            {
                folderDialog.ValidateNames = false;
                folderDialog.CheckFileExists = false;
                folderDialog.CheckPathExists = true;
                folderDialog.FileName = "Selecciona una carpeta";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string? folderPath = Path.GetDirectoryName(folderDialog.FileName);
                    if (folderPath != null)
                    {
                        this.textBox1.Text = folderPath; // Mostrar la ruta de la carpeta en textBox1
                    }
                }
            }
        }

        // Botón para borrar ficheros
        private void button_delete_Click(object? sender, EventArgs e)
        {
            DeleteFiles();
        }

        private void DeleteFiles()
        {
            string folderPath = textBox1.Text;
            if (Directory.Exists(folderPath))
            {
                var extensionsToDelete = new List<string>();
                var deletedFiles = new List<string>();

                if (checkBox_all.Checked)
                {
                    // Eliminar todos los archivos en la carpeta
                    var allFiles = Directory.GetFiles(folderPath);
                    foreach (var file in allFiles)
                    {
                        File.Delete(file);
                        deletedFiles.Add(file);
                    }
                }
                else
                {
                    if (checkBox_doxc.Checked) extensionsToDelete.Add(".docx");
                    if (checkBox_xslx.Checked) extensionsToDelete.Add(".xlsx");
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
                            deletedFiles.Add(file);
                        }
                    }
                }

                // Mostrar archivos eliminados en el ListBox
                foreach (var file in deletedFiles)
                {
                    listBox_deletedFiles.Items.Add($"{Path.GetFileName(file)} eliminado...");
                }

                MessageBox.Show("Archivos eliminados correctamente.");
            }
            else
            {
                MessageBox.Show("La carpeta especificada no existe.");
            }
        }

        // Botón para autodestruir el script y eliminar archivos seleccionados
        private void button_autodelete_Click(object? sender, EventArgs e)
        {
            // Eliminar el propio programa
            string exePath = Application.ExecutablePath;
            Process.Start(new ProcessStartInfo()
            {
                Arguments = $"/C choice /C Y /N /D Y /T 3 & Del \"{exePath}\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
            });
            Application.Exit();
        }

        private void listBox_deletefile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_deletedFiles.SelectedItem != null)
            {
                string selectedFile = listBox_deletedFiles.SelectedItem.ToString();
                MessageBox.Show($"Has seleccionado: {selectedFile}", "Archivo Seleccionado");
            }
        }
    }
}