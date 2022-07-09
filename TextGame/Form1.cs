using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextGame.Classes;

namespace TextGame
{
    public partial class Form1 : Form
    {
        Dialog dialog = new Dialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void mainBut_Click(object sender, EventArgs e)
        {
            if (dialog.ToNotEmptyList() == false) // Если список пуст, то считывает файл со сценарием
            {
                dialog.ReadScript();
                mainBut.Text = "Далее...";
            }

            mainTextBox.Text = dialog.ShowScript(); // Вывод сценария построчно

            if (dialog.GameMode == false) // Окончание списка со сценарием - конец игры.
            {
                mainBut.Visible = false;
                mainLabel.Text = "Спасибо за игру!";
            }
        }
    }
}
