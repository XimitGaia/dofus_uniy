using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C9C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceLeftEvent : IMessage<AllianceLeftEvent>, IMessage, IEquatable<AllianceLeftEvent>, IDeepCloneable<AllianceLeftEvent>, IBufferMessage
{
	[Token(Token = "0x4002E82")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceLeftEvent> _parser;

	[Token(Token = "0x4002E83")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001D11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceLeftEvent> Parser
	{
		[Token(Token = "0x60084CF")]
		[Address(RVA = "0xC96C40", Offset = "0xC96040", VA = "0x180C96C40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60084D0")]
		[Address(RVA = "0xC96B90", Offset = "0xC95F90", VA = "0x180C96B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D13")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60084D1")]
		[Address(RVA = "0xC96C90", Offset = "0xC96090", VA = "0x180C96C90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60084D2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceLeftEvent()
	{
	}

	[Token(Token = "0x60084D3")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceLeftEvent(AllianceLeftEvent other)
	{
	}

	[Token(Token = "0x60084D4")]
	[Address(RVA = "0xC96930", Offset = "0xC95D30", VA = "0x180C96930", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceLeftEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60084D5")]
	[Address(RVA = "0xC969B0", Offset = "0xC95DB0", VA = "0x180C969B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60084D6")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceLeftEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60084D7")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60084D8")]
	[Address(RVA = "0xC96A30", Offset = "0xC95E30", VA = "0x180C96A30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60084D9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60084DA")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60084DB")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60084DC")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceLeftEvent other)
	{
	}

	[Token(Token = "0x60084DD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60084DE")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
