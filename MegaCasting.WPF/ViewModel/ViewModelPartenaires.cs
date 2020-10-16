
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
   public  class ViewModelPartenaires:ViewModelBase
    {




        #region Attributes
        private Partenaire _SelectedPartenaire;
        private ObservableCollection<Partenaire> _Partenaires;
        #endregion

        #region Properties

        public ObservableCollection<Partenaire> Partenaires
        {
            get { return _Partenaires; }
            set { _Partenaires = value; }
        }


        public Partenaire SelectedPartenaire
        {
            get { return _SelectedPartenaire; }
            set { _SelectedPartenaire = value; }
        }
        #endregion
        #region Constrcutor
        public ViewModelPartenaires(MegaCastingEntities entities):base(entities)
        {
            this.Partenaires = new ObservableCollection<Partenaire>();
            foreach(Partenaire partenaire in this.Entities.Partenaires)
            {
                this.Partenaires.Add(partenaire);
            }
        }
        #endregion
    }
}
