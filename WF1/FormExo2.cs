namespace WF1
{
    public partial class FormExo2 : Form
    {
        public FormExo2()
        {
            InitializeComponent();
        }

        private void FormExo2_Load(object sender, EventArgs e)
        {

        }

        public void ecrireMessage()
        {
            Console.WriteLine("Message");
            return;
        }
        public void ecrireUnMessage(string message, string message2)
        {
            Console.WriteLine(message);
            Console.WriteLine(message2);
            return;
        }

        public int returnMessage()
        {
            Console.WriteLine("Message");
            throw new NotImplementedException();
            return 0;
        }

        public string returnMessage(string message)
        {
            Console.WriteLine(message);
            return message;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int year, month, day;
            bool yearParsed = int.TryParse(textBoxYear.Text, out year);
            bool monthParsed = int.TryParse(textBoxMonth.Text, out month);
            bool dayParsed = int.TryParse(textBoxDay.Text, out day);

            try
            {
                returnMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ex : " + ex.Message);
            }


            //int day1 = 0;

            //try
            //{
            //    day1 = int.Parse(textBoxDay.Text);
            //}
            //catch (NullReferenceException nrEx)
            //{

            //}
            //catch (Exception ex)
            //{
            //    dayParsed = false;
            //}
            //finally
            //{

            //}

            //throw new Exception("Déclanchée manuellement");


            if (!yearParsed || !monthParsed || !dayParsed)
            {
                labelResult.Text = "Saisie non valide !";
                return;
            }
            if (month < 1 || month > 12)
            {
                labelResult.Text = "Mois non valide !";
                return;
            }
            int[] month31 = { 1, 3, 5, 7, 8, 10, 12 };
            if (month31.Contains(month) && (day < 1 || day > 31))
            {
                labelResult.Text = "Nb jours non valide !";
                return;
            }
            int[] month30 = { 4, 6, 9, 11 };
            if (month30.Contains(month) && (day < 1 || day > 30))
            {
                labelResult.Text = "Nb jours non valide !";
                return;
            }
            bool isLeap = year % 4 == 0 && (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0));
            isLeap = DateTime.IsLeapYear(year);
            if (isLeap && month == 2 && (day < 1 || day > 29))
            {
                labelResult.Text = "Nb jours non valide !";
                return;
            }
            if (!isLeap && month == 2 && (day < 1 || day > 28))
            {
                labelResult.Text = "Nb jours non valide !";
                return;
            }
            labelResult.Text = "Date valide !";
        }

        //Exo 2 : Écrire un algorithme qui après avoir demandé un numéro de jour, de mois et d'année à l'utilisateur,
        // renvoie true s'il s'agit d'une date valide (Attention aux années bissextiles)


    }
}
