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
            var w1 = new W�ze�(5);
            var w2 = new W�ze�(3);
            var w3 = new W�ze�(1);
            var w4 = new W�ze�(2);
            var w5 = new W�ze�(6);
            var w6 = new W�ze�(4);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);
            //A(w1);

            var p1 = new W�ze�2(1);
            var p2 = new W�ze�2(2);
            var p3 = new W�ze�2(3);
            var p4 = new W�ze�2(4);
            var p5 = new W�ze�2(5);
            var p6 = new W�ze�2(6);

            p1.Add(p2);
            p1.Add(p3);
            p2.Add(p4);
            p2.Add(p5);
            p3.Add(p6);
            p4.Add(p6);
            B(p1);
        }
        void A(W�ze� w)
        {
            MessageBox.Show(w.warto��.ToString());
            for (int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
        }
        void B(W�ze�2 p)
        {
            for(int i= 0;i<p.)
        }

    public class W�ze�
    {
        public int warto��;
        public List<W�ze�> dzieci = new List<W�ze�>();
        public W�ze�(int liczba)
        {
            this.warto�� = liczba;
        }
    }
    public class W�ze�2
    {
        public int warto;
        public List<W�ze�2> s�siad = new List<W�ze�2>();
        public W�ze�2(int liczba)
        {
            this.warto = liczba;
        }
        public void Add(W�ze�2 s)
        {
            if (s == this)
            {
                return;
            }
            if (!this.s�siad.Contains(s))
            {
                this.s�siad.Add(s);
                s.s�siad.Add(this);
            }
            if (!s.s�siad.Contains(this))
            {
                s.s�siad.Add(this);
            }
        }
    }
}