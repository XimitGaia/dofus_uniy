using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000873")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class LifePointsRegenBeginEvent : IMessage<LifePointsRegenBeginEvent>, IMessage, IEquatable<LifePointsRegenBeginEvent>, IDeepCloneable<LifePointsRegenBeginEvent>, IBufferMessage
{
	[Token(Token = "0x4001D47")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<LifePointsRegenBeginEvent> _parser;

	[Token(Token = "0x4001D48")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D49")]
	public const int RegenRateFieldNumber = 1;

	[Token(Token = "0x4001D4A")]
	[FieldOffset(Offset = "0x18")]
	private int regenRate_;

	[Token(Token = "0x17001321")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LifePointsRegenBeginEvent> Parser
	{
		[Token(Token = "0x60059D9")]
		[Address(RVA = "0xB27460", Offset = "0xB26860", VA = "0x180B27460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001322")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60059DA")]
		[Address(RVA = "0xB273B0", Offset = "0xB267B0", VA = "0x180B273B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001323")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60059DB")]
		[Address(RVA = "0xB274B0", Offset = "0xB268B0", VA = "0x180B274B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001324")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RegenRate
	{
		[Token(Token = "0x60059DF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059E0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60059DC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LifePointsRegenBeginEvent()
	{
	}

	[Token(Token = "0x60059DD")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LifePointsRegenBeginEvent(LifePointsRegenBeginEvent other)
	{
	}

	[Token(Token = "0x60059DE")]
	[Address(RVA = "0xB27140", Offset = "0xB26540", VA = "0x180B27140", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LifePointsRegenBeginEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60059E1")]
	[Address(RVA = "0xB271C0", Offset = "0xB265C0", VA = "0x180B271C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60059E2")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LifePointsRegenBeginEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60059E3")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60059E4")]
	[Address(RVA = "0xB27250", Offset = "0xB26650", VA = "0x180B27250", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60059E5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60059E6")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60059E7")]
	[Address(RVA = "0xB270B0", Offset = "0xB264B0", VA = "0x180B270B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60059E8")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(LifePointsRegenBeginEvent other)
	{
	}

	[Token(Token = "0x60059E9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60059EA")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
