using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CC8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceMotdEvent : IMessage<AllianceMotdEvent>, IMessage, IEquatable<AllianceMotdEvent>, IDeepCloneable<AllianceMotdEvent>, IBufferMessage
{
	[Token(Token = "0x4002F29")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceMotdEvent> _parser;

	[Token(Token = "0x4002F2A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F2B")]
	public const int MotdInfoFieldNumber = 1;

	[Token(Token = "0x4002F2C")]
	[FieldOffset(Offset = "0x18")]
	private SocialNoticeInformation motdInfo_;

	[Token(Token = "0x17001D7A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceMotdEvent> Parser
	{
		[Token(Token = "0x60086B2")]
		[Address(RVA = "0xC9A790", Offset = "0xC99B90", VA = "0x180C9A790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D7B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60086B3")]
		[Address(RVA = "0xC9A6E0", Offset = "0xC99AE0", VA = "0x180C9A6E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D7C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60086B4")]
		[Address(RVA = "0xC9A8E0", Offset = "0xC99CE0", VA = "0x180C9A8E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D7D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialNoticeInformation MotdInfo
	{
		[Token(Token = "0x60086B8")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086B9")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60086B5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMotdEvent()
	{
	}

	[Token(Token = "0x60086B6")]
	[Address(RVA = "0x9E9A90", Offset = "0x9E8E90", VA = "0x1809E9A90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMotdEvent(AllianceMotdEvent other)
	{
	}

	[Token(Token = "0x60086B7")]
	[Address(RVA = "0xC9A360", Offset = "0xC99760", VA = "0x180C9A360", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMotdEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60086BA")]
	[Address(RVA = "0xC9A400", Offset = "0xC99800", VA = "0x180C9A400", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60086BB")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceMotdEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60086BC")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60086BD")]
	[Address(RVA = "0xC9A580", Offset = "0xC99980", VA = "0x180C9A580", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60086BE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60086BF")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60086C0")]
	[Address(RVA = "0xC9A2D0", Offset = "0xC996D0", VA = "0x180C9A2D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60086C1")]
	[Address(RVA = "0xC9A4B0", Offset = "0xC998B0", VA = "0x180C9A4B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceMotdEvent other)
	{
	}

	[Token(Token = "0x60086C2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60086C3")]
	[Address(RVA = "0xC9A7E0", Offset = "0xC99BE0", VA = "0x180C9A7E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
