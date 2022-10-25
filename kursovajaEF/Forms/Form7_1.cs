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
    public partial class Form7_1 : AdvancedForm
    {
        public Form7_1()
        {
            InitializeComponent();
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }

        private void Form7_1_Load(object sender, EventArgs e)
        {
            using (testDBContext db = new()) 
            {
                foreach (DisciplinesTeacher dt in db.DisciplinesTeachers.AsNoTracking().ToList())
                    disciplines_teachers.Rows.Add(
                        dt.DisciplineId,
                        dt.TeacherId
                        );
                if (disciplines_teachers.RowCount != 0)
                    disciplines_teachers.Rows[0].Selected = true;

                foreach (DisciplinesTimetable dtt in db.DisciplinesTimetables.AsNoTracking().ToList())
                    disciplines_timetable.Rows.Add(
                        dtt.DisciplineId,
                        dtt.TtId
                        );
                if (disciplines_timetable.RowCount != 0)
                    disciplines_timetable.Rows[0].Selected = true;
            }
        }
    }
}
