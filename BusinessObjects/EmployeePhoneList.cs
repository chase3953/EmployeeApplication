using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DatabaseHelper;
using System.Data;
using BusinessObjects;

namespace BusinessObjects
{
    public class EmployeePhoneList : Event
    {
        #region Public Properties
        public BindingList<EmployeePhone> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<EmployeePhone> _List;

        #endregion

        #region Construction
        public EmployeePhoneList()
        {
            _List = new BindingList<EmployeePhone>();
            _List.AddingNew += _List_AddingNew;
        }



        #endregion

        #region Public Methods
        public EmployeePhoneList GetByEmployeeId(Guid id)
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblEmployeePhoneGetByEmployeeId";
            database.Command.Parameters.Add("@EmployeeId", SqlDbType.UniqueIdentifier).Value = id; 
            DataTable dt = database.ExecuteQuery();

            foreach (DataRow dr in dt.Rows)
            {
                EmployeePhone ePhone = new EmployeePhone();
                ePhone.Initialize(dr);
                ePhone.InitializeBusinessData(dr);
                ePhone.IsNew = false;
                ePhone.IsDirty = false;
                ePhone.Savable += EmployeePhone_Savable;
                _List.Add(ePhone);
            }

            return this;
        }
        public bool Save(Database database)
        {
            bool result = false;
            foreach (EmployeePhone ePhone in _List)
            {
                if (ePhone.IsSavable() == true)
                {
                    ePhone.Save(database);
                    if (ePhone.IsNew == false)
                    {
                        result = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }
        public bool IsSavable()
        {
            bool result = false;
            foreach (EmployeePhone ep in _List)
            {
                if (ep.IsSavable() == true)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        #endregion

        #region  Public Event Handlers
        private void _List_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new EmployeePhone();
            EmployeePhone employeePhone = (EmployeePhone)e.NewObject;
            employeePhone.Savable += EmployeePhone_Savable;
        }

        private void EmployeePhone_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }
        #endregion
    }
}
