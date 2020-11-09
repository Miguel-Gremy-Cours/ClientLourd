using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelContrat : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant la liste des TypeContrats de la base de donnée
        /// </summary>
        private ObservableCollection<TypeContrat> _TypeContrats;
        /// <summary>
        /// Attribut contenant la liste des Contrats de la base de donnée
        /// </summary>
        private ObservableCollection<Contrat> _Contrats;
        /// <summary>
        /// Attribut contenant la liste des Offres de la base de donnée
        /// </summary>
        private ObservableCollection<Offre> _Offres;
        /// <summary>
        /// Attribut contenant l'offre séléctionnée dans la vue
        /// </summary>
        private Offre _SelectedOffre;
        /// <summary>
        /// Attribut contenant le contrat séléctionné dans la vue
        /// </summary>
        private Contrat _SelectedContrat;
        /// <summary>
        /// Attribut contenant le TypeContrat séléctionné dans la vue
        /// </summary>
        private TypeContrat _SelectedTypeContrat;
        #endregion
        #region Properties
        /// <summary>
        /// TypeContrat de la base de donnée
        /// </summary>
        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }
        /// <summary>
        /// Contrats de la base de donnée
        /// </summary>
        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
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
        /// Offre dans la vue
        /// </summary>
        public Offre SelectedOffre
        {
            get { return _SelectedOffre; }
            set { _SelectedOffre = value; }
        }
        /// <summary>
        /// Contrat de la vue
        /// </summary>
        public Contrat SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }
        /// <summary>
        /// TypeContrat de la vue
        /// </summary>
        public TypeContrat SelectedTypeContrat
        {
            get { return _SelectedTypeContrat; }
            set { _SelectedTypeContrat = value; }
        }


        #endregion
        #region Constructor
        /// <summary>
        /// Constructeur de la classe ViewModelContrat
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelContrat(MegaCastingEntities entities) : base(entities)
        {
            // Initialisation de la liste Contrats dans la variable
            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;
            // Initialisation de la liste TypeContrats dans la variable
            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local;
            // Initialisation de la liste Offres dans la variable
            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// Supprimer un type de contrat
        /// </summary>
        public void DeleteContrat()
        {
            // vérification de droit de suppression puis suppréssion
            this.Contrats.Remove(SelectedContrat);
            this.SaveChanges();
        }
        #endregion
    }
}
