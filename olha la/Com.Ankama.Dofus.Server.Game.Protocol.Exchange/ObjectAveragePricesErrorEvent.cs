using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000725")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectAveragePricesErrorEvent : IMessage<ObjectAveragePricesErrorEvent>, IMessage, IEquatable<ObjectAveragePricesErrorEvent>, IDeepCloneable<ObjectAveragePricesErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4001933")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectAveragePricesErrorEvent> _parser;

	[Token(Token = "0x4001934")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001072")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectAveragePricesErrorEvent> Parser
	{
		[Token(Token = "0x6004CCD")]
		[Address(RVA = "0xAC4000", Offset = "0xAC3400", VA = "0x180AC4000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001073")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004CCE")]
		[Address(RVA = "0xAC3F50", Offset = "0xAC3350", VA = "0x180AC3F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001074")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004CCF")]
		[Address(RVA = "0xAC4050", Offset = "0xAC3450", VA = "0x180AC4050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004CD0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectAveragePricesErrorEvent()
	{
	}

	[Token(Token = "0x6004CD1")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectAveragePricesErrorEvent(ObjectAveragePricesErrorEvent other)
	{
	}

	[Token(Token = "0x6004CD2")]
	[Address(RVA = "0xAC3CF0", Offset = "0xAC30F0", VA = "0x180AC3CF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectAveragePricesErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004CD3")]
	[Address(RVA = "0xAC3D70", Offset = "0xAC3170", VA = "0x180AC3D70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CD4")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectAveragePricesErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CD5")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004CD6")]
	[Address(RVA = "0xAC3DF0", Offset = "0xAC31F0", VA = "0x180AC3DF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004CD7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004CD8")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004CD9")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004CDA")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectAveragePricesErrorEvent other)
	{
	}

	[Token(Token = "0x6004CDB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004CDC")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
