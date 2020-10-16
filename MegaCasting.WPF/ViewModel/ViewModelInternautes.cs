
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelInternautes:ViewModelBase
    {


        private Internaute _SelectedInternautes;

        public Internaute Internaute
        {
            get { return _SelectedInternautes; }
            set { _SelectedInternautes = value; }
        }



        #region Attributes
        private ObservableCollection<Internaute> _Internautes;
        #endregion

        #region Properties
        public ObservableCollection<Internaute> Internautes
        {
            get { return _Internautes; }
            set { _Internautes = value; }
        }
        #endregion
        #region Constrcutor

        public ViewModelInternautes(MegaCastingEntities entities):base(entities)
        {
            this.Internautes = new ObservableCollection<Internaute>();
            foreach(Internaute internaute in this.Entities.Internautes)
            {
                this.Internautes.Add(internaute);
            }
        }
        #endregion

    }
}
