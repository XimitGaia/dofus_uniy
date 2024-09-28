using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alteration;

[Token(Token = "0x2000C41")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlterationsEvent : IMessage<AlterationsEvent>, IMessage, IEquatable<AlterationsEvent>, IDeepCloneable<AlterationsEvent>, IBufferMessage
{
	[Token(Token = "0x4002D74")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AlterationsEvent> _parser;

	[Token(Token = "0x4002D75")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D76")]
	public const int AlterationsFieldNumber = 1;

	[Token(Token = "0x4002D77")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Alteration> _repeated_alterations_codec;

	[Token(Token = "0x4002D78")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Alteration> alterations_;

	[Token(Token = "0x17001C4F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlterationsEvent> Parser
	{
		[Token(Token = "0x60080F8")]
		[Address(RVA = "0xC82250", Offset = "0xC81650", VA = "0x180C82250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60080F9")]
		[Address(RVA = "0xC821A0", Offset = "0xC815A0", VA = "0x180C821A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C51")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60080FA")]
		[Address(RVA = "0xC82460", Offset = "0xC81860", VA = "0x180C82460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C52")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Alteration> Alterations
	{
		[Token(Token = "0x60080FE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60080FB")]
	[Address(RVA = "0xC82120", Offset = "0xC81520", VA = "0x180C82120")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlterationsEvent()
	{
	}

	[Token(Token = "0x60080FC")]
	[Address(RVA = "0xC82090", Offset = "0xC81490", VA = "0x180C82090")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlterationsEvent(AlterationsEvent other)
	{
	}

	[Token(Token = "0x60080FD")]
	[Address(RVA = "0xC81BE0", Offset = "0xC80FE0", VA = "0x180C81BE0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlterationsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60080FF")]
	[Address(RVA = "0xC81D30", Offset = "0xC81130", VA = "0x180C81D30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008100")]
	[Address(RVA = "0xC81CA0", Offset = "0xC810A0", VA = "0x180C81CA0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AlterationsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008101")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008102")]
	[Address(RVA = "0xC81E90", Offset = "0xC81290", VA = "0x180C81E90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008103")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008104")]
	[Address(RVA = "0xC823B0", Offset = "0xC817B0", VA = "0x180C823B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008105")]
	[Address(RVA = "0xC81B40", Offset = "0xC80F40", VA = "0x180C81B40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008106")]
	[Address(RVA = "0xC81E10", Offset = "0xC81210", VA = "0x180C81E10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlterationsEvent other)
	{
	}

	[Token(Token = "0x6008107")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008108")]
	[Address(RVA = "0xC822A0", Offset = "0xC816A0", VA = "0x180C822A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
