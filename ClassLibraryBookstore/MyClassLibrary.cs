using lab3Lib;

namespace ClassLibraryBookstore
{
    public class MyClassLibrary
    {
        // Элементы интерфейса
        private static Shop myShop;
        private static Panel panelNewBook;
        private static Panel panelStore;
        private static Button buttonNewBook;
        private static Label labelNameBook;
        private static Button buttonStore;
        private static TextBox textBoxGenre;
        private static Label labelGenre;
        private static TextBox textBoxAuthor;
        private static Label labelAuthor;
        private static TextBox textBoxNameBook;
        private static Label labelPages;
        private static TextBox textBoxPrice;
        private static Label labelPrice;
        private static TextBox textBoxPages;
        private static Label label_idBook;
        private static TextBox textBoxIDBook;
        private static Label labelRUB;
        private static Button buttonRandom;
        private static Button buttonAddBook;
        private static Label labelBalance;
        private static Label labelRUBL;
        private static TextBox textBoxBalance;
        private static Label labelFindBook;
        private static TextBox textBoxFindBook;
        private static Button buttonCloset1;
        private static Button buttonCloset5;
        private static Button buttonCloset4;
        private static Button buttonCloset3;
        private static Button buttonCloset2;
        private static Button buttonCloset11;
        private static Button buttonCloset10;
        private static Button buttonCloset9;
        private static Button buttonCloset8;
        private static Button buttonCloset7;
        private static Button buttonCloset6;
        private static Panel panelBookInfo;
        private static Label label_panel_id;
        private static Label label_panel_namebook;
        private static ListBox listBoxID;
        private static ListBox listBoxNameBook;
        private static Label label_panel_author;
        private static Label label_panel_pages;
        private static ListBox listBoxAuthor;
        private static ListBox listBoxPrice;
        private static Label label_panel_price;
        private static ListBox listBoxPages;
        private static Button buttonSellBook;
        private static Button[] buttons;

        // Глобальные переменные
        private static bool closet_choice = false;
        private static bool closet_choice_peek = false;
        private const int constX = 10;
        private const int constY = 80;
        private const int constPanelX = 72;
        private const int constPanelY = 80;
        private const int constPanelBack = 860;
        private static int tempX;
        private static int tempY;
        private static int currentShelfId;
        private static readonly string[] alphabets = {"0123456789", "QWERTYUIOPASDFGHJKLZXCVBNM", "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ", " !,.<>:;-\"\'[]{}()?", "\n" };
        // Конструктор
        public MyClassLibrary(Panel panelNewBook_, Panel panelStore_, Button buttonNewBook_, Label labelNameBook_, Button buttonStore_, TextBox textBoxGenre_, Label labelGenre_, TextBox textBoxAuthor_, Label labelAuthor_, TextBox textBoxNameBook_, Label labelPages_, TextBox textBoxPrice_, Label labelPrice_, TextBox textBoxPages_, Label label_idBook_, TextBox textBoxIDBook_, Label labelRUB_, Button buttonRandom_, Button buttonAddBook_, Label labelBalance_, Label labelRUBL_, TextBox textBoxBalance_, Label labelFindBook_, TextBox textBoxFindBook_, Button buttonCloset1_, Button buttonCloset5_, Button buttonCloset4_, Button buttonCloset3_, Button buttonCloset2_, Button buttonCloset11_, Button buttonCloset10_, Button buttonCloset9_, Button buttonCloset8_, Button buttonCloset7_, Button buttonCloset6_, Panel panelBookInfo_, Label label_panel_id_, Label label_panel_namebook_, ListBox listBoxID_, ListBox listBoxNameBook_, Label label_panel_author_, Label label_panel_pages_, ListBox listBoxAuthor_, ListBox listBoxPrice_, Label label_panel_price_, ListBox listBoxPages_, Button buttonSellBook_) {
            myShop = new Shop();
            panelNewBook = panelNewBook_;
            panelStore = panelStore_;
            buttonNewBook = buttonNewBook_;
            labelNameBook = labelNameBook_;
            buttonStore = buttonStore_;
            textBoxGenre = textBoxGenre_;
            labelGenre = labelGenre_;
            textBoxAuthor = textBoxAuthor_;
            labelAuthor = labelAuthor_;
            textBoxNameBook = textBoxNameBook_;
            labelPages = labelPages_;
            textBoxPrice = textBoxPrice_;
            labelPrice = labelPrice_;
            textBoxPages = textBoxPages_;
            label_idBook = label_idBook_;
            textBoxIDBook = textBoxIDBook_;
            labelRUB = labelRUB_;
            buttonRandom = buttonRandom_;
            buttonAddBook = buttonAddBook_;
            labelBalance = labelBalance_;
            labelRUBL = labelRUBL_;
            textBoxBalance = textBoxBalance_;
            labelFindBook = labelFindBook_;
            textBoxFindBook = textBoxFindBook_;
            buttonCloset1 = buttonCloset1_;
            buttonCloset5 = buttonCloset5_;
            buttonCloset4 = buttonCloset4_;
            buttonCloset3 = buttonCloset3_;
            buttonCloset2 = buttonCloset2_;
            buttonCloset11 = buttonCloset11_;
            buttonCloset10 = buttonCloset10_;
            buttonCloset9 = buttonCloset9_;
            buttonCloset8 = buttonCloset8_;
            buttonCloset7 = buttonCloset7_;
            buttonCloset6 = buttonCloset6_;
            panelBookInfo = panelBookInfo_;
            label_panel_id = label_panel_id_;
            label_panel_namebook = label_panel_namebook_;
            listBoxID = listBoxID_;
            listBoxNameBook = listBoxNameBook_;
            label_panel_author = label_panel_author_;
            label_panel_pages = label_panel_pages_;
            listBoxAuthor = listBoxAuthor_;
            listBoxPrice = listBoxPrice_;
            label_panel_price = label_panel_price_;
            listBoxPages = listBoxPages_;
            buttonSellBook = buttonSellBook_;

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
            BookShelf[] shelves = myShop.GetShelfs();
            for (int i = 0; i < 11; i++)
            {
                if (i >= shelves.Count())
                {
                    buttons[i].Enabled = false;
                    buttons[i].Visible = false;
                }
                else
                {
                    buttons[i].Text = shelves.ElementAt(i).GetGenre();
                }
            }
            textBoxBalance.Text = myShop.GetBalance().ToString();
            listBoxID.Items.Clear();
            listBoxAuthor.Items.Clear();
            listBoxNameBook.Items.Clear();
            listBoxPages.Items.Clear();
            listBoxPrice.Items.Clear();
            buttonSellBook.Enabled = false;
            panelStore.Visible = false;
            textBoxIDBook.Text = myShop.GetLastBookId().ToString();
        }

        // Обновление шкафов в интерфейсе
        private static void updateClosets()
        {
            BookShelf[] shelves = myShop.GetShelfs();
            for (int i = 0; i < shelves.Count(); i++)
            {
                buttons[i].Text = String.Join("\n", shelves.ElementAt(i).GetGenre().ToString().ToCharArray());
            }
            textBoxBalance.Text = myShop.GetBalance().ToString();
            textBoxIDBook.Text = myShop.GetLastBookId().ToString();
        }

        // Загрузить содержимое шкафа
        private static void loadBooks(int shelfId)
        {
            currentShelfId = shelfId;
            listBoxID.Items.Clear();
            listBoxAuthor.Items.Clear();
            listBoxNameBook.Items.Clear();
            listBoxPages.Items.Clear();
            listBoxPrice.Items.Clear();

            foreach (Book book in myShop.GetShelfs().ElementAt(shelfId).GetBooks())
            {
                if (book != null) {
                    listBoxID.Items.Add(book.GetId().ToString());
                    listBoxAuthor.Items.Add(book.GetAuthor());
                    listBoxNameBook.Items.Add(book.GetName(true));
                    listBoxPages.Items.Add(book.GetPageAmount().ToString());
                    listBoxPrice.Items.Add(book.GetPrice().ToString());
                }
            }
        }

        // Проверка текст на число
        public static bool isNumber(string text)
        {
            try
            {
                Convert.ToInt32(text);
                return true;
            } catch { return false; }
        }
        
        public static void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (textBoxNameBook.Text != "" && textBoxAuthor.Text != "" && textBoxGenre.Text != "" && textBoxPages.Text != "" && textBoxPrice.Text != "")
            {
                if (isNumber(textBoxNameBook.Text.Split(" ").ElementAt(textBoxNameBook.Text.Split(" ").Length - 1)))
                {
                    textBoxNameBook.Text = string.Join(" ", textBoxNameBook.Text.Split(" ")[..^1]);
                }
                myShop.AddBook(textBoxNameBook.Text, textBoxAuthor.Text, textBoxGenre.Text, Convert.ToInt32(textBoxPages.Text), Convert.ToInt32(textBoxPrice.Text));
                textBoxNameBook.Text = "";
                textBoxAuthor.Text = "";
                textBoxGenre.Text = "";
                textBoxPages.Text = "";
                textBoxPrice.Text = "";
                updateClosets();
            }
        }

        public static void textBoxNameBook_TextChanged(object sender, EventArgs e)
        {
            String newText = "";
            foreach (char letter in textBoxNameBook.Text)
            {
                if ((alphabets[0] + alphabets[1] + alphabets[2] + alphabets[3]).Contains(char.ToUpper(letter)))
                {
                    newText += letter;
                }
            }
            textBoxNameBook.Text = newText;
        }

        public static void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
            String newText = "";
            int i = 0;
            foreach (char letter in textBoxGenre.Text)
            {
                if ((alphabets[1] + alphabets[2] + " ").Contains(char.ToUpper(letter)) && i < 9)
                {
                    newText += letter;
                }
                i++;
            }
            textBoxGenre.Text = newText;
        }

        public static void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            String newText = "";
            foreach (char letter in textBoxAuthor.Text)
            {
                if ((alphabets[1] + alphabets[2] + alphabets[3]).Contains(char.ToUpper(letter)))
                {
                    newText += letter;
                }
            }
            textBoxAuthor.Text = newText;
        }

        public static void textBoxPages_TextChanged(object sender, EventArgs e)
        {
            String newText = "";
            foreach (char letter in textBoxPages.Text)
            {
                if (alphabets[0].Contains(char.ToUpper(letter)))
                {
                    newText += letter;
                }
            }
            if (newText != "")
            {
                if (!isNumber(newText)) {
                    newText = Int32.MaxValue.ToString();
                } else {
                    newText = Convert.ToInt32(newText).ToString();
                }
            }
            textBoxPages.Text = newText;
        }

        public static void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            String newText = "";
            foreach (char letter in textBoxPrice.Text)
            {
                if (alphabets[0].Contains(char.ToUpper(letter)))
                {
                    newText += letter;
                }
            }
            if (newText != "")
            {
                if (!isNumber(newText))
                {
                    newText = Int32.MaxValue.ToString();
                } else {
                    newText = Convert.ToInt32(newText).ToString();
                }
            }
            textBoxPrice.Text = newText;
        }

        public static void textBoxFindBook_TextChanged(object sender, EventArgs e)
        {
            String newText = "";
            foreach (char letter in textBoxFindBook.Text)
            {
                if (string.Join("", alphabets).Contains(char.ToUpper(letter)))
                {
                    newText += letter;
                }
            }
            textBoxFindBook.Text = newText;
            if (textBoxFindBook.Text.Contains("\n"))
            {
                textBoxFindBook.Text = textBoxFindBook.Text.Replace("\n", "");
                int i = 0;
                foreach (BookShelf shelf in myShop.GetShelfs())
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

        public static void buttonSellBook_Click(object sender, EventArgs e)
        {
            try
            {
                Book bookToSell = myShop.GetShelfs().ElementAt(currentShelfId).SearchBook(Convert.ToInt32(listBoxID.Items[listBoxID.SelectedIndex]));
                if (bookToSell != null)
                {
                    int income = myShop.GetShelfs().ElementAt(currentShelfId).SellBook(bookToSell);
                    myShop.AddBalance(income);
                    updateClosets();
                    loadBooks(currentShelfId);
                }
            }
            catch (Exception ignored) { }
        }

        public static void listBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxID.SelectedIndex;
            listBoxAuthor.SelectedIndex = listBoxID.SelectedIndex;
            listBoxNameBook.SelectedIndex = listBoxID.SelectedIndex;
            listBoxPages.SelectedIndex = listBoxID.SelectedIndex;
            listBoxPrice.SelectedIndex = listBoxID.SelectedIndex;
        }

        public static void listBoxNameBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxNameBook.SelectedIndex;
            listBoxAuthor.SelectedIndex = listBoxNameBook.SelectedIndex;
            listBoxNameBook.SelectedIndex = listBoxNameBook.SelectedIndex;
            listBoxPages.SelectedIndex = listBoxNameBook.SelectedIndex;
            listBoxPrice.SelectedIndex = listBoxNameBook.SelectedIndex;
        }

        public static void listBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxAuthor.SelectedIndex;
            listBoxAuthor.SelectedIndex = listBoxAuthor.SelectedIndex;
            listBoxNameBook.SelectedIndex = listBoxAuthor.SelectedIndex;
            listBoxPages.SelectedIndex = listBoxAuthor.SelectedIndex;
            listBoxPrice.SelectedIndex = listBoxAuthor.SelectedIndex;
        }

        public static void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxPages.SelectedIndex;
            listBoxAuthor.SelectedIndex = listBoxPages.SelectedIndex;
            listBoxNameBook.SelectedIndex = listBoxPages.SelectedIndex;
            listBoxPages.SelectedIndex = listBoxPages.SelectedIndex;
            listBoxPrice.SelectedIndex = listBoxPages.SelectedIndex;
        }

        public static void listBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxPrice.SelectedIndex;
            listBoxAuthor.SelectedIndex = listBoxPrice.SelectedIndex;
            listBoxNameBook.SelectedIndex = listBoxPrice.SelectedIndex;
            listBoxPages.SelectedIndex = listBoxPrice.SelectedIndex;
            listBoxPrice.SelectedIndex = listBoxPrice.SelectedIndex;
        }

        public static void buttonStore_Click(object sender, EventArgs e)
        {
            panelNewBook.Visible = false;
            panelStore.Visible = true;
            buttonStore.BackColor = Color.Gray;
            buttonNewBook.BackColor = Color.White;
            panelStore.Location = new Point(0, 40);
            updateClosets();
        }

        public static void buttonNewBook_Click(object sender, EventArgs e)
        {
            panelNewBook.Visible = true;
            panelStore.Visible = false;
            buttonNewBook.BackColor = Color.Gray;
            buttonStore.BackColor = Color.White;
            updateClosets();
        }
        public static void enabled_buttons(Button but, bool enabled)
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

        public static void buttonRandom_Click(object sender, EventArgs e)
        {
            Book newBookData = new Book(-1, myShop.GetRandom());
            textBoxAuthor.Text = newBookData.GetAuthor();
            textBoxGenre.Text = newBookData.GetGenre();
            textBoxNameBook.Text = newBookData.GetName(false);
            textBoxPages.Text = newBookData.GetPageAmount().ToString();
            textBoxPrice.Text = newBookData.GetPrice().ToString();
        }

        public static void buttonCloset1_Click(object sender, EventArgs e)
        {
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(0);
        }

        public static void buttonCloset2_Click(object sender, EventArgs e)
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(1);
        }

        public static void buttonCloset3_Click(object sender, EventArgs e)
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(2);
        }

        public static void buttonCloset4_Click(object sender, EventArgs e)
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(3);
        }

        public static void buttonCloset5_Click(object sender, EventArgs e)
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(4);
        }

        public static void buttonCloset6_Click(object sender, EventArgs e)
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(5);
        }

        public static void buttonCloset7_Click(object sender, EventArgs e)
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(6);
        }

        public static void Store_Load(object sender, EventArgs e)
        {
            
        }

        public static void buttonCloset8_Click(object sender, EventArgs e)
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(7);
        }

        public static void buttonCloset9_Click(object sender, EventArgs e)
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(8);
        }

        public static void buttonCloset10_Click(object sender, EventArgs e)
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(9);
        }

        public static void buttonCloset11_Click(object sender, EventArgs e)
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
                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(10);
        }
    }
}
