using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006A7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMultiCraftCrafterCanUseHisResourcesEvent : IMessage<ExchangeMultiCraftCrafterCanUseHisResourcesEvent>, IMessage, IEquatable<ExchangeMultiCraftCrafterCanUseHisResourcesEvent>, IDeepCloneable<ExchangeMultiCraftCrafterCanUseHisResourcesEvent>, IBufferMessage
{
	[Token(Token = "0x4001749")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMultiCraftCrafterCanUseHisResourcesEvent> _parser;

	[Token(Token = "0x400174A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400174B")]
	public const int AllowedFieldNumber = 1;

	[Token(Token = "0x400174C")]
	[FieldOffset(Offset = "0x18")]
	private bool allowed_;

	[Token(Token = "0x17000F43")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeMultiCraftCrafterCanUseHisResourcesEvent> Parser
	{
		[Token(Token = "0x600476D")]
		[Address(RVA = "0xA8C4A0", Offset = "0xA8B8A0", VA = "0x180A8C4A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F44")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600476E")]
		[Address(RVA = "0xA8C3F0", Offset = "0xA8B7F0", VA = "0x180A8C3F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F45")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600476F")]
		[Address(RVA = "0xA8C4F0", Offset = "0xA8B8F0", VA = "0x180A8C4F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F46")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Allowed
	{
		[Token(Token = "0x6004773")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004774")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6004770")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftCrafterCanUseHisResourcesEvent()
	{
	}

	[Token(Token = "0x6004771")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftCrafterCanUseHisResourcesEvent(ExchangeMultiCraftCrafterCanUseHisResourcesEvent other)
	{
	}

	[Token(Token = "0x6004772")]
	[Address(RVA = "0xA8C0E0", Offset = "0xA8B4E0", VA = "0x180A8C0E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftCrafterCanUseHisResourcesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004775")]
	[Address(RVA = "0xA8C160", Offset = "0xA8B560", VA = "0x180A8C160", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004776")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeMultiCraftCrafterCanUseHisResourcesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004777")]
	[Address(RVA = "0xA8C1F0", Offset = "0xA8B5F0", VA = "0x180A8C1F0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004778")]
	[Address(RVA = "0xA8C290", Offset = "0xA8B690", VA = "0x180A8C290", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004779")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600477A")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600477B")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600477C")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMultiCraftCrafterCanUseHisResourcesEvent other)
	{
	}

	[Token(Token = "0x600477D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600477E")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
