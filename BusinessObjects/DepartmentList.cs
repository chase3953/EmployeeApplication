using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatabaseHelper;
using System.ComponentModel;

namespace BusinessObjects
{
    public class DepartmentList : Event
    {
        #region Public Properties
        public BindingList<Department> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<Department> _List;

        #endregion

        #region Construction
        public DepartmentList()
        {
            _List = new BindingList<Department>();
            _List.AddingNew += _List_AddingNew;
        }

        #endregion

        #region Public Methods

        public bool IsSavable()
        {
            bool result = false;
            foreach (Department h in _List)
            {
                if (h.IsSavable() == true)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public DepartmentList GetAll()
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblDepartmentGetAll";
            DataTable dt = database.ExecuteQuery();
            Department blank = new Department();
            blank.Name = "Select a Department";
            _List.Add(blank);

            foreach (DataRow dr in dt.Rows)
            {
                Department d = new Department();
                d.Initialize(dr);
                d.InitializeBusinessData(dr);
                d.IsNew = false;
                d.IsDirty = false;
                d.Savable += Department_Savable;
                _List.Add(d);
            }

            return this;
        }

        public DepartmentList Save()
        {
            foreach (Department dep in _List)
            {
                if (dep.IsSavable() == true)
                {
                    dep.Save();
                }
            }
            return this;
        }
        #endregion

        #region  Public Event Handlers
        private void Department_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }
        private void _List_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Department();
            Department department = (Department)e.NewObject;
            department.Savable += Department_Savable;
        }






        #endregion
    }
}

