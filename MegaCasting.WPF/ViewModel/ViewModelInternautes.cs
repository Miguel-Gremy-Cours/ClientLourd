
using MegaCasting.DBLib;
using MegaCasting.WPF.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelInternautes : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant la Civilite de la vue
        /// </summary>
        private Civilite _SelectedCivilite;
        /// <summary>
        /// Attribut contenant la liste des Civilites de la base de donnée
        /// </summary>
        private ObservableCollection<Civilite> _Civilites;
        /// <summary>
        /// Attribut contenant l'Internaute de la vue
        /// </summary>
        private Internaute _SelectedInternaute;
        /// <summary>
        /// Attribut contennant la liste des Internautes de la base de donnée
        /// </summary>
        private ObservableCollection<Internaute> _Internautes;
        #endregion
        #region Properties
        /// <summary>
        /// Civilites de la base de donnée
        /// </summary>
        public ObservableCollection<Civilite> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }
        /// <summary>
        /// Civilite de la vue
        /// </summary>
        public Civilite SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
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
        /// Internautes de la base de donnée
        /// </summary>
        public ObservableCollection<Internaute> Internautes
        {
            get { return _Internautes; }
            set { _Internautes = value; }
        }
        #endregion
        #region Constrcutor
        /// <summary>
        /// Contructeur de la classe ViewModelInternautes
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelInternautes(MegaCastingEntities entities) : base(entities)
        {
            // Initialisation de la liste Internautes dans la base de donnée
            this.Entities.Internautes.ToList();
            this.Internautes = this.Entities.Internautes.Local;
            // Initialisation de la liste Civilites dans la base de donnée
            this.Entities.Civilites.ToList();
            this.Civilites = this.Entities.Civilites.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// supprimer un internaute
        /// </summary>
        public void DeleteInternaute()
        {
            // vérification de droit de suppression puis suppréssion d'un élément
            if(!SelectedInternaute.OffresInternautes.Any())
            {
                this.Internautes.Remove(SelectedInternaute);
                this.SaveChanges();
            }
            else
            {
                SuppresionError suppresionError = new SuppresionError();
                suppresionError.ShowDialog();
            }
        }
        #endregion
    }
}
