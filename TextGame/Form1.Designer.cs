namespace TextGame
{
    partial class Form1
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
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.mainBut = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.readScriptButMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileScript = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.mainTextBox.Location = new System.Drawing.Point(3, 23);
            this.mainTextBox.MaxLength = 2048;
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.Size = new System.Drawing.Size(554, 151);
            this.mainTextBox.TabIndex = 0;
            // 
            // mainBut
            // 
            this.mainBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainBut.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainBut.Location = new System.Drawing.Point(221, 270);
            this.mainBut.Name = "mainBut";
            this.mainBut.Size = new System.Drawing.Size(139, 49);
            this.mainBut.TabIndex = 1;
            this.mainBut.Text = "Начать";
            this.mainBut.UseVisualStyleBackColor = true;
            this.mainBut.Click += new System.EventHandler(this.mainBut_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainLabel.Location = new System.Drawing.Point(12, 37);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(153, 33);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Приятной игры!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Имя Персонажа";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readScriptButMenu});
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(48, 20);
            this.fileMenuStrip.Text = "Файл";
            // 
            // readScriptButMenu
            // 
            this.readScriptButMenu.Name = "readScriptButMenu";
            this.readScriptButMenu.Size = new System.Drawing.Size(220, 22);
            this.readScriptButMenu.Text = "Прочитать файл сценария";
            this.readScriptButMenu.Click += new System.EventHandler(this.readScriptButMenu_Click);
            // 
            // openFileScript
            // 
            this.openFileScript.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.mainBut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button mainBut;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem readScriptButMenu;
        private System.Windows.Forms.OpenFileDialog openFileScript;
    }
}
