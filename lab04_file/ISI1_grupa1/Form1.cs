using System.Net;
using System.Numerics;
using System.Security.Cryptography;

namespace ISI1_grupa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int[] tab = Corvert(tbInput.Text);
            BubbleSort(tab);
            lblWynik.Text = ArrayToString(tab);
        }

        int Fib(int n)
        {
            if (n == 1) return 1;
            if (n == 0) return 0;
            return Fib(n - 1) + Fib(n - 2);
        }
        long Fib2(int n)
        {
            if (n == 0 || n == 1) return n;
            long[] wyrazy = new long[n + 1];
            wyrazy[1] = 1;
            for (int i = 2; i < wyrazy.Length; i++)
            {
                wyrazy[i] = wyrazy[i - 1] + wyrazy[i - 2];
            }
            return wyrazy[n];
        }
        static void BubbleSort(int[] tab)
        {
            int n = tab.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
        }
        int[] Selectsort(int[] tab)
        {
            int min = tab[0];
            int temp = 0;
            int ind = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                min = tab[i];
                ind = i;
                for (int j = i; j < tab.Length; j++)
                {
                    if (tab[j] < min)
                    {
                        min = tab[j];
                        ind = j;
                    }
                }
                temp = tab[i];
                tab[i] = min;
                tab[ind] = temp;
            }
            return tab;
        }
        public int[] Insertsort(int[] tab)
{
            var arrayLength = tab.Length;
    for (int i = 0; i < arrayLength - 1; i++)
    {
        var smallestVal = i;
        for (int j = i + 1; j < arrayLength; j++)
        {
            if (tab[j] < tab[smallestVal])
            {
                smallestVal = j;
            }
        }
        var tempVar = tab[smallestVal];
        tab[smallestVal] = tab[i];
        tab[i] = tempVar;
    }
    return tab;
}
        int[] Corvert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            int[] liczby = new int[liczbyS.Length];
            for(int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }
        static string ArrayToString(int[] tab)
        {
            string wynik = " ";
            for(int i = 0; i < tab.Length; i++)
            {
                wynik += tab[i]+ " ";
            }
            return wynik;
        }
        private void nudLiczbaN_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFib1_Click(object sender, EventArgs e)
        {
            int liczbaN = (int)nudLiczbaN.Value;
            long wynik = Fib(liczbaN);
            MessageBox.Show(wynik.ToString());
        }

        private void btnFib2_Click(object sender, EventArgs e)
        {
            int liczbaN = (int)nudLiczbaN.Value;
            long wynik = Fib2(liczbaN);
            MessageBox.Show(wynik.ToString());
        }

        private void Lbl_Bombel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int[] tab = Corvert(tbInput.Text);
            Selectsort(tab);
            lblWynik.Text = ArrayToString(tab);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int[] tab = Corvert(tbInput.Text);
            Insertsort(tab);
            lblWynik.Text = ArrayToString(tab);
        }
    }
}