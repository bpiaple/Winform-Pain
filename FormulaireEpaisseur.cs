using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormulaireEpaisseur : Form
    {
        public FormulaireEpaisseur()
        {
            InitializeComponent();
        }

    public float ValeurEpaisseur
    {
        get { return (float)changeurEpaisseur.Value; }
        set
        {
            decimal nouvelleValeur = (decimal)Math.Max((float)changeurEpaisseur.Minimum, Math.Min((float)changeurEpaisseur.Maximum, value));
            changeurEpaisseur.Value = nouvelleValeur;
        }
    }

    }
}
