using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DokkanCalc : Form
    {
        int apt;
        decimal hpSABoost;
        decimal superValue;
        List<RadioButton> dupeButtons;
        public DokkanCalc()
        {
            InitializeComponent();
            superMult.Text = "Immense";
            saEffect.Text = "None";
            apt = 0;
            output.Text = "0";
            hpSABoost = 0.3M;
            superValue = 0;
            dupeButtons = new List<RadioButton>() { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5 };
        }

      
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cardATK_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }

        private void turnStartPassive_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }

        private void buildupPassive_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }

        private void onSuper_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }
        private void leaderSkill_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }   
        private void kiMult_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }
        private void ki_ValueChanged(object sender, EventArgs e)
        {
            if (smartMode.Checked)
            {
                if (ki.Value >= 18)
                {
                    superMult.Text = "Mega-Colossal";
                }

                else if (ki.Value > 12)
                {
                    superMult.Text = "Colossal";
                }
            }
            recalculateStat();
        }
        private void superMult_SelectedIndexChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }
        private void saEffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (saEffect.Text)
            {
                case ("None"):
                    superValue = 0M;
                    break;

                case ("Raises ATK"):
                    superValue = 30M;
                    break;

                case ("Greatly raises ATK"):
                    superValue = 50M;
                    break;

                case ("Massively raises ATK"):
                    superValue = 100M;
                    break;
            }
            recalculateStat();
        }
        private void linkSum_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }

        private void nukePercentAny_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }
        private void nukeOrbsAny_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }
        private void nukePercentType_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }
        private void nukeOrbsType_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }
        private void nukePercentRainbow_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }
        private void nukeOrbsRainbow_ValueChanged(object sender, EventArgs e)
        {
            recalculateStat();
        }
        private void recalculateStat()
        {
            decimal tempStat = cardATK.Value;
            decimal phase1 = turnStartPassive.Value;

            phase1 += (nukePercentAny.Value * nukeOrbsAny.Value);
            phase1 += (nukePercentType.Value * nukeOrbsType.Value);
            phase1 += (nukePercentRainbow.Value * nukeOrbsRainbow.Value);

            tempStat *= (phase1 / 100M) + 1M;
            Console.WriteLine("Base X Passive: " + tempStat.ToString());

            tempStat *= (buildupPassive.Value / 100M) + 1M;
            Console.WriteLine("X Buildup Passive: " + tempStat.ToString());

            tempStat *= (onSuper.Value / 100M) + 1M;
            Console.WriteLine("X On-Super: " + tempStat.ToString());

            tempStat *= (leaderSkill.Value / 50M) + 1M;
            Console.WriteLine("X Leader Skill: " + tempStat.ToString());

            tempStat *= (linkSum.Value / 100M) + 1M;
            Console.WriteLine("X Links: " + tempStat.ToString());

            // Ki multipliers
            if (ki.Value <= 12) 
                tempStat *= (kiMult.Value / 100M);
            else
            {
                decimal kiPercent = ((200M - kiMult.Value) / 12M);
                tempStat *= ((kiPercent * (ki.Value - 12) + kiMult.Value) / 100M);
            }

            Console.WriteLine("X Ki Multipliers: " + tempStat.ToString() + "\n\n");

            switch (superMult.Text)
            {
                case ("Immense"):
                    tempStat *= 5.05M + hpSABoost + (superValue / 100M);
                    break;

                case ("Colossal"):
                    tempStat *= 4.25M + hpSABoost + (superValue / 100M);
                    break;

                case ("Mega-Colossal"):
                    tempStat *= 5.7M + hpSABoost + (superValue / 100M);
                    break;
            }
            int finalStat = (int)tempStat;
            output.Text = finalStat.ToString("#,#");
        }

        private void advancedSettings_CheckedChanged(object sender, EventArgs e)
        {
            //if (advancedSettings.Checked)
            //{
            //    label8.Visible = true;
            //    label9.Visible = true;
            //    label10.Visible = true;
            //    label11.Visible = true;
            //    label12.Visible = true;

            //    ki.Visible = true;
            //    kiMult.Visible = true;
            //    dupeButtonsPanel.Visible = true;
            //    saEffect.Visible = true;
            //    linkSum.Visible = true;
            //}
            //else
            //{             
            //    label8.Visible = false;
            //    label9.Visible = false;
            //    label10.Visible = false;
            //    label11.Visible = false;
            //    label12.Visible = false;

            //    ki.Visible = false;
            //    kiMult.Visible = false;
            //    dupeButtonsPanel.Visible = false;
            //    saEffect.Visible = false;
            //    linkSum.Visible = false;
            //}

            tableLayoutPanel3.Visible = !tableLayoutPanel3.Visible;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                hpSABoost = 0.3M;
            else if (radioButton2.Checked)
                hpSABoost = 0.35M;
            else if (radioButton3.Checked)
                hpSABoost = 0.4M;
            else if (radioButton4.Checked)
                hpSABoost = 0.7M;
            else
                hpSABoost = 0.75M;
            recalculateStat();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void smartMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nukeMenu_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel4.Visible = !tableLayoutPanel4.Visible;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
