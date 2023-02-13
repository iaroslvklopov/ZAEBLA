using vstavka;

namespace brrrPitpm1vo2sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] massiv = new int[10];

        private void genBtn_Click(object sender, EventArgs e)
        {
            genTb.Text = "";
            generate gi = new generate();
            massiv = gi.genMethod();
            for (int i = 0; i < massiv.Length; i++)
            {
                genTb.Text += massiv[i] + " ";
            }
            
        }

        private void vstavkaBtn_Click(object sender, EventArgs e)
        {
            Vstavkas brr = new Vstavkas();
            if (upRb.Checked == true) vyvodTb.Text = brr.sorta_vstavka(massiv);
            else vyvodTb.Text = brr.sorta_vstavka_down(massiv);
        }

        private void obmenBtn_Click(object sender, EventArgs e)
        {
            Obmene brrr = new Obmene();
            if (upRb.Checked == true) vyvodTb.Text = brrr.sorta_obmena(massiv);
            else vyvodTb.Text = brrr.sorta_obmena_down(massiv);
        }

        private void choBtn_Click(object sender, EventArgs e)
        {
            Vybore br = new Vybore();
            if (upRb.Checked == true) vyvodTb.Text = br.sorta_vybora(massiv);
            else vyvodTb.Text = br.sorta_vybora_down(massiv);
        }
    }
}