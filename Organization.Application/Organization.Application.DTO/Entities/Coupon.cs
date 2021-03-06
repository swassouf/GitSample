// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.61
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using Organization.Application.DTO.Interface;

namespace Organization.Application.DTO.Entities
{

    // Coupon
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public partial class Coupon : IEntity
    {
        public int ID { get; set; } // ID (Primary key)
        public string Code { get; set; } // Code (length: 50)
        public string Description { get; set; } // Description (length: 1000)
        public int Amount { get; set; } // Amount
        public string Symbol { get; set; } // Symbol (length: 50)
        public System.DateTime? FromDate { get; set; } // FromDate
        public System.DateTime? ToDate { get; set; } // ToDate
        public System.DateTime? InActiveAsOf { get; set; } // InActiveAsOf

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<PersonToCoupon> PersonToCoupons { get; set; } // PersonToCoupon.FK_PersonToCoupon_Coupon

        public Coupon()
        {
            PersonToCoupons = new System.Collections.Generic.List<PersonToCoupon>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
