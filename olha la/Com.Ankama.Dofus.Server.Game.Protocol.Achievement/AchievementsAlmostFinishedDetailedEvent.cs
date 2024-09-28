using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D1F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementsAlmostFinishedDetailedEvent : IMessage<AchievementsAlmostFinishedDetailedEvent>, IMessage, IEquatable<AchievementsAlmostFinishedDetailedEvent>, IDeepCloneable<AchievementsAlmostFinishedDetailedEvent>, IBufferMessage
{
	[Token(Token = "0x400301D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementsAlmostFinishedDetailedEvent> _parser;

	[Token(Token = "0x400301E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400301F")]
	public const int AlmostFinishedAchievementsFieldNumber = 1;

	[Token(Token = "0x4003020")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Achievement> _repeated_almostFinishedAchievements_codec;

	[Token(Token = "0x4003021")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Achievement> almostFinishedAchievements_;

	[Token(Token = "0x17001E28")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AchievementsAlmostFinishedDetailedEvent> Parser
	{
		[Token(Token = "0x6008A28")]
		[Address(RVA = "0xCA6230", Offset = "0xCA5630", VA = "0x180CA6230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E29")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008A29")]
		[Address(RVA = "0xCA6180", Offset = "0xCA5580", VA = "0x180CA6180")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E2A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008A2A")]
		[Address(RVA = "0xCA6440", Offset = "0xCA5840", VA = "0x180CA6440", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E2B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Achievement> AlmostFinishedAchievements
	{
		[Token(Token = "0x6008A2E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008A2B")]
	[Address(RVA = "0xCA6070", Offset = "0xCA5470", VA = "0x180CA6070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsAlmostFinishedDetailedEvent()
	{
	}

	[Token(Token = "0x6008A2C")]
	[Address(RVA = "0xCA60F0", Offset = "0xCA54F0", VA = "0x180CA60F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementsAlmostFinishedDetailedEvent(AchievementsAlmostFinishedDetailedEvent other)
	{
	}

	[Token(Token = "0x6008A2D")]
	[Address(RVA = "0xCA5BC0", Offset = "0xCA4FC0", VA = "0x180CA5BC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsAlmostFinishedDetailedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008A2F")]
	[Address(RVA = "0xCA5D10", Offset = "0xCA5110", VA = "0x180CA5D10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A30")]
	[Address(RVA = "0xCA5C80", Offset = "0xCA5080", VA = "0x180CA5C80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievementsAlmostFinishedDetailedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A31")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008A32")]
	[Address(RVA = "0xCA5E70", Offset = "0xCA5270", VA = "0x180CA5E70", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008A33")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008A34")]
	[Address(RVA = "0xCA6390", Offset = "0xCA5790", VA = "0x180CA6390", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008A35")]
	[Address(RVA = "0xCA5B20", Offset = "0xCA4F20", VA = "0x180CA5B20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008A36")]
	[Address(RVA = "0xCA5DF0", Offset = "0xCA51F0", VA = "0x180CA5DF0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AchievementsAlmostFinishedDetailedEvent other)
	{
	}

	[Token(Token = "0x6008A37")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008A38")]
	[Address(RVA = "0xCA6280", Offset = "0xCA5680", VA = "0x180CA6280", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
