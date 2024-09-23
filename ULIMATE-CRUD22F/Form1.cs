namespace ULIMATE_CRUD22F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<CRUD> lista = new List<CRUD>();



        // CREARE ELEMENTO
        private void CREATE_Click(object sender, EventArgs e)
        {
            if (textbox_name.Text != null && textbox_cognome.Text != null)
            {
                CRUD rud = new CRUD(textbox_name.Text, textbox_cognome.Text);
                lista.Add(rud);

                LISTBOX.Items.Add(rud.toString());
            }
        }

        // AGGIUNGERE LISTA
        private void READ_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("elenco.txt");
            string stringa = sr.ReadLine();

            // scrivo nella listbox gli elementi del file
            while (stringa != null)
            {
                LISTBOX.Items.Add(stringa);

                stringa = sr.ReadLine();
            }

            sr.Close();
        }

        // AGGIORNARE ELEMENTI

        private void UPDATE_Click(object sender, EventArgs e)
        {
            string nome_da_cambiare = $"{textbox_name.Text}";

            for (int i = 0; i < lista.Count; i++)
            {
                if (nome_da_cambiare == lista[i].Nome)
                {
                    LISTBOX.Items.Remove($"{textbox_name.Text};{textbox_cognome.Text}");

                    // modifica lista

                    lista[i].Nome = textBoxupdateNOME.Text;
                    lista[i].Cogome = textboxudateCOGNOME.Text;

                    // modifica listbox

                    LISTBOX.Items.Add($"{textBoxupdateNOME.Text};{textboxudateCOGNOME.Text}");

                    break;
                }
            }

        }

        // ELIMINARE ELEMETO
        private void DELETE_Click(object sender, EventArgs e)
        {
            string nome_da_cambiare = $"{textbox_name.Text}";

            for (int i = 0; i < lista.Count; i++)
            {
                if (nome_da_cambiare == lista[i].Nome)
                {
                    LISTBOX.Items.Remove($"{textbox_name.Text};{textbox_cognome.Text}");
                    lista.Remove(lista[i]);

                    break;
                }
            }
        }

        // CARICAMENTO PROGRAMMA

        private void Form1_Load(object sender, EventArgs e)
        {
            // se durante l'apertura il file non esiste, allora lo crea

            if (File.Exists("elenco.txt") == false)
            {
                StreamWriter sw = new StreamWriter("elenco.txt");
                sw.Close();
            }

            update_label.Visible = false;
        }

        // SALVATAGGIO FILE
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("elenco.txt");

            for (int i = 0; i < lista.Count; i++)
            {
                sw.WriteLine(lista[i].toString());
            }

            sw.Close();
        }

        private void LISTBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    class CRUD
    {
        private string nome;
        private string cogome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cogome
        {
            get { return cogome; }
            set { cogome = value; }
        }

        public CRUD(string nome, string cogome)
        {
            this.nome = nome;
            this.cogome = cogome;
        }

        public string toString()
        {

            return $"{nome};{cogome}";
        }
    }
}