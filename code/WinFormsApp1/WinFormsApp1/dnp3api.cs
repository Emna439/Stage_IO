// Decompiled with JetBrains decompiler
// Type: dnp3api
// Assembly: dnp3clienttest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7F4F0122-5C1E-4FEA-AC7F-CEED20628A11
// Assembly location: C:\Users\LENOVO\Downloads\DNP3-master\DNP3-master\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\C-sharp\project\dnp3clienttest\obj\x86\Release\dnp3clienttest.exe

using System;
using System.Runtime.InteropServices;

public class dnp3api
{
  public const string DNP3_VERSION = "21.05.026";

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern IntPtr DNP3GetLibraryVersion();

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern IntPtr DNP3GetLibraryBuildTime();

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern IntPtr DNP3Create(
    ref dnp3types.sDNP3Parameters psParameters,
    ref short pi16ErrorCode,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3LoadConfiguration(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3ConfigurationParameters psDNP3Config,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3Start(IntPtr myDNP3Obj, ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3SetDebugOptions(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DebugParameters psDebugParams,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3Stop(IntPtr myDNP3Obj, ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3Free(IntPtr myDNP3Obj, ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3Update(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DataAttributeData psNewValue,
    ushort u16Count,
    dnp3types.eUpdateClassID eUpdateClass,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3Read(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DataAttributeData psReturnedValue,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3Write(
    IntPtr myDNP3Obj,
    dnp3types.eWriteFunctionID eFunctionID,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DataAttributeData psNewValue,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3Select(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DataAttributeData psSelectValue,
    ref dnp3types.sDNP3CommandParameters psSelectParams,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3Operate(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DataAttributeData psOperateValue,
    ref dnp3types.sDNP3CommandParameters psOperateParams,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3SelectBeforeOperate(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DataAttributeData psSelectValue,
    ref dnp3types.sDNP3CommandParameters psSelectParams,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3DirectOperateWithNoAck(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DataAttributeData psOperateValue,
    ref dnp3types.sDNP3CommandParameters psOperateParams,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3DirectOperate(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DataAttributeData psOperateValue,
    ref dnp3types.sDNP3CommandParameters psOperateParams,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3Cancel(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DataAttributeData psCancelValue,
    ref dnp3types.sDNP3CommandParameters psCancelParams,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3GetDataTypeAndSize(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DataAttributeData psReturnedValue,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3ClientStatus(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.eServerConnectionStatus peSat,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3FileRead(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3FileAttributeData psDNP3FileAttributeData,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3FileWrite(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3FileAttributeData psDNP3FileAttributeData,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3ReadDataSetPrototype(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sClientDatasetPrototype psClDatasetPrototype,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3ReadDataSetDescriptor(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sClientDatasetPrototype psClDatasetDescriptor,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3ReadDataSetPresentValue(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sClientDatasetPresentvalue psClDatasetPsValue,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3DirectoryRead(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref dnp3types.sDNP3DirAttributeData psDNP3DirAttributeData,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3GetServerDatabaseValue(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNPServerDatabase psDNPServerDatabase,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3GetClientDatabaseValue(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNPClientDatabase psDNPClientDatabase,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3ReadDeviceAttribute(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    byte u8Variation,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3ClientGetIIN(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    ref byte pu8IIN1,
    ref byte pu8IIN2,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short GetDNP3ObjectStatus(
    IntPtr myDNP3Obj,
    ref tgtcommon.eAppState peCurrentState,
    ref short ptErrorValue);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern void DNP3ErrorCodeString(ref dnp3types.sDNP3ErrorCode psDNP3ErrorCodeDes);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern void DNP3ErrorValueString(ref dnp3types.sDNP3ErrorValue psDNP3ErrorValueDes);

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern IntPtr DNP3GetLibraryLicenseInfo();

  [DllImport("dnp3win32d.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern short DNP3ClientStopServerMultidrop(
    IntPtr myDNP3Obj,
    ref dnp3types.sDNP3DataAttributeID psDAID,
    byte bStop,
    ref short ptErrorValue);
}
