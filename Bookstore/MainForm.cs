using ClassLibraryBookstore;
using lab3Lib;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Bookstore
{
    public partial class Store : Form
    {
        // ���������� ����������
        private static bool closet_choice = false;
        private static Button[] buttons;
        private static bool closet_choice_peek = false;
        private static bool easterEggActive = false;
        private static int tempX;
        private static int tempY;
        private static int currentShelfId;

        // Константы
        private const int constX = 10;
        private const int constY = 80;
        private const int constPanelX = 72;
        private const int constPanelY = 80;
        private const int constPanelBack = 860;
        private static readonly string[] alphabets = { "0123456789", "QWERTYUIOPASDFGHJKLZXCVBNM", "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ", " !,.<>:;-\"\'[]{}()?", "\n" };

        // Конструктор
        public Store()
        {
            InitializeComponent();

            new MyClassLibrary();

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
            BookShelf[] shelves = MyClassLibrary.GetShop().GetShelfs();
            for (int i = 0; i < 11; i++)
            {
                if (i >= MyClassLibrary.GetShop().GetMaxShelfs())
                {
                    buttons[i].Enabled = false;
                    buttons[i].Visible = false;
                }
                else
                {
                    buttons[i].Text = shelves.ElementAt(i).GetGenre();
                }
            }
            textBoxBalance.Text = MyClassLibrary.GetShop().GetBalance().ToString();
            listBoxID.Items.Clear();
            listBoxAuthor.Items.Clear();
            listBoxNameBook.Items.Clear();
            listBoxPages.Items.Clear();
            listBoxPrice.Items.Clear();
            buttonSellBook.Enabled = false;
            panelStore.Visible = false;
            textBoxIDBook.Text = MyClassLibrary.GetShop().GetLastBookId().ToString();

        }

        // ���������� ������ � ����������
        public void updateClosets()
        {
            BookShelf[] shelves = MyClassLibrary.GetShop().GetShelfs();
            for (int i = 0; i < MyClassLibrary.GetShop().GetMaxShelfs(); i++)
            {
                buttons[i].Text = String.Join("\n", shelves.ElementAt(i).GetGenre().ToString().ToCharArray());
            }
            if (easterEggActive)
            {
                buttons[10].Enabled = true;
                buttons[10].Visible = true;
                buttons[10].Text = String.Join("\n", shelves.ElementAt(10).GetGenre().ToString().ToCharArray());
            }
            textBoxBalance.Text = MyClassLibrary.GetShop().GetBalance().ToString();
            textBoxIDBook.Text = MyClassLibrary.GetShop().GetLastBookId().ToString();
        }

        // ��������� ���������� �����
        public void loadBooks(int shelfId)
        {
            currentShelfId = shelfId;
            listBoxID.Items.Clear();
            listBoxAuthor.Items.Clear();
            listBoxNameBook.Items.Clear();
            listBoxPages.Items.Clear();
            listBoxPrice.Items.Clear();

            foreach (Book book in MyClassLibrary.GetShop().GetShelfs().ElementAt(shelfId).GetBooks())
            {
                if (book != null)
                {
                    listBoxID.Items.Add(book.GetId().ToString());
                    listBoxAuthor.Items.Add(book.GetAuthor());
                    listBoxNameBook.Items.Add(book.GetName(true));
                    listBoxPages.Items.Add(book.GetPageAmount().ToString());
                    listBoxPrice.Items.Add(book.GetPrice().ToString());
                }
            }
        }

        public void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (textBoxNameBook.Text != "" && textBoxAuthor.Text != "" && textBoxGenre.Text != "" && textBoxPages.Text != "" && textBoxPrice.Text != "")
            {
                if (MyClassLibrary.isNumber(textBoxNameBook.Text.Split(" ").ElementAt(textBoxNameBook.Text.Split(" ").Length - 1)))
                {
                    textBoxNameBook.Text = string.Join(" ", textBoxNameBook.Text.Split(" ")[..^1]);
                }

                if (textBoxGenre.Text == "ZOV")
                {
                    easterEggActive = true;
                }

                MyClassLibrary.GetShop().AddBook(textBoxNameBook.Text, textBoxAuthor.Text, textBoxGenre.Text, Convert.ToInt32(textBoxPages.Text), Convert.ToInt32(textBoxPrice.Text));
                textBoxNameBook.Text = "";
                textBoxAuthor.Text = "";
                textBoxGenre.Text = "";
                textBoxPages.Text = "";
                textBoxPrice.Text = "";

                updateClosets();
            }
        }

        public void textBoxNameBook_TextChanged(object sender, EventArgs e)
        {
            textBoxNameBook.Text = MyClassLibrary.checkInput(textBoxNameBook.Text, alphabets[0] + alphabets[1] + alphabets[2] + alphabets[3], false);
        }

        public void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
            textBoxGenre.Text = MyClassLibrary.checkInput(textBoxGenre.Text, alphabets[1] + alphabets[2] + " ", false);
        }

        public void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            textBoxAuthor.Text = MyClassLibrary.checkInput(textBoxAuthor.Text, alphabets[1] + alphabets[2] + alphabets[3], false);
        }

        public void textBoxPages_TextChanged(object sender, EventArgs e)
        {
            textBoxPages.Text = MyClassLibrary.checkInput(textBoxPages.Text, alphabets[0], true);
        }

        public void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = MyClassLibrary.checkInput(textBoxPrice.Text, alphabets[0], true);
        }

        public void textBoxFindBook_TextChanged(object sender, EventArgs e)
        {
            textBoxFindBook.Text = MyClassLibrary.checkInput(textBoxFindBook.Text, string.Join("", alphabets), false);
            if (textBoxFindBook.Text.Contains("\n"))
            {
                textBoxFindBook.Text = textBoxFindBook.Text.Replace("\n", "");
                int i = 0;
                foreach (BookShelf shelf in MyClassLibrary.GetShop().GetShelfs())
                {
                    if (shelf != null)
                    {
                        Book foundBook = shelf.SearchBook(textBoxFindBook.Text);
                        if (foundBook != null)
                        {
                            closet_choice = closet_choice == false;
                            tempX = buttons[i].Location.X;
                            tempY = buttons[i].Location.Y;
                            buttons[i].Location = new Point(constX, constY);
                            enabled_buttons(buttons[i], closet_choice != false);
                            panelBookInfo.Location = new Point(constPanelX, constPanelY);
                            loadBooks(i);
                            listBoxID.SelectedIndex = listBoxID.Items.IndexOf(foundBook.GetId().ToString());
                            buttonSellBook.Enabled = true;
                            textBoxFindBook.Enabled = false;
                            return;
                        }
                        i++;
                    }
                }
            }
        }

        public void buttonSellBook_Click(object sender, EventArgs e)
        {
            try
            {
                Book bookToSell = MyClassLibrary.GetShop().GetShelfs().ElementAt(currentShelfId).SearchBook(Convert.ToInt32(listBoxID.Items[listBoxID.SelectedIndex]));
                if (bookToSell != null)
                {
                    int income = MyClassLibrary.GetShop().GetShelfs().ElementAt(currentShelfId).SellBook(bookToSell);
                    MyClassLibrary.GetShop().AddBalance(income);
                    updateClosets();
                    loadBooks(currentShelfId);
                }
            }
            catch (Exception ignored) { }
        }

        public void listBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxID.SelectedIndex;
            listBoxAuthor.SelectedIndex = listBoxID.SelectedIndex;
            listBoxNameBook.SelectedIndex = listBoxID.SelectedIndex;
            listBoxPages.SelectedIndex = listBoxID.SelectedIndex;
            listBoxPrice.SelectedIndex = listBoxID.SelectedIndex;
        }

        public void listBoxNameBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxNameBook.SelectedIndex;
            listBoxAuthor.SelectedIndex = listBoxNameBook.SelectedIndex;
            listBoxNameBook.SelectedIndex = listBoxNameBook.SelectedIndex;
            listBoxPages.SelectedIndex = listBoxNameBook.SelectedIndex;
            listBoxPrice.SelectedIndex = listBoxNameBook.SelectedIndex;
        }

        public void listBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxAuthor.SelectedIndex;
            listBoxAuthor.SelectedIndex = listBoxAuthor.SelectedIndex;
            listBoxNameBook.SelectedIndex = listBoxAuthor.SelectedIndex;
            listBoxPages.SelectedIndex = listBoxAuthor.SelectedIndex;
            listBoxPrice.SelectedIndex = listBoxAuthor.SelectedIndex;
        }

        public void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxPages.SelectedIndex;
            listBoxAuthor.SelectedIndex = listBoxPages.SelectedIndex;
            listBoxNameBook.SelectedIndex = listBoxPages.SelectedIndex;
            listBoxPages.SelectedIndex = listBoxPages.SelectedIndex;
            listBoxPrice.SelectedIndex = listBoxPages.SelectedIndex;
        }

        public void listBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxPrice.SelectedIndex;
            listBoxAuthor.SelectedIndex = listBoxPrice.SelectedIndex;
            listBoxNameBook.SelectedIndex = listBoxPrice.SelectedIndex;
            listBoxPages.SelectedIndex = listBoxPrice.SelectedIndex;
            listBoxPrice.SelectedIndex = listBoxPrice.SelectedIndex;
        }

        public void buttonStore_Click(object sender, EventArgs e)
        {
            panelNewBook.Visible = false;
            panelStore.Visible = true;
            buttonStore.BackColor = Color.Gray;
            buttonNewBook.BackColor = Color.White;
            panelStore.Location = new Point(0, 40);
            updateClosets();
        }

        public void buttonNewBook_Click(object sender, EventArgs e)
        {
            panelNewBook.Visible = true;
            panelStore.Visible = false;
            buttonNewBook.BackColor = Color.Gray;
            buttonStore.BackColor = Color.White;
            updateClosets();
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
            buttonSellBook.Enabled = !enabled;
            textBoxFindBook.Enabled = enabled;
            updateClosets();
        }

        public void buttonRandom_Click(object sender, EventArgs e)
        {
            Book newBookData = MyClassLibrary.generateRandomBook(false);
            textBoxAuthor.Text = newBookData.GetAuthor();
            textBoxGenre.Text = newBookData.GetGenre();
            textBoxNameBook.Text = newBookData.GetName(false);
            textBoxPages.Text = newBookData.GetPageAmount().ToString();
            textBoxPrice.Text = newBookData.GetPrice().ToString();
        }

        public void buttonCloset1_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset1.Location.X;
                tempY = buttonCloset1.Location.Y;
                buttonCloset1.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset1, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset1.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset1, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(0);
        }

        public void buttonCloset2_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset2.Location.X;
                tempY = buttonCloset2.Location.Y;
                buttonCloset2.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset2, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset2.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset2, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(1);
        }

        public void buttonCloset3_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset3.Location.X;
                tempY = buttonCloset3.Location.Y;
                buttonCloset3.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset3, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset3.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset3, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(2);
        }

        public void buttonCloset4_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset4.Location.X;
                tempY = buttonCloset4.Location.Y;
                buttonCloset4.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset4, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset4.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset4, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(3);
        }

        public void buttonCloset5_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset5.Location.X;
                tempY = buttonCloset5.Location.Y;
                buttonCloset5.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset5, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset5.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset5, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(4);
        }

        public void buttonCloset6_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset6.Location.X;
                tempY = buttonCloset6.Location.Y;
                buttonCloset6.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset6, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset6.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset6, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(5);
        }

        public void buttonCloset7_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset7.Location.X;
                tempY = buttonCloset7.Location.Y;
                buttonCloset7.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset7, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset7.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset7, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(6);
        }

        public void Store_Load(object sender, EventArgs e)
        {

        }

        public void buttonCloset8_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset8.Location.X;
                tempY = buttonCloset8.Location.Y;
                buttonCloset8.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset8, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset8.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset8, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(7);
        }

        public void buttonCloset9_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset9.Location.X;
                tempY = buttonCloset9.Location.Y;
                buttonCloset9.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset9, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset9.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset9, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(8);
        }

        public void buttonCloset10_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset10.Location.X;
                tempY = buttonCloset10.Location.Y;
                buttonCloset10.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset10, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset10.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset10, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(9);
        }

        public void buttonCloset11_Click(object sender, EventArgs e)
        {
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset11.Location.X;
                tempY = buttonCloset11.Location.Y;
                buttonCloset11.Location = new Point(constX, constY);
                //��������� ��� ��������� ������
                enabled_buttons(buttonCloset11, false);
                //���������� ����� � �����
                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                buttonCloset11.Location = new Point(tempX, tempY);
                //�������� ��� ��������� ������
                enabled_buttons(buttonCloset11, true);
                //�� ���������� ����� � �����
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(10);
        }
    }
}
