using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AC3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonsterInGroupInformation : IMessage<MonsterInGroupInformation>, IMessage, IEquatable<MonsterInGroupInformation>, IDeepCloneable<MonsterInGroupInformation>, IBufferMessage
{
	[Token(Token = "0x4002765")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MonsterInGroupInformation> _parser;

	[Token(Token = "0x4002766")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002767")]
	public const int GidFieldNumber = 1;

	[Token(Token = "0x4002768")]
	[FieldOffset(Offset = "0x18")]
	private int gid_;

	[Token(Token = "0x4002769")]
	public const int GradeFieldNumber = 2;

	[Token(Token = "0x400276A")]
	[FieldOffset(Offset = "0x1C")]
	private int grade_;

	[Token(Token = "0x400276B")]
	public const int LevelFieldNumber = 3;

	[Token(Token = "0x400276C")]
	[FieldOffset(Offset = "0x20")]
	private int level_;

	[Token(Token = "0x400276D")]
	public const int LookFieldNumber = 4;

	[Token(Token = "0x400276E")]
	[FieldOffset(Offset = "0x28")]
	private EntityLook look_;

	[Token(Token = "0x17001895")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterInGroupInformation> Parser
	{
		[Token(Token = "0x60070BE")]
		[Address(RVA = "0xBE4CB0", Offset = "0xBE40B0", VA = "0x180BE4CB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001896")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60070BF")]
		[Address(RVA = "0xBE4C00", Offset = "0xBE4000", VA = "0x180BE4C00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001897")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60070C0")]
		[Address(RVA = "0xBE4E60", Offset = "0xBE4260", VA = "0x180BE4E60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001898")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Gid
	{
		[Token(Token = "0x60070C4")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60070C5")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001899")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Grade
	{
		[Token(Token = "0x60070C6")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60070C7")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700189A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Level
	{
		[Token(Token = "0x60070C8")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60070C9")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700189B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityLook Look
	{
		[Token(Token = "0x60070CA")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60070CB")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x60070C1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterInGroupInformation()
	{
	}

	[Token(Token = "0x60070C2")]
	[Address(RVA = "0xBE4B80", Offset = "0xBE3F80", VA = "0x180BE4B80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterInGroupInformation(MonsterInGroupInformation other)
	{
	}

	[Token(Token = "0x60070C3")]
	[Address(RVA = "0xBE47C0", Offset = "0xBE3BC0", VA = "0x180BE47C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterInGroupInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60070CC")]
	[Address(RVA = "0xBE4870", Offset = "0xBE3C70", VA = "0x180BE4870", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60070CD")]
	[Address(RVA = "0xB7FFB0", Offset = "0xB7F3B0", VA = "0x180B7FFB0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MonsterInGroupInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60070CE")]
	[Address(RVA = "0xB80030", Offset = "0xB7F430", VA = "0x180B80030", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60070CF")]
	[Address(RVA = "0xBE4A20", Offset = "0xBE3E20", VA = "0x180BE4A20", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60070D0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60070D1")]
	[Address(RVA = "0xB805F0", Offset = "0xB7F9F0", VA = "0x180B805F0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60070D2")]
	[Address(RVA = "0xBE46B0", Offset = "0xBE3AB0", VA = "0x180BE46B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60070D3")]
	[Address(RVA = "0xBE4930", Offset = "0xBE3D30", VA = "0x180BE4930", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MonsterInGroupInformation other)
	{
	}

	[Token(Token = "0x60070D4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60070D5")]
	[Address(RVA = "0xBE4D00", Offset = "0xBE4100", VA = "0x180BE4D00", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
