using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Script;

[Token(Token = "0x200015F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CinematicEvent : IMessage<CinematicEvent>, IMessage, IEquatable<CinematicEvent>, IDeepCloneable<CinematicEvent>, IBufferMessage
{
	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CinematicEvent> _parser;

	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004AA")]
	public const int CinematicIdFieldNumber = 1;

	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0x18")]
	private int cinematicId_;

	[Token(Token = "0x170002E8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CinematicEvent> Parser
	{
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0xC42C60", Offset = "0xC42060", VA = "0x180C42C60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0xC42BB0", Offset = "0xC41FB0", VA = "0x180C42BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0xC42CB0", Offset = "0xC420B0", VA = "0x180C42CB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CinematicId
	{
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CinematicEvent()
	{
	}

	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CinematicEvent(CinematicEvent other)
	{
	}

	[Token(Token = "0x6000D98")]
	[Address(RVA = "0xC42940", Offset = "0xC41D40", VA = "0x180C42940", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CinematicEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0xC429C0", Offset = "0xC41DC0", VA = "0x180C429C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CinematicEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0xC42A50", Offset = "0xC41E50", VA = "0x180C42A50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0xC428B0", Offset = "0xC41CB0", VA = "0x180C428B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000DA2")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CinematicEvent other)
	{
	}

	[Token(Token = "0x6000DA3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
