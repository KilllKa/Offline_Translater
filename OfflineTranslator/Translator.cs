using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

        private string Transliterate(string word)
        {
            var transliterationMap = new Dictionary<char, string>
            {
                {'а', "a"}, {'б', "b"}, {'в', "v"}, {'г', "g"}, {'д', "d"},
                {'е', "e"}, {'ё', "yo"}, {'ж', "zh"}, {'з', "z"}, {'и', "i"},
                {'й', "y"}, {'к', "k"}, {'л', "l"}, {'м', "m"}, {'н', "n"},
                {'о', "o"}, {'п', "p"}, {'р', "r"}, {'с', "s"}, {'т', "t"},
                {'у', "u"}, {'ф', "f"}, {'х', "kh"}, {'ц', "ts"}, {'ч', "ch"},
                {'ш', "sh"}, {'щ', "shch"}, {'ъ', ""}, {'ы', "y"}, {'ь', ""},
                {'э', "e"}, {'ю', "yu"}, {'я', "ya"}
            };

            var result = new StringBuilder();
            foreach (var ch in word)
            {
                if (transliterationMap.TryGetValue(char.ToLower(ch), out var translitChar))
                {
                    result.Append(char.IsUpper(ch) ? 
                        char.ToUpper(translitChar[0]) + translitChar.Substring(1) : translitChar);
                }
                else
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }
        
        public string TranslateText(string text)
        {
            var words = text.Split(new [] {' ', '\n', '\t', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            
            var result = new StringBuilder();
            foreach (var word in words)
            {
                if (_dictionary.TryGetValue(word.ToLower(), out var translation))
                {
                    result.Append(translation + " ");
                }
                else
                {
                    result.Append(Transliterate(word) + " "); // Используем транслитерацию
                }
            }
            return result.ToString().Trim();
        }

        public void AddOrUpdateWord(string word, string translation)
        {
            _dictionary[word.ToLower()] = translation;
        }
        
        public Dictionary<string, string> GetDictionary() => _dictionary;
        
    }
}