using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FilesFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //загружаем путь к последней использованной папке
            LoadLastDirectory();

            ToolStripMenuItem copyMenuItemFilesNames = new ToolStripMenuItem("Copy");
            ToolStripMenuItem copyMenuItemNameSurname = new ToolStripMenuItem("Copy");
            ToolStripMenuItem copyMenuItemMissingFiles = new ToolStripMenuItem("Copy");
            ToolStripMenuItem pasteMenuItemFilesNames = new ToolStripMenuItem("Paste");
            ToolStripMenuItem pasteMenuItemNameSurname = new ToolStripMenuItem("Paste");
            ToolStripMenuItem pasteMenuItemMissingFiles = new ToolStripMenuItem("Paste");

            contextMenuStrip1.Items.AddRange(new[] { copyMenuItemFilesNames, pasteMenuItemFilesNames });
            contextMenuStrip2.Items.AddRange(new[] { copyMenuItemNameSurname, pasteMenuItemNameSurname });
            contextMenuStrip3.Items.AddRange(new[] { copyMenuItemMissingFiles, pasteMenuItemMissingFiles });

            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBoxChildrenName.ContextMenuStrip = contextMenuStrip2;
            missingFilesTextBox.ContextMenuStrip = contextMenuStrip3;

            copyMenuItemFilesNames.Click += copyToolStripMenuItem_Click;
            pasteMenuItemFilesNames.Click += pasteToolStripMenuItem_Click;

            copyMenuItemNameSurname.Click += copyToolNameSurname;
            pasteMenuItemNameSurname.Click += pasteToolNameSurname;

            copyMenuItemMissingFiles.Click += copyToolMissingFiles;
            pasteMenuItemMissingFiles.Click += pasteToolMissingFiles;
        }
        private string _lastPath;
        private string _lastPathFileName = "C:\\users\\Default\\FilesFinderLastPath.txt";
        private void LoadLastDirectory()
        {
            if (!File.Exists(_lastPathFileName)) return;
            StreamReader streamReader = new StreamReader(_lastPathFileName);
            _lastPath = streamReader.ReadToEnd();
            labelPathFiles.Text = _lastPath;
            filesExist = Directory.GetFiles(_lastPath);
            streamReader.Close();
        }

        private void SaveLastDirectory(string lastPath)
        {
            StreamWriter streamWriter = new StreamWriter(_lastPathFileName);
            streamWriter.Write(lastPath);
            streamWriter.Close();
        }

        //Получаем каталог с исходниками, создаём в нём новый каталог,
        //получаем список файлов, по каждому файлу из списка ищем в каталоге с исходниками нужный
        //если он найден - копируем его в новый каталог,
        //если не найден, записываем его имя в массив,
        //выводим список не найденных файлов в отдельное окно
        List<string> filesNotExist;
        string _filesNotExist;
        private void ButtonStartCopying_Click(object sender, EventArgs e)
        {
            if (richTextBoxChildrenName.Text == "")
            {
                MessageBox.Show("Не указана целевая папка.\nНекуда копировать!");
                return;

            } else if (filesNames == null)
            {
                MessageBox.Show("Не указаны имена файлов.\nНечего копировать!");
                return;
            }
            missingFilesTextBox.Enabled = true;
            CreateDirectoryAndCopyFiles();
        }

        private void CreateDirectoryAndCopyFiles()
        {
            string directoryPath = $"{_lastPath}\\{richTextBoxChildrenName.Text}";
            lblFinalPath.Text = directoryPath;
            Directory.CreateDirectory(directoryPath);
            //
            filesNotExist = new List<string>();
            int filesCopyCount = 0;
            bool isCopying = false;
            foreach (string names in filesNames)
            {
                isCopying = false;
                foreach (string files in filesExist)
                {
                    string fname1 = Path.GetFileNameWithoutExtension(files);
                    if (fname1 == names)
                    {
                        File.Copy(Path.Combine(_lastPath, files.Substring(_lastPath.Length + 1)),
                                  Path.Combine(lblFinalPath.Text, files.Substring(_lastPath.Length + 1)), true);
                        filesCopyCount++;
                        isCopying = true;
                    }
                }
                if (!isCopying)
                {
                    filesNotExist.Add(names);
                }
            }
            if (filesNotExist.Count > 0)
            {
                foreach (string f in filesNotExist)
                {
                    _filesNotExist += $"{f} ";
                }
            }
            MessageBox.Show($"Скопировано {filesCopyCount} файлов!\nНе найдено {filesNames.Length - filesCopyCount} файлов\nВот они: {_filesNotExist}");
            missingFilesTextBox.Text = _filesNotExist;
            _filesNotExist = null;
        }


        string[] filesExist;

        FileInfo[] filesExistInfo;
        //открываем каталог и получаем список файлов в нём лежащих, полный путь к файлу
        private void opedFolder_Click(object sender, EventArgs e)
        {
            LoadFilesFullPath();
        }

        private void LoadFilesFullPath()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                labelPathFiles.Text = folderBrowserDialog1.SelectedPath;
                filesExist = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                _lastPath = folderBrowserDialog1.SelectedPath;
                SaveLastDirectory(_lastPath);
            }
        }

        public string[] filesNames;
        // Разбивает текст из окна на отдельные слова и помещает их в массив
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string Spisoc = richTextBox1.Text;
            filesNames = Spisoc.Split(' ');
        }

        private void ButtonMessage()
        {
            if (filesNames != null)
            {
                lblFinalPath.Text = filesNames[0];
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Context Menu

        private ContextMenuStrip _contextMenuStrip;
        private void CopyText(RichTextBox richTextBox)
        {
            if (richTextBox.SelectedText == "") return;
            Clipboard.SetText(richTextBox.SelectedText);
        }

        private void PasteText(RichTextBox richTextBox)
        {
            richTextBox.Paste();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText(richTextBox1);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteText(richTextBox1);
        }

        private void copyToolNameSurname(object sender, EventArgs e)
        {
            CopyText(richTextBoxChildrenName);
        }
        private void pasteToolNameSurname(object sender, EventArgs e)
        {
            PasteText(richTextBoxChildrenName);
        }

        private void copyToolMissingFiles(object sender, EventArgs e)
        {
            CopyText(missingFilesTextBox);
        }

        private void pasteToolMissingFiles(Object sender, EventArgs e)
        {
            PasteText(missingFilesTextBox);
        }
        #endregion
    }
}
