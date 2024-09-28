using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CA1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceCreationValidRequest : IMessage<AllianceCreationValidRequest>, IMessage, IEquatable<AllianceCreationValidRequest>, IDeepCloneable<AllianceCreationValidRequest>, IBufferMessage
{
	[Token(Token = "0x4002E8B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceCreationValidRequest> _parser;

	[Token(Token = "0x4002E8C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E8D")]
	public const int AllianceNameFieldNumber = 1;

	[Token(Token = "0x4002E8E")]
	[FieldOffset(Offset = "0x18")]
	private string allianceName_;

	[Token(Token = "0x4002E8F")]
	public const int AllianceTagFieldNumber = 2;

	[Token(Token = "0x4002E90")]
	[FieldOffset(Offset = "0x20")]
	private string allianceTag_;

	[Token(Token = "0x4002E91")]
	public const int AllianceEmblemFieldNumber = 3;

	[Token(Token = "0x4002E92")]
	[FieldOffset(Offset = "0x28")]
	private SocialEmblem allianceEmblem_;

	[Token(Token = "0x17001D19")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceCreationValidRequest> Parser
	{
		[Token(Token = "0x60084FB")]
		[Address(RVA = "0xC8CC80", Offset = "0xC8C080", VA = "0x180C8CC80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D1A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60084FC")]
		[Address(RVA = "0xC8CBD0", Offset = "0xC8BFD0", VA = "0x180C8CBD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D1B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60084FD")]
		[Address(RVA = "0xC8CF10", Offset = "0xC8C310", VA = "0x180C8CF10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D1C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AllianceName
	{
		[Token(Token = "0x6008501")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008502")]
		[Address(RVA = "0xC8CFF0", Offset = "0xC8C3F0", VA = "0x180C8CFF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D1D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AllianceTag
	{
		[Token(Token = "0x6008503")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008504")]
		[Address(RVA = "0xC8D060", Offset = "0xC8C460", VA = "0x180C8D060")]
		set
		{
		}
	}

	[Token(Token = "0x17001D1E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialEmblem AllianceEmblem
	{
		[Token(Token = "0x6008505")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008506")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x60084FE")]
	[Address(RVA = "0xC8CB60", Offset = "0xC8BF60", VA = "0x180C8CB60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceCreationValidRequest()
	{
	}

	[Token(Token = "0x60084FF")]
	[Address(RVA = "0xC8CA60", Offset = "0xC8BE60", VA = "0x180C8CA60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceCreationValidRequest(AllianceCreationValidRequest other)
	{
	}

	[Token(Token = "0x6008500")]
	[Address(RVA = "0xC8C490", Offset = "0xC8B890", VA = "0x180C8C490", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceCreationValidRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008507")]
	[Address(RVA = "0xC8C650", Offset = "0xC8BA50", VA = "0x180C8C650", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008508")]
	[Address(RVA = "0xC8C5C0", Offset = "0xC8B9C0", VA = "0x180C8C5C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceCreationValidRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008509")]
	[Address(RVA = "0xC8C730", Offset = "0xC8BB30", VA = "0x180C8C730", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600850A")]
	[Address(RVA = "0xC8C900", Offset = "0xC8BD00", VA = "0x180C8C900", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600850B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600850C")]
	[Address(RVA = "0xC8CE50", Offset = "0xC8C250", VA = "0x180C8CE50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600850D")]
	[Address(RVA = "0xC8C3A0", Offset = "0xC8B7A0", VA = "0x180C8C3A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600850E")]
	[Address(RVA = "0xC8C7F0", Offset = "0xC8BBF0", VA = "0x180C8C7F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceCreationValidRequest other)
	{
	}

	[Token(Token = "0x600850F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008510")]
	[Address(RVA = "0xC8CCD0", Offset = "0xC8C0D0", VA = "0x180C8CCD0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
