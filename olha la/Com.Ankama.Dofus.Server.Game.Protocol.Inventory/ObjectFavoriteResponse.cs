using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003B9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectFavoriteResponse : IMessage<ObjectFavoriteResponse>, IMessage, IEquatable<ObjectFavoriteResponse>, IDeepCloneable<ObjectFavoriteResponse>, IBufferMessage
{
	[Token(Token = "0x4000CC6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectFavoriteResponse> _parser;

	[Token(Token = "0x4000CC7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CC8")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0x18")]
	private bool result_;

	[Token(Token = "0x17000848")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectFavoriteResponse> Parser
	{
		[Token(Token = "0x60026C5")]
		[Address(RVA = "0x98EFA0", Offset = "0x98E3A0", VA = "0x18098EFA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000849")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x98EEF0", Offset = "0x98E2F0", VA = "0x18098EEF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700084A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x98EFF0", Offset = "0x98E3F0", VA = "0x18098EFF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700084B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Result
	{
		[Token(Token = "0x60026CB")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60026CC")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60026C8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectFavoriteResponse()
	{
	}

	[Token(Token = "0x60026C9")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectFavoriteResponse(ObjectFavoriteResponse other)
	{
	}

	[Token(Token = "0x60026CA")]
	[Address(RVA = "0x98EBE0", Offset = "0x98DFE0", VA = "0x18098EBE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectFavoriteResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60026CD")]
	[Address(RVA = "0x98EC60", Offset = "0x98E060", VA = "0x18098EC60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60026CE")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectFavoriteResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60026CF")]
	[Address(RVA = "0x98ECF0", Offset = "0x98E0F0", VA = "0x18098ECF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60026D0")]
	[Address(RVA = "0x98ED90", Offset = "0x98E190", VA = "0x18098ED90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60026D1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60026D2")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60026D3")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60026D4")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectFavoriteResponse other)
	{
	}

	[Token(Token = "0x60026D5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60026D6")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
