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
using Newtonsoft.Json;

namespace OfflineTranslator
{
    public partial class Form1 : Form
    {
        private Translator _translator;
        private Dictionary<string, string> _dictionary  = new Dictionary<string, string>();
        private string _dictionaryPath = "dictionary.json";
        private string _currentTextFilePath;
        public Form1()
        {
            InitializeComponent();
            _translator = new Translator("dictionary.json");
        }


        private void LoadDefaultDictionary()
        {
            if (File.Exists(_dictionaryPath))
            {
                _dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(_dictionaryPath));
            }
            else
            {
                MessageBox.Show("Файл словаря по умолчанию не найден. Пожалуйста, выберите словарь вручную.");
            }
        }
        private void LoadDictionary(string path)
        {
            if (File.Exists(path))
            {
                _dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(path));
                _dictionaryPath = path; // Обновляем путь для дальнейших сохранений
            }
            else
            {
                MessageBox.Show("Файл словаря не найден.");
            }
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
        
        private void LoadTextFile(string path)
        {
            if (File.Exists(path))
            {
                _currentTextFilePath = path;
                txtOriginalText.Text = File.ReadAllText(path);
            }
            else
            {
                MessageBox.Show("Файл для перевода не найден.");
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_currentTextFilePath))
            {
                LoadTextFile(_currentTextFilePath); // Загружаем свежий текст
            }

            var translatedText = _translator.TranslateText(txtOriginalText.Text);
            txtTranslatedText.Text = translatedText;
        }

        private void btnManageDictionary_Click(object sender, EventArgs e)
        {
            using (var dictionaryForm = new DictionaryForm(_translator))
            {
                dictionaryForm.ShowDialog();
            }
        }

        private void btnReloadFile_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                try
                {
                    txtOriginalText.Text = File.ReadAllText(filePath);
                    MessageBox.Show("Текст успешно обновлен из файла.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении текста: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Файл для перевода не выбран или отсутствует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}