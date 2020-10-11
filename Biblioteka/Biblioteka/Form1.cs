using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Primerak[] p = {
                (Primerak)(new Knjiga("Bas vam hvala", "Marko Vidojkovic", 2018)),
                (Primerak)(new Knjiga("Na zapadu nista novo", "Remark", 2015)),
                (Primerak)(new Casopis("Nacionalna geografija", 2018, 1)),
                (Primerak)(new Knjiga("Trijumfalna kapija", "Remark", 2015)),
                (Primerak)(new Casopis("Nacionalna geografija", 2019, 2)),
                (Primerak)(new Casopis("Nacionalna geografija", 2017, 3)),
                (Primerak)(new Casopis("Nacionalna geografija", 2017, 4)),
                (Primerak)(new Casopis("Nacionalna geografija", 2019, 5)),
                (Primerak)(new Casopis("Nacionalna geografija", 2019, 6)),
                (Primerak)(new Knjiga("Programiranje - klase i objekti", "Dusa Vukovic", 2018))
            };

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            listBox1.Items.Clear();
            for (int i = 0; i < p.Length; i++)
            {
                for (int j = i + 1; j < p.Length; j++)
                {
                    if (p[j].StarijiOd(p[i]))
                    {
                        Primerak pom = p[i];
                        p[i] = p[j];
                        p[j] = pom;
                    }
                }
            }

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] is Knjiga)
                    listBox1.Items.Add("KNJIGA: " + p[i].Info());
                else if (p[i] is Casopis)
                    listBox1.Items.Add("CASOPIS: " + p[i].Info());
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            listBox1.Items.Clear();
            for (int i = 0; i < p.Length; i++)
            {
                for (int j = i + 1; j < p.Length; j++)
                {
                    if (p[j].MladjiOd(p[i]))
                    {
                        Primerak pom = p[i];
                        p[i] = p[j];
                        p[j] = pom;
                    }
                }
            }

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] is Knjiga)
                    listBox1.Items.Add("KNJIGA: " + p[i].Info());
                else if (p[i] is Casopis)
                    listBox1.Items.Add("CASOPIS: " + p[i].Info());
            }
        }

        }
    }

