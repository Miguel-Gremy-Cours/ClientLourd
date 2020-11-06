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
        private DomaineMetier _SelectedDomaineMetier;
        private ObservableCollection<DomaineMetier> _DomaineMetiers;
        private ObservableCollection<Metier> _Metiers;

        #endregion

        #region Properties
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }

        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetiers; }
            set { _DomaineMetiers = value; }
        }
        public DomaineMetier SelectedDomaineMetier
        {
            get { return _SelectedDomaineMetier; }
            set { _SelectedDomaineMetier = value; }
        }

        #endregion

        #region Constrcutor
        public ViewModelDomaineMetier(MegaCastingEntities entities) : base(entities)
        {


            this.Entities.DomaineMetiers.ToList();
            this.DomaineMetiers = this.Entities.DomaineMetiers.Local;
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;
            //this.TypeContrats = new ObservableCollection<TypeContrat>();
            //foreach (TypeContrat typeContrat in this.Entities.TypeContrats) 
            //{
            //    this.TypeContrats.Add(typeContrat);
            //}
        }

        #endregion
        #region Method

       
        /// <summary>
        /// supprimer un domaine
        /// </summary>

        public void DeleteDomaineMetier()
        {
            // vérification de droit de suppression, table liée à Metier
            var domaineEmpty = (from domaine in DomaineMetiers
                                join mt in Metiers
                                on domaine.Id equals mt.IdDomaineMetier
                                into x
                                from mt in x.DefaultIfEmpty()
                                where mt==null
                                select domaine
                                );
            //suppression d'élément
            if (domaineEmpty.Contains(SelectedDomaineMetier))
            {
                this.DomaineMetiers.Remove(SelectedDomaineMetier);
                this.SaveChanges();
            }
            else
            {
                MessageBox.Show("Cette table ne peut être supprimée car il y a des données liées!", "ERROR");
            }
            //try
            //{
            //    this.DomaineMetiers.Remove(SelectedDomaineMetier);
            //    this.SaveChanges();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Cette table ne peut être supprimée car il y a des données liées!", "ERROR");
            //}
        }
        #endregion
    }
}
