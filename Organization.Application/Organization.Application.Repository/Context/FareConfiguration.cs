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

    // Fares
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public partial class FareConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fare>
    {
        public FareConfiguration()
            : this("dbo")
        {
        }

        public FareConfiguration(string schema)
        {
            ToTable("Fares", schema);
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PersonId).HasColumnName(@"PersonID").IsRequired().HasColumnType("int");
            Property(x => x.Latitude).HasColumnName(@"Latitude").IsRequired().HasColumnType("decimal").HasPrecision(9,6);
            Property(x => x.Longitude).HasColumnName(@"Longitude").IsRequired().HasColumnType("decimal").HasPrecision(9,6);
            Property(x => x.CountryId).HasColumnName(@"CountryID").IsRequired().HasColumnType("int");
            Property(x => x.OrderTimeZone).HasColumnName(@"OrderTimeZone").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.TransportOptionId).HasColumnName(@"TransportOptionID").IsRequired().HasColumnType("int");
            Property(x => x.IsCancelled).HasColumnName(@"IsCancelled").IsRequired().HasColumnType("bit");
            Property(x => x.PickupTime).HasColumnName(@"PickupTime").IsRequired().HasColumnType("datetime");
            Property(x => x.DestinationLatitude).HasColumnName(@"DestinationLatitude").IsOptional().HasColumnType("decimal").HasPrecision(9,6);
            Property(x => x.DestinationLongitude).HasColumnName(@"DestinationLongitude").IsOptional().HasColumnType("decimal").HasPrecision(9,6);
            Property(x => x.FareStartTime).HasColumnName(@"FareStartTime").IsOptional().HasColumnType("datetime");
            Property(x => x.FareEndTime).HasColumnName(@"FareEndTime").IsOptional().HasColumnType("datetime");
            Property(x => x.Distance).HasColumnName(@"Distance").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.Duration).HasColumnName(@"Duration").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.TotalFarePrice).HasColumnName(@"TotalFarePrice").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.BaseFare).HasColumnName(@"BaseFare").IsOptional().HasColumnType("decimal").HasPrecision(4,2);
            Property(x => x.PerMile).HasColumnName(@"PerMile").IsOptional().HasColumnType("decimal").HasPrecision(4,2);
            Property(x => x.PerMinute).HasColumnName(@"PerMinute").IsOptional().HasColumnType("decimal").HasPrecision(4,2);
            Property(x => x.SafeRideFee).HasColumnName(@"SafeRideFee").IsOptional().HasColumnType("decimal").HasPrecision(4,2);
            Property(x => x.FareIncreased).HasColumnName(@"FareIncreased").IsRequired().HasColumnType("bit");
            Property(x => x.FareIncreasedBy).HasColumnName(@"FareIncreasedBy").IsOptional().HasColumnType("decimal").HasPrecision(4,2);
            Property(x => x.FareTracking).HasColumnName(@"FareTracking").IsOptional().IsUnicode(false).HasColumnType("varchar(max)");
            Property(x => x.ReceiptSentDate).HasColumnName(@"ReceiptSentDate").IsOptional().HasColumnType("datetime");
            Property(x => x.ReasonId).HasColumnName(@"ReasonID").IsOptional().HasColumnType("int");
            Property(x => x.Created).HasColumnName(@"Created").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasOptional(a => a.Reason).WithMany(b => b.Fares).HasForeignKey(c => c.ReasonId).WillCascadeOnDelete(false); // FK_Fares_Reason
            HasRequired(a => a.CountryRegion).WithMany(b => b.Fares).HasForeignKey(c => c.CountryId).WillCascadeOnDelete(false); // FK_Fares_CountryRegion
            HasRequired(a => a.Person).WithMany(b => b.Fares).HasForeignKey(c => c.PersonId).WillCascadeOnDelete(false); // FK_Fares_Person
            HasRequired(a => a.TransportOption).WithMany(b => b.Fares).HasForeignKey(c => c.TransportOptionId).WillCascadeOnDelete(false); // FK_Fares_TransportOption
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
