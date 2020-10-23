
using MahApps.Metro.Behaviors;
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModel
{
   public    class ViewModelOffresInternautes:ViewModelBase
    {

       

        #region Attributes
        private ObservableCollection<OffresInternaute> _OffresInternautes;
        private OffresInternaute _SelectedOffresInternaute;
        #endregion

        #region Properties
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
