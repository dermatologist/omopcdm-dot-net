﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace omopcdmlib.Models
{
    public partial class OmopCdmContext : DbContext
    {
        public OmopCdmContext()
        {
        }

        public OmopCdmContext(DbContextOptions<OmopCdmContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttributeDefinition> AttributeDefinition { get; set; }
        public virtual DbSet<CareSite> CareSite { get; set; }
        public virtual DbSet<CdmSource> CdmSource { get; set; }
        public virtual DbSet<Cohort> Cohort { get; set; }
        public virtual DbSet<CohortAttribute> CohortAttribute { get; set; }
        public virtual DbSet<CohortDefinition> CohortDefinition { get; set; }
        public virtual DbSet<Concept> Concept { get; set; }
        public virtual DbSet<ConceptAncestor> ConceptAncestor { get; set; }
        public virtual DbSet<ConceptClass> ConceptClass { get; set; }
        public virtual DbSet<ConceptRelationship> ConceptRelationship { get; set; }
        public virtual DbSet<ConceptSynonym> ConceptSynonym { get; set; }
        public virtual DbSet<ConditionEra> ConditionEra { get; set; }
        public virtual DbSet<ConditionOccurrence> ConditionOccurrence { get; set; }
        public virtual DbSet<Death> Death { get; set; }
        public virtual DbSet<DeviceCost> DeviceCost { get; set; }
        public virtual DbSet<DeviceExposure> DeviceExposure { get; set; }
        public virtual DbSet<Domain> Domain { get; set; }
        public virtual DbSet<DoseEra> DoseEra { get; set; }
        public virtual DbSet<DrugCost> DrugCost { get; set; }
        public virtual DbSet<DrugEra> DrugEra { get; set; }
        public virtual DbSet<DrugExposure> DrugExposure { get; set; }
        public virtual DbSet<DrugStrength> DrugStrength { get; set; }
        public virtual DbSet<FactRelationship> FactRelationship { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Measurement> Measurement { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Observation> Observation { get; set; }
        public virtual DbSet<ObservationPeriod> ObservationPeriod { get; set; }
        public virtual DbSet<PayerPlanPeriod> PayerPlanPeriod { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<ProcedureCost> ProcedureCost { get; set; }
        public virtual DbSet<ProcedureOccurrence> ProcedureOccurrence { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Relationship> Relationship { get; set; }
        public virtual DbSet<SourceToConceptMap> SourceToConceptMap { get; set; }
        public virtual DbSet<Specimen> Specimen { get; set; }
        public virtual DbSet<VisitCost> VisitCost { get; set; }
        public virtual DbSet<VisitOccurrence> VisitOccurrence { get; set; }
        public virtual DbSet<Vocabulary> Vocabulary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("DataSource=cdm.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttributeDefinition>(entity =>
            {
                entity.ToTable("attribute_definition");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeDefinitionId).HasColumnName("attribute_definition_id");

                entity.Property(e => e.AttributeDescription).HasColumnName("attribute_description");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasColumnName("attribute_name")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.AttributeSyntax).HasColumnName("attribute_syntax");

                entity.Property(e => e.AttributeTypeConceptId).HasColumnName("attribute_type_concept_id");
            });

            modelBuilder.Entity<CareSite>(entity =>
            {
                entity.ToTable("care_site");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CareSiteId).HasColumnName("care_site_id");

                entity.Property(e => e.CareSiteName)
                    .HasColumnName("care_site_name")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.CareSiteSourceValue)
                    .HasColumnName("care_site_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.PlaceOfServiceConceptId).HasColumnName("place_of_service_concept_id");

                entity.Property(e => e.PlaceOfServiceSourceValue)
                    .HasColumnName("place_of_service_source_value")
                    .HasColumnType("VARCHAR(50)");
            });

            modelBuilder.Entity<CdmSource>(entity =>
            {
                entity.ToTable("cdm_source");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdmEtlReference)
                    .HasColumnName("cdm_etl_reference")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.CdmHolder)
                    .HasColumnName("cdm_holder")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.CdmReleaseDate)
                    .HasColumnName("cdm_release_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.CdmSourceAbbreviation)
                    .HasColumnName("cdm_source_abbreviation")
                    .HasColumnType("VARCHAR(25)");

                entity.Property(e => e.CdmSourceName)
                    .IsRequired()
                    .HasColumnName("cdm_source_name")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.CdmVersion)
                    .HasColumnName("cdm_version")
                    .HasColumnType("VARCHAR(10)");

                entity.Property(e => e.SourceDescription).HasColumnName("source_description");

                entity.Property(e => e.SourceDocumentationReference)
                    .HasColumnName("source_documentation_reference")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.SourceReleaseDate)
                    .HasColumnName("source_release_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.VocabularyVersion)
                    .HasColumnName("vocabulary_version")
                    .HasColumnType("VARCHAR(20)");
            });

            modelBuilder.Entity<Cohort>(entity =>
            {
                entity.ToTable("cohort");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CohortDefinitionId).HasColumnName("cohort_definition_id");

                entity.Property(e => e.CohortEndDate)
                    .IsRequired()
                    .HasColumnName("cohort_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.CohortStartDate)
                    .IsRequired()
                    .HasColumnName("cohort_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            });

            modelBuilder.Entity<CohortAttribute>(entity =>
            {
                entity.ToTable("cohort_attribute");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeDefinitionId).HasColumnName("attribute_definition_id");

                entity.Property(e => e.CohortDefinitionId).HasColumnName("cohort_definition_id");

                entity.Property(e => e.CohortEndDate)
                    .IsRequired()
                    .HasColumnName("cohort_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.CohortStartDate)
                    .IsRequired()
                    .HasColumnName("cohort_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.ValueAsConceptId).HasColumnName("value_as_concept_id");

                entity.Property(e => e.ValueAsNumber)
                    .HasColumnName("value_as_number")
                    .HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<CohortDefinition>(entity =>
            {
                entity.ToTable("cohort_definition");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CohortDefinitionDescription).HasColumnName("cohort_definition_description");

                entity.Property(e => e.CohortDefinitionId).HasColumnName("cohort_definition_id");

                entity.Property(e => e.CohortDefinitionName)
                    .IsRequired()
                    .HasColumnName("cohort_definition_name")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.CohortDefinitionSyntax).HasColumnName("cohort_definition_syntax");

                entity.Property(e => e.CohortInitiationDate)
                    .HasColumnName("cohort_initiation_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DefinitionTypeConceptId).HasColumnName("definition_type_concept_id");

                entity.Property(e => e.SubjectConceptId).HasColumnName("subject_concept_id");
            });

            modelBuilder.Entity<Concept>(entity =>
            {
                entity.ToTable("concept");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConceptClassId)
                    .IsRequired()
                    .HasColumnName("concept_class_id")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.ConceptCode)
                    .IsRequired()
                    .HasColumnName("concept_code")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.ConceptId).HasColumnName("concept_id");

                entity.Property(e => e.ConceptName)
                    .IsRequired()
                    .HasColumnName("concept_name")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.DomainId)
                    .IsRequired()
                    .HasColumnName("domain_id")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.InvalidReason)
                    .HasColumnName("invalid_reason")
                    .HasColumnType("VARCHAR(1)");

                entity.Property(e => e.StandardConcept)
                    .HasColumnName("standard_concept")
                    .HasColumnType("VARCHAR(1)");

                entity.Property(e => e.ValidEndDate)
                    .IsRequired()
                    .HasColumnName("valid_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ValidStartDate)
                    .IsRequired()
                    .HasColumnName("valid_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.VocabularyId)
                    .IsRequired()
                    .HasColumnName("vocabulary_id")
                    .HasColumnType("VARCHAR(20)");
            });

            modelBuilder.Entity<ConceptAncestor>(entity =>
            {
                entity.ToTable("concept_ancestor");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AncestorConceptId).HasColumnName("ancestor_concept_id");

                entity.Property(e => e.DescendantConceptId).HasColumnName("descendant_concept_id");

                entity.Property(e => e.MaxLevelsOfSeparation).HasColumnName("max_levels_of_separation");

                entity.Property(e => e.MinLevelsOfSeparation).HasColumnName("min_levels_of_separation");
            });

            modelBuilder.Entity<ConceptClass>(entity =>
            {
                entity.ToTable("concept_class");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConceptClassConceptId).HasColumnName("concept_class_concept_id");

                entity.Property(e => e.ConceptClassId)
                    .IsRequired()
                    .HasColumnName("concept_class_id")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.ConceptClassName)
                    .IsRequired()
                    .HasColumnName("concept_class_name")
                    .HasColumnType("VARCHAR(255)");
            });

            modelBuilder.Entity<ConceptRelationship>(entity =>
            {
                entity.ToTable("concept_relationship");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConceptId1).HasColumnName("concept_id_1");

                entity.Property(e => e.ConceptId2).HasColumnName("concept_id_2");

                entity.Property(e => e.InvalidReason)
                    .HasColumnName("invalid_reason")
                    .HasColumnType("VARCHAR(1)");

                entity.Property(e => e.RelationshipId)
                    .IsRequired()
                    .HasColumnName("relationship_id")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.ValidEndDate)
                    .IsRequired()
                    .HasColumnName("valid_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ValidStartDate)
                    .IsRequired()
                    .HasColumnName("valid_start_date")
                    .HasColumnType("DATE");
            });

            modelBuilder.Entity<ConceptSynonym>(entity =>
            {
                entity.ToTable("concept_synonym");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConceptId).HasColumnName("concept_id");

                entity.Property(e => e.ConceptSynonymName)
                    .IsRequired()
                    .HasColumnName("concept_synonym_name")
                    .HasColumnType("VARCHAR(1000)");

                entity.Property(e => e.LanguageConceptId).HasColumnName("language_concept_id");
            });

            modelBuilder.Entity<ConditionEra>(entity =>
            {
                entity.ToTable("condition_era");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionConceptId).HasColumnName("condition_concept_id");

                entity.Property(e => e.ConditionEraEndDate)
                    .IsRequired()
                    .HasColumnName("condition_era_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ConditionEraId).HasColumnName("condition_era_id");

                entity.Property(e => e.ConditionEraStartDate)
                    .IsRequired()
                    .HasColumnName("condition_era_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ConditionOccurrenceCount).HasColumnName("condition_occurrence_count");

                entity.Property(e => e.PersonId).HasColumnName("person_id");
            });

            modelBuilder.Entity<ConditionOccurrence>(entity =>
            {
                entity.ToTable("condition_occurrence");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionConceptId).HasColumnName("condition_concept_id");

                entity.Property(e => e.ConditionEndDate)
                    .HasColumnName("condition_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ConditionOccurrenceId).HasColumnName("condition_occurrence_id");

                entity.Property(e => e.ConditionSourceConceptId).HasColumnName("condition_source_concept_id");

                entity.Property(e => e.ConditionSourceValue)
                    .HasColumnName("condition_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.ConditionStartDate)
                    .IsRequired()
                    .HasColumnName("condition_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ConditionTypeConceptId).HasColumnName("condition_type_concept_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.StopReason)
                    .HasColumnName("stop_reason")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.VisitOccurrenceId)
                    .HasColumnName("visit_occurrence_id")
                    .HasColumnType("BIGINT");
            });

            modelBuilder.Entity<Death>(entity =>
            {
                entity.ToTable("death");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CauseConceptId).HasColumnName("cause_concept_id");

                entity.Property(e => e.CauseSourceConceptId).HasColumnName("cause_source_concept_id");

                entity.Property(e => e.CauseSourceValue)
                    .HasColumnName("cause_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.DeathDate)
                    .IsRequired()
                    .HasColumnName("death_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DeathTypeConceptId).HasColumnName("death_type_concept_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");
            });

            modelBuilder.Entity<DeviceCost>(entity =>
            {
                entity.ToTable("device_cost");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyConceptId).HasColumnName("currency_concept_id");

                entity.Property(e => e.DeviceCostId).HasColumnName("device_cost_id");

                entity.Property(e => e.DeviceExposureId).HasColumnName("device_exposure_id");

                entity.Property(e => e.PaidByCoordinationBenefits)
                    .HasColumnName("paid_by_coordination_benefits")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidByPayer)
                    .HasColumnName("paid_by_payer")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidCoinsurance)
                    .HasColumnName("paid_coinsurance")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidCopay)
                    .HasColumnName("paid_copay")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidTowardDeductible)
                    .HasColumnName("paid_toward_deductible")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PayerPlanPeriodId).HasColumnName("payer_plan_period_id");

                entity.Property(e => e.TotalOutOfPocket)
                    .HasColumnName("total_out_of_pocket")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.TotalPaid)
                    .HasColumnName("total_paid")
                    .HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<DeviceExposure>(entity =>
            {
                entity.ToTable("device_exposure");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeviceConceptId).HasColumnName("device_concept_id");

                entity.Property(e => e.DeviceExposureEndDate)
                    .HasColumnName("device_exposure_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DeviceExposureId).HasColumnName("device_exposure_id");

                entity.Property(e => e.DeviceExposureStartDate)
                    .IsRequired()
                    .HasColumnName("device_exposure_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DeviceSourceConceptId).HasColumnName("device_source_concept_id");

                entity.Property(e => e.DeviceSourceValue)
                    .HasColumnName("device_source_value")
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.DeviceTypeConceptId).HasColumnName("device_type_concept_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UniqueDeviceId)
                    .HasColumnName("unique_device_id")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.VisitOccurrenceId)
                    .HasColumnName("visit_occurrence_id")
                    .HasColumnType("BIGINT");
            });

            modelBuilder.Entity<Domain>(entity =>
            {
                entity.ToTable("domain");

                entity.Property(e => e.DomainId)
                    .HasColumnName("domain_id")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.DomainConceptId).HasColumnName("domain_concept_id");

                entity.Property(e => e.DomainName)
                    .IsRequired()
                    .HasColumnName("domain_name")
                    .HasColumnType("VARCHAR(255)");
            });

            modelBuilder.Entity<DoseEra>(entity =>
            {
                entity.ToTable("dose_era");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoseEraEndDate)
                    .IsRequired()
                    .HasColumnName("dose_era_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DoseEraId).HasColumnName("dose_era_id");

                entity.Property(e => e.DoseEraStartDate)
                    .IsRequired()
                    .HasColumnName("dose_era_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DoseValue)
                    .IsRequired()
                    .HasColumnName("dose_value")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.DrugConceptId).HasColumnName("drug_concept_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.UnitConceptId).HasColumnName("unit_concept_id");
            });

            modelBuilder.Entity<DrugCost>(entity =>
            {
                entity.ToTable("drug_cost");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AverageWholesalePrice)
                    .HasColumnName("average_wholesale_price")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.CurrencyConceptId).HasColumnName("currency_concept_id");

                entity.Property(e => e.DispensingFee)
                    .HasColumnName("dispensing_fee")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.DrugCostId).HasColumnName("drug_cost_id");

                entity.Property(e => e.DrugExposureId).HasColumnName("drug_exposure_id");

                entity.Property(e => e.IngredientCost)
                    .HasColumnName("ingredient_cost")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidByCoordinationBenefits)
                    .HasColumnName("paid_by_coordination_benefits")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidByPayer)
                    .HasColumnName("paid_by_payer")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidCoinsurance)
                    .HasColumnName("paid_coinsurance")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidCopay)
                    .HasColumnName("paid_copay")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidTowardDeductible)
                    .HasColumnName("paid_toward_deductible")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PayerPlanPeriodId).HasColumnName("payer_plan_period_id");

                entity.Property(e => e.TotalOutOfPocket)
                    .HasColumnName("total_out_of_pocket")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.TotalPaid)
                    .HasColumnName("total_paid")
                    .HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<DrugEra>(entity =>
            {
                entity.ToTable("drug_era");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DrugConceptId).HasColumnName("drug_concept_id");

                entity.Property(e => e.DrugEraEndDate)
                    .IsRequired()
                    .HasColumnName("drug_era_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DrugEraId).HasColumnName("drug_era_id");

                entity.Property(e => e.DrugEraStartDate)
                    .IsRequired()
                    .HasColumnName("drug_era_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DrugExposureCount).HasColumnName("drug_exposure_count");

                entity.Property(e => e.GapDays).HasColumnName("gap_days");

                entity.Property(e => e.PersonId).HasColumnName("person_id");
            });

            modelBuilder.Entity<DrugExposure>(entity =>
            {
                entity.ToTable("drug_exposure");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DaysSupply).HasColumnName("days_supply");

                entity.Property(e => e.DoseUnitConceptId).HasColumnName("dose_unit_concept_id");

                entity.Property(e => e.DoseUnitSourceValue)
                    .HasColumnName("dose_unit_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.DrugConceptId).HasColumnName("drug_concept_id");

                entity.Property(e => e.DrugExposureEndDate)
                    .HasColumnName("drug_exposure_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DrugExposureId).HasColumnName("drug_exposure_id");

                entity.Property(e => e.DrugExposureStartDate)
                    .IsRequired()
                    .HasColumnName("drug_exposure_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.DrugSourceConceptId).HasColumnName("drug_source_concept_id");

                entity.Property(e => e.DrugSourceValue)
                    .HasColumnName("drug_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.DrugTypeConceptId).HasColumnName("drug_type_concept_id");

                entity.Property(e => e.EffectiveDrugDose)
                    .HasColumnName("effective_drug_dose")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.LotNumber)
                    .HasColumnName("lot_number")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.Refills).HasColumnName("refills");

                entity.Property(e => e.RouteConceptId).HasColumnName("route_concept_id");

                entity.Property(e => e.RouteSourceValue)
                    .HasColumnName("route_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Sig).HasColumnName("sig");

                entity.Property(e => e.StopReason)
                    .HasColumnName("stop_reason")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.VisitOccurrenceId)
                    .HasColumnName("visit_occurrence_id")
                    .HasColumnType("BIGINT");
            });

            modelBuilder.Entity<DrugStrength>(entity =>
            {
                entity.ToTable("drug_strength");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmountUnitConceptId).HasColumnName("amount_unit_concept_id");

                entity.Property(e => e.AmountValue)
                    .HasColumnName("amount_value")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.BoxSize).HasColumnName("box_size");

                entity.Property(e => e.DenominatorUnitConceptId).HasColumnName("denominator_unit_concept_id");

                entity.Property(e => e.DenominatorValue)
                    .HasColumnName("denominator_value")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.DrugConceptId).HasColumnName("drug_concept_id");

                entity.Property(e => e.IngredientConceptId).HasColumnName("ingredient_concept_id");

                entity.Property(e => e.InvalidReason)
                    .HasColumnName("invalid_reason")
                    .HasColumnType("VARCHAR(1)");

                entity.Property(e => e.NumeratorUnitConceptId).HasColumnName("numerator_unit_concept_id");

                entity.Property(e => e.NumeratorValue)
                    .HasColumnName("numerator_value")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.ValidEndDate)
                    .IsRequired()
                    .HasColumnName("valid_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ValidStartDate)
                    .IsRequired()
                    .HasColumnName("valid_start_date")
                    .HasColumnType("DATE");
            });

            modelBuilder.Entity<FactRelationship>(entity =>
            {
                entity.ToTable("fact_relationship");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DomainConceptId1).HasColumnName("domain_concept_id_1");

                entity.Property(e => e.DomainConceptId2).HasColumnName("domain_concept_id_2");

                entity.Property(e => e.FactId1).HasColumnName("fact_id_1");

                entity.Property(e => e.FactId2).HasColumnName("fact_id_2");

                entity.Property(e => e.RelationshipConceptId).HasColumnName("relationship_concept_id");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasColumnName("address_1")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Address2)
                    .HasColumnName("address_2")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.LocationSourceValue)
                    .HasColumnName("location_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("VARCHAR(2)");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("VARCHAR(9)");
            });

            modelBuilder.Entity<Measurement>(entity =>
            {
                entity.ToTable("measurement");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MeasurementConceptId).HasColumnName("measurement_concept_id");

                entity.Property(e => e.MeasurementDate)
                    .IsRequired()
                    .HasColumnName("measurement_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.MeasurementId).HasColumnName("measurement_id");

                entity.Property(e => e.MeasurementSourceConceptId).HasColumnName("measurement_source_concept_id");

                entity.Property(e => e.MeasurementSourceValue)
                    .HasColumnName("measurement_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.MeasurementTime)
                    .HasColumnName("measurement_time")
                    .HasColumnType("VARCHAR(10)");

                entity.Property(e => e.MeasurementTypeConceptId).HasColumnName("measurement_type_concept_id");

                entity.Property(e => e.OperatorConceptId).HasColumnName("operator_concept_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.RangeHigh)
                    .HasColumnName("range_high")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.RangeLow)
                    .HasColumnName("range_low")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.UnitConceptId).HasColumnName("unit_concept_id");

                entity.Property(e => e.UnitSourceValue)
                    .HasColumnName("unit_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.ValueAsConceptId).HasColumnName("value_as_concept_id");

                entity.Property(e => e.ValueAsNumber)
                    .HasColumnName("value_as_number")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.ValueSourceValue)
                    .HasColumnName("value_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.VisitOccurrenceId)
                    .HasColumnName("visit_occurrence_id")
                    .HasColumnType("BIGINT");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("note");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.NoteDate)
                    .IsRequired()
                    .HasColumnName("note_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.NoteId).HasColumnName("note_id");

                entity.Property(e => e.NoteSourceValue)
                    .HasColumnName("note_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.NoteText)
                    .IsRequired()
                    .HasColumnName("note_text");

                entity.Property(e => e.NoteTime)
                    .HasColumnName("note_time")
                    .HasColumnType("VARCHAR(10)");

                entity.Property(e => e.NoteTypeConceptId).HasColumnName("note_type_concept_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.VisitOccurrenceId)
                    .HasColumnName("visit_occurrence_id")
                    .HasColumnType("BIGINT");
            });

            modelBuilder.Entity<Observation>(entity =>
            {
                entity.ToTable("observation");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ObservationConceptId).HasColumnName("observation_concept_id");

                entity.Property(e => e.ObservationDate)
                    .IsRequired()
                    .HasColumnName("observation_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ObservationId).HasColumnName("observation_id");

                entity.Property(e => e.ObservationSourceConceptId).HasColumnName("observation_source_concept_id");

                entity.Property(e => e.ObservationSourceValue)
                    .HasColumnName("observation_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.ObservationTime)
                    .HasColumnName("observation_time")
                    .HasColumnType("VARCHAR(10)");

                entity.Property(e => e.ObservationTypeConceptId).HasColumnName("observation_type_concept_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.QualifierConceptId).HasColumnName("qualifier_concept_id");

                entity.Property(e => e.QualifierSourceValue)
                    .HasColumnName("qualifier_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.UnitConceptId).HasColumnName("unit_concept_id");

                entity.Property(e => e.UnitSourceValue)
                    .HasColumnName("unit_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.ValueAsConceptId).HasColumnName("value_as_concept_id");

                entity.Property(e => e.ValueAsNumber)
                    .HasColumnName("value_as_number")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.ValueAsString)
                    .HasColumnName("value_as_string")
                    .HasColumnType("VARCHAR(60)");

                entity.Property(e => e.VisitOccurrenceId)
                    .HasColumnName("visit_occurrence_id")
                    .HasColumnType("BIGINT");
            });

            modelBuilder.Entity<ObservationPeriod>(entity =>
            {
                entity.ToTable("observation_period");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ObservationPeriodEndDate)
                    .IsRequired()
                    .HasColumnName("observation_period_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ObservationPeriodId).HasColumnName("observation_period_id");

                entity.Property(e => e.ObservationPeriodStartDate)
                    .IsRequired()
                    .HasColumnName("observation_period_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.PeriodTypeConceptId).HasColumnName("period_type_concept_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");
            });

            modelBuilder.Entity<PayerPlanPeriod>(entity =>
            {
                entity.ToTable("payer_plan_period");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilySourceValue)
                    .HasColumnName("family_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.PayerPlanPeriodEndDate)
                    .IsRequired()
                    .HasColumnName("payer_plan_period_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.PayerPlanPeriodId).HasColumnName("payer_plan_period_id");

                entity.Property(e => e.PayerPlanPeriodStartDate)
                    .IsRequired()
                    .HasColumnName("payer_plan_period_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.PayerSourceValue)
                    .HasColumnName("payer_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.PlanSourceValue)
                    .HasColumnName("plan_source_value")
                    .HasColumnType("VARCHAR(50)");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CareSiteId).HasColumnName("care_site_id");

                entity.Property(e => e.DayOfBirth).HasColumnName("day_of_birth");

                entity.Property(e => e.EthnicityConceptId).HasColumnName("ethnicity_concept_id");

                entity.Property(e => e.EthnicitySourceConceptId).HasColumnName("ethnicity_source_concept_id");

                entity.Property(e => e.EthnicitySourceValue)
                    .HasColumnName("ethnicity_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.GenderConceptId).HasColumnName("gender_concept_id");

                entity.Property(e => e.GenderSourceConceptId).HasColumnName("gender_source_concept_id");

                entity.Property(e => e.GenderSourceValue)
                    .HasColumnName("gender_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MonthOfBirth).HasColumnName("month_of_birth");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.PersonSourceValue)
                    .HasColumnName("person_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.RaceConceptId).HasColumnName("race_concept_id");

                entity.Property(e => e.RaceSourceConceptId).HasColumnName("race_source_concept_id");

                entity.Property(e => e.RaceSourceValue)
                    .HasColumnName("race_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.TimeOfBirth)
                    .HasColumnName("time_of_birth")
                    .HasColumnType("VARCHAR(10)");

                entity.Property(e => e.YearOfBirth).HasColumnName("year_of_birth");
            });

            modelBuilder.Entity<ProcedureCost>(entity =>
            {
                entity.ToTable("procedure_cost");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyConceptId).HasColumnName("currency_concept_id");

                entity.Property(e => e.PaidByCoordinationBenefits)
                    .HasColumnName("paid_by_coordination_benefits")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidByPayer)
                    .HasColumnName("paid_by_payer")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidCoinsurance)
                    .HasColumnName("paid_coinsurance")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidCopay)
                    .HasColumnName("paid_copay")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidTowardDeductible)
                    .HasColumnName("paid_toward_deductible")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PayerPlanPeriodId).HasColumnName("payer_plan_period_id");

                entity.Property(e => e.ProcedureCostId).HasColumnName("procedure_cost_id");

                entity.Property(e => e.ProcedureOccurrenceId).HasColumnName("procedure_occurrence_id");

                entity.Property(e => e.RevenueCodeConceptId).HasColumnName("revenue_code_concept_id");

                entity.Property(e => e.RevenueCodeSourceValue)
                    .HasColumnName("revenue_code_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.TotalOutOfPocket)
                    .HasColumnName("total_out_of_pocket")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.TotalPaid)
                    .HasColumnName("total_paid")
                    .HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<ProcedureOccurrence>(entity =>
            {
                entity.ToTable("procedure_occurrence");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifierConceptId).HasColumnName("modifier_concept_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.ProcedureConceptId).HasColumnName("procedure_concept_id");

                entity.Property(e => e.ProcedureDate)
                    .IsRequired()
                    .HasColumnName("procedure_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ProcedureOccurrenceId).HasColumnName("procedure_occurrence_id");

                entity.Property(e => e.ProcedureSourceConceptId).HasColumnName("procedure_source_concept_id");

                entity.Property(e => e.ProcedureSourceValue)
                    .HasColumnName("procedure_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.ProcedureTypeConceptId).HasColumnName("procedure_type_concept_id");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.QualifierSourceValue)
                    .HasColumnName("qualifier_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.VisitOccurrenceId)
                    .HasColumnName("visit_occurrence_id")
                    .HasColumnType("BIGINT");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("provider");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CareSiteId).HasColumnName("care_site_id");

                entity.Property(e => e.Dea)
                    .HasColumnName("dea")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.GenderConceptId).HasColumnName("gender_concept_id");

                entity.Property(e => e.GenderSourceConceptId).HasColumnName("gender_source_concept_id");

                entity.Property(e => e.GenderSourceValue)
                    .HasColumnName("gender_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Npi)
                    .HasColumnName("npi")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("provider_name")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.ProviderSourceValue)
                    .HasColumnName("provider_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.SpecialtyConceptId).HasColumnName("specialty_concept_id");

                entity.Property(e => e.SpecialtySourceConceptId).HasColumnName("specialty_source_concept_id");

                entity.Property(e => e.SpecialtySourceValue)
                    .HasColumnName("specialty_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.YearOfBirth).HasColumnName("year_of_birth");
            });

            modelBuilder.Entity<Relationship>(entity =>
            {
                entity.ToTable("relationship");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefinesAncestry)
                    .IsRequired()
                    .HasColumnName("defines_ancestry")
                    .HasColumnType("VARCHAR(1)");

                entity.Property(e => e.IsHierarchical)
                    .IsRequired()
                    .HasColumnName("is_hierarchical")
                    .HasColumnType("VARCHAR(1)");

                entity.Property(e => e.RelationshipConceptId).HasColumnName("relationship_concept_id");

                entity.Property(e => e.RelationshipId)
                    .IsRequired()
                    .HasColumnName("relationship_id")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.RelationshipName)
                    .IsRequired()
                    .HasColumnName("relationship_name")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.ReverseRelationshipId)
                    .IsRequired()
                    .HasColumnName("reverse_relationship_id")
                    .HasColumnType("VARCHAR(20)");
            });

            modelBuilder.Entity<SourceToConceptMap>(entity =>
            {
                entity.ToTable("source_to_concept_map");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.InvalidReason)
                    .HasColumnName("invalid_reason")
                    .HasColumnType("VARCHAR(1)");

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasColumnName("source_code")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.SourceCodeDescription)
                    .HasColumnName("source_code_description")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.SourceConceptId).HasColumnName("source_concept_id");

                entity.Property(e => e.SourceVocabularyId)
                    .IsRequired()
                    .HasColumnName("source_vocabulary_id")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.TargetConceptId).HasColumnName("target_concept_id");

                entity.Property(e => e.TargetVocabularyId)
                    .IsRequired()
                    .HasColumnName("target_vocabulary_id")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.ValidEndDate)
                    .IsRequired()
                    .HasColumnName("valid_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.ValidStartDate)
                    .IsRequired()
                    .HasColumnName("valid_start_date")
                    .HasColumnType("DATE");
            });

            modelBuilder.Entity<Specimen>(entity =>
            {
                entity.ToTable("specimen");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnatomicSiteConceptId).HasColumnName("anatomic_site_concept_id");

                entity.Property(e => e.AnatomicSiteSourceValue)
                    .HasColumnName("anatomic_site_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.DiseaseStatusConceptId).HasColumnName("disease_status_concept_id");

                entity.Property(e => e.DiseaseStatusSourceValue)
                    .HasColumnName("disease_status_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.SpecimenConceptId).HasColumnName("specimen_concept_id");

                entity.Property(e => e.SpecimenDate)
                    .IsRequired()
                    .HasColumnName("specimen_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.SpecimenId).HasColumnName("specimen_id");

                entity.Property(e => e.SpecimenSourceId)
                    .HasColumnName("specimen_source_id")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.SpecimenSourceValue)
                    .HasColumnName("specimen_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.SpecimenTime)
                    .HasColumnName("specimen_time")
                    .HasColumnType("VARCHAR(10)");

                entity.Property(e => e.SpecimenTypeConceptId).HasColumnName("specimen_type_concept_id");

                entity.Property(e => e.UnitConceptId).HasColumnName("unit_concept_id");

                entity.Property(e => e.UnitSourceValue)
                    .HasColumnName("unit_source_value")
                    .HasColumnType("VARCHAR(50)");
            });

            modelBuilder.Entity<VisitCost>(entity =>
            {
                entity.ToTable("visit_cost");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyConceptId).HasColumnName("currency_concept_id");

                entity.Property(e => e.PaidByCoordinationBenefits)
                    .HasColumnName("paid_by_coordination_benefits")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidByPayer)
                    .HasColumnName("paid_by_payer")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidCoinsurance)
                    .HasColumnName("paid_coinsurance")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidCopay)
                    .HasColumnName("paid_copay")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PaidTowardDeductible)
                    .HasColumnName("paid_toward_deductible")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.PayerPlanPeriodId).HasColumnName("payer_plan_period_id");

                entity.Property(e => e.TotalOutOfPocket)
                    .HasColumnName("total_out_of_pocket")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.TotalPaid)
                    .HasColumnName("total_paid")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.VisitCostId).HasColumnName("visit_cost_id");

                entity.Property(e => e.VisitOccurrenceId)
                    .HasColumnName("visit_occurrence_id")
                    .HasColumnType("BIGINT");
            });

            modelBuilder.Entity<VisitOccurrence>(entity =>
            {
                entity.ToTable("visit_occurrence");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CareSiteId).HasColumnName("care_site_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.VisitConceptId).HasColumnName("visit_concept_id");

                entity.Property(e => e.VisitEndDate)
                    .IsRequired()
                    .HasColumnName("visit_end_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.VisitEndTime)
                    .HasColumnName("visit_end_time")
                    .HasColumnType("VARCHAR(10)");

                entity.Property(e => e.VisitOccurrenceId)
                    .HasColumnName("visit_occurrence_id")
                    .HasColumnType("BIGINT");

                entity.Property(e => e.VisitSourceConceptId).HasColumnName("visit_source_concept_id");

                entity.Property(e => e.VisitSourceValue)
                    .HasColumnName("visit_source_value")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.VisitStartDate)
                    .IsRequired()
                    .HasColumnName("visit_start_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.VisitStartTime)
                    .HasColumnName("visit_start_time")
                    .HasColumnType("VARCHAR(10)");

                entity.Property(e => e.VisitTypeConceptId).HasColumnName("visit_type_concept_id");
            });

            modelBuilder.Entity<Vocabulary>(entity =>
            {
                entity.ToTable("vocabulary");

                entity.Property(e => e.VocabularyId)
                    .HasColumnName("vocabulary_id")
                    .HasColumnType("VARCHAR(20)");

                entity.Property(e => e.VocabularyConceptId).HasColumnName("vocabulary_concept_id");

                entity.Property(e => e.VocabularyName)
                    .IsRequired()
                    .HasColumnName("vocabulary_name")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.VocabularyReference)
                    .IsRequired()
                    .HasColumnName("vocabulary_reference")
                    .HasColumnType("VARCHAR(255)");

                entity.Property(e => e.VocabularyVersion)
                    .IsRequired()
                    .HasColumnName("vocabulary_version")
                    .HasColumnType("VARCHAR(255)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
