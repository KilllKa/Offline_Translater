using System;
using System.Windows.Forms;

namespace OfflineTranslator
{
    public partial class DictionaryForm : Form
    {
        private Translator _translator;
        
        public DictionaryForm(Translator translator)
        {
            InitializeComponent();
            _translator = translator;
            UpdateDictionaryList();
        }

        private void UpdateDictionaryList()
        {
            listBoxDictionary.Items.Clear();
            foreach (var kvp in _translator.GetDictionary())
            {
                listBoxDictionary.Items.Add($"{kvp.Key} -> {kvp.Value}");
            }
        }

        private void btnSelectJson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _translator.LoadDictionary(openFileDialog.FileName);
                    UpdateDictionaryList();
                }
            }
            
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            var word = txtWord.Text.Trim();
            var translation = txtTranslation.Text.Trim();

            if (!string.IsNullOrEmpty(word) && !string.IsNullOrEmpty(translation))
            {
                _translator.AddOrUpdateWord(word, translation);
                UpdateDictionaryList();
            }
        }

        private void btnSaveDictionary_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                DefaultExt = "json"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _translator.SaveDictionary(saveFileDialog.FileName);
            }
        }
    }
}