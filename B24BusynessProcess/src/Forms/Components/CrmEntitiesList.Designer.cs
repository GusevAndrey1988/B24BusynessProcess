namespace B24BusynessProcess.Forms.Components
{
    partial class CrmEntitiesList
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EntitiesTable = new System.Windows.Forms.DataGridView();
            this.RowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.EntitiesTable)).BeginInit();
            this.RowContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntitiesTable
            // 
            this.EntitiesTable.AllowUserToAddRows = false;
            this.EntitiesTable.AllowUserToDeleteRows = false;
            this.EntitiesTable.AllowUserToOrderColumns = true;
            this.EntitiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntitiesTable.Location = new System.Drawing.Point(3, 3);
            this.EntitiesTable.Name = "EntitiesTable";
            this.EntitiesTable.ReadOnly = true;
            this.EntitiesTable.RowTemplate.Height = 25;
            this.EntitiesTable.Size = new System.Drawing.Size(626, 356);
            this.EntitiesTable.TabIndex = 1;
            this.EntitiesTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EntitiesTable_CellMouseEnter);
            // 
            // RowContextMenu
            // 
            this.RowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NopToolStripMenuItem});
            this.RowContextMenu.Name = "RowContextMenu";
            this.RowContextMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // NopToolStripMenuItem
            // 
            this.NopToolStripMenuItem.Name = "NopToolStripMenuItem";
            this.NopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NopToolStripMenuItem.Text = "Nop";
            this.NopToolStripMenuItem.Click += new System.EventHandler(this.NopToolStripMenuItem_Click);
            // 
            // CrmEntitiesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EntitiesTable);
            this.Name = "CrmEntitiesList";
            this.Size = new System.Drawing.Size(632, 362);
            ((System.ComponentModel.ISupportInitialize)(this.EntitiesTable)).EndInit();
            this.RowContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView EntitiesTable;
        private ContextMenuStrip RowContextMenu;
        private ToolStripMenuItem NopToolStripMenuItem;
    }
}
