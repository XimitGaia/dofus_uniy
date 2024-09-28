using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002AF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockMoveItemRequest : IMessage<PaddockMoveItemRequest>, IMessage, IEquatable<PaddockMoveItemRequest>, IDeepCloneable<PaddockMoveItemRequest>, IBufferMessage
{
	[Token(Token = "0x4000970")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockMoveItemRequest> _parser;

	[Token(Token = "0x4000971")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000972")]
	public const int OldCellIdFieldNumber = 1;

	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x18")]
	private int oldCellId_;

	[Token(Token = "0x4000974")]
	public const int NewCellIdFieldNumber = 2;

	[Token(Token = "0x4000975")]
	[FieldOffset(Offset = "0x1C")]
	private int newCellId_;

	[Token(Token = "0x17000604")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PaddockMoveItemRequest> Parser
	{
		[Token(Token = "0x6001BE7")]
		[Address(RVA = "0xD07BF0", Offset = "0xD06FF0", VA = "0x180D07BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000605")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001BE8")]
		[Address(RVA = "0xD07B40", Offset = "0xD06F40", VA = "0x180D07B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000606")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001BE9")]
		[Address(RVA = "0xD07C40", Offset = "0xD07040", VA = "0x180D07C40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000607")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OldCellId
	{
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000608")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NewCellId
	{
		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6001BEA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockMoveItemRequest()
	{
	}

	[Token(Token = "0x6001BEB")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockMoveItemRequest(PaddockMoveItemRequest other)
	{
	}

	[Token(Token = "0x6001BEC")]
	[Address(RVA = "0xD078C0", Offset = "0xD06CC0", VA = "0x180D078C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockMoveItemRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0xD07950", Offset = "0xD06D50", VA = "0x180D07950", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PaddockMoveItemRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BF3")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001BF4")]
	[Address(RVA = "0xD079E0", Offset = "0xD06DE0", VA = "0x180D079E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001BF5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0xD07800", Offset = "0xD06C00", VA = "0x180D07800", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PaddockMoveItemRequest other)
	{
	}

	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001BFA")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
