namespace P_As_AutoClicker
{

    public partial class MainWindow : Form
    {
        private static System.Windows.Forms.Timer timer;


        // auto press properties
        private Keys startStopHotkey;
        private int[] timerDelay; // 0 = h, 1 = m, 2 = s, 3 = ms
        private int timerOffset;
        private int pressType;


        public MainWindow()
        {
            InitializeComponent();

            /* Enable KyePreview so it can capture key events even when the window is not focused
             (mais aussi pcq les keyboard hooks en LL son trop compliqués à mettre en place 
              et si je fais pas en LL ça trigger l'antivirus)*/
            KeyPreview = true;

            KeyDown += OnKeyDown;

            timer = new System.Windows.Forms.Timer();

            // Set default setting properties
            startStopHotkey = Keys.F6;
            timerDelay = [0, 0, 0, 100];
            timerOffset = 0;
            pressType = 0;
            // Then in UI
            RefreshStartStopButtons();
            numericUpDownDelay_Hours.Value = timerDelay[0];
            numericUpDownDelay_Minutes.Value = timerDelay[1];
            numericUpDownDelay_Seconds.Value = timerDelay[2];
            numericUpDownDelay_Milliseconds.Value = timerDelay[3];
            numericUpDown_DelayOffset.Value = timerOffset;
            listBox_PressType.SelectedItem = pressType;
            // TODO: make func to clean this scheisse
        }

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Key pressed: " + e.KeyValue, "Key Pressed");

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;

            timer.Interval = 333;
            timer.Tick += DoPress;
            timer.Start();
        }

        private void DoPress(object sender, EventArgs e)
        {
            //Point mouseCursorPos;
            //MouseHandler.GetCursorPos(out mouseCursorPos);
            //MouseHandler.PerformLeftClick(mouseCursorPos.X, mouseCursorPos.Y);

            //SendKeys.Send("a");
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btn_Stop.Text = startStopHotkey.ToString();
        }

        private void btn_ChangeStartStopHK_Click(object sender, EventArgs e)
        {
            Keys newHK;
            KeyHandler.AskNewKey(out newHK);

            if (newHK == Keys.None)
                return;

            startStopHotkey = newHK;

            RefreshStartStopButtons();
        }

        private void RefreshStartStopButtons()
        {
            btn_Start.Text = "START\n(" + startStopHotkey.ToString() + ')';
            btn_Stop.Text = "STOP\n(" + startStopHotkey.ToString() + ')';
        }

        private void button_PickPosition_Click(object sender, EventArgs e)
        {
            Point newPos;
            MouseHandler.PickCursorPosition(out newPos);

            textBox_CursorPosX.Text = newPos.X.ToString();
            textBox_CursorPosY.Text = newPos.Y.ToString();
        }
    }
}
