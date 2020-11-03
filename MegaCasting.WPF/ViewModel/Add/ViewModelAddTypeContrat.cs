using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddTypeContrat : ViewModelBase
    {
        #region Attributes
        private TypeContrat _TypeContrat;
        #endregion
        #region Accesseurs
        public TypeContrat TypeContrat
        {
            get { return _TypeContrat; }
            set { _TypeContrat = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddTypeContrat(MegaCastingEntities entities) : base(entities)
        {
            this.TypeContrat = new TypeContrat();
        }
        #endregion
    }
}
