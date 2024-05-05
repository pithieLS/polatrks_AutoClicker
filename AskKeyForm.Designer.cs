namespace P_As_AutoClicker
{
    partial class AskKeyForm
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
            btn_Cancel = new Button();
            btn_Apply = new Button();
            label_AskPressKey = new Label();
            label_NewKey = new Label();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(12, 95);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(106, 42);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Apply
            // 
            btn_Apply.Location = new Point(163, 95);
            btn_Apply.Name = "btn_Apply";
            btn_Apply.Size = new Size(106, 42);
            btn_Apply.TabIndex = 1;
            btn_Apply.Text = "Apply";
            btn_Apply.UseVisualStyleBackColor = true;
            btn_Apply.Click += btn_Apply_Click;
            // 
            // label_AskPressKey
            // 
            label_AskPressKey.AutoSize = true;
            label_AskPressKey.Location = new Point(90, 9);
            label_AskPressKey.Name = "label_AskPressKey";
            label_AskPressKey.Size = new Size(104, 20);
            label_AskPressKey.TabIndex = 2;
            label_AskPressKey.Text = "Press any key...";
            // 
            // label_NewKey
            // 
            label_NewKey.AutoSize = true;
            label_NewKey.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label_NewKey.Location = new Point(108, 38);
            label_NewKey.Name = "label_NewKey";
            label_NewKey.Size = new Size(78, 46);
            label_NewKey.TabIndex = 3;
            label_NewKey.Text = "Key";
            // 
            // AskKeyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 149);
            Controls.Add(label_NewKey);
            Controls.Add(label_AskPressKey);
            Controls.Add(btn_Apply);
            Controls.Add(btn_Cancel);
            Name = "AskKeyForm";
            Text = "AskKeyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Button btn_Apply;
        private Label label_AskPressKey;
        private Label label_NewKey;
    }
}