using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public delegate void ColorChangeEventHandler();

    public partial class speelRij : UserControl
    {
        public event ColorChangeEventHandler ColorChanged;

        private void OnColorChange()
        {
            if(ColorChanged != null)
            {
                ColorChanged.Invoke();
            }
        }
       
        public speelRij()
        {
            InitializeComponent();
        }
      
        private void rbtnA_Click(object sender, EventArgs e)//zorgt dat de achtergrondkleur van de eerste button verandert
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)//cases van de switch zijn de achtergrond kleur van de geklikte button
            {
                case "Crimson": ctrl.BackColor = Color.Blue; break;//als je op rood klik wordt de kleur blauw
                case "Green": ctrl.BackColor = Color.Orange; break;//als je op groen klikt wordt de kleur Geel
                case "Orange": ctrl.BackColor = Color.Crimson; break;//als je op geel klikt wordt de kleur Rood
                case "Blue": ctrl.BackColor = Color.Green; break;//als je op blauw klikt wordt de kleur Groen
                default: ctrl.BackColor = Color.Crimson; break;//bij eerste klik kleur word rood
            }
            rbtnB.Enabled = true;//activeert button B van de usercontrol
        }
        private void rbtnB_Click(object sender, EventArgs e)//zorgt dat de achtergrondkleur van de 2e button verandert
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)//cases van de switch zijn de achtergrond kleur van de geklikte button
            {
                case "Crimson": ctrl.BackColor = Color.Blue; break;//als je op rood klik wordt de kleur blauw
                case "Green": ctrl.BackColor = Color.Orange; break;//als je op groen klikt wordt de kleur Geel
                case "Orange": ctrl.BackColor = Color.Crimson; break;//als je op geel klikt wordt de kleur Rood
                case "Blue": ctrl.BackColor = Color.Green; break;//als je op blauw klikt wordt de kleur Groen
                default: ctrl.BackColor = Color.Crimson; break;//bij eerste klik kleur word rood
            }
            rbtnC.Enabled = true;//activeert buuton C van de usercontrol
        }
        private void rbtnC_Click(object sender, EventArgs e)//zorgt dat de achtergrondkleur van de 3e button verandert
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)//cases van de switch zijn de achtergrond kleur van de geklikte button
            {
                case "Crimson": ctrl.BackColor = Color.Blue; break;//als je op rood klik wordt de kleur blauw
                case "Green": ctrl.BackColor = Color.Orange; break;//als je op groen klikt wordt de kleur Geel
                case "Orange": ctrl.BackColor = Color.Crimson; break;//als je op geel klikt wordt de kleur Rood
                case "Blue": ctrl.BackColor = Color.Green; break;//als je op blauw klikt wordt de kleur Groen
                default: ctrl.BackColor = Color.Crimson; break;//bij eerste klik kleur word rood
            }
            rbtnD.Enabled = true;//activeert button D van de usercontrol
        }
        private void rbtnD_Click(object sender, EventArgs e)//zorgt dat de achtergrondkleur van de 4e button verandert
        {
            OnColorChange();//event
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)//cases van de switch zijn de achtergrond kleur van de geklikte button
            {
                case "Crimson": ctrl.BackColor = Color.Blue; break;//als je op rood klik wordt de kleur blauw
                case "Green": ctrl.BackColor = Color.Orange; break;//als je op groen klikt wordt de kleur Geel
                case "Orange": ctrl.BackColor = Color.Crimson; break;//als je op geel klikt wordt de kleur Rood
                case "Blue": ctrl.BackColor = Color.Green; break;//als je op blauw klikt wordt de kleur Groen
                default: ctrl.BackColor = Color.Crimson; break;//bij eerste klik kleur word rood
            }
        }
        public void Reset()//reset de achtergrond kleur van de buttons van de usercontrol
        {
            rbtnA.BackColor = Color.Gainsboro;//reset achtergrondkleur van btn A
            rbtnB.BackColor = Color.Gainsboro;//reset achtergrondkleur van btn B
            rbtnC.BackColor = Color.Gainsboro;//reset achtergrondkleur van btn C
            rbtnD.BackColor = Color.Gainsboro;//reset achtergrondkleur van btn D
            rbtnScoreA.BackColor = Color.Gainsboro;//reset achtergrondkleur van scorepen 1
            rbtnScoreB.BackColor = Color.Gainsboro;//reset achtergrondkleur van scorepen 2
            rbtnScoreC.BackColor = Color.Gainsboro;//reset achtergrondkleur van scorepen 3
            rbtnScoreD.BackColor = Color.Gainsboro;//reset achtergrondkleur van scorepen 4
            rbtnA.Enabled = false;//Deactiveert button A van de usercontrol
            rbtnB.Enabled = false;//Deactiveert button B van de usercontrol
            rbtnC.Enabled = false;//Deactiveert button C van de usercontrol
            rbtnD.Enabled = false;//Deactiveert button D van de usercontrol
        }
        public void winScorePen()//zet de score pennetjes op rood als je de code hebt gekraakt
        {
            rbtnScoreA.BackColor = Color.Crimson;//zet pen 1 op rood
            rbtnScoreB.BackColor = Color.Crimson;//zet pen 2 op rood
            rbtnScoreC.BackColor = Color.Crimson;//zet pen 3 op rood
            rbtnScoreD.BackColor = Color.Crimson;//zet pen 4 op rood
        }
    }
}