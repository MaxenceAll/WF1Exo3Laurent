namespace WF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateIsValid(20, 13, 2020);
        }

        bool dateIsValid(int day, int month, int year)
        {
            bool result = false;
            //31 jours : 1 3 5 7 8 10 12
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day > 0 && day <= 31)
                {
                    result = true;
                }
            }
            //30 jours : 4 6 9 11
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day > 0 && day <= 30)
                {
                    result = true;
                }
            }
            else if (month == 2)
            {
                bool isBisextil = (year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 100 == 0 && year % 400 == 0);
                //isBisextil = year % 4 == 0 && (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0));

                //29 jours : 2 && bs
                if (isBisextil && day == 29)
                {
                    result = true;
                }
                //28 jours : 2 && !bs
                if (!isBisextil && day == 28)
                {
                    result = true;
                }

            }

            return result;
        }


    }
}