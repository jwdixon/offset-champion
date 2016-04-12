using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_resize : Form
    {
        private int room_min_w, room_min_h, room_shift_x, room_shift_y;
        private bool room_shift_always;

        public int MinimumWidth { get { return room_min_w; } set { room_min_w = value; } }
        public int MinimumHeight { get { return room_min_h; } set { room_min_h = value; } }
        public int ShiftX { get { return room_shift_x; } set { room_shift_x = value; } }
        public int ShiftY { get { return room_shift_y; } set { room_shift_y = value; } }
        public bool ShiftAlways { get { return room_shift_always; } set { room_shift_always = value; } }

        public frm_resize(int _min_w, int _min_h, int _shift_x, int _shift_y, bool _shift_always)
        {
            InitializeComponent();

            if (_min_w >= 0) { MIN_WIDTH.Text = _min_w.ToString(); }
            if (_min_h >= 0) { MIN_HEIGHT.Text = _min_h.ToString(); }

            SHIFT_X.Text = _shift_x.ToString();
            SHIFT_Y.Text = _shift_y.ToString();

            CHECK_SHIFT.Checked = !_shift_always;
        }

        private void RESIZE_ACCEPT_Click(object sender, EventArgs e)
        {
            int _min_w, _min_h, _shift_x, _shift_y;

            if (int.TryParse(MIN_WIDTH.Text, out _min_w))   { MinimumWidth = _min_w; }
            if (int.TryParse(MIN_HEIGHT.Text, out _min_h))  { MinimumHeight = _min_h; }
            if (int.TryParse(SHIFT_X.Text, out _shift_x))   { ShiftX = _shift_x; }
            if (int.TryParse(SHIFT_Y.Text, out _shift_y))   { ShiftY = _shift_y; }

            ShiftAlways = !CHECK_SHIFT.Checked;

            Close();
        }

        private void RESIZE_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MIN_WIDTH_TextChanged(object sender, EventArgs e)
        {
            int _min_w;

            if(Int32.TryParse(MIN_WIDTH.Text, out _min_w))
            {
                if(_min_w < 0) { MIN_WIDTH.Text = "0"; }
            }
        }

        private void MIN_HEIGHT_TextChanged(object sender, EventArgs e)
        {
            int _min_h;

            if(Int32.TryParse(MIN_HEIGHT.Text, out _min_h))
            {
                if(_min_h < 0) { MIN_HEIGHT.Text = "0"; }
            }
        }
    }
}
