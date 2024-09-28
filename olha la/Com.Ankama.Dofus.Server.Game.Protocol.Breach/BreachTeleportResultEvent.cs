using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008F9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachTeleportResultEvent : IMessage<BreachTeleportResultEvent>, IMessage, IEquatable<BreachTeleportResultEvent>, IDeepCloneable<BreachTeleportResultEvent>, IBufferMessage
{
	[Token(Token = "0x4001EBD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachTeleportResultEvent> _parser;

	[Token(Token = "0x4001EBE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EBF")]
	public const int TeleportedFieldNumber = 1;

	[Token(Token = "0x4001EC0")]
	[FieldOffset(Offset = "0x18")]
	private bool teleported_;

	[Token(Token = "0x1700141A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachTeleportResultEvent> Parser
	{
		[Token(Token = "0x6005EF1")]
		[Address(RVA = "0xB584C0", Offset = "0xB578C0", VA = "0x180B584C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700141B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005EF2")]
		[Address(RVA = "0xB58410", Offset = "0xB57810", VA = "0x180B58410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700141C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005EF3")]
		[Address(RVA = "0xB58510", Offset = "0xB57910", VA = "0x180B58510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700141D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Teleported
	{
		[Token(Token = "0x6005EF7")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005EF8")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6005EF4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachTeleportResultEvent()
	{
	}

	[Token(Token = "0x6005EF5")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachTeleportResultEvent(BreachTeleportResultEvent other)
	{
	}

	[Token(Token = "0x6005EF6")]
	[Address(RVA = "0xB58100", Offset = "0xB57500", VA = "0x180B58100", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachTeleportResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005EF9")]
	[Address(RVA = "0xB58180", Offset = "0xB57580", VA = "0x180B58180", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005EFA")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachTeleportResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005EFB")]
	[Address(RVA = "0xB58210", Offset = "0xB57610", VA = "0x180B58210", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005EFC")]
	[Address(RVA = "0xB582B0", Offset = "0xB576B0", VA = "0x180B582B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005EFD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005EFE")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005EFF")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005F00")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BreachTeleportResultEvent other)
	{
	}

	[Token(Token = "0x6005F01")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005F02")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
