
using MahApps.Metro.Behaviors;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
   public    class ViewModelOffresInternautes:ViewModelBase
    {



        #region Attributes
        private Internaute _SelectedInternaute;
        private ObservableCollection<Internaute> _Internautes;
        private ObservableCollection<OffresInternaute> _OffresInternautes;
        private OffresInternaute _SelectedOffresInternaute;
        private ObservableCollection<Offre> _Offres;
        private Offre _SelectedOffres;
        #endregion

        #region Properties
        public Offre SelectedOffre
        {
            get { return _SelectedOffres; }
            set { _SelectedOffres = value; }
        }

        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        public Internaute SelectedInternaute
        {
            get { return _SelectedInternaute; }
            set { _SelectedInternaute = value; }
        }
        public ObservableCollection<Internaute> Internautes
        {
            get { return _Internautes; }
            set { _Internautes = value; }
        }
        public ObservableCollection<OffresInternaute> OffresInternautes
        {
            get { return _OffresInternautes; }
            set { _OffresInternautes = value; }
        }


        public OffresInternaute SelectedOffresInternaute
        {
            get { return _SelectedOffresInternaute; }
            set { _SelectedOffresInternaute = value; }
        }
        #endregion
        #region Constrcutor

        public ViewModelOffresInternautes(MegaCastingEntities entities):base(entities)
        {

            this.Entities.OffresInternautes.ToList();
            this.OffresInternautes = this.Entities.OffresInternautes.Local;

            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;

            this.Entities.Internautes.ToList();
            this.Internautes = this.Entities.Internautes.Local;
        }
        #endregion


        #region Method

        /// <summary>
        /// Ajouter une offreInternaute
        /// </summary>
        public void InsertOffreInternaute()
        {
            if (this.Entities.TypeContrats.Any(type => type.Libelle == "Nouvelle offreInternaute"))
            {
                OffresInternaute offresInternaute = new OffresInternaute();
                offresInternaute.DatePostulation = DateTime.Now ;
                this.OffresInternautes.Add(offresInternaute);
                this.SaveChanges();
                this.SelectedOffresInternaute = offresInternaute;

            }

        }



        /// <summary>
        /// supprimer une offreInternaute
        /// </summary>

        public void DeleteOffreInternaute()
        {
            // vérification de droit de suppression, aucune table liée

            //suppression d'élément
            this.OffresInternautes.Remove(SelectedOffresInternaute);
            this.SaveChanges();
        }
        #endregion


    }
}
