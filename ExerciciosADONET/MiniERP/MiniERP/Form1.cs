namespace MiniERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNavigateFunc(object sender, EventArgs e)
        {
            Forn newFunc = new();
            newFunc.ShowDialog();
        }
    }
}
