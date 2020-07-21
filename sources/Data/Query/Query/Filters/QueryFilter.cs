/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Query
{
    public partial class QueryFilter<TPropEnum>
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This class represents a filter applied to a query sent to the Repository.
    /// </summary>
    public partial class QueryFilter<TPropEnum>:IQueryFilter where TPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        #region Static Private Fields
        //the key is one of the properties on this class these keys are guaranteed to be present.
        private static readonly Dictionary<int, HashSet<FilterConditions>> _supportedConditions;
        private static readonly HashSet<string> _valueTypes;
        private static readonly HashSet<string> _suppressableTypes;
        private static readonly int _stringKey = 1;
        private static readonly int _valTypeKey = 2;
        private static readonly int _dateKey = 3;
        private static readonly int _yearKey = 4;
        private static readonly int _monthKey = 5;
        private static readonly int _dayKey = 6;
        private static readonly int _containKey = 7;
        #endregion

        #region Instance Private Fields
        private int _currentType = typeof(TPropEnum).MetadataToken;
        private TPropEnum _property;
        private Type _type;
        private TypeCode _typeCode;
        private int _propertyId;
        private string _typeName;
        private string _propName;
        private bool _isArray = false;
        private bool _isNullable = false;
        private bool _isDateFilter = false;
        private bool _isYearFilter = false;
        private bool _isMonthFilter = false;
        private bool _isDayFilter = false;
        private bool _isBoolean = false;
        private bool _hasValue = true;
        //default value is Equals.
        private FilterConditions _condition = FilterConditions.Equals;
        private FilterOperators _operator = FilterOperators.And;
        private object _value = null;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the property to filter by as an enum.
        /// </summary>
        /// <value>
        /// TPropEnum
        /// </value>
        public TPropEnum Property { get{ return _property; }  }

        /// <summary>
        /// Gets the id of the property to filter by.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        public int PropertyId { get{ return _propertyId; }  }

        /// <summary>
        /// Gets the name of the property to filter by.
        /// </summary>
        /// <value>
        /// string
        /// </value>
        public string PropertyName { get{ return _propName; }  }

        /// <summary>
        /// Gets the condition to apply to the filter.
        /// </summary>
        /// <value>
        /// FilterConditions
        /// </value>
        public FilterConditions Condition { get{ return _condition; }  }

        /// <summary>
        /// Gets the operator used to chain the filter to the query.
        /// </summary>
        /// <value>
        /// FilterOperators
        /// </value>
        public FilterOperators Operator { get{ return _operator; }  }

        /// <summary>
        /// Gets the name of the CLR type corresponding to the Property specified in the FieldName.
        /// </summary>
        /// <value>
        /// string
        /// </value>
        public string TypeName { get{ return _typeName; }  }

        /// <summary>
        /// Gets the name of the CLR type corresponding to the Property specified in the FieldName.
        /// </summary>
        /// <value>
        /// Type
        /// </value>
        public Type Type { get{ return _type; }  }

        /// <summary>
        /// Gets System.TypeCode that corresponds to Type.
        /// </summary>
        /// <value>
        /// TypeCode
        /// </value>
        public TypeCode TypeCode { get{ return _typeCode; }  }

        /// <summary>
        /// True if the Value property is an Array.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        public bool IsArray { get{ return _isArray; }  }

        /// <summary>
        /// True if filtering by the Date part of a DateTime.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        public bool IsDateFilter { get{ return _isDateFilter; }  }

        /// <summary>
        /// True if filtering by the Date.Year part of a DateTime.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        public bool IsYearFilter { get{ return _isYearFilter; }  }

        /// <summary>
        /// True if filtering by the Date.Month part of a DateTime.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        public bool IsMonthFilter { get{ return _isMonthFilter; }  }

        /// <summary>
        /// True if filtering by the Date.Day part of a DateTime.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        public bool IsDayFilter { get{ return _isDayFilter; }  }

        /// <summary>
        /// True if the property is nullable.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        public bool IsNullable { get{ return _isNullable; }  }

        /// <summary>
        /// True if the Value property is a boolean.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        public bool IsBoolean { get{ return _isBoolean; }  }

        /// <summary>
        /// True if the value is not null.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        public bool HasValue { get{ return _hasValue; }  }

        /// <summary>
        /// Gets the value to use for filtering.
        /// </summary>
        /// <value>
        /// object
        /// </value>
        public object Value { get{ return _value; }  }

        /// <summary>
        /// Gets the number of expressions that start on this filter.  Used for grouping conditions inside parenthesis.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        public int StartExpressions { get; set; }

        /// <summary>
        /// Gets the number of expressions that end on this filter.  Used for grouping conditions inside parenthesis.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        public int EndExpressions { get; set; }

        #endregion

        #region Static Constructor
        static QueryFilter()
        {
            _supportedConditions = new Dictionary<int, HashSet<FilterConditions>>(7)
            {
                { _stringKey, new HashSet<FilterConditions>{FilterConditions.Contains, FilterConditions.DoesNotContain, FilterConditions.StartsWith, FilterConditions.DoesNotStartWith, FilterConditions.EndsWith, FilterConditions.DoesNotEndWith} },
                { _valTypeKey, new HashSet<FilterConditions>{FilterConditions.GreaterThan, FilterConditions.LessThan, FilterConditions.GreaterThanOrEquals, FilterConditions.LessThanOrEquals} },
                { _dateKey, new HashSet<FilterConditions>{FilterConditions.DateEquals, FilterConditions.DateNotEquals, FilterConditions.DateGreaterThan, FilterConditions.DateLessThan, FilterConditions.DateGreaterThanOrEquals, FilterConditions.DateLessThanOrEquals, FilterConditions.DateContains,FilterConditions.DateDoesNotContain} },
                { _yearKey, new HashSet<FilterConditions>{FilterConditions.YearEquals, FilterConditions.YearNotEquals, FilterConditions.YearGreaterThan, FilterConditions.YearLessThan, FilterConditions.YearGreaterThanOrEquals, FilterConditions.YearLessThanOrEquals} },
                { _monthKey, new HashSet<FilterConditions>{FilterConditions.MonthEquals, FilterConditions.MonthNotEquals, FilterConditions.MonthGreaterThan, FilterConditions.MonthLessThan, FilterConditions.MonthGreaterThanOrEquals, FilterConditions.MonthLessThanOrEquals, FilterConditions.MonthContains, FilterConditions.MonthDoesNotContain} },
                { _dayKey, new HashSet<FilterConditions>{FilterConditions.DayEquals, FilterConditions.DayNotEquals, FilterConditions.DayGreaterThan, FilterConditions.DayLessThan, FilterConditions.DayGreaterThanOrEquals, FilterConditions.DayLessThanOrEquals, FilterConditions.DayContains, FilterConditions.DayDoesNotContain} },
                { _containKey, new HashSet<FilterConditions>{FilterConditions.Contains, FilterConditions.DoesNotContain, FilterConditions.DayContains, FilterConditions.DayDoesNotContain, FilterConditions.MonthContains, FilterConditions.MonthDoesNotContain, FilterConditions.YearContains, FilterConditions.YearDoesNotContain, FilterConditions.DateContains,FilterConditions.DateDoesNotContain} }
            };
            _valueTypes = new HashSet<string>
            {
                "Byte",
                "Int16",
                "Int32",
                "Int64",
                "Single",
                "Double",
                "Decimal",
                "DateTime"
            };
            _suppressableTypes = new HashSet<string>
            {
                "Boolean",
                "Byte",
                "Int16",
                "Int32",
                "Int64",
            };
        }
        #endregion

        #region Instance Constructors
        private QueryFilter()
        {
        
        }
        /// <summary>
        /// Initializes a new instance of the Filter class.
        /// </summary>
        /// <param name="prop">The property to filter on.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="val">The field value.</param>
        internal QueryFilter(TPropEnum prop, FilterConditions condition, object val)
        {
            InitializeFilter(prop, condition, FilterOperators.And, val);
        }
        /// <summary>
        /// Initializes a new instance of the Filter class.
        /// </summary>
        /// <param name="prop">The property to filter on.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="op">The operator to chain conditions. For example And, Or.</param>
        /// <param name="val">The field value.</param>
        internal QueryFilter(TPropEnum prop, FilterConditions condition, FilterOperators op, object val)
        {
            InitializeFilter(prop, condition, op, val);
        }
        #endregion

        #region InitializeFilter Function
        private void InitializeFilter(TPropEnum prop, FilterConditions condition, FilterOperators op, object val)
        {
            var propertyInt = prop.ToInt32(null);
            if(!Lookup.PropTypes[_currentType].ContainsKey(propertyInt))
                throw new ArgumentException("Property " + prop.ToString() + " is not supported for this Entity");
            _propertyId = propertyInt;
            _property = prop;
            _propName = _property.ToString();
            _type = Lookup.PropTypes[_currentType][propertyInt];
            _typeCode = Type.GetTypeCode(_type);
            _typeName = _type.Name;
            _condition = condition;
            _isNullable = Lookup.NullableProps[_currentType].Contains(propertyInt);
            _isDateFilter = _supportedConditions[_dateKey].Contains(_condition);
            _isYearFilter = _supportedConditions[_yearKey].Contains(_condition);
            _isMonthFilter = _supportedConditions[_monthKey].Contains(_condition);
            _isDayFilter = _supportedConditions[_dayKey].Contains(_condition);
            var isContains = _supportedConditions[_containKey].Contains(_condition);
            var isDatePart = _isDateFilter || _isYearFilter || _isMonthFilter || _isDayFilter;
            var requiresInt = _isYearFilter || _isMonthFilter || _isDayFilter;
            _isBoolean = _type == typeof(bool);
            _operator = op;
            _value = val;
            if(_value == null)
            {
                _hasValue = false;
                if(!_isNullable)
                    throw new ArgumentException("Property: " + _propName + " is not nullable.");
                if(isContains)
                    throw new ArgumentException("Any Contains or DoesNotContain condition requires a non null value.");
                if(isDatePart)
                    throw new ArgumentException("Condition: " + _condition.ToString() + " cannot be applied to null values.");
                if(_condition != FilterConditions.Equals && _condition != FilterConditions.NotEquals)
                    throw new ArgumentException("When Value is null the property: " + _propName + " supports only Equals, NotEquals.");
                _isArray = false;
            }
            else
            {
                var valType = _value.GetType();
                var valTypeName = string.Empty;
                if(valType.IsArray)
                {
                    valTypeName = valType.GetElementType().Name;
                    _isArray = true;
                    _hasValue = ((Array)_value).Length > 0;
                }
                else
                {
                    valTypeName = valType.Name;
                    _isArray = false;
                }
                if(requiresInt)
                {
                    if(string.CompareOrdinal(valTypeName, "Int32") != 0)
                        throw new ArgumentException("Invalid type. Condition: " + _condition.ToString() + " expects int or int[]).");
                }
                else
                {
                    if(string.CompareOrdinal(_typeName, "Int64") == 0)
                    {
                        if(string.CompareOrdinal(valTypeName, "Int64") != 0 && string.CompareOrdinal(valTypeName, "Int32") != 0)
                            throw new ArgumentException("Invalid type. Property: " + _propName + " expects " + _typeName + " or " + _typeName + "[]).");
                    }
                    else
                    {
                        if(string.CompareOrdinal(valTypeName, _typeName) != 0)
                            throw new ArgumentException("Invalid type. Property: " + _propName + " expects " + _typeName + " or " + _typeName + "[]).");
                    }
                }
            }
            if(_isArray)
            {
                if(Lookup.BinaryProps[_currentType].Contains(propertyInt))
                {
                    if(_condition != FilterConditions.Equals && _condition != FilterConditions.NotEquals)
                        throw new ArgumentException("When Value is byte[] and the property is binary... " + _propName + " supports only Equals, NotEquals.");
                }
                else
                {
                    if(!isContains)
                        throw new ArgumentException("When Value is array " + _typeName + "[] the property: " + _propName + " supports only one of the Contains or DoesNotContain condition.");
                }
            }
            else
            {
                if(!GetPropertySupportsCondition(_typeName, _condition))
                    throw new ArgumentException("Condition " + _condition.ToString() + " is not supported for type " + _typeName);
            }
        }
        #endregion

        #region GetPropertySupportsCondition Function
        private static bool GetPropertySupportsCondition(string typeName, FilterConditions condition)
        {
            if(condition == FilterConditions.Equals || condition == FilterConditions.NotEquals)
                return true;
            if(string.CompareOrdinal(typeName, "String") == 0)
                return _supportedConditions[_stringKey].Contains(condition);
            if(string.CompareOrdinal(typeName, "DateTime") == 0)
            {
                var dateOrPart = _supportedConditions[_dateKey].Contains(condition) || _supportedConditions[_yearKey].Contains(condition) || _supportedConditions[_monthKey].Contains(condition) || _supportedConditions[_dayKey].Contains(condition);
                if(dateOrPart)
                    return true;
            }
            if(_valueTypes.Contains(typeName))
                return _supportedConditions[_valTypeKey].Contains(condition);
            return false;
        }
        #endregion
    }

    /// <summary>
    /// This class is a factory for creating QueryFilter instances.
    /// </summary>
    public static class QueryFilter
    {
        /// <summary>
        /// Initializes a new instance of the Filter class.
        /// </summary>
        /// <param name="prop">The property to filter on.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="val">The field value.</param>
        public static QueryFilter<TPropEnum> New<TPropEnum>(TPropEnum prop, FilterConditions condition, object val) where TPropEnum : struct, IComparable, IFormattable, IConvertible
        {
            return new QueryFilter<TPropEnum>(prop, condition, val);
        }
        /// <summary>
        /// Initializes a new instance of the Filter class.
        /// </summary>
        /// <param name="prop">The property to filter on.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="op">The operator to chain conditions. For example And, Or.</param>
        /// <param name="val">The field value.</param>
        public static QueryFilter<TPropEnum> New<TPropEnum>(TPropEnum prop, FilterConditions condition, FilterOperators op, object val) where TPropEnum : struct, IComparable, IFormattable, IConvertible
        {
            return new QueryFilter<TPropEnum>(prop, condition, op, val);
        }
    }
}
