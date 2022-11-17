namespace Comida_2
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        public void tbHamburguesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHamburguesaQueso_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDobleCarne_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPapasFritas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPapasCheddar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCoca_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFanta_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSprite_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAgregarHamburguesa_Click(object sender, EventArgs e)
        {
            
            
            if(tbHamburguesa.Text != "")
            {
                Menu h2 = new Menu();
                float h = float.Parse(tbHamburguesa.Text);
                h2.HamburguesaSimple(h);
                tbHamburguesa.Text = "";
            }

            if (tbHamburguesaQueso.Text != "")
            {
                Menu h2 = new Menu();
                float h = float.Parse(tbHamburguesaQueso.Text);
                h2.HamburguesaQueso(h);
                tbHamburguesaQueso.Text = "";
            }

            if (tbDobleCarne.Text != "")
            {
                Menu h2 = new Menu();
                float h = float.Parse(tbDobleCarne.Text);
                h2.DobleCarne(h);
                tbDobleCarne.Text = "";
            }


        }

        private void btAgregarPapas_Click(object sender, EventArgs e)
        {

            if(tbPapasFritas.Text != "")
            {
                Menu h2 = new Menu();
                float p = float.Parse(tbPapasFritas.Text);
                h2.PapasFritasSimple(p);
                tbPapasFritas.Text = "";
            }

            if (tbPapasCheddar.Text != "")
            {
                Menu h2 = new Menu();
                float p = float.Parse(tbPapasCheddar.Text);
                h2.PapasCheddar(p);
                tbPapasCheddar.Text = "";
            }

        }

        private void btIngredientes_Click(object sender, EventArgs e)
        {
            // Agregar/quitar ingredientes -> lechuga, tomate, condimentos, etc
        }


        private void btImprimirTicket_Click(object sender, EventArgs e)
        {

            var ticket = new Ticket();
            ticket.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFecha1.Text = DateTime.Now.ToString();
        }

        private void btAgregarGaseosa_Click(object sender, EventArgs e)
        {
            if (tbCoca.Text != "")
            {
                Menu h2 = new Menu();
                float g = float.Parse(tbCoca.Text);
                h2.CocaCola(g);
                tbCoca.Text = "";
            }

            if (tbFanta.Text != "")
            {
                Menu h2 = new Menu();
                float g = float.Parse(tbFanta.Text);
                h2.Fanta(g);
                tbFanta.Text = "";
            }

            if (tbSprite.Text != "")
            {
                Menu h2 = new Menu();
                float g = float.Parse(tbSprite.Text);
                h2.Sprite(g);
                tbSprite.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0); //sobra si tienes la posici�n en el dise�o
            //this.Size = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
        }
    }
}