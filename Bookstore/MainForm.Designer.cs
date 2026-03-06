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
            panelNewBook = new Panel();
            labelErrors = new Label();
            buttonAddBook = new Button();
            buttonRandom = new Button();
            labelRUB = new Label();
            textBoxIDBook = new TextBox();
            label_idBook = new Label();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            textBoxPages = new TextBox();
            labelPages = new Label();
            textBoxGenre = new TextBox();
            labelGenre = new Label();
            textBoxAuthor = new TextBox();
            labelAuthor = new Label();
            textBoxNameBook = new TextBox();
            labelNameBook = new Label();
            panelStore = new Panel();
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
            labelRUBL = new Label();
            textBoxBalance = new TextBox();
            labelBalance = new Label();
            buttonNewBook = new Button();
            buttonStore = new Button();
            panelNewBook.SuspendLayout();
            panelStore.SuspendLayout();
            panelBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelNewBook
            // 
            panelNewBook.BackgroundImage = Properties.Resources.library_backgroud;
            panelNewBook.Controls.Add(labelErrors);
            panelNewBook.Controls.Add(buttonAddBook);
            panelNewBook.Controls.Add(buttonRandom);
            panelNewBook.Controls.Add(labelRUB);
            panelNewBook.Controls.Add(textBoxIDBook);
            panelNewBook.Controls.Add(label_idBook);
            panelNewBook.Controls.Add(textBoxPrice);
            panelNewBook.Controls.Add(labelPrice);
            panelNewBook.Controls.Add(textBoxPages);
            panelNewBook.Controls.Add(labelPages);
            panelNewBook.Controls.Add(textBoxGenre);
            panelNewBook.Controls.Add(labelGenre);
            panelNewBook.Controls.Add(textBoxAuthor);
            panelNewBook.Controls.Add(labelAuthor);
            panelNewBook.Controls.Add(textBoxNameBook);
            panelNewBook.Controls.Add(labelNameBook);
            panelNewBook.Location = new Point(0, 40);
            panelNewBook.Name = "panelNewBook";
            panelNewBook.Size = new Size(706, 500);
            panelNewBook.TabIndex = 0;
            // 
            // labelErrors
            // 
            labelErrors.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelErrors.Location = new Point(10, 350);
            labelErrors.Margin = new Padding(10);
            labelErrors.Name = "labelErrors";
            labelErrors.Size = new Size(686, 140);
            labelErrors.TabIndex = 14;
            labelErrors.Text = "Обработка ошибок";
            // 
            // buttonAddBook
            // 
            buttonAddBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddBook.Location = new Point(19, 280);
            buttonAddBook.Margin = new Padding(10);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(250, 50);
            buttonAddBook.TabIndex = 12;
            buttonAddBook.Text = "Добавить книгу";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += MyClassLibrary.buttonAddBook_Click;
            // 
            // buttonRandom
            // 
            buttonRandom.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRandom.Location = new Point(428, 280);
            buttonRandom.Margin = new Padding(10);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(250, 50);
            buttonRandom.TabIndex = 13;
            buttonRandom.Text = "Случайная генерация";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += MyClassLibrary.buttonRandom_Click;
            // 
            // labelRUB
            // 
            labelRUB.AutoSize = true;
            labelRUB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRUB.Location = new Point(626, 178);
            labelRUB.Margin = new Padding(1, 10, 10, 10);
            labelRUB.Name = "labelRUB";
            labelRUB.Size = new Size(52, 30);
            labelRUB.TabIndex = 11;
            labelRUB.Text = "руб.";
            // 
            // textBoxIDBook
            // 
            textBoxIDBook.Enabled = false;
            textBoxIDBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIDBook.Location = new Point(135, 227);
            textBoxIDBook.Margin = new Padding(10);
            textBoxIDBook.Name = "textBoxIDBook";
            textBoxIDBook.Size = new Size(196, 35);
            textBoxIDBook.TabIndex = 10;
            // 
            // label_idBook
            // 
            label_idBook.AutoSize = true;
            label_idBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_idBook.Location = new Point(10, 230);
            label_idBook.Margin = new Padding(10);
            label_idBook.Name = "label_idBook";
            label_idBook.Size = new Size(94, 30);
            label_idBook.TabIndex = 9;
            label_idBook.Text = "ID книги";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPrice.Location = new Point(434, 175);
            textBoxPrice.Margin = new Padding(10, 10, 1, 10);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(190, 35);
            textBoxPrice.TabIndex = 7;
            textBoxPrice.TextChanged += MyClassLibrary.textBoxPrice_TextChanged;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(351, 180);
            labelPrice.Margin = new Padding(10);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(63, 30);
            labelPrice.TabIndex = 8;
            labelPrice.Text = "Цена";
            // 
            // textBoxPages
            // 
            textBoxPages.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPages.Location = new Point(135, 175);
            textBoxPages.Margin = new Padding(10);
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new Size(196, 35);
            textBoxPages.TabIndex = 6;
            textBoxPages.TextChanged += MyClassLibrary.textBoxPages_TextChanged;
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPages.Location = new Point(10, 180);
            labelPages.Margin = new Padding(10);
            labelPages.Name = "labelPages";
            labelPages.Size = new Size(110, 30);
            labelPages.TabIndex = 6;
            labelPages.Text = "Страницы";
            // 
            // textBoxGenre
            // 
            textBoxGenre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxGenre.Location =  new Point(135, 120);
            textBoxGenre.Margin = new Padding(10);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(561, 35);
            textBoxGenre.TabIndex = 4;
            textBoxGenre.TextChanged += MyClassLibrary.textBoxGenre_TextChanged;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGenre.Location = new Point(10, 123);
            labelGenre.Margin = new Padding(10);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(66, 30);
            labelGenre.TabIndex = 4;
            labelGenre.Text = "Жанр";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAuthor.Location = new Point(135, 65);
            textBoxAuthor.Margin = new Padding(10);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(561, 35);
            textBoxAuthor.TabIndex = 5;
            textBoxAuthor.TextChanged += MyClassLibrary.textBoxAuthor_TextChanged;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuthor.Location = new Point(10, 68);
            labelAuthor.Margin = new Padding(10);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(71, 30);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Автор";
            // 
            // textBoxNameBook
            // 
            textBoxNameBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxNameBook.Location = new Point(135, 10);
            textBoxNameBook.Margin = new Padding(10);
            textBoxNameBook.Name = "textBoxNameBook";
            textBoxNameBook.Size = new Size(561, 35);
            textBoxNameBook.TabIndex = 3;
            textBoxNameBook.TextChanged += MyClassLibrary.textBoxNameBook_TextChanged;
            // 
            // labelNameBook
            // 
            labelNameBook.AutoSize = true;
            labelNameBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameBook.Location = new Point(10, 10);
            labelNameBook.Margin = new Padding(10);
            labelNameBook.Name = "labelNameBook";
            labelNameBook.Size = new Size(105, 30);
            labelNameBook.TabIndex = 0;
            labelNameBook.Text = "Название";
            // 
            // panelStore
            // 
            panelStore.BackgroundImage = Properties.Resources.backgroundLibrary2;
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
            panelStore.Controls.Add(labelRUBL);
            panelStore.Controls.Add(textBoxBalance);
            panelStore.Controls.Add(labelBalance);
            panelStore.Location = new Point(761, 40);
            panelStore.Name = "panelStore";
            panelStore.Size = new Size(915, 910);
            panelStore.TabIndex = 1;
            // 
            // buttonSellBook
            // 
            buttonSellBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSellBook.Location = new Point(10, 457);
            buttonSellBook.Name = "buttonSellBook";
            buttonSellBook.Size = new Size(233, 43);
            buttonSellBook.TabIndex = 19;
            buttonSellBook.Text = "Продать книгу";
            buttonSellBook.UseVisualStyleBackColor = true;
            buttonSellBook.Click += MyClassLibrary.buttonSellBook_Click;
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
            panelBookInfo.Location = new Point(82, 564);
            panelBookInfo.Name = "panelBookInfo";
            panelBookInfo.Size = new Size(725, 323);
            panelBookInfo.TabIndex = 3;
            // 
            // listBoxPrice
            // 
            listBoxPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxPrice.FormattingEnabled = true;
            listBoxPrice.HorizontalScrollbar = true;
            listBoxPrice.Items.AddRange(new object[] { "666", "100", "999", "1234" });
            listBoxPrice.Location = new Point(657, 30);
            listBoxPrice.Name = "listBoxPrice";
            listBoxPrice.Size = new Size(58, 279);
            listBoxPrice.TabIndex = 9;
            listBoxPrice.SelectedIndexChanged += MyClassLibrary.listBoxPrice_SelectedIndexChanged;
            // 
            // label_panel_price
            // 
            label_panel_price.AutoSize = true;
            label_panel_price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_price.Location = new Point(657, 3);
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
            listBoxPages.Items.AddRange(new object[] { "100", "67", "123", "1234567" });
            listBoxPages.Location = new Point(593, 30);
            listBoxPages.Name = "listBoxPages";
            listBoxPages.Size = new Size(58, 279);
            listBoxPages.TabIndex = 7;
            listBoxPages.SelectedIndexChanged += MyClassLibrary.listBoxPages_SelectedIndexChanged;
            // 
            // label_panel_pages
            // 
            label_panel_pages.AutoSize = true;
            label_panel_pages.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_pages.Location = new Point(593, 3);
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
            listBoxAuthor.Items.AddRange(new object[] { "пушкин", "александр", "хз кто", "долбоеб" });
            listBoxAuthor.Location = new Point(466, 30);
            listBoxAuthor.Name = "listBoxAuthor";
            listBoxAuthor.Size = new Size(121, 279);
            listBoxAuthor.TabIndex = 5;
            listBoxAuthor.SelectedIndexChanged += MyClassLibrary.listBoxAuthor_SelectedIndexChanged;
            // 
            // label_panel_author
            // 
            label_panel_author.AutoSize = true;
            label_panel_author.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_author.Location = new Point(470, 3);
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
            listBoxNameBook.Items.AddRange(new object[] { "алые паруса fodsajfldsjfjsdlkfjsfjsdjksl;jf;sdj;fsdk;fjkalfd", "залупа", "коля", "гей" });
            listBoxNameBook.Location = new Point(39, 30);
            listBoxNameBook.Name = "listBoxNameBook";
            listBoxNameBook.Size = new Size(421, 279);
            listBoxNameBook.TabIndex = 3;
            listBoxNameBook.SelectedIndexChanged += MyClassLibrary.listBoxNameBook_SelectedIndexChanged;
            // 
            // listBoxID
            // 
            listBoxID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxID.FormattingEnabled = true;
            listBoxID.HorizontalScrollbar = true;
            listBoxID.Items.AddRange(new object[] { "1", "2", "3", "4" });
            listBoxID.Location = new Point(3, 30);
            listBoxID.Name = "listBoxID";
            listBoxID.Size = new Size(30, 279);
            listBoxID.TabIndex = 2;
            listBoxID.SelectedIndexChanged += MyClassLibrary.listBoxID_SelectedIndexChanged;
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
            buttonCloset11.Location = new Point(672, 80);
            buttonCloset11.Margin = new Padding(5);
            buttonCloset11.Name = "buttonCloset11";
            buttonCloset11.Size = new Size(50, 323);
            buttonCloset11.TabIndex = 18;
            buttonCloset11.Text = "Хуйня";
            buttonCloset11.UseVisualStyleBackColor = true;
            buttonCloset11.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset11.Click += MyClassLibrary.buttonCloset11_Click;
            // 
            // buttonCloset10
            // 
            buttonCloset10.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset10.ForeColor = SystemColors.ControlLightLight;
            buttonCloset10.Location = new Point(612, 80);
            buttonCloset10.Margin = new Padding(5);
            buttonCloset10.Name = "buttonCloset10";
            buttonCloset10.Size = new Size(50, 323);
            buttonCloset10.TabIndex = 17;
            buttonCloset10.Text = "Хоррор";
            buttonCloset10.UseVisualStyleBackColor = true;
            buttonCloset10.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset10.Click += MyClassLibrary.buttonCloset10_Click;
            // 
            // buttonCloset9
            // 
            buttonCloset9.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset9.ForeColor = SystemColors.ControlLightLight;
            buttonCloset9.Location = new Point(552, 80);
            buttonCloset9.Margin = new Padding(5);
            buttonCloset9.Name = "buttonCloset9";
            buttonCloset9.Size = new Size(50, 323);
            buttonCloset9.TabIndex = 16;
            buttonCloset9.Text = "Научная литература";
            buttonCloset9.UseVisualStyleBackColor = true;
            buttonCloset9.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset9.Click += MyClassLibrary.buttonCloset9_Click;
            // 
            // buttonCloset8
            // 
            buttonCloset8.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset8.ForeColor = SystemColors.ControlLightLight;
            buttonCloset8.Location = new Point(492, 80);
            buttonCloset8.Margin = new Padding(5);
            buttonCloset8.Name = "buttonCloset8";
            buttonCloset8.Size = new Size(50, 323);
            buttonCloset8.TabIndex = 15;
            buttonCloset8.Text = "Биография";
            buttonCloset8.UseVisualStyleBackColor = true;
            buttonCloset8.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset8.Click += MyClassLibrary.buttonCloset8_Click;
            // 
            // buttonCloset7
            // 
            buttonCloset7.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset7.ForeColor = SystemColors.ControlLightLight;
            buttonCloset7.Location = new Point(432, 80);
            buttonCloset7.Margin = new Padding(5);
            buttonCloset7.Name = "buttonCloset7";
            buttonCloset7.Size = new Size(50, 323);
            buttonCloset7.TabIndex = 14;
            buttonCloset7.Text = "Психология";
            buttonCloset7.UseVisualStyleBackColor = true;
            buttonCloset7.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset7.Click += MyClassLibrary.buttonCloset7_Click;
            // 
            // buttonCloset6
            // 
            buttonCloset6.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset6.ForeColor = SystemColors.ControlLightLight;
            buttonCloset6.Location = new Point(372, 80);
            buttonCloset6.Margin = new Padding(5);
            buttonCloset6.Name = "buttonCloset6";
            buttonCloset6.Size = new Size(50, 323);
            buttonCloset6.TabIndex = 13;
            buttonCloset6.Text = "Классическая литература";
            buttonCloset6.UseVisualStyleBackColor = true;
            buttonCloset6.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset6.Click += MyClassLibrary.buttonCloset6_Click;
            // 
            // buttonCloset5
            // 
            buttonCloset5.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset5.ForeColor = SystemColors.ControlLightLight;
            buttonCloset5.Location = new Point(312, 80);
            buttonCloset5.Margin = new Padding(5);
            buttonCloset5.Name = "buttonCloset5";
            buttonCloset5.Size = new Size(50, 323);
            buttonCloset5.TabIndex = 12;
            buttonCloset5.Text = "Поэзия";
            buttonCloset5.UseVisualStyleBackColor = true;
            buttonCloset5.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset5.Click += MyClassLibrary.buttonCloset5_Click;
            // 
            // buttonCloset4
            // 
            buttonCloset4.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset4.ForeColor = SystemColors.ControlLightLight;
            buttonCloset4.Location = new Point(252, 80);
            buttonCloset4.Margin = new Padding(5);
            buttonCloset4.Name = "buttonCloset4";
            buttonCloset4.Size = new Size(50, 323);
            buttonCloset4.TabIndex = 11;
            buttonCloset4.Text = "Приключение";
            buttonCloset4.UseVisualStyleBackColor = true;
            buttonCloset4.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset4.Click += MyClassLibrary.buttonCloset4_Click;
            // 
            // buttonCloset3
            // 
            buttonCloset3.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset3.ForeColor = SystemColors.ControlLightLight;
            buttonCloset3.Location = new Point(192, 80);
            buttonCloset3.Margin = new Padding(5);
            buttonCloset3.Name = "buttonCloset3";
            buttonCloset3.Size = new Size(50, 323);
            buttonCloset3.TabIndex = 10;
            buttonCloset3.Text = "Роман";
            buttonCloset3.UseVisualStyleBackColor = true;
            buttonCloset3.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset3.Click += MyClassLibrary.buttonCloset3_Click;
            // 
            // buttonCloset2
            // 
            buttonCloset2.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset2.ForeColor = SystemColors.ControlLightLight;
            buttonCloset2.Location = new Point(132, 80);
            buttonCloset2.Margin = new Padding(5);
            buttonCloset2.Name = "buttonCloset2";
            buttonCloset2.Size = new Size(50, 323);
            buttonCloset2.TabIndex = 9;
            buttonCloset2.Text = "Фентези";
            buttonCloset2.UseVisualStyleBackColor = true;
            buttonCloset2.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset2.Click += MyClassLibrary.buttonCloset2_Click;
            // 
            // buttonCloset1
            // 
            buttonCloset1.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset1.ForeColor = SystemColors.ControlLightLight;
            buttonCloset1.Location = new Point(72, 80);
            buttonCloset1.Margin = new Padding(5);
            buttonCloset1.Name = "buttonCloset1";
            buttonCloset1.Size = new Size(50, 323);
            buttonCloset1.TabIndex = 8;
            buttonCloset1.Text = "Философия";
            buttonCloset1.UseVisualStyleBackColor = true;
            buttonCloset1.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset1.Click += MyClassLibrary.buttonCloset1_Click;
            // 
            // textBoxFindBook
            // 
            textBoxFindBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFindBook.Location = new Point(82, 411);
            textBoxFindBook.Name = "textBoxFindBook";
            textBoxFindBook.Size = new Size(621, 38);
            textBoxFindBook.TabIndex = 7;
            textBoxFindBook.Multiline = true;
            textBoxFindBook.TextChanged += MyClassLibrary.textBoxFindBook_TextChanged;
            // 
            // labelFindBook
            // 
            labelFindBook.AutoSize = true;
            labelFindBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFindBook.Location = new Point(10, 414);
            labelFindBook.Name = "labelFindBook";
            labelFindBook.Size = new Size(66, 25);
            labelFindBook.TabIndex = 6;
            labelFindBook.Text = "Поиск";
            // 
            // labelRUBL
            // 
            labelRUBL.AutoSize = true;
            labelRUBL.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRUBL.Location = new Point(656, 10);
            labelRUBL.Name = "labelRUBL";
            labelRUBL.Size = new Size(47, 25);
            labelRUBL.TabIndex = 2;
            labelRUBL.Text = "руб.";
            // 
            // textBoxBalance
            // 
            textBoxBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBalance.Location = new Point(460, 7);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(190, 33);
            textBoxBalance.TabIndex = 1;
            textBoxBalance.Enabled = false;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBalance.Location = new Point(381, 10);
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
            buttonNewBook.Size = new Size(345, 34);
            buttonNewBook.TabIndex = 1;
            buttonNewBook.Text = "Новая книга";
            buttonNewBook.UseVisualStyleBackColor = true;
            buttonNewBook.Click += MyClassLibrary.buttonNewBook_Click;
            // 
            // buttonStore
            // 
            buttonStore.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStore.Location = new Point(351, 0);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(345, 34);
            buttonStore.TabIndex = 2;
            buttonStore.Text = "Магазин";
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += MyClassLibrary.buttonStore_Click;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 561);
            Controls.Add(buttonStore);
            Controls.Add(buttonNewBook);
            Controls.Add(panelStore);
            Controls.Add(panelNewBook);
            MinimumSize = new Size(800, 600);
            Name = "Store";
            Text = "Store";
            Load += MyClassLibrary.Store_Load;
            panelNewBook.ResumeLayout(false);
            panelNewBook.PerformLayout();
            panelStore.ResumeLayout(false);
            panelStore.PerformLayout();
            panelBookInfo.ResumeLayout(false);
            panelBookInfo.PerformLayout();
            ResumeLayout(false);
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
        private Label labelErrors;
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
    }
}

/*
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
            panelNewBook = new Panel();
            labelErrors = new Label();
            buttonAddBook = new Button();
            buttonRandom = new Button();
            labelRUB = new Label();
            textBoxIDBook = new TextBox();
            label_idBook = new Label();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            textBoxPages = new TextBox();
            labelPages = new Label();
            textBoxGenre = new TextBox();
            labelGenre = new Label();
            textBoxAuthor = new TextBox();
            labelAuthor = new Label();
            textBoxNameBook = new TextBox();
            labelNameBook = new Label();
            panelStore = new Panel();
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
            labelRUBL = new Label();
            textBoxBalance = new TextBox();
            labelBalance = new Label();
            buttonNewBook = new Button();
            buttonStore = new Button();
            panelNewBook.SuspendLayout();
            panelStore.SuspendLayout();
            panelBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelNewBook
            // 
            panelNewBook.BackgroundImage = Properties.Resources.library_backgroud;
            panelNewBook.Controls.Add(labelErrors);
            panelNewBook.Controls.Add(buttonAddBook);
            panelNewBook.Controls.Add(buttonRandom);
            panelNewBook.Controls.Add(labelRUB);
            panelNewBook.Controls.Add(textBoxIDBook);
            panelNewBook.Controls.Add(label_idBook);
            panelNewBook.Controls.Add(textBoxPrice);
            panelNewBook.Controls.Add(labelPrice);
            panelNewBook.Controls.Add(textBoxPages);
            panelNewBook.Controls.Add(labelPages);
            panelNewBook.Controls.Add(textBoxGenre);
            panelNewBook.Controls.Add(labelGenre);
            panelNewBook.Controls.Add(textBoxAuthor);
            panelNewBook.Controls.Add(labelAuthor);
            panelNewBook.Controls.Add(textBoxNameBook);
            panelNewBook.Controls.Add(labelNameBook);
            panelNewBook.Location = new Point(0, 40);
            panelNewBook.Name = "panelNewBook";
            panelNewBook.Size = new Size(706, 500);
            panelNewBook.TabIndex = 0;
            // 
            // labelErrors
            // 
            labelErrors.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelErrors.Location = new Point(10, 350);
            labelErrors.Margin = new Padding(10);
            labelErrors.Name = "labelErrors";
            labelErrors.Size = new Size(686, 140);
            labelErrors.TabIndex = 14;
            labelErrors.Text = "Обработка ошибок";
            // 
            // buttonAddBook
            // 
            buttonAddBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddBook.Location = new Point(19, 280);
            buttonAddBook.Margin = new Padding(10);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(250, 50);
            buttonAddBook.TabIndex = 12;
            buttonAddBook.Text = "Добавить книгу";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += MyClassLibrary.buttonAddBook_Click;
            // 
            // buttonRandom
            // 
            buttonRandom.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRandom.Location = new Point(428, 280);
            buttonRandom.Margin = new Padding(10);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(250, 50);
            buttonRandom.TabIndex = 13;
            buttonRandom.Text = "Случайная генерация";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += MyClassLibrary.buttonRandom_Click;
            // 
            // labelRUB
            // 
            labelRUB.AutoSize = true;
            labelRUB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRUB.Location = new Point(626, 178);
            labelRUB.Margin = new Padding(1, 10, 10, 10);
            labelRUB.Name = "labelRUB";
            labelRUB.Size = new Size(52, 30);
            labelRUB.TabIndex = 11;
            labelRUB.Text = "руб.";
            // 
            // textBoxIDBook
            // 
            textBoxIDBook.Enabled = false;
            textBoxIDBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIDBook.Location = new Point(135, 227);
            textBoxIDBook.Margin = new Padding(10);
            textBoxIDBook.Name = "textBoxIDBook";
            textBoxIDBook.Size = new Size(196, 35);
            textBoxIDBook.TabIndex = 10;
            // 
            // label_idBook
            // 
            label_idBook.AutoSize = true;
            label_idBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_idBook.Location = new Point(10, 230);
            label_idBook.Margin = new Padding(10);
            label_idBook.Name = "label_idBook";
            label_idBook.Size = new Size(94, 30);
            label_idBook.TabIndex = 9;
            label_idBook.Text = "ID книги";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPrice.Location = new Point(434, 175);
            textBoxPrice.Margin = new Padding(10, 10, 1, 10);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(190, 35);
            textBoxPrice.TabIndex = 7;
            textBoxPrice.TextChanged += MyClassLibrary.textBoxPrice_TextChanged;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(351, 180);
            labelPrice.Margin = new Padding(10);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(63, 30);
            labelPrice.TabIndex = 8;
            labelPrice.Text = "Цена";
            // 
            // textBoxPages
            // 
            textBoxPages.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPages.Location = new Point(135, 175);
            textBoxPages.Margin = new Padding(10);
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new Size(196, 35);
            textBoxPages.TabIndex = 6;
            textBoxPages.TextChanged += MyClassLibrary.textBoxPages_TextChanged;
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPages.Location = new Point(10, 180);
            labelPages.Margin = new Padding(10);
            labelPages.Name = "labelPages";
            labelPages.Size = new Size(110, 30);
            labelPages.TabIndex = 6;
            labelPages.Text = "Страницы";
            // 
            // textBoxGenre
            //  
            textBoxGenre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxGenre.Location =  new Point(135, 120);
            textBoxGenre.Margin = new Padding(10);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(561, 35);
            textBoxGenre.TabIndex = 4;
            textBoxGenre.TextChanged += MyClassLibrary.textBoxGenre_TextChanged;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGenre.Location = new Point(10, 123);
            labelGenre.Margin = new Padding(10);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(66, 30);
            labelGenre.TabIndex = 4;
            labelGenre.Text = "Жанр";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAuthor.Location = new Point(135, 65);
            textBoxAuthor.Margin = new Padding(10);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(561, 35);
            textBoxAuthor.TabIndex = 5;
            textBoxAuthor.TextChanged += MyClassLibrary.textBoxAuthor_TextChanged;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuthor.Location = new Point(10, 68);
            labelAuthor.Margin = new Padding(10);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(71, 30);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Автор";
            // 
            // textBoxNameBook
            // 
            textBoxNameBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxNameBook.Location = new Point(135, 10);
            textBoxNameBook.Margin = new Padding(10);
            textBoxNameBook.Name = "textBoxNameBook";
            textBoxNameBook.Size = new Size(561, 35);
            textBoxNameBook.TabIndex = 3;
            textBoxNameBook.TextChanged += MyClassLibrary.textBoxNameBook_TextChanged;
            // 
            // labelNameBook
            // 
            labelNameBook.AutoSize = true;
            labelNameBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameBook.Location = new Point(10, 10);
            labelNameBook.Margin = new Padding(10);
            labelNameBook.Name = "labelNameBook";
            labelNameBook.Size = new Size(105, 30);
            labelNameBook.TabIndex = 0;
            labelNameBook.Text = "Название";
            // 
            // panelStore
            // 
            panelStore.BackgroundImage = Properties.Resources.backgroundLibrary2;
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
            panelStore.Controls.Add(labelRUBL);
            panelStore.Controls.Add(textBoxBalance);
            panelStore.Controls.Add(labelBalance);
            panelStore.Location = new Point(761, 40);
            panelStore.Name = "panelStore";
            panelStore.Size = new Size(915, 910);
            panelStore.TabIndex = 1;
            // 
            // buttonSellBook
            // 
            buttonSellBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSellBook.Location = new Point(10, 457);
            buttonSellBook.Name = "buttonSellBook";
            buttonSellBook.Size = new Size(233, 43);
            buttonSellBook.TabIndex = 19;
            buttonSellBook.Text = "Продать книгу";
            buttonSellBook.UseVisualStyleBackColor = true;
            buttonSellBook.Click += MyClassLibrary.buttonSellBook_Click;
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
            panelBookInfo.Location = new Point(82, 564);
            panelBookInfo.Name = "panelBookInfo";
            panelBookInfo.Size = new Size(725, 323);
            panelBookInfo.TabIndex = 3;
            // 
            // listBoxPrice
            // 
            listBoxPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxPrice.FormattingEnabled = true;
            listBoxPrice.HorizontalScrollbar = true;
            listBoxPrice.Items.AddRange(new object[] { "666", "100", "999", "1234" });
            listBoxPrice.Location = new Point(657, 30);
            listBoxPrice.Name = "listBoxPrice";
            listBoxPrice.Size = new Size(58, 279);
            listBoxPrice.TabIndex = 9;
            listBoxPrice.SelectedIndexChanged += MyClassLibrary.listBoxPrice_SelectedIndexChanged;
            // 
            // label_panel_price
            // 
            label_panel_price.AutoSize = true;
            label_panel_price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_price.Location = new Point(657, 3);
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
            listBoxPages.Items.AddRange(new object[] { "100", "67", "123", "1234567" });
            listBoxPages.Location = new Point(593, 30);
            listBoxPages.Name = "listBoxPages";
            listBoxPages.Size = new Size(58, 279);
            listBoxPages.TabIndex = 7;
            listBoxPages.SelectedIndexChanged += MyClassLibrary.listBoxPages_SelectedIndexChanged;
            // 
            // label_panel_pages
            // 
            label_panel_pages.AutoSize = true;
            label_panel_pages.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_pages.Location = new Point(593, 3);
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
            listBoxAuthor.Items.AddRange(new object[] { "пушкин", "александр", "хз кто", "долбоеб" });
            listBoxAuthor.Location = new Point(466, 30);
            listBoxAuthor.Name = "listBoxAuthor";
            listBoxAuthor.Size = new Size(121, 279);
            listBoxAuthor.TabIndex = 5;
            listBoxAuthor.SelectedIndexChanged += MyClassLibrary.listBoxAuthor_SelectedIndexChanged;
            // 
            // label_panel_author
            // 
            label_panel_author.AutoSize = true;
            label_panel_author.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_panel_author.Location = new Point(470, 3);
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
            listBoxNameBook.Items.AddRange(new object[] { "алые паруса fodsajfldsjfjsdlkfjsfjsdjksl;jf;sdj;fsdk;fjkalfd", "залупа", "коля", "гей" });
            listBoxNameBook.Location = new Point(39, 30);
            listBoxNameBook.Name = "listBoxNameBook";
            listBoxNameBook.Size = new Size(421, 279);
            listBoxNameBook.TabIndex = 3;
            listBoxNameBook.SelectedIndexChanged += MyClassLibrary.listBoxNameBook_SelectedIndexChanged;
            // 
            // listBoxID
            // 
            listBoxID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxID.FormattingEnabled = true;
            listBoxID.HorizontalScrollbar = true;
            listBoxID.Items.AddRange(new object[] { "1", "2", "3", "4" });
            listBoxID.Location = new Point(3, 30);
            listBoxID.Name = "listBoxID";
            listBoxID.Size = new Size(30, 279);
            listBoxID.TabIndex = 2;
            listBoxID.SelectedIndexChanged += MyClassLibrary.listBoxID_SelectedIndexChanged;
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
            buttonCloset11.Location = new Point(672, 80);
            buttonCloset11.Margin = new Padding(5);
            buttonCloset11.Name = "buttonCloset11";
            buttonCloset11.Size = new Size(50, 323);
            buttonCloset11.TabIndex = 18;
            buttonCloset11.Text = "Хуйня";
            buttonCloset11.UseVisualStyleBackColor = true;
            buttonCloset11.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset11.Click += MyClassLibrary.buttonCloset11_Click;
            // 
            // buttonCloset10
            // 
            buttonCloset10.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset10.ForeColor = SystemColors.ControlLightLight;
            buttonCloset10.Location = new Point(612, 80);
            buttonCloset10.Margin = new Padding(5);
            buttonCloset10.Name = "buttonCloset10";
            buttonCloset10.Size = new Size(50, 323);
            buttonCloset10.TabIndex = 17;
            buttonCloset10.Text = "Хоррор";
            buttonCloset10.UseVisualStyleBackColor = true;
            buttonCloset10.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset10.Click += MyClassLibrary.buttonCloset10_Click;
            // 
            // buttonCloset9
            // 
            buttonCloset9.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset9.ForeColor = SystemColors.ControlLightLight;
            buttonCloset9.Location = new Point(552, 80);
            buttonCloset9.Margin = new Padding(5);
            buttonCloset9.Name = "buttonCloset9";
            buttonCloset9.Size = new Size(50, 323);
            buttonCloset9.TabIndex = 16;
            buttonCloset9.Text = "Научная литература";
            buttonCloset9.UseVisualStyleBackColor = true;
            buttonCloset9.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset9.Click += MyClassLibrary.buttonCloset9_Click;
            // 
            // buttonCloset8
            // 
            buttonCloset8.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset8.ForeColor = SystemColors.ControlLightLight;
            buttonCloset8.Location = new Point(492, 80);
            buttonCloset8.Margin = new Padding(5);
            buttonCloset8.Name = "buttonCloset8";
            buttonCloset8.Size = new Size(50, 323);
            buttonCloset8.TabIndex = 15;
            buttonCloset8.Text = "Биография";
            buttonCloset8.UseVisualStyleBackColor = true;
            buttonCloset8.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset8.Click += MyClassLibrary.buttonCloset8_Click;
            // 
            // buttonCloset7
            // 
            buttonCloset7.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset7.ForeColor = SystemColors.ControlLightLight;
            buttonCloset7.Location = new Point(432, 80);
            buttonCloset7.Margin = new Padding(5);
            buttonCloset7.Name = "buttonCloset7";
            buttonCloset7.Size = new Size(50, 323);
            buttonCloset7.TabIndex = 14;
            buttonCloset7.Text = "Психология";
            buttonCloset7.UseVisualStyleBackColor = true;
            buttonCloset7.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset7.Click += MyClassLibrary.buttonCloset7_Click;
            // 
            // buttonCloset6
            // 
            buttonCloset6.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset6.ForeColor = SystemColors.ControlLightLight;
            buttonCloset6.Location = new Point(372, 80);
            buttonCloset6.Margin = new Padding(5);
            buttonCloset6.Name = "buttonCloset6";
            buttonCloset6.Size = new Size(50, 323);
            buttonCloset6.TabIndex = 13;
            buttonCloset6.Text = "Классическая литература";
            buttonCloset6.UseVisualStyleBackColor = true;
            buttonCloset6.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset6.Click += MyClassLibrary.buttonCloset6_Click;
            // 
            // buttonCloset5
            // 
            buttonCloset5.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset5.ForeColor = SystemColors.ControlLightLight;
            buttonCloset5.Location = new Point(312, 80);
            buttonCloset5.Margin = new Padding(5);
            buttonCloset5.Name = "buttonCloset5";
            buttonCloset5.Size = new Size(50, 323);
            buttonCloset5.TabIndex = 12;
            buttonCloset5.Text = "Поэзия";
            buttonCloset5.UseVisualStyleBackColor = true;
            buttonCloset5.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset5.Click += MyClassLibrary.buttonCloset5_Click;
            // 
            // buttonCloset4
            // 
            buttonCloset4.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset4.ForeColor = SystemColors.ControlLightLight;
            buttonCloset4.Location = new Point(252, 80);
            buttonCloset4.Margin = new Padding(5);
            buttonCloset4.Name = "buttonCloset4";
            buttonCloset4.Size = new Size(50, 323);
            buttonCloset4.TabIndex = 11;
            buttonCloset4.Text = "Приключение";
            buttonCloset4.UseVisualStyleBackColor = true;
            buttonCloset4.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset4.Click += MyClassLibrary.buttonCloset4_Click;
            // 
            // buttonCloset3
            // 
            buttonCloset3.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset3.ForeColor = SystemColors.ControlLightLight;
            buttonCloset3.Location = new Point(192, 80);
            buttonCloset3.Margin = new Padding(5);
            buttonCloset3.Name = "buttonCloset3";
            buttonCloset3.Size = new Size(50, 323);
            buttonCloset3.TabIndex = 10;
            buttonCloset3.Text = "Роман";
            buttonCloset3.UseVisualStyleBackColor = true;
            buttonCloset3.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset3.Click += MyClassLibrary.buttonCloset3_Click;
            // 
            // buttonCloset2
            // 
            buttonCloset2.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset2.ForeColor = SystemColors.ControlLightLight;
            buttonCloset2.Location = new Point(132, 80);
            buttonCloset2.Margin = new Padding(5);
            buttonCloset2.Name = "buttonCloset2";
            buttonCloset2.Size = new Size(50, 323);
            buttonCloset2.TabIndex = 9;
            buttonCloset2.Text = "Фентези";
            buttonCloset2.UseVisualStyleBackColor = true;
            buttonCloset2.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset2.Click += MyClassLibrary.buttonCloset2_Click;
            textBoxBalance.Enabled = false;
            // 
            // buttonCloset1
            // 
            buttonCloset1.BackgroundImage = Properties.Resources.shelf9;
            buttonCloset1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloset1.ForeColor = SystemColors.ControlLightLight;
            buttonCloset1.Location = new Point(72, 80);
            buttonCloset1.Margin = new Padding(5);
            buttonCloset1.Name = "buttonCloset1";
            buttonCloset1.Size = new Size(50, 323);
            buttonCloset1.TabIndex = 8;
            buttonCloset1.Text = "Философия";
            buttonCloset1.UseVisualStyleBackColor = true;
            buttonCloset1.TextAlign = ContentAlignment.MiddleLeft;
            buttonCloset1.Click += MyClassLibrary.buttonCloset1_Click;
            // 
            // textBoxFindBook
            // 
            textBoxFindBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFindBook.Location = new Point(82, 411);
            textBoxFindBook.Name = "textBoxFindBook";
            textBoxFindBook.Size = new Size(621, 38);
            textBoxFindBook.TabIndex = 7;
            textBoxFindBook.Multiline = true;
            textBoxFindBook.TextChanged += MyClassLibrary.textBoxFindBook_TextChanged;
            // 
            // labelFindBook
            // 
            labelFindBook.AutoSize = true;
            labelFindBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFindBook.Location = new Point(10, 414);
            labelFindBook.Name = "labelFindBook";
            labelFindBook.Size = new Size(66, 25);
            labelFindBook.TabIndex = 6;
            labelFindBook.Text = "Поиск";
            // 
            // labelRUBL
            // 
            labelRUBL.AutoSize = true;
            labelRUBL.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRUBL.Location = new Point(656, 10);
            labelRUBL.Name = "labelRUBL";
            labelRUBL.Size = new Size(47, 25);
            labelRUBL.TabIndex = 2;
            labelRUBL.Text = "руб.";
            // 
            // textBoxBalance
            // 
            textBoxBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBalance.Location = new Point(460, 7);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(190, 33);
            textBoxBalance.TabIndex = 1;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBalance.Location = new Point(381, 10);
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
            buttonNewBook.Size = new Size(345, 34);
            buttonNewBook.TabIndex = 1;
            buttonNewBook.Text = "Новая книга";
            buttonNewBook.UseVisualStyleBackColor = true;
            buttonNewBook.Click += MyClassLibrary.buttonNewBook_Click;
            // 
            // buttonStore
            // 
            buttonStore.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStore.Location = new Point(351, 0);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(345, 34);
            buttonStore.TabIndex = 2;
            buttonStore.Text = "Магазин";
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += MyClassLibrary.buttonStore_Click;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 561);
            Controls.Add(buttonStore);
            Controls.Add(buttonNewBook);
            Controls.Add(panelStore);
            Controls.Add(panelNewBook);
            MinimumSize = new Size(800, 600);
            Name = "Store";
            Text = "Store";
            Load += MyClassLibrary.Store_Load;
            panelNewBook.ResumeLayout(false);
            panelNewBook.PerformLayout();
            panelStore.ResumeLayout(false);
            panelStore.PerformLayout();
            panelBookInfo.ResumeLayout(false);
            panelBookInfo.PerformLayout();
            ResumeLayout(false);
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
        private Label labelErrors;
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
    }
}
*/