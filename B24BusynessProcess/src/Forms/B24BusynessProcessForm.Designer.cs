namespace B24BusynessProcess
{
    partial class B24BusynessProcessForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.AppMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestButton = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppMainMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // AppMainMenuItem
            // 
            this.AppMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigMainMenuItem,
            this.ExitMainMenuItem});
            this.AppMainMenuItem.Name = "AppMainMenuItem";
            this.AppMainMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AppMainMenuItem.Text = " Приложение";
            // 
            // ConfigMainMenuItem
            // 
            this.ConfigMainMenuItem.Name = "ConfigMainMenuItem";
            this.ConfigMainMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ConfigMainMenuItem.Text = "Настройки";
            this.ConfigMainMenuItem.Click += new System.EventHandler(this.ConfigMainMenuItem_Click);
            // 
            // ExitMainMenuItem
            // 
            this.ExitMainMenuItem.Name = "ExitMainMenuItem";
            this.ExitMainMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ExitMainMenuItem.Text = "Выход";
            this.ExitMainMenuItem.Click += new System.EventHandler(this.ExitMainMenuItem_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(672, 401);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 1;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // B24BusynessProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "B24BusynessProcessForm";
            this.Text = "B24BusynessProcess";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem AppMainMenuItem;
        private ToolStripMenuItem ConfigMainMenuItem;
        private ToolStripMenuItem ExitMainMenuItem;
        private Button TestButton;
    }
}