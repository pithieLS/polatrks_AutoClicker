namespace P_As_AutoClicker
{

    public partial class Form1 : Form
    {
        private static System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();

            /* Enable KyePreview so it can capture key events even when the window is not focused
             (mais aussi pcq les keyboard hooks en LL son trop compliqués à mettre en place 
              et si je fais pas en LL ça trigger l'antivirus)*/
            KeyPreview = true;

            KeyDown += OnKeyDown;

            timer = new System.Windows.Forms.Timer();
        }

        public void OnKeyDown(object sender, KeyEventArgs e) 
        {
            MessageBox.Show("Key pressed: " + e.KeyValue, "Key Pressed");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;

            timer.Interval = 333;
            timer.Tick += DoClick;
            timer.Start();
        }

        private void DoClick(object sender, EventArgs e)
        {
            //Point mouseCursorPos;
            //MouseHandler.GetCursorPos(out mouseCursorPos);
            //MouseHandler.PerformLeftClick(mouseCursorPos.X, mouseCursorPos.Y);

            //SendKeys.Send("a");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
