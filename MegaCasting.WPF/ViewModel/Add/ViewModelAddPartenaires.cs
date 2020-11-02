using ClientLourd.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddPartenaires : ViewModelBase
    {
        #region Attributes
        private Partenaire _Partenaire;
        #endregion
        #region Accesseurs
        public Partenaire Partenaire
        {
            get { return _Partenaire; }
            set { _Partenaire = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddPartenaires(MegaCastingEntities entities) : base(entities)
        {
            this.Partenaire = new Partenaire();
        }
        #endregion
    }
}
