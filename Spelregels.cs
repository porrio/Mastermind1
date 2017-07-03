using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Spelregels : Form
    {
        public Spelregels()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "De computer maakt een geheime code die zó moeilijk is dat jij hem niet kan breken.\nDe code kan uit iedere combinatie van de 4 verschillende kleuren bestaan. \nDe speler die de code ontcijfert: jij moet de geheime code in zo min mogelijk pogingen breken.\nJe hebt maximaal 8 kansen om de code van de computer na te maken – d.w.z.de juiste kleuren in de juiste volgorde te raden. \nHET SPEL\nDe code bestaat uit 4 codepinnetjes in iedere gewenste combinatie van de 4 kleuren.\nAls de code is opgezet, kan de tegenspeler beginnen met raden. Zijn / haar doel is de exacte kleuren en plaatsen van de verborgen codepinnetjes te kopiëren.\nRaden betekent dat je een rij codepinnetjes in het Mastermind-spel zet.\nElke rij pinnetjes(dus elke poging) blijft de rest van de ronde zo staan. \nNa iedere poging moet de computer de tegenspeler vertellen wat er goed en fout is in het rijtje. Dat gaat als volgt:\n Rode scorepinnetjes: Zet een rood scorepinnetje in een scoregaatje voor elk codepinnetje van de juiste kleur op de juiste plaats.\nzwart scorepinnetjes: Zet een zwart scorepinnetje in een scoregaatje voor elk codepinnetje van de juiste kleur op een verkeerde plaats.\nLege scoregaatjes: Laat een scoregaatje leeg voor elk codepinnetje van een verkeerde kleur.\nCodebreker: vergeet niet dat het jouw doel is de code in zo min mogelijk pogingen te breken, dus bestudeer het antwoord van de codemaker aandachtig om het aantal keuzemogelijkheden te beperken.\nAls de codebreker de code ontcijfert, moet de computer het schermpje omklappen om de geheime code te laten zien. \nDe ronde is voorbij.De score word berekend";
        }
    }
}
