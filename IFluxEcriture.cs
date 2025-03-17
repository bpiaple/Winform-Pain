using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public interface IFluxEcriture
    {
        void Ecrire(int entier);
        void Ecrire(string chaine);
        void Ecrire(float reel);
    }
}
