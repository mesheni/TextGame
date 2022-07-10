using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextGame.Classes
{
    internal class Dialog
    {
        private List<string> script = new List<string>(); // Список в котором хранится файл сценария
        private static int count = -1; // Указатель, который пробегает по строкам списка
        private static bool gamemode = true; // Если false, то игра закончена
        public bool GameMode { get { return gamemode; } } 

        public bool ToNotEmptyList() // Проверяет список на пустоту
        {
            if (script.Count > 0) return true;
            else return false;
        }

        public async void ReadScript() // Читает сценарий из файла и построчно записывает в список
        {
            await Task.Run(() =>
            {
                string path = @"Script\script.txt";

                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        script.Add(line);
                    }
                }
            });
            await Task.Run(() => MessageBox.Show("Файл прочитан!"));
        }

        public string ShowScript() // Возвращает строки из списка
        {
            try
            {
                count++;
                return script[count].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ОШИБКА!");
                gamemode = false;
                return "Конец";
            }
        }
    }
}
