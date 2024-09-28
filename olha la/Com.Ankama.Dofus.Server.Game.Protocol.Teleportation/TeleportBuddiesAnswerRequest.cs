using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x200006B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportBuddiesAnswerRequest : IMessage<TeleportBuddiesAnswerRequest>, IMessage, IEquatable<TeleportBuddiesAnswerRequest>, IDeepCloneable<TeleportBuddiesAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportBuddiesAnswerRequest> _parser;

	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000158")]
	public const int AcceptFieldNumber = 1;

	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x18")]
	private bool accept_;

	[Token(Token = "0x170000C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TeleportBuddiesAnswerRequest> Parser
	{
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x95DDE0", Offset = "0x95D1E0", VA = "0x18095DDE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x95DD30", Offset = "0x95D130", VA = "0x18095DD30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x95DE30", Offset = "0x95D230", VA = "0x18095DE30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Accept
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportBuddiesAnswerRequest()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportBuddiesAnswerRequest(TeleportBuddiesAnswerRequest other)
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x95DA20", Offset = "0x95CE20", VA = "0x18095DA20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportBuddiesAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x95DAA0", Offset = "0x95CEA0", VA = "0x18095DAA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TeleportBuddiesAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x95DB30", Offset = "0x95CF30", VA = "0x18095DB30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x95DBD0", Offset = "0x95CFD0", VA = "0x18095DBD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TeleportBuddiesAnswerRequest other)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
