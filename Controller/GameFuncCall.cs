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
  public partial class GameFuncCall {
    public interface Iface {
      int SetUID(string strUID, string strPWD);
      #if SILVERLIGHT
      IAsyncResult Begin_SetUID(AsyncCallback callback, object state, string strUID, string strPWD);
      int End_SetUID(IAsyncResult asyncResult);
      #endif
      bool IsValidServer();
      #if SILVERLIGHT
      IAsyncResult Begin_IsValidServer(AsyncCallback callback, object state);
      bool End_IsValidServer(IAsyncResult asyncResult);
      #endif
      void Test();
      #if SILVERLIGHT
      IAsyncResult Begin_Test(AsyncCallback callback, object state);
      void End_Test(IAsyncResult asyncResult);
      #endif
      void Update();
      #if SILVERLIGHT
      IAsyncResult Begin_Update(AsyncCallback callback, object state);
      void End_Update(IAsyncResult asyncResult);
      #endif
      Pos GetPlayerPos();
      #if SILVERLIGHT
      IAsyncResult Begin_GetPlayerPos(AsyncCallback callback, object state);
      Pos End_GetPlayerPos(IAsyncResult asyncResult);
      #endif
      void Move(int x, int y);
      #if SILVERLIGHT
      IAsyncResult Begin_Move(AsyncCallback callback, object state, int x, int y);
      void End_Move(IAsyncResult asyncResult);
      #endif
    }

    public class Client : IDisposable, Iface {
      public Client(TProtocol prot) : this(prot, prot)
      {
      }

      public Client(TProtocol iprot, TProtocol oprot)
      {
        iprot_ = iprot;
        oprot_ = oprot;
      }

      protected TProtocol iprot_;
      protected TProtocol oprot_;
      protected int seqid_;

      public TProtocol InputProtocol
      {
        get { return iprot_; }
      }
      public TProtocol OutputProtocol
      {
        get { return oprot_; }
      }


      #region " IDisposable Support "
      private bool _IsDisposed;

      // IDisposable
      public void Dispose()
      {
        Dispose(true);
      }
      

      protected virtual void Dispose(bool disposing)
      {
        if (!_IsDisposed)
        {
          if (disposing)
          {
            if (iprot_ != null)
            {
              ((IDisposable)iprot_).Dispose();
            }
            if (oprot_ != null)
            {
              ((IDisposable)oprot_).Dispose();
            }
          }
        }
        _IsDisposed = true;
      }
      #endregion


      
      #if SILVERLIGHT
      public IAsyncResult Begin_SetUID(AsyncCallback callback, object state, string strUID, string strPWD)
      {
        return send_SetUID(callback, state, strUID, strPWD);
      }

      public int End_SetUID(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_SetUID();
      }

      #endif

      public int SetUID(string strUID, string strPWD)
      {
        #if !SILVERLIGHT
        send_SetUID(strUID, strPWD);
        return recv_SetUID();

        #else
        var asyncResult = Begin_SetUID(null, null, strUID, strPWD);
        return End_SetUID(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_SetUID(AsyncCallback callback, object state, string strUID, string strPWD)
      #else
      public void send_SetUID(string strUID, string strPWD)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("SetUID", TMessageType.Call, seqid_));
        SetUID_args args = new SetUID_args();
        args.StrUID = strUID;
        args.StrPWD = strPWD;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public int recv_SetUID()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        SetUID_result result = new SetUID_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "SetUID failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_IsValidServer(AsyncCallback callback, object state)
      {
        return send_IsValidServer(callback, state);
      }

      public bool End_IsValidServer(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_IsValidServer();
      }

      #endif

      public bool IsValidServer()
      {
        #if !SILVERLIGHT
        send_IsValidServer();
        return recv_IsValidServer();

        #else
        var asyncResult = Begin_IsValidServer(null, null);
        return End_IsValidServer(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_IsValidServer(AsyncCallback callback, object state)
      #else
      public void send_IsValidServer()
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("IsValidServer", TMessageType.Call, seqid_));
        IsValidServer_args args = new IsValidServer_args();
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public bool recv_IsValidServer()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        IsValidServer_result result = new IsValidServer_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "IsValidServer failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_Test(AsyncCallback callback, object state)
      {
        return send_Test(callback, state);
      }

      public void End_Test(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        recv_Test();
      }

      #endif

      public void Test()
      {
        #if !SILVERLIGHT
        send_Test();
        recv_Test();

        #else
        var asyncResult = Begin_Test(null, null);
        End_Test(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_Test(AsyncCallback callback, object state)
      #else
      public void send_Test()
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("Test", TMessageType.Call, seqid_));
        Test_args args = new Test_args();
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public void recv_Test()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        Test_result result = new Test_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        return;
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_Update(AsyncCallback callback, object state)
      {
        return send_Update(callback, state);
      }

      public void End_Update(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        recv_Update();
      }

      #endif

      public void Update()
      {
        #if !SILVERLIGHT
        send_Update();
        recv_Update();

        #else
        var asyncResult = Begin_Update(null, null);
        End_Update(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_Update(AsyncCallback callback, object state)
      #else
      public void send_Update()
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("Update", TMessageType.Call, seqid_));
        Update_args args = new Update_args();
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public void recv_Update()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        Update_result result = new Update_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        return;
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_GetPlayerPos(AsyncCallback callback, object state)
      {
        return send_GetPlayerPos(callback, state);
      }

      public Pos End_GetPlayerPos(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_GetPlayerPos();
      }

      #endif

      public Pos GetPlayerPos()
      {
        #if !SILVERLIGHT
        send_GetPlayerPos();
        return recv_GetPlayerPos();

        #else
        var asyncResult = Begin_GetPlayerPos(null, null);
        return End_GetPlayerPos(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_GetPlayerPos(AsyncCallback callback, object state)
      #else
      public void send_GetPlayerPos()
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("GetPlayerPos", TMessageType.Call, seqid_));
        GetPlayerPos_args args = new GetPlayerPos_args();
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public Pos recv_GetPlayerPos()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        GetPlayerPos_result result = new GetPlayerPos_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "GetPlayerPos failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_Move(AsyncCallback callback, object state, int x, int y)
      {
        return send_Move(callback, state, x, y);
      }

      public void End_Move(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        recv_Move();
      }

      #endif

      public void Move(int x, int y)
      {
        #if !SILVERLIGHT
        send_Move(x, y);
        recv_Move();

        #else
        var asyncResult = Begin_Move(null, null, x, y);
        End_Move(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_Move(AsyncCallback callback, object state, int x, int y)
      #else
      public void send_Move(int x, int y)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("Move", TMessageType.Call, seqid_));
        Move_args args = new Move_args();
        args.X = x;
        args.Y = y;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public void recv_Move()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        Move_result result = new Move_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        return;
      }

    }
    public class Processor : TProcessor {
      public Processor(Iface iface)
      {
        iface_ = iface;
        processMap_["SetUID"] = SetUID_Process;
        processMap_["IsValidServer"] = IsValidServer_Process;
        processMap_["Test"] = Test_Process;
        processMap_["Update"] = Update_Process;
        processMap_["GetPlayerPos"] = GetPlayerPos_Process;
        processMap_["Move"] = Move_Process;
      }

      protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
      private Iface iface_;
      protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

      public bool Process(TProtocol iprot, TProtocol oprot)
      {
        try
        {
          TMessage msg = iprot.ReadMessageBegin();
          ProcessFunction fn;
          processMap_.TryGetValue(msg.Name, out fn);
          if (fn == null) {
            TProtocolUtil.Skip(iprot, TType.Struct);
            iprot.ReadMessageEnd();
            TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
            oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
            x.Write(oprot);
            oprot.WriteMessageEnd();
            oprot.Transport.Flush();
            return true;
          }
          fn(msg.SeqID, iprot, oprot);
        }
        catch (IOException)
        {
          return false;
        }
        return true;
      }

      public void SetUID_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        SetUID_args args = new SetUID_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        SetUID_result result = new SetUID_result();
        result.Success = iface_.SetUID(args.StrUID, args.StrPWD);
        oprot.WriteMessageBegin(new TMessage("SetUID", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void IsValidServer_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        IsValidServer_args args = new IsValidServer_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        IsValidServer_result result = new IsValidServer_result();
        result.Success = iface_.IsValidServer();
        oprot.WriteMessageBegin(new TMessage("IsValidServer", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void Test_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        Test_args args = new Test_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        Test_result result = new Test_result();
        iface_.Test();
        oprot.WriteMessageBegin(new TMessage("Test", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void Update_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        Update_args args = new Update_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        Update_result result = new Update_result();
        iface_.Update();
        oprot.WriteMessageBegin(new TMessage("Update", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void GetPlayerPos_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        GetPlayerPos_args args = new GetPlayerPos_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        GetPlayerPos_result result = new GetPlayerPos_result();
        result.Success = iface_.GetPlayerPos();
        oprot.WriteMessageBegin(new TMessage("GetPlayerPos", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void Move_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        Move_args args = new Move_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        Move_result result = new Move_result();
        iface_.Move(args.X, args.Y);
        oprot.WriteMessageBegin(new TMessage("Move", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class SetUID_args : TBase
    {
      private string _strUID;
      private string _strPWD;

      public string StrUID
      {
        get
        {
          return _strUID;
        }
        set
        {
          __isset.strUID = true;
          this._strUID = value;
        }
      }

      public string StrPWD
      {
        get
        {
          return _strPWD;
        }
        set
        {
          __isset.strPWD = true;
          this._strPWD = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool strUID;
        public bool strPWD;
      }

      public SetUID_args() {
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
              if (field.Type == TType.String) {
                StrUID = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                StrPWD = iprot.ReadString();
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
        TStruct struc = new TStruct("SetUID_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (StrUID != null && __isset.strUID) {
          field.Name = "strUID";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(StrUID);
          oprot.WriteFieldEnd();
        }
        if (StrPWD != null && __isset.strPWD) {
          field.Name = "strPWD";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(StrPWD);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("SetUID_args(");
        sb.Append("StrUID: ");
        sb.Append(StrUID);
        sb.Append(",StrPWD: ");
        sb.Append(StrPWD);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class SetUID_result : TBase
    {
      private int _success;

      public int Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public SetUID_result() {
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
            case 0:
              if (field.Type == TType.I32) {
                Success = iprot.ReadI32();
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
        TStruct struc = new TStruct("SetUID_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          field.Name = "Success";
          field.Type = TType.I32;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Success);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("SetUID_result(");
        sb.Append("Success: ");
        sb.Append(Success);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class IsValidServer_args : TBase
    {

      public IsValidServer_args() {
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
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("IsValidServer_args");
        oprot.WriteStructBegin(struc);
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("IsValidServer_args(");
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class IsValidServer_result : TBase
    {
      private bool _success;

      public bool Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public IsValidServer_result() {
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
            case 0:
              if (field.Type == TType.Bool) {
                Success = iprot.ReadBool();
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
        TStruct struc = new TStruct("IsValidServer_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          field.Name = "Success";
          field.Type = TType.Bool;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Success);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("IsValidServer_result(");
        sb.Append("Success: ");
        sb.Append(Success);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class Test_args : TBase
    {

      public Test_args() {
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
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("Test_args");
        oprot.WriteStructBegin(struc);
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("Test_args(");
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class Test_result : TBase
    {

      public Test_result() {
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
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("Test_result");
        oprot.WriteStructBegin(struc);

        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("Test_result(");
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class Update_args : TBase
    {

      public Update_args() {
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
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("Update_args");
        oprot.WriteStructBegin(struc);
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("Update_args(");
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class Update_result : TBase
    {

      public Update_result() {
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
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("Update_result");
        oprot.WriteStructBegin(struc);

        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("Update_result(");
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class GetPlayerPos_args : TBase
    {

      public GetPlayerPos_args() {
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
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("GetPlayerPos_args");
        oprot.WriteStructBegin(struc);
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("GetPlayerPos_args(");
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class GetPlayerPos_result : TBase
    {
      private Pos _success;

      public Pos Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public GetPlayerPos_result() {
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
            case 0:
              if (field.Type == TType.Struct) {
                Success = new Pos();
                Success.Read(iprot);
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
        TStruct struc = new TStruct("GetPlayerPos_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          if (Success != null) {
            field.Name = "Success";
            field.Type = TType.Struct;
            field.ID = 0;
            oprot.WriteFieldBegin(field);
            Success.Write(oprot);
            oprot.WriteFieldEnd();
          }
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("GetPlayerPos_result(");
        sb.Append("Success: ");
        sb.Append(Success== null ? "<null>" : Success.ToString());
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class Move_args : TBase
    {
      private int _x;
      private int _y;

      public int X
      {
        get
        {
          return _x;
        }
        set
        {
          __isset.x = true;
          this._x = value;
        }
      }

      public int Y
      {
        get
        {
          return _y;
        }
        set
        {
          __isset.y = true;
          this._y = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool x;
        public bool y;
      }

      public Move_args() {
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
                X = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                Y = iprot.ReadI32();
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
        TStruct struc = new TStruct("Move_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.x) {
          field.Name = "x";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(X);
          oprot.WriteFieldEnd();
        }
        if (__isset.y) {
          field.Name = "y";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Y);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("Move_args(");
        sb.Append("X: ");
        sb.Append(X);
        sb.Append(",Y: ");
        sb.Append(Y);
        sb.Append(")");
        return sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class Move_result : TBase
    {

      public Move_result() {
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
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("Move_result");
        oprot.WriteStructBegin(struc);

        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder sb = new StringBuilder("Move_result(");
        sb.Append(")");
        return sb.ToString();
      }

    }

  }
}
