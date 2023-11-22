using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24BusynessProcess.Forms.Components
{
    public partial class CrmEntitiesList : UserControl
    {
        private int rowIndex = -1;

        public CrmEntitiesList()
        {
            InitializeComponent();

            EntitiesTable.ColumnCount = 2;
            EntitiesTable.Columns[0].Name = "Id";
            EntitiesTable.Columns[1].Name = "Название";
        }

        public void AddEntity(string id, string title)
        {
            int newRowId = EntitiesTable.Rows.Add(id, title);
            EntitiesTable.Rows[newRowId].ContextMenuStrip = RowContextMenu;
            EntitiesTable.AutoResizeColumns();
        }

        public void Clear()
        {
            EntitiesTable.Rows.Clear();
        }

        private void EntitiesTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void NopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                return;
            }

            string message = $"[{EntitiesTable.Rows[rowIndex].Cells[0].Value.ToString() ?? ""}]";
            message += " " + EntitiesTable.Rows[rowIndex].Cells[1].Value.ToString() ?? "";
            
            MessageBox.Show(message);
        }
    }
}
