using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddDomaineMetier : ViewModelBase
    {
        #region Attributes
        private DomaineMetier _DomianeMetier;
        private ObservableCollection<DomaineMetier> _DomaineMetiers;
        private DomaineMetier _SelectedDomaineMetier;


        #endregion
        #region Accesseurs
        public DomaineMetier SelectedDomaineMetier
        {
            get { return _SelectedDomaineMetier; }
            set { _SelectedDomaineMetier = value; }
        }
        public DomaineMetier DomaineMetier
        {
            get { return _DomianeMetier; }
            set { _DomianeMetier = value; }
        }
        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetiers; }
            set { _DomaineMetiers = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddDomaineMetier(MegaCastingEntities entities) : base(entities)
        {
            this.DomaineMetier = new DomaineMetier();
            this.Entities.DomaineMetiers.ToList();
            this.DomaineMetiers = this.Entities.DomaineMetiers.Local;
        }
        #endregion

        #region Method
        public void InsertDomaineMetier(string libelle)
        {
            DomaineMetier domaineMetier = new DomaineMetier();

            domaineMetier.Libelle = libelle;

            this.DomaineMetiers.Add(domaineMetier);
            this.SaveChanges();
            
        }
        #endregion
    }
}
