
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModel
{
    public class ViewModelInternautes:ViewModelBase
    {


    

      



        #region Attributes
        private Internaute _SelectedInternaute;
        private ObservableCollection<Internaute> _Internautes;
        #endregion

        #region Properties
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
        #endregion
        #region Constrcutor

        public ViewModelInternautes(MegaCastingEntities entities):base(entities)
        {
            this.Entities.Internautes.ToList();
            this.Internautes = this.Entities.Internautes.Local;
        }
        #endregion

        #region Method
        /// <summary>
        /// Ajouter un internaute
        /// </summary>
        public void InsertInternaute()
        {
            if (this.Entities.Internautes.Any(In => In.nom == "Nouveau nom") &&this.Entities.Internautes.Any(Ip=>Ip.prenom == "Nouveau prénom") )
            {
                Internaute internaute = new Internaute();
                internaute.nom = "Nouveau nom";
                internaute.prenom = "Nouveau prénom";
                this.Internautes.Add(internaute);
                this.SaveChanges();
                this.SelectedInternaute = internaute;

            }

        }



        /// <summary>
        /// supprimer un internaute
        /// </summary>

        public void DeleteInternaute()
        {
            // vérification de droit de suppression, table liée à OffresInternautes

            //suppression d'élément
            this.Internautes.Remove(SelectedInternaute);
            this.SaveChanges();
        }
        #endregion
    }
}
