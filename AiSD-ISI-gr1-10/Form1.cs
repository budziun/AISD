
namespace AiSD_ISI_gr1_10
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
    public int GetLiczbaDzieci()
    {
        int wynik = 0;
        if (this.lewe != null)
            wynik++;
        if (this.prawe != null)
            wynik++;
        return wynik;
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

    private Wezel3 Znajdz(int liczba)
    {
        var w = this.korzen;
        while (true)
        {
            if (liczba == w.wartosc)
            {
                return w;
            }
            if (liczba < w.wartosc)
            {
                if (w.lewe == null)
                {
                    return null;
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
                    return null;
                }
                else
                {
                    w = w.prawe;
                }
            }
        }
    }
    public Wezel3 ZnajdzMin(Wezel3 w)
    {
        while (w.lewe != null)
        {
            w = w.lewe;
        }

        return w;
    }
    public Wezel3 ZnajdzMax(Wezel3 w)
    {
        while (w.prawe != null)
        {
            w = w.prawe;
        }

        return w;
    }
    public Wezel3 Nastepnik(Wezel3 w)
    {
        if (w.prawe != null)
        {
            return this.ZnajdzMin(w.prawe);
        }
        while (w.rodzic != null)
        {
            if (w.rodzic.lewe == w)
            {
                return w.rodzic;
            }
            else
            {
                w = w.rodzic;
            }
        }
        return null;
    }
    Wezel3 Usun(Wezel3 w)
    {
        switch (w.GetLiczbaDzieci())
        {
            case 0:
                w = this.UsunGdy0Dzieci(w);
                break;
            case 1:
                w = this.UsunGdy1Dziecko(w);
                break;
            case 2:
                w = this.UsunGdy2Dzieci(w);
                break;
        }
        return w;
    }
    Wezel3 UsunGdy0Dzieci(Wezel3 w)
    {
        if (w.rodzic == null)
        {
            this.korzen = null;
            return w;
        }
        if (w.rodzic.lewe == w)
            w.rodzic.lewe = null;
        else
            w.rodzic.prawe = null;
        w.rodzic = null;
        return w;
    }
    Wezel3 UsunGdy1Dziecko(Wezel3 w)
    {
        Wezel3 dziecko = null;
        if (w.lewe != null)
        {
            dziecko = w.lewe;
            w.lewe = null;
        }
        else
        {
            dziecko = w.prawe;
            w.prawe = null;
        }
        dziecko.rodzic = w.rodzic;
        if (w.rodzic == null)
        {
            this.korzen = null;
            return w;
        }
        if (w.rodzic.lewe == w)
        {
            w.rodzic.lewe = dziecko;
        }
        else
        {
            w.rodzic.prawe = dziecko;
        }
        w.rodzic = null;
        return w;
    }
    Wezel3 UsunGdy2Dzieci(Wezel3 w)
    {
        var zamiennik = this.Nastepnik(w);
        if (zamiennik.GetLiczbaDzieci() == 0)
            zamiennik = this.UsunGdy0Dzieci(zamiennik);
        else
            zamiennik = this.UsunGdy1Dziecko(zamiennik);

        if (w.rodzic != null)
        {
            if (w.rodzic.lewe == w)
                w.rodzic.lewe = zamiennik;
            else
                w.rodzic.prawe = zamiennik;
        }
        zamiennik.rodzic = w.rodzic;
        w.rodzic = null;

        return zamiennik;
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
    // lab10 do zrobienia
    //dijkstra algorytm - moze byc na egzaminie lub kolosie
    public class Wezel4
    {
        public int wartosc;
        public List<Wezel4> dzieci = new List<Wezel4>();

        public Wezel4(int wartosc)
        {
            this.wartosc = wartosc;
        }
    }
    public class Krawedz
    {
        public int waga;
        public Wezel4 poczatek;
        public Wezel4 koniec;
    }
    public class Graf
    {
        List<Wezel4> wezly = new List<Wezel4>();
        List<Krawedz> krawedzie = new List<Krawedz>();

        public Dictionary<Wezel4, int> Dijkstra(Wezel4 start)
        {
            Dictionary<Wezel4, int> odleglosci = new Dictionary<Wezel4, int>();
            Dictionary<Wezel4, Wezel4> poprzednicy = new Dictionary<Wezel4, Wezel4>();
            List<Wezel4> niesprawdzoneWezly = new List<Wezel4>();

            foreach (var wezel in wezly)
            {
                if (wezel == start)
                    odleglosci[wezel] = 0;
                else
                    odleglosci[wezel] = int.MaxValue;

                poprzednicy[wezel] = null;
                niesprawdzoneWezly.Add(wezel);
            }

            void Visit(Wezel4 w)
            {
                MessageBox.Show(w.wartosc.ToString());
                foreach (var dziecko in w.dzieci)
                {
                    int nowaOdleglosc = odleglosci[w] + dziecko.wartosc;
                    if (nowaOdleglosc < odleglosci[dziecko])
                    {
                        odleglosci[dziecko] = nowaOdleglosc;
                        poprzednicy[dziecko] = w;
                    }
                }
            }

            while (niesprawdzoneWezly.Count > 0)
            {
                Wezel4 aktualnyWezel = ZnajdzWezelZMinOdl(odleglosci, niesprawdzoneWezly);
                niesprawdzoneWezly.Remove(aktualnyWezel);
                Visit(aktualnyWezel);
            }

            return odleglosci;
        }

        private Wezel4 ZnajdzWezelZMinOdl(Dictionary<Wezel4, int> odleglosci, List<Wezel4> niesprawdzoneWezly)
        {
            Wezel4 minWezel = null;
            foreach (var wezel in niesprawdzoneWezly)
            {
                if (minWezel == null || odleglosci[wezel] < odleglosci[minWezel])
                    minWezel = wezel;
            }
            return minWezel;
        }
    }


}
