using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000B8A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaRegisterRequest : IMessage<ArenaRegisterRequest>, IMessage, IEquatable<ArenaRegisterRequest>, IDeepCloneable<ArenaRegisterRequest>, IBufferMessage
{
	[Token(Token = "0x4002B0F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaRegisterRequest> _parser;

	[Token(Token = "0x4002B10")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B11")]
	public const int ArenaTypeFieldNumber = 1;

	[Token(Token = "0x4002B12")]
	[FieldOffset(Offset = "0x18")]
	private ArenaType arenaType_;

	[Token(Token = "0x17001AB7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArenaRegisterRequest> Parser
	{
		[Token(Token = "0x6007957")]
		[Address(RVA = "0xC324B0", Offset = "0xC318B0", VA = "0x180C324B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AB8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007958")]
		[Address(RVA = "0xC32400", Offset = "0xC31800", VA = "0x180C32400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AB9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007959")]
		[Address(RVA = "0xC32500", Offset = "0xC31900", VA = "0x180C32500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ABA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaType ArenaType
	{
		[Token(Token = "0x600795D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ArenaType);
		}
		[Token(Token = "0x600795E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600795A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaRegisterRequest()
	{
	}

	[Token(Token = "0x600795B")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaRegisterRequest(ArenaRegisterRequest other)
	{
	}

	[Token(Token = "0x600795C")]
	[Address(RVA = "0xC32190", Offset = "0xC31590", VA = "0x180C32190", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaRegisterRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600795F")]
	[Address(RVA = "0xC32210", Offset = "0xC31610", VA = "0x180C32210", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007960")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArenaRegisterRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007961")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007962")]
	[Address(RVA = "0xC322A0", Offset = "0xC316A0", VA = "0x180C322A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007963")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007964")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007965")]
	[Address(RVA = "0xC32100", Offset = "0xC31500", VA = "0x180C32100", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007966")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ArenaRegisterRequest other)
	{
	}

	[Token(Token = "0x6007967")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007968")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
