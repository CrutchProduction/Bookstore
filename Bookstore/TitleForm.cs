using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBookstore;

namespace Bookstore
{
    public partial class TitleForm : Form
    {
        private static int curDifficulty = 0;
        public TitleForm()
        {
            InitializeComponent();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            labelChoiceGameMode.Text += " лёгкий ?";
            buttonNormal.Enabled = buttonNormal.Enabled == false;
            buttonHard.Enabled = buttonHard.Enabled == false;

            curDifficulty = 0;
            buttonsEasyNormalHard_Click();
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            labelChoiceGameMode.Text += " нормальный ?";
            buttonEasy.Enabled = buttonEasy.Enabled == false;
            buttonHard.Enabled = buttonHard.Enabled == false;

            curDifficulty = 1;
            buttonsEasyNormalHard_Click();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            labelChoiceGameMode.Text += " сложный ?";
            buttonEasy.Enabled = buttonEasy.Enabled == false;
            buttonNormal.Enabled = buttonNormal.Enabled == false;

            curDifficulty = 2;
            buttonsEasyNormalHard_Click();
        }

        private void TitleForm_Load(object sender, EventArgs e)
        {
            panelYesNo.Visible = false;
            labelAboutGame.Visible = false;
        }

        public void buttonsEasyNormalHard_Click()
        {
            panelYesNo.Visible = true;
            panelYesNo.Location = new Point(buttonEasy.Location.X - 100, buttonEasy.Location.Y);
            buttonAboutGame.Enabled = false;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            panelYesNo.Visible = false;
            labelChoiceGameMode.Text = "Вы уверены, что хотите начать игру в режиме";
            buttonEasy.Enabled = true;
            buttonNormal.Enabled = true;
            buttonHard.Enabled = true;
            buttonAboutGame.Enabled = true;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Program.yes = true;
            this.Close();
        }

        private void buttonAboutGame_Click(object sender, EventArgs e)
        {
            labelAboutGame.Visible = labelAboutGame.Visible == false;
        }

        public int GetCurDifficulty() { return curDifficulty; }
    }
}
