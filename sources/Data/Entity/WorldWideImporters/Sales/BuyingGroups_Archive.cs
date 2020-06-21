/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Sales
{
    public partial class BuyingGroups_Archive
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Sales
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class BuyingGroups_Archive
    {
        #region Simple Properties
        public int BuyingGroupID { get; set; } 
        public string BuyingGroupName { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion
    }
}
