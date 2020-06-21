/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This class represents a single Navigation Property.
    /// </summary>
    public abstract class NavProp
    {
        public string Name { get; protected set; }

        public string FullName { get; protected set; }

        public string StringValue { get; protected set; }

        public int MetadataToken { get; protected set; }

        public object Value { get; protected set; }

        public int IntValue { get; protected set; }

        /// <summary>
        /// Sub Navigation Properties for this Navigation Property
        /// </summary>
        /// <value>
        /// NavProps
        /// </value>
        public NavProps NavProps { get; protected set; }

        public NavProp SubNavProp<TNavPropEnum>(TNavPropEnum subNavPropEnum) where TNavPropEnum : struct, IComparable, IFormattable, IConvertible
        {
            if(NavProps == null)
                NavProps = new NavProps();
            var navProp = new NavProp<TNavPropEnum>(subNavPropEnum);
            if(NavProps.Contains(navProp))
                return NavProps.Get(navProp);
            NavProps.Add(navProp);
            return navProp;
        }
        public override string ToString() 
        {
            return $"{FullName}.{StringValue}";
        }
    }

    /// <summary>
    /// This class represents a single Navigation Property.
    /// </summary>
    public sealed class NavProp<TNavPropEnum> : NavProp where TNavPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        public NavProp(TNavPropEnum navPropEnum)
        {
            var type = typeof(TNavPropEnum);
            MetadataToken = type.MetadataToken;
            FullName = type.FullName;
            Name = type.Name;
            StringValue = navPropEnum.ToString();
            Value = navPropEnum;
            IntValue = navPropEnum.ToInt32(null);
        }
    }
}
