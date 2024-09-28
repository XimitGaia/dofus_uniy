using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C21")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitCreationResponse : IMessage<OutfitCreationResponse>, IMessage, IEquatable<OutfitCreationResponse>, IDeepCloneable<OutfitCreationResponse>, IBufferMessage
{
	[Token(Token = "0x4002CFF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitCreationResponse> _parser;

	[Token(Token = "0x4002D00")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D01")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002D02")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x4002D03")]
	public const int OutfitCreatedFieldNumber = 2;

	[Token(Token = "0x4002D04")]
	[FieldOffset(Offset = "0x20")]
	private Outfit outfitCreated_;

	[Token(Token = "0x17001BFF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitCreationResponse> Parser
	{
		[Token(Token = "0x6007F97")]
		[Address(RVA = "0xC60A80", Offset = "0xC5FE80", VA = "0x180C60A80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007F98")]
		[Address(RVA = "0xC609D0", Offset = "0xC5FDD0", VA = "0x180C609D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C01")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007F99")]
		[Address(RVA = "0xC60C00", Offset = "0xC60000", VA = "0x180C60C00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C02")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6007F9D")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007F9E")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001C03")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Outfit OutfitCreated
	{
		[Token(Token = "0x6007F9F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007FA0")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6007F9A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitCreationResponse()
	{
	}

	[Token(Token = "0x6007F9B")]
	[Address(RVA = "0xC60960", Offset = "0xC5FD60", VA = "0x180C60960")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitCreationResponse(OutfitCreationResponse other)
	{
	}

	[Token(Token = "0x6007F9C")]
	[Address(RVA = "0xC60510", Offset = "0xC5F910", VA = "0x180C60510", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitCreationResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007FA1")]
	[Address(RVA = "0xC605B0", Offset = "0xC5F9B0", VA = "0x180C605B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FA2")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitCreationResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FA3")]
	[Address(RVA = "0xC60660", Offset = "0xC5FA60", VA = "0x180C60660", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007FA4")]
	[Address(RVA = "0xC60800", Offset = "0xC5FC00", VA = "0x180C60800", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007FA5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007FA6")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007FA7")]
	[Address(RVA = "0xC60470", Offset = "0xC5F870", VA = "0x180C60470", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007FA8")]
	[Address(RVA = "0xC60720", Offset = "0xC5FB20", VA = "0x180C60720", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OutfitCreationResponse other)
	{
	}

	[Token(Token = "0x6007FA9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007FAA")]
	[Address(RVA = "0xC60AD0", Offset = "0xC5FED0", VA = "0x180C60AD0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
