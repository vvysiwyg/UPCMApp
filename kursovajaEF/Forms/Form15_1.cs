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
                foreach (GroupsTeacher gt in db.GroupsTeachers.AsNoTracking().ToList())
                    groups_teachers.Rows.Add(
                        gt.GroupId,
                        gt.TeacherId
                        );
                if (groups_teachers.RowCount != 0)
                    groups_teachers.Rows[0].Selected = true;

                foreach (GroupsTimetable gtt in db.GroupsTimetables.AsNoTracking().ToList())
                    groups_timetable.Rows.Add(
                        gtt.GroupId,
                        gtt.TtId
                        );
                if (groups_timetable.RowCount != 0)
                    groups_timetable.Rows[0].Selected = true;

                foreach (GroupsListener gl in db.GroupsListeners.AsNoTracking().ToList())
                    groups_listeners.Rows.Add(
                        gl.ListenerId,
                        gl.GroupId
                        );
                if (groups_listeners.RowCount != 0)
                    groups_listeners.Rows[0].Selected = true;
            }
        }
    }
}
