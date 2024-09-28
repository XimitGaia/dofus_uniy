using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D33")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievedAchievement : IMessage<AchievedAchievement>, IMessage, IEquatable<AchievedAchievement>, IDeepCloneable<AchievedAchievement>, IBufferMessage
{
	[Token(Token = "0x400305B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievedAchievement> _parser;

	[Token(Token = "0x400305C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400305D")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x400305E")]
	public const int AchievementIdFieldNumber = 1;

	[Token(Token = "0x400305F")]
	[FieldOffset(Offset = "0x1C")]
	private int achievementId_;

	[Token(Token = "0x4003060")]
	public const int AchievedByFieldNumber = 2;

	[Token(Token = "0x4003061")]
	[FieldOffset(Offset = "0x20")]
	private long achievedBy_;

	[Token(Token = "0x4003062")]
	public const int FinishedLevelFieldNumber = 3;

	[Token(Token = "0x4003063")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int FinishedLevelDefaultValue;

	[Token(Token = "0x4003064")]
	[FieldOffset(Offset = "0x28")]
	private int finishedLevel_;

	[Token(Token = "0x4003065")]
	public const int PioneerRankFieldNumber = 4;

	[Token(Token = "0x4003066")]
	[FieldOffset(Offset = "0x2C")]
	private int pioneerRank_;

	[Token(Token = "0x17001E53")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AchievedAchievement> Parser
	{
		[Token(Token = "0x6008AF9")]
		[Address(RVA = "0xCBAE50", Offset = "0xCBA250", VA = "0x180CBAE50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E54")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008AFA")]
		[Address(RVA = "0xCBAD30", Offset = "0xCBA130", VA = "0x180CBAD30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E55")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008AFB")]
		[Address(RVA = "0xCBB0B0", Offset = "0xCBA4B0", VA = "0x180CBB0B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E56")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AchievementId
	{
		[Token(Token = "0x6008AFF")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008B00")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001E57")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AchievedBy
	{
		[Token(Token = "0x6008B01")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008B02")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001E58")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FinishedLevel
	{
		[Token(Token = "0x6008B03")]
		[Address(RVA = "0xCBADE0", Offset = "0xCBA1E0", VA = "0x180CBADE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008B04")]
		[Address(RVA = "0xA0A2B0", Offset = "0xA096B0", VA = "0x180A0A2B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001E59")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasFinishedLevel
	{
		[Token(Token = "0x6008B05")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001E5A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PioneerRank
	{
		[Token(Token = "0x6008B07")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008B08")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x6008AFC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievedAchievement()
	{
	}

	[Token(Token = "0x6008AFD")]
	[Address(RVA = "0xCBACC0", Offset = "0xCBA0C0", VA = "0x180CBACC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievedAchievement(AchievedAchievement other)
	{
	}

	[Token(Token = "0x6008AFE")]
	[Address(RVA = "0xCBA7C0", Offset = "0xCB9BC0", VA = "0x180CBA7C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievedAchievement Clone()
	{
		return null;
	}

	[Token(Token = "0x6008B06")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFinishedLevel()
	{
	}

	[Token(Token = "0x6008B09")]
	[Address(RVA = "0xCBA8F0", Offset = "0xCB9CF0", VA = "0x180CBA8F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B0A")]
	[Address(RVA = "0xCBA860", Offset = "0xCB9C60", VA = "0x180CBA860", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievedAchievement other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B0B")]
	[Address(RVA = "0xCBA9C0", Offset = "0xCB9DC0", VA = "0x180CBA9C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008B0C")]
	[Address(RVA = "0xCBAB50", Offset = "0xCB9F50", VA = "0x180CBAB50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008B0D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008B0E")]
	[Address(RVA = "0xCBAFA0", Offset = "0xCBA3A0", VA = "0x180CBAFA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008B0F")]
	[Address(RVA = "0xCBA660", Offset = "0xCB9A60", VA = "0x180CBA660", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008B10")]
	[Address(RVA = "0xCBAAD0", Offset = "0xCB9ED0", VA = "0x180CBAAD0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AchievedAchievement other)
	{
	}

	[Token(Token = "0x6008B11")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008B12")]
	[Address(RVA = "0xCBAEA0", Offset = "0xCBA2A0", VA = "0x180CBAEA0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
