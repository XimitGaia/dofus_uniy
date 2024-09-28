using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Notification;

[Token(Token = "0x20002F6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NotificationsEvent : IMessage<NotificationsEvent>, IMessage, IEquatable<NotificationsEvent>, IDeepCloneable<NotificationsEvent>, IBufferMessage
{
	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NotificationsEvent> _parser;

	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A6A")]
	public const int FlagsFieldNumber = 1;

	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_flags_codec;

	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> flags_;

	[Token(Token = "0x170006A4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NotificationsEvent> Parser
	{
		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0xD26450", Offset = "0xD25850", VA = "0x180D26450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0xD263A0", Offset = "0xD257A0", VA = "0x180D263A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0xD26670", Offset = "0xD25A70", VA = "0x180D26670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Flags
	{
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EC3")]
	[Address(RVA = "0xD26290", Offset = "0xD25690", VA = "0x180D26290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NotificationsEvent()
	{
	}

	[Token(Token = "0x6001EC4")]
	[Address(RVA = "0xD26310", Offset = "0xD25710", VA = "0x180D26310")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NotificationsEvent(NotificationsEvent other)
	{
	}

	[Token(Token = "0x6001EC5")]
	[Address(RVA = "0xD25E50", Offset = "0xD25250", VA = "0x180D25E50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NotificationsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001EC7")]
	[Address(RVA = "0xD25FA0", Offset = "0xD253A0", VA = "0x180D25FA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EC8")]
	[Address(RVA = "0xD25F10", Offset = "0xD25310", VA = "0x180D25F10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NotificationsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EC9")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001ECA")]
	[Address(RVA = "0xD26100", Offset = "0xD25500", VA = "0x180D26100", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001ECB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001ECC")]
	[Address(RVA = "0xD265C0", Offset = "0xD259C0", VA = "0x180D265C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001ECD")]
	[Address(RVA = "0xD25DB0", Offset = "0xD251B0", VA = "0x180D25DB0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001ECE")]
	[Address(RVA = "0xD26080", Offset = "0xD25480", VA = "0x180D26080", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(NotificationsEvent other)
	{
	}

	[Token(Token = "0x6001ECF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0xD264A0", Offset = "0xD258A0", VA = "0x180D264A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
