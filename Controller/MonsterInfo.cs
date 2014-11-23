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
  public partial class MonsterInfo : TBase
  {
    private Pos _pos;
    private string _name;

    public Pos Pos
    {
      get
      {
        return _pos;
      }
      set
      {
        __isset.pos = true;
        this._pos = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool pos;
      public bool name;
    }

    public MonsterInfo() {
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
            if (field.Type == TType.Struct) {
              Pos = new Pos();
              Pos.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
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
      TStruct struc = new TStruct("MonsterInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Pos != null && __isset.pos) {
        field.Name = "pos";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        Pos.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("MonsterInfo(");
      sb.Append("Pos: ");
      sb.Append(Pos== null ? "<null>" : Pos.ToString());
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(")");
      return sb.ToString();
    }

  }

}