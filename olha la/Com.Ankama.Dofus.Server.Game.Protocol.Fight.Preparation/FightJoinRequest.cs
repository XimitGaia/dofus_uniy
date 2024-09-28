using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000613")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightJoinRequest : IMessage<FightJoinRequest>, IMessage, IEquatable<FightJoinRequest>, IDeepCloneable<FightJoinRequest>, IBufferMessage
{
	[Token(Token = "0x400155E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightJoinRequest> _parser;

	[Token(Token = "0x400155F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001560")]
	public const int FighterIdFieldNumber = 1;

	[Token(Token = "0x4001561")]
	[FieldOffset(Offset = "0x18")]
	private long fighterId_;

	[Token(Token = "0x4001562")]
	public const int FightIdFieldNumber = 2;

	[Token(Token = "0x4001563")]
	[FieldOffset(Offset = "0x20")]
	private int fightId_;

	[Token(Token = "0x17000DF1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightJoinRequest> Parser
	{
		[Token(Token = "0x60040E5")]
		[Address(RVA = "0xA7CE90", Offset = "0xA7C290", VA = "0x180A7CE90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60040E6")]
		[Address(RVA = "0xA7CDE0", Offset = "0xA7C1E0", VA = "0x180A7CDE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60040E7")]
		[Address(RVA = "0xA7CEE0", Offset = "0xA7C2E0", VA = "0x180A7CEE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DF4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long FighterId
	{
		[Token(Token = "0x60040EB")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60040EC")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000DF5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x60040ED")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60040EE")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60040E8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightJoinRequest()
	{
	}

	[Token(Token = "0x60040E9")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightJoinRequest(FightJoinRequest other)
	{
	}

	[Token(Token = "0x60040EA")]
	[Address(RVA = "0xA7CB50", Offset = "0xA7BF50", VA = "0x180A7CB50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightJoinRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60040EF")]
	[Address(RVA = "0xA7CBE0", Offset = "0xA7BFE0", VA = "0x180A7CBE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60040F0")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightJoinRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60040F1")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60040F2")]
	[Address(RVA = "0xA7CC80", Offset = "0xA7C080", VA = "0x180A7CC80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60040F3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60040F4")]
	[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60040F5")]
	[Address(RVA = "0xA7CA90", Offset = "0xA7BE90", VA = "0x180A7CA90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60040F6")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightJoinRequest other)
	{
	}

	[Token(Token = "0x60040F7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60040F8")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
