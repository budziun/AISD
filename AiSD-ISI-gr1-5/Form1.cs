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
            //A(w1);

            var p1 = new Wêze³2(1);
            var p2 = new Wêze³2(2);
            var p3 = new Wêze³2(3);
            var p4 = new Wêze³2(4);
            var p5 = new Wêze³2(5);
            var p6 = new Wêze³2(6);

            p1.Add(p2);
            p1.Add(p3);
            p2.Add(p4);
            p2.Add(p5);
            p3.Add(p6);
            p4.Add(p6);
            B(p1);
        }
        void A(Wêze³ w)
        {
            MessageBox.Show(w.wartoœæ.ToString());
            for (int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
        }
        void B(Wêze³2 p)
        {
            for(int i= 0;i<p.)
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
    public class Wêze³2
    {
        public int warto;
        public List<Wêze³2> s¹siad = new List<Wêze³2>();
        public Wêze³2(int liczba)
        {
            this.warto = liczba;
        }
        public void Add(Wêze³2 s)
        {
            if (s == this)
            {
                return;
            }
            if (!this.s¹siad.Contains(s))
            {
                this.s¹siad.Add(s);
                s.s¹siad.Add(this);
            }
            if (!s.s¹siad.Contains(this))
            {
                s.s¹siad.Add(this);
            }
        }
    }
}