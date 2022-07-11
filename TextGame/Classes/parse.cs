using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TextGame.Interfaces;

namespace TextGame.Classes
{
    internal class Parse : IPers
    {
        StringBuilder sb = new StringBuilder();

        int begin = 0, end = 0;
        List<IPers.Pers> persList = new List<IPers.Pers>();
        IPers.Pers pers = new IPers.Pers();

        public List<IPers.Pers> TextPers(List<string> srt)
        {
            for (int i = 0; i < srt.Count; i++)
            {
                if (srt[i].StartsWith("begin pers"))
                {
                    //MessageBox.Show(i.ToString());
                    begin = i;
                }
                    
                if (srt[i].StartsWith("end pers"))
                {
                    //MessageBox.Show(i.ToString());
                    end = i;
                }
            }
            for (int i = begin + 1; i < end; i++)
            {
                srt[i] = srt[i].Trim();
                string[] words = srt[i].Split(new char[] { ':' });
                //MessageBox.Show(srt[i]);
                //MessageBox.Show(words[0] + "\n" + words[1]);
                pers.NamePers = words[0];
                switch (words[1])
                {
                    case "red":
                        {
                            pers.colorPers = IPers.Pers.ColorPers.red;
                            break;
                        }
                    case "green":
                        {
                            pers.colorPers = IPers.Pers.ColorPers.green;
                            break;
                        }
                    case "blue":
                        {
                            pers.colorPers = IPers.Pers.ColorPers.blue;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Такого цвета нет!");
                            break;
                        }
                }
                persList.Add(pers);
            }
            return persList;
        }
    }
}
