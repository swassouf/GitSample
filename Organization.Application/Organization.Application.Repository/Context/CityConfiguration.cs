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

using Organization.Application.DTO.Entities;

namespace Organization.Application.Repository.Context
{

    // City
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public partial class CityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<City>
    {
        public CityConfiguration()
            : this("dbo")
        {
        }

        public CityConfiguration(string schema)
        {
            ToTable("City", schema);
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceId).HasColumnName(@"StateProvinceID").IsRequired().HasColumnType("int");
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.Created).HasColumnName(@"Created").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.StateProvince).WithMany(b => b.Cities).HasForeignKey(c => c.StateProvinceId).WillCascadeOnDelete(false); // FK_City_StateProvince
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
