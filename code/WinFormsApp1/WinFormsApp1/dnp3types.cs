// Decompiled with JetBrains decompiler
// Type: dnp3types
// Assembly: dnp3clienttest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7F4F0122-5C1E-4FEA-AC7F-CEED20628A11
// Assembly location: C:\Users\LENOVO\Downloads\DNP3-master\DNP3-master\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\C-sharp\project\dnp3clienttest\obj\x86\Release\dnp3clienttest.exe

using System;
using System.Runtime.InteropServices;

public class dnp3types
{
  public const int DNP3_MAX_RX_MESSAGE = 292;
  public const int DNP3_MAX_TX_MESSAGE = 292;

  public enum eDNP3ApplicationOptionFlag
  {
    DNP3_APP_OPTION_NONE,
  }

  public enum eCommunicationMode
  {
    COMM_SERIAL = 1,
    TCP_IP_MODE = 2,
    UDP_IP_MODE = 3,
  }

  public class eAppErrorCodes
  {
    public const int APP_ERROR_ERRORVALUE_IS_NULL = -1501;
    public const int APP_ERROR_CREATE_FAILED = -1502;
    public const int APP_ERROR_FREE_FAILED = -1503;
    public const int APP_ERROR_INITIALIZE = -1504;
    public const int APP_ERROR_LOADCONFIG_FAILED = -1505;
    public const int APP_ERROR_CHECKALLOCLOGICNODE = -1506;
    public const int APP_ERROR_START_FAILED = -1507;
    public const int APP_ERROR_STOP_FAILED = -1508;
    public const int APP_ERROR_SETDEBUGOPTIONS_FAILED = -1509;
    public const int APP_ERROR_PHYSICALLAYEROPEN_FAILED = -1510;
    public const int APP_ERROR_PHYSICALLAYERCLOSE_FAILED = -1511;
    public const int APP_ERROR_SERIALCOMOPEN_FAILED = -1512;
    public const int APP_ERROR_SERIALCOMCLOSE_FAILED = -1513;
    public const int APP_ERROR_PHYSICALINITIALIZE_FAILED = -1514;
    public const int APP_ERROR_LINKLAYER_INITIALIZE = -1515;
    public const int APP_ERROR_LINKLAYER_DEINITIALIZE = -1516;
    public const int APP_ERROR_LINKLAYER_INVALIDSTATE = -1517;
    public const int APP_ERROR_TCPWAIT_FAILED = -1518;
    public const int APP_ERROR_ETHERNET_INITIALIZATION_FAILED = -1519;
    public const int APP_ERROR_RECEIVE_FAILED = -1520;
    public const int APP_ERROR_DLDECODE_FAILED = -1521;
    public const int APP_ERROR_TRANSLAYER_INITIALIZE = -1522;
    public const int APP_ERROR_TRANSLAYER_FAILED = -1523;
    public const int APP_ERROR_INVALIDDNP3_OBJECTPREFIXCODE = -1524;
    public const int APP_ERROR_DNP3RANGE_SPECIFIER_ERROR = -1525;
    public const int APP_ERROR_DNP3APPL_ASDUPHARSE_FAILED = -1526;
    public const int APP_ERROR_APPLAYER_INITIALIZE_FAILED = -1527;
    public const int APP_ERROR_OBJECTDB_INITIALIZE_FAILED = -1528;
    public const int APP_ERROR_UPDATE_FAILED = -1529;
    public const int APP_ERROR_EVENTBUFFER_INITIALIZE_FAILED = -1530;
    public const int APP_ERROR_DNP3APPL_INVALID_OHDO = -1531;
    public const int APP_ERROR_DNP3APPL_INVALID_VARIATION = -1532;
    public const int APP_ERROR_DNP3APPL_INVALID_QUALIFIER = -1533;
    public const int APP_ERROR_DNP3APPL_INVALID_INDEX = -1534;
    public const int APP_ERROR_LOADCONFIG_INVALID_VAR = -1535;
    public const int APP_ERROR_CREATESEMAPHORE_PHYSCIALLAYER = -1536;
    public const int APP_ERROR_DELETESEMAPHORE_PHYSCIALLAYER = -1537;
    public const int APP_ERROR_RESERVESEMAPHORE_PHYSCIALLAYER = -1538;
    public const int APP_ERROR_CREATESEMAPHORE_TRANSPORTLAYER = -1539;
    public const int APP_ERROR_DELETESEMAPHORE_TRANSPORTLAYER = -1540;
    public const int APP_ERROR_RESERVESEMAPHORE_TRANSPORTLAYER = -1541;
    public const int APP_ERROR_TIMESTRUCT_INVALID = -1542;
    public const int APP_ERROR_READ_FAILED = -1543;
    public const int APP_ERROR_WRITE_FAILED = -1544;
    public const int APP_ERROR_SELECT_FAILED = -1545;
    public const int APP_ERROR_OPERATE_FAILED = -1546;
    public const int APP_ERROR_CANCEL_FAILED = -1547;
    public const int APP_ERROR_GETDATATYPEANDSIZE_FAILED = -1548;
    public const int APP_ERROR_INVALID_POINTCOUNT = -1549;
    public const int APP_ERROR_TCPCONNECT_FAILED = -1550;
    public const int APP_ERROR_COMMAND_FAILED = -1551;
    public const int APP_ERROR_FILEREAD_FAILED = -1552;
    public const int APP_ERROR_DATASET_READ_FAILED = -1553;
    public const int APP_ERROR_CLIENTSTATUS_FAILED = -1554;
    public const int APP_ERROR_FILEWRITE_FAILED = -1555;
    public const int APP_ERROR_READ_DEVICEATTRIBUTE_FAILED = -1556;
    public const int APP_ERROR_GETIIN1_FAILED = -1557;
    public const int APP_ERROR_GET_OBJECTSTATUS_FAILED = -1558;
    public const int APP_ERROR_CLIENT_STOPSERVERMULTIDROP = -1559;
  }

  public class eAppErrorValues
  {
    public const int APP_ERRORVALUE_ERRORCODE_IS_NULL = -1501;
    public const int APP_ERRORVALUE_INVALID_INPUTPARAMETERS = -1502;
    public const int APP_ERRORVALUE_INVALID_APPFLAG = -1503;
    public const int APP_ERRORVALUE_UPDATECALLBACK_CLIENTONLY = -1504;
    public const int APP_ERRORVALUE_NO_MEMORY = -1505;
    public const int APP_ERRORVALUE_INVALID_DNP3OBJECT = -1506;
    public const int APP_ERRORVALUE_DNP3FREE_CALLED_BEFORE_STOP = -1507;
    public const int APP_ERRORVALUE_INVALID_STATE = -1508;
    public const int APP_ERRORVALUE_INVALID_DEBUG_OPTION = -1509;
    public const int APP_ERRORVALUE_INVALID_COMMODE = -1510;
    public const int APP_ERRORVALUE_TASK_CREATEFAILED = -1511;
    public const int APP_ERRORVALUE_TASK_STOPFAILED = -1512;
    public const int APP_ERRORVALUE_DATALINKLAYER_INVALIDSTATE = -1513;
    public const int APP_ERRORVALUE_DLRECEIVE_INVALIDSTARTCHAR = -1514;
    public const int APP_ERRORVALUE_DLRECEIVE_INVALIDCRC = -1515;
    public const int APP_ERRORVALUE_DLRECEIVE_INVALIDSLAVEADDRESS = -1516;
    public const int APP_ERRORVALUE_DLDECODE_INVALID_DIRBIT = -1517;
    public const int APP_ERRORVALUE_DLDECODE_INVALID_FUNCTIONCODE = -1518;
    public const int APP_ERRORVALUE_DLDECODE_INVALID_PRMBIT = -1519;
    public const int APP_ERRORVALUE_DLDECODE_INVALID_FCVBIT = -1520;
    public const int APP_ERRORVALUE_TRANSLAYER_INVALID_STATE = -1521;
    public const int APP_ERRORVALUE_TRANSLAYER_INVALID_FIRFIN = -1522;
    public const int APP_ERRORVALUE_INVALID_GROUPID = -1523;
    public const int APP_ERRORVALUE_INVALIDUPDATE_COUNT = -1524;
    public const int APP_ERRORVALUE_UPDATEOBJECT_NOTFOUND = -1525;
    public const int APP_ERRORVALUE_INVALID_DATATYPE = -1526;
    public const int APP_ERRORVALUE_INVALID_DATASIZE = -1527;
    public const int APP_ERRORVALUE_INVALID_BI_STATICVAR = -1528;
    public const int APP_ERRORVALUE_INVALID_DBI_STATICVAR = -1529;
    public const int APP_ERRORVALUE_INVALID_BO_STATICVAR = -1530;
    public const int APP_ERRORVALUE_INVALID_CI_STATICVAR = -1531;
    public const int APP_ERRORVALUE_INVALID_FZCI_STATICVAR = -1532;
    public const int APP_ERRORVALUE_INVALID_AI_STATICVAR = -1533;
    public const int APP_ERRORVALUE_INVALID_FZAI_STATICVAR = -1534;
    public const int APP_ERRORVALUE_INVALID_AID_STATICVAR = -1535;
    public const int APP_ERRORVALUE_INVALID_AO_STATICVAR = -1536;
    public const int APP_ERRORVALUE_INVALID_BI_EVENTVAR = -1537;
    public const int APP_ERRORVALUE_INVALID_DBI_EVENTVAR = -1538;
    public const int APP_ERRORVALUE_INVALID_CI_EVENTVAR = -1539;
    public const int APP_ERRORVALUE_INVALID_AI_EVENTVAR = -1540;
    public const int APP_ERRORVALUE_INVALID_FZCI_EVENTVAR = -1541;
    public const int APP_ERRORVALUE_INVALID_FZAI_EVENTVAR = -1542;
    public const int APP_ERRORVALUE_INVALID_COM_MODE = -1543;
    public const int APP_ERRORVALUE_INVALID_COMPORT_NUMBER = -1544;
    public const int APP_ERRORVALUE_INVALID_BAUD_RATE = -1545;
    public const int APP_ERRORVALUE_INVALID_PARITY = -1546;
    public const int APP_ERRORVALUE_INVALID_STOPBIT = -1547;
    public const int APP_ERRORVALUE_INVALID_WORDLENGTH = -1548;
    public const int APP_ERRORVALUE_INVALID_FLOWCONTROL = -1549;
    public const int APP_ERRORVALUE_INVALID_ETHERNETCOMMODE = -1550;
    public const int APP_ERRORVALUE_INVALID_IPPORTNUMBER = -1551;
    public const int APP_ERRORVALUE_INVALID_DEBUGOPTION = -1552;
    public const int APP_ERRORVALUE_INVALID_MASTER_ADDRESS = -1553;
    public const int APP_ERRORVALUE_INVALID_SLAVE_ADDRESS = -1554;
    public const int APP_ERRORVALUE_INVALID_SLAVEMASTER_ADDRESSSAME = -1555;
    public const int APP_ERRORVALUE_INVALID_LINKLAYER_TIMEOUT = -1556;
    public const int APP_ERRORVALUE_INVLAID_EVENTBUFFER_SIZE = -1557;
    public const int APP_ERRORVALUE_INVLAID_EVENTBUF_OVERFLOWPER = -1558;
    public const int APP_ERRORVALUE_INVALID_DATETIME_STRUCT = -1559;
    public const int APP_ERRORVALUE_INVALID_NUMBEROFOBJECTS = -1560;
    public const int APP_ERRORVALUE_INVALID_DNP3OBJECTS = -1561;
    public const int APP_ERRORVALUE_INVALID_MAXNOOFEVENTSUNSOL = -1562;
    public const int APP_ERRORVALUE_READCALLBACK_CLIENTONLY = -1563;
    public const int APP_ERRORVALUE_CANCELCALLBACK_CLIENTONLY = -1564;
    public const int APP_ERRORVALUE_INVALID_DATAPOINTER = -1565;
    public const int APP_ERRORVALUE_INVALID_POINTCOUNT = -1566;
    public const int APP_ERRORVALUE_INVALID_INDEX = -1567;
    public const int APP_ERRORVALUE_INVALID_APPSQUENCE = -1568;
    public const int APP_ERRORVALUE_INVALID_CONTROLMODEL = -1569;
    public const int APP_ERRORVALUE_SERVER_NOTCONNECTED = -1570;
    public const int APP_ERRORVALUE_INVALID_OPTYPE = -1571;
    public const int APP_ERRORVALUE_INVALID_DEADBANDCALCULATION_METHOD = -1572;
    public const int APP_ERRORVALUE_INVALID_CCOMMANDTIMEOUT = -1573;
    public const int APP_ERRORVALUE_COMMAND_TIMEOUT = -1574;
    public const int APP_ERRORVALUE_FILE_INVALIDINPUTFILE = -1575;
    public const int APP_ERRORVALUE_FILEREAD_PERMISSION_DENIED = -1576;
    public const int APP_ERRORVALUE_FILEREAD_INVALID_MODE = -1577;
    public const int APP_ERRORVALUE_FILEREAD_FILE_NOT_FOUND = -1578;
    public const int APP_ERRORVALUE_FILEREAD_FILE_LOCKED = -1579;
    public const int APP_ERRORVALUE_FILEREAD_TOO_MANY_OPEN = -1580;
    public const int APP_ERRORVALUE_FILEREAD_INVALID_HANDLE = -1581;
    public const int APP_ERRORVALUE_FILEREAD_WRITE_BLOCK_SIZE = -1582;
    public const int APP_ERRORVALUE_FILEREAD_COMM_LOST = -1583;
    public const int APP_ERRORVALUE_FILEREAD_CANNOT_ABORT = -1584;
    public const int APP_ERRORVALUE_FILEREAD_NOT_OPENED = -1585;
    public const int APP_ERRORVALUE_FILE_INVALID_OUTPUTFILE = -1586;
    public const int APP_ERRORVALUE_CALLBACK_TIMEOUT = -1587;
    public const int APP_ERRORVALUE_CALLBACK_NO_SELECT = -1588;
    public const int APP_ERRORVALUE_CALLBACK_FORMAT_ERROR = -1589;
    public const int APP_ERRORVALUE_CALLBACK_NOT_SUPPORTED = -1590;
    public const int APP_ERRORVALUE_CALLBACK_ALREADY_ACTIVE = -1591;
    public const int APP_ERRORVALUE_CALLBACK_HARDWARE_ERROR = -1592;
    public const int APP_ERRORVALUE_CALLBACK_LOCAL = -1593;
    public const int APP_ERRORVALUE_CALLBACK_NOT_AUTHORIZED = -1594;
    public const int APP_ERRORVALUE_CALLBACK_AUTOMATION_INHIBIT = -1595;
    public const int APP_ERRORVALUE_CALLBACK_PROCESSING_LIMITED = -1596;
    public const int APP_ERRORVALUE_CALLBACK_OUT_OF_RANGE = -1597;
    public const int APP_ERRORVALUE_CALLBACK_NON_PARTICIPATING = -1598;
    public const int APP_ERRORVALUE_CALLBACK_UNDEFINED = -1599;
    public const int APP_ERRORVALUE_INVALID_DEADBAND = -1600;
    public const int APP_ERRORVALUE_INVALID_SBO_TIMEOUT = -1601;
    public const int APP_ERRORVALUE_INVALID_APPLAYER_TIMEOUT = -1602;
    public const int APP_ERRORVALUE_INVALID_TIMESYNC_TIMEOUT = -1603;
    public const int APP_ERRORVALUE_FILETRANSFER_DISABLED = -1604;
    public const int APP_ERRORVALUE_INVALID_INTIAL_DATABASE_QUALITYFLAG = -1605;
    public const int APP_ERRORVALUE_DEMO_EXPIRED = -1606;
    public const int APP_ERRORVALUE_DEMO_INVALID_POINTCOUNT = -1607;
    public const int APP_ERRORVALUE_SERVER_DISABLED = -1608;
    public const int APP_ERRORVALUE_CLIENT_DISABLED = -1609;
    public const int APP_ERRORVALUE_INVALID_BO_EVENTVAR = -1610;
    public const int APP_ERRORVALUE_INVALID_AO_EVENTVAR = -1611;
    public const int APP_ERRORVALUE_FILEREAD_HANDLE_EXPIRED = -1612;
    public const int APP_ERRORVALUE_FILEREAD_BUFFER_OVERRUN = -1613;
    public const int APP_ERRORVALUE_FILEREAD_FATAL = -1614;
    public const int APP_ERRORVALUE_FILEREAD_BLOCK_SEQ = -1615;
    public const int APP_ERRORVALUE_INVALID_CROB_TCC_VALUE = -1616;
    public const int APP_ERRORVALUE_INVALID_COMMAND_VARIATION = -1617;
  }

  public enum eDNP3QualityFlags
  {
    GOOD = 0,
    ONLINE = 1,
    RESTART = 2,
    COMM_LOST = 4,
    REMOTE_FORCED = 8,
    LOCAL_FORCED = 16, // 0x00000010
    CHATTER_FILTER = 32, // 0x00000020
    ROLLOVER = 64, // 0x00000040
    OVER_RANGE = 128, // 0x00000080
    DISCONTINUITY = 256, // 0x00000100
    REFERENCE_ERR = 512, // 0x00000200
  }

  public enum eDNP3GroupID
  {
    BINARY_INPUT = 1,
    DOUBLE_INPUT = 3,
    BINARY_OUTPUT = 10, // 0x0000000A
    COUNTER_INPUT = 20, // 0x00000014
    FRCOUNTER_INPUT = 21, // 0x00000015
    ANALOG_INPUT = 30, // 0x0000001E
    FRANALOG_INPUT = 31, // 0x0000001F
    ANALOG_OUTPUTS = 40, // 0x00000028
    DATE_TIME = 50, // 0x00000032
    OCTECT_STRING = 110, // 0x0000006E
    VIRTUAL_TERMINAL_OUTPUT = 112, // 0x00000070
  }

  public enum eDefaultStaticVariationBinaryInput
  {
    BI_PACKED_FORMAT = 1,
    BI_WITH_FLAGS = 2,
  }

  public enum eDefaultStaticVariationDoubleBitBinaryInput
  {
    DBBI_PACKED_FORMAT = 1,
    DBBI_WITH_FLAGS = 2,
  }

  public enum eDefaultStaticVariationBinaryOutput
  {
    BO_PACKED_FORMAT = 1,
    BO_WITH_FLAGS = 2,
  }

  public enum eDefaultStaticVariationCounterInput
  {
    CI_32BIT_WITHFLAG = 1,
    CI_16BIT_WITHFLAG = 2,
    CI_32BIT_WITHOUTFLAG = 5,
    CI_16BIT_WITHOUTFLAG = 6,
  }

  public enum eDefaultStaticVariationFrozenCounterInput
  {
    FCI_32BIT_WITHFLAG = 1,
    FCI_16BIT_WITHFLAG = 2,
    FCI_32BIT_WITHFLAGANDTIME = 5,
    FCI_16BIT_WITHFLAGANDTIME = 6,
    FCI_32BIT_WITHOUTFLAG = 9,
    FCI_16BIT_WITHOUTFLAG = 10, // 0x0000000A
  }

  public enum eDefaultStaticVariationAnalogInput
  {
    AI_32BIT_WITHFLAG = 1,
    AI_16BIT_WITHFLAG = 2,
    AI_32BIT_WITHOUTFLAG = 3,
    AI_16BIT_WITHOUTFLAG = 4,
    AI_SINGLEPREC_FLOATWITHFLAG = 5,
  }

  public enum eDefaultStaticVariationFrozenAnalogInput
  {
    FAI_32BITWITHFLAG = 1,
    FAI_16BITWITHFLAG = 2,
    FAI_32BITWITHTIMEOFFREEZE = 3,
    FAI_16BITWITHTIMEOFFREEZE = 4,
    FAI_32BITWITHOUTFLAG = 5,
    FAI_16BITWITHOUTFLAG = 6,
    FAI_SINGLEPRECFLOATWITHFLAG = 7,
  }

  public enum eDefaultStaticVariationAnalogInputDeadBand
  {
    DAI_16BIT = 1,
    DAI_32BIT = 2,
    DAI_SINGLEPRECFLOAT = 3,
  }

  public enum eDefaultStaticVariationAnalogOutput
  {
    AO_32BIT_WITHFLAG = 1,
    AO_16BIT_WITHFLAG = 2,
    AO_SINGLEPRECFLOAT_WITHFLAG = 3,
  }

  public enum eDefaultEventVariationBinaryInput
  {
    BIE_WITHOUT_TIME = 1,
    BIE_WITH_ABSOLUTETIME = 2,
    BIE_WITH_RELATIVETIME = 3,
  }

  public enum eDefaultEventVariationDoubleBitBinaryInput
  {
    DBBIE_WITHOUT_TIME = 1,
    DBBIE_WITH_ABSOLUTETIME = 2,
    DBBIE_WITH_RELATIVETIME = 3,
  }

  public enum eDefaultEventVariationCounterInput
  {
    CIE_32BIT_WITHFLAG = 1,
    CIE_16BIT_WITHFLAG = 2,
    CIE_32BIT_WITHFLAG_WITHTIME = 5,
    CIE_16BIT_WITHFLAG_WITHTIME = 6,
  }

  public enum eDefaultEventVariationFrozenCounterInput
  {
    FCIE_32BIT_WITHFLAG = 1,
    FCIE_16BIT_WITHFLAG = 2,
    FCIE_32BIT_WITHFLAG_WITHTIME = 5,
    FCIE_16BIT_WITHFLAG_WITHTIME = 6,
  }

  public enum eDefaultEventVariationAnalogInput
  {
    AIE_32BIT_WITHOUTTIME = 1,
    AIE_16BIT_WITHOUTTIME = 2,
    AIE_32BIT_WITHTIME = 3,
    AIE_16BIT_WITHTIME = 4,
    AIE_SINGLEPREC_WITHOUTTIME = 5,
    AIE_SINGLEPREC_WITHTIME = 7,
  }

  public enum eDefaultEventVariationAnalogOutput
  {
    AOE_32BIT_WITHOUTTIME = 1,
    AOE_16BIT_WITHOUTTIME = 2,
    AOE_32BIT_WITHTIME = 3,
    AOE_16BIT_WITHTIME = 4,
    AOE_SINGLEPREC_WITHOUTTIME = 5,
    AOE_SINGLEPREC_WITHTIME = 7,
  }

  public enum eDefaultEventVariationFrozenAnalogInput
  {
    FAIE_32BIT_WITHOUTTIME = 1,
    FAIE_16BIT_WITHOUTTIME = 2,
    FAIE_32BIT_WITHTIME = 3,
    FAIE_16BIT_WITHTIME = 4,
    FAIE_SINGLEPREC_WITHOUTTIME = 5,
    FAIE_SINGLEPREC_WITHTIME = 7,
  }

  public enum eDefaultEventVariationBinaryOutput
  {
    BOE_WITHOUT_TIME = 1,
    BOE_WITH_TIME = 2,
  }

  public enum eDNP3ClassID
  {
    NO_CLASS,
    CLASS_ONE,
    CLASS_TWO,
    CLASS_THREE,
  }

  public enum eDNP3ControlModelConfig
  {
    INPUT_STATUS_ONLY,
    DIRECT_OPERATION,
    SELECT_BEFORE_OPERATION,
  }

  public enum eClassSet
  {
    CLASS1_SETTINGS,
    CLASS2_SETTINGS,
    CLASS3_SETTINGS,
  }

  public enum eWriteFunctionID
  {
    READCLASS0 = 1,
    READCLASS1 = 2,
    READCLASS2 = 3,
    READCLASS3 = 4,
    READCLASS123 = 5,
    READCLASS0123 = 6,
    TIMESYNC = 7,
    CLEARRESTARTIIN = 8,
    ENABLESPONT = 9,
    DISABLESPONT = 10, // 0x0000000A
    COLDRESTART = 11, // 0x0000000B
    WARMRESTART = 12, // 0x0000000C
    DELAYMEASURE = 13, // 0x0000000D
    COUNTER_IMMEDIATE_FREEZE = 14, // 0x0000000E
    COUNTER_IMMEDIATE_FREEZE_NOACK = 15, // 0x0000000F
    COUNTER_FREEZE_AND_CLEAR = 16, // 0x00000010
    COUNTER_FREEZE_AND_CLEAR_NOACK = 17, // 0x00000011
    AI_IMMEDIATE_FREEZE = 18, // 0x00000012
    AI_IMMEDIATE_FREEZE_NOACK = 19, // 0x00000013
    AI_FREEZE_AND_CLEAR = 20, // 0x00000014
    AI_FREEZE_AND_CLEAR_NOACK = 21, // 0x00000015
  }

  public enum eAnalogInputDeadbandMethod
  {
    DEADBAND_NONE,
    DEADBAND_FIXED,
    DEADBAND_INTEGRATING,
  }

  public enum eIINFirstByteBitsFlag
  {
    BROADCAST = 1,
    CLASS_1_EVENTS = 2,
    CLASS_2_EVENTS = 4,
    CLASS_3_EVENTS = 8,
    NEED_TIME = 16, // 0x00000010
    LOCAL_CONTROL = 32, // 0x00000020
    DEVICE_TROUBLE = 64, // 0x00000040
    DEVICE_RESTART = 128, // 0x00000080
  }

  public enum eIINSecondByteBitsFlag
  {
    NO_FUNC_CODE_SUPPORT = 1,
    OBJECT_UNKNOWN = 2,
    PARAMETER_ERROR = 4,
    EVENT_BUFFER_OVERFLOW = 8,
    ALREADY_EXECUTING = 16, // 0x00000010
    CONFIG_CORRUPT = 32, // 0x00000020
    RESERVED_2 = 64, // 0x00000040
    RESERVED_1 = 128, // 0x00000080
  }

  public enum eOperationType
  {
    NUL,
    PULSE_ON,
    PULSE_OFF,
    LATCH_ON,
    LATCH_OFF,
  }

  public enum eTripCloseCode
  {
    NULLL,
    CLOSE,
    TRIP,
    RESERVED,
  }

  public enum eServerConnectionStatus
  {
    SERVER_NOTCONNECTED,
    SERVER_CONNECTED,
    SERVER_STOPPED_BY_USER,
  }

  public enum eFileType
  {
    DIRECTORY_TYPE,
    SIMPLE_FILE,
  }

  public enum eCommandObjectVariation
  {
    CROB_G12V1 = 1,
    ANALOG_OUTPUT_BLOCK_INTEGER32 = 2,
    ANALOG_OUTPUT_BLOCK_INTEGER16 = 3,
    ANALOG_OUTPUT_BLOCK_FLOAT32 = 4,
  }

  public enum eUpdateClassID
  {
    UPDATE_DEFAULT_EVENT,
    UPDATE_NO_CLASS,
    UPDATE_CLASS_ONE,
    UPDATE_CLASS_TWO,
    UPDATE_CLASS_THREE,
  }

  public enum eAnalogStorageType
  {
    AS_FLOAT,
    AS_INTEGER32,
  }

  public enum eUpdateCause
  {
    STATIC_DATA,
    POLLED_EVENT,
    UNSOLICITED_EVENT,
  }

  public enum eLinkLayerConform
  {
    CONFORM_NEVER,
    CONFORM_ALWAYS,
  }

  public struct sDatasetpsvalueeelement
  {
    public byte u8Datasetvaluelength;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U1)]
    public byte[] au8Datasetvalue;
  }

  public struct sDatasetPsvalue
  {
    public uint u32ID;
    public tgtcommon.sTargetTimeStamp sTimeStamp;
    public ushort u16Noofdatasetpseelement;
    public IntPtr psDatasetpsvalueeelement;
  }

  public struct sClientDatasetPresentvalue
  {
    public uint u32NoofDefinedDataSetDescriptor;
    public IntPtr psDatasetPsvalue;
  }

  public struct sDatasetprototypeelement
  {
    public byte u8Descriptorcode;
    public byte u8Datatypecode;
    public byte u8Maxdatalength;
    public byte u8Auxdatasetvaluelength;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U1)]
    public byte[] au8Auxdatasetvalue;
  }

  public struct sDatasetPrototype
  {
    public ushort u16Noofdatasetprototypeelement;
    public IntPtr psDatasetprototypeelement;
  }

  public struct sClientDatasetPrototype
  {
    public uint u32NoofDefinedDataSetPrototype;
    public IntPtr psDatasetPrototype;
  }

  public struct sEthernetPortSettings
  {
    public ushort u16PortNumber;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ai8FromIPAddress;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ai8ToIPAddress;
  }

  public struct sEthernetCommunicationSettings
  {
    public byte bServerUDPtransmitPortNumberdefault;
    public dnp3types.sEthernetPortSettings sEthernetportSet;
  }

  public struct sDNP3Object
  {
    public dnp3types.eDNP3GroupID eGroupID;
    public ushort u16NoofPoints;
    public dnp3types.eDNP3ClassID eClassID;
    public dnp3types.eDNP3ControlModelConfig eControlModel;
    public uint u32SBOTimeOut;
    public float f32AnalogInputDeadband;
    public dnp3types.eAnalogStorageType eAnalogStoreType;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
    public string ai8Name;
  }

  public struct sDNP3DebugParameters
  {
    public uint u32DebugOptions;
  }

  public struct sDefaultStaticVariation
  {
    public dnp3types.eDefaultStaticVariationBinaryInput eDeStVarBI;
    public dnp3types.eDefaultStaticVariationDoubleBitBinaryInput eDeStVarDBI;
    public dnp3types.eDefaultStaticVariationBinaryOutput eDeStVarBO;
    public dnp3types.eDefaultStaticVariationCounterInput eDeStVarCI;
    public dnp3types.eDefaultStaticVariationFrozenCounterInput eDeStVarFzCI;
    public dnp3types.eDefaultStaticVariationAnalogInput eDeStVarAI;
    public dnp3types.eDefaultStaticVariationFrozenAnalogInput eDeStVarFzAI;
    public dnp3types.eDefaultStaticVariationAnalogInputDeadBand eDeStVarAID;
    public dnp3types.eDefaultStaticVariationAnalogOutput eDeStVarAO;
  }

  public struct sDefaultEventVariation
  {
    public dnp3types.eDefaultEventVariationBinaryInput eDeEvVarBI;
    public dnp3types.eDefaultEventVariationDoubleBitBinaryInput eDeEvVarDBI;
    public dnp3types.eDefaultEventVariationCounterInput eDeEvVarCI;
    public dnp3types.eDefaultEventVariationAnalogInput eDeEvVarAI;
    public dnp3types.eDefaultEventVariationFrozenCounterInput eDeEvVarFzCI;
    public dnp3types.eDefaultEventVariationFrozenAnalogInput eDeEvVarFzAI;
    public dnp3types.eDefaultEventVariationBinaryOutput eDeEvVarBO;
    public dnp3types.eDefaultEventVariationAnalogOutput eDeEvVarAO;
  }

  public struct sUnsolicitedResponseSettings
  {
    public byte bEnableUnsolicited;
    public byte bEnableResponsesonStartup;
    public uint u32Timeout;
    public byte u8Retries;
    public ushort u16MaxNumberofEvents;
    public ushort u16Class1TriggerNumberofEvents;
    public ushort u16Class1HoldTimeAfterResponse;
    public ushort u16Class2TriggerNumberofEvents;
    public ushort u16Class2HoldTimeAfterResponse;
    public ushort u16Class3TriggerNumberofEvents;
    public ushort u16Class3HoldTimeAfterResponse;
  }

  public struct sDeviceAttributes
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string ai8HW_VERSION;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string ai8LOCATION;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string ai8ID_CODE;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string ai8DEVICE_NAME;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string ai8SERIAL_NUMBER;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string ai8PRODUCTNAME_MODEL;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string ai8MANUFACTURE_NAME;
  }

  public struct sServerCommunicationSettings
  {
    public dnp3types.eCommunicationMode eCommMode;
    public dnp3types.sEthernetCommunicationSettings sEthernetCommsSet;
    public tgtserialtypes.sSerialCommunicationSettings sSerialSet;
  }

  public struct sServerProtocolSettings
  {
    public ushort u16SlaveAddress;
    public uint u32LinkLayerTimeout;
    public uint u32ApplicationLayerTimeout;
    public ushort u16MasterAddress;
    public dnp3types.sUnsolicitedResponseSettings sUnsolicitedResponseSet;
    public uint u32TimeSyncIntervalSeconds;
    public dnp3types.sDefaultStaticVariation sStaticVariation;
    public dnp3types.sDefaultEventVariation sEventVariation;
    public tgtcommon.sTargetTimeStamp sTimeStamp;
    public byte bAddBIinClass0;
    public byte bAddDBIinClass0;
    public byte bAddBOinClass0;
    public byte bAddCIinClass0;
    public byte bAddFzCIinClass0;
    public byte bAddAIinClass0;
    public byte bAddFzAIinClass0;
    public byte bAddAIDinClass0;
    public byte bAddAOinClass0;
    public byte bAddOSinClass0;
    public byte bAddBIEvent;
    public byte bAddDBIEvent;
    public byte bAddBOEvent;
    public byte bAddCIEvent;
    public byte bAddFzCIEvent;
    public byte bAddAIEvent;
    public byte bAddFzAIEvent;
    public byte bAddAIDEvent;
    public byte bAddAOEvent;
    public byte bAddOSEvent;
    public byte bAddVTOEvent;
    public dnp3types.eAnalogInputDeadbandMethod eAIDeadbandMethod;
    public byte bFrozenAnalogInputSupport;
    public byte bEnableSelfAddressSupport;
    public byte bEnableFileTransferSupport;
    public byte u8IntialdatabaseQualityFlag;
    public byte bLocalMode;
    public byte bUpdateCheckTimestamp;
    public ushort u16Class1EventBufferSize;
    public byte u8Class1EventBufferOverFlowPercentage;
    public ushort u16Class2EventBufferSize;
    public byte u8Class2EventBufferOverFlowPercentage;
    public ushort u16Class3EventBufferSize;
    public byte u8Class3EventBufferOverFlowPercentage;
    public dnp3types.sDeviceAttributes sConfigureDeviceAttributes;
  }

  public struct sDNP3ServerSettings
  {
    public dnp3types.sServerCommunicationSettings sServerCommunicationSet;
    public dnp3types.sDNP3DebugParameters sDebug;
    public dnp3types.sServerProtocolSettings sServerProtSet;
    public ushort u16NoofObject;
    public byte benabaleUTCtime;
    public IntPtr psDNP3Objects;
  }

  public struct sClientCommunicationSettings
  {
    public tgtserialtypes.sSerialCommunicationSettings sSerialSet;
    public dnp3types.sEthernetPortSettings sEthernetCommsSet;
  }

  public struct sClientProtocolSettings
  {
    public ushort u16MasterAddress;
    public ushort u16SlaveAddress;
    public uint u32LinkLayerTimeout;
    public uint u32ApplicationTimeout;
    public uint u32Class123pollInterval;
    public uint u32Class0123pollInterval;
    public uint u32Class0pollInterval;
    public uint u32Class1pollInterval;
    public uint u32Class2pollInterval;
    public uint u32Class3pollInterval;
    public byte bDisableUnsolicitedStatup;
    public byte bFrozenAnalogInputSupport;
    public byte bEnableFileTransferSupport;
    public byte bDisableResetofRemotelink;
    public dnp3types.eLinkLayerConform eLinkConform;
  }

  public struct sDNP3clObject
  {
    public ushort u16StartingIndexAddress;
    public ushort u16NoofPoints;
    public dnp3types.eDNP3GroupID eGroupID;
    public dnp3types.eDNP3ClassID eClassID;
    public dnp3types.eDNP3ControlModelConfig eControlModel;
    public uint u32SBOTimeOut;
    public float f32AnalogInputDeadband;
    public dnp3types.eAnalogStorageType eAnalogStoreType;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
    public string ai8Name;
  }

  public struct sClientObject
  {
    public dnp3types.eCommunicationMode eCommMode;
    public dnp3types.sClientCommunicationSettings sClientCommunicationSet;
    public dnp3types.sClientProtocolSettings sClientProtSet;
    public uint u32CommandTimeout;
    public uint u32FileOperationTimeout;
    public ushort u16NoofObject;
    public IntPtr psDNP3Objects;
  }

  public struct sDNP3ClientSettings
  {
    public byte bAutoGenDNP3DataObjects;
    public ushort u16UpdateBuffersize;
    public dnp3types.sDNP3DebugParameters sDebug;
    public tgtcommon.sTargetTimeStamp sTimeStamp;
    public byte benabaleUTCtime;
    public byte bUpdateCallbackCheckTimestamp;
    public ushort u16NoofClient;
    public IntPtr psClientObjects;
  }

  public struct sDNP3ConfigurationParameters
  {
    public dnp3types.sDNP3ServerSettings sDNP3ServerSet;
    public dnp3types.sDNP3ClientSettings sDNP3ClientSet;
  }

  public struct sDNP3DataAttributeID
  {
    public dnp3types.eCommunicationMode eCommMode;
    public ushort u16SerialPortNumber;
    public ushort u16PortNumber;
    public ushort u16SlaveAddress;
    public dnp3types.eDNP3GroupID eGroupID;
    public ushort u16IndexNumber;
    public IntPtr pvUserData;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ai8IPAddress;
  }

  public struct sDNP3DataAttributeData
  {
    public tgtcommon.sTargetTimeStamp sTimeStamp;
    public ushort tQuality;
    public tgtcommon.eDataTypes eDataType;
    public tgttypes.eDataSizes eDataSize;
    public tgtcommon.eTimeQualityFlags eTimeQuality;
    public IntPtr pvData;
  }

  public struct sDNP3FileAttributeData
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 242)]
    public string ai8sourceFile;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 242)]
    public string ai8DestinationFile;
  }

  public struct sFileDescriptor
  {
    public ushort u16FileNameOffset;
    public ushort u16Filenamesize;
    public dnp3types.eFileType eFltype;
    public uint u32Filesize;
    public ushort u16Permissions;
    public ushort u16RequestID;
    public tgtcommon.sTargetTimeStamp sTimeStamp;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 242)]
    public string ai8Filename;
  }

  public struct sDNP3DirAttributeData
  {
    public ushort u16TotalNumberofFiles;
    public IntPtr psFileDescriptor;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 242)]
    public string ai8DestinationDirPath;
  }

  public struct sDNP3CommandParameters
  {
    public dnp3types.eCommandObjectVariation eCommandVariation;
    public dnp3types.eOperationType eOPType;
    public byte u8Count;
    public uint u32ONtime;
    public uint u32OFFtime;
    public byte bCR;
  }

  public struct sDNP3WriteParameters
  {
    public byte u8Dummy;
  }

  public struct sDNP3ReadParameters
  {
    public byte u8Dummy;
  }

  public struct sDNP3UpdateParameters
  {
    public byte u8Group;
    public byte u8Variation;
    public dnp3types.eUpdateCause eUpCause;
  }

  public struct sDNP3DebugData
  {
    public uint u32DebugOptions;
    public short i16ErrorCode;
    public short tErrorValue;
    public dnp3types.eCommunicationMode eCommMode;
    public ushort u16ComportNumber;
    public ushort u16RxCount;
    public ushort u16TxCount;
    public ushort u16PortNumber;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 292)]
    public byte[] au8RxData;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 292)]
    public byte[] au8TxData;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
    public string au8ErrorMessage;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
    public string au8WarningMessage;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ai8IPAddress;
  }

  public struct sServerDatabasePoint
  {
    public dnp3types.eDNP3GroupID eGroupID;
    public ushort u16IndexNumber;
    public tgtcommon.eDataTypes eDataType;
    public tgttypes.eDataSizes eDataSize;
    public ushort tQuality;
    public tgtcommon.sTargetTimeStamp sTimeStamp;
    public IntPtr pvData;
  }

  public struct sDNPServerDatabase
  {
    public uint u32TotalPoints;
    public IntPtr psServerDatabasePoint;
  }

  public struct sClientDatabasePoint
  {
    public dnp3types.eCommunicationMode eCommMode;
    public ushort u16SerialPortNumber;
    public ushort u16PortNumber;
    public ushort u16SlaveAddress;
    public dnp3types.eDNP3GroupID eGroupID;
    public tgtcommon.eDataTypes eDataType;
    public tgttypes.eDataSizes eDataSize;
    public ushort u16IndexNumber;
    public dnp3types.eDNP3ClassID eClassID;
    public ushort tQuality;
    public tgtcommon.sTargetTimeStamp sTimeStamp;
    public IntPtr pvData;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ai8IPAddress;
  }

  public struct sDNPClientDatabase
  {
    public uint u32TotalPoints;
    public IntPtr psClientDatabasePoint;
  }

  public struct sDNP3DeviceAttributeData
  {
    public byte u8Variation;
    public byte u8Datatype;
    public ushort u16Length;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.U2)]
    public byte[] u8Data;
  }

  public struct sDNP3ErrorCode
  {
    public short iErrorCode;
    public IntPtr shortDes;
    public IntPtr LongDes;
  }

  public struct sDNP3ErrorValue
  {
    public short iErrorValue;
    public IntPtr shortDes;
    public IntPtr LongDes;
  }

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3ReadCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DataAttributeID ptReadID,
    ref dnp3types.sDNP3DataAttributeData ptReadValue,
    ref dnp3types.sDNP3ReadParameters ptReadParams,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3WriteCallback(
    ushort u16ObjectId,
    dnp3types.eWriteFunctionID eFunctionID,
    ref dnp3types.sDNP3DataAttributeID ptWriteID,
    ref dnp3types.sDNP3DataAttributeData ptWriteValue,
    ref dnp3types.sDNP3WriteParameters ptWriteParams,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3UpdateCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DataAttributeID ptUpdateID,
    ref dnp3types.sDNP3DataAttributeData ptUpdateValue,
    ref dnp3types.sDNP3UpdateParameters ptUpdateParams,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3UpdateIINCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DataAttributeID ptUpdateID,
    byte u8IIN1,
    byte u8IIN2,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3ClientPollStatusCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DataAttributeID ptUpdateID,
    dnp3types.eWriteFunctionID eFunctionID,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3ControlSelectCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DataAttributeID psSelectID,
    ref dnp3types.sDNP3DataAttributeData psSelectValue,
    ref dnp3types.sDNP3CommandParameters psSelectParams,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3ControlOperateCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DataAttributeID psOperateID,
    ref dnp3types.sDNP3DataAttributeData psOperateValue,
    ref dnp3types.sDNP3CommandParameters psOperateParams,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3DebugMessageCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DebugData psDebugData,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3ClientStatusCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.eServerConnectionStatus peSat,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3ColdRestartCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3WarmRestartCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref short ptErrorValue);

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public delegate short DNP3DeviceAttributeCallback(
    ushort u16ObjectId,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DeviceAttributeData psDeviceAttrValue,
    ref short ptErrorValue);

  public struct sDNP3Parameters
  {
    public tgtcommon.eApplicationFlag eAppFlag;
    public uint u32Options;
    public ushort u16ObjectId;
    public dnp3types.DNP3ReadCallback ptReadCallback;
    public dnp3types.DNP3WriteCallback ptWriteCallback;
    public dnp3types.DNP3UpdateCallback ptUpdateCallback;
    public dnp3types.DNP3ControlSelectCallback ptSelectCallback;
    public dnp3types.DNP3ControlOperateCallback ptOperateCallback;
    public dnp3types.DNP3DebugMessageCallback ptDebugCallback;
    public dnp3types.DNP3UpdateIINCallback ptUpdateIINCallback;
    public dnp3types.DNP3ClientPollStatusCallback ptClientPollStatusCallback;
    public dnp3types.DNP3ClientStatusCallback ptClientStatusCallback;
    public dnp3types.DNP3ColdRestartCallback ptColdRestartCallback;
    public dnp3types.DNP3WarmRestartCallback ptWarmRestartCallback;
    public dnp3types.DNP3DeviceAttributeCallback ptDeviceAttrCallback;
  }
}
