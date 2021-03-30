// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/datacatalog/v1/search.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DataCatalog.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/datacatalog/v1/search.proto</summary>
  public static partial class SearchReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/datacatalog/v1/search.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SearchReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvZGF0YWNhdGFsb2cvdjEvc2VhcmNoLnByb3RvEhtn",
            "b29nbGUuY2xvdWQuZGF0YWNhdGFsb2cudjEaH2dvb2dsZS9hcGkvZmllbGRf",
            "YmVoYXZpb3IucHJvdG8aKGdvb2dsZS9jbG91ZC9kYXRhY2F0YWxvZy92MS9j",
            "b21tb24ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8i",
            "gwMKE1NlYXJjaENhdGFsb2dSZXN1bHQSSQoSc2VhcmNoX3Jlc3VsdF90eXBl",
            "GAEgASgOMi0uZ29vZ2xlLmNsb3VkLmRhdGFjYXRhbG9nLnYxLlNlYXJjaFJl",
            "c3VsdFR5cGUSHQoVc2VhcmNoX3Jlc3VsdF9zdWJ0eXBlGAIgASgJEh4KFnJl",
            "bGF0aXZlX3Jlc291cmNlX25hbWUYAyABKAkSFwoPbGlua2VkX3Jlc291cmNl",
            "GAQgASgJEi8KC21vZGlmeV90aW1lGAcgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcBJPChFpbnRlZ3JhdGVkX3N5c3RlbRgIIAEoDjItLmdvb2ds",
            "ZS5jbG91ZC5kYXRhY2F0YWxvZy52MS5JbnRlZ3JhdGVkU3lzdGVtQgPgQQNI",
            "ABIfChV1c2VyX3NwZWNpZmllZF9zeXN0ZW0YCSABKAlIABIcChRmdWxseV9x",
            "dWFsaWZpZWRfbmFtZRgKIAEoCUIICgZzeXN0ZW0qZAoQU2VhcmNoUmVzdWx0",
            "VHlwZRIiCh5TRUFSQ0hfUkVTVUxUX1RZUEVfVU5TUEVDSUZJRUQQABIJCgVF",
            "TlRSWRABEhAKDFRBR19URU1QTEFURRACEg8KC0VOVFJZX0dST1VQEANCywEK",
            "H2NvbS5nb29nbGUuY2xvdWQuZGF0YWNhdGFsb2cudjFQAVpGZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9kYXRhY2F0YWxv",
            "Zy92MTtkYXRhY2F0YWxvZ/gBAaoCG0dvb2dsZS5DbG91ZC5EYXRhQ2F0YWxv",
            "Zy5WMcoCG0dvb2dsZVxDbG91ZFxEYXRhQ2F0YWxvZ1xWMeoCHkdvb2dsZTo6",
            "Q2xvdWQ6OkRhdGFDYXRhbG9nOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Cloud.DataCatalog.V1.CommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.DataCatalog.V1.SearchResultType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.SearchCatalogResult), global::Google.Cloud.DataCatalog.V1.SearchCatalogResult.Parser, new[]{ "SearchResultType", "SearchResultSubtype", "RelativeResourceName", "LinkedResource", "ModifyTime", "IntegratedSystem", "UserSpecifiedSystem", "FullyQualifiedName" }, new[]{ "System" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The different types of resources that can be returned in search.
  /// </summary>
  public enum SearchResultType {
    /// <summary>
    /// Default unknown type.
    /// </summary>
    [pbr::OriginalName("SEARCH_RESULT_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// An [Entry][google.cloud.datacatalog.v1.Entry].
    /// </summary>
    [pbr::OriginalName("ENTRY")] Entry = 1,
    /// <summary>
    /// A [TagTemplate][google.cloud.datacatalog.v1.TagTemplate].
    /// </summary>
    [pbr::OriginalName("TAG_TEMPLATE")] TagTemplate = 2,
    /// <summary>
    /// An [EntryGroup][google.cloud.datacatalog.v1.EntryGroup].
    /// </summary>
    [pbr::OriginalName("ENTRY_GROUP")] EntryGroup = 3,
  }

  #endregion

  #region Messages
  /// <summary>
  /// A result that appears in the response of a search request. Each result
  /// captures details of one entry that matches the search.
  /// </summary>
  public sealed partial class SearchCatalogResult : pb::IMessage<SearchCatalogResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SearchCatalogResult> _parser = new pb::MessageParser<SearchCatalogResult>(() => new SearchCatalogResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SearchCatalogResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.SearchReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchCatalogResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchCatalogResult(SearchCatalogResult other) : this() {
      searchResultType_ = other.searchResultType_;
      searchResultSubtype_ = other.searchResultSubtype_;
      relativeResourceName_ = other.relativeResourceName_;
      linkedResource_ = other.linkedResource_;
      modifyTime_ = other.modifyTime_ != null ? other.modifyTime_.Clone() : null;
      fullyQualifiedName_ = other.fullyQualifiedName_;
      switch (other.SystemCase) {
        case SystemOneofCase.IntegratedSystem:
          IntegratedSystem = other.IntegratedSystem;
          break;
        case SystemOneofCase.UserSpecifiedSystem:
          UserSpecifiedSystem = other.UserSpecifiedSystem;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchCatalogResult Clone() {
      return new SearchCatalogResult(this);
    }

    /// <summary>Field number for the "search_result_type" field.</summary>
    public const int SearchResultTypeFieldNumber = 1;
    private global::Google.Cloud.DataCatalog.V1.SearchResultType searchResultType_ = global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified;
    /// <summary>
    /// Type of the search result. This field can be used to determine which Get
    /// method to call to fetch the full resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.DataCatalog.V1.SearchResultType SearchResultType {
      get { return searchResultType_; }
      set {
        searchResultType_ = value;
      }
    }

    /// <summary>Field number for the "search_result_subtype" field.</summary>
    public const int SearchResultSubtypeFieldNumber = 2;
    private string searchResultSubtype_ = "";
    /// <summary>
    /// Sub-type of the search result. This is a dot-delimited description of the
    /// resource's full type, and is the same as the value callers would provide in
    /// the "type" search facet.  Examples: `entry.table`, `entry.dataStream`,
    /// `tagTemplate`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SearchResultSubtype {
      get { return searchResultSubtype_; }
      set {
        searchResultSubtype_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "relative_resource_name" field.</summary>
    public const int RelativeResourceNameFieldNumber = 3;
    private string relativeResourceName_ = "";
    /// <summary>
    /// The relative resource name of the resource in URL format.
    /// Examples:
    ///
    ///  * `projects/{project_id}/locations/{location_id}/entryGroups/{entry_group_id}/entries/{entry_id}`
    ///  * `projects/{project_id}/tagTemplates/{tag_template_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RelativeResourceName {
      get { return relativeResourceName_; }
      set {
        relativeResourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "linked_resource" field.</summary>
    public const int LinkedResourceFieldNumber = 4;
    private string linkedResource_ = "";
    /// <summary>
    /// The full name of the cloud resource the entry belongs to. See:
    /// https://cloud.google.com/apis/design/resource_names#full_resource_name.
    /// Example:
    ///
    ///  * `//bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LinkedResource {
      get { return linkedResource_; }
      set {
        linkedResource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "modify_time" field.</summary>
    public const int ModifyTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp modifyTime_;
    /// <summary>
    /// Last-modified timestamp of the entry from the managing system.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ModifyTime {
      get { return modifyTime_; }
      set {
        modifyTime_ = value;
      }
    }

    /// <summary>Field number for the "integrated_system" field.</summary>
    public const int IntegratedSystemFieldNumber = 8;
    /// <summary>
    /// Output only. This field indicates the entry's source system that Data Catalog
    /// integrates with, such as BigQuery or Cloud Pub/Sub.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.DataCatalog.V1.IntegratedSystem IntegratedSystem {
      get { return systemCase_ == SystemOneofCase.IntegratedSystem ? (global::Google.Cloud.DataCatalog.V1.IntegratedSystem) system_ : global::Google.Cloud.DataCatalog.V1.IntegratedSystem.Unspecified; }
      set {
        system_ = value;
        systemCase_ = SystemOneofCase.IntegratedSystem;
      }
    }

    /// <summary>Field number for the "user_specified_system" field.</summary>
    public const int UserSpecifiedSystemFieldNumber = 9;
    /// <summary>
    /// This field indicates the entry's source system that Data Catalog does not
    /// integrate with.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserSpecifiedSystem {
      get { return systemCase_ == SystemOneofCase.UserSpecifiedSystem ? (string) system_ : ""; }
      set {
        system_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        systemCase_ = SystemOneofCase.UserSpecifiedSystem;
      }
    }

    /// <summary>Field number for the "fully_qualified_name" field.</summary>
    public const int FullyQualifiedNameFieldNumber = 10;
    private string fullyQualifiedName_ = "";
    /// <summary>
    /// Fully Qualified Name of the resource.
    /// There are two main forms of FQNs:
    /// {system}:{project}.{dot-separated path to resource}
    ///     for non-regionalized resources
    /// {system}:{project}.{location id}.{dot-separated path to resource}
    ///     for regionalized resources
    /// Examples:
    /// * dataproc_metastore:projectId.locationId.instanceId.databaseId.tableId
    /// * bigquery:table.project_id.dataset_id.table_id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FullyQualifiedName {
      get { return fullyQualifiedName_; }
      set {
        fullyQualifiedName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object system_;
    /// <summary>Enum of possible cases for the "system" oneof.</summary>
    public enum SystemOneofCase {
      None = 0,
      IntegratedSystem = 8,
      UserSpecifiedSystem = 9,
    }
    private SystemOneofCase systemCase_ = SystemOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemOneofCase SystemCase {
      get { return systemCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearSystem() {
      systemCase_ = SystemOneofCase.None;
      system_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SearchCatalogResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SearchCatalogResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SearchResultType != other.SearchResultType) return false;
      if (SearchResultSubtype != other.SearchResultSubtype) return false;
      if (RelativeResourceName != other.RelativeResourceName) return false;
      if (LinkedResource != other.LinkedResource) return false;
      if (!object.Equals(ModifyTime, other.ModifyTime)) return false;
      if (IntegratedSystem != other.IntegratedSystem) return false;
      if (UserSpecifiedSystem != other.UserSpecifiedSystem) return false;
      if (FullyQualifiedName != other.FullyQualifiedName) return false;
      if (SystemCase != other.SystemCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SearchResultType != global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified) hash ^= SearchResultType.GetHashCode();
      if (SearchResultSubtype.Length != 0) hash ^= SearchResultSubtype.GetHashCode();
      if (RelativeResourceName.Length != 0) hash ^= RelativeResourceName.GetHashCode();
      if (LinkedResource.Length != 0) hash ^= LinkedResource.GetHashCode();
      if (modifyTime_ != null) hash ^= ModifyTime.GetHashCode();
      if (systemCase_ == SystemOneofCase.IntegratedSystem) hash ^= IntegratedSystem.GetHashCode();
      if (systemCase_ == SystemOneofCase.UserSpecifiedSystem) hash ^= UserSpecifiedSystem.GetHashCode();
      if (FullyQualifiedName.Length != 0) hash ^= FullyQualifiedName.GetHashCode();
      hash ^= (int) systemCase_;
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
      if (SearchResultType != global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) SearchResultType);
      }
      if (SearchResultSubtype.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SearchResultSubtype);
      }
      if (RelativeResourceName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RelativeResourceName);
      }
      if (LinkedResource.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LinkedResource);
      }
      if (modifyTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ModifyTime);
      }
      if (systemCase_ == SystemOneofCase.IntegratedSystem) {
        output.WriteRawTag(64);
        output.WriteEnum((int) IntegratedSystem);
      }
      if (systemCase_ == SystemOneofCase.UserSpecifiedSystem) {
        output.WriteRawTag(74);
        output.WriteString(UserSpecifiedSystem);
      }
      if (FullyQualifiedName.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(FullyQualifiedName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SearchResultType != global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) SearchResultType);
      }
      if (SearchResultSubtype.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SearchResultSubtype);
      }
      if (RelativeResourceName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RelativeResourceName);
      }
      if (LinkedResource.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LinkedResource);
      }
      if (modifyTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ModifyTime);
      }
      if (systemCase_ == SystemOneofCase.IntegratedSystem) {
        output.WriteRawTag(64);
        output.WriteEnum((int) IntegratedSystem);
      }
      if (systemCase_ == SystemOneofCase.UserSpecifiedSystem) {
        output.WriteRawTag(74);
        output.WriteString(UserSpecifiedSystem);
      }
      if (FullyQualifiedName.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(FullyQualifiedName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SearchResultType != global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SearchResultType);
      }
      if (SearchResultSubtype.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SearchResultSubtype);
      }
      if (RelativeResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RelativeResourceName);
      }
      if (LinkedResource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LinkedResource);
      }
      if (modifyTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModifyTime);
      }
      if (systemCase_ == SystemOneofCase.IntegratedSystem) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) IntegratedSystem);
      }
      if (systemCase_ == SystemOneofCase.UserSpecifiedSystem) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserSpecifiedSystem);
      }
      if (FullyQualifiedName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FullyQualifiedName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SearchCatalogResult other) {
      if (other == null) {
        return;
      }
      if (other.SearchResultType != global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified) {
        SearchResultType = other.SearchResultType;
      }
      if (other.SearchResultSubtype.Length != 0) {
        SearchResultSubtype = other.SearchResultSubtype;
      }
      if (other.RelativeResourceName.Length != 0) {
        RelativeResourceName = other.RelativeResourceName;
      }
      if (other.LinkedResource.Length != 0) {
        LinkedResource = other.LinkedResource;
      }
      if (other.modifyTime_ != null) {
        if (modifyTime_ == null) {
          ModifyTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ModifyTime.MergeFrom(other.ModifyTime);
      }
      if (other.FullyQualifiedName.Length != 0) {
        FullyQualifiedName = other.FullyQualifiedName;
      }
      switch (other.SystemCase) {
        case SystemOneofCase.IntegratedSystem:
          IntegratedSystem = other.IntegratedSystem;
          break;
        case SystemOneofCase.UserSpecifiedSystem:
          UserSpecifiedSystem = other.UserSpecifiedSystem;
          break;
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
            SearchResultType = (global::Google.Cloud.DataCatalog.V1.SearchResultType) input.ReadEnum();
            break;
          }
          case 18: {
            SearchResultSubtype = input.ReadString();
            break;
          }
          case 26: {
            RelativeResourceName = input.ReadString();
            break;
          }
          case 34: {
            LinkedResource = input.ReadString();
            break;
          }
          case 58: {
            if (modifyTime_ == null) {
              ModifyTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ModifyTime);
            break;
          }
          case 64: {
            system_ = input.ReadEnum();
            systemCase_ = SystemOneofCase.IntegratedSystem;
            break;
          }
          case 74: {
            UserSpecifiedSystem = input.ReadString();
            break;
          }
          case 82: {
            FullyQualifiedName = input.ReadString();
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
            SearchResultType = (global::Google.Cloud.DataCatalog.V1.SearchResultType) input.ReadEnum();
            break;
          }
          case 18: {
            SearchResultSubtype = input.ReadString();
            break;
          }
          case 26: {
            RelativeResourceName = input.ReadString();
            break;
          }
          case 34: {
            LinkedResource = input.ReadString();
            break;
          }
          case 58: {
            if (modifyTime_ == null) {
              ModifyTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ModifyTime);
            break;
          }
          case 64: {
            system_ = input.ReadEnum();
            systemCase_ = SystemOneofCase.IntegratedSystem;
            break;
          }
          case 74: {
            UserSpecifiedSystem = input.ReadString();
            break;
          }
          case 82: {
            FullyQualifiedName = input.ReadString();
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
