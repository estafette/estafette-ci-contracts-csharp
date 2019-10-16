// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: build.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Contracts.V1 {

  /// <summary>Holder for reflection information generated from build.proto</summary>
  public static partial class BuildReflection {

    #region Descriptor
    /// <summary>File descriptor for build.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuildReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtidWlsZC5wcm90bxIMY29udHJhY3RzLnYxGgtsYWJlbC5wcm90byKpAgoF",
            "QnVpbGQSCgoCaWQYASABKAkSEwoLcmVwb19zb3VyY2UYAiABKAkSEgoKcmVw",
            "b19vd25lchgDIAEoCRIRCglyZXBvX25hbWUYBCABKAkSEwoLcmVwb19icmFu",
            "Y2gYBSABKAkSFQoNcmVwb19yZXZpc2lvbhgGIAEoCRIVCg1idWlsZF92ZXJz",
            "aW9uGAcgASgJEhQKDGJ1aWxkX3N0YXR1cxgIIAEoCRIjCgZsYWJlbHMYCSAD",
            "KAsyEy5jb250cmFjdHMudjEuTGFiZWwiWgoGQ29ycHVzEg0KCVVOSVZFUlNB",
            "TBAAEgcKA1dFQhABEgoKBklNQUdFUxACEgkKBUxPQ0FMEAMSCAoETkVXUxAE",
            "EgwKCFBST0RVQ1RTEAUSCQoFVklERU8QBmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Contracts.V1.LabelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Contracts.V1.Build), global::Contracts.V1.Build.Parser, new[]{ "Id", "RepoSource", "RepoOwner", "RepoName", "RepoBranch", "RepoRevision", "BuildVersion", "BuildStatus", "Labels" }, null, new[]{ typeof(global::Contracts.V1.Build.Types.Corpus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Build : pb::IMessage<Build> {
    private static readonly pb::MessageParser<Build> _parser = new pb::MessageParser<Build>(() => new Build());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Build> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Contracts.V1.BuildReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Build() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Build(Build other) : this() {
      id_ = other.id_;
      repoSource_ = other.repoSource_;
      repoOwner_ = other.repoOwner_;
      repoName_ = other.repoName_;
      repoBranch_ = other.repoBranch_;
      repoRevision_ = other.repoRevision_;
      buildVersion_ = other.buildVersion_;
      buildStatus_ = other.buildStatus_;
      labels_ = other.labels_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Build Clone() {
      return new Build(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_source" field.</summary>
    public const int RepoSourceFieldNumber = 2;
    private string repoSource_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoSource {
      get { return repoSource_; }
      set {
        repoSource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_owner" field.</summary>
    public const int RepoOwnerFieldNumber = 3;
    private string repoOwner_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoOwner {
      get { return repoOwner_; }
      set {
        repoOwner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_name" field.</summary>
    public const int RepoNameFieldNumber = 4;
    private string repoName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoName {
      get { return repoName_; }
      set {
        repoName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_branch" field.</summary>
    public const int RepoBranchFieldNumber = 5;
    private string repoBranch_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoBranch {
      get { return repoBranch_; }
      set {
        repoBranch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_revision" field.</summary>
    public const int RepoRevisionFieldNumber = 6;
    private string repoRevision_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoRevision {
      get { return repoRevision_; }
      set {
        repoRevision_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "build_version" field.</summary>
    public const int BuildVersionFieldNumber = 7;
    private string buildVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuildVersion {
      get { return buildVersion_; }
      set {
        buildVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "build_status" field.</summary>
    public const int BuildStatusFieldNumber = 8;
    private string buildStatus_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuildStatus {
      get { return buildStatus_; }
      set {
        buildStatus_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Contracts.V1.Label> _repeated_labels_codec
        = pb::FieldCodec.ForMessage(74, global::Contracts.V1.Label.Parser);
    private readonly pbc::RepeatedField<global::Contracts.V1.Label> labels_ = new pbc::RepeatedField<global::Contracts.V1.Label>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Contracts.V1.Label> Labels {
      get { return labels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Build);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Build other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (RepoSource != other.RepoSource) return false;
      if (RepoOwner != other.RepoOwner) return false;
      if (RepoName != other.RepoName) return false;
      if (RepoBranch != other.RepoBranch) return false;
      if (RepoRevision != other.RepoRevision) return false;
      if (BuildVersion != other.BuildVersion) return false;
      if (BuildStatus != other.BuildStatus) return false;
      if(!labels_.Equals(other.labels_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (RepoSource.Length != 0) hash ^= RepoSource.GetHashCode();
      if (RepoOwner.Length != 0) hash ^= RepoOwner.GetHashCode();
      if (RepoName.Length != 0) hash ^= RepoName.GetHashCode();
      if (RepoBranch.Length != 0) hash ^= RepoBranch.GetHashCode();
      if (RepoRevision.Length != 0) hash ^= RepoRevision.GetHashCode();
      if (BuildVersion.Length != 0) hash ^= BuildVersion.GetHashCode();
      if (BuildStatus.Length != 0) hash ^= BuildStatus.GetHashCode();
      hash ^= labels_.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (RepoSource.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RepoSource);
      }
      if (RepoOwner.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RepoOwner);
      }
      if (RepoName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(RepoName);
      }
      if (RepoBranch.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RepoBranch);
      }
      if (RepoRevision.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(RepoRevision);
      }
      if (BuildVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(BuildVersion);
      }
      if (BuildStatus.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(BuildStatus);
      }
      labels_.WriteTo(output, _repeated_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (RepoSource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoSource);
      }
      if (RepoOwner.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoOwner);
      }
      if (RepoName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoName);
      }
      if (RepoBranch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoBranch);
      }
      if (RepoRevision.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoRevision);
      }
      if (BuildVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuildVersion);
      }
      if (BuildStatus.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuildStatus);
      }
      size += labels_.CalculateSize(_repeated_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Build other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.RepoSource.Length != 0) {
        RepoSource = other.RepoSource;
      }
      if (other.RepoOwner.Length != 0) {
        RepoOwner = other.RepoOwner;
      }
      if (other.RepoName.Length != 0) {
        RepoName = other.RepoName;
      }
      if (other.RepoBranch.Length != 0) {
        RepoBranch = other.RepoBranch;
      }
      if (other.RepoRevision.Length != 0) {
        RepoRevision = other.RepoRevision;
      }
      if (other.BuildVersion.Length != 0) {
        BuildVersion = other.BuildVersion;
      }
      if (other.BuildStatus.Length != 0) {
        BuildStatus = other.BuildStatus;
      }
      labels_.Add(other.labels_);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            RepoSource = input.ReadString();
            break;
          }
          case 26: {
            RepoOwner = input.ReadString();
            break;
          }
          case 34: {
            RepoName = input.ReadString();
            break;
          }
          case 42: {
            RepoBranch = input.ReadString();
            break;
          }
          case 50: {
            RepoRevision = input.ReadString();
            break;
          }
          case 58: {
            BuildVersion = input.ReadString();
            break;
          }
          case 66: {
            BuildStatus = input.ReadString();
            break;
          }
          case 74: {
            labels_.AddEntriesFrom(input, _repeated_labels_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Build message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Corpus {
        [pbr::OriginalName("UNIVERSAL")] Universal = 0,
        [pbr::OriginalName("WEB")] Web = 1,
        [pbr::OriginalName("IMAGES")] Images = 2,
        [pbr::OriginalName("LOCAL")] Local = 3,
        [pbr::OriginalName("NEWS")] News = 4,
        [pbr::OriginalName("PRODUCTS")] Products = 5,
        [pbr::OriginalName("VIDEO")] Video = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code