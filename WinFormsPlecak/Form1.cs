using Problem_plecakowy;

namespace WinFormsPlecak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int L_Przedmiotow, Seed, Pojemno��;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string l_przed = textBox_l_przed.Text.ToString();           
            string seed = textBox_seed.Text.ToString();           
            string pojemosc = textBox_pojemnosc.Text.ToString();
            if(textBox_l_przed.Text.Length == 0)
            {
                l_przed = "-1";
                textBox_przedmioty.Clear();
                textBox_wynik.Clear();
            }
            if (textBox_seed.Text.Length == 0)
            {
                seed = "-1";
                textBox_przedmioty.Clear();
                textBox_wynik.Clear();
            }
            if (textBox_pojemnosc.Text.Length == 0)
            {
                pojemosc = "-1";
                textBox_przedmioty.Clear();
                textBox_wynik.Clear();
            }
            L_Przedmiotow = int.Parse(l_przed);
            Seed = int.Parse(seed);
            Pojemno�� = int.Parse(pojemosc);

            if(Seed <= 0)
            {
                textBox_seed.BackColor = Color.Red;
            }
            if(Pojemno�� <= 0)
            {
                textBox_pojemnosc.BackColor = Color.Red;
            }
            if(L_Przedmiotow <= 0)
            {
                textBox_l_przed.BackColor = Color.Red;
            }
           
            if (Seed > 0)
            {
                textBox_seed.BackColor = Color.White;
            }
            if (Pojemno�� > 0)
            {
                textBox_pojemnosc.BackColor = Color.White;
            }
            if (L_Przedmiotow > 0)
            {
                textBox_l_przed.BackColor = Color.White;
            }

            Problem problem = new Problem(L_Przedmiotow, Seed);
            Result result = problem.Solve(Pojemno��);

            textBox_wynik.Text = result.ToString();
            foreach (var item in problem.listaPrzedmiotow) 
            {
                textBox_przedmioty.AppendText($"Warto��: {item.wartosc} Waga: {item.waga}" + Environment.NewLine);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
