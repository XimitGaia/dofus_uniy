using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x200039B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class KamasUpdateEvent : IMessage<KamasUpdateEvent>, IMessage, IEquatable<KamasUpdateEvent>, IDeepCloneable<KamasUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000C70")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<KamasUpdateEvent> _parser;

	[Token(Token = "0x4000C71")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C72")]
	public const int QuantityFieldNumber = 1;

	[Token(Token = "0x4000C73")]
	[FieldOffset(Offset = "0x18")]
	private long quantity_;

	[Token(Token = "0x17000809")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<KamasUpdateEvent> Parser
	{
		[Token(Token = "0x600257A")]
		[Address(RVA = "0x98A8E0", Offset = "0x989CE0", VA = "0x18098A8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700080A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600257B")]
		[Address(RVA = "0x98A830", Offset = "0x989C30", VA = "0x18098A830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700080B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600257C")]
		[Address(RVA = "0x98A930", Offset = "0x989D30", VA = "0x18098A930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700080C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Quantity
	{
		[Token(Token = "0x6002580")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x600257D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KamasUpdateEvent()
	{
	}

	[Token(Token = "0x600257E")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KamasUpdateEvent(KamasUpdateEvent other)
	{
	}

	[Token(Token = "0x600257F")]
	[Address(RVA = "0x98A5C0", Offset = "0x9899C0", VA = "0x18098A5C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public KamasUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002582")]
	[Address(RVA = "0x98A640", Offset = "0x989A40", VA = "0x18098A640", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002583")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(KamasUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002584")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002585")]
	[Address(RVA = "0x98A6D0", Offset = "0x989AD0", VA = "0x18098A6D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002586")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002587")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002588")]
	[Address(RVA = "0x98A530", Offset = "0x989930", VA = "0x18098A530", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002589")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KamasUpdateEvent other)
	{
	}

	[Token(Token = "0x600258A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600258B")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
