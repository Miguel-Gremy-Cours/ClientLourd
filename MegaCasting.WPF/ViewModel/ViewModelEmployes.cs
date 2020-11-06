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
    public class ViewModelEmployes:ViewModelBase

    {

      

       





        #region Attributes
        private ObservableCollection<GroupeEmploye> _GroupeEmployes;
        private GroupeEmploye _SelectedGroupeEmploye;
        private Civilite _SelectedCivilite;
        private ObservableCollection<Civilite> _Civilites;
        private Employe _SelectedEmploye;
        private ObservableCollection<Employe> _Employes;
        private ObservableCollection<Offre> _Offres;
        #endregion

        #region Properties
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }

        public ObservableCollection<GroupeEmploye> GroupeEmployes
        {
            get { return _GroupeEmployes; }
            set { _GroupeEmployes = value; }
        }
        public GroupeEmploye SelectedGroupeEmploye
        {
            get { return _SelectedGroupeEmploye; }
            set { _SelectedGroupeEmploye = value; }
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
        public ObservableCollection<Civilite> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }
        public Civilite SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
        }

        #endregion
        #region constrcutor

        public ViewModelEmployes(MegaCastingEntities entities):base(entities)
        {
            this.Entities.Employes.ToList();
            this.Employes = this.Entities.Employes.Local;

            this.Entities.Civilites.ToList();
            this.Civilites = this.Entities.Civilites.Local;

            this.Entities.GroupeEmployes.ToList();
            this.GroupeEmployes = this.Entities.GroupeEmployes.Local;

            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;
        }
        #endregion



        #region Method


        /// <summary>
        /// supprimer un employé
        /// </summary>

        public void DeleteEmploye()
        {
            var EmployeEmpty = (from emp in Employes
                                join of in Offres
                                on emp.Id equals of.IdEmploye
                                into x
                                from of in x.DefaultIfEmpty()
                                where of == null
                                select emp
                              );
            // vérification de droit de suppression, aucune table liée
            if (EmployeEmpty.Contains(SelectedEmploye))
            {

            //suppression d'élément
            this.Employes.Remove(SelectedEmploye);
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
