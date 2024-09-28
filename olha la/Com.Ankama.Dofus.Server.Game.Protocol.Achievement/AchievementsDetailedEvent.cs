using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D1D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementsDetailedEvent : IMessage<AchievementsDetailedEvent>, IMessage, IEquatable<AchievementsDetailedEvent>, IDeepCloneable<AchievementsDetailedEvent>, IBufferMessage
{
	[Token(Token = "0x4003017")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementsDetailedEvent> _parser;

	[Token(Token = "0x4003018")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4003019")]
	public const int AchievementsFieldNumber = 1;

	[Token(Token = "0x400301A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Achievement> _repeated_achievements_codec;

	[Token(Token = "0x400301B")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Achievement> achievements_;

	[Token(Token = "0x17001E24")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AchievementsDetailedEvent> Parser
	{
		[Token(Token = "0x6008A13")]
		[Address(RVA = "0xCA7070", Offset = "0xCA6470", VA = "0x180CA7070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E25")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008A14")]
		[Address(RVA = "0xCA6FC0", Offset = "0xCA63C0", VA = "0x180CA6FC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E26")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008A15")]
		[Address(RVA = "0xCA7280", Offset = "0xCA6680", VA = "0x180CA7280", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E27")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Achievement> Achievements
	{
		[Token(Token = "0x6008A19")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008A16")]
	[Address(RVA = "0xCA6EB0", Offset = "0xCA62B0", VA = "0x180CA6EB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementsDetailedEvent()
	{
	}

	[Token(Token = "0x6008A17")]
	[Address(RVA = "0xCA6F30", Offset = "0xCA6330", VA = "0x180CA6F30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementsDetailedEvent(AchievementsDetailedEvent other)
	{
	}

	[Token(Token = "0x6008A18")]
	[Address(RVA = "0xCA6A00", Offset = "0xCA5E00", VA = "0x180CA6A00", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementsDetailedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008A1A")]
	[Address(RVA = "0xCA6B50", Offset = "0xCA5F50", VA = "0x180CA6B50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A1B")]
	[Address(RVA = "0xCA6AC0", Offset = "0xCA5EC0", VA = "0x180CA6AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievementsDetailedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A1C")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008A1D")]
	[Address(RVA = "0xCA6CB0", Offset = "0xCA60B0", VA = "0x180CA6CB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008A1E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008A1F")]
	[Address(RVA = "0xCA71D0", Offset = "0xCA65D0", VA = "0x180CA71D0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008A20")]
	[Address(RVA = "0xCA6960", Offset = "0xCA5D60", VA = "0x180CA6960", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008A21")]
	[Address(RVA = "0xCA6C30", Offset = "0xCA6030", VA = "0x180CA6C30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AchievementsDetailedEvent other)
	{
	}

	[Token(Token = "0x6008A22")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008A23")]
	[Address(RVA = "0xCA70C0", Offset = "0xCA64C0", VA = "0x180CA70C0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
