using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jornal
{
    public class GridViewMetods
    {
        static public void ColorSelectedRows(DataGridView grid)
        {
            Color colorDefault = Color.DarkCyan;
            Color colorWork = Color.FromArgb(192, 0, 0);
            Color colorFinish = Color.Green;
            Color colorSented = Color.Blue;
            if (grid.Rows.Count != 0)
            {
                
                if (Convert.ToString((grid.CurrentRow.Cells[14].Value)) != "")
                {
                    switch (Convert.ToInt32((grid.CurrentRow.Cells[14].Value)))
                    {
                        case -882036:
                            grid.CurrentRow.DefaultCellStyle.SelectionBackColor = colorWork;
                            return;
                        case -10238087:
                            grid.CurrentRow.DefaultCellStyle.SelectionBackColor = colorFinish;
                            return;
                        case -8154114:
                            grid.CurrentRow.DefaultCellStyle.SelectionBackColor = colorSented;
                            return;
                        default:
                            grid.CurrentRow.DefaultCellStyle.SelectionBackColor = colorDefault;
                            return;
                    }
                }
            }
        }
    }
}
