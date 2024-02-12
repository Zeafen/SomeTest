using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace Project_Ver3._0_
{
    public class Storage
    {
        public IList<IList<string>> Answers { get; set; }
        public IList<string> Texts { get; set; }

        public static IList<string> GetAsnwersByTxtNum(int text_number)
        {

            Storage storage = null;
            List<string>answers = new List<string>();
            using (var file = File.Open("Config.json", FileMode.OpenOrCreate))
            {

                if (file.Length > 0)
                {
                    storage = JsonSerializer.Deserialize<Storage>(file);
                }
            }
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    answers.AddRange(storage.Answers[text_number]);
                }
                return answers;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Config Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return null;
        }
        public static string GetTextByNum(int text_number)
        {
            Storage storage = new Storage();
            using (Stream file = File.Open("Config.json", FileMode.Open))
            {
                if (file.Length > 0)
                {
                    storage =  JsonSerializer.Deserialize<Storage>(file);
                }
            }
            try
            {
                return storage.Texts[text_number];
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Config Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return null;
        }
    }
}