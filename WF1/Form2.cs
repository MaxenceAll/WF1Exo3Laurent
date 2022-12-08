namespace WF1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem == null)
            {
                label1.Text = "?";
                return;
            }
            string selectedItem = (string)cb.SelectedItem;

            if (selectedItem == "A")
            {
                label1.Text = "A";
            }
            else if (selectedItem == "B")
            {
                label1.Text = "B";
            }
            else if (selectedItem == "C")
            {
                label1.Text = "C";
            }
            else if (selectedItem == "D")
            {
                label1.Text = "D";
            }
            else
            {
                label1.Text = "?";
            }

            bool test = false;
            int nb = -1;
            if (test)
            {
                //exécuté si test vaut true
                nb = 0;
            }
            else
            {
                //exécuté si test vaut false
                nb = 1;
            }
            nb = test ? 1 : 0;
            //bool stop = true;

            //NON !
            //ET &&
            //OU ||

            bool a = true, b = false, c = true, d = false;
            if (!(a && b)) // !a || !b
            {

            }



        }
    }
}
