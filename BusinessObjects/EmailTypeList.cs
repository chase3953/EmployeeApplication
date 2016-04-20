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
    public class EmailTypeList : Event
    {

        #region Public Properties
        public BindingList<EmailType> List
        {
            get
            {
                return _List;
            }
        }
        #endregion

        #region Private Members
        private BindingList<EmailType> _List;

        #endregion

        #region Construction
        public EmailTypeList()
        {
            _List = new BindingList<EmailType>();
            _List.AddingNew += _List_AddingNew;
        }



        #endregion

        #region Public Methods
        public EmailTypeList GetAll()
        {
            Database database = new Database("Employer");
            database.Command.Parameters.Clear();
            database.Command.CommandType = System.Data.CommandType.StoredProcedure;
            database.Command.CommandText = "tblEmailTypeGetAll";
            DataTable dt = database.ExecuteQuery();
            EmailType blank = new EmailType();
            blank.Type = "Select an Email Type";
            _List.Add(blank);
            foreach (DataRow dr in dt.Rows)
            {
                EmailType e = new EmailType();
                e.Initialize(dr);
                e.InitializeBusinessData(dr);
                e.IsNew = false;
                e.IsDirty = false;
                e.Savable += EmailType_Savable;
                _List.Add(e);
            }

            return this;
        }
        public EmailTypeList Save()
        {
            foreach (EmailType pt in _List)
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
            e.NewObject = new EmailType();
            EmailType EmailType = (EmailType)e.NewObject;
            EmailType.Savable += EmailType_Savable;
        }

        private void EmailType_Savable(SavableEventArgs e)
        {
            RaiseEvent(e);
        }   
        #endregion
    }
}