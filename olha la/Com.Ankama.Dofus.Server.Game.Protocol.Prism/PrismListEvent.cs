using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism;

[Token(Token = "0x20001BB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismListEvent : IMessage<PrismListEvent>, IMessage, IEquatable<PrismListEvent>, IDeepCloneable<PrismListEvent>, IBufferMessage
{
	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismListEvent> _parser;

	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40005CF")]
	public const int PrismLocalizedInformationFieldNumber = 1;

	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<PrismLocalizedInformation> _repeated_prismLocalizedInformation_codec;

	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<PrismLocalizedInformation> prismLocalizedInformation_;

	[Token(Token = "0x170003B9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PrismListEvent> Parser
	{
		[Token(Token = "0x6001188")]
		[Address(RVA = "0xCD02A0", Offset = "0xCCF6A0", VA = "0x180CD02A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001189")]
		[Address(RVA = "0xCD01F0", Offset = "0xCCF5F0", VA = "0x180CD01F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600118A")]
		[Address(RVA = "0xCD04B0", Offset = "0xCCF8B0", VA = "0x180CD04B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PrismLocalizedInformation> PrismLocalizedInformation
	{
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600118B")]
	[Address(RVA = "0xCD00E0", Offset = "0xCCF4E0", VA = "0x180CD00E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismListEvent()
	{
	}

	[Token(Token = "0x600118C")]
	[Address(RVA = "0xCD0160", Offset = "0xCCF560", VA = "0x180CD0160")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismListEvent(PrismListEvent other)
	{
	}

	[Token(Token = "0x600118D")]
	[Address(RVA = "0xCCFC30", Offset = "0xCCF030", VA = "0x180CCFC30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600118F")]
	[Address(RVA = "0xCCFCF0", Offset = "0xCCF0F0", VA = "0x180CCFCF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001190")]
	[Address(RVA = "0xCCFDD0", Offset = "0xCCF1D0", VA = "0x180CCFDD0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PrismListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001191")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001192")]
	[Address(RVA = "0xCCFEE0", Offset = "0xCCF2E0", VA = "0x180CCFEE0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001193")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001194")]
	[Address(RVA = "0xCD0400", Offset = "0xCCF800", VA = "0x180CD0400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001195")]
	[Address(RVA = "0xCCFB90", Offset = "0xCCEF90", VA = "0x180CCFB90", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001196")]
	[Address(RVA = "0xCCFE60", Offset = "0xCCF260", VA = "0x180CCFE60", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PrismListEvent other)
	{
	}

	[Token(Token = "0x6001197")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001198")]
	[Address(RVA = "0xCD02F0", Offset = "0xCCF6F0", VA = "0x180CD02F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
