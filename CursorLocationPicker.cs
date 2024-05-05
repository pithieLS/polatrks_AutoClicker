using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_As_AutoClicker
{
    public partial class CursorLocationPicker : Form
    {
        public CursorLocationPicker()
        {
            InitializeComponent();

            KeyPreview = true;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += UpdateCursorPos;
            timer.Start();

            MouseClick += MouseClicked;
        }

        private void UpdateCursorPos(object sender, EventArgs e)
        {
            Point CurrentPos = Cursor.Position;

            /*                Set the cursor location           */
            Point newLocation = Cursor.Position;

            // Adding offset so it collide w/ the cursor
            newLocation.X -= 3;
            newLocation.Y -= 3;

            Location = newLocation;

            /*          Set the tooltip label w/ current coords  */
            label_XValue.Text = CurrentPos.X.ToString();
            label_YValue.Text = CurrentPos.Y.ToString();
        }

        private void MouseClicked(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
