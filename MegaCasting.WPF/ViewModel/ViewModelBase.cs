using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModel
{
    public abstract class ViewModelBase
    {

        #region Attributues
        private MegaCastingEntities _Entities;
        private ViewModelMainWindow _ViewModel;
        #endregion

        #region  Properties
        public MegaCastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }


        }
        public ViewModelMainWindow ViewModel
        {
            get { return _ViewModel; }
            set { _ViewModel = value; }
        }

        #endregion
        #region constrcutor


        public ViewModelBase(MegaCastingEntities entities)
        {
            this.Entities = entities;


        }
        #endregion

        #region Method
        /// <summary>
        /// Sauvegarde de modification
        /// </summary>
        public void SaveChanges()
        {
            this.Entities.SaveChanges();
        }
        #endregion
    }
}
