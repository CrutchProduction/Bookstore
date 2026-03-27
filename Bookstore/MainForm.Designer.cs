using ClassLibraryBookstore;

namespace Bookstore
{
    partial class Store
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            panelNewBook = new Panel();
            buttonReject = new Button();
            buttonAccept = new Button();
            buttonAddBook = new Button();
            buttonRandom = new Button();
            textBoxIDBook = new TextBox();
            label_idBook = new Label();
            textBoxPages = new TextBox();
            labelPages = new Label();
            textBoxGenre = new TextBox();
            labelGenre = new Label();
            textBoxAuthor = new TextBox();
            labelAuthor = new Label();
            textBoxNameBook = new TextBox();
            labelNameBook = new Label();
            labelPrice = new Label();
            labelRUB = new Label();
            textBoxPrice = new TextBox();
            panelScore = new Panel();
            buttonContinue = new Button();
            labelCount = new Label();
            labelCountClient = new Label();
            labelCurrentDiff = new Label();
            labelDifficult = new Label();
            labelSEC = new Label();
            labelTime = new Label();
            labelPlayTime = new Label();
            labelWinLose = new Label();
            panelStore = new Panel();
            panel_inputBox = new Panel();
            button_sell = new Button();
            buttonCancel = new Button();
            textBox_inputBox = new TextBox();
            label_inputBox = new Label();
            buttonSellBook = new Button();
            panelBookInfo = new Panel();
            listBoxPrice = new ListBox();
            label_panel_price = new Label();
            listBoxPages = new ListBox();
            label_panel_pages = new Label();
            listBoxAuthor = new ListBox();
            label_panel_author = new Label();
            listBoxNameBook = new ListBox();
            listBoxID = new ListBox();
            label_panel_namebook = new Label();
            label_panel_id = new Label();
            buttonCloset11 = new Button();
            buttonCloset10 = new Button();
            buttonCloset9 = new Button();
            buttonCloset8 = new Button();
            buttonCloset7 = new Button();
            buttonCloset6 = new Button();
            buttonCloset5 = new Button();
            buttonCloset4 = new Button();
            buttonCloset3 = new Button();
            buttonCloset2 = new Button();
            buttonCloset1 = new Button();
            textBoxFindBook = new TextBox();
            labelFindBook = new Label();
            pictureBoxClient = new PictureBox();
            promptLabel = new Label();
            labelClient = new Label();
            labelRUBL = new Label();
            textBoxBalance = new TextBox();
            labelBalance = new Label();
            buttonNewBook = new Button();
            buttonStore = new Button();
            buttonDelivery = new Button();
            buttonBuyers = new Button();
            panelNewBook.SuspendLayout();
            panelScore.SuspendLayout();
            panelStore.SuspendLayout();
            panel_inputBox.SuspendLayout();
            panelBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClient).BeginInit();
            SuspendLayout();
            // 
            // panelNewBook
            // 
            panelNewBook.BackgroundImage = Properties.Resources.backgroundLibrary;
            panelNewBook.Controls.Add(buttonReject);
            panelNewBook.Controls.Add(buttonAccept);
            panelNewBook.Controls.Add(buttonAddBook);
            panelNewBook.Controls.Add(buttonRandom);
            panelNewBook.Controls.Add(textBoxIDBook);
            panelNewBook.Controls.Add(label_idBook);
            panelNewBook.Controls.Add(textBoxPages);
            panelNewBook.Controls.Add(labelPages);
            panelNewBook.Controls.Add(textBoxGenre);
            panelNewBook.Controls.Add(labelGenre);
            panelNewBook.Controls.Add(textBoxAuthor);
            panelNewBook.Controls.Add(labelAuthor);
            panelNewBook.Controls.Add(textBoxNameBook);
            panelNewBook.Controls.Add(labelNameBook);
            panelNewBook.Controls.Add(labelPrice);
            panelNewBook.Controls.Add(labelRUB);
            panelNewBook.Controls.Add(textBoxPrice);
            panelNewBook.Location = new Point(28, 52);
            panelNewBook.Name = "panelNewBook";
            panelNewBook.Size = new Size(1227, 733);
            panelNewBook.TabIndex = 0;
            // 
            // buttonReject
            // 
            buttonReject.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReject.Location = new Point(967, 439);
            buttonReject.Margin = new Padding(10);
            buttonReject.Name = "buttonReject";
            buttonReject.Size = new Size(250, 50);
            buttonReject.TabIndex = 17;
            buttonReject.Text = "Отклонить";
            buttonReject.UseVisualStyleBackColor = true;
            buttonReject.Click += buttonReject_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAccept.Location = new Point(19, 439);
            buttonAccept.Margin = new Padding(10);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(250, 50);
            buttonAccept.TabIndex = 16;
            buttonAccept.Text = "Принять";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddBook.Location = new Point(19, 369);
            buttonAddBook.Margin = new Padding(10);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(250, 50);
            buttonAddBook.TabIndex = 12;
            buttonAddBook.Text = "Заказать";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // buttonRandom
            // 
            buttonRandom.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRandom.Location = new Point(967, 369);
            buttonRandom.Margin = new Padding(10);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(250, 50);
            buttonRandom.TabIndex = 13;
            buttonRandom.Text = "Случайная генерация";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += buttonRandom_Click;
            // 
            // textBoxIDBook
            // 
            textBoxIDBook.Enabled = false;
            textBoxIDBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIDBook.Location = new Point(135, 316);
            textBoxIDBook.Margin = new Padding(10);
            textBoxIDBook.Name = "textBoxIDBook";
            textBoxIDBook.Size = new Size(196, 35);
            textBoxIDBook.TabIndex = 10;
            // 
            // label_idBook
            // 
            label_idBook.AutoSize = true;
            label_idBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_idBook.Location = new Point(10, 319);
            label_idBook.Margin = new Padding(10);
            label_idBook.Name = "label_idBook";
            label_idBook.Size = new Size(94, 30);
            label_idBook.TabIndex = 9;
            label_idBook.Text = "ID книги";
            // 
            // textBoxPages
            // 
            textBoxPages.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPages.Location = new Point(135, 264);
            textBoxPages.Margin = new Padding(10);
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new Size(506, 35);
            textBoxPages.TabIndex = 6;
            textBoxPages.TextChanged += textBoxPages_TextChanged;
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPages.Location = new Point(10, 269);
            labelPages.Margin = new Padding(10);
            labelPages.Name = "labelPages";
            labelPages.Size = new Size(110, 30);
            labelPages.TabIndex = 6;
            labelPages.Text = "Страницы";
            // 
            // textBoxGenre
            // 
            textBoxGenre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxGenre.Location = new Point(135, 209);
            textBoxGenre.Margin = new Padding(10);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(1082, 35);
            textBoxGenre.TabIndex = 5;
            textBoxGenre.TextChanged += textBoxGenre_TextChanged;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGenre.Location = new Point(10, 212);
            labelGenre.Margin = new Padding(10);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(66, 30);
            labelGenre.TabIndex = 4;
            labelGenre.Text = "Жанр";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAuthor.Location = new Point(135, 154);
            textBoxAuthor.Margin = new Padding(10);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(1082, 35);
            textBoxAuthor.TabIndex = 4;
            textBoxAuthor.TextChanged += textBoxAuthor_TextChanged;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuthor.Location = new Point(10, 157);
            labelAuthor.Margin = new Padding(10);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(71, 30);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Автор";
            // 
            // textBoxNameBook
            // 
            textBoxNameBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxNameBook.Location = new Point(135, 99);
            textBoxNameBook.Margin = new Padding(10);
            textBoxNameBook.Name = "textBoxNameBook";
            textBoxNameBook.Size = new Size(1082, 35);
            textBoxNameBook.TabIndex = 3;
            textBoxNameBook.TextChanged += textBoxNameBook_TextChanged;
            // 
            // labelNameBook
            // 
            labelNameBook.AutoSize = true;
            labelNameBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameBook.Location = new Point(10, 99);
            labelNameBook.Margin = new Padding(10);
            labelNameBook.Name = "labelNameBook";
            labelNameBook.Size = new Size(105, 30);
            labelNameBook.TabIndex = 0;
            labelNameBook.Text = "Название";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(654, 264);
            labelPrice.Margin = new Padding(10);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(63, 30);
            labelPrice.TabIndex = 8;
            labelPrice.Text = "Цена";
            // 
            // labelRUB
            // 
            labelRUB.AutoSize = true;
            labelRUB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRUB.Location = new Point(1155, 264);
            labelRUB.Margin = new Padding(1, 10, 10, 10);
            labelRUB.Name = "labelRUB";
            labelRUB.Size = new Size(52, 30);
            labelRUB.TabIndex = 11;
            labelRUB.Text = "руб.";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPrice.Location = new Point(731, 264);
            textBoxPrice.Margin = new Padding(10, 10, 1, 10);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(422, 35);
            textBoxPrice.TabIndex = 7;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // panelScore
            // 
            panelScore.Controls.Add(buttonContinue);
            panelScore.Controls.Add(labelCount);
            panelScore.Controls.Add(labelCountClient);
            panelScore.Controls.Add(labelCurrentDiff);
            panelScore.Controls.Add(labelDifficult);
            panelScore.Controls.Add(labelSEC);
            panelScore.Controls.Add(labelTime);
            panelScore.Controls.Add(labelPlayTime);
            panelScore.Controls.Add(labelWinLose);
            panelScore.Location = new Point(154, 75);
            panelScore.Name = "panelScore";
            panelScore.Size = new Size(652, 414);
            panelScore.TabIndex = 18;
            // 
            // buttonContinue
            // 
            buttonContinue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonContinue.Location = new Point(451, 334);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(177, 55);
            buttonContinue.TabIndex = 8;
            buttonContinue.Text = " Продолжить";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += button1_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCount.Location = new Point(528, 278);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(77, 37);
            labelCount.TabIndex = 7;
            labelCount.Text = "1488";
            // 
            // labelCountClient
            // 
            labelCountClient.AutoSize = true;
            labelCountClient.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCountClient.Location = new Point(47, 278);
            labelCountClient.Name = "labelCountClient";
            labelCountClient.Size = new Size(457, 37);
            labelCountClient.TabIndex = 6;
            labelCountClient.Text = "Количество обслуженных клиентов";
            // 
            // labelCurrentDiff
            // 
            labelCurrentDiff.AutoSize = true;
            labelCurrentDiff.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCurrentDiff.Location = new Point(214, 201);
            labelCurrentDiff.Name = "labelCurrentDiff";
            labelCurrentDiff.Size = new Size(173, 37);
            labelCurrentDiff.TabIndex = 5;
            labelCurrentDiff.Text = "Нормальная";
            // 
            // labelDifficult
            // 
            labelDifficult.AutoSize = true;
            labelDifficult.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDifficult.Location = new Point(47, 200);
            labelDifficult.Name = "labelDifficult";
            labelDifficult.Size = new Size(153, 37);
            labelDifficult.TabIndex = 4;
            labelDifficult.Text = "Сложность";
            // 
            // labelSEC
            // 
            labelSEC.AutoSize = true;
            labelSEC.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSEC.Location = new Point(294, 129);
            labelSEC.Name = "labelSEC";
            labelSEC.Size = new Size(56, 37);
            labelSEC.TabIndex = 3;
            labelSEC.Text = "сек";
            // 
            // labelTime
            // 
            labelTime.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTime.ImageAlign = ContentAlignment.MiddleRight;
            labelTime.Location = new Point(216, 129);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(77, 37);
            labelTime.TabIndex = 2;
            labelTime.Text = "67";
            labelTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPlayTime
            // 
            labelPlayTime.AutoSize = true;
            labelPlayTime.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPlayTime.Location = new Point(47, 129);
            labelPlayTime.Name = "labelPlayTime";
            labelPlayTime.Size = new Size(163, 37);
            labelPlayTime.TabIndex = 1;
            labelPlayTime.Text = "Время игры";
            // 
            // labelWinLose
            // 
            labelWinLose.AutoSize = true;
            labelWinLose.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWinLose.Location = new Point(106, 36);
            labelWinLose.Name = "labelWinLose";
            labelWinLose.Size = new Size(456, 65);
            labelWinLose.TabIndex = 0;
            labelWinLose.Text = "победа/поражение";
            // 
            // panelStore
            // 
            panelStore.BackgroundImage = Properties.Resources.backgroundLibraryTwo;
            panelStore.Controls.Add(panel_inputBox);
            panelStore.Controls.Add(buttonSellBook);
            panelStore.Controls.Add(panelBookInfo);
            panelStore.Controls.Add(buttonCloset11);
            panelStore.Controls.Add(buttonCloset10);
            panelStore.Controls.Add(buttonCloset9);
            panelStore.Controls.Add(buttonCloset8);
            panelStore.Controls.Add(buttonCloset7);
            panelStore.Controls.Add(buttonCloset6);
            panelStore.Controls.Add(buttonCloset5);
            panelStore.Controls.Add(buttonCloset4);
            panelStore.Controls.Add(buttonCloset3);
            panelStore.Controls.Add(buttonCloset2);
            panelStore.Controls.Add(buttonCloset1);
            panelStore.Controls.Add(textBoxFindBook);
            panelStore.Controls.Add(labelFindBook);
            panelStore.Controls.Add(pictureBoxClient);
            panelStore.Controls.Add(promptLabel);
            panelStore.Controls.Add(labelClient);
            panelStore.Location = new Point(129, 40);
            panelStore.Name = "panelStore";
            panelStore.Size = new Size(1200, 1310);
            panelStore.TabIndex = 1;
            // 
            // panel_inputBox
            // 
            panel_inputBox.Controls.Add(button_sell);
            panel_inputBox.Controls.Add(buttonCancel);
            panel_inputBox.Controls.Add(textBox_inputBox);
            panel_inputBox.Controls.Add(label_inputBox);
            panel_inputBox.Location = new Point(333, 164);
            panel_inputBox.Name = "panel_inputBox";
            panel_inputBox.Size = new Size(415, 252);
            panel_inputBox.TabIndex = 23;
            // 
            // button_sell
            // 
            button_sell.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_sell.Location = new Point(20, 140);
            button_sell.Name = "button_sell";
            button_sell.Size = new Size(164, 67);
            button_sell.TabIndex = 3;
            button_sell.Text = "Продать";
            button_sell.UseVisualStyleBackColor = true;
            button_sell.Click += button_sell_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(221, 140);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(164, 67);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBox_inputBox
            // 
            textBox_inputBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_inputBox.Location = new Point(20, 80);
            textBox_inputBox.Name = "textBox_inputBox";
            textBox_inputBox.Size = new Size(370, 43);
            textBox_inputBox.TabIndex = 1;
            textBox_inputBox.TextChanged += textBox_inputBox_TextChanged;
            // 
            // label_inputBox
            // 
            label_inputBox.AutoSize = true;
            label_inputBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_inputBox.Location = new Point(20, 20);
            label_inputBox.Margin = new Padding(20);
            label_inputBox.Name = "label_inputBox";
            label_inputBox.Size = new Size(370, 37);
            label_inputBox.TabIndex = 0;
            label_inputBox.Text = "Выберите сумму продажи";
            // 
            // buttonSellBook
            // 
            buttonSellBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSellBook.Location = new Point(3, 628);
            buttonSellBook.Name = "buttonSellBook";
            buttonSellBook.Size = new Size(233, 43);
            buttonSellBook.TabIndex = 19;
            buttonSellBook.Text = "Продать книгу";
            buttonSellBook.UseVisualStyleBackColor = true;
            buttonSellBook.Click += buttonSellBook_Click;
            // 
            // panelBookInfo
            // 
            panelBookInfo.BackgroundImage = Properties.Resources.bordersBook1;
            panelBookInfo.Controls.Add(listBoxPrice);
            panelBookInfo.Controls.Add(label_panel_price);
            panelBookInfo.Controls.Add(listBoxPages);
            panelBookInfo.Controls.Add(label_panel_pages);
            panelBookInfo.Controls.Add(listBoxAuthor);
            panelBookInfo.Controls.Add(label_panel_author);
            panelBookInfo.Controls.Add(listBoxNameBook);
            panelBookInfo.Controls.Add(listBoxID);
            panelBookInfo.Controls.Add(label_panel_namebook);
            panelBookInfo.Controls.Add(label_panel_id);
            panelBookInfo.Location = new Point(72, 859);
            panelBookInfo.Name = "panelBookInfo";
            panelBookInfo.Size = new Size(1050, 323);
            panelBookInfo.TabIndex = 3;
            // 
            // listBoxPrice
            // 
            listBoxPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxPrice.FormattingEnabled = true;
            listBoxPrice.HorizontalScrollbar = true;
            listBoxPrice.Location = new Point(963, 30);
            listBoxPrice.Name = "listBoxPrice";
            listBoxPrice.Size = new Size(75, 279);
            listBoxPrice.TabIndex = 9;
            listBoxPrice.SelectedIndexChanged += listBoxPrice_SelectedIndexChanged;
            // 
            // label_panel_price
            // 
            label_panel_price.AutoSize = true;
            label_panel_price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_price.Location = new Point(963, 3);
            label_panel_price.Margin = new Padding(3);
            label_panel_price.Name = "label_panel_price";
            label_panel_price.Size = new Size(57, 25);
            label_panel_price.TabIndex = 8;
            label_panel_price.Text = "Цена";
            // 
            // listBoxPages
            // 
            listBoxPages.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxPages.FormattingEnabled = true;
            listBoxPages.HorizontalScrollbar = true;
            listBoxPages.Location = new Point(886, 30);
            listBoxPages.Name = "listBoxPages";
            listBoxPages.Size = new Size(71, 279);
            listBoxPages.TabIndex = 7;
            listBoxPages.SelectedIndexChanged += listBoxPages_SelectedIndexChanged;
            // 
            // label_panel_pages
            // 
            label_panel_pages.AutoSize = true;
            label_panel_pages.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_pages.Location = new Point(886, 3);
            label_panel_pages.Margin = new Padding(3);
            label_panel_pages.Name = "label_panel_pages";
            label_panel_pages.Size = new Size(47, 25);
            label_panel_pages.TabIndex = 6;
            label_panel_pages.Text = "Стр.";
            // 
            // listBoxAuthor
            // 
            listBoxAuthor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxAuthor.FormattingEnabled = true;
            listBoxAuthor.HorizontalScrollbar = true;
            listBoxAuthor.Location = new Point(574, 30);
            listBoxAuthor.Name = "listBoxAuthor";
            listBoxAuthor.Size = new Size(306, 279);
            listBoxAuthor.TabIndex = 5;
            listBoxAuthor.SelectedIndexChanged += listBoxAuthor_SelectedIndexChanged;
            // 
            // label_panel_author
            // 
            label_panel_author.AutoSize = true;
            label_panel_author.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_author.Location = new Point(574, 3);
            label_panel_author.Margin = new Padding(3);
            label_panel_author.Name = "label_panel_author";
            label_panel_author.Size = new Size(64, 25);
            label_panel_author.TabIndex = 4;
            label_panel_author.Text = "Автор";
            // 
            // listBoxNameBook
            // 
            listBoxNameBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxNameBook.FormattingEnabled = true;
            listBoxNameBook.HorizontalScrollbar = true;
            listBoxNameBook.Location = new Point(39, 30);
            listBoxNameBook.Name = "listBoxNameBook";
            listBoxNameBook.Size = new Size(529, 279);
            listBoxNameBook.TabIndex = 3;
            listBoxNameBook.SelectedIndexChanged += listBoxNameBook_SelectedIndexChanged;
            // 
            // listBoxID
            // 
            listBoxID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxID.FormattingEnabled = true;
            listBoxID.HorizontalScrollbar = true;
            listBoxID.Location = new Point(3, 30);
            listBoxID.Name = "listBoxID";
            listBoxID.Size = new Size(30, 279);
            listBoxID.TabIndex = 2;
            listBoxID.SelectedIndexChanged += listBoxID_SelectedIndexChanged;
            // 
            // label_panel_namebook
            // 
            label_panel_namebook.AutoSize = true;
            label_panel_namebook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_namebook.Location = new Point(39, 3);
            label_panel_namebook.Margin = new Padding(3);
            label_panel_namebook.Name = "label_panel_namebook";
            label_panel_namebook.Size = new Size(149, 25);
            label_panel_namebook.TabIndex = 1;
            label_panel_namebook.Text = "Название книги";
            // 
            // label_panel_id
            // 
            label_panel_id.AutoSize = true;
            label_panel_id.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_id.Location = new Point(3, 3);
            label_panel_id.Margin = new Padding(3);
            label_panel_id.Name = "label_panel_id";
            label_panel_id.Size = new Size(30, 25);
            label_panel_id.TabIndex = 0;
            label_panel_id.Text = "ID";
            // 
            // buttonCloset11
            // 
            buttonCloset11.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset11.ForeColor = SystemColors.ControlLightLight;
            buttonCloset11.Location = new Point(1076, 231);
            buttonCloset11.Margin = new Padding(25);
            buttonCloset11.Name = "buttonCloset11";
            buttonCloset11.Size = new Size(50, 323);
            buttonCloset11.TabIndex = 18;
            buttonCloset11.Text = "genre";
            buttonCloset11.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset11.UseVisualStyleBackColor = true;
            buttonCloset11.Click += buttonCloset11_Click;
            // 
            // buttonCloset10
            // 
            buttonCloset10.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset10.ForeColor = SystemColors.ControlLightLight;
            buttonCloset10.Location = new Point(976, 231);
            buttonCloset10.Margin = new Padding(25);
            buttonCloset10.Name = "buttonCloset10";
            buttonCloset10.Size = new Size(50, 323);
            buttonCloset10.TabIndex = 17;
            buttonCloset10.Text = "genre";
            buttonCloset10.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset10.UseVisualStyleBackColor = true;
            buttonCloset10.Click += buttonCloset10_Click;
            // 
            // buttonCloset9
            // 
            buttonCloset9.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset9.ForeColor = SystemColors.ControlLightLight;
            buttonCloset9.Location = new Point(876, 231);
            buttonCloset9.Margin = new Padding(25);
            buttonCloset9.Name = "buttonCloset9";
            buttonCloset9.Size = new Size(50, 323);
            buttonCloset9.TabIndex = 16;
            buttonCloset9.Text = "genre";
            buttonCloset9.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset9.UseVisualStyleBackColor = true;
            buttonCloset9.Click += buttonCloset9_Click;
            // 
            // buttonCloset8
            // 
            buttonCloset8.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset8.ForeColor = SystemColors.ControlLightLight;
            buttonCloset8.Location = new Point(776, 231);
            buttonCloset8.Margin = new Padding(25);
            buttonCloset8.Name = "buttonCloset8";
            buttonCloset8.Size = new Size(50, 323);
            buttonCloset8.TabIndex = 15;
            buttonCloset8.Text = "genre";
            buttonCloset8.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset8.UseVisualStyleBackColor = true;
            buttonCloset8.Click += buttonCloset8_Click;
            // 
            // buttonCloset7
            // 
            buttonCloset7.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset7.ForeColor = SystemColors.ControlLightLight;
            buttonCloset7.Location = new Point(676, 231);
            buttonCloset7.Margin = new Padding(25);
            buttonCloset7.Name = "buttonCloset7";
            buttonCloset7.Size = new Size(50, 323);
            buttonCloset7.TabIndex = 14;
            buttonCloset7.Text = "genre";
            buttonCloset7.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset7.UseVisualStyleBackColor = true;
            buttonCloset7.Click += buttonCloset7_Click;
            // 
            // buttonCloset6
            // 
            buttonCloset6.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset6.ForeColor = SystemColors.ControlLightLight;
            buttonCloset6.Location = new Point(576, 231);
            buttonCloset6.Margin = new Padding(25);
            buttonCloset6.Name = "buttonCloset6";
            buttonCloset6.Size = new Size(50, 323);
            buttonCloset6.TabIndex = 13;
            buttonCloset6.Text = "genre";
            buttonCloset6.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset6.UseVisualStyleBackColor = true;
            buttonCloset6.Click += buttonCloset6_Click;
            // 
            // buttonCloset5
            // 
            buttonCloset5.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset5.ForeColor = SystemColors.ControlLightLight;
            buttonCloset5.Location = new Point(476, 231);
            buttonCloset5.Margin = new Padding(25);
            buttonCloset5.Name = "buttonCloset5";
            buttonCloset5.Size = new Size(50, 323);
            buttonCloset5.TabIndex = 12;
            buttonCloset5.Text = "genre";
            buttonCloset5.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset5.UseVisualStyleBackColor = true;
            buttonCloset5.Click += buttonCloset5_Click;
            // 
            // buttonCloset4
            // 
            buttonCloset4.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset4.ForeColor = SystemColors.ControlLightLight;
            buttonCloset4.Location = new Point(376, 231);
            buttonCloset4.Margin = new Padding(25);
            buttonCloset4.Name = "buttonCloset4";
            buttonCloset4.Size = new Size(50, 323);
            buttonCloset4.TabIndex = 11;
            buttonCloset4.Text = "genre";
            buttonCloset4.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset4.UseVisualStyleBackColor = true;
            buttonCloset4.Click += buttonCloset4_Click;
            // 
            // buttonCloset3
            // 
            buttonCloset3.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset3.ForeColor = SystemColors.ControlLightLight;
            buttonCloset3.Location = new Point(276, 231);
            buttonCloset3.Margin = new Padding(25);
            buttonCloset3.Name = "buttonCloset3";
            buttonCloset3.Size = new Size(50, 323);
            buttonCloset3.TabIndex = 10;
            buttonCloset3.Text = "genre";
            buttonCloset3.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset3.UseVisualStyleBackColor = true;
            buttonCloset3.Click += buttonCloset3_Click;
            // 
            // buttonCloset2
            // 
            buttonCloset2.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset2.ForeColor = SystemColors.ControlLightLight;
            buttonCloset2.Location = new Point(176, 231);
            buttonCloset2.Margin = new Padding(25);
            buttonCloset2.Name = "buttonCloset2";
            buttonCloset2.Size = new Size(50, 323);
            buttonCloset2.TabIndex = 9;
            buttonCloset2.Text = "genre";
            buttonCloset2.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset2.UseVisualStyleBackColor = true;
            buttonCloset2.Click += buttonCloset2_Click;
            // 
            // buttonCloset1
            // 
            buttonCloset1.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset1.ForeColor = SystemColors.ControlLightLight;
            buttonCloset1.Location = new Point(76, 231);
            buttonCloset1.Margin = new Padding(25);
            buttonCloset1.Name = "buttonCloset1";
            buttonCloset1.Size = new Size(50, 323);
            buttonCloset1.TabIndex = 8;
            buttonCloset1.Text = "genre";
            buttonCloset1.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset1.UseVisualStyleBackColor = true;
            buttonCloset1.Click += buttonCloset1_Click;
            // 
            // textBoxFindBook
            // 
            textBoxFindBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFindBook.Location = new Point(75, 582);
            textBoxFindBook.Multiline = true;
            textBoxFindBook.Name = "textBoxFindBook";
            textBoxFindBook.Size = new Size(474, 38);
            textBoxFindBook.TabIndex = 7;
            textBoxFindBook.TextChanged += textBoxFindBook_TextChanged;
            // 
            // labelFindBook
            // 
            labelFindBook.AutoSize = true;
            labelFindBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFindBook.Location = new Point(3, 585);
            labelFindBook.Name = "labelFindBook";
            labelFindBook.Size = new Size(66, 25);
            labelFindBook.TabIndex = 6;
            labelFindBook.Text = "Поиск";
            // 
            // pictureBoxClient
            // 
            pictureBoxClient.BackColor = Color.Transparent;
            pictureBoxClient.Location = new Point(741, 200);
            pictureBoxClient.Name = "pictureBoxClient";
            pictureBoxClient.Size = new Size(341, 439);
            pictureBoxClient.TabIndex = 20;
            pictureBoxClient.TabStop = false;
            // 
            // promptLabel
            // 
            promptLabel.BackColor = Color.Transparent;
            promptLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            promptLabel.Location = new Point(741, 127);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(341, 70);
            promptLabel.TabIndex = 22;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelClient.Location = new Point(554, 75);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(477, 37);
            labelClient.TabIndex = 21;
            labelClient.Text = "У Вас пока нет ни одного покупателя";
            labelClient.Click += labelClient_Click;
            // 
            // labelRUBL
            // 
            labelRUBL.AutoSize = true;
            labelRUBL.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRUBL.Location = new Point(1146, 55);
            labelRUBL.Name = "labelRUBL";
            labelRUBL.Size = new Size(47, 25);
            labelRUBL.TabIndex = 2;
            labelRUBL.Text = "руб.";
            // 
            // textBoxBalance
            // 
            textBoxBalance.Enabled = false;
            textBoxBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBalance.Location = new Point(950, 52);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(190, 33);
            textBoxBalance.TabIndex = 1;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBalance.Location = new Point(871, 55);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(73, 25);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "Баланс";
            // 
            // buttonNewBook
            // 
            buttonNewBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonNewBook.Location = new Point(0, 0);
            buttonNewBook.Name = "buttonNewBook";
            buttonNewBook.Size = new Size(400, 34);
            buttonNewBook.TabIndex = 2;
            buttonNewBook.Text = "Заказать книгу";
            buttonNewBook.UseVisualStyleBackColor = true;
            buttonNewBook.Click += buttonNewBook_Click;
            // 
            // buttonStore
            // 
            buttonStore.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStore.Location = new Point(406, 0);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(400, 34);
            buttonStore.TabIndex = 1;
            buttonStore.Text = "Магазин";
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += buttonStore_Click;
            // 
            // buttonDelivery
            // 
            buttonDelivery.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelivery.Location = new Point(927, 0);
            buttonDelivery.Name = "buttonDelivery";
            buttonDelivery.Size = new Size(290, 34);
            buttonDelivery.TabIndex = 3;
            buttonDelivery.Text = "Поставки";
            buttonDelivery.UseVisualStyleBackColor = true;
            buttonDelivery.Click += buttonDelivery_Click;
            // 
            // buttonBuyers
            // 
            buttonBuyers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBuyers.Location = new Point(812, 0);
            buttonBuyers.Name = "buttonBuyers";
            buttonBuyers.Size = new Size(400, 34);
            buttonBuyers.TabIndex = 4;
            buttonBuyers.Text = "Покупатели";
            buttonBuyers.UseVisualStyleBackColor = true;
            buttonBuyers.Click += buttonBuyers_Click;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1234, 866);
            Controls.Add(panelStore);
            Controls.Add(textBoxBalance);
            Controls.Add(labelBalance);
            Controls.Add(labelRUBL);
            Controls.Add(buttonBuyers);
            Controls.Add(buttonDelivery);
            Controls.Add(buttonStore);
            Controls.Add(buttonNewBook);
            Controls.Add(panelNewBook);
            Controls.Add(panelScore);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1250, 905);
            MinimumSize = new Size(1250, 905);
            Name = "Store";
            Text = "МагаZин";
            Load += Store_Load;
            panelNewBook.ResumeLayout(false);
            panelNewBook.PerformLayout();
            panelScore.ResumeLayout(false);
            panelScore.PerformLayout();
            panelStore.ResumeLayout(false);
            panelStore.PerformLayout();
            panel_inputBox.ResumeLayout(false);
            panel_inputBox.PerformLayout();
            panelBookInfo.ResumeLayout(false);
            panelBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelNewBook;
        private Panel panelStore;
        private Button buttonNewBook;
        private Label labelNameBook;
        private Button buttonStore;
        private TextBox textBoxGenre;
        private Label labelGenre;
        private TextBox textBoxAuthor;
        private Label labelAuthor;
        private TextBox textBoxNameBook;
        private Label labelPages;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private TextBox textBoxPages;
        private Label label_idBook;
        private TextBox textBoxIDBook;
        private Label labelRUB;
        private Button buttonRandom;
        private Button buttonAddBook;
        private Label labelBalance;
        private Label labelRUBL;
        private TextBox textBoxBalance;
        private Label labelFindBook;
        private TextBox textBoxFindBook;
        private Button buttonCloset1;
        private Button buttonCloset5;
        private Button buttonCloset4;
        private Button buttonCloset3;
        private Button buttonCloset2;
        private Button buttonCloset11;
        private Button buttonCloset10;
        private Button buttonCloset9;
        private Button buttonCloset8;
        private Button buttonCloset7;
        private Button buttonCloset6;
        private Panel panelBookInfo;
        private Label label_panel_id;
        private Label label_panel_namebook;
        private ListBox listBoxID;
        private ListBox listBoxNameBook;
        private Label label_panel_author;
        private Label label_panel_pages;
        private ListBox listBoxAuthor;
        private ListBox listBoxPrice;
        private Label label_panel_price;
        private ListBox listBoxPages;
        private Button buttonSellBook;
        private Button buttonDelivery;
        private Button buttonBuyers;
        private Button buttonAccept;
        private Button buttonReject;
        private PictureBox pictureBoxClient;
        private Label labelClient;
        private Label promptLabel;
        private Panel panel_inputBox;
        private TextBox textBox_inputBox;
        private Label label_inputBox;
        private Button buttonCancel;
        private Button button_sell;
        private Panel panelScore;
        private Label labelWinLose;
        private Label labelDifficult;
        private Label labelSEC;
        private Label labelTime;
        private Label labelPlayTime;
        private Label labelCount;
        private Label labelCountClient;
        private Label labelCurrentDiff;
        private Button buttonContinue;
    }
}