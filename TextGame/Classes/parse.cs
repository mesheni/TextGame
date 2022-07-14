using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TextGame.Interfaces;

namespace TextGame.Classes
{
    internal class Parse : IPers, ILabel
    {
        int begin = 0, end = 0;
        IPers.Pers pers = new IPers.Pers();
        List<IPers.Pers> persList = new List<IPers.Pers>();
        

        ILabel.Label label = new ILabel.Label();
        List<ILabel.Label> labelList = new List<ILabel.Label>();

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
                pers.namePers = words[0];
                switch (words[1])
                {
                    case "red":
                        {
                            pers.colorPers = IPers.Pers.Color.red;
                            break;
                        }
                    case "green":
                        {
                            pers.colorPers = IPers.Pers.Color.green;
                            break;
                        }
                    case "blue":
                        {
                            pers.colorPers = IPers.Pers.Color.blue;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Такого цвета нет!");
                            break;
                        }
                }
                pers.aliasPers = words[2];
                persList.Add(pers);
            }
            return persList;
        }
        public void TextLabel(List<string> srt)
        {
            begin = 0; 
            end = 0;
            string[] words;
            for (int i = 0; i < srt.Count; i++)
            {
                
                if (srt[i].StartsWith("begin label:main"))
                {
                    MessageBox.Show(i.ToString());
                    begin = i;
                    label.beginLabel = begin;
                    words = srt[i].Split(new char[] { ':' });
                    label.nameLabel = words[1];
                }

                if (srt[i].StartsWith("end label:main"))
                {
                    MessageBox.Show(i.ToString());
                    end = i;
                    label.endLabel = end;
                }
            }
            for (int i = begin + 1; i < end; i++)
            {
                srt[i] = srt[i].Trim();
            }

        }
    }
}
