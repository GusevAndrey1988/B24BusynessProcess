namespace B24BusynessProcess
{
    partial class ConfigForm
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
            this.HookLabel = new System.Windows.Forms.Label();
            this.HookInput = new System.Windows.Forms.TextBox();
            this.SaveConfigButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HookLabel
            // 
            this.HookLabel.AutoSize = true;
            this.HookLabel.Location = new System.Drawing.Point(12, 9);
            this.HookLabel.Name = "HookLabel";
            this.HookLabel.Size = new System.Drawing.Size(63, 15);
            this.HookLabel.TabIndex = 0;
            this.HookLabel.Text = "WebHook:";
            // 
            // HookInput
            // 
            this.HookInput.Location = new System.Drawing.Point(81, 6);
            this.HookInput.Name = "HookInput";
            this.HookInput.Size = new System.Drawing.Size(393, 23);
            this.HookInput.TabIndex = 1;
            // 
            // SaveConfigButton
            // 
            this.SaveConfigButton.Location = new System.Drawing.Point(399, 61);
            this.SaveConfigButton.Name = "SaveConfigButton";
            this.SaveConfigButton.Size = new System.Drawing.Size(75, 23);
            this.SaveConfigButton.TabIndex = 2;
            this.SaveConfigButton.Text = "Сохранить";
            this.SaveConfigButton.UseVisualStyleBackColor = true;
            this.SaveConfigButton.Click += new System.EventHandler(this.SaveConfigButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(318, 61);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 96);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveConfigButton);
            this.Controls.Add(this.HookInput);
            this.Controls.Add(this.HookLabel);
            this.Name = "ConfigForm";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HookLabel;
        private TextBox HookInput;
        private Button SaveConfigButton;
        private Button CancelButton;
    }
}