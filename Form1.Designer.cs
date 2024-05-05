namespace P_As_AutoClicker
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_Start = new Button();
            btn_Stop = new Button();
            groupBox_TimerSettings = new GroupBox();
            groupBox1 = new GroupBox();
            label_Repeat2 = new Label();
            label_Repeat1 = new Label();
            numericUpDown_RepeatN = new NumericUpDown();
            checkBox_RepeatUntilStopped = new CheckBox();
            label6 = new Label();
            groupBox_Delay = new GroupBox();
            numericUpDownDelay_Milliseconds = new NumericUpDown();
            numericUpDownDelay_Minutes = new NumericUpDown();
            numericUpDownDelay_Seconds = new NumericUpDown();
            numericUpDownDelay_Hours = new NumericUpDown();
            label_DelayOffset = new Label();
            numericUpDown_DelayOffset = new NumericUpDown();
            labelDelay_Milliseconds = new Label();
            labelDelay_Minutes = new Label();
            labelDelay_Seconds = new Label();
            labelDelay_Hours = new Label();
            label1 = new Label();
            groupBox_KeySettings = new GroupBox();
            groupBox_CursorSetting = new GroupBox();
            label_CursorOffset = new Label();
            numericUpDown_CursorOffset = new NumericUpDown();
            button_PickPosition = new Button();
            label_Y = new Label();
            textBox_CursorPosY = new TextBox();
            label_X = new Label();
            textBox_CursorPosX = new TextBox();
            radioButton_OtherPosition = new RadioButton();
            radioButton_CurrentPosition = new RadioButton();
            groupBox2 = new GroupBox();
            listBox_PressType = new ListBox();
            btn_ChangeStartStopHK = new Button();
            toolTip1 = new ToolTip(components);
            groupBox_TimerSettings.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_RepeatN).BeginInit();
            groupBox_Delay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay_Milliseconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay_Minutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay_Seconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay_Hours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_DelayOffset).BeginInit();
            groupBox_KeySettings.SuspendLayout();
            groupBox_CursorSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_CursorOffset).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(223, 337);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(135, 53);
            btn_Start.TabIndex = 0;
            btn_Start.Text = "START \r\n(HOTKEY)";
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_Stop
            // 
            btn_Stop.Location = new Point(364, 337);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(135, 53);
            btn_Stop.TabIndex = 1;
            btn_Stop.Text = "STOP \r\n(HOTKEY)\r\n";
            btn_Stop.UseVisualStyleBackColor = true;
            // 
            // groupBox_TimerSettings
            // 
            groupBox_TimerSettings.Controls.Add(groupBox1);
            groupBox_TimerSettings.Controls.Add(groupBox_Delay);
            groupBox_TimerSettings.Location = new Point(12, 12);
            groupBox_TimerSettings.Name = "groupBox_TimerSettings";
            groupBox_TimerSettings.Size = new Size(245, 319);
            groupBox_TimerSettings.TabIndex = 2;
            groupBox_TimerSettings.TabStop = false;
            groupBox_TimerSettings.Text = "Timer settings";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_Repeat2);
            groupBox1.Controls.Add(label_Repeat1);
            groupBox1.Controls.Add(numericUpDown_RepeatN);
            groupBox1.Controls.Add(checkBox_RepeatUntilStopped);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(6, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 93);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delay";
            // 
            // label_Repeat2
            // 
            label_Repeat2.AutoSize = true;
            label_Repeat2.Location = new Point(152, 58);
            label_Repeat2.Name = "label_Repeat2";
            label_Repeat2.Size = new Size(45, 20);
            label_Repeat2.TabIndex = 4;
            label_Repeat2.Text = "times";
            // 
            // label_Repeat1
            // 
            label_Repeat1.AutoSize = true;
            label_Repeat1.Location = new Point(11, 58);
            label_Repeat1.Name = "label_Repeat1";
            label_Repeat1.Size = new Size(56, 20);
            label_Repeat1.TabIndex = 3;
            label_Repeat1.Text = "Repeat";
            // 
            // numericUpDown_RepeatN
            // 
            numericUpDown_RepeatN.Location = new Point(73, 56);
            numericUpDown_RepeatN.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDown_RepeatN.Name = "numericUpDown_RepeatN";
            numericUpDown_RepeatN.Size = new Size(73, 27);
            numericUpDown_RepeatN.TabIndex = 2;
            // 
            // checkBox_RepeatUntilStopped
            // 
            checkBox_RepeatUntilStopped.AutoSize = true;
            checkBox_RepeatUntilStopped.Checked = true;
            checkBox_RepeatUntilStopped.CheckState = CheckState.Checked;
            checkBox_RepeatUntilStopped.Location = new Point(6, 26);
            checkBox_RepeatUntilStopped.Name = "checkBox_RepeatUntilStopped";
            checkBox_RepeatUntilStopped.Size = new Size(179, 24);
            checkBox_RepeatUntilStopped.TabIndex = 1;
            checkBox_RepeatUntilStopped.Text = "Repeat until stoppped";
            checkBox_RepeatUntilStopped.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 0;
            label6.Text = "Repeat";
            // 
            // groupBox_Delay
            // 
            groupBox_Delay.Controls.Add(numericUpDownDelay_Milliseconds);
            groupBox_Delay.Controls.Add(numericUpDownDelay_Minutes);
            groupBox_Delay.Controls.Add(numericUpDownDelay_Seconds);
            groupBox_Delay.Controls.Add(numericUpDownDelay_Hours);
            groupBox_Delay.Controls.Add(label_DelayOffset);
            groupBox_Delay.Controls.Add(numericUpDown_DelayOffset);
            groupBox_Delay.Controls.Add(labelDelay_Milliseconds);
            groupBox_Delay.Controls.Add(labelDelay_Minutes);
            groupBox_Delay.Controls.Add(labelDelay_Seconds);
            groupBox_Delay.Controls.Add(labelDelay_Hours);
            groupBox_Delay.Controls.Add(label1);
            groupBox_Delay.Location = new Point(6, 26);
            groupBox_Delay.Name = "groupBox_Delay";
            groupBox_Delay.Size = new Size(233, 137);
            groupBox_Delay.TabIndex = 0;
            groupBox_Delay.TabStop = false;
            groupBox_Delay.Text = "Delay";
            // 
            // numericUpDownDelay_Milliseconds
            // 
            numericUpDownDelay_Milliseconds.Location = new Point(116, 64);
            numericUpDownDelay_Milliseconds.Name = "numericUpDownDelay_Milliseconds";
            numericUpDownDelay_Milliseconds.Size = new Size(65, 27);
            numericUpDownDelay_Milliseconds.TabIndex = 13;
            // 
            // numericUpDownDelay_Minutes
            // 
            numericUpDownDelay_Minutes.Location = new Point(116, 31);
            numericUpDownDelay_Minutes.Name = "numericUpDownDelay_Minutes";
            numericUpDownDelay_Minutes.Size = new Size(65, 27);
            numericUpDownDelay_Minutes.TabIndex = 12;
            // 
            // numericUpDownDelay_Seconds
            // 
            numericUpDownDelay_Seconds.Location = new Point(4, 64);
            numericUpDownDelay_Seconds.Name = "numericUpDownDelay_Seconds";
            numericUpDownDelay_Seconds.Size = new Size(65, 27);
            numericUpDownDelay_Seconds.TabIndex = 11;
            // 
            // numericUpDownDelay_Hours
            // 
            numericUpDownDelay_Hours.Location = new Point(4, 31);
            numericUpDownDelay_Hours.Name = "numericUpDownDelay_Hours";
            numericUpDownDelay_Hours.Size = new Size(65, 27);
            numericUpDownDelay_Hours.TabIndex = 10;
            // 
            // label_DelayOffset
            // 
            label_DelayOffset.AutoSize = true;
            label_DelayOffset.Location = new Point(111, 103);
            label_DelayOffset.Name = "label_DelayOffset";
            label_DelayOffset.Size = new Size(108, 20);
            label_DelayOffset.TabIndex = 9;
            label_DelayOffset.Text = "+/- Offset (ms)";
            // 
            // numericUpDown_DelayOffset
            // 
            numericUpDown_DelayOffset.Location = new Point(6, 101);
            numericUpDown_DelayOffset.Name = "numericUpDown_DelayOffset";
            numericUpDown_DelayOffset.Size = new Size(99, 27);
            numericUpDown_DelayOffset.TabIndex = 8;
            // 
            // labelDelay_Milliseconds
            // 
            labelDelay_Milliseconds.AutoSize = true;
            labelDelay_Milliseconds.Location = new Point(184, 66);
            labelDelay_Milliseconds.Name = "labelDelay_Milliseconds";
            labelDelay_Milliseconds.Size = new Size(28, 20);
            labelDelay_Milliseconds.TabIndex = 7;
            labelDelay_Milliseconds.Text = "ms";
            // 
            // labelDelay_Minutes
            // 
            labelDelay_Minutes.AutoSize = true;
            labelDelay_Minutes.Location = new Point(184, 33);
            labelDelay_Minutes.Name = "labelDelay_Minutes";
            labelDelay_Minutes.Size = new Size(22, 20);
            labelDelay_Minutes.TabIndex = 5;
            labelDelay_Minutes.Text = "m";
            // 
            // labelDelay_Seconds
            // 
            labelDelay_Seconds.AutoSize = true;
            labelDelay_Seconds.Location = new Point(73, 66);
            labelDelay_Seconds.Name = "labelDelay_Seconds";
            labelDelay_Seconds.Size = new Size(15, 20);
            labelDelay_Seconds.TabIndex = 4;
            labelDelay_Seconds.Text = "s";
            // 
            // labelDelay_Hours
            // 
            labelDelay_Hours.AutoSize = true;
            labelDelay_Hours.Location = new Point(73, 33);
            labelDelay_Hours.Name = "labelDelay_Hours";
            labelDelay_Hours.Size = new Size(17, 20);
            labelDelay_Hours.TabIndex = 3;
            labelDelay_Hours.Text = "h";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 0;
            label1.Text = "Delay";
            // 
            // groupBox_KeySettings
            // 
            groupBox_KeySettings.Controls.Add(groupBox_CursorSetting);
            groupBox_KeySettings.Controls.Add(groupBox2);
            groupBox_KeySettings.Location = new Point(268, 12);
            groupBox_KeySettings.Name = "groupBox_KeySettings";
            groupBox_KeySettings.Size = new Size(232, 319);
            groupBox_KeySettings.TabIndex = 3;
            groupBox_KeySettings.TabStop = false;
            groupBox_KeySettings.Text = "Key settings";
            // 
            // groupBox_CursorSetting
            // 
            groupBox_CursorSetting.Controls.Add(label_CursorOffset);
            groupBox_CursorSetting.Controls.Add(numericUpDown_CursorOffset);
            groupBox_CursorSetting.Controls.Add(button_PickPosition);
            groupBox_CursorSetting.Controls.Add(label_Y);
            groupBox_CursorSetting.Controls.Add(textBox_CursorPosY);
            groupBox_CursorSetting.Controls.Add(label_X);
            groupBox_CursorSetting.Controls.Add(textBox_CursorPosX);
            groupBox_CursorSetting.Controls.Add(radioButton_OtherPosition);
            groupBox_CursorSetting.Controls.Add(radioButton_CurrentPosition);
            groupBox_CursorSetting.Location = new Point(6, 118);
            groupBox_CursorSetting.Name = "groupBox_CursorSetting";
            groupBox_CursorSetting.Size = new Size(220, 195);
            groupBox_CursorSetting.TabIndex = 1;
            groupBox_CursorSetting.TabStop = false;
            groupBox_CursorSetting.Text = "Cursor settings";
            // 
            // label_CursorOffset
            // 
            label_CursorOffset.AutoSize = true;
            label_CursorOffset.Location = new Point(106, 160);
            label_CursorOffset.Name = "label_CursorOffset";
            label_CursorOffset.Size = new Size(108, 20);
            label_CursorOffset.TabIndex = 11;
            label_CursorOffset.Text = "+/- Offset (ms)";
            // 
            // numericUpDown_CursorOffset
            // 
            numericUpDown_CursorOffset.Location = new Point(10, 158);
            numericUpDown_CursorOffset.Name = "numericUpDown_CursorOffset";
            numericUpDown_CursorOffset.Size = new Size(93, 27);
            numericUpDown_CursorOffset.TabIndex = 10;
            // 
            // button_PickPosition
            // 
            button_PickPosition.Location = new Point(34, 109);
            button_PickPosition.Name = "button_PickPosition";
            button_PickPosition.Size = new Size(150, 42);
            button_PickPosition.TabIndex = 8;
            button_PickPosition.Text = "Pick";
            button_PickPosition.UseVisualStyleBackColor = true;
            button_PickPosition.Click += button_PickPosition_Click;
            // 
            // label_Y
            // 
            label_Y.AutoSize = true;
            label_Y.Location = new Point(186, 71);
            label_Y.Name = "label_Y";
            label_Y.Size = new Size(17, 20);
            label_Y.TabIndex = 7;
            label_Y.Text = "Y";
            // 
            // textBox_CursorPosY
            // 
            textBox_CursorPosY.Location = new Point(145, 66);
            textBox_CursorPosY.Name = "textBox_CursorPosY";
            textBox_CursorPosY.Size = new Size(39, 27);
            textBox_CursorPosY.TabIndex = 6;
            textBox_CursorPosY.Text = "0000";
            // 
            // label_X
            // 
            label_X.AutoSize = true;
            label_X.Location = new Point(121, 71);
            label_X.Name = "label_X";
            label_X.Size = new Size(18, 20);
            label_X.TabIndex = 5;
            label_X.Text = "X";
            // 
            // textBox_CursorPosX
            // 
            textBox_CursorPosX.Location = new Point(81, 66);
            textBox_CursorPosX.Name = "textBox_CursorPosX";
            textBox_CursorPosX.Size = new Size(39, 27);
            textBox_CursorPosX.TabIndex = 4;
            textBox_CursorPosX.Text = "0000";
            // 
            // radioButton_OtherPosition
            // 
            radioButton_OtherPosition.AutoSize = true;
            radioButton_OtherPosition.Location = new Point(6, 66);
            radioButton_OtherPosition.Name = "radioButton_OtherPosition";
            radioButton_OtherPosition.Size = new Size(67, 24);
            radioButton_OtherPosition.TabIndex = 1;
            radioButton_OtherPosition.Text = "Other";
            radioButton_OtherPosition.UseVisualStyleBackColor = true;
            // 
            // radioButton_CurrentPosition
            // 
            radioButton_CurrentPosition.AutoSize = true;
            radioButton_CurrentPosition.Checked = true;
            radioButton_CurrentPosition.Location = new Point(6, 26);
            radioButton_CurrentPosition.Name = "radioButton_CurrentPosition";
            radioButton_CurrentPosition.Size = new Size(136, 24);
            radioButton_CurrentPosition.TabIndex = 0;
            radioButton_CurrentPosition.TabStop = true;
            radioButton_CurrentPosition.Text = "Current position";
            radioButton_CurrentPosition.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox_PressType);
            groupBox2.Location = new Point(6, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 86);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Press type";
            // 
            // listBox_PressType
            // 
            listBox_PressType.FormattingEnabled = true;
            listBox_PressType.Items.AddRange(new object[] { "Single", "Double" });
            listBox_PressType.Location = new Point(34, 24);
            listBox_PressType.Name = "listBox_PressType";
            listBox_PressType.Size = new Size(150, 44);
            listBox_PressType.TabIndex = 0;
            // 
            // btn_ChangeStartStopHK
            // 
            btn_ChangeStartStopHK.Location = new Point(11, 337);
            btn_ChangeStartStopHK.Name = "btn_ChangeStartStopHK";
            btn_ChangeStartStopHK.Size = new Size(206, 53);
            btn_ChangeStartStopHK.TabIndex = 4;
            btn_ChangeStartStopHK.Text = "Change Hotkey";
            btn_ChangeStartStopHK.UseVisualStyleBackColor = true;
            btn_ChangeStartStopHK.Click += btn_ChangeStartStopHK_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 424);
            Controls.Add(btn_ChangeStartStopHK);
            Controls.Add(groupBox_KeySettings);
            Controls.Add(groupBox_TimerSettings);
            Controls.Add(btn_Stop);
            Controls.Add(btn_Start);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "P-A's Autoclicker";
            groupBox_TimerSettings.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_RepeatN).EndInit();
            groupBox_Delay.ResumeLayout(false);
            groupBox_Delay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay_Milliseconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay_Minutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay_Seconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay_Hours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_DelayOffset).EndInit();
            groupBox_KeySettings.ResumeLayout(false);
            groupBox_CursorSetting.ResumeLayout(false);
            groupBox_CursorSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_CursorOffset).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Start;
        private Button btn_Stop;
        private GroupBox groupBox_TimerSettings;
        private GroupBox groupBox_Delay;
        private Label label1;
        private Label labelDelay_Seconds;
        private Label labelDelay_Hours;
        private Label labelDelay_Minutes;
        private Label labelDelay_Milliseconds;
        private GroupBox groupBox1;
        private Label label6;
        private NumericUpDown numericUpDown_RepeatN;
        private CheckBox checkBox_RepeatUntilStopped;
        private Label label_Repeat2;
        private Label label_Repeat1;
        private Label label_DelayOffset;
        private NumericUpDown numericUpDown_DelayOffset;
        private GroupBox groupBox_KeySettings;
        private GroupBox groupBox2;
        private ListBox listBox_PressType;
        private Button btn_ChangeStartStopHK;
        private GroupBox groupBox_CursorSetting;
        private RadioButton radioButton_OtherPosition;
        private RadioButton radioButton_CurrentPosition;
        private Label label_Y;
        private TextBox textBox_CursorPosY;
        private Label label_X;
        private TextBox textBox_CursorPosX;
        private Button button_PickPosition;
        private ToolTip toolTip1;
        private Label label_CursorOffset;
        private NumericUpDown numericUpDown_CursorOffset;
        private NumericUpDown numericUpDownDelay_Milliseconds;
        private NumericUpDown numericUpDownDelay_Minutes;
        private NumericUpDown numericUpDownDelay_Seconds;
        private NumericUpDown numericUpDownDelay_Hours;
    }
}
