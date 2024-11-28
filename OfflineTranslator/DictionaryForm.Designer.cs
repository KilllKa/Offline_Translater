using System.ComponentModel;

namespace OfflineTranslator
{
    partial class DictionaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.listBoxDictionary = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectJson = new System.Windows.Forms.Button();
            this.btnSaveDictionary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(58, 118);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(165, 22);
            this.txtWord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(60, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите новое слово";
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(337, 117);
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(169, 22);
            this.txtTranslation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(341, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите его перевод";
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Location = new System.Drawing.Point(194, 180);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(162, 27);
            this.btnAddOrUpdate.TabIndex = 4;
            this.btnAddOrUpdate.Text = "Добавить/Обновить";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // listBoxDictionary
            // 
            this.listBoxDictionary.FormattingEnabled = true;
            this.listBoxDictionary.ItemHeight = 16;
            this.listBoxDictionary.Location = new System.Drawing.Point(48, 287);
            this.listBoxDictionary.Name = "listBoxDictionary";
            this.listBoxDictionary.Size = new System.Drawing.Size(120, 84);
            this.listBoxDictionary.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(51, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текущий словарь";
            // 
            // btnSelectJson
            // 
            this.btnSelectJson.Location = new System.Drawing.Point(288, 276);
            this.btnSelectJson.Name = "btnSelectJson";
            this.btnSelectJson.Size = new System.Drawing.Size(147, 23);
            this.btnSelectJson.TabIndex = 7;
            this.btnSelectJson.Text = "Выбор словаря";
            this.btnSelectJson.UseVisualStyleBackColor = true;
            this.btnSelectJson.Click += new System.EventHandler(this.btnSelectJson_Click);
            // 
            // btnSaveDictionary
            // 
            this.btnSaveDictionary.Location = new System.Drawing.Point(487, 281);
            this.btnSaveDictionary.Name = "btnSaveDictionary";
            this.btnSaveDictionary.Size = new System.Drawing.Size(106, 23);
            this.btnSaveDictionary.TabIndex = 8;
            this.btnSaveDictionary.Text = "Сохранить";
            this.btnSaveDictionary.UseVisualStyleBackColor = true;
            this.btnSaveDictionary.Click += new System.EventHandler(this.btnSaveDictionary_Click);
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveDictionary);
            this.Controls.Add(this.btnSelectJson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxDictionary);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWord);
            this.Name = "DictionaryForm";
            this.Text = "DictionaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnSaveDictionary;

        private System.Windows.Forms.Button btnSelectJson;

        private System.Windows.Forms.ListBox listBoxDictionary;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button btnAddOrUpdate;

        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtWord;

        #endregion
    }
}