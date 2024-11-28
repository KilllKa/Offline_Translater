using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace OfflineTranslator
{
    public class Translator
    {
        private Dictionary<string, string> _dictionary;

        public Translator(string filePath)
        {
            LoadDictionary(filePath);
        }

        public void LoadDictionary(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                _dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
            else
            {
                _dictionary = new Dictionary<string, string>();
            }
        }

        public void SaveDictionary(string filePath)
        {
            var json = JsonConvert.SerializeObject(_dictionary, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public string TranslateText(string text)
        {
            var words = text.Split(' '); //StringSplitOptions.RemoveEmptyEntries
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i].ToLower();
                if (_dictionary.TryGetValue(word, out var translation))
                {
                    words[i] = translation;
                }
            }
            return string.Join(" ", words);
        }

        public void AddOrUpdateWord(string word, string translation)
        {
            _dictionary[word.ToLower()] = translation;
        }
        
        public Dictionary<string, string> GetDictionary() => _dictionary;
        
    }
}