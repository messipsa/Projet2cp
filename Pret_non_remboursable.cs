﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjp
{
    public class Pret_non_remboursable : Prets
    {
        public Pret_non_remboursable( Employé employé, Type_pret type, string motif, int num_pv, DateTime date_pv, double montant, DateTime date_demande, string montant_lettre) : base( employé, type, motif, num_pv, date_pv, montant, date_demande, montant_lettre)
        {
        }
    }
}
