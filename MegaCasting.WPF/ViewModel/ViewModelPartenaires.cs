
using Caliburn.Micro;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelPartenaires : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant le Partenaire de la vue
        /// </summary>
        private Partenaire _SelectedPartenaire;
        /// <summary>
        /// Attribut contenant la liste des Partenaires de la base de donnée
        /// </summary>
        private ObservableCollection<Partenaire> _Partenaires;
        #endregion
        #region Properties
        /// <summary>
        /// Partenaires de la base de donnée
        /// </summary>
        public ObservableCollection<Partenaire> Partenaires
        {
            get { return _Partenaires; }
            set { _Partenaires = value; }
        }
        /// <summary>
        /// Partenaire de la vue
        /// </summary>
        public Partenaire SelectedPartenaire
        {
            get { return _SelectedPartenaire; }
            set { _SelectedPartenaire = value; }
        }
        #endregion
        #region Constrcutor
        public ViewModelPartenaires(MegaCastingEntities entities) : base(entities)
        {
            // Initialisation de la liste des Partenaires en base de donnée
            this.Entities.Partenaires.ToList();
            this.Partenaires = this.Entities.Partenaires.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// supprimer un partenaire
        /// </summary>
        public void DeletePartenaire()
        {
            // vérification de droit de suppression puis suppréssion des éléments
            try
            {
                this.Partenaires.Remove(SelectedPartenaire);
                this.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de supprimer cet élément", "OK");
            }
        }
        #endregion
    }
}
