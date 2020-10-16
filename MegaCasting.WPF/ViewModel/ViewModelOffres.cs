
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
   public  class ViewModelOffres:ViewModelBase
    {

     

      

        #region Attributes
        private ObservableCollection<Offre> _Offres;
        private Offre _SelectedOffres;
        #endregion

        #region Properties
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }



        public Offre SelectedOffre
        {
            get { return _SelectedOffres; }
            set { _SelectedOffres = value; }
        }

        #endregion
        #region Constrcutor

        public ViewModelOffres(MegaCastingEntities entities):base(entities)
        {
            this.Offres = new ObservableCollection<Offre>();
            foreach(Offre offre in this.Entities.Offres)
            {
                this.Offres.Add(offre);
            }
        }
        #endregion
    }
}
