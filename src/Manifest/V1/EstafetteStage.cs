// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_stage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_stage.proto</summary>
  public static partial class EstafetteStageReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_stage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteStageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFtYW5pZmVzdC52MS9lc3RhZmV0dGVfc3RhZ2UucHJvdG8SC21hbmlmZXN0",
            "LnYxGhlnb29nbGUvcHJvdG9idWYvYW55LnByb3RvIrIDCg5Fc3RhZmV0dGVT",
            "dGFnZRIMCgRuYW1lGAEgASgJEhcKD2NvbnRhaW5lcl9pbWFnZRgCIAEoCRIN",
            "CgVzaGVsbBgDIAEoCRIZChF3b3JraW5nX2RpcmVjdG9yeRgEIAEoCRIQCghj",
            "b21tYW5kcxgFIAMoCRIMCgR3aGVuGAYgASgJEjoKCGVudl92YXJzGAcgAygL",
            "MigubWFuaWZlc3QudjEuRXN0YWZldHRlU3RhZ2UuRW52VmFyc0VudHJ5EhUK",
            "DWF1dG9faW5qZWN0ZWQYCCABKAgSDwoHcmV0cmllcxgJIAEoAxJMChFjdXN0",
            "b21fcHJvcGVydGllcxgKIAMoCzIxLm1hbmlmZXN0LnYxLkVzdGFmZXR0ZVN0",
            "YWdlLkN1c3RvbVByb3BlcnRpZXNFbnRyeRouCgxFbnZWYXJzRW50cnkSCwoD",
            "a2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ARpNChVDdXN0b21Qcm9wZXJ0",
            "aWVzRW50cnkSCwoDa2V5GAEgASgJEiMKBXZhbHVlGAIgASgLMhQuZ29vZ2xl",
            "LnByb3RvYnVmLkFueToCOAFCfAoiaW8uZXN0YWZldHRlLmNpLnByb3Rvcy5t",
            "YW5pZmVzdC52MVo7Z2l0aHViLmNvbS9lc3RhZmV0dGUvZXN0YWZldHRlLWNp",
            "LXByb3Rvcy1nb2xhbmcvbWFuaWZlc3RfdjGqAhhFc3RhZmV0dGUuQ0kuTWFu",
            "aWZlc3QuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Manifest.V1.EstafetteStage), global::Estafette.CI.Manifest.V1.EstafetteStage.Parser, new[]{ "Name", "ContainerImage", "Shell", "WorkingDirectory", "Commands", "When", "EnvVars", "AutoInjected", "Retries", "CustomProperties" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteStage : pb::IMessage<EstafetteStage> {
    private static readonly pb::MessageParser<EstafetteStage> _parser = new pb::MessageParser<EstafetteStage>(() => new EstafetteStage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteStage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Manifest.V1.EstafetteStageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteStage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteStage(EstafetteStage other) : this() {
      name_ = other.name_;
      containerImage_ = other.containerImage_;
      shell_ = other.shell_;
      workingDirectory_ = other.workingDirectory_;
      commands_ = other.commands_.Clone();
      when_ = other.when_;
      envVars_ = other.envVars_.Clone();
      autoInjected_ = other.autoInjected_;
      retries_ = other.retries_;
      customProperties_ = other.customProperties_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteStage Clone() {
      return new EstafetteStage(this);
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

    /// <summary>Field number for the "container_image" field.</summary>
    public const int ContainerImageFieldNumber = 2;
    private string containerImage_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContainerImage {
      get { return containerImage_; }
      set {
        containerImage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "shell" field.</summary>
    public const int ShellFieldNumber = 3;
    private string shell_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Shell {
      get { return shell_; }
      set {
        shell_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "working_directory" field.</summary>
    public const int WorkingDirectoryFieldNumber = 4;
    private string workingDirectory_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string WorkingDirectory {
      get { return workingDirectory_; }
      set {
        workingDirectory_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "commands" field.</summary>
    public const int CommandsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_commands_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> commands_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Commands {
      get { return commands_; }
    }

    /// <summary>Field number for the "when" field.</summary>
    public const int WhenFieldNumber = 6;
    private string when_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string When {
      get { return when_; }
      set {
        when_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "env_vars" field.</summary>
    public const int EnvVarsFieldNumber = 7;
    private static readonly pbc::MapField<string, string>.Codec _map_envVars_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 58);
    private readonly pbc::MapField<string, string> envVars_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> EnvVars {
      get { return envVars_; }
    }

    /// <summary>Field number for the "auto_injected" field.</summary>
    public const int AutoInjectedFieldNumber = 8;
    private bool autoInjected_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AutoInjected {
      get { return autoInjected_; }
      set {
        autoInjected_ = value;
      }
    }

    /// <summary>Field number for the "retries" field.</summary>
    public const int RetriesFieldNumber = 9;
    private long retries_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Retries {
      get { return retries_; }
      set {
        retries_ = value;
      }
    }

    /// <summary>Field number for the "custom_properties" field.</summary>
    public const int CustomPropertiesFieldNumber = 10;
    private static readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Any>.Codec _map_customProperties_codec
        = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Any>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.Any.Parser), 82);
    private readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Any> customProperties_ = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Any>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Any> CustomProperties {
      get { return customProperties_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafetteStage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteStage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (ContainerImage != other.ContainerImage) return false;
      if (Shell != other.Shell) return false;
      if (WorkingDirectory != other.WorkingDirectory) return false;
      if(!commands_.Equals(other.commands_)) return false;
      if (When != other.When) return false;
      if (!EnvVars.Equals(other.EnvVars)) return false;
      if (AutoInjected != other.AutoInjected) return false;
      if (Retries != other.Retries) return false;
      if (!CustomProperties.Equals(other.CustomProperties)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (ContainerImage.Length != 0) hash ^= ContainerImage.GetHashCode();
      if (Shell.Length != 0) hash ^= Shell.GetHashCode();
      if (WorkingDirectory.Length != 0) hash ^= WorkingDirectory.GetHashCode();
      hash ^= commands_.GetHashCode();
      if (When.Length != 0) hash ^= When.GetHashCode();
      hash ^= EnvVars.GetHashCode();
      if (AutoInjected != false) hash ^= AutoInjected.GetHashCode();
      if (Retries != 0L) hash ^= Retries.GetHashCode();
      hash ^= CustomProperties.GetHashCode();
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
      if (ContainerImage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ContainerImage);
      }
      if (Shell.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Shell);
      }
      if (WorkingDirectory.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(WorkingDirectory);
      }
      commands_.WriteTo(output, _repeated_commands_codec);
      if (When.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(When);
      }
      envVars_.WriteTo(output, _map_envVars_codec);
      if (AutoInjected != false) {
        output.WriteRawTag(64);
        output.WriteBool(AutoInjected);
      }
      if (Retries != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(Retries);
      }
      customProperties_.WriteTo(output, _map_customProperties_codec);
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
      if (ContainerImage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContainerImage);
      }
      if (Shell.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Shell);
      }
      if (WorkingDirectory.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(WorkingDirectory);
      }
      size += commands_.CalculateSize(_repeated_commands_codec);
      if (When.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(When);
      }
      size += envVars_.CalculateSize(_map_envVars_codec);
      if (AutoInjected != false) {
        size += 1 + 1;
      }
      if (Retries != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Retries);
      }
      size += customProperties_.CalculateSize(_map_customProperties_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteStage other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.ContainerImage.Length != 0) {
        ContainerImage = other.ContainerImage;
      }
      if (other.Shell.Length != 0) {
        Shell = other.Shell;
      }
      if (other.WorkingDirectory.Length != 0) {
        WorkingDirectory = other.WorkingDirectory;
      }
      commands_.Add(other.commands_);
      if (other.When.Length != 0) {
        When = other.When;
      }
      envVars_.Add(other.envVars_);
      if (other.AutoInjected != false) {
        AutoInjected = other.AutoInjected;
      }
      if (other.Retries != 0L) {
        Retries = other.Retries;
      }
      customProperties_.Add(other.customProperties_);
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
            ContainerImage = input.ReadString();
            break;
          }
          case 26: {
            Shell = input.ReadString();
            break;
          }
          case 34: {
            WorkingDirectory = input.ReadString();
            break;
          }
          case 42: {
            commands_.AddEntriesFrom(input, _repeated_commands_codec);
            break;
          }
          case 50: {
            When = input.ReadString();
            break;
          }
          case 58: {
            envVars_.AddEntriesFrom(input, _map_envVars_codec);
            break;
          }
          case 64: {
            AutoInjected = input.ReadBool();
            break;
          }
          case 72: {
            Retries = input.ReadInt64();
            break;
          }
          case 82: {
            customProperties_.AddEntriesFrom(input, _map_customProperties_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
