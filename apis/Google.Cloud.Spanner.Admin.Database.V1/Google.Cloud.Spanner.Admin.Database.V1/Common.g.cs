// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/spanner/admin/database/v1/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Spanner.Admin.Database.V1 {

  /// <summary>Holder for reflection information generated from google/spanner/admin/database/v1/common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/spanner/admin/database/v1/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvc3Bhbm5lci9hZG1pbi9kYXRhYmFzZS92MS9jb21tb24ucHJv",
            "dG8SIGdvb2dsZS5zcGFubmVyLmFkbWluLmRhdGFiYXNlLnYxGh9nb29nbGUv",
            "YXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNl",
            "LnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhdnb29n",
            "bGUvcnBjL3N0YXR1cy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5w",
            "cm90byKLAQoRT3BlcmF0aW9uUHJvZ3Jlc3MSGAoQcHJvZ3Jlc3NfcGVyY2Vu",
            "dBgBIAEoBRIuCgpzdGFydF90aW1lGAIgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcBIsCghlbmRfdGltZRgDIAEoCzIaLmdvb2dsZS5wcm90b2J1",
            "Zi5UaW1lc3RhbXAiUAoQRW5jcnlwdGlvbkNvbmZpZxI8CgxrbXNfa2V5X25h",
            "bWUYAiABKAlCJvpBIwohY2xvdWRrbXMuZ29vZ2xlYXBpcy5jb20vQ3J5cHRv",
            "S2V5IsICCg5FbmNyeXB0aW9uSW5mbxJTCg9lbmNyeXB0aW9uX3R5cGUYAyAB",
            "KA4yNS5nb29nbGUuc3Bhbm5lci5hZG1pbi5kYXRhYmFzZS52MS5FbmNyeXB0",
            "aW9uSW5mby5UeXBlQgPgQQMSMgoRZW5jcnlwdGlvbl9zdGF0dXMYBCABKAsy",
            "Ei5nb29nbGUucnBjLlN0YXR1c0ID4EEDEkkKD2ttc19rZXlfdmVyc2lvbhgC",
            "IAEoCUIw4EED+kEqCihjbG91ZGttcy5nb29nbGVhcGlzLmNvbS9DcnlwdG9L",
            "ZXlWZXJzaW9uIlwKBFR5cGUSFAoQVFlQRV9VTlNQRUNJRklFRBAAEh0KGUdP",
            "T0dMRV9ERUZBVUxUX0VOQ1JZUFRJT04QARIfChtDVVNUT01FUl9NQU5BR0VE",
            "X0VOQ1JZUFRJT04QAkKkBAokY29tLmdvb2dsZS5zcGFubmVyLmFkbWluLmRh",
            "dGFiYXNlLnYxQgtDb21tb25Qcm90b1ABWkhnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL3NwYW5uZXIvYWRtaW4vZGF0YWJhc2UvdjE7",
            "ZGF0YWJhc2WqAiZHb29nbGUuQ2xvdWQuU3Bhbm5lci5BZG1pbi5EYXRhYmFz",
            "ZS5WMcoCJkdvb2dsZVxDbG91ZFxTcGFubmVyXEFkbWluXERhdGFiYXNlXFYx",
            "6gIrR29vZ2xlOjpDbG91ZDo6U3Bhbm5lcjo6QWRtaW46OkRhdGFiYXNlOjpW",
            "MepBeAohY2xvdWRrbXMuZ29vZ2xlYXBpcy5jb20vQ3J5cHRvS2V5ElNwcm9q",
            "ZWN0cy97cHJvamVjdH0vbG9jYXRpb25zL3tsb2NhdGlvbn0va2V5UmluZ3Mv",
            "e2tleV9yaW5nfS9jcnlwdG9LZXlzL3tjcnlwdG9fa2V5fepBpgEKKGNsb3Vk",
            "a21zLmdvb2dsZWFwaXMuY29tL0NyeXB0b0tleVZlcnNpb24SenByb2plY3Rz",
            "L3twcm9qZWN0fS9sb2NhdGlvbnMve2xvY2F0aW9ufS9rZXlSaW5ncy97a2V5",
            "X3Jpbmd9L2NyeXB0b0tleXMve2NyeXB0b19rZXl9L2NyeXB0b0tleVZlcnNp",
            "b25zL3tjcnlwdG9fa2V5X3ZlcnNpb259YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.Admin.Database.V1.OperationProgress), global::Google.Cloud.Spanner.Admin.Database.V1.OperationProgress.Parser, new[]{ "ProgressPercent", "StartTime", "EndTime" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionConfig), global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionConfig.Parser, new[]{ "KmsKeyName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo), global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Parser, new[]{ "EncryptionType", "EncryptionStatus", "KmsKeyVersion" }, null, new[]{ typeof(global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Encapsulates progress related information for a Cloud Spanner long
  /// running operation.
  /// </summary>
  public sealed partial class OperationProgress : pb::IMessage<OperationProgress>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OperationProgress> _parser = new pb::MessageParser<OperationProgress>(() => new OperationProgress());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OperationProgress> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.Admin.Database.V1.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationProgress() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationProgress(OperationProgress other) : this() {
      progressPercent_ = other.progressPercent_;
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationProgress Clone() {
      return new OperationProgress(this);
    }

    /// <summary>Field number for the "progress_percent" field.</summary>
    public const int ProgressPercentFieldNumber = 1;
    private int progressPercent_;
    /// <summary>
    /// Percent completion of the operation.
    /// Values are between 0 and 100 inclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ProgressPercent {
      get { return progressPercent_; }
      set {
        progressPercent_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startTime_;
    /// <summary>
    /// Time the request was received.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// If set, the time at which this operation failed or was completed
    /// successfully.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OperationProgress);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OperationProgress other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProgressPercent != other.ProgressPercent) return false;
      if (!object.Equals(StartTime, other.StartTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProgressPercent != 0) hash ^= ProgressPercent.GetHashCode();
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ProgressPercent != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProgressPercent);
      }
      if (startTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EndTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ProgressPercent != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProgressPercent);
      }
      if (startTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EndTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProgressPercent != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ProgressPercent);
      }
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OperationProgress other) {
      if (other == null) {
        return;
      }
      if (other.ProgressPercent != 0) {
        ProgressPercent = other.ProgressPercent;
      }
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartTime.MergeFrom(other.StartTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 8: {
            ProgressPercent = input.ReadInt32();
            break;
          }
          case 18: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 26: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ProgressPercent = input.ReadInt32();
            break;
          }
          case 18: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 26: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Encryption configuration for a Cloud Spanner database.
  /// </summary>
  public sealed partial class EncryptionConfig : pb::IMessage<EncryptionConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EncryptionConfig> _parser = new pb::MessageParser<EncryptionConfig>(() => new EncryptionConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncryptionConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.Admin.Database.V1.CommonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncryptionConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncryptionConfig(EncryptionConfig other) : this() {
      kmsKeyName_ = other.kmsKeyName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncryptionConfig Clone() {
      return new EncryptionConfig(this);
    }

    /// <summary>Field number for the "kms_key_name" field.</summary>
    public const int KmsKeyNameFieldNumber = 2;
    private string kmsKeyName_ = "";
    /// <summary>
    /// The Cloud KMS key to be used for encrypting and decrypting
    /// the database. Values are of the form
    /// `projects/&lt;project>/locations/&lt;location>/keyRings/&lt;key_ring>/cryptoKeys/&lt;kms_key_name>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KmsKeyName {
      get { return kmsKeyName_; }
      set {
        kmsKeyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncryptionConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncryptionConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KmsKeyName != other.KmsKeyName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (KmsKeyName.Length != 0) hash ^= KmsKeyName.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (KmsKeyName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(KmsKeyName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (KmsKeyName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(KmsKeyName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (KmsKeyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KmsKeyName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncryptionConfig other) {
      if (other == null) {
        return;
      }
      if (other.KmsKeyName.Length != 0) {
        KmsKeyName = other.KmsKeyName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 18: {
            KmsKeyName = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            KmsKeyName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Encryption information for a Cloud Spanner database or backup.
  /// </summary>
  public sealed partial class EncryptionInfo : pb::IMessage<EncryptionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EncryptionInfo> _parser = new pb::MessageParser<EncryptionInfo>(() => new EncryptionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncryptionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.Admin.Database.V1.CommonReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncryptionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncryptionInfo(EncryptionInfo other) : this() {
      encryptionType_ = other.encryptionType_;
      encryptionStatus_ = other.encryptionStatus_ != null ? other.encryptionStatus_.Clone() : null;
      kmsKeyVersion_ = other.kmsKeyVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncryptionInfo Clone() {
      return new EncryptionInfo(this);
    }

    /// <summary>Field number for the "encryption_type" field.</summary>
    public const int EncryptionTypeFieldNumber = 3;
    private global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type encryptionType_ = global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type.Unspecified;
    /// <summary>
    /// Output only. The type of encryption.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type EncryptionType {
      get { return encryptionType_; }
      set {
        encryptionType_ = value;
      }
    }

    /// <summary>Field number for the "encryption_status" field.</summary>
    public const int EncryptionStatusFieldNumber = 4;
    private global::Google.Rpc.Status encryptionStatus_;
    /// <summary>
    /// Output only. If present, the status of a recent encrypt/decrypt call on underlying data
    /// for this database or backup. Regardless of status, data is always encrypted
    /// at rest.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Rpc.Status EncryptionStatus {
      get { return encryptionStatus_; }
      set {
        encryptionStatus_ = value;
      }
    }

    /// <summary>Field number for the "kms_key_version" field.</summary>
    public const int KmsKeyVersionFieldNumber = 2;
    private string kmsKeyVersion_ = "";
    /// <summary>
    /// Output only. A Cloud KMS key version that is being used to protect the database or
    /// backup.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KmsKeyVersion {
      get { return kmsKeyVersion_; }
      set {
        kmsKeyVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncryptionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncryptionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncryptionType != other.EncryptionType) return false;
      if (!object.Equals(EncryptionStatus, other.EncryptionStatus)) return false;
      if (KmsKeyVersion != other.KmsKeyVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncryptionType != global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type.Unspecified) hash ^= EncryptionType.GetHashCode();
      if (encryptionStatus_ != null) hash ^= EncryptionStatus.GetHashCode();
      if (KmsKeyVersion.Length != 0) hash ^= KmsKeyVersion.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (KmsKeyVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(KmsKeyVersion);
      }
      if (EncryptionType != global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) EncryptionType);
      }
      if (encryptionStatus_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(EncryptionStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (KmsKeyVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(KmsKeyVersion);
      }
      if (EncryptionType != global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) EncryptionType);
      }
      if (encryptionStatus_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(EncryptionStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncryptionType != global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EncryptionType);
      }
      if (encryptionStatus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EncryptionStatus);
      }
      if (KmsKeyVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KmsKeyVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncryptionInfo other) {
      if (other == null) {
        return;
      }
      if (other.EncryptionType != global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type.Unspecified) {
        EncryptionType = other.EncryptionType;
      }
      if (other.encryptionStatus_ != null) {
        if (encryptionStatus_ == null) {
          EncryptionStatus = new global::Google.Rpc.Status();
        }
        EncryptionStatus.MergeFrom(other.EncryptionStatus);
      }
      if (other.KmsKeyVersion.Length != 0) {
        KmsKeyVersion = other.KmsKeyVersion;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 18: {
            KmsKeyVersion = input.ReadString();
            break;
          }
          case 24: {
            EncryptionType = (global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type) input.ReadEnum();
            break;
          }
          case 34: {
            if (encryptionStatus_ == null) {
              EncryptionStatus = new global::Google.Rpc.Status();
            }
            input.ReadMessage(EncryptionStatus);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            KmsKeyVersion = input.ReadString();
            break;
          }
          case 24: {
            EncryptionType = (global::Google.Cloud.Spanner.Admin.Database.V1.EncryptionInfo.Types.Type) input.ReadEnum();
            break;
          }
          case 34: {
            if (encryptionStatus_ == null) {
              EncryptionStatus = new global::Google.Rpc.Status();
            }
            input.ReadMessage(EncryptionStatus);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EncryptionInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible encryption types.
      /// </summary>
      public enum Type {
        /// <summary>
        /// Encryption type was not specified, though data at rest remains encrypted.
        /// </summary>
        [pbr::OriginalName("TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The data is encrypted at rest with a key that is
        /// fully managed by Google. No key version or status will be populated.
        /// This is the default state.
        /// </summary>
        [pbr::OriginalName("GOOGLE_DEFAULT_ENCRYPTION")] GoogleDefaultEncryption = 1,
        /// <summary>
        /// The data is encrypted at rest with a key that is
        /// managed by the customer. The active version of the key. `kms_key_version`
        /// will be populated, and `encryption_status` may be populated.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_MANAGED_ENCRYPTION")] CustomerManagedEncryption = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
