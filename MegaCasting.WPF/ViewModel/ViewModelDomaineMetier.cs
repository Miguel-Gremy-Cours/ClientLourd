using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelDomaineMetier:ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Attribut contenant le DomaineMetier de la vue
        /// </summary>
        private DomaineMetier _SelectedDomaineMetier;
        /// <summary>
        /// Attribut contenant la liste des DomaineMetiers de la base de donnée
        /// </summary>
        private ObservableCollection<DomaineMetier> _DomaineMetiers;
        /// <summary>
        /// Attribut contenant la liste des Metiers de la base de donnée
        /// </summary>
        private ObservableCollection<Metier> _Metiers;
        #endregion
        #region Properties
        /// <summary>
        /// DomaineMetier de la vue
        /// </summary>
        public DomaineMetier SelectedDomaineMetier
        {
            get { return _SelectedDomaineMetier; }
            set { _SelectedDomaineMetier = value; }
        }
        /// <summary>
        /// DomaineMetiers de la base de donnée
        /// </summary>
        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetiers; }
            set { _DomaineMetiers = value; }
        }
        /// <summary>
        /// Metiers de la base de donnée
        /// </summary>
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }
        #endregion
        #region Constrcutor
        /// <summary>
        /// Constructeur de la classe ViewModelDomaineMetier
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelDomaineMetier(MegaCastingEntities entities) : base(entities)
        {
            // Initialisation de la liste des DomaineMetiers dans la variable
            this.Entities.DomaineMetiers.ToList();
            this.DomaineMetiers = this.Entities.DomaineMetiers.Local;
            // Initialisation de la liste des Metiers dans la variable
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// supprimer un domaine
        /// </summary>
        public void DeleteDomaineMetier()
        {
            // vérification de droit de suppression puis suppréssion d'élément
            if(!SelectedDomaineMetier.Metiers.Any())
            {
                this.DomaineMetiers.Remove(SelectedDomaineMetier);
                this.SaveChanges();
            }
            else
            {
                MessageBox.Show("Impossible de supprimer cet élément", "OK");
            }
        }
        #endregion
    }
}
