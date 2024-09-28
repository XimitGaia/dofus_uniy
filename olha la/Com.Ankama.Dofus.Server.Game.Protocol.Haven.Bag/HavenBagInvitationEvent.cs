using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000449")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagInvitationEvent : IMessage<HavenBagInvitationEvent>, IMessage, IEquatable<HavenBagInvitationEvent>, IDeepCloneable<HavenBagInvitationEvent>, IBufferMessage
{
	[Token(Token = "0x4000EC8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagInvitationEvent> _parser;

	[Token(Token = "0x4000EC9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000ECA")]
	public const int GuestInformationFieldNumber = 1;

	[Token(Token = "0x4000ECB")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character guestInformation_;

	[Token(Token = "0x4000ECC")]
	public const int AcceptedFieldNumber = 2;

	[Token(Token = "0x4000ECD")]
	[FieldOffset(Offset = "0x20")]
	private bool accepted_;

	[Token(Token = "0x170009A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagInvitationEvent> Parser
	{
		[Token(Token = "0x6002D1F")]
		[Address(RVA = "0x9BDCB0", Offset = "0x9BD0B0", VA = "0x1809BDCB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009A4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002D20")]
		[Address(RVA = "0x9BDC00", Offset = "0x9BD000", VA = "0x1809BDC00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009A5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002D21")]
		[Address(RVA = "0x9BDEB0", Offset = "0x9BD2B0", VA = "0x1809BDEB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009A6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character GuestInformation
	{
		[Token(Token = "0x6002D25")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D26")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x170009A7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Accepted
	{
		[Token(Token = "0x6002D27")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002D28")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x6002D22")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagInvitationEvent()
	{
	}

	[Token(Token = "0x6002D23")]
	[Address(RVA = "0x9BDB80", Offset = "0x9BCF80", VA = "0x1809BDB80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagInvitationEvent(HavenBagInvitationEvent other)
	{
	}

	[Token(Token = "0x6002D24")]
	[Address(RVA = "0x9BD6B0", Offset = "0x9BCAB0", VA = "0x1809BD6B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagInvitationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002D29")]
	[Address(RVA = "0x9BD7D0", Offset = "0x9BCBD0", VA = "0x1809BD7D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D2A")]
	[Address(RVA = "0x9BD760", Offset = "0x9BCB60", VA = "0x1809BD760", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagInvitationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D2B")]
	[Address(RVA = "0x9BD880", Offset = "0x9BCC80", VA = "0x1809BD880", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002D2C")]
	[Address(RVA = "0x9BDA20", Offset = "0x9BCE20", VA = "0x1809BDA20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002D2D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002D2E")]
	[Address(RVA = "0x9BDE30", Offset = "0x9BD230", VA = "0x1809BDE30", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002D2F")]
	[Address(RVA = "0x9BD620", Offset = "0x9BCA20", VA = "0x1809BD620", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002D30")]
	[Address(RVA = "0x9BD940", Offset = "0x9BCD40", VA = "0x1809BD940", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagInvitationEvent other)
	{
	}

	[Token(Token = "0x6002D31")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002D32")]
	[Address(RVA = "0x9BDD00", Offset = "0x9BD100", VA = "0x1809BDD00", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
