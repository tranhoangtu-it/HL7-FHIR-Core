using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HL7.FHIR.DLL.DTO.Components
{
    public class DischargeDto
    {
        public string RegistererDisplay { get; set; }
        public string AuthorDisplay { get; set; }
        public string Status { get; set; }
        public string DocumentCode { get; set; }
        public string DocumentDisplay { get; set; }
        public string DocumentDate { get; set; }
        public string DocumentFilePath { get; set; }
        public string DocumentFileName { get; set; }
        public string BrowsingConsent { get; set; }
        public string PClass { get; set; }

        // 医療機関
        public string CustodianFacilityCode { get; set; }
        public string CustodianFacilityName { get; set; }
        public string AuthorFacilityCode { get; set; }
        public string AuthorFacilityName { get; set; }
        public string AuthorFacilityPostalCode { get; set; }
        public string AuthorFacilityAddress { get; set; }
        public string AuthorFacilityTel01 { get; set; }
        public string AuthorFacilityTel02 { get; set; }
        public string AuthorFacilityFax { get; set; }
        public string AuthorDepartmentCode { get; set; }
        public string AuthorDepartmentDisplay { get; set; }

        // 入院詳細
        public string AdmIdentifier { get; set; }
        public string AdmStartDate { get; set; }
        public string AdmEndDate { get; set; }
        public string AdmDiagnoses { get; set; }
        public string AMedisKanriNo { get; set; }
        public string AMedisKanriNoDisplay { get; set; }

        // 臨床情報
        public string AllergyIntolerance { get; set; }
        public string ChiefComplaint { get; set; }
        public string AdmReason { get; set; }
        public string PresentIllness { get; set; }
        public string PastIllness { get; set; }
        public string AdmMedication { get; set; }
        public string SocialHistory { get; set; }
        public string AdmPhysical { get; set; }
        public string FamiliyHistory { get; set; }
        public string HospitalCourse { get; set; }

        // 退院時
        public string DisDiagnoses { get; set; }
        public string DMedisKanriNo { get; set; }
        public string DMedisKanriNoDisplay { get; set; }
        public string DisDisposition { get; set; }
        public string DisMedication { get; set; }
        public string DisInstruction { get; set; }
        public string DisPhysical { get; set; }

        // その他
        public string HospitalProcedure { get; set; }
        public string HospitalStudy { get; set; }
        public string MedicalDevice { get; set; }
        public string Immunization { get; set; }
        public string AdvanceDirective { get; set; }
        public string ResearchParticipation { get; set; }
        public string Attachment { get; set; }
        public string Remarks { get; set; }
    }
}