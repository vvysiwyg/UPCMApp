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
                foreach (var dt in db.DisciplinesTeachers.
                    Include(i => i.Discipline).
                    Include(i => i.Teacher).
                    Select(s => new
                    {
                        DisciplineName = s.Discipline.DisciplineName,
                        TeacherFio = s.Teacher.Fio
                    }).
                    AsNoTracking().ToList())
                    disciplines_teachers.Rows.Add(
                        dt.DisciplineName,
                        dt.TeacherFio
                        );
                if (disciplines_teachers.RowCount != 0)
                    disciplines_teachers.Rows[0].Selected = true;

                foreach (var dtt in db.DisciplinesTimetables.
                    Include(i => i.Discipline).
                    Include(i => i.Tt).
                    Select(s => new
                    {
                        DisciplineName = s.Discipline.DisciplineName,
                        Weekday = s.Tt.Weekday,
                        StartTime = s.Tt.StartTime,
                        EndTime = s.Tt.EndTime,
                    }).
                    AsNoTracking().ToList())
                    disciplines_timetable.Rows.Add(
                        dtt.DisciplineName,
                        dtt.Weekday,
                        dtt.StartTime,
                        dtt.EndTime
                        );
                if (disciplines_timetable.RowCount != 0)
                    disciplines_timetable.Rows[0].Selected = true;
            }
        }
    }
}
