using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DatabaseHelper;
using System.Data;

namespace BusinessObjects
{
    public class EmployeeList : Event
    {
        #region Public Properties
        public BindingList<Employee> List
        {
            get
            {
                return _List;
            }
        }
        #endregion
        
        #region Private Members
        private BindingList<Employee> _List;

        #endregion
        
        #region Construction
        public EmployeeList()
        {
            _List = new BindingList<Employee>();
            _List.AddingNew += _List_AddingNew;
        }

        

        #endregion

        #region Public Methods
        public EmployeeList GetAll()
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblEmployeeGetAll";
            DataTable dt = database.ExecuteQuery();
            
            foreach (DataRow dr in dt.Rows)
            {
                Employee e = new Employee();
                e.Initialize(dr);
                e.InitializeBusinessData(dr);
                e.IsNew = false;
                e.IsDirty = false;
                e.Savable += Employee_Savable;
                e.Phones.Savable += Phones_Savable;
                _List.Add(e);
            }

            return this;
        }

       

        public EmployeeList Save()
        {
            foreach (Employee em in _List)
            {
                if (em.IsSavable() == true)
                {
                    em.Save();
                }
            }
            return this;
        }
        #endregion

        #region  Public Event Handlers
        private void _List_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Employee();
            Employee employee = (Employee)e.NewObject;
            employee.Savable += Employee_Savable;
            employee.Phones.Savable += Phones_Savable;
        }

        private void Employee_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }

        private void Phones_Savable(SavableEventArgs e)
        {
             RaiseEvent(e);
        }
        #endregion
    }
}
