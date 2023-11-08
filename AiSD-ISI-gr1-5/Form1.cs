namespace AiSD_ISI_gr1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var w1 = new Wêze³(5);
            var w2 = new Wêze³(3);
            var w3 = new Wêze³(1);
            var w4 = new Wêze³(2);
            var w5 = new Wêze³(6);
            var w6 = new Wêze³(4);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);
            A(w1);
        }
        void A(Wêze³ w)
        {
            MessageBox.Show(w.wartoœæ.ToString());
            for(int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
        }
    }
    public class Wêze³
    {
        public int wartoœæ;
        public List<Wêze³> dzieci = new List<Wêze³>();
        public Wêze³(int liczba)
        {
            this.wartoœæ = liczba;
        }
    }
}