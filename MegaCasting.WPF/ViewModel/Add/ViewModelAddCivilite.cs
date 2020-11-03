using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddCivilite : ViewModelBase
    {
        #region Attributes
        private Civilite _Civilite;
        #endregion
        #region Accesseurs
        public Civilite Civilite
        {
            get { return _Civilite; }
            set { _Civilite = value; }
        }
        #endregion
        #region constructor
        public ViewModelAddCivilite(MegaCastingEntities entities) : base(entities)
        {
            this.Civilite = new Civilite();
        }
        #endregion
    }
}
