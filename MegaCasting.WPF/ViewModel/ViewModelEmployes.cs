using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModel
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
        #endregion

        #region Properties
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
        }
        #endregion
        /// <summary>
        /// Ajouter un employé
        /// </summary>
        public void InsertEmploye()
        {
            if (this.Entities.Employes.Any(person => person.Nom == "Nouveau Nom")&& this.Entities.Employes.Any(P=>P.Prenom=="Nouveau préNom"))
            {
                Employe employe = new Employe();
                employe.Nom = "Nouveau Nom";
                employe.Prenom = "Nouveau prénom";
                this.Employes.Add(employe);
                this.SaveChanges();
                this.SelectedEmploye = employe;

            }

        }



        /// <summary>
        /// supprimer un employé
        /// </summary>

        public void DeleteEmploye()
        {
            // vérification de droit de suppression, aucune table liée

            //suppression d'élément
            this.Employes.Remove(SelectedEmploye);
            this.SaveChanges();
        }
    }
}
