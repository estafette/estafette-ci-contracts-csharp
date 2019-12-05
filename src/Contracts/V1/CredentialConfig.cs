// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/contracts.v1/credential_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Contracts.V1 {

  /// <summary>Holder for reflection information generated from protos/contracts.v1/credential_config.proto</summary>
  public static partial class CredentialConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/contracts.v1/credential_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CredentialConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citwcm90b3MvY29udHJhY3RzLnYxL2NyZWRlbnRpYWxfY29uZmlnLnByb3Rv",
            "Egxjb250cmFjdHMudjEaGWdvb2dsZS9wcm90b2J1Zi9hbnkucHJvdG8i2gEK",
            "EENyZWRlbnRpYWxDb25maWcSDAoEbmFtZRgBIAEoCRIMCgR0eXBlGAIgASgJ",
            "ElcKFWFkZGl0aW9uYWxfcHJvcGVydGllcxgDIAMoCzI4LmNvbnRyYWN0cy52",
            "MS5DcmVkZW50aWFsQ29uZmlnLkFkZGl0aW9uYWxQcm9wZXJ0aWVzRW50cnka",
            "UQoZQWRkaXRpb25hbFByb3BlcnRpZXNFbnRyeRILCgNrZXkYASABKAkSIwoF",
            "dmFsdWUYAiABKAsyFC5nb29nbGUucHJvdG9idWYuQW55OgI4AUJ/CiNpby5l",
            "c3RhZmV0dGUuY2kucHJvdG9zLmNvbnRyYWN0cy52MVo8Z2l0aHViLmNvbS9l",
            "c3RhZmV0dGUvZXN0YWZldHRlLWNpLXByb3Rvcy1nb2xhbmcvY29udHJhY3Rz",
            "X3YxqgIZRXN0YWZldHRlLkNJLkNvbnRyYWN0cy5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Contracts.V1.CredentialConfig), global::Estafette.CI.Contracts.V1.CredentialConfig.Parser, new[]{ "Name", "Type", "AdditionalProperties" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CredentialConfig : pb::IMessage<CredentialConfig> {
    private static readonly pb::MessageParser<CredentialConfig> _parser = new pb::MessageParser<CredentialConfig>(() => new CredentialConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CredentialConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Contracts.V1.CredentialConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialConfig(CredentialConfig other) : this() {
      name_ = other.name_;
      type_ = other.type_;
      additionalProperties_ = other.additionalProperties_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CredentialConfig Clone() {
      return new CredentialConfig(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "additional_properties" field.</summary>
    public const int AdditionalPropertiesFieldNumber = 3;
    private static readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Any>.Codec _map_additionalProperties_codec
        = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Any>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.Any.Parser), 26);
    private readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Any> additionalProperties_ = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Any>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Any> AdditionalProperties {
      get { return additionalProperties_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CredentialConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CredentialConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      if (!AdditionalProperties.Equals(other.AdditionalProperties)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      hash ^= AdditionalProperties.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      additionalProperties_.WriteTo(output, _map_additionalProperties_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      size += additionalProperties_.CalculateSize(_map_additionalProperties_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CredentialConfig other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      additionalProperties_.Add(other.additionalProperties_);
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Type = input.ReadString();
            break;
          }
          case 26: {
            additionalProperties_.AddEntriesFrom(input, _map_additionalProperties_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
