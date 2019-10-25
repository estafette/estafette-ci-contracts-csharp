// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contracts.v1/build_params_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Contracts.V1 {

  /// <summary>Holder for reflection information generated from contracts.v1/build_params_config.proto</summary>
  public static partial class BuildParamsConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for contracts.v1/build_params_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuildParamsConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZjb250cmFjdHMudjEvYnVpbGRfcGFyYW1zX2NvbmZpZy5wcm90bxIMY29u",
            "dHJhY3RzLnYxIiUKEUJ1aWxkUGFyYW1zQ29uZmlnEhAKCGJ1aWxkX2lkGAEg",
            "ASgDQn8KI2lvLmVzdGFmZXR0ZS5jaS5wcm90b3MuY29udHJhY3RzLnYxWjxn",
            "aXRodWIuY29tL2VzdGFmZXR0ZS9lc3RhZmV0dGUtY2ktcHJvdG9zLWdvbGFu",
            "Zy9jb250cmFjdHNfdjGqAhlFc3RhZmV0dGUuQ0kuQ29udHJhY3RzLlYxYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Contracts.V1.BuildParamsConfig), global::Estafette.CI.Contracts.V1.BuildParamsConfig.Parser, new[]{ "BuildId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BuildParamsConfig : pb::IMessage<BuildParamsConfig> {
    private static readonly pb::MessageParser<BuildParamsConfig> _parser = new pb::MessageParser<BuildParamsConfig>(() => new BuildParamsConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuildParamsConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Contracts.V1.BuildParamsConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildParamsConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildParamsConfig(BuildParamsConfig other) : this() {
      buildId_ = other.buildId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildParamsConfig Clone() {
      return new BuildParamsConfig(this);
    }

    /// <summary>Field number for the "build_id" field.</summary>
    public const int BuildIdFieldNumber = 1;
    private long buildId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BuildId {
      get { return buildId_; }
      set {
        buildId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuildParamsConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuildParamsConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuildId != other.BuildId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BuildId != 0L) hash ^= BuildId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BuildId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BuildId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BuildId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BuildId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuildParamsConfig other) {
      if (other == null) {
        return;
      }
      if (other.BuildId != 0L) {
        BuildId = other.BuildId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            BuildId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
