using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007C6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContactLookEvent : IMessage<ContactLookEvent>, IMessage, IEquatable<ContactLookEvent>, IDeepCloneable<ContactLookEvent>, IBufferMessage
{
	[Token(Token = "0x4001AF3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContactLookEvent> _parser;

	[Token(Token = "0x4001AF4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001AF5")]
	public const int RequestIdFieldNumber = 1;

	[Token(Token = "0x4001AF6")]
	[FieldOffset(Offset = "0x18")]
	private int requestId_;

	[Token(Token = "0x4001AF7")]
	public const int PlayerNameFieldNumber = 2;

	[Token(Token = "0x4001AF8")]
	[FieldOffset(Offset = "0x20")]
	private string playerName_;

	[Token(Token = "0x4001AF9")]
	public const int PlayerIdFieldNumber = 3;

	[Token(Token = "0x4001AFA")]
	[FieldOffset(Offset = "0x28")]
	private long playerId_;

	[Token(Token = "0x4001AFB")]
	public const int LookFieldNumber = 4;

	[Token(Token = "0x4001AFC")]
	[FieldOffset(Offset = "0x30")]
	private EntityLook look_;

	[Token(Token = "0x1700119A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ContactLookEvent> Parser
	{
		[Token(Token = "0x600529E")]
		[Address(RVA = "0xAEB0B0", Offset = "0xAEA4B0", VA = "0x180AEB0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700119B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600529F")]
		[Address(RVA = "0xAEB000", Offset = "0xAEA400", VA = "0x180AEB000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700119C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60052A0")]
		[Address(RVA = "0xAEB350", Offset = "0xAEA750", VA = "0x180AEB350", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700119D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RequestId
	{
		[Token(Token = "0x60052A4")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60052A5")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700119E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PlayerName
	{
		[Token(Token = "0x60052A6")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60052A7")]
		[Address(RVA = "0xAEB430", Offset = "0xAEA830", VA = "0x180AEB430")]
		set
		{
		}
	}

	[Token(Token = "0x1700119F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x60052A8")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60052A9")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x170011A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityLook Look
	{
		[Token(Token = "0x60052AA")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60052AB")]
		[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
		set
		{
		}
	}

	[Token(Token = "0x60052A1")]
	[Address(RVA = "0xAEAFB0", Offset = "0xAEA3B0", VA = "0x180AEAFB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactLookEvent()
	{
	}

	[Token(Token = "0x60052A2")]
	[Address(RVA = "0xAEAEE0", Offset = "0xAEA2E0", VA = "0x180AEAEE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactLookEvent(ContactLookEvent other)
	{
	}

	[Token(Token = "0x60052A3")]
	[Address(RVA = "0xAEA940", Offset = "0xAE9D40", VA = "0x180AEA940", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactLookEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60052AC")]
	[Address(RVA = "0xAEAAD0", Offset = "0xAE9ED0", VA = "0x180AEAAD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60052AD")]
	[Address(RVA = "0xAEAA40", Offset = "0xAE9E40", VA = "0x180AEAA40", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContactLookEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60052AE")]
	[Address(RVA = "0xAEABB0", Offset = "0xAE9FB0", VA = "0x180AEABB0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60052AF")]
	[Address(RVA = "0xAEAD80", Offset = "0xAEA180", VA = "0x180AEAD80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60052B0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60052B1")]
	[Address(RVA = "0xAEB280", Offset = "0xAEA680", VA = "0x180AEB280", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60052B2")]
	[Address(RVA = "0xAEA830", Offset = "0xAE9C30", VA = "0x180AEA830", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60052B3")]
	[Address(RVA = "0xAEAC80", Offset = "0xAEA080", VA = "0x180AEAC80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContactLookEvent other)
	{
	}

	[Token(Token = "0x60052B4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60052B5")]
	[Address(RVA = "0xAEB100", Offset = "0xAEA500", VA = "0x180AEB100", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
