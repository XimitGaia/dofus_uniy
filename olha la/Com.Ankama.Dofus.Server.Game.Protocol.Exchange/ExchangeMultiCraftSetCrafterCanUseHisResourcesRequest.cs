using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000662")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest : IMessage<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest>, IMessage, IEquatable<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest>, IDeepCloneable<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest>, IBufferMessage
{
	[Token(Token = "0x400165C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest> _parser;

	[Token(Token = "0x400165D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400165E")]
	public const int AllowFieldNumber = 1;

	[Token(Token = "0x400165F")]
	[FieldOffset(Offset = "0x18")]
	private bool allow_;

	[Token(Token = "0x17000EA8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest> Parser
	{
		[Token(Token = "0x600446F")]
		[Address(RVA = "0xA8C990", Offset = "0xA8BD90", VA = "0x180A8C990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EA9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004470")]
		[Address(RVA = "0xA8C8E0", Offset = "0xA8BCE0", VA = "0x180A8C8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EAA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004471")]
		[Address(RVA = "0xA8C9E0", Offset = "0xA8BDE0", VA = "0x180A8C9E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EAB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Allow
	{
		[Token(Token = "0x6004475")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004476")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6004472")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest()
	{
	}

	[Token(Token = "0x6004473")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest(ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest other)
	{
	}

	[Token(Token = "0x6004474")]
	[Address(RVA = "0xA8C5D0", Offset = "0xA8B9D0", VA = "0x180A8C5D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004477")]
	[Address(RVA = "0xA8C650", Offset = "0xA8BA50", VA = "0x180A8C650", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004478")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004479")]
	[Address(RVA = "0xA8C6E0", Offset = "0xA8BAE0", VA = "0x180A8C6E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600447A")]
	[Address(RVA = "0xA8C780", Offset = "0xA8BB80", VA = "0x180A8C780", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600447B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600447C")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600447D")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600447E")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMultiCraftSetCrafterCanUseHisResourcesRequest other)
	{
	}

	[Token(Token = "0x600447F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004480")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
