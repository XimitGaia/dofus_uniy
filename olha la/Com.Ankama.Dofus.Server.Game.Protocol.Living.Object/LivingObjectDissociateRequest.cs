using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Living.Object;

[Token(Token = "0x2000340")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class LivingObjectDissociateRequest : IMessage<LivingObjectDissociateRequest>, IMessage, IEquatable<LivingObjectDissociateRequest>, IDeepCloneable<LivingObjectDissociateRequest>, IBufferMessage
{
	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<LivingObjectDissociateRequest> _parser;

	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B33")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4000B35")]
	public const int PositionFieldNumber = 2;

	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x1C")]
	private int position_;

	[Token(Token = "0x17000731")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<LivingObjectDissociateRequest> Parser
	{
		[Token(Token = "0x6002196")]
		[Address(RVA = "0x9786B0", Offset = "0x977AB0", VA = "0x1809786B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000732")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002197")]
		[Address(RVA = "0x978600", Offset = "0x977A00", VA = "0x180978600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000733")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002198")]
		[Address(RVA = "0x978700", Offset = "0x977B00", VA = "0x180978700", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000734")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x600219C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600219D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000735")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Position
	{
		[Token(Token = "0x600219E")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600219F")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6002199")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LivingObjectDissociateRequest()
	{
	}

	[Token(Token = "0x600219A")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LivingObjectDissociateRequest(LivingObjectDissociateRequest other)
	{
	}

	[Token(Token = "0x600219B")]
	[Address(RVA = "0x978380", Offset = "0x977780", VA = "0x180978380", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LivingObjectDissociateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60021A0")]
	[Address(RVA = "0x978410", Offset = "0x977810", VA = "0x180978410", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60021A1")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LivingObjectDissociateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60021A2")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60021A3")]
	[Address(RVA = "0x9784A0", Offset = "0x9778A0", VA = "0x1809784A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60021A4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60021A5")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60021A6")]
	[Address(RVA = "0x9782C0", Offset = "0x9776C0", VA = "0x1809782C0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60021A7")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(LivingObjectDissociateRequest other)
	{
	}

	[Token(Token = "0x60021A8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60021A9")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
