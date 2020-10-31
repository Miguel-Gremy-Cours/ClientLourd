

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
        private ObservableCollection<Metier> _Metiers;
        private Metier _SelectedMetier;
        private ObservableCollection<Studio> _Studios;
        private Studio _SelectedStudio;
        private ObservableCollection<Offre> _Offres;
        private Offre _SelectedOffres;
        private ObservableCollection<Employe> _Employes;
        private Employe _SelectedEmploye;
        #endregion

        #region Properties
        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }


        public Employe SelectedEmploye
        {
            get { return _SelectedEmploye; }
            set { _SelectedEmploye = value; }
        }
        public Metier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }

            set { _Metiers = value; }
        }
        public ObservableCollection<Studio> Studios
        {
            get { return _Studios; }
            set { _Studios = value; }
        }
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }

        public Studio SelectedStudio
        {
            get { return _SelectedStudio; }
            set { _SelectedStudio = value; }
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
            this.Entities.Studios.ToList();
            this.Studios = this.Entities.Studios.Local;
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;
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
