using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddInternautes : ViewModelBase
    {
        #region Attributes
        private Internaute _Internaute;
        private ObservableCollection<Civilite> _Civilites;
        private Civilite _SelectedCivilite;
        #endregion
        #region Accesseurs
        public Internaute Internaute
        {
            get { return _Internaute; }
            set { _Internaute = value; }
        }
        public ObservableCollection<Civilite> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }
        public Civilite SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddInternautes(MegaCastingEntities entities) : base(entities)
        {
            this.Internaute = new Internaute();

            this.Entities.Civilites.ToList();
            this.Civilites = this.Entities.Civilites.Local;
        }
        #endregion
    }
}
