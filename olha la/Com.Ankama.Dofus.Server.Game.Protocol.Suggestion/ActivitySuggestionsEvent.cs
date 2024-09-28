using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Suggestion;

[Token(Token = "0x20000FB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActivitySuggestionsEvent : IMessage<ActivitySuggestionsEvent>, IMessage, IEquatable<ActivitySuggestionsEvent>, IDeepCloneable<ActivitySuggestionsEvent>, IBufferMessage
{
	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ActivitySuggestionsEvent> _parser;

	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000351")]
	public const int LockedActivitiesFieldNumber = 1;

	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_lockedActivities_codec;

	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> lockedActivities_;

	[Token(Token = "0x4000354")]
	public const int UnlockedActivitiesFieldNumber = 2;

	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_unlockedActivities_codec;

	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> unlockedActivities_;

	[Token(Token = "0x1700020D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ActivitySuggestionsEvent> Parser
	{
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xA54B30", Offset = "0xA53F30", VA = "0x180A54B30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xA54A80", Offset = "0xA53E80", VA = "0x180A54A80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xA54DC0", Offset = "0xA541C0", VA = "0x180A54DC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000210")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> LockedActivities
	{
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000211")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> UnlockedActivities
	{
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60009BA")]
	[Address(RVA = "0xA54920", Offset = "0xA53D20", VA = "0x180A54920")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ActivitySuggestionsEvent()
	{
	}

	[Token(Token = "0x60009BB")]
	[Address(RVA = "0xA549D0", Offset = "0xA53DD0", VA = "0x180A549D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivitySuggestionsEvent(ActivitySuggestionsEvent other)
	{
	}

	[Token(Token = "0x60009BC")]
	[Address(RVA = "0xA54440", Offset = "0xA53840", VA = "0x180A54440", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivitySuggestionsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60009BF")]
	[Address(RVA = "0xA54520", Offset = "0xA53920", VA = "0x180A54520", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60009C0")]
	[Address(RVA = "0xA54610", Offset = "0xA53A10", VA = "0x180A54610", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ActivitySuggestionsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60009C2")]
	[Address(RVA = "0xA54760", Offset = "0xA53B60", VA = "0x180A54760", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60009C4")]
	[Address(RVA = "0xA54CE0", Offset = "0xA540E0", VA = "0x180A54CE0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60009C5")]
	[Address(RVA = "0xA54360", Offset = "0xA53760", VA = "0x180A54360", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60009C6")]
	[Address(RVA = "0xA546C0", Offset = "0xA53AC0", VA = "0x180A546C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ActivitySuggestionsEvent other)
	{
	}

	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60009C8")]
	[Address(RVA = "0xA54B80", Offset = "0xA53F80", VA = "0x180A54B80", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
