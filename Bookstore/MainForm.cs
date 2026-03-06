using System.Security.Cryptography.X509Certificates;

namespace Bookstore
{
    public partial class Store : Form
    {
        private Button[] buttons;
        public Store()
        {
            InitializeComponent();
            buttons = new Button[11];
            buttons[0] = buttonCloset1;
            buttons[1] = buttonCloset2;
            buttons[2] = buttonCloset3;
            buttons[3] = buttonCloset4;
            buttons[4] = buttonCloset5;
            buttons[5] = buttonCloset6;
            buttons[6] = buttonCloset7;
            buttons[7] = buttonCloset8;
            buttons[8] = buttonCloset9;
            buttons[9] = buttonCloset10;
            buttons[10] = buttonCloset11;
        }
        public static bool closet_choice = false;
        public static bool closet_choice_peek = false;
        public const int constX = 10;
        public const int constY = 80;
        public const int constPanelX = 72;
        public const int constPanelY = 80;
        public static int tempX;
        public static int tempY;

        private void buttonStore_Click(object sender, EventArgs e)
        {
            panelNewBook.Visible = false;
            panelStore.Visible = true;
            buttonStore.BackColor = Color.Gray;
            buttonNewBook.BackColor = Color.White;
            panelStore.Location = new Point(0, 40);
        }

        private void buttonNewBook_Click(object sender, EventArgs e)
        {
            panelNewBook.Visible = true;
            panelStore.Visible = false;
            buttonNewBook.BackColor = Color.Gray;
            buttonStore.BackColor = Color.White;
        }
        public void enabled_buttons(Button but, bool enabled)
        {
            foreach (Button button in buttons)
            {
                if (button.Name != but.Name)
                {
                    button.Enabled = enabled;
                }
            }
        }

        private void buttonCloset1_Click(object sender, EventArgs e)
        {
            //buttonCloset1.Text = "Ф\nа\nн\nт\nа\nс\nт\nи\nк\nа\n1\n";
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset1.Location.X;
                tempY = buttonCloset1.Location.Y;
                buttonCloset1.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset1, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset1.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset1, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }

        }

        private void buttonCloset2_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset2.Location.X;
                tempY = buttonCloset2.Location.Y;
                buttonCloset2.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset2, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset2.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset2, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }
        }

        private void buttonCloset3_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset3.Location.X;
                tempY = buttonCloset3.Location.Y;
                buttonCloset3.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset3, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset3.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset3, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }
        }

        private void buttonCloset4_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset4.Location.X;
                tempY = buttonCloset4.Location.Y;
                buttonCloset4.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset4, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset4.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset4, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }
        }

        private void buttonCloset5_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset5.Location.X;
                tempY = buttonCloset5.Location.Y;
                buttonCloset5.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset5, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset5.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset5, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }
        }

        private void buttonCloset6_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset6.Location.X;
                tempY = buttonCloset6.Location.Y;
                buttonCloset6.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset6, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset6.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset6, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }
        }

        private void buttonCloset7_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset7.Location.X;
                tempY = buttonCloset7.Location.Y;
                buttonCloset7.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset7, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset7.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset7, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }
        }

        private void Store_Load(object sender, EventArgs e)
        {
            buttonCloset1.Text = "Ф\nи\nл\nо\nс\nо\nф\nи\nя\n";
        }

        private void buttonCloset8_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset8.Location.X;
                tempY = buttonCloset8.Location.Y;
                buttonCloset8.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset8, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset8.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset8, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }
        }

        private void buttonCloset9_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset9.Location.X;
                tempY = buttonCloset9.Location.Y;
                buttonCloset9.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset9, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset9.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset9, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }
        }

        private void buttonCloset10_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset10.Location.X;
                tempY = buttonCloset10.Location.Y;
                buttonCloset10.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset10, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset10.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset10, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }
        }

        private void buttonCloset11_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset11.Location.X;
                tempY = buttonCloset11.Location.Y;
                buttonCloset11.Location = new Point(constX, constY);
                //отключаем все остальные кнопки
                enabled_buttons(buttonCloset11, false);
                //показываем книги в шкафу
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset11.Location = new Point(tempX, tempY);
                //включаем все остальные кнопки
                enabled_buttons(buttonCloset11, true);
                //не показываем книги в шкафу
                panelBookInfo.Location = new Point(82, 560);
            }
        }
    }
}
