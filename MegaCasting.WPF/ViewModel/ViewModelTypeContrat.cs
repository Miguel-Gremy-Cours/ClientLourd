
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
    public class ViewModelTypeContrat : ViewModelBase

    {
        #region Attributes
        /// <summary>
        /// Attribut contenant le TypeContrat de la vue
        /// </summary>
        private TypeContrat _SelectedTypeContrat;
        /// <summary>
        /// Attribut contenant la liste des TypeContrats de la base de donnée
        /// </summary>
        private ObservableCollection<TypeContrat> _TypeContrats;
        /// <summary>
        /// Attribut contenant la liste des Contrats de la base de donnée
        /// </summary>
        private ObservableCollection<Contrat> _Contrats;
        #endregion
        #region Properties
        /// <summary>
        /// Contrats de la base de donnée
        /// </summary>
        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }
        /// <summary>
        /// TypeContrat de la vue
        /// </summary>
        public TypeContrat SelectedTypeContrat
        {
            get { return _SelectedTypeContrat; }
            set { _SelectedTypeContrat = value; }
        }
        /// <summary>
        /// TypeContrat de la base de donnée
        /// </summary>
        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }
        #endregion
        #region constrcutor
        /// <summary>
        /// Constructeur de la classe ViewModelTypeContrat
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelTypeContrat(MegaCastingEntities entities) : base(entities)
        {
            // Initialisation de la liste des TypeContrats dans la base de donnée
            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local;
            // Initialisation de la liste des Contrats dans la base de donnée
            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// supprimer un type de contrat
        /// </summary>
        public void DeleteTypeContrats()
        {
            // vérification de droit de suppression puis suppréssion de l'élément
            if (!SelectedTypeContrat.Contrats.Any())
            {
                this.TypeContrats.Remove(SelectedTypeContrat);
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
