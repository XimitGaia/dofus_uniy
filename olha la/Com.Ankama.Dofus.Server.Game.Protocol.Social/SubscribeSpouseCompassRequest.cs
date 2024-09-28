using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000134")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SubscribeSpouseCompassRequest : IMessage<SubscribeSpouseCompassRequest>, IMessage, IEquatable<SubscribeSpouseCompassRequest>, IDeepCloneable<SubscribeSpouseCompassRequest>, IBufferMessage
{
	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SubscribeSpouseCompassRequest> _parser;

	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000421")]
	public const int EnableFieldNumber = 1;

	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x18")]
	private bool enable_;

	[Token(Token = "0x1700028D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SubscribeSpouseCompassRequest> Parser
	{
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0xB752C0", Offset = "0xB746C0", VA = "0x180B752C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0xB75210", Offset = "0xB74610", VA = "0x180B75210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0xB75310", Offset = "0xB74710", VA = "0x180B75310", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Enable
	{
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscribeSpouseCompassRequest()
	{
	}

	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscribeSpouseCompassRequest(SubscribeSpouseCompassRequest other)
	{
	}

	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0xB74F00", Offset = "0xB74300", VA = "0x180B74F00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscribeSpouseCompassRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0xB74F80", Offset = "0xB74380", VA = "0x180B74F80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SubscribeSpouseCompassRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0xB75010", Offset = "0xB74410", VA = "0x180B75010", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0xB750B0", Offset = "0xB744B0", VA = "0x180B750B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000BFF")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000C00")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SubscribeSpouseCompassRequest other)
	{
	}

	[Token(Token = "0x6000C02")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
