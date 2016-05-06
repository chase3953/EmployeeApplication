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
    public class EmployeeSubordinateList : Event
    {
        #region Public Properties
        public BindingList<EmployeeSubordinate> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<EmployeeSubordinate> _List;

        #endregion

        #region Construction
        public EmployeeSubordinateList()
        {
            _List = new BindingList<EmployeeSubordinate>();
            _List.AddingNew += _List_AddingNew;
        }



        #endregion

        #region Public Methods
        public EmployeeSubordinateList GetByEmployeeId(Guid id)
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblEmployeeSubordinateGetByEmployeeId";
            database.Command.Parameters.Add("@EmployeeId", SqlDbType.UniqueIdentifier).Value = id;
            DataTable dt = database.ExecuteQuery();

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeSubordinate eSub = new EmployeeSubordinate();
                eSub.Initialize(dr);
                eSub.InitializeBusinessData(dr);
                eSub.IsNew = false;
                eSub.IsDirty = false;
                eSub.Savable += EmployeeSubordinate_Savable;
                _List.Add(eSub);
            }

            return this;
        }
        public bool Save(Database database, Guid parentId)
        {
            bool result = false;
            foreach (EmployeeSubordinate eSub in _List)
            {
                if (eSub.IsSavable() == true)
                {
                    eSub.Save(database, parentId);
                    if (eSub.IsNew == false)
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
            foreach (EmployeeSubordinate es in _List)
            {
                if (es.IsSavable() == true)
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
            e.NewObject = new EmployeeSubordinate();
            EmployeeSubordinate employeeSubordinate = (EmployeeSubordinate)e.NewObject;
            employeeSubordinate.Savable += EmployeeSubordinate_Savable;
        }

        private void EmployeeSubordinate_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }

        //private void EmployeePhone_Savable(SavableEventArgs e)
        //{
        //    RaiseEvent(e);
        //}
        #endregion
    }
}

