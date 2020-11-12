using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.WPF.Windows;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddDomaineMetier : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut de DomaineMetier qui sera créé
        /// </summary>
        private DomaineMetier _DomianeMetier;
        /// <summary>
        /// Attribut contenant la liste des DomaineMetiers de la base de donnée
        /// </summary>
        private ObservableCollection<DomaineMetier> _DomaineMetiers;
        /// <summary>
        /// Attribut contenant le DomaineMetier selectionné dans la vue
        /// </summary>
        private DomaineMetier _SelectedDomaineMetier;


        #endregion
        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété de type de classe DomaineMetier, pour DomaineMetier qui sera selectionné dans la vue
        /// </summary>
        public DomaineMetier SelectedDomaineMetier
        {
            get { return _SelectedDomaineMetier; }
            set { _SelectedDomaineMetier = value; }
        }

        /// <summary>
        /// Déclarer une propriété de type de classe DomaineMetier, pour DomaineMetier qui sera créé
        /// </summary>
        public DomaineMetier DomaineMetier
        {
            get { return _DomianeMetier; }
            set { _DomianeMetier = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste de DomaineMetiers de la base de données
        /// </summary>
        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetiers; }
            set { _DomaineMetiers = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Contraucteur de ViewModelAddDomaineMetier, dans lequel contient la nouvelle instance de DomaineMetier, la liste de DomaineMetiers de la base de données
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddDomaineMetier(MegaCastingEntities entities) : base(entities)
        {
            this.DomaineMetier = new DomaineMetier();
            this.Entities.DomaineMetiers.ToList();
            this.DomaineMetiers = this.Entities.DomaineMetiers.Local;
        }
        #endregion

        #region Method
        /// <summary>
        /// Méthode pour ajouter un nouveau DomaineMetier, prendra les parametères qui suivent
        /// </summary>
        /// <param name="libelle"></param>
        public void InsertDomaineMetier(string libelle)
        {
            DomaineMetier domaineMetier = new DomaineMetier();

            domaineMetier.Libelle = libelle;


            if (domaineMetier.Libelle != null)
            {

            this.DomaineMetiers.Add(domaineMetier);
            this.SaveChanges();
                WindowSucces window =new WindowSucces();
            }
            else
            {
                WindowErrorChampEmpty window = new WindowErrorChampEmpty();
            }
            
        }
        #endregion
    }
}
