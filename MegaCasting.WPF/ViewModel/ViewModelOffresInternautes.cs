
using MahApps.Metro.Behaviors;
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
    public class ViewModelOffresInternautes : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant l'Internaute de la vue
        /// </summary>
        private Internaute _SelectedInternaute;
        /// <summary>
        /// Attribut contenant la liste des Internautes de la base de donnée
        /// </summary>
        private ObservableCollection<Internaute> _Internautes;
        /// <summary>
        /// Attribut contenant la liste des OffresInternautes de la base de donnée
        /// </summary>
        private ObservableCollection<OffresInternaute> _OffresInternautes;
        /// <summary>
        /// Attribut contenant l'OffreInternautes de la vue
        /// </summary>
        private OffresInternaute _SelectedOffresInternaute;
        /// <summary>
        /// Attribut contenant la liste des Offres de la base de donnée
        /// </summary>
        private ObservableCollection<Offre> _Offres;
        /// <summary>
        /// Attribut contenant l'Offre de la vue
        /// </summary>
        private Offre _SelectedOffres;
        #endregion
        #region Properties
        /// <summary>
        /// Offre de la vue
        /// </summary>
        public Offre SelectedOffre
        {
            get { return _SelectedOffres; }
            set { _SelectedOffres = value; }
        }
        /// <summary>
        /// Offres de la base de donnée
        /// </summary>
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        /// <summary>
        /// Internaute de la vue
        /// </summary>
        public Internaute SelectedInternaute
        {
            get { return _SelectedInternaute; }
            set { _SelectedInternaute = value; }
        }
        /// <summary>
        /// Internuates de la base de donnée
        /// </summary>
        public ObservableCollection<Internaute> Internautes
        {
            get { return _Internautes; }
            set { _Internautes = value; }
        }
        /// <summary>
        /// OffreInternautes de la base de donnée
        /// </summary>
        public ObservableCollection<OffresInternaute> OffresInternautes
        {
            get { return _OffresInternautes; }
            set { _OffresInternautes = value; }
        }
        /// <summary>
        /// OffreInternaute de la vue
        /// </summary>
        public OffresInternaute SelectedOffresInternaute
        {
            get { return _SelectedOffresInternaute; }
            set { _SelectedOffresInternaute = value; }
        }
        #endregion
        #region Constrcutor
        /// <summary>
        /// Constructeur de la classe ViewModelOffresInternautes
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelOffresInternautes(MegaCastingEntities entities) : base(entities)
        {
            // Initialisation de la liste des OffresInternautes dans la base de donnée
            this.Entities.OffresInternautes.ToList();
            this.OffresInternautes = this.Entities.OffresInternautes.Local;
            // Initialisation de la liste des Offres dans la base de donnée
            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;
            // Initialisation de la liste des Internautes dans la base de donnée
            this.Entities.Internautes.ToList();
            this.Internautes = this.Entities.Internautes.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// supprimer une offreInternaute
        /// </summary>
        public void DeleteOffreInternaute()
        {
            // vérification de droit de suppression puis suppréssion de l'élément
            try
            {
                this.OffresInternautes.Remove(SelectedOffresInternaute);
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
