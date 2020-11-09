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
    class ViewModelAddOffresInternautes : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut d'OffresInternaute qui sera créée
        /// </summary>
        private OffresInternaute _Offresinternautes;
        /// <summary>
        /// Attribut contenant la liste des Internautes de la base de données
        /// </summary>
        private ObservableCollection<Internaute> _Internautes;
        /// <summary>
        /// Attribut contenant l'Internaute selectionné dans la vue
        /// </summary>
        private Internaute _SelectedInternaute;
        /// <summary>
        /// Attribut contenant la liste des Offres de la base de données
        /// </summary>
        private ObservableCollection<Offre> _Offres;
        /// <summary>
        /// Attribut contenant l'Offre selectionnée dans la vue
        /// </summary>
        private Offre _SelectedOffre;


        #endregion
        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété de type de Classe OffresInternaute, pour OffresInternaute qui sera créé
        /// </summary>
        public OffresInternaute OffresInternautes
        {
            get { return _Offresinternautes; }
            set { _Offresinternautes = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste d'Internautes de la base de données
        /// </summary>
        public ObservableCollection<Internaute> Internautes
        {
            get { return _Internautes; }
            set { _Internautes = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Internaute, pour l'Internaute qui sera sélectionnée dans la vue
        /// </summary>
        public Internaute SelectedInternaute
        {
            get { return _SelectedInternaute; }
            set { _SelectedInternaute = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste d'Offres de la base de données
        /// </summary>
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Offre, pour l'Offre qui sera sélectionnée dans la vue
        /// </summary>
        public Offre SelectedOffre
        {
            get { return _SelectedOffre; }
            set { _SelectedOffre = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Contructeur pour ViewModelAddOffresInternautes, dans lequel contient les liste de Offres et Internautes de la base de données
        /// </summary>
        /// <param name="entities"></param>
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
