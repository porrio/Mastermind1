using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Mastermind
{
    public partial class frmMasterMind : Form
    {
        Socket sck;
        EndPoint eplocal, epRemote;
        byte[] buffer;
        int multiplayer = 0;
        int textChanges = 0;
        int textCode1;
        int textCode2;
        int textCode3;
        int textCode4;
        int textCode5;
        int textCode6;
        int textCode7;
        int textCode8;
        int speelRijX;
        public frmMasterMind()
        {
            InitializeComponent();
            vulCodeArray();//vult de te kraken code in
            
            speelRij1.ColorChanged += () =>
            {
                sec = 1;
                timer1.Enabled = true;
                btnSpeelNewEnabled();
                ClickAction = () =>
                {
                    speelRij1.Enabled = false;
                    speelRij2.Enabled = true;
                    speelRij2.rbtnA.Enabled = true;
                    btnSpeelNewDisabled();
                    winCheck(
                        speelRij1.rbtnA.BackColor.ToString(), speelRij1.rbtnB.BackColor.ToString(),
                        speelRij1.rbtnC.BackColor.ToString(), speelRij1.rbtnD.BackColor.ToString(), 1);
                    if (multiplayer == 1)
                    {
                        gekozenCodeDisplayBijTegenstander(
                        speelRij1.rbtnA.BackColor.ToString(), speelRij1.rbtnB.BackColor.ToString(),
                        speelRij1.rbtnC.BackColor.ToString(), speelRij1.rbtnD.BackColor.ToString(),
                        speelRij1.rbtnScoreA.BackColor.ToString(), speelRij1.rbtnScoreB.BackColor.ToString(),
                        speelRij1.rbtnScoreC.BackColor.ToString(), speelRij1.rbtnScoreD.BackColor.ToString());
                        btnNew.Enabled = false;
                    }
                };
                ClickNew = () =>
                {
                    nieuw();
                };
            };
            speelRij2.ColorChanged += () =>
            {
                btnSpeelNewEnabled();
                ClickAction = () =>
                {
                    speelRij2.Enabled = false;
                    speelRij3.Enabled = true;
                    speelRij3.rbtnA.Enabled = true;
                    btnSpeelNewDisabled();
                    winCheck(
                        speelRij2.rbtnA.BackColor.ToString(), speelRij2.rbtnB.BackColor.ToString(),
                        speelRij2.rbtnC.BackColor.ToString(), speelRij2.rbtnD.BackColor.ToString(), 2);
                    if (multiplayer == 1)
                    {
                        gekozenCodeDisplayBijTegenstander(
                        speelRij2.rbtnA.BackColor.ToString(), speelRij2.rbtnB.BackColor.ToString(),
                        speelRij2.rbtnC.BackColor.ToString(), speelRij2.rbtnD.BackColor.ToString(),
                        speelRij2.rbtnScoreA.BackColor.ToString(), speelRij2.rbtnScoreB.BackColor.ToString(),
                        speelRij2.rbtnScoreC.BackColor.ToString(), speelRij2.rbtnScoreD.BackColor.ToString());
                        btnNew.Enabled = false;
                    }
                };
                ClickNew = () =>
                {
                    nieuw();
                };
            };
            speelRij3.ColorChanged += () =>
            {
                btnSpeelNewEnabled();
                ClickAction = () =>
                {
                    speelRij3.Enabled = false;
                    speelRij4.Enabled = true;
                    speelRij4.rbtnA.Enabled = true;
                    btnSpeelNewDisabled();
                    winCheck(
                        speelRij3.rbtnA.BackColor.ToString(), speelRij3.rbtnB.BackColor.ToString(),
                        speelRij3.rbtnC.BackColor.ToString(), speelRij3.rbtnD.BackColor.ToString(), 3);
                    if (multiplayer == 1)
                    {
                        gekozenCodeDisplayBijTegenstander(
                        speelRij3.rbtnA.BackColor.ToString(), speelRij3.rbtnB.BackColor.ToString(),
                        speelRij3.rbtnC.BackColor.ToString(), speelRij3.rbtnD.BackColor.ToString(),
                        speelRij3.rbtnScoreA.BackColor.ToString(), speelRij3.rbtnScoreB.BackColor.ToString(),
                        speelRij3.rbtnScoreC.BackColor.ToString(), speelRij3.rbtnScoreD.BackColor.ToString());
                        btnNew.Enabled = false;
                    }
                };
                ClickNew = () =>
                {
                    nieuw();
                };
            };
            speelRij4.ColorChanged += () =>
            {
                btnSpeelNewEnabled();
                ClickAction = () =>
                {
                    speelRij4.Enabled = false;
                    speelRij5.Enabled = true;
                    speelRij5.rbtnA.Enabled = true;
                    btnSpeelNewDisabled();
                    winCheck(
                        speelRij4.rbtnA.BackColor.ToString(), speelRij4.rbtnB.BackColor.ToString(),
                        speelRij4.rbtnC.BackColor.ToString(), speelRij4.rbtnD.BackColor.ToString(), 4);
                    if (multiplayer == 1)
                    {
                        gekozenCodeDisplayBijTegenstander(
                        speelRij4.rbtnA.BackColor.ToString(), speelRij4.rbtnB.BackColor.ToString(),
                        speelRij4.rbtnC.BackColor.ToString(), speelRij4.rbtnD.BackColor.ToString(),
                        speelRij4.rbtnScoreA.BackColor.ToString(), speelRij4.rbtnScoreB.BackColor.ToString(),
                        speelRij4.rbtnScoreC.BackColor.ToString(), speelRij4.rbtnScoreD.BackColor.ToString());
                        btnNew.Enabled = false;
                    }
                };
                ClickNew = () =>
                {
                    nieuw();
                };
            };
            speelRij5.ColorChanged += () =>
            {
                btnSpeelNewEnabled();
                ClickAction = () =>
                {
                    speelRij5.Enabled = false;
                    speelRij6.Enabled = true;
                    speelRij6.rbtnA.Enabled = true;
                    btnSpeelNewDisabled();
                    winCheck(
                        speelRij5.rbtnA.BackColor.ToString(), speelRij5.rbtnB.BackColor.ToString(),
                        speelRij5.rbtnC.BackColor.ToString(), speelRij5.rbtnD.BackColor.ToString(), 5);
                    if (multiplayer == 1)
                    {
                        gekozenCodeDisplayBijTegenstander(
                        speelRij5.rbtnA.BackColor.ToString(), speelRij5.rbtnB.BackColor.ToString(),
                        speelRij5.rbtnC.BackColor.ToString(), speelRij5.rbtnD.BackColor.ToString(),
                        speelRij5.rbtnScoreA.BackColor.ToString(), speelRij5.rbtnScoreB.BackColor.ToString(),
                        speelRij5.rbtnScoreC.BackColor.ToString(), speelRij5.rbtnScoreD.BackColor.ToString());
                        btnNew.Enabled = false;
                    }
                };
                ClickNew = () =>
                {
                    nieuw();
                };
            };
            speelRij6.ColorChanged += () =>
            {
                btnSpeelNewEnabled();
                ClickAction = () =>
                {
                    speelRij6.Enabled = false;
                    speelRij7.Enabled = true;
                    speelRij7.rbtnA.Enabled = true;
                    btnSpeelNewDisabled();
                    winCheck(
                        speelRij6.rbtnA.BackColor.ToString(), speelRij6.rbtnB.BackColor.ToString(),
                        speelRij6.rbtnC.BackColor.ToString(), speelRij6.rbtnD.BackColor.ToString(), 6);
                    if (multiplayer == 1)
                    {
                        gekozenCodeDisplayBijTegenstander(
                        speelRij6.rbtnA.BackColor.ToString(), speelRij6.rbtnB.BackColor.ToString(),
                        speelRij6.rbtnC.BackColor.ToString(), speelRij6.rbtnD.BackColor.ToString(),
                        speelRij6.rbtnScoreA.BackColor.ToString(), speelRij6.rbtnScoreB.BackColor.ToString(),
                        speelRij6.rbtnScoreC.BackColor.ToString(), speelRij6.rbtnScoreD.BackColor.ToString());
                        btnNew.Enabled = false;
                    }
                };
                ClickNew = () =>
                {
                    nieuw();
                };
            };
            speelRij7.ColorChanged += () =>
            {
                btnSpeelNewEnabled();
                ClickAction = () =>
                {
                    speelRij7.Enabled = false;
                    speelRij8.Enabled = true;
                    speelRij8.rbtnA.Enabled = true;
                    btnSpeelNewDisabled();
                    winCheck(
                        speelRij7.rbtnA.BackColor.ToString(), speelRij7.rbtnB.BackColor.ToString(),
                        speelRij7.rbtnC.BackColor.ToString(), speelRij7.rbtnD.BackColor.ToString(), 7);
                    if (multiplayer == 1)
                    {
                        gekozenCodeDisplayBijTegenstander(
                        speelRij7.rbtnA.BackColor.ToString(), speelRij7.rbtnB.BackColor.ToString(),
                        speelRij7.rbtnC.BackColor.ToString(), speelRij7.rbtnD.BackColor.ToString(),
                        speelRij7.rbtnScoreA.BackColor.ToString(), speelRij7.rbtnScoreB.BackColor.ToString(),
                        speelRij7.rbtnScoreC.BackColor.ToString(), speelRij7.rbtnScoreD.BackColor.ToString());
                        btnNew.Enabled = false;
                    }
                };
                ClickNew = () =>
                {
                    nieuw();
                };
            };
            speelRij8.ColorChanged += () =>
            {
                btnSpeelNewEnabled();
                ClickAction = () =>
                {
                    speelRij8.Enabled = false;
                    winCheck(
                        speelRij8.rbtnA.BackColor.ToString(), speelRij8.rbtnB.BackColor.ToString(),
                        speelRij8.rbtnC.BackColor.ToString(), speelRij8.rbtnD.BackColor.ToString(), 8);
                    if (multiplayer == 1)
                    {
                        gekozenCodeDisplayBijTegenstander(
                        speelRij8.rbtnA.BackColor.ToString(), speelRij8.rbtnB.BackColor.ToString(),
                        speelRij8.rbtnC.BackColor.ToString(), speelRij8.rbtnD.BackColor.ToString(),
                        speelRij8.rbtnScoreA.BackColor.ToString(), speelRij8.rbtnScoreB.BackColor.ToString(),
                        speelRij8.rbtnScoreC.BackColor.ToString(), speelRij8.rbtnScoreD.BackColor.ToString());
                        btnNew.Enabled = false;
                    }
                };
                ClickNew = () =>
                {
                    nieuw();
                };
            };
        }
        private Action ClickAction;
        private Action ClickNew;
        private void vulCodeArray()
        {
            int Min = 1;//zet het minimum op 1
            int Max = 5;//zet het maximum op 5
            Random randNum = new Random();//genereerd random nummer
            int[] code = Enumerable.Repeat(0, 5).Select(i => randNum.Next(Min, Max)).ToArray();//vult array code met random nummers tussen 0 en 5
            richTextBox1.Text = code[0].ToString();//vult richtextbox1 met eerste element uit code array
            richTextBox2.Text = code[1].ToString();//vult richtextbox2 met 2e element uit code array
            richTextBox3.Text = code[2].ToString();//vult richtextbox3 met 3e element uit code array
            richTextBox4.Text = code[3].ToString();//vult richtextbox4 met 4e element uit code array
            int code1 = int.Parse(richTextBox1.Text);//eesrte code in eerste textbox zetten
            int code2 = int.Parse(richTextBox2.Text);//2e code in 2e textbox zetten
            int code3 = int.Parse(richTextBox3.Text);//3e code in 3e textbox zetten
            int code4 = int.Parse(richTextBox4.Text);//4e code in 4e textbox zetten
            switch (code1)//zet de eerste code om naar kleur
            {
                case 1: rbtnCode1.BackColor = Color.Crimson; break;//code 1, kleur wordt rood
                case 2: rbtnCode1.BackColor = Color.Blue; break;//code 2, kleur wordt blauw
                case 3: rbtnCode1.BackColor = Color.Green; break;//code 3, kleur wordt groen
                case 4: rbtnCode1.BackColor = Color.Orange; break;//code 4, kleur wordt geel
            }
            switch (code2)//zet de 2e code om naar kleur
            {
                case 1: rbtnCode2.BackColor = Color.Crimson; break;//code 1, kleur wordt rood
                case 2: rbtnCode2.BackColor = Color.Blue; break;//code 2, kleur wordt blauw
                case 3: rbtnCode2.BackColor = Color.Green; break;//code 3, kleur wordt groen
                case 4: rbtnCode2.BackColor = Color.Orange; break;//code 4, kleur wordt geel
            }
            switch (code3)//zet de 3e code om naar kleur
            {
                case 1: rbtnCode3.BackColor = Color.Crimson; break;//code 1, kleur wordt rood
                case 2: rbtnCode3.BackColor = Color.Blue; break;//code 2, kleur wordt blauw
                case 3: rbtnCode3.BackColor = Color.Green; break;//code 3, kleur wordt groen
                case 4: rbtnCode3.BackColor = Color.Orange; break;//code 4, kleur wordt geel
            }
            switch (code4)//zet de 4e code om naar kleur
            {
                case 1: rbtnCode4.BackColor = Color.Crimson; break;//code 1, kleur wordt rood
                case 2: rbtnCode4.BackColor = Color.Blue; break;//code 2, kleur wordt blauw
                case 3: rbtnCode4.BackColor = Color.Green; break;//code 3, kleur wordt groen
                case 4: rbtnCode4.BackColor = Color.Orange; break;//code 4, kleur wordt geel
            }
        }
        private void winCheck(string btn1, string btn2, string btn3, string btn4, int x)//check ofgekozen code overeen komt met de te kraken code
        {
            switch (btn1)//kleur eerste gekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": btn1 = "1"; break;//kleur rood wordt 1
                case "Color [Green]": btn1 = "3"; break;//kleur groen wordt 3
                case "Color [Orange]": btn1 = "4"; break;// kleur geel wordt 4
                case "Color [Blue]": btn1 = "2"; break;// kleur blauw wordt 2
            }
            switch (btn2)//kleur 2e ekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": btn2 = "1"; break;//kleur rood wordt 1
                case "Color [Green]": btn2 = "3"; break;//kleur groen wordt 3
                case "Color [Orange]": btn2 = "4"; break;// kleur geel wordt 4
                case "Color [Blue]": btn2 = "2"; break;// kleur blauw wordt 2
            }
            switch (btn3)//kleur 3e gekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": btn3 = "1"; break;//kleur rood wordt 1
                case "Color [Green]": btn3 = "3"; break;//kleur groen wordt 3
                case "Color [Orange]": btn3 = "4"; break;// kleur geel wordt 4
                case "Color [Blue]": btn3 = "2"; break;// kleur blauw wordt 2
            }
            switch (btn4)//kleur 4e gekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": btn4 = "1"; break;//kleur rood wordt 1
                case "Color [Green]": btn4 = "3"; break;//kleur groen wordt 3
                case "Color [Orange]": btn4 = "4"; break;// kleur geel wordt 4
                case "Color [Blue]": btn4 = "2"; break;// kleur blauw wordt 2
            }
            string code = richTextBox1.Text + richTextBox2.Text + richTextBox3.Text + richTextBox4.Text;//de vier codes omzetten naar 1 code
            string code1 = btn1 + btn2 + btn3 + btn4;//gekozen codes omzetten naar 1 code
            if (code == code1)//checken of gekozen code overeenkomt met de code
            {
                timer1.Enabled = false;//timer stoppen
                btnNew.Enabled = true;//activeren van de nieuw button
                if (x == 1)//speelrij 1
                {
                    speelRij1.winScorePen();//gewonnen bij 1e usercontrol? zet alle scorepennen op rood
                    speelRij2.Enabled = false;//deactiveer volgende usercontrol zie row 99 van speelRij.cs
                    int tijd = int.Parse(lblTime.Text)+1;//zet de tijd van de label om naar int
                    int score = 8 * 1000 / tijd;//berekend de score
                    lblScore.Text = score.ToString();//zet berekende score in label Score
                }
                if (x == 2)//speelrij 2
                {
                    speelRij2.winScorePen();//gewonnen bij 2e usercontrol? zet alle scorepennen op rood
                    speelRij3.Enabled = false;//deactiveer volgende usercontrol zie row 99 van speelRij.cs
                    int tijd = int.Parse(lblTime.Text);//zet de tijd van de label om naar int
                    int score = 7 * 1000 / tijd;//berekend de score
                    lblScore.Text = score.ToString();//zet berekende score in label Score
                }
                if (x == 3)//speelrij 3
                {
                    speelRij3.winScorePen();//gewonnen bij 3e usercontrol? zet alle scorepennen op rood
                    speelRij4.Enabled = false;//deactiveer volgende usercontrol zie row 99 van speelRij.cs
                    int tijd = int.Parse(lblTime.Text);//zet de tijd van de label om naar int
                    int score = 6 * 1000 / tijd;//berekend de score
                    lblScore.Text = score.ToString();//zet berekende score in label Score
                }
                if (x == 4)//speelrij 4
                {
                    speelRij4.winScorePen();//gewonnen bij 4e usercontrol? zet alle scorepennen op rood
                    speelRij5.Enabled = false;//deactiveer volgende usercontrol zie row 99 van speelRij.cs
                    int tijd = int.Parse(lblTime.Text);//zet de tijd van de label om naar int
                    int score = 5 * 1000 / tijd;//berekend de score
                    lblScore.Text = score.ToString();//zet berekende score in label Score
                }
                if (x == 5)//speelrij 5
                {
                    speelRij5.winScorePen();//gewonnen bij 5e usercontrol? zet alle scorepennen op rood 
                    speelRij6.Enabled = false;//deactiveer volgende usercontrol zie row 99 van speelRij.cs
                    int tijd = int.Parse(lblTime.Text);//zet de tijd van de label om naar int
                    int score = 4 * 1000 / tijd;//berekend de score
                    lblScore.Text = score.ToString();//zet berekende score in label Score
                }
                if (x == 6)//speelrij 6
                {
                    speelRij6.winScorePen();//gewonnen bij 6e usercontrol? zet alle scorepennen op rood
                    speelRij7.Enabled = false;//deactiveer volgende usercontrol zie row 99 van speelRij.cs
                    int tijd = int.Parse(lblTime.Text);//zet de tijd van de label om naar int
                    int score = 3 * 1000 / tijd;//berekend de score
                    lblScore.Text = score.ToString();//zet berekende score in label Score
                }
                if (x == 7)//speelrij 7
                {
                    speelRij7.winScorePen();//gewonnen bij 7e usercontrol? zet alle scorepennen op rood en deactiveer volgende usercontrol zie row 99 van speelRij.cs
                    speelRij8.Enabled = false;//deactiveer volgende usercontrol zie row 99 van speelRij.cs
                    int tijd = int.Parse(lblTime.Text);//zet de tijd van de label om naar int
                    int score = 2 * 1000 / tijd;//berekend de score
                    lblScore.Text = score.ToString();//zet berekende score in label Score
                }
                if (x == 8)//speelrij 8
                {
                    speelRij8.winScorePen();//gewonnen bij 8e usercontrol? zet alle scorepennen op rood zie row 99 van speelRij.cs
                    int tijd = int.Parse(lblTime.Text);//zet de tijd van de label om naar int
                    int score = 1 * 1000 / tijd;//berekend de score
                    lblScore.Text = score.ToString();//zet berekende score in label Score
                }
                winActies(); }
            else //als bij speel rij 8 de code niet is gekraakt
            {
                if (x == 8)
                {
                    panel1.Visible = false;//code zichtbaar maken
                    lblResultaat.ForeColor = Color.Red;//text kleur resultaat label rood maken
                    lblResultaat.Text = "code niet gekraakt!";//text van resultaat label veranderen in code niet gekraakt
                    timer1.Enabled = false;
                }
                // checken of een goede kleur voorkomt op verkeerde plek
                if (richTextBox1.Text == btn2 || richTextBox1.Text == btn3 || richTextBox1.Text == btn4)
                {
                    eenGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox2.Text == btn1 || richTextBox2.Text == btn3 || richTextBox2.Text == btn4)
                {
                    eenGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox3.Text == btn1 || richTextBox3.Text == btn2 || richTextBox3.Text == btn4)
                {
                    eenGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox4.Text == btn1 || richTextBox4.Text == btn2 || richTextBox4.Text == btn3)
                {
                    eenGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox1.Text == btn2 && richTextBox1.Text == btn3)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox1.Text == btn2 && richTextBox1.Text == btn4)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox1.Text == btn3 && richTextBox1.Text == btn4)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox2.Text == btn1 && richTextBox2.Text == btn3)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox2.Text == btn1 && richTextBox2.Text == btn4)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox2.Text == btn3 && richTextBox2.Text == btn4)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox3.Text == btn1 && richTextBox3.Text == btn2)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox3.Text == btn1 && richTextBox3.Text == btn4)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox3.Text == btn2 && richTextBox3.Text == btn4)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox4.Text == btn1 && richTextBox4.Text == btn2)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox4.Text == btn1 && richTextBox4.Text == btn3)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox4.Text == btn2 && richTextBox4.Text == btn3)
                {
                    tweeGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox1.Text == btn2 && richTextBox1.Text == btn3 && richTextBox1.Text == btn4)
                {
                    drieGoedKleurFoutePleCheck(x);
                }
                if (richTextBox2.Text == btn1 && richTextBox2.Text == btn3 && richTextBox2.Text == btn4)
                {
                    drieGoedKleurFoutePleCheck(x);
                }
                if (richTextBox3.Text == btn1 && richTextBox3.Text == btn2 && richTextBox3.Text == btn4)
                {
                    drieGoedKleurFoutePleCheck(x);
                }
                if (richTextBox4.Text == btn1 && richTextBox4.Text == btn2 && richTextBox4.Text == btn3)
                {
                    drieGoedKleurFoutePleCheck(x);
                }
                if (richTextBox1.Text == btn1 && richTextBox1.Text == btn2 && richTextBox1.Text == btn3 & richTextBox1.Text == btn4)
                {
                    vierGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox2.Text == btn1 && richTextBox2.Text == btn2 && richTextBox2.Text == btn3 & richTextBox2.Text == btn4)
                {
                    vierGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox3.Text == btn1 && richTextBox3.Text == btn2 && richTextBox3.Text == btn3 & richTextBox3.Text == btn4)
                {
                    vierGoedKleurFoutePlekCheck(x);
                }
                if (richTextBox4.Text == btn1 && richTextBox4.Text == btn2 && richTextBox4.Text == btn3 & richTextBox4.Text == btn4)
                {
                    vierGoedKleurFoutePlekCheck(x);
                }
                //checken of 1 kleur goed is op goede plek
                if (btn1 == richTextBox1.Text || btn2 == richTextBox2.Text || btn3 == richTextBox3.Text || btn4 == richTextBox4.Text)
                {
                    eenKleurGoedePlekChck(x);
                }
                //checken of 2 kleuren goed zijn op goede plaats
                if (btn1 == richTextBox1.Text && btn2 == richTextBox2.Text)
                {
                    tweeKleurGoedePlekCheck(x);
                }
                if (btn1 == richTextBox1.Text && btn3 == richTextBox3.Text)
                {
                    tweeKleurGoedePlekCheck(x);
                }
                if (btn1 == richTextBox1.Text && btn4 == richTextBox4.Text)
                {
                    tweeKleurGoedePlekCheck(x);
                }
                if (btn2 == richTextBox2.Text && btn3 == richTextBox3.Text)
                {
                    tweeKleurGoedePlekCheck(x);
                }
                if (btn2 == richTextBox2.Text && btn4 == richTextBox4.Text)
                {
                    tweeKleurGoedePlekCheck(x);
                }
                if (btn3 == richTextBox3.Text && btn4 == richTextBox4.Text)
                {
                    tweeKleurGoedePlekCheck(x);
                }
                //checken of 3 kleuren goed zijn op goede plaats
                if (btn1 == richTextBox1.Text && btn2 == richTextBox2.Text && btn3 == richTextBox3.Text)
                {
                    drieKleurGoedePlekCheck(x);
                }
                if (btn1 == richTextBox1.Text && btn2 == richTextBox2.Text && btn4 == richTextBox4.Text)
                {
                    drieKleurGoedePlekCheck(x);
                }
                if (btn1 == richTextBox1.Text && btn3 == richTextBox3.Text && btn4 == richTextBox4.Text)
                {
                    drieKleurGoedePlekCheck(x);
                }
                if (btn2 == richTextBox2.Text && btn3 == richTextBox3.Text && btn4 == richTextBox4.Text)
                {
                    drieKleurGoedePlekCheck(x);
                }
            }
        }
        private void btnSpeel_Click(object sender, EventArgs e)
        {
            ClickAction.Invoke();
        }
        private void frmMasterMind_Load(object sender, EventArgs e)
        {
            this.scoreTableAdapter.Fill(this.mastermindDataSet.Score);
            dataGridView2.Sort(dataGridView2.Columns[2], ListSortDirection.Ascending);
            

            txbNaam.Text = "Vul hier je naam in en klik op enter om je score te verzenden!";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClickNew.Invoke();
        }
        private void resultaatReset()//reset resultaat label en genereerd nieuwe code
        {
            panel1.Visible = true;//maakt de code onzichtbaar
            lblResultaat.ForeColor = Color.Black;//zet kleur label resultaat op blauw
            lblResultaat.Text = "Mastermind";//zet tekst label resultaat op Mastermind
            vulCodeArray();//genereerd nieuwe code
            lblTime.Text = "0";//reset label time
            timer1.Enabled = false; // zet timer uit
            grpbScore.Visible = false; //maakt de score onzichtbaar
            grpbNaam.Visible = false;//maakt de groupbox naam onzichtbaar
        }
        private void eenKleurGoedePlekChck(int x)//cheken of er 1 kleur op de goede plek staat
        {
            switch (x) {
                case 1: speelRij1.rbtnScoreA.BackColor = Color.Crimson; break;
                case 2: speelRij2.rbtnScoreA.BackColor = Color.Crimson; break;
                case 3: speelRij3.rbtnScoreA.BackColor = Color.Crimson; break;
                case 4: speelRij4.rbtnScoreA.BackColor = Color.Crimson; break;
                case 5: speelRij5.rbtnScoreA.BackColor = Color.Crimson; break;
                case 6: speelRij6.rbtnScoreA.BackColor = Color.Crimson; break;
                case 7: speelRij7.rbtnScoreA.BackColor = Color.Crimson; break;
                case 8: speelRij8.rbtnScoreA.BackColor = Color.Crimson; break;
            }
        }
        private void tweeKleurGoedePlekCheck(int x)//cheken of er 2 kleure op de goede plek staan
        {
            switch (x) {
                case 1: speelRij1.rbtnScoreA.BackColor = Color.Crimson; speelRij1.rbtnScoreB.BackColor = Color.Crimson; break;
                case 2: speelRij2.rbtnScoreA.BackColor = Color.Crimson; speelRij2.rbtnScoreB.BackColor = Color.Crimson; break;
                case 3: speelRij3.rbtnScoreA.BackColor = Color.Crimson; speelRij3.rbtnScoreB.BackColor = Color.Crimson; break;
                case 4: speelRij4.rbtnScoreA.BackColor = Color.Crimson; speelRij4.rbtnScoreB.BackColor = Color.Crimson; break;
                case 5: speelRij5.rbtnScoreA.BackColor = Color.Crimson; speelRij5.rbtnScoreB.BackColor = Color.Crimson; break;
                case 6: speelRij6.rbtnScoreA.BackColor = Color.Crimson; speelRij6.rbtnScoreB.BackColor = Color.Crimson; break;
                case 7: speelRij7.rbtnScoreA.BackColor = Color.Crimson; speelRij7.rbtnScoreB.BackColor = Color.Crimson; break;
                case 8: speelRij8.rbtnScoreA.BackColor = Color.Crimson; speelRij8.rbtnScoreB.BackColor = Color.Crimson; break;
            }
        }
        private void drieKleurGoedePlekCheck(int x)//cheken of er 3 kleure op de goede plek staan
        {
            switch (x) {
                case 1: speelRij1.rbtnScoreA.BackColor = Color.Crimson; speelRij1.rbtnScoreB.BackColor = Color.Crimson; speelRij1.rbtnScoreC.BackColor = Color.Crimson; break;
                case 2: speelRij2.rbtnScoreA.BackColor = Color.Crimson; speelRij2.rbtnScoreB.BackColor = Color.Crimson; speelRij2.rbtnScoreC.BackColor = Color.Crimson; break;
                case 3: speelRij3.rbtnScoreA.BackColor = Color.Crimson; speelRij3.rbtnScoreB.BackColor = Color.Crimson; speelRij3.rbtnScoreC.BackColor = Color.Crimson; break;
                case 4: speelRij4.rbtnScoreA.BackColor = Color.Crimson; speelRij4.rbtnScoreB.BackColor = Color.Crimson; speelRij4.rbtnScoreC.BackColor = Color.Crimson; break;
                case 5: speelRij5.rbtnScoreA.BackColor = Color.Crimson; speelRij5.rbtnScoreB.BackColor = Color.Crimson; speelRij5.rbtnScoreC.BackColor = Color.Crimson; break;
                case 6: speelRij6.rbtnScoreA.BackColor = Color.Crimson; speelRij6.rbtnScoreB.BackColor = Color.Crimson; speelRij6.rbtnScoreC.BackColor = Color.Crimson; break;
                case 7: speelRij7.rbtnScoreA.BackColor = Color.Crimson; speelRij7.rbtnScoreB.BackColor = Color.Crimson; speelRij7.rbtnScoreC.BackColor = Color.Crimson; break;
                case 8: speelRij8.rbtnScoreA.BackColor = Color.Crimson; speelRij8.rbtnScoreB.BackColor = Color.Crimson; speelRij8.rbtnScoreC.BackColor = Color.Crimson; break;
            }
        }
        private void eenGoedKleurFoutePlekCheck(int x)//cheken of er 1 goede kleur op de verkeerde plek staat
        {
            switch (x) {
                case 1: speelRij1.rbtnScoreA.BackColor = Color.Black; break;
                case 2: speelRij2.rbtnScoreA.BackColor = Color.Black; break;
                case 3: speelRij3.rbtnScoreA.BackColor = Color.Black; break;
                case 4: speelRij4.rbtnScoreA.BackColor = Color.Black; break;
                case 5: speelRij5.rbtnScoreA.BackColor = Color.Black; break;
                case 6: speelRij6.rbtnScoreA.BackColor = Color.Black; break;
                case 7: speelRij7.rbtnScoreA.BackColor = Color.Black; break;
                case 8: speelRij8.rbtnScoreA.BackColor = Color.Black; break;
            }
        }
        private void tweeGoedKleurFoutePlekCheck(int x)//cheken of er 2 goede kleure op de verkeerde plek staan
        {
            switch (x)
            {
                case 1: speelRij1.rbtnScoreA.BackColor = Color.Black; speelRij1.rbtnScoreB.BackColor = Color.Black; break;
                case 2: speelRij2.rbtnScoreA.BackColor = Color.Black; speelRij2.rbtnScoreB.BackColor = Color.Black; break;
                case 3: speelRij3.rbtnScoreA.BackColor = Color.Black; speelRij3.rbtnScoreB.BackColor = Color.Black; break;
                case 4: speelRij4.rbtnScoreA.BackColor = Color.Black; speelRij4.rbtnScoreB.BackColor = Color.Black; break;
                case 5: speelRij5.rbtnScoreA.BackColor = Color.Black; speelRij5.rbtnScoreB.BackColor = Color.Black; break;
                case 6: speelRij6.rbtnScoreA.BackColor = Color.Black; speelRij6.rbtnScoreB.BackColor = Color.Black; break;
                case 7: speelRij7.rbtnScoreA.BackColor = Color.Black; speelRij7.rbtnScoreB.BackColor = Color.Black; break;
                case 8: speelRij8.rbtnScoreA.BackColor = Color.Black; speelRij8.rbtnScoreB.BackColor = Color.Black; break;
            }
        }
        private void drieGoedKleurFoutePleCheck(int x)//cheken of er 3 goede kleure op de verkeerde plek staan
        {
            switch (x)
            {
                case 1: speelRij1.rbtnScoreA.BackColor = Color.Black; speelRij1.rbtnScoreB.BackColor = Color.Black; speelRij1.rbtnScoreC.BackColor = Color.Black; break;
                case 2: speelRij2.rbtnScoreA.BackColor = Color.Black; speelRij2.rbtnScoreB.BackColor = Color.Black; speelRij2.rbtnScoreC.BackColor = Color.Black; break;
                case 3: speelRij3.rbtnScoreA.BackColor = Color.Black; speelRij3.rbtnScoreB.BackColor = Color.Black; speelRij3.rbtnScoreC.BackColor = Color.Black; break;
                case 4: speelRij4.rbtnScoreA.BackColor = Color.Black; speelRij4.rbtnScoreB.BackColor = Color.Black; speelRij4.rbtnScoreC.BackColor = Color.Black; break;
                case 5: speelRij5.rbtnScoreA.BackColor = Color.Black; speelRij5.rbtnScoreB.BackColor = Color.Black; speelRij5.rbtnScoreC.BackColor = Color.Black; break;
                case 6: speelRij6.rbtnScoreA.BackColor = Color.Black; speelRij6.rbtnScoreB.BackColor = Color.Black; speelRij6.rbtnScoreC.BackColor = Color.Black; break;
                case 7: speelRij7.rbtnScoreA.BackColor = Color.Black; speelRij7.rbtnScoreB.BackColor = Color.Black; speelRij7.rbtnScoreC.BackColor = Color.Black; break;
                case 8: speelRij8.rbtnScoreA.BackColor = Color.Black; speelRij8.rbtnScoreB.BackColor = Color.Black; speelRij8.rbtnScoreC.BackColor = Color.Black; break;
            }
        }
        private void vierGoedKleurFoutePlekCheck(int x)//cheken of er 4 goede kleure op de verkeerde plek staan
        {
            switch (x)
            {
                case 1: speelRij1.rbtnScoreA.BackColor = Color.Black; speelRij1.rbtnScoreB.BackColor = Color.Black; speelRij1.rbtnScoreC.BackColor = Color.Black; speelRij1.rbtnScoreD.BackColor = Color.Black; break;
                case 2: speelRij2.rbtnScoreA.BackColor = Color.Black; speelRij2.rbtnScoreB.BackColor = Color.Black; speelRij2.rbtnScoreC.BackColor = Color.Black; speelRij2.rbtnScoreD.BackColor = Color.Black; break;
                case 3: speelRij3.rbtnScoreA.BackColor = Color.Black; speelRij3.rbtnScoreB.BackColor = Color.Black; speelRij3.rbtnScoreC.BackColor = Color.Black; speelRij3.rbtnScoreD.BackColor = Color.Black; break;
                case 4: speelRij4.rbtnScoreA.BackColor = Color.Black; speelRij4.rbtnScoreB.BackColor = Color.Black; speelRij4.rbtnScoreC.BackColor = Color.Black; speelRij4.rbtnScoreD.BackColor = Color.Black; break;
                case 5: speelRij5.rbtnScoreA.BackColor = Color.Black; speelRij5.rbtnScoreB.BackColor = Color.Black; speelRij5.rbtnScoreC.BackColor = Color.Black; speelRij5.rbtnScoreD.BackColor = Color.Black; break;
                case 6: speelRij6.rbtnScoreA.BackColor = Color.Black; speelRij6.rbtnScoreB.BackColor = Color.Black; speelRij6.rbtnScoreC.BackColor = Color.Black; speelRij6.rbtnScoreD.BackColor = Color.Black; break;
                case 7: speelRij7.rbtnScoreA.BackColor = Color.Black; speelRij7.rbtnScoreB.BackColor = Color.Black; speelRij7.rbtnScoreC.BackColor = Color.Black; speelRij7.rbtnScoreD.BackColor = Color.Black; break;
                case 8: speelRij8.rbtnScoreA.BackColor = Color.Black; speelRij8.rbtnScoreB.BackColor = Color.Black; speelRij8.rbtnScoreC.BackColor = Color.Black; speelRij8.rbtnScoreD.BackColor = Color.Black; break;
            }
        }
        int sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = sec++.ToString();//zet de seconden van de timer in de tijd label
        }
        private void nieuw()
        {
            speelRij1.Reset();//zie row 84 van speelRij.cs
            speelRij2.Reset();//zie row 84 van speelRij.cs
            speelRij3.Reset();//zie row 84 van speelRij.cs
            speelRij4.Reset();//zie row 84 van speelRij.cs
            speelRij5.Reset();//zie row 84 van speelRij.cs
            speelRij6.Reset();//zie row 84 van speelRij.cs
            speelRij7.Reset();//zie row 84 van speelRij.cs
            speelRij8.Reset();//zie row 84 van speelRij.cs
            resultaatReset();//reset resultaat label en genereerd nieuwe code
            multiPlayerReset();//reset multiplayer velden
            btnSpeelNewDisabled();//deactiveer de knoppen nieuw en speel
            speelRij1.Enabled = true;//activeert speelrij1
            speelRij1.rbtnA.Enabled = true;//activeert eerste button van speelrij 1
        }
        private void multiPlayerReset()//reset multiplayer velden
        {
            btnMakeCode.Visible = false;//maakt maak code knop onzichtbaar
            groupBox4.Visible = false;//maakt groepbox4 onzichtbaar
            btnMakeCode.Enabled = true; //activeert maak code knop

        }
        private void btnSpeelNewEnabled()//activeert de knoppen nieuw en speel
        {
            btnNew.Enabled = true;//activeert de knop nieuw
            btnSpeel.Enabled = true;//activeert de knop speel
        }
        private void btnSpeelNewDisabled()//deactiveert de knoppen nieuw en speel
        {
            btnNew.Enabled = false;//deactiveert knop nieuw
            btnSpeel.Enabled = false;//deactiveert knop speel
        }
        private void spelRegelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spelregels settingsForm = new Spelregels();//maakt nieuw venster voor spelregels
            settingsForm.ShowDialog();//laat het venster met spelrgels zien
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();//sluit het spel af
        }
        private void multiplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            multiplayer = 1;//zet de variable multiplayer op 1
            textChanges = 0;// zet de textchanges op 0
            textBox1.Text = "";//leegt de comunicatie textbox
            rbtnMultiCode1.BackColor = Color.Gainsboro;//reset achtergrondkleur van kies code buttons
            rbtnMultiCode2.BackColor = Color.Gainsboro;//reset achtergrondkleur van kies code buttons
            rbtnMultiCode3.BackColor = Color.Gainsboro;//reset achtergrondkleur van kies code buttons
            rbtnMultiCode4.BackColor = Color.Gainsboro;//reset achtergrondkleur van kies code buttons
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;

            nieuw();
            speelRij1.Enabled = false;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            Start.Visible = true;
            Start.Enabled = true;
            txbNaam.Enabled = true;
            btnMakeCode.Enabled = false;
            //setup socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //get local ip
            label1.Text = localIP();//zet je lokale ip in de label
        }
        private string localIP()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint.Address.ToString();
            }
        }
        private void vraag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Voor de beste resultaten gebruik poort 80 en laat uw tegenstander poort 81 gebruiken, of andersom");
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (label1.Text == "127.0.0.1")
            {
                MessageBox.Show("controleer uw netwerk verbinding");
            }
            else
            {
                if (IsTextAValidIPAddress(RemoteIP.Text))
                {
                    string mijnPoort;
                    string zijnIP;
                    string zijnPoort;
                    mijnPoort = myPort.Text;
                    zijnIP = RemoteIP.Text;
                    zijnPoort = RemotePort.Text;


                    if (mijnPoort != "" && zijnIP != "" && zijnPoort != "")
                    {
                        groupBox4.Visible = true;
                        groupBox4.Enabled = true;
                        rbtnMultiCode1.Enabled = true;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        Start.Enabled = false;
                        //btnMakeCode.Visible = true;
                        //bind the socket
                        try
                        {
                            eplocal = new IPEndPoint(IPAddress.Parse(label1.Text), Convert.ToInt32(myPort.Text));
                            sck.Bind(eplocal);
                        }
                        catch
                        {
                            DialogResult dialogResult = MessageBox.Show("Er is een onherstelbare fout opgetreden wilt u de applicatie afsluiten?", "Fout", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                Close();
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("U moet de applicatie sluiten om verder te kunnen gaan met Multiplayer, \n P.S. vul de volgende keer het juiste IP in.");
                            }
                        }
                        //connection
                        try
                        {
                            epRemote = new IPEndPoint(IPAddress.Parse(RemoteIP.Text), Convert.ToInt32(RemotePort.Text));
                            sck.Connect(epRemote);
                        }
                        catch

                        {
                            groupBox4.Visible = false;
                            groupBox4.Enabled = false;
                            rbtnMultiCode1.Enabled = false;
                            groupBox2.Enabled = true;
                            groupBox3.Enabled = true;
                            Start.Enabled = true;
                        }
                        //Listening Specific port
                        buffer = new byte[1500];
                        sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                        if (textBox1.Text != "")
                        {
                            string code = textBox1.Text;

                            int code1 = int.Parse(code[0].ToString());
                            int code2 = int.Parse(code[1].ToString());
                            int code3 = int.Parse(code[2].ToString());
                            int code4 = int.Parse(code[3].ToString());
                            switch (code1)//zet de eerste code om naar kleur
                            {
                                case 1: rbtnCode1.BackColor = Color.Crimson; break;
                                case 2: rbtnCode1.BackColor = Color.Blue; break;
                                case 3: rbtnCode1.BackColor = Color.Green; break;
                                case 4: rbtnCode1.BackColor = Color.Orange; break;
                            }
                            switch (code2)//zet de 2e code om naar kleur
                            {
                                case 1: rbtnCode2.BackColor = Color.Crimson; break;
                                case 2: rbtnCode2.BackColor = Color.Blue; break;
                                case 3: rbtnCode2.BackColor = Color.Green; break;
                                case 4: rbtnCode2.BackColor = Color.Orange; break;
                            }
                            switch (code3)//zet de 3e code om naar kleur
                            {
                                case 1: rbtnCode3.BackColor = Color.Crimson; break;
                                case 2: rbtnCode3.BackColor = Color.Blue; break;
                                case 3: rbtnCode3.BackColor = Color.Green; break;
                                case 4: rbtnCode3.BackColor = Color.Orange; break;
                            }
                            switch (code4)//zet de 4e code om naar kleur
                            {
                                case 1: rbtnCode4.BackColor = Color.Crimson; break;
                                case 2: rbtnCode4.BackColor = Color.Blue; break;
                                case 3: rbtnCode4.BackColor = Color.Green; break;
                                case 4: rbtnCode4.BackColor = Color.Orange; break;
                            }
                        }
                    }
                    else { MessageBox.Show("Vul alle velden!"); }
                }
                else { MessageBox.Show("Vul een geldig Ip adres in"); }
            }
        }
        
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                //converting byte to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);
                textBox1.Text = receivedMessage.ToString();
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }
        }
        private void rbtnMultiCode1_Click(object sender, EventArgs e)
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
            rbtnMultiCode2.Enabled = true;
        }
        private void rbtnMultiCode2_Click(object sender, EventArgs e)
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
            rbtnMultiCode3.Enabled = true;
        }
        private void rbtnMultiCode3_Click(object sender, EventArgs e)
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
            rbtnMultiCode4.Enabled = true;
        }
        private void rbtnMulticode4_Click(object sender, EventArgs e)
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
            btnMakeCode.Visible = true;
            btnMakeCode.Enabled = true;
        }
        private void codeOmzetter(string maakCode1, string maakCode2, string maakCode3, string maakCode4)
        {
            switch (maakCode1)//kleur eerste gekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": maakCode1 = "1"; break;
                case "Color [Green]": maakCode1 = "3"; break;
                case "Color [Orange]": maakCode1 = "4"; break;
                case "Color [Blue]": maakCode1 = "2"; break;
            }
            switch (maakCode2)//kleur 2e ekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": maakCode2 = "1"; break;
                case "Color [Green]": maakCode2 = "3"; break;
                case "Color [Orange]": maakCode2 = "4"; break;
                case "Color [Blue]": maakCode2 = "2"; break;
            }
            switch (maakCode3)//kleur 3e gekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": maakCode3 = "1"; break;
                case "Color [Green]": maakCode3 = "3"; break;
                case "Color [Orange]": maakCode3 = "4"; break;
                case "Color [Blue]": maakCode3 = "2"; break;
            }
            switch (maakCode4)//kleur 4e gekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": maakCode4 = "1"; break;
                case "Color [Green]": maakCode4 = "3"; break;
                case "Color [Orange]": maakCode4 = "4"; break;
                case "Color [Blue]": maakCode4 = "2"; break;
            }
            string code = richTextBox1.Text + richTextBox2.Text + richTextBox3.Text + richTextBox4.Text;//de vier codes omzetten naar 1 code
            string code1 = maakCode1 + maakCode2 + maakCode3 + maakCode4;//gekozen codes omzetten naar 1 code
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(code1);
            // sending the encoded message
            sck.Send(sendingMessage);
            //adding to listbox
            // listBox1.Items.Clear();
            //listBox1.Items.Add(code1);
            textBox1.Text = code1;
        }
        private void btnMakeCode_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MessageBox.Show("uw tegenstander heeft al een code gemaak, veel plezier met het kraken van de code");
                //uitsplitsen door tegenstander gekozen code
                string code = textBox1.Text;//text van het in een string zetten zodat het gesplitst kan worden
                int code1 = int.Parse(code[0].ToString());//uitsplitsen 1e karakter
                int code2 = int.Parse(code[1].ToString());//uitsplitsen 2e karakter
                int code3 = int.Parse(code[2].ToString());//uitsplitsen 3e karakter
                int code4 = int.Parse(code[3].ToString());//uitsplitsen 4e karakter
                richTextBox1.Text = code1.ToString();//zet 1e karakter in de tekraken code
                richTextBox2.Text = code2.ToString();//zet 2e karakter in de tekraken code
                richTextBox3.Text = code3.ToString();//zet 3e karakter in de tekraken code
                richTextBox4.Text = code4.ToString();//zet 4e karakter in de tekraken code
                switch (code1)//zet de eerste door tegenstander gekozen code om naar kleur
                {
                    case 1: rbtnCode1.BackColor = Color.Crimson; break;
                    case 2: rbtnCode1.BackColor = Color.Blue; break;
                    case 3: rbtnCode1.BackColor = Color.Green; break;
                    case 4: rbtnCode1.BackColor = Color.Orange; break;
                }
                switch (code2)//zet de 2e code om naar kleur
                {
                    case 1: rbtnCode2.BackColor = Color.Crimson; break;
                    case 2: rbtnCode2.BackColor = Color.Blue; break;
                    case 3: rbtnCode2.BackColor = Color.Green; break;
                    case 4: rbtnCode2.BackColor = Color.Orange; break;
                }
                switch (code3)//zet de 3e code om naar kleur
                {
                    case 1: rbtnCode3.BackColor = Color.Crimson; break;
                    case 2: rbtnCode3.BackColor = Color.Blue; break;
                    case 3: rbtnCode3.BackColor = Color.Green; break;
                    case 4: rbtnCode3.BackColor = Color.Orange; break;
                }
                switch (code4)//zet de 4e code om naar kleur
                {
                    case 1: rbtnCode4.BackColor = Color.Crimson; break;
                    case 2: rbtnCode4.BackColor = Color.Blue; break;
                    case 3: rbtnCode4.BackColor = Color.Green; break;
                    case 4: rbtnCode4.BackColor = Color.Orange; break;
                }
                btnMakeCode.Enabled = false;
                speelRij1.Enabled = true;
            }
            else
            {
                //convert string message to byte[]
                codeOmzetter(rbtnMultiCode1.BackColor.ToString(), rbtnMultiCode2.BackColor.ToString(), rbtnMultiCode3.BackColor.ToString(), rbtnMultiCode4.BackColor.ToString());
                groupBox4.Enabled = false;
                MessageBox.Show("Het spel is gestart wacht tot uw tegenstander de code heeft gekraakt");
                GekozenCodeInCodeDisplay();
                btnMakeCode.Enabled = false;
            }
        }
            private void GekozenCodeInCodeDisplay()
        {
            rbtnCode1.BackColor = rbtnMultiCode1.BackColor;
            rbtnCode2.BackColor = rbtnMultiCode2.BackColor;
            rbtnCode3.BackColor = rbtnMultiCode3.BackColor;
            rbtnCode4.BackColor = rbtnMultiCode4.BackColor;
        }
         
        bool IsTextAValidIPAddress(string text)//test of er een geldig ipadres is ingevult
        {
            System.Net.IPAddress test;
            return System.Net.IPAddress.TryParse(text, out test);
        }
        private void codeDisplaySwitch(int code1, int code2, int code3, int code4, int code5, int code6, int code7, int code8, int x)
        {
            //bepalen welke speel rij ingekleurt moet worden
            var speelrij = speelRij1;
            switch (x)
            {
                case 1: speelrij = speelRij1; break;//speelrij 1 moet worden ingekleurt
                case 2: speelrij = speelRij2; break;//speelrij 2 moet worden ingekleurt
                case 3: speelrij = speelRij3; break;//speelrij 3 moet worden ingekleurt
                case 4: speelrij = speelRij4; break;//speelrij 4 moet worden ingekleurt
                case 5: speelrij = speelRij5; break;//speelrij 5 moet worden ingekleurt
                case 6: speelrij = speelRij6; break;//speelrij 6 moet worden ingekleurt
                case 7: speelrij = speelRij7; break;//speelrij 7 moet worden ingekleurt
                case 8: speelrij = speelRij8; break; timer1.Enabled = false;//speelrij 8 moet worden ingekleurt
            }
            switch (code1)//1e uitgesplitste code omzetten naar kleur
            {
                case 1: speelrij.rbtnA.BackColor = Color.Crimson; break;
                case 2: speelrij.rbtnA.BackColor = Color.Blue; break;
                case 3: speelrij.rbtnA.BackColor = Color.Green; break;
                case 4: speelrij.rbtnA.BackColor = Color.Orange; break;
            }
            switch (code2)//2e uitgesplitste code omzetten naar kleur
            {
                case 1: speelrij.rbtnB.BackColor = Color.Crimson; break;
                case 2: speelrij.rbtnB.BackColor = Color.Blue; break;
                case 3: speelrij.rbtnB.BackColor = Color.Green; break;
                case 4: speelrij.rbtnB.BackColor = Color.Orange; break;
            }
            switch (code3)//3e uitgesplitste code omzetten naar kleur
            {
                case 1: speelrij.rbtnC.BackColor = Color.Crimson; break;
                case 2: speelrij.rbtnC.BackColor = Color.Blue; break;
                case 3: speelrij.rbtnC.BackColor = Color.Green; break;
                case 4: speelrij.rbtnC.BackColor = Color.Orange; break;
            }
            switch (code4)//4e uitgesplitste code omzetten naar kleur
            {
                case 1: speelrij.rbtnD.BackColor = Color.Crimson; break;
                case 2: speelrij.rbtnD.BackColor = Color.Blue; break;
                case 3: speelrij.rbtnD.BackColor = Color.Green; break;
                case 4: speelrij.rbtnD.BackColor = Color.Orange; break;
            }
            switch (code5)//5e uitgesplitste code omzetten naar kleur
            {
                case 0: speelrij.rbtnScoreA.BackColor = Color.Gainsboro; break;
                case 1: speelrij.rbtnScoreA.BackColor = Color.Crimson; break;
                case 2: speelrij.rbtnScoreA.BackColor = Color.Black; break;
            }
            switch (code6)//6e uitgesplitste code omzetten naar kleur
            {
                case 0: speelrij.rbtnScoreB.BackColor = Color.Gainsboro; break;
                case 1: speelrij.rbtnScoreB.BackColor = Color.Crimson; break;
                case 2: speelrij.rbtnScoreB.BackColor = Color.Black; break;
            }
            switch (code7)//7e uitgesplitste code omzetten naar kleur
            {
                case 0: speelrij.rbtnScoreC.BackColor = Color.Gainsboro; break;
                case 1: speelrij.rbtnScoreC.BackColor = Color.Crimson; break;
                case 2: speelrij.rbtnScoreC.BackColor = Color.Black; break;
            }
            switch (code8)//8e uitgesplitste code omzetten naar kleur
            {
                case 0: speelrij.rbtnScoreD.BackColor = Color.Gainsboro; break;
                case 1: speelrij.rbtnScoreD.BackColor = Color.Crimson; break;
                case 2: speelrij.rbtnScoreD.BackColor = Color.Black; break;
            }
            timer1.Enabled = true;
            
            
        }

        private void textBoxSplitter()
        {
            if (textBox1.TextLength == 8)
            {


                textCode1 = int.Parse(textBox1.Text[0].ToString());//uitsplitsen textbox text 1e karakter naar int
                textCode2 = int.Parse(textBox1.Text[1].ToString());//uitsplitsen textbox text 2e karakter naar int
                textCode3 = int.Parse(textBox1.Text[2].ToString());//uitsplitsen textbox text 3e karakter naar int
                textCode4 = int.Parse(textBox1.Text[3].ToString());//uitsplitsen textbox text 4e karakter naar int
                textCode5 = int.Parse(textBox1.Text[4].ToString());//uitsplitsen textbox text 5e karakter naar int(scorepen1) 
                textCode6 = int.Parse(textBox1.Text[5].ToString());//uitsplitsen textbox text 6e karakter naar int(scorepen2) 
                textCode7 = int.Parse(textBox1.Text[6].ToString());//uitsplitsen textbox text 7e karakter naar int(scorepen3) 
                textCode8 = int.Parse(textBox1.Text[7].ToString());//uitsplitsen textbox text 8e karakter naar int(scorepen4) 
                switch (textChanges)
                {
                    case 2: speelRijX = 1; break;
                    case 3: speelRijX = 2; break;
                    case 4: speelRijX = 3; break;
                    case 5: speelRijX = 4; break;
                    case 6: speelRijX = 5; break;
                    case 7: speelRijX = 6; break;
                    case 8: speelRijX = 7; break;
                    case 9: speelRijX = 8; break;
                }
                codeDisplaySwitch(textCode1, textCode2, textCode3, textCode4, textCode5, textCode6, textCode7, textCode8, speelRijX);//uitgesplitste code in switch stoppen zodat er een kleur komt(speelrij 1)
            }
            else
            {
               
            }
        }
        
        private void multiWinCheck()
        {
            if (textCode5 == 1 && textCode6 == 1 && textCode7 == 1 && textCode8 == 1)
                     {
                        winActies();
                dataGridView2.Visible = true;
                timer1.Enabled = false;
                     }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)//binnengekomen code uitsplitsen en omzetten naar kleur
        {
            //MessageBox.Show(textBox1.TextLength.ToString());
            int x = textBox1.TextLength-1;
            string y = textBox1.Text[x].ToString();
            
            string Score = lblScore.Text;
            string Tijd = lblTime.Text;
            string Datum = dateTimePicker1.Value.ToString();
            if ( y == "8")
            {
                timer1.Enabled = false;
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                string value = textBox1.Text;
                char delimiter = '?';
                string[] substrings = value.Split(delimiter);
                string[] rows = { substrings[0], substrings[1], substrings[2], substrings[3] };
                dataGridView2.Rows.Add(rows);
                dataGridView2.Sort(dataGridView2.Columns[2], ListSortDirection.Ascending);
                grpbNaam.Visible = false;
                txbNaam.Enabled = false;
                grpbScore.Visible = false;
                txbNaam.Text = "Vul hier je naam in en klik op enter om je score te verzenden!";
            }
            textChanges++;//bepaald welke speelrij de tegenstander heeft gevuld
            if (textCode5 == 1 && textCode6 == 1 && textCode7 == 1 && textCode8 == 1)
            {
                textChanges = 0;
            }
            
                textBox2.Text = textChanges.ToString();
                string text = textBox2.Text;
                // int texxt = int.Parse(textBox2.Text);
                switch (text)
                {
                    case "2": multiWinCheck(); textBoxSplitter(); break;
                    case "3": multiWinCheck(); textBoxSplitter(); break;
                    case "4": multiWinCheck(); textBoxSplitter(); break;
                    case "5": multiWinCheck(); textBoxSplitter(); break;
                    case "6": multiWinCheck(); textBoxSplitter(); break;
                    case "7": multiWinCheck(); textBoxSplitter(); break;
                    case "8": multiWinCheck(); textBoxSplitter(); break;
                    case "9": multiWinCheck(); textBoxSplitter(); break;
                        //case "55555555": MessageBox.Show("hallo"); break;
                }
                // if (texxt >= 9)
                /// {
                //      MessageBox.Show("jojojojojooojojoojojojoojo");   
                // }

                /*if (textChanges >= 2)
                {
                    textBoxSplitter();
                    switch (textChanges)
                    {
                        case 2: multiWinCheck(); textBoxSplitter(); break;
                        case 3: multiWinCheck(); textBoxSplitter(); break;
                        case 4: multiWinCheck(); textBoxSplitter(); break;
                        case 5: multiWinCheck(); textBoxSplitter(); break;
                        case 6: multiWinCheck(); textBoxSplitter(); break;
                        case 7: multiWinCheck(); textBoxSplitter(); break;
                        case 8: multiWinCheck(); textBoxSplitter(); break;
                        case 9: multiWinCheck(); textBoxSplitter(); break;
                    }
                }*/
            }
        
        private void winActies()
        {
            
            //MessageBox.Show("De code is gekraakt");
            timer1.Enabled = false;//zet timer stop
            panel1.Visible = false;//als je gewonnen hebt wordt de code zichtbaar
            lblResultaat.ForeColor = Color.Green;//kleur van resultaat label wordt groen
            lblResultaat.Text = "code gekraakt!";//tekst van resultaat label wordt code gekraakt!
            grpbScore.Visible = true;//laat de score zien
            grpbNaam.Visible = true;//maakt het invulveld voor naam zichtbaar
            timer1.Enabled = false;//zet timer stop
            btnSpeel.Enabled = false;//deactiveer speel knop
            
        }
        private void gekozenCodeDisplayBijTegenstander(string gekozenKleur1, string gekozenKleur2, string gekozenKleur3, string gekozenKleur4, string scorePen1, string scorePen2, string scorePen3, string scorePen4)//kleurcode omzetten naar bericht
        {
            switch (gekozenKleur1)//kleur eerste gekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": gekozenKleur1 = "1"; break;
                case "Color [Green]": gekozenKleur1 = "3"; break;
                case "Color [Orange]": gekozenKleur1 = "4"; break;
                case "Color [Blue]": gekozenKleur1 = "2"; break;
            }
            switch (gekozenKleur2)//kleur 2e gekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": gekozenKleur2 = "1"; break;
                case "Color [Green]": gekozenKleur2 = "3"; break;
                case "Color [Orange]": gekozenKleur2 = "4"; break;
                case "Color [Blue]": gekozenKleur2 = "2"; break;
            }
            switch (gekozenKleur3)//kleur 3e gekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": gekozenKleur3 = "1"; break;
                case "Color [Green]": gekozenKleur3 = "3"; break;
                case "Color [Orange]": gekozenKleur3 = "4"; break;
                case "Color [Blue]": gekozenKleur3 = "2"; break;
            }
            switch (gekozenKleur4)//kleur 4e gekozen code omzetten naar cijfers
            {
                case "Color [Crimson]": gekozenKleur4 = "1"; break;
                case "Color [Green]": gekozenKleur4 = "3"; break;
                case "Color [Orange]": gekozenKleur4 = "4"; break;
                case "Color [Blue]": gekozenKleur4 = "2"; break;
            }
            switch (scorePen1)//score pen 1 omzetten naar code
            {
                case "Color [Gainsboro]": scorePen1 = "0"; break;
                case "Color [Crimson]": scorePen1 = "1"; break;
                case "Color [Black]": scorePen1 = "2"; break;
            }
            switch (scorePen2)//score pen 3 omzetten naar code
            {
                case "Color [Gainsboro]": scorePen2 = "0"; break;
                case "Color [Crimson]": scorePen2 = "1"; break;
                case "Color [Black]": scorePen2 = "2"; break;
            }
            switch (scorePen3)//score pen 3 omzetten naar code
            {
                case "Color [Gainsboro]": scorePen3 = "0"; break;
                case "Color [Crimson]": scorePen3 = "1"; break;
                case "Color [Black]": scorePen3 = "2"; break;
            }
            switch (scorePen4)//score pen 3 omzetten naar code
            {
                case "Color [Gainsboro]": scorePen4 = "0"; break;
                case "Color [Crimson]": scorePen4 = "1"; break;
                case "Color [Black]": scorePen4 = "2"; break;
            }
            string bericht = gekozenKleur1 + gekozenKleur2 + gekozenKleur3 + gekozenKleur4 + scorePen1 + scorePen2 + scorePen3 + scorePen4;//codes samenvoegen voor verzenden
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(bericht);
            // sending the encoded message
            sck.Send(sendingMessage);
            textBox1.Text = bericht.ToString();
           
        }
      
        private void panel1_Paint(object sender, PaintEventArgs e) {}

        private void singleplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nieuw();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            multiplayer = 0;
            textBox1.Text = "";
            textChanges = 0;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            Start.Visible = false;
            groupBox4.Visible = false;
            btnMakeCode.Visible = false;
            teller = 0;
        }

        private void myPort_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(myPort.Text, "[^0-9]"))
            {
                myPort.Text = null;
                MessageBox.Show("Gelieve alleen nummerieke waarden invoeren.");
            }
        }
        private void RemotePort_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(RemotePort.Text, "[^0-9]"))
            {
                RemotePort.Text = null;
                MessageBox.Show("Gelieve alleen nummerieke waarden invoeren.");
            }
        }

        private void RemoteIP_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(RemoteIP.Text, "[^.0-9]"))
            {
                RemoteIP.Text = null;
                MessageBox.Show("Gelieve alleen nummerieke waarden invoeren.");
            }
        }
       
        private void txbNaam_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        int teller;
        
        private void txbNaam_KeyDown(object sender, KeyEventArgs e)
        {

            if (Convert.ToInt32(e.KeyData) == 13)
            {

                string Score = lblScore.Text;
                string Tijd = lblTime.Text;
                string Datum = dateTimePicker1.Value.ToString();
                string Naam = txbNaam.Text;
                string[] row = { Naam, Score, Tijd, Datum };
                
                if (multiplayer == 1)
                {
                    textChanges = 0;
                    string code1 = Naam + "?" + Score + "?" + Tijd + "?" + Datum +"8";
                    ASCIIEncoding aEncoding = new ASCIIEncoding();
                    byte[] sendingMessage = new byte[1500];
                    sendingMessage = aEncoding.GetBytes(code1);
                    sck.Send(sendingMessage);
                    textBox1.Text = code1;
                    teller = 0;
                    
                }
                else
                {
                    teller = 0;
                    dataGridView1.Rows.Add(row);
                    dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
                    grpbNaam.Visible = false;
                    grpbScore.Visible = false;
                    txbNaam.Text = "Vul hier je naam in en klik op enter om je score te verzenden!";
                }
                
            }
        }

        private void txbNaam_Click(object sender, EventArgs e)
        {
            teller++;
            if (teller == 1)
            {
                txbNaam.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void speelRij1_SystemColorsChanged(object sender, EventArgs e)
        {
            
        }

        private void speelRij1_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {}
    }
}