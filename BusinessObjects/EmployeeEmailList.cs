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
    public class EmployeeEmailList : Event
    {
        #region Public Properties
        public BindingList<EmployeeEmail> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<EmployeeEmail> _List;

        #endregion

        #region Construction
        public EmployeeEmailList()
        {
            _List = new BindingList<EmployeeEmail>();
            _List.AddingNew += _List_AddingNew;
        }



        #endregion

        #region Public Methods
        public EmployeeEmailList GetByEmployeeId(Guid id)
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblEmployeeEmailGetByEmployeeId";
            database.Command.Parameters.Add("@EmployeeId", SqlDbType.UniqueIdentifier).Value = id;
            DataTable dt = database.ExecuteQuery();

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeEmail eEmail = new EmployeeEmail();
                eEmail.Initialize(dr);
                eEmail.InitializeBusinessData(dr);
                eEmail.IsNew = false;
                eEmail.IsDirty = false;
                eEmail.Savable += EmployeeEmail_Savable;
                _List.Add(eEmail);
            }

            return this;
        }
        public bool Save(Database database, Guid parentId)
        {
            bool result = false;
            foreach (EmployeeEmail eEmail in _List)
            {
                if (eEmail.IsSavable() == true)
                {
                    eEmail.Save(database, parentId);
                    if (eEmail.IsNew == false)
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
            foreach (EmployeeEmail ep in _List)
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
            e.NewObject = new EmployeeEmail();
            EmployeeEmail employeeEmail = (EmployeeEmail)e.NewObject;
            employeeEmail.Savable += EmployeeEmail_Savable;
        }

        private void EmployeeEmail_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }       
        #endregion
    }
}