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
    public class EmployeeSubordinate : HeaderData
    {
        #region Private Members
        private Guid _EmployeeId = Guid.Empty;
        private Guid _SubordinateID = Guid.Empty;
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

        public Guid SubordinateID
        {
            get
            {
                return _SubordinateID;
            }
            set
            {
                if (_SubordinateID != value)
                {
                    _SubordinateID = value;
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
                database.Command.CommandText = "tblEmployeeSubordinateINSERT";
                database.Command.Parameters.Add("@EmployeeId", SqlDbType.UniqueIdentifier).Value = _EmployeeId;
                database.Command.Parameters.Add("@SubordinateId", SqlDbType.UniqueIdentifier).Value = _SubordinateID;

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
                database.Command.CommandText = "tblEmployeeSubordinateUPDATE";
                database.Command.Parameters.Add("@EmployeeId", SqlDbType.UniqueIdentifier).Value = _EmployeeId;
                database.Command.Parameters.Add("@SubordinateId", SqlDbType.UniqueIdentifier).Value = _SubordinateID;


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
                database.Command.CommandText = "tblEmployeeSubordinateDELETE";

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
            if (_SubordinateID == null || _SubordinateID == Guid.Empty)
            {
                result = false;
            }
            return result;
        }

        #endregion

        #region Public Methods

        public EmployeeSubordinate GetById(Guid id)
        {
            Database database = new Database("Employer");
            DataTable dt = new DataTable();
            database.Command.CommandType = CommandType.StoredProcedure;
            database.Command.CommandText = "tblEmployeeSubordinateGetId";
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
            _EmployeeId = (Guid)dr["EmployeeId"];
            _SubordinateID = (Guid)dr["SubordinateId"];
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
        public EmployeeSubordinate Save(Database database, Guid parentId)
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
        public EmployeeSubordinate()
        {

        }
        #endregion
    }
}