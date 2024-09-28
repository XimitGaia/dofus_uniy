using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C15")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipFaceRequest : IMessage<OutfitEquipFaceRequest>, IMessage, IEquatable<OutfitEquipFaceRequest>, IDeepCloneable<OutfitEquipFaceRequest>, IBufferMessage
{
	[Token(Token = "0x4002CD3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipFaceRequest> _parser;

	[Token(Token = "0x4002CD4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CD5")]
	public const int FaceIdFieldNumber = 1;

	[Token(Token = "0x4002CD6")]
	[FieldOffset(Offset = "0x18")]
	private int faceId_;

	[Token(Token = "0x17001BE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitEquipFaceRequest> Parser
	{
		[Token(Token = "0x6007F05")]
		[Address(RVA = "0xC630C0", Offset = "0xC624C0", VA = "0x180C630C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BE1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007F06")]
		[Address(RVA = "0xC63010", Offset = "0xC62410", VA = "0x180C63010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BE2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007F07")]
		[Address(RVA = "0xC63110", Offset = "0xC62510", VA = "0x180C63110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BE3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FaceId
	{
		[Token(Token = "0x6007F0B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007F0C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6007F08")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipFaceRequest()
	{
	}

	[Token(Token = "0x6007F09")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipFaceRequest(OutfitEquipFaceRequest other)
	{
	}

	[Token(Token = "0x6007F0A")]
	[Address(RVA = "0xC62DA0", Offset = "0xC621A0", VA = "0x180C62DA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipFaceRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007F0D")]
	[Address(RVA = "0xC62E20", Offset = "0xC62220", VA = "0x180C62E20", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F0E")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitEquipFaceRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F0F")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007F10")]
	[Address(RVA = "0xC62EB0", Offset = "0xC622B0", VA = "0x180C62EB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007F11")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007F12")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007F13")]
	[Address(RVA = "0xC62D10", Offset = "0xC62110", VA = "0x180C62D10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007F14")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipFaceRequest other)
	{
	}

	[Token(Token = "0x6007F15")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007F16")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
