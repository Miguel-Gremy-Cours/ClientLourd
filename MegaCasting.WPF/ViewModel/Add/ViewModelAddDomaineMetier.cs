using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddDomaineMetier : ViewModelBase
    {
        #region Attributes
        private DomaineMetier _DomaineMetiers;
        #endregion
        #region Accesseurs
        public DomaineMetier DomaineMetier
        {
            get { return _DomaineMetiers; }
            set { _DomaineMetiers = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddDomaineMetier(MegaCastingEntities entities) : base(entities)
        {
            this.DomaineMetier = new DomaineMetier();
        }
        #endregion
    }
}
