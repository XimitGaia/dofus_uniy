using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x2000835")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Choice : IMessage<Choice>, IMessage, IEquatable<Choice>, IDeepCloneable<Choice>, IBufferMessage
{
	[Token(Token = "0x4001C41")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Choice> _parser;

	[Token(Token = "0x4001C42")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C43")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4001C44")]
	[FieldOffset(Offset = "0x18")]
	private int id_;

	[Token(Token = "0x4001C45")]
	public const int PositionFieldNumber = 2;

	[Token(Token = "0x4001C46")]
	[FieldOffset(Offset = "0x1C")]
	private int position_;

	[Token(Token = "0x17001288")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Choice> Parser
	{
		[Token(Token = "0x6005724")]
		[Address(RVA = "0xB07820", Offset = "0xB06C20", VA = "0x180B07820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001289")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005725")]
		[Address(RVA = "0xB07770", Offset = "0xB06B70", VA = "0x180B07770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700128A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005726")]
		[Address(RVA = "0xB07870", Offset = "0xB06C70", VA = "0x180B07870", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700128B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		[Token(Token = "0x600572A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600572B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700128C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Position
	{
		[Token(Token = "0x600572C")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600572D")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6005727")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Choice()
	{
	}

	[Token(Token = "0x6005728")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Choice(Choice other)
	{
	}

	[Token(Token = "0x6005729")]
	[Address(RVA = "0xB074F0", Offset = "0xB068F0", VA = "0x180B074F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Choice Clone()
	{
		return null;
	}

	[Token(Token = "0x600572E")]
	[Address(RVA = "0xB07580", Offset = "0xB06980", VA = "0x180B07580", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600572F")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(Choice other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005730")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005731")]
	[Address(RVA = "0xB07610", Offset = "0xB06A10", VA = "0x180B07610", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005732")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005733")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005734")]
	[Address(RVA = "0xB07430", Offset = "0xB06830", VA = "0x180B07430", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005735")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Choice other)
	{
	}

	[Token(Token = "0x6005736")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005737")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
