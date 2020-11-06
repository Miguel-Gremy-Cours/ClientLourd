
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelMetier : ViewModelBase
    {



        #region Attributes
        private ObservableCollection<Metier> _Metiers;
        private Metier _SelectedMetier;
        private ObservableCollection<DomaineMetier> _DomaineMetier;
        private DomaineMetier _SelectedDomaineMetier;
        private ObservableCollection<Offre> _Offres;



        #endregion

        #region Properties
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
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
        public DomaineMetier SelectedDomaineMetier
        {
            get { return _SelectedDomaineMetier; }
            set { _SelectedDomaineMetier = value; }
        }



        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetier; }
            set { _DomaineMetier = value; }
        }

        #endregion


        #region Constructor

        public ViewModelMetier(MegaCastingEntities entities) : base(entities)
        {
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;

            this.Entities.DomaineMetiers.ToList();
            this.DomaineMetiers = this.Entities.DomaineMetiers.Local;
        }

        #endregion


        #region Method

     
        

        /// <summary>
        /// supprimer un métier
        /// </summary>
        public void DeleteMetier()
        {
            // vérification de droit de suppression, table Metier liée à Offre
            var emptyMetier = (from mt in Metiers
                               join of in Offres
                               on mt.Id equals of.IdMetier
                               into x
                               from of in x.DefaultIfEmpty()
                               where of == null
                               select mt
                               );

            //suppression d'élément
            if (emptyMetier.Contains(SelectedMetier))
            {
                this.Metiers.Remove(SelectedMetier);
                this.SaveChanges();
            }
            else
            {
                MessageBox.Show("Cette table ne peut être supprimée car il y a des données liées!", "ERROR");
            }
            
        }


        #endregion

    }
}
