using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Mytextbox.Text))
            {
                return;
            }
            string typed_msg;
            typed_msg = Mytextbox.Text;
            Mylistbox.Items.Add(typed_msg);
            Mytextbox.Clear();
            Mytextbox.Focus();
        }

        private void Mylistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mytextbox_TextChanged(object sender, EventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsend.PerformClick();
            }
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
