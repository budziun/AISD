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
            A(w1);
        }
        void A(W�ze� w)
        {
            MessageBox.Show(w.warto��.ToString());
            for(int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
        }
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
}