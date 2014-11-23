/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Thrift.GameCall
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TrophyBaseInfo : TBase
  {
    private int _ObjPtr;
    private short _X;
    private short _Y;

    public int ObjPtr
    {
      get
      {
        return _ObjPtr;
      }
      set
      {
        __isset.ObjPtr = true;
        this._ObjPtr = value;
      }
    }

    public short X
    {
      get
      {
        return _X;
      }
      set
      {
        __isset.X = true;
        this._X = value;
      }
    }

    public short Y
    {
      get
      {
        return _Y;
      }
      set
      {
        __isset.Y = true;
        this._Y = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool ObjPtr;
      public bool X;
      public bool Y;
    }

    public TrophyBaseInfo() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              ObjPtr = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I16) {
              X = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I16) {
              Y = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TrophyBaseInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.ObjPtr) {
        field.Name = "ObjPtr";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ObjPtr);
        oprot.WriteFieldEnd();
      }
      if (__isset.X) {
        field.Name = "X";
        field.Type = TType.I16;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(X);
        oprot.WriteFieldEnd();
      }
      if (__isset.Y) {
        field.Name = "Y";
        field.Type = TType.I16;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Y);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TrophyBaseInfo(");
      sb.Append("ObjPtr: ");
      sb.Append(ObjPtr);
      sb.Append(",X: ");
      sb.Append(X);
      sb.Append(",Y: ");
      sb.Append(Y);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
