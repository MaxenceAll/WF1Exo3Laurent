namespace CountDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            for (int i = 9; i >= 0; i--)
            {
                await Task.Delay(1000);
                label1.Text = i.ToString();
            }
            label1.ForeColor = System.Drawing.Color.Red;
            //Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}