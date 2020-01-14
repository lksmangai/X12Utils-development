using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

using System.Web;
using System.Xml;
using System.Security.Cryptography;
using System.Data;
using System.Xml.Linq;


using Newtonsoft.Json;

using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;

namespace EDIUtilsWeb
{

    public class EDIInput270
    {
        public string SurescriptsPassword { get; set; }
        public string SurescriptsParticipantId { get; set; }
        public bool Staging { get; set; }

        public string PatientProviderLastName { get; set; }
        public string PatientProviderFirstName { get; set; }
        public string PatientProviderMiddleName { get; set; }
        public string PatientProviderSuffix { get; set; }
        public string PatientProviderNPI { get; set; }
        public string PatientProviderDEA { get; set; }
        public string PatientProviderAddressLine1 { get; set; }
        public string PatientProviderAddressLine2 { get; set; }
        public string PatientProviderAddressCity { get; set; }
        public string PatientProviderAddressState { get; set; }
        public string PatientProviderAddressZip { get; set; }

        public long PatientID { get; set; }
        public string PatientLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleName { get; set; }
        public string PatientAddressLine1 { get; set; }
        public string PatientAddressLine2 { get; set; }
        public string PatientAddressCity { get; set; }
        public string PatientAddressState { get; set; }
        public string PatientAddressZip { get; set; }
        public DateTime PatientDOB { get; set; }
        public string PatientGender { get; set; }

    }
    public class EDIOutput270
    {
        public string strControlNo { get; set; }
        public string ediItem { get; set; }
    }
    public class EDIInput271
    {
        public bool Send270UsingDEA { get; set; }
        public string ediItem { get; set; }
    }
    public class EDIOutput271
    {
        public bool Send270UsingDEA { get; set; }
        public string SenderID { get; set; }
        public string RecieverID { get; set; }
        public string ControlNumber { get; set; }
        public string ShowMessage { get; set; }
        public string EligibilityDate { get; set; }
        public string MessageType { get; set; }
        public string STLoopCount { get; set; }
        public string MessageID { get; set; }
        public string Entity { get; set; }
        public string InformationSourceName { get; set; }
        public string PayerName { get; set; }
        public string PayerParticipantId { get; set; }
        public string RecieverLastName { get; set; }
        public string RecieverFirstName { get; set; }
        public string RecieverMiddleName { get; set; }
        public string InformationRecieverName { get; set; }
        public string InformationRecieverSuffix { get; set; }
        public string CodeQualifier { get; set; }
        public string NPINumber { get; set; }
        public string InformationReceiverAAAQualifier { get; set; }
        public string InformationReceiverRejectionDescription { get; set; }
        public string TRNQualifier { get; set; }
        public string TRNReferenceIdentification { get; set; }
        public string TRNOrignationCompanyIdentifier { get; set; }
        public string TRNDivisionorGroup { get; set; }
        public string SubscriberLastName { get; set; }
        public string SubscriberFirstName { get; set; }
        public string SubscriberMiddleName { get; set; }
        public string SubscriberSuffix { get; set; }
        public string MemberID { get; set; }
        public string SubscriberAddress1 { get; set; }
        public string SubscriberAddress2 { get; set; }
        public string SubscriberCity { get; set; }
        public string SubscriberState { get; set; }
        public string SubscriberZip { get; set; }
        public string EmployeeId { get; set; }
        public string HealthPlanNumber { get; set; }
        public string HealthPlanName { get; set; }
        public string CardHolderId { get; set; }
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public string FormularyListId { get; set; }
        public string AlternativeListId { get; set; }
        public string CoverageId { get; set; }
        public string BINNumber { get; set; }
        public string CopayId { get; set; }
        public string CardHolderName { get; set; }
        public string PersonCode { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string PatientAccountNumber { get; set; }
        public string SubscriberAAAQualifier { get; set; }
        public string SubscriberRejectionDescription { get; set; }
        public string SubscriberDOB { get; set; }
        public string SubscriberGender { get; set; }
        public string IsSubscriberdemoChange { get; set; }
        public string SubscriberDemoChgLastName { get; set; }
        public string SubscriberDemochgFirstName { get; set; }
        public string SubscriberDemoChgMiddleName { get; set; }
        public string SubscriberDemoChgZip { get; set; }
        public string SubscriberDemoChgDOB { get; set; }
        public string SubscriberDemoChgGender { get; set; }
        public string SubscriberDemoChgState { get; set; }
        public string SubscriberDemoChgCity { get; set; }
        public string SubscriberDemoChgAddress1 { get; set; }
        public string SubscriberDemoChgAddress2 { get; set; }
        public string RelationshipCode { get; set; }
        public string RelationshipDescription { get; set; }
        public string EligiblityDate { get; set; }
        public string ServiceDate { get; set; }
        public bool NM1InformationFound { get; set; }
        public string DependentProvider { get; set; }
        public string IsContractedProvider { get; set; }
        public string ContractedProviderName { get; set; }
        public string ContractedProviderNumber { get; set; }
        public string IsPrimaryProvider { get; set; }
        public string PrimaryProviderName { get; set; }
        public string PrimaryProviderNumber { get; set; }
        public string QualifierPharmacyCode { get; set; }
        public string QualifierInsuranceTypeCode { get; set; }
        public string IsMailOrdRxDrugEligible { get; set; }
        public string MailOrdRxDrugEligiblityorBenefitInfo { get; set; }
        public string IsRetailPharmacyEligible { get; set; }
        public string RetailInsTypeCode { get; set; }
        public string RetailPharmacyCoveragePlanName { get; set; }
        public string RetailMonetaryAmount { get; set; }
        public string RetailPharmacyEligiblityorBenefitInfo { get; set; }
        public string MailOrdRxDrugCoveragePlanName { get; set; }
        public string MailOrderMonetaryAmount { get; set; }
        public string HlthPlnCovInsTypeCode { get; set; }
        public string HealthPlanBenefitEligibilityInfo { get; set; }
        public string HealthPlanBenefitCoverageName { get; set; }
        public string SpecialtyorLTCPhrmCovName { get; set; }
        public string SpecialtyorLTCCoverageStatus { get; set; }
        public string ContProvRetailsEligible { get; set; }
        public string ContProvRetailInsTypeCode { get; set; }
        public string ContProvRetailCoveragePlanName { get; set; }
        public string ContProvRetailMonetaryAmt { get; set; }
        public string ContProvRetailCoverageInfo { get; set; }
        public string ContProvMailOrderEligible { get; set; }
        public string ContProvMailOrderTypeCode { get; set; }
        public string ContProvMailOrderCoveragePlanName { get; set; }
        public string ContProvMailOrderMonetaryAmt { get; set; }
        public string ContProvMailOrderCoverageInfo { get; set; }
        public string PrimaryPayerRetailsEligible { get; set; }
        public string PrimaryPayerRetailInsTypeCode { get; set; }
        public string PrimaryPayerRetailCoveragePlanName { get; set; }
        public string PrimaryPayerRetailMonetaryAmt { get; set; }
        public string PrimaryPayerRetailCoverageInfo { get; set; }
        public string PrimaryPayerMailOrderEligible { get; set; }
        public string PrimaryPayerMailOrderTypeCode { get; set; }
        public string PrimaryPayerMailOrderCoveragePlanName { get; set; }
        public string PrimaryPayerMailOrderMonetaryAmt { get; set; }
        public string PrimaryPayerMailOrderCoverageInfo { get; set; }
        public string PCNNumber { get; set; }
        public string HlthPlnBenftCovEligibilityDate { get; set; }
        public string HlthPlnBenftCovServiceDate { get; set; }
        public string RetailOrdPhrmEligibilityDate { get; set; }
        public string RetailPhrmServiceDate { get; set; }
        public string MailOrdPhrmEligibilityDate { get; set; }
        public string MailOrdPhrmServiceDate { get; set; }
        public string SpecialtyorLTCPhrmEligibilityDate { get; set; }
        public string SpecialtyorLTCPhrmServiceDate { get; set; }
        public string QualifierMSGText { get; set; }
        public string LTCPhEligiblityorBenefitInfo { get; set; }
        public string LTCPharmCovName { get; set; }
        public string LTCPhrmEligDate { get; set; }
        public string LTCPhrmServiceDate { get; set; }
        public string SpecialityPhEligiblityorBenefitInfo { get; set; }
        public string SpecialtyPharmCovName { get; set; }
        public string SpecialtyPhrmEligDate { get; set; }
        public string SpecialtyPhrmServiceDate { get; set; }

    }

    public class EDIInput
    {
        public string SurescriptsPassword { get; set; }
        public string SurescriptsParticipantId { get; set; }
        public bool Staging { get; set; }

        public string PatientProviderLastName { get; set; }
        public string PatientProviderFirstName { get; set; }
        public string PatientProviderMiddleName { get; set; }
        public string PatientProviderSuffix { get; set; }
        public string PatientProviderNPI { get; set; }
        public string PatientProviderDEA { get; set; }
        public string PatientProviderAddressLine1 { get; set; }
        public string PatientProviderAddressLine2 { get; set; }
        public string PatientProviderAddressCity { get; set; }
        public string PatientProviderAddressState { get; set; }
        public string PatientProviderAddressZip { get; set; }

        public long PatientID { get; set; }
        public string PatientLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleName { get; set; }
        public string PatientAddressLine1 { get; set; }
        public string PatientAddressLine2 { get; set; }
        public string PatientAddressCity { get; set; }
        public string PatientAddressState { get; set; }
        public string PatientAddressZip { get; set; }
        public DateTime PatientDOB { get; set; }
        public string PatientGender { get; set; }
        public string RxhubURL { get; set; }
        public string RxHubAuthorization { get; set; }
        public bool Send270UsingDEA { get; set; }
    }

    public static class gloDate
    {

        public static Int32 DateAsNumber(string datevalue)
        {
            Int32 _result = 0;
            DateTime _internaldate = Convert.ToDateTime(datevalue);
            datevalue = string.Format(_internaldate.ToShortDateString(), "MM/dd/yyyy");
            try
            {
                if (datevalue.Length == 10)
                {
                    string _internalresult = "";
                    _internalresult = datevalue.Substring(6, 4) + datevalue.Substring(0, 2) + datevalue.Substring(3, 2);
                    _result = Convert.ToInt32(_internalresult);
                    _internalresult = null;
                }
                else if (datevalue.Length == 9)
                {
                    string _internalresult = "";
                    if (_internaldate.Month <= 9) // 1/11/2007
                    {
                        _internalresult = datevalue.Substring(5, 4) + "0" + datevalue.Substring(0, 1) + datevalue.Substring(2, 2);
                    }
                    else if (_internaldate.Day <= 9) // 11/2/2007
                    {
                        _internalresult = datevalue.Substring(5, 4) + datevalue.Substring(0, 2) + "0" + datevalue.Substring(3, 1);
                    }


                    _result = Convert.ToInt32(_internalresult);
                    _internalresult = null;
                }
                else if (datevalue.Length == 8)
                {
                    string _internalresult = "";
                    _internalresult = datevalue.Substring(4, 4) + "0" + datevalue.Substring(0, 1) + "0" + datevalue.Substring(2, 1);
                    _result = Convert.ToInt32(_internalresult);
                    _internalresult = null;
                }
            }
            catch (Exception)
            {

            }
            return _result;
        }
    }
    public static class gloTime
    {
        public static Int32 TimeAsNumber(string timevalue)
        {
            Int32 _result = 0;
            timevalue = string.Format(Convert.ToDateTime(timevalue).ToShortTimeString(), "hh:mm tt");
            string _internalresult = "";
            string _AmPm = null;
            string _Hour = null;
            string _Minutes = null;
            string _HourNo = "";
            string _MinuteNo = "";
            try
            {
                if (timevalue.Length <= 8)
                {
                    if (timevalue.Substring(timevalue.Length - 2, 2).ToUpper().Trim() == "AM" || timevalue.Substring(timevalue.Length - 2, 2).ToUpper().Trim() == "PM")
                    {
                        _AmPm = timevalue.Substring(timevalue.Length - 2, 2).ToUpper().Trim();
                        _Hour = timevalue.Substring(0, timevalue.IndexOf(":", 0)).ToUpper().Trim();
                        _Minutes = timevalue.Substring(timevalue.IndexOf(":", 0) + 1, 2).ToUpper().Trim();

                        if (_AmPm == "PM")
                        {
                            if (_Hour != "12")
                            {
                                _HourNo = Convert.ToString(Convert.ToInt16(_Hour) + 12);
                            }
                            else
                            {
                                _HourNo = _Hour;
                            }
                        }
                        else
                        {
                            if (_Hour == "12")
                            {
                                _HourNo = "";
                            }
                            else
                            {
                                _HourNo = _Hour;
                            }

                        }
                        _MinuteNo = _Minutes;

                        _internalresult = _HourNo + _MinuteNo;
                        _result = Convert.ToInt32(_internalresult);
                    }
                }
            }
            catch (Exception)
            {
            }
            return _result;
        }
    }

    public class EDIUtils
    {


        private string FormattedTime(string TimeFormat)
        {
            return TimeFormat.PadLeft(4, '0');
        }
        private string ReplaceSpecialChar(string sTempString)
        {
            if (sTempString != null)
            {
                return Regex.Replace(sTempString, "[~*:^]", "");
            }
            else
            {
                return sTempString;
            }

        }

        private string getRejectionDescription(string RejectionCode, string LoopName, string SegmentName)
        {
            string _sRejectionDescription = "";
            try
            {
                #region "AAA Information Source level Request Validation (HL)"

                if (LoopName == "Reciever" && SegmentName == "HL")
                {
                    switch (RejectionCode)
                    {
                        case "04":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Authorized Quantity Exceeded";
                            break;
                        case "41":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Authorization/Access Restrictions";
                            break;
                        case "42":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Unable to Respond at Current Time";
                            break;
                        case "79":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid Participant Identification";
                            break;
                        case "80":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": No Response received — Transaction Terminated";
                            break;
                        case "T4":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Payer Name or Identifier Missing";
                            break;

                    }
                }
                #endregion "AAA Information Source level Request Validation (HL)"

                #region "AAA Information Receiver Request Validation (NM1)"

                else if (LoopName == "Reciever" && SegmentName == "NM1")
                {
                    switch (RejectionCode)
                    {
                        case "15":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Required application data missing";
                            break;
                        case "41":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Authorization/Access Restrictions";
                            break;
                        case "43":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider Identification (Surescripts recommends this for NPI error.)";
                            break;
                        case "44":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider Name";
                            break;
                        case "45":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider Specialty";
                            break;
                        case "46":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider Phone Number";
                            break;
                        case "47":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider State";
                            break;
                        case "48":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Referring Provider Identification Number";
                            break;
                        case "50":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Provider Ineligible for Inquiries";
                            break;
                        case "51":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Provider Not on File";
                            break;
                        case "79":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid Participant Identification";
                            break;
                        case "97":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid or Missing Provider Address";
                            break;
                        case "T4":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Payer Name or Identifier Missing";
                            break;

                    }
                }
                #endregion "AAA Information Receiver Request Validation (NM1)"

                #region "AAA Subscriber Request Validation (NM1)"

                else if (LoopName == "Subscriber" && SegmentName == "NM1")
                {
                    switch (RejectionCode)
                    {
                        case "15":
                            //*At Surescripts — Not enough infomiation for Surescripts to identify patient.
                            //*At PBM — PBM wants more info than what was supplied.
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Required application data missing";
                            break;
                        case "35":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Out of Network";
                            break;
                        case "42":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Unable to Respond at Current Time";
                            break;
                        case "43":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider Identification";
                            break;
                        case "45":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider Specialty";
                            break;
                        case "47":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider State";
                            break;
                        case "48":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Referring Provider Identification Number";
                            break;
                        case "49":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Provider is Not Primary Care Physician";
                            break;
                        case "51":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Provider Not on File";
                            break;
                        case "52":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Service Dates Not Within Provider Plan Enrollment";
                            break;
                        case "56":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inappropriate Date";
                            break;
                        case "57":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Date(s) of Service";
                            break;
                        case "58":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Date-of-Birth";
                            break;
                        case "60":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Birth Follows Date(s) of Service";
                            break;
                        case "61":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Death Precedes Date(s) of Service";
                            break;
                        case "62":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Service Not Within Allowable Inquiry Period";
                            break;
                        case "63":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Service in Future";
                            break;
                        case "71":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Patient Birth Date Does Not Match That for the Patient on the Database";
                            break;
                        case "72":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Subscriber/Insured ID";
                            break;
                        case "73":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Subscriber/Insured Name";
                            break;
                        case "74":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Subscriber/Insured Gender Code";
                            break;
                        case "75":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Subscriber/Insured Not Found";
                            break;
                        case "76":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Duplicate Subscriber/Insured ID Number";
                            break;
                        case "78":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Subscriber/Insured Not in Group/Plan Identified";
                            break;

                    }
                }
                #endregion "AAA Subscriber Request Validation (NM1)"

                #region "AAA Subscriber Request Validation (EB)"
                else if (LoopName == "Subscriber" && SegmentName == "EB")
                {
                    switch (RejectionCode)
                    {
                        case "15":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Required application data missing";
                            break;
                        case "33":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Input Errors";
                            break;
                        case "52":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Service Dates Not Within Provider Plan Enrollment";
                            break;
                        case "54":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inappropriate Product/Service ID Qualifier";
                            break;
                        case "55":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inappropriate Product/Service ID";
                            break;
                        case "56":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inappropriate Date";
                            break;
                        case "57":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Date(s) of Service";
                            break;
                        case "60":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Birth Follows Date(s) of Service";
                            break;
                        case "61":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Death Precedes Date(s) of Service";
                            break;
                        case "62":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Service Not Within Allowable Inquiry Period";
                            break;
                        case "63":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Service in Future";
                            break;
                        case "69":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inconsistent with Patient’s Age";
                            break;
                        case "70":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inconsistent with Patient’s Gender";
                            break;
                    }
                }
                #endregion "AAA Subscriber Request Validation (EB)"

                #region "All combined"
                else if (LoopName == "" && SegmentName == "")
                {
                    switch (RejectionCode)
                    {
                        //"AAA Information Source level Request Validation (HL)"
                        case "04":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Authorized Quantity Exceeded";
                            break;
                        case "41":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Authorization/Access Restrictions";
                            break;
                        case "42":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Unable to Respond at Current Time";
                            break;
                        case "79":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid Participant Identification";
                            break;
                        case "80":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": No Response received — Transaction Terminated";
                            break;
                        case "T4":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Payer Name or Identifier Missing";
                            break;

                        //"AAA Information Receiver Request Validation (NM1)"
                        case "15":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Required application data missing";
                            break;
                        //case "41":
                        //    _sRejectionDescription = "Authorization/Access Restrictions";
                        //    break;
                        case "43":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider Identification (Surescripts recommends this for NPI error.)";
                            break;
                        case "44":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider Name";
                            break;
                        case "45":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider Specialty";
                            break;
                        case "46":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider Phone Number";
                            break;
                        case "47":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Provider State";
                            break;
                        case "48":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Referring Provider Identification Number";
                            break;
                        case "50":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Provider Ineligible for Inquiries";
                            break;
                        case "51":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Provider Not on File";
                            break;
                        //case "79":
                        //    _sRejectionDescription = "Invalid Participant Identification";
                        //    break;
                        case "97":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid or Missing Provider Address";
                            break;
                        //case "T4":
                        //    _sRejectionDescription = "Payer Name or Identifier Missing";
                        //    break;

                        // #endregion "AAA Subscriber Request Validation (NM1)"
                        //case "15":
                        //    //*At Surescripts — Not enough infomiation for Surescripts to identify patient.
                        //    //*At PBM — PBM wants more info than what was supplied.
                        //    _sRejectionDescription = "Required application data missing";
                        //    break;
                        case "35":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Out of Network";
                            break;
                        //case "42":
                        //    _sRejectionDescription = "Unable to Respond at Current Time";
                        //    break;
                        //case "43":
                        //    _sRejectionDescription = "Invalid/Missing Provider Identification";
                        //    break;
                        //case "45":
                        //    _sRejectionDescription = "Invalid/Missing Provider Specialty";
                        //    break;
                        //case "47":
                        //    _sRejectionDescription = "Invalid/Missing Provider State";
                        //    break;
                        //case "48":
                        //    _sRejectionDescription = "Invalid/Missing Referring Provider Identification Number";
                        //    break;
                        case "49":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Provider is Not Primary Care Physician";
                            break;
                        //case "51":
                        //    _sRejectionDescription = "Provider Not on File";
                        //    break;
                        case "52":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Service Dates Not Within Provider Plan Enrollment";
                            break;
                        case "56":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inappropriate Date";
                            break;
                        case "57":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Date(s) of Service";
                            break;
                        case "58":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Date-of-Birth";
                            break;
                        case "60":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Birth Follows Date(s) of Service";
                            break;
                        case "61":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Death Precedes Date(s) of Service";
                            break;
                        case "62":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Service Not Within Allowable Inquiry Period";
                            break;
                        case "63":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Date of Service in Future";
                            break;
                        case "71":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Patient Birth Date Does Not Match That for the Patient on the Database";
                            break;
                        case "72":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Subscriber/Insured ID";
                            break;
                        case "73":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Subscriber/Insured Name";
                            break;
                        case "74":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Invalid/Missing Subscriber/Insured Gender Code";
                            break;
                        case "75":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Subscriber/Insured Not Found";
                            break;
                        case "76":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Duplicate Subscriber/Insured ID Number";
                            break;
                        case "78":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Subscriber/Insured Not in Group/Plan Identified";
                            break;

                        //"AAA Subscriber Request Validation (EB)"
                        //case "15":
                        //    _sRejectionDescription = "Required application data missing";
                        //    break;
                        case "33":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Input Errors";
                            break;
                        //case "52":
                        //    _sRejectionDescription = "Service Dates Not Within Provider Plan Enrollment";
                        //    break;
                        case "54":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inappropriate Product/Service ID Qualifier";
                            break;
                        case "55":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inappropriate Product/Service ID";
                            break;
                        //case "56":
                        //    _sRejectionDescription = "Inappropriate Date";
                        //    break;
                        //case "57":
                        //    _sRejectionDescription = "Invalid/Missing Date(s) of Service";
                        //    break;
                        //case "60":
                        //    _sRejectionDescription = "Date of Birth Follows Date(s) of Service";
                        //    break;
                        //case "61":
                        //    _sRejectionDescription = "Date of Death Precedes Date(s) of Service";
                        //    break;
                        //case "62":
                        //    _sRejectionDescription = "Date of Service Not Within Allowable Inquiry Period";
                        //    break;
                        //case "63":
                        //    _sRejectionDescription = "Date of Service in Future";
                        //break;
                        case "69":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inconsistent with Patient’s Age";
                            break;
                        case "70":
                            _sRejectionDescription = "Error Code AAA" + RejectionCode + ": Inconsistent with Patient’s Gender";
                            break;
                    }
                }

                #endregion "All Combined"

                return _sRejectionDescription;

            }
            catch (Exception)
            {

                return "";
            }
            finally
            {

            }
        }
        private string GetPharmacyInfo(string QualifierInsuranceTypeCode)
        {
            switch (QualifierInsuranceTypeCode)
            {
                case "47":
                    return "Medicare Secondary, Other Liability Insurance is Primary";
                case "CP":
                    return "Medicare Conditionally Primary";
                case "MC":
                    return "Medicaid";
                case "MP":
                    return "Medicare Primary";
                case "OT":
                    return "Other (Used for Medicare Part D)";

            }
            return "";
        }

        private string GetEligibityInfo(string QualifierCode)
        {
            switch (QualifierCode)
            {
                case "1":
                    return "Yes";
                case "6":
                    return "No";
                case "G":
                    return "No";
                case "I":
                    return "No"; ;
                case "V":
                    return "No";

            }
            return "";
        }

        private string GetCoverageInfo(string QualifierCode)
        {
            switch (QualifierCode)
            {
                case "1":
                    return "Active Coverage";
                case "6":
                    return "Inactive";
                case "G":
                    return "Out of Pocket (Stop Loss)";
                case "I":
                    return "Cannot Process"; ;
                case "V":
                    return "Non-Covered";

            }
            return "";
        }
        public static string sampleEDIString270 = "ISA*00*          *01*FXTXGJVZ0W*ZZ*T00000000020315*ZZ*S00000000000001*191125*0000*^*00501*645191411*1*T*:~GS*HS*T00000000020315*S00000000000001*20191125*0000*1*X*005010X279A1~ST*270*000000001*005010X279A1~BHT*0022*13*11252019111420557*20191125*0000~HL*1**20*1~NM1*2B*2*SURESCRIPTS LLC*****PI*S00000000000001~HL*2*1*21*1~NM1*1P*1*Best*Wayne*w***XX*5627182012~REF*EO*T00000000020315~N3*204 1361 K ST SE APT 204~N4*Washington*DC*20030~HL*3*2*22*0~NM1*IL*1*SCHNUR*BERT*L~REF*EJ*111047851722752038~N3*312 HILL ROAD~N4*Hillsboro*MO*63050~DMG*D8*19450419*M~DTP*291*D8*20191125~EQ*30~SE*18*000000001~GE*1*1~IEA*1*645191411~";
        public string Write270(

             string SurescriptsPassword,
             string SurescriptsParticipantId,
             bool Staging,

             string PatientProviderLastName,
             string PatientProviderFirstName,
             string PatientProviderMiddleName,
             string PatientProviderSuffix,
             string PatientProviderNPI,
             string PatientProviderDEA,
             string PatientProviderAddressLine1,
             string PatientProviderAddressLine2,
             string PatientProviderAddressCity,
             string PatientProviderAddressState,
             string PatientProviderAddressZip,

             long PatientID,
             string PatientLastName,
             string PatientFirstName,
             string PatientMiddleName,
             string PatientAddressLine1,
             string PatientAddressLine2,
             string PatientAddressCity,
             string PatientAddressState,
             string PatientAddressZip,
             DateTime PatientDOB,
             string PatientGender,
             out string strControlNo
             )
        {
            string ediString;
            using (var edi270Stream = new MemoryStream(Encoding.ASCII.GetBytes(sampleEDIString270)))
            {


                List<IEdiItem> edi270Items;
                using (var edi270Reader = new X12Reader(edi270Stream, "EdiFabric.Templates.Hipaa"))
                {
                    edi270Items = edi270Reader.ReadToEnd().ToList();
                }



                #region "Interchange Control Header - ISA"
                ISA isa;
                try
                {
                    isa = (ISA)edi270Items[0];
                }
                catch
                {
                    isa = new ISA();
                }

                isa.AuthorizationInformationQualifier_1 = "00";
                isa.SecurityInformationQualifier_3 = "01";
                isa.SecurityInformation_4 = SurescriptsPassword;
                isa.SenderIDQualifier_5 = "ZZ";
                isa.InterchangeSenderID_6 = SurescriptsParticipantId;
                isa.ReceiverIDQualifier_7 = "ZZ";
                isa.InterchangeReceiverID_8 = "S00000000000001";
                isa.InterchangeDate_9 = gloDate.DateAsNumber(DateTime.Now.ToShortDateString()).ToString().Substring(2);
                isa.InterchangeTime_10 = FormattedTime(gloTime.TimeAsNumber(DateTime.Now.ToLocalTime().ToShortTimeString()).ToString()).Trim();
                isa.InterchangeControlStandardsIdentifier_11 = "^";
                isa.InterchangeControlVersionNumber_12 = "00501";
                strControlNo = DateTime.Now.Millisecond.ToString("#000") + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString();
                isa.InterchangeControlNumber_13 = strControlNo;
                isa.AcknowledgementRequested_14 = "1";
                isa.UsageIndicator_15 = Staging ? "T" : "P";
                isa.ComponentElementSeparator_16 = ":";
                #endregion "Interchange Control Header - ISA"

                #region "Functional Group Header - GS"
                GS gs;
                try
                {
                    gs = (GS)edi270Items[1];
                }
                catch
                {
                    gs = new GS();
                }
                gs.CodeIdentifyingInformationType_1 = "HS";
                gs.SenderIDCode_2 = SurescriptsParticipantId;
                gs.ReceiverIDCode_3 = "S00000000000001";
                gs.Date_4 = Convert.ToString(gloDate.DateAsNumber(DateTime.Now.ToShortDateString())).Trim();
                gs.Time_5 = FormattedTime(Convert.ToString(gloTime.TimeAsNumber(DateTime.Now.ToLocalTime().ToShortTimeString())).Trim());
                gs.GroupControlNumber_6 = "1";
                gs.TransactionTypeCode_7 = "X";
                gs.VersionAndRelease_8 = "005010X279A1";
                #endregion  "Functional Group Header - GS"

                #region "Transaction Set Header - ST"
                TS270 transaction = new TS270();
                transaction.ST = new ST();
                transaction.ST.TransactionSetControlNumber_02 = "000000001";
                transaction.ST.ImplementationConventionPreference_03 = "005010X279A1";
                #endregion "Transaction Set Header - ST"

                #region "Beginning of Hierarchical Transaction - BHT"
                transaction.BHT_BeginningofHierarchicalTransaction = new BHT_BeginningofHierarchicalTransaction();
                transaction.BHT_BeginningofHierarchicalTransaction.HierarchicalStructureCode_01 = "0022";
                transaction.BHT_BeginningofHierarchicalTransaction.TransactionSetPurposeCode_02 = "13";
                string BHT_TransactionRef = DateTime.Now.Date.ToString("MMddyyyy") + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
                transaction.BHT_BeginningofHierarchicalTransaction.SubmitterTransactionIdentifier_03 = BHT_TransactionRef;
                transaction.BHT_BeginningofHierarchicalTransaction.TransactionSetCreationDate_04 = Convert.ToString(gloDate.DateAsNumber(DateTime.Now.ToShortDateString()));
                transaction.BHT_BeginningofHierarchicalTransaction.TransactionSetCreationTime_05 = FormattedTime(Convert.ToString(gloTime.TimeAsNumber(DateTime.Now.ToLocalTime().ToShortTimeString())).Trim());
                #endregion "Beginning of Hierarchical Transaction - BHT"

                #region "Hierarchical Information Source Level - HL"
                transaction.Loop2000A = new List<Loop_2000A_270>();
                transaction.Loop2000A.Add(new Loop_2000A_270());
                transaction.Loop2000A[0].HL_InformationSourceLevel = new HL_BillingProviderHierarchicalLevel();
                transaction.Loop2000A[0].HL_InformationSourceLevel.HierarchicalIDNumber_01 = "1";
                transaction.Loop2000A[0].HL_InformationSourceLevel.HierarchicalLevelCode_03 = "20";
                transaction.Loop2000A[0].HL_InformationSourceLevel.HierarchicalChildCode_04 = "1";
                #endregion "Hierarchical Information Source Level - HL"

                #region "Information Source Name - NM1"
                transaction.Loop2000A[0].Loop2100A = new Loop_2100A_270();
                transaction.Loop2000A[0].Loop2100A.NM1_InformationSourceName = new NM1_InformationSourceName();
                transaction.Loop2000A[0].Loop2100A.NM1_InformationSourceName.EntityIdentifierCode_01 = "2B";
                transaction.Loop2000A[0].Loop2100A.NM1_InformationSourceName.EntityTypeQualifier_02 = "2";
                transaction.Loop2000A[0].Loop2100A.NM1_InformationSourceName.ResponseContactLastorOrganizationName_03 = "SURESCRIPTS LLC";
                transaction.Loop2000A[0].Loop2100A.NM1_InformationSourceName.IdentificationCodeQualifier_08 = "PI";
                transaction.Loop2000A[0].Loop2100A.NM1_InformationSourceName.ResponseContactIdentifier_09 = "S00000000000001";
                #endregion "Information Source Name - NM1"

                #region "Hierarchical Information Receiver Level - HL2"
                transaction.Loop2000A[0].Loop2000B = new List<Loop_2000B_270>();
                transaction.Loop2000A[0].Loop2000B.Add(new Loop_2000B_270());
                transaction.Loop2000A[0].Loop2000B[0].HL_InformationReceiverLevel = new HL_InformationReceiverLevel();
                transaction.Loop2000A[0].Loop2000B[0].HL_InformationReceiverLevel.HierarchicalIDNumber_01 = "2";
                transaction.Loop2000A[0].Loop2000B[0].HL_InformationReceiverLevel.HierarchicalParentIDNumber_02 = "1";
                transaction.Loop2000A[0].Loop2000B[0].HL_InformationReceiverLevel.HierarchicalLevelCode_03 = "21";
                transaction.Loop2000A[0].Loop2000B[0].HL_InformationReceiverLevel.HierarchicalChildCode_04 = "1";
                #endregion "Hierarchical Information Receiver Level - HL2"


                #region "Information Receiver Name - NM2"
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B = new Loop_2100B_270();
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.NM1_InformationReceiverName = new NM1_InformationReceiverName();
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.NM1_InformationReceiverName.EntityIdentifierCode_01 = "1P";
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.NM1_InformationReceiverName.EntityTypeQualifier_02 = "1";
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.NM1_InformationReceiverName.ResponseContactLastorOrganizationName_03 = PatientProviderLastName;
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.NM1_InformationReceiverName.ResponseContactFirstName_04 = PatientProviderFirstName;
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.NM1_InformationReceiverName.ResponseContactMiddleName_05 = PatientProviderMiddleName;
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.NM1_InformationReceiverName.NamePrefix_06 = "";
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.NM1_InformationReceiverName.ResponseContactNameSuffix_07 = PatientProviderSuffix;
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.NM1_InformationReceiverName.IdentificationCodeQualifier_08 = "XX";
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.NM1_InformationReceiverName.ResponseContactIdentifier_09 = PatientProviderNPI == "" ? PatientProviderDEA : PatientProviderNPI;
                #endregion "Information Receiver Name - NM2"

                #region "Information Receiver Additional Identification (POC Identification/Physician System Identification) - REF"
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.REF_InformationReceiverAdditionalIdentification = new List<REF_InformationReceiverAdditionalIdentification>();
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.REF_InformationReceiverAdditionalIdentification.Add(new REF_InformationReceiverAdditionalIdentification());
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.REF_InformationReceiverAdditionalIdentification[0].ReferenceIdentificationQualifier_01 = "EO";
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.REF_InformationReceiverAdditionalIdentification[0].MemberGrouporPolicyNumber_02 = SurescriptsParticipantId;
                #endregion "Information Receiver Additional Identification (POC Identification/Physician System Identification) - REF"

                #region "Information Receiver Address - N3"
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.N3_InformationReceiverAddress = new N3_AdditionalPatientInformationContactAddress();
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.N3_InformationReceiverAddress.ResponseContactAddressLine_01 = (PatientProviderAddressLine1 + " " + PatientProviderAddressLine2).Trim();
                #endregion "Information Receiver Address - N3"

                #region "Information Receiver Citi/State/ZIP Code - N4"
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.N4_InformationReceiverCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.N4_InformationReceiverCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = PatientProviderAddressCity;
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.N4_InformationReceiverCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = PatientProviderAddressState;
                transaction.Loop2000A[0].Loop2000B[0].Loop2100B.N4_InformationReceiverCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = (PatientProviderAddressZip + "     ").Substring(0, 5);
                #endregion "Information Receiver Citi/State/ZIP Code - N4"

                #region "Subscriber Level - HL"
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C = new List<Loop_2000C_270>();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C.Add(new Loop_2000C_270());
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].HL_SubscriberLevel = new HL_SubscriberHierarchicalLevel();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].HL_SubscriberLevel.HierarchicalIDNumber_01 = "3";
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].HL_SubscriberLevel.HierarchicalParentIDNumber_02 = "2";
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].HL_SubscriberLevel.HierarchicalLevelCode_03 = "22";
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].HL_SubscriberLevel.HierarchicalChildCode_04 = "0";
                #endregion "Subscriber Level - HL"

                #region "Subscriber Name - NM1"
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C = new Loop_2100C_270();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.NM1_SubscriberName = new NM1_InsuredName();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.NM1_SubscriberName.ResponseContactLastorOrganizationName_03 = ReplaceSpecialChar(PatientLastName);
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.NM1_SubscriberName.ResponseContactFirstName_04 = ReplaceSpecialChar(PatientFirstName);
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.NM1_SubscriberName.ResponseContactMiddleName_05 = ReplaceSpecialChar(PatientMiddleName);
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.NM1_SubscriberName.IdentificationCodeQualifier_08 = "";
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.NM1_SubscriberName.ResponseContactIdentifier_09 = "";
                #endregion "Subscriber Name - NM1"

                #region "Subscriber Additional Identification - REF"
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.REF_SubscriberAdditionalIdentification = new List<REF_SubscriberAdditionalIdentification_2>();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.REF_SubscriberAdditionalIdentification.Add(new REF_SubscriberAdditionalIdentification_2());
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.REF_SubscriberAdditionalIdentification[0].ReferenceIdentificationQualifier_01 = "EJ";
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.REF_SubscriberAdditionalIdentification[0].MemberGrouporPolicyNumber_02 = PatientID.ToString();
                #endregion "Subscriber Additional Identification - REF"

                #region "Subscriber Address - N3"
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.N3_SubscriberAddress = new N3_AdditionalPatientInformationContactAddress();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.N3_SubscriberAddress.ResponseContactAddressLine_01 = ReplaceSpecialChar(PatientAddressLine1);
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.N3_SubscriberAddress.ResponseContactAddressLine_02 = ReplaceSpecialChar(PatientAddressLine2);
                #endregion "Subscriber Address - N3"

                #region "Subscriber City/State/ZIP Code - N4"
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.N4_SubscriberCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = ReplaceSpecialChar(PatientAddressCity);
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = PatientAddressState;
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = (PatientAddressZip + "     ").Substring(0, 5);
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.N4_SubscriberCity_State_ZIPCode.CountryCode_04 = "";
                #endregion "Subscriber City/State/ZIP Code - N4"

                #region "Subscriber Demographic Information - DMG"
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DMG_SubscriberDemographicInformation = new DMG_DependentDemographicInformation();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DMG_SubscriberDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DMG_SubscriberDemographicInformation.DependentBirthDate_02 = gloDate.DateAsNumber(PatientDOB.ToShortDateString()).ToString();
                if (PatientGender == "Female")
                {
                    transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DMG_SubscriberDemographicInformation.DependentGenderCode_03 = "F";
                }
                else
                {
                    if (PatientGender == "Male")
                    {
                        transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DMG_SubscriberDemographicInformation.DependentGenderCode_03 = "M";
                    }
                    else
                    {
                        transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DMG_SubscriberDemographicInformation.DependentGenderCode_03 = "";
                    }
                }
                #endregion "Subscriber Demographic Information - DMG"

                #region "Subscriber Date - DTP"
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DTP_SubscriberDate = new List<DTP_DependentDate>();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DTP_SubscriberDate.Add(new DTP_DependentDate());
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DTP_SubscriberDate[0].DateTimeQualifier_01 = "291";
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DTP_SubscriberDate[0].DateTimePeriodFormatQualifier_02 = "D8";
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.DTP_SubscriberDate[0].AccidentDate_03 = Convert.ToString(gloDate.DateAsNumber(DateTime.Now.ToShortDateString()));
                #endregion "Subscriber Date - DTP"

                #region "Subscriber Eligibility or Benefit Inquiry Information (Pharmacy) - EQ"
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.Loop2110C = new List<Loop_2110C_270>();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.Loop2110C.Add(new Loop_2110C_270());
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.Loop2110C[0].EQ_SubscriberEligibilityorBenefitInquiry = new EQ_DependentEligibilityorBenefitInquiry();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.Loop2110C[0].EQ_SubscriberEligibilityorBenefitInquiry.ServiceTypeCode_01 = new List<string>();
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.Loop2110C[0].EQ_SubscriberEligibilityorBenefitInquiry.ServiceTypeCode_01.Add("");
                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2100C.Loop2110C[0].EQ_SubscriberEligibilityorBenefitInquiry.ServiceTypeCode_01[0] = "30";
                #endregion "Subscriber Eligibility or Benefit Inquiry Information (Pharmacy) - EQ"

                transaction.Loop2000A[0].Loop2000B[0].Loop2000C[0].Loop2000D = null;
                //IEA ieaTrailor = new IEA();

                //ieaTrailor.InterchangeControlNumber_2 = strControlNo;

                EdiFabric.Framework.Separators seperators = new EdiFabric.Framework.Separators('~', ':', '*', EdiFabric.Framework.Separators.X12.RepetitionDataElement, EdiFabric.Framework.Separators.X12.Escape, EdiFabric.Framework.Separators.X12.DecimalPoint, EdiFabric.Framework.Separators.X12.SyntaxId);
                //seperators.Segment = '~';
                //seperators.DataElement = '*';
                //seperators.ComponentDataElement = ':';
                X12WriterSettings xwSettings = new X12WriterSettings(seperators);
                using (var stream = new MemoryStream())
                {
                    using (var writer = new X12Writer(stream, xwSettings))
                    {
                        writer.Write(isa);
                        writer.Write(gs);
                        writer.Write(transaction);
                        //writer.Write(ieaTrailor);
                    }

                    ediString = Encoding.ASCII.GetString(stream.ToArray());
                }
                edi270Items.Clear();
            }

            return ediString.Replace("?", "");

        }
        public EDIOutput271 Read271(string edi271, ref bool Send270UsingDEA)
        {
            EDIOutput271 ediOutput271 = new EDIOutput271();

            using (var edi271Stream = new MemoryStream(Encoding.ASCII.GetBytes(edi271)))
            {
                List<IEdiItem> edi271Items;
                using (var edi271Reader = new X12Reader(edi271Stream, "EdiFabric.Templates.Hipaa"))//, "EdiFabric.Examples.X12.Templates.V5010.NoValidation"))
                    edi271Items = edi271Reader.ReadToEnd().ToList();

                // var transactions271 = edi271Items.OfType<TS271>();

                foreach (var edi271Item in edi271Items)
                {
                    var mytype = edi271Item.GetType();

                    #region "Interchange Control Header - ISA"
                    if (mytype.FullName == "EdiFabric.Core.Model.Edi.X12.ISA")
                    {
                        ISA isa = (ISA)edi271Item;
                        ediOutput271.SenderID = isa.InterchangeSenderID_6;
                        ediOutput271.RecieverID = isa.InterchangeReceiverID_8;
                        ediOutput271.ControlNumber = isa.InterchangeControlNumber_13;
                    }
                    #endregion "Interchange Control Header - ISA"

                    #region "Interchange Control Structure Header and Trailer - TA1"
                    if (mytype.FullName == "EdiFabric.Core.Model.Edi.X12.TA1")
                    {
                        TA1 ta1 = (TA1)edi271Item;
                        ediOutput271.MessageType = "TA1" + "-" + ta1.InterchangeAcknowledgmentCode_4;
                        if (ta1.InterchangeAcknowledgmentCode_4 == "A")
                        {
                            ediOutput271.ShowMessage = ediOutput271.ShowMessage + "\r\n" + "The Transmitted Interchange Control Structure Header and Trailer Have Been Received and Have No Errors.";
                        }
                        if (ta1.InterchangeAcknowledgmentCode_4 == "R")
                        {
                            StringBuilder strTA1Msg = new StringBuilder();
                            strTA1Msg.Append("The Transmitted Interchange Control Structure Header");
                            strTA1Msg.Append(Environment.NewLine);
                            strTA1Msg.Append("and Trailer Have Been Received and Are Accepted But");
                            strTA1Msg.Append(Environment.NewLine);
                            strTA1Msg.Append("Errors Are Noted. This Means the Sender Must Not Resend This Data.");
                            ediOutput271.ShowMessage = ediOutput271.ShowMessage + "\r\n" + strTA1Msg.ToString();
                        }
                        if (ta1.InterchangeAcknowledgmentCode_4 == "E")
                        {
                            ediOutput271.ShowMessage = ediOutput271.ShowMessage + "\r\n" + "The Transmitted Interchange Control Structure Header and Trailer are Rejected Because of Errors.";
                        }
                        break;
                    }
                    #endregion "Interchange Control Structure Header and Trailer - TA1"

                    #region "Functional Group Header - GS"
                    if (mytype.FullName == "EdiFabric.Core.Model.Edi.X12.GS")
                    {
                        GS gs = (GS)edi271Item;
                        ediOutput271.EligibilityDate = gs.Date_4.Trim() + " " + gs.Time_5.Trim();
                    }
                    #endregion "Functional Group Header - GS"

                    #region "Transaction Set Header - ST"
                    if (mytype.FullName == "EdiFabric.Core.Model.Edi.X12.ST")
                    {
                        ST st = (ST)edi271Item;
                        if (st.TransactionSetIdentifierCode_01 == "997")
                        {
                            ediOutput271.MessageType = st.TransactionSetIdentifierCode_01;
                            if (Send270UsingDEA == false)
                            {
                                Send270UsingDEA = true;
                            }
                            else
                            {
                                ediOutput271.ShowMessage = ediOutput271.ShowMessage + "\r\n" + "The 270 eligibility request file contains invalid patient information. 997 error code responded in 271 response file";
                            }
                            break;
                        }
                        else
                        {
                            if (st.TransactionSetIdentifierCode_01 == null || st.TransactionSetIdentifierCode_01 == "")
                            {
                                ediOutput271.MessageType = "TA1";
                            }
                            else
                            {

                                Send270UsingDEA = false;
                                ediOutput271.MessageType = st.TransactionSetIdentifierCode_01;
                                ediOutput271.STLoopCount = st.TransactionSetControlNumber_02;
                            }
                        }
                    }
                    #endregion "Transaction Set Header - ST"

                    if (mytype.FullName == "EdiFabric.Templates.Hipaa5010.TS271")
                    {
                        TS271 transaction = (TS271)edi271Item;
                        #region "ST Segment in Transaction"
                        ST st = (ST)transaction.ST;
                        if (st != null)
                        {
                            if (st.TransactionSetIdentifierCode_01 == "997")
                            {
                                ediOutput271.MessageType = st.TransactionSetIdentifierCode_01;
                                if (Send270UsingDEA == false)
                                {
                                    Send270UsingDEA = true;
                                }
                                else
                                {
                                    ediOutput271.ShowMessage = ediOutput271.ShowMessage + "\r\n" + "The 270 eligibility request file contains invalid patient information. 997 error code responded in 271 response file";
                                }
                                break;
                            }
                            else
                            {
                                if (st.TransactionSetIdentifierCode_01 == null || st.TransactionSetIdentifierCode_01 == "")
                                {
                                    ediOutput271.MessageType = "TA1";
                                }
                                else
                                {
                                    ediOutput271.Send270UsingDEA = false;
                                    ediOutput271.MessageType = st.TransactionSetIdentifierCode_01;
                                    ediOutput271.STLoopCount = st.TransactionSetControlNumber_02;
                                }
                            }
                        }
                        #endregion "ST Segment in Transaction"

                        #region "BHT Segment in Transaction"
                        BHT_BeginningofHierarchicalTransaction_2 bht = transaction.BHT_BeginningofHierarchicalTransaction;
                        if (bht != null)
                        {
                            ediOutput271.MessageID = bht.SubmitterTransactionIdentifier_03;
                        }
                        #endregion "BHT Segment in Transaction"

                        if (transaction.Loop2000A != null)
                        {
                            foreach (var loop2000A in transaction.Loop2000A)
                            {
                                #region "HL Segment"
                                if (loop2000A.HL_InformationSourceLevel != null)
                                {
                                    ediOutput271.Entity = loop2000A.HL_InformationSourceLevel.HierarchicalLevelCode_03;
                                }
                                #endregion "HL Segment"

                                #region "NM1 Segment"
                                if (loop2000A.Loop2100A != null && loop2000A.Loop2100A.NM1_InformationSourceName != null)
                                {

                                    ediOutput271.InformationSourceName = loop2000A.Loop2100A.NM1_InformationSourceName.ResponseContactLastorOrganizationName_03 + " " + loop2000A.Loop2100A.NM1_InformationSourceName.ResponseContactFirstName_04 + " " + loop2000A.Loop2100A.NM1_InformationSourceName.ResponseContactMiddleName_05;
                                    ediOutput271.PayerName = loop2000A.Loop2100A.NM1_InformationSourceName.ResponseContactLastorOrganizationName_03;
                                    ediOutput271.PayerParticipantId = loop2000A.Loop2100A.NM1_InformationSourceName.ResponseContactIdentifier_09;

                                }
                                #endregion "NM1 Segment"

                                if (loop2000A.Loop2000B != null)
                                {
                                    foreach (var loop2000B in loop2000A.Loop2000B)
                                    {
                                        #region "NM1 Reciever Segment"
                                        if (loop2000B.Loop2100B != null && loop2000B.Loop2100B.NM1_InformationReceiverName != null)
                                        {
                                            ediOutput271.RecieverLastName = loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactLastorOrganizationName_03;
                                            ediOutput271.RecieverFirstName = loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactFirstName_04;
                                            ediOutput271.RecieverMiddleName = loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactMiddleName_05;
                                            ediOutput271.InformationRecieverName = ediOutput271.RecieverLastName + " " + ediOutput271.RecieverFirstName + " " + ediOutput271.RecieverMiddleName;
                                            ediOutput271.InformationRecieverSuffix = loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactNameSuffix_07;
                                            ediOutput271.CodeQualifier = loop2000B.Loop2100B.NM1_InformationReceiverName.IdentificationCodeQualifier_08;
                                            if (ediOutput271.CodeQualifier == "XX")
                                            {
                                                ediOutput271.NPINumber = loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactIdentifier_09;
                                            }
                                            if (loop2000B.Loop2100B.AAA_InformationReceiverRequestValidation != null)
                                            {
                                                foreach (var aaa in loop2000B.Loop2100B.AAA_InformationReceiverRequestValidation)
                                                {
                                                    if (aaa.ValidRequestIndicator_01 == "Y")
                                                    {
                                                        ediOutput271.InformationReceiverAAAQualifier = aaa.RejectReasonCode_03 + "|" + ediOutput271.InformationReceiverAAAQualifier;
                                                        ediOutput271.InformationReceiverRejectionDescription = getRejectionDescription(aaa.RejectReasonCode_03, "Reciever", "NM1") + "|" + ediOutput271.InformationReceiverRejectionDescription;

                                                        if (ediOutput271.MessageType != "")
                                                        {
                                                            ediOutput271.MessageType = ediOutput271.MessageType + "|" + aaa.RejectReasonCode_03;
                                                        }
                                                        ediOutput271.ShowMessage = ediOutput271.ShowMessage + "\r\n" + "Transaction was unable to be processed successfully because " + ediOutput271.InformationReceiverRejectionDescription;
                                                    }
                                                }
                                            }


                                        }
                                        #endregion "NM1 Reciever Segment"
                                        if (loop2000B.Loop2000C != null)
                                        {
                                            foreach (var loop2000C in loop2000B.Loop2000C)
                                            {
                                                #region "TRN Segment"
                                                if (loop2000C.TRN_SubscriberTraceNumber != null)
                                                {
                                                    foreach (var trn in loop2000C.TRN_SubscriberTraceNumber)
                                                    {
                                                        ediOutput271.TRNQualifier = trn.TraceTypeCode_01;
                                                        if (ediOutput271.TRNQualifier == "1")
                                                        {
                                                            ediOutput271.TRNReferenceIdentification = trn.CurrentTransactionTraceNumber_02;
                                                            ediOutput271.TRNOrignationCompanyIdentifier = trn.OriginatingCompanyIdentifier_03;
                                                            ediOutput271.TRNDivisionorGroup = trn.ReferenceIdentification_04;
                                                        }
                                                    }


                                                }
                                                #endregion "TRN Segment"
                                                if (loop2000C.Loop2100C != null)
                                                {
                                                    #region "NM1 Subscriber Segment"
                                                    if (loop2000C.Loop2100C.NM1_SubscriberName != null)
                                                    {
                                                        ediOutput271.SubscriberLastName = loop2000C.Loop2100C.NM1_SubscriberName.ResponseContactLastorOrganizationName_03;
                                                        ediOutput271.SubscriberFirstName = loop2000C.Loop2100C.NM1_SubscriberName.ResponseContactFirstName_04;
                                                        ediOutput271.SubscriberMiddleName = loop2000C.Loop2100C.NM1_SubscriberName.ResponseContactMiddleName_05;
                                                        ediOutput271.SubscriberSuffix = loop2000C.Loop2100C.NM1_SubscriberName.ResponseContactNameSuffix_07;
                                                        ediOutput271.MemberID = loop2000C.Loop2100C.NM1_SubscriberName.ResponseContactIdentifier_09;
                                                    }
                                                    if (loop2000C.Loop2100C.N3_SubscriberAddress != null)
                                                    {
                                                        ediOutput271.SubscriberAddress1 = loop2000C.Loop2100C.N3_SubscriberAddress.ResponseContactAddressLine_01;
                                                        ediOutput271.SubscriberAddress2 = loop2000C.Loop2100C.N3_SubscriberAddress.ResponseContactAddressLine_02;
                                                    }
                                                    if (loop2000C.Loop2100C.N4_SubscriberCity_State_ZIPCode != null)
                                                    {
                                                        ediOutput271.SubscriberCity = loop2000C.Loop2100C.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01;
                                                        ediOutput271.SubscriberState = loop2000C.Loop2100C.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02;
                                                        ediOutput271.SubscriberZip = loop2000C.Loop2100C.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03;
                                                    }
                                                    #endregion "NM1 Subscriber Segment"

                                                    #region "Subscriber additonal segment"
                                                    if (loop2000C.Loop2100C.REF_SubscriberAdditionalIdentification != null)
                                                    {
                                                        foreach (var refsub in loop2000C.Loop2100C.REF_SubscriberAdditionalIdentification)
                                                        {
                                                            switch (refsub.ReferenceIdentificationQualifier_01)
                                                            {
                                                                case "A6":
                                                                    ediOutput271.EmployeeId = refsub.MemberGrouporPolicyNumber_02;
                                                                    break;
                                                                case "18":
                                                                    ediOutput271.HealthPlanNumber = refsub.MemberGrouporPolicyNumber_02;
                                                                    ediOutput271.HealthPlanName = refsub.Description_03;
                                                                    break;
                                                                case "1W":
                                                                    ediOutput271.CardHolderId = refsub.MemberGrouporPolicyNumber_02;
                                                                    ediOutput271.CardHolderName = refsub.Description_03;
                                                                    break;
                                                                case "6P":
                                                                    ediOutput271.GroupId = refsub.MemberGrouporPolicyNumber_02;
                                                                    ediOutput271.GroupName = refsub.Description_03;
                                                                    break;
                                                                case "IF":
                                                                    ediOutput271.FormularyListId = refsub.MemberGrouporPolicyNumber_02;
                                                                    ediOutput271.AlternativeListId = refsub.Description_03;
                                                                    break;
                                                                case "1L":
                                                                    ediOutput271.CoverageId = refsub.Description_03;
                                                                    break;
                                                                case "N6":
                                                                    ediOutput271.BINNumber = refsub.MemberGrouporPolicyNumber_02;
                                                                    break;
                                                                case "IG":
                                                                    ediOutput271.CopayId = refsub.Description_03;
                                                                    break;
                                                                case "HJ":
                                                                    ediOutput271.CardHolderId = refsub.MemberGrouporPolicyNumber_02;
                                                                    ediOutput271.CardHolderName = refsub.Description_03;
                                                                    break;
                                                                case "49":
                                                                    ediOutput271.PersonCode = refsub.MemberGrouporPolicyNumber_02;
                                                                    break;
                                                                case "SY":
                                                                    ediOutput271.SocialSecurityNumber = refsub.MemberGrouporPolicyNumber_02;
                                                                    break;
                                                                case "EJ":
                                                                    ediOutput271.PatientAccountNumber = refsub.MemberGrouporPolicyNumber_02;
                                                                    break;
                                                            }

                                                        }

                                                    }
                                                    #endregion "Subscriber additonal segment"

                                                    #region "AAA Segment"
                                                    if (loop2000C.Loop2100C.AAA_SubscriberRequestValidation != null)
                                                    {

                                                        foreach (var aaa in loop2000C.Loop2100C.AAA_SubscriberRequestValidation)
                                                        {
                                                            if (aaa.ValidRequestIndicator_01 == "Y")
                                                            {
                                                                ediOutput271.SubscriberAAAQualifier = aaa.RejectReasonCode_03 + "|" + ediOutput271.SubscriberAAAQualifier;
                                                                ediOutput271.SubscriberRejectionDescription = getRejectionDescription(aaa.RejectReasonCode_03, "Subscriber", "NM1") + "|" + ediOutput271.SubscriberRejectionDescription;

                                                                if (ediOutput271.MessageType != "")
                                                                {
                                                                    ediOutput271.MessageType = ediOutput271.MessageType + "|" + aaa.RejectReasonCode_03;
                                                                }
                                                                ediOutput271.ShowMessage = ediOutput271.ShowMessage + "\r\n" + "Transaction was unable to be processed successfully for PBM: " + ediOutput271.PayerName + " because " + ediOutput271.SubscriberRejectionDescription;
                                                            }
                                                            else
                                                            {
                                                                ediOutput271.ShowMessage = ediOutput271.ShowMessage + "\r\n" + "The request or an element in the request is not valid. The transaction has been rejected";
                                                                break;
                                                            }
                                                        }


                                                    }
                                                    #endregion "AAA Segment"

                                                    #region "DMG Segment"
                                                    if (loop2000C.Loop2100C.DMG_SubscriberDemographicInformation != null)
                                                    {
                                                        ediOutput271.SubscriberDOB = loop2000C.Loop2100C.DMG_SubscriberDemographicInformation.DependentBirthDate_02;
                                                        ediOutput271.SubscriberGender = loop2000C.Loop2100C.DMG_SubscriberDemographicInformation.DependentGenderCode_03;
                                                    }
                                                    #endregion "DMG Segment"

                                                    #region "Insurance Relationship Segment"
                                                    if (loop2000C.Loop2100C.INS_SubscriberRelationship != null)
                                                    {
                                                        if (loop2000C.Loop2100C.INS_SubscriberRelationship.MaintenanceTypeCode_03 == "001" && loop2000C.Loop2100C.INS_SubscriberRelationship.MaintenanceReasonCode_04 == "25")
                                                        {

                                                            ediOutput271.IsSubscriberdemoChange = "True";
                                                            ediOutput271.SubscriberDemoChgLastName = ediOutput271.SubscriberLastName;
                                                            ediOutput271.SubscriberDemochgFirstName = ediOutput271.SubscriberFirstName;
                                                            ediOutput271.SubscriberDemoChgMiddleName = ediOutput271.SubscriberMiddleName;
                                                            ediOutput271.SubscriberDemoChgZip = ediOutput271.SubscriberZip;
                                                            ediOutput271.SubscriberDemoChgDOB = ediOutput271.SubscriberDOB;
                                                            ediOutput271.SubscriberDemoChgGender = ediOutput271.SubscriberGender;
                                                            ediOutput271.SubscriberDemoChgState = ediOutput271.SubscriberState;
                                                            ediOutput271.SubscriberDemoChgCity = ediOutput271.SubscriberCity;
                                                            ediOutput271.SubscriberDemoChgAddress1 = ediOutput271.SubscriberAddress1;
                                                            ediOutput271.SubscriberDemoChgAddress2 = ediOutput271.SubscriberAddress2;

                                                        }
                                                        else
                                                        {
                                                            ediOutput271.IsSubscriberdemoChange = "False";
                                                        }

                                                        if (loop2000C.Loop2100C.INS_SubscriberRelationship.InsuredIndicator_01 == "Y")
                                                        {
                                                            if (loop2000C.Loop2100C.INS_SubscriberRelationship.IndividualRelationshipCode_02 == "18")
                                                            {
                                                                ediOutput271.RelationshipCode = loop2000C.Loop2100C.INS_SubscriberRelationship.IndividualRelationshipCode_02;
                                                                ediOutput271.RelationshipDescription = "Self";
                                                            }

                                                        }
                                                        else
                                                        {
                                                            ediOutput271.RelationshipCode = loop2000C.Loop2100C.INS_SubscriberRelationship.IndividualRelationshipCode_02;
                                                            ediOutput271.RelationshipDescription = "Dependent";
                                                        }
                                                    }
                                                    #endregion "Insurance Relationship Segment"

                                                    #region "Subscriber dependent Segment"
                                                    if (loop2000C.Loop2100C.DTP_SubscriberDate != null)
                                                    {
                                                        foreach (var dtp in loop2000C.Loop2100C.DTP_SubscriberDate)
                                                        {
                                                            string Qlfr = dtp.DateTimePeriodFormatQualifier_02;
                                                            switch (dtp.DateTimeQualifier_01)
                                                            {
                                                                case "307":
                                                                    ediOutput271.EligiblityDate = dtp.AccidentDate_03;
                                                                    break;
                                                                case "472":

                                                                    if (Qlfr == "D8")
                                                                    {
                                                                        ediOutput271.EligiblityDate = dtp.AccidentDate_03;
                                                                    }
                                                                    else if (Qlfr == "RD8")
                                                                    {
                                                                        ediOutput271.ServiceDate = dtp.AccidentDate_03;
                                                                    }

                                                                    break;
                                                                case "291":

                                                                    if (Qlfr == "D8")
                                                                    {
                                                                        ediOutput271.EligiblityDate = dtp.AccidentDate_03;
                                                                    }
                                                                    else if (Qlfr == "RD8")
                                                                    {
                                                                        ediOutput271.ServiceDate = dtp.AccidentDate_03;
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                    }
                                                    #endregion "Subscriber dependent Segment"
                                                }
                                                #region "Subscriber other information"
                                                if (loop2000C.Loop2000D != null)
                                                {

                                                    foreach (var loop2000D in loop2000C.Loop2000D)
                                                    {
                                                        if (loop2000D.Loop2100D != null)
                                                        {
                                                            ediOutput271.NM1InformationFound = false;
                                                            if (loop2000D.Loop2100D.NM1_DependentName != null)
                                                            {
                                                                ediOutput271.NM1InformationFound = true;
                                                                ediOutput271.DependentProvider = loop2000D.Loop2100D.NM1_DependentName.EntityIdentifierCode_01;
                                                                if (ediOutput271.DependentProvider == "13")
                                                                {
                                                                    ediOutput271.IsContractedProvider = "Yes";
                                                                    ediOutput271.ContractedProviderName = loop2000D.Loop2100D.NM1_DependentName.ResponseContactLastorOrganizationName_03;
                                                                    ediOutput271.ContractedProviderNumber = loop2000D.Loop2100D.NM1_DependentName.ResponseContactIdentifier_09;
                                                                }
                                                                else if (ediOutput271.DependentProvider == "PRP")
                                                                {
                                                                    ediOutput271.IsPrimaryProvider = "Yes";
                                                                    ediOutput271.PrimaryProviderName = loop2000D.Loop2100D.NM1_DependentName.ResponseContactLastorOrganizationName_03;
                                                                    ediOutput271.PrimaryProviderNumber = loop2000D.Loop2100D.NM1_DependentName.ResponseContactIdentifier_09;

                                                                }

                                                            }
                                                            if (loop2000D.Loop2100D.Loop2110D != null)
                                                            {
                                                                foreach (var loop2100D in loop2000D.Loop2100D.Loop2110D)
                                                                {

                                                                    if (loop2100D.EB_DependentEligibilityorBenefitInformation != null)
                                                                    {
                                                                        string Qlfr = loop2100D.EB_DependentEligibilityorBenefitInformation.EligibilityorBenefitInformation_01;
                                                                        if (loop2100D.EB_DependentEligibilityorBenefitInformation.ServiceTypeCode_03 != null && loop2100D.EB_DependentEligibilityorBenefitInformation.ServiceTypeCode_03.Count > 0)
                                                                        {
                                                                            ediOutput271.QualifierPharmacyCode = loop2100D.EB_DependentEligibilityorBenefitInformation.ServiceTypeCode_03[0];
                                                                        }

                                                                        ediOutput271.QualifierInsuranceTypeCode = loop2100D.EB_DependentEligibilityorBenefitInformation.InsuranceTypeCode_04;

                                                                        string buffer = loop2100D.EB_DependentEligibilityorBenefitInformation.ToString();
                                                                        if (ediOutput271.NM1InformationFound == false)
                                                                        {
                                                                            if (ediOutput271.QualifierPharmacyCode == "88")
                                                                            {
                                                                                if (buffer.Contains("18890"))
                                                                                {
                                                                                    ediOutput271.IsMailOrdRxDrugEligible = GetEligibityInfo(Qlfr);
                                                                                    ediOutput271.MailOrdRxDrugEligiblityorBenefitInfo = GetCoverageInfo(Qlfr);
                                                                                }
                                                                                ediOutput271.IsRetailPharmacyEligible = GetEligibityInfo(Qlfr);

                                                                                if (ediOutput271.QualifierInsuranceTypeCode != "")
                                                                                {
                                                                                    ediOutput271.RetailInsTypeCode = GetPharmacyInfo(ediOutput271.QualifierInsuranceTypeCode);
                                                                                }
                                                                                ediOutput271.RetailPharmacyCoveragePlanName = loop2100D.EB_DependentEligibilityorBenefitInformation.PlanCoverageDescription_05;
                                                                                ediOutput271.RetailMonetaryAmount = loop2100D.EB_DependentEligibilityorBenefitInformation.BenefitAmount_07;
                                                                                ediOutput271.RetailPharmacyEligiblityorBenefitInfo = GetCoverageInfo(Qlfr);
                                                                            }

                                                                            if (ediOutput271.QualifierPharmacyCode == "90")
                                                                            {
                                                                                ediOutput271.IsMailOrdRxDrugEligible = GetEligibityInfo(Qlfr);

                                                                                if (ediOutput271.QualifierInsuranceTypeCode != "")
                                                                                {
                                                                                    ediOutput271.RetailInsTypeCode = GetPharmacyInfo(ediOutput271.QualifierInsuranceTypeCode);
                                                                                }
                                                                                ediOutput271.MailOrdRxDrugCoveragePlanName = loop2100D.EB_DependentEligibilityorBenefitInformation.PlanCoverageDescription_05;
                                                                                ediOutput271.MailOrderMonetaryAmount = loop2100D.EB_DependentEligibilityorBenefitInformation.BenefitAmount_07;
                                                                                ediOutput271.MailOrdRxDrugEligiblityorBenefitInfo = GetCoverageInfo(Qlfr);

                                                                            }

                                                                            if (ediOutput271.QualifierPharmacyCode == "30")
                                                                            {
                                                                                if (ediOutput271.QualifierInsuranceTypeCode != "")
                                                                                {
                                                                                    ediOutput271.HlthPlnCovInsTypeCode = GetPharmacyInfo(ediOutput271.QualifierInsuranceTypeCode);
                                                                                }

                                                                                ediOutput271.HealthPlanBenefitEligibilityInfo = GetCoverageInfo(Qlfr);
                                                                                ediOutput271.HealthPlanBenefitCoverageName = loop2100D.EB_DependentEligibilityorBenefitInformation.PlanCoverageDescription_05;
                                                                            }
                                                                            if (ediOutput271.QualifierPharmacyCode == "")
                                                                            {
                                                                                ediOutput271.SpecialtyorLTCPhrmCovName = loop2100D.EB_DependentEligibilityorBenefitInformation.PlanCoverageDescription_05;
                                                                                ediOutput271.SpecialtyorLTCCoverageStatus = GetCoverageInfo(Qlfr);
                                                                            }

                                                                        }
                                                                        else if (ediOutput271.DependentProvider == "13")
                                                                        {
                                                                            if (ediOutput271.QualifierPharmacyCode == "88")
                                                                            {

                                                                                ediOutput271.ContProvRetailsEligible = GetEligibityInfo(Qlfr);

                                                                                if (ediOutput271.QualifierInsuranceTypeCode != "")
                                                                                {
                                                                                    ediOutput271.ContProvRetailInsTypeCode = GetPharmacyInfo(ediOutput271.QualifierInsuranceTypeCode);
                                                                                }
                                                                                ediOutput271.ContProvRetailCoveragePlanName = loop2100D.EB_DependentEligibilityorBenefitInformation.PlanCoverageDescription_05;
                                                                                ediOutput271.ContProvRetailMonetaryAmt = loop2100D.EB_DependentEligibilityorBenefitInformation.BenefitAmount_07;
                                                                                ediOutput271.ContProvRetailCoverageInfo = GetCoverageInfo(Qlfr);
                                                                            }

                                                                            if (ediOutput271.QualifierPharmacyCode == "90")
                                                                            {
                                                                                ediOutput271.ContProvMailOrderEligible = GetEligibityInfo(Qlfr);

                                                                                if (ediOutput271.QualifierInsuranceTypeCode != "")
                                                                                {
                                                                                    ediOutput271.ContProvMailOrderTypeCode = GetPharmacyInfo(ediOutput271.QualifierInsuranceTypeCode);
                                                                                }
                                                                                ediOutput271.ContProvMailOrderCoveragePlanName = loop2100D.EB_DependentEligibilityorBenefitInformation.PlanCoverageDescription_05;
                                                                                ediOutput271.ContProvMailOrderMonetaryAmt = loop2100D.EB_DependentEligibilityorBenefitInformation.BenefitAmount_07;
                                                                                ediOutput271.ContProvMailOrderCoverageInfo = GetCoverageInfo(Qlfr);

                                                                            }

                                                                        }
                                                                        else if (ediOutput271.DependentProvider == "PRP")
                                                                        {

                                                                            if (ediOutput271.QualifierPharmacyCode == "88")
                                                                            {

                                                                                ediOutput271.PrimaryPayerRetailsEligible = GetEligibityInfo(Qlfr);

                                                                                if (ediOutput271.QualifierInsuranceTypeCode != "")
                                                                                {
                                                                                    ediOutput271.PrimaryPayerRetailInsTypeCode = GetPharmacyInfo(ediOutput271.QualifierInsuranceTypeCode);
                                                                                }
                                                                                ediOutput271.PrimaryPayerRetailCoveragePlanName = loop2100D.EB_DependentEligibilityorBenefitInformation.PlanCoverageDescription_05;
                                                                                ediOutput271.PrimaryPayerRetailMonetaryAmt = loop2100D.EB_DependentEligibilityorBenefitInformation.BenefitAmount_07;
                                                                                ediOutput271.PrimaryPayerRetailCoverageInfo = GetCoverageInfo(Qlfr);
                                                                            }

                                                                            if (ediOutput271.QualifierPharmacyCode == "90")
                                                                            {
                                                                                ediOutput271.PrimaryPayerMailOrderEligible = GetEligibityInfo(Qlfr);

                                                                                if (ediOutput271.QualifierInsuranceTypeCode != "")
                                                                                {
                                                                                    ediOutput271.PrimaryPayerMailOrderTypeCode = GetPharmacyInfo(ediOutput271.QualifierInsuranceTypeCode);
                                                                                }
                                                                                ediOutput271.PrimaryPayerMailOrderCoveragePlanName = loop2100D.EB_DependentEligibilityorBenefitInformation.PlanCoverageDescription_05;
                                                                                ediOutput271.PrimaryPayerMailOrderMonetaryAmt = loop2100D.EB_DependentEligibilityorBenefitInformation.BenefitAmount_07;
                                                                                ediOutput271.PrimaryPayerMailOrderCoverageInfo = GetCoverageInfo(Qlfr);

                                                                            }
                                                                        }

                                                                    }

                                                                    if (loop2100D.REF_DependentAdditionalIdentification != null)
                                                                    {
                                                                        foreach (var refdep in loop2100D.REF_DependentAdditionalIdentification)
                                                                        {
                                                                            switch (refdep.ReferenceIdentificationQualifier_01)
                                                                            {

                                                                                case "18":
                                                                                    ediOutput271.HealthPlanNumber = refdep.MemberGrouporPolicyNumber_02;
                                                                                    ediOutput271.HealthPlanName = refdep.Description_03;
                                                                                    break;
                                                                                case "6P":
                                                                                    ediOutput271.GroupId = refdep.MemberGrouporPolicyNumber_02;
                                                                                    ediOutput271.GroupName = refdep.Description_03;
                                                                                    break;
                                                                                case "ALS":
                                                                                    ediOutput271.AlternativeListId = refdep.MemberGrouporPolicyNumber_02;
                                                                                    break;
                                                                                case "CLI":
                                                                                    ediOutput271.CoverageId = refdep.MemberGrouporPolicyNumber_02;
                                                                                    break;
                                                                                case "N6":
                                                                                    ediOutput271.BINNumber = refdep.MemberGrouporPolicyNumber_02;
                                                                                    ediOutput271.PCNNumber = refdep.Description_03;
                                                                                    if (ediOutput271.PCNNumber != null && ediOutput271.PCNNumber != "")
                                                                                    {
                                                                                        if (ediOutput271.BINNumber != null && ediOutput271.BINNumber != "")
                                                                                        {
                                                                                            ediOutput271.BINNumber = ediOutput271.BINNumber + " / " + ediOutput271.PCNNumber;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            ediOutput271.BINNumber = ediOutput271.PCNNumber;
                                                                                        }
                                                                                    }
                                                                                    break;
                                                                                case "FO":
                                                                                    ediOutput271.FormularyListId = refdep.MemberGrouporPolicyNumber_02;
                                                                                    break;
                                                                                case "IG":
                                                                                    ediOutput271.CopayId = refdep.MemberGrouporPolicyNumber_02;
                                                                                    break;

                                                                            }
                                                                        }
                                                                    }
                                                                    if (loop2100D.DTP_DependentEligibility_BenefitDate != null)
                                                                    {
                                                                        foreach (var dtp in loop2100D.DTP_DependentEligibility_BenefitDate)
                                                                        {
                                                                            string Qlfr = dtp.DateTimePeriodFormatQualifier_02;
                                                                            switch (ediOutput271.QualifierPharmacyCode)
                                                                            {
                                                                                case "30":
                                                                                    if (Qlfr == "D8")
                                                                                    {
                                                                                        ediOutput271.HlthPlnBenftCovEligibilityDate = dtp.AccidentDate_03;
                                                                                    }
                                                                                    else if (Qlfr == "RD8")
                                                                                    {
                                                                                        ediOutput271.HlthPlnBenftCovServiceDate = dtp.AccidentDate_03;
                                                                                    }
                                                                                    break;
                                                                                case "88":
                                                                                    if (Qlfr == "D8")
                                                                                    {
                                                                                        ediOutput271.RetailOrdPhrmEligibilityDate = dtp.AccidentDate_03;
                                                                                    }
                                                                                    else if (Qlfr == "RD8")
                                                                                    {
                                                                                        ediOutput271.RetailPhrmServiceDate = dtp.AccidentDate_03;
                                                                                    }
                                                                                    break;
                                                                                case "90":
                                                                                    if (Qlfr == "D8")
                                                                                    {
                                                                                        ediOutput271.MailOrdPhrmEligibilityDate = dtp.AccidentDate_03;
                                                                                    }
                                                                                    else if (Qlfr == "RD8")
                                                                                    {
                                                                                        ediOutput271.MailOrdPhrmServiceDate = dtp.AccidentDate_03;
                                                                                    }
                                                                                    break;
                                                                                case "":
                                                                                    if (Qlfr == "D8")
                                                                                    {
                                                                                        ediOutput271.SpecialtyorLTCPhrmEligibilityDate = dtp.AccidentDate_03;
                                                                                    }
                                                                                    else if (Qlfr == "RD8")
                                                                                    {
                                                                                        ediOutput271.SpecialtyorLTCPhrmServiceDate = dtp.AccidentDate_03;
                                                                                    }
                                                                                    break;

                                                                            }
                                                                        }
                                                                    }
                                                                    if (loop2100D.MSG_MessageText != null)
                                                                    {
                                                                        foreach (var msg in loop2100D.MSG_MessageText)
                                                                        {
                                                                            ediOutput271.QualifierMSGText = msg.FreeFormMessageText_01 + "|" + ediOutput271.QualifierMSGText;
                                                                            switch (msg.FreeFormMessageText_01)
                                                                            {
                                                                                case "LTC":
                                                                                    ediOutput271.LTCPhEligiblityorBenefitInfo = ediOutput271.SpecialtyorLTCCoverageStatus;
                                                                                    ediOutput271.LTCPharmCovName = ediOutput271.SpecialtyorLTCPhrmCovName;
                                                                                    ediOutput271.LTCPhrmEligDate = ediOutput271.SpecialtyorLTCPhrmEligibilityDate;
                                                                                    ediOutput271.LTCPhrmServiceDate = ediOutput271.SpecialtyorLTCPhrmServiceDate;
                                                                                    break;
                                                                                case "LTC PHARMACY":
                                                                                    ediOutput271.LTCPhEligiblityorBenefitInfo = ediOutput271.SpecialtyorLTCCoverageStatus;
                                                                                    ediOutput271.LTCPharmCovName = ediOutput271.SpecialtyorLTCPhrmCovName;
                                                                                    ediOutput271.LTCPhrmEligDate = ediOutput271.SpecialtyorLTCPhrmEligibilityDate;
                                                                                    ediOutput271.LTCPhrmServiceDate = ediOutput271.SpecialtyorLTCPhrmServiceDate;
                                                                                    break;
                                                                                case "SPECIALTY":
                                                                                    ediOutput271.SpecialityPhEligiblityorBenefitInfo = ediOutput271.SpecialtyorLTCCoverageStatus;
                                                                                    ediOutput271.SpecialtyPharmCovName = ediOutput271.SpecialtyorLTCPhrmCovName;
                                                                                    ediOutput271.SpecialtyPhrmEligDate = ediOutput271.SpecialtyorLTCPhrmEligibilityDate;
                                                                                    ediOutput271.SpecialtyPhrmServiceDate = ediOutput271.SpecialtyorLTCPhrmServiceDate;
                                                                                    break;
                                                                                case "SPECIALTY PHARMACY":
                                                                                    ediOutput271.SpecialityPhEligiblityorBenefitInfo = ediOutput271.SpecialtyorLTCCoverageStatus;
                                                                                    ediOutput271.SpecialtyPharmCovName = ediOutput271.SpecialtyorLTCPhrmCovName;
                                                                                    ediOutput271.SpecialtyPhrmEligDate = ediOutput271.SpecialtyorLTCPhrmEligibilityDate;
                                                                                    ediOutput271.SpecialtyPhrmServiceDate = ediOutput271.SpecialtyorLTCPhrmServiceDate;
                                                                                    break;
                                                                            }
                                                                        }
                                                                    }
                                                                }

                                                            }


                                                        }

                                                    }
                                                }
                                                #endregion "Subscriber other information"
                                            }
                                        }



                                    }

                                }

                            }

                        }


                    }


                    #region "Group Set Trailor - GE"
                    if (mytype.FullName == "EdiFabric.Core.Model.Edi.X12.GE")
                    {
                        GE ge = (GE)edi271Item;
                    }
                    #endregion "Group Set Trailor - GE"

                    #region "Interchange Segment Trailor - IEA"
                    if (mytype.FullName == "EdiFabric.Core.Model.Edi.X12.IEA")
                    {
                        IEA iea = (IEA)edi271Item;
                    }
                    #endregion "Interchange Segment Trailor - IEA"

                    #region "Transaction Segment Trailor - SE"
                    if (mytype.FullName == "EdiFabric.Core.Model.Edi.X12.SE")
                    {
                        SE se = (SE)edi271Item;
                        ediOutput271.STLoopCount = se.TransactionSetControlNumber_02;
                    }
                    #endregion "Transaction Segment Trailor - SE"
                }
            }

            ediOutput271.Send270UsingDEA = Send270UsingDEA;
            return ediOutput271;
        }

        public string Post270AndGet271(string edi270, string RxhubURL, string RxHubAuthorization)
        {

            System.Net.WebResponse result = null;

            ASCIIEncoding asciiEncoding = null;
            StringBuilder restURL = null;
            HttpWebRequest restRequest = null;

            System.IO.StreamReader oReader = null;
            System.IO.Stream mystream = null;

            byte[] edit270Bytes = null;

            string resultString = string.Empty;

            try
            {

                asciiEncoding = new ASCIIEncoding();
                restURL = new StringBuilder();
                restURL.AppendFormat(RxhubURL.ToString());
                //'= WebRequest.Create("https://switch-cert01.rxhub.net/rxhub")
                restRequest = (HttpWebRequest)WebRequest.Create(restURL.ToString());
                restRequest.Headers.Add("Authorization: Basic " + Convert.ToBase64String(asciiEncoding.GetBytes(RxHubAuthorization.ToString())));


                string strEncodedContents = "request=";
                strEncodedContents += HttpUtility.UrlEncode(edi270);


                edit270Bytes = asciiEncoding.GetBytes(strEncodedContents);


                restRequest.UseDefaultCredentials = true;
                restRequest.Method = "POST";
                restRequest.ContentType = "application/x-www-form-urlencoded";
                restRequest.KeepAlive = true;
                restRequest.ContentLength = edit270Bytes.Length;

                //'Posting request

                using (Stream requestStream = restRequest.GetRequestStream())
                {
                    requestStream.Write(edit270Bytes, 0, edit270Bytes.Length);
                    requestStream.Close();
                }


                //'Reading response
                ///''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                result = restRequest.GetResponse();
                if (result != null)
                {
                    using (mystream = result.GetResponseStream())
                    {
                        using (oReader = new System.IO.StreamReader(mystream))
                        {
                            resultString = oReader.ReadToEnd();
                            oReader.Close();
                        }
                        mystream.Close();
                    }
                    result.Close();
                }
                restRequest = null;
            }
            catch (Exception Ex)
            {
                resultString = "$Exception$" + Ex.ToString();
            }
            return resultString;
        }

        public string getX12(string ediJSON)
        {
            string url = "https://api.edifabric.com/v1/generate/x12-interchange";
            string apiKey = "1f8e7c5a3f1e4ea5bb965c3fdd388aff";
            string Response = null;
            HttpWebRequest httpWebRequest = null;//Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse httpWebResponse = null;//Declare an HTTP-specific implementation of the WebResponse class

            //Creates an HttpWebRequest for the specified URL.
            httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                httpWebRequest.Headers.Add("Content-type", "application/json");
                httpWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", apiKey);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                byte[] bytes;
                bytes = System.Text.Encoding.ASCII.GetBytes(ediJSON);
                httpWebRequest.ContentLength = bytes.Length;
                using (Stream requestStream = httpWebRequest.GetRequestStream())
                {
                    //Writes a sequence of bytes to the current stream 
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();//Close stream
                }

                //Sends the HttpWebRequest, and waits for a Response.
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                if (httpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    //Get Response stream into StreamReader
                    using (Stream ResponseStream = httpWebResponse.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(ResponseStream))
                            Response = reader.ReadToEnd();
                    }
                }
                httpWebResponse.Close();//Close HttpWebResponse

            }
            catch (WebException Ex)
            {
                Console.WriteLine(Ex);
            }
            finally
            {
                httpWebResponse.Close();
                //Release objects
                httpWebResponse = null;
                httpWebRequest = null;
            }
            return Response;

        }
    }

}
