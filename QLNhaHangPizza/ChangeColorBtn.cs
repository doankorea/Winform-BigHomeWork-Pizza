using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyNhaHangPizza
{
    public class ChangeColorBtn
    {
        public void Changecolor(Button btn)
        {
            btn.BackColor = Color.FromArgb(28, 26, 36);
            btn.FlatAppearance.BorderColor = Color.FromArgb(0xC8, 0x50, 0xF2);
        }
        public void Resetcolor(Button btn)
        {
            btn.BackColor = Color.FromArgb(0xC8, 0x50, 0xF2);
            btn.FlatAppearance.BorderColor = Color.FromArgb(28, 26, 36);
        }
    }
}
