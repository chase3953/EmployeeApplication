using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatabaseHelper;

namespace BusinessObjects
{
    public class PositionType : HeaderData
    {
        #region Private Members
        private String _Position = String.Empty;
        private double _MinimumPay = 0.0;
        private double _MaximumPay = 0.0;
        #endregion

        #region Public Properties
        public string Position
        {
            get
            {
                return _Position;
            }
            set
            {
                if (_Position != value)
                {
                    _Position = value;
                    base.IsDirty = true;
                    bool Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }
        public double MinimumPay
        {
            get
            {
                return _MinimumPay;
            }
            set
            {
                if (_MinimumPay != value)
                {
                    _MinimumPay = value;
                    base.IsDirty = true;
                    bool Savable = IsSavable();
                    SavableEventArgs e = new SavableEventArgs(Savable);
                    RaiseEvent(e);
                }
            }
        }
        public double MaximumPay
        {
            get
            {
                return _MaximumPay;
            }
            set
            {
                if (_MaximumPay != value)
                {
                    _MaximumPay = value;
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
                database.Command.CommandText = "tblPositionINSERT";
                database.Command.Parameters.Add("@Name", SqlDbType.VarChar).Value = _Position;
                database.Command.Parameters.Add("@MinimumPay", SqlDbType.Decimal).Value = _MinimumPay;
                database.Command.Parameters.Add("@MaximumPay", SqlDbType.VarChar).Value = _MaximumPay;


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
                database.Command.CommandText = "tblPositionUPDATE";
                database.Command.Parameters.Add("@Name", SqlDbType.VarChar).Value = _Position;
                database.Command.Parameters.Add("@MinimumPay", SqlDbType.Decimal).Value = _MinimumPay;
                database.Command.Parameters.Add("@MaximumPay", SqlDbType.VarChar).Value = _MaximumPay;


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
                database.Command.CommandText = "tblPositionDELETE";

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

            if (_Position.Trim() == string.Empty || _Position == null)
            {
                result = false;
            }
            if (_Position.Length > 30 || _Position.Length < 2)
            {
                result = false;
            }
            if (_MinimumPay <= 0 || _MinimumPay > double.MaxValue)
            {
                result = false;
            }
            if (_MaximumPay <= 0 || _MinimumPay > double.MaxValue)
            {
                result = false;
            }
            return result;
        }

        #endregion

        #region Public Methods

        private PositionType GetById(Guid id)
        {
            Database database = new Database("Employer");
            DataTable dt = new DataTable();
            database.Command.CommandType = CommandType.StoredProcedure;
            database.Command.CommandText = "tblPositionGetId";
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
            _Position = dr["PositionType"].ToString();
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
        public PositionType Save()
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
