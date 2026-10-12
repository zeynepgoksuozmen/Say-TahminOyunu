using Microsoft.VisualBasic;

namespace sayıtahminoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tutulan, sayac, tahmin;       // sınıf düzeyi

        void AnaProgram()
        {
            Random sayi = new Random();
            tutulan = sayi.Next(1, 100);   // 1–99 arası
            sayac = 1;
            do
            {
                tahmin = int.Parse(Interaction.InputBox(sayac + ". Tahmininiz"));
                if (tahmin == tutulan)
                    MessageBox.Show("Bravo! " + sayac + ". tahminde bildiniz");
                else if (tahmin < tutulan)
                    MessageBox.Show("Daha büyük sayı giriniz");
                else
                    MessageBox.Show("Daha küçük sayı giriniz");
                sayac++;
            } while (tahmin != tutulan);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult cvp;
            do
            {
                AnaProgram();
                cvp = MessageBox.Show("Devam etmek istiyor musunuz?",
                        "Tahmin Oyunu", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            } while (cvp == DialogResult.Yes);
            this.Close();

        }
    }
}
