namespace ULIMATE_CRUD22F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CREARE ELEMENTO
        private void CREATE_Click(object sender, EventArgs e)
        {
            if (textbox_name.Text != null && textbox_cognome.Text != null) 
            {
                CRUD crud = new CRUD(textbox_name.Text, textbox_cognome.Text);

                LISTBOX.Items.Add(crud);
            }
        }

        // AGGIUNGERE LISTA
        private void READ_Click(object sender, EventArgs e)
        {

        }

        // AGGIORNARE ELEMENTI

        private void UPDATE_Click(object sender, EventArgs e)
        {

        }

        // ELIMINARE ELEMETO
        private void DELETE_Click(object sender, EventArgs e)
        {

        }

        // CARICAMENTO PROGRAMMA

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // SALVATAGGIO FILE
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }

    class CRUD
    {
        private string nome { get; set; }
        private string cogome { get; set; }

        public CRUD(string nome, string cogome)
        {
            this.nome = nome;
            this.cogome = cogome;
        }

        private List<CRUD> lista { get; set; }


        public void create(string nome,string cognome)
        {
            this.nome=nome;
            this.cogome=cognome;
        }
    }
}