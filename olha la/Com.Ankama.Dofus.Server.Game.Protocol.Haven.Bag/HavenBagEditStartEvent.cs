using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200043B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagEditStartEvent : IMessage<HavenBagEditStartEvent>, IMessage, IEquatable<HavenBagEditStartEvent>, IDeepCloneable<HavenBagEditStartEvent>, IBufferMessage
{
	[Token(Token = "0x4000EA5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagEditStartEvent> _parser;

	[Token(Token = "0x4000EA6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700098B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HavenBagEditStartEvent> Parser
	{
		[Token(Token = "0x6002C9C")]
		[Address(RVA = "0x9BA300", Offset = "0x9B9700", VA = "0x1809BA300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700098C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002C9D")]
		[Address(RVA = "0x9BA250", Offset = "0x9B9650", VA = "0x1809BA250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700098D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002C9E")]
		[Address(RVA = "0x9BA350", Offset = "0x9B9750", VA = "0x1809BA350", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002C9F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagEditStartEvent()
	{
	}

	[Token(Token = "0x6002CA0")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagEditStartEvent(HavenBagEditStartEvent other)
	{
	}

	[Token(Token = "0x6002CA1")]
	[Address(RVA = "0x9B9FF0", Offset = "0x9B93F0", VA = "0x1809B9FF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagEditStartEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002CA2")]
	[Address(RVA = "0x9BA070", Offset = "0x9B9470", VA = "0x1809BA070", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CA3")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagEditStartEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CA4")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002CA5")]
	[Address(RVA = "0x9BA0F0", Offset = "0x9B94F0", VA = "0x1809BA0F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002CA6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002CA7")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002CA8")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002CA9")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagEditStartEvent other)
	{
	}

	[Token(Token = "0x6002CAA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002CAB")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
