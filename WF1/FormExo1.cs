namespace WF1
{
    public partial class FormExo1 : Form
    {
        public FormExo1()
        {
            InitializeComponent();
        }

        //private void FormExo1_Load(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBoxAge.Text;
            int age = -1;
            bool convertResult = int.TryParse(input, out age);
            if (convertResult && age > 0 && age < 100)
            {
                if (age < 5)
                {
                    MessageBox.Show("trop jeune !");
                }
                else if (age >= 5 && age <= 6)
                {
                    MessageBox.Show("baby foot");
                }
                else
                {
                    MessageBox.Show("saisie incorrecte !");
                }

                int rnd = new Random().Next(0, 100);

                switch (age)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        MessageBox.Show("trop jeune !");
                        break;
                    case 5:
                    case 6:
                        MessageBox.Show("baby foot");
                        break;
                    ///...
                    default:
                        MessageBox.Show("trop vieux");
                        break;
                }

                //switch (true)
                //{
                //    case (age < 5):
                //        MessageBox.Show("trop jeune !");
                //        break;
                //}
            }
            else
            {
                MessageBox.Show("saisie incorrecte !");
            }

        }

        // Exo 1
        // écrire un algorithme qui demande à l’utilisateur de saisir l’age de son enfant et qui lui affiche 
        // dans quelle catégorie celui-ci jouera au foot cette saison.
        // Moins de 5 ans : pas possible de s’inscrire !
        // 5-6 ans : baby foot
        // 7-8 ans : poussins
        // 9-10 ans : pupilles
        // 11-12 ans : minimes
        // 13-14 ans : cadets
        // 15-16-17 ans : junior
        // 18 ans et + : ça n’est plus un enfant


    }
}
