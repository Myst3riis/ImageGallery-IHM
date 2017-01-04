using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2015
{
    public interface IMemento
    {
        IMemento Restore();
        // Restore restaure l'état conservé dans ce Mémento
        // Le Mémento retourné permet de faciliter l'écriture de
        // l'opération Redo

    }
}
