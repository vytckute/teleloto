using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teleloto
{
    public partial class Form1 : Form
    {


        int[] melyni = new int[5];
        int[] juodi = new int[5];
        int[] raudoni = new int[5];
        int[] geltoni = new int[5];
        int[] zali = new int[5];
        public readonly List<int> kamuoliukai = new List<int>();
        public readonly List<int> mas = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Suranda 5 unikalius kammuoliukus tam tikruose reziuose
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int[] Atrenka_kamuoliukus(int a, int b)
        {
            int[] temporary = new int[5];
            Random rng = new Random();
            int i = 0;
            while (i < 5)
            {
                int temp = rng.Next(a, b);
                int flag = 0;
                foreach (int t in temporary)
                {
                    if (t == temp)
                    { flag++; }
                }
                if (flag == 0)
                {
                    temporary[i] = temp;
                    i++;
                }

            }
            return temporary;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            melyni = Atrenka_kamuoliukus(1, 16);

            M1.Text = melyni[0].ToString();
            M2.Text = melyni[1].ToString();
            M3.Text = melyni[2].ToString();
            M4.Text = melyni[3].ToString();
            M5.Text = melyni[4].ToString();


            juodi = Atrenka_kamuoliukus(16, 31);

            J1.Text = juodi[0].ToString();
            J2.Text = juodi[1].ToString();
            J3.Text = juodi[2].ToString();
            J4.Text = juodi[3].ToString();
            J5.Text = juodi[4].ToString();


            raudoni = Atrenka_kamuoliukus(31, 46);

            R1.Text = raudoni[0].ToString();
            R2.Text = raudoni[1].ToString();
            R3.Text = raudoni[2].ToString();
            R4.Text = raudoni[3].ToString();
            R5.Text = raudoni[4].ToString();


            geltoni = Atrenka_kamuoliukus(46, 61);

            G1.Text = geltoni[0].ToString();
            G2.Text = geltoni[1].ToString();
            G3.Text = geltoni[2].ToString();
            G4.Text = geltoni[3].ToString();
            G5.Text = geltoni[4].ToString();



            zali = Atrenka_kamuoliukus(61, 76);

            Z1.Text = zali[0].ToString();
            Z2.Text = zali[1].ToString();
            Z3.Text = zali[2].ToString();
            Z4.Text = zali[3].ToString();
            Z5.Text = zali[4].ToString();

            mas.Add(melyni[0]);
            mas.Add(melyni[1]);
            mas.Add(melyni[2]);
            mas.Add(melyni[3]);
            mas.Add(melyni[4]);
            mas.Add(juodi[0]);
            mas.Add(juodi[1]);
            mas.Add(juodi[2]);
            mas.Add(juodi[3]);
            mas.Add(juodi[4]);
            mas.Add(geltoni[0]);
            mas.Add(geltoni[1]);
            mas.Add(geltoni[2]);
            mas.Add(geltoni[3]);
            mas.Add(geltoni[4]);
            mas.Add(raudoni[0]);
            mas.Add(raudoni[1]);
            mas.Add(raudoni[2]);
            mas.Add(raudoni[3]);
            mas.Add(raudoni[4]);
            mas.Add(zali[0]);
            mas.Add(zali[1]);
            mas.Add(zali[2]);
            mas.Add(zali[3]);
            mas.Add(zali[4]);
        }

        private void SuIntegravimas(int istrauktas_kamuoliukas)
        {
            if (istrauktas_kamuoliukas < 16)
            {
                if (melyni[0] == istrauktas_kamuoliukas)
                {
                    M1.BackColor = Color.Green;
                }
                else if (melyni[1] == istrauktas_kamuoliukas)
                {
                    M2.BackColor = Color.Green;
                }
                else if (melyni[2] == istrauktas_kamuoliukas)
                {
                    M3.BackColor = Color.Green;
                }
                else if (melyni[3] == istrauktas_kamuoliukas)
                {
                    M4.BackColor = Color.Green;
                }
                else if (melyni[4] == istrauktas_kamuoliukas)
                {
                    M5.BackColor = Color.Green;
                }
            }
            else if (istrauktas_kamuoliukas > 31 && istrauktas_kamuoliukas < 46)
            {
                if (raudoni[0] == istrauktas_kamuoliukas)
                {
                    R1.BackColor = Color.Green;
                }
                else if (raudoni[1] == istrauktas_kamuoliukas)
                {
                    R2.BackColor = Color.Green;
                }
                else if (raudoni[2] == istrauktas_kamuoliukas)
                {
                    R3.BackColor = Color.Green;
                }
                else if (raudoni[3] == istrauktas_kamuoliukas)
                {
                    R4.BackColor = Color.Green;
                }
                else if (raudoni[4] == istrauktas_kamuoliukas)
                {
                    R5.BackColor = Color.Green;
                }

            }
            else if (istrauktas_kamuoliukas > 16 && istrauktas_kamuoliukas < 31)
            {
                if (juodi[0] == istrauktas_kamuoliukas)
                {
                    J1.BackColor = Color.Green;
                }
                else if (juodi[1] == istrauktas_kamuoliukas)
                {
                    J2.BackColor = Color.Green;
                }
                else if (juodi[2] == istrauktas_kamuoliukas)
                {
                    J3.BackColor = Color.Green;
                }
                else if (juodi[3] == istrauktas_kamuoliukas)
                {
                    J4.BackColor = Color.Green;
                }
                else if (juodi[4] == istrauktas_kamuoliukas)
                {
                    J5.BackColor = Color.Green;
                }

            }
            else if (istrauktas_kamuoliukas > 46 && istrauktas_kamuoliukas < 61)
            {
                if (geltoni[0] == istrauktas_kamuoliukas)
                {
                    G1.BackColor = Color.Green;
                }
                else if (geltoni[1] == istrauktas_kamuoliukas)
                {
                    G2.BackColor = Color.Green;
                }
                else if (geltoni[2] == istrauktas_kamuoliukas)
                {
                    G3.BackColor = Color.Green;
                }
                else if (geltoni[3] == istrauktas_kamuoliukas)
                {
                    G4.BackColor = Color.Green;
                }
                else if (geltoni[4] == istrauktas_kamuoliukas)
                {
                    G5.BackColor = Color.Green;
                }

            }
            else if (istrauktas_kamuoliukas > 61 && istrauktas_kamuoliukas < 71)
            {
                if (zali[0] == istrauktas_kamuoliukas)
                {
                    Z1.BackColor = Color.Green;
                }
                else if (zali[1] == istrauktas_kamuoliukas)
                {
                    Z2.BackColor = Color.Green;
                }
                else if (zali[2] == istrauktas_kamuoliukas)
                {
                    Z3.BackColor = Color.Green;
                }
                else if (zali[3] == istrauktas_kamuoliukas)
                {
                    Z4.BackColor = Color.Green;
                }
                else if (zali[4] == istrauktas_kamuoliukas)
                {
                    Z5.BackColor = Color.Green;
                }

            }

        }

        //  }



        private void J1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //   List<int> kamuoliukai = new List<int>();
            Random rng = new Random();
            int i = 0;
            while (i < 50)
            {
                int temp = rng.Next(1, 76);
                int flag = 0;
                foreach (int k in kamuoliukai)
                {
                    if (k == temp)
                    { flag++; }
                }
                if (flag == 0)
                {
                    kamuoliukai.Add(temp);
                    i++;
                    string jjjj = textBox26.Text;
                    jjjj += " " + temp.ToString();
                    SuIntegravimas(temp);
                    textBox26.Text = jjjj;
                }

            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
         //   label3.Text = "skaiciuoju";
            int tikrina=0;

            
            int bilietu = 0;
            while (tikrina <25)
            {tikrina = 0;
                for (int z = 0; z < 50; z++)
                { 
                    for (int k = 0; k < 25; k++)
                    {
                        if (kamuoliukai[z] == mas[k])
                        {
                            tikrina++;
                        }

                    }
                    
                }bilietu++;
                mas.Clear();
                button1_Click(sender, e);
      //          button2_Click(sender, e);
                
            }
            button2_Click(sender, e);
         //   label3.Text = " ";
            label1.Text = Convert.ToString(bilietu);
        }

    }
}

