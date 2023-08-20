// Decompiled with JetBrains decompiler
// Type: iec60870common
// Assembly: dnp3clienttest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7F4F0122-5C1E-4FEA-AC7F-CEED20628A11
// Assembly location: C:\Users\LENOVO\Downloads\DNP3-master\DNP3-master\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\C-sharp\project\dnp3clienttest\obj\x86\Release\dnp3clienttest.exe

public class iec60870common
{
  public const int MAX_DIRECTORY_PATH = 248;
  public const int MAX_CA = 100;

  public enum eApplicationOptionFlag
  {
    APP_OPTION_NONE,
    APP_SEQUENCE_BIT,
  }

  public enum eOperationFlag
  {
    SELECT = 1,
    OPERATE = 2,
  }

  public enum eStatus
  {
    NOT_CONNECTED,
    CONNECTED,
  }

  public enum eCauseofTransmissionSize
  {
    COT_ONE_BYTE = 1,
    COT_TWO_BYTE = 2,
  }

  public enum eIEC870QualityFlags
  {
    GD = 0,
    IV = 1,
    NT = 2,
    SB = 4,
    BL = 8,
    OV = 16, // 0x00000010
    EI = 32, // 0x00000020
    TR = 64, // 0x00000040
    CA = 128, // 0x00000080
    CR = 256, // 0x00000100
  }

  public enum eControlModelConfig
  {
    STATUS_ONLY,
    DIRECT_OPERATE,
    SELECT_BEFORE_OPERATE,
  }

  public enum eCounterFreezeFlags
  {
    COUNTER_READ,
    COUNTER_FREEZE,
    COUNTER_FREEZE_WITH_RESET,
    COUNTER_RESET,
  }

  public enum eKindofParameter
  {
    PARAMETER_NONE,
    PARAMETER_THRESHOLDVALUE,
    PARAMETER_SMOOTHINGFACTOR,
    PARAMETER_LOWLIMIT,
    PARAMETER_HIGHLIMIT,
  }

  public enum eIEC870COTCause
  {
    NOTUSED = 0,
    PERCYC = 1,
    BACK = 2,
    SPONT = 3,
    INIT = 4,
    REQ = 5,
    ACT = 6,
    ACTCON = 7,
    DEACT = 8,
    DEACTCON = 9,
    ACTTERM = 10, // 0x0000000A
    RETREM = 11, // 0x0000000B
    RETLOC = 12, // 0x0000000C
    FILETRANFER = 13, // 0x0000000D
    INROGEN = 20, // 0x00000014
    INRO1 = 21, // 0x00000015
    INRO2 = 22, // 0x00000016
    INRO3 = 23, // 0x00000017
    INRO4 = 24, // 0x00000018
    INRO5 = 25, // 0x00000019
    INRO6 = 26, // 0x0000001A
    INRO7 = 27, // 0x0000001B
    INRO8 = 28, // 0x0000001C
    INRO9 = 29, // 0x0000001D
    INRO10 = 30, // 0x0000001E
    INRO11 = 31, // 0x0000001F
    INRO12 = 32, // 0x00000020
    INRO13 = 33, // 0x00000021
    INRO14 = 34, // 0x00000022
    INRO15 = 35, // 0x00000023
    INRO16 = 36, // 0x00000024
    REQCOGEN = 37, // 0x00000025
    REQCO1 = 38, // 0x00000026
    REQCO2 = 39, // 0x00000027
    REQCO3 = 40, // 0x00000028
    REQCO4 = 41, // 0x00000029
    UNKNOWN_TYPEID = 44, // 0x0000002C
    UNKNOWN_COT = 45, // 0x0000002D
    UNKNOWN_CASDU = 46, // 0x0000002E
    UNKNOWN_IOA = 47, // 0x0000002F
  }

  public enum eStartEventsofProtFlags
  {
    GS = 1,
    SL1 = 2,
    SL2 = 4,
    SL3 = 8,
    SIE = 16, // 0x00000010
    SRD = 32, // 0x00000020
  }

  public enum ePackedOutputCircuitInfoofProtFlags
  {
    GC = 1,
    CL1 = 2,
    CL2 = 4,
    CL3 = 8,
  }

  public enum eCommandQOCQU
  {
    NOADDDEF = 0,
    SHORTPULSE = 1,
    LONGPULSE = 2,
    PERSISTANT = 3,
    COMPATIBLE_RANGE_START = 4,
    COMPATIBLE_RANGE_END = 8,
    PREDEFINED_RANGE_START = 9,
    PREDEFINED_RANGE_END = 15, // 0x0000000F
    PRIVATE_RANGE_START = 16, // 0x00000010
    PRIVATE_RANGE_END = 31, // 0x0000001F
  }

  public enum eIEC870TypeID
  {
    M_SP_NA_1 = 1,
    M_SP_TA_1 = 2,
    M_DP_NA_1 = 3,
    M_DP_TA_1 = 4,
    M_ST_NA_1 = 5,
    M_ST_TA_1 = 6,
    M_BO_NA_1 = 7,
    M_BO_TA_1 = 8,
    M_ME_NA_1 = 9,
    M_ME_TA_1 = 10, // 0x0000000A
    M_ME_NB_1 = 11, // 0x0000000B
    M_ME_TB_1 = 12, // 0x0000000C
    M_ME_NC_1 = 13, // 0x0000000D
    M_ME_TC_1 = 14, // 0x0000000E
    M_IT_NA_1 = 15, // 0x0000000F
    M_IT_TA_1 = 16, // 0x00000010
    M_EP_TA_1 = 17, // 0x00000011
    M_EP_TB_1 = 18, // 0x00000012
    M_EP_TC_1 = 19, // 0x00000013
    M_PS_NA_1 = 20, // 0x00000014
    M_ME_ND_1 = 21, // 0x00000015
    M_SP_TB_1 = 30, // 0x0000001E
    M_DP_TB_1 = 31, // 0x0000001F
    M_ST_TB_1 = 32, // 0x00000020
    M_BO_TB_1 = 33, // 0x00000021
    M_ME_TD_1 = 34, // 0x00000022
    M_ME_TE_1 = 35, // 0x00000023
    M_ME_TF_1 = 36, // 0x00000024
    M_IT_TB_1 = 37, // 0x00000025
    M_EP_TD_1 = 38, // 0x00000026
    M_EP_TE_1 = 39, // 0x00000027
    M_EP_TF_1 = 40, // 0x00000028
    C_SC_NA_1 = 45, // 0x0000002D
    C_DC_NA_1 = 46, // 0x0000002E
    C_RC_NA_1 = 47, // 0x0000002F
    C_SE_NA_1 = 48, // 0x00000030
    C_SE_NB_1 = 49, // 0x00000031
    C_SE_NC_1 = 50, // 0x00000032
    C_BO_NA_1 = 51, // 0x00000033
    C_SC_TA_1 = 58, // 0x0000003A
    C_DC_TA_1 = 59, // 0x0000003B
    C_RC_TA_1 = 60, // 0x0000003C
    C_SE_TA_1 = 61, // 0x0000003D
    C_SE_TB_1 = 62, // 0x0000003E
    C_SE_TC_1 = 63, // 0x0000003F
    C_BO_TA_1 = 64, // 0x00000040
    M_EI_NA_1 = 70, // 0x00000046
    C_IC_NA_1 = 100, // 0x00000064
    C_CI_NA_1 = 101, // 0x00000065
    C_RD_NA_1 = 102, // 0x00000066
    C_CS_NA_1 = 103, // 0x00000067
    C_TS_NA_1 = 104, // 0x00000068
    C_RP_NA_1 = 105, // 0x00000069
    C_CD_NA_1 = 106, // 0x0000006A
    C_TS_TA_1 = 107, // 0x0000006B
    P_ME_NA_1 = 110, // 0x0000006E
    P_ME_NB_1 = 111, // 0x0000006F
    P_ME_NC_1 = 112, // 0x00000070
    P_AC_NA_1 = 113, // 0x00000071
    F_FR_NA_1 = 120, // 0x00000078
    F_SR_NA_1 = 121, // 0x00000079
    F_SC_NA_1 = 122, // 0x0000007A
    F_LS_NA_1 = 123, // 0x0000007B
    F_AF_NA_1 = 124, // 0x0000007C
    F_SG_NA_1 = 125, // 0x0000007D
    F_DR_TA_1 = 126, // 0x0000007E
  }
}
