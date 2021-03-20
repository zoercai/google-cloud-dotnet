// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Settings for <see cref="AnswerRecordsClient"/> instances.</summary>
    public sealed partial class AnswerRecordsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AnswerRecordsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AnswerRecordsSettings"/>.</returns>
        public static AnswerRecordsSettings GetDefault() => new AnswerRecordsSettings();

        /// <summary>Constructs a new <see cref="AnswerRecordsSettings"/> object with default settings.</summary>
        public AnswerRecordsSettings()
        {
        }

        private AnswerRecordsSettings(AnswerRecordsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAnswerRecordsSettings = existing.ListAnswerRecordsSettings;
            UpdateAnswerRecordSettings = existing.UpdateAnswerRecordSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AnswerRecordsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnswerRecordsClient.ListAnswerRecords</c> and <c>AnswerRecordsClient.ListAnswerRecordsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAnswerRecordsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnswerRecordsClient.UpdateAnswerRecord</c> and <c>AnswerRecordsClient.UpdateAnswerRecordAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAnswerRecordSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AnswerRecordsSettings"/> object.</returns>
        public AnswerRecordsSettings Clone() => new AnswerRecordsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AnswerRecordsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AnswerRecordsClientBuilder : gaxgrpc::ClientBuilderBase<AnswerRecordsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AnswerRecordsSettings Settings { get; set; }

        partial void InterceptBuild(ref AnswerRecordsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AnswerRecordsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AnswerRecordsClient Build()
        {
            AnswerRecordsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AnswerRecordsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AnswerRecordsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AnswerRecordsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AnswerRecordsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AnswerRecordsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AnswerRecordsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AnswerRecordsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AnswerRecordsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AnswerRecordsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AnswerRecords client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [AnswerRecords][google.cloud.dialogflow.v2.AnswerRecord].
    /// </remarks>
    public abstract partial class AnswerRecordsClient
    {
        /// <summary>
        /// The default endpoint for the AnswerRecords service, which is a host of "dialogflow.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default AnswerRecords scopes.</summary>
        /// <remarks>
        /// The default AnswerRecords scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AnswerRecordsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AnswerRecordsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AnswerRecordsClient"/>.</returns>
        public static stt::Task<AnswerRecordsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AnswerRecordsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AnswerRecordsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AnswerRecordsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AnswerRecordsClient"/>.</returns>
        public static AnswerRecordsClient Create() => new AnswerRecordsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AnswerRecordsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AnswerRecordsSettings"/>.</param>
        /// <returns>The created <see cref="AnswerRecordsClient"/>.</returns>
        internal static AnswerRecordsClient Create(grpccore::CallInvoker callInvoker, AnswerRecordsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AnswerRecords.AnswerRecordsClient grpcClient = new AnswerRecords.AnswerRecordsClient(callInvoker);
            return new AnswerRecordsClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC AnswerRecords client</summary>
        public virtual AnswerRecords.AnswerRecordsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all answer records in the specified project in reverse
        /// chronological order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnswerRecord"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnswerRecordsResponse, AnswerRecord> ListAnswerRecords(ListAnswerRecordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all answer records in the specified project in reverse
        /// chronological order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnswerRecord"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnswerRecordsResponse, AnswerRecord> ListAnswerRecordsAsync(ListAnswerRecordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all answer records in the specified project in reverse
        /// chronological order.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all answer records for in reverse
        /// chronological order. Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnswerRecord"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnswerRecordsResponse, AnswerRecord> ListAnswerRecords(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnswerRecords(new ListAnswerRecordsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all answer records in the specified project in reverse
        /// chronological order.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all answer records for in reverse
        /// chronological order. Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnswerRecord"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnswerRecordsResponse, AnswerRecord> ListAnswerRecordsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnswerRecordsAsync(new ListAnswerRecordsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all answer records in the specified project in reverse
        /// chronological order.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all answer records for in reverse
        /// chronological order. Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnswerRecord"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnswerRecordsResponse, AnswerRecord> ListAnswerRecords(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnswerRecords(new ListAnswerRecordsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all answer records in the specified project in reverse
        /// chronological order.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all answer records for in reverse
        /// chronological order. Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnswerRecord"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnswerRecordsResponse, AnswerRecord> ListAnswerRecordsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnswerRecordsAsync(new ListAnswerRecordsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all answer records in the specified project in reverse
        /// chronological order.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all answer records for in reverse
        /// chronological order. Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnswerRecord"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnswerRecordsResponse, AnswerRecord> ListAnswerRecords(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnswerRecords(new ListAnswerRecordsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all answer records in the specified project in reverse
        /// chronological order.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all answer records for in reverse
        /// chronological order. Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnswerRecord"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnswerRecordsResponse, AnswerRecord> ListAnswerRecordsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnswerRecordsAsync(new ListAnswerRecordsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates the specified answer record.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnswerRecord UpdateAnswerRecord(UpdateAnswerRecordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified answer record.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnswerRecord> UpdateAnswerRecordAsync(UpdateAnswerRecordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified answer record.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnswerRecord> UpdateAnswerRecordAsync(UpdateAnswerRecordRequest request, st::CancellationToken cancellationToken) =>
            UpdateAnswerRecordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified answer record.
        /// </summary>
        /// <param name="answerRecord">
        /// Required. Answer record to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnswerRecord UpdateAnswerRecord(AnswerRecord answerRecord, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAnswerRecord(new UpdateAnswerRecordRequest
            {
                AnswerRecord = gax::GaxPreconditions.CheckNotNull(answerRecord, nameof(answerRecord)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified answer record.
        /// </summary>
        /// <param name="answerRecord">
        /// Required. Answer record to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnswerRecord> UpdateAnswerRecordAsync(AnswerRecord answerRecord, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAnswerRecordAsync(new UpdateAnswerRecordRequest
            {
                AnswerRecord = gax::GaxPreconditions.CheckNotNull(answerRecord, nameof(answerRecord)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified answer record.
        /// </summary>
        /// <param name="answerRecord">
        /// Required. Answer record to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnswerRecord> UpdateAnswerRecordAsync(AnswerRecord answerRecord, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAnswerRecordAsync(answerRecord, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AnswerRecords client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [AnswerRecords][google.cloud.dialogflow.v2.AnswerRecord].
    /// </remarks>
    public sealed partial class AnswerRecordsClientImpl : AnswerRecordsClient
    {
        private readonly gaxgrpc::ApiCall<ListAnswerRecordsRequest, ListAnswerRecordsResponse> _callListAnswerRecords;

        private readonly gaxgrpc::ApiCall<UpdateAnswerRecordRequest, AnswerRecord> _callUpdateAnswerRecord;

        /// <summary>
        /// Constructs a client wrapper for the AnswerRecords service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AnswerRecordsSettings"/> used within this client.</param>
        public AnswerRecordsClientImpl(AnswerRecords.AnswerRecordsClient grpcClient, AnswerRecordsSettings settings)
        {
            GrpcClient = grpcClient;
            AnswerRecordsSettings effectiveSettings = settings ?? AnswerRecordsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListAnswerRecords = clientHelper.BuildApiCall<ListAnswerRecordsRequest, ListAnswerRecordsResponse>(grpcClient.ListAnswerRecordsAsync, grpcClient.ListAnswerRecords, effectiveSettings.ListAnswerRecordsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnswerRecords);
            Modify_ListAnswerRecordsApiCall(ref _callListAnswerRecords);
            _callUpdateAnswerRecord = clientHelper.BuildApiCall<UpdateAnswerRecordRequest, AnswerRecord>(grpcClient.UpdateAnswerRecordAsync, grpcClient.UpdateAnswerRecord, effectiveSettings.UpdateAnswerRecordSettings).WithGoogleRequestParam("answer_record.name", request => request.AnswerRecord?.Name);
            Modify_ApiCall(ref _callUpdateAnswerRecord);
            Modify_UpdateAnswerRecordApiCall(ref _callUpdateAnswerRecord);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAnswerRecordsApiCall(ref gaxgrpc::ApiCall<ListAnswerRecordsRequest, ListAnswerRecordsResponse> call);

        partial void Modify_UpdateAnswerRecordApiCall(ref gaxgrpc::ApiCall<UpdateAnswerRecordRequest, AnswerRecord> call);

        partial void OnConstruction(AnswerRecords.AnswerRecordsClient grpcClient, AnswerRecordsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AnswerRecords client</summary>
        public override AnswerRecords.AnswerRecordsClient GrpcClient { get; }

        partial void Modify_ListAnswerRecordsRequest(ref ListAnswerRecordsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAnswerRecordRequest(ref UpdateAnswerRecordRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all answer records in the specified project in reverse
        /// chronological order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnswerRecord"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnswerRecordsResponse, AnswerRecord> ListAnswerRecords(ListAnswerRecordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnswerRecordsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnswerRecordsRequest, ListAnswerRecordsResponse, AnswerRecord>(_callListAnswerRecords, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all answer records in the specified project in reverse
        /// chronological order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnswerRecord"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnswerRecordsResponse, AnswerRecord> ListAnswerRecordsAsync(ListAnswerRecordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnswerRecordsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnswerRecordsRequest, ListAnswerRecordsResponse, AnswerRecord>(_callListAnswerRecords, request, callSettings);
        }

        /// <summary>
        /// Updates the specified answer record.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnswerRecord UpdateAnswerRecord(UpdateAnswerRecordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAnswerRecordRequest(ref request, ref callSettings);
            return _callUpdateAnswerRecord.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified answer record.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnswerRecord> UpdateAnswerRecordAsync(UpdateAnswerRecordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAnswerRecordRequest(ref request, ref callSettings);
            return _callUpdateAnswerRecord.Async(request, callSettings);
        }
    }

    public partial class ListAnswerRecordsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnswerRecordsResponse : gaxgrpc::IPageResponse<AnswerRecord>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AnswerRecord> GetEnumerator() => AnswerRecords.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
