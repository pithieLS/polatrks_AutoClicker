namespace P_As_AutoClicker
{
    partial class CursorLocationPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_XValue = new Label();
            label_X = new Label();
            label_Y = new Label();
            label_YValue = new Label();
            SuspendLayout();
            // 
            // label_XValue
            // 
            label_XValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_XValue.Location = new Point(26, 9);
            label_XValue.Name = "label_XValue";
            label_XValue.Size = new Size(41, 20);
            label_XValue.TabIndex = 0;
            label_XValue.Text = "0000";
            // 
            // label_X
            // 
            label_X.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_X.Location = new Point(10, 9);
            label_X.Name = "label_X";
            label_X.Size = new Size(21, 20);
            label_X.TabIndex = 1;
            label_X.Text = "X:";
            // 
            // label_Y
            // 
            label_Y.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_Y.Location = new Point(74, 9);
            label_Y.Name = "label_Y";
            label_Y.Size = new Size(20, 20);
            label_Y.TabIndex = 3;
            label_Y.Text = "Y:";
            // 
            // label_YValue
            // 
            label_YValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_YValue.Location = new Point(90, 9);
            label_YValue.Name = "label_YValue";
            label_YValue.Size = new Size(41, 20);
            label_YValue.TabIndex = 2;
            label_YValue.Text = "0000";
            // 
            // CursorLocationPicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(134, 40);
            Controls.Add(label_Y);
            Controls.Add(label_YValue);
            Controls.Add(label_X);
            Controls.Add(label_XValue);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CursorLocationPicker";
            Text = "CursorLocationPicker";
            ResumeLayout(false);
        }

        #endregion

        private Label label_XValue;
        private Label label_X;
        private Label label_Y;
        private Label label_YValue;
    }
}