using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SteamKit2
{
	public interface ISteamSerializable
	{
		void Serialize(Stream stream);
		void Deserialize( Stream stream );
	}
	public interface ISteamSerializableHeader : ISteamSerializable
	{
		void SetEMsg( EMsg msg );
	}
	public interface ISteamSerializableMessage : ISteamSerializable
	{
		EMsg GetEMsg();
	}

	public enum EMsg
	{
		Invalid = 0,
		Multi = 1,
		RemoteSysID = 128,
		FileXferRequest = 1200,
		FileXferResponse = 1201,
		FileXferData = 1202,
		FileXferEnd = 1203,
		FileXferDataAck = 1204,
		ChannelEncryptRequest = 1303,
		ChannelEncryptResponse = 1304,
		ChannelEncryptResult = 1305,
		ClientReportOverlayDetourFailure = 5517,
		ClientMMSGetLobbyData = 6611,
		ClientMMSLobbyData = 6612,
		ClientChatAction = 597,
		CSUserContentRequest = 652,
		ClientLogOn_Deprecated = 701,
		ClientAnonLogOn_Deprecated = 702,
		ClientHeartBeat = 703,
		ClientVACResponse = 704,
		ClientLogOff = 706,
		ClientNoUDPConnectivity = 707,
		ClientInformOfCreateAccount = 708,
		ClientAckVACBan = 709,
		ClientConnectionStats = 710,
		ClientInitPurchase = 711,
		ClientPingResponse = 712,
		ClientRemoveFriend = 714,
		ClientGamesPlayedNoDataBlob = 715,
		ClientChangeStatus = 716,
		ClientVacStatusResponse = 717,
		ClientFriendMsg = 718,
		ClientGetFinalPrice = 722,
		ClientSystemIM = 726,
		ClientSystemIMAck = 727,
		ClientGetLicenses = 728,
		ClientCancelLicense = 729,
		ClientGetLegacyGameKey = 730,
		ClientContentServerLogOn_Deprecated = 731,
		ClientAckVACBan2 = 732,
		ClientCompletePurchase = 733,
		ClientCancelPurchase = 734,
		ClientAckMessageByGID = 735,
		ClientGetPurchaseReceipts = 736,
		ClientAckPurchaseReceipt = 737,
		ClientSendGuestPass = 739,
		ClientAckGuestPass = 740,
		ClientRedeemGuestPass = 741,
		ClientGamesPlayed = 742,
		ClientRegisterKey = 743,
		ClientInviteUserToClan = 744,
		ClientAcknowledgeClanInvite = 745,
		ClientPurchaseWithMachineID = 746,
		ClientAppUsageEvent = 747,
		ClientGetGiftTargetList = 748,
		ClientGetGiftTargetListResponse = 749,
		ClientLogOnResponse = 751,
		ClientVACChallenge = 753,
		ClientSetHeartbeatRate = 755,
		ClientNotLoggedOnDeprecated = 756,
		ClientLoggedOff = 757,
		GSApprove = 758,
		GSDeny = 759,
		GSKick = 760,
		ClientCreateAcctResponse = 761,
		ClientPurchaseResponse = 763,
		ClientPing = 764,
		ClientNOP = 765,
		ClientPersonaState = 766,
		ClientFriendsList = 767,
		ClientAccountInfo = 768,
		ClientVacStatusQuery = 770,
		ClientNewsUpdate = 771,
		ClientGameConnectDeny = 773,
		GSStatusReply = 774,
		ClientGetFinalPriceResponse = 775,
		ClientGameConnectTokens = 779,
		ClientLicenseList = 780,
		ClientCancelLicenseResponse = 781,
		ClientVACBanStatus = 782,
		ClientCMList = 783,
		ClientEncryptPct = 784,
		ClientGetLegacyGameKeyResponse = 785,
		CSUserContentApprove = 787,
		CSUserContentDeny = 788,
		ClientInitPurchaseResponse = 789,
		ClientAddFriend = 791,
		ClientAddFriendResponse = 792,
		ClientInviteFriend = 793,
		ClientInviteFriendResponse = 794,
		ClientSendGuestPassResponse = 795,
		ClientAckGuestPassResponse = 796,
		ClientRedeemGuestPassResponse = 797,
		ClientUpdateGuestPassesList = 798,
		ClientChatMsg = 799,
		ClientChatInvite = 800,
		ClientJoinChat = 801,
		ClientChatMemberInfo = 802,
		ClientLogOnWithCredentials_Deprecated = 803,
		ClientPasswordChangeResponse = 805,
		ClientChatEnter = 807,
		ClientFriendRemovedFromSource = 808,
		ClientCreateChat = 809,
		ClientCreateChatResponse = 810,
		ClientUpdateChatMetadata = 811,
		ClientP2PIntroducerMessage = 813,
		ClientChatActionResult = 814,
		ClientRequestFriendData = 815,
		ClientGetUserStats = 818,
		ClientGetUserStatsResponse = 819,
		ClientStoreUserStats = 820,
		ClientStoreUserStatsResponse = 821,
		ClientClanState = 822,
		ClientServiceModule = 830,
		ClientServiceCall = 831,
		ClientServiceCallResponse = 832,
		ClientNatTraversalStatEvent = 839,
		ClientAppInfoRequest = 840,
		ClientAppInfoResponse = 841,
		ClientSteamUsageEvent = 842,
		ClientCheckPassword = 845,
		ClientResetPassword = 846,
		ClientCheckPasswordResponse = 848,
		ClientResetPasswordResponse = 849,
		ClientSessionToken = 850,
		ClientDRMProblemReport = 851,
		ClientSetIgnoreFriend = 855,
		ClientSetIgnoreFriendResponse = 856,
		ClientGetAppOwnershipTicket = 857,
		ClientGetAppOwnershipTicketResponse = 858,
		ClientGetLobbyListResponse = 860,
		ClientGetLobbyMetadata = 861,
		ClientGetLobbyMetadataResponse = 862,
		ClientVTTCert = 863,
		ClientAppInfoUpdate = 866,
		ClientAppInfoChanges = 867,
		ClientServerList = 880,
		ClientGetFriendsLobbies = 888,
		ClientGetFriendsLobbiesResponse = 889,
		ClientGetLobbyList = 890,
		ClientEmailChangeResponse = 891,
		ClientSecretQAChangeResponse = 892,
		ClientDRMBlobRequest = 896,
		ClientDRMBlobResponse = 897,
		ClientLookupKey = 898,
		ClientLookupKeyResponse = 899,
		GSDisconnectNotice = 901,
		GSStatus = 903,
		GSUserPlaying = 905,
		GSStatus2 = 906,
		GSStatusUpdate_Unused = 907,
		GSServerType = 908,
		GSPlayerList = 909,
		GSGetUserAchievementStatus = 910,
		GSGetUserAchievementStatusResponse = 911,
		GSGetPlayStats = 918,
		GSGetPlayStatsResponse = 919,
		GSGetUserGroupStatus = 920,
		GSGetUserGroupStatusResponse = 923,
		GSGetReputation = 936,
		GSGetReputationResponse = 937,
		ClientChatRoomInfo = 4026,
		ClientUFSUploadFileRequest = 5202,
		ClientUFSUploadFileResponse = 5203,
		ClientUFSUploadFileChunk = 5204,
		ClientUFSUploadFileFinished = 5205,
		ClientUFSGetFileListForApp = 5206,
		ClientUFSGetFileListForAppResponse = 5207,
		ClientUFSDownloadRequest = 5210,
		ClientUFSDownloadResponse = 5211,
		ClientUFSDownloadChunk = 5212,
		ClientUFSLoginRequest = 5213,
		ClientUFSLoginResponse = 5214,
		ClientUFSTransferHeartbeat = 5216,
		ClientUFSDeleteFileRequest = 5219,
		ClientUFSDeleteFileResponse = 5220,
		ClientUFSGetUGCDetails = 5226,
		ClientUFSGetUGCDetailsResponse = 5227,
		ClientUFSGetSingleFileInfo = 5230,
		ClientUFSGetSingleFileInfoResponse = 5231,
		ClientUFSShareFile = 5232,
		ClientUFSShareFileResponse = 5233,
		ClientRequestForgottenPasswordEmail = 5401,
		ClientRequestForgottenPasswordEmailResponse = 5402,
		ClientCreateAccountResponse = 5403,
		ClientResetForgottenPassword = 5404,
		ClientResetForgottenPasswordResponse = 5405,
		ClientCreateAccount2 = 5406,
		ClientInformOfResetForgottenPassword = 5407,
		ClientInformOfResetForgottenPasswordResponse = 5408,
		ClientAnonUserLogOn_Deprecated = 5409,
		ClientGamesPlayedWithDataBlob = 5410,
		ClientUpdateUserGameInfo = 5411,
		ClientFileToDownload = 5412,
		ClientFileToDownloadResponse = 5413,
		ClientLBSSetScore = 5414,
		ClientLBSSetScoreResponse = 5415,
		ClientLBSFindOrCreateLB = 5416,
		ClientLBSFindOrCreateLBResponse = 5417,
		ClientLBSGetLBEntries = 5418,
		ClientLBSGetLBEntriesResponse = 5419,
		ClientMarketingMessageUpdate = 5420,
		ClientChatDeclined = 5426,
		ClientFriendMsgIncoming = 5427,
		ClientAuthList_Deprecated = 5428,
		ClientTicketAuthComplete = 5429,
		ClientIsLimitedAccount = 5430,
		ClientAuthList = 5432,
		ClientStat = 5433,
		ClientP2PConnectionInfo = 5434,
		ClientP2PConnectionFailInfo = 5435,
		ClientGetNumberOfCurrentPlayers = 5436,
		ClientGetNumberOfCurrentPlayersResponse = 5437,
		ClientGetDepotDecryptionKey = 5438,
		ClientGetDepotDecryptionKeyResponse = 5439,
		GSPerformHardwareSurvey = 5440,
		ClientEnableTestLicense = 5443,
		ClientEnableTestLicenseResponse = 5444,
		ClientDisableTestLicense = 5445,
		ClientDisableTestLicenseResponse = 5446,
		ClientRequestValidationMail = 5448,
		ClientRequestValidationMailResponse = 5449,
		ClientToGC = 5452,
		ClientFromGC = 5453,
		ClientRequestChangeMail = 5454,
		ClientRequestChangeMailResponse = 5455,
		ClientEmailAddrInfo = 5456,
		ClientPasswordChange3 = 5457,
		ClientEmailChange3 = 5458,
		ClientPersonalQAChange3 = 5459,
		ClientResetForgottenPassword3 = 5460,
		ClientRequestForgottenPasswordEmail3 = 5461,
		ClientCreateAccount3 = 5462,
		ClientNewLoginKey = 5463,
		ClientNewLoginKeyAccepted = 5464,
		ClientLogOnWithHash_Deprecated = 5465,
		ClientStoreUserStats2 = 5466,
		ClientStatsUpdated = 5467,
		ClientActivateOEMLicense = 5468,
		ClientRequestedClientStats = 5480,
		ClientStat2Int32 = 5481,
		ClientStat2 = 5482,
		ClientVerifyPassword = 5483,
		ClientVerifyPasswordResponse = 5484,
		ClientDRMDownloadRequest = 5485,
		ClientDRMDownloadResponse = 5486,
		ClientDRMFinalResult = 5487,
		ClientGetFriendsWhoPlayGame = 5488,
		ClientGetFriendsWhoPlayGameResponse = 5489,
		ClientOGSBeginSession = 5490,
		ClientOGSBeginSessionResponse = 5491,
		ClientOGSEndSession = 5492,
		ClientOGSEndSessionResponse = 5493,
		ClientOGSWriteRow = 5494,
		ClientDRMTest = 5495,
		ClientDRMTestResult = 5496,
		ClientServerUnavailable = 5500,
		ClientServersAvailable = 5501,
		ClientRegisterAuthTicketWithCM = 5502,
		ClientGCMsgFailed = 5503,
		ClientMicroTxnAuthRequest = 5504,
		ClientMicroTxnAuthorize = 5505,
		ClientMicroTxnAuthorizeResponse = 5506,
		ClientAppMinutesPlayedData = 5507,
		ClientGetMicroTxnInfo = 5508,
		ClientGetMicroTxnInfoResponse = 5509,
		ClientMarketingMessageUpdate2 = 5510,
		ClientDeregisterWithServer = 5511,
		ClientSubscribeToPersonaFeed = 5512,
		ClientLogon = 5514,
		ClientGetClientDetails = 5515,
		ClientGetClientDetailsResponse = 5516,
		ClientGetClientAppList = 5518,
		ClientGetClientAppListResponse = 5519,
		ClientInstallClientApp = 5520,
		ClientInstallClientAppResponse = 5521,
		ClientUninstallClientApp = 5522,
		ClientUninstallClientAppResponse = 5523,
		ClientSetClientAppUpdateState = 5524,
		ClientSetClientAppUpdateStateResponse = 5525,
		ClientRequestEncryptedAppTicket = 5526,
		ClientRequestEncryptedAppTicketResponse = 5527,
		ClientWalletInfoUpdate = 5528,
		ClientLBSSetUGC = 5529,
		ClientLBSSetUGCResponse = 5530,
		ClientAMGetClanOfficers = 5531,
		ClientAMGetClanOfficersResponse = 5532,
		ClientCheckFileSignature = 5533,
		ClientCheckFileSignatureResponse = 5534,
		ClientFriendProfileInfo = 5535,
		ClientFriendProfileInfoResponse = 5536,
		ClientUpdateMachineAuth = 5537,
		ClientUpdateMachineAuthResponse = 5538,
		ClientReadMachineAuth = 5539,
		ClientReadMachineAuthResponse = 5540,
		ClientRequestMachineAuth = 5541,
		ClientRequestMachineAuthResponse = 5542,
		ClientScreenshotsChanged = 5543,
		ClientEmailChange4 = 5544,
		ClientEmailChangeResponse4 = 5545,
		ClientDFSAuthenticateRequest = 5605,
		ClientDFSAuthenticateResponse = 5606,
		ClientDFSEndSession = 5607,
		ClientDFSDownloadStatus = 5617,
		ClientMDSLoginRequest = 5801,
		ClientMDSLoginResponse = 5802,
		ClientMDSUploadManifestRequest = 5803,
		ClientMDSUploadManifestResponse = 5804,
		ClientMDSTransmitManifestDataChunk = 5805,
		ClientMDSHeartbeat = 5806,
		ClientMDSUploadDepotChunks = 5807,
		ClientMDSUploadDepotChunksResponse = 5808,
		ClientMDSInitDepotBuildRequest = 5809,
		ClientMDSInitDepotBuildResponse = 5810,
		ClientMDSGetDepotManifest = 5818,
		ClientMDSGetDepotManifestResponse = 5819,
		ClientMDSGetDepotManifestChunk = 5820,
		ClientMDSDownloadDepotChunksRequest = 5823,
		ClientMDSDownloadDepotChunksAsync = 5824,
		ClientMDSDownloadDepotChunksAck = 5825,
		ClientMMSCreateLobby = 6601,
		ClientMMSCreateLobbyResponse = 6602,
		ClientMMSJoinLobby = 6603,
		ClientMMSJoinLobbyResponse = 6604,
		ClientMMSLeaveLobby = 6605,
		ClientMMSLeaveLobbyResponse = 6606,
		ClientMMSGetLobbyList = 6607,
		ClientMMSGetLobbyListResponse = 6608,
		ClientMMSSetLobbyData = 6609,
		ClientMMSSetLobbyDataResponse = 6610,
		ClientMMSSendLobbyChatMsg = 6613,
		ClientMMSLobbyChatMsg = 6614,
		ClientMMSSetLobbyOwner = 6615,
		ClientMMSSetLobbyOwnerResponse = 6616,
		ClientMMSSetLobbyGameServer = 6617,
		ClientMMSLobbyGameServerSet = 6618,
		ClientMMSUserJoinedLobby = 6619,
		ClientMMSUserLeftLobby = 6620,
		ClientMMSInviteToLobby = 6621,
		ClientUDSP2PSessionStarted = 7001,
		ClientUDSP2PSessionEnded = 7002,
		ClientUDSInviteToGame = 7005,
		ClientUCMAddScreenshot = 7301,
		ClientUCMAddScreenshotResponse = 7302,
		ClientUCMGetScreenshotList = 7305,
		ClientUCMGetScreenshotListResponse = 7306,
		ClientUCMDeleteScreenshot = 7309,
		ClientUCMDeleteScreenshotResponse = 7310,
		ClientRichPresenceUpload = 7501,
		ClientRichPresenceRequest = 7502,
		ClientRichPresenceInfo = 7503,
		Max = 7504,
	}
	public enum EResult
	{
		Invalid = 0,
		OK = 1,
		Fail = 2,
		NoConnection = 3,
		InvalidPassword = 5,
		LoggedInElsewhere = 6,
		InvalidProtocolVer = 7,
		InvalidParam = 8,
		FileNotFound = 9,
		Busy = 10,
		InvalidState = 11,
		InvalidName = 12,
		InvalidEmail = 13,
		DuplicateName = 14,
		AccessDenied = 15,
		Timeout = 16,
		Banned = 17,
		AccountNotFound = 18,
		InvalidSteamID = 19,
		ServiceUnavailable = 20,
		NotLoggedOn = 21,
		Pending = 22,
		EncryptionFailure = 23,
		InsufficientPrivilege = 24,
		LimitExceeded = 25,
		Revoked = 26,
		Expired = 27,
		AlreadyRedeemed = 28,
		DuplicateRequest = 29,
		AlreadyOwned = 30,
		IPNotFound = 31,
		PersistFailed = 32,
		LockingFailed = 33,
		LogonSessionReplaced = 34,
		ConnectFailed = 35,
		HandshakeFailed = 36,
		IOFailure = 37,
		RemoteDisconnect = 38,
		ShoppingCartNotFound = 39,
		Blocked = 40,
		Ignored = 41,
		NoMatch = 42,
		AccountDisabled = 43,
		ServiceReadOnly = 44,
		AccountNotFeatured = 45,
		AdministratorOK = 46,
		ContentVersion = 47,
		TryAnotherCM = 48,
		PasswordRequiredToKickSession = 49,
		AlreadyLoggedInElsewhere = 50,
		Suspended = 51,
		Cancelled = 52,
		DataCorruption = 53,
		DiskFull = 54,
		RemoteCallFailed = 55,
		Max = 56,
	}
	public enum EUniverse
	{
		Invalid = 0,
		Public = 1,
		Beta = 2,
		Internal = 3,
		Dev = 4,
		RC = 5,
		Max = 6,
	}
	public enum EChatEntryType
	{
		Invalid = 0,
		ChatMsg = 1,
		Typing = 2,
		InviteGame = 3,
		Emote = 4,
		LobbyGameStart = 5,
		LeftConversation = 6,
		Max = 7,
	}
	public enum EPersonaState
	{
		Offline = 0,
		Online = 1,
		Busy = 2,
		Away = 3,
		Snooze = 4,
		Max = 5,
	}
	public enum EAccountType
	{
		Invalid = 0,
		Individual = 1,
		Multiseat = 2,
		GameServer = 3,
		AnonGameServer = 4,
		Pending = 5,
		ContentServer = 6,
		Clan = 7,
		Chat = 8,
		P2PSuperSeeder = 9,
		AnonUser = 10,
		Max = 11,
	}
	public enum EFriendRelationship
	{
		None = 0,
		Blocked = 1,
		RequestRecipient = 2,
		Friend = 3,
		RequestInitiator = 4,
		Ignored = 5,
		IgnoredFriend = 6,
		Max = 7,
	}
	[Flags]
	public enum EAccountFlags
	{
		NormalUser = 0,
		PersonaNameSet = 1,
		Unbannable = 2,
		PasswordSet = 4,
		Support = 8,
		Admin = 16,
		Supervisor = 32,
		AppEditor = 64,
		HWIDSet = 128,
		PersonalQASet = 256,
		VacBeta = 512,
		Debug = 1024,
		Disabled = 2048,
		LimitedUser = 4096,
		LimitedUserForce = 8192,
		EmailValidated = 16384,
		MarketingTreatment = 32768,
		Max = 32769,
	}
	[Flags]
	public enum EFriendFlags
	{
		None = 0,
		Blocked = 1,
		FriendshipRequested = 2,
		Immediate = 4,
		ClanMember = 8,
		GameServer = 16,
		RequestingFriendship = 128,
		RequestingInfo = 256,
		Ignored = 512,
		IgnoredFriend = 1024,
		FlagAll = 65535,
		Max = 65536,
	}
	[Flags]
	public enum EClientPersonaStateFlag
	{
		Status = 1,
		PlayerName = 2,
		QueryPort = 4,
		SourceID = 8,
		Presence = 16,
		Metadata = 32,
		LastSeen = 64,
		ClanInfo = 128,
		GameExtraInfo = 256,
		GameDataBlob = 512,
		Max = 513,
	}
	public enum EAppUsageEvent
	{
		GameLaunch = 1,
		GameLaunchTrial = 2,
		Media = 3,
		PreloadStart = 4,
		PreloadFinish = 5,
		MarketingMessageView = 6,
		InGameAdViewed = 7,
		GameLaunchFreeWeekend = 8,
		Max = 9,
	}
	[Flags]
	public enum ELicenseFlags
	{
		Renew = 0x01,
		RenewalFailed = 0x02,
		Pending = 0x04,
		Expired = 0x08,
		CancelledByUser = 0x10,
		CancelledByAdmin = 0x20,
		Max = 33,
	}
	public enum ELicenseType
	{
		NoLicense = 0,
		SinglePurchase = 1,
		SinglePurchaseLimitedUse = 2,
		RecurringCharge = 3,
		RecurringChargeLimitedUse = 4,
		RecurringChargeLimitedUseWithOverages = 5,
		Max = 6,
	}
	public enum EPaymentMethod
	{
		None = 0,
		ActivationCode = 1,
		CreditCard = 2,
		PayPal = 4,
		GuestPass = 8,
		HardwarePromo = 16,
		ClickAndBuy = 32,
		AutoGrant = 64,
		Wallet = 128,
		OEMTicket = 256,
		Split = 512,
		Max = 513,
	}
	public enum EIntroducerRouting
	{
		FileShare = 0,
		P2PVoiceChat = 1,
		P2PNetworking = 2,
		Max = 3,
	}
	public enum EUdpPacketType
	{
		Invalid = 0,
		ChallengeReq = 1,
		Challenge = 2,
		Connect = 3,
		Accept = 4,
		Disconnect = 5,
		Data = 6,
		Datagram = 7,
		Max = 8,
	}
	public class UdpHeader : ISteamSerializable
	{
		public static readonly uint MAGIC = 0x31305356;
		// Static size: 4
		public uint Magic { get; set; }
		// Static size: 2
		public ushort PayloadSize { get; set; }
		// Static size: 1
		public EUdpPacketType PacketType { get; set; }
		// Static size: 1
		public byte Flags { get; set; }
		// Static size: 4
		public uint SourceConnID { get; set; }
		// Static size: 4
		public uint DestConnID { get; set; }
		// Static size: 4
		public uint SeqThis { get; set; }
		// Static size: 4
		public uint SeqAck { get; set; }
		// Static size: 4
		public uint PacketsInMsg { get; set; }
		// Static size: 4
		public uint MsgStartSeq { get; set; }
		// Static size: 4
		public uint MsgSize { get; set; }

		public UdpHeader()
		{
			Magic = UdpHeader.MAGIC;
			PayloadSize = 0;
			PacketType = EUdpPacketType.Invalid;
			Flags = 0;
			SourceConnID = 512;
			DestConnID = 0;
			SeqThis = 0;
			SeqAck = 0;
			PacketsInMsg = 0;
			MsgStartSeq = 0;
			MsgSize = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( Magic );
			bw.Write( PayloadSize );
			bw.Write( (byte)PacketType );
			bw.Write( Flags );
			bw.Write( SourceConnID );
			bw.Write( DestConnID );
			bw.Write( SeqThis );
			bw.Write( SeqAck );
			bw.Write( PacketsInMsg );
			bw.Write( MsgStartSeq );
			bw.Write( MsgSize );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			Magic = br.ReadUInt32();
			PayloadSize = br.ReadUInt16();
			PacketType = (EUdpPacketType)br.ReadByte();
			Flags = br.ReadByte();
			SourceConnID = br.ReadUInt32();
			DestConnID = br.ReadUInt32();
			SeqThis = br.ReadUInt32();
			SeqAck = br.ReadUInt32();
			PacketsInMsg = br.ReadUInt32();
			MsgStartSeq = br.ReadUInt32();
			MsgSize = br.ReadUInt32();
		}
	}

	public class ChallengeData : ISteamSerializable
	{
		public static readonly uint CHALLENGE_MASK = 0xA426DF2B;
		// Static size: 4
		public uint ChallengeValue { get; set; }
		// Static size: 4
		public uint ServerLoad { get; set; }

		public ChallengeData()
		{
			ChallengeValue = 0;
			ServerLoad = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( ChallengeValue );
			bw.Write( ServerLoad );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			ChallengeValue = br.ReadUInt32();
			ServerLoad = br.ReadUInt32();
		}
	}

	public class ConnectData : ISteamSerializable
	{
		public static readonly uint CHALLENGE_MASK = ChallengeData.CHALLENGE_MASK;
		// Static size: 4
		public uint ChallengeValue { get; set; }

		public ConnectData()
		{
			ChallengeValue = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( ChallengeValue );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			ChallengeValue = br.ReadUInt32();
		}
	}

	public class Accept : ISteamSerializable
	{

		public Accept()
		{
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );


		}

		public void Deserialize( Stream stream )
		{
		}
	}

	public class Datagram : ISteamSerializable
	{

		public Datagram()
		{
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );


		}

		public void Deserialize( Stream stream )
		{
		}
	}

	public class Disconnect : ISteamSerializable
	{

		public Disconnect()
		{
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );


		}

		public void Deserialize( Stream stream )
		{
		}
	}

	[StructLayout( LayoutKind.Sequential )]
	public class MsgHdr : ISteamSerializableHeader
	{
		public void SetEMsg( EMsg msg ) { this.Msg = msg; }

		// Static size: 4
		public EMsg Msg { get; set; }
		// Static size: 8
		public long TargetJobID { get; set; }
		// Static size: 8
		public long SourceJobID { get; set; }

		public MsgHdr()
		{
			Msg = EMsg.Invalid;
			TargetJobID = -1;
			SourceJobID = -1;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( (int)Msg );
			bw.Write( TargetJobID );
			bw.Write( SourceJobID );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			Msg = (EMsg)br.ReadInt32();
			TargetJobID = br.ReadInt64();
			SourceJobID = br.ReadInt64();
		}
	}

	[StructLayout( LayoutKind.Sequential )]
	public class ExtendedClientMsgHdr : ISteamSerializableHeader
	{
		public void SetEMsg( EMsg msg ) { this.Msg = msg; }

		// Static size: 4
		public EMsg Msg { get; set; }
		// Static size: 1
		public byte HeaderSize { get; set; }
		// Static size: 2
		public ushort HeaderVersion { get; set; }
		// Static size: 8
		public long TargetJobID { get; set; }
		// Static size: 8
		public long SourceJobID { get; set; }
		// Static size: 1
		public byte HeaderCanary { get; set; }
		// Static size: 8
		private ulong steamID;
		public SteamID SteamID { get { return new SteamID( steamID ); } set { steamID = value.ConvertToUint64(); } }
		// Static size: 4
		public int SessionID { get; set; }

		public ExtendedClientMsgHdr()
		{
			Msg = EMsg.Invalid;
			HeaderSize = 36;
			HeaderVersion = 2;
			TargetJobID = -1;
			SourceJobID = -1;
			HeaderCanary = 239;
			steamID = 0;
			SessionID = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( (int)Msg );
			bw.Write( HeaderSize );
			bw.Write( HeaderVersion );
			bw.Write( TargetJobID );
			bw.Write( SourceJobID );
			bw.Write( HeaderCanary );
			bw.Write( steamID );
			bw.Write( SessionID );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			Msg = (EMsg)br.ReadInt32();
			HeaderSize = br.ReadByte();
			HeaderVersion = br.ReadUInt16();
			TargetJobID = br.ReadInt64();
			SourceJobID = br.ReadInt64();
			HeaderCanary = br.ReadByte();
			steamID = br.ReadUInt64();
			SessionID = br.ReadInt32();
		}
	}

	[StructLayout( LayoutKind.Sequential )]
	public class MsgHdrProtoBuf : ISteamSerializableHeader
	{
		public void SetEMsg( EMsg msg ) { this.Msg = msg; }

		// Static size: 4
		public EMsg Msg { get; set; }
		// Static size: 4
		public int HeaderLength { get; set; }
		// Static size: 0
		public CMsgProtoBufHeader ProtoHeader { get; set; }

		public MsgHdrProtoBuf()
		{
			Msg = EMsg.Invalid;
			HeaderLength = 0;
			ProtoHeader = new CMsgProtoBufHeader();
		}

		public void Serialize(Stream stream)
		{
			MemoryStream msProtoHeader = new MemoryStream();
			ProtoBuf.Serializer.Serialize<CMsgProtoBufHeader>(msProtoHeader, ProtoHeader);
			HeaderLength = (int)msProtoHeader.Length;
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( (int)MsgUtil.MakeMsg( Msg, true ) );
			bw.Write( HeaderLength );
			bw.Write( msProtoHeader.ToArray() );

			msProtoHeader.Close();
		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			Msg = (EMsg)MsgUtil.GetMsg( (uint)br.ReadInt32() );
			HeaderLength = br.ReadInt32();
			using( MemoryStream msProtoHeader = new MemoryStream( br.ReadBytes( HeaderLength ) ) )
				ProtoHeader = ProtoBuf.Serializer.Deserialize<CMsgProtoBufHeader>( msProtoHeader );
		}
	}

	public class MsgChannelEncryptRequest : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ChannelEncryptRequest; }

		public static readonly uint PROTOCOL_VERSION = 1;
		// Static size: 4
		public uint ProtocolVersion { get; set; }
		// Static size: 4
		public EUniverse Universe { get; set; }

		public MsgChannelEncryptRequest()
		{
			ProtocolVersion = MsgChannelEncryptRequest.PROTOCOL_VERSION;
			Universe = EUniverse.Invalid;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( ProtocolVersion );
			bw.Write( (int)Universe );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			ProtocolVersion = br.ReadUInt32();
			Universe = (EUniverse)br.ReadInt32();
		}
	}

	public class MsgChannelEncryptResponse : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ChannelEncryptResponse; }

		// Static size: 4
		public uint ProtocolVersion { get; set; }
		// Static size: 4
		public uint KeySize { get; set; }

		public MsgChannelEncryptResponse()
		{
			ProtocolVersion = MsgChannelEncryptRequest.PROTOCOL_VERSION;
			KeySize = 128;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( ProtocolVersion );
			bw.Write( KeySize );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			ProtocolVersion = br.ReadUInt32();
			KeySize = br.ReadUInt32();
		}
	}

	public class MsgChannelEncryptResult : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ChannelEncryptResult; }

		// Static size: 4
		public EResult Result { get; set; }

		public MsgChannelEncryptResult()
		{
			Result = EResult.Invalid;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( (int)Result );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			Result = (EResult)br.ReadInt32();
		}
	}

	public class MsgMulti : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.Multi; }

		// Static size: 0
		public CMsgMulti Proto { get; set; }

		public MsgMulti()
		{
			Proto = new CMsgMulti();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgMulti>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgMulti>( stream );
		}
	}

	public class MsgClientNewLoginKey : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientNewLoginKey; }

		// Static size: 4
		public uint UniqueID { get; set; }
		// Static size: 20
		public byte[] LoginKey { get; set; }

		public MsgClientNewLoginKey()
		{
			UniqueID = 0;
			LoginKey = new byte[20];
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( UniqueID );
			bw.Write( LoginKey );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			UniqueID = br.ReadUInt32();
			LoginKey = br.ReadBytes( 20 );
		}
	}

	public class MsgClientNewLoginKeyAccepted : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientNewLoginKeyAccepted; }

		// Static size: 4
		public uint UniqueID { get; set; }

		public MsgClientNewLoginKeyAccepted()
		{
			UniqueID = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( UniqueID );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			UniqueID = br.ReadUInt32();
		}
	}

	public class MsgClientHeartBeat : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientHeartBeat; }

		// Static size: 0
		public CMsgClientHeartBeat Proto { get; set; }

		public MsgClientHeartBeat()
		{
			Proto = new CMsgClientHeartBeat();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientHeartBeat>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientHeartBeat>( stream );
		}
	}

	public class MsgClientLogon : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientLogon; }

		public static readonly uint ObfuscationMask = 0xBAADF00D;
		public static readonly uint CurrentProtocol = 65569;
		// Static size: 0
		public CMsgClientLogon Proto { get; set; }

		public MsgClientLogon()
		{
			Proto = new CMsgClientLogon();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientLogon>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientLogon>( stream );
		}
	}

	public class MsgClientLogOff : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientLogOff; }

		// Static size: 0
		public CMsgClientLogOff Proto { get; set; }

		public MsgClientLogOff()
		{
			Proto = new CMsgClientLogOff();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientLogOff>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientLogOff>( stream );
		}
	}

	public class MsgClientLogOnResponse : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientLogOnResponse; }

		// Static size: 0
		public CMsgClientLogonResponse Proto { get; set; }

		public MsgClientLogOnResponse()
		{
			Proto = new CMsgClientLogonResponse();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientLogonResponse>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientLogonResponse>( stream );
		}
	}

	public class MsgGSServerType : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.GSServerType; }

		// Static size: 0
		public CMsgGSServerType Proto { get; set; }

		public MsgGSServerType()
		{
			Proto = new CMsgGSServerType();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgGSServerType>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgGSServerType>( stream );
		}
	}

	public class MsgGSStatusReply : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.GSStatusReply; }

		// Static size: 0
		public CMsgGSStatusReply Proto { get; set; }

		public MsgGSStatusReply()
		{
			Proto = new CMsgGSStatusReply();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgGSStatusReply>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgGSStatusReply>( stream );
		}
	}

	public class MsgClientRegisterAuthTicketWithCM : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientRegisterAuthTicketWithCM; }

		// Static size: 0
		public CMsgClientRegisterAuthTicketWithCM Proto { get; set; }

		public MsgClientRegisterAuthTicketWithCM()
		{
			Proto = new CMsgClientRegisterAuthTicketWithCM();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientRegisterAuthTicketWithCM>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientRegisterAuthTicketWithCM>( stream );
		}
	}

	public class MsgClientGetAppOwnershipTicket : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientGetAppOwnershipTicket; }

		// Static size: 0
		public CMsgClientGetAppOwnershipTicket Proto { get; set; }

		public MsgClientGetAppOwnershipTicket()
		{
			Proto = new CMsgClientGetAppOwnershipTicket();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientGetAppOwnershipTicket>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientGetAppOwnershipTicket>( stream );
		}
	}

	public class MsgClientGetAppOwnershipTicketResponse : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientGetAppOwnershipTicketResponse; }

		// Static size: 0
		public CMsgClientGetAppOwnershipTicketResponse Proto { get; set; }

		public MsgClientGetAppOwnershipTicketResponse()
		{
			Proto = new CMsgClientGetAppOwnershipTicketResponse();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientGetAppOwnershipTicketResponse>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientGetAppOwnershipTicketResponse>( stream );
		}
	}

	public class MsgClientAuthList : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientAuthList; }

		// Static size: 0
		public CMsgClientAuthList Proto { get; set; }

		public MsgClientAuthList()
		{
			Proto = new CMsgClientAuthList();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientAuthList>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientAuthList>( stream );
		}
	}

	public class MsgClientRequestFriendData : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientRequestFriendData; }

		// Static size: 0
		public CMsgClientRequestFriendData Proto { get; set; }

		public MsgClientRequestFriendData()
		{
			Proto = new CMsgClientRequestFriendData();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientRequestFriendData>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientRequestFriendData>( stream );
		}
	}

	public class MsgClientChangeStatus : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientChangeStatus; }

		// Static size: 1
		public byte PersonaState { get; set; }

		public MsgClientChangeStatus()
		{
			PersonaState = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( PersonaState );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			PersonaState = br.ReadByte();
		}
	}

	public class MsgClientPersonaState : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientPersonaState; }

		// Static size: 0
		public CMsgClientPersonaState Proto { get; set; }

		public MsgClientPersonaState()
		{
			Proto = new CMsgClientPersonaState();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientPersonaState>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientPersonaState>( stream );
		}
	}

	public class MsgClientSessionToken : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientSessionToken; }

		// Static size: 0
		public CMsgClientSessionToken Proto { get; set; }

		public MsgClientSessionToken()
		{
			Proto = new CMsgClientSessionToken();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientSessionToken>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientSessionToken>( stream );
		}
	}

	public class MsgClientGameConnectTokens : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientGameConnectTokens; }

		// Static size: 0
		public CMsgClientGameConnectTokens Proto { get; set; }

		public MsgClientGameConnectTokens()
		{
			Proto = new CMsgClientGameConnectTokens();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientGameConnectTokens>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientGameConnectTokens>( stream );
		}
	}

	public class MsgClientGamesPlayedWithDataBlob : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientGamesPlayedWithDataBlob; }

		// Static size: 0
		public CMsgClientGamesPlayed Proto { get; set; }

		public MsgClientGamesPlayedWithDataBlob()
		{
			Proto = new CMsgClientGamesPlayed();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientGamesPlayed>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientGamesPlayed>( stream );
		}
	}

	public class MsgClientFriendsList : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientFriendsList; }

		// Static size: 0
		public CMsgClientFriendsList Proto { get; set; }

		public MsgClientFriendsList()
		{
			Proto = new CMsgClientFriendsList();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientFriendsList>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientFriendsList>( stream );
		}
	}

	public class MsgClientFriendMsg : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientFriendMsg; }

		// Static size: 0
		public CMsgClientFriendMsg Proto { get; set; }

		public MsgClientFriendMsg()
		{
			Proto = new CMsgClientFriendMsg();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientFriendMsg>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientFriendMsg>( stream );
		}
	}

	public class MsgClientFriendMsgIncoming : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientFriendMsgIncoming; }

		// Static size: 0
		public CMsgClientFriendMsgIncoming Proto { get; set; }

		public MsgClientFriendMsgIncoming()
		{
			Proto = new CMsgClientFriendMsgIncoming();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientFriendMsgIncoming>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientFriendMsgIncoming>( stream );
		}
	}

	public class MsgClientVACBanStatus : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientVACBanStatus; }

		// Static size: 4
		public uint NumBans { get; set; }

		public MsgClientVACBanStatus()
		{
			NumBans = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( NumBans );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			NumBans = br.ReadUInt32();
		}
	}

	public class MsgClientAppUsageEvent : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientAppUsageEvent; }

		// Static size: 4
		public EAppUsageEvent AppUsageEvent { get; set; }
		// Static size: 8
		public ulong GameID { get; set; }
		// Static size: 2
		public ushort Offline { get; set; }

		public MsgClientAppUsageEvent()
		{
			AppUsageEvent = 0;
			GameID = 0;
			Offline = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( (int)AppUsageEvent );
			bw.Write( GameID );
			bw.Write( Offline );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			AppUsageEvent = (EAppUsageEvent)br.ReadInt32();
			GameID = br.ReadUInt64();
			Offline = br.ReadUInt16();
		}
	}

	public class MsgClientAccountInfo : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientAccountInfo; }

		// Static size: 0
		public CMsgClientAccountInfo Proto { get; set; }

		public MsgClientAccountInfo()
		{
			Proto = new CMsgClientAccountInfo();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientAccountInfo>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientAccountInfo>( stream );
		}
	}

	public class MsgClientLicenseList : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientLicenseList; }

		// Static size: 0
		public CMsgClientLicenseList Proto { get; set; }

		public MsgClientLicenseList()
		{
			Proto = new CMsgClientLicenseList();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientLicenseList>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientLicenseList>( stream );
		}
	}

	public class MsgClientAppMinutesPlayedData : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientAppMinutesPlayedData; }

		// Static size: 0
		public CMsgClientAppMinutesPlayedData Proto { get; set; }

		public MsgClientAppMinutesPlayedData()
		{
			Proto = new CMsgClientAppMinutesPlayedData();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientAppMinutesPlayedData>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientAppMinutesPlayedData>( stream );
		}
	}

	public class MsgClientWalletInfoUpdate : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientWalletInfoUpdate; }

		// Static size: 0
		public CMsgClientWalletInfoUpdate Proto { get; set; }

		public MsgClientWalletInfoUpdate()
		{
			Proto = new CMsgClientWalletInfoUpdate();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientWalletInfoUpdate>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientWalletInfoUpdate>( stream );
		}
	}

	public class MsgClientCMList : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientCMList; }

		// Static size: 0
		public CMsgClientCMList Proto { get; set; }

		public MsgClientCMList()
		{
			Proto = new CMsgClientCMList();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientCMList>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientCMList>( stream );
		}
	}

	public class MsgClientEmailAddrInfo : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientEmailAddrInfo; }

		// Static size: 4
		public uint PasswordStrength { get; set; }
		// Static size: 4
		public uint FlagsAccountSecurityPolicy { get; set; }
		// Static size: 1
		public byte Validated { get; set; }

		public MsgClientEmailAddrInfo()
		{
			PasswordStrength = 0;
			FlagsAccountSecurityPolicy = 0;
			Validated = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( PasswordStrength );
			bw.Write( FlagsAccountSecurityPolicy );
			bw.Write( Validated );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			PasswordStrength = br.ReadUInt32();
			FlagsAccountSecurityPolicy = br.ReadUInt32();
			Validated = br.ReadByte();
		}
	}

	public class MsgClientUpdateGuestPassesList : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientUpdateGuestPassesList; }

		// Static size: 4
		public EResult Result { get; set; }
		// Static size: 4
		public int CountGuestPassesToGive { get; set; }
		// Static size: 4
		public int CountGuestPassesToRedeem { get; set; }

		public MsgClientUpdateGuestPassesList()
		{
			Result = 0;
			CountGuestPassesToGive = 0;
			CountGuestPassesToRedeem = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( (int)Result );
			bw.Write( CountGuestPassesToGive );
			bw.Write( CountGuestPassesToRedeem );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			Result = (EResult)br.ReadInt32();
			CountGuestPassesToGive = br.ReadInt32();
			CountGuestPassesToRedeem = br.ReadInt32();
		}
	}

	public class MsgClientServerList : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientServerList; }

		// Static size: 4
		public int CountServers { get; set; }

		public MsgClientServerList()
		{
			CountServers = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( CountServers );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			CountServers = br.ReadInt32();
		}
	}

	public class MsgClientRequestedClientStats : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientRequestedClientStats; }

		// Static size: 4
		public int CountStats { get; set; }

		public MsgClientRequestedClientStats()
		{
			CountStats = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( CountStats );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			CountStats = br.ReadInt32();
		}
	}

	public class MsgClientAddFriend : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientAddFriend; }

		// Static size: 0
		public CMsgClientAddFriend Proto { get; set; }

		public MsgClientAddFriend()
		{
			Proto = new CMsgClientAddFriend();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientAddFriend>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientAddFriend>( stream );
		}
	}

	public class MsgClientAddFriendResponse : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientAddFriendResponse; }

		// Static size: 0
		public CMsgClientAddFriendResponse Proto { get; set; }

		public MsgClientAddFriendResponse()
		{
			Proto = new CMsgClientAddFriendResponse();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientAddFriendResponse>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientAddFriendResponse>( stream );
		}
	}

	public class MsgClientRemoveFriend : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientRemoveFriend; }

		// Static size: 0
		public CMsgClientRemoveFriend Proto { get; set; }

		public MsgClientRemoveFriend()
		{
			Proto = new CMsgClientRemoveFriend();
		}

		public void Serialize(Stream stream)
		{
			ProtoBuf.Serializer.Serialize<CMsgClientRemoveFriend>(stream, Proto);
		}

		public void Deserialize( Stream stream )
		{
			Proto = ProtoBuf.Serializer.Deserialize<CMsgClientRemoveFriend>( stream );
		}
	}

	public class MsgClientP2PIntroducerMessage : ISteamSerializableMessage
	{
		public EMsg GetEMsg() { return EMsg.ClientP2PIntroducerMessage; }

		// Static size: 8
		private ulong steamID;
		public SteamID SteamID { get { return new SteamID( steamID ); } set { steamID = value.ConvertToUint64(); } }
		// Static size: 4
		public EIntroducerRouting RoutingType { get; set; }
		// Static size: 1450
		public byte[] Data { get; set; }
		// Static size: 4
		public uint DataLen { get; set; }

		public MsgClientP2PIntroducerMessage()
		{
			steamID = 0;
			RoutingType = 0;
			Data = new byte[1450];
			DataLen = 0;
		}

		public void Serialize(Stream stream)
		{
			BinaryWriterEx bw = new BinaryWriterEx( stream );

			bw.Write( steamID );
			bw.Write( (int)RoutingType );
			bw.Write( Data );
			bw.Write( DataLen );

		}

		public void Deserialize( Stream stream )
		{
			BinaryReaderEx br = new BinaryReaderEx( stream );

			steamID = br.ReadUInt64();
			RoutingType = (EIntroducerRouting)br.ReadInt32();
			Data = br.ReadBytes( 1450 );
			DataLen = br.ReadUInt32();
		}
	}

}