using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x20002A0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyNameUpdateEvent : IMessage<PartyNameUpdateEvent>, IMessage, IEquatable<PartyNameUpdateEvent>, IDeepCloneable<PartyNameUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000936")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyNameUpdateEvent> _parser;

	[Token(Token = "0x4000937")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000938")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000939")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x400093A")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x400093B")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x170005E1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyNameUpdateEvent> Parser
	{
		[Token(Token = "0x6001B4E")]
		[Address(RVA = "0xD16740", Offset = "0xD15B40", VA = "0x180D16740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0xD16690", Offset = "0xD15A90", VA = "0x180D16690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001B50")]
		[Address(RVA = "0xD16860", Offset = "0xD15C60", VA = "0x180D16860", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001B54")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B55")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170005E5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6001B56")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B57")]
		[Address(RVA = "0xD16940", Offset = "0xD15D40", VA = "0x180D16940")]
		set
		{
		}
	}

	[Token(Token = "0x6001B51")]
	[Address(RVA = "0xD16590", Offset = "0xD15990", VA = "0x180D16590")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyNameUpdateEvent()
	{
	}

	[Token(Token = "0x6001B52")]
	[Address(RVA = "0xD165E0", Offset = "0xD159E0", VA = "0x180D165E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyNameUpdateEvent(PartyNameUpdateEvent other)
	{
	}

	[Token(Token = "0x6001B53")]
	[Address(RVA = "0xD16240", Offset = "0xD15640", VA = "0x180D16240", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyNameUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001B58")]
	[Address(RVA = "0xD16310", Offset = "0xD15710", VA = "0x180D16310", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B59")]
	[Address(RVA = "0xAD8B90", Offset = "0xAD7F90", VA = "0x180AD8B90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyNameUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B5A")]
	[Address(RVA = "0xAD8CB0", Offset = "0xAD80B0", VA = "0x180AD8CB0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001B5B")]
	[Address(RVA = "0xD16430", Offset = "0xD15830", VA = "0x180D16430", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001B5C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001B5D")]
	[Address(RVA = "0xB789B0", Offset = "0xB77DB0", VA = "0x180B789B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001B5E")]
	[Address(RVA = "0xD16180", Offset = "0xD15580", VA = "0x180D16180", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001B5F")]
	[Address(RVA = "0xD163C0", Offset = "0xD157C0", VA = "0x180D163C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyNameUpdateEvent other)
	{
	}

	[Token(Token = "0x6001B60")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001B61")]
	[Address(RVA = "0xD16790", Offset = "0xD15B90", VA = "0x180D16790", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
