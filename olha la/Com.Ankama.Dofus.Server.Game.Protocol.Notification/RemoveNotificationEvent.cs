using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Notification;

[Token(Token = "0x20002FA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class RemoveNotificationEvent : IMessage<RemoveNotificationEvent>, IMessage, IEquatable<RemoveNotificationEvent>, IDeepCloneable<RemoveNotificationEvent>, IBufferMessage
{
	[Token(Token = "0x4000A78")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<RemoveNotificationEvent> _parser;

	[Token(Token = "0x4000A79")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A7A")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4000A7B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_id_codec;

	[Token(Token = "0x4000A7C")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> id_;

	[Token(Token = "0x170006AE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RemoveNotificationEvent> Parser
	{
		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0xD2DEC0", Offset = "0xD2D2C0", VA = "0x180D2DEC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006AF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0xD2DE10", Offset = "0xD2D210", VA = "0x180D2DE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001EF0")]
		[Address(RVA = "0xD2E0E0", Offset = "0xD2D4E0", VA = "0x180D2E0E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Id
	{
		[Token(Token = "0x6001EF4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EF1")]
	[Address(RVA = "0xD2DD00", Offset = "0xD2D100", VA = "0x180D2DD00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveNotificationEvent()
	{
	}

	[Token(Token = "0x6001EF2")]
	[Address(RVA = "0xD2DD80", Offset = "0xD2D180", VA = "0x180D2DD80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RemoveNotificationEvent(RemoveNotificationEvent other)
	{
	}

	[Token(Token = "0x6001EF3")]
	[Address(RVA = "0xD2D8C0", Offset = "0xD2CCC0", VA = "0x180D2D8C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveNotificationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001EF5")]
	[Address(RVA = "0xD2D980", Offset = "0xD2CD80", VA = "0x180D2D980", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0xD2DA60", Offset = "0xD2CE60", VA = "0x180D2DA60", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RemoveNotificationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001EF8")]
	[Address(RVA = "0xD2DB70", Offset = "0xD2CF70", VA = "0x180D2DB70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001EFA")]
	[Address(RVA = "0xD2E030", Offset = "0xD2D430", VA = "0x180D2E030", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001EFB")]
	[Address(RVA = "0xD2D820", Offset = "0xD2CC20", VA = "0x180D2D820", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001EFC")]
	[Address(RVA = "0xD2DAF0", Offset = "0xD2CEF0", VA = "0x180D2DAF0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(RemoveNotificationEvent other)
	{
	}

	[Token(Token = "0x6001EFD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001EFE")]
	[Address(RVA = "0xD2DF10", Offset = "0xD2D310", VA = "0x180D2DF10", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
