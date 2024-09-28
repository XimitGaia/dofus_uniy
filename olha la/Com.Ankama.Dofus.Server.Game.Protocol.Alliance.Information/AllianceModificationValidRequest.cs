using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CA7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceModificationValidRequest : IMessage<AllianceModificationValidRequest>, IMessage, IEquatable<AllianceModificationValidRequest>, IDeepCloneable<AllianceModificationValidRequest>, IBufferMessage
{
	[Token(Token = "0x4002EA0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceModificationValidRequest> _parser;

	[Token(Token = "0x4002EA1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002EA2")]
	public const int AllianceNameFieldNumber = 1;

	[Token(Token = "0x4002EA3")]
	[FieldOffset(Offset = "0x18")]
	private string allianceName_;

	[Token(Token = "0x4002EA4")]
	public const int AllianceTagFieldNumber = 2;

	[Token(Token = "0x4002EA5")]
	[FieldOffset(Offset = "0x20")]
	private string allianceTag_;

	[Token(Token = "0x4002EA6")]
	public const int AllianceEmblemFieldNumber = 3;

	[Token(Token = "0x4002EA7")]
	[FieldOffset(Offset = "0x28")]
	private SocialEmblem allianceEmblem_;

	[Token(Token = "0x17001D28")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceModificationValidRequest> Parser
	{
		[Token(Token = "0x6008543")]
		[Address(RVA = "0xC99F40", Offset = "0xC99340", VA = "0x180C99F40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D29")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008544")]
		[Address(RVA = "0xC99E90", Offset = "0xC99290", VA = "0x180C99E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D2A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008545")]
		[Address(RVA = "0xC9A110", Offset = "0xC99510", VA = "0x180C9A110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D2B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string AllianceName
	{
		[Token(Token = "0x6008549")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600854A")]
		[Address(RVA = "0xC9A1F0", Offset = "0xC995F0", VA = "0x180C9A1F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D2C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string AllianceTag
	{
		[Token(Token = "0x600854B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600854C")]
		[Address(RVA = "0xC9A260", Offset = "0xC99660", VA = "0x180C9A260")]
		set
		{
		}
	}

	[Token(Token = "0x17001D2D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialEmblem AllianceEmblem
	{
		[Token(Token = "0x600854D")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600854E")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6008546")]
	[Address(RVA = "0xC99D20", Offset = "0xC99120", VA = "0x180C99D20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceModificationValidRequest()
	{
	}

	[Token(Token = "0x6008547")]
	[Address(RVA = "0xC99D90", Offset = "0xC99190", VA = "0x180C99D90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceModificationValidRequest(AllianceModificationValidRequest other)
	{
	}

	[Token(Token = "0x6008548")]
	[Address(RVA = "0xC998A0", Offset = "0xC98CA0", VA = "0x180C998A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceModificationValidRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600854F")]
	[Address(RVA = "0xC999D0", Offset = "0xC98DD0", VA = "0x180C999D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008550")]
	[Address(RVA = "0xC8C5C0", Offset = "0xC8B9C0", VA = "0x180C8C5C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceModificationValidRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008551")]
	[Address(RVA = "0xC8C730", Offset = "0xC8BB30", VA = "0x180C8C730", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008552")]
	[Address(RVA = "0xC99BC0", Offset = "0xC98FC0", VA = "0x180C99BC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008553")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008554")]
	[Address(RVA = "0xC8CE50", Offset = "0xC8C250", VA = "0x180C8CE50", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008555")]
	[Address(RVA = "0xC997B0", Offset = "0xC98BB0", VA = "0x180C997B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008556")]
	[Address(RVA = "0xC99AB0", Offset = "0xC98EB0", VA = "0x180C99AB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceModificationValidRequest other)
	{
	}

	[Token(Token = "0x6008557")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008558")]
	[Address(RVA = "0xC99F90", Offset = "0xC99390", VA = "0x180C99F90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
