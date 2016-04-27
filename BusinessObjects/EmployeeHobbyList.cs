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
    public class EmployeeHobbyList : Event
    {
        #region Public Properties
        public BindingList<EmployeeHobby> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<EmployeeHobby> _List;

        #endregion

        #region Construction
        public EmployeeHobbyList()
        {
            _List = new BindingList<EmployeeHobby>();
            _List.AddingNew += _List_AddingNew;
        }



        #endregion

        #region Public Methods
        public EmployeeHobbyList GetByEmployeeId(Guid id)
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblEmployeeHobbyGetByEmployeeId";
            database.Command.Parameters.Add("@EmployeeId", SqlDbType.UniqueIdentifier).Value = id;
            DataTable dt = database.ExecuteQuery();

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeHobby eHobby = new EmployeeHobby();
                eHobby.Initialize(dr);
                eHobby.InitializeBusinessData(dr);
                eHobby.IsNew = false;
                eHobby.IsDirty = false;
                eHobby.Savable += EmployeeHobby_Savable;
                _List.Add(eHobby);
            }

            return this;
        }

        public bool Save(Database database, Guid parentId)
        {
            bool result = false;
            foreach (EmployeeHobby ePhone in _List)
            {
                if (ePhone.IsSavable() == true)
                {
                    ePhone.Save(database, parentId);
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
            foreach (EmployeeHobby ep in _List)
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
            e.NewObject = new EmployeeHobby();
            EmployeeHobby employeeHobby = (EmployeeHobby)e.NewObject;
            employeeHobby.Savable += EmployeeHobby_Savable;
        }

        private void EmployeeHobby_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }
        
        #endregion
    }
}
