using noxORM.src.core.exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.mapper
{
    public class SqlData
    {
        #region Field

        /// <summary>
        /// Contains .NET framework types and their equivalent in Sql server.
        /// </summary>
        private Dictionary<Type, DbType> dbTypeMap { get; set; }

        #endregion

        #region Singleton

        private static SqlData _instance;

        /// <summary>
        /// Singleton of SqlData
        /// </summary>
        public static SqlData Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SqlData();
                }
                return (_instance);
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Main constructor of SqlData class.
        /// </summary>
        private SqlData()
        {
            dbTypeMap = new Dictionary<Type, DbType>();
            dbTypeMap[typeof(byte)] = DbType.Byte;
            dbTypeMap[typeof(sbyte)] = DbType.SByte;
            dbTypeMap[typeof(short)] = DbType.Int16;
            dbTypeMap[typeof(ushort)] = DbType.UInt16;
            dbTypeMap[typeof(int)] = DbType.Int32;
            dbTypeMap[typeof(uint)] = DbType.UInt32;
            dbTypeMap[typeof(long)] = DbType.Int64;
            dbTypeMap[typeof(ulong)] = DbType.UInt64;
            dbTypeMap[typeof(float)] = DbType.Single;
            dbTypeMap[typeof(double)] = DbType.Double;
            dbTypeMap[typeof(decimal)] = DbType.Decimal;
            dbTypeMap[typeof(bool)] = DbType.Boolean;
            dbTypeMap[typeof(string)] = DbType.String;
            dbTypeMap[typeof(char)] = DbType.StringFixedLength;
            dbTypeMap[typeof(Guid)] = DbType.Guid;
            dbTypeMap[typeof(DateTime)] = DbType.DateTime;
            dbTypeMap[typeof(DateTimeOffset)] = DbType.DateTimeOffset;
            dbTypeMap[typeof(TimeSpan)] = DbType.Time;
            dbTypeMap[typeof(byte[])] = DbType.Binary;
            dbTypeMap[typeof(byte?)] = DbType.Byte;
            dbTypeMap[typeof(sbyte?)] = DbType.SByte;
            dbTypeMap[typeof(short?)] = DbType.Int16;
            dbTypeMap[typeof(ushort?)] = DbType.UInt16;
            dbTypeMap[typeof(int?)] = DbType.Int32;
            dbTypeMap[typeof(uint?)] = DbType.UInt32;
            dbTypeMap[typeof(long?)] = DbType.Int64;
            dbTypeMap[typeof(ulong?)] = DbType.UInt64;
            dbTypeMap[typeof(float?)] = DbType.Single;
            dbTypeMap[typeof(double?)] = DbType.Double;
            dbTypeMap[typeof(decimal?)] = DbType.Decimal;
            dbTypeMap[typeof(bool?)] = DbType.Boolean;
            dbTypeMap[typeof(char?)] = DbType.StringFixedLength;
            dbTypeMap[typeof(Guid?)] = DbType.Guid;
            dbTypeMap[typeof(DateTime?)] = DbType.DateTime;
            dbTypeMap[typeof(DateTimeOffset?)] = DbType.DateTimeOffset;
            dbTypeMap[typeof(TimeSpan?)] = DbType.Time;
            dbTypeMap[typeof(object)] = DbType.Object;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method that allow the user to get the dbType equivalent of Type.
        /// </summary>
        /// <param name="type">Type of the propertie</param>
        /// <param name="name">Name of the propertie</param>
        /// <returns></returns>
        public DbType GetDbTypeByType(Type type, string name)
        {
            string linqBinary = "System.Data.Linq.Binary";
            DbType dbType;
            var nullUnderlyingType = Nullable.GetUnderlyingType(type);
            if (nullUnderlyingType != null) type = nullUnderlyingType;
            if (type.IsEnum && !dbTypeMap.ContainsKey(type))
            {
                type = Enum.GetUnderlyingType(type);
            }
            if (dbTypeMap.TryGetValue(type, out dbType))
            {
                return dbType;
            }
            if (type.FullName == linqBinary)
            {
                return DbType.Binary;
            }
            throw new DatabaseTypeErrorException("[DBT1] Unable to get a database type for propertie named '" + name + "' of type : " + type.Name + ". Did you used [NotGenerateColumn] attribute ?");
            return (dbType);

        }

        #endregion
    }
}
