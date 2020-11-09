

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
        /// <summary>
        /// Attribut contenant la liste des Studios de la base de donnée
        /// </summary>
        private ObservableCollection<Studio> _Studios;
        /// <summary>
        /// Attribut contenant le Studio de la vue
        /// </summary>
        private Studio _SelectedStudio;
        /// <summary>
        /// Attribut contenant la liste des Offres de la base de donnée
        /// </summary>
        private ObservableCollection<Offre> _Offres;
        #endregion
        #region Properties
        /// <summary>
        /// Offres de la base de donnée
        /// </summary>
        public ObservableCollection<Offre> Offres
        {
            get { return _Offres; }
            set { _Offres = value; }
        }
        /// <summary>
        /// Studios de la base de donnée
        /// </summary>
        public ObservableCollection<Studio> Studios
        {
            get { return _Studios; }
            set { _Studios = value; }
        }
        /// <summary>
        /// Offre de la vue
        /// </summary>
        public Studio SelectedStudio
        {
            get { return _SelectedStudio; }
            set { _SelectedStudio = value; }
        }
        #endregion
        #region Constrcutor
        /// <summary>
        /// Constructeur de la classe ViewModelStudios
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelStudios(MegaCastingEntities entities):base(entities)
        {
            // Initialisation de la liste des Studios dans la base de donnée
            this.Entities.Studios.ToList();
            this.Studios = this.Entities.Studios.Local;
            // Initialisation de la liste des Offres dans la base de donnée
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
            // vérification de droit de suppression puis suppréssion d'un élément
            if(!SelectedStudio.Offres.Any())
            {
                this.Studios.Remove(SelectedStudio);
                this.SaveChanges();
            }
            else
            {
                System.Windows.MessageBox.Show("Impossible de supprimer cet élément", "OK");
            }
        }
        #endregion
    }
}
