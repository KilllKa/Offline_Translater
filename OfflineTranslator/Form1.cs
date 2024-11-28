using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OfflineTranslator
{
    public partial class Form1 : Form
    {
        private Translator _translator;
        public Form1()
        {
            InitializeComponent();
            _translator = new Translator("dictionary.json");
        }


        private void btnBrowseTxt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                    txtOriginalText.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            var originalText = txtOriginalText.Text;
            var translatedText = _translator.TranslateText(originalText);
            txtTranslatedText.Text = translatedText;
        }

        private void btnManageDictionary_Click(object sender, EventArgs e)
        {
            using (var dictionaryForm = new DictionaryForm(_translator))
            {
                dictionaryForm.ShowDialog();
            }
        }
    }
}