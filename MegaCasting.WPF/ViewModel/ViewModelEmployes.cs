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
        private Employe _SelectedEmploye;
        private ObservableCollection<Employe> _Employes;
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
        #endregion
        #region constrcutor

        public ViewModelEmployes(MegaCastingEntities entities):base(entities)
        {
            this.Entities.Employes.ToList();
            this.Employes = this.Entities.Employes.Local;
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
                employe.Prenom = "Nouveau préNom";
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
