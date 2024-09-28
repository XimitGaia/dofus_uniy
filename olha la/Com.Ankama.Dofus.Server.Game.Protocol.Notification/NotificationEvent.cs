using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Notification;

[Token(Token = "0x20002F8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NotificationEvent : IMessage<NotificationEvent>, IMessage, IEquatable<NotificationEvent>, IDeepCloneable<NotificationEvent>, IBufferMessage
{
	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NotificationEvent> _parser;

	[Token(Token = "0x4000A6F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A70")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x18")]
	private int id_;

	[Token(Token = "0x4000A72")]
	public const int ParametersFieldNumber = 2;

	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<string> _repeated_parameters_codec;

	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<string> parameters_;

	[Token(Token = "0x4000A75")]
	public const int ForceFieldNumber = 3;

	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0x28")]
	private bool force_;

	[Token(Token = "0x170006A8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NotificationEvent> Parser
	{
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0xD24850", Offset = "0xD23C50", VA = "0x180D24850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0xD247A0", Offset = "0xD23BA0", VA = "0x180D247A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006AA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0xD24AE0", Offset = "0xD23EE0", VA = "0x180D24AE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006AB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Id
	{
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170006AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> Parameters
	{
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006AD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Force
	{
		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x6001ED8")]
	[Address(RVA = "0xD24720", Offset = "0xD23B20", VA = "0x180D24720")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NotificationEvent()
	{
	}

	[Token(Token = "0x6001ED9")]
	[Address(RVA = "0xD24680", Offset = "0xD23A80", VA = "0x180D24680")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NotificationEvent(NotificationEvent other)
	{
	}

	[Token(Token = "0x6001EDA")]
	[Address(RVA = "0xD24120", Offset = "0xD23520", VA = "0x180D24120", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NotificationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001EE0")]
	[Address(RVA = "0xD241F0", Offset = "0xD235F0", VA = "0x180D241F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EE1")]
	[Address(RVA = "0xD242E0", Offset = "0xD236E0", VA = "0x180D242E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NotificationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0xD24380", Offset = "0xD23780", VA = "0x180D24380", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0xD244F0", Offset = "0xD238F0", VA = "0x180D244F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001EE4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001EE5")]
	[Address(RVA = "0xD249F0", Offset = "0xD23DF0", VA = "0x180D249F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001EE6")]
	[Address(RVA = "0xD24030", Offset = "0xD23430", VA = "0x180D24030", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001EE7")]
	[Address(RVA = "0xD24460", Offset = "0xD23860", VA = "0x180D24460", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(NotificationEvent other)
	{
	}

	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0xD248A0", Offset = "0xD23CA0", VA = "0x180D248A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
