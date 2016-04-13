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
    public class HobbyTypeList : Event
    {
        #region Public Properties
        public BindingList<HobbyType> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<HobbyType> _List;

        #endregion

        #region Construction
        public HobbyTypeList()
        {
            _List = new BindingList<HobbyType>();
            _List.AddingNew += _List_AddingNew;
        }



        #endregion

        #region Public Methods
        public HobbyTypeList GetAll()
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblHobbiesGetAll";
            DataTable dt = database.ExecuteQuery();

            foreach (DataRow dr in dt.Rows)
            {
                HobbyType e = new HobbyType();
                e.Initialize(dr);
                e.InitializeBusinessData(dr);
                e.IsNew = false;
                e.IsDirty = false;
                e.Savable += HobbyType_Savable;
                _List.Add(e);
            }

            return this;
        }
        public HobbyTypeList Save()
        {
            foreach (HobbyType pt in _List)
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
            foreach (HobbyType h in _List)
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
            e.NewObject = new HobbyType();
            HobbyType HobbyType = (HobbyType)e.NewObject;
            HobbyType.Savable += HobbyType_Savable;
        }

        private void HobbyType_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }
        #endregion
    }
}
