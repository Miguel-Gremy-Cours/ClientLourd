

using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelStudios:ViewModelBase
    {



        #region Attributes
        private ObservableCollection<Studio> _Studios;
        private Studio _SelectedStudio;
        #endregion

        #region Properties
        public ObservableCollection<Studio> Studios
        {
            get { return _Studios; }
            set { _Studios = value; }
        }

        public Studio SelectedStudio
        {
            get { return _SelectedStudio; }
            set { _SelectedStudio = value; }
        }
        #endregion
        #region Constrcutor
        public ViewModelStudios(MegaCastingEntities entities):base(entities)
        {
            this.Entities.Studios.ToList();
            this.Studios = this.Entities.Studios.Local;
        }
        #endregion

        #region Method

        /// <summary>
        /// Ajouter un nouveau studio
        /// </summary>
        public void InsertStudio()
        {
            if (this.Entities.Studios.Any(stu => stu.Libelle == "Nouveau studio"))
            {
                Studio studio = new Studio();
                studio.Libelle = "Nouveau studio";
                this.Studios.Add(studio);
                this.SaveChanges();
                this.SelectedStudio = studio;

            }

        }



        /// <summary>
        /// supprimer un studio
        /// </summary>

        public void DeleteStudio()
        {
            // vérification de droit de suppression, table liée à Offre

            //suppression d'élément
            this.Studios.Remove(SelectedStudio);
            this.SaveChanges();
        }
        #endregion
    }
}
