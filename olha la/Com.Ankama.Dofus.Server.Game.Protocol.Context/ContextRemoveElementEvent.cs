using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x2000791")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContextRemoveElementEvent : IMessage<ContextRemoveElementEvent>, IMessage, IEquatable<ContextRemoveElementEvent>, IDeepCloneable<ContextRemoveElementEvent>, IBufferMessage
{
	[Token(Token = "0x4001A5A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContextRemoveElementEvent> _parser;

	[Token(Token = "0x4001A5B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A5C")]
	public const int ElementIdFieldNumber = 1;

	[Token(Token = "0x4001A5D")]
	[FieldOffset(Offset = "0x18")]
	private long elementId_;

	[Token(Token = "0x17001132")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContextRemoveElementEvent> Parser
	{
		[Token(Token = "0x6005082")]
		[Address(RVA = "0xAD4820", Offset = "0xAD3C20", VA = "0x180AD4820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001133")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005083")]
		[Address(RVA = "0xAD4770", Offset = "0xAD3B70", VA = "0x180AD4770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001134")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005084")]
		[Address(RVA = "0xAD4870", Offset = "0xAD3C70", VA = "0x180AD4870", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001135")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ElementId
	{
		[Token(Token = "0x6005088")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005089")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6005085")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextRemoveElementEvent()
	{
	}

	[Token(Token = "0x6005086")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextRemoveElementEvent(ContextRemoveElementEvent other)
	{
	}

	[Token(Token = "0x6005087")]
	[Address(RVA = "0xAD4500", Offset = "0xAD3900", VA = "0x180AD4500", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextRemoveElementEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600508A")]
	[Address(RVA = "0xAD4580", Offset = "0xAD3980", VA = "0x180AD4580", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600508B")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ContextRemoveElementEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600508C")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600508D")]
	[Address(RVA = "0xAD4610", Offset = "0xAD3A10", VA = "0x180AD4610", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600508E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600508F")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005090")]
	[Address(RVA = "0xAD4470", Offset = "0xAD3870", VA = "0x180AD4470", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005091")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContextRemoveElementEvent other)
	{
	}

	[Token(Token = "0x6005092")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005093")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
