using System.Linq;

namespace WF1
{
    public partial class FormExo3 : Form
    {
        private List<int> notes = new List<int>();
        //int[] notes = new int[99];
        public FormExo3()
        {
            InitializeComponent();
            addTextBoxNote();            
        }

        //public int getNotesQty()
        //{
        //    return int.Parse(textBoxNoteQty.Text);
        //}
        //public void setNotesQty(int value)
        //{
        //    textBoxNoteQty.Text = value.ToString();
        //}

        private int NotesQty //Propriété
        {
            get
            {
                return int.Parse(textBoxNoteQty.Text);
            }
            set
            {
                textBoxNoteQty.Text = value.ToString();
            }
        }

        private void buttonNoteQtyMoins_Click(object sender, EventArgs e)
        {
            if (NotesQty == 1)
            {
                return;
            }
            NotesQty--;
            removeTextBoxNote();
        }

        private void buttonNoteQtyPlus_Click(object sender, EventArgs e)
        {
            if (NotesQty == 99)
            {
                return;
            }
            NotesQty++;
            addTextBoxNote();
        }

        private void addTextBoxNote()
        {            
            int index = NotesQty - 1;
            TextBox newTextBox = new TextBox();
            int x = 3 + 39 * (index % 10);
            int y = 3 + 36 * (index / 10);
            newTextBox.Location = new System.Drawing.Point(x, y);
            newTextBox.Size = new System.Drawing.Size(33, 27);
            newTextBox.TabIndex = index;
            panelNotes.Controls.Add(newTextBox);
            newTextBox.TextChanged += NewTextBox_TextChanged;
            notes.Add(0);
        }

        private void NewTextBox_TextChanged(object? sender, EventArgs e)
        {
            int number;
            int index = panelNotes.Controls.IndexOf((TextBox)sender);
            TextBox currentTextBox = (TextBox)panelNotes.Controls[index];
  
            if ( Int32.TryParse(currentTextBox.Text, out number) )
            {
                notes[index] = number;
            }

            textBoxMax.Text = Convert.ToString(notes.Max());
            textBoxMin.Text = Convert.ToString(notes.Min());
            textBoxMoy.Text = Convert.ToString(notes.Average());
        }

        private void removeTextBoxNote()
        {
            panelNotes.Controls.RemoveAt(NotesQty);
            notes.RemoveAt(notes.Count -1);
        }

        private void buttonCalcul_Click(object sender, EventArgs e)
        {
            textBoxMax.Text = Convert.ToString(notes.Max());
            textBoxMin.Text = Convert.ToString(notes.Min());
            textBoxMoy.Text = Convert.ToString(notes.Average());
            bool bp = true;
        }

        // Exo 3

        // 1. Écrire un algo qui permet de saisir les notes d’un élève pour en calculer la moyenne (Attention au contrôle de saisie)
        // On commence par demander à l’utilisateur combien de notes il souhaite saisir.
        // Une fois toutes les notes saisies, on calcule et affiche la moyenne

        // 2. Compléter l’algorithme précédent en affichant la note maxi et la note mini de l'élève

        // 3. Modifier l’algorithme précédent en supprimant l’étape “demander à l’utilisateur combien de notes il souhaite saisir” 
        // La saisie des notes sera possible tant que l’utilisateur ne clic pas sur le bouton “Calculer” 
        // En plus de la moyenne et des notes min et max, il faudra afficher combien de notes ont été saisies
    }
}
