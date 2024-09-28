using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D23")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementFinishedInformationEvent : IMessage<AchievementFinishedInformationEvent>, IMessage, IEquatable<AchievementFinishedInformationEvent>, IDeepCloneable<AchievementFinishedInformationEvent>, IBufferMessage
{
	[Token(Token = "0x4003028")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementFinishedInformationEvent> _parser;

	[Token(Token = "0x4003029")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400302A")]
	public const int AchievementFieldNumber = 1;

	[Token(Token = "0x400302B")]
	[FieldOffset(Offset = "0x18")]
	private AchievedAchievement achievement_;

	[Token(Token = "0x400302C")]
	public const int PlayerNameFieldNumber = 2;

	[Token(Token = "0x400302D")]
	[FieldOffset(Offset = "0x20")]
	private string playerName_;

	[Token(Token = "0x400302E")]
	public const int PlayerIdFieldNumber = 3;

	[Token(Token = "0x400302F")]
	[FieldOffset(Offset = "0x28")]
	private long playerId_;

	[Token(Token = "0x17001E30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AchievementFinishedInformationEvent> Parser
	{
		[Token(Token = "0x6008A53")]
		[Address(RVA = "0xCA20C0", Offset = "0xCA14C0", VA = "0x180CA20C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E31")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008A54")]
		[Address(RVA = "0xCA2010", Offset = "0xCA1410", VA = "0x180CA2010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E32")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008A55")]
		[Address(RVA = "0xCA2260", Offset = "0xCA1660", VA = "0x180CA2260", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E33")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievedAchievement Achievement
	{
		[Token(Token = "0x6008A59")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A5A")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001E34")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PlayerName
	{
		[Token(Token = "0x6008A5B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A5C")]
		[Address(RVA = "0xCA2340", Offset = "0xCA1740", VA = "0x180CA2340")]
		set
		{
		}
	}

	[Token(Token = "0x17001E35")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x6008A5D")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008A5E")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6008A56")]
	[Address(RVA = "0xCA1EF0", Offset = "0xCA12F0", VA = "0x180CA1EF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementFinishedInformationEvent()
	{
	}

	[Token(Token = "0x6008A57")]
	[Address(RVA = "0xCA1F40", Offset = "0xCA1340", VA = "0x180CA1F40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementFinishedInformationEvent(AchievementFinishedInformationEvent other)
	{
	}

	[Token(Token = "0x6008A58")]
	[Address(RVA = "0xCA1AD0", Offset = "0xCA0ED0", VA = "0x180CA1AD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementFinishedInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008A5F")]
	[Address(RVA = "0xCA1BD0", Offset = "0xCA0FD0", VA = "0x180CA1BD0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A60")]
	[Address(RVA = "0xBB0270", Offset = "0xBAF670", VA = "0x180BB0270", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievementFinishedInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A61")]
	[Address(RVA = "0xBB02F0", Offset = "0xBAF6F0", VA = "0x180BB02F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008A62")]
	[Address(RVA = "0xCA1D90", Offset = "0xCA1190", VA = "0x180CA1D90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008A63")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008A64")]
	[Address(RVA = "0xBB0AA0", Offset = "0xBAFEA0", VA = "0x180BB0AA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008A65")]
	[Address(RVA = "0xCA19E0", Offset = "0xCA0DE0", VA = "0x180CA19E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008A66")]
	[Address(RVA = "0xCA1CA0", Offset = "0xCA10A0", VA = "0x180CA1CA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AchievementFinishedInformationEvent other)
	{
	}

	[Token(Token = "0x6008A67")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008A68")]
	[Address(RVA = "0xCA2110", Offset = "0xCA1510", VA = "0x180CA2110", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
