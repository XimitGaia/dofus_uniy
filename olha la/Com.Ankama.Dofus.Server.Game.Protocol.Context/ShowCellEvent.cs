using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x200079F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShowCellEvent : IMessage<ShowCellEvent>, IMessage, IEquatable<ShowCellEvent>, IDeepCloneable<ShowCellEvent>, IBufferMessage
{
	[Token(Token = "0x4001A87")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShowCellEvent> _parser;

	[Token(Token = "0x4001A88")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A89")]
	public const int SourceIdFieldNumber = 1;

	[Token(Token = "0x4001A8A")]
	[FieldOffset(Offset = "0x18")]
	private long sourceId_;

	[Token(Token = "0x4001A8B")]
	public const int CellIdFieldNumber = 2;

	[Token(Token = "0x4001A8C")]
	[FieldOffset(Offset = "0x20")]
	private int cellId_;

	[Token(Token = "0x17001151")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShowCellEvent> Parser
	{
		[Token(Token = "0x600511E")]
		[Address(RVA = "0xAE0F40", Offset = "0xAE0340", VA = "0x180AE0F40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001152")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600511F")]
		[Address(RVA = "0xAE0E90", Offset = "0xAE0290", VA = "0x180AE0E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001153")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005120")]
		[Address(RVA = "0xAE0F90", Offset = "0xAE0390", VA = "0x180AE0F90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001154")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SourceId
	{
		[Token(Token = "0x6005124")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005125")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001155")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CellId
	{
		[Token(Token = "0x6005126")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005127")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6005121")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShowCellEvent()
	{
	}

	[Token(Token = "0x6005122")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShowCellEvent(ShowCellEvent other)
	{
	}

	[Token(Token = "0x6005123")]
	[Address(RVA = "0xAE0C00", Offset = "0xAE0000", VA = "0x180AE0C00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShowCellEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005128")]
	[Address(RVA = "0xAE0C90", Offset = "0xAE0090", VA = "0x180AE0C90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005129")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShowCellEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600512A")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600512B")]
	[Address(RVA = "0xAE0D30", Offset = "0xAE0130", VA = "0x180AE0D30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600512C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600512D")]
	[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600512E")]
	[Address(RVA = "0xAE0B40", Offset = "0xADFF40", VA = "0x180AE0B40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600512F")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShowCellEvent other)
	{
	}

	[Token(Token = "0x6005130")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005131")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
