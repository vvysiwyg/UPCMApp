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
                foreach (DisciplinesTeacher dt in db.DisciplinesTeachers.AsNoTracking().ToList())
                    disciplines_teachers.Rows.Add(
                        dt.TeacherId,
                        dt.DisciplineId
                        );
                if (disciplines_teachers.RowCount != 0)
                    disciplines_teachers.Rows[0].Selected = true;

                foreach (GroupsTeacher gt in db.GroupsTeachers.AsNoTracking().ToList())
                    groups_teachers.Rows.Add(
                        gt.TeacherId,
                        gt.GroupId
                        );
                if (groups_teachers.RowCount != 0)
                    groups_teachers.Rows[0].Selected = true;
            }
        }
    }
}
