// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	public sealed partial class LobbyDetails : Handle
	{
		public LobbyDetails()
		{
		}

		public LobbyDetails(System.IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// The most recent version of the <see cref="CopyAttributeByIndex" /> API.
		/// </summary>
		public const int LobbydetailsCopyattributebyindexApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="CopyAttributeByKey" /> API.
		/// </summary>
		public const int LobbydetailsCopyattributebykeyApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="CopyInfo" /> API.
		/// </summary>
		public const int LobbydetailsCopyinfoApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="CopyMemberAttributeByIndex" /> API.
		/// </summary>
		public const int LobbydetailsCopymemberattributebyindexApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="CopyMemberAttributeByKey" /> API.
		/// </summary>
		public const int LobbydetailsCopymemberattributebykeyApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="CopyMemberInfo" /> API.
		/// </summary>
		public const int LobbydetailsCopymemberinfoApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="GetAttributeCount" /> API.
		/// </summary>
		public const int LobbydetailsGetattributecountApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="GetLobbyOwner" /> API.
		/// </summary>
		public const int LobbydetailsGetlobbyownerApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="GetMemberAttributeCount" /> API.
		/// </summary>
		public const int LobbydetailsGetmemberattributecountApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="GetMemberByIndex" /> API.
		/// </summary>
		public const int LobbydetailsGetmemberbyindexApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="GetMemberCount" /> API.
		/// </summary>
		public const int LobbydetailsGetmembercountApiLatest = 1;

		public const int LobbydetailsInfoApiLatest = 3;

		/// <summary>
		/// The most recent version of the <see cref="LobbyDetailsMemberInfo" /> API.
		/// </summary>
		public const int LobbydetailsMemberinfoApiLatest = 1;

		/// <summary>
		/// <see cref="CopyAttributeByIndex" /> is used to immediately retrieve a copy of a lobby attribute from a given source such as a existing lobby or a search result.
		/// If the call returns an <see cref="Result.Success" /> result, the out parameter, OutAttribute, must be passed to <see cref="LobbyInterface.Release" /> to release the memory associated with it.
		/// <seealso cref="Attribute" />
		/// <seealso cref="LobbyDetailsCopyAttributeByIndexOptions" />
		/// <seealso cref="LobbyInterface.Release" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <param name="outAttribute">Out parameter used to receive the <see cref="Attribute" /> structure.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutAttribute
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result CopyAttributeByIndex(ref LobbyDetailsCopyAttributeByIndexOptions options, out Attribute? outAttribute)
		{
			LobbyDetailsCopyAttributeByIndexOptionsInternal optionsInternal = new LobbyDetailsCopyAttributeByIndexOptionsInternal();
			optionsInternal.Set(ref options);

			var outAttributeAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_LobbyDetails_CopyAttributeByIndex(InnerHandle, ref optionsInternal, ref outAttributeAddress);

			Helper.Dispose(ref optionsInternal);

			Helper.Get<AttributeInternal, Attribute>(outAttributeAddress, out outAttribute);
			if (outAttribute != null)
			{
				Bindings.EOS_Lobby_Attribute_Release(outAttributeAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// <see cref="CopyAttributeByKey" /> is used to immediately retrieve a copy of a lobby attribute from a given source such as a existing lobby or a search result.
		/// If the call returns an <see cref="Result.Success" /> result, the out parameter, OutAttribute, must be passed to <see cref="LobbyInterface.Release" /> to release the memory associated with it.
		/// <seealso cref="Attribute" />
		/// <seealso cref="LobbyDetailsCopyAttributeByKeyOptions" />
		/// <seealso cref="LobbyInterface.Release" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <param name="outAttribute">Out parameter used to receive the <see cref="Attribute" /> structure.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutAttribute
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result CopyAttributeByKey(ref LobbyDetailsCopyAttributeByKeyOptions options, out Attribute? outAttribute)
		{
			LobbyDetailsCopyAttributeByKeyOptionsInternal optionsInternal = new LobbyDetailsCopyAttributeByKeyOptionsInternal();
			optionsInternal.Set(ref options);

			var outAttributeAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_LobbyDetails_CopyAttributeByKey(InnerHandle, ref optionsInternal, ref outAttributeAddress);

			Helper.Dispose(ref optionsInternal);

			Helper.Get<AttributeInternal, Attribute>(outAttributeAddress, out outAttribute);
			if (outAttribute != null)
			{
				Bindings.EOS_Lobby_Attribute_Release(outAttributeAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// <see cref="CopyInfo" /> is used to immediately retrieve a copy of lobby information from a given source such as a existing lobby or a search result.
		/// If the call returns an <see cref="Result.Success" /> result, the out parameter, OutLobbyDetailsInfo, must be passed to <see cref="Release" /> to release the memory associated with it.
		/// <seealso cref="LobbyDetailsInfo" />
		/// <seealso cref="LobbyDetailsCopyInfoOptions" />
		/// <seealso cref="Release" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <param name="outLobbyDetailsInfo">Out parameter used to receive the <see cref="LobbyDetailsInfo" /> structure.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutLobbyDetailsInfo
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result CopyInfo(ref LobbyDetailsCopyInfoOptions options, out LobbyDetailsInfo? outLobbyDetailsInfo)
		{
			LobbyDetailsCopyInfoOptionsInternal optionsInternal = new LobbyDetailsCopyInfoOptionsInternal();
			optionsInternal.Set(ref options);

			var outLobbyDetailsInfoAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_LobbyDetails_CopyInfo(InnerHandle, ref optionsInternal, ref outLobbyDetailsInfoAddress);

			Helper.Dispose(ref optionsInternal);

			Helper.Get<LobbyDetailsInfoInternal, LobbyDetailsInfo>(outLobbyDetailsInfoAddress, out outLobbyDetailsInfo);
			if (outLobbyDetailsInfo != null)
			{
				Bindings.EOS_LobbyDetails_Info_Release(outLobbyDetailsInfoAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// <see cref="CopyMemberAttributeByIndex" /> is used to immediately retrieve a copy of a lobby member attribute from an existing lobby.
		/// If the call returns an <see cref="Result.Success" /> result, the out parameter, OutAttribute, must be passed to <see cref="LobbyInterface.Release" /> to release the memory associated with it.
		/// Note: this information is only available if you are actively in the lobby. It is not available for search results.
		/// <seealso cref="Attribute" />
		/// <seealso cref="LobbyDetailsCopyMemberAttributeByIndexOptions" />
		/// <seealso cref="LobbyInterface.Release" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <param name="outAttribute">Out parameter used to receive the <see cref="Attribute" /> structure.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutAttribute
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result CopyMemberAttributeByIndex(ref LobbyDetailsCopyMemberAttributeByIndexOptions options, out Attribute? outAttribute)
		{
			LobbyDetailsCopyMemberAttributeByIndexOptionsInternal optionsInternal = new LobbyDetailsCopyMemberAttributeByIndexOptionsInternal();
			optionsInternal.Set(ref options);

			var outAttributeAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_LobbyDetails_CopyMemberAttributeByIndex(InnerHandle, ref optionsInternal, ref outAttributeAddress);

			Helper.Dispose(ref optionsInternal);

			Helper.Get<AttributeInternal, Attribute>(outAttributeAddress, out outAttribute);
			if (outAttribute != null)
			{
				Bindings.EOS_Lobby_Attribute_Release(outAttributeAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// <see cref="CopyMemberAttributeByKey" /> is used to immediately retrieve a copy of a lobby member attribute from an existing lobby.
		/// If the call returns an <see cref="Result.Success" /> result, the out parameter, OutAttribute, must be passed to <see cref="LobbyInterface.Release" /> to release the memory associated with it.
		/// Note: this information is only available if you are actively in the lobby. It is not available for search results.
		/// <seealso cref="Attribute" />
		/// <seealso cref="LobbyDetailsCopyMemberAttributeByKeyOptions" />
		/// <seealso cref="LobbyInterface.Release" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <param name="outAttribute">Out parameter used to receive the <see cref="Attribute" /> structure.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutAttribute
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result CopyMemberAttributeByKey(ref LobbyDetailsCopyMemberAttributeByKeyOptions options, out Attribute? outAttribute)
		{
			LobbyDetailsCopyMemberAttributeByKeyOptionsInternal optionsInternal = new LobbyDetailsCopyMemberAttributeByKeyOptionsInternal();
			optionsInternal.Set(ref options);

			var outAttributeAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_LobbyDetails_CopyMemberAttributeByKey(InnerHandle, ref optionsInternal, ref outAttributeAddress);

			Helper.Dispose(ref optionsInternal);

			Helper.Get<AttributeInternal, Attribute>(outAttributeAddress, out outAttribute);
			if (outAttribute != null)
			{
				Bindings.EOS_Lobby_Attribute_Release(outAttributeAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// <see cref="CopyMemberInfo" /> is used to immediately retrieve a copy of lobby member information from an existing lobby.
		/// If the call returns an <see cref="Result.Success" /> result, the out parameter, OutLobbyDetailsMemberInfo, must be passed to <see cref="Release" /> to release the memory associated with it.
		/// Note: this information is only available if you are actively in the lobby. It is not available for search results.
		/// <seealso cref="LobbyDetailsMemberInfo" />
		/// <seealso cref="LobbyDetailsCopyMemberInfoOptions" />
		/// <seealso cref="Release" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <param name="outLobbyDetailsMemberInfo">Out parameter used to receive the <see cref="LobbyDetailsInfo" /> structure.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutLobbyMemberDetailsInfo
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// <see cref="Result.NotFound" /> if searching for a target user ID returns no results
		/// </returns>
		public Result CopyMemberInfo(ref LobbyDetailsCopyMemberInfoOptions options, out LobbyDetailsMemberInfo? outLobbyDetailsMemberInfo)
		{
			LobbyDetailsCopyMemberInfoOptionsInternal optionsInternal = new LobbyDetailsCopyMemberInfoOptionsInternal();
			optionsInternal.Set(ref options);

			var outLobbyDetailsMemberInfoAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_LobbyDetails_CopyMemberInfo(InnerHandle, ref optionsInternal, ref outLobbyDetailsMemberInfoAddress);

			Helper.Dispose(ref optionsInternal);

			Helper.Get<LobbyDetailsMemberInfoInternal, LobbyDetailsMemberInfo>(outLobbyDetailsMemberInfoAddress, out outLobbyDetailsMemberInfo);
			if (outLobbyDetailsMemberInfo != null)
			{
				Bindings.EOS_LobbyDetails_MemberInfo_Release(outLobbyDetailsMemberInfoAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// Get the number of attributes associated with this lobby
		/// </summary>
		/// <param name="options">the Options associated with retrieving the attribute count</param>
		/// <returns>
		/// number of attributes on the lobby or 0 if there is an error
		/// </returns>
		public uint GetAttributeCount(ref LobbyDetailsGetAttributeCountOptions options)
		{
			LobbyDetailsGetAttributeCountOptionsInternal optionsInternal = new LobbyDetailsGetAttributeCountOptionsInternal();
			optionsInternal.Set(ref options);

			var funcResult = Bindings.EOS_LobbyDetails_GetAttributeCount(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			return funcResult;
		}

		/// <summary>
		/// Get the product user ID of the current owner for a given lobby
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <returns>
		/// the product user ID for the lobby owner or null if the input parameters are invalid
		/// </returns>
		public ProductUserId GetLobbyOwner(ref LobbyDetailsGetLobbyOwnerOptions options)
		{
			LobbyDetailsGetLobbyOwnerOptionsInternal optionsInternal = new LobbyDetailsGetLobbyOwnerOptionsInternal();
			optionsInternal.Set(ref options);

			var funcResult = Bindings.EOS_LobbyDetails_GetLobbyOwner(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			ProductUserId funcResultReturn;
			Helper.Get(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// <see cref="GetMemberAttributeCount" /> is used to immediately retrieve the attribute count for members in a lobby.
		/// Note: this information is only available if you are actively in the lobby. It is not available for search results.
		/// <seealso cref="GetMemberCount" />
		/// <seealso cref="LobbyDetailsGetMemberAttributeCountOptions" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <returns>
		/// the number of attributes associated with a given lobby member or 0 if that member is invalid
		/// </returns>
		public uint GetMemberAttributeCount(ref LobbyDetailsGetMemberAttributeCountOptions options)
		{
			LobbyDetailsGetMemberAttributeCountOptionsInternal optionsInternal = new LobbyDetailsGetMemberAttributeCountOptionsInternal();
			optionsInternal.Set(ref options);

			var funcResult = Bindings.EOS_LobbyDetails_GetMemberAttributeCount(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			return funcResult;
		}

		/// <summary>
		/// <see cref="GetMemberByIndex" /> is used to immediately retrieve individual members registered with a lobby.
		/// Note: this information is only available if you are actively in the lobby. It is not available for search results.
		/// <seealso cref="GetMemberCount" />
		/// <seealso cref="LobbyDetailsGetMemberByIndexOptions" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <returns>
		/// the product user ID for the registered member at a given index or null if that index is invalid
		/// </returns>
		public ProductUserId GetMemberByIndex(ref LobbyDetailsGetMemberByIndexOptions options)
		{
			LobbyDetailsGetMemberByIndexOptionsInternal optionsInternal = new LobbyDetailsGetMemberByIndexOptionsInternal();
			optionsInternal.Set(ref options);

			var funcResult = Bindings.EOS_LobbyDetails_GetMemberByIndex(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			ProductUserId funcResultReturn;
			Helper.Get(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Get the number of members associated with this lobby
		/// </summary>
		/// <param name="options">the Options associated with retrieving the member count</param>
		/// <returns>
		/// number of members in the existing lobby or 0 if there is an error
		/// </returns>
		public uint GetMemberCount(ref LobbyDetailsGetMemberCountOptions options)
		{
			LobbyDetailsGetMemberCountOptionsInternal optionsInternal = new LobbyDetailsGetMemberCountOptionsInternal();
			optionsInternal.Set(ref options);

			var funcResult = Bindings.EOS_LobbyDetails_GetMemberCount(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			return funcResult;
		}

		/// <summary>
		/// Release the memory associated with a single lobby. This must be called on data retrieved from <see cref="LobbySearch.CopySearchResultByIndex" />.
		/// <seealso cref="LobbySearch.CopySearchResultByIndex" />
		/// </summary>
		/// <param name="lobbyHandle">- The lobby handle to release</param>
		public void Release()
		{
			Bindings.EOS_LobbyDetails_Release(InnerHandle);
		}
	}
}