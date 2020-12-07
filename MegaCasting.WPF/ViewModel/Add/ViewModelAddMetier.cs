using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCasting.WPF.Windows;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddMetier : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut de Metier qui sera créé
        /// </summary>
        private Metier _Metier;
        /// <summary>
        /// Attribut contenant la liste des DomaineMetier de la base de données
        /// </summary>
        private ObservableCollection<DomaineMetier> _DomaineMetiers;
        /// <summary>
        /// Attribut contenant le DomaineMetier selectionné dans la vue
        /// </summary>
        private DomaineMetier _SelectedDomaineMetier;
        /// <summary>
        /// Attribut contenant la liste des Metiers de la base de données
        /// </summary>
        private ObservableCollection<Metier> _Metiers;
        #endregion


        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste de Metiers de la base de données
        /// </summary>
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe Metier, pour Metier qui sera créé
        /// </summary>
        public Metier Metier
        {
            get { return _Metier; }
            set { _Metier = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste de DomaineMetier de la base de données
        /// </summary>
        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetiers; }
            set { _DomaineMetiers = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe DomaineMetier, pour la DomaineMetier qui sera sélectionné dans la vue
        /// </summary>
        public DomaineMetier SelectedDomaineMetier
        {
            get { return _SelectedDomaineMetier; }
            set { _SelectedDomaineMetier = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Contructeur de ViewModelAddMetier, dans lequel contient la liste de DomaineMetier et Metiers de la base de données
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddMetier(MegaCastingEntities entities) : base(entities)
        {
            this.Entities.DomaineMetiers.ToList();
            this.DomaineMetiers = this.Entities.DomaineMetiers.Local;
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;
        }
        #endregion

        #region Method
        /// <summary>
        /// Méthode pour ajouter un nouveau metier, qui prendra la paramètre qui suit.
        /// </summary>
        /// <param name="libelle"></param>
         public void InsertMetier(string libelle)
        {
            Metier metier = new Metier();
            metier.Libelle = libelle;
            metier.DomaineMetier = SelectedDomaineMetier;


            if (metier.Libelle!= null && metier.DomaineMetier!=null)
            {
                if (!Entities.Metiers.Any(m=>m.Libelle==libelle))
                {
                    this.Metiers.Add(metier);
                    this.SaveChanges();
                    WindowSucces window = new WindowSucces();
                }
                else
                {
                    ErrorDoubleElement errorDoubleElement = new ErrorDoubleElement();
                }
            }
            else
            {
                WindowErrorChampEmpty window = new WindowErrorChampEmpty();
            }
        }
        #endregion
    }
}
