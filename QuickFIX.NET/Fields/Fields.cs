using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// Account Field
    /// </summary>/
    public sealed class Account : StringField
    {
        public Account()
            :base(Tags.Account) {}
        public Account(string val)
            :base(Tags.Account, val) {}

    }


    /// <summary>
    /// AdvId Field
    /// </summary>/
    public sealed class AdvId : StringField
    {
        public AdvId()
            :base(Tags.AdvId) {}
        public AdvId(string val)
            :base(Tags.AdvId, val) {}

    }


    /// <summary>
    /// AdvRefID Field
    /// </summary>/
    public sealed class AdvRefID : StringField
    {
        public AdvRefID()
            :base(Tags.AdvRefID) {}
        public AdvRefID(string val)
            :base(Tags.AdvRefID, val) {}

    }


    /// <summary>
    /// AdvSide Field
    /// </summary>/
    public sealed class AdvSide : CharField
    {
        public AdvSide()
            :base(Tags.AdvSide) {}
        public AdvSide(char val)
            :base(Tags.AdvSide, val) {}


        // Field Enumerations
        public const char BUY = 'B';
        public const char SELL = 'S';
        public const char TRADE = 'T';
        public const char CROSS = 'X';
    }


    /// <summary>
    /// AdvTransType Field
    /// </summary>/
    public sealed class AdvTransType : StringField
    {
        public AdvTransType()
            :base(Tags.AdvTransType) {}
        public AdvTransType(string val)
            :base(Tags.AdvTransType, val) {}


        // Field Enumerations
        public const string CANCEL = "C";
        public const string NEW = "N";
        public const string REPLACE = "R";
    }


    /// <summary>
    /// AvgPx Field
    /// </summary>/
    public sealed class AvgPx : DecimalField
    {
        public AvgPx()
            :base(Tags.AvgPx) {}
        public AvgPx(Decimal val)
            :base(Tags.AvgPx, val) {}

    }


    /// <summary>
    /// BeginSeqNo Field
    /// </summary>/
    public sealed class BeginSeqNo : IntField
    {
        public BeginSeqNo()
            :base(Tags.BeginSeqNo) {}
        public BeginSeqNo(int val)
            :base(Tags.BeginSeqNo, val) {}

    }


    /// <summary>
    /// BeginString Field
    /// </summary>/
    public sealed class BeginString : StringField
    {
        public BeginString()
            :base(Tags.BeginString) {}
        public BeginString(string val)
            :base(Tags.BeginString, val) {}

    }


    /// <summary>
    /// BodyLength Field
    /// </summary>/
    public sealed class BodyLength : DecimalField
    {
        public BodyLength()
            :base(Tags.BodyLength) {}
        public BodyLength(Decimal val)
            :base(Tags.BodyLength, val) {}

    }


    /// <summary>
    /// CheckSum Field
    /// </summary>/
    public sealed class CheckSum : StringField
    {
        public CheckSum()
            :base(Tags.CheckSum) {}
        public CheckSum(string val)
            :base(Tags.CheckSum, val) {}

    }


    /// <summary>
    /// ClOrdID Field
    /// </summary>/
    public sealed class ClOrdID : StringField
    {
        public ClOrdID()
            :base(Tags.ClOrdID) {}
        public ClOrdID(string val)
            :base(Tags.ClOrdID, val) {}

    }


    /// <summary>
    /// Commission Field
    /// </summary>/
    public sealed class Commission : DecimalField
    {
        public Commission()
            :base(Tags.Commission) {}
        public Commission(Decimal val)
            :base(Tags.Commission, val) {}

    }


    /// <summary>
    /// CommType Field
    /// </summary>/
    public sealed class CommType : CharField
    {
        public CommType()
            :base(Tags.CommType) {}
        public CommType(char val)
            :base(Tags.CommType, val) {}


        // Field Enumerations
        public const char PER_UNIT = '1';
        public const char PERCENT = '2';
        public const char ABSOLUTE = '3';
        public const char PERCENTAGE_WAIVED_4 = '4';
        public const char PERCENTAGE_WAIVED_5 = '5';
        public const char POINTS_PER_BOND_OR_CONTRACT = '6';
    }


    /// <summary>
    /// CumQty Field
    /// </summary>/
    public sealed class CumQty : DecimalField
    {
        public CumQty()
            :base(Tags.CumQty) {}
        public CumQty(Decimal val)
            :base(Tags.CumQty, val) {}

    }


    /// <summary>
    /// Currency Field
    /// </summary>/
    public sealed class Currency : DecimalField
    {
        public Currency()
            :base(Tags.Currency) {}
        public Currency(Decimal val)
            :base(Tags.Currency, val) {}

    }


    /// <summary>
    /// EndSeqNo Field
    /// </summary>/
    public sealed class EndSeqNo : IntField
    {
        public EndSeqNo()
            :base(Tags.EndSeqNo) {}
        public EndSeqNo(int val)
            :base(Tags.EndSeqNo, val) {}

    }


    /// <summary>
    /// ExecID Field
    /// </summary>/
    public sealed class ExecID : StringField
    {
        public ExecID()
            :base(Tags.ExecID) {}
        public ExecID(string val)
            :base(Tags.ExecID, val) {}

    }


    /// <summary>
    /// ExecInst Field
    /// </summary>/
    public sealed class ExecInst : StringField
    {
        public ExecInst()
            :base(Tags.ExecInst) {}
        public ExecInst(string val)
            :base(Tags.ExecInst, val) {}


        // Field Enumerations
        public const string STAY_ON_OFFER_SIDE = "0";
        public const string NOT_HELD = "1";
        public const string WORK = "2";
        public const string GO_ALONG = "3";
        public const string OVER_THE_DAY = "4";
        public const string HELD = "5";
        public const string PARTICIPANT_DONT_INITIATE = "6";
        public const string STRICT_SCALE = "7";
        public const string TRY_TO_SCALE = "8";
        public const string STAY_ON_BID_SIDE = "9";
        public const string NO_CROSS = "A";
        public const string TRAILING_STOP_PEG = "a";
        public const string OK_TO_CROSS = "B";
        public const string STRICT_LIMIT = "b";
        public const string IGNORE_PRICE_VALIDITY_CHECKS = "c";
        public const string CALL_FIRST = "C";
        public const string PEG_TO_LIMIT_PRICE = "d";
        public const string PERCENT_OF_VOLUME = "D";
        public const string DO_NOT_INCREASE = "E";
        public const string WORK_TO_TARGET_STRATEGY = "e";
        public const string DO_NOT_REDUCE = "F";
        public const string ALL_OR_NONE = "G";
        public const string REINSTATE_ON_SYSTEM_FAILUE = "H";
        public const string INSTITUTIONS_ONLY = "I";
        public const string REINSTATE_ON_TRADING_HALT = "J";
        public const string CANCEL_ON_TRADING_HALT = "K";
        public const string LAST_PEG = "L";
        public const string MID_PRICE_PEG = "M";
        public const string NON_NEGOTIABLE = "N";
        public const string OPENING_PEG = "O";
        public const string MARKET_PEG = "P";
        public const string CANCEL_ON_SYSTEM_FAILURE = "Q";
        public const string PRIMARY_PEG = "R";
        public const string SUSPEND = "S";
        public const string CUSTOMER_DISPLAY_INSTRUCTION = "U";
        public const string NETTING = "V";
        public const string PEG_TO_VWAP = "W";
        public const string TRADE_ALONG = "X";
        public const string TRY_TO_STOP = "Y";
        public const string CANCEL_IF_NOT_BEST = "Z";
        public const string INTERMARKET_SWEEP = "f";
        public const string SINGLE_EXECUTION_REQUESTED_FOR_BLOCK_TRADE = "j";
        public const string EXTERNAL_ROUTING_ALLOWED = "g";
        public const string EXTERNAL_ROUTING_NOT_ALLOWED = "h";
        public const string IMBALANCE_ONLY = "i";
        public const string FIXED_PEG_TO_LOCAL_BEST_BID_OR_OFFER_AT_TIME_OF_ORDER = "T";
        public const string BEST_EXECUTION = "k";
    }


    /// <summary>
    /// ExecRefID Field
    /// </summary>/
    public sealed class ExecRefID : StringField
    {
        public ExecRefID()
            :base(Tags.ExecRefID) {}
        public ExecRefID(string val)
            :base(Tags.ExecRefID, val) {}

    }


    /// <summary>
    /// ExecTransType Field
    /// </summary>/
    public sealed class ExecTransType : CharField
    {
        public ExecTransType()
            :base(Tags.ExecTransType) {}
        public ExecTransType(char val)
            :base(Tags.ExecTransType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char CANCEL = '1';
        public const char CORRECT = '2';
        public const char STATUS = '3';
    }


    /// <summary>
    /// HandlInst Field
    /// </summary>/
    public sealed class HandlInst : CharField
    {
        public HandlInst()
            :base(Tags.HandlInst) {}
        public HandlInst(char val)
            :base(Tags.HandlInst, val) {}


        // Field Enumerations
        public const char AUTOMATED_EXECUTION_ORDER_PRIVATE_NO_BROKER_INTERVENTION = '1';
        public const char AUTOMATED_EXECUTION_ORDER_PUBLIC_BROKER_INTERVENTION_OK = '2';
        public const char MANUAL_ORDER_BEST_EXECUTION = '3';
    }


    /// <summary>
    /// IDSource Field
    /// </summary>/
    public sealed class IDSource : StringField
    {
        public IDSource()
            :base(Tags.IDSource) {}
        public IDSource(string val)
            :base(Tags.IDSource, val) {}


        // Field Enumerations
        public const string CUSIP = "1";
        public const string SEDOL = "2";
        public const string QUIK = "3";
        public const string ISIN_NUMBER = "4";
        public const string RIC_CODE = "5";
        public const string ISO_CURRENCY_CODE = "6";
        public const string ISO_COUNTRY_CODE = "7";
        public const string EXCHANGE_SYMBOL = "8";
        public const string CONSOLIDATED_TAPE_ASSOCIATION = "9";
    }


    /// <summary>
    /// IOIid Field
    /// </summary>/
    public sealed class IOIid : StringField
    {
        public IOIid()
            :base(Tags.IOIid) {}
        public IOIid(string val)
            :base(Tags.IOIid, val) {}

    }


    /// <summary>
    /// IOIOthSvc Field
    /// </summary>/
    public sealed class IOIOthSvc : CharField
    {
        public IOIOthSvc()
            :base(Tags.IOIOthSvc) {}
        public IOIOthSvc(char val)
            :base(Tags.IOIOthSvc, val) {}

    }


    /// <summary>
    /// IOIQltyInd Field
    /// </summary>/
    public sealed class IOIQltyInd : CharField
    {
        public IOIQltyInd()
            :base(Tags.IOIQltyInd) {}
        public IOIQltyInd(char val)
            :base(Tags.IOIQltyInd, val) {}


        // Field Enumerations
        public const char HIGH = 'H';
        public const char LOW = 'L';
        public const char MEDIUM = 'M';
    }


    /// <summary>
    /// IOIRefID Field
    /// </summary>/
    public sealed class IOIRefID : StringField
    {
        public IOIRefID()
            :base(Tags.IOIRefID) {}
        public IOIRefID(string val)
            :base(Tags.IOIRefID, val) {}

    }


    /// <summary>
    /// IOIShares Field
    /// </summary>/
    public sealed class IOIShares : StringField
    {
        public IOIShares()
            :base(Tags.IOIShares) {}
        public IOIShares(string val)
            :base(Tags.IOIShares, val) {}

    }


    /// <summary>
    /// IOITransType Field
    /// </summary>/
    public sealed class IOITransType : CharField
    {
        public IOITransType()
            :base(Tags.IOITransType) {}
        public IOITransType(char val)
            :base(Tags.IOITransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NEW = 'N';
        public const char REPLACE = 'R';
    }


    /// <summary>
    /// LastCapacity Field
    /// </summary>/
    public sealed class LastCapacity : CharField
    {
        public LastCapacity()
            :base(Tags.LastCapacity) {}
        public LastCapacity(char val)
            :base(Tags.LastCapacity, val) {}


        // Field Enumerations
        public const char AGENT = '1';
        public const char CROSS_AS_AGENT = '2';
        public const char CROSS_AS_PRINCIPAL = '3';
        public const char PRINCIPAL = '4';
    }


    /// <summary>
    /// LastMkt Field
    /// </summary>/
    public sealed class LastMkt : StringField
    {
        public LastMkt()
            :base(Tags.LastMkt) {}
        public LastMkt(string val)
            :base(Tags.LastMkt, val) {}

    }


    /// <summary>
    /// LastPx Field
    /// </summary>/
    public sealed class LastPx : DecimalField
    {
        public LastPx()
            :base(Tags.LastPx) {}
        public LastPx(Decimal val)
            :base(Tags.LastPx, val) {}

    }


    /// <summary>
    /// LastShares Field
    /// </summary>/
    public sealed class LastShares : DecimalField
    {
        public LastShares()
            :base(Tags.LastShares) {}
        public LastShares(Decimal val)
            :base(Tags.LastShares, val) {}

    }


    /// <summary>
    /// LinesOfText Field
    /// </summary>/
    public sealed class LinesOfText : IntField
    {
        public LinesOfText()
            :base(Tags.LinesOfText) {}
        public LinesOfText(int val)
            :base(Tags.LinesOfText, val) {}

    }


    /// <summary>
    /// MsgSeqNum Field
    /// </summary>/
    public sealed class MsgSeqNum : IntField
    {
        public MsgSeqNum()
            :base(Tags.MsgSeqNum) {}
        public MsgSeqNum(int val)
            :base(Tags.MsgSeqNum, val) {}

    }


    /// <summary>
    /// MsgType Field
    /// </summary>/
    public sealed class MsgType : StringField
    {
        public MsgType()
            :base(Tags.MsgType) {}
        public MsgType(string val)
            :base(Tags.MsgType, val) {}


        // Field Enumerations
        public const string HEARTBEAT = "0";
        public const string TEST_REQUEST = "1";
        public const string RESEND_REQUEST = "2";
        public const string REJECT = "3";
        public const string SEQUENCE_RESET = "4";
        public const string LOGOUT = "5";
        public const string INDICATION_OF_INTEREST = "6";
        public const string ADVERTISEMENT = "7";
        public const string EXECUTION_REPORT = "8";
        public const string ORDER_CANCEL_REJECT = "9";
        public const string QUOTE_STATUS_REQUEST = "a";
        public const string LOGON = "A";
        public const string DERIVATIVE_SECURITY_LIST = "AA";
        public const string NEW_ORDER_AB = "AB";
        public const string MULTILEG_ORDER_CANCEL_REPLACE = "AC";
        public const string TRADE_CAPTURE_REPORT_REQUEST = "AD";
        public const string TRADE_CAPTURE_REPORT = "AE";
        public const string ORDER_MASS_STATUS_REQUEST = "AF";
        public const string QUOTE_REQUEST_REJECT = "AG";
        public const string RFQ_REQUEST = "AH";
        public const string QUOTE_STATUS_REPORT = "AI";
        public const string QUOTE_RESPONSE = "AJ";
        public const string CONFIRMATION = "AK";
        public const string POSITION_MAINTENANCE_REQUEST = "AL";
        public const string POSITION_MAINTENANCE_REPORT = "AM";
        public const string REQUEST_FOR_POSITIONS = "AN";
        public const string REQUEST_FOR_POSITIONS_ACK = "AO";
        public const string POSITION_REPORT = "AP";
        public const string TRADE_CAPTURE_REPORT_REQUEST_ACK = "AQ";
        public const string TRADE_CAPTURE_REPORT_ACK = "AR";
        public const string ALLOCATION_REPORT = "AS";
        public const string ALLOCATION_REPORT_ACK = "AT";
        public const string CONFIRMATION_ACK = "AU";
        public const string SETTLEMENT_INSTRUCTION_REQUEST = "AV";
        public const string ASSIGNMENT_REPORT = "AW";
        public const string COLLATERAL_REQUEST = "AX";
        public const string COLLATERAL_ASSIGNMENT = "AY";
        public const string COLLATERAL_RESPONSE = "AZ";
        public const string NEWS = "B";
        public const string MASS_QUOTE_ACKNOWLEDGEMENT = "b";
        public const string COLLATERAL_REPORT = "BA";
        public const string COLLATERAL_INQUIRY = "BB";
        public const string NETWORK_COUNTERPARTY_SYSTEM_STATUS_REQUEST = "BC";
        public const string NETWORK_COUNTERPARTY_SYSTEM_STATUS_RESPONSE = "BD";
        public const string USER_REQUEST = "BE";
        public const string USER_RESPONSE = "BF";
        public const string COLLATERAL_INQUIRY_ACK = "BG";
        public const string CONFIRMATION_REQUEST = "BH";
        public const string EMAIL = "C";
        public const string SECURITY_DEFINITION_REQUEST = "c";
        public const string SECURITY_DEFINITION = "d";
        public const string NEW_ORDER_D = "D";
        public const string SECURITY_STATUS_REQUEST = "e";
        public const string NEW_ORDER_E = "E";
        public const string ORDER_CANCEL_REQUEST = "F";
        public const string SECURITY_STATUS = "f";
        public const string ORDER_CANCEL_REPLACE_REQUEST = "G";
        public const string TRADING_SESSION_STATUS_REQUEST = "g";
        public const string ORDER_STATUS_REQUEST = "H";
        public const string TRADING_SESSION_STATUS = "h";
        public const string MASS_QUOTE = "i";
        public const string BUSINESS_MESSAGE_REJECT = "j";
        public const string ALLOCATION_INSTRUCTION = "J";
        public const string BID_REQUEST = "k";
        public const string LIST_CANCEL_REQUEST = "K";
        public const string BID_RESPONSE = "l";
        public const string LIST_EXECUTE = "L";
        public const string LIST_STRIKE_PRICE = "m";
        public const string LIST_STATUS_REQUEST = "M";
        public const string XML_MESSAGE = "n";
        public const string LIST_STATUS = "N";
        public const string REGISTRATION_INSTRUCTIONS = "o";
        public const string REGISTRATION_INSTRUCTIONS_RESPONSE = "p";
        public const string ALLOCATION_INSTRUCTION_ACK = "P";
        public const string ORDER_MASS_CANCEL_REQUEST = "q";
        public const string DONT_KNOW_TRADE = "Q";
        public const string QUOTE_REQUEST = "R";
        public const string ORDER_MASS_CANCEL_REPORT = "r";
        public const string QUOTE = "S";
        public const string NEW_ORDER_s = "s";
        public const string SETTLEMENT_INSTRUCTIONS = "T";
        public const string CROSS_ORDER_CANCEL_REPLACE_REQUEST = "t";
        public const string CROSS_ORDER_CANCEL_REQUEST = "u";
        public const string MARKET_DATA_REQUEST = "V";
        public const string SECURITY_TYPE_REQUEST = "v";
        public const string SECURITY_TYPES = "w";
        public const string MARKET_DATA_W = "W";
        public const string SECURITY_LIST_REQUEST = "x";
        public const string MARKET_DATA_X = "X";
        public const string MARKET_DATA_REQUEST_REJECT = "Y";
        public const string SECURITY_LIST = "y";
        public const string QUOTE_CANCEL = "Z";
        public const string DERIVATIVE_SECURITY_LIST_REQUEST = "z";
        public const string CONTRARY_INTENTION_REPORT = "BO";
        public const string SECURITY_DEFINITION_UPDATE_REPORT = "BP";
        public const string SECURITY_LIST_UPDATE_REPORT = "BK";
        public const string ADJUSTED_POSITION_REPORT = "BL";
        public const string ALLOCATION_INSTRUCTION_ALERT = "BM";
        public const string EXECUTION_ACKNOWLEDGEMENT = "BN";
        public const string TRADING_SESSION_LIST = "BJ";
        public const string TRADING_SESSION_LIST_REQUEST = "BI";
    }


    /// <summary>
    /// NewSeqNo Field
    /// </summary>/
    public sealed class NewSeqNo : IntField
    {
        public NewSeqNo()
            :base(Tags.NewSeqNo) {}
        public NewSeqNo(int val)
            :base(Tags.NewSeqNo, val) {}

    }


    /// <summary>
    /// OrderID Field
    /// </summary>/
    public sealed class OrderID : StringField
    {
        public OrderID()
            :base(Tags.OrderID) {}
        public OrderID(string val)
            :base(Tags.OrderID, val) {}

    }


    /// <summary>
    /// OrderQty Field
    /// </summary>/
    public sealed class OrderQty : DecimalField
    {
        public OrderQty()
            :base(Tags.OrderQty) {}
        public OrderQty(Decimal val)
            :base(Tags.OrderQty, val) {}

    }


    /// <summary>
    /// OrdStatus Field
    /// </summary>/
    public sealed class OrdStatus : CharField
    {
        public OrdStatus()
            :base(Tags.OrdStatus) {}
        public OrdStatus(char val)
            :base(Tags.OrdStatus, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char PARTIALLY_FILLED = '1';
        public const char FILLED = '2';
        public const char DONE_FOR_DAY = '3';
        public const char CANCELED = '4';
        public const char PENDING_CANCEL = '6';
        public const char STOPPED = '7';
        public const char REJECTED = '8';
        public const char SUSPENDED = '9';
        public const char PENDING_NEW = 'A';
        public const char CALCULATED = 'B';
        public const char EXPIRED = 'C';
        public const char ACCEPTED_FOR_BIDDING = 'D';
        public const char PENDING_REPLACE = 'E';
        public const char REPLACED = '5';
    }


    /// <summary>
    /// OrdType Field
    /// </summary>/
    public sealed class OrdType : CharField
    {
        public OrdType()
            :base(Tags.OrdType) {}
        public OrdType(char val)
            :base(Tags.OrdType, val) {}


        // Field Enumerations
        public const char MARKET = '1';
        public const char LIMIT = '2';
        public const char STOP = '3';
        public const char STOP_LIMIT = '4';
        public const char MARKET_ON_CLOSE = '5';
        public const char WITH_OR_WITHOUT = '6';
        public const char LIMIT_OR_BETTER = '7';
        public const char LIMIT_WITH_OR_WITHOUT = '8';
        public const char ON_BASIS = '9';
        public const char ON_CLOSE = 'A';
        public const char LIMIT_ON_CLOSE = 'B';
        public const char FOREX_MARKET = 'C';
        public const char PREVIOUSLY_QUOTED = 'D';
        public const char PREVIOUSLY_INDICATED = 'E';
        public const char FOREX_LIMIT = 'F';
        public const char FOREX_SWAP = 'G';
        public const char FOREX_PREVIOUSLY_QUOTED = 'H';
        public const char FUNARI = 'I';
        public const char MARKET_IF_TOUCHED = 'J';
        public const char MARKET_WITH_LEFT_OVER_AS_LIMIT = 'K';
        public const char PREVIOUS_FUND_VALUATION_POINT = 'L';
        public const char NEXT_FUND_VALUATION_POINT = 'M';
        public const char PEGGED = 'P';
        public const char COUNTER_ORDER_SELECTION = 'Q';
    }


    /// <summary>
    /// OrigClOrdID Field
    /// </summary>/
    public sealed class OrigClOrdID : StringField
    {
        public OrigClOrdID()
            :base(Tags.OrigClOrdID) {}
        public OrigClOrdID(string val)
            :base(Tags.OrigClOrdID, val) {}

    }


    /// <summary>
    /// OrigTime Field
    /// </summary>/
    public sealed class OrigTime : DateTimeField
    {
        public OrigTime()
            :base(Tags.OrigTime) {}
        public OrigTime(DateTime val)
            :base(Tags.OrigTime, val) {}

    }


    /// <summary>
    /// PossDupFlag Field
    /// </summary>/
    public sealed class PossDupFlag : BooleanField
    {
        public PossDupFlag()
            :base(Tags.PossDupFlag) {}
        public PossDupFlag(Boolean val)
            :base(Tags.PossDupFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// Price Field
    /// </summary>/
    public sealed class Price : DecimalField
    {
        public Price()
            :base(Tags.Price) {}
        public Price(Decimal val)
            :base(Tags.Price, val) {}

    }


    /// <summary>
    /// RefSeqNum Field
    /// </summary>/
    public sealed class RefSeqNum : IntField
    {
        public RefSeqNum()
            :base(Tags.RefSeqNum) {}
        public RefSeqNum(int val)
            :base(Tags.RefSeqNum, val) {}

    }


    /// <summary>
    /// RelatdSym Field
    /// </summary>/
    public sealed class RelatdSym : StringField
    {
        public RelatdSym()
            :base(Tags.RelatdSym) {}
        public RelatdSym(string val)
            :base(Tags.RelatdSym, val) {}

    }


    /// <summary>
    /// Rule80A Field
    /// </summary>/
    public sealed class Rule80A : CharField
    {
        public Rule80A()
            :base(Tags.Rule80A) {}
        public Rule80A(char val)
            :base(Tags.Rule80A, val) {}


        // Field Enumerations
        public const char AGENCY_SINGLE_ORDER = 'A';
        public const char SHORT_EXEMPT_TRANSACTION_B = 'B';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_MEMBER_FIRM_ORG = 'C';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_MEMBER_FIRM_ORG = 'D';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_PRINCIPAL = 'E';
        public const char SHORT_EXEMPT_TRANSACTION_F = 'F';
        public const char SHORT_EXEMPT_TRANSACTION_H = 'H';
        public const char INDIVIDUAL_INVESTOR_SINGLE_ORDER = 'I';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_INDIVIDUAL_CUSTOMER = 'J';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_INDIVIDUAL_CUSTOMER = 'K';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_MEMBER_COMPETING_MARKET_MAKER_AFFLIATED_WITH_THE_FIRM_CLEARING_THE_TRADE = 'L';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_OTHER_MEMBER = 'M';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_OTHER_MEMBER = 'N';
        public const char PROPRIETARY_TRANSACTIONS_FOR_COMPETING_MARKET_MAKER_THAT_IS_AFFILIATED_WITH_THE_CLEARING_MEMBER = 'O';
        public const char PRINCIPAL = 'P';
        public const char TRANSACTIONS_FOR_THE_ACCOUNT_OF_A_NON_MEMBER_COMPTING_MARKET_MAKER = 'R';
        public const char SPECIALIST_TRADES = 'S';
        public const char TRANSACTIONS_FOR_THE_ACCOUNT_OF_AN_UNAFFILIATED_MEMBERS_COMPETING_MARKET_MAKER = 'T';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_OTHER_AGENCY = 'U';
        public const char ALL_OTHER_ORDERS_AS_AGENT_FOR_OTHER_MEMBER = 'W';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_MEMBER_COMPETING_MARKET_MAKER_NOT_AFFILIATED_WITH_THE_FIRM_CLEARING_THE_TRADE = 'X';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_OTHER_AGENCY = 'Y';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_NON_MEMBER_COMPETING_MARKET_MAKER = 'Z';
    }


    /// <summary>
    /// SecurityID Field
    /// </summary>/
    public sealed class SecurityID : StringField
    {
        public SecurityID()
            :base(Tags.SecurityID) {}
        public SecurityID(string val)
            :base(Tags.SecurityID, val) {}

    }


    /// <summary>
    /// SenderCompID Field
    /// </summary>/
    public sealed class SenderCompID : StringField
    {
        public SenderCompID()
            :base(Tags.SenderCompID) {}
        public SenderCompID(string val)
            :base(Tags.SenderCompID, val) {}

    }


    /// <summary>
    /// SenderSubID Field
    /// </summary>/
    public sealed class SenderSubID : StringField
    {
        public SenderSubID()
            :base(Tags.SenderSubID) {}
        public SenderSubID(string val)
            :base(Tags.SenderSubID, val) {}

    }


    /// <summary>
    /// SendingTime Field
    /// </summary>/
    public sealed class SendingTime : DateTimeField
    {
        public SendingTime()
            :base(Tags.SendingTime) {}
        public SendingTime(DateTime val)
            :base(Tags.SendingTime, val) {}

    }


    /// <summary>
    /// Shares Field
    /// </summary>/
    public sealed class Shares : DecimalField
    {
        public Shares()
            :base(Tags.Shares) {}
        public Shares(Decimal val)
            :base(Tags.Shares, val) {}

    }


    /// <summary>
    /// Side Field
    /// </summary>/
    public sealed class Side : CharField
    {
        public Side()
            :base(Tags.Side) {}
        public Side(char val)
            :base(Tags.Side, val) {}


        // Field Enumerations
        public const char BUY = '1';
        public const char SELL = '2';
        public const char BUY_MINUS = '3';
        public const char SELL_PLUS = '4';
        public const char SELL_SHORT = '5';
        public const char SELL_SHORT_EXEMPT = '6';
        public const char UNDISCLOSED = '7';
        public const char CROSS = '8';
        public const char CROSS_SHORT = '9';
        public const char CROSS_SHORT_EXXMPT = 'A';
        public const char AS_DEFINED = 'B';
        public const char OPPOSITE = 'C';
        public const char SUBSCRIBE = 'D';
        public const char REDEEM = 'E';
        public const char LEND = 'F';
        public const char BORROW = 'G';
    }


    /// <summary>
    /// Symbol Field
    /// </summary>/
    public sealed class Symbol : StringField
    {
        public Symbol()
            :base(Tags.Symbol) {}
        public Symbol(string val)
            :base(Tags.Symbol, val) {}

    }


    /// <summary>
    /// TargetCompID Field
    /// </summary>/
    public sealed class TargetCompID : StringField
    {
        public TargetCompID()
            :base(Tags.TargetCompID) {}
        public TargetCompID(string val)
            :base(Tags.TargetCompID, val) {}

    }


    /// <summary>
    /// TargetSubID Field
    /// </summary>/
    public sealed class TargetSubID : StringField
    {
        public TargetSubID()
            :base(Tags.TargetSubID) {}
        public TargetSubID(string val)
            :base(Tags.TargetSubID, val) {}

    }


    /// <summary>
    /// Text Field
    /// </summary>/
    public sealed class Text : StringField
    {
        public Text()
            :base(Tags.Text) {}
        public Text(string val)
            :base(Tags.Text, val) {}

    }


    /// <summary>
    /// TimeInForce Field
    /// </summary>/
    public sealed class TimeInForce : CharField
    {
        public TimeInForce()
            :base(Tags.TimeInForce) {}
        public TimeInForce(char val)
            :base(Tags.TimeInForce, val) {}


        // Field Enumerations
        public const char DAY = '0';
        public const char GOOD_TILL_CANCEL = '1';
        public const char AT_THE_OPENING = '2';
        public const char IMMEDIATE_OR_CANCEL = '3';
        public const char FILL_OR_KILL = '4';
        public const char GOOD_TILL_CROSSING = '5';
        public const char GOOD_TILL_DATE = '6';
        public const char AT_THE_CLOSE = '7';
    }


    /// <summary>
    /// TransactTime Field
    /// </summary>/
    public sealed class TransactTime : DateTimeField
    {
        public TransactTime()
            :base(Tags.TransactTime) {}
        public TransactTime(DateTime val)
            :base(Tags.TransactTime, val) {}

    }


    /// <summary>
    /// Urgency Field
    /// </summary>/
    public sealed class Urgency : CharField
    {
        public Urgency()
            :base(Tags.Urgency) {}
        public Urgency(char val)
            :base(Tags.Urgency, val) {}


        // Field Enumerations
        public const char NORMAL = '0';
        public const char FLASH = '1';
        public const char BACKGROUND = '2';
    }


    /// <summary>
    /// ValidUntilTime Field
    /// </summary>/
    public sealed class ValidUntilTime : DateTimeField
    {
        public ValidUntilTime()
            :base(Tags.ValidUntilTime) {}
        public ValidUntilTime(DateTime val)
            :base(Tags.ValidUntilTime, val) {}

    }


    /// <summary>
    /// SettlmntTyp Field
    /// </summary>/
    public sealed class SettlmntTyp : CharField
    {
        public SettlmntTyp()
            :base(Tags.SettlmntTyp) {}
        public SettlmntTyp(char val)
            :base(Tags.SettlmntTyp, val) {}


        // Field Enumerations
        public const char REGULAR = '0';
        public const char CASH = '1';
        public const char NEXT_DAY = '2';
        public const char T_PLUS_2 = '3';
        public const char T_PLUS_3 = '4';
        public const char T_PLUS_4 = '5';
        public const char FUTURE = '6';
        public const char WHEN_AND_IF_ISSUED = '7';
        public const char SELLERS_OPTION = '8';
        public const char T_PLUS_5 = '9';
        public const char T_PLUS_1 = 'A';
    }


    /// <summary>
    /// FutSettDate Field
    /// </summary>/
    public sealed class FutSettDate : StringField
    {
        public FutSettDate()
            :base(Tags.FutSettDate) {}
        public FutSettDate(string val)
            :base(Tags.FutSettDate, val) {}

    }


    /// <summary>
    /// SymbolSfx Field
    /// </summary>/
    public sealed class SymbolSfx : StringField
    {
        public SymbolSfx()
            :base(Tags.SymbolSfx) {}
        public SymbolSfx(string val)
            :base(Tags.SymbolSfx, val) {}


        // Field Enumerations
        public const string EUCP_WITH_LUMP_SUM_INTEREST_RATHER_THAN_DISCOUNT_PRICE = "CD";
        public const string WHEN_ISSUED_FOR_A_SECURITY_TO_BE_REISSUED_UNDER_AN_OLD_CUSIP_OR_ISIN = "WI";
    }


    /// <summary>
    /// ListID Field
    /// </summary>/
    public sealed class ListID : StringField
    {
        public ListID()
            :base(Tags.ListID) {}
        public ListID(string val)
            :base(Tags.ListID, val) {}

    }


    /// <summary>
    /// ListSeqNo Field
    /// </summary>/
    public sealed class ListSeqNo : IntField
    {
        public ListSeqNo()
            :base(Tags.ListSeqNo) {}
        public ListSeqNo(int val)
            :base(Tags.ListSeqNo, val) {}

    }


    /// <summary>
    /// ListNoOrds Field
    /// </summary>/
    public sealed class ListNoOrds : IntField
    {
        public ListNoOrds()
            :base(Tags.ListNoOrds) {}
        public ListNoOrds(int val)
            :base(Tags.ListNoOrds, val) {}

    }


    /// <summary>
    /// ListExecInst Field
    /// </summary>/
    public sealed class ListExecInst : StringField
    {
        public ListExecInst()
            :base(Tags.ListExecInst) {}
        public ListExecInst(string val)
            :base(Tags.ListExecInst, val) {}

    }


    /// <summary>
    /// AllocID Field
    /// </summary>/
    public sealed class AllocID : StringField
    {
        public AllocID()
            :base(Tags.AllocID) {}
        public AllocID(string val)
            :base(Tags.AllocID, val) {}

    }


    /// <summary>
    /// AllocTransType Field
    /// </summary>/
    public sealed class AllocTransType : CharField
    {
        public AllocTransType()
            :base(Tags.AllocTransType) {}
        public AllocTransType(char val)
            :base(Tags.AllocTransType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char REPLACE = '1';
        public const char CANCEL = '2';
        public const char PRELIMINARY = '3';
        public const char CALCULATED = '4';
        public const char CALCULATED_WITHOUT_PRELIMINARY = '5';
        public const char REVERSAL = '6';
    }


    /// <summary>
    /// RefAllocID Field
    /// </summary>/
    public sealed class RefAllocID : StringField
    {
        public RefAllocID()
            :base(Tags.RefAllocID) {}
        public RefAllocID(string val)
            :base(Tags.RefAllocID, val) {}

    }


    /// <summary>
    /// NoOrders Field
    /// </summary>/
    public sealed class NoOrders : IntField
    {
        public NoOrders()
            :base(Tags.NoOrders) {}
        public NoOrders(int val)
            :base(Tags.NoOrders, val) {}

    }


    /// <summary>
    /// AvgPrxPrecision Field
    /// </summary>/
    public sealed class AvgPrxPrecision : IntField
    {
        public AvgPrxPrecision()
            :base(Tags.AvgPrxPrecision) {}
        public AvgPrxPrecision(int val)
            :base(Tags.AvgPrxPrecision, val) {}

    }


    /// <summary>
    /// TradeDate Field
    /// </summary>/
    public sealed class TradeDate : StringField
    {
        public TradeDate()
            :base(Tags.TradeDate) {}
        public TradeDate(string val)
            :base(Tags.TradeDate, val) {}

    }


    /// <summary>
    /// ExecBroker Field
    /// </summary>/
    public sealed class ExecBroker : StringField
    {
        public ExecBroker()
            :base(Tags.ExecBroker) {}
        public ExecBroker(string val)
            :base(Tags.ExecBroker, val) {}

    }


    /// <summary>
    /// OpenClose Field
    /// </summary>/
    public sealed class OpenClose : CharField
    {
        public OpenClose()
            :base(Tags.OpenClose) {}
        public OpenClose(char val)
            :base(Tags.OpenClose, val) {}


        // Field Enumerations
        public const char OPEN = 'O';
        public const char CLOSE = 'C';
    }


    /// <summary>
    /// NoAllocs Field
    /// </summary>/
    public sealed class NoAllocs : IntField
    {
        public NoAllocs()
            :base(Tags.NoAllocs) {}
        public NoAllocs(int val)
            :base(Tags.NoAllocs, val) {}

    }


    /// <summary>
    /// AllocAccount Field
    /// </summary>/
    public sealed class AllocAccount : StringField
    {
        public AllocAccount()
            :base(Tags.AllocAccount) {}
        public AllocAccount(string val)
            :base(Tags.AllocAccount, val) {}

    }


    /// <summary>
    /// AllocShares Field
    /// </summary>/
    public sealed class AllocShares : DecimalField
    {
        public AllocShares()
            :base(Tags.AllocShares) {}
        public AllocShares(Decimal val)
            :base(Tags.AllocShares, val) {}

    }


    /// <summary>
    /// ProcessCode Field
    /// </summary>/
    public sealed class ProcessCode : CharField
    {
        public ProcessCode()
            :base(Tags.ProcessCode) {}
        public ProcessCode(char val)
            :base(Tags.ProcessCode, val) {}


        // Field Enumerations
        public const char REGULAR = '0';
        public const char SOFT_DOLLAR = '1';
        public const char STEP_IN = '2';
        public const char STEP_OUT = '3';
        public const char SOFT_DOLLAR_STEP_IN = '4';
        public const char SOFT_DOLLAR_STEP_OUT = '5';
        public const char PLAN_SPONSOR = '6';
    }


    /// <summary>
    /// NoRpts Field
    /// </summary>/
    public sealed class NoRpts : IntField
    {
        public NoRpts()
            :base(Tags.NoRpts) {}
        public NoRpts(int val)
            :base(Tags.NoRpts, val) {}

    }


    /// <summary>
    /// RptSeq Field
    /// </summary>/
    public sealed class RptSeq : IntField
    {
        public RptSeq()
            :base(Tags.RptSeq) {}
        public RptSeq(int val)
            :base(Tags.RptSeq, val) {}

    }


    /// <summary>
    /// CxlQty Field
    /// </summary>/
    public sealed class CxlQty : DecimalField
    {
        public CxlQty()
            :base(Tags.CxlQty) {}
        public CxlQty(Decimal val)
            :base(Tags.CxlQty, val) {}

    }


    /// <summary>
    /// NoDlvyInst Field
    /// </summary>/
    public sealed class NoDlvyInst : IntField
    {
        public NoDlvyInst()
            :base(Tags.NoDlvyInst) {}
        public NoDlvyInst(int val)
            :base(Tags.NoDlvyInst, val) {}

    }


    /// <summary>
    /// DlvyInst Field
    /// </summary>/
    public sealed class DlvyInst : StringField
    {
        public DlvyInst()
            :base(Tags.DlvyInst) {}
        public DlvyInst(string val)
            :base(Tags.DlvyInst, val) {}

    }


    /// <summary>
    /// AllocStatus Field
    /// </summary>/
    public sealed class AllocStatus : IntField
    {
        public AllocStatus()
            :base(Tags.AllocStatus) {}
        public AllocStatus(int val)
            :base(Tags.AllocStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int BLOCK_LEVEL_REJECT = 1;
        public const int ACCOUNT_LEVEL_REJECT = 2;
        public const int RECEIVED = 3;
        public const int INCOMPLETE = 4;
        public const int REJECTED_BY_INTERMEDIARY = 5;
        public const int ALLOCATION_PENDING = 6;
        public const int REVERSED = 7;
    }


    /// <summary>
    /// AllocRejCode Field
    /// </summary>/
    public sealed class AllocRejCode : IntField
    {
        public AllocRejCode()
            :base(Tags.AllocRejCode) {}
        public AllocRejCode(int val)
            :base(Tags.AllocRejCode, val) {}


        // Field Enumerations
        public const int UNKNOWN_ACCOUNT = 0;
        public const int INCORRECT_QUANTITY = 1;
        public const int UNKNOWN_OR_STALE_EXECID = 10;
        public const int MISMATCHED_DATA = 11;
        public const int UNKNOWN_CLORDID = 12;
        public const int WAREHOUSE_REQUEST_REJECTED = 13;
        public const int INCORRECT_AVERAGEG_PRICE = 2;
        public const int UNKNOWN_EXECUTING_BROKER_MNEMONIC = 3;
        public const int COMMISSION_DIFFERENCE = 4;
        public const int UNKNOWN_ORDERID = 5;
        public const int UNKNOWN_LISTID = 6;
        public const int OTHER = 7;
        public const int INCORRECT_ALLOCATED_QUANTITY = 8;
        public const int CALCULATION_DIFFERENCE = 9;
    }


    /// <summary>
    /// Signature Field
    /// </summary>/
    public sealed class Signature : StringField
    {
        public Signature()
            :base(Tags.Signature) {}
        public Signature(string val)
            :base(Tags.Signature, val) {}

    }


    /// <summary>
    /// SecureDataLen Field
    /// </summary>/
    public sealed class SecureDataLen : DecimalField
    {
        public SecureDataLen()
            :base(Tags.SecureDataLen) {}
        public SecureDataLen(Decimal val)
            :base(Tags.SecureDataLen, val) {}

    }


    /// <summary>
    /// SecureData Field
    /// </summary>/
    public sealed class SecureData : StringField
    {
        public SecureData()
            :base(Tags.SecureData) {}
        public SecureData(string val)
            :base(Tags.SecureData, val) {}

    }


    /// <summary>
    /// BrokerOfCredit Field
    /// </summary>/
    public sealed class BrokerOfCredit : StringField
    {
        public BrokerOfCredit()
            :base(Tags.BrokerOfCredit) {}
        public BrokerOfCredit(string val)
            :base(Tags.BrokerOfCredit, val) {}

    }


    /// <summary>
    /// SignatureLength Field
    /// </summary>/
    public sealed class SignatureLength : DecimalField
    {
        public SignatureLength()
            :base(Tags.SignatureLength) {}
        public SignatureLength(Decimal val)
            :base(Tags.SignatureLength, val) {}

    }


    /// <summary>
    /// EmailType Field
    /// </summary>/
    public sealed class EmailType : CharField
    {
        public EmailType()
            :base(Tags.EmailType) {}
        public EmailType(char val)
            :base(Tags.EmailType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char REPLY = '1';
        public const char ADMIN_REPLY = '2';
    }


    /// <summary>
    /// RawDataLength Field
    /// </summary>/
    public sealed class RawDataLength : DecimalField
    {
        public RawDataLength()
            :base(Tags.RawDataLength) {}
        public RawDataLength(Decimal val)
            :base(Tags.RawDataLength, val) {}

    }


    /// <summary>
    /// RawData Field
    /// </summary>/
    public sealed class RawData : StringField
    {
        public RawData()
            :base(Tags.RawData) {}
        public RawData(string val)
            :base(Tags.RawData, val) {}

    }


    /// <summary>
    /// PossResend Field
    /// </summary>/
    public sealed class PossResend : BooleanField
    {
        public PossResend()
            :base(Tags.PossResend) {}
        public PossResend(Boolean val)
            :base(Tags.PossResend, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// EncryptMethod Field
    /// </summary>/
    public sealed class EncryptMethod : IntField
    {
        public EncryptMethod()
            :base(Tags.EncryptMethod) {}
        public EncryptMethod(int val)
            :base(Tags.EncryptMethod, val) {}


        // Field Enumerations
        public const int NONE = 0;
        public const int PKCS_1 = 1;
        public const int DES = 2;
        public const int PKCS_3 = 3;
        public const int PGP_4 = 4;
        public const int PGP_5 = 5;
        public const int PEM = 6;
    }


    /// <summary>
    /// StopPx Field
    /// </summary>/
    public sealed class StopPx : DecimalField
    {
        public StopPx()
            :base(Tags.StopPx) {}
        public StopPx(Decimal val)
            :base(Tags.StopPx, val) {}

    }


    /// <summary>
    /// ExDestination Field
    /// </summary>/
    public sealed class ExDestination : StringField
    {
        public ExDestination()
            :base(Tags.ExDestination) {}
        public ExDestination(string val)
            :base(Tags.ExDestination, val) {}

    }


    /// <summary>
    /// CxlRejReason Field
    /// </summary>/
    public sealed class CxlRejReason : IntField
    {
        public CxlRejReason()
            :base(Tags.CxlRejReason) {}
        public CxlRejReason(int val)
            :base(Tags.CxlRejReason, val) {}


        // Field Enumerations
        public const int TOO_LATE_TO_CANCEL = 0;
        public const int UNKNOWN_ORDER = 1;
        public const int BROKER = 2;
        public const int ORDER_ALREADY_IN_PENDING_CANCEL_OR_PENDING_REPLACE_STATUS = 3;
        public const int UNABLE_TO_PROCESS_ORDER_MASS_CANCEL_REQUEST = 4;
        public const int ORIGORDMODTIME = 5;
        public const int DUPLICATE_CLORDID = 6;
        public const int OTHER = 99;
        public const int INVALID_PRICE_INCREMENT = 18;
    }


    /// <summary>
    /// OrdRejReason Field
    /// </summary>/
    public sealed class OrdRejReason : IntField
    {
        public OrdRejReason()
            :base(Tags.OrdRejReason) {}
        public OrdRejReason(int val)
            :base(Tags.OrdRejReason, val) {}


        // Field Enumerations
        public const int BROKER = 0;
        public const int UNKNOWN_SYMBOL = 1;
        public const int INVALID_INVESTOR_ID = 10;
        public const int UNSUPPORTED_ORDER_CHARACTERISTIC = 11;
        public const int SURVEILLENCE_OPTION = 12;
        public const int INCORRECT_QUANTITY = 13;
        public const int INCORRECT_ALLOCATED_QUANTITY = 14;
        public const int UNKNOWN_ACCOUNT = 15;
        public const int EXCHANGE_CLOSED = 2;
        public const int ORDER_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_ORDER = 5;
        public const int DUPLICATE_ORDER = 6;
        public const int DUPLICATE_OF_A_VERBALLY_COMMUNICATED_ORDER = 7;
        public const int STALE_ORDER = 8;
        public const int TRADE_ALONG_REQUIRED = 9;
        public const int OTHER = 99;
        public const int INVALID_PRICE_INCREMENT = 18;
    }


    /// <summary>
    /// IOIQualifier Field
    /// </summary>/
    public sealed class IOIQualifier : CharField
    {
        public IOIQualifier()
            :base(Tags.IOIQualifier) {}
        public IOIQualifier(char val)
            :base(Tags.IOIQualifier, val) {}


        // Field Enumerations
        public const char ALL_OR_NONE = 'A';
        public const char MARKET_ON_CLOSE = 'B';
        public const char AT_THE_CLOSE = 'C';
        public const char VWAP = 'D';
        public const char IN_TOUCH_WITH = 'I';
        public const char LIMIT = 'L';
        public const char MORE_BEHIND = 'M';
        public const char AT_THE_OPEN = 'O';
        public const char TAKING_A_POSITION = 'P';
        public const char AT_THE_MARKET = 'Q';
        public const char READY_TO_TRADE = 'R';
        public const char PORTFOLIO_SHOWN = 'S';
        public const char THROUGH_THE_DAY = 'T';
        public const char VERSUS = 'V';
        public const char INDIDCATION = 'W';
        public const char CROSSING_OPPORTUNITY = 'X';
        public const char AT_THE_MIDPOINT = 'Y';
        public const char PRE_OPEN = 'Z';
    }


    /// <summary>
    /// WaveNo Field
    /// </summary>/
    public sealed class WaveNo : StringField
    {
        public WaveNo()
            :base(Tags.WaveNo) {}
        public WaveNo(string val)
            :base(Tags.WaveNo, val) {}

    }


    /// <summary>
    /// Issuer Field
    /// </summary>/
    public sealed class Issuer : StringField
    {
        public Issuer()
            :base(Tags.Issuer) {}
        public Issuer(string val)
            :base(Tags.Issuer, val) {}

    }


    /// <summary>
    /// SecurityDesc Field
    /// </summary>/
    public sealed class SecurityDesc : StringField
    {
        public SecurityDesc()
            :base(Tags.SecurityDesc) {}
        public SecurityDesc(string val)
            :base(Tags.SecurityDesc, val) {}

    }


    /// <summary>
    /// HeartBtInt Field
    /// </summary>/
    public sealed class HeartBtInt : IntField
    {
        public HeartBtInt()
            :base(Tags.HeartBtInt) {}
        public HeartBtInt(int val)
            :base(Tags.HeartBtInt, val) {}

    }


    /// <summary>
    /// ClientID Field
    /// </summary>/
    public sealed class ClientID : StringField
    {
        public ClientID()
            :base(Tags.ClientID) {}
        public ClientID(string val)
            :base(Tags.ClientID, val) {}

    }


    /// <summary>
    /// MinQty Field
    /// </summary>/
    public sealed class MinQty : DecimalField
    {
        public MinQty()
            :base(Tags.MinQty) {}
        public MinQty(Decimal val)
            :base(Tags.MinQty, val) {}

    }


    /// <summary>
    /// MaxFloor Field
    /// </summary>/
    public sealed class MaxFloor : DecimalField
    {
        public MaxFloor()
            :base(Tags.MaxFloor) {}
        public MaxFloor(Decimal val)
            :base(Tags.MaxFloor, val) {}

    }


    /// <summary>
    /// TestReqID Field
    /// </summary>/
    public sealed class TestReqID : StringField
    {
        public TestReqID()
            :base(Tags.TestReqID) {}
        public TestReqID(string val)
            :base(Tags.TestReqID, val) {}

    }


    /// <summary>
    /// ReportToExch Field
    /// </summary>/
    public sealed class ReportToExch : BooleanField
    {
        public ReportToExch()
            :base(Tags.ReportToExch) {}
        public ReportToExch(Boolean val)
            :base(Tags.ReportToExch, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// LocateReqd Field
    /// </summary>/
    public sealed class LocateReqd : BooleanField
    {
        public LocateReqd()
            :base(Tags.LocateReqd) {}
        public LocateReqd(Boolean val)
            :base(Tags.LocateReqd, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// OnBehalfOfCompID Field
    /// </summary>/
    public sealed class OnBehalfOfCompID : StringField
    {
        public OnBehalfOfCompID()
            :base(Tags.OnBehalfOfCompID) {}
        public OnBehalfOfCompID(string val)
            :base(Tags.OnBehalfOfCompID, val) {}

    }


    /// <summary>
    /// OnBehalfOfSubID Field
    /// </summary>/
    public sealed class OnBehalfOfSubID : StringField
    {
        public OnBehalfOfSubID()
            :base(Tags.OnBehalfOfSubID) {}
        public OnBehalfOfSubID(string val)
            :base(Tags.OnBehalfOfSubID, val) {}

    }


    /// <summary>
    /// QuoteID Field
    /// </summary>/
    public sealed class QuoteID : StringField
    {
        public QuoteID()
            :base(Tags.QuoteID) {}
        public QuoteID(string val)
            :base(Tags.QuoteID, val) {}

    }


    /// <summary>
    /// NetMoney Field
    /// </summary>/
    public sealed class NetMoney : DecimalField
    {
        public NetMoney()
            :base(Tags.NetMoney) {}
        public NetMoney(Decimal val)
            :base(Tags.NetMoney, val) {}

    }


    /// <summary>
    /// SettlCurrAmt Field
    /// </summary>/
    public sealed class SettlCurrAmt : DecimalField
    {
        public SettlCurrAmt()
            :base(Tags.SettlCurrAmt) {}
        public SettlCurrAmt(Decimal val)
            :base(Tags.SettlCurrAmt, val) {}

    }


    /// <summary>
    /// SettlCurrency Field
    /// </summary>/
    public sealed class SettlCurrency : DecimalField
    {
        public SettlCurrency()
            :base(Tags.SettlCurrency) {}
        public SettlCurrency(Decimal val)
            :base(Tags.SettlCurrency, val) {}

    }


    /// <summary>
    /// ForexReq Field
    /// </summary>/
    public sealed class ForexReq : BooleanField
    {
        public ForexReq()
            :base(Tags.ForexReq) {}
        public ForexReq(Boolean val)
            :base(Tags.ForexReq, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// OrigSendingTime Field
    /// </summary>/
    public sealed class OrigSendingTime : DateTimeField
    {
        public OrigSendingTime()
            :base(Tags.OrigSendingTime) {}
        public OrigSendingTime(DateTime val)
            :base(Tags.OrigSendingTime, val) {}

    }


    /// <summary>
    /// GapFillFlag Field
    /// </summary>/
    public sealed class GapFillFlag : BooleanField
    {
        public GapFillFlag()
            :base(Tags.GapFillFlag) {}
        public GapFillFlag(Boolean val)
            :base(Tags.GapFillFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// NoExecs Field
    /// </summary>/
    public sealed class NoExecs : IntField
    {
        public NoExecs()
            :base(Tags.NoExecs) {}
        public NoExecs(int val)
            :base(Tags.NoExecs, val) {}

    }


    /// <summary>
    /// CxlType Field
    /// </summary>/
    public sealed class CxlType : CharField
    {
        public CxlType()
            :base(Tags.CxlType) {}
        public CxlType(char val)
            :base(Tags.CxlType, val) {}

    }


    /// <summary>
    /// ExpireTime Field
    /// </summary>/
    public sealed class ExpireTime : DateTimeField
    {
        public ExpireTime()
            :base(Tags.ExpireTime) {}
        public ExpireTime(DateTime val)
            :base(Tags.ExpireTime, val) {}

    }


    /// <summary>
    /// DKReason Field
    /// </summary>/
    public sealed class DKReason : CharField
    {
        public DKReason()
            :base(Tags.DKReason) {}
        public DKReason(char val)
            :base(Tags.DKReason, val) {}


        // Field Enumerations
        public const char UNKNOWN_SYMBOL = 'A';
        public const char WRONG_SIDE = 'B';
        public const char QUANTITY_EXCEEDS_ORDER = 'C';
        public const char NO_MATCHING_ORDER = 'D';
        public const char PRICE_EXCEEDS_LIMIT = 'E';
        public const char CALCULATION_DIFFERENCE = 'F';
        public const char OTHER = 'Z';
    }


    /// <summary>
    /// DeliverToCompID Field
    /// </summary>/
    public sealed class DeliverToCompID : StringField
    {
        public DeliverToCompID()
            :base(Tags.DeliverToCompID) {}
        public DeliverToCompID(string val)
            :base(Tags.DeliverToCompID, val) {}

    }


    /// <summary>
    /// DeliverToSubID Field
    /// </summary>/
    public sealed class DeliverToSubID : StringField
    {
        public DeliverToSubID()
            :base(Tags.DeliverToSubID) {}
        public DeliverToSubID(string val)
            :base(Tags.DeliverToSubID, val) {}

    }


    /// <summary>
    /// IOINaturalFlag Field
    /// </summary>/
    public sealed class IOINaturalFlag : BooleanField
    {
        public IOINaturalFlag()
            :base(Tags.IOINaturalFlag) {}
        public IOINaturalFlag(Boolean val)
            :base(Tags.IOINaturalFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// QuoteReqID Field
    /// </summary>/
    public sealed class QuoteReqID : StringField
    {
        public QuoteReqID()
            :base(Tags.QuoteReqID) {}
        public QuoteReqID(string val)
            :base(Tags.QuoteReqID, val) {}

    }


    /// <summary>
    /// BidPx Field
    /// </summary>/
    public sealed class BidPx : DecimalField
    {
        public BidPx()
            :base(Tags.BidPx) {}
        public BidPx(Decimal val)
            :base(Tags.BidPx, val) {}

    }


    /// <summary>
    /// OfferPx Field
    /// </summary>/
    public sealed class OfferPx : DecimalField
    {
        public OfferPx()
            :base(Tags.OfferPx) {}
        public OfferPx(Decimal val)
            :base(Tags.OfferPx, val) {}

    }


    /// <summary>
    /// BidSize Field
    /// </summary>/
    public sealed class BidSize : DecimalField
    {
        public BidSize()
            :base(Tags.BidSize) {}
        public BidSize(Decimal val)
            :base(Tags.BidSize, val) {}

    }


    /// <summary>
    /// OfferSize Field
    /// </summary>/
    public sealed class OfferSize : DecimalField
    {
        public OfferSize()
            :base(Tags.OfferSize) {}
        public OfferSize(Decimal val)
            :base(Tags.OfferSize, val) {}

    }


    /// <summary>
    /// NoMiscFees Field
    /// </summary>/
    public sealed class NoMiscFees : IntField
    {
        public NoMiscFees()
            :base(Tags.NoMiscFees) {}
        public NoMiscFees(int val)
            :base(Tags.NoMiscFees, val) {}

    }


    /// <summary>
    /// MiscFeeAmt Field
    /// </summary>/
    public sealed class MiscFeeAmt : DecimalField
    {
        public MiscFeeAmt()
            :base(Tags.MiscFeeAmt) {}
        public MiscFeeAmt(Decimal val)
            :base(Tags.MiscFeeAmt, val) {}

    }


    /// <summary>
    /// MiscFeeCurr Field
    /// </summary>/
    public sealed class MiscFeeCurr : DecimalField
    {
        public MiscFeeCurr()
            :base(Tags.MiscFeeCurr) {}
        public MiscFeeCurr(Decimal val)
            :base(Tags.MiscFeeCurr, val) {}

    }


    /// <summary>
    /// MiscFeeType Field
    /// </summary>/
    public sealed class MiscFeeType : StringField
    {
        public MiscFeeType()
            :base(Tags.MiscFeeType) {}
        public MiscFeeType(string val)
            :base(Tags.MiscFeeType, val) {}


        // Field Enumerations
        public const string REGULATORY = "1";
        public const string PER_TRANSACTION = "10";
        public const string CONVERSION = "11";
        public const string AGENT = "12";
        public const string TAX = "2";
        public const string LOCAL_COMMISSION = "3";
        public const string EXCHANGE_FEES = "4";
        public const string STAMP = "5";
        public const string LEVY = "6";
        public const string OTHER = "7";
        public const string MARKUP = "8";
        public const string CONSUMPTION_TAX = "9";
        public const string TRANSFER_FEE = "13";
        public const string SECURITY_LENDING = "14";
    }


    /// <summary>
    /// PrevClosePx Field
    /// </summary>/
    public sealed class PrevClosePx : DecimalField
    {
        public PrevClosePx()
            :base(Tags.PrevClosePx) {}
        public PrevClosePx(Decimal val)
            :base(Tags.PrevClosePx, val) {}

    }


    /// <summary>
    /// ResetSeqNumFlag Field
    /// </summary>/
    public sealed class ResetSeqNumFlag : BooleanField
    {
        public ResetSeqNumFlag()
            :base(Tags.ResetSeqNumFlag) {}
        public ResetSeqNumFlag(Boolean val)
            :base(Tags.ResetSeqNumFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// SenderLocationID Field
    /// </summary>/
    public sealed class SenderLocationID : StringField
    {
        public SenderLocationID()
            :base(Tags.SenderLocationID) {}
        public SenderLocationID(string val)
            :base(Tags.SenderLocationID, val) {}

    }


    /// <summary>
    /// TargetLocationID Field
    /// </summary>/
    public sealed class TargetLocationID : StringField
    {
        public TargetLocationID()
            :base(Tags.TargetLocationID) {}
        public TargetLocationID(string val)
            :base(Tags.TargetLocationID, val) {}

    }


    /// <summary>
    /// OnBehalfOfLocationID Field
    /// </summary>/
    public sealed class OnBehalfOfLocationID : StringField
    {
        public OnBehalfOfLocationID()
            :base(Tags.OnBehalfOfLocationID) {}
        public OnBehalfOfLocationID(string val)
            :base(Tags.OnBehalfOfLocationID, val) {}

    }


    /// <summary>
    /// DeliverToLocationID Field
    /// </summary>/
    public sealed class DeliverToLocationID : StringField
    {
        public DeliverToLocationID()
            :base(Tags.DeliverToLocationID) {}
        public DeliverToLocationID(string val)
            :base(Tags.DeliverToLocationID, val) {}

    }


    /// <summary>
    /// NoRelatedSym Field
    /// </summary>/
    public sealed class NoRelatedSym : IntField
    {
        public NoRelatedSym()
            :base(Tags.NoRelatedSym) {}
        public NoRelatedSym(int val)
            :base(Tags.NoRelatedSym, val) {}

    }


    /// <summary>
    /// Subject Field
    /// </summary>/
    public sealed class Subject : StringField
    {
        public Subject()
            :base(Tags.Subject) {}
        public Subject(string val)
            :base(Tags.Subject, val) {}

    }


    /// <summary>
    /// Headline Field
    /// </summary>/
    public sealed class Headline : StringField
    {
        public Headline()
            :base(Tags.Headline) {}
        public Headline(string val)
            :base(Tags.Headline, val) {}

    }


    /// <summary>
    /// URLLink Field
    /// </summary>/
    public sealed class URLLink : StringField
    {
        public URLLink()
            :base(Tags.URLLink) {}
        public URLLink(string val)
            :base(Tags.URLLink, val) {}

    }


    /// <summary>
    /// ExecType Field
    /// </summary>/
    public sealed class ExecType : CharField
    {
        public ExecType()
            :base(Tags.ExecType) {}
        public ExecType(char val)
            :base(Tags.ExecType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char DONE_FOR_DAY = '3';
        public const char CANCELED = '4';
        public const char REPLACED = '5';
        public const char PENDING_CANCEL = '6';
        public const char STOPPED = '7';
        public const char REJECTED = '8';
        public const char SUSPENDED = '9';
        public const char PENDING_NEW = 'A';
        public const char CALCULATED = 'B';
        public const char EXPIRED = 'C';
        public const char RESTATED = 'D';
        public const char PENDING_REPLACE = 'E';
        public const char TRADE = 'F';
        public const char TRADE_CORRECT = 'G';
        public const char TRADE_CANCEL = 'H';
        public const char ORDER_STATUS = 'I';
        public const char TRADE_IN_A_CLEARING_HOLD = 'J';
        public const char TRADE_HAS_BEEN_RELEASED_TO_CLEARING = 'K';
        public const char TRIGGERED_OR_ACTIVATED_BY_SYSTEM = 'L';
    }


    /// <summary>
    /// LeavesQty Field
    /// </summary>/
    public sealed class LeavesQty : DecimalField
    {
        public LeavesQty()
            :base(Tags.LeavesQty) {}
        public LeavesQty(Decimal val)
            :base(Tags.LeavesQty, val) {}

    }


    /// <summary>
    /// CashOrderQty Field
    /// </summary>/
    public sealed class CashOrderQty : DecimalField
    {
        public CashOrderQty()
            :base(Tags.CashOrderQty) {}
        public CashOrderQty(Decimal val)
            :base(Tags.CashOrderQty, val) {}

    }


    /// <summary>
    /// AllocAvgPx Field
    /// </summary>/
    public sealed class AllocAvgPx : DecimalField
    {
        public AllocAvgPx()
            :base(Tags.AllocAvgPx) {}
        public AllocAvgPx(Decimal val)
            :base(Tags.AllocAvgPx, val) {}

    }


    /// <summary>
    /// AllocNetMoney Field
    /// </summary>/
    public sealed class AllocNetMoney : DecimalField
    {
        public AllocNetMoney()
            :base(Tags.AllocNetMoney) {}
        public AllocNetMoney(Decimal val)
            :base(Tags.AllocNetMoney, val) {}

    }


    /// <summary>
    /// SettlCurrFxRate Field
    /// </summary>/
    public sealed class SettlCurrFxRate : DecimalField
    {
        public SettlCurrFxRate()
            :base(Tags.SettlCurrFxRate) {}
        public SettlCurrFxRate(Decimal val)
            :base(Tags.SettlCurrFxRate, val) {}

    }


    /// <summary>
    /// SettlCurrFxRateCalc Field
    /// </summary>/
    public sealed class SettlCurrFxRateCalc : CharField
    {
        public SettlCurrFxRateCalc()
            :base(Tags.SettlCurrFxRateCalc) {}
        public SettlCurrFxRateCalc(char val)
            :base(Tags.SettlCurrFxRateCalc, val) {}


        // Field Enumerations
        public const char MULTIPLY = 'M';
        public const char DIVIDE = 'D';
    }


    /// <summary>
    /// NumDaysInterest Field
    /// </summary>/
    public sealed class NumDaysInterest : IntField
    {
        public NumDaysInterest()
            :base(Tags.NumDaysInterest) {}
        public NumDaysInterest(int val)
            :base(Tags.NumDaysInterest, val) {}

    }


    /// <summary>
    /// AccruedInterestRate Field
    /// </summary>/
    public sealed class AccruedInterestRate : DecimalField
    {
        public AccruedInterestRate()
            :base(Tags.AccruedInterestRate) {}
        public AccruedInterestRate(Decimal val)
            :base(Tags.AccruedInterestRate, val) {}

    }


    /// <summary>
    /// AccruedInterestAmt Field
    /// </summary>/
    public sealed class AccruedInterestAmt : DecimalField
    {
        public AccruedInterestAmt()
            :base(Tags.AccruedInterestAmt) {}
        public AccruedInterestAmt(Decimal val)
            :base(Tags.AccruedInterestAmt, val) {}

    }


    /// <summary>
    /// SettlInstMode Field
    /// </summary>/
    public sealed class SettlInstMode : CharField
    {
        public SettlInstMode()
            :base(Tags.SettlInstMode) {}
        public SettlInstMode(char val)
            :base(Tags.SettlInstMode, val) {}


        // Field Enumerations
        public const char DEFAULT = '0';
        public const char STANDING_INSTRUCTIONS_PROVIDED = '1';
        public const char SPECIFIC_ALLOCATION_ACCOUNT_OVERRIDING = '2';
        public const char SPECIFIC_ALLOCATION_ACCOUNT_STANDING = '3';
        public const char SPECIFIC_ORDER_FOR_A_SINGLE_ACCOUNT = '4';
        public const char REQUEST_REJECT = '5';
    }


    /// <summary>
    /// AllocText Field
    /// </summary>/
    public sealed class AllocText : StringField
    {
        public AllocText()
            :base(Tags.AllocText) {}
        public AllocText(string val)
            :base(Tags.AllocText, val) {}

    }


    /// <summary>
    /// SettlInstID Field
    /// </summary>/
    public sealed class SettlInstID : StringField
    {
        public SettlInstID()
            :base(Tags.SettlInstID) {}
        public SettlInstID(string val)
            :base(Tags.SettlInstID, val) {}

    }


    /// <summary>
    /// SettlInstTransType Field
    /// </summary>/
    public sealed class SettlInstTransType : CharField
    {
        public SettlInstTransType()
            :base(Tags.SettlInstTransType) {}
        public SettlInstTransType(char val)
            :base(Tags.SettlInstTransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NEW = 'N';
        public const char REPLACE = 'R';
        public const char RESTATE = 'T';
    }


    /// <summary>
    /// EmailThreadID Field
    /// </summary>/
    public sealed class EmailThreadID : StringField
    {
        public EmailThreadID()
            :base(Tags.EmailThreadID) {}
        public EmailThreadID(string val)
            :base(Tags.EmailThreadID, val) {}

    }


    /// <summary>
    /// SettlInstSource Field
    /// </summary>/
    public sealed class SettlInstSource : CharField
    {
        public SettlInstSource()
            :base(Tags.SettlInstSource) {}
        public SettlInstSource(char val)
            :base(Tags.SettlInstSource, val) {}


        // Field Enumerations
        public const char BROKERS_INSTRUCTIONS = '1';
        public const char INSTITUTIONS_INSTRUCTIONS = '2';
        public const char INVESTOR = '3';
    }


    /// <summary>
    /// SettlLocation Field
    /// </summary>/
    public sealed class SettlLocation : StringField
    {
        public SettlLocation()
            :base(Tags.SettlLocation) {}
        public SettlLocation(string val)
            :base(Tags.SettlLocation, val) {}


        // Field Enumerations
        public const string CEDEL = "CED";
        public const string DEPOSITORY_TRUST_COMPANY = "DTC";
        public const string EURO_CLEAR = "EUR";
        public const string FEDERAL_BOOK_ENTRY = "FED";
        public const string LOCAL_MARKET_SETTLE_LOCATION = "ISO_Country_Code";
        public const string PHYSICAL = "PNY";
        public const string PARTICIPANT_TRUST_COMPANY = "PTC";
    }


    /// <summary>
    /// SecurityType Field
    /// </summary>/
    public sealed class SecurityType : StringField
    {
        public SecurityType()
            :base(Tags.SecurityType) {}
        public SecurityType(string val)
            :base(Tags.SecurityType, val) {}


        // Field Enumerations
        public const string ASSET_BACKED_SECURITIES = "ABS";
        public const string AMENDED_RESTATED = "AMENDED";
        public const string OTHER_ANTICIPATION_NOTES = "AN";
        public const string BANKERS_ACCEPTANCE = "BA";
        public const string BANK_NOTES = "BN";
        public const string BILL_OF_EXCHANGES = "BOX";
        public const string BRADY_BOND = "BRADY";
        public const string BRIDGE_LOAN = "BRIDGE";
        public const string BUY_SELLBACK = "BUYSELL";
        public const string CONVERTIBLE_BOND = "CB";
        public const string CERTIFICATE_OF_DEPOSIT = "CD";
        public const string CALL_LOANS = "CL";
        public const string CORP_MORTGAGE_BACKED_SECURITIES = "CMBS";
        public const string COLLATERALIZED_MORTGAGE_OBLIGATION = "CMO";
        public const string CERTIFICATE_OF_OBLIGATION = "COFO";
        public const string CERTIFICATE_OF_PARTICIPATION = "COFP";
        public const string CORPORATE_BOND = "CORP";
        public const string COMMERCIAL_PAPER = "CP";
        public const string CORPORATE_PRIVATE_PLACEMENT = "CPP";
        public const string COMMON_STOCK = "CS";
        public const string DEFAULTED = "DEFLTED";
        public const string DEBTOR_IN_POSSESSION = "DINP";
        public const string DEPOSIT_NOTES = "DN";
        public const string DUAL_CURRENCY = "DUAL";
        public const string EURO_CERTIFICATE_OF_DEPOSIT = "EUCD";
        public const string EURO_CORPORATE_BOND = "EUCORP";
        public const string EURO_COMMERCIAL_PAPER = "EUCP";
        public const string EURO_SOVEREIGNS = "EUSOV";
        public const string EURO_SUPRANATIONAL_COUPONS = "EUSUPRA";
        public const string FEDERAL_AGENCY_COUPON = "FAC";
        public const string FEDERAL_AGENCY_DISCOUNT_NOTE = "FADN";
        public const string FOREIGN_EXCHANGE_CONTRACT = "FOR";
        public const string FORWARD = "FORWARD";
        public const string FUTURE = "FUT";
        public const string GENERAL_OBLIGATION_BONDS = "GO";
        public const string IOETTE_MORTGAGE = "IET";
        public const string LETTER_OF_CREDIT = "LOFC";
        public const string LIQUIDITY_NOTE = "LQN";
        public const string MATURED = "MATURED";
        public const string MORTGAGE_BACKED_SECURITIES = "MBS";
        public const string MUTUAL_FUND = "MF";
        public const string MORTGAGE_INTEREST_ONLY = "MIO";
        public const string MULTILEG_INSTRUMENT = "MLEG";
        public const string MORTGAGE_PRINCIPAL_ONLY = "MPO";
        public const string MORTGAGE_PRIVATE_PLACEMENT = "MPP";
        public const string MISCELLANEOUS_PASS_THROUGH = "MPT";
        public const string MANDATORY_TENDER = "MT";
        public const string MEDIUM_TERM_NOTES = "MTN";
        public const string NO_SECURITY_TYPE = "NONE";
        public const string OVERNIGHT = "ONITE";
        public const string OPTION = "OPT";
        public const string PRIVATE_EXPORT_FUNDING = "PEF";
        public const string PFANDBRIEFE = "PFAND";
        public const string PROMISSORY_NOTE = "PN";
        public const string PREFERRED_STOCK = "PS";
        public const string PLAZOS_FIJOS = "PZFJ";
        public const string REVENUE_ANTICIPATION_NOTE = "RAN";
        public const string REPLACED = "REPLACD";
        public const string REPURCHASE = "REPO";
        public const string RETIRED = "RETIRED";
        public const string REVENUE_BONDS = "REV";
        public const string REVOLVER_LOAN = "RVLV";
        public const string REVOLVER_TERM_LOAN = "RVLVTRM";
        public const string SECURITIES_LOAN = "SECLOAN";
        public const string SECURITIES_PLEDGE = "SECPLEDGE";
        public const string SPECIAL_ASSESSMENT = "SPCLA";
        public const string SPECIAL_OBLIGATION = "SPCLO";
        public const string SPECIAL_TAX = "SPCLT";
        public const string SHORT_TERM_LOAN_NOTE = "STN";
        public const string STRUCTURED_NOTES = "STRUCT";
        public const string USD_SUPRANATIONAL_COUPONS = "SUPRA";
        public const string SWING_LINE_FACILITY = "SWING";
        public const string TAX_ANTICIPATION_NOTE = "TAN";
        public const string TAX_ALLOCATION = "TAXA";
        public const string TO_BE_ANNOUNCED = "TBA";
        public const string US_TREASURY_BILL_TBILL = "TBILL";
        public const string US_TREASURY_BOND = "TBOND";
        public const string PRINCIPAL_STRIP_OF_A_CALLABLE_BOND_OR_NOTE = "TCAL";
        public const string TIME_DEPOSIT = "TD";
        public const string TAX_EXEMPT_COMMERCIAL_PAPER = "TECP";
        public const string TERM_LOAN = "TERM";
        public const string INTEREST_STRIP_FROM_ANY_BOND_OR_NOTE = "TINT";
        public const string TREASURY_INFLATION_PROTECTED_SECURITIES = "TIPS";
        public const string US_TREASURY_NOTE_TNOTE = "TNOTE";
        public const string PRINCIPAL_STRIP_FROM_A_NON_CALLABLE_BOND_OR_NOTE = "TPRN";
        public const string TAX_REVENUE_ANTICIPATION_NOTE = "TRAN";
        public const string US_TREASURY_NOTE_UST = "UST";
        public const string US_TREASURY_BILL_USTB = "USTB";
        public const string VARIABLE_RATE_DEMAND_NOTE = "VRDN";
        public const string WARRANT = "WAR";
        public const string WITHDRAWN = "WITHDRN";
        public const string WILDCARD_ENTRY = "WLD";
        public const string EXTENDED_COMM_NOTE = "XCN";
        public const string INDEXED_LINKED = "XLINKD";
        public const string YANKEE_CORPORATE_BOND = "YANK";
        public const string YANKEE_CERTIFICATE_OF_DEPOSIT = "YCD";
        public const string OPTIONS_ON_PHYSICAL = "OOP";
        public const string OPTIONS_ON_FUTURES = "OOF";
        public const string CASH = "CASH";
    }


    /// <summary>
    /// EffectiveTime Field
    /// </summary>/
    public sealed class EffectiveTime : DateTimeField
    {
        public EffectiveTime()
            :base(Tags.EffectiveTime) {}
        public EffectiveTime(DateTime val)
            :base(Tags.EffectiveTime, val) {}

    }


    /// <summary>
    /// StandInstDbType Field
    /// </summary>/
    public sealed class StandInstDbType : IntField
    {
        public StandInstDbType()
            :base(Tags.StandInstDbType) {}
        public StandInstDbType(int val)
            :base(Tags.StandInstDbType, val) {}


        // Field Enumerations
        public const int OTHER = 0;
        public const int DTC_SID = 1;
        public const int THOMSON_ALERT = 2;
        public const int A_GLOBAL_CUSTODIAN = 3;
        public const int ACCOUNTNET = 4;
    }


    /// <summary>
    /// StandInstDbName Field
    /// </summary>/
    public sealed class StandInstDbName : StringField
    {
        public StandInstDbName()
            :base(Tags.StandInstDbName) {}
        public StandInstDbName(string val)
            :base(Tags.StandInstDbName, val) {}

    }


    /// <summary>
    /// StandInstDbID Field
    /// </summary>/
    public sealed class StandInstDbID : StringField
    {
        public StandInstDbID()
            :base(Tags.StandInstDbID) {}
        public StandInstDbID(string val)
            :base(Tags.StandInstDbID, val) {}

    }


    /// <summary>
    /// SettlDeliveryType Field
    /// </summary>/
    public sealed class SettlDeliveryType : IntField
    {
        public SettlDeliveryType()
            :base(Tags.SettlDeliveryType) {}
        public SettlDeliveryType(int val)
            :base(Tags.SettlDeliveryType, val) {}


        // Field Enumerations
        public const int VERSUS_PAYMENT_DELIVER = 0;
        public const int FREE_DELIVER = 1;
        public const int TRI_PARTY = 2;
        public const int HOLD_IN_CUSTODY = 3;
    }


    /// <summary>
    /// SettlDepositoryCode Field
    /// </summary>/
    public sealed class SettlDepositoryCode : StringField
    {
        public SettlDepositoryCode()
            :base(Tags.SettlDepositoryCode) {}
        public SettlDepositoryCode(string val)
            :base(Tags.SettlDepositoryCode, val) {}

    }


    /// <summary>
    /// SettlBrkrCode Field
    /// </summary>/
    public sealed class SettlBrkrCode : StringField
    {
        public SettlBrkrCode()
            :base(Tags.SettlBrkrCode) {}
        public SettlBrkrCode(string val)
            :base(Tags.SettlBrkrCode, val) {}

    }


    /// <summary>
    /// SettlInstCode Field
    /// </summary>/
    public sealed class SettlInstCode : StringField
    {
        public SettlInstCode()
            :base(Tags.SettlInstCode) {}
        public SettlInstCode(string val)
            :base(Tags.SettlInstCode, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentName Field
    /// </summary>/
    public sealed class SecuritySettlAgentName : StringField
    {
        public SecuritySettlAgentName()
            :base(Tags.SecuritySettlAgentName) {}
        public SecuritySettlAgentName(string val)
            :base(Tags.SecuritySettlAgentName, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentCode Field
    /// </summary>/
    public sealed class SecuritySettlAgentCode : StringField
    {
        public SecuritySettlAgentCode()
            :base(Tags.SecuritySettlAgentCode) {}
        public SecuritySettlAgentCode(string val)
            :base(Tags.SecuritySettlAgentCode, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentAcctNum Field
    /// </summary>/
    public sealed class SecuritySettlAgentAcctNum : StringField
    {
        public SecuritySettlAgentAcctNum()
            :base(Tags.SecuritySettlAgentAcctNum) {}
        public SecuritySettlAgentAcctNum(string val)
            :base(Tags.SecuritySettlAgentAcctNum, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentAcctName Field
    /// </summary>/
    public sealed class SecuritySettlAgentAcctName : StringField
    {
        public SecuritySettlAgentAcctName()
            :base(Tags.SecuritySettlAgentAcctName) {}
        public SecuritySettlAgentAcctName(string val)
            :base(Tags.SecuritySettlAgentAcctName, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentContactName Field
    /// </summary>/
    public sealed class SecuritySettlAgentContactName : StringField
    {
        public SecuritySettlAgentContactName()
            :base(Tags.SecuritySettlAgentContactName) {}
        public SecuritySettlAgentContactName(string val)
            :base(Tags.SecuritySettlAgentContactName, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentContactPhone Field
    /// </summary>/
    public sealed class SecuritySettlAgentContactPhone : StringField
    {
        public SecuritySettlAgentContactPhone()
            :base(Tags.SecuritySettlAgentContactPhone) {}
        public SecuritySettlAgentContactPhone(string val)
            :base(Tags.SecuritySettlAgentContactPhone, val) {}

    }


    /// <summary>
    /// CashSettlAgentName Field
    /// </summary>/
    public sealed class CashSettlAgentName : StringField
    {
        public CashSettlAgentName()
            :base(Tags.CashSettlAgentName) {}
        public CashSettlAgentName(string val)
            :base(Tags.CashSettlAgentName, val) {}

    }


    /// <summary>
    /// CashSettlAgentCode Field
    /// </summary>/
    public sealed class CashSettlAgentCode : StringField
    {
        public CashSettlAgentCode()
            :base(Tags.CashSettlAgentCode) {}
        public CashSettlAgentCode(string val)
            :base(Tags.CashSettlAgentCode, val) {}

    }


    /// <summary>
    /// CashSettlAgentAcctNum Field
    /// </summary>/
    public sealed class CashSettlAgentAcctNum : StringField
    {
        public CashSettlAgentAcctNum()
            :base(Tags.CashSettlAgentAcctNum) {}
        public CashSettlAgentAcctNum(string val)
            :base(Tags.CashSettlAgentAcctNum, val) {}

    }


    /// <summary>
    /// CashSettlAgentAcctName Field
    /// </summary>/
    public sealed class CashSettlAgentAcctName : StringField
    {
        public CashSettlAgentAcctName()
            :base(Tags.CashSettlAgentAcctName) {}
        public CashSettlAgentAcctName(string val)
            :base(Tags.CashSettlAgentAcctName, val) {}

    }


    /// <summary>
    /// CashSettlAgentContactName Field
    /// </summary>/
    public sealed class CashSettlAgentContactName : StringField
    {
        public CashSettlAgentContactName()
            :base(Tags.CashSettlAgentContactName) {}
        public CashSettlAgentContactName(string val)
            :base(Tags.CashSettlAgentContactName, val) {}

    }


    /// <summary>
    /// CashSettlAgentContactPhone Field
    /// </summary>/
    public sealed class CashSettlAgentContactPhone : StringField
    {
        public CashSettlAgentContactPhone()
            :base(Tags.CashSettlAgentContactPhone) {}
        public CashSettlAgentContactPhone(string val)
            :base(Tags.CashSettlAgentContactPhone, val) {}

    }


    /// <summary>
    /// BidSpotRate Field
    /// </summary>/
    public sealed class BidSpotRate : DecimalField
    {
        public BidSpotRate()
            :base(Tags.BidSpotRate) {}
        public BidSpotRate(Decimal val)
            :base(Tags.BidSpotRate, val) {}

    }


    /// <summary>
    /// BidForwardPoints Field
    /// </summary>/
    public sealed class BidForwardPoints : DecimalField
    {
        public BidForwardPoints()
            :base(Tags.BidForwardPoints) {}
        public BidForwardPoints(Decimal val)
            :base(Tags.BidForwardPoints, val) {}

    }


    /// <summary>
    /// OfferSpotRate Field
    /// </summary>/
    public sealed class OfferSpotRate : DecimalField
    {
        public OfferSpotRate()
            :base(Tags.OfferSpotRate) {}
        public OfferSpotRate(Decimal val)
            :base(Tags.OfferSpotRate, val) {}

    }


    /// <summary>
    /// OfferForwardPoints Field
    /// </summary>/
    public sealed class OfferForwardPoints : DecimalField
    {
        public OfferForwardPoints()
            :base(Tags.OfferForwardPoints) {}
        public OfferForwardPoints(Decimal val)
            :base(Tags.OfferForwardPoints, val) {}

    }


    /// <summary>
    /// OrderQty2 Field
    /// </summary>/
    public sealed class OrderQty2 : DecimalField
    {
        public OrderQty2()
            :base(Tags.OrderQty2) {}
        public OrderQty2(Decimal val)
            :base(Tags.OrderQty2, val) {}

    }


    /// <summary>
    /// FutSettDate2 Field
    /// </summary>/
    public sealed class FutSettDate2 : StringField
    {
        public FutSettDate2()
            :base(Tags.FutSettDate2) {}
        public FutSettDate2(string val)
            :base(Tags.FutSettDate2, val) {}

    }


    /// <summary>
    /// LastSpotRate Field
    /// </summary>/
    public sealed class LastSpotRate : DecimalField
    {
        public LastSpotRate()
            :base(Tags.LastSpotRate) {}
        public LastSpotRate(Decimal val)
            :base(Tags.LastSpotRate, val) {}

    }


    /// <summary>
    /// LastForwardPoints Field
    /// </summary>/
    public sealed class LastForwardPoints : DecimalField
    {
        public LastForwardPoints()
            :base(Tags.LastForwardPoints) {}
        public LastForwardPoints(Decimal val)
            :base(Tags.LastForwardPoints, val) {}

    }


    /// <summary>
    /// AllocLinkID Field
    /// </summary>/
    public sealed class AllocLinkID : StringField
    {
        public AllocLinkID()
            :base(Tags.AllocLinkID) {}
        public AllocLinkID(string val)
            :base(Tags.AllocLinkID, val) {}

    }


    /// <summary>
    /// AllocLinkType Field
    /// </summary>/
    public sealed class AllocLinkType : IntField
    {
        public AllocLinkType()
            :base(Tags.AllocLinkType) {}
        public AllocLinkType(int val)
            :base(Tags.AllocLinkType, val) {}


        // Field Enumerations
        public const int FX_NETTING = 0;
        public const int FX_SWAP = 1;
    }


    /// <summary>
    /// SecondaryOrderID Field
    /// </summary>/
    public sealed class SecondaryOrderID : StringField
    {
        public SecondaryOrderID()
            :base(Tags.SecondaryOrderID) {}
        public SecondaryOrderID(string val)
            :base(Tags.SecondaryOrderID, val) {}

    }


    /// <summary>
    /// NoIOIQualifiers Field
    /// </summary>/
    public sealed class NoIOIQualifiers : IntField
    {
        public NoIOIQualifiers()
            :base(Tags.NoIOIQualifiers) {}
        public NoIOIQualifiers(int val)
            :base(Tags.NoIOIQualifiers, val) {}

    }


    /// <summary>
    /// MaturityMonthYear Field
    /// </summary>/
    public sealed class MaturityMonthYear : StringField
    {
        public MaturityMonthYear()
            :base(Tags.MaturityMonthYear) {}
        public MaturityMonthYear(string val)
            :base(Tags.MaturityMonthYear, val) {}

    }


    /// <summary>
    /// PutOrCall Field
    /// </summary>/
    public sealed class PutOrCall : IntField
    {
        public PutOrCall()
            :base(Tags.PutOrCall) {}
        public PutOrCall(int val)
            :base(Tags.PutOrCall, val) {}


        // Field Enumerations
        public const int PUT = 0;
        public const int CALL = 1;
    }


    /// <summary>
    /// StrikePrice Field
    /// </summary>/
    public sealed class StrikePrice : DecimalField
    {
        public StrikePrice()
            :base(Tags.StrikePrice) {}
        public StrikePrice(Decimal val)
            :base(Tags.StrikePrice, val) {}

    }


    /// <summary>
    /// CoveredOrUncovered Field
    /// </summary>/
    public sealed class CoveredOrUncovered : IntField
    {
        public CoveredOrUncovered()
            :base(Tags.CoveredOrUncovered) {}
        public CoveredOrUncovered(int val)
            :base(Tags.CoveredOrUncovered, val) {}


        // Field Enumerations
        public const int COVERED = 0;
        public const int UNCOVERED = 1;
    }


    /// <summary>
    /// CustomerOrFirm Field
    /// </summary>/
    public sealed class CustomerOrFirm : IntField
    {
        public CustomerOrFirm()
            :base(Tags.CustomerOrFirm) {}
        public CustomerOrFirm(int val)
            :base(Tags.CustomerOrFirm, val) {}


        // Field Enumerations
        public const int CUSTOMER = 0;
        public const int FIRM = 1;
    }


    /// <summary>
    /// MaturityDay Field
    /// </summary>/
    public sealed class MaturityDay : StringField
    {
        public MaturityDay()
            :base(Tags.MaturityDay) {}
        public MaturityDay(string val)
            :base(Tags.MaturityDay, val) {}

    }


    /// <summary>
    /// OptAttribute Field
    /// </summary>/
    public sealed class OptAttribute : CharField
    {
        public OptAttribute()
            :base(Tags.OptAttribute) {}
        public OptAttribute(char val)
            :base(Tags.OptAttribute, val) {}

    }


    /// <summary>
    /// SecurityExchange Field
    /// </summary>/
    public sealed class SecurityExchange : StringField
    {
        public SecurityExchange()
            :base(Tags.SecurityExchange) {}
        public SecurityExchange(string val)
            :base(Tags.SecurityExchange, val) {}

    }


    /// <summary>
    /// NotifyBrokerOfCredit Field
    /// </summary>/
    public sealed class NotifyBrokerOfCredit : BooleanField
    {
        public NotifyBrokerOfCredit()
            :base(Tags.NotifyBrokerOfCredit) {}
        public NotifyBrokerOfCredit(Boolean val)
            :base(Tags.NotifyBrokerOfCredit, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// AllocHandlInst Field
    /// </summary>/
    public sealed class AllocHandlInst : IntField
    {
        public AllocHandlInst()
            :base(Tags.AllocHandlInst) {}
        public AllocHandlInst(int val)
            :base(Tags.AllocHandlInst, val) {}


        // Field Enumerations
        public const int MATCH = 1;
        public const int FORWARD = 2;
        public const int FORWARD_AND_MATCH = 3;
    }


    /// <summary>
    /// MaxShow Field
    /// </summary>/
    public sealed class MaxShow : DecimalField
    {
        public MaxShow()
            :base(Tags.MaxShow) {}
        public MaxShow(Decimal val)
            :base(Tags.MaxShow, val) {}

    }


    /// <summary>
    /// PegDifference Field
    /// </summary>/
    public sealed class PegDifference : DecimalField
    {
        public PegDifference()
            :base(Tags.PegDifference) {}
        public PegDifference(Decimal val)
            :base(Tags.PegDifference, val) {}

    }


    /// <summary>
    /// TotNoOrders Field
    /// </summary>/
    public sealed class TotNoOrders : IntField
    {
        public TotNoOrders()
            :base(Tags.TotNoOrders) {}
        public TotNoOrders(int val)
            :base(Tags.TotNoOrders, val) {}

    }


    /// <summary>
    /// XmlDataLen Field
    /// </summary>/
    public sealed class XmlDataLen : DecimalField
    {
        public XmlDataLen()
            :base(Tags.XmlDataLen) {}
        public XmlDataLen(Decimal val)
            :base(Tags.XmlDataLen, val) {}

    }


    /// <summary>
    /// XmlData Field
    /// </summary>/
    public sealed class XmlData : StringField
    {
        public XmlData()
            :base(Tags.XmlData) {}
        public XmlData(string val)
            :base(Tags.XmlData, val) {}

    }


    /// <summary>
    /// SettlInstRefID Field
    /// </summary>/
    public sealed class SettlInstRefID : StringField
    {
        public SettlInstRefID()
            :base(Tags.SettlInstRefID) {}
        public SettlInstRefID(string val)
            :base(Tags.SettlInstRefID, val) {}

    }


    /// <summary>
    /// NoRoutingIDs Field
    /// </summary>/
    public sealed class NoRoutingIDs : IntField
    {
        public NoRoutingIDs()
            :base(Tags.NoRoutingIDs) {}
        public NoRoutingIDs(int val)
            :base(Tags.NoRoutingIDs, val) {}

    }


    /// <summary>
    /// RoutingType Field
    /// </summary>/
    public sealed class RoutingType : IntField
    {
        public RoutingType()
            :base(Tags.RoutingType) {}
        public RoutingType(int val)
            :base(Tags.RoutingType, val) {}


        // Field Enumerations
        public const int TARGET_FIRM = 1;
        public const int TARGET_LIST = 2;
        public const int BLOCK_FIRM = 3;
        public const int BLOCK_LIST = 4;
    }


    /// <summary>
    /// RoutingID Field
    /// </summary>/
    public sealed class RoutingID : StringField
    {
        public RoutingID()
            :base(Tags.RoutingID) {}
        public RoutingID(string val)
            :base(Tags.RoutingID, val) {}

    }


    /// <summary>
    /// SpreadToBenchmark Field
    /// </summary>/
    public sealed class SpreadToBenchmark : DecimalField
    {
        public SpreadToBenchmark()
            :base(Tags.SpreadToBenchmark) {}
        public SpreadToBenchmark(Decimal val)
            :base(Tags.SpreadToBenchmark, val) {}

    }


    /// <summary>
    /// Benchmark Field
    /// </summary>/
    public sealed class Benchmark : CharField
    {
        public Benchmark()
            :base(Tags.Benchmark) {}
        public Benchmark(char val)
            :base(Tags.Benchmark, val) {}


        // Field Enumerations
        public const char CURVE = '1';
        public const char VAL_5YR = '2';
        public const char OLD5 = '3';
        public const char VAL_10YR = '4';
        public const char OLD10 = '5';
        public const char VAL_30YR = '6';
        public const char OLD30 = '7';
        public const char VAL_3MOLIBOR = '8';
        public const char VAL_6MOLIBOR = '9';
    }


    /// <summary>
    /// CouponRate Field
    /// </summary>/
    public sealed class CouponRate : DecimalField
    {
        public CouponRate()
            :base(Tags.CouponRate) {}
        public CouponRate(Decimal val)
            :base(Tags.CouponRate, val) {}

    }


    /// <summary>
    /// ContractMultiplier Field
    /// </summary>/
    public sealed class ContractMultiplier : DecimalField
    {
        public ContractMultiplier()
            :base(Tags.ContractMultiplier) {}
        public ContractMultiplier(Decimal val)
            :base(Tags.ContractMultiplier, val) {}

    }


    /// <summary>
    /// MDReqID Field
    /// </summary>/
    public sealed class MDReqID : StringField
    {
        public MDReqID()
            :base(Tags.MDReqID) {}
        public MDReqID(string val)
            :base(Tags.MDReqID, val) {}

    }


    /// <summary>
    /// SubscriptionRequestType Field
    /// </summary>/
    public sealed class SubscriptionRequestType : CharField
    {
        public SubscriptionRequestType()
            :base(Tags.SubscriptionRequestType) {}
        public SubscriptionRequestType(char val)
            :base(Tags.SubscriptionRequestType, val) {}


        // Field Enumerations
        public const char SNAPSHOT = '0';
        public const char SNAPSHOT_PLUS_UPDATES = '1';
        public const char DISABLE_PREVIOUS_SNAPSHOT_PLUS_UPDATE_REQUEST = '2';
    }


    /// <summary>
    /// MarketDepth Field
    /// </summary>/
    public sealed class MarketDepth : IntField
    {
        public MarketDepth()
            :base(Tags.MarketDepth) {}
        public MarketDepth(int val)
            :base(Tags.MarketDepth, val) {}

    }


    /// <summary>
    /// MDUpdateType Field
    /// </summary>/
    public sealed class MDUpdateType : IntField
    {
        public MDUpdateType()
            :base(Tags.MDUpdateType) {}
        public MDUpdateType(int val)
            :base(Tags.MDUpdateType, val) {}


        // Field Enumerations
        public const int FULL_REFRESH = 0;
        public const int INCREMENTAL_REFRESH = 1;
    }


    /// <summary>
    /// AggregatedBook Field
    /// </summary>/
    public sealed class AggregatedBook : BooleanField
    {
        public AggregatedBook()
            :base(Tags.AggregatedBook) {}
        public AggregatedBook(Boolean val)
            :base(Tags.AggregatedBook, val) {}


        // Field Enumerations
        public const Boolean YES = true;
        public const Boolean NO = false;
    }


    /// <summary>
    /// NoMDEntryTypes Field
    /// </summary>/
    public sealed class NoMDEntryTypes : IntField
    {
        public NoMDEntryTypes()
            :base(Tags.NoMDEntryTypes) {}
        public NoMDEntryTypes(int val)
            :base(Tags.NoMDEntryTypes, val) {}

    }


    /// <summary>
    /// NoMDEntries Field
    /// </summary>/
    public sealed class NoMDEntries : IntField
    {
        public NoMDEntries()
            :base(Tags.NoMDEntries) {}
        public NoMDEntries(int val)
            :base(Tags.NoMDEntries, val) {}

    }


    /// <summary>
    /// MDEntryType Field
    /// </summary>/
    public sealed class MDEntryType : CharField
    {
        public MDEntryType()
            :base(Tags.MDEntryType) {}
        public MDEntryType(char val)
            :base(Tags.MDEntryType, val) {}


        // Field Enumerations
        public const char BID = '0';
        public const char OFFER = '1';
        public const char TRADE = '2';
        public const char INDEX_VALUE = '3';
        public const char OPENING_PRICE = '4';
        public const char CLOSING_PRICE = '5';
        public const char SETTLEMENT_PRICE = '6';
        public const char TRADING_SESSION_HIGH_PRICE = '7';
        public const char TRADING_SESSION_LOW_PRICE = '8';
        public const char TRADING_SESSION_VWAP_PRICE = '9';
        public const char IMBALANCE = 'A';
        public const char TRADE_VOLUME = 'B';
        public const char OPEN_INTEREST = 'C';
        public const char COMPOSITE_UNDERLYING_PRICE = 'D';
        public const char SIMULATED_SELL_PRICE = 'E';
        public const char SIMULATED_BUY_PRICE = 'F';
        public const char MARGIN_RATE = 'G';
        public const char MID_PRICE = 'H';
        public const char EMPTY_BOOK = 'J';
        public const char SETTLE_HIGH_PRICE = 'K';
        public const char SETTLE_LOW_PRICE = 'L';
        public const char PRIOR_SETTLE_PRICE = 'M';
        public const char SESSION_HIGH_BID = 'N';
        public const char SESSION_LOW_OFFER = 'O';
        public const char EARLY_PRICES = 'P';
        public const char AUCTION_CLEARING_PRICE = 'Q';
    }


    /// <summary>
    /// MDEntryPx Field
    /// </summary>/
    public sealed class MDEntryPx : DecimalField
    {
        public MDEntryPx()
            :base(Tags.MDEntryPx) {}
        public MDEntryPx(Decimal val)
            :base(Tags.MDEntryPx, val) {}

    }


    /// <summary>
    /// MDEntrySize Field
    /// </summary>/
    public sealed class MDEntrySize : DecimalField
    {
        public MDEntrySize()
            :base(Tags.MDEntrySize) {}
        public MDEntrySize(Decimal val)
            :base(Tags.MDEntrySize, val) {}

    }


    /// <summary>
    /// MDEntryDate Field
    /// </summary>/
    public sealed class MDEntryDate : DateTimeField
    {
        public MDEntryDate()
            :base(Tags.MDEntryDate) {}
        public MDEntryDate(DateTime val)
            :base(Tags.MDEntryDate, val) {}

    }


    /// <summary>
    /// MDEntryTime Field
    /// </summary>/
    public sealed class MDEntryTime : DateTimeField
    {
        public MDEntryTime()
            :base(Tags.MDEntryTime) {}
        public MDEntryTime(DateTime val)
            :base(Tags.MDEntryTime, val) {}

    }


    /// <summary>
    /// TickDirection Field
    /// </summary>/
    public sealed class TickDirection : CharField
    {
        public TickDirection()
            :base(Tags.TickDirection) {}
        public TickDirection(char val)
            :base(Tags.TickDirection, val) {}


        // Field Enumerations
        public const char PLUS_TICK = '0';
        public const char ZERO_PLUS_TICK = '1';
        public const char MINUS_TICK = '2';
        public const char ZERO_MINUS_TICK = '3';
    }


    /// <summary>
    /// MDMkt Field
    /// </summary>/
    public sealed class MDMkt : StringField
    {
        public MDMkt()
            :base(Tags.MDMkt) {}
        public MDMkt(string val)
            :base(Tags.MDMkt, val) {}

    }


    /// <summary>
    /// QuoteCondition Field
    /// </summary>/
    public sealed class QuoteCondition : StringField
    {
        public QuoteCondition()
            :base(Tags.QuoteCondition) {}
        public QuoteCondition(string val)
            :base(Tags.QuoteCondition, val) {}


        // Field Enumerations
        public const string OPEN_ACTIVE = "A";
        public const string CLOSED_INACTIVE = "B";
        public const string EXCHANGE_BEST = "C";
        public const string CONSOLIDATED_BEST = "D";
        public const string LOCKED = "E";
        public const string CROSSED = "F";
        public const string DEPTH = "G";
        public const string FAST_TRADING = "H";
        public const string NON_FIRM = "I";
        public const string MANUAL_SLOW_QUOTE = "L";
        public const string OUTRIGHT_PRICE = "J";
        public const string IMPLIED_PRICE = "K";
        public const string DEPTH_ON_OFFER = "M";
        public const string DEPTH_ON_BID = "N";
        public const string CLOSING = "O";
        public const string NEWS_DISSEMINATION = "P";
        public const string TRADING_RANGE = "Q";
        public const string ORDER_INFLUX = "R";
        public const string DUE_TO_RELATED = "S";
        public const string NEWS_PENDING = "T";
        public const string ADDITIONAL_INFO = "U";
        public const string ADDITIONAL_INFO_DUE_TO_RELATED = "V";
        public const string RESUME = "W";
        public const string VIEW_OF_COMMON = "X";
        public const string VOLUME_ALERT = "Y";
        public const string ORDER_IMBALANCE = "Z";
        public const string EQUIPMENT_CHANGEOVER = "a";
        public const string NO_OPEN = "b";
        public const string REGULAR_ETH = "c";
        public const string AUTOMATIC_EXECUTION = "d";
        public const string AUTOMATIC_EXECUTION_ETH = "e";
        public const string FAST_MARKET_ETH = "f ";
        public const string INACTIVE_ETH = "g";
        public const string ROTATION = "h";
        public const string ROTATION_ETH = "i";
        public const string HALT = "j";
        public const string HALT_ETH = "k";
        public const string DUE_TO_NEWS_DISSEMINATION = "l";
        public const string DUE_TO_NEWS_PENDING = "m";
        public const string TRADING_RESUME = "n";
        public const string OUT_OF_SEQUENCE = "o";
        public const string BID_SPECIALIST = "p";
        public const string OFFER_SPECIALIST = "q";
        public const string BID_OFFER_SPECIALIST = "r";
        public const string END_OF_DAY_SAM = "s";
        public const string FORBIDDEN_SAM = "t";
        public const string FROZEN_SAM = "u";
        public const string PREOPENING_SAM = "v";
        public const string OPENING_SAM = "w";
        public const string OPEN_SAM = "x";
        public const string SURVEILLANCE_SAM = "y";
        public const string SUSPENDED_SAM = "z";
        public const string RESERVED_SAM = "0";
        public const string NO_ACTIVE_SAM = "1";
        public const string RESTRICTED = "2";
    }


    /// <summary>
    /// TradeCondition Field
    /// </summary>/
    public sealed class TradeCondition : StringField
    {
        public TradeCondition()
            :base(Tags.TradeCondition) {}
        public TradeCondition(string val)
            :base(Tags.TradeCondition, val) {}


        // Field Enumerations
        public const string CASH = "A";
        public const string AVERAGE_PRICE_TRADE = "B";
        public const string CASH_TRADE = "C";
        public const string NEXT_DAY = "D";
        public const string OPENING_REOPENING_TRADE_DETAIL = "E";
        public const string INTRADAY_TRADE_DETAIL = "F";
        public const string RULE_127_TRADE = "G";
        public const string RULE_155_TRADE = "H";
        public const string SOLD_LAST = "I";
        public const string NEXT_DAY_TRADE = "J";
        public const string OPENED = "K";
        public const string SELLER = "L";
        public const string SOLD = "M";
        public const string STOPPED_STOCK = "N";
        public const string IMBALANCE_MORE_BUYERS = "P";
        public const string IMBALANCE_MORE_SELLERS = "Q";
        public const string OPENING_PRICE = "R";
        public const string TRADES_RESULTING_FROM_MANUAL_SLOW_QUOTE = "Y";
        public const string TRADES_RESULTING_FROM_INTERMARKET_SWEEP = "Z";
        public const string BARGAIN_CONDITION = "S";
        public const string CONVERTED_PRICE_INDICATOR = "T";
        public const string EXCHANGE_LAST = "U";
        public const string FINAL_PRICE_OF_SESSION = "V";
        public const string EX_PIT = "W";
        public const string CROSSED_X = "X";
        public const string CANCEL = "0";
        public const string VOLUME_ONLY = "a";
        public const string DIRECT_PLUS = "b";
        public const string ACQUISITION = "c";
        public const string BUNCHED = "d";
        public const string DISTRIBUTION = "e";
        public const string BUNCHED_SALE = "f";
        public const string SPLIT_TRADE = "g";
        public const string CANCEL_STOPPED = "h";
        public const string CANCEL_ETH = "i";
        public const string CANCEL_STOPPED_ETH = "j";
        public const string OUT_OF_SEQUENCE_ETH = "k";
        public const string CANCEL_LAST_ETH = "l";
        public const string SOLD_LAST_SALE_ETH = "m";
        public const string CANCEL_LAST = "n";
        public const string SOLD_LAST_SALE = "o";
        public const string CANCEL_OPEN = "p";
        public const string CANCEL_OPEN_ETH = "q";
        public const string OPENED_SALE_ETH = "r";
        public const string CANCEL_ONLY = "s";
        public const string CANCEL_ONLY_ETH = "t";
        public const string LATE_OPEN_ETH = "u";
        public const string AUTO_EXECUTION_ETH = "v";
        public const string REOPEN = "w";
        public const string REOPEN_ETH = "x";
        public const string ADJUSTED = "y";
        public const string ADJUSTED_ETH = "z";
        public const string SPREAD = "AA";
        public const string SPREAD_ETH = "AB";
        public const string STRADDLE = "AC";
        public const string STRADDLE_ETH = "AD";
        public const string STOPPED = "AE";
        public const string STOPPED_ETH = "AF";
        public const string REGULAR_ETH = "AG";
        public const string COMBO = "AH";
        public const string COMBO_ETH = "AI";
        public const string OFFICIAL_CLOSING_PRICE = "AJ";
        public const string PRIOR_REFERENCE_PRICE = "AK";
        public const string STOPPED_SOLD_LAST = "AL";
        public const string STOPPED_OUT_OF_SEQUENCE = "AM";
        public const string OFFICAL_CLOSING_PRICE = "AN";
        public const string CROSSED_AO = "AO";
        public const string FAST_MARKET = "AP";
        public const string AUTOMATIC_EXECUTION = "AQ";
        public const string FORM_T = "AR";
        public const string BASKET_INDEX = "AS";
        public const string BURST_BASKET = "AT";
    }


    /// <summary>
    /// MDEntryID Field
    /// </summary>/
    public sealed class MDEntryID : StringField
    {
        public MDEntryID()
            :base(Tags.MDEntryID) {}
        public MDEntryID(string val)
            :base(Tags.MDEntryID, val) {}

    }


    /// <summary>
    /// MDUpdateAction Field
    /// </summary>/
    public sealed class MDUpdateAction : CharField
    {
        public MDUpdateAction()
            :base(Tags.MDUpdateAction) {}
        public MDUpdateAction(char val)
            :base(Tags.MDUpdateAction, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char CHANGE = '1';
        public const char DELETE = '2';
        public const char DELETE_THRU = '3';
        public const char DELETE_FROM = '4';
    }


    /// <summary>
    /// MDEntryRefID Field
    /// </summary>/
    public sealed class MDEntryRefID : StringField
    {
        public MDEntryRefID()
            :base(Tags.MDEntryRefID) {}
        public MDEntryRefID(string val)
            :base(Tags.MDEntryRefID, val) {}

    }


    /// <summary>
    /// MDReqRejReason Field
    /// </summary>/
    public sealed class MDReqRejReason : CharField
    {
        public MDReqRejReason()
            :base(Tags.MDReqRejReason) {}
        public MDReqRejReason(char val)
            :base(Tags.MDReqRejReason, val) {}


        // Field Enumerations
        public const char UNKNOWN_SYMBOL = '0';
        public const char DUPLICATE_MDREQID = '1';
        public const char INSUFFICIENT_BANDWIDTH = '2';
        public const char INSUFFICIENT_PERMISSIONS = '3';
        public const char UNSUPPORTED_SUBSCRIPTIONREQUESTTYPE = '4';
        public const char UNSUPPORTED_MARKETDEPTH = '5';
        public const char UNSUPPORTED_MDUPDATETYPE = '6';
        public const char UNSUPPORTED_AGGREGATEDBOOK = '7';
        public const char UNSUPPORTED_MDENTRYTYPE = '8';
        public const char UNSUPPORTED_TRADINGSESSIONID = '9';
        public const char UNSUPPORTED_SCOPE = 'A';
        public const char UNSUPPORTED_OPENCLOSESETTLEFLAG = 'B';
        public const char UNSUPPORTED_MDIMPLICITDELETE = 'C';
        public const char INSUFFICIENT_CREDIT = 'D';
    }


    /// <summary>
    /// MDEntryOriginator Field
    /// </summary>/
    public sealed class MDEntryOriginator : StringField
    {
        public MDEntryOriginator()
            :base(Tags.MDEntryOriginator) {}
        public MDEntryOriginator(string val)
            :base(Tags.MDEntryOriginator, val) {}

    }


    /// <summary>
    /// LocationID Field
    /// </summary>/
    public sealed class LocationID : StringField
    {
        public LocationID()
            :base(Tags.LocationID) {}
        public LocationID(string val)
            :base(Tags.LocationID, val) {}

    }


    /// <summary>
    /// DeskID Field
    /// </summary>/
    public sealed class DeskID : StringField
    {
        public DeskID()
            :base(Tags.DeskID) {}
        public DeskID(string val)
            :base(Tags.DeskID, val) {}

    }


    /// <summary>
    /// DeleteReason Field
    /// </summary>/
    public sealed class DeleteReason : CharField
    {
        public DeleteReason()
            :base(Tags.DeleteReason) {}
        public DeleteReason(char val)
            :base(Tags.DeleteReason, val) {}


        // Field Enumerations
        public const char CANCELLATION = '0';
        public const char ERROR = '1';
    }


    /// <summary>
    /// OpenCloseSettleFlag Field
    /// </summary>/
    public sealed class OpenCloseSettleFlag : StringField
    {
        public OpenCloseSettleFlag()
            :base(Tags.OpenCloseSettleFlag) {}
        public OpenCloseSettleFlag(string val)
            :base(Tags.OpenCloseSettleFlag, val) {}


        // Field Enumerations
        public const string DAILY_OPEN = "0";
        public const string SESSION_OPEN = "1";
        public const string DELIVERY_SETTLEMENT_PRICE = "2";
        public const string EXPECTED_PRICE = "3";
        public const string PRICE_FROM_PREVIOUS_BUSINESS_DAY = "4";
    }


    /// <summary>
    /// SellerDays Field
    /// </summary>/
    public sealed class SellerDays : IntField
    {
        public SellerDays()
            :base(Tags.SellerDays) {}
        public SellerDays(int val)
            :base(Tags.SellerDays, val) {}

    }


    /// <summary>
    /// MDEntryBuyer Field
    /// </summary>/
    public sealed class MDEntryBuyer : StringField
    {
        public MDEntryBuyer()
            :base(Tags.MDEntryBuyer) {}
        public MDEntryBuyer(string val)
            :base(Tags.MDEntryBuyer, val) {}

    }


    /// <summary>
    /// MDEntrySeller Field
    /// </summary>/
    public sealed class MDEntrySeller : StringField
    {
        public MDEntrySeller()
            :base(Tags.MDEntrySeller) {}
        public MDEntrySeller(string val)
            :base(Tags.MDEntrySeller, val) {}

    }


    /// <summary>
    /// MDEntryPositionNo Field
    /// </summary>/
    public sealed class MDEntryPositionNo : IntField
    {
        public MDEntryPositionNo()
            :base(Tags.MDEntryPositionNo) {}
        public MDEntryPositionNo(int val)
            :base(Tags.MDEntryPositionNo, val) {}

    }


    /// <summary>
    /// FinancialStatus Field
    /// </summary>/
    public sealed class FinancialStatus : StringField
    {
        public FinancialStatus()
            :base(Tags.FinancialStatus) {}
        public FinancialStatus(string val)
            :base(Tags.FinancialStatus, val) {}


        // Field Enumerations
        public const string BANKRUPT = "1";
        public const string PENDING_DELISTING = "2";
        public const string RESTRICTED = "3";
    }


    /// <summary>
    /// CorporateAction Field
    /// </summary>/
    public sealed class CorporateAction : StringField
    {
        public CorporateAction()
            :base(Tags.CorporateAction) {}
        public CorporateAction(string val)
            :base(Tags.CorporateAction, val) {}


        // Field Enumerations
        public const string EX_DIVIDEND = "A";
        public const string EX_DISTRIBUTION = "B";
        public const string EX_RIGHTS = "C";
        public const string NEW = "D";
        public const string EX_INTEREST = "E";
        public const string CASH_DIVIDEND = "F";
        public const string STOCK_DIVIDEND = "G";
        public const string NON_INTEGER_STOCK_SPLIT = "H";
        public const string REVERSE_STOCK_SPLIT = "I";
        public const string STANDARD_INTEGER_STOCK_SPLIT = "J";
        public const string POSITION_CONSOLIDATION = "K";
        public const string LIQUIDATION_REORGANIZATION = "L";
        public const string MERGER_REORGANIZATION = "M";
        public const string RIGHTS_OFFERING = "N";
        public const string SHAREHOLDER_MEETING = "O";
        public const string SPINOFF = "P";
        public const string TENDER_OFFER = "Q";
        public const string WARRANT = "R";
        public const string SPECIAL_ACTION = "S";
        public const string SYMBOL_CONVERSION = "T";
        public const string CUSIP = "U";
        public const string LEAP_ROLLOVER = "V";
    }


    /// <summary>
    /// DefBidSize Field
    /// </summary>/
    public sealed class DefBidSize : DecimalField
    {
        public DefBidSize()
            :base(Tags.DefBidSize) {}
        public DefBidSize(Decimal val)
            :base(Tags.DefBidSize, val) {}

    }


    /// <summary>
    /// DefOfferSize Field
    /// </summary>/
    public sealed class DefOfferSize : DecimalField
    {
        public DefOfferSize()
            :base(Tags.DefOfferSize) {}
        public DefOfferSize(Decimal val)
            :base(Tags.DefOfferSize, val) {}

    }


    /// <summary>
    /// NoQuoteEntries Field
    /// </summary>/
    public sealed class NoQuoteEntries : IntField
    {
        public NoQuoteEntries()
            :base(Tags.NoQuoteEntries) {}
        public NoQuoteEntries(int val)
            :base(Tags.NoQuoteEntries, val) {}

    }


    /// <summary>
    /// NoQuoteSets Field
    /// </summary>/
    public sealed class NoQuoteSets : IntField
    {
        public NoQuoteSets()
            :base(Tags.NoQuoteSets) {}
        public NoQuoteSets(int val)
            :base(Tags.NoQuoteSets, val) {}

    }


    /// <summary>
    /// QuoteAckStatus Field
    /// </summary>/
    public sealed class QuoteAckStatus : IntField
    {
        public QuoteAckStatus()
            :base(Tags.QuoteAckStatus) {}
        public QuoteAckStatus(int val)
            :base(Tags.QuoteAckStatus, val) {}

    }


    /// <summary>
    /// QuoteCancelType Field
    /// </summary>/
    public sealed class QuoteCancelType : IntField
    {
        public QuoteCancelType()
            :base(Tags.QuoteCancelType) {}
        public QuoteCancelType(int val)
            :base(Tags.QuoteCancelType, val) {}


        // Field Enumerations
        public const int CANCEL_FOR_SYMBOL = 1;
        public const int CANCEL_FOR_SECURITY_TYPE = 2;
        public const int CANCEL_FOR_UNDERLYING_SYMBOL = 3;
        public const int CANCEL_ALL_QUOTES = 4;
        public const int CANCEL_QUOTE_SPECIFIED_IN_QUOTEID = 5;
    }


    /// <summary>
    /// QuoteEntryID Field
    /// </summary>/
    public sealed class QuoteEntryID : StringField
    {
        public QuoteEntryID()
            :base(Tags.QuoteEntryID) {}
        public QuoteEntryID(string val)
            :base(Tags.QuoteEntryID, val) {}

    }


    /// <summary>
    /// QuoteRejectReason Field
    /// </summary>/
    public sealed class QuoteRejectReason : IntField
    {
        public QuoteRejectReason()
            :base(Tags.QuoteRejectReason) {}
        public QuoteRejectReason(int val)
            :base(Tags.QuoteRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_SYMBOL = 1;
        public const int EXCHANGE = 2;
        public const int QUOTE_REQUEST_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_QUOTE = 5;
        public const int DUPLICATE_QUOTE = 6;
        public const int INVALID_BID_ASK_SPREAD = 7;
        public const int INVALID_PRICE = 8;
        public const int NOT_AUTHORIZED_TO_QUOTE_SECURITY = 9;
        public const int OTHER = 99;
    }


    /// <summary>
    /// QuoteResponseLevel Field
    /// </summary>/
    public sealed class QuoteResponseLevel : IntField
    {
        public QuoteResponseLevel()
            :base(Tags.QuoteResponseLevel) {}
        public QuoteResponseLevel(int val)
            :base(Tags.QuoteResponseLevel, val) {}


        // Field Enumerations
        public const int NO_ACKNOWLEDGEMENT = 0;
        public const int ACKNOWLEDGE_ONLY_NEGATIVE_OR_ERRONEOUS_QUOTES = 1;
        public const int ACKNOWLEDGE_EACH_QUOTE_MESSAGES = 2;
    }


    /// <summary>
    /// QuoteSetID Field
    /// </summary>/
    public sealed class QuoteSetID : StringField
    {
        public QuoteSetID()
            :base(Tags.QuoteSetID) {}
        public QuoteSetID(string val)
            :base(Tags.QuoteSetID, val) {}

    }


    /// <summary>
    /// QuoteRequestType Field
    /// </summary>/
    public sealed class QuoteRequestType : IntField
    {
        public QuoteRequestType()
            :base(Tags.QuoteRequestType) {}
        public QuoteRequestType(int val)
            :base(Tags.QuoteRequestType, val) {}


        // Field Enumerations
        public const int MANUAL = 1;
        public const int AUTOMATIC = 2;
    }


    /// <summary>
    /// TotQuoteEntries Field
    /// </summary>/
    public sealed class TotQuoteEntries : IntField
    {
        public TotQuoteEntries()
            :base(Tags.TotQuoteEntries) {}
        public TotQuoteEntries(int val)
            :base(Tags.TotQuoteEntries, val) {}

    }


    /// <summary>
    /// UnderlyingIDSource Field
    /// </summary>/
    public sealed class UnderlyingIDSource : StringField
    {
        public UnderlyingIDSource()
            :base(Tags.UnderlyingIDSource) {}
        public UnderlyingIDSource(string val)
            :base(Tags.UnderlyingIDSource, val) {}

    }


    /// <summary>
    /// UnderlyingIssuer Field
    /// </summary>/
    public sealed class UnderlyingIssuer : StringField
    {
        public UnderlyingIssuer()
            :base(Tags.UnderlyingIssuer) {}
        public UnderlyingIssuer(string val)
            :base(Tags.UnderlyingIssuer, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityDesc Field
    /// </summary>/
    public sealed class UnderlyingSecurityDesc : StringField
    {
        public UnderlyingSecurityDesc()
            :base(Tags.UnderlyingSecurityDesc) {}
        public UnderlyingSecurityDesc(string val)
            :base(Tags.UnderlyingSecurityDesc, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityExchange Field
    /// </summary>/
    public sealed class UnderlyingSecurityExchange : StringField
    {
        public UnderlyingSecurityExchange()
            :base(Tags.UnderlyingSecurityExchange) {}
        public UnderlyingSecurityExchange(string val)
            :base(Tags.UnderlyingSecurityExchange, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityID Field
    /// </summary>/
    public sealed class UnderlyingSecurityID : StringField
    {
        public UnderlyingSecurityID()
            :base(Tags.UnderlyingSecurityID) {}
        public UnderlyingSecurityID(string val)
            :base(Tags.UnderlyingSecurityID, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityType Field
    /// </summary>/
    public sealed class UnderlyingSecurityType : StringField
    {
        public UnderlyingSecurityType()
            :base(Tags.UnderlyingSecurityType) {}
        public UnderlyingSecurityType(string val)
            :base(Tags.UnderlyingSecurityType, val) {}

    }


    /// <summary>
    /// UnderlyingSymbol Field
    /// </summary>/
    public sealed class UnderlyingSymbol : StringField
    {
        public UnderlyingSymbol()
            :base(Tags.UnderlyingSymbol) {}
        public UnderlyingSymbol(string val)
            :base(Tags.UnderlyingSymbol, val) {}

    }


    /// <summary>
    /// UnderlyingSymbolSfx Field
    /// </summary>/
    public sealed class UnderlyingSymbolSfx : StringField
    {
        public UnderlyingSymbolSfx()
            :base(Tags.UnderlyingSymbolSfx) {}
        public UnderlyingSymbolSfx(string val)
            :base(Tags.UnderlyingSymbolSfx, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityMonthYear Field
    /// </summary>/
    public sealed class UnderlyingMaturityMonthYear : StringField
    {
        public UnderlyingMaturityMonthYear()
            :base(Tags.UnderlyingMaturityMonthYear) {}
        public UnderlyingMaturityMonthYear(string val)
            :base(Tags.UnderlyingMaturityMonthYear, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityDay Field
    /// </summary>/
    public sealed class UnderlyingMaturityDay : StringField
    {
        public UnderlyingMaturityDay()
            :base(Tags.UnderlyingMaturityDay) {}
        public UnderlyingMaturityDay(string val)
            :base(Tags.UnderlyingMaturityDay, val) {}

    }


    /// <summary>
    /// UnderlyingPutOrCall Field
    /// </summary>/
    public sealed class UnderlyingPutOrCall : IntField
    {
        public UnderlyingPutOrCall()
            :base(Tags.UnderlyingPutOrCall) {}
        public UnderlyingPutOrCall(int val)
            :base(Tags.UnderlyingPutOrCall, val) {}

    }


    /// <summary>
    /// UnderlyingStrikePrice Field
    /// </summary>/
    public sealed class UnderlyingStrikePrice : DecimalField
    {
        public UnderlyingStrikePrice()
            :base(Tags.UnderlyingStrikePrice) {}
        public UnderlyingStrikePrice(Decimal val)
            :base(Tags.UnderlyingStrikePrice, val) {}

    }


    /// <summary>
    /// UnderlyingOptAttribute Field
    /// </summary>/
    public sealed class UnderlyingOptAttribute : CharField
    {
        public UnderlyingOptAttribute()
            :base(Tags.UnderlyingOptAttribute) {}
        public UnderlyingOptAttribute(char val)
            :base(Tags.UnderlyingOptAttribute, val) {}

    }


    /// <summary>
    /// UnderlyingCurrency Field
    /// </summary>/
    public sealed class UnderlyingCurrency : DecimalField
    {
        public UnderlyingCurrency()
            :base(Tags.UnderlyingCurrency) {}
        public UnderlyingCurrency(Decimal val)
            :base(Tags.UnderlyingCurrency, val) {}

    }


    /// <summary>
    /// RatioQty Field
    /// </summary>/
    public sealed class RatioQty : DecimalField
    {
        public RatioQty()
            :base(Tags.RatioQty) {}
        public RatioQty(Decimal val)
            :base(Tags.RatioQty, val) {}

    }


    /// <summary>
    /// SecurityReqID Field
    /// </summary>/
    public sealed class SecurityReqID : StringField
    {
        public SecurityReqID()
            :base(Tags.SecurityReqID) {}
        public SecurityReqID(string val)
            :base(Tags.SecurityReqID, val) {}

    }


    /// <summary>
    /// SecurityRequestType Field
    /// </summary>/
    public sealed class SecurityRequestType : IntField
    {
        public SecurityRequestType()
            :base(Tags.SecurityRequestType) {}
        public SecurityRequestType(int val)
            :base(Tags.SecurityRequestType, val) {}


        // Field Enumerations
        public const int REQUEST_SECURITY_IDENTITY_AND_SPECIFICATIONS = 0;
        public const int REQUEST_SECURITY_IDENTITY_FOR_THE_SPECIFICATIONS_PROVIDED = 1;
        public const int REQUEST_LIST_SECURITY_TYPES = 2;
        public const int REQUEST_LIST_SECURITIES = 3;
    }


    /// <summary>
    /// SecurityResponseID Field
    /// </summary>/
    public sealed class SecurityResponseID : StringField
    {
        public SecurityResponseID()
            :base(Tags.SecurityResponseID) {}
        public SecurityResponseID(string val)
            :base(Tags.SecurityResponseID, val) {}

    }


    /// <summary>
    /// SecurityResponseType Field
    /// </summary>/
    public sealed class SecurityResponseType : IntField
    {
        public SecurityResponseType()
            :base(Tags.SecurityResponseType) {}
        public SecurityResponseType(int val)
            :base(Tags.SecurityResponseType, val) {}


        // Field Enumerations
        public const int ACCEPT_SECURITY_PROPOSAL_AS_IS = 1;
        public const int ACCEPT_SECURITY_PROPOSAL_WITH_REVISIONS_AS_INDICATED_IN_THE_MESSAGE = 2;
        public const int LIST_OF_SECURITY_TYPES_RETURNED_PER_REQUEST = 3;
        public const int LIST_OF_SECURITIES_RETURNED_PER_REQUEST = 4;
        public const int REJECT_SECURITY_PROPOSAL = 5;
        public const int CANNOT_MATCH_SELECTION_CRITERIA = 6;
    }


    /// <summary>
    /// SecurityStatusReqID Field
    /// </summary>/
    public sealed class SecurityStatusReqID : StringField
    {
        public SecurityStatusReqID()
            :base(Tags.SecurityStatusReqID) {}
        public SecurityStatusReqID(string val)
            :base(Tags.SecurityStatusReqID, val) {}

    }


    /// <summary>
    /// UnsolicitedIndicator Field
    /// </summary>/
    public sealed class UnsolicitedIndicator : BooleanField
    {
        public UnsolicitedIndicator()
            :base(Tags.UnsolicitedIndicator) {}
        public UnsolicitedIndicator(Boolean val)
            :base(Tags.UnsolicitedIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// SecurityTradingStatus Field
    /// </summary>/
    public sealed class SecurityTradingStatus : IntField
    {
        public SecurityTradingStatus()
            :base(Tags.SecurityTradingStatus) {}
        public SecurityTradingStatus(int val)
            :base(Tags.SecurityTradingStatus, val) {}


        // Field Enumerations
        public const int OPENING_DELAY = 1;
        public const int MARKET_ON_CLOSE_IMBALANCE_SELL = 10;
        public const int VAL_11 = 11;
        public const int NO_MARKET_IMBALANCE = 12;
        public const int NO_MARKET_ON_CLOSE_IMBALANCE = 13;
        public const int ITS_PRE_OPENING = 14;
        public const int NEW_PRICE_INDICATION = 15;
        public const int TRADE_DISSEMINATION_TIME = 16;
        public const int READY_TO_TRADE = 17;
        public const int NOT_AVAILABLE_FOR_TRADING = 18;
        public const int NOT_TRADED_ON_THIS_MARKET = 19;
        public const int TRADING_HALT = 2;
        public const int UNKNOWN_OR_INVALID = 20;
        public const int PRE_OPEN = 21;
        public const int OPENING_ROTATION = 22;
        public const int FAST_MARKET = 23;
        public const int RESUME = 3;
        public const int NO_OPEN = 4;
        public const int PRICE_INDICATION = 5;
        public const int TRADING_RANGE_INDICATION = 6;
        public const int MARKET_IMBALANCE_BUY = 7;
        public const int MARKET_IMBALANCE_SELL = 8;
        public const int MARKET_ON_CLOSE_IMBALANCE_BUY = 9;
    }


    /// <summary>
    /// HaltReason Field
    /// </summary>/
    public sealed class HaltReason : CharField
    {
        public HaltReason()
            :base(Tags.HaltReason) {}
        public HaltReason(char val)
            :base(Tags.HaltReason, val) {}


        // Field Enumerations
        public const char ORDER_IMBALANCE = 'I';
        public const char EQUIPMENT_CHANGEOVER = 'X';
        public const char NEWS_PENDING = 'P';
        public const char NEWS_DISSEMINATION = 'D';
        public const char ORDER_INFLUX = 'E';
        public const char ADDITIONAL_INFORMATION = 'M';
    }


    /// <summary>
    /// InViewOfCommon Field
    /// </summary>/
    public sealed class InViewOfCommon : BooleanField
    {
        public InViewOfCommon()
            :base(Tags.InViewOfCommon) {}
        public InViewOfCommon(Boolean val)
            :base(Tags.InViewOfCommon, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// DueToRelated Field
    /// </summary>/
    public sealed class DueToRelated : BooleanField
    {
        public DueToRelated()
            :base(Tags.DueToRelated) {}
        public DueToRelated(Boolean val)
            :base(Tags.DueToRelated, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// BuyVolume Field
    /// </summary>/
    public sealed class BuyVolume : DecimalField
    {
        public BuyVolume()
            :base(Tags.BuyVolume) {}
        public BuyVolume(Decimal val)
            :base(Tags.BuyVolume, val) {}

    }


    /// <summary>
    /// SellVolume Field
    /// </summary>/
    public sealed class SellVolume : DecimalField
    {
        public SellVolume()
            :base(Tags.SellVolume) {}
        public SellVolume(Decimal val)
            :base(Tags.SellVolume, val) {}

    }


    /// <summary>
    /// HighPx Field
    /// </summary>/
    public sealed class HighPx : DecimalField
    {
        public HighPx()
            :base(Tags.HighPx) {}
        public HighPx(Decimal val)
            :base(Tags.HighPx, val) {}

    }


    /// <summary>
    /// LowPx Field
    /// </summary>/
    public sealed class LowPx : DecimalField
    {
        public LowPx()
            :base(Tags.LowPx) {}
        public LowPx(Decimal val)
            :base(Tags.LowPx, val) {}

    }


    /// <summary>
    /// Adjustment Field
    /// </summary>/
    public sealed class Adjustment : IntField
    {
        public Adjustment()
            :base(Tags.Adjustment) {}
        public Adjustment(int val)
            :base(Tags.Adjustment, val) {}


        // Field Enumerations
        public const int CANCEL = 1;
        public const int ERROR = 2;
        public const int CORRECTION = 3;
    }


    /// <summary>
    /// TradSesReqID Field
    /// </summary>/
    public sealed class TradSesReqID : StringField
    {
        public TradSesReqID()
            :base(Tags.TradSesReqID) {}
        public TradSesReqID(string val)
            :base(Tags.TradSesReqID, val) {}

    }


    /// <summary>
    /// TradingSessionID Field
    /// </summary>/
    public sealed class TradingSessionID : StringField
    {
        public TradingSessionID()
            :base(Tags.TradingSessionID) {}
        public TradingSessionID(string val)
            :base(Tags.TradingSessionID, val) {}

    }


    /// <summary>
    /// ContraTrader Field
    /// </summary>/
    public sealed class ContraTrader : StringField
    {
        public ContraTrader()
            :base(Tags.ContraTrader) {}
        public ContraTrader(string val)
            :base(Tags.ContraTrader, val) {}

    }


    /// <summary>
    /// TradSesMethod Field
    /// </summary>/
    public sealed class TradSesMethod : IntField
    {
        public TradSesMethod()
            :base(Tags.TradSesMethod) {}
        public TradSesMethod(int val)
            :base(Tags.TradSesMethod, val) {}


        // Field Enumerations
        public const int ELECTRONIC = 1;
        public const int OPEN_OUTCRY = 2;
        public const int TWO_PARTY = 3;
    }


    /// <summary>
    /// TradSesMode Field
    /// </summary>/
    public sealed class TradSesMode : IntField
    {
        public TradSesMode()
            :base(Tags.TradSesMode) {}
        public TradSesMode(int val)
            :base(Tags.TradSesMode, val) {}


        // Field Enumerations
        public const int TESTING = 1;
        public const int SIMULATED = 2;
        public const int PRODUCTION = 3;
    }


    /// <summary>
    /// TradSesStatus Field
    /// </summary>/
    public sealed class TradSesStatus : IntField
    {
        public TradSesStatus()
            :base(Tags.TradSesStatus) {}
        public TradSesStatus(int val)
            :base(Tags.TradSesStatus, val) {}


        // Field Enumerations
        public const int UNKNOWN = 0;
        public const int HALTED = 1;
        public const int OPEN = 2;
        public const int CLOSED = 3;
        public const int PRE_OPEN = 4;
        public const int PRE_CLOSE = 5;
        public const int REQUEST_REJECTED = 6;
    }


    /// <summary>
    /// TradSesStartTime Field
    /// </summary>/
    public sealed class TradSesStartTime : DateTimeField
    {
        public TradSesStartTime()
            :base(Tags.TradSesStartTime) {}
        public TradSesStartTime(DateTime val)
            :base(Tags.TradSesStartTime, val) {}

    }


    /// <summary>
    /// TradSesOpenTime Field
    /// </summary>/
    public sealed class TradSesOpenTime : DateTimeField
    {
        public TradSesOpenTime()
            :base(Tags.TradSesOpenTime) {}
        public TradSesOpenTime(DateTime val)
            :base(Tags.TradSesOpenTime, val) {}

    }


    /// <summary>
    /// TradSesPreCloseTime Field
    /// </summary>/
    public sealed class TradSesPreCloseTime : DateTimeField
    {
        public TradSesPreCloseTime()
            :base(Tags.TradSesPreCloseTime) {}
        public TradSesPreCloseTime(DateTime val)
            :base(Tags.TradSesPreCloseTime, val) {}

    }


    /// <summary>
    /// TradSesCloseTime Field
    /// </summary>/
    public sealed class TradSesCloseTime : DateTimeField
    {
        public TradSesCloseTime()
            :base(Tags.TradSesCloseTime) {}
        public TradSesCloseTime(DateTime val)
            :base(Tags.TradSesCloseTime, val) {}

    }


    /// <summary>
    /// TradSesEndTime Field
    /// </summary>/
    public sealed class TradSesEndTime : DateTimeField
    {
        public TradSesEndTime()
            :base(Tags.TradSesEndTime) {}
        public TradSesEndTime(DateTime val)
            :base(Tags.TradSesEndTime, val) {}

    }


    /// <summary>
    /// NumberOfOrders Field
    /// </summary>/
    public sealed class NumberOfOrders : IntField
    {
        public NumberOfOrders()
            :base(Tags.NumberOfOrders) {}
        public NumberOfOrders(int val)
            :base(Tags.NumberOfOrders, val) {}

    }


    /// <summary>
    /// MessageEncoding Field
    /// </summary>/
    public sealed class MessageEncoding : StringField
    {
        public MessageEncoding()
            :base(Tags.MessageEncoding) {}
        public MessageEncoding(string val)
            :base(Tags.MessageEncoding, val) {}

    }


    /// <summary>
    /// EncodedIssuerLen Field
    /// </summary>/
    public sealed class EncodedIssuerLen : DecimalField
    {
        public EncodedIssuerLen()
            :base(Tags.EncodedIssuerLen) {}
        public EncodedIssuerLen(Decimal val)
            :base(Tags.EncodedIssuerLen, val) {}

    }


    /// <summary>
    /// EncodedIssuer Field
    /// </summary>/
    public sealed class EncodedIssuer : StringField
    {
        public EncodedIssuer()
            :base(Tags.EncodedIssuer) {}
        public EncodedIssuer(string val)
            :base(Tags.EncodedIssuer, val) {}

    }


    /// <summary>
    /// EncodedSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedSecurityDescLen : DecimalField
    {
        public EncodedSecurityDescLen()
            :base(Tags.EncodedSecurityDescLen) {}
        public EncodedSecurityDescLen(Decimal val)
            :base(Tags.EncodedSecurityDescLen, val) {}

    }


    /// <summary>
    /// EncodedSecurityDesc Field
    /// </summary>/
    public sealed class EncodedSecurityDesc : StringField
    {
        public EncodedSecurityDesc()
            :base(Tags.EncodedSecurityDesc) {}
        public EncodedSecurityDesc(string val)
            :base(Tags.EncodedSecurityDesc, val) {}

    }


    /// <summary>
    /// EncodedListExecInstLen Field
    /// </summary>/
    public sealed class EncodedListExecInstLen : DecimalField
    {
        public EncodedListExecInstLen()
            :base(Tags.EncodedListExecInstLen) {}
        public EncodedListExecInstLen(Decimal val)
            :base(Tags.EncodedListExecInstLen, val) {}

    }


    /// <summary>
    /// EncodedListExecInst Field
    /// </summary>/
    public sealed class EncodedListExecInst : StringField
    {
        public EncodedListExecInst()
            :base(Tags.EncodedListExecInst) {}
        public EncodedListExecInst(string val)
            :base(Tags.EncodedListExecInst, val) {}

    }


    /// <summary>
    /// EncodedTextLen Field
    /// </summary>/
    public sealed class EncodedTextLen : DecimalField
    {
        public EncodedTextLen()
            :base(Tags.EncodedTextLen) {}
        public EncodedTextLen(Decimal val)
            :base(Tags.EncodedTextLen, val) {}

    }


    /// <summary>
    /// EncodedText Field
    /// </summary>/
    public sealed class EncodedText : StringField
    {
        public EncodedText()
            :base(Tags.EncodedText) {}
        public EncodedText(string val)
            :base(Tags.EncodedText, val) {}

    }


    /// <summary>
    /// EncodedSubjectLen Field
    /// </summary>/
    public sealed class EncodedSubjectLen : DecimalField
    {
        public EncodedSubjectLen()
            :base(Tags.EncodedSubjectLen) {}
        public EncodedSubjectLen(Decimal val)
            :base(Tags.EncodedSubjectLen, val) {}

    }


    /// <summary>
    /// EncodedSubject Field
    /// </summary>/
    public sealed class EncodedSubject : StringField
    {
        public EncodedSubject()
            :base(Tags.EncodedSubject) {}
        public EncodedSubject(string val)
            :base(Tags.EncodedSubject, val) {}

    }


    /// <summary>
    /// EncodedHeadlineLen Field
    /// </summary>/
    public sealed class EncodedHeadlineLen : DecimalField
    {
        public EncodedHeadlineLen()
            :base(Tags.EncodedHeadlineLen) {}
        public EncodedHeadlineLen(Decimal val)
            :base(Tags.EncodedHeadlineLen, val) {}

    }


    /// <summary>
    /// EncodedHeadline Field
    /// </summary>/
    public sealed class EncodedHeadline : StringField
    {
        public EncodedHeadline()
            :base(Tags.EncodedHeadline) {}
        public EncodedHeadline(string val)
            :base(Tags.EncodedHeadline, val) {}

    }


    /// <summary>
    /// EncodedAllocTextLen Field
    /// </summary>/
    public sealed class EncodedAllocTextLen : DecimalField
    {
        public EncodedAllocTextLen()
            :base(Tags.EncodedAllocTextLen) {}
        public EncodedAllocTextLen(Decimal val)
            :base(Tags.EncodedAllocTextLen, val) {}

    }


    /// <summary>
    /// EncodedAllocText Field
    /// </summary>/
    public sealed class EncodedAllocText : StringField
    {
        public EncodedAllocText()
            :base(Tags.EncodedAllocText) {}
        public EncodedAllocText(string val)
            :base(Tags.EncodedAllocText, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingIssuerLen Field
    /// </summary>/
    public sealed class EncodedUnderlyingIssuerLen : DecimalField
    {
        public EncodedUnderlyingIssuerLen()
            :base(Tags.EncodedUnderlyingIssuerLen) {}
        public EncodedUnderlyingIssuerLen(Decimal val)
            :base(Tags.EncodedUnderlyingIssuerLen, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingIssuer Field
    /// </summary>/
    public sealed class EncodedUnderlyingIssuer : StringField
    {
        public EncodedUnderlyingIssuer()
            :base(Tags.EncodedUnderlyingIssuer) {}
        public EncodedUnderlyingIssuer(string val)
            :base(Tags.EncodedUnderlyingIssuer, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedUnderlyingSecurityDescLen : DecimalField
    {
        public EncodedUnderlyingSecurityDescLen()
            :base(Tags.EncodedUnderlyingSecurityDescLen) {}
        public EncodedUnderlyingSecurityDescLen(Decimal val)
            :base(Tags.EncodedUnderlyingSecurityDescLen, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingSecurityDesc Field
    /// </summary>/
    public sealed class EncodedUnderlyingSecurityDesc : StringField
    {
        public EncodedUnderlyingSecurityDesc()
            :base(Tags.EncodedUnderlyingSecurityDesc) {}
        public EncodedUnderlyingSecurityDesc(string val)
            :base(Tags.EncodedUnderlyingSecurityDesc, val) {}

    }


    /// <summary>
    /// AllocPrice Field
    /// </summary>/
    public sealed class AllocPrice : DecimalField
    {
        public AllocPrice()
            :base(Tags.AllocPrice) {}
        public AllocPrice(Decimal val)
            :base(Tags.AllocPrice, val) {}

    }


    /// <summary>
    /// QuoteSetValidUntilTime Field
    /// </summary>/
    public sealed class QuoteSetValidUntilTime : DateTimeField
    {
        public QuoteSetValidUntilTime()
            :base(Tags.QuoteSetValidUntilTime) {}
        public QuoteSetValidUntilTime(DateTime val)
            :base(Tags.QuoteSetValidUntilTime, val) {}

    }


    /// <summary>
    /// QuoteEntryRejectReason Field
    /// </summary>/
    public sealed class QuoteEntryRejectReason : IntField
    {
        public QuoteEntryRejectReason()
            :base(Tags.QuoteEntryRejectReason) {}
        public QuoteEntryRejectReason(int val)
            :base(Tags.QuoteEntryRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_SYMBOL = 1;
        public const int EXHCNAGE = 2;
        public const int QUOTE_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_QUOTE = 5;
        public const int DUPLICATE_QUOTE = 6;
        public const int INVALID_BID_ASK_SPREAD = 7;
        public const int INVALID_PRICE = 8;
        public const int NOT_AUTHORIZED_TO_QUOTE_SECURITY = 9;
        public const int OTHER = 99;
    }


    /// <summary>
    /// LastMsgSeqNumProcessed Field
    /// </summary>/
    public sealed class LastMsgSeqNumProcessed : IntField
    {
        public LastMsgSeqNumProcessed()
            :base(Tags.LastMsgSeqNumProcessed) {}
        public LastMsgSeqNumProcessed(int val)
            :base(Tags.LastMsgSeqNumProcessed, val) {}

    }


    /// <summary>
    /// OnBehalfOfSendingTime Field
    /// </summary>/
    public sealed class OnBehalfOfSendingTime : DateTimeField
    {
        public OnBehalfOfSendingTime()
            :base(Tags.OnBehalfOfSendingTime) {}
        public OnBehalfOfSendingTime(DateTime val)
            :base(Tags.OnBehalfOfSendingTime, val) {}

    }


    /// <summary>
    /// RefTagID Field
    /// </summary>/
    public sealed class RefTagID : IntField
    {
        public RefTagID()
            :base(Tags.RefTagID) {}
        public RefTagID(int val)
            :base(Tags.RefTagID, val) {}

    }


    /// <summary>
    /// RefMsgType Field
    /// </summary>/
    public sealed class RefMsgType : StringField
    {
        public RefMsgType()
            :base(Tags.RefMsgType) {}
        public RefMsgType(string val)
            :base(Tags.RefMsgType, val) {}

    }


    /// <summary>
    /// SessionRejectReason Field
    /// </summary>/
    public sealed class SessionRejectReason : IntField
    {
        public SessionRejectReason()
            :base(Tags.SessionRejectReason) {}
        public SessionRejectReason(int val)
            :base(Tags.SessionRejectReason, val) {}


        // Field Enumerations
        public const int INVALID_TAG_NUMBER = 0;
        public const int REQUIRED_TAG_MISSING = 1;
        public const int SENDINGTIME_ACCURACY_PROBLEM = 10;
        public const int INVALID_MSGTYPE = 11;
        public const int XML_VALIDATION_ERROR = 12;
        public const int TAG_APPEARS_MORE_THAN_ONCE = 13;
        public const int TAG_SPECIFIED_OUT_OF_REQUIRED_ORDER = 14;
        public const int REPEATING_GROUP_FIELDS_OUT_OF_ORDER = 15;
        public const int INCORRECT_NUMINGROUP_COUNT_FOR_REPEATING_GROUP = 16;
        public const int NON_DATA_VALUE_INCLUDES_FIELD_DELIMITER = 17;
        public const int TAG_NOT_DEFINED_FOR_THIS_MESSAGE_TYPE = 2;
        public const int UNDEFINED_TAG = 3;
        public const int TAG_SPECIFIED_WITHOUT_A_VALUE = 4;
        public const int VALUE_IS_INCORRECT = 5;
        public const int INCORRECT_DATA_FORMAT_FOR_VALUE = 6;
        public const int DECRYPTION_PROBLEM = 7;
        public const int SIGNATURE_PROBLEM = 8;
        public const int COMPID_PROBLEM = 9;
        public const int OTHER = 99;
    }


    /// <summary>
    /// BidRequestTransType Field
    /// </summary>/
    public sealed class BidRequestTransType : CharField
    {
        public BidRequestTransType()
            :base(Tags.BidRequestTransType) {}
        public BidRequestTransType(char val)
            :base(Tags.BidRequestTransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NO = 'N';
    }


    /// <summary>
    /// ContraBroker Field
    /// </summary>/
    public sealed class ContraBroker : StringField
    {
        public ContraBroker()
            :base(Tags.ContraBroker) {}
        public ContraBroker(string val)
            :base(Tags.ContraBroker, val) {}

    }


    /// <summary>
    /// ComplianceID Field
    /// </summary>/
    public sealed class ComplianceID : StringField
    {
        public ComplianceID()
            :base(Tags.ComplianceID) {}
        public ComplianceID(string val)
            :base(Tags.ComplianceID, val) {}

    }


    /// <summary>
    /// SolicitedFlag Field
    /// </summary>/
    public sealed class SolicitedFlag : BooleanField
    {
        public SolicitedFlag()
            :base(Tags.SolicitedFlag) {}
        public SolicitedFlag(Boolean val)
            :base(Tags.SolicitedFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// ExecRestatementReason Field
    /// </summary>/
    public sealed class ExecRestatementReason : IntField
    {
        public ExecRestatementReason()
            :base(Tags.ExecRestatementReason) {}
        public ExecRestatementReason(int val)
            :base(Tags.ExecRestatementReason, val) {}


        // Field Enumerations
        public const int GT_CORPORATE_ACTION = 0;
        public const int GT_RENEWAL = 1;
        public const int WAREHOUSE_RECAP = 10;
        public const int VERBAL_CHANGE = 2;
        public const int REPRICING_OF_ORDER = 3;
        public const int BROKER_OPTION = 4;
        public const int PARTIAL_DECLINE_OF_ORDERQTY = 5;
        public const int CANCEL_ON_TRADING_HALT = 6;
        public const int CANCEL_ON_SYSTEM_FAILURE = 7;
        public const int MARKET = 8;
        public const int CANCELED_NOT_BEST = 9;
        public const int OTHER = 99;
        public const int PEG_REFRESH = 11;
    }


    /// <summary>
    /// BusinessRejectRefID Field
    /// </summary>/
    public sealed class BusinessRejectRefID : StringField
    {
        public BusinessRejectRefID()
            :base(Tags.BusinessRejectRefID) {}
        public BusinessRejectRefID(string val)
            :base(Tags.BusinessRejectRefID, val) {}

    }


    /// <summary>
    /// BusinessRejectReason Field
    /// </summary>/
    public sealed class BusinessRejectReason : IntField
    {
        public BusinessRejectReason()
            :base(Tags.BusinessRejectReason) {}
        public BusinessRejectReason(int val)
            :base(Tags.BusinessRejectReason, val) {}


        // Field Enumerations
        public const int OTHER = 0;
        public const int UNKNOWN_ID = 1;
        public const int UNKNOWN_SECURITY = 2;
        public const int UNKNOWN_MESSAGE_TYPE = 3;
        public const int APPLICATION_NOT_AVAILABLE = 4;
        public const int CONDITIONALLY_REQUIRED_FIELD_MISSING = 5;
        public const int NOT_AUTHORIZED = 6;
        public const int DELIVERTO_FIRM_NOT_AVAILABLE_AT_THIS_TIME = 7;
        public const int INVALID_PRICE_INCREMENT = 18;
    }


    /// <summary>
    /// GrossTradeAmt Field
    /// </summary>/
    public sealed class GrossTradeAmt : DecimalField
    {
        public GrossTradeAmt()
            :base(Tags.GrossTradeAmt) {}
        public GrossTradeAmt(Decimal val)
            :base(Tags.GrossTradeAmt, val) {}

    }


    /// <summary>
    /// NoContraBrokers Field
    /// </summary>/
    public sealed class NoContraBrokers : IntField
    {
        public NoContraBrokers()
            :base(Tags.NoContraBrokers) {}
        public NoContraBrokers(int val)
            :base(Tags.NoContraBrokers, val) {}

    }


    /// <summary>
    /// MaxMessageSize Field
    /// </summary>/
    public sealed class MaxMessageSize : DecimalField
    {
        public MaxMessageSize()
            :base(Tags.MaxMessageSize) {}
        public MaxMessageSize(Decimal val)
            :base(Tags.MaxMessageSize, val) {}

    }


    /// <summary>
    /// NoMsgTypes Field
    /// </summary>/
    public sealed class NoMsgTypes : IntField
    {
        public NoMsgTypes()
            :base(Tags.NoMsgTypes) {}
        public NoMsgTypes(int val)
            :base(Tags.NoMsgTypes, val) {}

    }


    /// <summary>
    /// MsgDirection Field
    /// </summary>/
    public sealed class MsgDirection : CharField
    {
        public MsgDirection()
            :base(Tags.MsgDirection) {}
        public MsgDirection(char val)
            :base(Tags.MsgDirection, val) {}


        // Field Enumerations
        public const char RECEIVE = 'R';
        public const char SEND = 'S';
    }


    /// <summary>
    /// NoTradingSessions Field
    /// </summary>/
    public sealed class NoTradingSessions : IntField
    {
        public NoTradingSessions()
            :base(Tags.NoTradingSessions) {}
        public NoTradingSessions(int val)
            :base(Tags.NoTradingSessions, val) {}

    }


    /// <summary>
    /// TotalVolumeTraded Field
    /// </summary>/
    public sealed class TotalVolumeTraded : DecimalField
    {
        public TotalVolumeTraded()
            :base(Tags.TotalVolumeTraded) {}
        public TotalVolumeTraded(Decimal val)
            :base(Tags.TotalVolumeTraded, val) {}

    }


    /// <summary>
    /// DiscretionInst Field
    /// </summary>/
    public sealed class DiscretionInst : CharField
    {
        public DiscretionInst()
            :base(Tags.DiscretionInst) {}
        public DiscretionInst(char val)
            :base(Tags.DiscretionInst, val) {}


        // Field Enumerations
        public const char RELATED_TO_DISPLAYED_PRICE = '0';
        public const char RELATED_TO_MARKET_PRICE = '1';
        public const char RELATED_TO_PRIMARY_PRICE = '2';
        public const char RELATED_TO_LOCAL_PRIMARY_PRICE = '3';
        public const char RELATED_TO_MIDPOINT_PRICE = '4';
        public const char RELATED_TO_LAST_TRADE_PRICE = '5';
        public const char RELATED_TO_VWAP = '6';
        public const char AVERAGE_PRICE_GUARANTEE = '7';
    }


    /// <summary>
    /// DiscretionOffset Field
    /// </summary>/
    public sealed class DiscretionOffset : DecimalField
    {
        public DiscretionOffset()
            :base(Tags.DiscretionOffset) {}
        public DiscretionOffset(Decimal val)
            :base(Tags.DiscretionOffset, val) {}

    }


    /// <summary>
    /// BidID Field
    /// </summary>/
    public sealed class BidID : StringField
    {
        public BidID()
            :base(Tags.BidID) {}
        public BidID(string val)
            :base(Tags.BidID, val) {}

    }


    /// <summary>
    /// ClientBidID Field
    /// </summary>/
    public sealed class ClientBidID : StringField
    {
        public ClientBidID()
            :base(Tags.ClientBidID) {}
        public ClientBidID(string val)
            :base(Tags.ClientBidID, val) {}

    }


    /// <summary>
    /// ListName Field
    /// </summary>/
    public sealed class ListName : StringField
    {
        public ListName()
            :base(Tags.ListName) {}
        public ListName(string val)
            :base(Tags.ListName, val) {}

    }


    /// <summary>
    /// TotalNumSecurities Field
    /// </summary>/
    public sealed class TotalNumSecurities : IntField
    {
        public TotalNumSecurities()
            :base(Tags.TotalNumSecurities) {}
        public TotalNumSecurities(int val)
            :base(Tags.TotalNumSecurities, val) {}

    }


    /// <summary>
    /// BidType Field
    /// </summary>/
    public sealed class BidType : IntField
    {
        public BidType()
            :base(Tags.BidType) {}
        public BidType(int val)
            :base(Tags.BidType, val) {}


        // Field Enumerations
        public const int NON_DISCLOSED_STYLE = 1;
        public const int DISCLOSED_SYTLE = 2;
        public const int NO_BIDDING_PROCESS = 3;
    }


    /// <summary>
    /// NumTickets Field
    /// </summary>/
    public sealed class NumTickets : IntField
    {
        public NumTickets()
            :base(Tags.NumTickets) {}
        public NumTickets(int val)
            :base(Tags.NumTickets, val) {}

    }


    /// <summary>
    /// SideValue1 Field
    /// </summary>/
    public sealed class SideValue1 : DecimalField
    {
        public SideValue1()
            :base(Tags.SideValue1) {}
        public SideValue1(Decimal val)
            :base(Tags.SideValue1, val) {}

    }


    /// <summary>
    /// SideValue2 Field
    /// </summary>/
    public sealed class SideValue2 : DecimalField
    {
        public SideValue2()
            :base(Tags.SideValue2) {}
        public SideValue2(Decimal val)
            :base(Tags.SideValue2, val) {}

    }


    /// <summary>
    /// NoBidDescriptors Field
    /// </summary>/
    public sealed class NoBidDescriptors : IntField
    {
        public NoBidDescriptors()
            :base(Tags.NoBidDescriptors) {}
        public NoBidDescriptors(int val)
            :base(Tags.NoBidDescriptors, val) {}

    }


    /// <summary>
    /// BidDescriptorType Field
    /// </summary>/
    public sealed class BidDescriptorType : IntField
    {
        public BidDescriptorType()
            :base(Tags.BidDescriptorType) {}
        public BidDescriptorType(int val)
            :base(Tags.BidDescriptorType, val) {}


        // Field Enumerations
        public const int SECTOR = 1;
        public const int COUNTRY = 2;
        public const int INDEX = 3;
    }


    /// <summary>
    /// BidDescriptor Field
    /// </summary>/
    public sealed class BidDescriptor : StringField
    {
        public BidDescriptor()
            :base(Tags.BidDescriptor) {}
        public BidDescriptor(string val)
            :base(Tags.BidDescriptor, val) {}

    }


    /// <summary>
    /// SideValueInd Field
    /// </summary>/
    public sealed class SideValueInd : IntField
    {
        public SideValueInd()
            :base(Tags.SideValueInd) {}
        public SideValueInd(int val)
            :base(Tags.SideValueInd, val) {}


        // Field Enumerations
        public const int SIDE_VALUE_1 = 1;
        public const int SIDE_VALUE_2 = 2;
    }


    /// <summary>
    /// LiquidityPctLow Field
    /// </summary>/
    public sealed class LiquidityPctLow : DecimalField
    {
        public LiquidityPctLow()
            :base(Tags.LiquidityPctLow) {}
        public LiquidityPctLow(Decimal val)
            :base(Tags.LiquidityPctLow, val) {}

    }


    /// <summary>
    /// LiquidityPctHigh Field
    /// </summary>/
    public sealed class LiquidityPctHigh : DecimalField
    {
        public LiquidityPctHigh()
            :base(Tags.LiquidityPctHigh) {}
        public LiquidityPctHigh(Decimal val)
            :base(Tags.LiquidityPctHigh, val) {}

    }


    /// <summary>
    /// LiquidityValue Field
    /// </summary>/
    public sealed class LiquidityValue : DecimalField
    {
        public LiquidityValue()
            :base(Tags.LiquidityValue) {}
        public LiquidityValue(Decimal val)
            :base(Tags.LiquidityValue, val) {}

    }


    /// <summary>
    /// EFPTrackingError Field
    /// </summary>/
    public sealed class EFPTrackingError : DecimalField
    {
        public EFPTrackingError()
            :base(Tags.EFPTrackingError) {}
        public EFPTrackingError(Decimal val)
            :base(Tags.EFPTrackingError, val) {}

    }


    /// <summary>
    /// FairValue Field
    /// </summary>/
    public sealed class FairValue : DecimalField
    {
        public FairValue()
            :base(Tags.FairValue) {}
        public FairValue(Decimal val)
            :base(Tags.FairValue, val) {}

    }


    /// <summary>
    /// OutsideIndexPct Field
    /// </summary>/
    public sealed class OutsideIndexPct : DecimalField
    {
        public OutsideIndexPct()
            :base(Tags.OutsideIndexPct) {}
        public OutsideIndexPct(Decimal val)
            :base(Tags.OutsideIndexPct, val) {}

    }


    /// <summary>
    /// ValueOfFutures Field
    /// </summary>/
    public sealed class ValueOfFutures : DecimalField
    {
        public ValueOfFutures()
            :base(Tags.ValueOfFutures) {}
        public ValueOfFutures(Decimal val)
            :base(Tags.ValueOfFutures, val) {}

    }


    /// <summary>
    /// LiquidityIndType Field
    /// </summary>/
    public sealed class LiquidityIndType : IntField
    {
        public LiquidityIndType()
            :base(Tags.LiquidityIndType) {}
        public LiquidityIndType(int val)
            :base(Tags.LiquidityIndType, val) {}


        // Field Enumerations
        public const int VAL_5_DAY_MOVING_AVERAGE = 1;
        public const int VAL_20_DAY_MOVING_AVERAGE = 2;
        public const int NORMAL_MARKET_SIZE = 3;
        public const int OTHER = 4;
    }


    /// <summary>
    /// WtAverageLiquidity Field
    /// </summary>/
    public sealed class WtAverageLiquidity : DecimalField
    {
        public WtAverageLiquidity()
            :base(Tags.WtAverageLiquidity) {}
        public WtAverageLiquidity(Decimal val)
            :base(Tags.WtAverageLiquidity, val) {}

    }


    /// <summary>
    /// ExchangeForPhysical Field
    /// </summary>/
    public sealed class ExchangeForPhysical : BooleanField
    {
        public ExchangeForPhysical()
            :base(Tags.ExchangeForPhysical) {}
        public ExchangeForPhysical(Boolean val)
            :base(Tags.ExchangeForPhysical, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// OutMainCntryUIndex Field
    /// </summary>/
    public sealed class OutMainCntryUIndex : DecimalField
    {
        public OutMainCntryUIndex()
            :base(Tags.OutMainCntryUIndex) {}
        public OutMainCntryUIndex(Decimal val)
            :base(Tags.OutMainCntryUIndex, val) {}

    }


    /// <summary>
    /// CrossPercent Field
    /// </summary>/
    public sealed class CrossPercent : DecimalField
    {
        public CrossPercent()
            :base(Tags.CrossPercent) {}
        public CrossPercent(Decimal val)
            :base(Tags.CrossPercent, val) {}

    }


    /// <summary>
    /// ProgRptReqs Field
    /// </summary>/
    public sealed class ProgRptReqs : IntField
    {
        public ProgRptReqs()
            :base(Tags.ProgRptReqs) {}
        public ProgRptReqs(int val)
            :base(Tags.ProgRptReqs, val) {}


        // Field Enumerations
        public const int BUY_SIDE_EXPLICITLY_REQUESTS_STATUS_USING_STATUE_REQUEST = 1;
        public const int SELL_SIDE_PERIODICALLY_SENDS_STATUS_USING_LIST_STATUS_PERIOD_OPTIONALLY_SPECIFIED_IN_PROGRESSPERIOD = 2;
        public const int REAL_TIME_EXECUTION_REPORTS = 3;
    }


    /// <summary>
    /// ProgPeriodInterval Field
    /// </summary>/
    public sealed class ProgPeriodInterval : IntField
    {
        public ProgPeriodInterval()
            :base(Tags.ProgPeriodInterval) {}
        public ProgPeriodInterval(int val)
            :base(Tags.ProgPeriodInterval, val) {}

    }


    /// <summary>
    /// IncTaxInd Field
    /// </summary>/
    public sealed class IncTaxInd : IntField
    {
        public IncTaxInd()
            :base(Tags.IncTaxInd) {}
        public IncTaxInd(int val)
            :base(Tags.IncTaxInd, val) {}


        // Field Enumerations
        public const int NET = 1;
        public const int GROSS = 2;
    }


    /// <summary>
    /// NumBidders Field
    /// </summary>/
    public sealed class NumBidders : IntField
    {
        public NumBidders()
            :base(Tags.NumBidders) {}
        public NumBidders(int val)
            :base(Tags.NumBidders, val) {}

    }


    /// <summary>
    /// TradeType Field
    /// </summary>/
    public sealed class TradeType : CharField
    {
        public TradeType()
            :base(Tags.TradeType) {}
        public TradeType(char val)
            :base(Tags.TradeType, val) {}

    }


    /// <summary>
    /// BasisPxType Field
    /// </summary>/
    public sealed class BasisPxType : CharField
    {
        public BasisPxType()
            :base(Tags.BasisPxType) {}
        public BasisPxType(char val)
            :base(Tags.BasisPxType, val) {}


        // Field Enumerations
        public const char CLOSING_PRICE_AT_MORNINGN_SESSION = '2';
        public const char CLOSING_PRICE = '3';
        public const char CURRENT_PRICE = '4';
        public const char SQ = '5';
        public const char VWAP_THROUGH_A_DAY = '6';
        public const char VWAP_THROUGH_A_MORNING_SESSION = '7';
        public const char VWAP_THROUGH_AN_AFTERNOON_SESSION = '8';
        public const char VWAP_THROUGH_A_DAY_EXCEPT_YORI = '9';
        public const char VWAP_THROUGH_A_MORNING_SESSION_EXCEPT_YORI = 'A';
        public const char VWAP_THROUGH_AN_AFTERNOON_SESSION_EXCEPT_YORI = 'B';
        public const char STRIKE = 'C';
        public const char OPEN = 'D';
        public const char OTHERS = 'Z';
    }


    /// <summary>
    /// NoBidComponents Field
    /// </summary>/
    public sealed class NoBidComponents : IntField
    {
        public NoBidComponents()
            :base(Tags.NoBidComponents) {}
        public NoBidComponents(int val)
            :base(Tags.NoBidComponents, val) {}

    }


    /// <summary>
    /// Country Field
    /// </summary>/
    public sealed class Country : StringField
    {
        public Country()
            :base(Tags.Country) {}
        public Country(string val)
            :base(Tags.Country, val) {}

    }


    /// <summary>
    /// TotNoStrikes Field
    /// </summary>/
    public sealed class TotNoStrikes : IntField
    {
        public TotNoStrikes()
            :base(Tags.TotNoStrikes) {}
        public TotNoStrikes(int val)
            :base(Tags.TotNoStrikes, val) {}

    }


    /// <summary>
    /// PriceType Field
    /// </summary>/
    public sealed class PriceType : IntField
    {
        public PriceType()
            :base(Tags.PriceType) {}
        public PriceType(int val)
            :base(Tags.PriceType, val) {}


        // Field Enumerations
        public const int PERCENTAGE = 1;
        public const int FIXED_CABINET_TRADE_PRICE = 10;
        public const int VARIABLE_CABINET_TRADE_PRICE = 11;
        public const int PER_UNIT = 2;
        public const int FIXED_AMOUNT = 3;
        public const int DISCOUNT = 4;
        public const int PREMIUM = 5;
        public const int SPREAD = 6;
        public const int TED_PRICE = 7;
        public const int TED_YIELD = 8;
        public const int YIELD = 9;
        public const int PRODUCT_TICKS_IN_HALFS = 13;
        public const int PRODUCT_TICKS_IN_FOURTHS = 14;
        public const int PRODUCT_TICKS_IN_EIGHTS = 15;
        public const int PRODUCT_TICKS_IN_SIXTEENTHS = 16;
        public const int PRODUCT_TICKS_IN_THIRTY_SECONDS = 17;
        public const int PRODUCT_TICKS_IN_SIXTY_FORTHS = 18;
        public const int PRODUCT_TICKS_IN_ONE_TWENTY_EIGHTS = 19;
    }


    /// <summary>
    /// DayOrderQty Field
    /// </summary>/
    public sealed class DayOrderQty : DecimalField
    {
        public DayOrderQty()
            :base(Tags.DayOrderQty) {}
        public DayOrderQty(Decimal val)
            :base(Tags.DayOrderQty, val) {}

    }


    /// <summary>
    /// DayCumQty Field
    /// </summary>/
    public sealed class DayCumQty : DecimalField
    {
        public DayCumQty()
            :base(Tags.DayCumQty) {}
        public DayCumQty(Decimal val)
            :base(Tags.DayCumQty, val) {}

    }


    /// <summary>
    /// DayAvgPx Field
    /// </summary>/
    public sealed class DayAvgPx : DecimalField
    {
        public DayAvgPx()
            :base(Tags.DayAvgPx) {}
        public DayAvgPx(Decimal val)
            :base(Tags.DayAvgPx, val) {}

    }


    /// <summary>
    /// GTBookingInst Field
    /// </summary>/
    public sealed class GTBookingInst : IntField
    {
        public GTBookingInst()
            :base(Tags.GTBookingInst) {}
        public GTBookingInst(int val)
            :base(Tags.GTBookingInst, val) {}


        // Field Enumerations
        public const int BOOK_OUT_ALL_TRADES_ON_DAY_OF_EXECUTION = 0;
        public const int ACCUMULATE_EXECTUIONS_UNTIL_FORDER_IS_FILLED_OR_EXPIRES = 1;
        public const int ACCUMULATE_UNTIL_VERBALLLY_NOTIFIED_OTHERWISE = 2;
    }


    /// <summary>
    /// NoStrikes Field
    /// </summary>/
    public sealed class NoStrikes : IntField
    {
        public NoStrikes()
            :base(Tags.NoStrikes) {}
        public NoStrikes(int val)
            :base(Tags.NoStrikes, val) {}

    }


    /// <summary>
    /// ListStatusType Field
    /// </summary>/
    public sealed class ListStatusType : IntField
    {
        public ListStatusType()
            :base(Tags.ListStatusType) {}
        public ListStatusType(int val)
            :base(Tags.ListStatusType, val) {}


        // Field Enumerations
        public const int ACK = 1;
        public const int RESPONSE = 2;
        public const int TIMED = 3;
        public const int EXEC_STARTED = 4;
        public const int ALL_DONE = 5;
        public const int ALERT = 6;
    }


    /// <summary>
    /// NetGrossInd Field
    /// </summary>/
    public sealed class NetGrossInd : IntField
    {
        public NetGrossInd()
            :base(Tags.NetGrossInd) {}
        public NetGrossInd(int val)
            :base(Tags.NetGrossInd, val) {}


        // Field Enumerations
        public const int NET = 1;
        public const int GROSS = 2;
    }


    /// <summary>
    /// ListOrderStatus Field
    /// </summary>/
    public sealed class ListOrderStatus : IntField
    {
        public ListOrderStatus()
            :base(Tags.ListOrderStatus) {}
        public ListOrderStatus(int val)
            :base(Tags.ListOrderStatus, val) {}


        // Field Enumerations
        public const int IN_BIDDING_PROCESS = 1;
        public const int RECEIVED_FOR_EXECUTION = 2;
        public const int EXECUTING = 3;
        public const int CANCELLING = 4;
        public const int ALERT = 5;
        public const int ALL_DONE = 6;
        public const int REJECT = 7;
    }


    /// <summary>
    /// ExpireDate Field
    /// </summary>/
    public sealed class ExpireDate : StringField
    {
        public ExpireDate()
            :base(Tags.ExpireDate) {}
        public ExpireDate(string val)
            :base(Tags.ExpireDate, val) {}

    }


    /// <summary>
    /// ListExecInstType Field
    /// </summary>/
    public sealed class ListExecInstType : CharField
    {
        public ListExecInstType()
            :base(Tags.ListExecInstType) {}
        public ListExecInstType(char val)
            :base(Tags.ListExecInstType, val) {}


        // Field Enumerations
        public const char IMMEDIATE = '1';
        public const char WAIT_FOR_EXECUT_INSTRUCTION = '2';
        public const char EXCHANGE_SWITCH_CIV_ORDER_3 = '3';
        public const char EXCHANGE_SWITCH_CIV_ORDER_4 = '4';
        public const char EXCHANGE_SWITCH_CIV_ORDER_5 = '5';
    }


    /// <summary>
    /// CxlRejResponseTo Field
    /// </summary>/
    public sealed class CxlRejResponseTo : CharField
    {
        public CxlRejResponseTo()
            :base(Tags.CxlRejResponseTo) {}
        public CxlRejResponseTo(char val)
            :base(Tags.CxlRejResponseTo, val) {}


        // Field Enumerations
        public const char ORDER_CANCEL_REQUEST = '1';
        public const char ORDER_CANCEL_REPLACE_REQUEST = '2';
    }


    /// <summary>
    /// UnderlyingCouponRate Field
    /// </summary>/
    public sealed class UnderlyingCouponRate : DecimalField
    {
        public UnderlyingCouponRate()
            :base(Tags.UnderlyingCouponRate) {}
        public UnderlyingCouponRate(Decimal val)
            :base(Tags.UnderlyingCouponRate, val) {}

    }


    /// <summary>
    /// UnderlyingContractMultiplier Field
    /// </summary>/
    public sealed class UnderlyingContractMultiplier : DecimalField
    {
        public UnderlyingContractMultiplier()
            :base(Tags.UnderlyingContractMultiplier) {}
        public UnderlyingContractMultiplier(Decimal val)
            :base(Tags.UnderlyingContractMultiplier, val) {}

    }


    /// <summary>
    /// ContraTradeQty Field
    /// </summary>/
    public sealed class ContraTradeQty : DecimalField
    {
        public ContraTradeQty()
            :base(Tags.ContraTradeQty) {}
        public ContraTradeQty(Decimal val)
            :base(Tags.ContraTradeQty, val) {}

    }


    /// <summary>
    /// ContraTradeTime Field
    /// </summary>/
    public sealed class ContraTradeTime : DateTimeField
    {
        public ContraTradeTime()
            :base(Tags.ContraTradeTime) {}
        public ContraTradeTime(DateTime val)
            :base(Tags.ContraTradeTime, val) {}

    }


    /// <summary>
    /// ClearingFirm Field
    /// </summary>/
    public sealed class ClearingFirm : StringField
    {
        public ClearingFirm()
            :base(Tags.ClearingFirm) {}
        public ClearingFirm(string val)
            :base(Tags.ClearingFirm, val) {}

    }


    /// <summary>
    /// ClearingAccount Field
    /// </summary>/
    public sealed class ClearingAccount : StringField
    {
        public ClearingAccount()
            :base(Tags.ClearingAccount) {}
        public ClearingAccount(string val)
            :base(Tags.ClearingAccount, val) {}

    }


    /// <summary>
    /// LiquidityNumSecurities Field
    /// </summary>/
    public sealed class LiquidityNumSecurities : IntField
    {
        public LiquidityNumSecurities()
            :base(Tags.LiquidityNumSecurities) {}
        public LiquidityNumSecurities(int val)
            :base(Tags.LiquidityNumSecurities, val) {}

    }


    /// <summary>
    /// MultiLegReportingType Field
    /// </summary>/
    public sealed class MultiLegReportingType : CharField
    {
        public MultiLegReportingType()
            :base(Tags.MultiLegReportingType) {}
        public MultiLegReportingType(char val)
            :base(Tags.MultiLegReportingType, val) {}


        // Field Enumerations
        public const char SINGLE_SECURITY = '1';
        public const char INDIVIDUAL_LEG_OF_A_MULTILEG_SECURITY = '2';
        public const char MULTI_LEG_SECURITY = '3';
    }


    /// <summary>
    /// StrikeTime Field
    /// </summary>/
    public sealed class StrikeTime : DateTimeField
    {
        public StrikeTime()
            :base(Tags.StrikeTime) {}
        public StrikeTime(DateTime val)
            :base(Tags.StrikeTime, val) {}

    }


    /// <summary>
    /// ListStatusText Field
    /// </summary>/
    public sealed class ListStatusText : StringField
    {
        public ListStatusText()
            :base(Tags.ListStatusText) {}
        public ListStatusText(string val)
            :base(Tags.ListStatusText, val) {}

    }


    /// <summary>
    /// EncodedListStatusTextLen Field
    /// </summary>/
    public sealed class EncodedListStatusTextLen : DecimalField
    {
        public EncodedListStatusTextLen()
            :base(Tags.EncodedListStatusTextLen) {}
        public EncodedListStatusTextLen(Decimal val)
            :base(Tags.EncodedListStatusTextLen, val) {}

    }


    /// <summary>
    /// EncodedListStatusText Field
    /// </summary>/
    public sealed class EncodedListStatusText : StringField
    {
        public EncodedListStatusText()
            :base(Tags.EncodedListStatusText) {}
        public EncodedListStatusText(string val)
            :base(Tags.EncodedListStatusText, val) {}

    }


    /// <summary>
    /// SecurityIDSource Field
    /// </summary>/
    public sealed class SecurityIDSource : StringField
    {
        public SecurityIDSource()
            :base(Tags.SecurityIDSource) {}
        public SecurityIDSource(string val)
            :base(Tags.SecurityIDSource, val) {}


        // Field Enumerations
        public const string CUSIP = "1";
        public const string SEDOL = "2";
        public const string QUIK = "3";
        public const string ISIN_NUMBER = "4";
        public const string RIC_CODE = "5";
        public const string ISO_CURRENCY_CODE = "6";
        public const string ISO_COUNTRY_CODE = "7";
        public const string EXCHANGE_SYMBOL = "8";
        public const string CONSOLIDATED_TAPE_ASSOCIATION = "9";
        public const string BLOOMBERG_SYMBOL = "A";
        public const string WERTPAPIER = "B";
        public const string DUTCH = "C";
        public const string VALOREN = "D";
        public const string SICOVAM = "E";
        public const string BELGIAN = "F";
        public const string COMMON = "G";
        public const string CLEARING_HOUSE = "H";
        public const string ISDA_FPML_PRODUCT_SPECIFICATION = "I";
        public const string OPTION_PRICE_REPORTING_AUTHORITY = "J";
        public const string LETTER_OF_CREDIT = "L";
        public const string ISDA_FPML_PRODUCT_URL = "K";
    }


    /// <summary>
    /// IOIQty Field
    /// </summary>/
    public sealed class IOIQty : StringField
    {
        public IOIQty()
            :base(Tags.IOIQty) {}
        public IOIQty(string val)
            :base(Tags.IOIQty, val) {}


        // Field Enumerations
        public const string VAL_1000000000 = "0";
        public const string SMALL = "S";
        public const string MEDIUM = "M";
        public const string LARGE = "L";
        public const string UNDISCLOSED_QUANTITY = "U";
    }


    /// <summary>
    /// LastQty Field
    /// </summary>/
    public sealed class LastQty : DecimalField
    {
        public LastQty()
            :base(Tags.LastQty) {}
        public LastQty(Decimal val)
            :base(Tags.LastQty, val) {}

    }


    /// <summary>
    /// SendingDate Field
    /// </summary>/
    public sealed class SendingDate : StringField
    {
        public SendingDate()
            :base(Tags.SendingDate) {}
        public SendingDate(string val)
            :base(Tags.SendingDate, val) {}

    }


    /// <summary>
    /// Quantity Field
    /// </summary>/
    public sealed class Quantity : DecimalField
    {
        public Quantity()
            :base(Tags.Quantity) {}
        public Quantity(Decimal val)
            :base(Tags.Quantity, val) {}

    }


    /// <summary>
    /// PositionEffect Field
    /// </summary>/
    public sealed class PositionEffect : CharField
    {
        public PositionEffect()
            :base(Tags.PositionEffect) {}
        public PositionEffect(char val)
            :base(Tags.PositionEffect, val) {}


        // Field Enumerations
        public const char CLOSE = 'C';
        public const char FIFO = 'F';
        public const char OPEN = 'O';
        public const char ROLLED = 'R';
    }


    /// <summary>
    /// AllocQty Field
    /// </summary>/
    public sealed class AllocQty : DecimalField
    {
        public AllocQty()
            :base(Tags.AllocQty) {}
        public AllocQty(Decimal val)
            :base(Tags.AllocQty, val) {}

    }


    /// <summary>
    /// Spread Field
    /// </summary>/
    public sealed class Spread : DecimalField
    {
        public Spread()
            :base(Tags.Spread) {}
        public Spread(Decimal val)
            :base(Tags.Spread, val) {}

    }


    /// <summary>
    /// BenchmarkCurveCurrency Field
    /// </summary>/
    public sealed class BenchmarkCurveCurrency : DecimalField
    {
        public BenchmarkCurveCurrency()
            :base(Tags.BenchmarkCurveCurrency) {}
        public BenchmarkCurveCurrency(Decimal val)
            :base(Tags.BenchmarkCurveCurrency, val) {}

    }


    /// <summary>
    /// BenchmarkCurveName Field
    /// </summary>/
    public sealed class BenchmarkCurveName : StringField
    {
        public BenchmarkCurveName()
            :base(Tags.BenchmarkCurveName) {}
        public BenchmarkCurveName(string val)
            :base(Tags.BenchmarkCurveName, val) {}


        // Field Enumerations
        public const string EONIA = "EONIA";
        public const string EUREPO = "EUREPO";
        public const string EURIBOR = "Euribor";
        public const string FUTURESWAP = "FutureSWAP";
        public const string LIBID = "LIBID";
        public const string LIBOR = "LIBOR";
        public const string MUNIAAA = "MuniAAA";
        public const string OTHER = "OTHER";
        public const string PFANDBRIEFE = "Pfandbriefe";
        public const string SONIA = "SONIA";
        public const string SWAP = "SWAP";
        public const string TREASURY = "Treasury";
    }


    /// <summary>
    /// BenchmarkCurvePoint Field
    /// </summary>/
    public sealed class BenchmarkCurvePoint : StringField
    {
        public BenchmarkCurvePoint()
            :base(Tags.BenchmarkCurvePoint) {}
        public BenchmarkCurvePoint(string val)
            :base(Tags.BenchmarkCurvePoint, val) {}

    }


    /// <summary>
    /// CouponPaymentDate Field
    /// </summary>/
    public sealed class CouponPaymentDate : StringField
    {
        public CouponPaymentDate()
            :base(Tags.CouponPaymentDate) {}
        public CouponPaymentDate(string val)
            :base(Tags.CouponPaymentDate, val) {}

    }


    /// <summary>
    /// IssueDate Field
    /// </summary>/
    public sealed class IssueDate : StringField
    {
        public IssueDate()
            :base(Tags.IssueDate) {}
        public IssueDate(string val)
            :base(Tags.IssueDate, val) {}

    }


    /// <summary>
    /// RepurchaseTerm Field
    /// </summary>/
    public sealed class RepurchaseTerm : IntField
    {
        public RepurchaseTerm()
            :base(Tags.RepurchaseTerm) {}
        public RepurchaseTerm(int val)
            :base(Tags.RepurchaseTerm, val) {}

    }


    /// <summary>
    /// RepurchaseRate Field
    /// </summary>/
    public sealed class RepurchaseRate : DecimalField
    {
        public RepurchaseRate()
            :base(Tags.RepurchaseRate) {}
        public RepurchaseRate(Decimal val)
            :base(Tags.RepurchaseRate, val) {}

    }


    /// <summary>
    /// Factor Field
    /// </summary>/
    public sealed class Factor : DecimalField
    {
        public Factor()
            :base(Tags.Factor) {}
        public Factor(Decimal val)
            :base(Tags.Factor, val) {}

    }


    /// <summary>
    /// TradeOriginationDate Field
    /// </summary>/
    public sealed class TradeOriginationDate : StringField
    {
        public TradeOriginationDate()
            :base(Tags.TradeOriginationDate) {}
        public TradeOriginationDate(string val)
            :base(Tags.TradeOriginationDate, val) {}

    }


    /// <summary>
    /// ExDate Field
    /// </summary>/
    public sealed class ExDate : StringField
    {
        public ExDate()
            :base(Tags.ExDate) {}
        public ExDate(string val)
            :base(Tags.ExDate, val) {}

    }


    /// <summary>
    /// NoStipulations Field
    /// </summary>/
    public sealed class NoStipulations : IntField
    {
        public NoStipulations()
            :base(Tags.NoStipulations) {}
        public NoStipulations(int val)
            :base(Tags.NoStipulations, val) {}

    }


    /// <summary>
    /// StipulationType Field
    /// </summary>/
    public sealed class StipulationType : StringField
    {
        public StipulationType()
            :base(Tags.StipulationType) {}
        public StipulationType(string val)
            :base(Tags.StipulationType, val) {}


        // Field Enumerations
        public const string ABSOLUTE_PREPAYMENT_SPEED = "ABS";
        public const string ALTERNATIVE_MINIMUM_TAX = "AMT";
        public const string AUTO_REINVESTMENT_AT_RATE_OR_BETTER = "AUTOREINV";
        public const string BANK_QUALIFIED = "BANKQUAL";
        public const string BARGAIN_CONDITIONS = "BGNCON";
        public const string COUPON_RANGE = "COUPON";
        public const string CONSTANT_PREPAYMENT_PENALTY = "CPP";
        public const string CONSTANT_PREPAYMENT_RATE = "CPR";
        public const string CONSTANT_PREPAYMENT_YIELD = "CPY";
        public const string ISO_CURRENCY_CODE = "CURRENCY";
        public const string CUSTOM_START_END_DATE = "CUSTOMDATE";
        public const string GEOGRAPHICS_AND_RANGE = "GEOG";
        public const string VALUATION_DISCOUNT = "HAIRCUT";
        public const string FINAL_CPR_OF_HOME_EQUITY_PREPAYMENT_CURVE = "HEP";
        public const string INSURED = "INSURED";
        public const string YEAR_OR_YEAR_MONTH_OF_ISSUE = "ISSUE";
        public const string ISSUERS_TICKER = "ISSUER";
        public const string ISSUE_SIZE_RANGE = "ISSUESIZE";
        public const string LOOKBACK_DAYS = "LOOKBACK";
        public const string EXPLICIT_LOT_IDENTIFIER = "LOT";
        public const string LOT_VARIANCE = "LOTVAR";
        public const string MATURITY_YEAR_AND_MONTH = "MAT";
        public const string MATURITY_RANGE = "MATURITY";
        public const string MAXIMUM_SUBSTITUTIONS = "MAXSUBS";
        public const string PERCENT_OF_MANUFACTURED_HOUSING_PREPAYMENT_CURVE = "MHP";
        public const string MINIMUM_DENOMINATION = "MINDNOM";
        public const string MINIMUM_INCREMENT = "MININCR";
        public const string MINIMUM_QUANTITY = "MINQTY";
        public const string MONTHLY_PREPAYMENT_RATE = "MPR";
        public const string PAYMENT_FREQUENCY_CALENDAR = "PAYFREQ";
        public const string NUMBER_OF_PIECES = "PIECES";
        public const string POOLS_MAXIMUM = "PMAX";
        public const string PERCENT_OF_PROSPECTUS_PREPAYMENT_CURVE = "PPC";
        public const string POOLS_PER_LOT = "PPL";
        public const string POOLS_PER_MILLION = "PPM";
        public const string POOLS_PER_TRADE = "PPT";
        public const string PRICE_RANGE = "PRICE";
        public const string PRICING_FREQUENCY = "PRICEFREQ";
        public const string PRODUCTION_YEAR = "PROD";
        public const string CALL_PROTECTION = "PROTECT";
        public const string PERCENT_OF_BMA_PREPAYMENT_CURVE = "PSA";
        public const string PURPOSE = "PURPOSE";
        public const string BENCHMARK_PRICE_SOURCE = "PXSOURCE";
        public const string RATING_SOURCE_AND_RANGE = "RATING";
        public const string TYPE_OF_REDEMPTION = "REDEMPTION";
        public const string RESTRICTED = "RESTRICTED";
        public const string MARKET_SECTOR = "SECTOR";
        public const string SECURITY_TYPE_INCLUDED_OR_EXCLUDED = "SECTYPE";
        public const string SINGLE_MONTHLY_MORTALITY = "SMM";
        public const string STRUCTURE = "STRUCT";
        public const string SUBSTITUTIONS_FREQUENCY = "SUBSFREQ";
        public const string SUBSTITUTIONS_LEFT = "SUBSLEFT";
        public const string FREEFORM_TEXT = "TEXT";
        public const string TRADE_VARIANCE = "TRDVAR";
        public const string WEIGHTED_AVERAGE_COUPON = "WAC";
        public const string WEIGHTED_AVERAGE_LIFE_COUPON = "WAL";
        public const string WEIGHTED_AVERAGE_LOAN_AGE = "WALA";
        public const string WEIGHTED_AVERAGE_MATURITY = "WAM";
        public const string WHOLE_POOL = "WHOLE";
        public const string YIELD_RANGE = "YIELD";
    }


    /// <summary>
    /// StipulationValue Field
    /// </summary>/
    public sealed class StipulationValue : StringField
    {
        public StipulationValue()
            :base(Tags.StipulationValue) {}
        public StipulationValue(string val)
            :base(Tags.StipulationValue, val) {}

    }


    /// <summary>
    /// YieldType Field
    /// </summary>/
    public sealed class YieldType : StringField
    {
        public YieldType()
            :base(Tags.YieldType) {}
        public YieldType(string val)
            :base(Tags.YieldType, val) {}


        // Field Enumerations
        public const string AFTER_TAX_YIELD = "AFTERTAX";
        public const string ANNUAL_YIELD = "ANNUAL";
        public const string YIELD_AT_ISSUE = "ATISSUE";
        public const string YIELD_TO_AVG_MATURITY = "AVGMATURITY";
        public const string BOOK_YIELD = "BOOK";
        public const string YIELD_TO_NEXT_CALL = "CALL";
        public const string YIELD_CHANGE_SINCE_CLOSE = "CHANGE";
        public const string CLOSING_YIELD = "CLOSE";
        public const string COMPOUND_YIELD = "COMPOUND";
        public const string CURRENT_YIELD = "CURRENT";
        public const string GVNT_EQUIVALENT_YIELD = "GOVTEQUIV";
        public const string TRUE_GROSS_YIELD = "GROSS";
        public const string YIELD_WITH_INFLATION_ASSUMPTION = "INFLATION";
        public const string INVERSE_FLOATER_BOND_YIELD = "INVERSEFLOATER";
        public const string MOST_RECENT_CLOSING_YIELD = "LASTCLOSE";
        public const string CLOSING_YIELD_MOST_RECENT_MONTH = "LASTMONTH";
        public const string CLOSING_YIELD_MOST_RECENT_QUARTER = "LASTQUARTER";
        public const string CLOSING_YIELD_MOST_RECENT_YEAR = "LASTYEAR";
        public const string YIELD_TO_LONGEST_AVERAGE_LIFE = "LONGAVGLIFE";
        public const string MARK_TO_MARKET_YIELD = "MARK";
        public const string YIELD_TO_MATURITY = "MATURITY";
        public const string YIELD_TO_NEXT_REFUND = "NEXTREFUND";
        public const string OPEN_AVERAGE_YIELD = "OPENAVG";
        public const string PREVIOUS_CLOSE_YIELD = "PREVCLOSE";
        public const string PROCEEDS_YIELD = "PROCEEDS";
        public const string YIELD_TO_NEXT_PUT = "PUT";
        public const string SEMI_ANNUAL_YIELD = "SEMIANNUAL";
        public const string YIELD_TO_SHORTEST_AVERAGE_LIFE = "SHORTAVGLIFE";
        public const string SIMPLE_YIELD = "SIMPLE";
        public const string TAX_EQUIVALENT_YIELD = "TAXEQUIV";
        public const string YIELD_TO_TENDER_DATE = "TENDER";
        public const string TRUE_YIELD = "TRUE";
        public const string YIELD_VALUE_OF_1_32 = "VALUE1_32";
        public const string YIELD_TO_WORST = "WORST";
    }


    /// <summary>
    /// Yield Field
    /// </summary>/
    public sealed class Yield : DecimalField
    {
        public Yield()
            :base(Tags.Yield) {}
        public Yield(Decimal val)
            :base(Tags.Yield, val) {}

    }


    /// <summary>
    /// TotalTakedown Field
    /// </summary>/
    public sealed class TotalTakedown : DecimalField
    {
        public TotalTakedown()
            :base(Tags.TotalTakedown) {}
        public TotalTakedown(Decimal val)
            :base(Tags.TotalTakedown, val) {}

    }


    /// <summary>
    /// Concession Field
    /// </summary>/
    public sealed class Concession : DecimalField
    {
        public Concession()
            :base(Tags.Concession) {}
        public Concession(Decimal val)
            :base(Tags.Concession, val) {}

    }


    /// <summary>
    /// RepoCollateralSecurityType Field
    /// </summary>/
    public sealed class RepoCollateralSecurityType : IntField
    {
        public RepoCollateralSecurityType()
            :base(Tags.RepoCollateralSecurityType) {}
        public RepoCollateralSecurityType(int val)
            :base(Tags.RepoCollateralSecurityType, val) {}

    }


    /// <summary>
    /// RedemptionDate Field
    /// </summary>/
    public sealed class RedemptionDate : StringField
    {
        public RedemptionDate()
            :base(Tags.RedemptionDate) {}
        public RedemptionDate(string val)
            :base(Tags.RedemptionDate, val) {}

    }


    /// <summary>
    /// UnderlyingCouponPaymentDate Field
    /// </summary>/
    public sealed class UnderlyingCouponPaymentDate : StringField
    {
        public UnderlyingCouponPaymentDate()
            :base(Tags.UnderlyingCouponPaymentDate) {}
        public UnderlyingCouponPaymentDate(string val)
            :base(Tags.UnderlyingCouponPaymentDate, val) {}

    }


    /// <summary>
    /// UnderlyingIssueDate Field
    /// </summary>/
    public sealed class UnderlyingIssueDate : StringField
    {
        public UnderlyingIssueDate()
            :base(Tags.UnderlyingIssueDate) {}
        public UnderlyingIssueDate(string val)
            :base(Tags.UnderlyingIssueDate, val) {}

    }


    /// <summary>
    /// UnderlyingRepoCollateralSecurityType Field
    /// </summary>/
    public sealed class UnderlyingRepoCollateralSecurityType : IntField
    {
        public UnderlyingRepoCollateralSecurityType()
            :base(Tags.UnderlyingRepoCollateralSecurityType) {}
        public UnderlyingRepoCollateralSecurityType(int val)
            :base(Tags.UnderlyingRepoCollateralSecurityType, val) {}

    }


    /// <summary>
    /// UnderlyingRepurchaseTerm Field
    /// </summary>/
    public sealed class UnderlyingRepurchaseTerm : IntField
    {
        public UnderlyingRepurchaseTerm()
            :base(Tags.UnderlyingRepurchaseTerm) {}
        public UnderlyingRepurchaseTerm(int val)
            :base(Tags.UnderlyingRepurchaseTerm, val) {}

    }


    /// <summary>
    /// UnderlyingRepurchaseRate Field
    /// </summary>/
    public sealed class UnderlyingRepurchaseRate : DecimalField
    {
        public UnderlyingRepurchaseRate()
            :base(Tags.UnderlyingRepurchaseRate) {}
        public UnderlyingRepurchaseRate(Decimal val)
            :base(Tags.UnderlyingRepurchaseRate, val) {}

    }


    /// <summary>
    /// UnderlyingFactor Field
    /// </summary>/
    public sealed class UnderlyingFactor : DecimalField
    {
        public UnderlyingFactor()
            :base(Tags.UnderlyingFactor) {}
        public UnderlyingFactor(Decimal val)
            :base(Tags.UnderlyingFactor, val) {}

    }


    /// <summary>
    /// UnderlyingRedemptionDate Field
    /// </summary>/
    public sealed class UnderlyingRedemptionDate : StringField
    {
        public UnderlyingRedemptionDate()
            :base(Tags.UnderlyingRedemptionDate) {}
        public UnderlyingRedemptionDate(string val)
            :base(Tags.UnderlyingRedemptionDate, val) {}

    }


    /// <summary>
    /// LegCouponPaymentDate Field
    /// </summary>/
    public sealed class LegCouponPaymentDate : StringField
    {
        public LegCouponPaymentDate()
            :base(Tags.LegCouponPaymentDate) {}
        public LegCouponPaymentDate(string val)
            :base(Tags.LegCouponPaymentDate, val) {}

    }


    /// <summary>
    /// LegIssueDate Field
    /// </summary>/
    public sealed class LegIssueDate : StringField
    {
        public LegIssueDate()
            :base(Tags.LegIssueDate) {}
        public LegIssueDate(string val)
            :base(Tags.LegIssueDate, val) {}

    }


    /// <summary>
    /// LegRepoCollateralSecurityType Field
    /// </summary>/
    public sealed class LegRepoCollateralSecurityType : IntField
    {
        public LegRepoCollateralSecurityType()
            :base(Tags.LegRepoCollateralSecurityType) {}
        public LegRepoCollateralSecurityType(int val)
            :base(Tags.LegRepoCollateralSecurityType, val) {}

    }


    /// <summary>
    /// LegRepurchaseTerm Field
    /// </summary>/
    public sealed class LegRepurchaseTerm : IntField
    {
        public LegRepurchaseTerm()
            :base(Tags.LegRepurchaseTerm) {}
        public LegRepurchaseTerm(int val)
            :base(Tags.LegRepurchaseTerm, val) {}

    }


    /// <summary>
    /// LegRepurchaseRate Field
    /// </summary>/
    public sealed class LegRepurchaseRate : DecimalField
    {
        public LegRepurchaseRate()
            :base(Tags.LegRepurchaseRate) {}
        public LegRepurchaseRate(Decimal val)
            :base(Tags.LegRepurchaseRate, val) {}

    }


    /// <summary>
    /// LegFactor Field
    /// </summary>/
    public sealed class LegFactor : DecimalField
    {
        public LegFactor()
            :base(Tags.LegFactor) {}
        public LegFactor(Decimal val)
            :base(Tags.LegFactor, val) {}

    }


    /// <summary>
    /// LegRedemptionDate Field
    /// </summary>/
    public sealed class LegRedemptionDate : StringField
    {
        public LegRedemptionDate()
            :base(Tags.LegRedemptionDate) {}
        public LegRedemptionDate(string val)
            :base(Tags.LegRedemptionDate, val) {}

    }


    /// <summary>
    /// CreditRating Field
    /// </summary>/
    public sealed class CreditRating : StringField
    {
        public CreditRating()
            :base(Tags.CreditRating) {}
        public CreditRating(string val)
            :base(Tags.CreditRating, val) {}

    }


    /// <summary>
    /// UnderlyingCreditRating Field
    /// </summary>/
    public sealed class UnderlyingCreditRating : StringField
    {
        public UnderlyingCreditRating()
            :base(Tags.UnderlyingCreditRating) {}
        public UnderlyingCreditRating(string val)
            :base(Tags.UnderlyingCreditRating, val) {}

    }


    /// <summary>
    /// LegCreditRating Field
    /// </summary>/
    public sealed class LegCreditRating : StringField
    {
        public LegCreditRating()
            :base(Tags.LegCreditRating) {}
        public LegCreditRating(string val)
            :base(Tags.LegCreditRating, val) {}

    }


    /// <summary>
    /// TradedFlatSwitch Field
    /// </summary>/
    public sealed class TradedFlatSwitch : BooleanField
    {
        public TradedFlatSwitch()
            :base(Tags.TradedFlatSwitch) {}
        public TradedFlatSwitch(Boolean val)
            :base(Tags.TradedFlatSwitch, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// BasisFeatureDate Field
    /// </summary>/
    public sealed class BasisFeatureDate : StringField
    {
        public BasisFeatureDate()
            :base(Tags.BasisFeatureDate) {}
        public BasisFeatureDate(string val)
            :base(Tags.BasisFeatureDate, val) {}

    }


    /// <summary>
    /// BasisFeaturePrice Field
    /// </summary>/
    public sealed class BasisFeaturePrice : DecimalField
    {
        public BasisFeaturePrice()
            :base(Tags.BasisFeaturePrice) {}
        public BasisFeaturePrice(Decimal val)
            :base(Tags.BasisFeaturePrice, val) {}

    }


    /// <summary>
    /// QuoteStatus Field
    /// </summary>/
    public sealed class QuoteStatus : IntField
    {
        public QuoteStatus()
            :base(Tags.QuoteStatus) {}
        public QuoteStatus(int val)
            :base(Tags.QuoteStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int CANCEL_FOR_SYMBOL = 1;
        public const int PENDING = 10;
        public const int PASS = 11;
        public const int LOCKED_MARKET_WARNING = 12;
        public const int CROSS_MARKET_WARNING = 13;
        public const int CANCELED_DUE_TO_LOCK_MARKET = 14;
        public const int CANCELED_DUE_TO_CROSS_MARKET = 15;
        public const int CANCELED_FOR_SECURITY_TYPE = 2;
        public const int CANCELED_FOR_UNDERLYING = 3;
        public const int CANCELED_ALL = 4;
        public const int REJECTED = 5;
        public const int REMOVED_FROM_MARKET = 6;
        public const int EXPIRED = 7;
        public const int QUERY = 8;
        public const int QUOTE_NOT_FOUND = 9;
    }


    /// <summary>
    /// UnderlyingSecurityIDSource Field
    /// </summary>/
    public sealed class UnderlyingSecurityIDSource : StringField
    {
        public UnderlyingSecurityIDSource()
            :base(Tags.UnderlyingSecurityIDSource) {}
        public UnderlyingSecurityIDSource(string val)
            :base(Tags.UnderlyingSecurityIDSource, val) {}

    }


    /// <summary>
    /// PartyIDSource Field
    /// </summary>/
    public sealed class PartyIDSource : CharField
    {
        public PartyIDSource()
            :base(Tags.PartyIDSource) {}
        public PartyIDSource(char val)
            :base(Tags.PartyIDSource, val) {}


        // Field Enumerations
        public const char KOREAN_INVESTOR_ID = '1';
        public const char TAIWANESE_QUALIFIED_FOREIGN_INVESTOR_ID_QFII_FID = '2';
        public const char TAIWANESE_TRADING_ACCT = '3';
        public const char MALAYSIAN_CENTRAL_DEPOSITORY = '4';
        public const char CHINESE_INVESTOR_ID = '5';
        public const char UK_NATIONAL_INSURANCE_OR_PENSION_NUMBER = '6';
        public const char US_SOCIAL_SECURITY_NUMBER = '7';
        public const char US_EMPLOYER_OR_TAX_ID_NUMBER = '8';
        public const char AUSTRALIAN_BUSINESS_NUMBER = '9';
        public const char AUSTRALIAN_TAX_FILE_NUMBER = 'A';
        public const char BIC = 'B';
        public const char GENERALLY_ACCEPTED_MARKET_PARTICIPANT_IDENTIFIER = 'C';
        public const char PROPRIETARY = 'D';
        public const char ISO_COUNTRY_CODE = 'E';
        public const char SETTLEMENT_ENTITY_LOCATION = 'F';
        public const char MIC = 'G';
        public const char CSD_PARTICIPANT_MEMBER_CODE = 'H';
        public const char DIRECTED_BROKER_THREE_CHARACTER_ACRONYM_AS_DEFINED_IN_ISITC_ETC_BEST_PRACTICE_GUIDELINES_DOCUMENT = 'I';
    }


    /// <summary>
    /// PartyID Field
    /// </summary>/
    public sealed class PartyID : StringField
    {
        public PartyID()
            :base(Tags.PartyID) {}
        public PartyID(string val)
            :base(Tags.PartyID, val) {}

    }


    /// <summary>
    /// TotalVolumeTradedDate Field
    /// </summary>/
    public sealed class TotalVolumeTradedDate : DateTimeField
    {
        public TotalVolumeTradedDate()
            :base(Tags.TotalVolumeTradedDate) {}
        public TotalVolumeTradedDate(DateTime val)
            :base(Tags.TotalVolumeTradedDate, val) {}

    }


    /// <summary>
    /// TotalVolumeTradedTime Field
    /// </summary>/
    public sealed class TotalVolumeTradedTime : DateTimeField
    {
        public TotalVolumeTradedTime()
            :base(Tags.TotalVolumeTradedTime) {}
        public TotalVolumeTradedTime(DateTime val)
            :base(Tags.TotalVolumeTradedTime, val) {}

    }


    /// <summary>
    /// NetChgPrevDay Field
    /// </summary>/
    public sealed class NetChgPrevDay : DecimalField
    {
        public NetChgPrevDay()
            :base(Tags.NetChgPrevDay) {}
        public NetChgPrevDay(Decimal val)
            :base(Tags.NetChgPrevDay, val) {}

    }


    /// <summary>
    /// PartyRole Field
    /// </summary>/
    public sealed class PartyRole : IntField
    {
        public PartyRole()
            :base(Tags.PartyRole) {}
        public PartyRole(int val)
            :base(Tags.PartyRole, val) {}


        // Field Enumerations
        public const int EXECUTING_FIRM = 1;
        public const int SETTLEMENT_LOCATION = 10;
        public const int ORDER_ORIGINATION_TRADER = 11;
        public const int EXECUTING_TRADER = 12;
        public const int ORDER_ORIGINATION_FIRM = 13;
        public const int GIVEUP_CLEARING_FIRM = 14;
        public const int CORRESPONDANT_CLEARING_FIRM = 15;
        public const int EXECUTING_SYSTEM = 16;
        public const int CONTRA_FIRM = 17;
        public const int CONTRA_CLEARING_FIRM = 18;
        public const int SPONSORING_FIRM = 19;
        public const int BROKER_OF_CREDIT = 2;
        public const int UNDERLYING_CONTRA_FIRM = 20;
        public const int CLEARING_ORGANIZATION = 21;
        public const int EXCHANGE = 22;
        public const int CUSTOMER_ACCOUNT = 24;
        public const int CORRESPONDENT_CLEARING_ORGANIZATION = 25;
        public const int CORRESPONDENT_BROKER = 26;
        public const int BUYER_SELLER = 27;
        public const int CUSTODIAN = 28;
        public const int INTERMEDIARY = 29;
        public const int CLIENT_ID = 3;
        public const int AGENT = 30;
        public const int SUB_CUSTODIAN = 31;
        public const int BENEFICIARY = 32;
        public const int INTERESTED_PARTY = 33;
        public const int REGULATORY_BODY = 34;
        public const int LIQUIDITY_PROVIDER = 35;
        public const int ENTERING_TRADER = 36;
        public const int CONTRA_TRADER = 37;
        public const int POSITION_ACCOUNT = 38;
        public const int CLEARING_FIRM = 4;
        public const int INVESTOR_ID = 5;
        public const int INTRODUCING_FIRM = 6;
        public const int ENTERING_FIRM = 7;
        public const int LOCATE = 8;
        public const int FUND_MANAGER_CLIENT_ID = 9;
        public const int INTRODUCING_BROKER = 60;
        public const int CONTRA_POSITION_ACCOUNT = 41;
        public const int CONTRA_EXCHANGE = 42;
        public const int INTERNAL_CARRY_ACCOUNT = 43;
        public const int ORDER_ENTRY_OPERATOR_ID = 44;
        public const int SECONDARY_ACCOUNT_NUMBER = 45;
        public const int FORIEGN_FIRM = 46;
        public const int THIRD_PARTY_ALLOCATION_FIRM = 47;
        public const int CLAIMING_ACCOUNT = 48;
        public const int ASSET_MANAGER = 49;
        public const int PLEDGOR_ACCOUNT = 50;
        public const int PLEDGEE_ACCOUNT = 51;
        public const int LARGE_TRADER_REPORTABLE_ACCOUNT = 52;
        public const int TRADER_MNEMONIC = 53;
        public const int SENDER_LOCATION = 54;
        public const int SESSION_ID = 55;
        public const int ACCEPTABLE_COUNTERPARTY = 56;
        public const int UNACCEPTABLE_COUNTERPARTY = 57;
        public const int ENTERING_UNIT = 58;
        public const int EXECUTING_UNIT = 59;
        public const int CONTRA_INVESTOR_ID = 39;
        public const int TRANSFER_TO_FIRM = 40;
        public const int QUOTE_ORIGINATOR = 61;
        public const int REPORT_ORIGINATOR = 62;
        public const int SYSTEMATIC_INTERNALISER = 63;
        public const int MULTILATERAL_TRADING_FACILITY = 64;
        public const int REGULATED_MARKET = 65;
        public const int MARKET_MAKER = 66;
        public const int INVESTMENT_FIRM = 67;
        public const int HOST_COMPETENT_AUTHORITY = 68;
        public const int HOME_COMPETENT_AUTHORITY = 69;
        public const int COMPETENT_AUTHORITY_OF_THE_MOST_RELEVANT_MARKET_IN_TERMS_OF_LIQUIDITY = 70;
        public const int COMPETENT_AUTHORITY_OF_THE_TRANSACTION = 71;
        public const int REPORTING_INTERMEDIARY = 72;
        public const int EXECUTION_VENUE = 73;
        public const int MARKET_DATA_ENTRY_ORIGINATOR = 74;
        public const int LOCATION_ID = 75;
        public const int DESK_ID = 76;
        public const int MARKET_DATA_MARKET = 77;
        public const int ALLOCATION_ENTITY = 78;
    }


    /// <summary>
    /// NoPartyIDs Field
    /// </summary>/
    public sealed class NoPartyIDs : IntField
    {
        public NoPartyIDs()
            :base(Tags.NoPartyIDs) {}
        public NoPartyIDs(int val)
            :base(Tags.NoPartyIDs, val) {}

    }


    /// <summary>
    /// NoSecurityAltID Field
    /// </summary>/
    public sealed class NoSecurityAltID : IntField
    {
        public NoSecurityAltID()
            :base(Tags.NoSecurityAltID) {}
        public NoSecurityAltID(int val)
            :base(Tags.NoSecurityAltID, val) {}

    }


    /// <summary>
    /// SecurityAltID Field
    /// </summary>/
    public sealed class SecurityAltID : StringField
    {
        public SecurityAltID()
            :base(Tags.SecurityAltID) {}
        public SecurityAltID(string val)
            :base(Tags.SecurityAltID, val) {}

    }


    /// <summary>
    /// SecurityAltIDSource Field
    /// </summary>/
    public sealed class SecurityAltIDSource : StringField
    {
        public SecurityAltIDSource()
            :base(Tags.SecurityAltIDSource) {}
        public SecurityAltIDSource(string val)
            :base(Tags.SecurityAltIDSource, val) {}

    }


    /// <summary>
    /// NoUnderlyingSecurityAltID Field
    /// </summary>/
    public sealed class NoUnderlyingSecurityAltID : IntField
    {
        public NoUnderlyingSecurityAltID()
            :base(Tags.NoUnderlyingSecurityAltID) {}
        public NoUnderlyingSecurityAltID(int val)
            :base(Tags.NoUnderlyingSecurityAltID, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityAltID Field
    /// </summary>/
    public sealed class UnderlyingSecurityAltID : StringField
    {
        public UnderlyingSecurityAltID()
            :base(Tags.UnderlyingSecurityAltID) {}
        public UnderlyingSecurityAltID(string val)
            :base(Tags.UnderlyingSecurityAltID, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityAltIDSource Field
    /// </summary>/
    public sealed class UnderlyingSecurityAltIDSource : StringField
    {
        public UnderlyingSecurityAltIDSource()
            :base(Tags.UnderlyingSecurityAltIDSource) {}
        public UnderlyingSecurityAltIDSource(string val)
            :base(Tags.UnderlyingSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// Product Field
    /// </summary>/
    public sealed class Product : IntField
    {
        public Product()
            :base(Tags.Product) {}
        public Product(int val)
            :base(Tags.Product, val) {}


        // Field Enumerations
        public const int AGENCY = 1;
        public const int MORTGAGE = 10;
        public const int MUNICIPAL = 11;
        public const int OTHER = 12;
        public const int FINANCING = 13;
        public const int COMMODITY = 2;
        public const int CORPORATE = 3;
        public const int CURRENCY = 4;
        public const int EQUITY = 5;
        public const int GOVERNMENT = 6;
        public const int INDEX = 7;
        public const int LOAN = 8;
        public const int MONEYMARKET = 9;
    }


    /// <summary>
    /// CFICode Field
    /// </summary>/
    public sealed class CFICode : StringField
    {
        public CFICode()
            :base(Tags.CFICode) {}
        public CFICode(string val)
            :base(Tags.CFICode, val) {}

    }


    /// <summary>
    /// UnderlyingProduct Field
    /// </summary>/
    public sealed class UnderlyingProduct : IntField
    {
        public UnderlyingProduct()
            :base(Tags.UnderlyingProduct) {}
        public UnderlyingProduct(int val)
            :base(Tags.UnderlyingProduct, val) {}

    }


    /// <summary>
    /// UnderlyingCFICode Field
    /// </summary>/
    public sealed class UnderlyingCFICode : StringField
    {
        public UnderlyingCFICode()
            :base(Tags.UnderlyingCFICode) {}
        public UnderlyingCFICode(string val)
            :base(Tags.UnderlyingCFICode, val) {}

    }


    /// <summary>
    /// TestMessageIndicator Field
    /// </summary>/
    public sealed class TestMessageIndicator : BooleanField
    {
        public TestMessageIndicator()
            :base(Tags.TestMessageIndicator) {}
        public TestMessageIndicator(Boolean val)
            :base(Tags.TestMessageIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// QuantityType Field
    /// </summary>/
    public sealed class QuantityType : IntField
    {
        public QuantityType()
            :base(Tags.QuantityType) {}
        public QuantityType(int val)
            :base(Tags.QuantityType, val) {}


        // Field Enumerations
        public const int SHARES = 1;
        public const int BONDS = 2;
        public const int CURRENTFACE = 3;
        public const int ORIGINALFACE = 4;
        public const int CURRENCY = 5;
        public const int CONTRACTS = 6;
        public const int OTHER = 7;
        public const int PAR = 8;
    }


    /// <summary>
    /// BookingRefID Field
    /// </summary>/
    public sealed class BookingRefID : StringField
    {
        public BookingRefID()
            :base(Tags.BookingRefID) {}
        public BookingRefID(string val)
            :base(Tags.BookingRefID, val) {}

    }


    /// <summary>
    /// IndividualAllocID Field
    /// </summary>/
    public sealed class IndividualAllocID : StringField
    {
        public IndividualAllocID()
            :base(Tags.IndividualAllocID) {}
        public IndividualAllocID(string val)
            :base(Tags.IndividualAllocID, val) {}

    }


    /// <summary>
    /// RoundingDirection Field
    /// </summary>/
    public sealed class RoundingDirection : CharField
    {
        public RoundingDirection()
            :base(Tags.RoundingDirection) {}
        public RoundingDirection(char val)
            :base(Tags.RoundingDirection, val) {}


        // Field Enumerations
        public const char ROUND_TO_NEAREST = '0';
        public const char ROUND_DOWN = '1';
        public const char ROUND_UP = '2';
    }


    /// <summary>
    /// RoundingModulus Field
    /// </summary>/
    public sealed class RoundingModulus : DecimalField
    {
        public RoundingModulus()
            :base(Tags.RoundingModulus) {}
        public RoundingModulus(Decimal val)
            :base(Tags.RoundingModulus, val) {}

    }


    /// <summary>
    /// CountryOfIssue Field
    /// </summary>/
    public sealed class CountryOfIssue : StringField
    {
        public CountryOfIssue()
            :base(Tags.CountryOfIssue) {}
        public CountryOfIssue(string val)
            :base(Tags.CountryOfIssue, val) {}

    }


    /// <summary>
    /// StateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class StateOrProvinceOfIssue : StringField
    {
        public StateOrProvinceOfIssue()
            :base(Tags.StateOrProvinceOfIssue) {}
        public StateOrProvinceOfIssue(string val)
            :base(Tags.StateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// LocaleOfIssue Field
    /// </summary>/
    public sealed class LocaleOfIssue : StringField
    {
        public LocaleOfIssue()
            :base(Tags.LocaleOfIssue) {}
        public LocaleOfIssue(string val)
            :base(Tags.LocaleOfIssue, val) {}

    }


    /// <summary>
    /// NoRegistDtls Field
    /// </summary>/
    public sealed class NoRegistDtls : IntField
    {
        public NoRegistDtls()
            :base(Tags.NoRegistDtls) {}
        public NoRegistDtls(int val)
            :base(Tags.NoRegistDtls, val) {}

    }


    /// <summary>
    /// MailingDtls Field
    /// </summary>/
    public sealed class MailingDtls : StringField
    {
        public MailingDtls()
            :base(Tags.MailingDtls) {}
        public MailingDtls(string val)
            :base(Tags.MailingDtls, val) {}

    }


    /// <summary>
    /// InvestorCountryOfResidence Field
    /// </summary>/
    public sealed class InvestorCountryOfResidence : StringField
    {
        public InvestorCountryOfResidence()
            :base(Tags.InvestorCountryOfResidence) {}
        public InvestorCountryOfResidence(string val)
            :base(Tags.InvestorCountryOfResidence, val) {}

    }


    /// <summary>
    /// PaymentRef Field
    /// </summary>/
    public sealed class PaymentRef : StringField
    {
        public PaymentRef()
            :base(Tags.PaymentRef) {}
        public PaymentRef(string val)
            :base(Tags.PaymentRef, val) {}

    }


    /// <summary>
    /// DistribPaymentMethod Field
    /// </summary>/
    public sealed class DistribPaymentMethod : IntField
    {
        public DistribPaymentMethod()
            :base(Tags.DistribPaymentMethod) {}
        public DistribPaymentMethod(int val)
            :base(Tags.DistribPaymentMethod, val) {}


        // Field Enumerations
        public const int CREST = 1;
        public const int BPAY = 10;
        public const int HIGH_VALUE_CLEARING_SYSTEM_HVACS = 11;
        public const int REINVEST_IN_FUND = 12;
        public const int NSCC = 2;
        public const int EUROCLEAR = 3;
        public const int CLEARSTREAM = 4;
        public const int CHEQUE = 5;
        public const int TELEGRAPHIC_TRANSFER = 6;
        public const int FED_WIRE = 7;
        public const int DIRECT_CREDIT = 8;
        public const int ACH_CREDIT = 9;
    }


    /// <summary>
    /// CashDistribCurr Field
    /// </summary>/
    public sealed class CashDistribCurr : DecimalField
    {
        public CashDistribCurr()
            :base(Tags.CashDistribCurr) {}
        public CashDistribCurr(Decimal val)
            :base(Tags.CashDistribCurr, val) {}

    }


    /// <summary>
    /// CommCurrency Field
    /// </summary>/
    public sealed class CommCurrency : DecimalField
    {
        public CommCurrency()
            :base(Tags.CommCurrency) {}
        public CommCurrency(Decimal val)
            :base(Tags.CommCurrency, val) {}

    }


    /// <summary>
    /// CancellationRights Field
    /// </summary>/
    public sealed class CancellationRights : CharField
    {
        public CancellationRights()
            :base(Tags.CancellationRights) {}
        public CancellationRights(char val)
            :base(Tags.CancellationRights, val) {}


        // Field Enumerations
        public const char NO_M = 'M';
        public const char NO_N = 'N';
        public const char NO_O = 'O';
        public const char YES = 'Y';
    }


    /// <summary>
    /// MoneyLaunderingStatus Field
    /// </summary>/
    public sealed class MoneyLaunderingStatus : CharField
    {
        public MoneyLaunderingStatus()
            :base(Tags.MoneyLaunderingStatus) {}
        public MoneyLaunderingStatus(char val)
            :base(Tags.MoneyLaunderingStatus, val) {}


        // Field Enumerations
        public const char EXEMPT_1 = '1';
        public const char EXEMPT_2 = '2';
        public const char EXEMPT_3 = '3';
        public const char NOT_CHECKED = 'N';
        public const char PASSED = 'Y';
    }


    /// <summary>
    /// MailingInst Field
    /// </summary>/
    public sealed class MailingInst : StringField
    {
        public MailingInst()
            :base(Tags.MailingInst) {}
        public MailingInst(string val)
            :base(Tags.MailingInst, val) {}

    }


    /// <summary>
    /// TransBkdTime Field
    /// </summary>/
    public sealed class TransBkdTime : DateTimeField
    {
        public TransBkdTime()
            :base(Tags.TransBkdTime) {}
        public TransBkdTime(DateTime val)
            :base(Tags.TransBkdTime, val) {}

    }


    /// <summary>
    /// ExecPriceType Field
    /// </summary>/
    public sealed class ExecPriceType : CharField
    {
        public ExecPriceType()
            :base(Tags.ExecPriceType) {}
        public ExecPriceType(char val)
            :base(Tags.ExecPriceType, val) {}


        // Field Enumerations
        public const char BID_PRICE = 'B';
        public const char CREATION_PRICE = 'C';
        public const char CREATION_PRICE_PLUS_ADJUSTMENT_PERCENT = 'D';
        public const char CREATION_PRICE_PLUS_ADJUSTMENT_AMOUNT = 'E';
        public const char OFFER_PRICE = 'O';
        public const char OFFER_PRICE_MINUS_ADJUSTMENT_PERCENT = 'P';
        public const char OFFER_PRICE_MINUS_ADJUSTMENT_AMOUNT = 'Q';
        public const char SINGLE_PRICE = 'S';
    }


    /// <summary>
    /// ExecPriceAdjustment Field
    /// </summary>/
    public sealed class ExecPriceAdjustment : DecimalField
    {
        public ExecPriceAdjustment()
            :base(Tags.ExecPriceAdjustment) {}
        public ExecPriceAdjustment(Decimal val)
            :base(Tags.ExecPriceAdjustment, val) {}

    }


    /// <summary>
    /// DateOfBirth Field
    /// </summary>/
    public sealed class DateOfBirth : StringField
    {
        public DateOfBirth()
            :base(Tags.DateOfBirth) {}
        public DateOfBirth(string val)
            :base(Tags.DateOfBirth, val) {}

    }


    /// <summary>
    /// TradeReportTransType Field
    /// </summary>/
    public sealed class TradeReportTransType : IntField
    {
        public TradeReportTransType()
            :base(Tags.TradeReportTransType) {}
        public TradeReportTransType(int val)
            :base(Tags.TradeReportTransType, val) {}


        // Field Enumerations
        public const int NEW = 0;
        public const int CANCEL = 1;
        public const int REPLACE = 2;
        public const int RELEASE = 3;
        public const int REVERSE = 4;
        public const int CANCEL_DUE_TO_BACK_OUT_OF_TRADE = 5;
    }


    /// <summary>
    /// CardHolderName Field
    /// </summary>/
    public sealed class CardHolderName : StringField
    {
        public CardHolderName()
            :base(Tags.CardHolderName) {}
        public CardHolderName(string val)
            :base(Tags.CardHolderName, val) {}

    }


    /// <summary>
    /// CardNumber Field
    /// </summary>/
    public sealed class CardNumber : StringField
    {
        public CardNumber()
            :base(Tags.CardNumber) {}
        public CardNumber(string val)
            :base(Tags.CardNumber, val) {}

    }


    /// <summary>
    /// CardExpDate Field
    /// </summary>/
    public sealed class CardExpDate : StringField
    {
        public CardExpDate()
            :base(Tags.CardExpDate) {}
        public CardExpDate(string val)
            :base(Tags.CardExpDate, val) {}

    }


    /// <summary>
    /// CardIssNo Field
    /// </summary>/
    public sealed class CardIssNo : StringField
    {
        public CardIssNo()
            :base(Tags.CardIssNo) {}
        public CardIssNo(string val)
            :base(Tags.CardIssNo, val) {}

    }


    /// <summary>
    /// PaymentMethod Field
    /// </summary>/
    public sealed class PaymentMethod : IntField
    {
        public PaymentMethod()
            :base(Tags.PaymentMethod) {}
        public PaymentMethod(int val)
            :base(Tags.PaymentMethod, val) {}


        // Field Enumerations
        public const int CREST = 1;
        public const int DIRECT_CREDIT = 10;
        public const int CREDIT_CARD = 11;
        public const int ACH_DEBIT = 12;
        public const int ACH_CREDIT = 13;
        public const int BPAY = 14;
        public const int HIGH_VALUE_CLEARING_SYSTEM = 15;
        public const int NSCC = 2;
        public const int EUROCLEAR = 3;
        public const int CLEARSTREAM = 4;
        public const int CHEQUE = 5;
        public const int TELEGRAPHIC_TRANSFER = 6;
        public const int FED_WIRE = 7;
        public const int DEBIT_CARD = 8;
        public const int DIRECT_DEBIT = 9;
    }


    /// <summary>
    /// RegistAcctType Field
    /// </summary>/
    public sealed class RegistAcctType : StringField
    {
        public RegistAcctType()
            :base(Tags.RegistAcctType) {}
        public RegistAcctType(string val)
            :base(Tags.RegistAcctType, val) {}

    }


    /// <summary>
    /// Designation Field
    /// </summary>/
    public sealed class Designation : StringField
    {
        public Designation()
            :base(Tags.Designation) {}
        public Designation(string val)
            :base(Tags.Designation, val) {}

    }


    /// <summary>
    /// TaxAdvantageType Field
    /// </summary>/
    public sealed class TaxAdvantageType : IntField
    {
        public TaxAdvantageType()
            :base(Tags.TaxAdvantageType) {}
        public TaxAdvantageType(int val)
            :base(Tags.TaxAdvantageType, val) {}


        // Field Enumerations
        public const int NONE_NOT_APPLICABLE = 0;
        public const int MAXI_ISA = 1;
        public const int EMPLOYEE_10 = 10;
        public const int EMPLOYER_11 = 11;
        public const int EMPLOYER_12 = 12;
        public const int NON_FUND_PROTOTYPE_IRA = 13;
        public const int NON_FUND_QUALIFIED_PLAN = 14;
        public const int DEFINED_CONTRIBUTION_PLAN = 15;
        public const int INDIVIDUAL_RETIREMENT_ACCOUNT_16 = 16;
        public const int INDIVIDUAL_RETIREMENT_ACCOUNT_17 = 17;
        public const int KEOGH = 18;
        public const int PROFIT_SHARING_PLAN = 19;
        public const int TESSA = 2;
        public const int VAL_401 = 20;
        public const int SELF_DIRECTED_IRA = 21;
        public const int VAL_403 = 22;
        public const int VAL_457 = 23;
        public const int ROTH_IRA_24 = 24;
        public const int ROTH_IRA_25 = 25;
        public const int ROTH_CONVERSION_IRA_26 = 26;
        public const int ROTH_CONVERSION_IRA_27 = 27;
        public const int EDUCATION_IRA_28 = 28;
        public const int EDUCATION_IRA_29 = 29;
        public const int MINI_CASH_ISA = 3;
        public const int MINI_STOCKS_AND_SHARES_ISA = 4;
        public const int MINI_INSURANCE_ISA = 5;
        public const int CURRENT_YEAR_PAYMENT = 6;
        public const int PRIOR_YEAR_PAYMENT = 7;
        public const int ASSET_TRANSFER = 8;
        public const int EMPLOYEE_9 = 9;
        public const int OTHER = 999;
    }


    /// <summary>
    /// RegistRejReasonText Field
    /// </summary>/
    public sealed class RegistRejReasonText : StringField
    {
        public RegistRejReasonText()
            :base(Tags.RegistRejReasonText) {}
        public RegistRejReasonText(string val)
            :base(Tags.RegistRejReasonText, val) {}

    }


    /// <summary>
    /// FundRenewWaiv Field
    /// </summary>/
    public sealed class FundRenewWaiv : CharField
    {
        public FundRenewWaiv()
            :base(Tags.FundRenewWaiv) {}
        public FundRenewWaiv(char val)
            :base(Tags.FundRenewWaiv, val) {}


        // Field Enumerations
        public const char NO = 'N';
        public const char YES = 'Y';
    }


    /// <summary>
    /// CashDistribAgentName Field
    /// </summary>/
    public sealed class CashDistribAgentName : StringField
    {
        public CashDistribAgentName()
            :base(Tags.CashDistribAgentName) {}
        public CashDistribAgentName(string val)
            :base(Tags.CashDistribAgentName, val) {}

    }


    /// <summary>
    /// CashDistribAgentCode Field
    /// </summary>/
    public sealed class CashDistribAgentCode : StringField
    {
        public CashDistribAgentCode()
            :base(Tags.CashDistribAgentCode) {}
        public CashDistribAgentCode(string val)
            :base(Tags.CashDistribAgentCode, val) {}

    }


    /// <summary>
    /// CashDistribAgentAcctNumber Field
    /// </summary>/
    public sealed class CashDistribAgentAcctNumber : StringField
    {
        public CashDistribAgentAcctNumber()
            :base(Tags.CashDistribAgentAcctNumber) {}
        public CashDistribAgentAcctNumber(string val)
            :base(Tags.CashDistribAgentAcctNumber, val) {}

    }


    /// <summary>
    /// CashDistribPayRef Field
    /// </summary>/
    public sealed class CashDistribPayRef : StringField
    {
        public CashDistribPayRef()
            :base(Tags.CashDistribPayRef) {}
        public CashDistribPayRef(string val)
            :base(Tags.CashDistribPayRef, val) {}

    }


    /// <summary>
    /// CashDistribAgentAcctName Field
    /// </summary>/
    public sealed class CashDistribAgentAcctName : StringField
    {
        public CashDistribAgentAcctName()
            :base(Tags.CashDistribAgentAcctName) {}
        public CashDistribAgentAcctName(string val)
            :base(Tags.CashDistribAgentAcctName, val) {}

    }


    /// <summary>
    /// CardStartDate Field
    /// </summary>/
    public sealed class CardStartDate : StringField
    {
        public CardStartDate()
            :base(Tags.CardStartDate) {}
        public CardStartDate(string val)
            :base(Tags.CardStartDate, val) {}

    }


    /// <summary>
    /// PaymentDate Field
    /// </summary>/
    public sealed class PaymentDate : StringField
    {
        public PaymentDate()
            :base(Tags.PaymentDate) {}
        public PaymentDate(string val)
            :base(Tags.PaymentDate, val) {}

    }


    /// <summary>
    /// PaymentRemitterID Field
    /// </summary>/
    public sealed class PaymentRemitterID : StringField
    {
        public PaymentRemitterID()
            :base(Tags.PaymentRemitterID) {}
        public PaymentRemitterID(string val)
            :base(Tags.PaymentRemitterID, val) {}

    }


    /// <summary>
    /// RegistStatus Field
    /// </summary>/
    public sealed class RegistStatus : CharField
    {
        public RegistStatus()
            :base(Tags.RegistStatus) {}
        public RegistStatus(char val)
            :base(Tags.RegistStatus, val) {}


        // Field Enumerations
        public const char ACCEPTED = 'A';
        public const char HELD = 'H';
        public const char REMINDER = 'N';
        public const char REJECTED = 'R';
    }


    /// <summary>
    /// RegistRejReasonCode Field
    /// </summary>/
    public sealed class RegistRejReasonCode : IntField
    {
        public RegistRejReasonCode()
            :base(Tags.RegistRejReasonCode) {}
        public RegistRejReasonCode(int val)
            :base(Tags.RegistRejReasonCode, val) {}


        // Field Enumerations
        public const int INVALID_UNACCEPTABLE_ACCOUNT_TYPE = 1;
        public const int INVALID_UNACEEPTABLE_INVESTOR_ID_SOURCE = 10;
        public const int INVALID_UNACCEPTABLE_DATE_OF_BIRTH = 11;
        public const int INVALID_UNACCEPTABLE_INVESTOR_COUNTRY_OF_RESIDENCE = 12;
        public const int INVALID_UNACCEPTABLE_NO_DISTRIB_INSTNS = 13;
        public const int INVALID_UNACCEPTABLE_DISTRIB_PERCENTAGE = 14;
        public const int INVALID_UNACCEPTABLE_DISTRIB_PAYMENT_METHOD = 15;
        public const int INVALID_UNACCEPTABLE_CASH_DISTRIB_AGENT_ACCT_NAME = 16;
        public const int INVALID_UNACCEPTABLE_CASH_DISTRIB_AGENT_CODE = 17;
        public const int INVALID_UNACCEPTABLE_CASH_DISTRIB_AGENT_ACCT_NUM = 18;
        public const int INVALID_UNACCEPTABLE_TAX_EXEMPT_TYPE = 2;
        public const int INVALID_UNACCEPTABLE_OWNERSHIP_TYPE = 3;
        public const int INVALID_UNACCEPTABLE_NO_REG_DETAILS = 4;
        public const int INVALID_UNACCEPTABLE_REG_SEQ_NO = 5;
        public const int INVALID_UNACCEPTABLE_REG_DETAILS = 6;
        public const int INVALID_UNACCEPTABLE_MAILING_DETAILS = 7;
        public const int INVALID_UNACCEPTABLE_MAILING_INSTRUCTIONS = 8;
        public const int INVALID_UNACCEPTABLE_INVESTOR_ID = 9;
        public const int OTHER = 99;
    }


    /// <summary>
    /// RegistRefID Field
    /// </summary>/
    public sealed class RegistRefID : StringField
    {
        public RegistRefID()
            :base(Tags.RegistRefID) {}
        public RegistRefID(string val)
            :base(Tags.RegistRefID, val) {}

    }


    /// <summary>
    /// RegistDetls Field
    /// </summary>/
    public sealed class RegistDetls : StringField
    {
        public RegistDetls()
            :base(Tags.RegistDetls) {}
        public RegistDetls(string val)
            :base(Tags.RegistDetls, val) {}

    }


    /// <summary>
    /// NoDistribInsts Field
    /// </summary>/
    public sealed class NoDistribInsts : IntField
    {
        public NoDistribInsts()
            :base(Tags.NoDistribInsts) {}
        public NoDistribInsts(int val)
            :base(Tags.NoDistribInsts, val) {}

    }


    /// <summary>
    /// RegistEmail Field
    /// </summary>/
    public sealed class RegistEmail : StringField
    {
        public RegistEmail()
            :base(Tags.RegistEmail) {}
        public RegistEmail(string val)
            :base(Tags.RegistEmail, val) {}

    }


    /// <summary>
    /// DistribPercentage Field
    /// </summary>/
    public sealed class DistribPercentage : DecimalField
    {
        public DistribPercentage()
            :base(Tags.DistribPercentage) {}
        public DistribPercentage(Decimal val)
            :base(Tags.DistribPercentage, val) {}

    }


    /// <summary>
    /// RegistID Field
    /// </summary>/
    public sealed class RegistID : StringField
    {
        public RegistID()
            :base(Tags.RegistID) {}
        public RegistID(string val)
            :base(Tags.RegistID, val) {}

    }


    /// <summary>
    /// RegistTransType Field
    /// </summary>/
    public sealed class RegistTransType : CharField
    {
        public RegistTransType()
            :base(Tags.RegistTransType) {}
        public RegistTransType(char val)
            :base(Tags.RegistTransType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char REPLACE = '1';
        public const char CANCEL = '2';
    }


    /// <summary>
    /// ExecValuationPoint Field
    /// </summary>/
    public sealed class ExecValuationPoint : DateTimeField
    {
        public ExecValuationPoint()
            :base(Tags.ExecValuationPoint) {}
        public ExecValuationPoint(DateTime val)
            :base(Tags.ExecValuationPoint, val) {}

    }


    /// <summary>
    /// OrderPercent Field
    /// </summary>/
    public sealed class OrderPercent : DecimalField
    {
        public OrderPercent()
            :base(Tags.OrderPercent) {}
        public OrderPercent(Decimal val)
            :base(Tags.OrderPercent, val) {}

    }


    /// <summary>
    /// OwnershipType Field
    /// </summary>/
    public sealed class OwnershipType : CharField
    {
        public OwnershipType()
            :base(Tags.OwnershipType) {}
        public OwnershipType(char val)
            :base(Tags.OwnershipType, val) {}


        // Field Enumerations
        public const char JOINT_TRUSTEES = '2';
        public const char JOINT_INVESTORS = 'J';
        public const char TENANTS_IN_COMMON = 'T';
    }


    /// <summary>
    /// NoContAmts Field
    /// </summary>/
    public sealed class NoContAmts : IntField
    {
        public NoContAmts()
            :base(Tags.NoContAmts) {}
        public NoContAmts(int val)
            :base(Tags.NoContAmts, val) {}

    }


    /// <summary>
    /// ContAmtType Field
    /// </summary>/
    public sealed class ContAmtType : IntField
    {
        public ContAmtType()
            :base(Tags.ContAmtType) {}
        public ContAmtType(int val)
            :base(Tags.ContAmtType, val) {}


        // Field Enumerations
        public const int COMMISSION_AMOUNT = 1;
        public const int EXIT_CHARGE_PERCENT = 10;
        public const int FUND_BASED_RENEWAL_COMMISSION_PERCENT = 11;
        public const int PROJECTED_FUND_VALUE = 12;
        public const int FUND_BASED_RENEWAL_COMMISSION_AMOUNT_13 = 13;
        public const int FUND_BASED_RENEWAL_COMMISSION_AMOUNT_14 = 14;
        public const int NET_SETTLEMENT_AMOUNT = 15;
        public const int COMMISSION_PERCENT = 2;
        public const int INITIAL_CHARGE_AMOUNT = 3;
        public const int INITIAL_CHARGE_PERCENT = 4;
        public const int DISCOUNT_AMOUNT = 5;
        public const int DISCOUNT_PERCENT = 6;
        public const int DILUTION_LEVY_AMOUNT = 7;
        public const int DILUTION_LEVY_PERCENT = 8;
        public const int EXIT_CHARGE_AMOUNT = 9;
    }


    /// <summary>
    /// ContAmtValue Field
    /// </summary>/
    public sealed class ContAmtValue : DecimalField
    {
        public ContAmtValue()
            :base(Tags.ContAmtValue) {}
        public ContAmtValue(Decimal val)
            :base(Tags.ContAmtValue, val) {}

    }


    /// <summary>
    /// ContAmtCurr Field
    /// </summary>/
    public sealed class ContAmtCurr : DecimalField
    {
        public ContAmtCurr()
            :base(Tags.ContAmtCurr) {}
        public ContAmtCurr(Decimal val)
            :base(Tags.ContAmtCurr, val) {}

    }


    /// <summary>
    /// OwnerType Field
    /// </summary>/
    public sealed class OwnerType : IntField
    {
        public OwnerType()
            :base(Tags.OwnerType) {}
        public OwnerType(int val)
            :base(Tags.OwnerType, val) {}


        // Field Enumerations
        public const int INDIVIDUAL_INVESTOR = 1;
        public const int NETWORKING_SUB_ACCOUNT = 10;
        public const int NON_PROFIT_ORGANIZATION = 11;
        public const int CORPORATE_BODY = 12;
        public const int NOMINEE = 13;
        public const int PUBLIC_COMPANY = 2;
        public const int PRIVATE_COMPANY = 3;
        public const int INDIVIDUAL_TRUSTEE = 4;
        public const int COMPANY_TRUSTEE = 5;
        public const int PENSION_PLAN = 6;
        public const int CUSTODIAN_UNDER_GIFTS_TO_MINORS_ACT = 7;
        public const int TRUSTS = 8;
        public const int FIDUCIARIES = 9;
    }


    /// <summary>
    /// PartySubID Field
    /// </summary>/
    public sealed class PartySubID : StringField
    {
        public PartySubID()
            :base(Tags.PartySubID) {}
        public PartySubID(string val)
            :base(Tags.PartySubID, val) {}

    }


    /// <summary>
    /// NestedPartyID Field
    /// </summary>/
    public sealed class NestedPartyID : StringField
    {
        public NestedPartyID()
            :base(Tags.NestedPartyID) {}
        public NestedPartyID(string val)
            :base(Tags.NestedPartyID, val) {}

    }


    /// <summary>
    /// NestedPartyIDSource Field
    /// </summary>/
    public sealed class NestedPartyIDSource : CharField
    {
        public NestedPartyIDSource()
            :base(Tags.NestedPartyIDSource) {}
        public NestedPartyIDSource(char val)
            :base(Tags.NestedPartyIDSource, val) {}

    }


    /// <summary>
    /// SecondaryClOrdID Field
    /// </summary>/
    public sealed class SecondaryClOrdID : StringField
    {
        public SecondaryClOrdID()
            :base(Tags.SecondaryClOrdID) {}
        public SecondaryClOrdID(string val)
            :base(Tags.SecondaryClOrdID, val) {}

    }


    /// <summary>
    /// SecondaryExecID Field
    /// </summary>/
    public sealed class SecondaryExecID : StringField
    {
        public SecondaryExecID()
            :base(Tags.SecondaryExecID) {}
        public SecondaryExecID(string val)
            :base(Tags.SecondaryExecID, val) {}

    }


    /// <summary>
    /// OrderCapacity Field
    /// </summary>/
    public sealed class OrderCapacity : CharField
    {
        public OrderCapacity()
            :base(Tags.OrderCapacity) {}
        public OrderCapacity(char val)
            :base(Tags.OrderCapacity, val) {}


        // Field Enumerations
        public const char AGENCY = 'A';
        public const char PROPRIETARY = 'G';
        public const char INDIVIDUAL = 'I';
        public const char PRINCIPAL = 'P';
        public const char RISKLESS_PRINCIPAL = 'R';
        public const char AGENT_FOR_OTHER_MEMBER = 'W';
    }


    /// <summary>
    /// OrderRestrictions Field
    /// </summary>/
    public sealed class OrderRestrictions : StringField
    {
        public OrderRestrictions()
            :base(Tags.OrderRestrictions) {}
        public OrderRestrictions(string val)
            :base(Tags.OrderRestrictions, val) {}


        // Field Enumerations
        public const string PROGRAM_TRADE = "1";
        public const string INDEX_ARBITRAGE = "2";
        public const string NON_INDEX_ARBITRAGE = "3";
        public const string COMPETING_MARKET_MAKER = "4";
        public const string ACTING_AS_MARKET_MAKER_OR_SPECIALIST_IN_THE_SECURITY = "5";
        public const string ACTING_AS_MARKET_MAKER_OF_SPECIALIST_IN_THE_UNDERLYING_SECURITY_OF_A_DERIVATIVE_SEUCIRTY = "6";
        public const string FOREIGN_ENTITY = "7";
        public const string EXTERNAL_MARKET_PARTICIPANT = "8";
        public const string EXTNERAL_INTER_CONNECTED_MARKET_LINKAGE = "9";
        public const string RISKLESS_ARBITRAGE = "A";
    }


    /// <summary>
    /// MassCancelRequestType Field
    /// </summary>/
    public sealed class MassCancelRequestType : CharField
    {
        public MassCancelRequestType()
            :base(Tags.MassCancelRequestType) {}
        public MassCancelRequestType(char val)
            :base(Tags.MassCancelRequestType, val) {}


        // Field Enumerations
        public const char CANCEL_ORDERS_FOR_A_SECURITY = '1';
        public const char CANCEL_ORDERS_FOR_AN_UNDERLYING_SECURITY = '2';
        public const char CANCEL_ORDERS_FOR_A_PRODUCT = '3';
        public const char CANCEL_ORDERS_FOR_A_CFICODE = '4';
        public const char CANCEL_ORDERS_FOR_A_SECURITYTYPE = '5';
        public const char CANCEL_ORDERS_FOR_A_TRADING_SESSION = '6';
        public const char CANCEL_ALL_ORDERS = '7';
    }


    /// <summary>
    /// MassCancelResponse Field
    /// </summary>/
    public sealed class MassCancelResponse : CharField
    {
        public MassCancelResponse()
            :base(Tags.MassCancelResponse) {}
        public MassCancelResponse(char val)
            :base(Tags.MassCancelResponse, val) {}


        // Field Enumerations
        public const char CANCEL_REQUEST_REJECTED = '0';
        public const char CANCEL_ORDERS_FOR_A_SECURITY = '1';
        public const char CANCEL_ORDERS_FOR_AN_UNDERLYING_SECURITY = '2';
        public const char CANCEL_ORDERS_FOR_A_PRODUCT = '3';
        public const char CANCEL_ORDERS_FOR_A_CFICODE = '4';
        public const char CANCEL_ORDERS_FOR_A_SECURITYTYPE = '5';
        public const char CANCEL_ORDERS_FOR_A_TRADING_SESSION = '6';
        public const char CANCEL_ALL_ORDERS = '7';
    }


    /// <summary>
    /// MassCancelRejectReason Field
    /// </summary>/
    public sealed class MassCancelRejectReason : IntField
    {
        public MassCancelRejectReason()
            :base(Tags.MassCancelRejectReason) {}
        public MassCancelRejectReason(int val)
            :base(Tags.MassCancelRejectReason, val) {}


        // Field Enumerations
        public const int MASS_CANCEL_NOT_SUPPORTED = 0;
        public const int INVALID_OR_UNKNOWN_SECURITY = 1;
        public const int INVALID_OR_UNKOWN_UNDERLYING_SECURITY = 2;
        public const int INVALID_OR_UNKNOWN_PRODUCT = 3;
        public const int INVALID_OR_UNKNOWN_CFICODE = 4;
        public const int INVALID_OR_UNKNOWN_SECURITYTYPE = 5;
        public const int INVALID_OR_UNKNOWN_TRADING_SESSION = 6;
        public const int OTHER = 99;
    }


    /// <summary>
    /// TotalAffectedOrders Field
    /// </summary>/
    public sealed class TotalAffectedOrders : IntField
    {
        public TotalAffectedOrders()
            :base(Tags.TotalAffectedOrders) {}
        public TotalAffectedOrders(int val)
            :base(Tags.TotalAffectedOrders, val) {}

    }


    /// <summary>
    /// NoAffectedOrders Field
    /// </summary>/
    public sealed class NoAffectedOrders : IntField
    {
        public NoAffectedOrders()
            :base(Tags.NoAffectedOrders) {}
        public NoAffectedOrders(int val)
            :base(Tags.NoAffectedOrders, val) {}

    }


    /// <summary>
    /// AffectedOrderID Field
    /// </summary>/
    public sealed class AffectedOrderID : StringField
    {
        public AffectedOrderID()
            :base(Tags.AffectedOrderID) {}
        public AffectedOrderID(string val)
            :base(Tags.AffectedOrderID, val) {}

    }


    /// <summary>
    /// AffectedSecondaryOrderID Field
    /// </summary>/
    public sealed class AffectedSecondaryOrderID : StringField
    {
        public AffectedSecondaryOrderID()
            :base(Tags.AffectedSecondaryOrderID) {}
        public AffectedSecondaryOrderID(string val)
            :base(Tags.AffectedSecondaryOrderID, val) {}

    }


    /// <summary>
    /// QuoteType Field
    /// </summary>/
    public sealed class QuoteType : IntField
    {
        public QuoteType()
            :base(Tags.QuoteType) {}
        public QuoteType(int val)
            :base(Tags.QuoteType, val) {}


        // Field Enumerations
        public const int INDICATIVE = 0;
        public const int TRADEABLE = 1;
        public const int RESTRICTED_TRADEABLE = 2;
        public const int COUNTER = 3;
    }


    /// <summary>
    /// NestedPartyRole Field
    /// </summary>/
    public sealed class NestedPartyRole : IntField
    {
        public NestedPartyRole()
            :base(Tags.NestedPartyRole) {}
        public NestedPartyRole(int val)
            :base(Tags.NestedPartyRole, val) {}

    }


    /// <summary>
    /// NoNestedPartyIDs Field
    /// </summary>/
    public sealed class NoNestedPartyIDs : IntField
    {
        public NoNestedPartyIDs()
            :base(Tags.NoNestedPartyIDs) {}
        public NoNestedPartyIDs(int val)
            :base(Tags.NoNestedPartyIDs, val) {}

    }


    /// <summary>
    /// TotalAccruedInterestAmt Field
    /// </summary>/
    public sealed class TotalAccruedInterestAmt : DecimalField
    {
        public TotalAccruedInterestAmt()
            :base(Tags.TotalAccruedInterestAmt) {}
        public TotalAccruedInterestAmt(Decimal val)
            :base(Tags.TotalAccruedInterestAmt, val) {}

    }


    /// <summary>
    /// MaturityDate Field
    /// </summary>/
    public sealed class MaturityDate : StringField
    {
        public MaturityDate()
            :base(Tags.MaturityDate) {}
        public MaturityDate(string val)
            :base(Tags.MaturityDate, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityDate Field
    /// </summary>/
    public sealed class UnderlyingMaturityDate : StringField
    {
        public UnderlyingMaturityDate()
            :base(Tags.UnderlyingMaturityDate) {}
        public UnderlyingMaturityDate(string val)
            :base(Tags.UnderlyingMaturityDate, val) {}

    }


    /// <summary>
    /// InstrRegistry Field
    /// </summary>/
    public sealed class InstrRegistry : StringField
    {
        public InstrRegistry()
            :base(Tags.InstrRegistry) {}
        public InstrRegistry(string val)
            :base(Tags.InstrRegistry, val) {}

    }


    /// <summary>
    /// CashMargin Field
    /// </summary>/
    public sealed class CashMargin : CharField
    {
        public CashMargin()
            :base(Tags.CashMargin) {}
        public CashMargin(char val)
            :base(Tags.CashMargin, val) {}


        // Field Enumerations
        public const char CASH = '1';
        public const char MARGIN_OPEN = '2';
        public const char MARGIN_CLOSE = '3';
    }


    /// <summary>
    /// NestedPartySubID Field
    /// </summary>/
    public sealed class NestedPartySubID : StringField
    {
        public NestedPartySubID()
            :base(Tags.NestedPartySubID) {}
        public NestedPartySubID(string val)
            :base(Tags.NestedPartySubID, val) {}

    }


    /// <summary>
    /// Scope Field
    /// </summary>/
    public sealed class Scope : StringField
    {
        public Scope()
            :base(Tags.Scope) {}
        public Scope(string val)
            :base(Tags.Scope, val) {}


        // Field Enumerations
        public const string LOCAL_MARKET = "1";
        public const string NATIONAL = "2";
        public const string GLOBAL = "3";
    }


    /// <summary>
    /// MDImplicitDelete Field
    /// </summary>/
    public sealed class MDImplicitDelete : BooleanField
    {
        public MDImplicitDelete()
            :base(Tags.MDImplicitDelete) {}
        public MDImplicitDelete(Boolean val)
            :base(Tags.MDImplicitDelete, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// CrossID Field
    /// </summary>/
    public sealed class CrossID : StringField
    {
        public CrossID()
            :base(Tags.CrossID) {}
        public CrossID(string val)
            :base(Tags.CrossID, val) {}

    }


    /// <summary>
    /// CrossType Field
    /// </summary>/
    public sealed class CrossType : IntField
    {
        public CrossType()
            :base(Tags.CrossType) {}
        public CrossType(int val)
            :base(Tags.CrossType, val) {}


        // Field Enumerations
        public const int CROSS_AON = 1;
        public const int CROSS_IOC = 2;
        public const int CROSS_ONE_SIDE = 3;
        public const int CROSS_SAME_PRICE = 4;
    }


    /// <summary>
    /// CrossPrioritization Field
    /// </summary>/
    public sealed class CrossPrioritization : IntField
    {
        public CrossPrioritization()
            :base(Tags.CrossPrioritization) {}
        public CrossPrioritization(int val)
            :base(Tags.CrossPrioritization, val) {}


        // Field Enumerations
        public const int NONE = 0;
        public const int BUY_SIDE_IS_PRIORITIZED = 1;
        public const int SELL_SIDE_IS_PRIORITIZED = 2;
    }


    /// <summary>
    /// OrigCrossID Field
    /// </summary>/
    public sealed class OrigCrossID : StringField
    {
        public OrigCrossID()
            :base(Tags.OrigCrossID) {}
        public OrigCrossID(string val)
            :base(Tags.OrigCrossID, val) {}

    }


    /// <summary>
    /// NoSides Field
    /// </summary>/
    public sealed class NoSides : IntField
    {
        public NoSides()
            :base(Tags.NoSides) {}
        public NoSides(int val)
            :base(Tags.NoSides, val) {}


        // Field Enumerations
        public const int ONE_SIDE = 1;
        public const int BOTH_SIDES = 2;
    }


    /// <summary>
    /// Username Field
    /// </summary>/
    public sealed class Username : StringField
    {
        public Username()
            :base(Tags.Username) {}
        public Username(string val)
            :base(Tags.Username, val) {}

    }


    /// <summary>
    /// Password Field
    /// </summary>/
    public sealed class Password : StringField
    {
        public Password()
            :base(Tags.Password) {}
        public Password(string val)
            :base(Tags.Password, val) {}

    }


    /// <summary>
    /// NoLegs Field
    /// </summary>/
    public sealed class NoLegs : IntField
    {
        public NoLegs()
            :base(Tags.NoLegs) {}
        public NoLegs(int val)
            :base(Tags.NoLegs, val) {}

    }


    /// <summary>
    /// LegCurrency Field
    /// </summary>/
    public sealed class LegCurrency : DecimalField
    {
        public LegCurrency()
            :base(Tags.LegCurrency) {}
        public LegCurrency(Decimal val)
            :base(Tags.LegCurrency, val) {}

    }


    /// <summary>
    /// TotalNumSecurityTypes Field
    /// </summary>/
    public sealed class TotalNumSecurityTypes : IntField
    {
        public TotalNumSecurityTypes()
            :base(Tags.TotalNumSecurityTypes) {}
        public TotalNumSecurityTypes(int val)
            :base(Tags.TotalNumSecurityTypes, val) {}

    }


    /// <summary>
    /// NoSecurityTypes Field
    /// </summary>/
    public sealed class NoSecurityTypes : IntField
    {
        public NoSecurityTypes()
            :base(Tags.NoSecurityTypes) {}
        public NoSecurityTypes(int val)
            :base(Tags.NoSecurityTypes, val) {}

    }


    /// <summary>
    /// SecurityListRequestType Field
    /// </summary>/
    public sealed class SecurityListRequestType : IntField
    {
        public SecurityListRequestType()
            :base(Tags.SecurityListRequestType) {}
        public SecurityListRequestType(int val)
            :base(Tags.SecurityListRequestType, val) {}


        // Field Enumerations
        public const int SYMBOL = 0;
        public const int SECURITYTYPE_AND_OR_CFICODE = 1;
        public const int PRODUCT = 2;
        public const int TRADINGSESSIONID = 3;
        public const int ALL_SECURITIES = 4;
    }


    /// <summary>
    /// SecurityRequestResult Field
    /// </summary>/
    public sealed class SecurityRequestResult : IntField
    {
        public SecurityRequestResult()
            :base(Tags.SecurityRequestResult) {}
        public SecurityRequestResult(int val)
            :base(Tags.SecurityRequestResult, val) {}


        // Field Enumerations
        public const int VALID_REQUEST = 0;
        public const int INVALID_OR_UNSUPPORTED_REQUEST = 1;
        public const int NO_INSTRUMENTS_FOUND_THAT_MATCH_SELECTION_CRITERIA = 2;
        public const int NOT_AUTHORIZED_TO_RETRIEVE_INSTRUMENT_DATA = 3;
        public const int INSTRUMENT_DATA_TEMPORARILY_UNAVAILABLE = 4;
        public const int REQUEST_FOR_INSTRUMENT_DATA_NOT_SUPPORTED = 5;
    }


    /// <summary>
    /// RoundLot Field
    /// </summary>/
    public sealed class RoundLot : DecimalField
    {
        public RoundLot()
            :base(Tags.RoundLot) {}
        public RoundLot(Decimal val)
            :base(Tags.RoundLot, val) {}

    }


    /// <summary>
    /// MinTradeVol Field
    /// </summary>/
    public sealed class MinTradeVol : DecimalField
    {
        public MinTradeVol()
            :base(Tags.MinTradeVol) {}
        public MinTradeVol(Decimal val)
            :base(Tags.MinTradeVol, val) {}

    }


    /// <summary>
    /// MultiLegRptTypeReq Field
    /// </summary>/
    public sealed class MultiLegRptTypeReq : IntField
    {
        public MultiLegRptTypeReq()
            :base(Tags.MultiLegRptTypeReq) {}
        public MultiLegRptTypeReq(int val)
            :base(Tags.MultiLegRptTypeReq, val) {}


        // Field Enumerations
        public const int REPORT_BY_MULITLEG_SECURITY_ONLY = 0;
        public const int REPORT_BY_MULTILEG_SECURITY_AND_BY_INSTRUMENT_LEGS_BELONGING_TO_THE_MULTILEG_SECURITY = 1;
        public const int REPORT_BY_INSTRUMENT_LEGS_BELONGING_TO_THE_MULTILEG_SECURITY_ONLY = 2;
    }


    /// <summary>
    /// LegPositionEffect Field
    /// </summary>/
    public sealed class LegPositionEffect : CharField
    {
        public LegPositionEffect()
            :base(Tags.LegPositionEffect) {}
        public LegPositionEffect(char val)
            :base(Tags.LegPositionEffect, val) {}

    }


    /// <summary>
    /// LegCoveredOrUncovered Field
    /// </summary>/
    public sealed class LegCoveredOrUncovered : IntField
    {
        public LegCoveredOrUncovered()
            :base(Tags.LegCoveredOrUncovered) {}
        public LegCoveredOrUncovered(int val)
            :base(Tags.LegCoveredOrUncovered, val) {}

    }


    /// <summary>
    /// LegPrice Field
    /// </summary>/
    public sealed class LegPrice : DecimalField
    {
        public LegPrice()
            :base(Tags.LegPrice) {}
        public LegPrice(Decimal val)
            :base(Tags.LegPrice, val) {}

    }


    /// <summary>
    /// TradSesStatusRejReason Field
    /// </summary>/
    public sealed class TradSesStatusRejReason : IntField
    {
        public TradSesStatusRejReason()
            :base(Tags.TradSesStatusRejReason) {}
        public TradSesStatusRejReason(int val)
            :base(Tags.TradSesStatusRejReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_OR_INVALID_TRADINGSESSIONID = 1;
        public const int OTHER = 99;
    }


    /// <summary>
    /// TradeRequestID Field
    /// </summary>/
    public sealed class TradeRequestID : StringField
    {
        public TradeRequestID()
            :base(Tags.TradeRequestID) {}
        public TradeRequestID(string val)
            :base(Tags.TradeRequestID, val) {}

    }


    /// <summary>
    /// TradeRequestType Field
    /// </summary>/
    public sealed class TradeRequestType : IntField
    {
        public TradeRequestType()
            :base(Tags.TradeRequestType) {}
        public TradeRequestType(int val)
            :base(Tags.TradeRequestType, val) {}


        // Field Enumerations
        public const int ALL_TRADES = 0;
        public const int MATCHED_TRADES_MATCHING_CRITERIA_PROVIDED_ON_REQUEST = 1;
        public const int UNMATCHED_TRADES_THAT_MATCH_CRITERIA = 2;
        public const int UNREPORTED_TRADES_THAT_MATCH_CRITERIA = 3;
        public const int ADVISORIES_THAT_MATCH_CRITERIA = 4;
    }


    /// <summary>
    /// PreviouslyReported Field
    /// </summary>/
    public sealed class PreviouslyReported : BooleanField
    {
        public PreviouslyReported()
            :base(Tags.PreviouslyReported) {}
        public PreviouslyReported(Boolean val)
            :base(Tags.PreviouslyReported, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// TradeReportID Field
    /// </summary>/
    public sealed class TradeReportID : StringField
    {
        public TradeReportID()
            :base(Tags.TradeReportID) {}
        public TradeReportID(string val)
            :base(Tags.TradeReportID, val) {}

    }


    /// <summary>
    /// TradeReportRefID Field
    /// </summary>/
    public sealed class TradeReportRefID : StringField
    {
        public TradeReportRefID()
            :base(Tags.TradeReportRefID) {}
        public TradeReportRefID(string val)
            :base(Tags.TradeReportRefID, val) {}

    }


    /// <summary>
    /// MatchStatus Field
    /// </summary>/
    public sealed class MatchStatus : CharField
    {
        public MatchStatus()
            :base(Tags.MatchStatus) {}
        public MatchStatus(char val)
            :base(Tags.MatchStatus, val) {}


        // Field Enumerations
        public const char COMPARED_MATCHED_OR_AFFIRMED = '0';
        public const char UNCOMPARED_UNMATCHED_OR_UNAFFIRED = '1';
        public const char ADVISORY_OR_ALERT = '2';
    }


    /// <summary>
    /// MatchType Field
    /// </summary>/
    public sealed class MatchType : StringField
    {
        public MatchType()
            :base(Tags.MatchType) {}
        public MatchType(string val)
            :base(Tags.MatchType, val) {}


        // Field Enumerations
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_FOUR_BADGES_AND_EXECUTION_TIME = "A1";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_FOUR_BADGES = "A2";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_TWO_BADGES_AND_EXECUTION_TIME = "A3";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_TWO_BADGES = "A4";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADETYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_EXECUTION_TIME = "A5";
        public const string ACT_ACCEPTED_TRADE = "M3";
        public const string ACT_DEFAULT_TRADE = "M4";
        public const string ACT_DEFAULT_AFTER_M2 = "M5";
        public const string ACT_M6_MATCH = "M6";
        public const string COMPARED_RECORDS_RESULTING_FROM_STAMPED_ADVISORIES_OR_SPECIALIST_ACCEPTS_PAIR_OFFS = "AQ";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_MINUS_BADGES_AND_TIMES_ACT_M1_MATCH = "M1";
        public const string SUMMARIZED_MATCH_MINUS_BADGES_AND_TIMES_ACT_M2_MATCH = "M2";
        public const string OCS_LOCKED_IN_NON_ACT = "MT";
        public const string SUMMARIZED_MATCH_USING_A1_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIED = "S1";
        public const string SUMMARIZED_MATCH_USING_A2_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S2";
        public const string SUMMARIZED_MATCH_USING_A3_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S3";
        public const string SUMMARIZED_MATCH_USING_A4_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S4";
        public const string SUMMARIZED_MATCH_USING_A5_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S5";
        public const string ONE_PARTY_PRIVATELY_NEGOTIATED_TRADE_REPORT = "60";
        public const string TWO_PARTY_PRIVATELY_NEGOTIATED_TRADE_REPORT = "61";
        public const string CONTINUOUS_AUTO_MATCH = "62";
        public const string CROSS_AUCTION_63 = "63";
        public const string COUNTER_ORDER_SELECTION_64 = "64";
        public const string CALL_AUCTION_65 = "65";
        public const string ONE_PARTY_TRADE_REPORT = "1";
        public const string TWO_PARTY_TRADE_REPORT = "2";
        public const string CONFIRMED_TRADE_REPORT = "3";
        public const string AUTO_MATCH = "4";
        public const string CROSS_AUCTION_5 = "5";
        public const string COUNTER_ORDER_SELECTION_6 = "6";
        public const string CALL_AUCTION_7 = "7";
    }


    /// <summary>
    /// OddLot Field
    /// </summary>/
    public sealed class OddLot : BooleanField
    {
        public OddLot()
            :base(Tags.OddLot) {}
        public OddLot(Boolean val)
            :base(Tags.OddLot, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// NoClearingInstructions Field
    /// </summary>/
    public sealed class NoClearingInstructions : IntField
    {
        public NoClearingInstructions()
            :base(Tags.NoClearingInstructions) {}
        public NoClearingInstructions(int val)
            :base(Tags.NoClearingInstructions, val) {}

    }


    /// <summary>
    /// ClearingInstruction Field
    /// </summary>/
    public sealed class ClearingInstruction : IntField
    {
        public ClearingInstruction()
            :base(Tags.ClearingInstruction) {}
        public ClearingInstruction(int val)
            :base(Tags.ClearingInstruction, val) {}


        // Field Enumerations
        public const int PROCESS_NORMALLY = 0;
        public const int EXCLUDE_FROM_ALL_NETTING = 1;
        public const int AUTOMATIC_GIVE_UP_MODE = 10;
        public const int QUALIFIED_SERVICE_REPRESENTATIVE_QSR = 11;
        public const int CUSTOMER_TRADE = 12;
        public const int SELF_CLEARING = 13;
        public const int BILATERAL_NETTING_ONLY = 2;
        public const int EX_CLEARING = 3;
        public const int SPECIAL_TRADE = 4;
        public const int MULTILATERAL_NETTING = 5;
        public const int CLEAR_AGAINST_CENTRAL_COUNTERPARTY = 6;
        public const int EXCLUDE_FROM_CENTRAL_COUNTERPARTY = 7;
        public const int MANUAL_MODE = 8;
        public const int AUTOMATIC_POSTING_MODE = 9;
    }


    /// <summary>
    /// TradeInputSource Field
    /// </summary>/
    public sealed class TradeInputSource : StringField
    {
        public TradeInputSource()
            :base(Tags.TradeInputSource) {}
        public TradeInputSource(string val)
            :base(Tags.TradeInputSource, val) {}

    }


    /// <summary>
    /// TradeInputDevice Field
    /// </summary>/
    public sealed class TradeInputDevice : StringField
    {
        public TradeInputDevice()
            :base(Tags.TradeInputDevice) {}
        public TradeInputDevice(string val)
            :base(Tags.TradeInputDevice, val) {}

    }


    /// <summary>
    /// NoDates Field
    /// </summary>/
    public sealed class NoDates : IntField
    {
        public NoDates()
            :base(Tags.NoDates) {}
        public NoDates(int val)
            :base(Tags.NoDates, val) {}

    }


    /// <summary>
    /// AccountType Field
    /// </summary>/
    public sealed class AccountType : IntField
    {
        public AccountType()
            :base(Tags.AccountType) {}
        public AccountType(int val)
            :base(Tags.AccountType, val) {}


        // Field Enumerations
        public const int ACCOUNT_IS_CARRIED_ON_CUSTOMER_SIDE_OF_THE_BOOKS = 1;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS = 2;
        public const int HOUSE_TRADER = 3;
        public const int FLOOR_TRADER = 4;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS_AND_IS_CROSS_MARGINED = 6;
        public const int ACCOUNT_IS_HOUSE_TRADER_AND_IS_CROSS_MARGINED = 7;
        public const int JOINT_BACK_OFFICE_ACCOUNT = 8;
    }


    /// <summary>
    /// CustOrderCapacity Field
    /// </summary>/
    public sealed class CustOrderCapacity : IntField
    {
        public CustOrderCapacity()
            :base(Tags.CustOrderCapacity) {}
        public CustOrderCapacity(int val)
            :base(Tags.CustOrderCapacity, val) {}


        // Field Enumerations
        public const int MEMBER_TRADING_FOR_THEIR_OWN_ACCOUNT = 1;
        public const int CLEARING_FIRM_TRADING_FOR_ITS_PROPRIETARY_ACCOUNT = 2;
        public const int MEMBER_TRADING_FOR_ANOTHER_MEMBER = 3;
        public const int ALL_OTHER = 4;
    }


    /// <summary>
    /// ClOrdLinkID Field
    /// </summary>/
    public sealed class ClOrdLinkID : StringField
    {
        public ClOrdLinkID()
            :base(Tags.ClOrdLinkID) {}
        public ClOrdLinkID(string val)
            :base(Tags.ClOrdLinkID, val) {}

    }


    /// <summary>
    /// MassStatusReqID Field
    /// </summary>/
    public sealed class MassStatusReqID : StringField
    {
        public MassStatusReqID()
            :base(Tags.MassStatusReqID) {}
        public MassStatusReqID(string val)
            :base(Tags.MassStatusReqID, val) {}

    }


    /// <summary>
    /// MassStatusReqType Field
    /// </summary>/
    public sealed class MassStatusReqType : IntField
    {
        public MassStatusReqType()
            :base(Tags.MassStatusReqType) {}
        public MassStatusReqType(int val)
            :base(Tags.MassStatusReqType, val) {}


        // Field Enumerations
        public const int STATUS_FOR_ORDERS_FOR_A_SECURITY = 1;
        public const int STATUS_FOR_ORDERS_FOR_AN_UNDERLYING_SECURITY = 2;
        public const int STATUS_FOR_ORDERS_FOR_A_PRODUCT = 3;
        public const int STATUS_FOR_ORDERS_FOR_A_CFICODE = 4;
        public const int STATUS_FOR_ORDERS_FOR_A_SECURITYTYPE = 5;
        public const int STATUS_FOR_ORDERS_FOR_A_TRADING_SESSION = 6;
        public const int STATUS_FOR_ALL_ORDERS = 7;
        public const int STATUS_FOR_ORDERS_FOR_A_PARTYID = 8;
    }


    /// <summary>
    /// OrigOrdModTime Field
    /// </summary>/
    public sealed class OrigOrdModTime : DateTimeField
    {
        public OrigOrdModTime()
            :base(Tags.OrigOrdModTime) {}
        public OrigOrdModTime(DateTime val)
            :base(Tags.OrigOrdModTime, val) {}

    }


    /// <summary>
    /// LegSettlmntTyp Field
    /// </summary>/
    public sealed class LegSettlmntTyp : CharField
    {
        public LegSettlmntTyp()
            :base(Tags.LegSettlmntTyp) {}
        public LegSettlmntTyp(char val)
            :base(Tags.LegSettlmntTyp, val) {}

    }


    /// <summary>
    /// LegFutSettDate Field
    /// </summary>/
    public sealed class LegFutSettDate : StringField
    {
        public LegFutSettDate()
            :base(Tags.LegFutSettDate) {}
        public LegFutSettDate(string val)
            :base(Tags.LegFutSettDate, val) {}

    }


    /// <summary>
    /// DayBookingInst Field
    /// </summary>/
    public sealed class DayBookingInst : CharField
    {
        public DayBookingInst()
            :base(Tags.DayBookingInst) {}
        public DayBookingInst(char val)
            :base(Tags.DayBookingInst, val) {}


        // Field Enumerations
        public const char CAN_TRIGGER_BOOKING_WITHOUT_REFERENCE_TO_THE_ORDER_INITIATOR = '0';
        public const char SPEAK_WITH_ORDER_INITIATOR_BEFORE_BOOKING = '1';
        public const char ACCUMULATE = '2';
    }


    /// <summary>
    /// BookingUnit Field
    /// </summary>/
    public sealed class BookingUnit : CharField
    {
        public BookingUnit()
            :base(Tags.BookingUnit) {}
        public BookingUnit(char val)
            :base(Tags.BookingUnit, val) {}


        // Field Enumerations
        public const char EACH_PARTIAL_EXECUTION_IS_A_BOOKABLE_UNIT = '0';
        public const char AGGREGATE_PARTIAL_EXECUTIONS_ON_THIS_ORDER_AND_BOOK_ONE_TRADE_PER_ORDER = '1';
        public const char AGGREGATE_EXECUTIONS_FOR_THIS_SYMBOL_SIDE_AND_SETTLEMENT_DATE = '2';
    }


    /// <summary>
    /// PreallocMethod Field
    /// </summary>/
    public sealed class PreallocMethod : CharField
    {
        public PreallocMethod()
            :base(Tags.PreallocMethod) {}
        public PreallocMethod(char val)
            :base(Tags.PreallocMethod, val) {}


        // Field Enumerations
        public const char PRO_RATA = '0';
        public const char DO_NOT_PRO_RATA = '1';
    }


    /// <summary>
    /// UnderlyingCountryOfIssue Field
    /// </summary>/
    public sealed class UnderlyingCountryOfIssue : StringField
    {
        public UnderlyingCountryOfIssue()
            :base(Tags.UnderlyingCountryOfIssue) {}
        public UnderlyingCountryOfIssue(string val)
            :base(Tags.UnderlyingCountryOfIssue, val) {}

    }


    /// <summary>
    /// UnderlyingStateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class UnderlyingStateOrProvinceOfIssue : StringField
    {
        public UnderlyingStateOrProvinceOfIssue()
            :base(Tags.UnderlyingStateOrProvinceOfIssue) {}
        public UnderlyingStateOrProvinceOfIssue(string val)
            :base(Tags.UnderlyingStateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// UnderlyingLocaleOfIssue Field
    /// </summary>/
    public sealed class UnderlyingLocaleOfIssue : StringField
    {
        public UnderlyingLocaleOfIssue()
            :base(Tags.UnderlyingLocaleOfIssue) {}
        public UnderlyingLocaleOfIssue(string val)
            :base(Tags.UnderlyingLocaleOfIssue, val) {}

    }


    /// <summary>
    /// UnderlyingInstrRegistry Field
    /// </summary>/
    public sealed class UnderlyingInstrRegistry : StringField
    {
        public UnderlyingInstrRegistry()
            :base(Tags.UnderlyingInstrRegistry) {}
        public UnderlyingInstrRegistry(string val)
            :base(Tags.UnderlyingInstrRegistry, val) {}

    }


    /// <summary>
    /// LegCountryOfIssue Field
    /// </summary>/
    public sealed class LegCountryOfIssue : StringField
    {
        public LegCountryOfIssue()
            :base(Tags.LegCountryOfIssue) {}
        public LegCountryOfIssue(string val)
            :base(Tags.LegCountryOfIssue, val) {}

    }


    /// <summary>
    /// LegStateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class LegStateOrProvinceOfIssue : StringField
    {
        public LegStateOrProvinceOfIssue()
            :base(Tags.LegStateOrProvinceOfIssue) {}
        public LegStateOrProvinceOfIssue(string val)
            :base(Tags.LegStateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// LegLocaleOfIssue Field
    /// </summary>/
    public sealed class LegLocaleOfIssue : StringField
    {
        public LegLocaleOfIssue()
            :base(Tags.LegLocaleOfIssue) {}
        public LegLocaleOfIssue(string val)
            :base(Tags.LegLocaleOfIssue, val) {}

    }


    /// <summary>
    /// LegInstrRegistry Field
    /// </summary>/
    public sealed class LegInstrRegistry : StringField
    {
        public LegInstrRegistry()
            :base(Tags.LegInstrRegistry) {}
        public LegInstrRegistry(string val)
            :base(Tags.LegInstrRegistry, val) {}

    }


    /// <summary>
    /// LegSymbol Field
    /// </summary>/
    public sealed class LegSymbol : StringField
    {
        public LegSymbol()
            :base(Tags.LegSymbol) {}
        public LegSymbol(string val)
            :base(Tags.LegSymbol, val) {}

    }


    /// <summary>
    /// LegSymbolSfx Field
    /// </summary>/
    public sealed class LegSymbolSfx : StringField
    {
        public LegSymbolSfx()
            :base(Tags.LegSymbolSfx) {}
        public LegSymbolSfx(string val)
            :base(Tags.LegSymbolSfx, val) {}

    }


    /// <summary>
    /// LegSecurityID Field
    /// </summary>/
    public sealed class LegSecurityID : StringField
    {
        public LegSecurityID()
            :base(Tags.LegSecurityID) {}
        public LegSecurityID(string val)
            :base(Tags.LegSecurityID, val) {}

    }


    /// <summary>
    /// LegSecurityIDSource Field
    /// </summary>/
    public sealed class LegSecurityIDSource : StringField
    {
        public LegSecurityIDSource()
            :base(Tags.LegSecurityIDSource) {}
        public LegSecurityIDSource(string val)
            :base(Tags.LegSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoLegSecurityAltID Field
    /// </summary>/
    public sealed class NoLegSecurityAltID : StringField
    {
        public NoLegSecurityAltID()
            :base(Tags.NoLegSecurityAltID) {}
        public NoLegSecurityAltID(string val)
            :base(Tags.NoLegSecurityAltID, val) {}

    }


    /// <summary>
    /// LegSecurityAltID Field
    /// </summary>/
    public sealed class LegSecurityAltID : StringField
    {
        public LegSecurityAltID()
            :base(Tags.LegSecurityAltID) {}
        public LegSecurityAltID(string val)
            :base(Tags.LegSecurityAltID, val) {}

    }


    /// <summary>
    /// LegSecurityAltIDSource Field
    /// </summary>/
    public sealed class LegSecurityAltIDSource : StringField
    {
        public LegSecurityAltIDSource()
            :base(Tags.LegSecurityAltIDSource) {}
        public LegSecurityAltIDSource(string val)
            :base(Tags.LegSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// LegProduct Field
    /// </summary>/
    public sealed class LegProduct : IntField
    {
        public LegProduct()
            :base(Tags.LegProduct) {}
        public LegProduct(int val)
            :base(Tags.LegProduct, val) {}

    }


    /// <summary>
    /// LegCFICode Field
    /// </summary>/
    public sealed class LegCFICode : StringField
    {
        public LegCFICode()
            :base(Tags.LegCFICode) {}
        public LegCFICode(string val)
            :base(Tags.LegCFICode, val) {}

    }


    /// <summary>
    /// LegSecurityType Field
    /// </summary>/
    public sealed class LegSecurityType : StringField
    {
        public LegSecurityType()
            :base(Tags.LegSecurityType) {}
        public LegSecurityType(string val)
            :base(Tags.LegSecurityType, val) {}

    }


    /// <summary>
    /// LegMaturityMonthYear Field
    /// </summary>/
    public sealed class LegMaturityMonthYear : StringField
    {
        public LegMaturityMonthYear()
            :base(Tags.LegMaturityMonthYear) {}
        public LegMaturityMonthYear(string val)
            :base(Tags.LegMaturityMonthYear, val) {}

    }


    /// <summary>
    /// LegMaturityDate Field
    /// </summary>/
    public sealed class LegMaturityDate : StringField
    {
        public LegMaturityDate()
            :base(Tags.LegMaturityDate) {}
        public LegMaturityDate(string val)
            :base(Tags.LegMaturityDate, val) {}

    }


    /// <summary>
    /// LegStrikePrice Field
    /// </summary>/
    public sealed class LegStrikePrice : DecimalField
    {
        public LegStrikePrice()
            :base(Tags.LegStrikePrice) {}
        public LegStrikePrice(Decimal val)
            :base(Tags.LegStrikePrice, val) {}

    }


    /// <summary>
    /// LegOptAttribute Field
    /// </summary>/
    public sealed class LegOptAttribute : CharField
    {
        public LegOptAttribute()
            :base(Tags.LegOptAttribute) {}
        public LegOptAttribute(char val)
            :base(Tags.LegOptAttribute, val) {}

    }


    /// <summary>
    /// LegContractMultiplier Field
    /// </summary>/
    public sealed class LegContractMultiplier : DecimalField
    {
        public LegContractMultiplier()
            :base(Tags.LegContractMultiplier) {}
        public LegContractMultiplier(Decimal val)
            :base(Tags.LegContractMultiplier, val) {}

    }


    /// <summary>
    /// LegCouponRate Field
    /// </summary>/
    public sealed class LegCouponRate : DecimalField
    {
        public LegCouponRate()
            :base(Tags.LegCouponRate) {}
        public LegCouponRate(Decimal val)
            :base(Tags.LegCouponRate, val) {}

    }


    /// <summary>
    /// LegSecurityExchange Field
    /// </summary>/
    public sealed class LegSecurityExchange : StringField
    {
        public LegSecurityExchange()
            :base(Tags.LegSecurityExchange) {}
        public LegSecurityExchange(string val)
            :base(Tags.LegSecurityExchange, val) {}

    }


    /// <summary>
    /// LegIssuer Field
    /// </summary>/
    public sealed class LegIssuer : StringField
    {
        public LegIssuer()
            :base(Tags.LegIssuer) {}
        public LegIssuer(string val)
            :base(Tags.LegIssuer, val) {}

    }


    /// <summary>
    /// EncodedLegIssuerLen Field
    /// </summary>/
    public sealed class EncodedLegIssuerLen : DecimalField
    {
        public EncodedLegIssuerLen()
            :base(Tags.EncodedLegIssuerLen) {}
        public EncodedLegIssuerLen(Decimal val)
            :base(Tags.EncodedLegIssuerLen, val) {}

    }


    /// <summary>
    /// EncodedLegIssuer Field
    /// </summary>/
    public sealed class EncodedLegIssuer : StringField
    {
        public EncodedLegIssuer()
            :base(Tags.EncodedLegIssuer) {}
        public EncodedLegIssuer(string val)
            :base(Tags.EncodedLegIssuer, val) {}

    }


    /// <summary>
    /// LegSecurityDesc Field
    /// </summary>/
    public sealed class LegSecurityDesc : StringField
    {
        public LegSecurityDesc()
            :base(Tags.LegSecurityDesc) {}
        public LegSecurityDesc(string val)
            :base(Tags.LegSecurityDesc, val) {}

    }


    /// <summary>
    /// EncodedLegSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedLegSecurityDescLen : DecimalField
    {
        public EncodedLegSecurityDescLen()
            :base(Tags.EncodedLegSecurityDescLen) {}
        public EncodedLegSecurityDescLen(Decimal val)
            :base(Tags.EncodedLegSecurityDescLen, val) {}

    }


    /// <summary>
    /// EncodedLegSecurityDesc Field
    /// </summary>/
    public sealed class EncodedLegSecurityDesc : StringField
    {
        public EncodedLegSecurityDesc()
            :base(Tags.EncodedLegSecurityDesc) {}
        public EncodedLegSecurityDesc(string val)
            :base(Tags.EncodedLegSecurityDesc, val) {}

    }


    /// <summary>
    /// LegRatioQty Field
    /// </summary>/
    public sealed class LegRatioQty : DecimalField
    {
        public LegRatioQty()
            :base(Tags.LegRatioQty) {}
        public LegRatioQty(Decimal val)
            :base(Tags.LegRatioQty, val) {}

    }


    /// <summary>
    /// LegSide Field
    /// </summary>/
    public sealed class LegSide : CharField
    {
        public LegSide()
            :base(Tags.LegSide) {}
        public LegSide(char val)
            :base(Tags.LegSide, val) {}

    }


    /// <summary>
    /// TradingSessionSubID Field
    /// </summary>/
    public sealed class TradingSessionSubID : StringField
    {
        public TradingSessionSubID()
            :base(Tags.TradingSessionSubID) {}
        public TradingSessionSubID(string val)
            :base(Tags.TradingSessionSubID, val) {}

    }


    /// <summary>
    /// AllocType Field
    /// </summary>/
    public sealed class AllocType : IntField
    {
        public AllocType()
            :base(Tags.AllocType) {}
        public AllocType(int val)
            :base(Tags.AllocType, val) {}


        // Field Enumerations
        public const int CALCULATED = 1;
        public const int PRELIMINARY = 2;
        public const int SELLSIDE_CALCULATED_USING_PRELIMINARY = 3;
        public const int SELLSIDE_CALCULATED_WITHOUT_PRELIMINARY = 4;
        public const int READY_TO_BOOK = 5;
        public const int BUYSIDE_READY_TO_BOOK = 6;
        public const int WAREHOUSE_INSTRUCTION = 7;
        public const int REQUEST_TO_INTERMEDIARY = 8;
        public const int ACCEPT = 9;
        public const int REJECT = 10;
        public const int ACCEPT_PENDING = 11;
        public const int INCOMPLETE_GROUP = 12;
        public const int COMPLETE_GROUP = 13;
        public const int REVERSAL_PENDING = 14;
    }


    /// <summary>
    /// NoHops Field
    /// </summary>/
    public sealed class NoHops : IntField
    {
        public NoHops()
            :base(Tags.NoHops) {}
        public NoHops(int val)
            :base(Tags.NoHops, val) {}

    }


    /// <summary>
    /// HopCompID Field
    /// </summary>/
    public sealed class HopCompID : StringField
    {
        public HopCompID()
            :base(Tags.HopCompID) {}
        public HopCompID(string val)
            :base(Tags.HopCompID, val) {}

    }


    /// <summary>
    /// HopSendingTime Field
    /// </summary>/
    public sealed class HopSendingTime : DateTimeField
    {
        public HopSendingTime()
            :base(Tags.HopSendingTime) {}
        public HopSendingTime(DateTime val)
            :base(Tags.HopSendingTime, val) {}

    }


    /// <summary>
    /// HopRefID Field
    /// </summary>/
    public sealed class HopRefID : IntField
    {
        public HopRefID()
            :base(Tags.HopRefID) {}
        public HopRefID(int val)
            :base(Tags.HopRefID, val) {}

    }


    /// <summary>
    /// MidPx Field
    /// </summary>/
    public sealed class MidPx : DecimalField
    {
        public MidPx()
            :base(Tags.MidPx) {}
        public MidPx(Decimal val)
            :base(Tags.MidPx, val) {}

    }


    /// <summary>
    /// BidYield Field
    /// </summary>/
    public sealed class BidYield : DecimalField
    {
        public BidYield()
            :base(Tags.BidYield) {}
        public BidYield(Decimal val)
            :base(Tags.BidYield, val) {}

    }


    /// <summary>
    /// MidYield Field
    /// </summary>/
    public sealed class MidYield : DecimalField
    {
        public MidYield()
            :base(Tags.MidYield) {}
        public MidYield(Decimal val)
            :base(Tags.MidYield, val) {}

    }


    /// <summary>
    /// OfferYield Field
    /// </summary>/
    public sealed class OfferYield : DecimalField
    {
        public OfferYield()
            :base(Tags.OfferYield) {}
        public OfferYield(Decimal val)
            :base(Tags.OfferYield, val) {}

    }


    /// <summary>
    /// ClearingFeeIndicator Field
    /// </summary>/
    public sealed class ClearingFeeIndicator : StringField
    {
        public ClearingFeeIndicator()
            :base(Tags.ClearingFeeIndicator) {}
        public ClearingFeeIndicator(string val)
            :base(Tags.ClearingFeeIndicator, val) {}


        // Field Enumerations
        public const string VAL_1ST_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "1";
        public const string VAL_2ND_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "2";
        public const string VAL_3RD_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "3";
        public const string VAL_4TH_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "4";
        public const string VAL_5TH_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "5";
        public const string VAL_6TH_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "9";
        public const string CBOE_MEMBER = "B";
        public const string NON_MEMBER_AND_CUSTOMER = "C";
        public const string EQUITY_MEMBER_AND_CLEARING_MEMBER = "E";
        public const string FULL_AND_ASSOCIATE_MEMBER_TRADING_FOR_OWN_ACCOUNT_AND_AS_FLOOR_BROKERS = "F";
        public const string VAL_106H_AND_106J_FIRMS = "H";
        public const string GIM_IDEM_AND_COM_MEMBERSHIP_INTEREST_HOLDERS = "I";
        public const string LESSEE_106F_EMPLOYEES = "L";
        public const string ALL_OTHER_OWNERSHIP_TYPES = "M";
    }


    /// <summary>
    /// WorkingIndicator Field
    /// </summary>/
    public sealed class WorkingIndicator : BooleanField
    {
        public WorkingIndicator()
            :base(Tags.WorkingIndicator) {}
        public WorkingIndicator(Boolean val)
            :base(Tags.WorkingIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// LegLastPx Field
    /// </summary>/
    public sealed class LegLastPx : DecimalField
    {
        public LegLastPx()
            :base(Tags.LegLastPx) {}
        public LegLastPx(Decimal val)
            :base(Tags.LegLastPx, val) {}

    }


    /// <summary>
    /// PriorityIndicator Field
    /// </summary>/
    public sealed class PriorityIndicator : IntField
    {
        public PriorityIndicator()
            :base(Tags.PriorityIndicator) {}
        public PriorityIndicator(int val)
            :base(Tags.PriorityIndicator, val) {}


        // Field Enumerations
        public const int PRIORITY_UNCHANGED = 0;
        public const int LOST_PRIORITY_AS_RESULT_OF_ORDER_CHANGE = 1;
    }


    /// <summary>
    /// PriceImprovement Field
    /// </summary>/
    public sealed class PriceImprovement : DecimalField
    {
        public PriceImprovement()
            :base(Tags.PriceImprovement) {}
        public PriceImprovement(Decimal val)
            :base(Tags.PriceImprovement, val) {}

    }


    /// <summary>
    /// Price2 Field
    /// </summary>/
    public sealed class Price2 : DecimalField
    {
        public Price2()
            :base(Tags.Price2) {}
        public Price2(Decimal val)
            :base(Tags.Price2, val) {}

    }


    /// <summary>
    /// LastForwardPoints2 Field
    /// </summary>/
    public sealed class LastForwardPoints2 : DecimalField
    {
        public LastForwardPoints2()
            :base(Tags.LastForwardPoints2) {}
        public LastForwardPoints2(Decimal val)
            :base(Tags.LastForwardPoints2, val) {}

    }


    /// <summary>
    /// BidForwardPoints2 Field
    /// </summary>/
    public sealed class BidForwardPoints2 : DecimalField
    {
        public BidForwardPoints2()
            :base(Tags.BidForwardPoints2) {}
        public BidForwardPoints2(Decimal val)
            :base(Tags.BidForwardPoints2, val) {}

    }


    /// <summary>
    /// OfferForwardPoints2 Field
    /// </summary>/
    public sealed class OfferForwardPoints2 : DecimalField
    {
        public OfferForwardPoints2()
            :base(Tags.OfferForwardPoints2) {}
        public OfferForwardPoints2(Decimal val)
            :base(Tags.OfferForwardPoints2, val) {}

    }


    /// <summary>
    /// RFQReqID Field
    /// </summary>/
    public sealed class RFQReqID : StringField
    {
        public RFQReqID()
            :base(Tags.RFQReqID) {}
        public RFQReqID(string val)
            :base(Tags.RFQReqID, val) {}

    }


    /// <summary>
    /// MktBidPx Field
    /// </summary>/
    public sealed class MktBidPx : DecimalField
    {
        public MktBidPx()
            :base(Tags.MktBidPx) {}
        public MktBidPx(Decimal val)
            :base(Tags.MktBidPx, val) {}

    }


    /// <summary>
    /// MktOfferPx Field
    /// </summary>/
    public sealed class MktOfferPx : DecimalField
    {
        public MktOfferPx()
            :base(Tags.MktOfferPx) {}
        public MktOfferPx(Decimal val)
            :base(Tags.MktOfferPx, val) {}

    }


    /// <summary>
    /// MinBidSize Field
    /// </summary>/
    public sealed class MinBidSize : DecimalField
    {
        public MinBidSize()
            :base(Tags.MinBidSize) {}
        public MinBidSize(Decimal val)
            :base(Tags.MinBidSize, val) {}

    }


    /// <summary>
    /// MinOfferSize Field
    /// </summary>/
    public sealed class MinOfferSize : DecimalField
    {
        public MinOfferSize()
            :base(Tags.MinOfferSize) {}
        public MinOfferSize(Decimal val)
            :base(Tags.MinOfferSize, val) {}

    }


    /// <summary>
    /// QuoteStatusReqID Field
    /// </summary>/
    public sealed class QuoteStatusReqID : StringField
    {
        public QuoteStatusReqID()
            :base(Tags.QuoteStatusReqID) {}
        public QuoteStatusReqID(string val)
            :base(Tags.QuoteStatusReqID, val) {}

    }


    /// <summary>
    /// LegalConfirm Field
    /// </summary>/
    public sealed class LegalConfirm : BooleanField
    {
        public LegalConfirm()
            :base(Tags.LegalConfirm) {}
        public LegalConfirm(Boolean val)
            :base(Tags.LegalConfirm, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// UnderlyingLastPx Field
    /// </summary>/
    public sealed class UnderlyingLastPx : DecimalField
    {
        public UnderlyingLastPx()
            :base(Tags.UnderlyingLastPx) {}
        public UnderlyingLastPx(Decimal val)
            :base(Tags.UnderlyingLastPx, val) {}

    }


    /// <summary>
    /// UnderlyingLastQty Field
    /// </summary>/
    public sealed class UnderlyingLastQty : DecimalField
    {
        public UnderlyingLastQty()
            :base(Tags.UnderlyingLastQty) {}
        public UnderlyingLastQty(Decimal val)
            :base(Tags.UnderlyingLastQty, val) {}

    }


    /// <summary>
    /// SecDefStatus Field
    /// </summary>/
    public sealed class SecDefStatus : IntField
    {
        public SecDefStatus()
            :base(Tags.SecDefStatus) {}
        public SecDefStatus(int val)
            :base(Tags.SecDefStatus, val) {}


        // Field Enumerations
        public const int PENDING_APPROVAL = 0;
        public const int APPROVED = 1;
        public const int REJECTED = 2;
        public const int UNAUTHORIZED_REQUEST = 3;
        public const int INVALID_DEFINITION_REQUEST = 4;
    }


    /// <summary>
    /// LegRefID Field
    /// </summary>/
    public sealed class LegRefID : StringField
    {
        public LegRefID()
            :base(Tags.LegRefID) {}
        public LegRefID(string val)
            :base(Tags.LegRefID, val) {}

    }


    /// <summary>
    /// ContraLegRefID Field
    /// </summary>/
    public sealed class ContraLegRefID : StringField
    {
        public ContraLegRefID()
            :base(Tags.ContraLegRefID) {}
        public ContraLegRefID(string val)
            :base(Tags.ContraLegRefID, val) {}

    }


    /// <summary>
    /// SettlCurrBidFxRate Field
    /// </summary>/
    public sealed class SettlCurrBidFxRate : DecimalField
    {
        public SettlCurrBidFxRate()
            :base(Tags.SettlCurrBidFxRate) {}
        public SettlCurrBidFxRate(Decimal val)
            :base(Tags.SettlCurrBidFxRate, val) {}

    }


    /// <summary>
    /// SettlCurrOfferFxRate Field
    /// </summary>/
    public sealed class SettlCurrOfferFxRate : DecimalField
    {
        public SettlCurrOfferFxRate()
            :base(Tags.SettlCurrOfferFxRate) {}
        public SettlCurrOfferFxRate(Decimal val)
            :base(Tags.SettlCurrOfferFxRate, val) {}

    }


    /// <summary>
    /// QuoteRequestRejectReason Field
    /// </summary>/
    public sealed class QuoteRequestRejectReason : IntField
    {
        public QuoteRequestRejectReason()
            :base(Tags.QuoteRequestRejectReason) {}
        public QuoteRequestRejectReason(int val)
            :base(Tags.QuoteRequestRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_SYMBOL = 1;
        public const int PASS = 10;
        public const int EXCHANGE = 2;
        public const int QUOTE_REQUEST_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int INVALID_PRICE = 5;
        public const int NOT_AUTHORIZED_TO_REQUEST_QUOTE = 6;
        public const int NO_MATCH_FOR_INQUIRY = 7;
        public const int NO_MARKET_FOR_INSTRUMENT = 8;
        public const int NO_INVENTORY = 9;
        public const int OTHER = 99;
        public const int INSUFFICIENT_CREDIT = 11;
    }


    /// <summary>
    /// SideComplianceID Field
    /// </summary>/
    public sealed class SideComplianceID : StringField
    {
        public SideComplianceID()
            :base(Tags.SideComplianceID) {}
        public SideComplianceID(string val)
            :base(Tags.SideComplianceID, val) {}

    }


    /// <summary>
    /// SettlType Field
    /// </summary>/
    public sealed class SettlType : StringField
    {
        public SettlType()
            :base(Tags.SettlType) {}
        public SettlType(string val)
            :base(Tags.SettlType, val) {}


        // Field Enumerations
        public const string REGULAR = "0";
        public const string CASH = "1";
        public const string NEXT_DAY = "2";
        public const string T_PLUS_2 = "3";
        public const string T_PLUS_3 = "4";
        public const string T_PLUS_4 = "5";
        public const string FUTURE = "6";
        public const string WHEN_AND_IF_ISSUED = "7";
        public const string SELLERS_OPTION = "8";
        public const string T_PLUS_5 = "9";
        public const string FX_SPOT_NEXT_SETTLEMENT = "C";
        public const string BROKEN_DATE = "B";
    }


    /// <summary>
    /// SettlDate Field
    /// </summary>/
    public sealed class SettlDate : StringField
    {
        public SettlDate()
            :base(Tags.SettlDate) {}
        public SettlDate(string val)
            :base(Tags.SettlDate, val) {}

    }


    /// <summary>
    /// AvgPxPrecision Field
    /// </summary>/
    public sealed class AvgPxPrecision : IntField
    {
        public AvgPxPrecision()
            :base(Tags.AvgPxPrecision) {}
        public AvgPxPrecision(int val)
            :base(Tags.AvgPxPrecision, val) {}

    }


    /// <summary>
    /// SettlDate2 Field
    /// </summary>/
    public sealed class SettlDate2 : StringField
    {
        public SettlDate2()
            :base(Tags.SettlDate2) {}
        public SettlDate2(string val)
            :base(Tags.SettlDate2, val) {}

    }


    /// <summary>
    /// PegOffsetValue Field
    /// </summary>/
    public sealed class PegOffsetValue : DecimalField
    {
        public PegOffsetValue()
            :base(Tags.PegOffsetValue) {}
        public PegOffsetValue(Decimal val)
            :base(Tags.PegOffsetValue, val) {}

    }


    /// <summary>
    /// OpenCloseSettlFlag Field
    /// </summary>/
    public sealed class OpenCloseSettlFlag : StringField
    {
        public OpenCloseSettlFlag()
            :base(Tags.OpenCloseSettlFlag) {}
        public OpenCloseSettlFlag(string val)
            :base(Tags.OpenCloseSettlFlag, val) {}


        // Field Enumerations
        public const string DAILY_OPEN = "0";
        public const string SESSION_OPEN = "1";
        public const string DELIVERY_SETTLEMENT_ENTRY = "2";
        public const string EXPECTED_ENTRY = "3";
        public const string ENTRY_FROM_PREVIOUS_BUSINESS_DAY = "4";
        public const string THEORETICAL_PRICE_VALUE = "5";
    }


    /// <summary>
    /// TotNoQuoteEntries Field
    /// </summary>/
    public sealed class TotNoQuoteEntries : IntField
    {
        public TotNoQuoteEntries()
            :base(Tags.TotNoQuoteEntries) {}
        public TotNoQuoteEntries(int val)
            :base(Tags.TotNoQuoteEntries, val) {}

    }


    /// <summary>
    /// DiscretionOffsetValue Field
    /// </summary>/
    public sealed class DiscretionOffsetValue : DecimalField
    {
        public DiscretionOffsetValue()
            :base(Tags.DiscretionOffsetValue) {}
        public DiscretionOffsetValue(Decimal val)
            :base(Tags.DiscretionOffsetValue, val) {}

    }


    /// <summary>
    /// TotNoRelatedSym Field
    /// </summary>/
    public sealed class TotNoRelatedSym : IntField
    {
        public TotNoRelatedSym()
            :base(Tags.TotNoRelatedSym) {}
        public TotNoRelatedSym(int val)
            :base(Tags.TotNoRelatedSym, val) {}

    }


    /// <summary>
    /// BidTradeType Field
    /// </summary>/
    public sealed class BidTradeType : CharField
    {
        public BidTradeType()
            :base(Tags.BidTradeType) {}
        public BidTradeType(char val)
            :base(Tags.BidTradeType, val) {}


        // Field Enumerations
        public const char AGENCY = 'A';
        public const char VWAP_GUARANTEE = 'G';
        public const char GUARANTEED_CLOSE = 'J';
        public const char RISK_TRADE = 'R';
    }


    /// <summary>
    /// CardIssNum Field
    /// </summary>/
    public sealed class CardIssNum : StringField
    {
        public CardIssNum()
            :base(Tags.CardIssNum) {}
        public CardIssNum(string val)
            :base(Tags.CardIssNum, val) {}

    }


    /// <summary>
    /// RegistDtls Field
    /// </summary>/
    public sealed class RegistDtls : StringField
    {
        public RegistDtls()
            :base(Tags.RegistDtls) {}
        public RegistDtls(string val)
            :base(Tags.RegistDtls, val) {}

    }


    /// <summary>
    /// TotNoSecurityTypes Field
    /// </summary>/
    public sealed class TotNoSecurityTypes : IntField
    {
        public TotNoSecurityTypes()
            :base(Tags.TotNoSecurityTypes) {}
        public TotNoSecurityTypes(int val)
            :base(Tags.TotNoSecurityTypes, val) {}

    }


    /// <summary>
    /// LegSettlType Field
    /// </summary>/
    public sealed class LegSettlType : CharField
    {
        public LegSettlType()
            :base(Tags.LegSettlType) {}
        public LegSettlType(char val)
            :base(Tags.LegSettlType, val) {}

    }


    /// <summary>
    /// LegSettlDate Field
    /// </summary>/
    public sealed class LegSettlDate : StringField
    {
        public LegSettlDate()
            :base(Tags.LegSettlDate) {}
        public LegSettlDate(string val)
            :base(Tags.LegSettlDate, val) {}

    }


    /// <summary>
    /// AcctIDSource Field
    /// </summary>/
    public sealed class AcctIDSource : IntField
    {
        public AcctIDSource()
            :base(Tags.AcctIDSource) {}
        public AcctIDSource(int val)
            :base(Tags.AcctIDSource, val) {}


        // Field Enumerations
        public const int BIC = 1;
        public const int SID_CODE = 2;
        public const int TFM = 3;
        public const int OMGEO = 4;
        public const int DTCC_CODE = 5;
        public const int OTHER = 99;
    }


    /// <summary>
    /// AllocAcctIDSource Field
    /// </summary>/
    public sealed class AllocAcctIDSource : IntField
    {
        public AllocAcctIDSource()
            :base(Tags.AllocAcctIDSource) {}
        public AllocAcctIDSource(int val)
            :base(Tags.AllocAcctIDSource, val) {}

    }


    /// <summary>
    /// BenchmarkPrice Field
    /// </summary>/
    public sealed class BenchmarkPrice : DecimalField
    {
        public BenchmarkPrice()
            :base(Tags.BenchmarkPrice) {}
        public BenchmarkPrice(Decimal val)
            :base(Tags.BenchmarkPrice, val) {}

    }


    /// <summary>
    /// BenchmarkPriceType Field
    /// </summary>/
    public sealed class BenchmarkPriceType : IntField
    {
        public BenchmarkPriceType()
            :base(Tags.BenchmarkPriceType) {}
        public BenchmarkPriceType(int val)
            :base(Tags.BenchmarkPriceType, val) {}

    }


    /// <summary>
    /// ConfirmID Field
    /// </summary>/
    public sealed class ConfirmID : StringField
    {
        public ConfirmID()
            :base(Tags.ConfirmID) {}
        public ConfirmID(string val)
            :base(Tags.ConfirmID, val) {}

    }


    /// <summary>
    /// ConfirmStatus Field
    /// </summary>/
    public sealed class ConfirmStatus : IntField
    {
        public ConfirmStatus()
            :base(Tags.ConfirmStatus) {}
        public ConfirmStatus(int val)
            :base(Tags.ConfirmStatus, val) {}


        // Field Enumerations
        public const int RECEIVED = 1;
        public const int MISMATCHED_ACCOUNT = 2;
        public const int MISSING_SETTLEMENT_INSTRUCTIONS = 3;
        public const int CONFIRMED = 4;
        public const int REQUEST_REJECTED = 5;
    }


    /// <summary>
    /// ConfirmTransType Field
    /// </summary>/
    public sealed class ConfirmTransType : IntField
    {
        public ConfirmTransType()
            :base(Tags.ConfirmTransType) {}
        public ConfirmTransType(int val)
            :base(Tags.ConfirmTransType, val) {}


        // Field Enumerations
        public const int NEW = 0;
        public const int REPLACE = 1;
        public const int CANCEL = 2;
    }


    /// <summary>
    /// ContractSettlMonth Field
    /// </summary>/
    public sealed class ContractSettlMonth : StringField
    {
        public ContractSettlMonth()
            :base(Tags.ContractSettlMonth) {}
        public ContractSettlMonth(string val)
            :base(Tags.ContractSettlMonth, val) {}

    }


    /// <summary>
    /// DeliveryForm Field
    /// </summary>/
    public sealed class DeliveryForm : IntField
    {
        public DeliveryForm()
            :base(Tags.DeliveryForm) {}
        public DeliveryForm(int val)
            :base(Tags.DeliveryForm, val) {}


        // Field Enumerations
        public const int BOOK_ENTRY = 1;
        public const int BEARER = 2;
    }


    /// <summary>
    /// LastParPx Field
    /// </summary>/
    public sealed class LastParPx : DecimalField
    {
        public LastParPx()
            :base(Tags.LastParPx) {}
        public LastParPx(Decimal val)
            :base(Tags.LastParPx, val) {}

    }


    /// <summary>
    /// NoLegAllocs Field
    /// </summary>/
    public sealed class NoLegAllocs : IntField
    {
        public NoLegAllocs()
            :base(Tags.NoLegAllocs) {}
        public NoLegAllocs(int val)
            :base(Tags.NoLegAllocs, val) {}

    }


    /// <summary>
    /// LegAllocAccount Field
    /// </summary>/
    public sealed class LegAllocAccount : StringField
    {
        public LegAllocAccount()
            :base(Tags.LegAllocAccount) {}
        public LegAllocAccount(string val)
            :base(Tags.LegAllocAccount, val) {}

    }


    /// <summary>
    /// LegIndividualAllocID Field
    /// </summary>/
    public sealed class LegIndividualAllocID : StringField
    {
        public LegIndividualAllocID()
            :base(Tags.LegIndividualAllocID) {}
        public LegIndividualAllocID(string val)
            :base(Tags.LegIndividualAllocID, val) {}

    }


    /// <summary>
    /// LegAllocQty Field
    /// </summary>/
    public sealed class LegAllocQty : DecimalField
    {
        public LegAllocQty()
            :base(Tags.LegAllocQty) {}
        public LegAllocQty(Decimal val)
            :base(Tags.LegAllocQty, val) {}

    }


    /// <summary>
    /// LegAllocAcctIDSource Field
    /// </summary>/
    public sealed class LegAllocAcctIDSource : StringField
    {
        public LegAllocAcctIDSource()
            :base(Tags.LegAllocAcctIDSource) {}
        public LegAllocAcctIDSource(string val)
            :base(Tags.LegAllocAcctIDSource, val) {}

    }


    /// <summary>
    /// LegSettlCurrency Field
    /// </summary>/
    public sealed class LegSettlCurrency : DecimalField
    {
        public LegSettlCurrency()
            :base(Tags.LegSettlCurrency) {}
        public LegSettlCurrency(Decimal val)
            :base(Tags.LegSettlCurrency, val) {}

    }


    /// <summary>
    /// LegBenchmarkCurveCurrency Field
    /// </summary>/
    public sealed class LegBenchmarkCurveCurrency : DecimalField
    {
        public LegBenchmarkCurveCurrency()
            :base(Tags.LegBenchmarkCurveCurrency) {}
        public LegBenchmarkCurveCurrency(Decimal val)
            :base(Tags.LegBenchmarkCurveCurrency, val) {}

    }


    /// <summary>
    /// LegBenchmarkCurveName Field
    /// </summary>/
    public sealed class LegBenchmarkCurveName : StringField
    {
        public LegBenchmarkCurveName()
            :base(Tags.LegBenchmarkCurveName) {}
        public LegBenchmarkCurveName(string val)
            :base(Tags.LegBenchmarkCurveName, val) {}

    }


    /// <summary>
    /// LegBenchmarkCurvePoint Field
    /// </summary>/
    public sealed class LegBenchmarkCurvePoint : StringField
    {
        public LegBenchmarkCurvePoint()
            :base(Tags.LegBenchmarkCurvePoint) {}
        public LegBenchmarkCurvePoint(string val)
            :base(Tags.LegBenchmarkCurvePoint, val) {}

    }


    /// <summary>
    /// LegBenchmarkPrice Field
    /// </summary>/
    public sealed class LegBenchmarkPrice : DecimalField
    {
        public LegBenchmarkPrice()
            :base(Tags.LegBenchmarkPrice) {}
        public LegBenchmarkPrice(Decimal val)
            :base(Tags.LegBenchmarkPrice, val) {}

    }


    /// <summary>
    /// LegBenchmarkPriceType Field
    /// </summary>/
    public sealed class LegBenchmarkPriceType : IntField
    {
        public LegBenchmarkPriceType()
            :base(Tags.LegBenchmarkPriceType) {}
        public LegBenchmarkPriceType(int val)
            :base(Tags.LegBenchmarkPriceType, val) {}

    }


    /// <summary>
    /// LegBidPx Field
    /// </summary>/
    public sealed class LegBidPx : DecimalField
    {
        public LegBidPx()
            :base(Tags.LegBidPx) {}
        public LegBidPx(Decimal val)
            :base(Tags.LegBidPx, val) {}

    }


    /// <summary>
    /// LegIOIQty Field
    /// </summary>/
    public sealed class LegIOIQty : StringField
    {
        public LegIOIQty()
            :base(Tags.LegIOIQty) {}
        public LegIOIQty(string val)
            :base(Tags.LegIOIQty, val) {}

    }


    /// <summary>
    /// NoLegStipulations Field
    /// </summary>/
    public sealed class NoLegStipulations : IntField
    {
        public NoLegStipulations()
            :base(Tags.NoLegStipulations) {}
        public NoLegStipulations(int val)
            :base(Tags.NoLegStipulations, val) {}

    }


    /// <summary>
    /// LegOfferPx Field
    /// </summary>/
    public sealed class LegOfferPx : DecimalField
    {
        public LegOfferPx()
            :base(Tags.LegOfferPx) {}
        public LegOfferPx(Decimal val)
            :base(Tags.LegOfferPx, val) {}

    }


    /// <summary>
    /// LegOrderQty Field
    /// </summary>/
    public sealed class LegOrderQty : DecimalField
    {
        public LegOrderQty()
            :base(Tags.LegOrderQty) {}
        public LegOrderQty(Decimal val)
            :base(Tags.LegOrderQty, val) {}

    }


    /// <summary>
    /// LegPriceType Field
    /// </summary>/
    public sealed class LegPriceType : IntField
    {
        public LegPriceType()
            :base(Tags.LegPriceType) {}
        public LegPriceType(int val)
            :base(Tags.LegPriceType, val) {}

    }


    /// <summary>
    /// LegQty Field
    /// </summary>/
    public sealed class LegQty : DecimalField
    {
        public LegQty()
            :base(Tags.LegQty) {}
        public LegQty(Decimal val)
            :base(Tags.LegQty, val) {}

    }


    /// <summary>
    /// LegStipulationType Field
    /// </summary>/
    public sealed class LegStipulationType : StringField
    {
        public LegStipulationType()
            :base(Tags.LegStipulationType) {}
        public LegStipulationType(string val)
            :base(Tags.LegStipulationType, val) {}

    }


    /// <summary>
    /// LegStipulationValue Field
    /// </summary>/
    public sealed class LegStipulationValue : StringField
    {
        public LegStipulationValue()
            :base(Tags.LegStipulationValue) {}
        public LegStipulationValue(string val)
            :base(Tags.LegStipulationValue, val) {}

    }


    /// <summary>
    /// LegSwapType Field
    /// </summary>/
    public sealed class LegSwapType : IntField
    {
        public LegSwapType()
            :base(Tags.LegSwapType) {}
        public LegSwapType(int val)
            :base(Tags.LegSwapType, val) {}


        // Field Enumerations
        public const int PAR_FOR_PAR = 1;
        public const int MODIFIED_DURATION = 2;
        public const int RISK = 4;
        public const int PROCEEDS = 5;
    }


    /// <summary>
    /// Pool Field
    /// </summary>/
    public sealed class Pool : StringField
    {
        public Pool()
            :base(Tags.Pool) {}
        public Pool(string val)
            :base(Tags.Pool, val) {}

    }


    /// <summary>
    /// QuotePriceType Field
    /// </summary>/
    public sealed class QuotePriceType : IntField
    {
        public QuotePriceType()
            :base(Tags.QuotePriceType) {}
        public QuotePriceType(int val)
            :base(Tags.QuotePriceType, val) {}


        // Field Enumerations
        public const int PERCENT = 1;
        public const int YIELD = 10;
        public const int PER_SHARE = 2;
        public const int FIXED_AMOUNT = 3;
        public const int DISCOUNT = 4;
        public const int PREMIUM = 5;
        public const int SPREAD = 6;
        public const int TED_PRICE = 7;
        public const int TED_YIELD = 8;
        public const int YIELD_SPREAD = 9;
    }


    /// <summary>
    /// QuoteRespID Field
    /// </summary>/
    public sealed class QuoteRespID : StringField
    {
        public QuoteRespID()
            :base(Tags.QuoteRespID) {}
        public QuoteRespID(string val)
            :base(Tags.QuoteRespID, val) {}

    }


    /// <summary>
    /// QuoteRespType Field
    /// </summary>/
    public sealed class QuoteRespType : IntField
    {
        public QuoteRespType()
            :base(Tags.QuoteRespType) {}
        public QuoteRespType(int val)
            :base(Tags.QuoteRespType, val) {}


        // Field Enumerations
        public const int HIT_LIFT = 1;
        public const int COUNTER = 2;
        public const int EXPIRED = 3;
        public const int COVER = 4;
        public const int DONE_AWAY = 5;
        public const int PASS = 6;
    }


    /// <summary>
    /// QuoteQualifier Field
    /// </summary>/
    public sealed class QuoteQualifier : CharField
    {
        public QuoteQualifier()
            :base(Tags.QuoteQualifier) {}
        public QuoteQualifier(char val)
            :base(Tags.QuoteQualifier, val) {}

    }


    /// <summary>
    /// YieldRedemptionDate Field
    /// </summary>/
    public sealed class YieldRedemptionDate : StringField
    {
        public YieldRedemptionDate()
            :base(Tags.YieldRedemptionDate) {}
        public YieldRedemptionDate(string val)
            :base(Tags.YieldRedemptionDate, val) {}

    }


    /// <summary>
    /// YieldRedemptionPrice Field
    /// </summary>/
    public sealed class YieldRedemptionPrice : DecimalField
    {
        public YieldRedemptionPrice()
            :base(Tags.YieldRedemptionPrice) {}
        public YieldRedemptionPrice(Decimal val)
            :base(Tags.YieldRedemptionPrice, val) {}

    }


    /// <summary>
    /// YieldRedemptionPriceType Field
    /// </summary>/
    public sealed class YieldRedemptionPriceType : IntField
    {
        public YieldRedemptionPriceType()
            :base(Tags.YieldRedemptionPriceType) {}
        public YieldRedemptionPriceType(int val)
            :base(Tags.YieldRedemptionPriceType, val) {}

    }


    /// <summary>
    /// BenchmarkSecurityID Field
    /// </summary>/
    public sealed class BenchmarkSecurityID : StringField
    {
        public BenchmarkSecurityID()
            :base(Tags.BenchmarkSecurityID) {}
        public BenchmarkSecurityID(string val)
            :base(Tags.BenchmarkSecurityID, val) {}

    }


    /// <summary>
    /// ReversalIndicator Field
    /// </summary>/
    public sealed class ReversalIndicator : BooleanField
    {
        public ReversalIndicator()
            :base(Tags.ReversalIndicator) {}
        public ReversalIndicator(Boolean val)
            :base(Tags.ReversalIndicator, val) {}

    }


    /// <summary>
    /// YieldCalcDate Field
    /// </summary>/
    public sealed class YieldCalcDate : StringField
    {
        public YieldCalcDate()
            :base(Tags.YieldCalcDate) {}
        public YieldCalcDate(string val)
            :base(Tags.YieldCalcDate, val) {}

    }


    /// <summary>
    /// NoPositions Field
    /// </summary>/
    public sealed class NoPositions : IntField
    {
        public NoPositions()
            :base(Tags.NoPositions) {}
        public NoPositions(int val)
            :base(Tags.NoPositions, val) {}

    }


    /// <summary>
    /// PosType Field
    /// </summary>/
    public sealed class PosType : StringField
    {
        public PosType()
            :base(Tags.PosType) {}
        public PosType(string val)
            :base(Tags.PosType, val) {}


        // Field Enumerations
        public const string ALLOCATION_TRADE_QTY = "ALC";
        public const string OPTION_ASSIGNMENT = "AS";
        public const string AS_OF_TRADE_QTY = "ASF";
        public const string DELIVERY_QTY = "DLV";
        public const string ELECTRONIC_TRADE_QTY = "ETR";
        public const string OPTION_EXERCISE_QTY = "EX";
        public const string END_OF_DAY_QTY = "FIN";
        public const string INTRA_SPREAD_QTY = "IAS";
        public const string INTER_SPREAD_QTY = "IES";
        public const string ADJUSTMENT_QTY = "PA";
        public const string PIT_TRADE_QTY = "PIT";
        public const string START_OF_DAY_QTY = "SOD";
        public const string INTEGRAL_SPLIT = "SPL";
        public const string TRANSACTION_FROM_ASSIGNMENT = "TA";
        public const string TOTAL_TRANSACTION_QTY = "TOT";
        public const string TRANSACTION_QUANTITY = "TQ";
        public const string TRANSFER_TRADE_QTY = "TRF";
        public const string TRANSACTION_FROM_EXERCISE = "TX";
        public const string CROSS_MARGIN_QTY = "XM";
        public const string RECEIVE_QUANTITY = "RCV";
        public const string CORPORATE_ACTION_ADJUSTMENT = "CAA";
        public const string DELIVERY_NOTICE_QTY = "DN";
        public const string EXCHANGE_FOR_PHYSICAL_QTY = "EP";
    }


    /// <summary>
    /// LongQty Field
    /// </summary>/
    public sealed class LongQty : DecimalField
    {
        public LongQty()
            :base(Tags.LongQty) {}
        public LongQty(Decimal val)
            :base(Tags.LongQty, val) {}

    }


    /// <summary>
    /// ShortQty Field
    /// </summary>/
    public sealed class ShortQty : DecimalField
    {
        public ShortQty()
            :base(Tags.ShortQty) {}
        public ShortQty(Decimal val)
            :base(Tags.ShortQty, val) {}

    }


    /// <summary>
    /// PosQtyStatus Field
    /// </summary>/
    public sealed class PosQtyStatus : IntField
    {
        public PosQtyStatus()
            :base(Tags.PosQtyStatus) {}
        public PosQtyStatus(int val)
            :base(Tags.PosQtyStatus, val) {}


        // Field Enumerations
        public const int SUBMITTED = 0;
        public const int ACCEPTED = 1;
        public const int REJECTED = 2;
    }


    /// <summary>
    /// PosAmtType Field
    /// </summary>/
    public sealed class PosAmtType : StringField
    {
        public PosAmtType()
            :base(Tags.PosAmtType) {}
        public PosAmtType(string val)
            :base(Tags.PosAmtType, val) {}


        // Field Enumerations
        public const string CASH_AMOUNT = "CASH";
        public const string CASH_RESIDUAL_AMOUNT = "CRES";
        public const string FINAL_MARK_TO_MARKET_AMOUNT = "FMTM";
        public const string INCREMENTAL_MARK_TO_MARKET_AMOUNT = "IMTM";
        public const string PREMIUM_AMOUNT = "PREM";
        public const string START_OF_DAY_MARK_TO_MARKET_AMOUNT = "SMTM";
        public const string TRADE_VARIATION_AMOUNT = "TVAR";
        public const string VALUE_ADJUSTED_AMOUNT = "VADJ";
        public const string SETTLEMENT_VALUE = "SETL";
    }


    /// <summary>
    /// PosAmt Field
    /// </summary>/
    public sealed class PosAmt : DecimalField
    {
        public PosAmt()
            :base(Tags.PosAmt) {}
        public PosAmt(Decimal val)
            :base(Tags.PosAmt, val) {}

    }


    /// <summary>
    /// PosTransType Field
    /// </summary>/
    public sealed class PosTransType : IntField
    {
        public PosTransType()
            :base(Tags.PosTransType) {}
        public PosTransType(int val)
            :base(Tags.PosTransType, val) {}


        // Field Enumerations
        public const int EXERCISE = 1;
        public const int DO_NOT_EXERCISE = 2;
        public const int POSITION_ADJUSTMENT = 3;
        public const int POSITION_CHANGE_SUBMISSION_MARGIN_DISPOSITION = 4;
        public const int PLEDGE = 5;
        public const int LARGE_TRADER_SUBMISSION = 6;
    }


    /// <summary>
    /// PosReqID Field
    /// </summary>/
    public sealed class PosReqID : StringField
    {
        public PosReqID()
            :base(Tags.PosReqID) {}
        public PosReqID(string val)
            :base(Tags.PosReqID, val) {}

    }


    /// <summary>
    /// NoUnderlyings Field
    /// </summary>/
    public sealed class NoUnderlyings : IntField
    {
        public NoUnderlyings()
            :base(Tags.NoUnderlyings) {}
        public NoUnderlyings(int val)
            :base(Tags.NoUnderlyings, val) {}

    }


    /// <summary>
    /// PosMaintAction Field
    /// </summary>/
    public sealed class PosMaintAction : IntField
    {
        public PosMaintAction()
            :base(Tags.PosMaintAction) {}
        public PosMaintAction(int val)
            :base(Tags.PosMaintAction, val) {}


        // Field Enumerations
        public const int NEW = 1;
        public const int REPLACE = 2;
        public const int CANCEL = 3;
        public const int REVERSE = 4;
    }


    /// <summary>
    /// OrigPosReqRefID Field
    /// </summary>/
    public sealed class OrigPosReqRefID : StringField
    {
        public OrigPosReqRefID()
            :base(Tags.OrigPosReqRefID) {}
        public OrigPosReqRefID(string val)
            :base(Tags.OrigPosReqRefID, val) {}

    }


    /// <summary>
    /// PosMaintRptRefID Field
    /// </summary>/
    public sealed class PosMaintRptRefID : StringField
    {
        public PosMaintRptRefID()
            :base(Tags.PosMaintRptRefID) {}
        public PosMaintRptRefID(string val)
            :base(Tags.PosMaintRptRefID, val) {}

    }


    /// <summary>
    /// ClearingBusinessDate Field
    /// </summary>/
    public sealed class ClearingBusinessDate : StringField
    {
        public ClearingBusinessDate()
            :base(Tags.ClearingBusinessDate) {}
        public ClearingBusinessDate(string val)
            :base(Tags.ClearingBusinessDate, val) {}

    }


    /// <summary>
    /// SettlSessID Field
    /// </summary>/
    public sealed class SettlSessID : StringField
    {
        public SettlSessID()
            :base(Tags.SettlSessID) {}
        public SettlSessID(string val)
            :base(Tags.SettlSessID, val) {}


        // Field Enumerations
        public const string INTRADAY = "ITD";
        public const string REGULAR_TRADING_HOURS = "RTH";
        public const string ELECTRONIC_TRADING_HOURS = "ETH";
        public const string END_OF_DAY = "EOD";
    }


    /// <summary>
    /// SettlSessSubID Field
    /// </summary>/
    public sealed class SettlSessSubID : StringField
    {
        public SettlSessSubID()
            :base(Tags.SettlSessSubID) {}
        public SettlSessSubID(string val)
            :base(Tags.SettlSessSubID, val) {}

    }


    /// <summary>
    /// AdjustmentType Field
    /// </summary>/
    public sealed class AdjustmentType : IntField
    {
        public AdjustmentType()
            :base(Tags.AdjustmentType) {}
        public AdjustmentType(int val)
            :base(Tags.AdjustmentType, val) {}


        // Field Enumerations
        public const int PROCESS_REQUEST_AS_MARGIN_DISPOSITION = 0;
        public const int DELTA_PLUS = 1;
        public const int DELTA_MINUS = 2;
        public const int FINAL = 3;
    }


    /// <summary>
    /// ContraryInstructionIndicator Field
    /// </summary>/
    public sealed class ContraryInstructionIndicator : BooleanField
    {
        public ContraryInstructionIndicator()
            :base(Tags.ContraryInstructionIndicator) {}
        public ContraryInstructionIndicator(Boolean val)
            :base(Tags.ContraryInstructionIndicator, val) {}

    }


    /// <summary>
    /// PriorSpreadIndicator Field
    /// </summary>/
    public sealed class PriorSpreadIndicator : BooleanField
    {
        public PriorSpreadIndicator()
            :base(Tags.PriorSpreadIndicator) {}
        public PriorSpreadIndicator(Boolean val)
            :base(Tags.PriorSpreadIndicator, val) {}

    }


    /// <summary>
    /// PosMaintRptID Field
    /// </summary>/
    public sealed class PosMaintRptID : StringField
    {
        public PosMaintRptID()
            :base(Tags.PosMaintRptID) {}
        public PosMaintRptID(string val)
            :base(Tags.PosMaintRptID, val) {}

    }


    /// <summary>
    /// PosMaintStatus Field
    /// </summary>/
    public sealed class PosMaintStatus : IntField
    {
        public PosMaintStatus()
            :base(Tags.PosMaintStatus) {}
        public PosMaintStatus(int val)
            :base(Tags.PosMaintStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int ACCEPTED_WITH_WARNINGS = 1;
        public const int REJECTED = 2;
        public const int COMPLETED = 3;
        public const int COMPLETED_WITH_WARNINGS = 4;
    }


    /// <summary>
    /// PosMaintResult Field
    /// </summary>/
    public sealed class PosMaintResult : IntField
    {
        public PosMaintResult()
            :base(Tags.PosMaintResult) {}
        public PosMaintResult(int val)
            :base(Tags.PosMaintResult, val) {}


        // Field Enumerations
        public const int SUCCESSFUL_COMPLETION = 0;
        public const int REJECTED = 1;
        public const int OTHER = 99;
    }


    /// <summary>
    /// PosReqType Field
    /// </summary>/
    public sealed class PosReqType : IntField
    {
        public PosReqType()
            :base(Tags.PosReqType) {}
        public PosReqType(int val)
            :base(Tags.PosReqType, val) {}


        // Field Enumerations
        public const int POSITIONS = 0;
        public const int TRADES = 1;
        public const int EXERCISES = 2;
        public const int ASSIGNMENTS = 3;
        public const int SETTLEMENT_ACTIVITY = 4;
        public const int BACKOUT_MESSAGE = 5;
    }


    /// <summary>
    /// ResponseTransportType Field
    /// </summary>/
    public sealed class ResponseTransportType : IntField
    {
        public ResponseTransportType()
            :base(Tags.ResponseTransportType) {}
        public ResponseTransportType(int val)
            :base(Tags.ResponseTransportType, val) {}


        // Field Enumerations
        public const int INBAND = 0;
        public const int OUT_OF_BAND = 1;
    }


    /// <summary>
    /// ResponseDestination Field
    /// </summary>/
    public sealed class ResponseDestination : StringField
    {
        public ResponseDestination()
            :base(Tags.ResponseDestination) {}
        public ResponseDestination(string val)
            :base(Tags.ResponseDestination, val) {}

    }


    /// <summary>
    /// TotalNumPosReports Field
    /// </summary>/
    public sealed class TotalNumPosReports : IntField
    {
        public TotalNumPosReports()
            :base(Tags.TotalNumPosReports) {}
        public TotalNumPosReports(int val)
            :base(Tags.TotalNumPosReports, val) {}

    }


    /// <summary>
    /// PosReqResult Field
    /// </summary>/
    public sealed class PosReqResult : IntField
    {
        public PosReqResult()
            :base(Tags.PosReqResult) {}
        public PosReqResult(int val)
            :base(Tags.PosReqResult, val) {}


        // Field Enumerations
        public const int VALID_REQUEST = 0;
        public const int INVALID_OR_UNSUPPORTED_REQUEST = 1;
        public const int NO_POSITIONS_FOUND_THAT_MATCH_CRITERIA = 2;
        public const int NOT_AUTHORIZED_TO_REQUEST_POSITIONS = 3;
        public const int REQUEST_FOR_POSITION_NOT_SUPPORTED = 4;
        public const int OTHER = 99;
    }


    /// <summary>
    /// PosReqStatus Field
    /// </summary>/
    public sealed class PosReqStatus : IntField
    {
        public PosReqStatus()
            :base(Tags.PosReqStatus) {}
        public PosReqStatus(int val)
            :base(Tags.PosReqStatus, val) {}


        // Field Enumerations
        public const int COMPLETED = 0;
        public const int COMPLETED_WITH_WARNINGS = 1;
        public const int REJECTED = 2;
    }


    /// <summary>
    /// SettlPrice Field
    /// </summary>/
    public sealed class SettlPrice : DecimalField
    {
        public SettlPrice()
            :base(Tags.SettlPrice) {}
        public SettlPrice(Decimal val)
            :base(Tags.SettlPrice, val) {}

    }


    /// <summary>
    /// SettlPriceType Field
    /// </summary>/
    public sealed class SettlPriceType : IntField
    {
        public SettlPriceType()
            :base(Tags.SettlPriceType) {}
        public SettlPriceType(int val)
            :base(Tags.SettlPriceType, val) {}


        // Field Enumerations
        public const int FINAL = 1;
        public const int THEORETICAL = 2;
    }


    /// <summary>
    /// UnderlyingSettlPrice Field
    /// </summary>/
    public sealed class UnderlyingSettlPrice : DecimalField
    {
        public UnderlyingSettlPrice()
            :base(Tags.UnderlyingSettlPrice) {}
        public UnderlyingSettlPrice(Decimal val)
            :base(Tags.UnderlyingSettlPrice, val) {}

    }


    /// <summary>
    /// UnderlyingSettlPriceType Field
    /// </summary>/
    public sealed class UnderlyingSettlPriceType : IntField
    {
        public UnderlyingSettlPriceType()
            :base(Tags.UnderlyingSettlPriceType) {}
        public UnderlyingSettlPriceType(int val)
            :base(Tags.UnderlyingSettlPriceType, val) {}

    }


    /// <summary>
    /// PriorSettlPrice Field
    /// </summary>/
    public sealed class PriorSettlPrice : DecimalField
    {
        public PriorSettlPrice()
            :base(Tags.PriorSettlPrice) {}
        public PriorSettlPrice(Decimal val)
            :base(Tags.PriorSettlPrice, val) {}

    }


    /// <summary>
    /// NoQuoteQualifiers Field
    /// </summary>/
    public sealed class NoQuoteQualifiers : IntField
    {
        public NoQuoteQualifiers()
            :base(Tags.NoQuoteQualifiers) {}
        public NoQuoteQualifiers(int val)
            :base(Tags.NoQuoteQualifiers, val) {}

    }


    /// <summary>
    /// AllocSettlCurrency Field
    /// </summary>/
    public sealed class AllocSettlCurrency : DecimalField
    {
        public AllocSettlCurrency()
            :base(Tags.AllocSettlCurrency) {}
        public AllocSettlCurrency(Decimal val)
            :base(Tags.AllocSettlCurrency, val) {}

    }


    /// <summary>
    /// AllocSettlCurrAmt Field
    /// </summary>/
    public sealed class AllocSettlCurrAmt : DecimalField
    {
        public AllocSettlCurrAmt()
            :base(Tags.AllocSettlCurrAmt) {}
        public AllocSettlCurrAmt(Decimal val)
            :base(Tags.AllocSettlCurrAmt, val) {}

    }


    /// <summary>
    /// InterestAtMaturity Field
    /// </summary>/
    public sealed class InterestAtMaturity : DecimalField
    {
        public InterestAtMaturity()
            :base(Tags.InterestAtMaturity) {}
        public InterestAtMaturity(Decimal val)
            :base(Tags.InterestAtMaturity, val) {}

    }


    /// <summary>
    /// LegDatedDate Field
    /// </summary>/
    public sealed class LegDatedDate : StringField
    {
        public LegDatedDate()
            :base(Tags.LegDatedDate) {}
        public LegDatedDate(string val)
            :base(Tags.LegDatedDate, val) {}

    }


    /// <summary>
    /// LegPool Field
    /// </summary>/
    public sealed class LegPool : StringField
    {
        public LegPool()
            :base(Tags.LegPool) {}
        public LegPool(string val)
            :base(Tags.LegPool, val) {}

    }


    /// <summary>
    /// AllocInterestAtMaturity Field
    /// </summary>/
    public sealed class AllocInterestAtMaturity : DecimalField
    {
        public AllocInterestAtMaturity()
            :base(Tags.AllocInterestAtMaturity) {}
        public AllocInterestAtMaturity(Decimal val)
            :base(Tags.AllocInterestAtMaturity, val) {}

    }


    /// <summary>
    /// AllocAccruedInterestAmt Field
    /// </summary>/
    public sealed class AllocAccruedInterestAmt : DecimalField
    {
        public AllocAccruedInterestAmt()
            :base(Tags.AllocAccruedInterestAmt) {}
        public AllocAccruedInterestAmt(Decimal val)
            :base(Tags.AllocAccruedInterestAmt, val) {}

    }


    /// <summary>
    /// DeliveryDate Field
    /// </summary>/
    public sealed class DeliveryDate : StringField
    {
        public DeliveryDate()
            :base(Tags.DeliveryDate) {}
        public DeliveryDate(string val)
            :base(Tags.DeliveryDate, val) {}

    }


    /// <summary>
    /// AssignmentMethod Field
    /// </summary>/
    public sealed class AssignmentMethod : CharField
    {
        public AssignmentMethod()
            :base(Tags.AssignmentMethod) {}
        public AssignmentMethod(char val)
            :base(Tags.AssignmentMethod, val) {}


        // Field Enumerations
        public const char PRO_RATA = 'P';
        public const char RANDOM = 'R';
    }


    /// <summary>
    /// AssignmentUnit Field
    /// </summary>/
    public sealed class AssignmentUnit : DecimalField
    {
        public AssignmentUnit()
            :base(Tags.AssignmentUnit) {}
        public AssignmentUnit(Decimal val)
            :base(Tags.AssignmentUnit, val) {}

    }


    /// <summary>
    /// OpenInterest Field
    /// </summary>/
    public sealed class OpenInterest : DecimalField
    {
        public OpenInterest()
            :base(Tags.OpenInterest) {}
        public OpenInterest(Decimal val)
            :base(Tags.OpenInterest, val) {}

    }


    /// <summary>
    /// ExerciseMethod Field
    /// </summary>/
    public sealed class ExerciseMethod : CharField
    {
        public ExerciseMethod()
            :base(Tags.ExerciseMethod) {}
        public ExerciseMethod(char val)
            :base(Tags.ExerciseMethod, val) {}


        // Field Enumerations
        public const char AUTOMATIC = 'A';
        public const char MANUAL = 'M';
    }


    /// <summary>
    /// TotNumTradeReports Field
    /// </summary>/
    public sealed class TotNumTradeReports : IntField
    {
        public TotNumTradeReports()
            :base(Tags.TotNumTradeReports) {}
        public TotNumTradeReports(int val)
            :base(Tags.TotNumTradeReports, val) {}

    }


    /// <summary>
    /// TradeRequestResult Field
    /// </summary>/
    public sealed class TradeRequestResult : IntField
    {
        public TradeRequestResult()
            :base(Tags.TradeRequestResult) {}
        public TradeRequestResult(int val)
            :base(Tags.TradeRequestResult, val) {}


        // Field Enumerations
        public const int SUCCESSFUL = 0;
        public const int INVALID_OR_UNKNOWN_INSTRUMENT = 1;
        public const int INVALID_TYPE_OF_TRADE_REQUESTED = 2;
        public const int INVALID_PARTIES = 3;
        public const int INVALID_TRANSPORT_TYPE_REQUESTED = 4;
        public const int INVALID_DESTINATION_REQUESTED = 5;
        public const int TRADEREQUESTTYPE_NOT_SUPPORTED = 8;
        public const int UNAUTHORIZED_ROR_TRADE_CAPTURE_REPORT_REQUEST = 9;
        public const int OTHER = 99;
    }


    /// <summary>
    /// TradeRequestStatus Field
    /// </summary>/
    public sealed class TradeRequestStatus : IntField
    {
        public TradeRequestStatus()
            :base(Tags.TradeRequestStatus) {}
        public TradeRequestStatus(int val)
            :base(Tags.TradeRequestStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int COMPLETED = 1;
        public const int REJECTED = 2;
    }


    /// <summary>
    /// TradeReportRejectReason Field
    /// </summary>/
    public sealed class TradeReportRejectReason : IntField
    {
        public TradeReportRejectReason()
            :base(Tags.TradeReportRejectReason) {}
        public TradeReportRejectReason(int val)
            :base(Tags.TradeReportRejectReason, val) {}


        // Field Enumerations
        public const int SUCCESSFUL = 0;
        public const int INVALID_PARTY_ONFORMATION = 1;
        public const int UNKNOWN_INSTRUMENT = 2;
        public const int UNAUTHORIZED_TO_REPORT_TRADES = 3;
        public const int INVALID_TRADE_TYPE = 4;
        public const int OTHER = 99;
    }


    /// <summary>
    /// SideMultiLegReportingType Field
    /// </summary>/
    public sealed class SideMultiLegReportingType : IntField
    {
        public SideMultiLegReportingType()
            :base(Tags.SideMultiLegReportingType) {}
        public SideMultiLegReportingType(int val)
            :base(Tags.SideMultiLegReportingType, val) {}


        // Field Enumerations
        public const int SINGLE_SECURITY = 1;
        public const int INDIVIDUAL_LEG_OF_A_MULTILEG_SECURITY = 2;
        public const int MULTILEG_SECURITY = 3;
    }


    /// <summary>
    /// NoPosAmt Field
    /// </summary>/
    public sealed class NoPosAmt : IntField
    {
        public NoPosAmt()
            :base(Tags.NoPosAmt) {}
        public NoPosAmt(int val)
            :base(Tags.NoPosAmt, val) {}

    }


    /// <summary>
    /// AutoAcceptIndicator Field
    /// </summary>/
    public sealed class AutoAcceptIndicator : BooleanField
    {
        public AutoAcceptIndicator()
            :base(Tags.AutoAcceptIndicator) {}
        public AutoAcceptIndicator(Boolean val)
            :base(Tags.AutoAcceptIndicator, val) {}

    }


    /// <summary>
    /// AllocReportID Field
    /// </summary>/
    public sealed class AllocReportID : StringField
    {
        public AllocReportID()
            :base(Tags.AllocReportID) {}
        public AllocReportID(string val)
            :base(Tags.AllocReportID, val) {}

    }


    /// <summary>
    /// NoNested2PartyIDs Field
    /// </summary>/
    public sealed class NoNested2PartyIDs : IntField
    {
        public NoNested2PartyIDs()
            :base(Tags.NoNested2PartyIDs) {}
        public NoNested2PartyIDs(int val)
            :base(Tags.NoNested2PartyIDs, val) {}

    }


    /// <summary>
    /// Nested2PartyID Field
    /// </summary>/
    public sealed class Nested2PartyID : StringField
    {
        public Nested2PartyID()
            :base(Tags.Nested2PartyID) {}
        public Nested2PartyID(string val)
            :base(Tags.Nested2PartyID, val) {}

    }


    /// <summary>
    /// Nested2PartyIDSource Field
    /// </summary>/
    public sealed class Nested2PartyIDSource : CharField
    {
        public Nested2PartyIDSource()
            :base(Tags.Nested2PartyIDSource) {}
        public Nested2PartyIDSource(char val)
            :base(Tags.Nested2PartyIDSource, val) {}

    }


    /// <summary>
    /// Nested2PartyRole Field
    /// </summary>/
    public sealed class Nested2PartyRole : IntField
    {
        public Nested2PartyRole()
            :base(Tags.Nested2PartyRole) {}
        public Nested2PartyRole(int val)
            :base(Tags.Nested2PartyRole, val) {}

    }


    /// <summary>
    /// Nested2PartySubID Field
    /// </summary>/
    public sealed class Nested2PartySubID : StringField
    {
        public Nested2PartySubID()
            :base(Tags.Nested2PartySubID) {}
        public Nested2PartySubID(string val)
            :base(Tags.Nested2PartySubID, val) {}

    }


    /// <summary>
    /// BenchmarkSecurityIDSource Field
    /// </summary>/
    public sealed class BenchmarkSecurityIDSource : StringField
    {
        public BenchmarkSecurityIDSource()
            :base(Tags.BenchmarkSecurityIDSource) {}
        public BenchmarkSecurityIDSource(string val)
            :base(Tags.BenchmarkSecurityIDSource, val) {}

    }


    /// <summary>
    /// SecuritySubType Field
    /// </summary>/
    public sealed class SecuritySubType : StringField
    {
        public SecuritySubType()
            :base(Tags.SecuritySubType) {}
        public SecuritySubType(string val)
            :base(Tags.SecuritySubType, val) {}

    }


    /// <summary>
    /// UnderlyingSecuritySubType Field
    /// </summary>/
    public sealed class UnderlyingSecuritySubType : StringField
    {
        public UnderlyingSecuritySubType()
            :base(Tags.UnderlyingSecuritySubType) {}
        public UnderlyingSecuritySubType(string val)
            :base(Tags.UnderlyingSecuritySubType, val) {}

    }


    /// <summary>
    /// LegSecuritySubType Field
    /// </summary>/
    public sealed class LegSecuritySubType : StringField
    {
        public LegSecuritySubType()
            :base(Tags.LegSecuritySubType) {}
        public LegSecuritySubType(string val)
            :base(Tags.LegSecuritySubType, val) {}

    }


    /// <summary>
    /// AllowableOneSidednessPct Field
    /// </summary>/
    public sealed class AllowableOneSidednessPct : DecimalField
    {
        public AllowableOneSidednessPct()
            :base(Tags.AllowableOneSidednessPct) {}
        public AllowableOneSidednessPct(Decimal val)
            :base(Tags.AllowableOneSidednessPct, val) {}

    }


    /// <summary>
    /// AllowableOneSidednessValue Field
    /// </summary>/
    public sealed class AllowableOneSidednessValue : DecimalField
    {
        public AllowableOneSidednessValue()
            :base(Tags.AllowableOneSidednessValue) {}
        public AllowableOneSidednessValue(Decimal val)
            :base(Tags.AllowableOneSidednessValue, val) {}

    }


    /// <summary>
    /// AllowableOneSidednessCurr Field
    /// </summary>/
    public sealed class AllowableOneSidednessCurr : DecimalField
    {
        public AllowableOneSidednessCurr()
            :base(Tags.AllowableOneSidednessCurr) {}
        public AllowableOneSidednessCurr(Decimal val)
            :base(Tags.AllowableOneSidednessCurr, val) {}

    }


    /// <summary>
    /// NoTrdRegTimestamps Field
    /// </summary>/
    public sealed class NoTrdRegTimestamps : IntField
    {
        public NoTrdRegTimestamps()
            :base(Tags.NoTrdRegTimestamps) {}
        public NoTrdRegTimestamps(int val)
            :base(Tags.NoTrdRegTimestamps, val) {}

    }


    /// <summary>
    /// TrdRegTimestamp Field
    /// </summary>/
    public sealed class TrdRegTimestamp : DateTimeField
    {
        public TrdRegTimestamp()
            :base(Tags.TrdRegTimestamp) {}
        public TrdRegTimestamp(DateTime val)
            :base(Tags.TrdRegTimestamp, val) {}

    }


    /// <summary>
    /// TrdRegTimestampType Field
    /// </summary>/
    public sealed class TrdRegTimestampType : IntField
    {
        public TrdRegTimestampType()
            :base(Tags.TrdRegTimestampType) {}
        public TrdRegTimestampType(int val)
            :base(Tags.TrdRegTimestampType, val) {}


        // Field Enumerations
        public const int EXECUTION_TIME = 1;
        public const int TIME_IN = 2;
        public const int TIME_OUT = 3;
        public const int BROKER_RECEIPT = 4;
        public const int BROKER_EXECUTION = 5;
        public const int DESK_RECEIPT = 6;
    }


    /// <summary>
    /// TrdRegTimestampOrigin Field
    /// </summary>/
    public sealed class TrdRegTimestampOrigin : StringField
    {
        public TrdRegTimestampOrigin()
            :base(Tags.TrdRegTimestampOrigin) {}
        public TrdRegTimestampOrigin(string val)
            :base(Tags.TrdRegTimestampOrigin, val) {}

    }


    /// <summary>
    /// ConfirmRefID Field
    /// </summary>/
    public sealed class ConfirmRefID : StringField
    {
        public ConfirmRefID()
            :base(Tags.ConfirmRefID) {}
        public ConfirmRefID(string val)
            :base(Tags.ConfirmRefID, val) {}

    }


    /// <summary>
    /// ConfirmType Field
    /// </summary>/
    public sealed class ConfirmType : IntField
    {
        public ConfirmType()
            :base(Tags.ConfirmType) {}
        public ConfirmType(int val)
            :base(Tags.ConfirmType, val) {}


        // Field Enumerations
        public const int STATUS = 1;
        public const int CONFIRMATION = 2;
        public const int CONFIRMATION_REQUEST_REJECTED = 3;
    }


    /// <summary>
    /// ConfirmRejReason Field
    /// </summary>/
    public sealed class ConfirmRejReason : IntField
    {
        public ConfirmRejReason()
            :base(Tags.ConfirmRejReason) {}
        public ConfirmRejReason(int val)
            :base(Tags.ConfirmRejReason, val) {}


        // Field Enumerations
        public const int MISMATCHED_ACCOUNT = 1;
        public const int MISSING_SETTLEMENT_INSTRUCTIONS = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// BookingType Field
    /// </summary>/
    public sealed class BookingType : IntField
    {
        public BookingType()
            :base(Tags.BookingType) {}
        public BookingType(int val)
            :base(Tags.BookingType, val) {}


        // Field Enumerations
        public const int REGULAR_BOOKING = 0;
        public const int CFD = 1;
        public const int TOTAL_RETURN_SWAP = 2;
    }


    /// <summary>
    /// IndividualAllocRejCode Field
    /// </summary>/
    public sealed class IndividualAllocRejCode : IntField
    {
        public IndividualAllocRejCode()
            :base(Tags.IndividualAllocRejCode) {}
        public IndividualAllocRejCode(int val)
            :base(Tags.IndividualAllocRejCode, val) {}

    }


    /// <summary>
    /// SettlInstMsgID Field
    /// </summary>/
    public sealed class SettlInstMsgID : StringField
    {
        public SettlInstMsgID()
            :base(Tags.SettlInstMsgID) {}
        public SettlInstMsgID(string val)
            :base(Tags.SettlInstMsgID, val) {}

    }


    /// <summary>
    /// NoSettlInst Field
    /// </summary>/
    public sealed class NoSettlInst : IntField
    {
        public NoSettlInst()
            :base(Tags.NoSettlInst) {}
        public NoSettlInst(int val)
            :base(Tags.NoSettlInst, val) {}

    }


    /// <summary>
    /// LastUpdateTime Field
    /// </summary>/
    public sealed class LastUpdateTime : DateTimeField
    {
        public LastUpdateTime()
            :base(Tags.LastUpdateTime) {}
        public LastUpdateTime(DateTime val)
            :base(Tags.LastUpdateTime, val) {}

    }


    /// <summary>
    /// AllocSettlInstType Field
    /// </summary>/
    public sealed class AllocSettlInstType : IntField
    {
        public AllocSettlInstType()
            :base(Tags.AllocSettlInstType) {}
        public AllocSettlInstType(int val)
            :base(Tags.AllocSettlInstType, val) {}


        // Field Enumerations
        public const int USE_DEFAULT_INSTRUCTIONS = 0;
        public const int DERIVE_FROM_PARAMETERS_PROVIDED = 1;
        public const int FULL_DETAILS_PROVIDED = 2;
        public const int SSI_DB_IDS_PROVIDED = 3;
        public const int PHONE_FOR_INSTRUCTIONS = 4;
    }


    /// <summary>
    /// NoSettlPartyIDs Field
    /// </summary>/
    public sealed class NoSettlPartyIDs : IntField
    {
        public NoSettlPartyIDs()
            :base(Tags.NoSettlPartyIDs) {}
        public NoSettlPartyIDs(int val)
            :base(Tags.NoSettlPartyIDs, val) {}

    }


    /// <summary>
    /// SettlPartyID Field
    /// </summary>/
    public sealed class SettlPartyID : StringField
    {
        public SettlPartyID()
            :base(Tags.SettlPartyID) {}
        public SettlPartyID(string val)
            :base(Tags.SettlPartyID, val) {}

    }


    /// <summary>
    /// SettlPartyIDSource Field
    /// </summary>/
    public sealed class SettlPartyIDSource : CharField
    {
        public SettlPartyIDSource()
            :base(Tags.SettlPartyIDSource) {}
        public SettlPartyIDSource(char val)
            :base(Tags.SettlPartyIDSource, val) {}

    }


    /// <summary>
    /// SettlPartyRole Field
    /// </summary>/
    public sealed class SettlPartyRole : IntField
    {
        public SettlPartyRole()
            :base(Tags.SettlPartyRole) {}
        public SettlPartyRole(int val)
            :base(Tags.SettlPartyRole, val) {}

    }


    /// <summary>
    /// SettlPartySubID Field
    /// </summary>/
    public sealed class SettlPartySubID : StringField
    {
        public SettlPartySubID()
            :base(Tags.SettlPartySubID) {}
        public SettlPartySubID(string val)
            :base(Tags.SettlPartySubID, val) {}

    }


    /// <summary>
    /// SettlPartySubIDType Field
    /// </summary>/
    public sealed class SettlPartySubIDType : IntField
    {
        public SettlPartySubIDType()
            :base(Tags.SettlPartySubIDType) {}
        public SettlPartySubIDType(int val)
            :base(Tags.SettlPartySubIDType, val) {}

    }


    /// <summary>
    /// DlvyInstType Field
    /// </summary>/
    public sealed class DlvyInstType : CharField
    {
        public DlvyInstType()
            :base(Tags.DlvyInstType) {}
        public DlvyInstType(char val)
            :base(Tags.DlvyInstType, val) {}


        // Field Enumerations
        public const char CASH = 'C';
        public const char SECURITIES = 'S';
    }


    /// <summary>
    /// TerminationType Field
    /// </summary>/
    public sealed class TerminationType : IntField
    {
        public TerminationType()
            :base(Tags.TerminationType) {}
        public TerminationType(int val)
            :base(Tags.TerminationType, val) {}


        // Field Enumerations
        public const int OVERNIGHT = 1;
        public const int TERM = 2;
        public const int FLEXIBLE = 3;
        public const int OPEN = 4;
    }


    /// <summary>
    /// NextExpectedMsgSeqNum Field
    /// </summary>/
    public sealed class NextExpectedMsgSeqNum : IntField
    {
        public NextExpectedMsgSeqNum()
            :base(Tags.NextExpectedMsgSeqNum) {}
        public NextExpectedMsgSeqNum(int val)
            :base(Tags.NextExpectedMsgSeqNum, val) {}

    }


    /// <summary>
    /// OrdStatusReqID Field
    /// </summary>/
    public sealed class OrdStatusReqID : StringField
    {
        public OrdStatusReqID()
            :base(Tags.OrdStatusReqID) {}
        public OrdStatusReqID(string val)
            :base(Tags.OrdStatusReqID, val) {}

    }


    /// <summary>
    /// SettlInstReqID Field
    /// </summary>/
    public sealed class SettlInstReqID : StringField
    {
        public SettlInstReqID()
            :base(Tags.SettlInstReqID) {}
        public SettlInstReqID(string val)
            :base(Tags.SettlInstReqID, val) {}

    }


    /// <summary>
    /// SettlInstReqRejCode Field
    /// </summary>/
    public sealed class SettlInstReqRejCode : IntField
    {
        public SettlInstReqRejCode()
            :base(Tags.SettlInstReqRejCode) {}
        public SettlInstReqRejCode(int val)
            :base(Tags.SettlInstReqRejCode, val) {}


        // Field Enumerations
        public const int UNABLE_TO_PROCESS_REQUEST = 0;
        public const int UNKNOWN_ACCOUNT = 1;
        public const int NO_MATCHING_SETTLEMENT_INSTRUCTIONS_FOUND = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// SecondaryAllocID Field
    /// </summary>/
    public sealed class SecondaryAllocID : StringField
    {
        public SecondaryAllocID()
            :base(Tags.SecondaryAllocID) {}
        public SecondaryAllocID(string val)
            :base(Tags.SecondaryAllocID, val) {}

    }


    /// <summary>
    /// AllocReportType Field
    /// </summary>/
    public sealed class AllocReportType : IntField
    {
        public AllocReportType()
            :base(Tags.AllocReportType) {}
        public AllocReportType(int val)
            :base(Tags.AllocReportType, val) {}


        // Field Enumerations
        public const int SELLSIDE_CALCULATED_USING_PRELIMINARY = 3;
        public const int SELLSIDE_CALCULATED_WITHOUT_PRELIMINARY = 4;
        public const int WAREHOUSE_RECAP = 5;
        public const int REQUEST_TO_INTERMEDIARY = 8;
        public const int PRELIMINARY_REQUEST_TO_INTERMEDIARY = 2;
        public const int ACCEPT = 9;
        public const int REJECT = 10;
        public const int ACCEPT_PENDING = 11;
        public const int COMPLETE = 12;
        public const int REVERSE_PENDING = 14;
    }


    /// <summary>
    /// AllocReportRefID Field
    /// </summary>/
    public sealed class AllocReportRefID : StringField
    {
        public AllocReportRefID()
            :base(Tags.AllocReportRefID) {}
        public AllocReportRefID(string val)
            :base(Tags.AllocReportRefID, val) {}

    }


    /// <summary>
    /// AllocCancReplaceReason Field
    /// </summary>/
    public sealed class AllocCancReplaceReason : IntField
    {
        public AllocCancReplaceReason()
            :base(Tags.AllocCancReplaceReason) {}
        public AllocCancReplaceReason(int val)
            :base(Tags.AllocCancReplaceReason, val) {}


        // Field Enumerations
        public const int ORIGINAL_DETAILS_INCOMPLETE_INCORRECT = 1;
        public const int CHANGE_IN_UNDERLYING_ORDER_DETAILS = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// CopyMsgIndicator Field
    /// </summary>/
    public sealed class CopyMsgIndicator : BooleanField
    {
        public CopyMsgIndicator()
            :base(Tags.CopyMsgIndicator) {}
        public CopyMsgIndicator(Boolean val)
            :base(Tags.CopyMsgIndicator, val) {}

    }


    /// <summary>
    /// AllocAccountType Field
    /// </summary>/
    public sealed class AllocAccountType : IntField
    {
        public AllocAccountType()
            :base(Tags.AllocAccountType) {}
        public AllocAccountType(int val)
            :base(Tags.AllocAccountType, val) {}


        // Field Enumerations
        public const int ACCOUNT_IS_CARRIED_PN_CUSTOMER_SIDE_OF_BOOKS = 1;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS = 2;
        public const int HOUSE_TRADER = 3;
        public const int FLOOR_TRADER = 4;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS_AND_IS_CROSS_MARGINED = 6;
        public const int ACCOUNT_IS_HOUSE_TRADER_AND_IS_CROSS_MARGINED = 7;
        public const int JOINT_BACK_OFFICE_ACCOUNT = 8;
    }


    /// <summary>
    /// OrderAvgPx Field
    /// </summary>/
    public sealed class OrderAvgPx : DecimalField
    {
        public OrderAvgPx()
            :base(Tags.OrderAvgPx) {}
        public OrderAvgPx(Decimal val)
            :base(Tags.OrderAvgPx, val) {}

    }


    /// <summary>
    /// OrderBookingQty Field
    /// </summary>/
    public sealed class OrderBookingQty : DecimalField
    {
        public OrderBookingQty()
            :base(Tags.OrderBookingQty) {}
        public OrderBookingQty(Decimal val)
            :base(Tags.OrderBookingQty, val) {}

    }


    /// <summary>
    /// NoSettlPartySubIDs Field
    /// </summary>/
    public sealed class NoSettlPartySubIDs : IntField
    {
        public NoSettlPartySubIDs()
            :base(Tags.NoSettlPartySubIDs) {}
        public NoSettlPartySubIDs(int val)
            :base(Tags.NoSettlPartySubIDs, val) {}

    }


    /// <summary>
    /// NoPartySubIDs Field
    /// </summary>/
    public sealed class NoPartySubIDs : IntField
    {
        public NoPartySubIDs()
            :base(Tags.NoPartySubIDs) {}
        public NoPartySubIDs(int val)
            :base(Tags.NoPartySubIDs, val) {}

    }


    /// <summary>
    /// PartySubIDType Field
    /// </summary>/
    public sealed class PartySubIDType : IntField
    {
        public PartySubIDType()
            :base(Tags.PartySubIDType) {}
        public PartySubIDType(int val)
            :base(Tags.PartySubIDType, val) {}


        // Field Enumerations
        public const int FIRM = 1;
        public const int SECURITIES_ACCOUNT_NUMBER = 10;
        public const int REGISTRATION_NUMBER = 11;
        public const int REGISTERED_ADDRESS_12 = 12;
        public const int REGULATORY_STATUS = 13;
        public const int REGISTRATION_NAME = 14;
        public const int CASH_ACCOUNT_NUMBER = 15;
        public const int BIC = 16;
        public const int CSD_PARTICIPANT_MEMBER_CODE = 17;
        public const int REGISTERED_ADDRESS_18 = 18;
        public const int FUND_ACCOUNT_NAME = 19;
        public const int PERSON = 2;
        public const int TELEX_NUMBER = 20;
        public const int FAX_NUMBER = 21;
        public const int SECURITIES_ACCOUNT_NAME = 22;
        public const int CASH_ACCOUNT_NAME = 23;
        public const int DEPARTMENT = 24;
        public const int LOCATION_DESK = 25;
        public const int POSITION_ACCOUNT_TYPE = 26;
        public const int SYSTEM = 3;
        public const int APPLICATION = 4;
        public const int FULL_LEGAL_NAME_OF_FIRM = 5;
        public const int POSTAL_ADDRESS = 6;
        public const int PHONE_NUMBER = 7;
        public const int EMAIL_ADDRESS = 8;
        public const int CONTACT_NAME = 9;
        public const int SECURITY_LOCATE_ID = 27;
        public const int MARKET_MAKER = 28;
        public const int ELIGIBLE_COUNTERPARTY = 29;
        public const int PROFESSIONAL_CLIENT = 30;
        public const int LOCATION = 31;
        public const int EXECUTION_VENUE = 32;
    }


    /// <summary>
    /// NoNestedPartySubIDs Field
    /// </summary>/
    public sealed class NoNestedPartySubIDs : IntField
    {
        public NoNestedPartySubIDs()
            :base(Tags.NoNestedPartySubIDs) {}
        public NoNestedPartySubIDs(int val)
            :base(Tags.NoNestedPartySubIDs, val) {}

    }


    /// <summary>
    /// NestedPartySubIDType Field
    /// </summary>/
    public sealed class NestedPartySubIDType : IntField
    {
        public NestedPartySubIDType()
            :base(Tags.NestedPartySubIDType) {}
        public NestedPartySubIDType(int val)
            :base(Tags.NestedPartySubIDType, val) {}

    }


    /// <summary>
    /// NoNested2PartySubIDs Field
    /// </summary>/
    public sealed class NoNested2PartySubIDs : IntField
    {
        public NoNested2PartySubIDs()
            :base(Tags.NoNested2PartySubIDs) {}
        public NoNested2PartySubIDs(int val)
            :base(Tags.NoNested2PartySubIDs, val) {}

    }


    /// <summary>
    /// Nested2PartySubIDType Field
    /// </summary>/
    public sealed class Nested2PartySubIDType : IntField
    {
        public Nested2PartySubIDType()
            :base(Tags.Nested2PartySubIDType) {}
        public Nested2PartySubIDType(int val)
            :base(Tags.Nested2PartySubIDType, val) {}

    }


    /// <summary>
    /// AllocIntermedReqType Field
    /// </summary>/
    public sealed class AllocIntermedReqType : IntField
    {
        public AllocIntermedReqType()
            :base(Tags.AllocIntermedReqType) {}
        public AllocIntermedReqType(int val)
            :base(Tags.AllocIntermedReqType, val) {}


        // Field Enumerations
        public const int PENDING_ACCEPT = 1;
        public const int PENDING_RELEASE = 2;
        public const int PENDING_REVERSAL = 3;
        public const int ACCEPT = 4;
        public const int BLOCK_LEVEL_REJECT = 5;
        public const int ACCOUNT_LEVEL_REJECT = 6;
    }


    /// <summary>
    /// UnderlyingPx Field
    /// </summary>/
    public sealed class UnderlyingPx : DecimalField
    {
        public UnderlyingPx()
            :base(Tags.UnderlyingPx) {}
        public UnderlyingPx(Decimal val)
            :base(Tags.UnderlyingPx, val) {}

    }


    /// <summary>
    /// PriceDelta Field
    /// </summary>/
    public sealed class PriceDelta : DecimalField
    {
        public PriceDelta()
            :base(Tags.PriceDelta) {}
        public PriceDelta(Decimal val)
            :base(Tags.PriceDelta, val) {}

    }


    /// <summary>
    /// ApplQueueMax Field
    /// </summary>/
    public sealed class ApplQueueMax : IntField
    {
        public ApplQueueMax()
            :base(Tags.ApplQueueMax) {}
        public ApplQueueMax(int val)
            :base(Tags.ApplQueueMax, val) {}

    }


    /// <summary>
    /// ApplQueueDepth Field
    /// </summary>/
    public sealed class ApplQueueDepth : IntField
    {
        public ApplQueueDepth()
            :base(Tags.ApplQueueDepth) {}
        public ApplQueueDepth(int val)
            :base(Tags.ApplQueueDepth, val) {}

    }


    /// <summary>
    /// ApplQueueResolution Field
    /// </summary>/
    public sealed class ApplQueueResolution : IntField
    {
        public ApplQueueResolution()
            :base(Tags.ApplQueueResolution) {}
        public ApplQueueResolution(int val)
            :base(Tags.ApplQueueResolution, val) {}


        // Field Enumerations
        public const int NO_ACTION_TAKEN = 0;
        public const int QUEUE_FLUSHED = 1;
        public const int OVERLAY_LAST = 2;
        public const int END_SESSION = 3;
    }


    /// <summary>
    /// ApplQueueAction Field
    /// </summary>/
    public sealed class ApplQueueAction : IntField
    {
        public ApplQueueAction()
            :base(Tags.ApplQueueAction) {}
        public ApplQueueAction(int val)
            :base(Tags.ApplQueueAction, val) {}


        // Field Enumerations
        public const int NO_ACTION_TAKEN = 0;
        public const int QUEUE_FLUSHED = 1;
        public const int OVERLAY_LAST = 2;
        public const int END_SESSION = 3;
    }


    /// <summary>
    /// NoAltMDSource Field
    /// </summary>/
    public sealed class NoAltMDSource : IntField
    {
        public NoAltMDSource()
            :base(Tags.NoAltMDSource) {}
        public NoAltMDSource(int val)
            :base(Tags.NoAltMDSource, val) {}

    }


    /// <summary>
    /// AltMDSourceID Field
    /// </summary>/
    public sealed class AltMDSourceID : StringField
    {
        public AltMDSourceID()
            :base(Tags.AltMDSourceID) {}
        public AltMDSourceID(string val)
            :base(Tags.AltMDSourceID, val) {}

    }


    /// <summary>
    /// SecondaryTradeReportID Field
    /// </summary>/
    public sealed class SecondaryTradeReportID : StringField
    {
        public SecondaryTradeReportID()
            :base(Tags.SecondaryTradeReportID) {}
        public SecondaryTradeReportID(string val)
            :base(Tags.SecondaryTradeReportID, val) {}

    }


    /// <summary>
    /// AvgPxIndicator Field
    /// </summary>/
    public sealed class AvgPxIndicator : IntField
    {
        public AvgPxIndicator()
            :base(Tags.AvgPxIndicator) {}
        public AvgPxIndicator(int val)
            :base(Tags.AvgPxIndicator, val) {}


        // Field Enumerations
        public const int NO_AVERAGE_PRICING = 0;
        public const int TRADE_IS_PART_OF_AN_AVERAGE_PRICE_GROUP_IDENTIFIED_BY_THE_TRADELINKID = 1;
        public const int LAST_TRADE_IS_THE_AVERAGE_PRICE_GROUP_IDENTIFIED_BY_THE_TRADELINKID = 2;
    }


    /// <summary>
    /// TradeLinkID Field
    /// </summary>/
    public sealed class TradeLinkID : StringField
    {
        public TradeLinkID()
            :base(Tags.TradeLinkID) {}
        public TradeLinkID(string val)
            :base(Tags.TradeLinkID, val) {}

    }


    /// <summary>
    /// OrderInputDevice Field
    /// </summary>/
    public sealed class OrderInputDevice : StringField
    {
        public OrderInputDevice()
            :base(Tags.OrderInputDevice) {}
        public OrderInputDevice(string val)
            :base(Tags.OrderInputDevice, val) {}

    }


    /// <summary>
    /// UnderlyingTradingSessionID Field
    /// </summary>/
    public sealed class UnderlyingTradingSessionID : StringField
    {
        public UnderlyingTradingSessionID()
            :base(Tags.UnderlyingTradingSessionID) {}
        public UnderlyingTradingSessionID(string val)
            :base(Tags.UnderlyingTradingSessionID, val) {}

    }


    /// <summary>
    /// UnderlyingTradingSessionSubID Field
    /// </summary>/
    public sealed class UnderlyingTradingSessionSubID : StringField
    {
        public UnderlyingTradingSessionSubID()
            :base(Tags.UnderlyingTradingSessionSubID) {}
        public UnderlyingTradingSessionSubID(string val)
            :base(Tags.UnderlyingTradingSessionSubID, val) {}

    }


    /// <summary>
    /// TradeLegRefID Field
    /// </summary>/
    public sealed class TradeLegRefID : StringField
    {
        public TradeLegRefID()
            :base(Tags.TradeLegRefID) {}
        public TradeLegRefID(string val)
            :base(Tags.TradeLegRefID, val) {}

    }


    /// <summary>
    /// ExchangeRule Field
    /// </summary>/
    public sealed class ExchangeRule : StringField
    {
        public ExchangeRule()
            :base(Tags.ExchangeRule) {}
        public ExchangeRule(string val)
            :base(Tags.ExchangeRule, val) {}

    }


    /// <summary>
    /// TradeAllocIndicator Field
    /// </summary>/
    public sealed class TradeAllocIndicator : IntField
    {
        public TradeAllocIndicator()
            :base(Tags.TradeAllocIndicator) {}
        public TradeAllocIndicator(int val)
            :base(Tags.TradeAllocIndicator, val) {}


        // Field Enumerations
        public const int ALLOCATION_NOT_REQUIRED = 0;
        public const int ALLOCATION_REQUIRED = 1;
        public const int USE_ALLOCATION_PROVIDED_WITH_THE_TRADE = 2;
        public const int ALLOCATION_GIVE_UP_EXECUTOR = 3;
        public const int ALLOCATION_FROM_EXECUTOR = 4;
        public const int ALLOCATION_TO_CLAIM_ACCOUNT = 5;
    }


    /// <summary>
    /// ExpirationCycle Field
    /// </summary>/
    public sealed class ExpirationCycle : IntField
    {
        public ExpirationCycle()
            :base(Tags.ExpirationCycle) {}
        public ExpirationCycle(int val)
            :base(Tags.ExpirationCycle, val) {}


        // Field Enumerations
        public const int EXPIRE_ON_TRADING_SESSION_CLOSE = 0;
        public const int EXPIRE_ON_TRADING_SESSION_OPEN = 1;
    }


    /// <summary>
    /// TrdType Field
    /// </summary>/
    public sealed class TrdType : IntField
    {
        public TrdType()
            :base(Tags.TrdType) {}
        public TrdType(int val)
            :base(Tags.TrdType, val) {}


        // Field Enumerations
        public const int REGULAR_TRADE = 0;
        public const int BLOCK_TRADE_1 = 1;
        public const int AFTER_HOURS_TRADE = 10;
        public const int EFP = 2;
        public const int TRANSFER = 3;
        public const int LATE_TRADE = 4;
        public const int T_TRADE = 5;
        public const int WEIGHTED_AVERAGE_PRICE_TRADE = 6;
        public const int BUNCHED_TRADE = 7;
        public const int LATE_BUNCHED_TRADE = 8;
        public const int PRIOR_REFERENCE_PRICE_TRADE = 9;
        public const int EXCHANGE_FOR_RISK = 11;
        public const int EXCHANGE_FOR_SWAP = 12;
        public const int EXCHANGE_OF_FUTURES_FOR = 13;
        public const int EXCHANGE_OF_OPTIONS_FOR_OPTIONS = 14;
        public const int TRADING_AT_SETTLEMENT = 15;
        public const int ALL_OR_NONE = 16;
        public const int FUTURES_LARGE_ORDER_EXECUTION = 17;
        public const int EXCHANGE_OF_FUTURES_FOR_FUTURES = 18;
        public const int OPTION_INTERIM_TRADE = 19;
        public const int OPTION_CABINET_TRADE = 20;
        public const int PRIVATELY_NEGOTIATED_TRADES = 22;
        public const int SUBSTITUTION_OF_FUTURES_FOR_FORWARDS = 23;
        public const int ERROR_TRADE = 24;
        public const int SPECIAL_CUM_DIVIDEND = 25;
        public const int SPECIAL_EX_DIVIDEND = 26;
        public const int SPECIAL_CUM_COUPON = 27;
        public const int SPECIAL_EX_COUPON = 28;
        public const int CASH_SETTLEMENT = 29;
        public const int SPECIAL_PRICE = 30;
        public const int GUARANTEED_DELIVERY = 31;
        public const int SPECIAL_CUM_RIGHTS = 32;
        public const int SPECIAL_EX_RIGHTS = 33;
        public const int SPECIAL_CUM_CAPITAL_REPAYMENTS = 34;
        public const int SPECIAL_EX_CAPITAL_REPAYMENTS = 35;
        public const int SPECIAL_CUM_BONUS = 36;
        public const int SPECIAL_EX_BONUS = 37;
        public const int BLOCK_TRADE_38 = 38;
        public const int WORKED_PRINCIPAL_TRADE = 39;
        public const int BLOCK_TRADES = 40;
        public const int NAME_CHANGE = 41;
        public const int PORTFOLIO_TRANSFER = 42;
        public const int PROROGATION_BUY = 43;
        public const int PROROGATION_SELL = 44;
        public const int OPTION_EXERCISE = 45;
        public const int DELTA_NEUTRAL_TRANSACTION = 46;
        public const int FINANCING_TRANSACTION = 47;
    }


    /// <summary>
    /// TrdSubType Field
    /// </summary>/
    public sealed class TrdSubType : IntField
    {
        public TrdSubType()
            :base(Tags.TrdSubType) {}
        public TrdSubType(int val)
            :base(Tags.TrdSubType, val) {}


        // Field Enumerations
        public const int CMTA = 0;
        public const int INTERNAL_TRANSFER_OR_ADJUSTMENT = 1;
        public const int EXTERNAL_TRANSFER_OR_TRANSFER_OF_ACCOUNT = 2;
        public const int REJECT_FOR_SUBMITTING_SIDE = 3;
        public const int ADVISORY_FOR_CONTRA_SIDE = 4;
        public const int OFFSET_DUE_TO_AN_ALLOCATION = 5;
        public const int ONSET_DUT_TO_AN_ALLOCATION = 6;
        public const int DIFFERENTIAL_SPREAD = 7;
        public const int IMPLIED_SPREAD_LEG_EXECUTED_AGAINST_AN_OUTRIGHT = 8;
        public const int TRANSACTION_FROM_EXERCISE = 9;
        public const int TRANSACTION_FROM_ASSIGNMENT = 10;
        public const int ACATS = 11;
        public const int AI = 14;
        public const int B = 15;
        public const int K = 16;
        public const int LC = 17;
        public const int M = 18;
        public const int N = 19;
        public const int NM = 20;
        public const int NR = 21;
        public const int P = 22;
        public const int PA = 23;
        public const int PC = 24;
        public const int PN = 25;
        public const int R = 26;
        public const int RO = 27;
        public const int RT = 28;
        public const int SW = 29;
        public const int T = 30;
        public const int WN = 31;
        public const int WT = 32;
    }


    /// <summary>
    /// TransferReason Field
    /// </summary>/
    public sealed class TransferReason : StringField
    {
        public TransferReason()
            :base(Tags.TransferReason) {}
        public TransferReason(string val)
            :base(Tags.TransferReason, val) {}

    }


    /// <summary>
    /// AsgnReqID Field
    /// </summary>/
    public sealed class AsgnReqID : StringField
    {
        public AsgnReqID()
            :base(Tags.AsgnReqID) {}
        public AsgnReqID(string val)
            :base(Tags.AsgnReqID, val) {}

    }


    /// <summary>
    /// TotNumAssignmentReports Field
    /// </summary>/
    public sealed class TotNumAssignmentReports : IntField
    {
        public TotNumAssignmentReports()
            :base(Tags.TotNumAssignmentReports) {}
        public TotNumAssignmentReports(int val)
            :base(Tags.TotNumAssignmentReports, val) {}

    }


    /// <summary>
    /// AsgnRptID Field
    /// </summary>/
    public sealed class AsgnRptID : StringField
    {
        public AsgnRptID()
            :base(Tags.AsgnRptID) {}
        public AsgnRptID(string val)
            :base(Tags.AsgnRptID, val) {}

    }


    /// <summary>
    /// ThresholdAmount Field
    /// </summary>/
    public sealed class ThresholdAmount : DecimalField
    {
        public ThresholdAmount()
            :base(Tags.ThresholdAmount) {}
        public ThresholdAmount(Decimal val)
            :base(Tags.ThresholdAmount, val) {}

    }


    /// <summary>
    /// PegMoveType Field
    /// </summary>/
    public sealed class PegMoveType : IntField
    {
        public PegMoveType()
            :base(Tags.PegMoveType) {}
        public PegMoveType(int val)
            :base(Tags.PegMoveType, val) {}


        // Field Enumerations
        public const int FLOATING = 0;
        public const int FIXED = 1;
    }


    /// <summary>
    /// PegOffsetType Field
    /// </summary>/
    public sealed class PegOffsetType : IntField
    {
        public PegOffsetType()
            :base(Tags.PegOffsetType) {}
        public PegOffsetType(int val)
            :base(Tags.PegOffsetType, val) {}


        // Field Enumerations
        public const int PRICE = 0;
        public const int BASIS_POINTS = 1;
        public const int TICKS = 2;
        public const int PRICE_TIER = 3;
    }


    /// <summary>
    /// PegLimitType Field
    /// </summary>/
    public sealed class PegLimitType : IntField
    {
        public PegLimitType()
            :base(Tags.PegLimitType) {}
        public PegLimitType(int val)
            :base(Tags.PegLimitType, val) {}


        // Field Enumerations
        public const int OR_BETTER = 0;
        public const int STRICT = 1;
        public const int OR_WORSE = 2;
    }


    /// <summary>
    /// PegRoundDirection Field
    /// </summary>/
    public sealed class PegRoundDirection : IntField
    {
        public PegRoundDirection()
            :base(Tags.PegRoundDirection) {}
        public PegRoundDirection(int val)
            :base(Tags.PegRoundDirection, val) {}


        // Field Enumerations
        public const int MORE_AGGRESSIVE = 1;
        public const int MORE_PASSIVE = 2;
    }


    /// <summary>
    /// PeggedPrice Field
    /// </summary>/
    public sealed class PeggedPrice : DecimalField
    {
        public PeggedPrice()
            :base(Tags.PeggedPrice) {}
        public PeggedPrice(Decimal val)
            :base(Tags.PeggedPrice, val) {}

    }


    /// <summary>
    /// PegScope Field
    /// </summary>/
    public sealed class PegScope : IntField
    {
        public PegScope()
            :base(Tags.PegScope) {}
        public PegScope(int val)
            :base(Tags.PegScope, val) {}


        // Field Enumerations
        public const int LOCAL = 1;
        public const int NATIONAL = 2;
        public const int GLOBAL = 3;
        public const int NATIONAL_XXCLUDING_LOCAL = 4;
    }


    /// <summary>
    /// DiscretionMoveType Field
    /// </summary>/
    public sealed class DiscretionMoveType : IntField
    {
        public DiscretionMoveType()
            :base(Tags.DiscretionMoveType) {}
        public DiscretionMoveType(int val)
            :base(Tags.DiscretionMoveType, val) {}


        // Field Enumerations
        public const int FLOATING = 0;
        public const int FIXED = 1;
    }


    /// <summary>
    /// DiscretionOffsetType Field
    /// </summary>/
    public sealed class DiscretionOffsetType : IntField
    {
        public DiscretionOffsetType()
            :base(Tags.DiscretionOffsetType) {}
        public DiscretionOffsetType(int val)
            :base(Tags.DiscretionOffsetType, val) {}


        // Field Enumerations
        public const int PRICE = 0;
        public const int BASIS_POINTS = 1;
        public const int TICKS = 2;
        public const int PRICE_TIER = 3;
    }


    /// <summary>
    /// DiscretionLimitType Field
    /// </summary>/
    public sealed class DiscretionLimitType : IntField
    {
        public DiscretionLimitType()
            :base(Tags.DiscretionLimitType) {}
        public DiscretionLimitType(int val)
            :base(Tags.DiscretionLimitType, val) {}


        // Field Enumerations
        public const int OR_BETTER = 0;
        public const int STRICT = 1;
        public const int OR_WORSE = 2;
    }


    /// <summary>
    /// DiscretionRoundDirection Field
    /// </summary>/
    public sealed class DiscretionRoundDirection : IntField
    {
        public DiscretionRoundDirection()
            :base(Tags.DiscretionRoundDirection) {}
        public DiscretionRoundDirection(int val)
            :base(Tags.DiscretionRoundDirection, val) {}


        // Field Enumerations
        public const int MORE_AGGRESSIVE = 1;
        public const int MORE_PASSIVE = 2;
    }


    /// <summary>
    /// DiscretionPrice Field
    /// </summary>/
    public sealed class DiscretionPrice : DecimalField
    {
        public DiscretionPrice()
            :base(Tags.DiscretionPrice) {}
        public DiscretionPrice(Decimal val)
            :base(Tags.DiscretionPrice, val) {}

    }


    /// <summary>
    /// DiscretionScope Field
    /// </summary>/
    public sealed class DiscretionScope : IntField
    {
        public DiscretionScope()
            :base(Tags.DiscretionScope) {}
        public DiscretionScope(int val)
            :base(Tags.DiscretionScope, val) {}


        // Field Enumerations
        public const int LOCAL = 1;
        public const int NATIONAL = 2;
        public const int GLOBAL = 3;
        public const int NATIONAL_EXCLUDING_LOCAL = 4;
    }


    /// <summary>
    /// TargetStrategy Field
    /// </summary>/
    public sealed class TargetStrategy : IntField
    {
        public TargetStrategy()
            :base(Tags.TargetStrategy) {}
        public TargetStrategy(int val)
            :base(Tags.TargetStrategy, val) {}


        // Field Enumerations
        public const int VWAP = 1;
        public const int PARTICIPATE = 2;
        public const int MININIZE_MARKET_IMPACT = 3;
    }


    /// <summary>
    /// TargetStrategyParameters Field
    /// </summary>/
    public sealed class TargetStrategyParameters : StringField
    {
        public TargetStrategyParameters()
            :base(Tags.TargetStrategyParameters) {}
        public TargetStrategyParameters(string val)
            :base(Tags.TargetStrategyParameters, val) {}

    }


    /// <summary>
    /// ParticipationRate Field
    /// </summary>/
    public sealed class ParticipationRate : DecimalField
    {
        public ParticipationRate()
            :base(Tags.ParticipationRate) {}
        public ParticipationRate(Decimal val)
            :base(Tags.ParticipationRate, val) {}

    }


    /// <summary>
    /// TargetStrategyPerformance Field
    /// </summary>/
    public sealed class TargetStrategyPerformance : DecimalField
    {
        public TargetStrategyPerformance()
            :base(Tags.TargetStrategyPerformance) {}
        public TargetStrategyPerformance(Decimal val)
            :base(Tags.TargetStrategyPerformance, val) {}

    }


    /// <summary>
    /// LastLiquidityInd Field
    /// </summary>/
    public sealed class LastLiquidityInd : IntField
    {
        public LastLiquidityInd()
            :base(Tags.LastLiquidityInd) {}
        public LastLiquidityInd(int val)
            :base(Tags.LastLiquidityInd, val) {}


        // Field Enumerations
        public const int ADDED_LIQUIDITY = 1;
        public const int REMOVED_LIQUIDITY = 2;
        public const int LIQUIDITY_ROUTED_OUT = 3;
    }


    /// <summary>
    /// PublishTrdIndicator Field
    /// </summary>/
    public sealed class PublishTrdIndicator : BooleanField
    {
        public PublishTrdIndicator()
            :base(Tags.PublishTrdIndicator) {}
        public PublishTrdIndicator(Boolean val)
            :base(Tags.PublishTrdIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// ShortSaleReason Field
    /// </summary>/
    public sealed class ShortSaleReason : IntField
    {
        public ShortSaleReason()
            :base(Tags.ShortSaleReason) {}
        public ShortSaleReason(int val)
            :base(Tags.ShortSaleReason, val) {}


        // Field Enumerations
        public const int DEALER_SOLD_SHORT = 0;
        public const int DEALER_SOLD_SHORT_EXEMPT = 1;
        public const int SELLING_CUSTOMER_SOLD_SHORT = 2;
        public const int SELLING_CUSTOMER_SOLD_SHORT_EXEMPT = 3;
        public const int QUALIFIED_SERVICE_REPRESENTATIVE = 4;
        public const int QSR_OR_AGU_CONTRA_SIDE_SOLD_SHORT_EXEMPT = 5;
    }


    /// <summary>
    /// QtyType Field
    /// </summary>/
    public sealed class QtyType : IntField
    {
        public QtyType()
            :base(Tags.QtyType) {}
        public QtyType(int val)
            :base(Tags.QtyType, val) {}


        // Field Enumerations
        public const int UNITS = 0;
        public const int CONTRACTS = 1;
        public const int UNITS_OF_MEASURE_PER_TIME_UNIT = 2;
    }


    /// <summary>
    /// SecondaryTrdType Field
    /// </summary>/
    public sealed class SecondaryTrdType : IntField
    {
        public SecondaryTrdType()
            :base(Tags.SecondaryTrdType) {}
        public SecondaryTrdType(int val)
            :base(Tags.SecondaryTrdType, val) {}

    }


    /// <summary>
    /// TradeReportType Field
    /// </summary>/
    public sealed class TradeReportType : IntField
    {
        public TradeReportType()
            :base(Tags.TradeReportType) {}
        public TradeReportType(int val)
            :base(Tags.TradeReportType, val) {}


        // Field Enumerations
        public const int SUBMIT = 0;
        public const int ALLEGED_1 = 1;
        public const int ACCEPT = 2;
        public const int DECLINE = 3;
        public const int ADDENDUM = 4;
        public const int NO_WAS = 5;
        public const int TRADE_REPORT_CANCEL = 6;
        public const int VAL_7 = 7;
        public const int DEFAULTED = 8;
        public const int INVALID_CMTA = 9;
        public const int PENDED = 10;
        public const int ALLEGED_NEW = 11;
        public const int ALLEGED_ADDENDUM = 12;
        public const int ALLEGED_NO_WAS = 13;
        public const int ALLEGED_TRADE_REPORT_CANCEL = 14;
        public const int ALLEGED_15 = 15;
    }


    /// <summary>
    /// AllocNoOrdersType Field
    /// </summary>/
    public sealed class AllocNoOrdersType : IntField
    {
        public AllocNoOrdersType()
            :base(Tags.AllocNoOrdersType) {}
        public AllocNoOrdersType(int val)
            :base(Tags.AllocNoOrdersType, val) {}


        // Field Enumerations
        public const int NOT_SPECIFIED = 0;
        public const int EXPLICIT_LIST_PROVIDED = 1;
    }


    /// <summary>
    /// SharedCommission Field
    /// </summary>/
    public sealed class SharedCommission : DecimalField
    {
        public SharedCommission()
            :base(Tags.SharedCommission) {}
        public SharedCommission(Decimal val)
            :base(Tags.SharedCommission, val) {}

    }


    /// <summary>
    /// ConfirmReqID Field
    /// </summary>/
    public sealed class ConfirmReqID : StringField
    {
        public ConfirmReqID()
            :base(Tags.ConfirmReqID) {}
        public ConfirmReqID(string val)
            :base(Tags.ConfirmReqID, val) {}

    }


    /// <summary>
    /// AvgParPx Field
    /// </summary>/
    public sealed class AvgParPx : DecimalField
    {
        public AvgParPx()
            :base(Tags.AvgParPx) {}
        public AvgParPx(Decimal val)
            :base(Tags.AvgParPx, val) {}

    }


    /// <summary>
    /// ReportedPx Field
    /// </summary>/
    public sealed class ReportedPx : DecimalField
    {
        public ReportedPx()
            :base(Tags.ReportedPx) {}
        public ReportedPx(Decimal val)
            :base(Tags.ReportedPx, val) {}

    }


    /// <summary>
    /// NoCapacities Field
    /// </summary>/
    public sealed class NoCapacities : IntField
    {
        public NoCapacities()
            :base(Tags.NoCapacities) {}
        public NoCapacities(int val)
            :base(Tags.NoCapacities, val) {}

    }


    /// <summary>
    /// OrderCapacityQty Field
    /// </summary>/
    public sealed class OrderCapacityQty : DecimalField
    {
        public OrderCapacityQty()
            :base(Tags.OrderCapacityQty) {}
        public OrderCapacityQty(Decimal val)
            :base(Tags.OrderCapacityQty, val) {}

    }


    /// <summary>
    /// NoEvents Field
    /// </summary>/
    public sealed class NoEvents : IntField
    {
        public NoEvents()
            :base(Tags.NoEvents) {}
        public NoEvents(int val)
            :base(Tags.NoEvents, val) {}

    }


    /// <summary>
    /// EventType Field
    /// </summary>/
    public sealed class EventType : IntField
    {
        public EventType()
            :base(Tags.EventType) {}
        public EventType(int val)
            :base(Tags.EventType, val) {}


        // Field Enumerations
        public const int PUT = 1;
        public const int CALL = 2;
        public const int TENDER = 3;
        public const int SINKING_FUND_CALL = 4;
        public const int OTHER = 99;
        public const int ACTIVATION = 5;
        public const int INACTIVIATION = 6;
    }


    /// <summary>
    /// EventDate Field
    /// </summary>/
    public sealed class EventDate : StringField
    {
        public EventDate()
            :base(Tags.EventDate) {}
        public EventDate(string val)
            :base(Tags.EventDate, val) {}

    }


    /// <summary>
    /// EventPx Field
    /// </summary>/
    public sealed class EventPx : DecimalField
    {
        public EventPx()
            :base(Tags.EventPx) {}
        public EventPx(Decimal val)
            :base(Tags.EventPx, val) {}

    }


    /// <summary>
    /// EventText Field
    /// </summary>/
    public sealed class EventText : StringField
    {
        public EventText()
            :base(Tags.EventText) {}
        public EventText(string val)
            :base(Tags.EventText, val) {}

    }


    /// <summary>
    /// PctAtRisk Field
    /// </summary>/
    public sealed class PctAtRisk : DecimalField
    {
        public PctAtRisk()
            :base(Tags.PctAtRisk) {}
        public PctAtRisk(Decimal val)
            :base(Tags.PctAtRisk, val) {}

    }


    /// <summary>
    /// NoInstrAttrib Field
    /// </summary>/
    public sealed class NoInstrAttrib : IntField
    {
        public NoInstrAttrib()
            :base(Tags.NoInstrAttrib) {}
        public NoInstrAttrib(int val)
            :base(Tags.NoInstrAttrib, val) {}

    }


    /// <summary>
    /// InstrAttribType Field
    /// </summary>/
    public sealed class InstrAttribType : IntField
    {
        public InstrAttribType()
            :base(Tags.InstrAttribType) {}
        public InstrAttribType(int val)
            :base(Tags.InstrAttribType, val) {}


        // Field Enumerations
        public const int FLAT = 1;
        public const int ORIGINAL_ISSUE_DISCOUNT = 10;
        public const int CALLABLE_PUTTABLE = 11;
        public const int ESCROWED_TO_MATURITY = 12;
        public const int ESCROWED_TO_REDEMPTION_DATE = 13;
        public const int PRE_REFUNDED = 14;
        public const int IN_DEFAULT = 15;
        public const int UNRATED = 16;
        public const int TAXABLE = 17;
        public const int INDEXED = 18;
        public const int SUBJECT_TO_ALTERNATIVE_MINIMUM_TAX = 19;
        public const int ZERO_COUPON = 2;
        public const int ORIGINAL_ISSUE_DISCOUNT_PRICE_SUPPLY_PRICE_IN_THE_INSTRATTRIBVALUE = 20;
        public const int CALLABLE_BELOW_MATURITY_VALUE = 21;
        public const int CALLABLE_WITHOUT_NOTICE_BY_MAIL_TO_HOLDER_UNLESS_REGISTERED = 22;
        public const int INTEREST_BEARING = 3;
        public const int NO_PERIODIC_PAYMENTS = 4;
        public const int VARIABLE_RATE = 5;
        public const int LESS_FEE_FOR_PUT = 6;
        public const int STEPPED_COUPON = 7;
        public const int COUPON_PERIOD = 8;
        public const int WHEN_AND_IF_ISSUED = 9;
        public const int TEXT_SUPPLY_THE_TEXT_OF_THE_ATTRIBUTE_OR_DISCLAIMER_IN_THE_INSTRATTRIBVALUE = 99;
    }


    /// <summary>
    /// InstrAttribValue Field
    /// </summary>/
    public sealed class InstrAttribValue : StringField
    {
        public InstrAttribValue()
            :base(Tags.InstrAttribValue) {}
        public InstrAttribValue(string val)
            :base(Tags.InstrAttribValue, val) {}

    }


    /// <summary>
    /// DatedDate Field
    /// </summary>/
    public sealed class DatedDate : StringField
    {
        public DatedDate()
            :base(Tags.DatedDate) {}
        public DatedDate(string val)
            :base(Tags.DatedDate, val) {}

    }


    /// <summary>
    /// InterestAccrualDate Field
    /// </summary>/
    public sealed class InterestAccrualDate : StringField
    {
        public InterestAccrualDate()
            :base(Tags.InterestAccrualDate) {}
        public InterestAccrualDate(string val)
            :base(Tags.InterestAccrualDate, val) {}

    }


    /// <summary>
    /// CPProgram Field
    /// </summary>/
    public sealed class CPProgram : IntField
    {
        public CPProgram()
            :base(Tags.CPProgram) {}
        public CPProgram(int val)
            :base(Tags.CPProgram, val) {}


        // Field Enumerations
        public const int VAL_3 = 1;
        public const int VAL_4 = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// CPRegType Field
    /// </summary>/
    public sealed class CPRegType : StringField
    {
        public CPRegType()
            :base(Tags.CPRegType) {}
        public CPRegType(string val)
            :base(Tags.CPRegType, val) {}

    }


    /// <summary>
    /// UnderlyingCPProgram Field
    /// </summary>/
    public sealed class UnderlyingCPProgram : StringField
    {
        public UnderlyingCPProgram()
            :base(Tags.UnderlyingCPProgram) {}
        public UnderlyingCPProgram(string val)
            :base(Tags.UnderlyingCPProgram, val) {}

    }


    /// <summary>
    /// UnderlyingCPRegType Field
    /// </summary>/
    public sealed class UnderlyingCPRegType : StringField
    {
        public UnderlyingCPRegType()
            :base(Tags.UnderlyingCPRegType) {}
        public UnderlyingCPRegType(string val)
            :base(Tags.UnderlyingCPRegType, val) {}

    }


    /// <summary>
    /// UnderlyingQty Field
    /// </summary>/
    public sealed class UnderlyingQty : DecimalField
    {
        public UnderlyingQty()
            :base(Tags.UnderlyingQty) {}
        public UnderlyingQty(Decimal val)
            :base(Tags.UnderlyingQty, val) {}

    }


    /// <summary>
    /// TrdMatchID Field
    /// </summary>/
    public sealed class TrdMatchID : StringField
    {
        public TrdMatchID()
            :base(Tags.TrdMatchID) {}
        public TrdMatchID(string val)
            :base(Tags.TrdMatchID, val) {}

    }


    /// <summary>
    /// SecondaryTradeReportRefID Field
    /// </summary>/
    public sealed class SecondaryTradeReportRefID : StringField
    {
        public SecondaryTradeReportRefID()
            :base(Tags.SecondaryTradeReportRefID) {}
        public SecondaryTradeReportRefID(string val)
            :base(Tags.SecondaryTradeReportRefID, val) {}

    }


    /// <summary>
    /// UnderlyingDirtyPrice Field
    /// </summary>/
    public sealed class UnderlyingDirtyPrice : DecimalField
    {
        public UnderlyingDirtyPrice()
            :base(Tags.UnderlyingDirtyPrice) {}
        public UnderlyingDirtyPrice(Decimal val)
            :base(Tags.UnderlyingDirtyPrice, val) {}

    }


    /// <summary>
    /// UnderlyingEndPrice Field
    /// </summary>/
    public sealed class UnderlyingEndPrice : DecimalField
    {
        public UnderlyingEndPrice()
            :base(Tags.UnderlyingEndPrice) {}
        public UnderlyingEndPrice(Decimal val)
            :base(Tags.UnderlyingEndPrice, val) {}

    }


    /// <summary>
    /// UnderlyingStartValue Field
    /// </summary>/
    public sealed class UnderlyingStartValue : DecimalField
    {
        public UnderlyingStartValue()
            :base(Tags.UnderlyingStartValue) {}
        public UnderlyingStartValue(Decimal val)
            :base(Tags.UnderlyingStartValue, val) {}

    }


    /// <summary>
    /// UnderlyingCurrentValue Field
    /// </summary>/
    public sealed class UnderlyingCurrentValue : DecimalField
    {
        public UnderlyingCurrentValue()
            :base(Tags.UnderlyingCurrentValue) {}
        public UnderlyingCurrentValue(Decimal val)
            :base(Tags.UnderlyingCurrentValue, val) {}

    }


    /// <summary>
    /// UnderlyingEndValue Field
    /// </summary>/
    public sealed class UnderlyingEndValue : DecimalField
    {
        public UnderlyingEndValue()
            :base(Tags.UnderlyingEndValue) {}
        public UnderlyingEndValue(Decimal val)
            :base(Tags.UnderlyingEndValue, val) {}

    }


    /// <summary>
    /// NoUnderlyingStips Field
    /// </summary>/
    public sealed class NoUnderlyingStips : IntField
    {
        public NoUnderlyingStips()
            :base(Tags.NoUnderlyingStips) {}
        public NoUnderlyingStips(int val)
            :base(Tags.NoUnderlyingStips, val) {}

    }


    /// <summary>
    /// UnderlyingStipType Field
    /// </summary>/
    public sealed class UnderlyingStipType : StringField
    {
        public UnderlyingStipType()
            :base(Tags.UnderlyingStipType) {}
        public UnderlyingStipType(string val)
            :base(Tags.UnderlyingStipType, val) {}

    }


    /// <summary>
    /// UnderlyingStipValue Field
    /// </summary>/
    public sealed class UnderlyingStipValue : StringField
    {
        public UnderlyingStipValue()
            :base(Tags.UnderlyingStipValue) {}
        public UnderlyingStipValue(string val)
            :base(Tags.UnderlyingStipValue, val) {}

    }


    /// <summary>
    /// MaturityNetMoney Field
    /// </summary>/
    public sealed class MaturityNetMoney : DecimalField
    {
        public MaturityNetMoney()
            :base(Tags.MaturityNetMoney) {}
        public MaturityNetMoney(Decimal val)
            :base(Tags.MaturityNetMoney, val) {}

    }


    /// <summary>
    /// MiscFeeBasis Field
    /// </summary>/
    public sealed class MiscFeeBasis : IntField
    {
        public MiscFeeBasis()
            :base(Tags.MiscFeeBasis) {}
        public MiscFeeBasis(int val)
            :base(Tags.MiscFeeBasis, val) {}


        // Field Enumerations
        public const int ABSOLUTE = 0;
        public const int PER_UNIT = 1;
        public const int PERCENTAGE = 2;
    }


    /// <summary>
    /// TotNoAllocs Field
    /// </summary>/
    public sealed class TotNoAllocs : IntField
    {
        public TotNoAllocs()
            :base(Tags.TotNoAllocs) {}
        public TotNoAllocs(int val)
            :base(Tags.TotNoAllocs, val) {}

    }


    /// <summary>
    /// LastFragment Field
    /// </summary>/
    public sealed class LastFragment : BooleanField
    {
        public LastFragment()
            :base(Tags.LastFragment) {}
        public LastFragment(Boolean val)
            :base(Tags.LastFragment, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// CollReqID Field
    /// </summary>/
    public sealed class CollReqID : StringField
    {
        public CollReqID()
            :base(Tags.CollReqID) {}
        public CollReqID(string val)
            :base(Tags.CollReqID, val) {}

    }


    /// <summary>
    /// CollAsgnReason Field
    /// </summary>/
    public sealed class CollAsgnReason : IntField
    {
        public CollAsgnReason()
            :base(Tags.CollAsgnReason) {}
        public CollAsgnReason(int val)
            :base(Tags.CollAsgnReason, val) {}


        // Field Enumerations
        public const int INITIAL = 0;
        public const int SCHEDULED = 1;
        public const int TIME_WARNING = 2;
        public const int MARGIN_DEFICIENCY = 3;
        public const int MARGIN_EXCESS = 4;
        public const int FORWARD_COLLATERAL_DEMAND = 5;
        public const int EVENT_OF_DEFAULT = 6;
        public const int ADVERSE_TAX_EVENT = 7;
    }


    /// <summary>
    /// CollInquiryQualifier Field
    /// </summary>/
    public sealed class CollInquiryQualifier : IntField
    {
        public CollInquiryQualifier()
            :base(Tags.CollInquiryQualifier) {}
        public CollInquiryQualifier(int val)
            :base(Tags.CollInquiryQualifier, val) {}


        // Field Enumerations
        public const int TRADE_DATE = 0;
        public const int GC_INSTRUMENT = 1;
        public const int COLLATERAL_INSTRUMENT = 2;
        public const int SUBSTITUTION_ELIGIBLE = 3;
        public const int NOT_ASSIGNED = 4;
        public const int PARTIALLY_ASSIGNED = 5;
        public const int FULLY_ASSIGNED = 6;
        public const int OUTSTANDING_TRADES = 7;
    }


    /// <summary>
    /// NoTrades Field
    /// </summary>/
    public sealed class NoTrades : IntField
    {
        public NoTrades()
            :base(Tags.NoTrades) {}
        public NoTrades(int val)
            :base(Tags.NoTrades, val) {}

    }


    /// <summary>
    /// MarginRatio Field
    /// </summary>/
    public sealed class MarginRatio : DecimalField
    {
        public MarginRatio()
            :base(Tags.MarginRatio) {}
        public MarginRatio(Decimal val)
            :base(Tags.MarginRatio, val) {}

    }


    /// <summary>
    /// MarginExcess Field
    /// </summary>/
    public sealed class MarginExcess : DecimalField
    {
        public MarginExcess()
            :base(Tags.MarginExcess) {}
        public MarginExcess(Decimal val)
            :base(Tags.MarginExcess, val) {}

    }


    /// <summary>
    /// TotalNetValue Field
    /// </summary>/
    public sealed class TotalNetValue : DecimalField
    {
        public TotalNetValue()
            :base(Tags.TotalNetValue) {}
        public TotalNetValue(Decimal val)
            :base(Tags.TotalNetValue, val) {}

    }


    /// <summary>
    /// CashOutstanding Field
    /// </summary>/
    public sealed class CashOutstanding : DecimalField
    {
        public CashOutstanding()
            :base(Tags.CashOutstanding) {}
        public CashOutstanding(Decimal val)
            :base(Tags.CashOutstanding, val) {}

    }


    /// <summary>
    /// CollAsgnID Field
    /// </summary>/
    public sealed class CollAsgnID : StringField
    {
        public CollAsgnID()
            :base(Tags.CollAsgnID) {}
        public CollAsgnID(string val)
            :base(Tags.CollAsgnID, val) {}

    }


    /// <summary>
    /// CollAsgnTransType Field
    /// </summary>/
    public sealed class CollAsgnTransType : IntField
    {
        public CollAsgnTransType()
            :base(Tags.CollAsgnTransType) {}
        public CollAsgnTransType(int val)
            :base(Tags.CollAsgnTransType, val) {}


        // Field Enumerations
        public const int NEW = 0;
        public const int REPLACE = 1;
        public const int CANCEL = 2;
        public const int RELEASE = 3;
        public const int REVERSE = 4;
    }


    /// <summary>
    /// CollRespID Field
    /// </summary>/
    public sealed class CollRespID : StringField
    {
        public CollRespID()
            :base(Tags.CollRespID) {}
        public CollRespID(string val)
            :base(Tags.CollRespID, val) {}

    }


    /// <summary>
    /// CollAsgnRespType Field
    /// </summary>/
    public sealed class CollAsgnRespType : IntField
    {
        public CollAsgnRespType()
            :base(Tags.CollAsgnRespType) {}
        public CollAsgnRespType(int val)
            :base(Tags.CollAsgnRespType, val) {}


        // Field Enumerations
        public const int RECEIVED = 0;
        public const int ACCEPTED = 1;
        public const int DECLINED = 2;
        public const int REJECTED = 3;
    }


    /// <summary>
    /// CollAsgnRejectReason Field
    /// </summary>/
    public sealed class CollAsgnRejectReason : IntField
    {
        public CollAsgnRejectReason()
            :base(Tags.CollAsgnRejectReason) {}
        public CollAsgnRejectReason(int val)
            :base(Tags.CollAsgnRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_DEAL = 0;
        public const int UNKNOWN_OR_INVALID_INSTRUMENT = 1;
        public const int UNAUTHORIZED_TRANSACTION = 2;
        public const int INSUFFICIENT_COLLATERAL = 3;
        public const int INVALID_TYPE_OF_COLLATERAL = 4;
        public const int EXCESSIVE_SUBSTITUTION = 5;
        public const int OTHER = 99;
    }


    /// <summary>
    /// CollAsgnRefID Field
    /// </summary>/
    public sealed class CollAsgnRefID : StringField
    {
        public CollAsgnRefID()
            :base(Tags.CollAsgnRefID) {}
        public CollAsgnRefID(string val)
            :base(Tags.CollAsgnRefID, val) {}

    }


    /// <summary>
    /// CollRptID Field
    /// </summary>/
    public sealed class CollRptID : StringField
    {
        public CollRptID()
            :base(Tags.CollRptID) {}
        public CollRptID(string val)
            :base(Tags.CollRptID, val) {}

    }


    /// <summary>
    /// CollInquiryID Field
    /// </summary>/
    public sealed class CollInquiryID : StringField
    {
        public CollInquiryID()
            :base(Tags.CollInquiryID) {}
        public CollInquiryID(string val)
            :base(Tags.CollInquiryID, val) {}

    }


    /// <summary>
    /// CollStatus Field
    /// </summary>/
    public sealed class CollStatus : IntField
    {
        public CollStatus()
            :base(Tags.CollStatus) {}
        public CollStatus(int val)
            :base(Tags.CollStatus, val) {}


        // Field Enumerations
        public const int UNASSIGNED = 0;
        public const int PARTIALLY_ASSIGNED = 1;
        public const int ASSIGNMENT_PROPOSED = 2;
        public const int ASSIGNED = 3;
        public const int CHALLENGED = 4;
    }


    /// <summary>
    /// TotNumReports Field
    /// </summary>/
    public sealed class TotNumReports : IntField
    {
        public TotNumReports()
            :base(Tags.TotNumReports) {}
        public TotNumReports(int val)
            :base(Tags.TotNumReports, val) {}

    }


    /// <summary>
    /// LastRptRequested Field
    /// </summary>/
    public sealed class LastRptRequested : BooleanField
    {
        public LastRptRequested()
            :base(Tags.LastRptRequested) {}
        public LastRptRequested(Boolean val)
            :base(Tags.LastRptRequested, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// AgreementDesc Field
    /// </summary>/
    public sealed class AgreementDesc : StringField
    {
        public AgreementDesc()
            :base(Tags.AgreementDesc) {}
        public AgreementDesc(string val)
            :base(Tags.AgreementDesc, val) {}

    }


    /// <summary>
    /// AgreementID Field
    /// </summary>/
    public sealed class AgreementID : StringField
    {
        public AgreementID()
            :base(Tags.AgreementID) {}
        public AgreementID(string val)
            :base(Tags.AgreementID, val) {}

    }


    /// <summary>
    /// AgreementDate Field
    /// </summary>/
    public sealed class AgreementDate : StringField
    {
        public AgreementDate()
            :base(Tags.AgreementDate) {}
        public AgreementDate(string val)
            :base(Tags.AgreementDate, val) {}

    }


    /// <summary>
    /// StartDate Field
    /// </summary>/
    public sealed class StartDate : StringField
    {
        public StartDate()
            :base(Tags.StartDate) {}
        public StartDate(string val)
            :base(Tags.StartDate, val) {}

    }


    /// <summary>
    /// EndDate Field
    /// </summary>/
    public sealed class EndDate : StringField
    {
        public EndDate()
            :base(Tags.EndDate) {}
        public EndDate(string val)
            :base(Tags.EndDate, val) {}

    }


    /// <summary>
    /// AgreementCurrency Field
    /// </summary>/
    public sealed class AgreementCurrency : DecimalField
    {
        public AgreementCurrency()
            :base(Tags.AgreementCurrency) {}
        public AgreementCurrency(Decimal val)
            :base(Tags.AgreementCurrency, val) {}

    }


    /// <summary>
    /// DeliveryType Field
    /// </summary>/
    public sealed class DeliveryType : IntField
    {
        public DeliveryType()
            :base(Tags.DeliveryType) {}
        public DeliveryType(int val)
            :base(Tags.DeliveryType, val) {}


        // Field Enumerations
        public const int VERSUS_PAYMENT_DELIVER = 0;
        public const int FREE_DELIVER = 1;
        public const int TRI_PARTY = 2;
        public const int HOLD_IN_CUSTODY = 3;
    }


    /// <summary>
    /// EndAccruedInterestAmt Field
    /// </summary>/
    public sealed class EndAccruedInterestAmt : DecimalField
    {
        public EndAccruedInterestAmt()
            :base(Tags.EndAccruedInterestAmt) {}
        public EndAccruedInterestAmt(Decimal val)
            :base(Tags.EndAccruedInterestAmt, val) {}

    }


    /// <summary>
    /// StartCash Field
    /// </summary>/
    public sealed class StartCash : DecimalField
    {
        public StartCash()
            :base(Tags.StartCash) {}
        public StartCash(Decimal val)
            :base(Tags.StartCash, val) {}

    }


    /// <summary>
    /// EndCash Field
    /// </summary>/
    public sealed class EndCash : DecimalField
    {
        public EndCash()
            :base(Tags.EndCash) {}
        public EndCash(Decimal val)
            :base(Tags.EndCash, val) {}

    }


    /// <summary>
    /// UserRequestID Field
    /// </summary>/
    public sealed class UserRequestID : StringField
    {
        public UserRequestID()
            :base(Tags.UserRequestID) {}
        public UserRequestID(string val)
            :base(Tags.UserRequestID, val) {}

    }


    /// <summary>
    /// UserRequestType Field
    /// </summary>/
    public sealed class UserRequestType : IntField
    {
        public UserRequestType()
            :base(Tags.UserRequestType) {}
        public UserRequestType(int val)
            :base(Tags.UserRequestType, val) {}


        // Field Enumerations
        public const int LOG_ON_USER = 1;
        public const int LOG_OFF_USER = 2;
        public const int CHANGE_PASSWORD_FOR_USER = 3;
        public const int REQUEST_INDIVIDUAL_USER_STATUS = 4;
    }


    /// <summary>
    /// NewPassword Field
    /// </summary>/
    public sealed class NewPassword : StringField
    {
        public NewPassword()
            :base(Tags.NewPassword) {}
        public NewPassword(string val)
            :base(Tags.NewPassword, val) {}

    }


    /// <summary>
    /// UserStatus Field
    /// </summary>/
    public sealed class UserStatus : IntField
    {
        public UserStatus()
            :base(Tags.UserStatus) {}
        public UserStatus(int val)
            :base(Tags.UserStatus, val) {}


        // Field Enumerations
        public const int LOGGED_IN = 1;
        public const int NOT_LOGGED_IN = 2;
        public const int USER_NOT_RECOGNISED = 3;
        public const int PASSWORD_INCORRECT = 4;
        public const int PASSWORD_CHANGED = 5;
        public const int OTHER = 6;
    }


    /// <summary>
    /// UserStatusText Field
    /// </summary>/
    public sealed class UserStatusText : StringField
    {
        public UserStatusText()
            :base(Tags.UserStatusText) {}
        public UserStatusText(string val)
            :base(Tags.UserStatusText, val) {}

    }


    /// <summary>
    /// StatusValue Field
    /// </summary>/
    public sealed class StatusValue : IntField
    {
        public StatusValue()
            :base(Tags.StatusValue) {}
        public StatusValue(int val)
            :base(Tags.StatusValue, val) {}


        // Field Enumerations
        public const int CONNECTED = 1;
        public const int NOT_CONNECTED_2 = 2;
        public const int NOT_CONNECTED_3 = 3;
        public const int IN_PROCESS = 4;
    }


    /// <summary>
    /// StatusText Field
    /// </summary>/
    public sealed class StatusText : StringField
    {
        public StatusText()
            :base(Tags.StatusText) {}
        public StatusText(string val)
            :base(Tags.StatusText, val) {}

    }


    /// <summary>
    /// RefCompID Field
    /// </summary>/
    public sealed class RefCompID : StringField
    {
        public RefCompID()
            :base(Tags.RefCompID) {}
        public RefCompID(string val)
            :base(Tags.RefCompID, val) {}

    }


    /// <summary>
    /// RefSubID Field
    /// </summary>/
    public sealed class RefSubID : StringField
    {
        public RefSubID()
            :base(Tags.RefSubID) {}
        public RefSubID(string val)
            :base(Tags.RefSubID, val) {}

    }


    /// <summary>
    /// NetworkResponseID Field
    /// </summary>/
    public sealed class NetworkResponseID : StringField
    {
        public NetworkResponseID()
            :base(Tags.NetworkResponseID) {}
        public NetworkResponseID(string val)
            :base(Tags.NetworkResponseID, val) {}

    }


    /// <summary>
    /// NetworkRequestID Field
    /// </summary>/
    public sealed class NetworkRequestID : StringField
    {
        public NetworkRequestID()
            :base(Tags.NetworkRequestID) {}
        public NetworkRequestID(string val)
            :base(Tags.NetworkRequestID, val) {}

    }


    /// <summary>
    /// LastNetworkResponseID Field
    /// </summary>/
    public sealed class LastNetworkResponseID : StringField
    {
        public LastNetworkResponseID()
            :base(Tags.LastNetworkResponseID) {}
        public LastNetworkResponseID(string val)
            :base(Tags.LastNetworkResponseID, val) {}

    }


    /// <summary>
    /// NetworkRequestType Field
    /// </summary>/
    public sealed class NetworkRequestType : IntField
    {
        public NetworkRequestType()
            :base(Tags.NetworkRequestType) {}
        public NetworkRequestType(int val)
            :base(Tags.NetworkRequestType, val) {}


        // Field Enumerations
        public const int SNAPSHOT = 1;
        public const int SUBSCRIBE = 2;
        public const int STOP_SUBSCRIBING = 4;
        public const int LEVEL_OF_DETAIL_THEN_NOCOMPIDS_BECOMES_REQUIRED = 8;
    }


    /// <summary>
    /// NoCompIDs Field
    /// </summary>/
    public sealed class NoCompIDs : IntField
    {
        public NoCompIDs()
            :base(Tags.NoCompIDs) {}
        public NoCompIDs(int val)
            :base(Tags.NoCompIDs, val) {}

    }


    /// <summary>
    /// NetworkStatusResponseType Field
    /// </summary>/
    public sealed class NetworkStatusResponseType : IntField
    {
        public NetworkStatusResponseType()
            :base(Tags.NetworkStatusResponseType) {}
        public NetworkStatusResponseType(int val)
            :base(Tags.NetworkStatusResponseType, val) {}


        // Field Enumerations
        public const int FULL = 1;
        public const int INCREMENTAL_UPDATE = 2;
    }


    /// <summary>
    /// NoCollInquiryQualifier Field
    /// </summary>/
    public sealed class NoCollInquiryQualifier : IntField
    {
        public NoCollInquiryQualifier()
            :base(Tags.NoCollInquiryQualifier) {}
        public NoCollInquiryQualifier(int val)
            :base(Tags.NoCollInquiryQualifier, val) {}

    }


    /// <summary>
    /// TrdRptStatus Field
    /// </summary>/
    public sealed class TrdRptStatus : IntField
    {
        public TrdRptStatus()
            :base(Tags.TrdRptStatus) {}
        public TrdRptStatus(int val)
            :base(Tags.TrdRptStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int REJECTED = 1;
        public const int ACCEPTED_WITH_ERRORS = 3;
    }


    /// <summary>
    /// AffirmStatus Field
    /// </summary>/
    public sealed class AffirmStatus : IntField
    {
        public AffirmStatus()
            :base(Tags.AffirmStatus) {}
        public AffirmStatus(int val)
            :base(Tags.AffirmStatus, val) {}


        // Field Enumerations
        public const int RECEIVED = 1;
        public const int CONFIRM_REJECTED_IE_NOT_AFFIRMED = 2;
        public const int AFFIRMED = 3;
    }


    /// <summary>
    /// UnderlyingStrikeCurrency Field
    /// </summary>/
    public sealed class UnderlyingStrikeCurrency : DecimalField
    {
        public UnderlyingStrikeCurrency()
            :base(Tags.UnderlyingStrikeCurrency) {}
        public UnderlyingStrikeCurrency(Decimal val)
            :base(Tags.UnderlyingStrikeCurrency, val) {}

    }


    /// <summary>
    /// LegStrikeCurrency Field
    /// </summary>/
    public sealed class LegStrikeCurrency : DecimalField
    {
        public LegStrikeCurrency()
            :base(Tags.LegStrikeCurrency) {}
        public LegStrikeCurrency(Decimal val)
            :base(Tags.LegStrikeCurrency, val) {}

    }


    /// <summary>
    /// TimeBracket Field
    /// </summary>/
    public sealed class TimeBracket : StringField
    {
        public TimeBracket()
            :base(Tags.TimeBracket) {}
        public TimeBracket(string val)
            :base(Tags.TimeBracket, val) {}

    }


    /// <summary>
    /// CollAction Field
    /// </summary>/
    public sealed class CollAction : IntField
    {
        public CollAction()
            :base(Tags.CollAction) {}
        public CollAction(int val)
            :base(Tags.CollAction, val) {}


        // Field Enumerations
        public const int RETAIN = 0;
        public const int ADD = 1;
        public const int REMOVE = 2;
    }


    /// <summary>
    /// CollInquiryStatus Field
    /// </summary>/
    public sealed class CollInquiryStatus : IntField
    {
        public CollInquiryStatus()
            :base(Tags.CollInquiryStatus) {}
        public CollInquiryStatus(int val)
            :base(Tags.CollInquiryStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int ACCEPTED_WITH_WARNINGS = 1;
        public const int COMPLETED = 2;
        public const int COMPLETED_WITH_WARNINGS = 3;
        public const int REJECTED = 4;
    }


    /// <summary>
    /// CollInquiryResult Field
    /// </summary>/
    public sealed class CollInquiryResult : IntField
    {
        public CollInquiryResult()
            :base(Tags.CollInquiryResult) {}
        public CollInquiryResult(int val)
            :base(Tags.CollInquiryResult, val) {}


        // Field Enumerations
        public const int SUCCESSFUL = 0;
        public const int INVALID_OR_UNKNOWN_INSTRUMENT = 1;
        public const int INVALID_OR_UNKNOWN_COLLATERAL_TYPE = 2;
        public const int INVALID_PARTIES = 3;
        public const int INVALID_TRANSPORT_TYPE_REQUESTED = 4;
        public const int INVALID_DESTINATION_REQUESTED = 5;
        public const int NO_COLLATERAL_FOUND_FOR_THE_TRADE_SPECIFIED = 6;
        public const int NO_COLLATERAL_FOUND_FOR_THE_ORDER_SPECIFIED = 7;
        public const int COLLATERAL_INQUIRY_TYPE_NOT_SUPPORTED = 8;
        public const int UNAUTHORIZED_FOR_COLLATERAL_INQUIRY = 9;
        public const int OTHER = 99;
    }


    /// <summary>
    /// StrikeCurrency Field
    /// </summary>/
    public sealed class StrikeCurrency : DecimalField
    {
        public StrikeCurrency()
            :base(Tags.StrikeCurrency) {}
        public StrikeCurrency(Decimal val)
            :base(Tags.StrikeCurrency, val) {}

    }


    /// <summary>
    /// NoNested3PartyIDs Field
    /// </summary>/
    public sealed class NoNested3PartyIDs : IntField
    {
        public NoNested3PartyIDs()
            :base(Tags.NoNested3PartyIDs) {}
        public NoNested3PartyIDs(int val)
            :base(Tags.NoNested3PartyIDs, val) {}

    }


    /// <summary>
    /// Nested3PartyID Field
    /// </summary>/
    public sealed class Nested3PartyID : StringField
    {
        public Nested3PartyID()
            :base(Tags.Nested3PartyID) {}
        public Nested3PartyID(string val)
            :base(Tags.Nested3PartyID, val) {}

    }


    /// <summary>
    /// Nested3PartyIDSource Field
    /// </summary>/
    public sealed class Nested3PartyIDSource : CharField
    {
        public Nested3PartyIDSource()
            :base(Tags.Nested3PartyIDSource) {}
        public Nested3PartyIDSource(char val)
            :base(Tags.Nested3PartyIDSource, val) {}

    }


    /// <summary>
    /// Nested3PartyRole Field
    /// </summary>/
    public sealed class Nested3PartyRole : IntField
    {
        public Nested3PartyRole()
            :base(Tags.Nested3PartyRole) {}
        public Nested3PartyRole(int val)
            :base(Tags.Nested3PartyRole, val) {}

    }


    /// <summary>
    /// NoNested3PartySubIDs Field
    /// </summary>/
    public sealed class NoNested3PartySubIDs : IntField
    {
        public NoNested3PartySubIDs()
            :base(Tags.NoNested3PartySubIDs) {}
        public NoNested3PartySubIDs(int val)
            :base(Tags.NoNested3PartySubIDs, val) {}

    }


    /// <summary>
    /// Nested3PartySubID Field
    /// </summary>/
    public sealed class Nested3PartySubID : StringField
    {
        public Nested3PartySubID()
            :base(Tags.Nested3PartySubID) {}
        public Nested3PartySubID(string val)
            :base(Tags.Nested3PartySubID, val) {}

    }


    /// <summary>
    /// Nested3PartySubIDType Field
    /// </summary>/
    public sealed class Nested3PartySubIDType : IntField
    {
        public Nested3PartySubIDType()
            :base(Tags.Nested3PartySubIDType) {}
        public Nested3PartySubIDType(int val)
            :base(Tags.Nested3PartySubIDType, val) {}

    }


    /// <summary>
    /// LegContractSettlMonth Field
    /// </summary>/
    public sealed class LegContractSettlMonth : StringField
    {
        public LegContractSettlMonth()
            :base(Tags.LegContractSettlMonth) {}
        public LegContractSettlMonth(string val)
            :base(Tags.LegContractSettlMonth, val) {}

    }


    /// <summary>
    /// LegInterestAccrualDate Field
    /// </summary>/
    public sealed class LegInterestAccrualDate : StringField
    {
        public LegInterestAccrualDate()
            :base(Tags.LegInterestAccrualDate) {}
        public LegInterestAccrualDate(string val)
            :base(Tags.LegInterestAccrualDate, val) {}

    }


    /// <summary>
    /// IOIID Field
    /// </summary>/
    public sealed class IOIID : StringField
    {
        public IOIID()
            :base(Tags.IOIID) {}
        public IOIID(string val)
            :base(Tags.IOIID, val) {}

    }


    /// <summary>
    /// NoLinesOfText Field
    /// </summary>/
    public sealed class NoLinesOfText : IntField
    {
        public NoLinesOfText()
            :base(Tags.NoLinesOfText) {}
        public NoLinesOfText(int val)
            :base(Tags.NoLinesOfText, val) {}

    }


    /// <summary>
    /// HaltReasonChar Field
    /// </summary>/
    public sealed class HaltReasonChar : CharField
    {
        public HaltReasonChar()
            :base(Tags.HaltReasonChar) {}
        public HaltReasonChar(char val)
            :base(Tags.HaltReasonChar, val) {}


        // Field Enumerations
        public const char NEWS_DISSEMINATION = 'D';
        public const char ORDER_INFLUX = 'E';
        public const char ORDER_IMBALANCE = 'I';
        public const char ADDITIONAL_INFORMATION = 'M';
        public const char NEW_PENDING = 'P';
        public const char EQUIPMENT_CHANGEOVER = 'X';
    }


    /// <summary>
    /// NoStrategyParameters Field
    /// </summary>/
    public sealed class NoStrategyParameters : IntField
    {
        public NoStrategyParameters()
            :base(Tags.NoStrategyParameters) {}
        public NoStrategyParameters(int val)
            :base(Tags.NoStrategyParameters, val) {}

    }


    /// <summary>
    /// StrategyParameterName Field
    /// </summary>/
    public sealed class StrategyParameterName : StringField
    {
        public StrategyParameterName()
            :base(Tags.StrategyParameterName) {}
        public StrategyParameterName(string val)
            :base(Tags.StrategyParameterName, val) {}

    }


    /// <summary>
    /// StrategyParameterType Field
    /// </summary>/
    public sealed class StrategyParameterType : IntField
    {
        public StrategyParameterType()
            :base(Tags.StrategyParameterType) {}
        public StrategyParameterType(int val)
            :base(Tags.StrategyParameterType, val) {}


        // Field Enumerations
        public const int INT = 1;
        public const int LENGTH = 2;
        public const int NUMINGROUP = 3;
        public const int SEQNUM = 4;
        public const int TAGNUM = 5;
        public const int FLOAT = 6;
        public const int QTY = 7;
        public const int PRICE = 8;
        public const int PRICEOFFSET = 9;
        public const int AMT = 10;
        public const int PERCENTAGE = 11;
        public const int CHAR = 12;
        public const int BOOLEAN = 13;
        public const int STRING = 14;
        public const int MULTIPLECHARVALUE = 15;
        public const int CURRENCY = 16;
        public const int EXCHANGE = 17;
        public const int MONTH_YEAR = 18;
        public const int UTCTIMESTAMP = 19;
        public const int UTCTIMEONLY = 20;
        public const int LOCALMKTTIME = 21;
        public const int UTCDATE = 22;
        public const int DATA = 23;
        public const int MULTIPLESTRINGVALUE = 24;
    }


    /// <summary>
    /// StrategyParameterValue Field
    /// </summary>/
    public sealed class StrategyParameterValue : StringField
    {
        public StrategyParameterValue()
            :base(Tags.StrategyParameterValue) {}
        public StrategyParameterValue(string val)
            :base(Tags.StrategyParameterValue, val) {}

    }


    /// <summary>
    /// HostCrossID Field
    /// </summary>/
    public sealed class HostCrossID : StringField
    {
        public HostCrossID()
            :base(Tags.HostCrossID) {}
        public HostCrossID(string val)
            :base(Tags.HostCrossID, val) {}

    }


    /// <summary>
    /// SideTimeInForce Field
    /// </summary>/
    public sealed class SideTimeInForce : DateTimeField
    {
        public SideTimeInForce()
            :base(Tags.SideTimeInForce) {}
        public SideTimeInForce(DateTime val)
            :base(Tags.SideTimeInForce, val) {}

    }


    /// <summary>
    /// MDReportID Field
    /// </summary>/
    public sealed class MDReportID : IntField
    {
        public MDReportID()
            :base(Tags.MDReportID) {}
        public MDReportID(int val)
            :base(Tags.MDReportID, val) {}

    }


    /// <summary>
    /// SecurityReportID Field
    /// </summary>/
    public sealed class SecurityReportID : IntField
    {
        public SecurityReportID()
            :base(Tags.SecurityReportID) {}
        public SecurityReportID(int val)
            :base(Tags.SecurityReportID, val) {}

    }


    /// <summary>
    /// SecurityStatus Field
    /// </summary>/
    public sealed class SecurityStatus : StringField
    {
        public SecurityStatus()
            :base(Tags.SecurityStatus) {}
        public SecurityStatus(string val)
            :base(Tags.SecurityStatus, val) {}


        // Field Enumerations
        public const string ACTIVE = "1";
        public const string INACTIVE = "2";
    }


    /// <summary>
    /// SettleOnOpenFlag Field
    /// </summary>/
    public sealed class SettleOnOpenFlag : StringField
    {
        public SettleOnOpenFlag()
            :base(Tags.SettleOnOpenFlag) {}
        public SettleOnOpenFlag(string val)
            :base(Tags.SettleOnOpenFlag, val) {}

    }


    /// <summary>
    /// StrikeMultiplier Field
    /// </summary>/
    public sealed class StrikeMultiplier : DecimalField
    {
        public StrikeMultiplier()
            :base(Tags.StrikeMultiplier) {}
        public StrikeMultiplier(Decimal val)
            :base(Tags.StrikeMultiplier, val) {}

    }


    /// <summary>
    /// StrikeValue Field
    /// </summary>/
    public sealed class StrikeValue : DecimalField
    {
        public StrikeValue()
            :base(Tags.StrikeValue) {}
        public StrikeValue(Decimal val)
            :base(Tags.StrikeValue, val) {}

    }


    /// <summary>
    /// MinPriceIncrement Field
    /// </summary>/
    public sealed class MinPriceIncrement : DecimalField
    {
        public MinPriceIncrement()
            :base(Tags.MinPriceIncrement) {}
        public MinPriceIncrement(Decimal val)
            :base(Tags.MinPriceIncrement, val) {}

    }


    /// <summary>
    /// PositionLimit Field
    /// </summary>/
    public sealed class PositionLimit : IntField
    {
        public PositionLimit()
            :base(Tags.PositionLimit) {}
        public PositionLimit(int val)
            :base(Tags.PositionLimit, val) {}

    }


    /// <summary>
    /// NTPositionLimit Field
    /// </summary>/
    public sealed class NTPositionLimit : IntField
    {
        public NTPositionLimit()
            :base(Tags.NTPositionLimit) {}
        public NTPositionLimit(int val)
            :base(Tags.NTPositionLimit, val) {}

    }


    /// <summary>
    /// UnderlyingAllocationPercent Field
    /// </summary>/
    public sealed class UnderlyingAllocationPercent : DecimalField
    {
        public UnderlyingAllocationPercent()
            :base(Tags.UnderlyingAllocationPercent) {}
        public UnderlyingAllocationPercent(Decimal val)
            :base(Tags.UnderlyingAllocationPercent, val) {}

    }


    /// <summary>
    /// UnderlyingCashAmount Field
    /// </summary>/
    public sealed class UnderlyingCashAmount : DecimalField
    {
        public UnderlyingCashAmount()
            :base(Tags.UnderlyingCashAmount) {}
        public UnderlyingCashAmount(Decimal val)
            :base(Tags.UnderlyingCashAmount, val) {}

    }


    /// <summary>
    /// UnderlyingCashType Field
    /// </summary>/
    public sealed class UnderlyingCashType : StringField
    {
        public UnderlyingCashType()
            :base(Tags.UnderlyingCashType) {}
        public UnderlyingCashType(string val)
            :base(Tags.UnderlyingCashType, val) {}


        // Field Enumerations
        public const string FIXED = "FIXED";
        public const string DIFF = "DIFF";
    }


    /// <summary>
    /// UnderlyingSettlementType Field
    /// </summary>/
    public sealed class UnderlyingSettlementType : IntField
    {
        public UnderlyingSettlementType()
            :base(Tags.UnderlyingSettlementType) {}
        public UnderlyingSettlementType(int val)
            :base(Tags.UnderlyingSettlementType, val) {}


        // Field Enumerations
        public const int T_PLUS_1 = 2;
        public const int T_PLUS_3 = 4;
        public const int T_PLUS_4 = 5;
    }


    /// <summary>
    /// QuantityDate Field
    /// </summary>/
    public sealed class QuantityDate : StringField
    {
        public QuantityDate()
            :base(Tags.QuantityDate) {}
        public QuantityDate(string val)
            :base(Tags.QuantityDate, val) {}

    }


    /// <summary>
    /// ContIntRptID Field
    /// </summary>/
    public sealed class ContIntRptID : StringField
    {
        public ContIntRptID()
            :base(Tags.ContIntRptID) {}
        public ContIntRptID(string val)
            :base(Tags.ContIntRptID, val) {}

    }


    /// <summary>
    /// LateIndicator Field
    /// </summary>/
    public sealed class LateIndicator : BooleanField
    {
        public LateIndicator()
            :base(Tags.LateIndicator) {}
        public LateIndicator(Boolean val)
            :base(Tags.LateIndicator, val) {}

    }


    /// <summary>
    /// InputSource Field
    /// </summary>/
    public sealed class InputSource : StringField
    {
        public InputSource()
            :base(Tags.InputSource) {}
        public InputSource(string val)
            :base(Tags.InputSource, val) {}

    }


    /// <summary>
    /// SecurityUpdateAction Field
    /// </summary>/
    public sealed class SecurityUpdateAction : CharField
    {
        public SecurityUpdateAction()
            :base(Tags.SecurityUpdateAction) {}
        public SecurityUpdateAction(char val)
            :base(Tags.SecurityUpdateAction, val) {}


        // Field Enumerations
        public const char ADD = 'A';
        public const char DELETE = 'D';
        public const char MODIFY = 'M';
    }


    /// <summary>
    /// NoExpiration Field
    /// </summary>/
    public sealed class NoExpiration : IntField
    {
        public NoExpiration()
            :base(Tags.NoExpiration) {}
        public NoExpiration(int val)
            :base(Tags.NoExpiration, val) {}

    }


    /// <summary>
    /// ExpType Field
    /// </summary>/
    public sealed class ExpType : IntField
    {
        public ExpType()
            :base(Tags.ExpType) {}
        public ExpType(int val)
            :base(Tags.ExpType, val) {}


        // Field Enumerations
        public const int AUTO_EXERCISE = 1;
        public const int NON_AUTO_EXERCISE = 2;
        public const int FINAL_WILL_BE_EXERCISED = 3;
        public const int CONTRARY_INTENTION = 4;
        public const int DIFFERENCE = 5;
    }


    /// <summary>
    /// ExpQty Field
    /// </summary>/
    public sealed class ExpQty : DecimalField
    {
        public ExpQty()
            :base(Tags.ExpQty) {}
        public ExpQty(Decimal val)
            :base(Tags.ExpQty, val) {}

    }


    /// <summary>
    /// NoUnderlyingAmounts Field
    /// </summary>/
    public sealed class NoUnderlyingAmounts : IntField
    {
        public NoUnderlyingAmounts()
            :base(Tags.NoUnderlyingAmounts) {}
        public NoUnderlyingAmounts(int val)
            :base(Tags.NoUnderlyingAmounts, val) {}

    }


    /// <summary>
    /// UnderlyingPayAmount Field
    /// </summary>/
    public sealed class UnderlyingPayAmount : DecimalField
    {
        public UnderlyingPayAmount()
            :base(Tags.UnderlyingPayAmount) {}
        public UnderlyingPayAmount(Decimal val)
            :base(Tags.UnderlyingPayAmount, val) {}

    }


    /// <summary>
    /// UnderlyingCollectAmount Field
    /// </summary>/
    public sealed class UnderlyingCollectAmount : DecimalField
    {
        public UnderlyingCollectAmount()
            :base(Tags.UnderlyingCollectAmount) {}
        public UnderlyingCollectAmount(Decimal val)
            :base(Tags.UnderlyingCollectAmount, val) {}

    }


    /// <summary>
    /// UnderlyingSettlementDate Field
    /// </summary>/
    public sealed class UnderlyingSettlementDate : StringField
    {
        public UnderlyingSettlementDate()
            :base(Tags.UnderlyingSettlementDate) {}
        public UnderlyingSettlementDate(string val)
            :base(Tags.UnderlyingSettlementDate, val) {}

    }


    /// <summary>
    /// UnderlyingSettlementStatus Field
    /// </summary>/
    public sealed class UnderlyingSettlementStatus : StringField
    {
        public UnderlyingSettlementStatus()
            :base(Tags.UnderlyingSettlementStatus) {}
        public UnderlyingSettlementStatus(string val)
            :base(Tags.UnderlyingSettlementStatus, val) {}

    }


    /// <summary>
    /// SecondaryIndividualAllocID Field
    /// </summary>/
    public sealed class SecondaryIndividualAllocID : StringField
    {
        public SecondaryIndividualAllocID()
            :base(Tags.SecondaryIndividualAllocID) {}
        public SecondaryIndividualAllocID(string val)
            :base(Tags.SecondaryIndividualAllocID, val) {}

    }


    /// <summary>
    /// LegReportID Field
    /// </summary>/
    public sealed class LegReportID : StringField
    {
        public LegReportID()
            :base(Tags.LegReportID) {}
        public LegReportID(string val)
            :base(Tags.LegReportID, val) {}

    }


    /// <summary>
    /// RndPx Field
    /// </summary>/
    public sealed class RndPx : DecimalField
    {
        public RndPx()
            :base(Tags.RndPx) {}
        public RndPx(Decimal val)
            :base(Tags.RndPx, val) {}

    }


    /// <summary>
    /// IndividualAllocType Field
    /// </summary>/
    public sealed class IndividualAllocType : IntField
    {
        public IndividualAllocType()
            :base(Tags.IndividualAllocType) {}
        public IndividualAllocType(int val)
            :base(Tags.IndividualAllocType, val) {}


        // Field Enumerations
        public const int SUB_ALLOCATE = 1;
        public const int THIRD_PARTY_ALLOCATION = 2;
    }


    /// <summary>
    /// AllocCustomerCapacity Field
    /// </summary>/
    public sealed class AllocCustomerCapacity : StringField
    {
        public AllocCustomerCapacity()
            :base(Tags.AllocCustomerCapacity) {}
        public AllocCustomerCapacity(string val)
            :base(Tags.AllocCustomerCapacity, val) {}

    }


    /// <summary>
    /// TierCode Field
    /// </summary>/
    public sealed class TierCode : StringField
    {
        public TierCode()
            :base(Tags.TierCode) {}
        public TierCode(string val)
            :base(Tags.TierCode, val) {}

    }


    /// <summary>
    /// UnitOfMeasure Field
    /// </summary>/
    public sealed class UnitOfMeasure : StringField
    {
        public UnitOfMeasure()
            :base(Tags.UnitOfMeasure) {}
        public UnitOfMeasure(string val)
            :base(Tags.UnitOfMeasure, val) {}


        // Field Enumerations
        public const string MEGAWATT_HOURS = "MWh";
        public const string ONE_MILLION_BTU = "MMBtu";
        public const string BARRELS = "Bbl";
        public const string GALLONS = "Gal";
        public const string METRIC_TONS = "t";
        public const string TONS = "tn";
        public const string MILLION_BARRELS = "MMbbl";
        public const string POUNDS = "lbs";
        public const string TROY_OUNCES = "oz_tr";
        public const string US_DOLLARS = "USD";
        public const string BILLION_CUBIC_FEET = "Bcf";
        public const string BUSHELS = "Bu";
    }


    /// <summary>
    /// TimeUnit Field
    /// </summary>/
    public sealed class TimeUnit : StringField
    {
        public TimeUnit()
            :base(Tags.TimeUnit) {}
        public TimeUnit(string val)
            :base(Tags.TimeUnit, val) {}


        // Field Enumerations
        public const string SECOND = "S";
        public const string MINUTE = "Min";
        public const string HOUR = "H";
        public const string DAY = "D";
        public const string WEEK = "Wk";
        public const string MONTH = "Mo";
        public const string YEAR = "Yr";
    }


    /// <summary>
    /// UnderlyingUnitOfMeasure Field
    /// </summary>/
    public sealed class UnderlyingUnitOfMeasure : StringField
    {
        public UnderlyingUnitOfMeasure()
            :base(Tags.UnderlyingUnitOfMeasure) {}
        public UnderlyingUnitOfMeasure(string val)
            :base(Tags.UnderlyingUnitOfMeasure, val) {}

    }


    /// <summary>
    /// LegUnitOfMeasure Field
    /// </summary>/
    public sealed class LegUnitOfMeasure : StringField
    {
        public LegUnitOfMeasure()
            :base(Tags.LegUnitOfMeasure) {}
        public LegUnitOfMeasure(string val)
            :base(Tags.LegUnitOfMeasure, val) {}

    }


    /// <summary>
    /// UnderlyingTimeUnit Field
    /// </summary>/
    public sealed class UnderlyingTimeUnit : StringField
    {
        public UnderlyingTimeUnit()
            :base(Tags.UnderlyingTimeUnit) {}
        public UnderlyingTimeUnit(string val)
            :base(Tags.UnderlyingTimeUnit, val) {}

    }


    /// <summary>
    /// LegTimeUnit Field
    /// </summary>/
    public sealed class LegTimeUnit : StringField
    {
        public LegTimeUnit()
            :base(Tags.LegTimeUnit) {}
        public LegTimeUnit(string val)
            :base(Tags.LegTimeUnit, val) {}

    }


    /// <summary>
    /// AllocMethod Field
    /// </summary>/
    public sealed class AllocMethod : IntField
    {
        public AllocMethod()
            :base(Tags.AllocMethod) {}
        public AllocMethod(int val)
            :base(Tags.AllocMethod, val) {}


        // Field Enumerations
        public const int AUTOMATIC = 1;
        public const int GUARANTOR = 2;
        public const int MANUAL = 3;
    }


    /// <summary>
    /// TradeID Field
    /// </summary>/
    public sealed class TradeID : StringField
    {
        public TradeID()
            :base(Tags.TradeID) {}
        public TradeID(string val)
            :base(Tags.TradeID, val) {}

    }


    /// <summary>
    /// SideTradeReportID Field
    /// </summary>/
    public sealed class SideTradeReportID : StringField
    {
        public SideTradeReportID()
            :base(Tags.SideTradeReportID) {}
        public SideTradeReportID(string val)
            :base(Tags.SideTradeReportID, val) {}

    }


    /// <summary>
    /// SideFillStationCd Field
    /// </summary>/
    public sealed class SideFillStationCd : StringField
    {
        public SideFillStationCd()
            :base(Tags.SideFillStationCd) {}
        public SideFillStationCd(string val)
            :base(Tags.SideFillStationCd, val) {}

    }


    /// <summary>
    /// SideReasonCd Field
    /// </summary>/
    public sealed class SideReasonCd : StringField
    {
        public SideReasonCd()
            :base(Tags.SideReasonCd) {}
        public SideReasonCd(string val)
            :base(Tags.SideReasonCd, val) {}

    }


    /// <summary>
    /// SideTrdSubTyp Field
    /// </summary>/
    public sealed class SideTrdSubTyp : IntField
    {
        public SideTrdSubTyp()
            :base(Tags.SideTrdSubTyp) {}
        public SideTrdSubTyp(int val)
            :base(Tags.SideTrdSubTyp, val) {}


        // Field Enumerations
        public const int CMTA = 0;
        public const int INTERNAL_TRANSFER = 1;
        public const int EXTERNAL_TRANSFER = 2;
        public const int REJECT_FOR_SUBMITTING_TRADE = 3;
        public const int ADVISORY_FOR_CONTRA_SIDE = 4;
        public const int OFFSET_DUE_TO_AN_ALLOCATION = 5;
        public const int ONSET_DUE_TO_AN_ALLOCATION = 6;
        public const int DIFFERENTIAL_SPREAD = 7;
        public const int IMPLIED_SPREAD_LEG_EXECUTED_AGAINST_AN_OUTRIGHT = 8;
        public const int TRANSACTION_FROM_EXERCISE = 9;
        public const int TRANSACTION_FROM_ASSIGNMENT = 10;
    }


    /// <summary>
    /// SideQty Field
    /// </summary>/
    public sealed class SideQty : IntField
    {
        public SideQty()
            :base(Tags.SideQty) {}
        public SideQty(int val)
            :base(Tags.SideQty, val) {}

    }


    /// <summary>
    /// MessageEventSource Field
    /// </summary>/
    public sealed class MessageEventSource : StringField
    {
        public MessageEventSource()
            :base(Tags.MessageEventSource) {}
        public MessageEventSource(string val)
            :base(Tags.MessageEventSource, val) {}

    }


    /// <summary>
    /// SideTrdRegTimestamp Field
    /// </summary>/
    public sealed class SideTrdRegTimestamp : DateTimeField
    {
        public SideTrdRegTimestamp()
            :base(Tags.SideTrdRegTimestamp) {}
        public SideTrdRegTimestamp(DateTime val)
            :base(Tags.SideTrdRegTimestamp, val) {}

    }


    /// <summary>
    /// SideTrdRegTimestampType Field
    /// </summary>/
    public sealed class SideTrdRegTimestampType : IntField
    {
        public SideTrdRegTimestampType()
            :base(Tags.SideTrdRegTimestampType) {}
        public SideTrdRegTimestampType(int val)
            :base(Tags.SideTrdRegTimestampType, val) {}

    }


    /// <summary>
    /// SideTrdRegTimestampSrc Field
    /// </summary>/
    public sealed class SideTrdRegTimestampSrc : StringField
    {
        public SideTrdRegTimestampSrc()
            :base(Tags.SideTrdRegTimestampSrc) {}
        public SideTrdRegTimestampSrc(string val)
            :base(Tags.SideTrdRegTimestampSrc, val) {}

    }


    /// <summary>
    /// AsOfIndicator Field
    /// </summary>/
    public sealed class AsOfIndicator : CharField
    {
        public AsOfIndicator()
            :base(Tags.AsOfIndicator) {}
        public AsOfIndicator(char val)
            :base(Tags.AsOfIndicator, val) {}


        // Field Enumerations
        public const char FALSE = '0';
        public const char TRUE = '1';
    }


    /// <summary>
    /// NoSideTrdRegTS Field
    /// </summary>/
    public sealed class NoSideTrdRegTS : IntField
    {
        public NoSideTrdRegTS()
            :base(Tags.NoSideTrdRegTS) {}
        public NoSideTrdRegTS(int val)
            :base(Tags.NoSideTrdRegTS, val) {}

    }


    /// <summary>
    /// LegOptionRatio Field
    /// </summary>/
    public sealed class LegOptionRatio : DecimalField
    {
        public LegOptionRatio()
            :base(Tags.LegOptionRatio) {}
        public LegOptionRatio(Decimal val)
            :base(Tags.LegOptionRatio, val) {}

    }


    /// <summary>
    /// NoInstrumentParties Field
    /// </summary>/
    public sealed class NoInstrumentParties : IntField
    {
        public NoInstrumentParties()
            :base(Tags.NoInstrumentParties) {}
        public NoInstrumentParties(int val)
            :base(Tags.NoInstrumentParties, val) {}

    }


    /// <summary>
    /// InstrumentPartyID Field
    /// </summary>/
    public sealed class InstrumentPartyID : StringField
    {
        public InstrumentPartyID()
            :base(Tags.InstrumentPartyID) {}
        public InstrumentPartyID(string val)
            :base(Tags.InstrumentPartyID, val) {}

    }


    /// <summary>
    /// TradeVolume Field
    /// </summary>/
    public sealed class TradeVolume : DecimalField
    {
        public TradeVolume()
            :base(Tags.TradeVolume) {}
        public TradeVolume(Decimal val)
            :base(Tags.TradeVolume, val) {}

    }


    /// <summary>
    /// MDBookType Field
    /// </summary>/
    public sealed class MDBookType : IntField
    {
        public MDBookType()
            :base(Tags.MDBookType) {}
        public MDBookType(int val)
            :base(Tags.MDBookType, val) {}


        // Field Enumerations
        public const int TOP_OF_BOOK = 1;
        public const int PRICE_DEPTH = 2;
        public const int ORDER_DEPTH = 3;
    }


    /// <summary>
    /// MDFeedType Field
    /// </summary>/
    public sealed class MDFeedType : StringField
    {
        public MDFeedType()
            :base(Tags.MDFeedType) {}
        public MDFeedType(string val)
            :base(Tags.MDFeedType, val) {}

    }


    /// <summary>
    /// MDPriceLevel Field
    /// </summary>/
    public sealed class MDPriceLevel : IntField
    {
        public MDPriceLevel()
            :base(Tags.MDPriceLevel) {}
        public MDPriceLevel(int val)
            :base(Tags.MDPriceLevel, val) {}

    }


    /// <summary>
    /// MDOriginType Field
    /// </summary>/
    public sealed class MDOriginType : IntField
    {
        public MDOriginType()
            :base(Tags.MDOriginType) {}
        public MDOriginType(int val)
            :base(Tags.MDOriginType, val) {}


        // Field Enumerations
        public const int BOOK = 0;
        public const int OFF_BOOK = 1;
        public const int CROSS = 2;
    }


    /// <summary>
    /// FirstPx Field
    /// </summary>/
    public sealed class FirstPx : DecimalField
    {
        public FirstPx()
            :base(Tags.FirstPx) {}
        public FirstPx(Decimal val)
            :base(Tags.FirstPx, val) {}

    }


    /// <summary>
    /// MDEntrySpotRate Field
    /// </summary>/
    public sealed class MDEntrySpotRate : DecimalField
    {
        public MDEntrySpotRate()
            :base(Tags.MDEntrySpotRate) {}
        public MDEntrySpotRate(Decimal val)
            :base(Tags.MDEntrySpotRate, val) {}

    }


    /// <summary>
    /// MDEntryForwardPoints Field
    /// </summary>/
    public sealed class MDEntryForwardPoints : DecimalField
    {
        public MDEntryForwardPoints()
            :base(Tags.MDEntryForwardPoints) {}
        public MDEntryForwardPoints(Decimal val)
            :base(Tags.MDEntryForwardPoints, val) {}

    }


    /// <summary>
    /// ManualOrderIndicator Field
    /// </summary>/
    public sealed class ManualOrderIndicator : BooleanField
    {
        public ManualOrderIndicator()
            :base(Tags.ManualOrderIndicator) {}
        public ManualOrderIndicator(Boolean val)
            :base(Tags.ManualOrderIndicator, val) {}

    }


    /// <summary>
    /// CustDirectedOrder Field
    /// </summary>/
    public sealed class CustDirectedOrder : BooleanField
    {
        public CustDirectedOrder()
            :base(Tags.CustDirectedOrder) {}
        public CustDirectedOrder(Boolean val)
            :base(Tags.CustDirectedOrder, val) {}

    }


    /// <summary>
    /// ReceivedDeptID Field
    /// </summary>/
    public sealed class ReceivedDeptID : StringField
    {
        public ReceivedDeptID()
            :base(Tags.ReceivedDeptID) {}
        public ReceivedDeptID(string val)
            :base(Tags.ReceivedDeptID, val) {}

    }


    /// <summary>
    /// CustOrderHandlingInst Field
    /// </summary>/
    public sealed class CustOrderHandlingInst : StringField
    {
        public CustOrderHandlingInst()
            :base(Tags.CustOrderHandlingInst) {}
        public CustOrderHandlingInst(string val)
            :base(Tags.CustOrderHandlingInst, val) {}


        // Field Enumerations
        public const string ADD_ON_ORDER = "ADD";
        public const string ALL_OR_NONE = "AON";
        public const string CASH_NOT_HELD = "CNH";
        public const string DIRECTED_ORDER = "DIR";
        public const string EXCHANGE_FOR_PHYSICAL_TRANSACTION = "E.W";
        public const string FILL_OR_KILL = "FOK";
        public const string IMBALANCE_ONLY = "IO";
        public const string IMMEDIATE_OR_CANCEL = "IOC";
        public const string LIMIT_ON_OPEN = "LOO";
        public const string LIMIT_ON_CLOSE = "LOC";
        public const string MARKET_AT_OPEN = "MAO";
        public const string MARKET_AT_CLOSE = "MAC";
        public const string MARKET_ON_OPEN = "MOO";
        public const string MARKET_ON_CLOSE = "MOC";
        public const string MINIMUM_QUANTITY = "MQT";
        public const string NOT_HELD = "NH";
        public const string OVER_THE_DAY = "OVD";
        public const string PEGGED = "PEG";
        public const string RESERVE_SIZE_ORDER = "RSV";
        public const string STOP_STOCK_TRANSACTION = "S.W";
        public const string SCALE = "SCL";
        public const string TIME_ORDER = "TMO";
        public const string TRAILING_STOP = "TS";
        public const string WORK = "WRK";
    }


    /// <summary>
    /// OrderHandlingInstSource Field
    /// </summary>/
    public sealed class OrderHandlingInstSource : IntField
    {
        public OrderHandlingInstSource()
            :base(Tags.OrderHandlingInstSource) {}
        public OrderHandlingInstSource(int val)
            :base(Tags.OrderHandlingInstSource, val) {}


        // Field Enumerations
        public const int NASD_OATS = 1;
    }


    /// <summary>
    /// DeskType Field
    /// </summary>/
    public sealed class DeskType : StringField
    {
        public DeskType()
            :base(Tags.DeskType) {}
        public DeskType(string val)
            :base(Tags.DeskType, val) {}


        // Field Enumerations
        public const string AGENCY = "A";
        public const string ARBITRAGE = "AR";
        public const string DERIVATIVES = "D";
        public const string INTERNATIONAL = "IN";
        public const string INSTITUTIONAL = "IS";
        public const string OTHER = "O";
        public const string PREFERRED_TRADING = "PF";
        public const string PROPRIETARY = "PR";
        public const string PROGRAM_TRADING = "PT";
        public const string SALES = "S";
        public const string TRADING = "T";
    }


    /// <summary>
    /// DeskTypeSource Field
    /// </summary>/
    public sealed class DeskTypeSource : IntField
    {
        public DeskTypeSource()
            :base(Tags.DeskTypeSource) {}
        public DeskTypeSource(int val)
            :base(Tags.DeskTypeSource, val) {}


        // Field Enumerations
        public const int NASD_OATS = 1;
    }


    /// <summary>
    /// DeskOrderHandlingInst Field
    /// </summary>/
    public sealed class DeskOrderHandlingInst : StringField
    {
        public DeskOrderHandlingInst()
            :base(Tags.DeskOrderHandlingInst) {}
        public DeskOrderHandlingInst(string val)
            :base(Tags.DeskOrderHandlingInst, val) {}


        // Field Enumerations
        public const string ADD_ON_ORDER = "ADD";
        public const string ALL_OR_NONE = "AON";
        public const string CASH_NOT_HELD = "CNH";
        public const string DIRECTED_ORDER = "DIR";
        public const string EXCHANGE_FOR_PHYSICAL_TRANSACTION = "E.W";
        public const string FILL_OR_KILL = "FOK";
        public const string IMBALANCE_ONLY = "IO";
        public const string IMMEDIATE_OR_CANCEL = "IOC";
        public const string LIMIT_ON_OPEN = "LOO";
        public const string LIMIT_ON_CLOSE = "LOC";
        public const string MARKET_AT_OPEN = "MAO";
        public const string MARKET_AT_CLOSE = "MAC";
        public const string MARKET_ON_OPEN = "MOO";
        public const string MARKET_ON_CLOSE = "MOC";
        public const string MINIMUM_QUANTITY = "MQT";
        public const string NOT_HELD = "NH";
        public const string OVER_THE_DAY = "OVD";
        public const string PEGGED = "PEG";
        public const string RESERVE_SIZE_ORDER = "RSV";
        public const string STOP_STOCK_TRANSACTION = "S.W";
        public const string SCALE = "SCL";
        public const string TIME_ORDER = "TMO";
        public const string TRAILING_STOP = "TS";
        public const string WORK = "WRK";
    }


    /// <summary>
    /// ExecAckStatus Field
    /// </summary>/
    public sealed class ExecAckStatus : CharField
    {
        public ExecAckStatus()
            :base(Tags.ExecAckStatus) {}
        public ExecAckStatus(char val)
            :base(Tags.ExecAckStatus, val) {}


        // Field Enumerations
        public const char RECEIVED_NOT_YET_PROCESSED = '0';
        public const char ACCEPTED = '1';
        public const char DONT_KNOW = '2';
    }


    /// <summary>
    /// UnderlyingDeliveryAmount Field
    /// </summary>/
    public sealed class UnderlyingDeliveryAmount : DecimalField
    {
        public UnderlyingDeliveryAmount()
            :base(Tags.UnderlyingDeliveryAmount) {}
        public UnderlyingDeliveryAmount(Decimal val)
            :base(Tags.UnderlyingDeliveryAmount, val) {}

    }


    /// <summary>
    /// UnderlyingCapValue Field
    /// </summary>/
    public sealed class UnderlyingCapValue : DecimalField
    {
        public UnderlyingCapValue()
            :base(Tags.UnderlyingCapValue) {}
        public UnderlyingCapValue(Decimal val)
            :base(Tags.UnderlyingCapValue, val) {}

    }


    /// <summary>
    /// UnderlyingSettlMethod Field
    /// </summary>/
    public sealed class UnderlyingSettlMethod : StringField
    {
        public UnderlyingSettlMethod()
            :base(Tags.UnderlyingSettlMethod) {}
        public UnderlyingSettlMethod(string val)
            :base(Tags.UnderlyingSettlMethod, val) {}

    }


    /// <summary>
    /// SecondaryTradeID Field
    /// </summary>/
    public sealed class SecondaryTradeID : StringField
    {
        public SecondaryTradeID()
            :base(Tags.SecondaryTradeID) {}
        public SecondaryTradeID(string val)
            :base(Tags.SecondaryTradeID, val) {}

    }


    /// <summary>
    /// FirmTradeID Field
    /// </summary>/
    public sealed class FirmTradeID : StringField
    {
        public FirmTradeID()
            :base(Tags.FirmTradeID) {}
        public FirmTradeID(string val)
            :base(Tags.FirmTradeID, val) {}

    }


    /// <summary>
    /// SecondaryFirmTradeID Field
    /// </summary>/
    public sealed class SecondaryFirmTradeID : StringField
    {
        public SecondaryFirmTradeID()
            :base(Tags.SecondaryFirmTradeID) {}
        public SecondaryFirmTradeID(string val)
            :base(Tags.SecondaryFirmTradeID, val) {}

    }


    /// <summary>
    /// CollApplType Field
    /// </summary>/
    public sealed class CollApplType : IntField
    {
        public CollApplType()
            :base(Tags.CollApplType) {}
        public CollApplType(int val)
            :base(Tags.CollApplType, val) {}


        // Field Enumerations
        public const int SPECIFIC_DEPOSIT = 0;
        public const int GENERAL = 1;
    }


    /// <summary>
    /// UnderlyingAdjustedQuantity Field
    /// </summary>/
    public sealed class UnderlyingAdjustedQuantity : DecimalField
    {
        public UnderlyingAdjustedQuantity()
            :base(Tags.UnderlyingAdjustedQuantity) {}
        public UnderlyingAdjustedQuantity(Decimal val)
            :base(Tags.UnderlyingAdjustedQuantity, val) {}

    }


    /// <summary>
    /// UnderlyingFXRate Field
    /// </summary>/
    public sealed class UnderlyingFXRate : DecimalField
    {
        public UnderlyingFXRate()
            :base(Tags.UnderlyingFXRate) {}
        public UnderlyingFXRate(Decimal val)
            :base(Tags.UnderlyingFXRate, val) {}

    }


    /// <summary>
    /// UnderlyingFXRateCalc Field
    /// </summary>/
    public sealed class UnderlyingFXRateCalc : CharField
    {
        public UnderlyingFXRateCalc()
            :base(Tags.UnderlyingFXRateCalc) {}
        public UnderlyingFXRateCalc(char val)
            :base(Tags.UnderlyingFXRateCalc, val) {}


        // Field Enumerations
        public const char MULTIPLY = 'M';
        public const char DIVIDE = 'D';
    }


    /// <summary>
    /// AllocPositionEffect Field
    /// </summary>/
    public sealed class AllocPositionEffect : CharField
    {
        public AllocPositionEffect()
            :base(Tags.AllocPositionEffect) {}
        public AllocPositionEffect(char val)
            :base(Tags.AllocPositionEffect, val) {}


        // Field Enumerations
        public const char OPEN = 'O';
        public const char CLOSE = 'C';
        public const char ROLLED = 'R';
        public const char FIFO = 'F';
    }


    /// <summary>
    /// DealingCapacity Field
    /// </summary>/
    public sealed class DealingCapacity : DecimalField
    {
        public DealingCapacity()
            :base(Tags.DealingCapacity) {}
        public DealingCapacity(Decimal val)
            :base(Tags.DealingCapacity, val) {}

    }


    /// <summary>
    /// InstrmtAssignmentMethod Field
    /// </summary>/
    public sealed class InstrmtAssignmentMethod : CharField
    {
        public InstrmtAssignmentMethod()
            :base(Tags.InstrmtAssignmentMethod) {}
        public InstrmtAssignmentMethod(char val)
            :base(Tags.InstrmtAssignmentMethod, val) {}

    }


    /// <summary>
    /// InstrumentPartyIDSource Field
    /// </summary>/
    public sealed class InstrumentPartyIDSource : CharField
    {
        public InstrumentPartyIDSource()
            :base(Tags.InstrumentPartyIDSource) {}
        public InstrumentPartyIDSource(char val)
            :base(Tags.InstrumentPartyIDSource, val) {}

    }


    /// <summary>
    /// InstrumentPartyRole Field
    /// </summary>/
    public sealed class InstrumentPartyRole : IntField
    {
        public InstrumentPartyRole()
            :base(Tags.InstrumentPartyRole) {}
        public InstrumentPartyRole(int val)
            :base(Tags.InstrumentPartyRole, val) {}

    }


    /// <summary>
    /// NoInstrumentPartySubIDs Field
    /// </summary>/
    public sealed class NoInstrumentPartySubIDs : IntField
    {
        public NoInstrumentPartySubIDs()
            :base(Tags.NoInstrumentPartySubIDs) {}
        public NoInstrumentPartySubIDs(int val)
            :base(Tags.NoInstrumentPartySubIDs, val) {}

    }


    /// <summary>
    /// InstrumentPartySubID Field
    /// </summary>/
    public sealed class InstrumentPartySubID : StringField
    {
        public InstrumentPartySubID()
            :base(Tags.InstrumentPartySubID) {}
        public InstrumentPartySubID(string val)
            :base(Tags.InstrumentPartySubID, val) {}

    }


    /// <summary>
    /// InstrumentPartySubIDType Field
    /// </summary>/
    public sealed class InstrumentPartySubIDType : IntField
    {
        public InstrumentPartySubIDType()
            :base(Tags.InstrumentPartySubIDType) {}
        public InstrumentPartySubIDType(int val)
            :base(Tags.InstrumentPartySubIDType, val) {}

    }


    /// <summary>
    /// PositionCurrency Field
    /// </summary>/
    public sealed class PositionCurrency : StringField
    {
        public PositionCurrency()
            :base(Tags.PositionCurrency) {}
        public PositionCurrency(string val)
            :base(Tags.PositionCurrency, val) {}

    }


    /// <summary>
    /// CalculatedCcyLastQty Field
    /// </summary>/
    public sealed class CalculatedCcyLastQty : DecimalField
    {
        public CalculatedCcyLastQty()
            :base(Tags.CalculatedCcyLastQty) {}
        public CalculatedCcyLastQty(Decimal val)
            :base(Tags.CalculatedCcyLastQty, val) {}

    }


    /// <summary>
    /// AggressorIndicator Field
    /// </summary>/
    public sealed class AggressorIndicator : BooleanField
    {
        public AggressorIndicator()
            :base(Tags.AggressorIndicator) {}
        public AggressorIndicator(Boolean val)
            :base(Tags.AggressorIndicator, val) {}


        // Field Enumerations
        public const Boolean YES = true;
        public const Boolean NO = false;
    }


    /// <summary>
    /// NoUndlyInstrumentParties Field
    /// </summary>/
    public sealed class NoUndlyInstrumentParties : IntField
    {
        public NoUndlyInstrumentParties()
            :base(Tags.NoUndlyInstrumentParties) {}
        public NoUndlyInstrumentParties(int val)
            :base(Tags.NoUndlyInstrumentParties, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartyID Field
    /// </summary>/
    public sealed class UndlyInstrumentPartyID : StringField
    {
        public UndlyInstrumentPartyID()
            :base(Tags.UndlyInstrumentPartyID) {}
        public UndlyInstrumentPartyID(string val)
            :base(Tags.UndlyInstrumentPartyID, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartyIDSource Field
    /// </summary>/
    public sealed class UndlyInstrumentPartyIDSource : CharField
    {
        public UndlyInstrumentPartyIDSource()
            :base(Tags.UndlyInstrumentPartyIDSource) {}
        public UndlyInstrumentPartyIDSource(char val)
            :base(Tags.UndlyInstrumentPartyIDSource, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartyRole Field
    /// </summary>/
    public sealed class UndlyInstrumentPartyRole : IntField
    {
        public UndlyInstrumentPartyRole()
            :base(Tags.UndlyInstrumentPartyRole) {}
        public UndlyInstrumentPartyRole(int val)
            :base(Tags.UndlyInstrumentPartyRole, val) {}

    }


    /// <summary>
    /// NoUndlyInstrumentPartySubIDs Field
    /// </summary>/
    public sealed class NoUndlyInstrumentPartySubIDs : IntField
    {
        public NoUndlyInstrumentPartySubIDs()
            :base(Tags.NoUndlyInstrumentPartySubIDs) {}
        public NoUndlyInstrumentPartySubIDs(int val)
            :base(Tags.NoUndlyInstrumentPartySubIDs, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartySubID Field
    /// </summary>/
    public sealed class UndlyInstrumentPartySubID : StringField
    {
        public UndlyInstrumentPartySubID()
            :base(Tags.UndlyInstrumentPartySubID) {}
        public UndlyInstrumentPartySubID(string val)
            :base(Tags.UndlyInstrumentPartySubID, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartySubIDType Field
    /// </summary>/
    public sealed class UndlyInstrumentPartySubIDType : IntField
    {
        public UndlyInstrumentPartySubIDType()
            :base(Tags.UndlyInstrumentPartySubIDType) {}
        public UndlyInstrumentPartySubIDType(int val)
            :base(Tags.UndlyInstrumentPartySubIDType, val) {}

    }


    /// <summary>
    /// BidSwapPoints Field
    /// </summary>/
    public sealed class BidSwapPoints : DecimalField
    {
        public BidSwapPoints()
            :base(Tags.BidSwapPoints) {}
        public BidSwapPoints(Decimal val)
            :base(Tags.BidSwapPoints, val) {}

    }


    /// <summary>
    /// OfferSwapPoints Field
    /// </summary>/
    public sealed class OfferSwapPoints : DecimalField
    {
        public OfferSwapPoints()
            :base(Tags.OfferSwapPoints) {}
        public OfferSwapPoints(Decimal val)
            :base(Tags.OfferSwapPoints, val) {}

    }


    /// <summary>
    /// LegBidForwardPoints Field
    /// </summary>/
    public sealed class LegBidForwardPoints : DecimalField
    {
        public LegBidForwardPoints()
            :base(Tags.LegBidForwardPoints) {}
        public LegBidForwardPoints(Decimal val)
            :base(Tags.LegBidForwardPoints, val) {}

    }


    /// <summary>
    /// LegOfferForwardPoints Field
    /// </summary>/
    public sealed class LegOfferForwardPoints : DecimalField
    {
        public LegOfferForwardPoints()
            :base(Tags.LegOfferForwardPoints) {}
        public LegOfferForwardPoints(Decimal val)
            :base(Tags.LegOfferForwardPoints, val) {}

    }


    /// <summary>
    /// SwapPoints Field
    /// </summary>/
    public sealed class SwapPoints : DecimalField
    {
        public SwapPoints()
            :base(Tags.SwapPoints) {}
        public SwapPoints(Decimal val)
            :base(Tags.SwapPoints, val) {}

    }


    /// <summary>
    /// MDQuoteType Field
    /// </summary>/
    public sealed class MDQuoteType : IntField
    {
        public MDQuoteType()
            :base(Tags.MDQuoteType) {}
        public MDQuoteType(int val)
            :base(Tags.MDQuoteType, val) {}


        // Field Enumerations
        public const int INDICATIVE = 0;
        public const int TRADEABLE = 1;
        public const int RESTRICTED_TRADEABLE = 2;
        public const int COUNTER = 3;
        public const int INDICATIVE_AND_TRADEABLE = 4;
    }


    /// <summary>
    /// LastSwapPoints Field
    /// </summary>/
    public sealed class LastSwapPoints : DecimalField
    {
        public LastSwapPoints()
            :base(Tags.LastSwapPoints) {}
        public LastSwapPoints(Decimal val)
            :base(Tags.LastSwapPoints, val) {}

    }


    /// <summary>
    /// SideGrossTradeAmt Field
    /// </summary>/
    public sealed class SideGrossTradeAmt : DecimalField
    {
        public SideGrossTradeAmt()
            :base(Tags.SideGrossTradeAmt) {}
        public SideGrossTradeAmt(Decimal val)
            :base(Tags.SideGrossTradeAmt, val) {}

    }


    /// <summary>
    /// LegLastForwardPoints Field
    /// </summary>/
    public sealed class LegLastForwardPoints : DecimalField
    {
        public LegLastForwardPoints()
            :base(Tags.LegLastForwardPoints) {}
        public LegLastForwardPoints(Decimal val)
            :base(Tags.LegLastForwardPoints, val) {}

    }


    /// <summary>
    /// LegCalculatedCcyLastQty Field
    /// </summary>/
    public sealed class LegCalculatedCcyLastQty : DecimalField
    {
        public LegCalculatedCcyLastQty()
            :base(Tags.LegCalculatedCcyLastQty) {}
        public LegCalculatedCcyLastQty(Decimal val)
            :base(Tags.LegCalculatedCcyLastQty, val) {}

    }


    /// <summary>
    /// LegGrossTradeAmt Field
    /// </summary>/
    public sealed class LegGrossTradeAmt : DecimalField
    {
        public LegGrossTradeAmt()
            :base(Tags.LegGrossTradeAmt) {}
        public LegGrossTradeAmt(Decimal val)
            :base(Tags.LegGrossTradeAmt, val) {}

    }


    /// <summary>
    /// MaturityTime Field
    /// </summary>/
    public sealed class MaturityTime : StringField
    {
        public MaturityTime()
            :base(Tags.MaturityTime) {}
        public MaturityTime(string val)
            :base(Tags.MaturityTime, val) {}

    }


    /// <summary>
    /// RefOrderID Field
    /// </summary>/
    public sealed class RefOrderID : StringField
    {
        public RefOrderID()
            :base(Tags.RefOrderID) {}
        public RefOrderID(string val)
            :base(Tags.RefOrderID, val) {}

    }


    /// <summary>
    /// RefOrderIDSource Field
    /// </summary>/
    public sealed class RefOrderIDSource : CharField
    {
        public RefOrderIDSource()
            :base(Tags.RefOrderIDSource) {}
        public RefOrderIDSource(char val)
            :base(Tags.RefOrderIDSource, val) {}


        // Field Enumerations
        public const char SECONDARYORDEID = '0';
        public const char ORDEID = '1';
        public const char MENTRYID = '2';
        public const char QUOTENTRYID = '3';
    }


    /// <summary>
    /// SecondaryDisplayQty Field
    /// </summary>/
    public sealed class SecondaryDisplayQty : DecimalField
    {
        public SecondaryDisplayQty()
            :base(Tags.SecondaryDisplayQty) {}
        public SecondaryDisplayQty(Decimal val)
            :base(Tags.SecondaryDisplayQty, val) {}

    }


    /// <summary>
    /// DisplayWhen Field
    /// </summary>/
    public sealed class DisplayWhen : CharField
    {
        public DisplayWhen()
            :base(Tags.DisplayWhen) {}
        public DisplayWhen(char val)
            :base(Tags.DisplayWhen, val) {}


        // Field Enumerations
        public const char IMMEDIATE = '1';
        public const char EXHAUST = '2';
    }


    /// <summary>
    /// DisplayMethod Field
    /// </summary>/
    public sealed class DisplayMethod : CharField
    {
        public DisplayMethod()
            :base(Tags.DisplayMethod) {}
        public DisplayMethod(char val)
            :base(Tags.DisplayMethod, val) {}


        // Field Enumerations
        public const char INITIAL = '1';
        public const char NEW = '2';
        public const char RANDOM = '3';
    }


    /// <summary>
    /// DisplayLowQty Field
    /// </summary>/
    public sealed class DisplayLowQty : DecimalField
    {
        public DisplayLowQty()
            :base(Tags.DisplayLowQty) {}
        public DisplayLowQty(Decimal val)
            :base(Tags.DisplayLowQty, val) {}

    }


    /// <summary>
    /// DisplayHighQty Field
    /// </summary>/
    public sealed class DisplayHighQty : DecimalField
    {
        public DisplayHighQty()
            :base(Tags.DisplayHighQty) {}
        public DisplayHighQty(Decimal val)
            :base(Tags.DisplayHighQty, val) {}

    }


    /// <summary>
    /// DisplayMinIncr Field
    /// </summary>/
    public sealed class DisplayMinIncr : DecimalField
    {
        public DisplayMinIncr()
            :base(Tags.DisplayMinIncr) {}
        public DisplayMinIncr(Decimal val)
            :base(Tags.DisplayMinIncr, val) {}

    }


    /// <summary>
    /// RefreshQty Field
    /// </summary>/
    public sealed class RefreshQty : DecimalField
    {
        public RefreshQty()
            :base(Tags.RefreshQty) {}
        public RefreshQty(Decimal val)
            :base(Tags.RefreshQty, val) {}

    }


    /// <summary>
    /// MatchIncrement Field
    /// </summary>/
    public sealed class MatchIncrement : DecimalField
    {
        public MatchIncrement()
            :base(Tags.MatchIncrement) {}
        public MatchIncrement(Decimal val)
            :base(Tags.MatchIncrement, val) {}

    }


    /// <summary>
    /// MaxPriceLevels Field
    /// </summary>/
    public sealed class MaxPriceLevels : IntField
    {
        public MaxPriceLevels()
            :base(Tags.MaxPriceLevels) {}
        public MaxPriceLevels(int val)
            :base(Tags.MaxPriceLevels, val) {}

    }


    /// <summary>
    /// PreTradeAnonymity Field
    /// </summary>/
    public sealed class PreTradeAnonymity : BooleanField
    {
        public PreTradeAnonymity()
            :base(Tags.PreTradeAnonymity) {}
        public PreTradeAnonymity(Boolean val)
            :base(Tags.PreTradeAnonymity, val) {}

    }


    /// <summary>
    /// PriceProtectionScope Field
    /// </summary>/
    public sealed class PriceProtectionScope : CharField
    {
        public PriceProtectionScope()
            :base(Tags.PriceProtectionScope) {}
        public PriceProtectionScope(char val)
            :base(Tags.PriceProtectionScope, val) {}


        // Field Enumerations
        public const char NONE = '0';
        public const char LOCAL = '1';
        public const char NATIONAL = '2';
        public const char GLOBAL = '3';
    }


    /// <summary>
    /// LotType Field
    /// </summary>/
    public sealed class LotType : CharField
    {
        public LotType()
            :base(Tags.LotType) {}
        public LotType(char val)
            :base(Tags.LotType, val) {}


        // Field Enumerations
        public const char ODD_LOT = '1';
        public const char ROUND_LOT = '2';
        public const char BLOCK_LOT = '3';
    }


    /// <summary>
    /// PegPriceType Field
    /// </summary>/
    public sealed class PegPriceType : IntField
    {
        public PegPriceType()
            :base(Tags.PegPriceType) {}
        public PegPriceType(int val)
            :base(Tags.PegPriceType, val) {}


        // Field Enumerations
        public const int LAST_PEG = 1;
        public const int MID_PRICE_PEG = 2;
        public const int OPENING_PEG = 3;
        public const int MARKET_PEG = 4;
        public const int PRIMARY_PEG = 5;
        public const int FIXED_PEG_TO_LOCAL_BEST_BID_OR_OFFER_AT_TIME_OF_ORDER = 6;
        public const int PEG_TO_VWAP = 7;
        public const int TRAILING_STOP_PEG = 8;
        public const int PEG_TO_LIMIT_PRICE = 9;
    }


    /// <summary>
    /// PeggedRefPrice Field
    /// </summary>/
    public sealed class PeggedRefPrice : DecimalField
    {
        public PeggedRefPrice()
            :base(Tags.PeggedRefPrice) {}
        public PeggedRefPrice(Decimal val)
            :base(Tags.PeggedRefPrice, val) {}

    }


    /// <summary>
    /// PegSecurityIDSource Field
    /// </summary>/
    public sealed class PegSecurityIDSource : StringField
    {
        public PegSecurityIDSource()
            :base(Tags.PegSecurityIDSource) {}
        public PegSecurityIDSource(string val)
            :base(Tags.PegSecurityIDSource, val) {}

    }


    /// <summary>
    /// PegSecurityID Field
    /// </summary>/
    public sealed class PegSecurityID : StringField
    {
        public PegSecurityID()
            :base(Tags.PegSecurityID) {}
        public PegSecurityID(string val)
            :base(Tags.PegSecurityID, val) {}

    }


    /// <summary>
    /// PegSymbol Field
    /// </summary>/
    public sealed class PegSymbol : StringField
    {
        public PegSymbol()
            :base(Tags.PegSymbol) {}
        public PegSymbol(string val)
            :base(Tags.PegSymbol, val) {}

    }


    /// <summary>
    /// PegSecurityDesc Field
    /// </summary>/
    public sealed class PegSecurityDesc : StringField
    {
        public PegSecurityDesc()
            :base(Tags.PegSecurityDesc) {}
        public PegSecurityDesc(string val)
            :base(Tags.PegSecurityDesc, val) {}

    }


    /// <summary>
    /// TriggerType Field
    /// </summary>/
    public sealed class TriggerType : CharField
    {
        public TriggerType()
            :base(Tags.TriggerType) {}
        public TriggerType(char val)
            :base(Tags.TriggerType, val) {}


        // Field Enumerations
        public const char PARTIAL_EXECUTION = '1';
        public const char SPECIFIED_TRADING_SESSION = '2';
        public const char NEXT_AUCTION = '3';
        public const char PRICE_MOVEMENT = '4';
    }


    /// <summary>
    /// TriggerAction Field
    /// </summary>/
    public sealed class TriggerAction : CharField
    {
        public TriggerAction()
            :base(Tags.TriggerAction) {}
        public TriggerAction(char val)
            :base(Tags.TriggerAction, val) {}


        // Field Enumerations
        public const char ACTIVATE = '1';
        public const char MODIFY = '2';
        public const char CANCEL = '3';
    }


    /// <summary>
    /// TriggerPrice Field
    /// </summary>/
    public sealed class TriggerPrice : DecimalField
    {
        public TriggerPrice()
            :base(Tags.TriggerPrice) {}
        public TriggerPrice(Decimal val)
            :base(Tags.TriggerPrice, val) {}

    }


    /// <summary>
    /// TriggerSymbol Field
    /// </summary>/
    public sealed class TriggerSymbol : StringField
    {
        public TriggerSymbol()
            :base(Tags.TriggerSymbol) {}
        public TriggerSymbol(string val)
            :base(Tags.TriggerSymbol, val) {}

    }


    /// <summary>
    /// TriggerSecurityID Field
    /// </summary>/
    public sealed class TriggerSecurityID : StringField
    {
        public TriggerSecurityID()
            :base(Tags.TriggerSecurityID) {}
        public TriggerSecurityID(string val)
            :base(Tags.TriggerSecurityID, val) {}

    }


    /// <summary>
    /// TriggerSecurityIDSource Field
    /// </summary>/
    public sealed class TriggerSecurityIDSource : StringField
    {
        public TriggerSecurityIDSource()
            :base(Tags.TriggerSecurityIDSource) {}
        public TriggerSecurityIDSource(string val)
            :base(Tags.TriggerSecurityIDSource, val) {}

    }


    /// <summary>
    /// TriggerSecurityDesc Field
    /// </summary>/
    public sealed class TriggerSecurityDesc : StringField
    {
        public TriggerSecurityDesc()
            :base(Tags.TriggerSecurityDesc) {}
        public TriggerSecurityDesc(string val)
            :base(Tags.TriggerSecurityDesc, val) {}

    }


    /// <summary>
    /// TriggerPriceType Field
    /// </summary>/
    public sealed class TriggerPriceType : CharField
    {
        public TriggerPriceType()
            :base(Tags.TriggerPriceType) {}
        public TriggerPriceType(char val)
            :base(Tags.TriggerPriceType, val) {}


        // Field Enumerations
        public const char BEST_OFFER = '1';
        public const char LAST_TRADE = '2';
        public const char BEST_BID = '3';
        public const char BEST_BID_OR_LAST_TRADE = '4';
        public const char BEST_OFFER_OR_LAST_TRADE = '5';
        public const char BEST_MID = '6';
    }


    /// <summary>
    /// TriggerPriceTypeScope Field
    /// </summary>/
    public sealed class TriggerPriceTypeScope : CharField
    {
        public TriggerPriceTypeScope()
            :base(Tags.TriggerPriceTypeScope) {}
        public TriggerPriceTypeScope(char val)
            :base(Tags.TriggerPriceTypeScope, val) {}


        // Field Enumerations
        public const char NONE = '0';
        public const char LOCAL = '1';
        public const char NATIONAL = '2';
        public const char GLOBAL = '3';
    }


    /// <summary>
    /// TriggerPriceDirection Field
    /// </summary>/
    public sealed class TriggerPriceDirection : CharField
    {
        public TriggerPriceDirection()
            :base(Tags.TriggerPriceDirection) {}
        public TriggerPriceDirection(char val)
            :base(Tags.TriggerPriceDirection, val) {}


        // Field Enumerations
        public const char TRIGGER_IF_THE_PRICE_OF_THE_SPECIFIED_TYPE_GOES_UP_TO_OR_THROUGH_THE_SPECIFIED_TRIGGER_PRICE = 'U';
        public const char TRIGGER_IF_THE_PRICE_OF_THE_SPECIFIED_TYPE_GOES_DOWN_TO_OR_THROUGH_THE_SPECIFIED_TRIGGER_PRICE = 'D';
    }


    /// <summary>
    /// TriggerNewPrice Field
    /// </summary>/
    public sealed class TriggerNewPrice : DecimalField
    {
        public TriggerNewPrice()
            :base(Tags.TriggerNewPrice) {}
        public TriggerNewPrice(Decimal val)
            :base(Tags.TriggerNewPrice, val) {}

    }


    /// <summary>
    /// TriggerOrderType Field
    /// </summary>/
    public sealed class TriggerOrderType : CharField
    {
        public TriggerOrderType()
            :base(Tags.TriggerOrderType) {}
        public TriggerOrderType(char val)
            :base(Tags.TriggerOrderType, val) {}


        // Field Enumerations
        public const char MARKET = '1';
        public const char LIMIT = '2';
    }


    /// <summary>
    /// TriggerNewQty Field
    /// </summary>/
    public sealed class TriggerNewQty : DecimalField
    {
        public TriggerNewQty()
            :base(Tags.TriggerNewQty) {}
        public TriggerNewQty(Decimal val)
            :base(Tags.TriggerNewQty, val) {}

    }


    /// <summary>
    /// TriggerTradingSessionID Field
    /// </summary>/
    public sealed class TriggerTradingSessionID : StringField
    {
        public TriggerTradingSessionID()
            :base(Tags.TriggerTradingSessionID) {}
        public TriggerTradingSessionID(string val)
            :base(Tags.TriggerTradingSessionID, val) {}

    }


    /// <summary>
    /// TriggerTradingSessionSubID Field
    /// </summary>/
    public sealed class TriggerTradingSessionSubID : StringField
    {
        public TriggerTradingSessionSubID()
            :base(Tags.TriggerTradingSessionSubID) {}
        public TriggerTradingSessionSubID(string val)
            :base(Tags.TriggerTradingSessionSubID, val) {}

    }


    /// <summary>
    /// OrderCategory Field
    /// </summary>/
    public sealed class OrderCategory : CharField
    {
        public OrderCategory()
            :base(Tags.OrderCategory) {}
        public OrderCategory(char val)
            :base(Tags.OrderCategory, val) {}


        // Field Enumerations
        public const char ORDER = '1';
        public const char QUOTE = '2';
        public const char PRIVATELY_NEGOTIATED_TRADE = '3';
        public const char MULTILEG_ORDER = '4';
        public const char LINKED_ORDER = '5';
        public const char QUOTE_REQUEST = '6';
        public const char IMPLIED_ORDER = '7';
        public const char CROSS_ORDER = '8';
    }


    /// <summary>
    /// NoRootPartyIDs Field
    /// </summary>/
    public sealed class NoRootPartyIDs : IntField
    {
        public NoRootPartyIDs()
            :base(Tags.NoRootPartyIDs) {}
        public NoRootPartyIDs(int val)
            :base(Tags.NoRootPartyIDs, val) {}

    }


    /// <summary>
    /// RootPartyID Field
    /// </summary>/
    public sealed class RootPartyID : StringField
    {
        public RootPartyID()
            :base(Tags.RootPartyID) {}
        public RootPartyID(string val)
            :base(Tags.RootPartyID, val) {}

    }


    /// <summary>
    /// RootPartyIDSource Field
    /// </summary>/
    public sealed class RootPartyIDSource : CharField
    {
        public RootPartyIDSource()
            :base(Tags.RootPartyIDSource) {}
        public RootPartyIDSource(char val)
            :base(Tags.RootPartyIDSource, val) {}

    }


    /// <summary>
    /// RootPartyRole Field
    /// </summary>/
    public sealed class RootPartyRole : IntField
    {
        public RootPartyRole()
            :base(Tags.RootPartyRole) {}
        public RootPartyRole(int val)
            :base(Tags.RootPartyRole, val) {}

    }


    /// <summary>
    /// NoRootPartySubIDs Field
    /// </summary>/
    public sealed class NoRootPartySubIDs : IntField
    {
        public NoRootPartySubIDs()
            :base(Tags.NoRootPartySubIDs) {}
        public NoRootPartySubIDs(int val)
            :base(Tags.NoRootPartySubIDs, val) {}

    }


    /// <summary>
    /// RootPartySubID Field
    /// </summary>/
    public sealed class RootPartySubID : StringField
    {
        public RootPartySubID()
            :base(Tags.RootPartySubID) {}
        public RootPartySubID(string val)
            :base(Tags.RootPartySubID, val) {}

    }


    /// <summary>
    /// RootPartySubIDType Field
    /// </summary>/
    public sealed class RootPartySubIDType : IntField
    {
        public RootPartySubIDType()
            :base(Tags.RootPartySubIDType) {}
        public RootPartySubIDType(int val)
            :base(Tags.RootPartySubIDType, val) {}

    }


    /// <summary>
    /// TradeHandlingInstr Field
    /// </summary>/
    public sealed class TradeHandlingInstr : CharField
    {
        public TradeHandlingInstr()
            :base(Tags.TradeHandlingInstr) {}
        public TradeHandlingInstr(char val)
            :base(Tags.TradeHandlingInstr, val) {}


        // Field Enumerations
        public const char TRADE_CONFIRMATION = '0';
        public const char TWO_PARTY_REPORT = '1';
        public const char ONE_PARTY_REPORT_FOR_MATCHING = '2';
        public const char ONE_PARTY_REPORT_FOR_PASS_THROUGH = '3';
        public const char AUTOMATED_FLOOR_ORDER_ROUTING = '4';
    }


    /// <summary>
    /// OrigTradeHandlingInstr Field
    /// </summary>/
    public sealed class OrigTradeHandlingInstr : CharField
    {
        public OrigTradeHandlingInstr()
            :base(Tags.OrigTradeHandlingInstr) {}
        public OrigTradeHandlingInstr(char val)
            :base(Tags.OrigTradeHandlingInstr, val) {}

    }


    /// <summary>
    /// OrigTradeDate Field
    /// </summary>/
    public sealed class OrigTradeDate : StringField
    {
        public OrigTradeDate()
            :base(Tags.OrigTradeDate) {}
        public OrigTradeDate(string val)
            :base(Tags.OrigTradeDate, val) {}

    }


    /// <summary>
    /// OrigTradeID Field
    /// </summary>/
    public sealed class OrigTradeID : StringField
    {
        public OrigTradeID()
            :base(Tags.OrigTradeID) {}
        public OrigTradeID(string val)
            :base(Tags.OrigTradeID, val) {}

    }


    /// <summary>
    /// OrigSecondaryTradeID Field
    /// </summary>/
    public sealed class OrigSecondaryTradeID : StringField
    {
        public OrigSecondaryTradeID()
            :base(Tags.OrigSecondaryTradeID) {}
        public OrigSecondaryTradeID(string val)
            :base(Tags.OrigSecondaryTradeID, val) {}

    }


    /// <summary>
    /// ApplVerID Field
    /// </summary>/
    public sealed class ApplVerID : StringField
    {
        public ApplVerID()
            :base(Tags.ApplVerID) {}
        public ApplVerID(string val)
            :base(Tags.ApplVerID, val) {}


        // Field Enumerations
        public const string FIX27 = "0";
        public const string FIX30 = "1";
        public const string FIX40 = "2";
        public const string FIX41 = "3";
        public const string FIX42 = "4";
        public const string FIX43 = "5";
        public const string FIX44 = "6";
        public const string FIX50 = "7";
    }


    /// <summary>
    /// CstmApplVerID Field
    /// </summary>/
    public sealed class CstmApplVerID : StringField
    {
        public CstmApplVerID()
            :base(Tags.CstmApplVerID) {}
        public CstmApplVerID(string val)
            :base(Tags.CstmApplVerID, val) {}

    }


    /// <summary>
    /// RefApplVerID Field
    /// </summary>/
    public sealed class RefApplVerID : StringField
    {
        public RefApplVerID()
            :base(Tags.RefApplVerID) {}
        public RefApplVerID(string val)
            :base(Tags.RefApplVerID, val) {}

    }


    /// <summary>
    /// RefCstmApplVerID Field
    /// </summary>/
    public sealed class RefCstmApplVerID : StringField
    {
        public RefCstmApplVerID()
            :base(Tags.RefCstmApplVerID) {}
        public RefCstmApplVerID(string val)
            :base(Tags.RefCstmApplVerID, val) {}

    }


    /// <summary>
    /// TZTransactTime Field
    /// </summary>/
    public sealed class TZTransactTime : DateTimeField
    {
        public TZTransactTime()
            :base(Tags.TZTransactTime) {}
        public TZTransactTime(DateTime val)
            :base(Tags.TZTransactTime, val) {}

    }


    /// <summary>
    /// ExDestinationIDSource Field
    /// </summary>/
    public sealed class ExDestinationIDSource : CharField
    {
        public ExDestinationIDSource()
            :base(Tags.ExDestinationIDSource) {}
        public ExDestinationIDSource(char val)
            :base(Tags.ExDestinationIDSource, val) {}


        // Field Enumerations
        public const char BIC = 'B';
        public const char GENERALLY_ACCEPTED_MARKET_PARTICIPANT_IDENTIFIER = 'C';
        public const char PROPRIETARY = 'D';
        public const char ISO_COUNTRY_CODE = 'E';
        public const char MIC = 'G';
    }


    /// <summary>
    /// ReportedPxDiff Field
    /// </summary>/
    public sealed class ReportedPxDiff : BooleanField
    {
        public ReportedPxDiff()
            :base(Tags.ReportedPxDiff) {}
        public ReportedPxDiff(Boolean val)
            :base(Tags.ReportedPxDiff, val) {}

    }


    /// <summary>
    /// RptSys Field
    /// </summary>/
    public sealed class RptSys : StringField
    {
        public RptSys()
            :base(Tags.RptSys) {}
        public RptSys(string val)
            :base(Tags.RptSys, val) {}

    }


    /// <summary>
    /// AllocClearingFeeIndicator Field
    /// </summary>/
    public sealed class AllocClearingFeeIndicator : StringField
    {
        public AllocClearingFeeIndicator()
            :base(Tags.AllocClearingFeeIndicator) {}
        public AllocClearingFeeIndicator(string val)
            :base(Tags.AllocClearingFeeIndicator, val) {}

    }


    /// <summary>
    /// DefaultApplVerID Field
    /// </summary>/
    public sealed class DefaultApplVerID : StringField
    {
        public DefaultApplVerID()
            :base(Tags.DefaultApplVerID) {}
        public DefaultApplVerID(string val)
            :base(Tags.DefaultApplVerID, val) {}

    }


    /// <summary>
    /// DisplayQty Field
    /// </summary>/
    public sealed class DisplayQty : DecimalField
    {
        public DisplayQty()
            :base(Tags.DisplayQty) {}
        public DisplayQty(Decimal val)
            :base(Tags.DisplayQty, val) {}

    }


    /// <summary>
    /// ExchangeSpecialInstructions Field
    /// </summary>/
    public sealed class ExchangeSpecialInstructions : StringField
    {
        public ExchangeSpecialInstructions()
            :base(Tags.ExchangeSpecialInstructions) {}
        public ExchangeSpecialInstructions(string val)
            :base(Tags.ExchangeSpecialInstructions, val) {}

    }


}
