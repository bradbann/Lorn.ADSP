//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lorn.ADSP.AM.DataModels
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// AdSpotPlan
    /// </summary>
    public partial class AdSpotPlan
    {
        public AdSpotPlan()
        {
            this.AdSpotPlanEditions = new HashSet<AdSpotPlanEdition>();
        }
    
        /// <summary>
        /// AdSpotPlanId
        /// </summary>
        public System.Guid AdSpotPlanId { get; set; }
        /// <summary>
        /// AdMasterPlanId
        /// </summary>
        public Nullable<System.Guid> AdMasterPlanId { get; set; }
        /// <summary>
        /// AdSpotPlanName
        /// </summary>
        public string AdSpotPlanName { get; set; }
        /// <summary>
        /// MediaId
        /// </summary>
        public System.Guid MediaId { get; set; }
    
         /// <summary>
        /// AdSpotPlanEditions
        /// </summary>
        public virtual ICollection<AdSpotPlanEdition> AdSpotPlanEditions { get; set; }
    }
}
