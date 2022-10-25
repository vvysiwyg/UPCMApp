using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace kursovajaEF.Forms
{
    public partial class Form3 : AdvancedForm
    {
        private NpgsqlConnection conn;
        Font fontRegular;
        Font fontBold;
        public Form3(NpgsqlConnection conn)
        {
            fontRegular = new Font("SegoeUI", 9, FontStyle.Regular);
            fontBold = new Font("SegoeUI", 9, FontStyle.Bold);
            this.conn = conn;
            InitializeComponent();
        }

        private void fetch()
        {
            using(testDBContext db = new())
            {
                foreach (var l in db.Listeners.Select(s => new { 
                    Firstname = s.Firstname, 
                    Midname = s.Midname, 
                    Lastname = s.Lastname, 
                    Yob = s.Yob, 
                    Sex = s.Sex, 
                    Id = s.Id, 
                    Matriculation = s.Matriculation, 
                    ContractId = s.ContractId, 
                    PhoneNum = s.PhoneNum, 
                    SchoolGrade = s.SchoolGrade, 
                    Email = s.Email}))
                    dataGridView1.Rows.Add(l.Firstname, l.Midname, l.Lastname, l.Yob, l.Sex, l.Id, l.Matriculation, l.ContractId,
                        l.PhoneNum, l.SchoolGrade, l.Email);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            fetch();
            // Отмечаем первую строку
            if (dataGridView1.RowCount != 0)
                dataGridView1.Rows[0].Selected = true;
		}

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form4 form = new(); // Создаем экземпляр соответствующей формы заполнения
            form.ShowDialog(); // Выводим ее на экран

            if (form.label12.Text != "0") { // form.label12.Text != L"0" означает, что был добавлен слушатель, а в label12 хранится его id.
                string sex, matriculation;

                if (form.sexM.Checked == true)
                    sex = form.sexM.Text;
                else sex = form.sexF.Text;

                if (form.yes.Checked == true)
                    matriculation = form.yes.Text;
                else matriculation = form.no.Text;

                // Добавляем запись в datagridview
                dataGridView1.Rows.Add(form.firstname.Text, form.midname.Text, form.lastname.Text,
                    form.yob.Value.ToString().Remove(10), sex, form.label12.Text,
                    matriculation, "", form.phoneNum.Text, form.schoolGrade.Text, form.email.Text);

                // Убираем отметки со всех строк
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    dataGridView1.Rows[i].Selected = false;

                dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true; // Отмечаем последнюю строку
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1]
                    .Cells[dataGridView1.CurrentCell.ColumnIndex]; // установка указателя на новую строку
            }
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Form4 fm = new(); // Создаем экземпляр соответствующей формы заполнения
                fm.button2.Visible = false; // Кнопка Добавить становится невидимой
                fm.button4.Visible = true; // Кнопка Изменить становится видимой
                                             // 102-113: заполняем поля и т.д имеющейся информацией по слушателю. В label13 сохраняем его id
                fm.label13.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["idCol"].Value.ToString();
                fm.firstname.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["firstnameCol"].Value.ToString();
                fm.midname.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["midnameCol"].Value.ToString();
                fm.lastname.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["lastnameCol"].Value.ToString();
                fm.yob.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["yobCol"].Value.ToString();

                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["sexCol"].Value.ToString() == "Ж")
                    fm.sexF.Checked = true;
                else fm.sexM.Checked = true;

                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["matriculationCol"].Value.ToString() == "Да")
                    fm.yes.Checked = true;
                else fm.no.Checked = true;

                fm.phoneNum.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["phoneNumCol"].Value.ToString();
                fm.schoolGrade.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["schoolGradeCol"].Value.ToString();
                fm.email.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["emailCol"].Value.ToString();

                fm.ShowDialog();
                // fm.label12.Text == L"1" означает, что данные были изменены. if-блок: обновляем информацию в datagridview
                if (fm.label12.Text == "1") {
                    dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["firstnameCol"].Value = fm.firstname.Text;
                    dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["midnameCol"].Value = fm.midname.Text;
                    dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["lastnameCol"].Value = fm.lastname.Text;
                    dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["yobCol"].Value = fm.yob.Value.ToString().Remove(10);
                    
                    if (fm.sexF.Checked == true)
                        dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["sexCol"].Value = "Ж";
                    else dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["sexCol"].Value = "М";

                    if (fm.yes.Checked == true)
                        dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["matriculationCol"].Value = "Да";
                    else dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["matriculationCol"].Value = "Нет";

                    dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["phoneNumCol"].Value = fm.phoneNum.Text;
                    dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["schoolGradeCol"].Value = fm.schoolGrade.Text;
                    dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["emailCol"].Value = fm.email.Text;
                }
            }
            else MessageBox.Show("Изменить можно только одну строку.", "Ошибка"); // Если выбрано более одной строки, то выводим ошибку
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            // Удаление нескольких строк

            /*cli::array<int>^ selrow = gcnew cli::array<int>(dataGridView1.SelectedCells.Count);
            int iter = 0;

            //for (int i = 0; i < dataGridView1.RowCount; i++)
                //dataGridView1.Rows[i].Selected == true ? selrow = i : NULL;
            //MessageBox::Show(dataGridView1.GetCellCount(DataGridViewElementStates::Selected).ToString());

            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                selrow[i] = dataGridView1.SelectedCells[i].RowIndex;

            for (int i = 0; i < selrow.Length; i++)
                for (int j = i + 1; j < selrow.Length; j++)
                    selrow[i] == selrow[j] ? selrow[j] = -1 : NULL;

            System::Array::Sort(selrow);

            //MessageBox::Show(dataGridView1[0, 0].Value.ToString());
            //MessageBox::Show(dataGridView1.SelectedCells[i].OwningColumn.Name + " : " + dataGridView1.SelectedCells[i].Value.ToString());
            //MessageBox::Show(dataGridView1.SelectedCells[i].RowIndex.ToString());

            for (int i = 0; i < selrow.Length; i++) {
                if (selrow[i] != -1) {
                    sql = "DELETE FROM list WHERE id =" + 
                        dataGridView1.Rows[selrow[i] - iter].Cells[dataGridView1.Columns["idCol"].Index].Value.ToString() +
                        ";";
                    dml = gcnew OdbcCommand(sql, conn);
                    dml.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(selrow[i] - iter);
                    iter++;
                }
            }*/

            if (dataGridView1.SelectedCells.Count == 0)
                return; // Если ни одна клетка не выбрана, то ничего не делаем

            Form3_1 validation_form = new();
            if (validation_form.ShowDialog() == DialogResult.Yes/* && dataGridView1.CurrentRow.Index != dataGridView1.RowCount - 1*/)
            {
                validation_form.Dispose();
                int[] selrow = new int[dataGridView1.SelectedCells.Count]; // Инициализация массива с размерностью = число выбранных клеток
                int index = -1, count = 0; // index - номер строки, count - число выбранных строк

                // В i-ю ячейку записываем номер строки i-й клетки
                for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                    selrow[i] = dataGridView1.SelectedCells[i].RowIndex;

                // Если выбрано более 1 клетки в строке, то обращаем повторяющиеся номера (кроме одной) строк в -1. Таким образом все ячейки, не равные -1, это номера выбранных строк
                for (int i = 0; i < selrow.Length; i++)
                    for (int j = i + 1; j < selrow.Length; j++)
                        if(selrow[i] == selrow[j])
                            selrow[j] = -1;

                // Считаем количество выбранных строк и сохраняем номер строки
                for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                    if (selrow[i] != -1)
                    {
                        index = i;
                        count++;
                    }

                // Удаляем запись из БД и datagridview
                if (count == 1)
                {
                    int id = int.Parse(dataGridView1.Rows[selrow[index]].Cells[dataGridView1.Columns["idCol"].Index].Value.ToString());
                    using (testDBContext db = new())
                    {
                        Listener l = db.Listeners.Find(id);
                        db.Listeners.Remove(l);
                        db.SaveChanges();
                    }
                    dataGridView1.Rows.RemoveAt(selrow[index]);
                }
                else if (count > 1) MessageBox.Show("За раз можно удалить только одну строку.", "Ошибка"); // Если выбрано более одной строки, то выводим сообщение об ошибке
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string txt = textBox1.Text;
                using (testDBContext db = new())
                {
                    var l = db.Listeners.AsNoTracking().Where(w => 
                    EF.Functions.Like(w.Firstname, $"%{txt}%") ||
                    EF.Functions.Like(w.Midname, $"%{txt}%") ||
                    EF.Functions.Like(w.Lastname, $"%{txt}%") ||
                    EF.Functions.Like(w.Yob, $"%{txt}%") ||
                    EF.Functions.Like(w.Sex, $"%{txt}%") ||
                    EF.Functions.Like(w.Matriculation, $"%{txt}%") ||
                    EF.Functions.Like(w.PhoneNum.ToString(), $"{txt}%") ||
                    EF.Functions.Like(w.SchoolGrade, $"%{txt}%") ||
                    EF.Functions.Like(w.Email, $"%{txt}%"));

                    dataGridView1.Rows.Clear();

                    foreach(var elem in l)
                    {
                        dataGridView1.Rows.Add(
                            elem.Firstname,
                            elem.Midname,
                            elem.Lastname,
                            elem.Yob,
                            elem.Sex,
                            elem.Id,
                            elem.Matriculation,
                            elem.ContractId,
                            elem.PhoneNum,
                            elem.SchoolGrade,
                            elem.Email
                            );
                    }
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                fetch();
                if(dataGridView1.RowCount != 0)
                    dataGridView1.Rows[0].Selected = true;
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }
    }
}
