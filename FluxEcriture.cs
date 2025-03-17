using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class FluxEcriture : IFluxEcriture
    {
        private StreamWriter ecrivain_;
        public FluxEcriture(string nomFichier)
        {
            ecrivain_ = new(nomFichier);
        }
        public void Ecrire(string chaine)
        {
            ecrivain_.Write(chaine);
        }

        public void Ecrire(int entier)
        {
            ecrivain_.Write(entier);
        }

        public void Ecrire(float reel) {
            ecrivain_.Write(reel);
        }

        public void FermerWriter()
        {
            ecrivain_.Close();
        }
    }
}
