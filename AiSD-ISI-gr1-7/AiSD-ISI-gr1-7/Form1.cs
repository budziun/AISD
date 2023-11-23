using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiSD_ISI_gr1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var w1 = new Węzeł(5);
            var w2 = new Węzeł(3);
            var w3 = new Węzeł(1);
            var w4 = new Węzeł(2);
            var w5 = new Węzeł(6);
            var w6 = new Węzeł(4);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);
            //A(w1);

            var p1 = new Węzeł2(1);
            var p2 = new Węzeł2(2);
            var p3 = new Węzeł2(3);
            var p4 = new Węzeł2(4);
            var p5 = new Węzeł2(5);
            var p6 = new Węzeł2(6);

            p1.Add(p2);
            p1.Add(p3);
            p2.Add(p4);
            p2.Add(p5);
            p3.Add(p6);
            p4.Add(p6);
            napis = "";
            odwiedzone.Clear();
            //B(p1);
            //MessageBox.Show(napis);

            var s1 = new Wezel3(5);
            var s2 = new Wezel3(2);
            
                
        }
        void A(Węzeł w)
        {
            MessageBox.Show(w.wartość.ToString());
            for (int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
        }
        //DFS GRAF z cyklami
        string napis = "";
        List<Węzeł2> odwiedzone = new();
        void B(Węzeł2 w)
        {
            odwiedzone.Add(w);
            napis += w.wartość.ToString();
            foreach (var sąsiad in w.sąsiad)
            {
                if (!odwiedzone.Contains(sąsiad))
                {
                    B(sąsiad);
                }
            }
        }
        //BFS dla kazdego GRAFu: 5,2,1,4,8,3


        
    }
    public class Węzeł
    {
        public int wartość;
        public List<Węzeł> dzieci = new List<Węzeł>();
        public Węzeł(int liczba)
        {
            this.wartość = liczba;
        }
    }
    public class Węzeł2
    {
        public int wartość;
        public List<Węzeł2> sąsiad = new List<Węzeł2>();

        public Węzeł2(int liczba)
        {
            this.wartość = liczba;
        }
        public void Add(Węzeł2 s)
        {
            if (s == this)
            {
                return;
            }
            if (!this.sąsiad.Contains(s))
            {
                this.sąsiad.Add(s);
                s.sąsiad.Add(this);
            }
            if (!s.sąsiad.Contains(this))
            {
                s.sąsiad.Add(this);
            }
        }
    }
    class Wezel3
    {
        public int wartosc;
        public List<Wezel3> rodzic = new List<Wezel3>();
        public List<Wezel3> lewedziecko = new List<Wezel3>();
        public List<Wezel3> prawedziecko = new List<Wezel3>();
        public Wezel3(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public void Addlewe(Wezel3 w)
        {
            if (w == this)
            {
                return;
            }
            if (!this.lewedziecko.Contains(w))
            {
                this.lewedziecko.Add(w);
            }
            if (!w.rodzic.Contains(this))
            {
                w.rodzic.Add(this);
            }

        }
        public void Addprawe(Wezel3 w)
        {
            if (w == this)
            {
                return;
            }
            if (!this.prawedziecko.Contains(w))
            {
                this.prawedziecko.Add(w);
            }
            if (!w.rodzic.Contains(this))
            {
                w.rodzic.Add(this);
            }

        }
        public override string ToString()
        {
            return this.wartosc.ToString();
        }
    }
}
