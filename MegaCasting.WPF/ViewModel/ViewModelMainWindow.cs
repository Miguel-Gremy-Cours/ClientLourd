
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelMainWindow:ViewModelBase
    {
        #region constrcutor
        /// <summary>
        /// Contrusteur de la classe ViewModelMainWindow
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelMainWindow(MegaCastingEntities entities):base(entities)
        {
        }
        #endregion
    }
}
