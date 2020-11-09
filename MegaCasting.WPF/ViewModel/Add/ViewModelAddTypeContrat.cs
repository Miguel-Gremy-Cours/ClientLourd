using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MegaCasting.WPF.ViewModel.Add
{
    class ViewModelAddTypeContrat : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut de TypeContrat qui sera créé
        /// </summary>
        private TypeContrat _TypeContrat;
        /// <summary>
        /// Attribut contenant la liste des TypeContrats de la base de données
        /// </summary>
        private ObservableCollection<TypeContrat> _TypeContrats;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Déclarer une propriété de type ObservableCollection, pour la liste de TypeContrat de la base de données
        /// </summary>
        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }
        /// <summary>
        /// Déclarer une propriété de type de Classe TypeContrat, pour TypeContrat qui sera créé
        /// </summary>
        public TypeContrat TypeContrat
        {
            get { return _TypeContrat; }
            set { _TypeContrat = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// Contructeur de ViewModelAddTypeContrat, dans lequel contient une liste de TypeContrats
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAddTypeContrat(MegaCastingEntities entities) : base(entities)
        {
            this.TypeContrat = new TypeContrat();
            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local;
        }
        #endregion

        #region Method
        /// <summary>
        /// Méthode pour ajouuter un nouveau TypeContrat, qui prendra le paramètre qui suivent
        /// </summary>
        /// <param name="libelle"></param>
        public void InserteTypeContrat(string libelle)
        {
            TypeContrat typeContrat = new TypeContrat();
            typeContrat.Libelle = libelle;
            this.TypeContrats.Add(typeContrat);
            this.SaveChanges();
        }
        #endregion


    }
}
