using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A03")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EntityDisposition : IMessage<EntityDisposition>, IMessage, IEquatable<EntityDisposition>, IDeepCloneable<EntityDisposition>, IBufferMessage
{
	[Token(Token = "0x40023CE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EntityDisposition> _parser;

	[Token(Token = "0x40023CF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40023D0")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x40023D1")]
	public const int EntityIdFieldNumber = 1;

	[Token(Token = "0x40023D2")]
	[FieldOffset(Offset = "0x8")]
	private static readonly long EntityIdDefaultValue;

	[Token(Token = "0x40023D3")]
	[FieldOffset(Offset = "0x20")]
	private long entityId_;

	[Token(Token = "0x40023D4")]
	public const int CellIdFieldNumber = 2;

	[Token(Token = "0x40023D5")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int CellIdDefaultValue;

	[Token(Token = "0x40023D6")]
	[FieldOffset(Offset = "0x28")]
	private int cellId_;

	[Token(Token = "0x40023D7")]
	public const int DirectionFieldNumber = 3;

	[Token(Token = "0x40023D8")]
	[FieldOffset(Offset = "0x2C")]
	private Direction direction_;

	[Token(Token = "0x40023D9")]
	public const int CarryingCharacterIdFieldNumber = 4;

	[Token(Token = "0x40023DA")]
	[FieldOffset(Offset = "0x18")]
	private static readonly long CarryingCharacterIdDefaultValue;

	[Token(Token = "0x40023DB")]
	[FieldOffset(Offset = "0x30")]
	private long carryingCharacterId_;

	[Token(Token = "0x1700167B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EntityDisposition> Parser
	{
		[Token(Token = "0x6006878")]
		[Address(RVA = "0xBA8B90", Offset = "0xBA7F90", VA = "0x180BA8B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700167C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006879")]
		[Address(RVA = "0xBA8A70", Offset = "0xBA7E70", VA = "0x180BA8A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700167D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600687A")]
		[Address(RVA = "0xBA8E90", Offset = "0xBA8290", VA = "0x180BA8E90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700167E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long EntityId
	{
		[Token(Token = "0x600687E")]
		[Address(RVA = "0xBA8B20", Offset = "0xBA7F20", VA = "0x180BA8B20")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600687F")]
		[Address(RVA = "0x9B9320", Offset = "0x9B8720", VA = "0x1809B9320")]
		set
		{
		}
	}

	[Token(Token = "0x1700167F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasEntityId
	{
		[Token(Token = "0x6006880")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001680")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CellId
	{
		[Token(Token = "0x6006882")]
		[Address(RVA = "0xBA8A00", Offset = "0xBA7E00", VA = "0x180BA8A00")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006883")]
		[Address(RVA = "0xBA8F80", Offset = "0xBA8380", VA = "0x180BA8F80")]
		set
		{
		}
	}

	[Token(Token = "0x17001681")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasCellId
	{
		[Token(Token = "0x6006884")]
		[Address(RVA = "0xAEF3E0", Offset = "0xAEE7E0", VA = "0x180AEF3E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001682")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Direction Direction
	{
		[Token(Token = "0x6006886")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(Direction);
		}
		[Token(Token = "0x6006887")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x17001683")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CarryingCharacterId
	{
		[Token(Token = "0x6006888")]
		[Address(RVA = "0xBA8990", Offset = "0xBA7D90", VA = "0x180BA8990")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006889")]
		[Address(RVA = "0xBA8F70", Offset = "0xBA8370", VA = "0x180BA8F70")]
		set
		{
		}
	}

	[Token(Token = "0x17001684")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCarryingCharacterId
	{
		[Token(Token = "0x600688A")]
		[Address(RVA = "0xAEF400", Offset = "0xAEE800", VA = "0x180AEF400")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600687B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityDisposition()
	{
	}

	[Token(Token = "0x600687C")]
	[Address(RVA = "0xBA8920", Offset = "0xBA7D20", VA = "0x180BA8920")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityDisposition(EntityDisposition other)
	{
	}

	[Token(Token = "0x600687D")]
	[Address(RVA = "0xBA82D0", Offset = "0xBA76D0", VA = "0x180BA82D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityDisposition Clone()
	{
		return null;
	}

	[Token(Token = "0x6006881")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEntityId()
	{
	}

	[Token(Token = "0x6006885")]
	[Address(RVA = "0xAEE790", Offset = "0xAEDB90", VA = "0x180AEE790")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCellId()
	{
	}

	[Token(Token = "0x600688B")]
	[Address(RVA = "0xAEE7B0", Offset = "0xAEDBB0", VA = "0x180AEE7B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCarryingCharacterId()
	{
	}

	[Token(Token = "0x600688C")]
	[Address(RVA = "0xBA8370", Offset = "0xBA7770", VA = "0x180BA8370", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600688D")]
	[Address(RVA = "0xBA8470", Offset = "0xBA7870", VA = "0x180BA8470", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EntityDisposition other)
	{
		return default(bool);
	}

	[Token(Token = "0x600688E")]
	[Address(RVA = "0xBA8530", Offset = "0xBA7930", VA = "0x180BA8530", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600688F")]
	[Address(RVA = "0xBA8790", Offset = "0xBA7B90", VA = "0x180BA8790", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006890")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006891")]
	[Address(RVA = "0xBA8CF0", Offset = "0xBA80F0", VA = "0x180BA8CF0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006892")]
	[Address(RVA = "0xBA80D0", Offset = "0xBA74D0", VA = "0x180BA80D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006893")]
	[Address(RVA = "0xBA86F0", Offset = "0xBA7AF0", VA = "0x180BA86F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EntityDisposition other)
	{
	}

	[Token(Token = "0x6006894")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006895")]
	[Address(RVA = "0xBA8BE0", Offset = "0xBA7FE0", VA = "0x180BA8BE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
