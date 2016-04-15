using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using System.Data;
using DatabaseHelper;

namespace BusinessObjects
{
    public class EmployeePhone : HeaderData
    {
        #region Private Members
        private Guid _EmployeeId = Guid.Empty;
        private String _Phone = String.Empty;
        private Guid _PhoneTypeID = Guid.Empty;
        #endregion

        #region Public Properties
        public Guid EmployeeID
        {
            get
            {
                return _EmployeeId;
            }
            set
            {
                if (_EmployeeId != value)
                {
                    _EmployeeId = value;
                    base.IsDirty = true;
                    bool Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }

        public Guid PhoneTypeID
        {
            get
            {
                return _PhoneTypeID;
            }
            set
            {
                if (_PhoneTypeID != value)
                {
                    _PhoneTypeID = value;
                    base.IsDirty = true;
                    bool Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }
        public String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                if (_Phone != value)
                {
                    _Phone = value;
                    base.IsDirty = true;
                    bool Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }
        #endregion

        #region Private Methods

        private Boolean Insert(Database database)
        {
            Boolean result = true;

            try
            {
                database.Command.Parameters.Clear();
                database.Command.CommandType = CommandType.StoredProcedure;
                database.Command.CommandText = "tblEmployeePhoneINSERT";
                database.Command.Parameters.Add("@EmployeeId", SqlDbType.UniqueIdentifier).Value = _EmployeeId;
                database.Command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = _Phone;
                database.Command.Parameters.Add("@PhoneTypeId", SqlDbType.UniqueIdentifier).Value = _PhoneTypeID;

                // Provides the empty buckets
                base.Initialize(database, Guid.Empty);
                database.ExecuteNonQueryWithTransaction();

                // Unloads the full buckets into the object
                base.Initialize(database.Command);
            }
            catch (Exception e)
            {
                result = false;
                throw;
            }

            // CHECK BACK HERE LATER!!!!!!
            return result;
        }

        private Boolean Update(Database database)
        {
            Boolean result = true;

            try
            {
                database.Command.Parameters.Clear();
                database.Command.CommandType = CommandType.StoredProcedure;
                database.Command.CommandText = "tblEmployeePhoneUPDATE";
                database.Command.Parameters.Add("@EmployeeId", SqlDbType.UniqueIdentifier).Value = _EmployeeId;
                database.Command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = _Phone;
                database.Command.Parameters.Add("@PhoneTypeId", SqlDbType.UniqueIdentifier).Value = _PhoneTypeID;
                

                // Provides the empty buckets
                base.Initialize(database, base.Id);
                database.ExecuteNonQueryWithTransaction();

                // Unloads the full buckets into the object
                base.Initialize(database.Command);
            }
            catch (Exception e)
            {
                result = false;
                throw;
            }

            return result;
        }

        private Boolean Delete(Database database)
        {
            Boolean result = true;

            try
            {
                database.Command.Parameters.Clear();
                database.Command.CommandType = CommandType.StoredProcedure;
                database.Command.CommandText = "tblEmployeePhoneDELETE";

                // Provides the empty buckets
                base.Initialize(database, base.Id);
                database.ExecuteNonQueryWithTransaction();

                // Unloads the full buckets into the object
                base.Initialize(database.Command);
            }
            catch (Exception e)
            {
                result = false;
                throw;
            }

            return result;
        }
        private bool IsValid()
        {
            bool result = true;

            if (_Phone.Trim() == string.Empty || _Phone.Trim() == string.Empty)
            {
                result = false;
            }
            if (_PhoneTypeID == Guid.Empty || _PhoneTypeID == null)
            {
                result = false;
            }
            if (_PhoneTypeID == null || _PhoneTypeID == Guid.Empty)
            {
                result = false;
            }
            if (_Phone.Length > 20)
            {
                result = false;
            }
            return result;           
        }

        #endregion

        #region Public Methods

        public EmployeePhone GetById(Guid id)
        {
            Database database = new Database("Employer");
            DataTable dt = new DataTable();
            database.Command.CommandType = CommandType.StoredProcedure;
            database.Command.CommandText = "tblEmployeePhoneGetId";
            base.Initialize(database, base.Id);
            dt = database.ExecuteQuery();
            if (dt != null && dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                base.Initialize(dr);
                InitializeBusinessData(dr);
                base.IsNew = false;
                base.IsDirty = false;

            }
            return this;
        }
        public void InitializeBusinessData(DataRow dr)
        {
            _EmployeeId = (Guid) dr["EmployeeId"];
            _PhoneTypeID = (Guid)dr["PhoneTypeID"];
            _Phone = dr["Phone"].ToString();        
        }
        public bool IsSavable()
        {
            bool result = false;
            if (base.IsDirty == true && IsValid() == true)
            {
                result = true;
            }
            return result;
        }
        public EmployeePhone Save(Database database, Guid parentId)
        {
            _EmployeeId = parentId;
            bool result = true;
            //Database database = new Database("Employer");
            if (base.IsNew == true && IsSavable())
            {
                result = Insert(database);
            }
            else if (base.Deleted == true && base.IsDirty == true)
            {
                result = Delete(database);
            }
            else if (base.IsNew == false && IsSavable() == true)
            {
                result = Update(database);
            }
            if (result == true)
            {
                base.IsDirty = false;
                base.IsNew = false;
            }
            return this;
        }
        #endregion

        #region Public Events

        #endregion

        #region Public Event Handlers

        #endregion

        #region Construction
        public EmployeePhone()
        {

        }
        #endregion
    }
}
