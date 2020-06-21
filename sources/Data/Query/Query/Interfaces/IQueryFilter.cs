/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Query
{
    public partial interface IQueryFilter
    {
    }
}

************************************************/

using System;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This interface represents a filter used when calling the Repository.
    /// </summary>
    public partial interface IQueryFilter
    {
        /// <summary>
        /// Gets the id of the property to filter by.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        int PropertyId { get;  }

        /// <summary>
        /// Gets the name of the property to filter by.
        /// </summary>
        /// <value>
        /// string
        /// </value>
        string PropertyName { get;  }

        /// <summary>
        /// Gets the condition to apply to the filter.
        /// </summary>
        /// <value>
        /// FilterConditions
        /// </value>
        FilterConditions Condition { get;  }

        /// <summary>
        /// Gets the operator used to chain the filter to the query.
        /// </summary>
        /// <value>
        /// FilterOperators
        /// </value>
        FilterOperators Operator { get;  }

        /// <summary>
        /// Gets the name of the CLR type corresponding to the Property specified in the FieldName.
        /// </summary>
        /// <value>
        /// string
        /// </value>
        string TypeName { get;  }

        /// <summary>
        /// Gets the name of the CLR type corresponding to the Property specified in the FieldName.
        /// </summary>
        /// <value>
        /// Type
        /// </value>
        Type Type { get;  }

        /// <summary>
        /// Gets System.TypeCode that corresponds to Type.
        /// </summary>
        /// <value>
        /// TypeCode
        /// </value>
        TypeCode TypeCode { get;  }

        /// <summary>
        /// True if the Value property is an Array.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        bool IsArray { get;  }

        /// <summary>
        /// True if filtering by the Date part of a DateTime.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        bool IsDateFilter { get;  }

        /// <summary>
        /// True if filtering by the Date.Year part of a DateTime.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        bool IsYearFilter { get;  }

        /// <summary>
        /// True if filtering by the Date.Month part of a DateTime.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        bool IsMonthFilter { get;  }

        /// <summary>
        /// True if filtering by the Date.Day part of a DateTime.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        bool IsDayFilter { get;  }

        /// <summary>
        /// True if the property is nullable.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        bool IsNullable { get;  }

        /// <summary>
        /// True if the Value property is a boolean.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        bool IsBoolean { get;  }

        /// <summary>
        /// True if the value is not null.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        bool HasValue { get;  }

        /// <summary>
        /// Gets the value to use for filtering.
        /// </summary>
        /// <value>
        /// object
        /// </value>
        object Value { get;  }

        /// <summary>
        /// Gets the number of expressions that start on this filter.  Used for grouping conditions inside parenthesis.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        int StartExpressions { get;  }

        /// <summary>
        /// Gets the number of expressions that end on this filter.  Used for grouping conditions inside parenthesis.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        int EndExpressions { get;  }

    }
}
