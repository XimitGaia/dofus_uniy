using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont;

[Token(Token = "0x20000E8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class WrapperObjectDissociateRequest : IMessage<WrapperObjectDissociateRequest>, IMessage, IEquatable<WrapperObjectDissociateRequest>, IDeepCloneable<WrapperObjectDissociateRequest>, IBufferMessage
{
	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<WrapperObjectDissociateRequest> _parser;

	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000315")]
	public const int HostUidFieldNumber = 1;

	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x18")]
	private int hostUid_;

	[Token(Token = "0x4000317")]
	public const int HostPositionFieldNumber = 2;

	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x1C")]
	private int hostPosition_;

	[Token(Token = "0x170001E6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<WrapperObjectDissociateRequest> Parser
	{
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xA6DC70", Offset = "0xA6D070", VA = "0x180A6DC70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xA6DBC0", Offset = "0xA6CFC0", VA = "0x180A6DBC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xA6DCC0", Offset = "0xA6D0C0", VA = "0x180A6DCC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HostUid
	{
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170001EA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HostPosition
	{
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WrapperObjectDissociateRequest()
	{
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WrapperObjectDissociateRequest(WrapperObjectDissociateRequest other)
	{
	}

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0xA6D940", Offset = "0xA6CD40", VA = "0x180A6D940", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WrapperObjectDissociateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000903")]
	[Address(RVA = "0xA6D9D0", Offset = "0xA6CDD0", VA = "0x180A6D9D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000904")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(WrapperObjectDissociateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000905")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000906")]
	[Address(RVA = "0xA6DA60", Offset = "0xA6CE60", VA = "0x180A6DA60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000907")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000908")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000909")]
	[Address(RVA = "0xA6D880", Offset = "0xA6CC80", VA = "0x180A6D880", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600090A")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(WrapperObjectDissociateRequest other)
	{
	}

	[Token(Token = "0x600090B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600090C")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
