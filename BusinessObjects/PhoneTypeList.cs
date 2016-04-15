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
    public class PhoneTypeList : Event
    {

        #region Public Properties
        public BindingList<PhoneType> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<PhoneType> _List;

        #endregion

        #region Construction
        public PhoneTypeList()
        {
            _List = new BindingList<PhoneType>();
            _List.AddingNew += _List_AddingNew;
        }



        #endregion

        #region Public Methods
        public PhoneTypeList GetAll()
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblPhoneTypeGetAll";
            DataTable dt = database.ExecuteQuery();
            PhoneType blank = new PhoneType();
            blank.Type = "Select a Phone Type";
            _List.Add(blank);
            foreach (DataRow dr in dt.Rows)
            {
                PhoneType e = new PhoneType();
                e.Initialize(dr);
                e.InitializeBusinessData(dr);
                e.IsNew = false;
                e.IsDirty = false;
                e.Savable += PhoneType_Savable;
                _List.Add(e);
            }

            return this;
        }
        public PhoneTypeList Save()
        {
            foreach (PhoneType pt in _List)
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
            e.NewObject = new PhoneType();
            PhoneType PhoneType = (PhoneType)e.NewObject;
            PhoneType.Savable += PhoneType_Savable;
        }

        private void PhoneType_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }
        #endregion
    }
}
