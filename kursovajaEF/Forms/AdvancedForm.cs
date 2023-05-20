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
        private DataGridViewCellStyle selectedCellStyle;
        public AdvancedForm()
        {
            fontRegular = new Font("SegoeUI", 9, FontStyle.Regular);
            fontBold = new Font("SegoeUI", 9, FontStyle.Bold);
            selectedCellStyle = new();
            selectedCellStyle.BackColor = Color.Lavender;
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

        public DataGridViewCellStyle getSelectedCellStyle()
        {
            return selectedCellStyle;
        }

        public void resetForm(List<DataGridView> dgvs, List<GroupBox> gbs)
        {
            foreach (DataGridView dgv in dgvs)
                dgv.Rows.Clear();

            foreach (GroupBox gb in gbs)
                foreach (Control ctrl in gb.Controls)
                    if (ctrl.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                        ctrl.Text = string.Empty;
        }

        public void showAllRows(DataGridView dgv, int rowIndex)
        {
            if (rowIndex == -1)
                return;

            dgv.Rows[rowIndex].Visible = true;

            showAllRows(dgv, rowIndex - 1);
        }

        public void dataGridViewSorted(object sender)
        {
            DataGridView dgv = (DataGridView)sender;

            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].HeaderCell.Style.Font = fontRegular;

            dgv.SortedColumn.HeaderCell.Style.Font = fontBold; // Делаем шрифт сортируемого столбца жирным
        }

        public int dataGridViewSelectedCellStyleCount(DataGridView dgv, int rowIndex)
        {
            if (rowIndex == -1)
                return 0;

            if (dgv.Rows[rowIndex].DefaultCellStyle.BackColor == selectedCellStyle.BackColor)
                return dataGridViewSelectedCellStyleCount(dgv, rowIndex - 1) + 1;
            else
                return dataGridViewSelectedCellStyleCount(dgv, rowIndex - 1);
        }


        public int dataGridViewVisibleRowCount(DataGridView dgv, int rowIndex)
        {
            if (rowIndex == -1)
                return 0;

            if (dgv.Rows[rowIndex].Visible)
                return dataGridViewVisibleRowCount(dgv, rowIndex - 1) + 1;
            else
                return dataGridViewVisibleRowCount(dgv, rowIndex - 1);
        }

        public int dataGridViewFirstVisibleRowIndex(DataGridView dgv, int rowIndex)
        {
            if (rowIndex == dgv.Rows.Count)
                return -1;

            if (dgv.Rows[rowIndex].Visible)
                return rowIndex;
            else return dataGridViewFirstVisibleRowIndex(dgv, rowIndex + 1);
        }

        public void dataGridViewDeleteRowsWithCondition(DataGridView dgv, string columnName, string condition)
        {
            for (int i = dgv.Rows.Count - 1; i > -1; i--)
                if (dgv.Rows[i].Cells[columnName].Value.ToString() == condition)
                    dgv.Rows.Remove(dgv.Rows[i]);
        }
    }
}
