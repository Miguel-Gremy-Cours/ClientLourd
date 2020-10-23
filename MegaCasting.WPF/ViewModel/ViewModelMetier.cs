
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModel
{
    class ViewModelMetier:ViewModelBase
    {



        #region Attributes
        private ObservableCollection<Metier> _Metiers;
        private Metier _SelectedMetier;

        #endregion

        #region Properties
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


        #endregion


        #region Constructor

        public ViewModelMetier(MegaCastingEntities entities):base(entities)
        {
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;
        }

        #endregion


        #region Method

        /// <summary>
        /// ajouter un métier
        /// </summary>
       public void InsertMetier()
        {

            if(this.Entities.Metiers.Any(m=>m.libelle=="Nouveau métier"))
            {
                Metier metier = new Metier();
                metier.libelle = "Nouveau métier";
                //TODO: Selectionner un DomaineMetier, lui affecter id de DomaineMetier

                metier.DomaineMetier.libelle = "DomaineMetier";


                this.Metiers.Add(metier);
                this.SaveChanges();
                this.SelectedMetier = metier;
            }
        }

        /// <summary>
        /// supprimer un métier
        /// </summary>
        public void DeleteMetier()
        {
            // vérification de droit de suppression, table Metier liée à Offre
            //
            //suppression d'élément
            this.Metiers.Remove(SelectedMetier);
            this.SaveChanges();
        }


        #endregion

    }
}
