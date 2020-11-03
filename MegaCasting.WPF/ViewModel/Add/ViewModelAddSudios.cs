using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddSudios : ViewModelBase
    {
        #region Attributes
        private Studio _Studio;
        #endregion
        #region Accesseurs
        public Studio Studio
        {
            get { return _Studio; }
            set { _Studio = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddSudios(MegaCastingEntities entities) : base(entities)
        {
            this.Studio = new Studio();
        }
        #endregion
    }
}
