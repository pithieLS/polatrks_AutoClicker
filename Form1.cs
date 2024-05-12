using System.Diagnostics;
using System.Runtime.InteropServices;

namespace polatrks_AutoClicker
{
    // TODO: make sftw listen to keyboard inputs even when the window is not focused
    public partial class MainWindow : Form
    {
        private static bool bIsStarted = false;


        // auto press properties
        private static Keys startStopHotkey;
        private static int[] pressDelayRaw; // 0 = h, 1 = m, 2 = s, 3 = ms
        private static int pressDelay;
        private static int delayOffset;
        private static int pressType; // 0 = Single, 1 = Double
        private static Point clickPos;
        private static int clickOffset;
        private static bool bIsClickInCurrentPos;
        private static int repeatIndex;
        private static int repeatIndexMax; //-1 if repeating indefinitly

        public MainWindow()
        {
            // Make key handler to start kb hook GLL
            KeyHandler.StartHook();
            KeyHandler.OnKeyPressed += OnKeyDown;
            InitializeComponent();

            /* Enable KyePreview so it can capture key events even when the window is not focused
             (mais aussi pcq les keyboard hooks en LL son trop compliqués à mettre en place 
              et si je fais pas en LL ça trigger l'antivirus)*/
            KeyPreview = true;

            // Set default setting properties
            startStopHotkey = Keys.F6;
            pressDelayRaw = [0, 0, 0, 100];
            delayOffset = 0;
            pressType = 0;
            repeatIndex = 0;
            repeatIndexMax = -1;
            // Then in UI
            RefreshStartStopButtons();
            numericUpDownDelay_Hours.Value = pressDelayRaw[0];
            numericUpDownDelay_Minutes.Value = pressDelayRaw[1];
            numericUpDownDelay_Seconds.Value = pressDelayRaw[2];
            numericUpDownDelay_Milliseconds.Value = pressDelayRaw[3];
            numericUpDown_DelayOffset.Value = delayOffset;
            listBox_PressType.SetSelected(pressType, true);
            // TODO: make func to clean this scheisse
        }
        public void SetVariables()
        {
            pressDelayRaw = [ (int)numericUpDownDelay_Hours.Value,
                              (int)numericUpDownDelay_Minutes.Value,
                              (int)numericUpDownDelay_Seconds.Value,
                              (int)numericUpDownDelay_Milliseconds.Value ];

            delayOffset = (int)numericUpDown_DelayOffset.Value;

            pressType = listBox_PressType.SelectedIndex;

            bIsClickInCurrentPos = radioButton_CurrentPosition.Checked;

            if (!bIsClickInCurrentPos)
            {
                clickPos.X = (int)numericUpDown_CursorPosX.Value;
                clickPos.Y = (int)numericUpDown_CursorPosY.Value;
            }

            clickOffset = (int)numericUpDown_CursorOffset.Value;


            pressDelay = (int)((pressDelayRaw[0] * 3.6e+6)
            + (pressDelayRaw[1] * 60000)
            + (pressDelayRaw[2] * 1000)
            + (pressDelayRaw[3]));

            if (radioButton_RepeatNTimes.Checked)
                repeatIndexMax = (int)numericUpDown_RepeatN.Value;
            else
                repeatIndexMax = -1;

            repeatIndex = 1; // Starts at 1 or it count 1 more

        }
        public void OnKeyDown(Keys pressedKey)
        {
            if (pressedKey == startStopHotkey)
                if (bIsStarted)
                    StopPress();
                else
                    StartPress();
        }

        private static async Task DoPress()
        {
            if (!bIsStarted)
                return;

            Point m_clickPos;
            if (bIsClickInCurrentPos)
                m_clickPos = MouseHandler.GetCursorPos();
            else
                m_clickPos = clickPos;
            Random rand = new Random();
            m_clickPos.X += rand.Next(clickOffset * -1, clickOffset);
            m_clickPos.Y += rand.Next(clickOffset * -1, clickOffset);

            MouseHandler.DoLeftClick(m_clickPos);

            if (pressType == 1)
            {
                await Task.Delay(100);
                MouseHandler.DoLeftClick(m_clickPos);
            }

            int newPressDelay = pressDelay + rand.Next(delayOffset * -1, delayOffset);
            if (newPressDelay < 0)
                newPressDelay = 0;

            await Task.Delay(newPressDelay);

            if(repeatIndexMax > -1)
                if (repeatIndex >= repeatIndexMax)
                    StopPress();

            repeatIndex++;

            DoPress();
        }

        private void StartPress()
        {
            SetVariables();
            bIsStarted = true;
            DoPress();
        }

        private static void StopPress()
        {
            bIsStarted = false;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            StartPress();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            StopPress();
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

            numericUpDown_CursorPosX.Value = newPos.X;
            numericUpDown_CursorPosY.Value = newPos.Y;
        }
    }
}
