using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002D7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcGenericActionFailureEvent : IMessage<NpcGenericActionFailureEvent>, IMessage, IEquatable<NpcGenericActionFailureEvent>, IDeepCloneable<NpcGenericActionFailureEvent>, IBufferMessage
{
	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NpcGenericActionFailureEvent> _parser;

	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700065E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NpcGenericActionFailureEvent> Parser
	{
		[Token(Token = "0x6001D82")]
		[Address(RVA = "0xD28580", Offset = "0xD27980", VA = "0x180D28580")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700065F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001D83")]
		[Address(RVA = "0xD284D0", Offset = "0xD278D0", VA = "0x180D284D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000660")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001D84")]
		[Address(RVA = "0xD285D0", Offset = "0xD279D0", VA = "0x180D285D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001D85")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcGenericActionFailureEvent()
	{
	}

	[Token(Token = "0x6001D86")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcGenericActionFailureEvent(NpcGenericActionFailureEvent other)
	{
	}

	[Token(Token = "0x6001D87")]
	[Address(RVA = "0xD28270", Offset = "0xD27670", VA = "0x180D28270", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcGenericActionFailureEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001D88")]
	[Address(RVA = "0xD282F0", Offset = "0xD276F0", VA = "0x180D282F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D89")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NpcGenericActionFailureEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D8A")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D8B")]
	[Address(RVA = "0xD28370", Offset = "0xD27770", VA = "0x180D28370", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001D8C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001D8D")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001D8E")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001D8F")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NpcGenericActionFailureEvent other)
	{
	}

	[Token(Token = "0x6001D90")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001D91")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
