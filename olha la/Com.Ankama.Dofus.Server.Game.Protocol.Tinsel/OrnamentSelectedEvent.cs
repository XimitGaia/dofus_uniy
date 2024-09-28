using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x2000061")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OrnamentSelectedEvent : IMessage<OrnamentSelectedEvent>, IMessage, IEquatable<OrnamentSelectedEvent>, IDeepCloneable<OrnamentSelectedEvent>, IBufferMessage
{
	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OrnamentSelectedEvent> _parser;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400013B")]
	public const int OrnamentIdFieldNumber = 1;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x18")]
	private int ornamentId_;

	[Token(Token = "0x170000AE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OrnamentSelectedEvent> Parser
	{
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x93E370", Offset = "0x93D770", VA = "0x18093E370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x93E2C0", Offset = "0x93D6C0", VA = "0x18093E2C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x93E3C0", Offset = "0x93D7C0", VA = "0x18093E3C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OrnamentId
	{
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OrnamentSelectedEvent()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OrnamentSelectedEvent(OrnamentSelectedEvent other)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x93E050", Offset = "0x93D450", VA = "0x18093E050", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OrnamentSelectedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x93E0D0", Offset = "0x93D4D0", VA = "0x18093E0D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OrnamentSelectedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x93E160", Offset = "0x93D560", VA = "0x18093E160", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x93DFC0", Offset = "0x93D3C0", VA = "0x18093DFC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OrnamentSelectedEvent other)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
