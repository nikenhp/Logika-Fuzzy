using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
Sangat Pendek   : 0 - 120
Pendek          : 115 - 145
Sedang          : 140 - 165
Tinggi          : 160 - 185
Sangat Tinggi   : >= 180

Sangat Kurus   : 0 - 45
Kurus          : 40 - 55
Biasa          : 50 - 65
Berat          : 60 - 85
Sangat Berat   : >= 80 

                Sangat kurus	Kurus	Biasa	Berat	Sangat Berat
Sangat Pendek	SS				S		AS		TS		TS
Pendek			S				SS		S		AS		TS
Sedang			AS				SS		SS		AS		TS
Tinggi			TS				S		SS		S		TS
Sangat Tinggi	TS				AS		SS		S		AS

*/
namespace Fuzzy
{
    public partial class Form1 : Form
    {
        //Range untuk nilai GPA
        double[] gpa = { 0, 2.2, 3.0, 3.8 };
        //Range untuk nilai GRE
        double[] gre = { 0, 800, 1200, 1800 };
        //Range untuk nilai tinggi badan
        double[] tb = { 0, 115, 120, 140, 145, 160, 165, 180, 185 };
        //Range untuk nilai berat badan
        double[] bb = { 0, 40, 45, 50, 55, 60, 65, 80, 85 };
        int[][] status = {
                                 new int[5]{1, 2, 3, 4, 4},
                                 new int[5]{2, 1, 2, 3, 4},
                                 new int[5]{3, 1, 1, 3, 4}, 
                                 new int[5]{4, 2, 1, 2, 4}, 
                                 new int[5]{4, 3, 1, 2, 3}
                             };
        double max;
        double sk, k, kbs, brt, sbrt;
        double sp, p, psdg, tg, stg;
        int i, j, sts;

        public Form1()
        {
            InitializeComponent();
        }

        double sangatKurus(double b)
        {
            if (b >= bb[0] && b <= bb[1])
            {
                return 1;
            }
            else if (b > bb[1] && b < bb[2])
            {
                return (bb[2] - b) / (bb[2] - bb[1]);
            }
            else
            {
                return 0;
            }
        }

        double kurus(double b)
        {
            if (b > bb[1] && b < bb[2])
            {
                return (b - bb[1]) / (bb[2] - bb[1]);
            }
            else if (b >= bb[2] && b <= bb[3])
            {
                return 1;
            }
            else if (b > bb[3] && b < bb[4])
            {
                return (bb[4] - b) / (bb[4] - bb[3]);
            }
            else
            {
                return 0;
            }
        }

        private void inputTinggi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxresult_TextChanged(object sender, EventArgs e)
        {

        }

        double biasa(double b)
        {
            if (b > bb[3] && b < bb[4])
            {
                return (b - bb[3]) / (bb[4] - bb[3]);
            }
            else if (b >= bb[4] && b <= bb[5])
            {
                return 1;
            }
            else if (b > bb[5] && b < bb[6])
            {
                return (bb[6] - b) / (bb[6] - bb[5]);
            }
            else
            {
                return 0;
            }
        }

        double berat(double b)
        {
            if (b > bb[5] && b < bb[6])
            {
                return (b - bb[5]) / (bb[6] - bb[5]);
            }
            else if (b >= bb[6] && b <= bb[7])
            {
                return 1;
            }
            else if (b > bb[7] && b < bb[8])
            {
                return (bb[8] - b) / (bb[8] - bb[7]);
            }
            else
            {
                return 0;
            }
        }

        double sangatBerat(double b)
        {
            if (b > bb[7] && b < bb[8])
            {
                return (b - bb[7]) / (bb[8] - bb[7]);
            }
            else if (b >= bb[8])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        double sangatPendek(double t)
        {
            if (t >= tb[0] && t <= tb[1])
            {
                return 1;
            }
            else if (t > tb[1] && t < tb[2])
            {
                return (tb[2] - t) / (tb[2] - tb[1]);
            }
            else
            {
                return 0;
            }
        }

        double pendek(double t)
        {
            if (t > tb[1] && t < tb[2])
            {
                return (t - tb[1]) / (tb[2] - tb[1]);
            }
            else if (t >= tb[2] && t <= tb[3])
            {
                return 1;
            }
            else if (t > tb[3] && t < tb[4])
            {
                return (tb[4] - t) / (tb[4] - tb[3]);
            }
            else
            {
                return 0;
            }
        }

        double sedang(double t)
        {
            if (t > tb[3] && t < tb[4])
            {
                return (t - tb[3]) / (tb[4] - tb[3]);
            }
            else if (t >= tb[4] && t <= tb[5])
            {
                return 1;
            }
            else if (t > tb[5] && t < tb[6])
            {
                return (tb[6] - t) / (tb[6] - tb[5]);
            }
            else
            {
                return 0;
            }
        }

        double tinggi(double t)
        {
            if (t > tb[5] && t < tb[6])
            {
                return (t - tb[5]) / (tb[6] - tb[5]);
            }
            else if (t >= tb[6] && t <= tb[7])
            {
                return 1;
            }
            else if (t > tb[7] && t < tb[8])
            {
                return (tb[8] - t) / (tb[8] - tb[7]);
            }
            else
            {
                return 0;
            }
        }

        double sangatTinggi(double t)
        {
            if (t > tb[7] && t < tb[8])
            {
                return (t - tb[7]) / (tb[8] - tb[7]);
            }
            else if (t >= tb[8])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCekKesehatan_Click(object sender, EventArgs e)
        {
            double t = double.Parse(inputTinggi.Text);
            double b = double.Parse(inputBerat.Text);
            double[,] anggota = new double[5, 5];

            sk      = sangatKurus(b);
            k       = kurus(b);
            kbs     = biasa(b);
            brt     = berat(b);
            sbrt    = sangatBerat(b);

            sp      = sangatPendek(t);
            p       = pendek(t);
            psdg    = sedang(t);
            tg      = tinggi(t);
            stg     = sangatTinggi(t);
            
            if (sk <= sp)
                anggota[0, 0] = sk;
            else
                anggota[0, 0] = sp;
            if (k <= sp)
                anggota[0, 1] = k;
            else
                anggota[0, 1] = sp;
            if (kbs <= sp)
                anggota[0, 2] = kbs;
            else
                anggota[0, 2] = sp;
            if (brt <= sp)
                anggota[0, 3] = brt;
            else
                anggota[0, 3] = sp;
            if (sbrt <= sp)
                anggota[0, 4] = sbrt;
            else
                anggota[0, 4] = sp;

            if (sk <= p)
                anggota[1, 0] = sk;
            else
                anggota[1, 0] = p;
            if (k <= p)
                anggota[1, 1] = k;
            else
                anggota[1, 1] = p;
            if (kbs <= p)
                anggota[1, 2] = kbs;
            else
                anggota[1, 2] = p;
            if (brt <= p)
                anggota[1, 3] = brt;
            else
                anggota[1, 3] = p;
            if (sbrt <= p)
                anggota[1, 4] = sbrt;
            else
                anggota[1, 4] = p;

            if (sk <= psdg)
                anggota[2, 0] = sk;
            else
                anggota[2, 0] = psdg;
            if (k <= psdg)
                anggota[2, 1] = k;
            else
                anggota[2, 1] = psdg;
            if (kbs <= psdg)
                anggota[2, 2] = kbs;
            else
                anggota[2, 2] = psdg;
            if (brt <= psdg)
                anggota[2, 3] = brt;
            else
                anggota[2, 3] = psdg;
            if (sbrt <= psdg)
                anggota[2, 4] = sbrt;
            else
                anggota[2, 4] = psdg;

            if (sk <= tg)
                anggota[3, 0] = sk;
            else
                anggota[3, 0] = tg;
            if (k <= tg)
                anggota[3, 1] = k;
            else
                anggota[3, 1] = tg;
            if (kbs <= psdg)
                anggota[3, 2] = kbs;
            else
                anggota[3, 2] = tg;
            if (brt <= psdg)
                anggota[3, 3] = brt;
            else
                anggota[3, 3] = tg;
            if (sbrt <= tg)
                anggota[3, 4] = sbrt;
            else
                anggota[3, 4] = tg;

            if (sk <= stg)
                anggota[4, 0] = sk;
            else
                anggota[4, 0] = stg;
            if (k <= stg)
                anggota[4, 1] = k;
            else
                anggota[4, 1] = stg;
            if (kbs <= stg)
                anggota[4, 2] = kbs;
            else
                anggota[4, 2] = stg;
            if (brt <= stg)
                anggota[4, 3] = brt;
            else
                anggota[4, 3] = stg;
            if (sbrt <= stg)
                anggota[4, 4] = sbrt;
            else
                anggota[4, 4] = stg;

                    

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    textBoxresult.AppendText("Anggota index ke [" + i + ","+ j + "] = " + anggota[i, j]);
                    textBoxresult.AppendText("\n");
                }
            }

            max = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (anggota[i, j] >= max)
                    {
                        max = anggota[i, j];
                        sts = status[i][j];
                    }
                }
            }
            textBoxresult.AppendText("\n");

            if (sts == 1)
                MessageBox.Show("Status Kesehatan Anda :\n\nSangat Sehat");
            else if (sts == 2)
                MessageBox.Show("Status Kesehatan Anda :\n\nSehat");
            else if (sts == 3)
                MessageBox.Show("Status Kesehatan Anda :\n\nAgak Sehat");
            else
                MessageBox.Show("Status Kesehatan Anda :\n\nKurang Sehat");
        }
    }
}
