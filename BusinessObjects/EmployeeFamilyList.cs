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
    public class EmployeeFamilyList : Event
    {
        #region Public Properties
        public BindingList<EmployeeFamily> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<EmployeeFamily> _List;

        #endregion

        #region Construction
        public EmployeeFamilyList()
        {
            _List = new BindingList<EmployeeFamily>();
            _List.AddingNew += _List_AddingNew;
        }



        #endregion

        #region Public Methods
        public EmployeeFamilyList GetByEmployeeId(Guid id)
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblEmployeeFamilyGetByEmployeeId";
            database.Command.Parameters.Add("@EmployeeId", SqlDbType.UniqueIdentifier).Value = id;
            DataTable dt = database.ExecuteQuery();

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeFamily eFam = new EmployeeFamily();
                eFam.Initialize(dr);
                eFam.InitializeBusinessData(dr);
                eFam.IsNew = false;
                eFam.IsDirty = false;
                eFam.Savable += EmployeeFamily_Savable;
                _List.Add(eFam);
            }

            return this;
        }
        public bool Save(Database database, Guid parentId)
        {
            bool result = false;
            foreach (EmployeeFamily eFam in _List)
            {
                if (eFam.IsSavable() == true)
                {
                    eFam.Save(database, parentId);
                    if (eFam.IsNew == false)
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
            foreach (EmployeeFamily ef in _List)
            {
                if (ef.IsSavable() == true)
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
            e.NewObject = new EmployeeFamily();
            EmployeeFamily employeeFamily = (EmployeeFamily)e.NewObject;
            employeeFamily.Savable += EmployeeFamily_Savable;         
        }

        private void EmployeeFamily_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }

        //private void EmployeeSubordinate_Savable(SavableEventArgs e)
        //{
        //    RaiseEvent(e);
        //}

        //private void EmployeePhone_Savable(SavableEventArgs e)
        //{
        //    RaiseEvent(e);
        //}
        #endregion
    }
}

