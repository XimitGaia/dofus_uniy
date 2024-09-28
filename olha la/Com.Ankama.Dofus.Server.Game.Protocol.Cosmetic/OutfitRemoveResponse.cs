using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C25")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitRemoveResponse : IMessage<OutfitRemoveResponse>, IMessage, IEquatable<OutfitRemoveResponse>, IDeepCloneable<OutfitRemoveResponse>, IBufferMessage
{
	[Token(Token = "0x4002D0B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitRemoveResponse> _parser;

	[Token(Token = "0x4002D0C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D0D")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002D0E")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001C08")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitRemoveResponse> Parser
	{
		[Token(Token = "0x6007FC5")]
		[Address(RVA = "0xC68C20", Offset = "0xC68020", VA = "0x180C68C20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C09")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007FC6")]
		[Address(RVA = "0xC68B70", Offset = "0xC67F70", VA = "0x180C68B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C0A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007FC7")]
		[Address(RVA = "0xC68C70", Offset = "0xC68070", VA = "0x180C68C70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C0B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x6007FCB")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007FCC")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007FC8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitRemoveResponse()
	{
	}

	[Token(Token = "0x6007FC9")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitRemoveResponse(OutfitRemoveResponse other)
	{
	}

	[Token(Token = "0x6007FCA")]
	[Address(RVA = "0xC68860", Offset = "0xC67C60", VA = "0x180C68860", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitRemoveResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007FCD")]
	[Address(RVA = "0xC688E0", Offset = "0xC67CE0", VA = "0x180C688E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FCE")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitRemoveResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FCF")]
	[Address(RVA = "0xC68970", Offset = "0xC67D70", VA = "0x180C68970", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007FD0")]
	[Address(RVA = "0xC68A10", Offset = "0xC67E10", VA = "0x180C68A10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007FD1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007FD2")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007FD3")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007FD4")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OutfitRemoveResponse other)
	{
	}

	[Token(Token = "0x6007FD5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007FD6")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
