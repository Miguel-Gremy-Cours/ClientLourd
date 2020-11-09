using Caliburn.Micro;
using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddContrat : ViewModelBase
    {
        #region Attribute
        /// <summary>
        /// Attribut de Contrat qui sera créé
        /// </summary>
        private Contrat _Contrat;
        /// <summary>
        /// Attribut contenant la liste des TypeContrats de la base de donnée
        /// </summary>
        private ObservableCollection<TypeContrat> _TypeContrats;
        /// <summary>
        /// Attribut contenant le TypeContrat selectionné dans la vue
        /// </summary>
        private TypeContrat _SelectedTypeContrat;
        /// <summary>
        /// Attribut contenant la liste des Offres de la base de donnée
        /// </summary>
        private ObservableCollection<Offre> _Offres;
        /// <summary>
        /// Attribut contenant l'Offre selectionnée dans la vue
        /// </summary>
        private Offre _SelectedOffre;
        /// <summary>
        /// Attribut contenant la liste des Contrats de la base de donnée
        /// </summary>
        private ObservableCollection<Contrat> _Contrats;
        /// <summary>
        /// Attribut contenant le Contrat selectionné dans la vue
        /// </summary>
        private Contrat _SelectedContrat;
        #endregion
        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété "Contrat" de type de classe Contrat
        /// </summary>
        public Contrat Contrat
        {
            get { return _Contrat; }
            set { _Contrat = value; }
        }
        /// <summary>
        /// Déclarer une propriété TypeContrats de type ObservableCollection de TypeContrats
        /// </summary>
        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }
        /// <summary>
        /// Déclarer une propriété SelectedTypeContrat de type de classe TypeContrat
        /// </summary>
        public TypeContrat SelectedTypeContrat
        {
            get { return _SelectedTypeContrat; }
            set { _SelectedTypeContrat = value; }
        }
        /// <summary>
        /// Déclarer une propriété TypeContrats de type ObservableCollection de Ofrre
        /// </summary>
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        /// <summary>
        /// Déclarer une propriété SelectedContrat de type de classe Contrat
        /// </summary>
        public Contrat SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }
        /// <summary>
        /// Déclarer une propriété SelectedOffre de type de classe Offre
        /// </summary>
        public Offre SelectedOffre
        {
            get { return _SelectedOffre; }
            set { _SelectedOffre = value; }
        }
        /// <summary>
        /// Déclarer une propriété Contrats de type ObservableCollection de Contrat
        /// </summary>
        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Contructeur de ViewModelAddContrat, dans laquel contient la nouvelle instance de Contrat, la liste de TypeContrat, Offre et Contrat.
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddContrat(MegaCastingEntities entities) : base(entities)
        {
            this.Contrat = new Contrat();

            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local;

            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;

            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;
        }
        #endregion

        #region Method
        /// <summary>
        /// Méthode pour ajouter un nouveau contrat
        /// </summary>
        /// <param name="debutContrat"></param>
        /// <param name="dureContrat"></param>
        /// <param name="codeContrat"></param>
        /// <param name="fichierContrat"></param>
        public void InsertContrat(DateTime debutContrat, int dureContrat, string codeContrat, string fichierContrat)
        {
            Contrat contrat = new Contrat();

            contrat.TypeContrat = SelectedTypeContrat;
            contrat.DebutContrat = debutContrat;
            contrat.DureContrat = dureContrat;
            contrat.CodeContrat = codeContrat;
            contrat.FichierContrat = fichierContrat;
            contrat.Offre = SelectedOffre;

            this.Contrats.Add(contrat);
            this.SaveChanges();
            //this.SelectedContrat = contrat;
        }

        #endregion
    }
}
