using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Notification;

[Token(Token = "0x20002F2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NotificationUpdateFlagRequest : IMessage<NotificationUpdateFlagRequest>, IMessage, IEquatable<NotificationUpdateFlagRequest>, IDeepCloneable<NotificationUpdateFlagRequest>, IBufferMessage
{
	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NotificationUpdateFlagRequest> _parser;

	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A62")]
	public const int IndexFieldNumber = 1;

	[Token(Token = "0x4000A63")]
	[FieldOffset(Offset = "0x18")]
	private int index_;

	[Token(Token = "0x1700069D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<NotificationUpdateFlagRequest> Parser
	{
		[Token(Token = "0x6001E96")]
		[Address(RVA = "0xD25C80", Offset = "0xD25080", VA = "0x180D25C80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0xD25BD0", Offset = "0xD24FD0", VA = "0x180D25BD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0xD25CD0", Offset = "0xD250D0", VA = "0x180D25CD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Index
	{
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001E99")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NotificationUpdateFlagRequest()
	{
	}

	[Token(Token = "0x6001E9A")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NotificationUpdateFlagRequest(NotificationUpdateFlagRequest other)
	{
	}

	[Token(Token = "0x6001E9B")]
	[Address(RVA = "0xD25960", Offset = "0xD24D60", VA = "0x180D25960", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NotificationUpdateFlagRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001E9E")]
	[Address(RVA = "0xD259E0", Offset = "0xD24DE0", VA = "0x180D259E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E9F")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NotificationUpdateFlagRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EA0")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001EA1")]
	[Address(RVA = "0xD25A70", Offset = "0xD24E70", VA = "0x180D25A70", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001EA2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001EA3")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001EA4")]
	[Address(RVA = "0xD258D0", Offset = "0xD24CD0", VA = "0x180D258D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001EA5")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(NotificationUpdateFlagRequest other)
	{
	}

	[Token(Token = "0x6001EA6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001EA7")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
