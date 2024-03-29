namespace simulacion_taller_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Client> ListClientes = new();
        const double MinLleggada = 5;
        const double MaxLleggada = 11;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {

                ListClientes.Add(new Client(i, MinLleggada, MaxLleggada));
            }

            dataGridView1.DataSource = ListClientes;
            dataGridView1.Refresh();

        }
    }
}