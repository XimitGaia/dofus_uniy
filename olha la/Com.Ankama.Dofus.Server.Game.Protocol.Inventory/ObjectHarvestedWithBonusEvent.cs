using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003BD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectHarvestedWithBonusEvent : IMessage<ObjectHarvestedWithBonusEvent>, IMessage, IEquatable<ObjectHarvestedWithBonusEvent>, IDeepCloneable<ObjectHarvestedWithBonusEvent>, IBufferMessage
{
	[Token(Token = "0x4000CD2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectHarvestedWithBonusEvent> _parser;

	[Token(Token = "0x4000CD3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CD4")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x4000CD5")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x4000CD6")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x4000CD7")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x4000CD8")]
	public const int BonusQuantityFieldNumber = 3;

	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0x20")]
	private int bonusQuantity_;

	[Token(Token = "0x17000851")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectHarvestedWithBonusEvent> Parser
	{
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x990970", Offset = "0x98FD70", VA = "0x180990970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000852")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x9908C0", Offset = "0x98FCC0", VA = "0x1809908C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000853")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60026F5")]
		[Address(RVA = "0x9909C0", Offset = "0x98FDC0", VA = "0x1809909C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000854")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGid
	{
		[Token(Token = "0x60026F9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60026FA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000855")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Quantity
	{
		[Token(Token = "0x60026FB")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60026FC")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000856")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BonusQuantity
	{
		[Token(Token = "0x60026FD")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60026FE")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60026F6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectHarvestedWithBonusEvent()
	{
	}

	[Token(Token = "0x60026F7")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectHarvestedWithBonusEvent(ObjectHarvestedWithBonusEvent other)
	{
	}

	[Token(Token = "0x60026F8")]
	[Address(RVA = "0x990630", Offset = "0x98FA30", VA = "0x180990630", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectHarvestedWithBonusEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60026FF")]
	[Address(RVA = "0x9906C0", Offset = "0x98FAC0", VA = "0x1809906C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002700")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectHarvestedWithBonusEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002701")]
	[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002702")]
	[Address(RVA = "0x990760", Offset = "0x98FB60", VA = "0x180990760", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002703")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002704")]
	[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002705")]
	[Address(RVA = "0x990550", Offset = "0x98F950", VA = "0x180990550", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002706")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectHarvestedWithBonusEvent other)
	{
	}

	[Token(Token = "0x6002707")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002708")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
