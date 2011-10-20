using System;
using System.Data;
using Spring.Data.Common;
using Spring.Expressions;
using Spring.Util;
using VMware.Data.SQLFire;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Repository
{
    /// <summary>
    /// Implemenation of of DbProvider that uses metadata to create provider specific ADO.NET objects.
    /// </summary>
    public class SqlFireDbProvider : IDbProvider
    {
        private string _connectionString;
        private readonly IDbMetadata _dbMetadata;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlFireDbProvider"/> class.
        /// </summary>
        /// <param name="dbMetadata">The db metadata.</param>
        public SqlFireDbProvider(IDbMetadata dbMetadata)
        {
            _dbMetadata = dbMetadata;
        }

        /// <summary>
        /// Returns a new command object for executing SQL statments/Stored Procedures
        /// against the database.
        /// </summary>
        /// <returns>An new <see cref="IDbCommand"/></returns>
        public IDbCommand CreateCommand()
        {
            return new SQLFCommand(null, null);
        }

        /// <summary>
        /// Returns a new instance of the providers CommandBuilder class.
        /// </summary>
        /// <returns>A new Command Builder</returns>
        /// <remarks>In .NET 1.1 there was no common base class or interface
        /// for command builders, hence the return signature is object to
        /// be portable (but more loosely typed) across .NET 1.1/2.0</remarks>
        public object CreateCommandBuilder()
        {
            return new SQLFCommandBuilder(null);
        }

        /// <summary>
        /// Returns a new connection object to communicate with the database.
        /// </summary>
        /// <returns>A new <see cref="IDbConnection"/></returns>
        public IDbConnection CreateConnection()
        {
            IDbConnection conn = new SQLFClientConnection();
            conn.ConnectionString = ConnectionString;
            return conn;
        }

        /// <summary>
        /// Returns a new adapter objects for use with offline DataSets.
        /// </summary>
        /// <returns>A new <see cref="IDbDataAdapter"/></returns>
        public IDbDataAdapter CreateDataAdapter()
        {
            return new SQLFDataAdapter();
        }

        /// <summary>
        /// Returns a new parameter object for binding values to parameter
        /// placeholders in SQL statements or Stored Procedure variables.
        /// </summary>
        /// <returns>A new <see cref="IDbDataParameter"/></returns>
        public IDbDataParameter CreateParameter()
        {
            return new SQLFParameter();
        }

        /// <summary>
        /// Creates the name of the parameter in the format appropriate to use inside IDbCommand.CommandText.
        /// </summary>
        /// <param name="name">The unformatted name of the parameter.</param>
        /// <returns>
        /// The parameter name formatted foran IDbCommand.CommandText.
        /// </returns>
        /// <remarks>In most cases this adds the parameter prefix to the name passed into this method.</remarks>
        public string CreateParameterName(string name)
        {
            if (_dbMetadata.BindByName)
            {
                if (DbMetadata.UseParameterPrefixInSql)
                {
                    return DbMetadata.ParameterNamePrefix + name;
                }
                else
                {
                    return name;
                }
            }
            else
            {
                return DbMetadata.ParameterNamePrefix;
            }
        }

        /// <summary>
        /// Creates the name ofthe parameter in the format appropriate for an IDataParameter, i.e. to be
        /// part of a IDataParameterCollection.
        /// </summary>
        /// <param name="name">The unformatted name of the parameter.</param>
        /// <returns>
        /// The parameter name formatted for an IDataParameter
        /// </returns>
        public string CreateParameterNameForCollection(string name)
        {
            if (_dbMetadata.BindByName)
            {
                if (DbMetadata.UseParameterNamePrefixInParameterCollection)
                {
                    return DbMetadata.ParameterNamePrefix + name;
                }
                else
                {
                    return name;
                }
            }
            else
            {
                return DbMetadata.ParameterNamePrefix;
            }
        }

        /// <summary>
        /// Return metadata information about the database provider
        /// </summary>
        /// <value></value>
        public IDbMetadata DbMetadata
        {
            get { return _dbMetadata; }
        }

        /// <summary>
        /// Connection string used to create connections.
        /// </summary>
        /// <value></value>
        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        /// <summary>
        /// Extracts the provider specific error code as a string.
        /// </summary>
        /// <param name="e">The data access exception.</param>
        /// <returns>The provider specific error code</returns>
        public string ExtractError(Exception e)
        {

            if (!StringUtils.IsNullOrEmpty(_dbMetadata.ErrorCodeExceptionExpression))
            {
                return ExpressionEvaluator.GetValue(e, _dbMetadata.ErrorCodeExceptionExpression).ToString();
            }
            else
            {
                return "Could not extract error code exception type." + e.GetType();
            }

        }



        /// <summary>
        /// Determines whether the provided exception is in fact related
        /// to database access.
        /// </summary>
        /// <param name="e">The exception thrown when performing data access
        /// operations.</param>
        /// <returns>
        /// 	<c>true</c> if is a valid data access exception for the specified
        /// exception; otherwise, <c>false</c>.
        /// </returns>
        public bool IsDataAccessException(Exception e)
        {
            return e is System.Data.Common.DbException;
        }
    }
}
