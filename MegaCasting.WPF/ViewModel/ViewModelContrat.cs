using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModel
{
    public class ViewModelContrat:ViewModelBase
    {




        #region Attributes
        private ObservableCollection<Contrat> _Contrats;
        private Contrat _SelectedContrat;

        #endregion


        #region Properties
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



        #endregion


        #region Constructor
        public ViewModelContrat(MegaCastingEntities entities):base(entities)
        {
            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;
        }
        #endregion


        #region Method
        /// <summary>
        /// Ajouter un nouveau type de contrat
        /// </summary>
        public void InsertContrat()
        {
            if (this.Entities.TypeContrats.Any(type => type.Libelle== "Nouveau contrat"))
            {
                Contrat Contrat = new Contrat();

                Contrat.DureContrat = 1;

                // remarque: ajouter un champ code de contrat pour faciliter administration de contrat car impossible de gérer sans une value unique mise à part id.
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
