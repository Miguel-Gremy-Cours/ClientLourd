using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModel
{
    public class ViewModelContrat:ViewModelBase
    {







        #region Attributes
        private ObservableCollection<TypeContrat> _TypeContrats;
        private ObservableCollection<Contrat> _Contrats;
        private Contrat _SelectedContrat;
        private TypeContrat _SelectedTypeContrat;
        #endregion


        #region Properties
        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }

        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }
        public Contrat SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }
        public TypeContrat SelectedTypeContrat
        {
            get { return _SelectedTypeContrat; }
            set { _SelectedTypeContrat = value; }
        }


        #endregion


        #region Constructor
        public ViewModelContrat(MegaCastingEntities entities):base(entities)
        {
            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;

            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local;
        }
        #endregion


        #region Method
        /// <summary>
        /// Ajouter un nouveau type de contrat
        /// </summary>
        public void InsertContrat()
        {
            if (this.Entities.Contrats.Any(type => type.CodeContrat== "New"))
            {
                Contrat Contrat = new Contrat();

                Contrat.DureContrat = 1;

                
                this.Contrats.Add(Contrat);
                this.SaveChanges();
                this.SelectedContrat = Contrat;

            }

        }



        /// <summary>
        /// supprimer un type de contrat
        /// </summary>

        public void DeleteContrat()
        {
            // vérification de droit de suppression, aucune table liée

            //suppression d'élément
            this.Contrats.Remove(SelectedContrat);
            this.SaveChanges();
        }

        #endregion
    }
}
