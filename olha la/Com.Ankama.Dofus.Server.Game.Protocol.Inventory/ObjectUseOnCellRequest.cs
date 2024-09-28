using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x2000392")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectUseOnCellRequest : IMessage<ObjectUseOnCellRequest>, IMessage, IEquatable<ObjectUseOnCellRequest>, IDeepCloneable<ObjectUseOnCellRequest>, IBufferMessage
{
	[Token(Token = "0x4000C52")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectUseOnCellRequest> _parser;

	[Token(Token = "0x4000C53")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C54")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000C55")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4000C56")]
	public const int CellIdFieldNumber = 2;

	[Token(Token = "0x4000C57")]
	[FieldOffset(Offset = "0x1C")]
	private int cellId_;

	[Token(Token = "0x170007F5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectUseOnCellRequest> Parser
	{
		[Token(Token = "0x600251C")]
		[Address(RVA = "0x992D50", Offset = "0x992150", VA = "0x180992D50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600251D")]
		[Address(RVA = "0x992CA0", Offset = "0x9920A0", VA = "0x180992CA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x992DA0", Offset = "0x9921A0", VA = "0x180992DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x6002522")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002523")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007F9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CellId
	{
		[Token(Token = "0x6002524")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002525")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x600251F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectUseOnCellRequest()
	{
	}

	[Token(Token = "0x6002520")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectUseOnCellRequest(ObjectUseOnCellRequest other)
	{
	}

	[Token(Token = "0x6002521")]
	[Address(RVA = "0x992A20", Offset = "0x991E20", VA = "0x180992A20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectUseOnCellRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002526")]
	[Address(RVA = "0x992AB0", Offset = "0x991EB0", VA = "0x180992AB0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002527")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ObjectUseOnCellRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002528")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002529")]
	[Address(RVA = "0x992B40", Offset = "0x991F40", VA = "0x180992B40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600252A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600252B")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600252C")]
	[Address(RVA = "0x992960", Offset = "0x991D60", VA = "0x180992960", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600252D")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectUseOnCellRequest other)
	{
	}

	[Token(Token = "0x600252E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600252F")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
