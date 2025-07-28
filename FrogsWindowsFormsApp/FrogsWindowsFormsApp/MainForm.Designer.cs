namespace FrogsWindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightPictureBox4 = new System.Windows.Forms.PictureBox();
            this.rightPictureBox3 = new System.Windows.Forms.PictureBox();
            this.rightPictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightPictureBox1 = new System.Windows.Forms.PictureBox();
            this.emptyPictureBox = new System.Windows.Forms.PictureBox();
            this.leftPictureBox3 = new System.Windows.Forms.PictureBox();
            this.leftPictureBox2 = new System.Windows.Forms.PictureBox();
            this.leftPictureBox4 = new System.Windows.Forms.PictureBox();
            this.leftPictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество ходов:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(275, 270);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 30);
            this.scoreLabel.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1351, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьToolStripMenuItem,
            this.правилаИгрыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // начатьToolStripMenuItem
            // 
            this.начатьToolStripMenuItem.Name = "начатьToolStripMenuItem";
            this.начатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.начатьToolStripMenuItem.Text = " Начать сначала";
            this.начатьToolStripMenuItem.Click += new System.EventHandler(this.начатьToolStripMenuItem_Click);
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // rightPictureBox4
            // 
            this.rightPictureBox4.Image = global::FrogsWindowsFormsApp.Properties.Resources.правая_лягушка;
            this.rightPictureBox4.Location = new System.Drawing.Point(1200, 50);
            this.rightPictureBox4.Name = "rightPictureBox4";
            this.rightPictureBox4.Size = new System.Drawing.Size(150, 150);
            this.rightPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPictureBox4.TabIndex = 8;
            this.rightPictureBox4.TabStop = false;
            this.rightPictureBox4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // rightPictureBox3
            // 
            this.rightPictureBox3.Image = global::FrogsWindowsFormsApp.Properties.Resources.правая_лягушка;
            this.rightPictureBox3.Location = new System.Drawing.Point(1050, 50);
            this.rightPictureBox3.Name = "rightPictureBox3";
            this.rightPictureBox3.Size = new System.Drawing.Size(150, 150);
            this.rightPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPictureBox3.TabIndex = 7;
            this.rightPictureBox3.TabStop = false;
            this.rightPictureBox3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // rightPictureBox2
            // 
            this.rightPictureBox2.Image = global::FrogsWindowsFormsApp.Properties.Resources.правая_лягушка;
            this.rightPictureBox2.Location = new System.Drawing.Point(900, 50);
            this.rightPictureBox2.Name = "rightPictureBox2";
            this.rightPictureBox2.Size = new System.Drawing.Size(150, 150);
            this.rightPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPictureBox2.TabIndex = 6;
            this.rightPictureBox2.TabStop = false;
            this.rightPictureBox2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // rightPictureBox1
            // 
            this.rightPictureBox1.Image = global::FrogsWindowsFormsApp.Properties.Resources.правая_лягушка;
            this.rightPictureBox1.Location = new System.Drawing.Point(750, 50);
            this.rightPictureBox1.Name = "rightPictureBox1";
            this.rightPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.rightPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPictureBox1.TabIndex = 5;
            this.rightPictureBox1.TabStop = false;
            this.rightPictureBox1.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // emptyPictureBox
            // 
            this.emptyPictureBox.Image = global::FrogsWindowsFormsApp.Properties.Resources.yjhvrediby;
            this.emptyPictureBox.Location = new System.Drawing.Point(600, 50);
            this.emptyPictureBox.Name = "emptyPictureBox";
            this.emptyPictureBox.Size = new System.Drawing.Size(150, 150);
            this.emptyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emptyPictureBox.TabIndex = 4;
            this.emptyPictureBox.TabStop = false;
            // 
            // leftPictureBox3
            // 
            this.leftPictureBox3.Image = global::FrogsWindowsFormsApp.Properties.Resources.левая_лягушка;
            this.leftPictureBox3.Location = new System.Drawing.Point(300, 50);
            this.leftPictureBox3.Name = "leftPictureBox3";
            this.leftPictureBox3.Size = new System.Drawing.Size(150, 150);
            this.leftPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPictureBox3.TabIndex = 3;
            this.leftPictureBox3.TabStop = false;
            this.leftPictureBox3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // leftPictureBox2
            // 
            this.leftPictureBox2.Image = global::FrogsWindowsFormsApp.Properties.Resources.левая_лягушка;
            this.leftPictureBox2.Location = new System.Drawing.Point(150, 50);
            this.leftPictureBox2.Name = "leftPictureBox2";
            this.leftPictureBox2.Size = new System.Drawing.Size(150, 150);
            this.leftPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPictureBox2.TabIndex = 2;
            this.leftPictureBox2.TabStop = false;
            this.leftPictureBox2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // leftPictureBox4
            // 
            this.leftPictureBox4.Image = global::FrogsWindowsFormsApp.Properties.Resources.левая_лягушка;
            this.leftPictureBox4.Location = new System.Drawing.Point(450, 50);
            this.leftPictureBox4.Name = "leftPictureBox4";
            this.leftPictureBox4.Size = new System.Drawing.Size(150, 150);
            this.leftPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPictureBox4.TabIndex = 1;
            this.leftPictureBox4.TabStop = false;
            this.leftPictureBox4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // leftPictureBox1
            // 
            this.leftPictureBox1.Image = global::FrogsWindowsFormsApp.Properties.Resources.левая_лягушка;
            this.leftPictureBox1.Location = new System.Drawing.Point(0, 50);
            this.leftPictureBox1.Name = "leftPictureBox1";
            this.leftPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.leftPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPictureBox1.TabIndex = 0;
            this.leftPictureBox1.TabStop = false;
            this.leftPictureBox1.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 450);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightPictureBox4);
            this.Controls.Add(this.rightPictureBox3);
            this.Controls.Add(this.rightPictureBox2);
            this.Controls.Add(this.rightPictureBox1);
            this.Controls.Add(this.emptyPictureBox);
            this.Controls.Add(this.leftPictureBox3);
            this.Controls.Add(this.leftPictureBox2);
            this.Controls.Add(this.leftPictureBox4);
            this.Controls.Add(this.leftPictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Лягушки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox leftPictureBox1;
        private System.Windows.Forms.PictureBox leftPictureBox4;
        private System.Windows.Forms.PictureBox leftPictureBox2;
        private System.Windows.Forms.PictureBox leftPictureBox3;
        private System.Windows.Forms.PictureBox emptyPictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox1;
        private System.Windows.Forms.PictureBox rightPictureBox2;
        private System.Windows.Forms.PictureBox rightPictureBox3;
        private System.Windows.Forms.PictureBox rightPictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
    }
}

