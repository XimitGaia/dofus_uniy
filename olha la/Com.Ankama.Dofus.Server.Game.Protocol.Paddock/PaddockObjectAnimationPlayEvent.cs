using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002C3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockObjectAnimationPlayEvent : IMessage<PaddockObjectAnimationPlayEvent>, IMessage, IEquatable<PaddockObjectAnimationPlayEvent>, IDeepCloneable<PaddockObjectAnimationPlayEvent>, IBufferMessage
{
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockObjectAnimationPlayEvent> _parser;

	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40009B5")]
	public const int CellsIdFieldNumber = 1;

	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_cellsId_codec;

	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> cellsId_;

	[Token(Token = "0x17000631")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PaddockObjectAnimationPlayEvent> Parser
	{
		[Token(Token = "0x6001CBE")]
		[Address(RVA = "0xD08AB0", Offset = "0xD07EB0", VA = "0x180D08AB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000632")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001CBF")]
		[Address(RVA = "0xD08A00", Offset = "0xD07E00", VA = "0x180D08A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000633")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001CC0")]
		[Address(RVA = "0xD08CD0", Offset = "0xD080D0", VA = "0x180D08CD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000634")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CellsId
	{
		[Token(Token = "0x6001CC4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001CC1")]
	[Address(RVA = "0xD088F0", Offset = "0xD07CF0", VA = "0x180D088F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockObjectAnimationPlayEvent()
	{
	}

	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0xD08970", Offset = "0xD07D70", VA = "0x180D08970")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockObjectAnimationPlayEvent(PaddockObjectAnimationPlayEvent other)
	{
	}

	[Token(Token = "0x6001CC3")]
	[Address(RVA = "0xD084B0", Offset = "0xD078B0", VA = "0x180D084B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockObjectAnimationPlayEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001CC5")]
	[Address(RVA = "0xD08570", Offset = "0xD07970", VA = "0x180D08570", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CC6")]
	[Address(RVA = "0xD08650", Offset = "0xD07A50", VA = "0x180D08650", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PaddockObjectAnimationPlayEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CC7")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001CC8")]
	[Address(RVA = "0xD08760", Offset = "0xD07B60", VA = "0x180D08760", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001CC9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0xD08C20", Offset = "0xD08020", VA = "0x180D08C20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001CCB")]
	[Address(RVA = "0xD08410", Offset = "0xD07810", VA = "0x180D08410", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001CCC")]
	[Address(RVA = "0xD086E0", Offset = "0xD07AE0", VA = "0x180D086E0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PaddockObjectAnimationPlayEvent other)
	{
	}

	[Token(Token = "0x6001CCD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0xD08B00", Offset = "0xD07F00", VA = "0x180D08B00", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
