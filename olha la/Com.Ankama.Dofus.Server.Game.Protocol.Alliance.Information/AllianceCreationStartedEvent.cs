using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CAD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceCreationStartedEvent : IMessage<AllianceCreationStartedEvent>, IMessage, IEquatable<AllianceCreationStartedEvent>, IDeepCloneable<AllianceCreationStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4002EAF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceCreationStartedEvent> _parser;

	[Token(Token = "0x4002EB0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001D34")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceCreationStartedEvent> Parser
	{
		[Token(Token = "0x6008585")]
		[Address(RVA = "0xC8C270", Offset = "0xC8B670", VA = "0x180C8C270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D35")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008586")]
		[Address(RVA = "0xC8C1C0", Offset = "0xC8B5C0", VA = "0x180C8C1C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D36")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008587")]
		[Address(RVA = "0xC8C2C0", Offset = "0xC8B6C0", VA = "0x180C8C2C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008588")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceCreationStartedEvent()
	{
	}

	[Token(Token = "0x6008589")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceCreationStartedEvent(AllianceCreationStartedEvent other)
	{
	}

	[Token(Token = "0x600858A")]
	[Address(RVA = "0xC8BF60", Offset = "0xC8B360", VA = "0x180C8BF60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceCreationStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600858B")]
	[Address(RVA = "0xC8BFE0", Offset = "0xC8B3E0", VA = "0x180C8BFE0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600858C")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceCreationStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600858D")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600858E")]
	[Address(RVA = "0xC8C060", Offset = "0xC8B460", VA = "0x180C8C060", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600858F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008590")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008591")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008592")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceCreationStartedEvent other)
	{
	}

	[Token(Token = "0x6008593")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008594")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
