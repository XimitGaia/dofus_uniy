using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection;

[Token(Token = "0x2000823")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QueueStatusEvent : IMessage<QueueStatusEvent>, IMessage, IEquatable<QueueStatusEvent>, IDeepCloneable<QueueStatusEvent>, IBufferMessage
{
	[Token(Token = "0x4001C1A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QueueStatusEvent> _parser;

	[Token(Token = "0x4001C1B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C1C")]
	public const int PositionFieldNumber = 1;

	[Token(Token = "0x4001C1D")]
	[FieldOffset(Offset = "0x18")]
	private int position_;

	[Token(Token = "0x4001C1E")]
	public const int TotalFieldNumber = 2;

	[Token(Token = "0x4001C1F")]
	[FieldOffset(Offset = "0x1C")]
	private int total_;

	[Token(Token = "0x17001267")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QueueStatusEvent> Parser
	{
		[Token(Token = "0x6005672")]
		[Address(RVA = "0xB0EAF0", Offset = "0xB0DEF0", VA = "0x180B0EAF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001268")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005673")]
		[Address(RVA = "0xB0EA40", Offset = "0xB0DE40", VA = "0x180B0EA40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001269")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005674")]
		[Address(RVA = "0xB0EB40", Offset = "0xB0DF40", VA = "0x180B0EB40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700126A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Position
	{
		[Token(Token = "0x6005678")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005679")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700126B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Total
	{
		[Token(Token = "0x600567A")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600567B")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6005675")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QueueStatusEvent()
	{
	}

	[Token(Token = "0x6005676")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QueueStatusEvent(QueueStatusEvent other)
	{
	}

	[Token(Token = "0x6005677")]
	[Address(RVA = "0xB0E7C0", Offset = "0xB0DBC0", VA = "0x180B0E7C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QueueStatusEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600567C")]
	[Address(RVA = "0xB0E850", Offset = "0xB0DC50", VA = "0x180B0E850", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600567D")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QueueStatusEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600567E")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600567F")]
	[Address(RVA = "0xB0E8E0", Offset = "0xB0DCE0", VA = "0x180B0E8E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005680")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005681")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005682")]
	[Address(RVA = "0xB0E700", Offset = "0xB0DB00", VA = "0x180B0E700", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005683")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QueueStatusEvent other)
	{
	}

	[Token(Token = "0x6005684")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005685")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
