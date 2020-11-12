
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelMainWindow:ViewModelConnexion
    {
        #region Attributes

        private Employe _CurrentEmploye;
        #endregion
        #region Properties
        public Employe CurrentEmploye
        {
            get { return _CurrentEmploye; }
            set { _CurrentEmploye = value; }
        }
        #endregion
        #region constrcutor
        /// <summary>
        /// Contrusteur de la classe ViewModelMainWindow
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelMainWindow(MegaCastingEntities entities):base(entities)
        {
            //this.CurrentEmploye=
        }
        #endregion

        
    }
}
