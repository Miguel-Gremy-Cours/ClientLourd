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
    class ViewModelAddSudios : ViewModelBase
    {
        #region Attributes
        private Studio _Studio;
        private ObservableCollection<Studio> _Studios;
        #endregion

        #region Accesseurs
        public ObservableCollection<Studio> Studios
        {
            get { return _Studios; }
            set { _Studios = value; }
        }

        public Studio Studio
        {
            get { return _Studio; }
            set { _Studio = value; }
        }
        #endregion
        #region Constructor
        public ViewModelAddSudios(MegaCastingEntities entities) : base(entities)
        {
            this.Studio = new Studio();
        }
        #endregion
        #region Method
        public void InsertStudio(string siret, string adresse, int numeroAdresse, string libelle, string email, string telephone)
        {
            Studio studio = new Studio();
            studio.Siret = siret;
            studio.Adresse = adresse;
            studio.NumeroAdresse = numeroAdresse;
            studio.Libelle = libelle;
            studio.Email = email;
            studio.Telephone = telephone;
            this.Studios.Add(studio);
            this.SaveChanges();
        }
        #endregion
    }
}
