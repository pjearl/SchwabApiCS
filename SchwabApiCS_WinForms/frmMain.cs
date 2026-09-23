namespace SchwabApiCS_WinForms
{
    public partial class frmMain : Form
    {
        frmAccounts frmAccounts; // = new frmAccounts();
        public frmMain()
        {
            InitializeComponent();
            frmAccounts = new frmAccounts();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            frmAccounts.Show();
        }
    }
}
