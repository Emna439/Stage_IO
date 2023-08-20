// Decompiled with JetBrains decompiler
// Type: tgtcommon
// Assembly: dnp3clienttest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7F4F0122-5C1E-4FEA-AC7F-CEED20628A11
// Assembly location: C:\Users\LENOVO\Downloads\DNP3-master\DNP3-master\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\C-sharp\project\dnp3clienttest\obj\x86\Release\dnp3clienttest.exe

public class tgtcommon
{
  public const int APP_OBJNAMESIZE = 48;

  public enum eAppState
  {
    APP_STATE_UNKNOWN,
    APP_STATE_NEW,
    APP_STATE_LOADED,
    APP_STATE_RUNNING,
    APP_STATE_STOPPED,
    APP_STATE_FREED,
  }

  public enum eTimeQualityFlags
  {
    TIME_ASSUMED,
    TIME_REPORTED,
  }

  public enum eApplicationFlag
  {
    APP_SERVER = 1,
    APP_CLIENT = 2,
    APP_SERVERCLIENT = 3,
  }

  public enum eDataTypes
  {
    UNSUPPORTED_DATA,
    SINGLE_POINT_DATA,
    DOUBLE_POINT_DATA,
    UNSIGNED_BYTE_DATA,
    SIGNED_BYTE_DATA,
    UNSIGNED_WORD_DATA,
    SIGNED_WORD_DATA,
    UNSIGNED_DWORD_DATA,
    SIGNED_DWORD_DATA,
    UNSIGNED_LWORD_DATA,
    SIGNED_LWORD_DATA,
    UNSIGNED_LLWORD_DATA,
    SIGNED_LLWORD_DATA,
    FLOAT32_DATA,
    FLOAT64_DATA,
    FLOAT128_DATA,
    VISIBLE_STRING_DATA,
    MAX_DATATYPES,
  }

  public enum eDebugOptionsFlag
  {
    DEBUG_OPTION_NONE = 0,
    DEBUG_OPTION_ERROR = 1,
    DEBUG_OPTION_WARNING = 2,
    DEBUG_OPTION_RX = 4,
    DEBUG_OPTION_TX = 8,
  }

  public struct sTargetTimeStamp
  {
    public byte u8Day;
    public byte u8Month;
    public ushort u16Year;
    public byte u8DayoftheWeek;
    public byte u8Hour;
    public byte u8Minute;
    public byte u8Seconds;
    public ushort u16MilliSeconds;
    public ushort u16MicroSeconds;
    public sbyte i8DSTTime;
  }
}
