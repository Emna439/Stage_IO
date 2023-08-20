// Decompiled with JetBrains decompiler
// Type: tgttypes
// Assembly: dnp3clienttest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7F4F0122-5C1E-4FEA-AC7F-CEED20628A11
// Assembly location: C:\Users\LENOVO\Downloads\DNP3-master\DNP3-master\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\C-sharp\project\dnp3clienttest\obj\x86\Release\dnp3clienttest.exe

public class tgttypes
{
  public enum eDataSizes
  {
    UNSUPPORTED_SIZE = 0,
    DOUBLE_POINT_SIZE = 1,
    SIGNED_BYTE_SIZE = 1,
    SINGLE_POINT_SIZE = 1,
    UNSIGNED_BYTE_SIZE = 1,
    SIGNED_WORD_SIZE = 2,
    UNSIGNED_WORD_SIZE = 2,
    FLOAT32_SIZE = 4,
    SIGNED_DWORD_SIZE = 4,
    UNSIGNED_DWORD_SIZE = 4,
    FLOAT128_SIZE = 8,
    FLOAT64_SIZE = 8,
    SIGNED_LLWORD_SIZE = 8,
    SIGNED_LWORD_SIZE = 8,
    UNSIGNED_LLWORD_SIZE = 8,
    UNSIGNED_LWORD_SIZE = 8,
    MAX_DATASIZE = 255, // 0x000000FF
    STRING_SIZE = 255, // 0x000000FF
  }
}
