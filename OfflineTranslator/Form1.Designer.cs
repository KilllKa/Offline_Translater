namespace OfflineTranslator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowseTxt = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnManageDictionary = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtOriginalText = new System.Windows.Forms.TextBox();
            this.txtTranslatedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReloadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowseTxt
            // 
            this.btnBrowseTxt.Location = new System.Drawing.Point(246, 86);
            this.btnBrowseTxt.Name = "btnBrowseTxt";
            this.btnBrowseTxt.Size = new System.Drawing.Size(156, 37);
            this.btnBrowseTxt.TabIndex = 0;
            this.btnBrowseTxt.Text = "Выбрать путь...";
            this.btnBrowseTxt.UseVisualStyleBackColor = true;
            this.btnBrowseTxt.Click += new System.EventHandler(this.btnBrowseTxt_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(408, 272);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(153, 91);
            this.btnTranslate.TabIndex = 1;
            this.btnTranslate.Text = "Перевести";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnManageDictionary
            // 
            this.btnManageDictionary.Location = new System.Drawing.Point(490, 58);
            this.btnManageDictionary.Name = "btnManageDictionary";
            this.btnManageDictionary.Size = new System.Drawing.Size(287, 65);
            this.btnManageDictionary.TabIndex = 2;
            this.btnManageDictionary.Text = "Открыть словарь";
            this.btnManageDictionary.UseVisualStyleBackColor = true;
            this.btnManageDictionary.Click += new System.EventHandler(this.btnManageDictionary_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(35, 58);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(367, 22);
            this.txtFilePath.TabIndex = 3;
            // 
            // txtOriginalText
            // 
            this.txtOriginalText.Location = new System.Drawing.Point(35, 217);
            this.txtOriginalText.Multiline = true;
            this.txtOriginalText.Name = "txtOriginalText";
            this.txtOriginalText.ReadOnly = true;
            this.txtOriginalText.Size = new System.Drawing.Size(346, 194);
            this.txtOriginalText.TabIndex = 4;
            // 
            // txtTranslatedText
            // 
            this.txtTranslatedText.Location = new System.Drawing.Point(588, 217);
            this.txtTranslatedText.Multiline = true;
            this.txtTranslatedText.Name = "txtTranslatedText";
            this.txtTranslatedText.ReadOnly = true;
            this.txtTranslatedText.Size = new System.Drawing.Size(346, 194);
            this.txtTranslatedText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Путь к файлу";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Исходный текст";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(588, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Переведенный текст";
            // 
            // btnReloadFile
            // 
            this.btnReloadFile.Location = new System.Drawing.Point(35, 86);
            this.btnReloadFile.Name = "btnReloadFile";
            this.btnReloadFile.Size = new System.Drawing.Size(156, 37);
            this.btnReloadFile.TabIndex = 9;
            this.btnReloadFile.Text = "Обновить текст";
            this.btnReloadFile.UseVisualStyleBackColor = true;
            this.btnReloadFile.Click += new System.EventHandler(this.btnReloadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.btnReloadFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTranslatedText);
            this.Controls.Add(this.txtOriginalText);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnManageDictionary);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.btnBrowseTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnReloadFile;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnBrowseTxt;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnManageDictionary;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtOriginalText;
        private System.Windows.Forms.TextBox txtTranslatedText;

        #endregion
    }
}