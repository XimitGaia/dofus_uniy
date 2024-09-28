using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x20001A4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestStepInformationEvent : IMessage<QuestStepInformationEvent>, IMessage, IEquatable<QuestStepInformationEvent>, IDeepCloneable<QuestStepInformationEvent>, IBufferMessage
{
	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestStepInformationEvent> _parser;

	[Token(Token = "0x4000590")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4000592")]
	public const int InformationFieldNumber = 1;

	[Token(Token = "0x4000593")]
	[FieldOffset(Offset = "0x20")]
	private QuestActive information_;

	[Token(Token = "0x4000594")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x8")]
	private static readonly long PlayerIdDefaultValue;

	[Token(Token = "0x4000596")]
	[FieldOffset(Offset = "0x28")]
	private long playerId_;

	[Token(Token = "0x1700038C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestStepInformationEvent> Parser
	{
		[Token(Token = "0x60010A5")]
		[Address(RVA = "0xCD4520", Offset = "0xCD3920", VA = "0x180CD4520")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700038D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0xCD4470", Offset = "0xCD3870", VA = "0x180CD4470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700038E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60010A7")]
		[Address(RVA = "0xCD47D0", Offset = "0xCD3BD0", VA = "0x180CD47D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700038F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestActive Information
	{
		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x17000390")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x60010AD")]
		[Address(RVA = "0xCD4570", Offset = "0xCD3970", VA = "0x180CD4570")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60010AE")]
		[Address(RVA = "0x960DE0", Offset = "0x9601E0", VA = "0x180960DE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000391")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPlayerId
	{
		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60010A8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStepInformationEvent()
	{
	}

	[Token(Token = "0x60010A9")]
	[Address(RVA = "0xCD42C0", Offset = "0xCD36C0", VA = "0x180CD42C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStepInformationEvent(QuestStepInformationEvent other)
	{
	}

	[Token(Token = "0x60010AA")]
	[Address(RVA = "0xCD3CC0", Offset = "0xCD30C0", VA = "0x180CD3CC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestStepInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearPlayerId()
	{
	}

	[Token(Token = "0x60010B1")]
	[Address(RVA = "0xCD3D20", Offset = "0xCD3120", VA = "0x180CD3D20", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60010B2")]
	[Address(RVA = "0xCD3DF0", Offset = "0xCD31F0", VA = "0x180CD3DF0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestStepInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60010B3")]
	[Address(RVA = "0xCD3E80", Offset = "0xCD3280", VA = "0x180CD3E80", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60010B4")]
	[Address(RVA = "0xCD4150", Offset = "0xCD3550", VA = "0x180CD4150", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60010B6")]
	[Address(RVA = "0xCD4700", Offset = "0xCD3B00", VA = "0x180CD4700", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60010B7")]
	[Address(RVA = "0xCD3BB0", Offset = "0xCD2FB0", VA = "0x180CD3BB0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60010B8")]
	[Address(RVA = "0xCD3F60", Offset = "0xCD3360", VA = "0x180CD3F60", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestStepInformationEvent other)
	{
	}

	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60010BA")]
	[Address(RVA = "0xCD45E0", Offset = "0xCD39E0", VA = "0x180CD45E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
