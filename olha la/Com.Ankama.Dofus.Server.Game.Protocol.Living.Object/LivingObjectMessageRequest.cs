using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Living.Object;

[Token(Token = "0x200033E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class LivingObjectMessageRequest : IMessage<LivingObjectMessageRequest>, IMessage, IEquatable<LivingObjectMessageRequest>, IDeepCloneable<LivingObjectMessageRequest>, IBufferMessage
{
	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<LivingObjectMessageRequest> _parser;

	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B2C")]
	public const int MessageIdFieldNumber = 1;

	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x18")]
	private int messageId_;

	[Token(Token = "0x4000B2E")]
	public const int ObjectGidFieldNumber = 2;

	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x1C")]
	private int objectGid_;

	[Token(Token = "0x1700072C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LivingObjectMessageRequest> Parser
	{
		[Token(Token = "0x600217E")]
		[Address(RVA = "0x979700", Offset = "0x978B00", VA = "0x180979700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600217F")]
		[Address(RVA = "0x979650", Offset = "0x978A50", VA = "0x180979650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002180")]
		[Address(RVA = "0x979750", Offset = "0x978B50", VA = "0x180979750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MessageId
	{
		[Token(Token = "0x6002184")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002185")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000730")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectGid
	{
		[Token(Token = "0x6002186")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002187")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6002181")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LivingObjectMessageRequest()
	{
	}

	[Token(Token = "0x6002182")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LivingObjectMessageRequest(LivingObjectMessageRequest other)
	{
	}

	[Token(Token = "0x6002183")]
	[Address(RVA = "0x9793D0", Offset = "0x9787D0", VA = "0x1809793D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LivingObjectMessageRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002188")]
	[Address(RVA = "0x979460", Offset = "0x978860", VA = "0x180979460", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002189")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LivingObjectMessageRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600218A")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600218B")]
	[Address(RVA = "0x9794F0", Offset = "0x9788F0", VA = "0x1809794F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600218C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600218D")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600218E")]
	[Address(RVA = "0x979310", Offset = "0x978710", VA = "0x180979310", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600218F")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LivingObjectMessageRequest other)
	{
	}

	[Token(Token = "0x6002190")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002191")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
