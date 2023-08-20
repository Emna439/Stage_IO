// Decompiled with JetBrains decompiler
// Type: tgtserialtypes
// Assembly: dnp3clienttest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7F4F0122-5C1E-4FEA-AC7F-CEED20628A11
// Assembly location: C:\Users\LENOVO\Downloads\DNP3-master\DNP3-master\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\C-sharp\project\dnp3clienttest\obj\x86\Release\dnp3clienttest.exe

public class tgtserialtypes
{
  public enum eSerialTypes
  {
    SERIAL_RS232,
    SERIAL_RS485,
    SERIAL_RS422,
  }

  public enum eSerialWordLength
  {
    WORDLEN_7BITS = 7,
    WORDLEN_8BITS = 8,
  }

  public enum eSerialStopBits
  {
    STOPBIT_1BIT = 1,
    STOPBIT_2BIT = 2,
  }

  public enum eSerialParity
  {
    NONE,
    ODD,
    EVEN,
  }

  public enum eLinuxSerialFlowControl
  {
    FLOW_NONE,
    FLOW_RTS_CTS,
    FLOW_XON_XOFF,
  }

  public enum eSerialBitRate
  {
    BITRATE_110 = 1,
    BITRATE_300 = 3,
    BITRATE_1200 = 12, // 0x0000000C
    BITRATE_2400 = 24, // 0x00000018
    BITRATE_4800 = 48, // 0x00000030
    BITRATE_9600 = 96, // 0x00000060
    BITRATE_14400 = 144, // 0x00000090
    BITRATE_19200 = 192, // 0x000000C0
    BITRATE_28800 = 288, // 0x00000120
    BITRATE_38400 = 384, // 0x00000180
    BITRATE_57600 = 576, // 0x00000240
    BITRATE_115200 = 1152, // 0x00000480
    BITRATE_230400 = 2304, // 0x00000900
  }

  public enum eWinRTScontrol
  {
    WIN_RTS_CONTROL_DISABLE,
    WIN_RTS_CONTROL_ENABLE,
    WIN_RTS_CONTROL_HANDSHAKE,
    WIN_RTS_CONTROL_TOGGLE,
  }

  public enum eWinDTRcontrol
  {
    WIN_DTR_CONTROL_DISABLE,
    WIN_DTR_CONTROL_ENABLE,
    WIN_DTR_CONTROL_HANDSHAKE,
  }

  public struct sSerialFlowControl
  {
    public tgtserialtypes.eWinRTScontrol eWinRTS;
    public byte bWinCTSoutputflow;
    public tgtserialtypes.eWinDTRcontrol eWinDTR;
    public byte bWinDSRoutputflow;
    public tgtserialtypes.eLinuxSerialFlowControl eLinuxFlowControl;
  }

  public struct sSerialTimeParameters
  {
    public ushort u16PreDelay;
    public ushort u16PostDelay;
    public ushort u16InterCharacterDelay;
    public ushort u16CharacterTimeout;
    public byte u8CharacterRetries;
    public ushort u16MessageTimeout;
    public byte u8MessageRetries;
    public uint u32Baud;
  }

  public struct sSerialCommunicationSettings
  {
    public tgtserialtypes.eSerialTypes eSerialType;
    public tgtserialtypes.eSerialWordLength eWordLength;
    public tgtserialtypes.eSerialStopBits eStopBits;
    public tgtserialtypes.eSerialParity eSerialParity;
    public tgtserialtypes.eSerialBitRate eSerialBitRate;
    public ushort u16SerialPortNumber;
    public ushort u16InterMessageDelay;
    public tgtserialtypes.sSerialFlowControl sFlowControl;
    public tgtserialtypes.sSerialTimeParameters sTxTimeParam;
    public tgtserialtypes.sSerialTimeParameters sRxTimeParam;
  }
}
