using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Anomaly;

[Token(Token = "0x2000C3E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AnomalyOpenedEvent : IMessage<AnomalyOpenedEvent>, IMessage, IEquatable<AnomalyOpenedEvent>, IDeepCloneable<AnomalyOpenedEvent>, IBufferMessage
{
	[Token(Token = "0x4002D6E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AnomalyOpenedEvent> _parser;

	[Token(Token = "0x4002D6F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D70")]
	public const int SubareaIdFieldNumber = 1;

	[Token(Token = "0x4002D71")]
	[FieldOffset(Offset = "0x18")]
	private int subareaId_;

	[Token(Token = "0x17001C4A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AnomalyOpenedEvent> Parser
	{
		[Token(Token = "0x60080E0")]
		[Address(RVA = "0xC832F0", Offset = "0xC826F0", VA = "0x180C832F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C4B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60080E1")]
		[Address(RVA = "0xC83240", Offset = "0xC82640", VA = "0x180C83240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C4C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60080E2")]
		[Address(RVA = "0xC83340", Offset = "0xC82740", VA = "0x180C83340", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C4D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SubareaId
	{
		[Token(Token = "0x60080E6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60080E7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60080E3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AnomalyOpenedEvent()
	{
	}

	[Token(Token = "0x60080E4")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AnomalyOpenedEvent(AnomalyOpenedEvent other)
	{
	}

	[Token(Token = "0x60080E5")]
	[Address(RVA = "0xC82FD0", Offset = "0xC823D0", VA = "0x180C82FD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AnomalyOpenedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60080E8")]
	[Address(RVA = "0xC83050", Offset = "0xC82450", VA = "0x180C83050", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60080E9")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AnomalyOpenedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60080EA")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60080EB")]
	[Address(RVA = "0xC830E0", Offset = "0xC824E0", VA = "0x180C830E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60080EC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60080ED")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60080EE")]
	[Address(RVA = "0xC82F40", Offset = "0xC82340", VA = "0x180C82F40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60080EF")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AnomalyOpenedEvent other)
	{
	}

	[Token(Token = "0x60080F0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60080F1")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
