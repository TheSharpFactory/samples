/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;
using System.Data;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Repository.Common
{

    /// <summary>
    /// Represents a Sql Table. This class is intended for internal use by the Repository classes for Sql Query Composition. 
    /// </summary>
    public partial class EntityInfo
    {
        public string DbFQName { get; set; }
        public string Alias { get; set; }
        public string AsAlias { get; set; }
        public string Projection { get; set; }
        public string InsertProjection { get; set; }
        public string InsertedProjection { get; set; }
        public string DeletedProjection { get; set; }
        public Dictionary<int, PropertyInfo> Props { get; set; }
    }

    /// <summary>
    /// Represents a Sql Column. This class is intended for internal use by the Repository classes for Sql Query Composition. 
    /// </summary>
    public partial class PropertyInfo
    {
        public string Column { get; set; }
        public string Alias { get; set; }
        public string ParamName { get; set; }
        public SqlDbType SqlType { get; set; }
        public string UdtTypeName { get; set; }
        public ParameterDirection Direction { get; set; } = ParameterDirection.Input;
        public int? Size { get; set; }
    }

    /// <summary>
    /// Represents a Sql Foreign Key. This class is intended for internal use by the Repository classes for Sql Query Composition. 
    /// </summary>
    public partial class NavPropertyInfo
    {
        public int EntityId { get; set; }
        public bool IsParent { get; set; }
        public List<NavPropertyPair> Predicate { get; set; }
        public List<NavPropertyInfo> NavProps { get; set; }
    }

    /// <summary>
    /// Represents a Sql Foreign Key Predicate. This class is intended for internal use by the Repository classes for Sql Query Composition. 
    /// </summary>
    public partial class NavPropertyPair
    {
        public int PropId { get; set; }
        public int OtherPropId { get; set; }
    }
}
