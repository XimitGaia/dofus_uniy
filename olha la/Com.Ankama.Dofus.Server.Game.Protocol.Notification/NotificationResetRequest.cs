using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Notification;

[Token(Token = "0x20002F4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NotificationResetRequest : IMessage<NotificationResetRequest>, IMessage, IEquatable<NotificationResetRequest>, IDeepCloneable<NotificationResetRequest>, IBufferMessage
{
	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NotificationResetRequest> _parser;

	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170006A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NotificationResetRequest> Parser
	{
		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0xD257A0", Offset = "0xD24BA0", VA = "0x180D257A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0xD256F0", Offset = "0xD24AF0", VA = "0x180D256F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001EAE")]
		[Address(RVA = "0xD257F0", Offset = "0xD24BF0", VA = "0x180D257F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EAF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NotificationResetRequest()
	{
	}

	[Token(Token = "0x6001EB0")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NotificationResetRequest(NotificationResetRequest other)
	{
	}

	[Token(Token = "0x6001EB1")]
	[Address(RVA = "0xD25490", Offset = "0xD24890", VA = "0x180D25490", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NotificationResetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001EB2")]
	[Address(RVA = "0xD25510", Offset = "0xD24910", VA = "0x180D25510", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EB3")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NotificationResetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EB4")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001EB5")]
	[Address(RVA = "0xD25590", Offset = "0xD24990", VA = "0x180D25590", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001EB6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001EB7")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001EB8")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001EB9")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NotificationResetRequest other)
	{
	}

	[Token(Token = "0x6001EBA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001EBB")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
