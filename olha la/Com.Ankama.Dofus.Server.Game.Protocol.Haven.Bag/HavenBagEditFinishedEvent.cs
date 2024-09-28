using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200043D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagEditFinishedEvent : IMessage<HavenBagEditFinishedEvent>, IMessage, IEquatable<HavenBagEditFinishedEvent>, IDeepCloneable<HavenBagEditFinishedEvent>, IBufferMessage
{
	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagEditFinishedEvent> _parser;

	[Token(Token = "0x4000EA9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700098E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagEditFinishedEvent> Parser
	{
		[Token(Token = "0x6002CB0")]
		[Address(RVA = "0x9B9A80", Offset = "0x9B8E80", VA = "0x1809B9A80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700098F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002CB1")]
		[Address(RVA = "0x9B99D0", Offset = "0x9B8DD0", VA = "0x1809B99D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000990")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002CB2")]
		[Address(RVA = "0x9B9AD0", Offset = "0x9B8ED0", VA = "0x1809B9AD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002CB3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagEditFinishedEvent()
	{
	}

	[Token(Token = "0x6002CB4")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagEditFinishedEvent(HavenBagEditFinishedEvent other)
	{
	}

	[Token(Token = "0x6002CB5")]
	[Address(RVA = "0x9B9770", Offset = "0x9B8B70", VA = "0x1809B9770", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagEditFinishedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002CB6")]
	[Address(RVA = "0x9B97F0", Offset = "0x9B8BF0", VA = "0x1809B97F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CB7")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagEditFinishedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CB8")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002CB9")]
	[Address(RVA = "0x9B9870", Offset = "0x9B8C70", VA = "0x1809B9870", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002CBA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002CBB")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002CBC")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002CBD")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagEditFinishedEvent other)
	{
	}

	[Token(Token = "0x6002CBE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002CBF")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
