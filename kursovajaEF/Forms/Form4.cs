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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void midname_TextChanged(object sender, EventArgs e)
        {
			for (int i = 0; i < midname.Text.Length; i++)
			{
				if (midname.Text[i] <= '~')
				{
					midname.ForeColor = Color.Red;
					break;
				}
				else midname.ForeColor = Color.Black;

				/*if(i==0 && (textBox2.Text[0] < char(192) || textBox2.Text[0] > char(223)))
					MessageBox.Show("Фамилия должна начинаться с заглавной буквы", "Ошибка");*/
			}
			// 21-34: Блокировка/Разблокирование кнопок. Если хотя бы в одном поле есть недопустимый символ
			// то кнопки блокируются, иначе они становятся доступными.
			if (lastname.ForeColor == Color.Red || midname.ForeColor == Color.Red || firstname.ForeColor == Color.Red)
			{
				button2.Enabled = false;
				button4.Enabled = false;
			}
			else
			{
				button2.Enabled = true;
				button4.Enabled = true;
			}
		}

        private void firstname_TextChanged(object sender, EventArgs e)
        {
			for (int i = 0; i < firstname.Text.Length; i++)
			{
				if (firstname.Text[i] <= '~')
				{
					firstname.ForeColor = Color.Red;
					break;
				}
				else firstname.ForeColor = Color.Black;
			}
			if (lastname.ForeColor == Color.Red ||
				midname.ForeColor == Color.Red ||
				firstname.ForeColor == Color.Red)
			{
				button2.Enabled = false;
				button4.Enabled = false;
			}
			else
			{
				button2.Enabled = true;
				button4.Enabled = true;
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
			string sex; // Сюда записываем пол, который выберет юзер
			string matriculation;
			if (sexM.Checked == false && sexF.Checked == false)
			{ // Если пол не выбран, то выводим на экран сообщение об ошибке и прекращаем выполнение функции. Иначе заполняем переменную sex
				MessageBox.Show("Отметьте пол.", "Ошибка");
				return;
			}
			else if (sexM.Checked == true)
				sex = sexM.Text;
			else sex = sexF.Text;

			if (yes.Checked == false && no.Checked == false)
			{
				MessageBox.Show("Отметьте Зачислен.", "Ошибка");
				return;
			}
			else if (yes.Checked == true)
				matriculation = yes.Text;
			else matriculation = no.Text;

			using (testDBContext db = new())
            {
				Listener l = new()
				{
					Firstname = firstname.Text,
					Midname = midname.Text,
					Lastname = lastname.Text,
					Yob = yob.Value.ToString().Remove(10),
					Sex = sex,
					Matriculation = matriculation,
					PhoneNum = decimal.Parse(phoneNum.Text),
					SchoolGrade = schoolGrade.Text,
					Email = email.Text
				};

				db.Listeners.Add(l);
				db.SaveChanges();

				int id = (from lis in db.Listeners
						  orderby lis.Id descending
						  select lis.Id).FirstOrDefault();
				label12.Text = id.ToString();

			}
				
			//MessageBox.Show("Данные успешно добавлены", "Форма заявления");
			Close(); // Закрывает форму после добавления слушателя
			}

        private void lastname_TextChanged(object sender, EventArgs e)
        {
			for (int i = 0; i < lastname.Text.Length; i++)
			{
				if (lastname.Text[i] <= '~')
				{
					lastname.ForeColor = Color.Red;
					break;
				}
				else lastname.ForeColor = Color.Black;
			}
			if (lastname.ForeColor == Color.Red || midname.ForeColor == Color.Red || firstname.ForeColor == Color.Red)
			{
				button2.Enabled = false;
				button4.Enabled = false;
			}
			else
			{
				button2.Enabled = true;
				button4.Enabled = true;
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			firstname.Text = "";
			midname.Text = "";
			lastname.Text = "";
			phoneNum.Text = "";
			schoolGrade.Text = "";
			email.Text = "";
			yes.Checked = false;
			no.Checked = false;
			sexF.Checked = false;
			sexM.Checked = false;
			yob.Value = DateTime.UtcNow;
		}

        private void button3_Click(object sender, EventArgs e)
        {
			Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
			string sex;
			string matriculation;
			if (sexM.Checked == false && sexF.Checked == false)
			{ // Если пол не выбран, то выводим на экран сообщение об ошибке и прекращаем выполнение функции. Иначе заполняем переменную sex
				MessageBox.Show("Отметьте Ваш пол.", "Ошибка");
				return;
			}
			else if (sexM.Checked == true)
				sex = sexM.Text;
			else sex = sexF.Text;

			if (yes.Checked == false && no.Checked == false)
			{
				MessageBox.Show("Отметьте Зачислен.", "Ошибка");
				return;
			}
			else if (yes.Checked == true)
				matriculation = yes.Text;
			else matriculation = no.Text;

			using (testDBContext db = new())
            {
				Listener l = db.Listeners.Find(int.Parse(label13.Text));

				l.Firstname = firstname.Text;
				l.Midname = midname.Text;
				l.Lastname = lastname.Text;
				l.Yob = yob.Value.ToString().Remove(10);
				l.Sex = sex;
				l.Matriculation = matriculation;
				l.PhoneNum = decimal.Parse(phoneNum.Text);
				l.SchoolGrade = schoolGrade.Text;
				l.Email = email.Text;

				db.Update(l);
				db.SaveChanges();
			}

			label12.Text = "1"; // Фиксируем факт изменения данных для того, чтобы обновить данные в datagridview
			Close(); // Закрываем форму
			}
    }
}
