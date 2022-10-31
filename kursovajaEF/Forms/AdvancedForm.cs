﻿using Npgsql;
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

        public void showAllListeners(DataGridView dgv, int rowIndex)
        {
            if (rowIndex == -1)
                return;

            dgv.Rows[rowIndex].Visible = true;

            showAllListeners(dgv, rowIndex - 1);
        }

        public void showExpelledListeners(DataGridView dgv, int rowIndex)
        {
            if (rowIndex == -1)
                return;

            if(!string.IsNullOrWhiteSpace(dgv.Rows[rowIndex].Cells["expulsionDateCol"].Value.ToString()))
                dgv.Rows[rowIndex].Visible = true;
            else
                dgv.Rows[rowIndex].Visible = false;

            showExpelledListeners(dgv, rowIndex - 1);
        }

        public void dataGridViewSorted(object sender)
        {
            DataGridView dgv = (DataGridView)sender;

            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].HeaderCell.Style.Font = fontRegular;

            dgv.SortedColumn.HeaderCell.Style.Font = fontBold; // Делаем шрифт сортируемого столбца жирным
        }

        public int dataGridViewVisibleRowCount(DataGridView dgv)
        {
            int count = 0;

            foreach (DataGridViewRow row in dgv.Rows)
                if (row.Visible)
                    count++;

            return count;
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
    }
}
