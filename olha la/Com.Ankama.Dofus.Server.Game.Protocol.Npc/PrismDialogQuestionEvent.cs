using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002E7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismDialogQuestionEvent : IMessage<PrismDialogQuestionEvent>, IMessage, IEquatable<PrismDialogQuestionEvent>, IDeepCloneable<PrismDialogQuestionEvent>, IBufferMessage
{
	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismDialogQuestionEvent> _parser;

	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000684")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PrismDialogQuestionEvent> Parser
	{
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0xD2D6F0", Offset = "0xD2CAF0", VA = "0x180D2D6F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000685")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0xD2D640", Offset = "0xD2CA40", VA = "0x180D2D640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000686")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001E21")]
		[Address(RVA = "0xD2D740", Offset = "0xD2CB40", VA = "0x180D2D740", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E22")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismDialogQuestionEvent()
	{
	}

	[Token(Token = "0x6001E23")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismDialogQuestionEvent(PrismDialogQuestionEvent other)
	{
	}

	[Token(Token = "0x6001E24")]
	[Address(RVA = "0xD2D3E0", Offset = "0xD2C7E0", VA = "0x180D2D3E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismDialogQuestionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001E25")]
	[Address(RVA = "0xD2D460", Offset = "0xD2C860", VA = "0x180D2D460", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E26")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PrismDialogQuestionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E27")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001E28")]
	[Address(RVA = "0xD2D4E0", Offset = "0xD2C8E0", VA = "0x180D2D4E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001E29")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001E2A")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001E2B")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001E2C")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PrismDialogQuestionEvent other)
	{
	}

	[Token(Token = "0x6001E2D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001E2E")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
