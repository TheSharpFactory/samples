/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// Builds the navigation property tree for a query.
    /// </summary>
    public sealed class NavPropsBuilder<TPropEnum, TQuery, TQueryBuilder, TNavPropEnum> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TNavPropEnum : struct, IComparable, IFormattable, IConvertible where TQuery : QueryBase<TPropEnum, TQuery, TQueryBuilder>, new() where TQueryBuilder : QueryBuilderBase<TPropEnum, TQuery, TQueryBuilder>, new()
    {
        private readonly TQuery _query;
        private NavProp _current = null;
        internal NavProps NavigationProperties { get; private set; }

        public NavPropsBuilder(TQuery query)
        {
            _query = query;
        }
        /// <summary>
        /// Add a Navigation Property to the root level of the query.
        /// </summary>
        /// <returns>
        /// NavPropsBuilder of TPropEnum, TQuery, TQueryBuilder, TNavPropEnum
        /// </returns>
        public NavPropsBuilder<TPropEnum, TQuery, TQueryBuilder, TNavPropEnum> Append(TNavPropEnum prop) 
        {
            if(NavigationProperties == null)
                NavigationProperties = new NavProps();
            var newNavProp = new NavProp<TNavPropEnum>(prop);
            if(_current != null && _current.IntValue == newNavProp.IntValue)
                return this;
            _current = newNavProp;
            NavigationProperties.Add(newNavProp);
            return this;
        }
        /// <summary>
        /// Add a Navigation Property Collection to the root level of the query.
        /// </summary>
        /// <returns>
        /// NavPropsBuilder of TPropEnum, TQuery, TQueryBuilder, TNavPropEnum
        /// </returns>
        public NavPropsBuilder<TPropEnum, TQuery, TQueryBuilder, TNavPropEnum> Append(NavProps<TNavPropEnum> props) 
        {
            if(!(props?.Count > 0))
                return this;
            if(NavigationProperties == null)
                NavigationProperties = new NavProps();
            foreach(var np in props)
                NavigationProperties.Add(np);
            return this;
        }
        /// <summary>
        /// Add a Navigation Property to the root level of the query.
        /// </summary>
        /// <returns>
        /// NavPropsBuilder of TPropEnum, TQuery, TQueryBuilder, TNavPropEnum
        /// </returns>
        public NavPropsBuilder<TPropEnum, TQuery, TQueryBuilder, TNavPropEnum> Append(NavProp prop) 
        {
            return Append((TNavPropEnum)prop.Value);
        }
        /// <summary>
        /// Add a Sub Navigation Property to the current level of the query.
        /// </summary>
        /// <returns>
        /// NavPropsBuilder of TPropEnum, TQuery, TQueryBuilder, TNavPropEnum
        /// </returns>
        public NavPropsBuilder<TPropEnum, TQuery, TQueryBuilder, TNavPropEnum> Then<TSubNavPropEnum>(TSubNavPropEnum prop) where TSubNavPropEnum : struct, IComparable, IFormattable, IConvertible
        {
            if(NavigationProperties == null)
                throw new InvalidOperationException("No navigation properties found to attach a sub navigation property.");
            if(_current == null)
                throw new InvalidOperationException("No navigation properties found to attach a sub navigation property.");
            _current = _current.SubNavProp(prop);
            return this;
        }
        /// <summary>
        /// Ends setting the navigation properties.
        /// </summary>
        /// <returns>
        /// TQuery
        /// </returns>
        public TQuery EndNavProps() 
        {
            return _query;
        }
    }
}
