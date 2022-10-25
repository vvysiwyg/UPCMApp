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
    public partial class Form5 : AdvancedForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void fetch(testDBContext db)
        {
            foreach (Department d in db.Departments.AsNoTracking().ToList())
                dataGridView1.Rows.Add(
                    d.DepartmentId,
                    d.DepartmentName);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                fetch(db);
            }
            if(dataGridView1.RowCount != 0)
                dataGridView1.Rows[0].Selected = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form6 form = new();
            form.ShowDialog();
            if (form.label1.Text != "0") {
                dataGridView1.Rows.Add(form.label1.Text, form.dept_name.Text);
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
                dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Form6 fm = new();
                fm.button1.Visible = false;
                fm.button3.Visible = true;
                fm.label2.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["idCol"].Value.ToString();
                fm.dept_name.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["deptCol"].Value.ToString();
                fm.ShowDialog();
                if (fm.label1.Text == "1")
			        dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["deptCol"].Value = fm.dept_name.Text;
            }
            else MessageBox.Show("Изменить можно только одну строку.", "Ошибка");
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                using(testDBContext db = new())
                {
                    Department d = db.Departments.Find(int.Parse(dataGridView1.
                        Rows[dataGridView1.SelectedRows[0].Index].
                        Cells[dataGridView1.Columns["idCol"].Index].Value.ToString()));

                    db.Departments.Remove(d);
                    db.SaveChanges();
                }
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else MessageBox.Show("За раз можно удалить только одну строку.", "Ошибка");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string txt = textBox1.Text;
                using (testDBContext db = new())
                {
                    var d = db.Departments.AsNoTracking().Where(w =>
                    EF.Functions.Like(w.DepartmentName, $"%{txt}%"));

                    dataGridView1.Rows.Clear();

                    foreach (var elem in d)
                        dataGridView1.Rows.Add(
                            elem.DepartmentId,
                            elem.DepartmentName
                            );
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                using (testDBContext db = new())
                {
                    fetch(db);
                }
                if (dataGridView1.RowCount != 0)
                    dataGridView1.Rows[0].Selected = true;
            }
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }
    }
}
