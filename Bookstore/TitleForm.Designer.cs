namespace Bookstore
{
    partial class TitleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleForm));
            titlelabel = new Label();
            buttonEasy = new Button();
            buttonNormal = new Button();
            buttonHard = new Button();
            CrutchProduction = new Label();
            buttonAboutGame = new Button();
            panelYesNo = new Panel();
            buttonNo = new Button();
            buttonYes = new Button();
            labelChoiceGameMode = new Label();
            labelAboutGame = new Label();
            panelYesNo.SuspendLayout();
            SuspendLayout();
            // 
            // titlelabel
            // 
            titlelabel.AutoSize = true;
            titlelabel.BackColor = Color.LightGray;
            titlelabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titlelabel.Location = new Point(411, 46);
            titlelabel.Name = "titlelabel";
            titlelabel.Size = new Size(353, 50);
            titlelabel.TabIndex = 0;
            titlelabel.Text = "Симулятор кассира";
            // 
            // buttonEasy
            // 
            buttonEasy.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEasy.Location = new Point(464, 138);
            buttonEasy.Name = "buttonEasy";
            buttonEasy.Size = new Size(241, 122);
            buttonEasy.TabIndex = 1;
            buttonEasy.Text = "Лёгкий";
            buttonEasy.UseVisualStyleBackColor = true;
            buttonEasy.Click += buttonEasy_Click;
            // 
            // buttonNormal
            // 
            buttonNormal.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonNormal.Location = new Point(463, 292);
            buttonNormal.Name = "buttonNormal";
            buttonNormal.Size = new Size(241, 122);
            buttonNormal.TabIndex = 2;
            buttonNormal.Text = "Нормальный";
            buttonNormal.UseVisualStyleBackColor = true;
            buttonNormal.Click += buttonNormal_Click;
            // 
            // buttonHard
            // 
            buttonHard.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHard.Location = new Point(463, 441);
            buttonHard.Name = "buttonHard";
            buttonHard.Size = new Size(241, 122);
            buttonHard.TabIndex = 3;
            buttonHard.Text = "Сложный";
            buttonHard.UseVisualStyleBackColor = true;
            buttonHard.Click += buttonHard_Click;
            // 
            // CrutchProduction
            // 
            CrutchProduction.AutoSize = true;
            CrutchProduction.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CrutchProduction.Location = new Point(1025, 793);
            CrutchProduction.Name = "CrutchProduction";
            CrutchProduction.Size = new Size(161, 25);
            CrutchProduction.TabIndex = 4;
            CrutchProduction.Text = "CrutchProduction";
            // 
            // buttonAboutGame
            // 
            buttonAboutGame.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAboutGame.Location = new Point(995, 27);
            buttonAboutGame.Name = "buttonAboutGame";
            buttonAboutGame.Size = new Size(141, 44);
            buttonAboutGame.TabIndex = 5;
            buttonAboutGame.Text = "Об игре";
            buttonAboutGame.UseVisualStyleBackColor = true;
            buttonAboutGame.Click += buttonAboutGame_Click;
            // 
            // panelYesNo
            // 
            panelYesNo.Controls.Add(buttonNo);
            panelYesNo.Controls.Add(buttonYes);
            panelYesNo.Controls.Add(labelChoiceGameMode);
            panelYesNo.Location = new Point(13, 138);
            panelYesNo.Name = "panelYesNo";
            panelYesNo.Size = new Size(445, 540);
            panelYesNo.TabIndex = 6;
            // 
            // buttonNo
            // 
            buttonNo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonNo.Location = new Point(153, 290);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(119, 73);
            buttonNo.TabIndex = 2;
            buttonNo.Text = "Нет";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // buttonYes
            // 
            buttonYes.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonYes.Location = new Point(153, 119);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(119, 73);
            buttonYes.TabIndex = 1;
            buttonYes.Text = "Да";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // labelChoiceGameMode
            // 
            labelChoiceGameMode.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelChoiceGameMode.Location = new Point(12, 10);
            labelChoiceGameMode.Name = "labelChoiceGameMode";
            labelChoiceGameMode.Size = new Size(420, 94);
            labelChoiceGameMode.TabIndex = 0;
            labelChoiceGameMode.Text = "Вы уверены, что хотите начать игру в режиме";
            // 
            // labelAboutGame
            // 
            labelAboutGame.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAboutGame.Location = new Point(192, 138);
            labelAboutGame.Name = "labelAboutGame";
            labelAboutGame.Size = new Size(791, 576);
            labelAboutGame.TabIndex = 7;
            labelAboutGame.Text = resources.GetString("labelAboutGame.Text");
            // 
            // TitleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.titleform;
            ClientSize = new Size(1198, 827);
            Controls.Add(labelAboutGame);
            Controls.Add(panelYesNo);
            Controls.Add(buttonAboutGame);
            Controls.Add(CrutchProduction);
            Controls.Add(buttonHard);
            Controls.Add(buttonNormal);
            Controls.Add(buttonEasy);
            Controls.Add(titlelabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1214, 866);
            MinimumSize = new Size(1214, 866);
            Name = "TitleForm";
            Text = "TitleForm";
            Load += TitleForm_Load;
            panelYesNo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonEasy_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label titlelabel;
        private Button buttonEasy;
        private Button buttonNormal;
        private Button buttonHard;
        private Label CrutchProduction;
        private Button buttonAboutGame;
        private Panel panelYesNo;
        private Label labelChoiceGameMode;
        private Button buttonYes;
        private Button buttonNo;
        private Label labelAboutGame;
    }
}