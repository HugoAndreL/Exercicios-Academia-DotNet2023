namespace MiniERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NavigateFunc(object sender, EventArgs e)
        {
            Forn newFunc = new();
            newFunc.Show();
        }

        private void NavigateProd(object sender, EventArgs e)
        {
            Prod prod = new();
            prod.Show();
        }
    }
}
