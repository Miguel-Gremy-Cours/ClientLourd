

using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelStudios:ViewModelBase
    {



        #region Attributes
        private ObservableCollection<Studio> _Studios;
        private Studio _SelectedStudio;
        private ObservableCollection<Offre> _Offres;
        
        #endregion

        #region Properties
        

        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }

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
            this.Entities.Offres.ToList();
            this.Offres = this.Entities.Offres.Local;
        }
        #endregion

        #region Method
        /// <summary>
        /// supprimer un studio
        /// </summary>

        public void DeleteStudio()
        {
            // vérification de droit de suppression, table liée à Offre

            var studioEmpty = (from stu in Studios
                              join offre in Offres
                              on stu.Id equals offre.IdStudio
                              into x
                              from offre in x.DefaultIfEmpty()
                              where offre == null
                              select stu
                              );

            if (studioEmpty == null)
            {
                //suppression d'élément
                this.Studios.Remove(SelectedStudio);
                this.SaveChanges();
            }
            else
            {
                System.Windows.MessageBox.Show("Cette table ne peut être supprimée car il y a des données liées!", "ERROR");
            }
        }
        #endregion
    }
}
