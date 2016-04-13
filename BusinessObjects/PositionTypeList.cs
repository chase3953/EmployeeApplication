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
    public class PositionTypeList : Event
    {
        #region Public Properties
        public BindingList<PositionType> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<PositionType> _List;

        #endregion

        #region Construction
        public PositionTypeList()
        {
            _List = new BindingList<PositionType>();
            _List.AddingNew += _List_AddingNew;
        }



        #endregion

        #region Public Methods
        public PositionTypeList GetAll()
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblPositionGetAll";
            DataTable dt = database.ExecuteQuery();

            foreach (DataRow dr in dt.Rows)
            {
                PositionType e = new PositionType();
                e.Initialize(dr);
                e.InitializeBusinessData(dr);
                e.IsNew = false;
                e.IsDirty = false;
                e.Savable += PositionType_Savable;
                _List.Add(e);
            }

            return this;
        }
        public PositionTypeList Save()
        {
            foreach (PositionType pt in _List)
            {
                if (pt.IsSavable() == true)
                {
                    pt.Save();
                }
            }
            return this;
        }
        #endregion

        #region  Public Event Handlers
        private void _List_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new PositionType();
            PositionType PositionType = (PositionType)e.NewObject;
            PositionType.Savable += PositionType_Savable;
        }

        private void PositionType_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }
        #endregion
    }
}

