namespace Bookstore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            buyersPage = new TabPage();
            storagePage = new TabPage();
            requestPage = new TabPage();
            arrivedPage = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(buyersPage);
            tabControl1.Controls.Add(storagePage);
            tabControl1.Controls.Add(requestPage);
            tabControl1.Controls.Add(arrivedPage);
            tabControl1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1263, 742);
            tabControl1.TabIndex = 0;
            // 
            // buyersPage
            // 
            buyersPage.BackColor = Color.Transparent;
            buyersPage.BackgroundImage = Properties.Resources.shopBook;
            buyersPage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buyersPage.ForeColor = SystemColors.ControlText;
            buyersPage.Location = new Point(4, 37);
            buyersPage.Name = "buyersPage";
            buyersPage.Padding = new Padding(3);
            buyersPage.Size = new Size(1255, 701);
            buyersPage.TabIndex = 0;
            buyersPage.Text = "Покупатели";
            // 
            // storagePage
            // 
            storagePage.BackgroundImage = Properties.Resources.backgroundLibraryTwo;
            storagePage.Location = new Point(4, 37);
            storagePage.Name = "storagePage";
            storagePage.Padding = new Padding(3);
            storagePage.Size = new Size(1255, 701);
            storagePage.TabIndex = 1;
            storagePage.Text = "Магазин";
            storagePage.UseVisualStyleBackColor = true;
            // 
            // requestPage
            // 
            requestPage.Location = new Point(4, 37);
            requestPage.Name = "requestPage";
            requestPage.Size = new Size(1255, 701);
            requestPage.TabIndex = 2;
            requestPage.Text = "Заказать книгу";
            requestPage.UseVisualStyleBackColor = true;
            // 
            // arrivedPage
            // 
            arrivedPage.Location = new Point(4, 37);
            arrivedPage.Name = "arrivedPage";
            arrivedPage.Size = new Size(1255, 701);
            arrivedPage.TabIndex = 3;
            arrivedPage.Text = "Поставки";
            arrivedPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 737);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage buyersPage;
        private TabPage storagePage;
        private TabPage requestPage;
        private TabPage arrivedPage;
    }
}