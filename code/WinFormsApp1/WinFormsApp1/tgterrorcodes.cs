﻿// Decompiled with JetBrains decompiler
// Type: tgterrorcodes
// Assembly: dnp3clienttest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7F4F0122-5C1E-4FEA-AC7F-CEED20628A11
// Assembly location: C:\Users\LENOVO\Downloads\DNP3-master\DNP3-master\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\DNP3 Protocol Windows SDK\C-sharp\project\dnp3clienttest\obj\x86\Release\dnp3clienttest.exe

public class tgterrorcodes
{
  public enum eTgtErrorCodes
  {
    EC_SPABUS_END = -5499, // 0xFFFFEA85
    EC_SPABUS_START = -5000, // 0xFFFFEC78
    EC_IEC101_END = -4999, // 0xFFFFEC79
    EC_IEC101_START = -4500, // 0xFFFFEE6C
    EC_IEC104_END = -2999, // 0xFFFFF449
    EC_IEC104_START = -2500, // 0xFFFFF63C
    EC_IEC103_END = -2499, // 0xFFFFF63D
    EC_IEC103_START = -2000, // 0xFFFFF830
    EC_DNP3_END = -1999, // 0xFFFFF831
    EC_DNP3_START = -1500, // 0xFFFFFA24
    EC_MODBUS_END = -1499, // 0xFFFFFA25
    EC_MODBUS_START = -1000, // 0xFFFFFC18
    EC_GPIO_WRITE = -652, // 0xFFFFFD74
    EC_GPIO_READ = -651, // 0xFFFFFD75
    EC_GPIO_OPEN = -650, // 0xFFFFFD76
    EC_UTILITY_SYSTEM_REBOOT = -608, // 0xFFFFFDA0
    EC_UTILITY_GET_MAC_ADDRESS = -607, // 0xFFFFFDA1
    EC_UTILITY_DESTROYCOMMONMEMORY = -606, // 0xFFFFFDA2
    EC_UTILITY_INITCOMMONMEMORY = -605, // 0xFFFFFDA3
    EC_UTILITY_CREATECOMMONMEMORY = -604, // 0xFFFFFDA4
    EC_UTILITY_ITEMNAME = -603, // 0xFFFFFDA5
    EC_UTILITY_SECTIONNAME = -602, // 0xFFFFFDA6
    EC_UTILITY_GETSTRING = -601, // 0xFFFFFDA7
    EC_UTILITY_FILEPOSTION = -600, // 0xFFFFFDA8
    EC_MESSAGE_FIND = -554, // 0xFFFFFDD6
    EC_MESSAGE_RECEIVE = -553, // 0xFFFFFDD7
    EC_MESSAGE_SEND = -552, // 0xFFFFFDD8
    EC_MESSAGE_DESTROY = -551, // 0xFFFFFDD9
    EC_MESSAGE_CREATE = -550, // 0xFFFFFDDA
    EC_SERIAL_RECEIVE = -503, // 0xFFFFFE09
    EC_SERIAL_TRANSMIT = -502, // 0xFFFFFE0A
    EC_SERIAL_CLOSE = -501, // 0xFFFFFE0B
    EC_SERIAL_OPEN = -500, // 0xFFFFFE0C
    EC_LIST_INSERT = -451, // 0xFFFFFE3D
    EC_LIST_ADD = -450, // 0xFFFFFE3E
    EC_LIST_DIRECTORY = -414, // 0xFFFFFE62
    EC_FILE_SEEK = -413, // 0xFFFFFE63
    EC_FILE_SIZE = -412, // 0xFFFFFE64
    EC_FILE_FIND = -411, // 0xFFFFFE65
    EC_FILE_DELETE = -410, // 0xFFFFFE66
    EC_GET_CURRENT_DIRECTORY = -409, // 0xFFFFFE67
    EC_CHANGE_DIRECTORY = -408, // 0xFFFFFE68
    EC_REMOVE_DIRECTORY = -407, // 0xFFFFFE69
    EC_CREATE_DIRECTORY = -406, // 0xFFFFFE6A
    EC_FILE_RENAME = -405, // 0xFFFFFE6B
    EC_FILE_END = -404, // 0xFFFFFE6C
    EC_FILE_WRITE = -403, // 0xFFFFFE6D
    EC_FILE_READ = -402, // 0xFFFFFE6E
    EC_FILE_CLOSE = -401, // 0xFFFFFE6F
    EC_FILE_OPEN = -400, // 0xFFFFFE70
    EC_GET_TIME = -352, // 0xFFFFFEA0
    EC_SET_TIME = -351, // 0xFFFFFEA1
    EC_SLEEP = -350, // 0xFFFFFEA2
    EC_SOCKET_KEEP_ALIVE = -316, // 0xFFFFFEC4
    EC_SOCKET_CONNECT_NOT_SUCEED = -315, // 0xFFFFFEC5
    EC_SOCKET_READ_READY = -314, // 0xFFFFFEC6
    EC_SOCKET_SELECT = -313, // 0xFFFFFEC7
    EC_SOCKET_RECEIVE_FROM = -312, // 0xFFFFFEC8
    EC_SOCKET_SEND_TO = -311, // 0xFFFFFEC9
    EC_SOCKET_RECEIVE = -310, // 0xFFFFFECA
    EC_SOCKET_SEND = -309, // 0xFFFFFECB
    EC_SOCKET_CONNECT = -308, // 0xFFFFFECC
    EC_SOCKET_ACCEPT = -307, // 0xFFFFFECD
    EC_SOCKET_LISTEN = -306, // 0xFFFFFECE
    EC_SOCKET_BIND = -305, // 0xFFFFFECF
    EC_SOCKET_NONBLOCKING = -304, // 0xFFFFFED0
    EC_SOCKET_SHUTDOWN = -303, // 0xFFFFFED1
    EC_SOCKET_CLOSE = -302, // 0xFFFFFED2
    EC_SOCKET_CREATE = -301, // 0xFFFFFED3
    EC_SOCKET_INITIAL = -300, // 0xFFFFFED4
    EC_TIMER_DESTROY = -254, // 0xFFFFFF02
    EC_TIMER_RESET = -253, // 0xFFFFFF03
    EC_TIMER_STOP = -252, // 0xFFFFFF04
    EC_TIMER_START = -251, // 0xFFFFFF05
    EC_TIMER_CREATE = -250, // 0xFFFFFF06
    EC_SEM_FIND = -204, // 0xFFFFFF34
    EC_SEM_DESTROY = -203, // 0xFFFFFF35
    EC_SEM_RELEASE = -202, // 0xFFFFFF36
    EC_SEM_GET = -201, // 0xFFFFFF37
    EC_SEM_CREATE = -200, // 0xFFFFFF38
    EC_TASK_ASSIGN_MEM = -152, // 0xFFFFFF68
    EC_TASK_DELETE = -151, // 0xFFFFFF69
    EC_TASK_CREATE = -150, // 0xFFFFFF6A
    EC_MEMORY = -100, // 0xFFFFFF9C
    EC_ERROR_VALUE_NULL = -2, // 0xFFFFFFFE
    EC_PARAMETER = -1, // 0xFFFFFFFF
    EC_NONE = 0,
  }
}