using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x200005B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OrnamentLostEvent : IMessage<OrnamentLostEvent>, IMessage, IEquatable<OrnamentLostEvent>, IDeepCloneable<OrnamentLostEvent>, IBufferMessage
{
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OrnamentLostEvent> _parser;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400012C")]
	public const int OrnamentIdFieldNumber = 1;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x18")]
	private int ornamentId_;

	[Token(Token = "0x170000A2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OrnamentLostEvent> Parser
	{
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x93DE90", Offset = "0x93D290", VA = "0x18093DE90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x93DDE0", Offset = "0x93D1E0", VA = "0x18093DDE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x93DEE0", Offset = "0x93D2E0", VA = "0x18093DEE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OrnamentId
	{
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OrnamentLostEvent()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OrnamentLostEvent(OrnamentLostEvent other)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x93DB70", Offset = "0x93CF70", VA = "0x18093DB70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OrnamentLostEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x93DBF0", Offset = "0x93CFF0", VA = "0x18093DBF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OrnamentLostEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x93DC80", Offset = "0x93D080", VA = "0x18093DC80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x93DAE0", Offset = "0x93CEE0", VA = "0x18093DAE0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OrnamentLostEvent other)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
