
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


        public GroupeEmploye GroupeEmploye
        {
            get { return _SelecteedGroupeEmploye; }
            set { _SelecteedGroupeEmploye = value; }
        }
        #endregion
        #region Constrcutor

        public ViewModelGroupeEmployes(MegaCastingEntities entities):base(entities)
        {
            this.GroupeEmployes = new ObservableCollection<GroupeEmploye>();

            foreach(GroupeEmploye groupeEmploye in this.Entities.GroupeEmployes)
            {
                this.GroupeEmployes.Add(groupeEmploye);
            }
        }
        #endregion

    }
}
