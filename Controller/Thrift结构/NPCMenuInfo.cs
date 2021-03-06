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
  public partial class NPCMenuInfo : TBase
  {
    private int _ID;
    private List<sbyte> _Text;

    public int ID
    {
      get
      {
        return _ID;
      }
      set
      {
        __isset.ID = true;
        this._ID = value;
      }
    }

    public List<sbyte> Text
    {
      get
      {
        return _Text;
      }
      set
      {
        __isset.Text = true;
        this._Text = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool ID;
      public bool Text;
    }

    public NPCMenuInfo() {
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
              ID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                Text = new List<sbyte>();
                TList _list48 = iprot.ReadListBegin();
                for( int _i49 = 0; _i49 < _list48.Count; ++_i49)
                {
                  sbyte _elem50 = 0;
                  _elem50 = iprot.ReadByte();
                  Text.Add(_elem50);
                }
                iprot.ReadListEnd();
              }
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
      TStruct struc = new TStruct("NPCMenuInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.ID) {
        field.Name = "ID";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ID);
        oprot.WriteFieldEnd();
      }
      if (Text != null && __isset.Text) {
        field.Name = "Text";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Byte, Text.Count));
          foreach (sbyte _iter51 in Text)
          {
            oprot.WriteByte(_iter51);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("NPCMenuInfo(");
      sb.Append("ID: ");
      sb.Append(ID);
      sb.Append(",Text: ");
      sb.Append(Text);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
