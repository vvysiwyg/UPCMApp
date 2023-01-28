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
    public partial class Form15_1 : AdvancedForm
    {
        public Form15_1()
        {
            InitializeComponent();
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            dataGridViewSorted(sender);
        }

        private void Form15_1_Load(object sender, EventArgs e)
        {
            using (testDBContext db = new())
            {
                foreach (var gt in db.GroupsTeachers.
                    Include(i => i.Group).
                    Include(i => i.Teacher).
                    Select(s => new
                    { 
                        GroupNum = s.Group.GroupNum,
                        TeacherFio = s.Teacher.Fio
                    }).
                    AsNoTracking().ToList())
                    groups_teachers.Rows.Add(
                        gt.GroupNum,
                        gt.TeacherFio
                        );
                if (groups_teachers.RowCount != 0)
                    groups_teachers.Rows[0].Selected = true;

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

                foreach (var gl in db.GroupsListeners.
                    Include(i => i.Group).
                    Include(i => i.Listener).
                    Select(s => new
                    {
                        GroupNum = s.Group.GroupNum,
                        ListenerFio = $"{s.Listener.Midname}  {s.Listener.Firstname}  {s.Listener.Lastname}"
                    }).
                    AsNoTracking().ToList())
                    groups_listeners.Rows.Add(
                        gl.GroupNum,
                        gl.ListenerFio
                        );
                if (groups_listeners.RowCount != 0)
                    groups_listeners.Rows[0].Selected = true;
            }
        }
    }
}
