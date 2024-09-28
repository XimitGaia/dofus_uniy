using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x2000059")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OrnamentGainedEvent : IMessage<OrnamentGainedEvent>, IMessage, IEquatable<OrnamentGainedEvent>, IDeepCloneable<OrnamentGainedEvent>, IBufferMessage
{
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OrnamentGainedEvent> _parser;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000127")]
	public const int OrnamentIdFieldNumber = 1;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x18")]
	private int ornamentId_;

	[Token(Token = "0x1700009E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OrnamentGainedEvent> Parser
	{
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x93D9B0", Offset = "0x93CDB0", VA = "0x18093D9B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x93D900", Offset = "0x93CD00", VA = "0x18093D900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x93DA00", Offset = "0x93CE00", VA = "0x18093DA00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OrnamentId
	{
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OrnamentGainedEvent()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OrnamentGainedEvent(OrnamentGainedEvent other)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x93D690", Offset = "0x93CA90", VA = "0x18093D690", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OrnamentGainedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x93D710", Offset = "0x93CB10", VA = "0x18093D710", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OrnamentGainedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x93D7A0", Offset = "0x93CBA0", VA = "0x18093D7A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x93D600", Offset = "0x93CA00", VA = "0x18093D600", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OrnamentGainedEvent other)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
