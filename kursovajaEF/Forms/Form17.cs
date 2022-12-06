using kursovajaEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovajaEF.Forms
{
    public partial class Form17 : AdvancedForm
    {
        public string chosenChair, chosenChairId;
        public Form17()
        {
            InitializeComponent();
            chosenChair = "0";
            using (testDBContext db = new())
            {
                fetch(db);
            }
        }

        private void fetch(testDBContext db)
        {
            foreach (Chair c in db.Chairs.AsNoTracking().ToList())
                chairs.Rows.Add(
                    c.ChairId,
                    c.ChairName);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form18 form = new();
            form.ShowDialog();
            if (form.label6.Text != "0")
            {
                chairs.Rows.Clear();
                using (testDBContext db = new())
                {
                    fetch(db);
                }

                if (chairs.RowCount != 0)
                    chairs.Rows[0].Selected = true;
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (chairs.SelectedRows.Count == 1 || chairs.SelectedCells.Count == 1)
            {
                Form18 fm = new();
                DataGridViewRow selRow = chairs.SelectedCells[0].OwningRow;
                fm.button1.Visible = false;
                fm.button3.Visible = true;
                fm.label7.Text = selRow.Cells["chairIdCol"].Value.ToString();
                fm.chairName.Text = selRow.Cells["chairNameCol"].Value.ToString();

                fm.ShowDialog();
                if (fm.label6.Text == "1")
                {
                    chairs.Rows.Clear();
                    using (testDBContext db = new())
                    {
                        fetch(db);
                    }

                    if (chairs.RowCount != 0)
                        chairs.Rows[0].Selected = true;
                }
            }
            else MessageBox.Show("Изменить можно только одну строку.", "Ошибка");
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (chairs.SelectedRows.Count == 1 || chairs.SelectedCells.Count == 1)
            {
                DataGridViewRow selRow = chairs.SelectedCells[0].OwningRow;
                string chairId = selRow.Cells["chairIdCol"].Value.ToString();

                using (testDBContext db = new())
                {
                    Chair c = db.Chairs.Find(int.Parse(chairId));
                    db.Remove(c);
                    db.SaveChanges();
                    chairs.Rows.Clear();
                    fetch(db);
                }
                if (chairs.RowCount != 0)
                    chairs.Rows[0].Selected = true;
            }
            else MessageBox.Show("За раз можно удалить только одну строку.", "Ошибка");
        }

        private void chooseСBtn_Click(object sender, EventArgs e)
        {
            if (chairs.SelectedRows.Count == 1 || chairs.SelectedCells.Count == 1)
            {
                chosenChair = chairs.SelectedCells[0].OwningRow.Cells["chairNameCol"].Value.ToString();
                chosenChairId = chairs.SelectedCells[0].OwningRow.Cells["chairIdCol"].Value.ToString();
                Close();
            }
        }

        private void chairs_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }

        private void chairs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            chooseСBtn_Click(sender, e);
        }
    }
}
