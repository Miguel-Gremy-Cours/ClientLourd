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
        /// <summary>
        /// Attribut d'Internaute qui sera créé
        /// </summary>
        private Internaute _Internaute;
        /// <summary>
        /// Attribut contenant la liste des Civilites de la base de données
        /// </summary>
        private ObservableCollection<Civilite> _Civilites;
        /// <summary>
        /// Attribut contenant la Civilité selectionnée dans la vue
        /// </summary>
        private Civilite _SelectedCivilite;
        #endregion
        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété de type de Classe Internaute, pour Internaute qui sera créé
        /// </summary>
        public Internaute Internaute
        {
            get { return _Internaute; }
            set { _Internaute = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste des Civilites de la base de données
        /// </summary>
        public ObservableCollection<Civilite> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Civilite, pour la Civilite qui sera sélectionnée dans la vue
        /// </summary>
        public Civilite SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Contructeur de ViewModelAddInternaute, dans lequel contient une nouvelle instance d'Internaute, la liste des Civilites de la base de données
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddInternautes(MegaCastingEntities entities) : base(entities)
        {
            this.Internaute = new Internaute();

            this.Entities.Civilites.ToList();
            this.Civilites = this.Entities.Civilites.Local;
        }
        #endregion
        #region Method
        /// Méthode pour ajouter un nouvel Internaute
        #endregion
    }
}
