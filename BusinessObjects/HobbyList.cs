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
    public class HobbyList : Event
    {
        #region Public Properties
        public BindingList<Hobby> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<Hobby> _List;

        #endregion

        #region Construction
        public HobbyList()
        {
            _List = new BindingList<Hobby>();
            _List.AddingNew += _List_AddingNew;
        }



        #endregion

        #region Public Methods
        public HobbyList GetAll()
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblHobbiesGetAll";
            DataTable dt = database.ExecuteQuery();

            foreach (DataRow dr in dt.Rows)
            {
                Hobby e = new Hobby();
                e.Initialize(dr);
                e.InitializeBusinessData(dr);
                e.IsNew = false;
                e.IsDirty = false;
                e.Savable += HobbyType_Savable;
                _List.Add(e);
            }

            return this;
        }
        public HobbyList Save()
        {
            foreach (Hobby pt in _List)
            {
                if (pt.IsSavable() == true)
                {
                    pt.Save();
                }
            }
            return this;
        }
        public bool IsSavable()
        {
            bool result = false;
            foreach (Hobby h in _List)
            {
                if (h.IsSavable() == true)
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
            e.NewObject = new Hobby();
            Hobby HobbyType = (Hobby)e.NewObject;
            HobbyType.Savable += HobbyType_Savable;
        }

        private void HobbyType_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }
        #endregion
    }
}
