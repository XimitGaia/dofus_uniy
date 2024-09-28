using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D19")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementsEvent : IMessage<AchievementsEvent>, IMessage, IEquatable<AchievementsEvent>, IDeepCloneable<AchievementsEvent>, IBufferMessage
{
	[Token(Token = "0x400300C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementsEvent> _parser;

	[Token(Token = "0x400300D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400300E")]
	public const int AchievedAchievementsFieldNumber = 1;

	[Token(Token = "0x400300F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<AchievedAchievement> _repeated_achievedAchievements_codec;

	[Token(Token = "0x4003010")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<AchievedAchievement> achievedAchievements_;

	[Token(Token = "0x17001E1C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AchievementsEvent> Parser
	{
		[Token(Token = "0x60089E8")]
		[Address(RVA = "0xCA7F50", Offset = "0xCA7350", VA = "0x180CA7F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E1D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60089E9")]
		[Address(RVA = "0xCA7EA0", Offset = "0xCA72A0", VA = "0x180CA7EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E1E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60089EA")]
		[Address(RVA = "0xCA8160", Offset = "0xCA7560", VA = "0x180CA8160", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E1F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<AchievedAchievement> AchievedAchievements
	{
		[Token(Token = "0x60089EE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60089EB")]
	[Address(RVA = "0xCA7E20", Offset = "0xCA7220", VA = "0x180CA7E20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsEvent()
	{
	}

	[Token(Token = "0x60089EC")]
	[Address(RVA = "0xCA7D90", Offset = "0xCA7190", VA = "0x180CA7D90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsEvent(AchievementsEvent other)
	{
	}

	[Token(Token = "0x60089ED")]
	[Address(RVA = "0xCA78E0", Offset = "0xCA6CE0", VA = "0x180CA78E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60089EF")]
	[Address(RVA = "0xCA79A0", Offset = "0xCA6DA0", VA = "0x180CA79A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60089F0")]
	[Address(RVA = "0xCA7A80", Offset = "0xCA6E80", VA = "0x180CA7A80", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AchievementsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60089F1")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60089F2")]
	[Address(RVA = "0xCA7B90", Offset = "0xCA6F90", VA = "0x180CA7B90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60089F3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60089F4")]
	[Address(RVA = "0xCA80B0", Offset = "0xCA74B0", VA = "0x180CA80B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60089F5")]
	[Address(RVA = "0xCA7840", Offset = "0xCA6C40", VA = "0x180CA7840", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60089F6")]
	[Address(RVA = "0xCA7B10", Offset = "0xCA6F10", VA = "0x180CA7B10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AchievementsEvent other)
	{
	}

	[Token(Token = "0x60089F7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60089F8")]
	[Address(RVA = "0xCA7FA0", Offset = "0xCA73A0", VA = "0x180CA7FA0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
