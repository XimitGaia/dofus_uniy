using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Atlas;

[Token(Token = "0x2000B7E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CompassResetEvent : IMessage<CompassResetEvent>, IMessage, IEquatable<CompassResetEvent>, IDeepCloneable<CompassResetEvent>, IBufferMessage
{
	[Token(Token = "0x4002AE8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CompassResetEvent> _parser;

	[Token(Token = "0x4002AE9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002AEA")]
	public const int TypeFieldNumber = 1;

	[Token(Token = "0x4002AEB")]
	[FieldOffset(Offset = "0x18")]
	private CompassType type_;

	[Token(Token = "0x17001AA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CompassResetEvent> Parser
	{
		[Token(Token = "0x60078F1")]
		[Address(RVA = "0xC220B0", Offset = "0xC214B0", VA = "0x180C220B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AA1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60078F2")]
		[Address(RVA = "0xC22000", Offset = "0xC21400", VA = "0x180C22000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AA2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60078F3")]
		[Address(RVA = "0xC22100", Offset = "0xC21500", VA = "0x180C22100", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AA3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CompassType Type
	{
		[Token(Token = "0x60078F7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(CompassType);
		}
		[Token(Token = "0x60078F8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60078F4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CompassResetEvent()
	{
	}

	[Token(Token = "0x60078F5")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CompassResetEvent(CompassResetEvent other)
	{
	}

	[Token(Token = "0x60078F6")]
	[Address(RVA = "0xC21D90", Offset = "0xC21190", VA = "0x180C21D90", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CompassResetEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60078F9")]
	[Address(RVA = "0xC21E10", Offset = "0xC21210", VA = "0x180C21E10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60078FA")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CompassResetEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60078FB")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60078FC")]
	[Address(RVA = "0xC21EA0", Offset = "0xC212A0", VA = "0x180C21EA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60078FD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60078FE")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60078FF")]
	[Address(RVA = "0xC21D00", Offset = "0xC21100", VA = "0x180C21D00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007900")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CompassResetEvent other)
	{
	}

	[Token(Token = "0x6007901")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007902")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
