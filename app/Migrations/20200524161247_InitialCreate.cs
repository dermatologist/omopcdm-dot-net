using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "attribute_definition",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    attribute_definition_id = table.Column<int>(nullable: false),
                    attribute_name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    attribute_description = table.Column<string>(nullable: true),
                    attribute_type_concept_id = table.Column<int>(nullable: false),
                    attribute_syntax = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attribute_definition", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "care_site",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    care_site_id = table.Column<int>(nullable: false),
                    care_site_name = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    place_of_service_concept_id = table.Column<int>(nullable: true),
                    location_id = table.Column<int>(nullable: true),
                    care_site_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    place_of_service_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_care_site", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "cdm_source",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    cdm_source_name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    cdm_source_abbreviation = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    cdm_holder = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    source_description = table.Column<string>(nullable: true),
                    source_documentation_reference = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    cdm_etl_reference = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    source_release_date = table.Column<byte[]>(type: "DATE", nullable: true),
                    cdm_release_date = table.Column<byte[]>(type: "DATE", nullable: true),
                    cdm_version = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    vocabulary_version = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdm_source", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "cohort",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    cohort_definition_id = table.Column<int>(nullable: false),
                    subject_id = table.Column<int>(nullable: false),
                    cohort_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    cohort_end_date = table.Column<byte[]>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cohort", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "cohort_attribute",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    cohort_definition_id = table.Column<int>(nullable: false),
                    cohort_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    cohort_end_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    subject_id = table.Column<int>(nullable: false),
                    attribute_definition_id = table.Column<int>(nullable: false),
                    value_as_number = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    value_as_concept_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cohort_attribute", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "cohort_definition",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    cohort_definition_id = table.Column<int>(nullable: false),
                    cohort_definition_name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    cohort_definition_description = table.Column<string>(nullable: true),
                    definition_type_concept_id = table.Column<int>(nullable: false),
                    cohort_definition_syntax = table.Column<string>(nullable: true),
                    subject_concept_id = table.Column<int>(nullable: false),
                    cohort_initiation_date = table.Column<byte[]>(type: "DATE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cohort_definition", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "concept",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    concept_id = table.Column<int>(nullable: false),
                    concept_name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    domain_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    vocabulary_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    concept_class_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    standard_concept = table.Column<string>(type: "VARCHAR(1)", nullable: true),
                    concept_code = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    valid_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    valid_end_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    invalid_reason = table.Column<string>(type: "VARCHAR(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_concept", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "concept_ancestor",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    ancestor_concept_id = table.Column<int>(nullable: false),
                    descendant_concept_id = table.Column<int>(nullable: false),
                    min_levels_of_separation = table.Column<int>(nullable: false),
                    max_levels_of_separation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_concept_ancestor", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "concept_class",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    concept_class_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    concept_class_name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    concept_class_concept_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_concept_class", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "concept_relationship",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    concept_id_1 = table.Column<int>(nullable: false),
                    concept_id_2 = table.Column<int>(nullable: false),
                    relationship_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    valid_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    valid_end_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    invalid_reason = table.Column<string>(type: "VARCHAR(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_concept_relationship", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "concept_synonym",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    concept_id = table.Column<int>(nullable: false),
                    concept_synonym_name = table.Column<string>(type: "VARCHAR(1000)", nullable: false),
                    language_concept_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_concept_synonym", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "condition_era",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    condition_era_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    condition_concept_id = table.Column<int>(nullable: false),
                    condition_era_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    condition_era_end_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    condition_occurrence_count = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_condition_era", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "condition_occurrence",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    condition_occurrence_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    condition_concept_id = table.Column<int>(nullable: false),
                    condition_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    condition_end_date = table.Column<byte[]>(type: "DATE", nullable: true),
                    condition_type_concept_id = table.Column<int>(nullable: false),
                    stop_reason = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    provider_id = table.Column<int>(nullable: true),
                    visit_occurrence_id = table.Column<int>(type: "BIGINT", nullable: true),
                    condition_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    condition_source_concept_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_condition_occurrence", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "death",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    death_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    death_type_concept_id = table.Column<int>(nullable: false),
                    cause_concept_id = table.Column<int>(nullable: true),
                    cause_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    cause_source_concept_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_death", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "device_cost",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    device_cost_id = table.Column<int>(nullable: false),
                    device_exposure_id = table.Column<int>(nullable: false),
                    currency_concept_id = table.Column<int>(nullable: true),
                    paid_copay = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_coinsurance = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_toward_deductible = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_by_payer = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_by_coordination_benefits = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    total_out_of_pocket = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    total_paid = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    payer_plan_period_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_device_cost", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "device_exposure",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    device_exposure_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    device_concept_id = table.Column<int>(nullable: false),
                    device_exposure_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    device_exposure_end_date = table.Column<byte[]>(type: "DATE", nullable: true),
                    device_type_concept_id = table.Column<int>(nullable: false),
                    unique_device_id = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    quantity = table.Column<int>(nullable: true),
                    provider_id = table.Column<int>(nullable: true),
                    visit_occurrence_id = table.Column<int>(type: "BIGINT", nullable: true),
                    device_source_value = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    device_source_concept_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_device_exposure", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "domain",
                columns: table => new
                {
                    domain_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    domain_name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    domain_concept_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_domain", x => x.domain_id);
                });

            migrationBuilder.CreateTable(
                name: "dose_era",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    dose_era_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    drug_concept_id = table.Column<int>(nullable: false),
                    unit_concept_id = table.Column<int>(nullable: false),
                    dose_value = table.Column<byte[]>(type: "NUMERIC", nullable: false),
                    dose_era_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    dose_era_end_date = table.Column<byte[]>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dose_era", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "drug_cost",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    drug_cost_id = table.Column<int>(nullable: false),
                    drug_exposure_id = table.Column<int>(nullable: false),
                    currency_concept_id = table.Column<int>(nullable: true),
                    paid_copay = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_coinsurance = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_toward_deductible = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_by_payer = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_by_coordination_benefits = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    total_out_of_pocket = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    total_paid = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    ingredient_cost = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    dispensing_fee = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    average_wholesale_price = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    payer_plan_period_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drug_cost", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "drug_era",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    drug_era_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    drug_concept_id = table.Column<int>(nullable: false),
                    drug_era_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    drug_era_end_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    drug_exposure_count = table.Column<int>(nullable: true),
                    gap_days = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drug_era", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "drug_exposure",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    drug_exposure_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    drug_concept_id = table.Column<int>(nullable: false),
                    drug_exposure_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    drug_exposure_end_date = table.Column<byte[]>(type: "DATE", nullable: true),
                    drug_type_concept_id = table.Column<int>(nullable: false),
                    stop_reason = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    refills = table.Column<int>(nullable: true),
                    quantity = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    days_supply = table.Column<int>(nullable: true),
                    sig = table.Column<string>(nullable: true),
                    route_concept_id = table.Column<int>(nullable: true),
                    effective_drug_dose = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    dose_unit_concept_id = table.Column<int>(nullable: true),
                    lot_number = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    provider_id = table.Column<int>(nullable: true),
                    visit_occurrence_id = table.Column<int>(type: "BIGINT", nullable: true),
                    drug_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    drug_source_concept_id = table.Column<int>(nullable: true),
                    route_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    dose_unit_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drug_exposure", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "drug_strength",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    drug_concept_id = table.Column<int>(nullable: false),
                    ingredient_concept_id = table.Column<int>(nullable: false),
                    amount_value = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    amount_unit_concept_id = table.Column<int>(nullable: true),
                    numerator_value = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    numerator_unit_concept_id = table.Column<int>(nullable: true),
                    denominator_value = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    denominator_unit_concept_id = table.Column<int>(nullable: true),
                    box_size = table.Column<int>(nullable: true),
                    valid_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    valid_end_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    invalid_reason = table.Column<string>(type: "VARCHAR(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drug_strength", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "fact_relationship",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    domain_concept_id_1 = table.Column<int>(nullable: false),
                    fact_id_1 = table.Column<int>(nullable: false),
                    domain_concept_id_2 = table.Column<int>(nullable: false),
                    fact_id_2 = table.Column<int>(nullable: false),
                    relationship_concept_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fact_relationship", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    location_id = table.Column<int>(nullable: false),
                    address_1 = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    address_2 = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    city = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    state = table.Column<string>(type: "VARCHAR(2)", nullable: true),
                    zip = table.Column<string>(type: "VARCHAR(9)", nullable: true),
                    county = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    location_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "measurement",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    measurement_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    measurement_concept_id = table.Column<int>(nullable: false),
                    measurement_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    measurement_time = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    measurement_type_concept_id = table.Column<int>(nullable: false),
                    operator_concept_id = table.Column<int>(nullable: true),
                    value_as_number = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    value_as_concept_id = table.Column<int>(nullable: true),
                    unit_concept_id = table.Column<int>(nullable: true),
                    range_low = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    range_high = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    provider_id = table.Column<int>(nullable: true),
                    visit_occurrence_id = table.Column<int>(type: "BIGINT", nullable: true),
                    measurement_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    measurement_source_concept_id = table.Column<int>(nullable: true),
                    unit_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    value_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_measurement", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "note",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    note_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    note_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    note_time = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    note_type_concept_id = table.Column<int>(nullable: false),
                    note_text = table.Column<string>(nullable: false),
                    provider_id = table.Column<int>(nullable: true),
                    visit_occurrence_id = table.Column<int>(type: "BIGINT", nullable: true),
                    note_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_note", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "observation",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    observation_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    observation_concept_id = table.Column<int>(nullable: false),
                    observation_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    observation_time = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    observation_type_concept_id = table.Column<int>(nullable: false),
                    value_as_number = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    value_as_string = table.Column<string>(type: "VARCHAR(60)", nullable: true),
                    value_as_concept_id = table.Column<int>(nullable: true),
                    qualifier_concept_id = table.Column<int>(nullable: true),
                    unit_concept_id = table.Column<int>(nullable: true),
                    provider_id = table.Column<int>(nullable: true),
                    visit_occurrence_id = table.Column<int>(type: "BIGINT", nullable: true),
                    observation_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    observation_source_concept_id = table.Column<int>(nullable: true),
                    unit_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    qualifier_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_observation", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "observation_period",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    observation_period_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    observation_period_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    observation_period_end_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    period_type_concept_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_observation_period", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "payer_plan_period",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    payer_plan_period_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    payer_plan_period_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    payer_plan_period_end_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    payer_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    plan_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    family_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payer_plan_period", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    gender_concept_id = table.Column<int>(nullable: false),
                    year_of_birth = table.Column<int>(nullable: false),
                    month_of_birth = table.Column<int>(nullable: true),
                    day_of_birth = table.Column<int>(nullable: true),
                    time_of_birth = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    race_concept_id = table.Column<int>(nullable: false),
                    ethnicity_concept_id = table.Column<int>(nullable: false),
                    location_id = table.Column<int>(nullable: true),
                    provider_id = table.Column<int>(nullable: true),
                    care_site_id = table.Column<int>(nullable: true),
                    person_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    gender_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    gender_source_concept_id = table.Column<int>(nullable: true),
                    race_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    race_source_concept_id = table.Column<int>(nullable: true),
                    ethnicity_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    ethnicity_source_concept_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "procedure_cost",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    procedure_cost_id = table.Column<int>(nullable: false),
                    procedure_occurrence_id = table.Column<int>(nullable: false),
                    currency_concept_id = table.Column<int>(nullable: true),
                    paid_copay = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_coinsurance = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_toward_deductible = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_by_payer = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_by_coordination_benefits = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    total_out_of_pocket = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    total_paid = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    revenue_code_concept_id = table.Column<int>(nullable: true),
                    payer_plan_period_id = table.Column<int>(nullable: true),
                    revenue_code_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procedure_cost", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "procedure_occurrence",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    procedure_occurrence_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    procedure_concept_id = table.Column<int>(nullable: false),
                    procedure_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    procedure_type_concept_id = table.Column<int>(nullable: false),
                    modifier_concept_id = table.Column<int>(nullable: true),
                    quantity = table.Column<int>(nullable: true),
                    provider_id = table.Column<int>(nullable: true),
                    visit_occurrence_id = table.Column<int>(type: "BIGINT", nullable: true),
                    procedure_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    procedure_source_concept_id = table.Column<int>(nullable: true),
                    qualifier_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procedure_occurrence", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "provider",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    provider_id = table.Column<int>(nullable: false),
                    provider_name = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    npi = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    dea = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    specialty_concept_id = table.Column<int>(nullable: true),
                    care_site_id = table.Column<int>(nullable: true),
                    year_of_birth = table.Column<int>(nullable: true),
                    gender_concept_id = table.Column<int>(nullable: true),
                    provider_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    specialty_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    specialty_source_concept_id = table.Column<int>(nullable: true),
                    gender_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    gender_source_concept_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provider", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "relationship",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    relationship_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    relationship_name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    is_hierarchical = table.Column<string>(type: "VARCHAR(1)", nullable: false),
                    defines_ancestry = table.Column<string>(type: "VARCHAR(1)", nullable: false),
                    reverse_relationship_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    relationship_concept_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relationship", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "source_to_concept_map",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    source_code = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    source_concept_id = table.Column<int>(nullable: false),
                    source_vocabulary_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    source_code_description = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    target_concept_id = table.Column<int>(nullable: false),
                    target_vocabulary_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    valid_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    valid_end_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    invalid_reason = table.Column<string>(type: "VARCHAR(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_source_to_concept_map", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "specimen",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    specimen_id = table.Column<int>(nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    specimen_concept_id = table.Column<int>(nullable: false),
                    specimen_type_concept_id = table.Column<int>(nullable: false),
                    specimen_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    specimen_time = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    quantity = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    unit_concept_id = table.Column<int>(nullable: true),
                    anatomic_site_concept_id = table.Column<int>(nullable: true),
                    disease_status_concept_id = table.Column<int>(nullable: true),
                    specimen_source_id = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    specimen_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    unit_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    anatomic_site_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    disease_status_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specimen", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "visit_cost",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    visit_cost_id = table.Column<int>(nullable: false),
                    visit_occurrence_id = table.Column<int>(type: "BIGINT", nullable: false),
                    currency_concept_id = table.Column<int>(nullable: true),
                    paid_copay = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_coinsurance = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_toward_deductible = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_by_payer = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    paid_by_coordination_benefits = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    total_out_of_pocket = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    total_paid = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    payer_plan_period_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit_cost", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "visit_occurrence",
                columns: table => new
                {
                    _id = table.Column<int>(nullable: false),
                    visit_occurrence_id = table.Column<int>(type: "BIGINT", nullable: false),
                    person_id = table.Column<int>(nullable: false),
                    visit_concept_id = table.Column<int>(nullable: false),
                    visit_start_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    visit_start_time = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    visit_end_date = table.Column<byte[]>(type: "DATE", nullable: false),
                    visit_end_time = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    visit_type_concept_id = table.Column<int>(nullable: false),
                    provider_id = table.Column<int>(nullable: true),
                    care_site_id = table.Column<int>(nullable: true),
                    visit_source_value = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    visit_source_concept_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit_occurrence", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "vocabulary",
                columns: table => new
                {
                    vocabulary_id = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    vocabulary_name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    vocabulary_reference = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    vocabulary_version = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    vocabulary_concept_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vocabulary", x => x.vocabulary_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attribute_definition");

            migrationBuilder.DropTable(
                name: "care_site");

            migrationBuilder.DropTable(
                name: "cdm_source");

            migrationBuilder.DropTable(
                name: "cohort");

            migrationBuilder.DropTable(
                name: "cohort_attribute");

            migrationBuilder.DropTable(
                name: "cohort_definition");

            migrationBuilder.DropTable(
                name: "concept");

            migrationBuilder.DropTable(
                name: "concept_ancestor");

            migrationBuilder.DropTable(
                name: "concept_class");

            migrationBuilder.DropTable(
                name: "concept_relationship");

            migrationBuilder.DropTable(
                name: "concept_synonym");

            migrationBuilder.DropTable(
                name: "condition_era");

            migrationBuilder.DropTable(
                name: "condition_occurrence");

            migrationBuilder.DropTable(
                name: "death");

            migrationBuilder.DropTable(
                name: "device_cost");

            migrationBuilder.DropTable(
                name: "device_exposure");

            migrationBuilder.DropTable(
                name: "domain");

            migrationBuilder.DropTable(
                name: "dose_era");

            migrationBuilder.DropTable(
                name: "drug_cost");

            migrationBuilder.DropTable(
                name: "drug_era");

            migrationBuilder.DropTable(
                name: "drug_exposure");

            migrationBuilder.DropTable(
                name: "drug_strength");

            migrationBuilder.DropTable(
                name: "fact_relationship");

            migrationBuilder.DropTable(
                name: "location");

            migrationBuilder.DropTable(
                name: "measurement");

            migrationBuilder.DropTable(
                name: "note");

            migrationBuilder.DropTable(
                name: "observation");

            migrationBuilder.DropTable(
                name: "observation_period");

            migrationBuilder.DropTable(
                name: "payer_plan_period");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "procedure_cost");

            migrationBuilder.DropTable(
                name: "procedure_occurrence");

            migrationBuilder.DropTable(
                name: "provider");

            migrationBuilder.DropTable(
                name: "relationship");

            migrationBuilder.DropTable(
                name: "source_to_concept_map");

            migrationBuilder.DropTable(
                name: "specimen");

            migrationBuilder.DropTable(
                name: "visit_cost");

            migrationBuilder.DropTable(
                name: "visit_occurrence");

            migrationBuilder.DropTable(
                name: "vocabulary");
        }
    }
}
