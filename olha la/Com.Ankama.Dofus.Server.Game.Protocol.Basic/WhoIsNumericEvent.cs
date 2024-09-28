using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B50")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class WhoIsNumericEvent : IMessage<WhoIsNumericEvent>, IMessage, IEquatable<WhoIsNumericEvent>, IDeepCloneable<WhoIsNumericEvent>, IBufferMessage
{
	[Token(Token = "0x4002A57")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<WhoIsNumericEvent> _parser;

	[Token(Token = "0x4002A58")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A59")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x4002A5A")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x4002A5B")]
	public const int AccountIdFieldNumber = 2;

	[Token(Token = "0x4002A5C")]
	[FieldOffset(Offset = "0x20")]
	private long accountId_;

	[Token(Token = "0x17001A4F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<WhoIsNumericEvent> Parser
	{
		[Token(Token = "0x6007754")]
		[Address(RVA = "0xC2B410", Offset = "0xC2A810", VA = "0x180C2B410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A50")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007755")]
		[Address(RVA = "0xC2B360", Offset = "0xC2A760", VA = "0x180C2B360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A51")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007756")]
		[Address(RVA = "0xC2B460", Offset = "0xC2A860", VA = "0x180C2B460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A52")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x600775A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600775B")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001A53")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AccountId
	{
		[Token(Token = "0x600775C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600775D")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6007757")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoIsNumericEvent()
	{
	}

	[Token(Token = "0x6007758")]
	[Address(RVA = "0x951C30", Offset = "0x951030", VA = "0x180951C30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WhoIsNumericEvent(WhoIsNumericEvent other)
	{
	}

	[Token(Token = "0x6007759")]
	[Address(RVA = "0xC2B0D0", Offset = "0xC2A4D0", VA = "0x180C2B0D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoIsNumericEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600775E")]
	[Address(RVA = "0xC2B160", Offset = "0xC2A560", VA = "0x180C2B160", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600775F")]
	[Address(RVA = "0x951900", Offset = "0x950D00", VA = "0x180951900", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(WhoIsNumericEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007760")]
	[Address(RVA = "0x9519E0", Offset = "0x950DE0", VA = "0x1809519E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007761")]
	[Address(RVA = "0xC2B200", Offset = "0xC2A600", VA = "0x180C2B200", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007762")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007763")]
	[Address(RVA = "0x951E40", Offset = "0x951240", VA = "0x180951E40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007764")]
	[Address(RVA = "0xC2B010", Offset = "0xC2A410", VA = "0x180C2B010", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007765")]
	[Address(RVA = "0x951A70", Offset = "0x950E70", VA = "0x180951A70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(WhoIsNumericEvent other)
	{
	}

	[Token(Token = "0x6007766")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007767")]
	[Address(RVA = "0x951D90", Offset = "0x951190", VA = "0x180951D90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
