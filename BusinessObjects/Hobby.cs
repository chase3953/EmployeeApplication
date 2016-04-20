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
    public class Hobby : HeaderData
    {
        #region Private Members
        private Guid _EmployeeId = Guid.Empty;
        private String _HobbyName = String.Empty;
        #endregion

        #region Public Properties
        public string HobbyName
        {
            get
            {
                return _HobbyName;
            }
            set
            {
                if (_HobbyName != value)
                {
                    _HobbyName = value;
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
                database.Command.CommandText = "tblHobbiesINSERT";
                database.Command.Parameters.Add("@HobbyName", SqlDbType.VarChar).Value = _HobbyName;

                // Provides the empty buckets
                base.Initialize(database, Guid.Empty);
                database.ExecuteNonQuery();

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
                database.Command.CommandText = "tblHobbiesUPDATE";
                database.Command.Parameters.Add("@HobbyName", SqlDbType.VarChar).Value = _HobbyName;

                // Provides the empty buckets
                base.Initialize(database, base.Id);
                database.ExecuteNonQuery();

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
                database.Command.CommandText = "tblHobbiesDELETE";

                // Provides the empty buckets
                base.Initialize(database, base.Id);
                database.ExecuteNonQuery();

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

            if (_HobbyName.Trim() == string.Empty || _HobbyName == null)
            {
                result = false;
            }
            if (_HobbyName.Length > 30 || _HobbyName.Length < 2)
            {
                result = false;
            }           
            return result;
        }

        #endregion

        #region Public Methods

        private Hobby GetById(Guid id)
        {
            Database database = new Database("Employer");
            DataTable dt = new DataTable();
            database.Command.CommandType = CommandType.StoredProcedure;
            database.Command.CommandText = "tblHobbiesGetId";
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
            _HobbyName = dr["HobbyName"].ToString();
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
        public Hobby Save()
        {
            bool result = true;
            Database database = new Database("Employer");
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

        #endregion
    }
}
