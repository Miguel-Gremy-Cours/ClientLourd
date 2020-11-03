using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddGroupeEmployes : ViewModelBase
    {
        #region Attributes
        private GroupeEmploye _GroupeEmploye;
        #endregion
        #region Accesseurs
        public GroupeEmploye GroupeEmploye
        {
            get { return _GroupeEmploye; }
            set { _GroupeEmploye = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddGroupeEmployes(MegaCastingEntities entities) : base(entities)
        {
            this.GroupeEmploye = new GroupeEmploye();
        }
        #endregion
    }
}
