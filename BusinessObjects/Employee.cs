﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatabaseHelper;

namespace BusinessObjects
{
    public class Employee : HeaderData
    {
        //
        //Check the end of the Insert()
        //

        #region Private Members
        private String _FirstName = String.Empty;
        private String _LastName = String.Empty;
        private Guid _DepartmentId = Guid.Empty;
        private EmployeePhoneList _Phones = null;
        private EmployeeEmailList _Emails = null;
        private EmployeeHobbyList _Hobbies = null;
        private EmployeeSubordinateList _Subordinates;
        private EmployeeFamilyList _Family;
        #endregion

        #region Public Properties
        public String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    base.IsDirty = true;
                    bool Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }
        public String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    base.IsDirty = true;
                    bool Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }

        public string FullName
        { get { return string.Concat(_FirstName, " ", _LastName); } }

        public Guid DepartmentId
        {
            get { return _DepartmentId;}
            set
            {
                if (_DepartmentId != value)
                {
                    _DepartmentId = value;
                    base.IsDirty = true;
                    bool Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }

        public EmployeeSubordinateList Subordinates
        {
            get
            {
                //LAZY LOADING
                if (_Subordinates == null)
                {
                    _Subordinates = new EmployeeSubordinateList();
                    _Subordinates = _Subordinates.GetByEmployeeId(base.Id);
                }
                return _Subordinates;
            }
        }    

        public EmployeePhoneList Phones
        {
            get
            {
                //LAZY LOADING
                if (_Phones == null)
                {
                    _Phones = new EmployeePhoneList();
                    _Phones = _Phones.GetByEmployeeId(base.Id);
                }
                return _Phones;
            }
        }
        public EmployeeEmailList Emails
        {
            get
            {
                //LAZY LOADING
                if (_Emails == null)
                {
                    _Emails = new EmployeeEmailList();
                    _Emails = _Emails.GetByEmployeeId(base.Id);
                }
                return _Emails;
            }
        }
        public EmployeeHobbyList HobbyName
        {
            get
            {
                //LAZY LOADING
                if (_Hobbies == null)
                {
                    _Hobbies = new EmployeeHobbyList();
                    _Hobbies = _Hobbies.GetByEmployeeId(base.Id);
                }
                return _Hobbies;
            }
        }

        public EmployeeFamilyList Family
        {
            get
            {
                //LAZY LOADING
                if (_Family == null)
                {
                    _Family = new EmployeeFamilyList();
                    _Family = _Family.GetByEmployeeId(base.Id);
                }
                return _Family;
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
                database.Command.CommandText = "tblEmployeeINSERT";
                database.Command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = _FirstName;
                database.Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = _LastName;
                database.Command.Parameters.Add("@DepartmentId", SqlDbType.UniqueIdentifier).Value = _DepartmentId;

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
                database.Command.CommandText = "tblEmployeeUPDATE";
                database.Command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = _FirstName;
                database.Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = _LastName;
                database.Command.Parameters.Add("@DepartmentId", SqlDbType.UniqueIdentifier).Value = _DepartmentId;

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
                database.Command.CommandText = "tblEmployee_DELETE";

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

            if (_FirstName.Trim() == string.Empty)
            {
                result = false;
            }
            if (_LastName.Trim() == string.Empty)
            {
                result = false;
            }
            if (_FirstName.Length > 20)
            {
                result = false;
            }
            if (_LastName.Length > 20)
            {
                result = false;
            }
            if (_DepartmentId == Guid.Empty)
            {
                result = false;
            }
            return result;
        }

        #endregion

        #region Public Methods

        public Employee GetById(Guid id)
        {
            Database database = new Database("Employer");
            DataTable dt = new DataTable();
            database.Command.CommandType = CommandType.StoredProcedure;
            database.Command.CommandText = "tblEmployeeGetById";
            database.Command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = id;
            //base.Initialize(database, id);
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
            _FirstName = dr["Firstname"].ToString();
            _LastName = dr["LastName"].ToString();
            _DepartmentId = (Guid) dr["DepartmentId"];
        }
        public bool IsSavable()
        {
            bool result = false;
            if (base.IsDirty == true && IsValid() == true 
                ||(_Phones != null && _Phones.IsSavable()) == true
                ||(_Emails != null && _Emails.IsSavable() == true) 
                ||(_Hobbies != null && _Hobbies.IsSavable() == true
                || (_Family != null && _Family.IsSavable() == true
                ||(_Subordinates != null && _Subordinates.IsSavable()))))
            {
                result = true;
            }
            return result;
        }
        public Employee Save()
        {
            bool result = true;
            Database database = new Database("Employer");
            database.BeginTransaction();
            if (base.IsNew == true && IsSavable())
            {
                result = Insert(database);
            }
            else if (base.Deleted == true && base.IsDirty == true)
            {
                result = Delete(database);
            }
            else if (base.IsNew == false && IsValid() == true && IsDirty == true)
            {
                result = Update(database);
            }
            if (result == true)
            {
                base.IsDirty = false;
                base.IsNew = false;
            }
            //SAVE THE CHILDREN
            if (result == true && _Family != null && _Family.IsSavable() == true)
            {
                result = _Family.Save(database, base.Id);
            }
            if (result == true && _Subordinates != null && _Subordinates.IsSavable() == true)
            {
                result = _Subordinates.Save(database, base.Id);
            }
            if (result == true && _Phones != null && _Phones.IsSavable() == true)
            {
                result = _Phones.Save(database, base.Id);
            }
            if (result == true && _Emails != null && _Emails.IsSavable() == true)
            {
                result = _Emails.Save(database, base.Id);
            }
            if (result == true && _Hobbies != null && _Hobbies.IsSavable() == true)
            {
                result = _Hobbies.Save(database, base.Id);
            }
            if (result == true)
            {
                database.EndTransaction();
            }
            else
            {
                database.RollBack();
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
