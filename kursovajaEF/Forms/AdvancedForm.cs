using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace kursovajaEF.Forms
{
    public partial class AdvancedForm : Form
    {
        Font fontRegular;
        Font fontBold;
        public AdvancedForm()
        {
            fontRegular = new Font("SegoeUI", 9, FontStyle.Regular);
            fontBold = new Font("SegoeUI", 9, FontStyle.Bold);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AdvancedForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "AdvancedForm";
            this.ResumeLayout(false);

        }

        public void dataGridViewSorted(object sender)
        {
            DataGridView dgv = (DataGridView)sender;

            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].HeaderCell.Style.Font = fontRegular;

            dgv.SortedColumn.HeaderCell.Style.Font = fontBold; // Делаем шрифт сортируемого столбца жирным
        }
    }
}
