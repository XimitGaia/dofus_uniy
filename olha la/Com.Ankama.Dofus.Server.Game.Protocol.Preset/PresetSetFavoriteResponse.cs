using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000241")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetSetFavoriteResponse : IMessage<PresetSetFavoriteResponse>, IMessage, IEquatable<PresetSetFavoriteResponse>, IDeepCloneable<PresetSetFavoriteResponse>, IBufferMessage
{
	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetSetFavoriteResponse> _parser;

	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007A4")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x40007A5")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x170004E2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetSetFavoriteResponse> Parser
	{
		[Token(Token = "0x60016E1")]
		[Address(RVA = "0xD042B0", Offset = "0xD036B0", VA = "0x180D042B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60016E2")]
		[Address(RVA = "0xD04200", Offset = "0xD03600", VA = "0x180D04200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0xD04300", Offset = "0xD03700", VA = "0x180D04300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsSuccess
	{
		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60016E4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSetFavoriteResponse()
	{
	}

	[Token(Token = "0x60016E5")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSetFavoriteResponse(PresetSetFavoriteResponse other)
	{
	}

	[Token(Token = "0x60016E6")]
	[Address(RVA = "0xD03EF0", Offset = "0xD032F0", VA = "0x180D03EF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSetFavoriteResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60016E9")]
	[Address(RVA = "0xD03F70", Offset = "0xD03370", VA = "0x180D03F70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60016EA")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetSetFavoriteResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60016EB")]
	[Address(RVA = "0xD04000", Offset = "0xD03400", VA = "0x180D04000", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60016EC")]
	[Address(RVA = "0xD040A0", Offset = "0xD034A0", VA = "0x180D040A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60016ED")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60016EE")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60016EF")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60016F0")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetSetFavoriteResponse other)
	{
	}

	[Token(Token = "0x60016F1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60016F2")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
