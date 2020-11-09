
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
    public class ViewModelCivilite : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant la Civilité selectionnée dans la vue
        /// </summary>
        private Civilite _SelectedCivilite;
        /// <summary>
        /// Attribut contenant la liste des civilités de la base de donnée
        /// </summary>
        private ObservableCollection<Civilite> _Civilites;
        #endregion
        #region Properties
        /// <summary>
        /// Civilité selectionnée dans la vue
        /// </summary>
        public Civilite SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
        }
        /// <summary>
        /// Civilités de la base de donnée
        /// </summary>
        public ObservableCollection<Civilite> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Constructeur de la classe 'ViewModelCivilite'
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelCivilite(MegaCastingEntities entities) : base(entities)
        {
            // Initialisation de la liste des Civilités dans la variable
            this.Entities.Civilites.ToList();
            this.Civilites = this.Entities.Civilites.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// Supprimer une civilité
        /// </summary>
        public void DeleteCivilite()
        {
            // Vérification de droit de suppression puis suppréssion d'élément
            if(!SelectedCivilite.Employes.Any() && SelectedCivilite.Internautes.Any())
            {
                this.Civilites.Remove(SelectedCivilite);
                this.SaveChanges();
            }
            else
            {
                MessageBox.Show("Impossibe de supprimer cet élément", "OK");
            }
        }
        #endregion
    }
}
