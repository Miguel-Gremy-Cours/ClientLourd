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
    class ViewModelAddMetier : ViewModelBase
    {
        #region Attributes
        private Metier _Metier;
        private ObservableCollection<DomaineMetier> _DomaineMetiers;
        private DomaineMetier _SelectedDomaineMetier;
        #endregion
        #region Accesseurs
        public Metier Metier
        {
            get { return _Metier; }
            set { _Metier = value; }
        }
        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetiers; }
            set { _DomaineMetiers = value; }
        }
        public DomaineMetier SelectedDomaineMetiers
        {
            get { return _SelectedDomaineMetier; }
            set { _SelectedDomaineMetier = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddMetier(MegaCastingEntities entities) : base(entities)
        {
            this.Entities.DomaineMetiers.ToList();
            this.DomaineMetiers = this.Entities.DomaineMetiers.Local;
        }
        #endregion
    }
}
