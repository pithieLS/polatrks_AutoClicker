namespace polatrks_AutoClicker
{
    public partial class AskKeyForm : Form
    {
        public Keys newKey;
        public AskKeyForm()
        {
            InitializeComponent();

            KeyPreview = true;
            KeyDown += OnKeyPressed;
        }

        private void OnKeyPressed(object sender, KeyEventArgs e)
        {
            newKey = e.KeyCode;

            label_NewKey.Text = e.KeyCode.ToString();

            // Prevent the form from processing the key further
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            newKey = Keys.None;
            Close();
        }
    }
}
