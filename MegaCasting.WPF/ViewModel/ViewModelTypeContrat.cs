using MegaCasting.DBLib;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelTypeContrat:ViewModelBase

    {

        #region Attributes
        #endregion

        #region Properties
        #endregion
        #region Constrcutor
        #endregion

        #region Attributes
        private TypeContrat _SelectedTypeContrat;
        private ObservableCollection<TypeContrat> _TypeContrats;
        #endregion

        #region Properties
        public TypeContrat SelectedTypeContrat
        {
            get { return _SelectedTypeContrat; }
            set { _SelectedTypeContrat = value; }
        }
        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }

        #endregion


        #region constrcutor


        public ViewModelTypeContrat(MegaCastingEntities entities):base(entities)
        {


            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local;
            
            //this.TypeContrats = new ObservableCollection<TypeContrat>();
            //foreach (TypeContrat typeContrat in this.Entities.TypeContrats) 
            //{
            //    this.TypeContrats.Add(typeContrat);
            //}
        }
        #endregion


        #region Méthode
        /// <summary>
        /// Sauvegarde de modification
        /// </summary>
        public void SaveChanges()
        {
            this.Entities.SaveChanges();
        }
        /// <summary>
        /// Ajouter un nouveau type de contrat
        /// </summary>
        public void InsertTypeContrats()
        {
            if(this.Entities.TypeContrats.Any(type=>type.libelle=="Nouveau type de contrat"))
            {
                TypeContrat typeContrat = new TypeContrat();
                typeContrat.libelle = "Nouveau type de contrat";
                this.TypeContrats.Add(typeContrat);
                this.SaveChanges();
                this.SelectedTypeContrat = typeContrat;

            }

        }


   
       /// <summary>
       /// supprimer un type de contrat
       /// </summary>

        public void DeleteTypeContrats()
        {
            // vérification de droit de suppression

            //suppression d'élément
            this.TypeContrats.Remove(SelectedTypeContrat);
            this.SaveChanges();
        }
        #endregion
    }
}
