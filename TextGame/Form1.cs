using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TextGame.Classes;

namespace TextGame
{
    public partial class Form1 : Form
    {
        

        private Dialog dialog = new Dialog();
        public Form1()
        {
            InitializeComponent();

            openFileScript.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileScript.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void mainBut_Click(object sender, EventArgs e)
        {
            if (dialog.ToNotEmptyList() == false) // Если список пуст, то считывает файл со сценарием
            {
                //dialog.ReadScript();
                //mainBut.Text = "Далее...";
                MessageBox.Show("Сначала загрузите файл со сценарием!");
            }
            else
            {
                mainTextBox.Text = dialog.ShowScript(); // Вывод сценария построчно

                if (dialog.GameMode == false) // Окончание списка со сценарием - конец игры.
                {
                    mainBut.Visible = false;
                    mainLabel.Text = "Спасибо за игру!";
                }
            }  
        }

        private void readScriptButMenu_Click(object sender, EventArgs e)
        {
            if (openFileScript.ShowDialog() == DialogResult.Cancel)
                return;
            string pathFile = openFileScript.FileName;

            dialog.ReadScript(pathFile);
            mainBut.Text = "Далее...";
        }
    }
}
