namespace AiSD_ISI_gr1_8
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
            napis = "";
            odwiedzone.Clear();
            //B(p1);
            //MessageBox.Show(napis);


            var d = new DrzewoBinarne(5);
            d.Add(4);
            d.Add(4);
            d.Add(8);
            d.Add(7);
            d.Add(9);
            d.Add(6);



        }

        void A(W�ze� w)
        {
            MessageBox.Show(w.warto��.ToString());
            for (int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
        }

        // DFS GRAF z cyklami
        string napis = "";
        List<W�ze�2> odwiedzone = new();

        void B(W�ze�2 w)
        {
            odwiedzone.Add(w);
            napis += w.warto��.ToString();
            foreach (var s�siad in w.s�siad)
            {
                if (!odwiedzone.Contains(s�siad))
                {
                    B(s�siad);
                }
            }
        }
        /*
        // BFS dla kazdego GRAFu: 5,2,1,4,8,3
        void C(Wezel3 start)
        {
            Queue<Wezel3> queue = new Queue<Wezel3>();
            HashSet<Wezel3> visited = new HashSet<Wezel3>();

            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                Wezel3 current = queue.Dequeue();
                napis += current.ToString() + Environment.NewLine; // Dodaj wynik do napisu

                foreach (Wezel3 child in current.lewedziecko.Concat(current.prawedziecko))
                {
                    if (!visited.Contains(child))
                    {
                        queue.Enqueue(child);
                        visited.Add(child);
                    }
                }
            }
        }
        */
        /////////////////////////
        //co do domu
        //1. funkcja znajdz
        // wezel3 znajdz(int liczba){
        // ma zwrocic wezel wartosci ktorej szukam
        // return wezel z wartoscia
        //}
        //2. wezel3 znajdz_min (Wezel3 w) -> idziemy w lewo i ten ktory ostatni ten jest najmniejsza wartoscia, czyli dziecko z lewej najmniejsze inaczej zwrot wart
        //3. wezel3 znajdz_max (Wezel3 w) -> na odwrot co min
        //4. wezel3 nastepnik  (Wezel3 w) 
        //a) jest prawe dziecko  -> 3,4,4,5,6,7,8,9 // znajdz min na prawym dziecku
        //b) nie ma prawego dziecka -> idz do gory tak dlugo az wyjdziesz jako lewe dziecko wtedy rodzic jest nastepnikiem
        //c) gdy idac do gory wychodze zawsze wychodze jako prawe dziecko az nie ma kolejnego rodzica wtedy brak nastepnika
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
public class W�ze�2
{
    public int warto��;
    public List<W�ze�2> s�siad = new List<W�ze�2>();

    public W�ze�2(int liczba)
    {
        this.warto�� = liczba;
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
public class Wezel3
{
    public int wartosc;
    public Wezel3 lewe;
    public Wezel3 prawe;
    public Wezel3 rodzic;

    public Wezel3(int wartosc)
    {
        this.wartosc = wartosc;
        this.prawe = null;
        this.lewe = null;
    }

    public void Add(int liczba)
    {
        var dziecko = new Wezel3(liczba);
        dziecko.rodzic = this;
        if (liczba < this.wartosc)
        {
            this.lewe = dziecko;
        }
        else
        {
            this.prawe = dziecko;
        }
    }
    public override string ToString()
    {
        return this.wartosc.ToString();
    }
}
class DrzewoBinarne
{
    public Wezel3 korzen;
    public int LiczbaWezlow;
    public DrzewoBinarne(int liczba)
    {
        this.korzen = new Wezel3(liczba);
        this.LiczbaWezlow = 1;
    }

    public void Add(int a)
    {
        Wezel3 rodzic = this.ZnajdzRodzica(a);
        rodzic.Add(a);
    }

    private Wezel3 ZnajdzRodzica(int a)
    {
        var w = this.korzen;

        while (true)
        {
            if (a < w.wartosc)
            {
                if (w.lewe == null)
                {
                    return w;
                }
                else
                {
                    w = w.lewe;
                }
            }
            else
            {
                if (w.prawe == null)
                {
                    return w;
                }
                else
                {
                    w = w.prawe;
                }
            }
        }


    }
}