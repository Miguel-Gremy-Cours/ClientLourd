using MegaCasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelConnexion : ViewModelBase
    {
        /// <summary>
        /// Constructeur de la classe ViewModelConnexion
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelConnexion(MegaCastingEntities entities) : base(entities)
        {
        }
        /// <summary>
        /// Récupère l'employé correspondant aux Logins
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public Employe GetEmployeeByLogs(string Login, string Password)
        {
            Employe employe = this.Entities.Employes.FirstOrDefault(empl => empl.Login == Login && empl.Password == Password);
            return employe;
        }
    }
}
