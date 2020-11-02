using ClientLourd.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddOffresInternautes : ViewModelBase
    {
        #region Attributes
        private OffresInternaute _Offresinternautes;
        private ObservableCollection<Internaute> _Internautes;
        private Internaute _SelectedInternaute;
        private ObservableCollection<Offre> _Offres;
        private Offre _SelectedOffre;


        #endregion
        #region Accesseurs
        public OffresInternaute OffresInternautes
        {
            get { return _Offresinternautes; }
            set { _Offresinternautes = value; }
        }
        public ObservableCollection<Internaute> Internautes
        {
            get { return Internautes; }
            set { Internautes = value; }
        }
        public Internaute SelectedInternaute
        {
            get { return _SelectedInternaute; }
            set { _SelectedInternaute = value; }
        }
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        public Offre SelectedOffre
        {
            get { return _SelectedOffre; }
            set { _SelectedOffre = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddOffresInternautes(MegaCastingEntities entities) : base(entities)
        {
            this.OffresInternautes = new OffresInternaute();

            this.Entities.Internautes.ToList();
            this.Internautes = this.Entities.Internautes.Local;

            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;
        }
        #endregion
    }
}
