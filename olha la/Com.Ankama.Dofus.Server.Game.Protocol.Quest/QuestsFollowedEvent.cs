using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x20001A6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestsFollowedEvent : IMessage<QuestsFollowedEvent>, IMessage, IEquatable<QuestsFollowedEvent>, IDeepCloneable<QuestsFollowedEvent>, IBufferMessage
{
	[Token(Token = "0x4000598")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestsFollowedEvent> _parser;

	[Token(Token = "0x4000599")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400059A")]
	public const int QuestsFieldNumber = 1;

	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<QuestActive> _repeated_quests_codec;

	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<QuestActive> quests_;

	[Token(Token = "0x17000392")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestsFollowedEvent> Parser
	{
		[Token(Token = "0x60010BF")]
		[Address(RVA = "0xCD54E0", Offset = "0xCD48E0", VA = "0x180CD54E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000393")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0xCD5430", Offset = "0xCD4830", VA = "0x180CD5430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000394")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0xCD56F0", Offset = "0xCD4AF0", VA = "0x180CD56F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000395")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<QuestActive> Quests
	{
		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60010C2")]
	[Address(RVA = "0xCD5320", Offset = "0xCD4720", VA = "0x180CD5320")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestsFollowedEvent()
	{
	}

	[Token(Token = "0x60010C3")]
	[Address(RVA = "0xCD53A0", Offset = "0xCD47A0", VA = "0x180CD53A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestsFollowedEvent(QuestsFollowedEvent other)
	{
	}

	[Token(Token = "0x60010C4")]
	[Address(RVA = "0xCD4E70", Offset = "0xCD4270", VA = "0x180CD4E70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestsFollowedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60010C6")]
	[Address(RVA = "0xCD4F30", Offset = "0xCD4330", VA = "0x180CD4F30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60010C7")]
	[Address(RVA = "0xCD5010", Offset = "0xCD4410", VA = "0x180CD5010", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestsFollowedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60010C9")]
	[Address(RVA = "0xCD5120", Offset = "0xCD4520", VA = "0x180CD5120", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60010CB")]
	[Address(RVA = "0xCD5640", Offset = "0xCD4A40", VA = "0x180CD5640", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60010CC")]
	[Address(RVA = "0xCD4DD0", Offset = "0xCD41D0", VA = "0x180CD4DD0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60010CD")]
	[Address(RVA = "0xCD50A0", Offset = "0xCD44A0", VA = "0x180CD50A0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestsFollowedEvent other)
	{
	}

	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60010CF")]
	[Address(RVA = "0xCD5530", Offset = "0xCD4930", VA = "0x180CD5530", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
