using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x2000028")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PortalUseRequest : IMessage<PortalUseRequest>, IMessage, IEquatable<PortalUseRequest>, IDeepCloneable<PortalUseRequest>, IBufferMessage
{
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PortalUseRequest> _parser;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400007E")]
	public const int PortalIdFieldNumber = 1;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x18")]
	private int portalId_;

	[Token(Token = "0x17000041")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PortalUseRequest> Parser
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x93E850", Offset = "0x93DC50", VA = "0x18093E850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000042")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x93E7A0", Offset = "0x93DBA0", VA = "0x18093E7A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000043")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x93E8A0", Offset = "0x93DCA0", VA = "0x18093E8A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000044")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PortalId
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PortalUseRequest()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PortalUseRequest(PortalUseRequest other)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x93E530", Offset = "0x93D930", VA = "0x18093E530", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PortalUseRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x93E5B0", Offset = "0x93D9B0", VA = "0x18093E5B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PortalUseRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x93E640", Offset = "0x93DA40", VA = "0x18093E640", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x93E4A0", Offset = "0x93D8A0", VA = "0x18093E4A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PortalUseRequest other)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
