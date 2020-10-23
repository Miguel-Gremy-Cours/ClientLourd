
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModel
{
   public  class ViewModelOffres:ViewModelBase
    {

     

      

        #region Attributes
        private ObservableCollection<Offre> _Offres;
        private Offre _SelectedOffres;
        #endregion

        #region Properties
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }



        public Offre SelectedOffre
        {
            get { return _SelectedOffres; }
            set { _SelectedOffres = value; }
        }

        #endregion
        #region Constrcutor

        public ViewModelOffres(MegaCastingEntities entities):base(entities)
        {
            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;
        }
        #endregion


        #region Method
        /// <summary>
        /// Ajouter une offre
        /// </summary>
        public void InsertOffre()
        {
            if (this.Entities.Offres.Any(of => of.Intitule == "Nouvelle offre"))
            {
                Offre offre = new Offre();
                offre.Intitule = "Nouvelle offre";
                this.Offres.Add(offre);
                this.SaveChanges();
                this.SelectedOffre = offre;

            }

        }



        /// <summary>
        /// supprimer une offre
        /// </summary>

        public void DeleteOffre()
        {
            // vérification de droit de suppression, aucune table liée à offresInternautes

            //suppression d'élément
            this.Offres.Remove(SelectedOffre);
            this.SaveChanges();
        }
        #endregion
    }
}
