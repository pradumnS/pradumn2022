using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuxiAddonNBFCHostEntityOTPRequestInterface
{
    class utilities
    {
    }

    public class CNBFCUserCredentials
    {
        public string userId { get; set; }
        public string userPassword { get; set; }
        public string otp { get; set; }
        public CNBFCUserCredentials()
        {
            userId = "";
            userPassword = "";
            otp = "";
        }
    }

    public class NBFCAddInfo
    {
        public string tag { get; set; }
        public string value { get; set; }

        public NBFCAddInfo()
        {
            tag = "";
            value = "";
        }
    }
    public class NBFCV2AddInfo
    {
        public string tag { get; set; }
        public string value { get; set; }

        public NBFCV2AddInfo()
        {
            tag = "";
            value = "";
        }
    }


    public class NBFCSpecialCharges
    {
        public string name { get; set; }
        public string valueType { get; set; }
        public string value { get; set; }

        public NBFCSpecialCharges()
        {
            name = string.Empty;
            valueType = "";
            value = "";
        }
    }

    public class CAuxiNBFCHostOTPRequestParamsMonTap
    {
        public string username { get; set; }
        public string password { get; set; }
        public string TransactionTypeId { get; set; }
        public string mobile { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiry { get; set; }
        public string TxnAmount { get; set; }
        public string TransactionID { get; set; }
        public string OriginalTransactionID { get; set; }
        public string Mid { get; set; }
        public string Tid { get; set; }
        public string DateTime { get; set; }

        public NBFCAddInfo[] AdditionalInfo;


        public CAuxiNBFCHostOTPRequestParamsMonTap()
        {
            username = "";
            password = "";
            TransactionTypeId = "";
            mobile = "";
            CardNumber = "";
            CardExpiry = "";
            TxnAmount = "";
            TransactionID = "";
            OriginalTransactionID = "";
            Mid = "";
            Tid = "";
            DateTime = "";
        }
    }

    public class CAuxiNBFCHostOTPRequestParams
    {
        public string TransactionTypeId { get; set; }
        public string mobile { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiry { get; set; }
        public string TxnAmount { get; set; }
        public string TransactionID { get; set; }
        public string OriginalTransactionID { get; set; }
        public string Mid { get; set; }
        public string Tid { get; set; }
        public string OemId { get; set; }
        public string ProductId { get; set; }
        public string ImeiNo { get; set; }
        public string ProductSku { get; set; }

        public string DateTime { get; set; }

        public NBFCAddInfo[] AdditionalInfo;


        public CAuxiNBFCHostOTPRequestParams()
        {

            TransactionTypeId = "";
            mobile = "";
            CardNumber = "";
            CardExpiry = "";
            TxnAmount = "";
            TransactionID = "";
            OriginalTransactionID = "";
            Mid = "";
            Tid = "";
            DateTime = "";
        }
    }
    
    public class CAuxiNBFCV2HostRequestParam
    {
        public string payload { get; set; }
        public string iv { get; set; }
        public string key { get; set; }


        public CAuxiNBFCV2HostRequestParam()
        {
            payload = "";
            iv = "";
            key = "";
        }
    }
  
    public class CAuxiNBFCV2HostResponseParam
    {
        public string payload { get; set; }
        public string iv { get; set; }
        public string key { get; set; }


        public CAuxiNBFCV2HostResponseParam()
        {
            payload = "";
            iv = "";
            key = "";
        }
    }

    public class CProductDetails
    {
        public string oemId { get; set; }
        public string productId { get; set; }
        public string imeiNo { get; set; }
        public string productSku { get; set; }


        public CProductDetails()
        {
            oemId = "";
            productId = "";
            imeiNo = "";

            productSku = "";
        }
    }

    public class CAuxiNBFCV2HostOTPRequestFeilds
    {
        public string transactionTypeId { get; set; }
        public string mobile { get; set; }
        public string cardNumber { get; set; }
        public string cardExpiry { get; set; }
        public string saleTxnType { get; set; }
        public string txnAmount { get; set; }
        public string loanAmount { get; set; }
        public string marginMoney { get; set; }
        public string transactionId { get; set; }
        public string originalTransactionId { get; set; }
        public string mid { get; set; }
        public string tid { get; set; }
        public string dateTime { get; set; }

        public CProductDetails productDetails;

        public NBFCV2AddInfo[] additionalInfo;

        public CAuxiNBFCV2HostOTPRequestFeilds()
        {

            transactionTypeId = "";
            mobile = "";
            cardNumber = "";
            cardExpiry = "";
            saleTxnType = "";
            txnAmount = "";
            loanAmount = "";
            marginMoney = "";
            transactionId = "";
            originalTransactionId = "";
            mid = "";
            tid = "";
            dateTime = "";

            productDetails = new CProductDetails();

        }
    }
    public class CAuxiNBFCV2HostHCEligibilityRequestFeilds 
    {
        public string transactionTypeId { get; set; }
        public string mobile { get; set; }
        public string cardNumber { get; set; }
        public string cardExpiry { get; set; }
        public string saleTxnType { get; set; }
        public string txnAmount { get; set; }
        public string loanAmount { get; set; }
        public string marginMoney { get; set; }
        public string transactionId { get; set; }
        public string mid { get; set; }
        public string tid { get; set; }
        public string dateTime { get; set; }

        public CProductDetails productDetails;

        public NBFCV2AddInfo[] additionalInfo;

        public CAuxiNBFCV2HostHCEligibilityRequestFeilds()
        {

            transactionTypeId = "";
            mobile = "";
            cardNumber = "";
            cardExpiry = "";
            saleTxnType = "";
            txnAmount = "";
            loanAmount = "";
            marginMoney = "";
            transactionId = "";
            mid = "";
            tid = "";
            dateTime = "";

            productDetails = new CProductDetails();

        }
    }
    public class NBFCV2OTPResponseFeilds
    {
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
        public string hostTransactionId { get; set; }

        public NBFCV2ResponseParamsSchemeDetails schemeDetails { get; set; }
        public NBFCV2AddInfo[] additionalInfo { get; set; }


        public NBFCV2OTPResponseFeilds()
        {
            responseCode = "";
            responseDescription = "";
            hostTransactionId = "";
            schemeDetails = new NBFCV2ResponseParamsSchemeDetails();
        }

    }
    public class NBFCV2HCEligibilityResponseFeilds
    {
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
        public string hostTransactionId { get; set; }

        public NBFCV2ResponseParamsSchemeDetails schemeDetails { get; set; }
        public NBFCV2AddInfo[] additionalInfo { get; set; }


        public NBFCV2HCEligibilityResponseFeilds()
        {
            responseCode = "";
            responseDescription = "";
            hostTransactionId = "";
            schemeDetails = new NBFCV2ResponseParamsSchemeDetails();
        }

    }



    public class NBFCV2CreateLoanRequestFeilds
    {
        public string mobile { get; set; }
        public string cardNumber { get; set; }
        public string cardExpiry { get; set; }
        public string txnAmount { get; set; }
        public string txnType { get; set; }
        public string mid { get; set; }
        public string tid { get; set; }
        public string otp { get; set; }
        public string dateTime { get; set; }
        public string transactionId { get; set; }
        public string schemeId { get; set; }
        public string tenure { get; set; }
        public string roi { get; set; }

        public NBFCV2CalculationDetail calculationDetails { get; set; }


        public NBFCV2AddInfo[] additionalInfo;

        public NBFCV2CreateLoanRequestFeilds()
        {

            mobile = "";
            cardNumber = "";
            cardExpiry = "";
            txnAmount = "";
            txnType = "";
            mid = "";
            tid = "";
            otp = "";
            dateTime = "";
            transactionId = "";
            schemeId = "";
            tenure = "";
            roi = "";
            calculationDetails = new NBFCV2CalculationDetail();


        }


    }
    public class NBFCV2HCCreateLoanRequestFeilds
    {
        public string mobile { get; set; }
        public string cardNumber { get; set; }
        public string cardExpiry { get; set; }
        public string txnAmount { get; set; }
        public string txnType { get; set; }
        public string mid { get; set; }
        public string tid { get; set; }
        public string otp { get; set; }
        public string dateTime { get; set; }
        public string transactionId { get; set; }
        public string schemeId { get; set; }
        public string tenure { get; set; }
        public string roi { get; set; }
        public NBFCV2CalculationDetail calculationDetails { get; set; }

        public NBFCV2AddInfo[] additionalInfo;
        public NBFCV2HCCreateLoanRequestFeilds()
        {
            mobile = "";
            cardNumber = "";
            cardExpiry = "";
            txnAmount = "";
            mid = "";
            tid = "";
            otp = "";
            dateTime = "";
            txnType = "";
            transactionId = "";
            schemeId = "";
            tenure = "";
            roi = "";
            calculationDetails = new NBFCV2CalculationDetail();
        }
    }
    public class NBFCV2CreateLoanResponseFeilds
    {
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
        public string hostTransactionId { get; set; }

        public NBFCV2CalculationDetail calculationDetailsResponse { get; set; }

        public string customerName { get; set; }
        public string secondaryIdentifier { get; set; }
        public string firstDueDate { get; set; }
        public string modeOfRepayment { get; set; }

        public CBankDetails bankDetails { get; set; }
        public CAddressDetails addressDetails { get; set; }
        public CLoanDocs loanDocs { get; set; }

        public NBFCV2AddInfo[] additionalInfo { get; set; }
        public NBFCV2CreateLoanResponseFeilds()
        {
            responseCode = "";
            responseDescription = "";
            hostTransactionId = "";
            calculationDetailsResponse = new NBFCV2CalculationDetail();
            customerName = "";
            secondaryIdentifier = "";
            firstDueDate = "";
            modeOfRepayment = "";
            bankDetails = new CBankDetails();
            addressDetails = new CAddressDetails();
            loanDocs = new CLoanDocs();
        }

    }
    public class NBFCV2HCCreateLoanResponseFeilds
    {
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
        public string hostTransactionId { get; set; }

        public NBFCV2CalculationDetail calculationDetailsResponse { get; set; }

        public string customerName { get; set; }
        public string secondaryIdentifier { get; set; }
        public string firstDueDate { get; set; }
        public string modeOfRepayment { get; set; }

        public CBankDetails bankDetails { get; set; }
        public CAddressDetails addressDetails { get; set; }
        public CLoanDocs loanDocs { get; set; }

        public NBFCV2AddInfo[] additionalInfo { get; set; }
        public NBFCV2HCCreateLoanResponseFeilds()
        {
            responseCode = "";
            responseDescription = "";
            hostTransactionId = "";
            calculationDetailsResponse = new NBFCV2CalculationDetail();
            customerName = "";
            secondaryIdentifier = "";
            firstDueDate = "";
            modeOfRepayment = "";
            bankDetails = new CBankDetails();
            addressDetails = new CAddressDetails();
            loanDocs = new CLoanDocs();
        }

    }


    public class NBFC2HCOTPRequestFileds
    {
        public string transactionTypeId { get; set; }
        public string transactionId { get; set; }
        public string originalTransactionId { get; set; }
        public string schemeId { get; set; }
        public string hostTransactionId { get; set; }

        public NBFC2HCOTPRequestFileds()
        {
            transactionTypeId = "";

            transactionId = "";

            originalTransactionId = "";

            schemeId = "";

            hostTransactionId = "";
        }
    }
    public class NBFC2HCOTPResponseFeilds
    {
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
        public string hostTransactionId { get; set; }

        public NBFC2HCOTPResponseFeilds()
        {
            responseCode = " ";

            responseDescription = " ";

            hostTransactionId = " ";

        }
    }


    public class NBFCV2CancellationRequestFeilds
    {
        public string mid { get; set; }
        public string tid { get; set; }
        public string mobile { get; set; }
        public string cardNumber { get; set; }
        public string cardExpiry { get; set; }
        public string cancellationType { get; set; }
        public string reversalTypeId { get; set; }
        public string otp { get; set; }
        public string txnAmount { get; set; }
        public string transactionId { get; set; }
        public string originalTransactionId { get; set; }
        public string dateTime { get; set; }

        public NBFCV2AddInfo[] additionalInfo;


        public NBFCV2CancellationRequestFeilds()
        {
            tid = "";
            mobile = "";
            cardNumber = "";
            cardExpiry = "";
            cancellationType = "";
            reversalTypeId = "";
            otp = "";
            txnAmount = "";
            transactionId = "";
            originalTransactionId = "";
            dateTime = "";
        }



    }
    public class NBFCV2HCCancellationRequestFeilds
    {
        public string mid { get; set; }
        public string tid { get; set; }
        public string mobile { get; set; }
        public string cardNumber { get; set; }
        public string cardExpiry { get; set; }
        public string cancellationType { get; set; }
        public string reversalTypeId { get; set; }
        public string otp { get; set; }
        public string txnAmount { get; set; }
        public string transactionId { get; set; }
        public string originalTransactionId { get; set; }
        public string dateTime { get; set; }

        public NBFCV2AddInfo[] additionalInfo;


        public NBFCV2HCCancellationRequestFeilds()
        {
            tid = "";
            mobile = "";
            cardNumber = "";
            cardExpiry = "";
            cancellationType = "";
            reversalTypeId = "";
            otp = "";
            txnAmount = "";
            transactionId = "";
            originalTransactionId = "";
            dateTime = "";
        }



    }
    public class NBFCV2CancellationResponseFeilds
    {
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
        public string hostTransactionId { get; set; }

        public NBFCV2CancellationResponseFeilds()
        {
            responseCode = "";
            responseDescription = "";
            hostTransactionId = "";

        }
    }
    public class NBFCV2HCCancellationResponseFeilds
    {
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
        public string hostTransactionId { get; set; }

        public NBFCV2HCCancellationResponseFeilds()
        {
            responseCode = "";
            responseDescription = "";
            hostTransactionId = "";

        }
    }

    public class CAuxiNBFCHostVoidRefundRequestParams
    {
        public string mobile { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiry { get; set; }
        public string TxnAmount { get; set; }
        public string TransactionID { get; set; }
        public string HostTransactionID { get; set; }
        public string OriginalTransactionID { get; set; }
        public string OriginalSaleHostTransactionID { get; set; }
        public string Otp { get; set; }
        public string AccessCode { get; set; }
        public string Mid { get; set; }
        public string Tid { get; set; }
        public string DateTime { get; set; }

        public NBFCAddInfo[] AdditionalInfo;


        public CAuxiNBFCHostVoidRefundRequestParams()
        {

            mobile = "";
            CardNumber = "";
            CardExpiry = "";
            TxnAmount = "";
            TransactionID = "";
            HostTransactionID = "";
            OriginalTransactionID = "";
            OriginalSaleHostTransactionID = "";
            Otp = "";
            AccessCode = "";
            Mid = "";
            Tid = "";
            DateTime = "";

        }
    }
    public class CAuxiNBFCHostVoidRefundRequestParamsMonTap
    {
        public string username { get; set; }
        public string password { get; set; }
        public string mobile { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiry { get; set; }
        public string TxnAmount { get; set; }
        public string TransactionID { get; set; }
        public string HostTransactionID { get; set; }
        public string OriginalTransactionID { get; set; }
        public string OriginalSaleHostTransactionID { get; set; }
        public string Otp { get; set; }
        public string AccessCode { get; set; }
        public string Mid { get; set; }
        public string Tid { get; set; }
        public string DateTime { get; set; }

        public NBFCAddInfo[] AdditionalInfo;


        public CAuxiNBFCHostVoidRefundRequestParamsMonTap()
        {
            username = "";
            password = "";
            mobile = "";
            CardNumber = "";
            CardExpiry = "";
            TxnAmount = "";
            TransactionID = "";
            HostTransactionID = "";
            OriginalTransactionID = "";
            OriginalSaleHostTransactionID = "";
            Otp = "";
            AccessCode = "";
            Mid = "";
            Tid = "";
            DateTime = "";

        }
    }
    public class CAuxiNBFCHostSaleRequestParams
    {
        public string mobile { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiry { get; set; }
        public string TxnAmount { get; set; }
        public string TransactionID { get; set; }
        public string HostTransactionID { get; set; }
        public string Mid { get; set; }
        public string Tid { get; set; }
        public string DateTime { get; set; }
        public string Otp { get; set; }
        public string AccessCode { get; set; }
        public string TxnType { get; set; }
        public string ProductId { get; set; }
        public string ProductSku { get; set; }
        public string OemId { get; set; }
        public string SchemeId { get; set; }
        public string SchemeDesc { get; set; }
        public string ImeiNo { get; set; }
        public string EmiAmount { get; set; }
        public string Roi { get; set; }
        public string TenureMonths { get; set; }
        public string DownPaymentAmt { get; set; }

        public NBFCAddInfo[] AdditionalInfo;


        public CAuxiNBFCHostSaleRequestParams()
        {

            mobile = "";
            TxnAmount = "";
            TransactionID = "";
            HostTransactionID = "";
            Mid = "";
            Tid = "";
            DateTime = "";
            CardNumber = "";
            CardExpiry = "";
            Otp = "";
            AccessCode = "";
            TxnType = "";
            ProductId = "";
            ProductSku = "";
            OemId = "";
            SchemeId = "";
            SchemeDesc = "";
            ImeiNo = "";
            EmiAmount = "";
            Roi = "";
            TenureMonths = "";
            DownPaymentAmt = "";
        }


    }   
    public class NBFCV2CalculationDetail
    {
        public string advanceEmiAmount { get; set; }
        public string downPaymentAmount { get; set; }
        public string emiAmount { get; set; }
        public string processingFee { get; set; }
        public string loanAmount { get; set; }
        public string marginMoney { get; set; }


        public NBFCV2CalculationDetail()
        {
            advanceEmiAmount = "";
            downPaymentAmount = "";
            emiAmount = "";
            processingFee = "";
            loanAmount = "";
            marginMoney = "";
        }

    }
    public class CBankDetails
    {
        public string ecsMandate { get; set; }
        public string bankName { get; set; }
        public string accountNumber { get; set; }
        public string micrCode { get; set; }

        public CBankDetails()
        {
            ecsMandate = "";
            bankName = "";
            accountNumber = "";
            micrCode = "";


        }

    }

    public class CAddressDetails
    {
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string addressLine3 { get; set; }
        public string residenceCity { get; set; }

        public CAddressDetails()
        {
            addressLine1 = "";
            addressLine2 = "";
            addressLine3 = "";
            residenceCity = "";

        }
    }

    public class CLoanDocs
    {
        public string idproof { get; set; }
        public string addressProof { get; set; }
        public string loanApplication { get; set; }
        public string dpn { get; set; }

        public CLoanDocs()
        {
            idproof = "";
            addressProof = "";
            loanApplication = "";
            dpn = "";


        }

    }
    public class CAuxiNBFCHostSaleRequestParamsMonTap
    {
        public string username { get; set; }
        public string password { get; set; }
        public string mobile { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiry { get; set; }
        public string TxnAmount { get; set; }
        public string TransactionID { get; set; }
        public string HostTransactionID { get; set; }
        public string Mid { get; set; }
        public string Tid { get; set; }
        public string DateTime { get; set; }
        public string Otp { get; set; }
        public string AccessCode { get; set; }
        public string TxnType { get; set; }
        public string ProductId { get; set; }
        public string ProductSku { get; set; }
        public string OemId { get; set; }
        public string SchemeId { get; set; }
        public string SchemeDesc { get; set; }
        public string ImeiNo { get; set; }
        public string EmiAmount { get; set; }
        public string Roi { get; set; }
        public string TenureMonths { get; set; }
        public string DownPaymentAmt { get; set; }

        public NBFCAddInfo[] AdditionalInfo;


        public CAuxiNBFCHostSaleRequestParamsMonTap()
        {
            username = "";
            password = "";
            mobile = "";
            TxnAmount = "";
            TransactionID = "";
            HostTransactionID = "";
            Mid = "";
            Tid = "";
            DateTime = "";
            CardNumber = "";
            CardExpiry = "";
            Otp = "";
            AccessCode = "";
            TxnType = "";
            ProductId = "";
            ProductSku = "";
            OemId = "";
            SchemeId = "";
            SchemeDesc = "";
            ImeiNo = "";
            EmiAmount = "";
            Roi = "";
            TenureMonths = "";
            DownPaymentAmt = "";
        }


    }
    public class CAuxiNBFCHostReversalRequestParams
    {

        public string TxnTypeId { get; set; }
        public string mobile { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiry { get; set; }
        public string TransactionID { get; set; }
        public string OriginalTransactionID { get; set; }
        public string TxnAmount { get; set; }
        public string Mid { get; set; }
        public string Tid { get; set; }
        public string DateTime { get; set; }

        public NBFCAddInfo[] AdditionalInfo;


        public CAuxiNBFCHostReversalRequestParams()
        {

            TxnTypeId = "";
            mobile = "";
            CardNumber = "";
            CardExpiry = "";
            TxnAmount = "";
            TransactionID = "";
            OriginalTransactionID = "";
            Mid = "";
            Tid = "";
            DateTime = "";

        }
    }
    public class CAuxiNBFCHostReversalRequestParamsMonTap
    {
        public string username { get; set; }
        public string password { get; set; }
        public string TxnTypeId { get; set; }
        public string mobile { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiry { get; set; }
        public string TransactionID { get; set; }
        public string OriginalTransactionID { get; set; }
        public string TxnAmount { get; set; }
        public string Mid { get; set; }
        public string Tid { get; set; }
        public string DateTime { get; set; }

        public NBFCAddInfo[] AdditionalInfo;


        public CAuxiNBFCHostReversalRequestParamsMonTap()
        {
            username = "";
            password = "";
            TxnTypeId = "";
            mobile = "";
            CardNumber = "";
            CardExpiry = "";
            TxnAmount = "";
            TransactionID = "";
            OriginalTransactionID = "";
            Mid = "";
            Tid = "";
            DateTime = "";

        }
    }

    public class NBFCV2SchemeValue
    {
        public string valueType { get; set; }
        public string value { get; set; }

        public NBFCV2SchemeValue()
        {
            valueType = "";
            value = "";
        }
    }

    public class CCashBack
    {
        public string type { get; set; }
        public string valueType { get; set; }
        //public string Value { get; set; }
        public string oemShare { get; set; }
        public string merchantShare { get; set; }
        public string financierShare { get; set; }
        public string thresholdAmount { get; set; }

        public CCashBack()
        {
            type = "";
            valueType = "";
            //Value = "";
            oemShare = "";
            merchantShare = "";
            financierShare = "";
            thresholdAmount = "";

        }

    }
   
    public class NBFCV2SchemeData
    {



        public string schemeId { get; set; }
        public string schemeDesc { get; set; }
        public string terminalDesc { get; set; }
        public string schemeType { get; set; }
        public string schemeFlag { get; set; }
        public string schemeStartDate { get; set; }
        public string schemeEndDate { get; set; }
        public string minAmount { get; set; }

        public string maxAmount { get; set; }
        public string roi { get; set; }
        public string tenure { get; set; }


        public NBFCV2SchemeValue schemeDownPayment { get; set; }

        public NBFCV2SchemeValue customerProcessingFee { get; set; }

        public NBFCV2SchemeValue oemProcessingFee { get; set; }

        public NBFCV2SchemeValue mdr { get; set; }

        public NBFCV2SchemeValue mbd { get; set; }
        public NBFCV2SchemeValue dbd { get; set; }

       

        public CCashBack cashBack { get; set; }

        
        public Dictionary<string, NBFCSpecialCharges> financierCrossSellCharges { get; set; }

        
        public Dictionary<string, NBFCSpecialCharges> financierAdditionalCharges { get; set; }


        public NBFCV2SchemeData()
        {
            schemeId = "";
            schemeDesc = "";
            terminalDesc = "";
            schemeType = "";
            schemeFlag = "";
            schemeStartDate = "";
            schemeEndDate = "";
            minAmount = "";
            maxAmount = "";
            roi = "";
            tenure = "";

            schemeDownPayment = new NBFCV2SchemeValue();
            customerProcessingFee = new NBFCV2SchemeValue();
            oemProcessingFee = new NBFCV2SchemeValue();
            mdr = new NBFCV2SchemeValue();
            mbd = new NBFCV2SchemeValue();
            dbd = new NBFCV2SchemeValue();
            // TaxRate = "";
            cashBack = new CCashBack();

        }
    }

    public class NBFCV2ResponseParamsSchemeDetails
    {
        public int nCount { get; set; }
        public NBFCV2SchemeData[] applicableSchemes { get; set; }
        public NBFCV2ResponseParamsSchemeDetails()
        {
            nCount = 0;
        }
    }

    
    public class NBFCResponseParams
    {
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
        public string HostTransactionID { get; set; }

        public NBFCAddInfo[] AdditionalInfo { get; set; }


        public NBFCResponseParams()
        {
            responseCode = "";
            responseDescription = "";
            HostTransactionID = "";
        }

    }

    public class NBFCReversalResponseParams
    {
        public string responseCode { get; set; }
        public string responseDescription { get; set; }

        public NBFCAddInfo[] AdditionalInfo { get; set; }


        public NBFCReversalResponseParams()
        {
            responseCode = "";
            responseDescription = "";
        }

    }

    static class Constants
    {

        public const int TXN_TYPE_SALE = 1;
        public const int TXN_TYPE_VOID = 2;
        public const int TXN_TYPE_REVERSAL = 3;
        public const int TXN_TYPE_REFUND = 4;
        public const int TXN_TYPE_ENQUIRY = 5;
        public const int TXN_TYPE_GET_OTP = 6;

        public const int MONEYTAP = 5;
        public const int ZESTMONEY = 7;
        public const int TESTGENERICNBFCV2 = 10;

    }

    static class CancellationType
    {
        public const int VOID = 1;
        public const int REVERSAL = 2;
        public const int REFUND = 3;
    }

    static class ReversalType
    {
        public const int SALE = 1;
        public const int VOID = 2;
        public const int REFUND = 3;
    }

    enum SchemeResponseFeilds
    {
        F1_SchemeId
, F2_SchemeDesc
, F3_TerminalDesc
, F4_SchemeType
, F5_SchemeFlag
, F6_SchemeStartDate
, F7_SchemeEndDate
, F8_MinAmount
, F9_MaxAmount
, F10_Roi
, F11_Tenure
, F12_SchemeDownPaymentValueType
, F13_SchemeDownPaymentValue
, F14_CustomerProcessingFeeValueType
, F15_CustomerProcessingFeeValue
, F16_OemProcessingFeeValueType
, F17_OemProcessingFeeValue
, F18_MDRValueType
, F19_MDRValue
, F20_MBDValueType
, F21_MBDValue
, F22_DBDValueType
, F23_DBDValue
, F24_TaxRate
, F25_CashbackType
, F26_CashbackValueType
, F27_CashbackValue
, F28_CashbackOemShare
, F29_CashbackMerchantShare
, F30_CashbackThresholdAmount
    }


}

static class Constants
{

    public const int TXN_TYPE_SALE = 1;
    public const int TXN_TYPE_VOID = 2;
    public const int TXN_TYPE_REVERSAL = 3;
    public const int TXN_TYPE_REFUND = 4;
    public const int TXN_TYPE_ENQUIRY = 5;
    public const int TXN_TYPE_GET_OTP = 6;

}



