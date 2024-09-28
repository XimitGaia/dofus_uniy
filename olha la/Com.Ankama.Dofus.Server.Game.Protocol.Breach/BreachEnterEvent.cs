using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008F7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachEnterEvent : IMessage<BreachEnterEvent>, IMessage, IEquatable<BreachEnterEvent>, IDeepCloneable<BreachEnterEvent>, IBufferMessage
{
	[Token(Token = "0x4001EB8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachEnterEvent> _parser;

	[Token(Token = "0x4001EB9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EBA")]
	public const int OwnerFieldNumber = 1;

	[Token(Token = "0x4001EBB")]
	[FieldOffset(Offset = "0x18")]
	private long owner_;

	[Token(Token = "0x17001416")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachEnterEvent> Parser
	{
		[Token(Token = "0x6005EDB")]
		[Address(RVA = "0xB4F910", Offset = "0xB4ED10", VA = "0x180B4F910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001417")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005EDC")]
		[Address(RVA = "0xB4F860", Offset = "0xB4EC60", VA = "0x180B4F860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001418")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005EDD")]
		[Address(RVA = "0xB4F960", Offset = "0xB4ED60", VA = "0x180B4F960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001419")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Owner
	{
		[Token(Token = "0x6005EE1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005EE2")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6005EDE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachEnterEvent()
	{
	}

	[Token(Token = "0x6005EDF")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachEnterEvent(BreachEnterEvent other)
	{
	}

	[Token(Token = "0x6005EE0")]
	[Address(RVA = "0xB4F5F0", Offset = "0xB4E9F0", VA = "0x180B4F5F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachEnterEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005EE3")]
	[Address(RVA = "0xB4F670", Offset = "0xB4EA70", VA = "0x180B4F670", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005EE4")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachEnterEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005EE5")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005EE6")]
	[Address(RVA = "0xB4F700", Offset = "0xB4EB00", VA = "0x180B4F700", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005EE7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005EE8")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005EE9")]
	[Address(RVA = "0xB4F560", Offset = "0xB4E960", VA = "0x180B4F560", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005EEA")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BreachEnterEvent other)
	{
	}

	[Token(Token = "0x6005EEB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005EEC")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
