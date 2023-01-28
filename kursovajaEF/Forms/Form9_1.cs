using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace kursovajaEF.Forms
{
    public partial class Form9_1 : AdvancedForm
    {
        public Form9_1()
        {
            InitializeComponent();
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }

        private void Form9_1_Load(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                foreach (var dt in db.DisciplinesTeachers.
                    Include(i => i.Discipline).
                    Include(i => i.Teacher).
                    Select(s => new 
                    {
                        TeacherFio = s.Teacher.Fio,
                        DisciplineName = s.Discipline.DisciplineName
                    }).
                    AsNoTracking().ToList())
                    disciplines_teachers.Rows.Add(
                        dt.TeacherFio,
                        dt.DisciplineName
                        );
                if (disciplines_teachers.RowCount != 0)
                    disciplines_teachers.Rows[0].Selected = true;

                foreach (var gt in db.GroupsTeachers.
                    Include(i => i.Group).
                    Include(i => i.Teacher).
                    Select(s => new
                    {
                        TeacherFio = s.Teacher.Fio,
                        GroupNum = s.Group.GroupNum
                    }).
                    AsNoTracking().ToList())
                    groups_teachers.Rows.Add(
                        gt.TeacherFio,
                        gt.GroupNum
                        );
                if (groups_teachers.RowCount != 0)
                    groups_teachers.Rows[0].Selected = true;
            }
        }
    }
}
