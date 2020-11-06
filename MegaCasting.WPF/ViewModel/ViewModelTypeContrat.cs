
using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelTypeContrat:ViewModelBase

    {

        

        #region Attributes
        private TypeContrat _SelectedTypeContrat;
        private ObservableCollection<TypeContrat> _TypeContrats;
        private ObservableCollection<Contrat> _Contrats;
        #endregion

        #region Properties
        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }
        public TypeContrat SelectedTypeContrat
        {
            get { return _SelectedTypeContrat; }
            set { _SelectedTypeContrat = value; }
        }
        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }
        #endregion


        #region constrcutor


        public ViewModelTypeContrat(MegaCastingEntities entities):base(entities)
        {


            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local;
            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;
            //this.TypeContrats = new ObservableCollection<TypeContrat>();
            //foreach (TypeContrat typeContrat in this.Entities.TypeContrats) 
            //{
            //    this.TypeContrats.Add(typeContrat);
            //}
        }
        #endregion

        #region Method
       /// <summary>
       /// supprimer un type de contrat
       /// </summary>

        public void DeleteTypeContrats()
        {
            // vérification de droit de suppression, aucune table liée
            var typeEmpty = (from tp in TypeContrats
                             join ctr in Contrats
                             on tp.Id equals ctr.IdTypeContrat
                             into x
                             from ctr in x.DefaultIfEmpty()
                             where ctr == null
                             select tp
                              );
            //suppression d'élément


            if (typeEmpty.Contains(SelectedTypeContrat))
            {
                
                    this.TypeContrats.Remove(SelectedTypeContrat);
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
