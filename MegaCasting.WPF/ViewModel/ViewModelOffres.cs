

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
        private ObservableCollection<Contrat> _Contrats;
        #endregion

        #region Properties
        public ObservableCollection<Contrat> Contrats 
        {
            get { return _Contrats; }
            set {  _Contrats= value; }
        }

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
            this.Entities.Employes.ToList();
            this.Employes = this.Entities.Employes.Local;
            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;
        }
        #endregion


        #region Method
        /// <summary>
        /// supprimer une offre
        /// </summary>

        public void DeleteOffre()
        {
            // vérification de droit de suppression, aucune table liée à offresInternautes
            var EmptyOffre= (from of in Offres
                             join ctr in Contrats
                             on of.Id equals ctr.IdOffre
                             into x
                             from ctr in x.DefaultIfEmpty()
                             where ctr == null
                             select of
                              );
            //suppression d'élément
            if (EmptyOffre.Contains(SelectedOffre))
            {
                this.Offres.Remove(SelectedOffre);
                this.SaveChanges();
            }
            else
            {
                MessageBox.Show("Cette table ne peut être supprimée car il y a des données liées!", "ERROR");
            }
            //try
            //{
            //    this.Offres.Remove(SelectedOffre);
            //    this.SaveChanges();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Cette table ne peut être supprimée car il y a des données liées!", "ERROR");
            //}
        }
        #endregion
    }
}
