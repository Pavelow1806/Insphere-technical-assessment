// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/PathDrift.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Insphere.Protos {

  /// <summary>Holder for reflection information generated from Protos/PathDrift.proto</summary>
  public static partial class PathDriftReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/PathDrift.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PathDriftReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQcm90b3MvUGF0aERyaWZ0LnByb3RvIikKG1BhdGhEcmlmdENvb3JkaW5h",
            "dGVzUmVxdWVzdBIKCgJJRBgBIAEoCSLWAQoTUGF0aERyaWZ0Q29vcmRpbmF0",
            "ZRIKCgJJRBgBIAEoCRINCgVJbmRleBgCIAEoBRIJCgFYGAMgASgBEgkKAVkY",
            "BCABKAESCQoBWhgFIAEoARIKCgJSeBgGIAEoARIKCgJSeRgHIAEoARIKCgJS",
            "ehgIIAEoARIKCgJVeBgJIAEoARIKCgJVeRgKIAEoARIKCgJVehgLIAEoARIU",
            "CgxVVHJhbnNsYXRpb24YDCABKAESCwoDVVJ4GA0gASgBEgsKA1VSeRgOIAEo",
            "ARILCgNVUnoYDyABKAEiSQocUGF0aERyaWZ0Q29vcmRpbmF0ZXNSZXNwb25z",
            "ZRIpCgtjb29yZGluYXRlcxgBIAMoCzIULlBhdGhEcmlmdENvb3JkaW5hdGUy",
            "VwoGUmVhZGVyEk0KDkdldENvb3JkaW5hdGVzEhwuUGF0aERyaWZ0Q29vcmRp",
            "bmF0ZXNSZXF1ZXN0Gh0uUGF0aERyaWZ0Q29vcmRpbmF0ZXNSZXNwb25zZUIS",
            "qgIPSW5zcGhlcmUuUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Insphere.Protos.PathDriftCoordinatesRequest), global::Insphere.Protos.PathDriftCoordinatesRequest.Parser, new[]{ "ID" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Insphere.Protos.PathDriftCoordinate), global::Insphere.Protos.PathDriftCoordinate.Parser, new[]{ "ID", "Index", "X", "Y", "Z", "Rx", "Ry", "Rz", "Ux", "Uy", "Uz", "UTranslation", "URx", "URy", "URz" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Insphere.Protos.PathDriftCoordinatesResponse), global::Insphere.Protos.PathDriftCoordinatesResponse.Parser, new[]{ "Coordinates" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PathDriftCoordinatesRequest : pb::IMessage<PathDriftCoordinatesRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PathDriftCoordinatesRequest> _parser = new pb::MessageParser<PathDriftCoordinatesRequest>(() => new PathDriftCoordinatesRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PathDriftCoordinatesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Insphere.Protos.PathDriftReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathDriftCoordinatesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathDriftCoordinatesRequest(PathDriftCoordinatesRequest other) : this() {
      iD_ = other.iD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathDriftCoordinatesRequest Clone() {
      return new PathDriftCoordinatesRequest(this);
    }

    /// <summary>Field number for the "ID" field.</summary>
    public const int IDFieldNumber = 1;
    private string iD_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ID {
      get { return iD_; }
      set {
        iD_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PathDriftCoordinatesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PathDriftCoordinatesRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ID != other.ID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ID.Length != 0) hash ^= ID.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PathDriftCoordinatesRequest other) {
      if (other == null) {
        return;
      }
      if (other.ID.Length != 0) {
        ID = other.ID;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ID = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ID = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PathDriftCoordinate : pb::IMessage<PathDriftCoordinate>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PathDriftCoordinate> _parser = new pb::MessageParser<PathDriftCoordinate>(() => new PathDriftCoordinate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PathDriftCoordinate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Insphere.Protos.PathDriftReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathDriftCoordinate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathDriftCoordinate(PathDriftCoordinate other) : this() {
      iD_ = other.iD_;
      index_ = other.index_;
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      rx_ = other.rx_;
      ry_ = other.ry_;
      rz_ = other.rz_;
      ux_ = other.ux_;
      uy_ = other.uy_;
      uz_ = other.uz_;
      uTranslation_ = other.uTranslation_;
      uRx_ = other.uRx_;
      uRy_ = other.uRy_;
      uRz_ = other.uRz_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathDriftCoordinate Clone() {
      return new PathDriftCoordinate(this);
    }

    /// <summary>Field number for the "ID" field.</summary>
    public const int IDFieldNumber = 1;
    private string iD_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ID {
      get { return iD_; }
      set {
        iD_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Index" field.</summary>
    public const int IndexFieldNumber = 2;
    private int index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "X" field.</summary>
    public const int XFieldNumber = 3;
    private double x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "Y" field.</summary>
    public const int YFieldNumber = 4;
    private double y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "Z" field.</summary>
    public const int ZFieldNumber = 5;
    private double z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "Rx" field.</summary>
    public const int RxFieldNumber = 6;
    private double rx_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Rx {
      get { return rx_; }
      set {
        rx_ = value;
      }
    }

    /// <summary>Field number for the "Ry" field.</summary>
    public const int RyFieldNumber = 7;
    private double ry_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Ry {
      get { return ry_; }
      set {
        ry_ = value;
      }
    }

    /// <summary>Field number for the "Rz" field.</summary>
    public const int RzFieldNumber = 8;
    private double rz_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Rz {
      get { return rz_; }
      set {
        rz_ = value;
      }
    }

    /// <summary>Field number for the "Ux" field.</summary>
    public const int UxFieldNumber = 9;
    private double ux_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Ux {
      get { return ux_; }
      set {
        ux_ = value;
      }
    }

    /// <summary>Field number for the "Uy" field.</summary>
    public const int UyFieldNumber = 10;
    private double uy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Uy {
      get { return uy_; }
      set {
        uy_ = value;
      }
    }

    /// <summary>Field number for the "Uz" field.</summary>
    public const int UzFieldNumber = 11;
    private double uz_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Uz {
      get { return uz_; }
      set {
        uz_ = value;
      }
    }

    /// <summary>Field number for the "UTranslation" field.</summary>
    public const int UTranslationFieldNumber = 12;
    private double uTranslation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double UTranslation {
      get { return uTranslation_; }
      set {
        uTranslation_ = value;
      }
    }

    /// <summary>Field number for the "URx" field.</summary>
    public const int URxFieldNumber = 13;
    private double uRx_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double URx {
      get { return uRx_; }
      set {
        uRx_ = value;
      }
    }

    /// <summary>Field number for the "URy" field.</summary>
    public const int URyFieldNumber = 14;
    private double uRy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double URy {
      get { return uRy_; }
      set {
        uRy_ = value;
      }
    }

    /// <summary>Field number for the "URz" field.</summary>
    public const int URzFieldNumber = 15;
    private double uRz_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double URz {
      get { return uRz_; }
      set {
        uRz_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PathDriftCoordinate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PathDriftCoordinate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ID != other.ID) return false;
      if (Index != other.Index) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Y, other.Y)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Z, other.Z)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Rx, other.Rx)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Ry, other.Ry)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Rz, other.Rz)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Ux, other.Ux)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Uy, other.Uy)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Uz, other.Uz)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(UTranslation, other.UTranslation)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(URx, other.URx)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(URy, other.URy)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(URz, other.URz)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ID.Length != 0) hash ^= ID.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
      if (X != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(X);
      if (Y != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Y);
      if (Z != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Z);
      if (Rx != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Rx);
      if (Ry != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Ry);
      if (Rz != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Rz);
      if (Ux != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Ux);
      if (Uy != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Uy);
      if (Uz != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Uz);
      if (UTranslation != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(UTranslation);
      if (URx != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(URx);
      if (URy != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(URy);
      if (URz != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(URz);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ID);
      }
      if (Index != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Index);
      }
      if (X != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(X);
      }
      if (Y != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Y);
      }
      if (Z != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Z);
      }
      if (Rx != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Rx);
      }
      if (Ry != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Ry);
      }
      if (Rz != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(Rz);
      }
      if (Ux != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(Ux);
      }
      if (Uy != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(Uy);
      }
      if (Uz != 0D) {
        output.WriteRawTag(89);
        output.WriteDouble(Uz);
      }
      if (UTranslation != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(UTranslation);
      }
      if (URx != 0D) {
        output.WriteRawTag(105);
        output.WriteDouble(URx);
      }
      if (URy != 0D) {
        output.WriteRawTag(113);
        output.WriteDouble(URy);
      }
      if (URz != 0D) {
        output.WriteRawTag(121);
        output.WriteDouble(URz);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ID);
      }
      if (Index != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Index);
      }
      if (X != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(X);
      }
      if (Y != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Y);
      }
      if (Z != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Z);
      }
      if (Rx != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Rx);
      }
      if (Ry != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Ry);
      }
      if (Rz != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(Rz);
      }
      if (Ux != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(Ux);
      }
      if (Uy != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(Uy);
      }
      if (Uz != 0D) {
        output.WriteRawTag(89);
        output.WriteDouble(Uz);
      }
      if (UTranslation != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(UTranslation);
      }
      if (URx != 0D) {
        output.WriteRawTag(105);
        output.WriteDouble(URx);
      }
      if (URy != 0D) {
        output.WriteRawTag(113);
        output.WriteDouble(URy);
      }
      if (URz != 0D) {
        output.WriteRawTag(121);
        output.WriteDouble(URz);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ID);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      if (X != 0D) {
        size += 1 + 8;
      }
      if (Y != 0D) {
        size += 1 + 8;
      }
      if (Z != 0D) {
        size += 1 + 8;
      }
      if (Rx != 0D) {
        size += 1 + 8;
      }
      if (Ry != 0D) {
        size += 1 + 8;
      }
      if (Rz != 0D) {
        size += 1 + 8;
      }
      if (Ux != 0D) {
        size += 1 + 8;
      }
      if (Uy != 0D) {
        size += 1 + 8;
      }
      if (Uz != 0D) {
        size += 1 + 8;
      }
      if (UTranslation != 0D) {
        size += 1 + 8;
      }
      if (URx != 0D) {
        size += 1 + 8;
      }
      if (URy != 0D) {
        size += 1 + 8;
      }
      if (URz != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PathDriftCoordinate other) {
      if (other == null) {
        return;
      }
      if (other.ID.Length != 0) {
        ID = other.ID;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.X != 0D) {
        X = other.X;
      }
      if (other.Y != 0D) {
        Y = other.Y;
      }
      if (other.Z != 0D) {
        Z = other.Z;
      }
      if (other.Rx != 0D) {
        Rx = other.Rx;
      }
      if (other.Ry != 0D) {
        Ry = other.Ry;
      }
      if (other.Rz != 0D) {
        Rz = other.Rz;
      }
      if (other.Ux != 0D) {
        Ux = other.Ux;
      }
      if (other.Uy != 0D) {
        Uy = other.Uy;
      }
      if (other.Uz != 0D) {
        Uz = other.Uz;
      }
      if (other.UTranslation != 0D) {
        UTranslation = other.UTranslation;
      }
      if (other.URx != 0D) {
        URx = other.URx;
      }
      if (other.URy != 0D) {
        URy = other.URy;
      }
      if (other.URz != 0D) {
        URz = other.URz;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ID = input.ReadString();
            break;
          }
          case 16: {
            Index = input.ReadInt32();
            break;
          }
          case 25: {
            X = input.ReadDouble();
            break;
          }
          case 33: {
            Y = input.ReadDouble();
            break;
          }
          case 41: {
            Z = input.ReadDouble();
            break;
          }
          case 49: {
            Rx = input.ReadDouble();
            break;
          }
          case 57: {
            Ry = input.ReadDouble();
            break;
          }
          case 65: {
            Rz = input.ReadDouble();
            break;
          }
          case 73: {
            Ux = input.ReadDouble();
            break;
          }
          case 81: {
            Uy = input.ReadDouble();
            break;
          }
          case 89: {
            Uz = input.ReadDouble();
            break;
          }
          case 97: {
            UTranslation = input.ReadDouble();
            break;
          }
          case 105: {
            URx = input.ReadDouble();
            break;
          }
          case 113: {
            URy = input.ReadDouble();
            break;
          }
          case 121: {
            URz = input.ReadDouble();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ID = input.ReadString();
            break;
          }
          case 16: {
            Index = input.ReadInt32();
            break;
          }
          case 25: {
            X = input.ReadDouble();
            break;
          }
          case 33: {
            Y = input.ReadDouble();
            break;
          }
          case 41: {
            Z = input.ReadDouble();
            break;
          }
          case 49: {
            Rx = input.ReadDouble();
            break;
          }
          case 57: {
            Ry = input.ReadDouble();
            break;
          }
          case 65: {
            Rz = input.ReadDouble();
            break;
          }
          case 73: {
            Ux = input.ReadDouble();
            break;
          }
          case 81: {
            Uy = input.ReadDouble();
            break;
          }
          case 89: {
            Uz = input.ReadDouble();
            break;
          }
          case 97: {
            UTranslation = input.ReadDouble();
            break;
          }
          case 105: {
            URx = input.ReadDouble();
            break;
          }
          case 113: {
            URy = input.ReadDouble();
            break;
          }
          case 121: {
            URz = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PathDriftCoordinatesResponse : pb::IMessage<PathDriftCoordinatesResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PathDriftCoordinatesResponse> _parser = new pb::MessageParser<PathDriftCoordinatesResponse>(() => new PathDriftCoordinatesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PathDriftCoordinatesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Insphere.Protos.PathDriftReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathDriftCoordinatesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathDriftCoordinatesResponse(PathDriftCoordinatesResponse other) : this() {
      coordinates_ = other.coordinates_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathDriftCoordinatesResponse Clone() {
      return new PathDriftCoordinatesResponse(this);
    }

    /// <summary>Field number for the "coordinates" field.</summary>
    public const int CoordinatesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Insphere.Protos.PathDriftCoordinate> _repeated_coordinates_codec
        = pb::FieldCodec.ForMessage(10, global::Insphere.Protos.PathDriftCoordinate.Parser);
    private readonly pbc::RepeatedField<global::Insphere.Protos.PathDriftCoordinate> coordinates_ = new pbc::RepeatedField<global::Insphere.Protos.PathDriftCoordinate>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Insphere.Protos.PathDriftCoordinate> Coordinates {
      get { return coordinates_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PathDriftCoordinatesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PathDriftCoordinatesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!coordinates_.Equals(other.coordinates_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= coordinates_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      coordinates_.WriteTo(output, _repeated_coordinates_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      coordinates_.WriteTo(ref output, _repeated_coordinates_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += coordinates_.CalculateSize(_repeated_coordinates_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PathDriftCoordinatesResponse other) {
      if (other == null) {
        return;
      }
      coordinates_.Add(other.coordinates_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            coordinates_.AddEntriesFrom(input, _repeated_coordinates_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            coordinates_.AddEntriesFrom(ref input, _repeated_coordinates_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code