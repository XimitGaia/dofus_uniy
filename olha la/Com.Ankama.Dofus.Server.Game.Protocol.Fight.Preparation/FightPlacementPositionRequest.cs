using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000617")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightPlacementPositionRequest : IMessage<FightPlacementPositionRequest>, IMessage, IEquatable<FightPlacementPositionRequest>, IDeepCloneable<FightPlacementPositionRequest>, IBufferMessage
{
	[Token(Token = "0x400156A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightPlacementPositionRequest> _parser;

	[Token(Token = "0x400156B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400156C")]
	public const int CellIdFieldNumber = 1;

	[Token(Token = "0x400156D")]
	[FieldOffset(Offset = "0x18")]
	private int cellId_;

	[Token(Token = "0x400156E")]
	public const int EntityIdFieldNumber = 2;

	[Token(Token = "0x400156F")]
	[FieldOffset(Offset = "0x20")]
	private long entityId_;

	[Token(Token = "0x17000DFA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightPlacementPositionRequest> Parser
	{
		[Token(Token = "0x6004113")]
		[Address(RVA = "0xA7EB20", Offset = "0xA7DF20", VA = "0x180A7EB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DFB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004114")]
		[Address(RVA = "0xA7EA70", Offset = "0xA7DE70", VA = "0x180A7EA70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DFC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004115")]
		[Address(RVA = "0xA7EB70", Offset = "0xA7DF70", VA = "0x180A7EB70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DFD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CellId
	{
		[Token(Token = "0x6004119")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600411A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000DFE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EntityId
	{
		[Token(Token = "0x600411B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600411C")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6004116")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementPositionRequest()
	{
	}

	[Token(Token = "0x6004117")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightPlacementPositionRequest(FightPlacementPositionRequest other)
	{
	}

	[Token(Token = "0x6004118")]
	[Address(RVA = "0xA7E7E0", Offset = "0xA7DBE0", VA = "0x180A7E7E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementPositionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600411D")]
	[Address(RVA = "0xA7E870", Offset = "0xA7DC70", VA = "0x180A7E870", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600411E")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightPlacementPositionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600411F")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004120")]
	[Address(RVA = "0xA7E910", Offset = "0xA7DD10", VA = "0x180A7E910", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004121")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004122")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004123")]
	[Address(RVA = "0xA7E720", Offset = "0xA7DB20", VA = "0x180A7E720", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004124")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightPlacementPositionRequest other)
	{
	}

	[Token(Token = "0x6004125")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004126")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
