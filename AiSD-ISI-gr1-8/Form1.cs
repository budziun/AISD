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

        void A(Wêze³ w)
        {
            MessageBox.Show(w.wartoœæ.ToString());
            for (int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
        }

        // DFS GRAF z cyklami
        string napis = "";
        List<Wêze³2> odwiedzone = new();

        void B(Wêze³2 w)
        {
            odwiedzone.Add(w);
            napis += w.wartoœæ.ToString();
            foreach (var s¹siad in w.s¹siad)
            {
                if (!odwiedzone.Contains(s¹siad))
                {
                    B(s¹siad);
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
    public int wartoœæ;
    public List<Wêze³2> s¹siad = new List<Wêze³2>();

    public Wêze³2(int liczba)
    {
        this.wartoœæ = liczba;
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