namespace FilesFinder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartCopying = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.opedFolder = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.labelPathFiles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxChildrenName = new System.Windows.Forms.RichTextBox();
            this.lblFinalPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.missingFilesTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnStartCopying
            // 
            this.btnStartCopying.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStartCopying.Location = new System.Drawing.Point(12, 414);
            this.btnStartCopying.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartCopying.Name = "btnStartCopying";
            this.btnStartCopying.Size = new System.Drawing.Size(226, 66);
            this.btnStartCopying.TabIndex = 4;
            this.btnStartCopying.Text = "Запустить копирование";
            this.btnStartCopying.UseVisualStyleBackColor = false;
            this.btnStartCopying.Click += new System.EventHandler(this.ButtonStartCopying_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 208);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(857, 183);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // opedFolder
            // 
            this.opedFolder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.opedFolder.Location = new System.Drawing.Point(12, 21);
            this.opedFolder.Name = "opedFolder";
            this.opedFolder.Size = new System.Drawing.Size(226, 53);
            this.opedFolder.TabIndex = 1;
            this.opedFolder.Text = "Открыть папку с исходниками";
            this.opedFolder.UseVisualStyleBackColor = false;
            this.opedFolder.Click += new System.EventHandler(this.opedFolder_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Info;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.Location = new System.Drawing.Point(769, 765);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 32);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // labelPathFiles
            // 
            this.labelPathFiles.AutoSize = true;
            this.labelPathFiles.Location = new System.Drawing.Point(245, 39);
            this.labelPathFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPathFiles.Name = "labelPathFiles";
            this.labelPathFiles.Size = new System.Drawing.Size(129, 16);
            this.labelPathFiles.TabIndex = 6;
            this.labelPathFiles.Text = "Путь к исходникам";
            this.labelPathFiles.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Скорпируй список файлов в это поле:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия и Имя ребёнка (создаст папку с его фамилией и именем)";
            // 
            // richTextBoxChildrenName
            // 
            this.richTextBoxChildrenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxChildrenName.Location = new System.Drawing.Point(12, 116);
            this.richTextBoxChildrenName.Name = "richTextBoxChildrenName";
            this.richTextBoxChildrenName.Size = new System.Drawing.Size(857, 29);
            this.richTextBoxChildrenName.TabIndex = 2;
            this.richTextBoxChildrenName.Text = "";
            this.richTextBoxChildrenName.TextChanged += new System.EventHandler(this.richTextBoxChildrenName_TextChanged);
            // 
            // lblFinalPath
            // 
            this.lblFinalPath.AutoSize = true;
            this.lblFinalPath.Location = new System.Drawing.Point(260, 439);
            this.lblFinalPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalPath.Name = "lblFinalPath";
            this.lblFinalPath.Size = new System.Drawing.Size(122, 16);
            this.lblFinalPath.TabIndex = 0;
            this.lblFinalPath.Text = "Финальная папка";
            this.lblFinalPath.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 496);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "!!! Если в папке уже есть файл с таким именем - он перезапишется";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // missingFilesTextBox
            // 
            this.missingFilesTextBox.Enabled = false;
            this.missingFilesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.missingFilesTextBox.Location = new System.Drawing.Point(12, 579);
            this.missingFilesTextBox.Name = "missingFilesTextBox";
            this.missingFilesTextBox.Size = new System.Drawing.Size(857, 123);
            this.missingFilesTextBox.TabIndex = 12;
            this.missingFilesTextBox.Text = "";
            this.missingFilesTextBox.TextChanged += new System.EventHandler(this.missingFilesTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 555);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ненайденные файлы:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(881, 809);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.missingFilesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxChildrenName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPathFiles);
            this.Controls.Add(this.btnStartCopying);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblFinalPath);
            this.Controls.Add(this.opedFolder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Files Finder version 0.2.16.04.2024";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartCopying;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button opedFolder;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label labelPathFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxChildrenName;
        private System.Windows.Forms.Label lblFinalPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox missingFilesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
    }
}

