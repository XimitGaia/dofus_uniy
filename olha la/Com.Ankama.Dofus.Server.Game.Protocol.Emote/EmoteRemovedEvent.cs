using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote;

[Token(Token = "0x200073D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EmoteRemovedEvent : IMessage<EmoteRemovedEvent>, IMessage, IEquatable<EmoteRemovedEvent>, IDeepCloneable<EmoteRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4001976")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EmoteRemovedEvent> _parser;

	[Token(Token = "0x4001977")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001978")]
	public const int EmoteIdFieldNumber = 1;

	[Token(Token = "0x4001979")]
	[FieldOffset(Offset = "0x18")]
	private int emoteId_;

	[Token(Token = "0x170010A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EmoteRemovedEvent> Parser
	{
		[Token(Token = "0x6004DB3")]
		[Address(RVA = "0xAB7B90", Offset = "0xAB6F90", VA = "0x180AB7B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004DB4")]
		[Address(RVA = "0xAB7AE0", Offset = "0xAB6EE0", VA = "0x180AB7AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004DB5")]
		[Address(RVA = "0xAB7BE0", Offset = "0xAB6FE0", VA = "0x180AB7BE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EmoteId
	{
		[Token(Token = "0x6004DB9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004DBA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004DB6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmoteRemovedEvent()
	{
	}

	[Token(Token = "0x6004DB7")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EmoteRemovedEvent(EmoteRemovedEvent other)
	{
	}

	[Token(Token = "0x6004DB8")]
	[Address(RVA = "0xAB7870", Offset = "0xAB6C70", VA = "0x180AB7870", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EmoteRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004DBB")]
	[Address(RVA = "0xAB78F0", Offset = "0xAB6CF0", VA = "0x180AB78F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004DBC")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EmoteRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004DBD")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004DBE")]
	[Address(RVA = "0xAB7980", Offset = "0xAB6D80", VA = "0x180AB7980", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004DBF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004DC0")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004DC1")]
	[Address(RVA = "0xAB77E0", Offset = "0xAB6BE0", VA = "0x180AB77E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004DC2")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EmoteRemovedEvent other)
	{
	}

	[Token(Token = "0x6004DC3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004DC4")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
