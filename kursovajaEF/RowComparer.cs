﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovajaEF
{
    public class RowComparer : System.Collections.IComparer
    {
        private static int sortOrderModifier = 1;

        public RowComparer(SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.Descending)
            {
                sortOrderModifier = -1;
            }
            else if (sortOrder == SortOrder.Ascending)
            {
                sortOrderModifier = 1;
            }
        }

        public int Compare(object x, object y)
        {
            DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
            DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

            int CompareResult = System.String.Compare(
                DataGridViewRow1.Cells[0].Value.ToString(),
                DataGridViewRow2.Cells[0].Value.ToString());

            if (CompareResult == 0)
            {
                CompareResult = System.String.Compare(
                    DataGridViewRow1.Cells[1].Value.ToString(),
                    DataGridViewRow2.Cells[1].Value.ToString());
            }
            if (CompareResult == 0)
            {
                CompareResult = System.String.Compare(
                    DataGridViewRow1.Cells[2].Value.ToString(),
                    DataGridViewRow2.Cells[2].Value.ToString());
            }
            return CompareResult * sortOrderModifier;
        }
    }
}
