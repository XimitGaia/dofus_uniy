using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B4C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class WhoIsEvent : IMessage<WhoIsEvent>, IMessage, IEquatable<WhoIsEvent>, IDeepCloneable<WhoIsEvent>, IBufferMessage
{
	[Token(Token = "0x4002A35")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<WhoIsEvent> _parser;

	[Token(Token = "0x4002A36")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A37")]
	public const int SelfFieldNumber = 1;

	[Token(Token = "0x4002A38")]
	[FieldOffset(Offset = "0x18")]
	private bool self_;

	[Token(Token = "0x4002A39")]
	public const int PositionFieldNumber = 2;

	[Token(Token = "0x4002A3A")]
	[FieldOffset(Offset = "0x1C")]
	private Hierarchy position_;

	[Token(Token = "0x4002A3B")]
	public const int AccountNameFieldNumber = 3;

	[Token(Token = "0x4002A3C")]
	[FieldOffset(Offset = "0x20")]
	private string accountName_;

	[Token(Token = "0x4002A3D")]
	public const int AccountTagFieldNumber = 4;

	[Token(Token = "0x4002A3E")]
	[FieldOffset(Offset = "0x28")]
	private string accountTag_;

	[Token(Token = "0x4002A3F")]
	public const int AccountIdFieldNumber = 5;

	[Token(Token = "0x4002A40")]
	[FieldOffset(Offset = "0x30")]
	private long accountId_;

	[Token(Token = "0x4002A41")]
	public const int CharacterNameFieldNumber = 6;

	[Token(Token = "0x4002A42")]
	[FieldOffset(Offset = "0x38")]
	private string characterName_;

	[Token(Token = "0x4002A43")]
	public const int CharacterIdFieldNumber = 7;

	[Token(Token = "0x4002A44")]
	[FieldOffset(Offset = "0x40")]
	private long characterId_;

	[Token(Token = "0x4002A45")]
	public const int AreaIdFieldNumber = 8;

	[Token(Token = "0x4002A46")]
	[FieldOffset(Offset = "0x48")]
	private int areaId_;

	[Token(Token = "0x4002A47")]
	public const int ServerIdFieldNumber = 9;

	[Token(Token = "0x4002A48")]
	[FieldOffset(Offset = "0x4C")]
	private int serverId_;

	[Token(Token = "0x4002A49")]
	public const int OriginServerIdFieldNumber = 10;

	[Token(Token = "0x4002A4A")]
	[FieldOffset(Offset = "0x50")]
	private int originServerId_;

	[Token(Token = "0x4002A4B")]
	public const int GuildInformationFieldNumber = 11;

	[Token(Token = "0x4002A4C")]
	[FieldOffset(Offset = "0x58")]
	private GuildInformation guildInformation_;

	[Token(Token = "0x4002A4D")]
	public const int AllianceInformationFieldNumber = 12;

	[Token(Token = "0x4002A4E")]
	[FieldOffset(Offset = "0x60")]
	private AllianceInformation allianceInformation_;

	[Token(Token = "0x4002A4F")]
	public const int VerboseFieldNumber = 13;

	[Token(Token = "0x4002A50")]
	[FieldOffset(Offset = "0x68")]
	private bool verbose_;

	[Token(Token = "0x4002A51")]
	public const int StateFieldNumber = 14;

	[Token(Token = "0x4002A52")]
	[FieldOffset(Offset = "0x6C")]
	private CharacterState state_;

	[Token(Token = "0x17001A3B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<WhoIsEvent> Parser
	{
		[Token(Token = "0x6007710")]
		[Address(RVA = "0xC2A3B0", Offset = "0xC297B0", VA = "0x180C2A3B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A3C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007711")]
		[Address(RVA = "0xC2A300", Offset = "0xC29700", VA = "0x180C2A300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A3D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007712")]
		[Address(RVA = "0xC2A990", Offset = "0xC29D90", VA = "0x180C2A990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A3E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Self
	{
		[Token(Token = "0x6007716")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007717")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001A3F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Hierarchy Position
	{
		[Token(Token = "0x6007718")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Hierarchy);
		}
		[Token(Token = "0x6007719")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001A40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string AccountName
	{
		[Token(Token = "0x600771A")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600771B")]
		[Address(RVA = "0xC2AA70", Offset = "0xC29E70", VA = "0x180C2AA70")]
		set
		{
		}
	}

	[Token(Token = "0x17001A41")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AccountTag
	{
		[Token(Token = "0x600771C")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600771D")]
		[Address(RVA = "0xC2AAE0", Offset = "0xC29EE0", VA = "0x180C2AAE0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A42")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long AccountId
	{
		[Token(Token = "0x600771E")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600771F")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A43")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CharacterName
	{
		[Token(Token = "0x6007720")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007721")]
		[Address(RVA = "0xC2AB50", Offset = "0xC29F50", VA = "0x180C2AB50")]
		set
		{
		}
	}

	[Token(Token = "0x17001A44")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6007722")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007723")]
		[Address(RVA = "0xAFF0D0", Offset = "0xAFE4D0", VA = "0x180AFF0D0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A45")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AreaId
	{
		[Token(Token = "0x6007724")]
		[Address(RVA = "0x7D9E50", Offset = "0x7D9250", VA = "0x1807D9E50")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007725")]
		[Address(RVA = "0xBA6350", Offset = "0xBA5750", VA = "0x180BA6350")]
		set
		{
		}
	}

	[Token(Token = "0x17001A46")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ServerId
	{
		[Token(Token = "0x6007726")]
		[Address(RVA = "0xBF3E70", Offset = "0xBF3270", VA = "0x180BF3E70")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007727")]
		[Address(RVA = "0xBF46B0", Offset = "0xBF3AB0", VA = "0x180BF46B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A47")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OriginServerId
	{
		[Token(Token = "0x6007728")]
		[Address(RVA = "0x874EA0", Offset = "0x8742A0", VA = "0x180874EA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007729")]
		[Address(RVA = "0x874F70", Offset = "0x874370", VA = "0x180874F70")]
		set
		{
		}
	}

	[Token(Token = "0x17001A48")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInformation GuildInformation
	{
		[Token(Token = "0x600772A")]
		[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600772B")]
		[Address(RVA = "0x912510", Offset = "0x911910", VA = "0x180912510")]
		set
		{
		}
	}

	[Token(Token = "0x17001A49")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation AllianceInformation
	{
		[Token(Token = "0x600772C")]
		[Address(RVA = "0x7D7250", Offset = "0x7D6650", VA = "0x1807D7250")]
		get
		{
			return null;
		}
		[Token(Token = "0x600772D")]
		[Address(RVA = "0xB745C0", Offset = "0xB739C0", VA = "0x180B745C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A4A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Verbose
	{
		[Token(Token = "0x600772E")]
		[Address(RVA = "0x9C6000", Offset = "0x9C5400", VA = "0x1809C6000")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600772F")]
		[Address(RVA = "0x9C6740", Offset = "0x9C5B40", VA = "0x1809C6740")]
		set
		{
		}
	}

	[Token(Token = "0x17001A4B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterState State
	{
		[Token(Token = "0x6007730")]
		[Address(RVA = "0xC2A400", Offset = "0xC29800", VA = "0x180C2A400")]
		get
		{
			return default(CharacterState);
		}
		[Token(Token = "0x6007731")]
		[Address(RVA = "0xC2ABC0", Offset = "0xC29FC0", VA = "0x180C2ABC0")]
		set
		{
		}
	}

	[Token(Token = "0x6007713")]
	[Address(RVA = "0xC2A270", Offset = "0xC29670", VA = "0x180C2A270")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoIsEvent()
	{
	}

	[Token(Token = "0x6007714")]
	[Address(RVA = "0xC2A160", Offset = "0xC29560", VA = "0x180C2A160")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoIsEvent(WhoIsEvent other)
	{
	}

	[Token(Token = "0x6007715")]
	[Address(RVA = "0xC29810", Offset = "0xC28C10", VA = "0x180C29810", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WhoIsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007732")]
	[Address(RVA = "0xC29950", Offset = "0xC28D50", VA = "0x180C29950", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007733")]
	[Address(RVA = "0xC29AC0", Offset = "0xC28EC0", VA = "0x180C29AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(WhoIsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007734")]
	[Address(RVA = "0xC29BE0", Offset = "0xC28FE0", VA = "0x180C29BE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007735")]
	[Address(RVA = "0xC2A000", Offset = "0xC29400", VA = "0x180C2A000", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007736")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007737")]
	[Address(RVA = "0xC2A750", Offset = "0xC29B50", VA = "0x180C2A750", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007738")]
	[Address(RVA = "0xC29580", Offset = "0xC28980", VA = "0x180C29580", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007739")]
	[Address(RVA = "0xC29E20", Offset = "0xC29220", VA = "0x180C29E20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(WhoIsEvent other)
	{
	}

	[Token(Token = "0x600773A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600773B")]
	[Address(RVA = "0xC2A410", Offset = "0xC29810", VA = "0x180C2A410", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
