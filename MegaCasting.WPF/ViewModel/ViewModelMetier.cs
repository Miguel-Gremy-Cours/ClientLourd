
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
    class ViewModelMetier : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant la liste des Metiers de la base de donnée
        /// </summary>
        private ObservableCollection<Metier> _Metiers;
        /// <summary>
        /// Attribut contenant le Metier de la vue
        /// </summary>
        private Metier _SelectedMetier;
        /// <summary>
        /// Attribut contenant la liste des DomaineMetiers de la base de donnée
        /// </summary>
        private ObservableCollection<DomaineMetier> _DomaineMetier;
        /// <summary>
        /// Attribut contenant le DomaineMetier de la vue
        /// </summary>
        private DomaineMetier _SelectedDomaineMetier;
        /// <summary>
        /// Attribut contenant la liste des Offres de la base de donnée
        /// </summary>
        private ObservableCollection<Offre> _Offres;
        #endregion
        #region Properties
        /// <summary>
        /// Offres de la base de donnée
        /// </summary>
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        /// <summary>
        /// Metier de la vue
        /// </summary>
        public Metier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }
        /// <summary>
        /// Metiers de la base de donnée
        /// </summary>
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }

            set { _Metiers = value; }
        }
        /// <summary>
        /// DomaineMetier de la vue
        /// </summary>
        public DomaineMetier SelectedDomaineMetier
        {
            get { return _SelectedDomaineMetier; }
            set { _SelectedDomaineMetier = value; }
        }
        /// <summary>
        /// DomaineMetier de la base de donnée
        /// </summary>
        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetier; }
            set { _DomaineMetier = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Constructeur de la classe ViewModelMetier
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelMetier(MegaCastingEntities entities) : base(entities)
        {
            // Initialisation de la liste des Metiers dans la base de donnée
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;
            // Initialisation de la liste des DomaineMetiers dans la base de donnée
            this.Entities.DomaineMetiers.ToList();
            this.DomaineMetiers = this.Entities.DomaineMetiers.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// supprimer un métier
        /// </summary>
        public void DeleteMetier()
        {
            // vérification de droit de suppression puis suppréssion d'un élément
            if(!SelectedMetier.Offres.Any())
            {
                this.Metiers.Remove(SelectedMetier);
                this.SaveChanges();
            }
            else
            {
                MessageBox.Show("Impossible de supprimer cet élément", "OK");
            }   
        }
        #endregion
    }
}
