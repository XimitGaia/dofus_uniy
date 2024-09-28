using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B54")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SequenceNumberEvent : IMessage<SequenceNumberEvent>, IMessage, IEquatable<SequenceNumberEvent>, IDeepCloneable<SequenceNumberEvent>, IBufferMessage
{
	[Token(Token = "0x4002A61")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SequenceNumberEvent> _parser;

	[Token(Token = "0x4002A62")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001A57")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SequenceNumberEvent> Parser
	{
		[Token(Token = "0x6007780")]
		[Address(RVA = "0xC252F0", Offset = "0xC246F0", VA = "0x180C252F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A58")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007781")]
		[Address(RVA = "0xC25240", Offset = "0xC24640", VA = "0x180C25240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A59")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007782")]
		[Address(RVA = "0xC25340", Offset = "0xC24740", VA = "0x180C25340", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007783")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceNumberEvent()
	{
	}

	[Token(Token = "0x6007784")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceNumberEvent(SequenceNumberEvent other)
	{
	}

	[Token(Token = "0x6007785")]
	[Address(RVA = "0xC24FE0", Offset = "0xC243E0", VA = "0x180C24FE0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SequenceNumberEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007786")]
	[Address(RVA = "0xC25060", Offset = "0xC24460", VA = "0x180C25060", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007787")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SequenceNumberEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007788")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007789")]
	[Address(RVA = "0xC250E0", Offset = "0xC244E0", VA = "0x180C250E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600778A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600778B")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600778C")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600778D")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SequenceNumberEvent other)
	{
	}

	[Token(Token = "0x600778E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600778F")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
