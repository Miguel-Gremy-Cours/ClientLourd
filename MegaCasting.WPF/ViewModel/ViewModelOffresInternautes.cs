
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
   public    class ViewModelOffresInternautes:ViewModelBase
    {

       

        #region Attributes
        private ObservableCollection<OffresInternaute> _OffresInternautes;
        private OffresInternaute _SelectedOffresInternaute;
        #endregion

        #region Properties
        public ObservableCollection<OffresInternaute> OffresInternautes
        {
            get { return _OffresInternautes; }
            set { _OffresInternautes = value; }
        }


        public OffresInternaute SelectedOffresInternaute
        {
            get { return _SelectedOffresInternaute; }
            set { _SelectedOffresInternaute = value; }
        }
        #endregion
        #region Constrcutor

        public ViewModelOffresInternautes(MegaCastingEntities entities):base(entities)
        {
            this.OffresInternautes = new ObservableCollection<OffresInternaute>();

            foreach(OffresInternaute offresInternaute in this.Entities.OffresInternautes)
            {
                this.OffresInternautes.Add(offresInternaute);
            }
        }
        #endregion
    }
}
