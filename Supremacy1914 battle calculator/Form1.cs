using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Supremacy1914_battle_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e); //to refresh combo boxes at the start of form
            comboBox2_SelectedIndexChanged(sender, e);
        }

        internal String calculatebotstring()
        {
            string botstring = "!";
            if (comboBox1.Text.ToLower() == "land")
            {
                botstring += "1";
            }
            if (comboBox1.Text.ToLower() == "sea")
            {
                botstring += "2";
            }
            if (comboBox1.Text.ToLower() == "air")
            {
                botstring += "3";
            }
            if (comboBox2.Text.ToLower() == "land")
            {
                botstring += "1";
            }
            if (comboBox2.Text.ToLower() == "sea")
            {
                botstring += "2";
            }
            if (comboBox2.Text.ToLower() == "air")
            {
                botstring += "3";
            }
            if (comboBox3.Text != "") //start by adding combobox3 units
            {
                if (textBox1.Text != "") //amount is present
                {
                    if (textBox9.Text != "") //morale values are present
                    {
                        //lets find out the type of unit
                        string unittype = stringtounit(comboBox3.Text);
                        string amount = textBox1.Text;
                        string morale = textBox9.Text;

                        botstring += " " + amount + unittype + morale;
                    }
                }
            }
            if (comboBox4.Text != "")
            {
                if (textBox3.Text != "") //amount is present
                {
                    if (textBox7.Text != "") //morale values are present
                    {
                        //lets find out the type of unit
                        string unittype = stringtounit(comboBox4.Text);
                        string amount = textBox3.Text;
                        string morale = textBox7.Text;

                        botstring += " " + amount + unittype + morale;
                    }
                }
            }
            if (comboBox5.Text != "")
            {
                if (textBox2.Text != "") //amount is present
                {
                    if (textBox8.Text != "") //morale values are present
                    {
                        //lets find out the type of unit
                        string unittype = stringtounit(comboBox5.Text);
                        string amount = textBox2.Text;
                        string morale = textBox8.Text;

                        botstring += " " + amount + unittype + morale;
                    }
                }
            }

            if (textBox15.Text != "" || textBox13.Text != "" || textBox14.Text != "") //if any value of troops in defenders
            {
                botstring += "."; //add the vs string
            }

            if (comboBox8.Text != "")
            {
                if (textBox15.Text != "") //amount is present
                {
                    if (textBox12.Text != "") //morale values are present
                    {
                        //lets find out the type of unit
                        string unittype = stringtounit(comboBox8.Text);
                        string amount = textBox15.Text;
                        string morale = textBox12.Text;

                        botstring += " " + amount + unittype + morale;
                    }
                }
            }
            if (comboBox7.Text != "")
            {
                if (textBox13.Text != "") //amount is present
                {
                    if (textBox10.Text != "") //morale values are present
                    {
                        //lets find out the type of unit
                        string unittype = stringtounit(comboBox7.Text);
                        string amount = textBox13.Text;
                        string morale = textBox10.Text;

                        botstring += " " + amount + unittype + morale;
                    }
                }
            }
            if (comboBox6.Text != "")
            {
                if (textBox14.Text != "") //amount is present
                {
                    if (textBox11.Text != "") //morale values are present
                    {
                        //lets find out the type of unit
                        string unittype = stringtounit(comboBox6.Text);
                        string amount = textBox14.Text;
                        string morale = textBox11.Text;

                        botstring += " " + amount + unittype + morale;
                    }
                }
            }
            if (comboBox9.Text.ToLower() != "none")
            {
                if (comboBox9.Text.ToLower() == "level 1")
                {
                    botstring += " 1F";
                }
                if (comboBox9.Text.ToLower() == "level 2")
                {
                    botstring += " 2F";
                }
                if (comboBox9.Text.ToLower() == "level 3")
                {
                    botstring += " 3F";
                }
                if (comboBox9.Text.ToLower() == "level 4")
                {
                    botstring += " 4F";
                }
                if (comboBox9.Text.ToLower() == "level 5")
                {
                    botstring += " 5F";
                }
            }
            return botstring;
        }

        internal String stringtounit(String str)
        {
            if (str.ToLower() == "infantry")
            {
                return "inf";
            }
            if (str.ToLower() == "artillery")
            {
                return "art";
            }
            if (str.ToLower() == "armoured car")
            {
                return "ac";
            }
            if (str.ToLower() == "cavalry")
            {
                return "cav";
            }
            if (str.ToLower() == "railgun")
            {
                return "rg";
            }
            if (str.ToLower() == "tank")
            {
                return "t";
            }
            if (str.ToLower() == "heavy tank")
            {
                return "ht";
            }
            if (str.ToLower() == "balloon")
            {
                return "bal";
            }
            if (str.ToLower() == "light cruiser")
            {
                return "lc";
            }
            if (str.ToLower() == "battleship")
            {
                return "bs";
            }
            if (str.ToLower() == "submarine")
            {
                return "sub";
            }
            if (str.ToLower() == "fighter")
            {
                return "f";
            }
            if (str.ToLower() == "bomber")
            {
                return "b";
            }
            return String.Empty;
        }

        internal void defenders_comboboxitemadd(String item)
        {
            comboBox8.Items.Add(item);
            comboBox7.Items.Add(item);
            comboBox6.Items.Add(item);
        }

        internal void defenders_clearcombobox()
        {
            comboBox8.Items.Clear();
            comboBox7.Items.Clear();
            comboBox6.Items.Clear();
        }

        internal void attackers_comboboxitemadd(String item)
        {
            comboBox3.Items.Add(item);
            comboBox4.Items.Add(item);
            comboBox5.Items.Add(item);
        }

        internal void attackers_clearcombobox()
        {
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox9.Text = trackBar1.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox7.Text = trackBar3.Value.ToString();

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox8.Text = trackBar2.Value.ToString();
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            textBox12.Text = trackBar6.Value.ToString();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            textBox10.Text = trackBar5.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            textBox11.Text = trackBar4.Value.ToString();
        }

        //All list
        /*
            Infantry
            Armoured Car
            Cavalry
            Artillery
            Tank
            Heavytank
            Railgun

            Light Cruiser
            Submarine
            Battleship

            Balloon (is a land unit)
            Fighter
            Bomber
         
         */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToLower() == "land")
            {
                attackers_clearcombobox();
                attackers_comboboxitemadd("Infantry");
                attackers_comboboxitemadd("Armoured Car");
                attackers_comboboxitemadd("Cavalry");
                attackers_comboboxitemadd("Artillery");
                attackers_comboboxitemadd("Tank");
                attackers_comboboxitemadd("Heavytank");
                attackers_comboboxitemadd("Railgun");
                attackers_comboboxitemadd("Balloon (is a land unit)");
            }
            if (comboBox1.Text.ToLower() == "sea")
            {
                attackers_clearcombobox();
                attackers_comboboxitemadd("Light Cruiser");
                attackers_comboboxitemadd("Submarine");
                attackers_comboboxitemadd("Battleship");
            }
            if (comboBox1.Text.ToLower() == "air")
            {
                attackers_clearcombobox();
                attackers_comboboxitemadd("Fighter");
                attackers_comboboxitemadd("Bomber");
                attackers_comboboxitemadd("Cavalry");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text.ToLower() == "land")
            {
                defenders_clearcombobox();
                defenders_comboboxitemadd("Infantry");
                defenders_comboboxitemadd("Armoured Car");
                defenders_comboboxitemadd("Cavalry");
                defenders_comboboxitemadd("Artillery");
                defenders_comboboxitemadd("Tank");
                defenders_comboboxitemadd("Heavytank");
                defenders_comboboxitemadd("Railgun");
                defenders_comboboxitemadd("Balloon (is a land unit)");
            }
            if (comboBox2.Text.ToLower() == "sea")
            {
                defenders_clearcombobox();
                defenders_comboboxitemadd("Light Cruiser");
                defenders_comboboxitemadd("Submarine");
                defenders_comboboxitemadd("Battleship");
            }
            if (comboBox2.Text.ToLower() == "air")
            {
                defenders_clearcombobox();
                defenders_comboboxitemadd("Fighter");
                defenders_comboboxitemadd("Bomber");
                defenders_comboboxitemadd("Cavalry");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox4.Text = calculatebotstring();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(textBox9.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            trackBar3.Value = Convert.ToInt32(textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            trackBar2.Value = Convert.ToInt32(textBox8.Text);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            trackBar6.Value = Convert.ToInt32(textBox12.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            trackBar5.Value = Convert.ToInt32(textBox10.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            trackBar4.Value = Convert.ToInt32(textBox11.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //File.WriteAllText();
            string settings = String.Empty;
            settings += comboBox1.Text + "," + comboBox2.Text + "," + comboBox3.Text + "," + comboBox4.Text + "," + comboBox5.Text + "," + comboBox6.Text + "," + comboBox7.Text + "," + comboBox8.Text + "," + comboBox9.Text;
            settings += ".." + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox7.Text + "," + textBox8.Text + "," + textBox9.Text + "," + textBox10.Text + "," + textBox11.Text + "," + textBox12.Text + "," + textBox13.Text + "," + textBox14.Text + "," + textBox15.Text;
            File.WriteAllText("settings.cfg", settings);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string settings = File.ReadAllText("settings.cfg");
            string combos = settings.Split(new string[] { ".." }, StringSplitOptions.None)[0];
            string texts = settings.Split(new string[] { ".." }, StringSplitOptions.None)[1];
            string[] comboz = combos.Split(',');
            string[] textz = texts.Split(',');

            int a = 0;
            comboBox1.Text = comboz[a];
            a++;
            comboBox2.Text = comboz[a];
            a++;
            comboBox3.Text = comboz[a];
            a++;
            comboBox4.Text = comboz[a];
            a++;
            comboBox5.Text = comboz[a];
            a++;
            comboBox6.Text = comboz[a];
            a++;
            comboBox7.Text = comboz[a];
            a++;
            comboBox8.Text = comboz[a];
            a++;
            comboBox9.Text = comboz[a];
            a = 0;
            textBox1.Text = textz[a];
            a++;
            textBox2.Text = textz[a];
            a++;
            textBox3.Text = textz[a];
            a++;
            textBox7.Text = textz[a];
            a++;
            textBox8.Text = textz[a];
            a++;
            textBox9.Text = textz[a];
            a++;
            textBox10.Text = textz[a];
            a++;
            textBox11.Text = textz[a];
            a++;
            textBox12.Text = textz[a];
            a++;
            textBox13.Text = textz[a];
            a++;
            textBox14.Text = textz[a];
            a++;
            textBox15.Text = textz[a];
            a++;
        }
    }
}
