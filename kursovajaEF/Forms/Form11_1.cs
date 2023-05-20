using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace kursovajaEF.Forms
{
    public partial class Form11_1 : AdvancedForm
    {
        public Form11_1()
        {
            InitializeComponent();
        }

        private void Form11_1_Load(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                foreach (var gtt in db.GroupsTimetables.
                    Include(i => i.Group).
                    Include(i => i.Tt).
                    Select(s => new 
                    {
                        GroupNum = s.Group.GroupNum,
                        Weekday = s.Tt.Weekday,
                        StartTime = s.Tt.StartTime,
                        EndTime = s.Tt.EndTime
                    }).
                    AsNoTracking().ToList())
                    groups_timetable.Rows.Add(
                        gtt.GroupNum,
                        gtt.Weekday,
                        gtt.StartTime,
                        gtt.EndTime
                        );
                if (groups_timetable.RowCount != 0)
                    groups_timetable.Rows[0].Selected = true;

                foreach (var dtt in db.DisciplinesTimetables.
                    Include(i => i.Discipline).
                    Include(i => i.Tt).
                    Select(s => new
                    {
                        DisciplineName = s.Discipline.DisciplineName,
                        Weekday = s.Tt.Weekday,
                        StartTime = s.Tt.StartTime,
                        EndTime = s.Tt.EndTime
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

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }
    }
}
