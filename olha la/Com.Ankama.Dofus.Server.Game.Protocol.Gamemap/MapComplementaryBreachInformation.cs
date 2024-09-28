using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200054C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapComplementaryBreachInformation : IMessage<MapComplementaryBreachInformation>, IMessage, IEquatable<MapComplementaryBreachInformation>, IDeepCloneable<MapComplementaryBreachInformation>, IBufferMessage
{
	[Token(Token = "0x4001224")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapComplementaryBreachInformation> _parser;

	[Token(Token = "0x4001225")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001226")]
	public const int FloorFieldNumber = 1;

	[Token(Token = "0x4001227")]
	[FieldOffset(Offset = "0x18")]
	private int floor_;

	[Token(Token = "0x4001228")]
	public const int RoomFieldNumber = 2;

	[Token(Token = "0x4001229")]
	[FieldOffset(Offset = "0x1C")]
	private int room_;

	[Token(Token = "0x400122A")]
	public const int InfinityModeFieldNumber = 3;

	[Token(Token = "0x400122B")]
	[FieldOffset(Offset = "0x20")]
	private int infinityMode_;

	[Token(Token = "0x400122C")]
	public const int BranchesFieldNumber = 4;

	[Token(Token = "0x400122D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<BreachBranch> _repeated_branches_codec;

	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<BreachBranch> branches_;

	[Token(Token = "0x17000BF2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapComplementaryBreachInformation> Parser
	{
		[Token(Token = "0x600383C")]
		[Address(RVA = "0xA035B0", Offset = "0xA029B0", VA = "0x180A035B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BF3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600383D")]
		[Address(RVA = "0xA03500", Offset = "0xA02900", VA = "0x180A03500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BF4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600383E")]
		[Address(RVA = "0xA03880", Offset = "0xA02C80", VA = "0x180A03880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BF5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Floor
	{
		[Token(Token = "0x6003842")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003843")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Room
	{
		[Token(Token = "0x6003844")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int InfinityMode
	{
		[Token(Token = "0x6003846")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003847")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BreachBranch> Branches
	{
		[Token(Token = "0x6003848")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600383F")]
	[Address(RVA = "0xA033E0", Offset = "0xA027E0", VA = "0x180A033E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryBreachInformation()
	{
	}

	[Token(Token = "0x6003840")]
	[Address(RVA = "0xA03460", Offset = "0xA02860", VA = "0x180A03460")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryBreachInformation(MapComplementaryBreachInformation other)
	{
	}

	[Token(Token = "0x6003841")]
	[Address(RVA = "0xA02E10", Offset = "0xA02210", VA = "0x180A02E10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryBreachInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6003849")]
	[Address(RVA = "0xA02F90", Offset = "0xA02390", VA = "0x180A02F90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600384A")]
	[Address(RVA = "0xA02EE0", Offset = "0xA022E0", VA = "0x180A02EE0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapComplementaryBreachInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600384B")]
	[Address(RVA = "0xA03080", Offset = "0xA02480", VA = "0x180A03080", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600384C")]
	[Address(RVA = "0xA031E0", Offset = "0xA025E0", VA = "0x180A031E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600384D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600384E")]
	[Address(RVA = "0xA03770", Offset = "0xA02B70", VA = "0x180A03770", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600384F")]
	[Address(RVA = "0xA02CE0", Offset = "0xA020E0", VA = "0x180A02CE0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003850")]
	[Address(RVA = "0xA03140", Offset = "0xA02540", VA = "0x180A03140", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapComplementaryBreachInformation other)
	{
	}

	[Token(Token = "0x6003851")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003852")]
	[Address(RVA = "0xA03600", Offset = "0xA02A00", VA = "0x180A03600", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
