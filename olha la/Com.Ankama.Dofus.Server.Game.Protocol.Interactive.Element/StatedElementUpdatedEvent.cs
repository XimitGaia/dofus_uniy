using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element;

[Token(Token = "0x20003EE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class StatedElementUpdatedEvent : IMessage<StatedElementUpdatedEvent>, IMessage, IEquatable<StatedElementUpdatedEvent>, IDeepCloneable<StatedElementUpdatedEvent>, IBufferMessage
{
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<StatedElementUpdatedEvent> _parser;

	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D8F")]
	public const int StatedElementFieldNumber = 1;

	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0x18")]
	private StatedElement statedElement_;

	[Token(Token = "0x170008CD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<StatedElementUpdatedEvent> Parser
	{
		[Token(Token = "0x600292F")]
		[Address(RVA = "0x9AA9D0", Offset = "0x9A9DD0", VA = "0x1809AA9D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008CE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002930")]
		[Address(RVA = "0x9AA920", Offset = "0x9A9D20", VA = "0x1809AA920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008CF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002931")]
		[Address(RVA = "0x9AAB20", Offset = "0x9A9F20", VA = "0x1809AAB20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatedElement StatedElement
	{
		[Token(Token = "0x6002935")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002936")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002932")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatedElementUpdatedEvent()
	{
	}

	[Token(Token = "0x6002933")]
	[Address(RVA = "0x9AA8B0", Offset = "0x9A9CB0", VA = "0x1809AA8B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatedElementUpdatedEvent(StatedElementUpdatedEvent other)
	{
	}

	[Token(Token = "0x6002934")]
	[Address(RVA = "0x9AA530", Offset = "0x9A9930", VA = "0x1809AA530", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StatedElementUpdatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002937")]
	[Address(RVA = "0x9AA5D0", Offset = "0x9A99D0", VA = "0x1809AA5D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002938")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StatedElementUpdatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002939")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600293A")]
	[Address(RVA = "0x9AA750", Offset = "0x9A9B50", VA = "0x1809AA750", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600293B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600293C")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600293D")]
	[Address(RVA = "0x9AA4A0", Offset = "0x9A98A0", VA = "0x1809AA4A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600293E")]
	[Address(RVA = "0x9AA680", Offset = "0x9A9A80", VA = "0x1809AA680", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(StatedElementUpdatedEvent other)
	{
	}

	[Token(Token = "0x600293F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002940")]
	[Address(RVA = "0x9AAA20", Offset = "0x9A9E20", VA = "0x1809AAA20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
