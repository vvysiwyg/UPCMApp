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
                foreach (GroupsTimetable gtt in db.GroupsTimetables.AsNoTracking().ToList())
                    groups_timetable.Rows.Add(
                        gtt.GroupId,
                        gtt.TtId
                        );
                if (groups_timetable.RowCount != 0)
                    groups_timetable.Rows[0].Selected = true;

                foreach (DisciplinesTimetable dtt in db.DisciplinesTimetables.AsNoTracking().ToList())
                    disciplines_timetable.Rows.Add(
                        dtt.DisciplineId,
                        dtt.TtId
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
