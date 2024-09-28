using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C1B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitUpdateResponse : IMessage<OutfitUpdateResponse>, IMessage, IEquatable<OutfitUpdateResponse>, IDeepCloneable<OutfitUpdateResponse>, IBufferMessage
{
	[Token(Token = "0x4002CE8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitUpdateResponse> _parser;

	[Token(Token = "0x4002CE9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CEA")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002CEB")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001BEF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitUpdateResponse> Parser
	{
		[Token(Token = "0x6007F4D")]
		[Address(RVA = "0xC69DB0", Offset = "0xC691B0", VA = "0x180C69DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007F4E")]
		[Address(RVA = "0xC69D00", Offset = "0xC69100", VA = "0x180C69D00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BF1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007F4F")]
		[Address(RVA = "0xC69E00", Offset = "0xC69200", VA = "0x180C69E00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BF2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x6007F53")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007F54")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007F50")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitUpdateResponse()
	{
	}

	[Token(Token = "0x6007F51")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitUpdateResponse(OutfitUpdateResponse other)
	{
	}

	[Token(Token = "0x6007F52")]
	[Address(RVA = "0xC699F0", Offset = "0xC68DF0", VA = "0x180C699F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitUpdateResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007F55")]
	[Address(RVA = "0xC69A70", Offset = "0xC68E70", VA = "0x180C69A70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F56")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OutfitUpdateResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F57")]
	[Address(RVA = "0xC69B00", Offset = "0xC68F00", VA = "0x180C69B00", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007F58")]
	[Address(RVA = "0xC69BA0", Offset = "0xC68FA0", VA = "0x180C69BA0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007F59")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007F5A")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007F5B")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007F5C")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OutfitUpdateResponse other)
	{
	}

	[Token(Token = "0x6007F5D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007F5E")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
