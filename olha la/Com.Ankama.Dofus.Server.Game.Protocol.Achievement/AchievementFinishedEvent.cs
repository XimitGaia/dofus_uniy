using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D21")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementFinishedEvent : IMessage<AchievementFinishedEvent>, IMessage, IEquatable<AchievementFinishedEvent>, IDeepCloneable<AchievementFinishedEvent>, IBufferMessage
{
	[Token(Token = "0x4003023")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementFinishedEvent> _parser;

	[Token(Token = "0x4003024")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4003025")]
	public const int AchievementFieldNumber = 1;

	[Token(Token = "0x4003026")]
	[FieldOffset(Offset = "0x18")]
	private AchievedAchievement achievement_;

	[Token(Token = "0x17001E2C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AchievementFinishedEvent> Parser
	{
		[Token(Token = "0x6008A3D")]
		[Address(RVA = "0xCA17B0", Offset = "0xCA0BB0", VA = "0x180CA17B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E2D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008A3E")]
		[Address(RVA = "0xCA1700", Offset = "0xCA0B00", VA = "0x180CA1700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E2E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008A3F")]
		[Address(RVA = "0xCA1900", Offset = "0xCA0D00", VA = "0x180CA1900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E2F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievedAchievement Achievement
	{
		[Token(Token = "0x6008A43")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A44")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6008A40")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementFinishedEvent()
	{
	}

	[Token(Token = "0x6008A41")]
	[Address(RVA = "0xCA1690", Offset = "0xCA0A90", VA = "0x180CA1690")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementFinishedEvent(AchievementFinishedEvent other)
	{
	}

	[Token(Token = "0x6008A42")]
	[Address(RVA = "0xCA1310", Offset = "0xCA0710", VA = "0x180CA1310", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementFinishedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008A45")]
	[Address(RVA = "0xCA13B0", Offset = "0xCA07B0", VA = "0x180CA13B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A46")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AchievementFinishedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A47")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008A48")]
	[Address(RVA = "0xCA1530", Offset = "0xCA0930", VA = "0x180CA1530", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008A49")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008A4A")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008A4B")]
	[Address(RVA = "0xCA1280", Offset = "0xCA0680", VA = "0x180CA1280", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008A4C")]
	[Address(RVA = "0xCA1460", Offset = "0xCA0860", VA = "0x180CA1460", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AchievementFinishedEvent other)
	{
	}

	[Token(Token = "0x6008A4D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008A4E")]
	[Address(RVA = "0xCA1800", Offset = "0xCA0C00", VA = "0x180CA1800", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
