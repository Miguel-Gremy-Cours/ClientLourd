using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelGroupeEmployes:ViewModelBase
    {




        #region Attributes
        private ObservableCollection<GroupeEmploye> _GroupeEmployes;
        private GroupeEmploye _SelecteedGroupeEmploye;
        #endregion

        #region Properties

        public ObservableCollection<GroupeEmploye> GroupeEmployes
        {
            get { return _GroupeEmployes; }
            set { _GroupeEmployes = value; }
        }


        public GroupeEmploye SelectedGroupeEmploye
        {
            get { return _SelecteedGroupeEmploye; }
            set { _SelecteedGroupeEmploye = value; }
        }
        #endregion
        #region Constrcutor

        public ViewModelGroupeEmployes(MegaCastingEntities entities):base(entities)
        {
            this.Entities.GroupeEmployes.ToList();
            this.GroupeEmployes = this.Entities.GroupeEmployes.Local;
        }
        #endregion
        #region Method

        /// <summary>
        /// Ajouter un groupe
        /// </summary>
        public void InsertGropue()
        {
            if (this.Entities.GroupeEmployes.Any(g => g.Libelle== "Nouveau groupe"))
            {
                GroupeEmploye groupeEmploye = new GroupeEmploye();
                groupeEmploye.Libelle = "Nouveau groupe";
                this.GroupeEmployes.Add(groupeEmploye);
                this.SaveChanges();
                this._SelecteedGroupeEmploye = groupeEmploye;

            }

        }



        /// <summary>
        /// supprimer un groupe
        /// </summary>

        public void DeleteGropue()
        {
            // vérification de droit de suppression, aucune table liée

            //suppression d'élément
            this.GroupeEmployes.Remove(SelectedGroupeEmploye);
            this.SaveChanges();
        }
        #endregion
    }
}
