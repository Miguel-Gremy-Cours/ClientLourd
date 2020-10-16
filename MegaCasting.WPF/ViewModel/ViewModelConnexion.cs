using MegaCasting.DBLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelConnexion : ViewModelBase
    {



        public ViewModelConnexion(MegaCastingEntities entities) : base(entities)
        {



        }

        /// <summary>
        /// Récupère l'employé correspondant aux logins
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Employe GetEmployeeByLogs(string login, string password)
        {

            Employe employe = this.Entities.Employes.FirstOrDefault(empl => empl.login == login && empl.password == password);
            return employe;
        }
    }
}
