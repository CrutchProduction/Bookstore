using Bookstore.Properties;
using ClassLibraryBookstore;
using lab3Lib;
using System.Collections;
using System.Reflection.Emit;
using System.Resources;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

using Timer = System.Timers.Timer;

namespace Bookstore
{
    public partial class Store : Form
    {
        // ���������� ����������
        private static bool closet_choice = false;
        private static Button[] buttons;
        private static int[][] buttonsInitialPos;
        private static bool closet_choice_peek = false;
        private static bool easterEggActive = false;
        private static int tempX;
        private static int tempY;
        private static int currentShelfId;
        private static int currentMenu = 0;


        // Константы
        private const int constX = 10;
        private const int constY = 80;
        private const int constPanelX = 72;
        private const int constPanelY = 80;
        private const int constPanelBack = 860;
        private static readonly string[] alphabets = { "0123456789", "QWERTYUIOPASDFGHJKLZXCVBNM", "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ", " !,.<>:;-\"\'[]{}()?", "\n" };
        private const int sizeButton1 = 400;
        private const int sizeButton2 = 300;


        // Очереди игры
        private static Queue clientsQueue;
        private static Queue booksPendingQueue;
        private static Queue booksArrivedQueue;

        // Параметры игры
        private static bool isGameStarted = false;
        private static int curGameDifficulty;

        // Константы
        private static readonly float[] difficultyDayTimes = { 120, 240, 480 };
        private static readonly float[] difficultyRndBookTimes = { 20, 30, 48 };
        private static readonly float[] difficultyClientTimes = { 10, 15, 24 };
        private static readonly float[] difficultyPenBookTimes = { 9, 14.5f, 25 };
        private static readonly int[] maxClientsQueue = { 7, 5, 3 };

        // Конструктор
        public Store()
        {
            InitializeComponent();

            new MyClassLibrary();

            clientsQueue = new Queue();
            booksPendingQueue = new Queue();
            booksArrivedQueue = new Queue();

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
            buttonsInitialPos = new int[buttons.Length][];
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
                buttonsInitialPos[i] = new int[] { buttons[i].Location.X, buttons[i].Location.Y };
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

        // Запуск цикла игры
        public void startGame(int gameDifficulty)
        {
            curGameDifficulty = gameDifficulty;

            Timer gameTimer = new Timer((int)difficultyDayTimes[gameDifficulty] * 1000);
            gameTimer.Elapsed += stopGameEvent;
            gameTimer.Start();

            Timer randomBookArrive = new Timer((int)difficultyRndBookTimes[gameDifficulty] * 1000);
            randomBookArrive.Elapsed += randomBookArriveEvent;
            randomBookArrive.Start();

            Timer randomClientArrive = new Timer((int)difficultyClientTimes[gameDifficulty] * 1000);
            randomClientArrive.Elapsed += randomClientArriveEvent;
            randomClientArrive.Start();

            Timer pendingBookArrive = new Timer((int)difficultyPenBookTimes[gameDifficulty] * 1000);
            pendingBookArrive.Elapsed += pendingBookArriveEvent;

            isGameStarted = true;
            while (isGameStarted)
            {
                if (booksPendingQueue.Count != 0)
                {
                    pendingBookArrive.Start();
                }
                else
                {
                    pendingBookArrive.Stop();
                }

                if (currentMenu != 3)
                {
                    if (booksArrivedQueue.Count == 0 && buttonDelivery.Visible)
                    {
                        buttonNewBook.Width = sizeButton1;
                        buttonStore.Width = sizeButton1;
                        buttonBuyers.Width = sizeButton1;
                        buttonStore.Location = new Point(buttonNewBook.Location.X + buttonNewBook.Width + 10, buttonStore.Location.Y);
                        buttonBuyers.Location = new Point(buttonStore.Location.X + buttonStore.Width + 10, buttonBuyers.Location.Y);
                        buttonDelivery.Visible = false;
                    }
                    else if (booksArrivedQueue.Count != 0 && !buttonDelivery.Visible)
                    {
                        buttonNewBook.Width = sizeButton2;
                        buttonStore.Width = sizeButton2;
                        buttonBuyers.Width = sizeButton2;
                        buttonStore.Location = new Point(buttonNewBook.Location.X + buttonNewBook.Width + 10, buttonStore.Location.Y);
                        buttonBuyers.Location = new Point(buttonStore.Location.X + buttonStore.Width + 10, buttonBuyers.Location.Y);
                        buttonDelivery.Visible = true;
                    }
                }

                if (currentMenu == 0)
                {
                    textBoxIDBook.Text = MyClassLibrary.GetShop().GetLastBookId().ToString();
                    if (promptLabel.Visible) promptLabel.Visible = false;
                }
                else if (currentMenu == 2)
                {
                    if (clientsQueue.Count != 0)
                    {
                        if (labelClient.Visible) labelClient.Visible = false;
                    }
                    else
                    {
                        if (!labelClient.Visible) labelClient.Visible = true;
                    }
                    if (!promptLabel.Visible) promptLabel.Visible = true;
                }
                else if (currentMenu == 3)
                {
                    if (booksArrivedQueue.Count != 0)
                    {
                        textBoxIDBook.Text = ((Book)booksArrivedQueue.Peek()).GetId().ToString();
                    }
                    else
                    {
                        textBoxIDBook.Text = "";
                    }
                    if (promptLabel.Visible) promptLabel.Visible = false;
                }
                else
                {
                    if (labelClient.Visible) labelClient.Visible = false;
                    if (promptLabel.Visible) promptLabel.Visible = false;
                }

                textBoxBalance.Text = MyClassLibrary.GetShop().GetBalance().ToString();
            }

            Application.Exit();

            gameTimer.Stop();
            gameTimer.Dispose();

            randomBookArrive.Stop();
            randomBookArrive.Dispose();

            randomClientArrive.Stop();
            randomClientArrive.Dispose();

            pendingBookArrive.Stop();
            pendingBookArrive.Dispose();
        }

        public void stopGame()
        {
            isGameStarted = false;
        }


        // Событие остановки игры по таймеру
        private void stopGameEvent(Object source, ElapsedEventArgs e)
        {
            stopGame();
        }

        // Событие добавление в очередь рандомной книги по таймеру
        private void randomBookArriveEvent(Object source, ElapsedEventArgs e)
        {
            booksArrivedQueue.Enqueue(MyClassLibrary.generateRandomBook(true));
            MyClassLibrary.GetShop().AddLastBookId();
            if (booksArrivedQueue.Count == 1)
            {
                changeTextInBoxes((Book)booksArrivedQueue.Peek());
            }
        }

        // Событие добавление в очерель нового клиента по таймеру
        private void randomClientArriveEvent(Object source, ElapsedEventArgs e)
        {
            clientsQueue.Enqueue(MyClassLibrary.generateRandomClient());
            if (clientsQueue.Count > maxClientsQueue[curGameDifficulty])
            {
                isGameStarted = false;
            }
            if (clientsQueue.Count == 1)
            {
                changeImage(((Client)clientsQueue.Peek()).GetAppearanceImage());
            }
        }

        // Событие добавление в очередь книги из очереди добавленных книг по таймеру
        private void pendingBookArriveEvent(Object source, ElapsedEventArgs e)
        {
            booksArrivedQueue.Enqueue(booksPendingQueue.Dequeue());
            if (booksArrivedQueue.Count == 1)
            {
                changeTextInBoxes((Book)booksArrivedQueue.Peek());
            }
        }

        private void changeTextInBoxes(Book book)
        {
            if (book != null)
            {
                MyClassLibrary.GetShop().CheckBookName(book);
            }
            if (currentMenu == 3 && book != null)
            {
                textBoxNameBook.Text = book.GetName(true);
                textBoxAuthor.Text = book.GetAuthor();
                textBoxGenre.Text = book.GetGenre();
                textBoxPages.Text = book.GetPageAmount().ToString();
                textBoxPrice.Text = book.GetPrice().ToString();
            }
            else
            {
                if (currentMenu != 0 || book == null)
                {
                    textBoxNameBook.Text = "";
                    textBoxAuthor.Text = "";
                    textBoxGenre.Text = "";
                    textBoxPages.Text = "";
                    textBoxPrice.Text = "";
                }
            }
        }

        private void changeImage(int id)
        {
            if (id != -1)
            {
                object obj = Resources.ResourceManager.GetObject("appearance" + id, Resources.Culture);
                pictureBoxClient.Image = ((System.Drawing.Bitmap)(obj));

            }
            else
            {
                object obj = Resources.ResourceManager.GetObject("appearanceE", Resources.Culture);
                pictureBoxClient.Image = ((System.Drawing.Bitmap)(obj));
            }

            Client curClient = (Client)clientsQueue.Peek();
            switch (curClient.GetPromptType())
            {
                case 0:
                    promptLabel.Text = "Здравствуйте, мне нужна книга \"" + curClient.GetPrompt().Split("|")[0] + "\", от " + curClient.GetPrompt().Split("|")[1];
                    break;
                case 1:
                    promptLabel.Text = "Здравствуйте, мне нужна книга с жанром " + curClient.GetPrompt();
                    break;
            }
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

        public void unloadClosets()
        {
            changeTextInBoxes(null);
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Location = new Point(buttonsInitialPos[i][0], buttonsInitialPos[i][1]);
            }
            panelBookInfo.Visible = false;
            panelBookInfo.Enabled = false;
            closet_choice = false;
            buttonSellBook.Enabled = false;
            textBoxFindBook.Enabled = true;
        }

        // ��������� ���������� �����
        public void loadBooks(int shelfId)
        {
            panelBookInfo.Visible = true;
            panelBookInfo.Enabled = true;
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
                if (textBoxNameBook.Text.Split(" ").Length != 1 && MyClassLibrary.isNumber(textBoxNameBook.Text.Split(" ").ElementAt(textBoxNameBook.Text.Split(" ").Length - 1)))
                {
                    textBoxNameBook.Text = string.Join(" ", textBoxNameBook.Text.Split(" ")[..^1]);
                }

                if (textBoxGenre.Text == "ZOV")
                {
                    easterEggActive = true;
                }

                Book newBook = new Book(textBoxNameBook.Text, textBoxAuthor.Text, textBoxGenre.Text, MyClassLibrary.GetShop().GetLastBookId(), Convert.ToInt32(textBoxPages.Text), Convert.ToInt32(textBoxPrice.Text), MyClassLibrary.GetShop().GetRandom());
                if (MyClassLibrary.GetShop().GetBalance() - Convert.ToInt32(textBoxPrice.Text) >= 0)
                {
                    MyClassLibrary.GetShop().AddLastBookId();
                    booksPendingQueue.Enqueue(newBook);
                    MyClassLibrary.GetShop().AddBalance(-Convert.ToInt32(textBoxPrice.Text));
                    textBoxNameBook.Text = "";
                    textBoxAuthor.Text = "";
                    textBoxGenre.Text = "";
                    textBoxPages.Text = "";
                    textBoxPrice.Text = "";

                    updateClosets();
                }
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
                            //чтобы кнопка была видна
                            buttons[i].Visible = true;
                            //блокируем вкладки
                            panelBookInfo.Visible = true;

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
            if (currentMenu == 2)
            {
                //делаем окно видимым
                panel_inputBox.Visible = true;
                //блокируем кнопку
                buttonSellBook.Enabled = false;
                //блокируем вкладки
                buttonStore.Enabled = false;
                buttonDelivery.Enabled = false;
                buttonNewBook.Enabled = false;
                buttonBuyers.Enabled = false;
                //блокируем шкафы
                foreach (Button button in buttons)
                {
                    button.Enabled = false;
                }

                Book bookToSell = MyClassLibrary.GetShop().GetShelfs().ElementAt(currentShelfId).SearchBook(Convert.ToInt32(listBoxID.Items[listBoxID.SelectedIndex]));
                textBox_inputBox.Text = bookToSell.GetPrice().ToString();
            }
            else
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
            currentMenu = 1;
            unloadClosets();
            panelNewBook.Visible = false;
            panelBookInfo.Visible = false;
            panelStore.Visible = true;
            buttonStore.BackColor = Color.Gray;
            buttonNewBook.BackColor = Color.White;
            buttonBuyers.BackColor = Color.White;
            buttonDelivery.BackColor = Color.White;
            panelStore.Location = new Point(0, 40);
            pictureBoxClient.Visible = false;
            labelClient.Visible = false;
            panelStore.BackgroundImage = Properties.Resources.backgroundLibraryTwo;

            //вроде работает
            for (int i = 0; i < 11; i++)
            {
                if (i < MyClassLibrary.GetShop().GetMaxShelfs())
                {
                    buttons[i].Visible = true;
                }

            }
            updateClosets();
        }

        public void buttonNewBook_Click(object sender, EventArgs e)
        {
            currentMenu = 0;
            unloadClosets();
            panelNewBook.Visible = true;
            panelStore.Visible = false;

            buttonAccept.Visible = false;
            buttonReject.Visible = false;
            buttonAddBook.Visible = true;
            buttonRandom.Visible = true;

            textBoxNameBook.Enabled = true;
            textBoxAuthor.Enabled = true;
            textBoxGenre.Enabled = true;
            textBoxPages.Enabled = true;
            textBoxPrice.Enabled = true;
            buttonNewBook.BackColor = Color.Gray;
            buttonStore.BackColor = Color.White;
            buttonBuyers.BackColor = Color.White;
            buttonDelivery.BackColor = Color.White;

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
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset1.Location.X;
                tempY = buttonCloset1.Location.Y;
                buttonCloset1.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset1, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset1.Visible = false;
                buttonCloset1.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset1, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }

            updateClosets();
            loadBooks(0);
        }

        public void buttonCloset2_Click(object sender, EventArgs e)
        {
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset2.Location.X;
                tempY = buttonCloset2.Location.Y;
                buttonCloset2.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset2, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset2.Visible = false;
                buttonCloset2.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset2, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(1);
        }

        public void buttonCloset3_Click(object sender, EventArgs e)
        {
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset3.Location.X;
                tempY = buttonCloset3.Location.Y;
                buttonCloset3.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset3, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset3.Visible = false;
                buttonCloset3.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset3, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(2);
        }

        public void buttonCloset4_Click(object sender, EventArgs e)
        {
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset4.Location.X;
                tempY = buttonCloset4.Location.Y;
                buttonCloset4.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset4, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset4.Visible = false;
                buttonCloset4.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset4, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(3);
        }

        public void buttonCloset5_Click(object sender, EventArgs e)
        {
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset5.Location.X;
                tempY = buttonCloset5.Location.Y;
                buttonCloset5.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset5, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset5.Visible = false;
                buttonCloset5.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset5, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(4);
        }

        public void buttonCloset6_Click(object sender, EventArgs e)
        {
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset6.Location.X;
                tempY = buttonCloset6.Location.Y;
                buttonCloset6.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset6, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset6.Visible = false;
                buttonCloset6.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset6, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(5);
        }

        public void buttonCloset7_Click(object sender, EventArgs e)
        {
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset7.Location.X;
                tempY = buttonCloset7.Location.Y;
                buttonCloset7.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset7, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset7.Visible = false;
                buttonCloset7.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset7, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(6);
        }

        public void Store_Load(object sender, EventArgs e)
        {
            panel_inputBox.Visible = false;
            panelNewBook.Location = new Point(0, 40);
            panelStore.Location = new Point(1500, 40);
            buttonDelivery.Visible = false;
            buttonAccept.Visible = false;
            buttonReject.Visible = false;
        }

        public void buttonCloset8_Click(object sender, EventArgs e)
        {
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset8.Location.X;
                tempY = buttonCloset8.Location.Y;
                buttonCloset8.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset8, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset8.Visible = false;
                buttonCloset8.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset8, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(7);
        }

        public void buttonCloset9_Click(object sender, EventArgs e)
        {
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset9.Location.X;
                tempY = buttonCloset9.Location.Y;
                buttonCloset9.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset9, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset9.Visible = false;
                buttonCloset9.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset9, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(8);
        }

        public void buttonCloset10_Click(object sender, EventArgs e)
        {
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset10.Location.X;
                tempY = buttonCloset10.Location.Y;
                buttonCloset10.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset10, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset10.Visible = false;
                buttonCloset10.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset10, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(9);
        }

        public void buttonCloset11_Click(object sender, EventArgs e)
        {
            //если нажать на кнопку на странице покупатели то кнопка пропадает
            closet_choice = closet_choice == false;
            if (closet_choice)
            {
                tempX = buttonCloset11.Location.X;
                tempY = buttonCloset11.Location.Y;
                buttonCloset11.Location = new Point(constX, constY);

                enabled_buttons(buttonCloset11, false);

                panelBookInfo.Location = new Point(constPanelX, constPanelY);
            }
            else
            {
                if (currentMenu == 2) buttonCloset11.Visible = false;
                buttonCloset11.Location = new Point(tempX, tempY);

                enabled_buttons(buttonCloset11, true);

                panelBookInfo.Location = new Point(82, constPanelBack);
            }
            updateClosets();
            loadBooks(10);
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            currentMenu = 3;
            unloadClosets();
            changeTextInBoxes((Book)booksArrivedQueue.Peek());
            buttonDelivery.BackColor = Color.Gray;
            buttonNewBook.BackColor = Color.White;
            buttonStore.BackColor = Color.White;
            buttonBuyers.BackColor = Color.White;
            buttonAccept.Visible = true;
            buttonReject.Visible = true;
            buttonAddBook.Visible = false;
            buttonRandom.Visible = false;

            panelNewBook.Visible = true;
            panelStore.Visible = false;

            textBoxNameBook.Enabled = false;
            textBoxAuthor.Enabled = false;
            textBoxGenre.Enabled = false;
            textBoxPages.Enabled = false;
            textBoxPrice.Enabled = false;
        }

        private void buttonBuyers_Click(object sender, EventArgs e)
        {
            unloadClosets();
            currentMenu = 2;
            buttonBuyers.BackColor = Color.Gray;
            buttonDelivery.BackColor = Color.White;
            buttonNewBook.BackColor = Color.White;
            buttonStore.BackColor = Color.White;
            panelStore.Location = new Point(0, 40);
            panelStore.BackgroundImage = Properties.Resources.shopBook;
            panelNewBook.Visible = false;
            panelStore.Visible = true;
            updateClosets();
            pictureBoxClient.Visible = true;
            panelBookInfo.Visible = false;
            foreach (Button button in buttons)
            {
                button.Visible = false;
            }

        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            if (booksArrivedQueue.Count != 0)
            {
                Book book = (Book)booksArrivedQueue.Dequeue();
                if (book.IsFake())
                {
                    MyClassLibrary.GetShop().AddBalance(10);
                    textBoxBalance.Text = MyClassLibrary.GetShop().GetBalance().ToString();
                }
                if (booksArrivedQueue.Count != 0)
                {
                    changeTextInBoxes((Book)booksArrivedQueue.Peek());
                }
                else
                {
                    changeTextInBoxes(null);
                }
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (booksArrivedQueue.Count != 0)
            {
                Book lastBook = (Book)booksArrivedQueue.Peek();
                BookShelf bookShelf = MyClassLibrary.GetShop().FindBookShelf(lastBook.GetGenre());
                if (bookShelf != null)
                {
                    if (lastBook.IsRandomized())
                    {
                        if (MyClassLibrary.GetShop().GetBalance() - lastBook.GetPrice() >= 0)
                        {
                            MyClassLibrary.GetShop().AddBalance(-lastBook.GetPrice());
                        }
                        else
                        {
                            return;
                        }
                    }

                    if (lastBook.IsFake())
                    {
                        MyClassLibrary.GetShop().AddBalance(-15);
                    }

                    bookShelf.AddBook(lastBook);
                    booksArrivedQueue.Dequeue();
                    if (booksArrivedQueue.Count != 0)
                    {
                        changeTextInBoxes((Book)booksArrivedQueue.Peek());
                    }
                    else
                    {
                        changeTextInBoxes(null);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, освободите место для книги и повторите попытку", "Недостаточно места!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox_inputBox_TextChanged(object sender, EventArgs e)
        {
            textBox_inputBox.Text = MyClassLibrary.checkInput(textBox_inputBox.Text, alphabets[0], true);

        }

        private void button_sell_Click(object sender, EventArgs e)
        {
            panel_inputBox.Visible = false;
            buttonSellBook.Enabled = true;
            //разблокировка вкладок
            buttonStore.Enabled = true;
            buttonDelivery.Enabled = true;
            buttonNewBook.Enabled = true;
            buttonBuyers.Enabled = true;
            //разблокируем шкафы
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }

            int summa;
            try
            {
                summa = Convert.ToInt32(textBox_inputBox.Text);
            }
            catch (Exception ex) { return; }
            if (summa < 0) return;

            try
            {
                Book bookToSell = MyClassLibrary.GetShop().GetShelfs().ElementAt(currentShelfId).SearchBook(Convert.ToInt32(listBoxID.Items[listBoxID.SelectedIndex]));
                if (bookToSell != null)
                {
                    int income = MyClassLibrary.GetShop().GetShelfs().ElementAt(currentShelfId).SellBook(bookToSell);
                    //MyClassLibrary.GetShop().AddBalance(income);
                    MyClassLibrary.GetShop().AddBalance(summa);
                    updateClosets();
                    loadBooks(currentShelfId);
                    if (currentMenu == 2)
                    {
                        if (clientsQueue.Count != 0)
                        {
                            Client curClient = (Client)clientsQueue.Peek();
                            switch (curClient.GetPromptType())
                            {
                                case 0:
                                    if (bookToSell.GetName(false) + "|" + bookToSell.GetAuthor() != curClient.GetPrompt())
                                    {
                                        //    --Dildo
                                    }
                                    break;
                                case 1:
                                    if (bookToSell.GetGenre() != curClient.GetPrompt())
                                    {
                                        //    --Dildo
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ignored) { }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panel_inputBox.Visible = false;
            buttonSellBook.Enabled = true;
            //разблокировка вкладок
            buttonStore.Enabled = true;
            buttonDelivery.Enabled = true;
            buttonNewBook.Enabled = true;
            buttonBuyers.Enabled = true;
            //разблокируем шкафы
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }
    }
}
