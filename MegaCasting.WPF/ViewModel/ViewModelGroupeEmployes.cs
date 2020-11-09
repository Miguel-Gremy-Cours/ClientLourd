using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelGroupeEmployes:ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant la liste des GroupeEmployes de la base de donnée
        /// </summary>
        private ObservableCollection<GroupeEmploye> _GroupeEmployes;
        /// <summary>
        /// Attribut contenant le GroupeEmploye de la vue
        /// </summary>
        private GroupeEmploye _SelectedGroupeEmploye;
        /// <summary>
        /// Attribut contenant la liste des Employes de la base de donnée
        /// </summary>
        private ObservableCollection<Employe> _Employes;
        private Employe _Employe;
        #endregion
        #region Properties
        /// <summary>
        /// Employe de la vue
        /// </summary>
        public Employe Employe
        {
            get { return _Employe; }
            set { _Employe = value; }
        }
        /// <summary>
        /// Employes de la base de donnée
        /// </summary>
        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }
        /// <summary>
        /// GroupeEmployes de la base de donnée
        /// </summary>
        public ObservableCollection<GroupeEmploye> GroupeEmployes
        {
            get { return _GroupeEmployes; }
            set { _GroupeEmployes = value; }
        }
        /// <summary>
        /// GroupeEmploye de la vue
        /// </summary>
        public GroupeEmploye SelectedGroupeEmploye
        {
            get { return _SelectedGroupeEmploye; }
            set { _SelectedGroupeEmploye = value; }
        }
        #endregion
        #region Constrcutor
        public ViewModelGroupeEmployes(MegaCastingEntities entities):base(entities)
        {
            this.Entities.GroupeEmployes.ToList();
            this.GroupeEmployes = this.Entities.GroupeEmployes.Local;
            this.Entities.Employes.ToList();
            this.Employes = this.Entities.Employes.Local;
        }
        #endregion
        #region Method

        



        /// <summary>
        /// supprimer un groupe
        /// </summary>

        public void DeleteGropue()
        {
            
            var groupEmpty = (from G in GroupeEmployes
                              join emp in Employes
                              on G.Id equals emp.IdGroupeEmployes
                              into x
                              from emp in x.DefaultIfEmpty()
                              where G==null
                              select G
                              );

            if (groupEmpty.Contains(SelectedGroupeEmploye))
            {
                this.GroupeEmployes.Remove(SelectedGroupeEmploye);
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
