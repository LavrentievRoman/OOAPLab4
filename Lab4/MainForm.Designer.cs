namespace Lab4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.monitorPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buyMonitorButton = new System.Windows.Forms.Button();
            this.monitorComboBox = new System.Windows.Forms.ComboBox();
            this.keyboardPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.buyKeyboardButton = new System.Windows.Forms.Button();
            this.keyboardComboBox = new System.Windows.Forms.ComboBox();
            this.mousePage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.buyMouseButton = new System.Windows.Forms.Button();
            this.mouseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recomendLabel1 = new System.Windows.Forms.Label();
            this.recomendLabel2 = new System.Windows.Forms.Label();
            this.recomendLabel3 = new System.Windows.Forms.Label();
            this.userRecomendLabel3 = new System.Windows.Forms.Label();
            this.userRecomendLabel2 = new System.Windows.Forms.Label();
            this.userRecomendLabel1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.monitorPage.SuspendLayout();
            this.keyboardPage.SuspendLayout();
            this.mousePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.monitorPage);
            this.tabControl1.Controls.Add(this.keyboardPage);
            this.tabControl1.Controls.Add(this.mousePage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(314, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // monitorPage
            // 
            this.monitorPage.Controls.Add(this.label2);
            this.monitorPage.Controls.Add(this.buyMonitorButton);
            this.monitorPage.Controls.Add(this.monitorComboBox);
            this.monitorPage.Location = new System.Drawing.Point(4, 22);
            this.monitorPage.Name = "monitorPage";
            this.monitorPage.Padding = new System.Windows.Forms.Padding(3);
            this.monitorPage.Size = new System.Drawing.Size(306, 412);
            this.monitorPage.TabIndex = 0;
            this.monitorPage.Text = "Мониторы";
            this.monitorPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Купить монитор";
            // 
            // buyMonitorButton
            // 
            this.buyMonitorButton.Location = new System.Drawing.Point(187, 369);
            this.buyMonitorButton.Name = "buyMonitorButton";
            this.buyMonitorButton.Size = new System.Drawing.Size(113, 37);
            this.buyMonitorButton.TabIndex = 1;
            this.buyMonitorButton.Text = "Купить";
            this.buyMonitorButton.UseVisualStyleBackColor = true;
            this.buyMonitorButton.Click += new System.EventHandler(this.buyMonitorButton_Click);
            // 
            // monitorComboBox
            // 
            this.monitorComboBox.FormattingEnabled = true;
            this.monitorComboBox.Items.AddRange(new object[] {
            "Dell UltraSharp U2719D",
            "ASUS ROG Swift PG279Q",
            "LG 34GN850-B",
            "Samsung Odyssey G7",
            "BenQ PD3200U",
            "Acer Predator XB273K",
            "ViewSonic VP2468",
            "HP Omen X 25f",
            "Dell S2721QS",
            "LG UltraGear 27GL850-B"});
            this.monitorComboBox.Location = new System.Drawing.Point(17, 51);
            this.monitorComboBox.Name = "monitorComboBox";
            this.monitorComboBox.Size = new System.Drawing.Size(193, 21);
            this.monitorComboBox.TabIndex = 0;
            this.monitorComboBox.Text = "Dell UltraSharp U2719D";
            // 
            // keyboardPage
            // 
            this.keyboardPage.Controls.Add(this.label3);
            this.keyboardPage.Controls.Add(this.buyKeyboardButton);
            this.keyboardPage.Controls.Add(this.keyboardComboBox);
            this.keyboardPage.Location = new System.Drawing.Point(4, 22);
            this.keyboardPage.Name = "keyboardPage";
            this.keyboardPage.Padding = new System.Windows.Forms.Padding(3);
            this.keyboardPage.Size = new System.Drawing.Size(306, 412);
            this.keyboardPage.TabIndex = 1;
            this.keyboardPage.Text = "Клавиатуры";
            this.keyboardPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Купить клавиатуру";
            // 
            // buyKeyboardButton
            // 
            this.buyKeyboardButton.Location = new System.Drawing.Point(187, 369);
            this.buyKeyboardButton.Name = "buyKeyboardButton";
            this.buyKeyboardButton.Size = new System.Drawing.Size(113, 37);
            this.buyKeyboardButton.TabIndex = 6;
            this.buyKeyboardButton.Text = "Купить";
            this.buyKeyboardButton.UseVisualStyleBackColor = true;
            this.buyKeyboardButton.Click += new System.EventHandler(this.buyKeyboardButton_Click);
            // 
            // keyboardComboBox
            // 
            this.keyboardComboBox.FormattingEnabled = true;
            this.keyboardComboBox.Items.AddRange(new object[] {
            "Corsair K95 RGB Platinum",
            "Apple Magic Keyboard",
            "Razer BlackWidow Elite",
            "Microsoft Sculpt Ergonomic Keyboard",
            "Logitech K780",
            "SteelSeries Apex Pro",
            "Dell KB216",
            "Ducky One 2 Mini",
            "Cherry MX Board 6.0",
            "Sensel Morph"});
            this.keyboardComboBox.Location = new System.Drawing.Point(11, 46);
            this.keyboardComboBox.Name = "keyboardComboBox";
            this.keyboardComboBox.Size = new System.Drawing.Size(213, 21);
            this.keyboardComboBox.TabIndex = 5;
            this.keyboardComboBox.Text = "Corsair K95 RGB Platinum";
            // 
            // mousePage
            // 
            this.mousePage.Controls.Add(this.label4);
            this.mousePage.Controls.Add(this.buyMouseButton);
            this.mousePage.Controls.Add(this.mouseComboBox);
            this.mousePage.Location = new System.Drawing.Point(4, 22);
            this.mousePage.Name = "mousePage";
            this.mousePage.Size = new System.Drawing.Size(306, 412);
            this.mousePage.TabIndex = 2;
            this.mousePage.Text = "Мышки";
            this.mousePage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Купить мышку";
            // 
            // buyMouseButton
            // 
            this.buyMouseButton.Location = new System.Drawing.Point(190, 372);
            this.buyMouseButton.Name = "buyMouseButton";
            this.buyMouseButton.Size = new System.Drawing.Size(113, 37);
            this.buyMouseButton.TabIndex = 9;
            this.buyMouseButton.Text = "Купить";
            this.buyMouseButton.UseVisualStyleBackColor = true;
            this.buyMouseButton.Click += new System.EventHandler(this.buyMouseButton_Click);
            // 
            // mouseComboBox
            // 
            this.mouseComboBox.FormattingEnabled = true;
            this.mouseComboBox.Items.AddRange(new object[] {
            "Logitech MX Master 3",
            "Razer DeathAdder Elite",
            "Apple Magic Mouse 2",
            "SteelSeries Rival 600",
            "Microsoft Sculpt Ergonomic Mouse",
            "Corsair Dark Core RGB Pro SE",
            "Logitech G502 HERO",
            "Razer Naga Trinity",
            "Logitech MX Anywhere 3",
            "Finalmouse Ultralight 2 - Cape Town"});
            this.mouseComboBox.Location = new System.Drawing.Point(11, 46);
            this.mouseComboBox.Name = "mouseComboBox";
            this.mouseComboBox.Size = new System.Drawing.Size(207, 21);
            this.mouseComboBox.TabIndex = 8;
            this.mouseComboBox.Text = "Logitech MX Master 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Популярное";
            // 
            // recomendLabel1
            // 
            this.recomendLabel1.AutoSize = true;
            this.recomendLabel1.Location = new System.Drawing.Point(341, 37);
            this.recomendLabel1.Name = "recomendLabel1";
            this.recomendLabel1.Size = new System.Drawing.Size(47, 13);
            this.recomendLabel1.TabIndex = 2;
            this.recomendLabel1.Text = "1. label2";
            // 
            // recomendLabel2
            // 
            this.recomendLabel2.AutoSize = true;
            this.recomendLabel2.Location = new System.Drawing.Point(341, 59);
            this.recomendLabel2.Name = "recomendLabel2";
            this.recomendLabel2.Size = new System.Drawing.Size(47, 13);
            this.recomendLabel2.TabIndex = 3;
            this.recomendLabel2.Text = "2. label2";
            // 
            // recomendLabel3
            // 
            this.recomendLabel3.AutoSize = true;
            this.recomendLabel3.Location = new System.Drawing.Point(341, 81);
            this.recomendLabel3.Name = "recomendLabel3";
            this.recomendLabel3.Size = new System.Drawing.Size(47, 13);
            this.recomendLabel3.TabIndex = 4;
            this.recomendLabel3.Text = "3. label2";
            // 
            // userRecomendLabel3
            // 
            this.userRecomendLabel3.AutoSize = true;
            this.userRecomendLabel3.Location = new System.Drawing.Point(341, 245);
            this.userRecomendLabel3.Name = "userRecomendLabel3";
            this.userRecomendLabel3.Size = new System.Drawing.Size(47, 13);
            this.userRecomendLabel3.TabIndex = 8;
            this.userRecomendLabel3.Text = "3. label2";
            // 
            // userRecomendLabel2
            // 
            this.userRecomendLabel2.AutoSize = true;
            this.userRecomendLabel2.Location = new System.Drawing.Point(341, 223);
            this.userRecomendLabel2.Name = "userRecomendLabel2";
            this.userRecomendLabel2.Size = new System.Drawing.Size(47, 13);
            this.userRecomendLabel2.TabIndex = 7;
            this.userRecomendLabel2.Text = "2. label2";
            // 
            // userRecomendLabel1
            // 
            this.userRecomendLabel1.AutoSize = true;
            this.userRecomendLabel1.Location = new System.Drawing.Point(341, 201);
            this.userRecomendLabel1.Name = "userRecomendLabel1";
            this.userRecomendLabel1.Size = new System.Drawing.Size(47, 13);
            this.userRecomendLabel1.TabIndex = 6;
            this.userRecomendLabel1.Text = "1. label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(355, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Рекомендуется";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.userRecomendLabel3);
            this.Controls.Add(this.userRecomendLabel2);
            this.Controls.Add(this.userRecomendLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.recomendLabel3);
            this.Controls.Add(this.recomendLabel2);
            this.Controls.Add(this.recomendLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.monitorPage.ResumeLayout(false);
            this.monitorPage.PerformLayout();
            this.keyboardPage.ResumeLayout(false);
            this.keyboardPage.PerformLayout();
            this.mousePage.ResumeLayout(false);
            this.mousePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage monitorPage;
        private System.Windows.Forms.TabPage keyboardPage;
        private System.Windows.Forms.TabPage mousePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recomendLabel1;
        private System.Windows.Forms.Label recomendLabel2;
        private System.Windows.Forms.Label recomendLabel3;
        private System.Windows.Forms.ComboBox monitorComboBox;
        private System.Windows.Forms.Button buyMonitorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buyKeyboardButton;
        private System.Windows.Forms.ComboBox keyboardComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buyMouseButton;
        private System.Windows.Forms.ComboBox mouseComboBox;
        private System.Windows.Forms.Label userRecomendLabel3;
        private System.Windows.Forms.Label userRecomendLabel2;
        private System.Windows.Forms.Label userRecomendLabel1;
        private System.Windows.Forms.Label label8;
    }
}

