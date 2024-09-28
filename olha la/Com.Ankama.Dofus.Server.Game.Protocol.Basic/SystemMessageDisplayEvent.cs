using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B46")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SystemMessageDisplayEvent : IMessage<SystemMessageDisplayEvent>, IMessage, IEquatable<SystemMessageDisplayEvent>, IDeepCloneable<SystemMessageDisplayEvent>, IBufferMessage
{
	[Token(Token = "0x4002A17")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SystemMessageDisplayEvent> _parser;

	[Token(Token = "0x4002A18")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A19")]
	public const int HangUpFieldNumber = 1;

	[Token(Token = "0x4002A1A")]
	[FieldOffset(Offset = "0x18")]
	private bool hangUp_;

	[Token(Token = "0x4002A1B")]
	public const int MessageIdFieldNumber = 2;

	[Token(Token = "0x4002A1C")]
	[FieldOffset(Offset = "0x1C")]
	private int messageId_;

	[Token(Token = "0x4002A1D")]
	public const int ParametersFieldNumber = 3;

	[Token(Token = "0x4002A1E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<string> _repeated_parameters_codec;

	[Token(Token = "0x4002A1F")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<string> parameters_;

	[Token(Token = "0x17001A2F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SystemMessageDisplayEvent> Parser
	{
		[Token(Token = "0x60076DE")]
		[Address(RVA = "0xC26120", Offset = "0xC25520", VA = "0x180C26120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60076DF")]
		[Address(RVA = "0xC26070", Offset = "0xC25470", VA = "0x180C26070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A31")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60076E0")]
		[Address(RVA = "0xC263B0", Offset = "0xC257B0", VA = "0x180C263B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A32")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HangUp
	{
		[Token(Token = "0x60076E4")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60076E5")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001A33")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MessageId
	{
		[Token(Token = "0x60076E6")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60076E7")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001A34")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> Parameters
	{
		[Token(Token = "0x60076E8")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076E1")]
	[Address(RVA = "0xC25F50", Offset = "0xC25350", VA = "0x180C25F50")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SystemMessageDisplayEvent()
	{
	}

	[Token(Token = "0x60076E2")]
	[Address(RVA = "0xC25FD0", Offset = "0xC253D0", VA = "0x180C25FD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SystemMessageDisplayEvent(SystemMessageDisplayEvent other)
	{
	}

	[Token(Token = "0x60076E3")]
	[Address(RVA = "0xC259F0", Offset = "0xC24DF0", VA = "0x180C259F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SystemMessageDisplayEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60076E9")]
	[Address(RVA = "0xC25AC0", Offset = "0xC24EC0", VA = "0x180C25AC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60076EA")]
	[Address(RVA = "0xC25BB0", Offset = "0xC24FB0", VA = "0x180C25BB0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SystemMessageDisplayEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60076EB")]
	[Address(RVA = "0xC25C50", Offset = "0xC25050", VA = "0x180C25C50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60076EC")]
	[Address(RVA = "0xC25DC0", Offset = "0xC251C0", VA = "0x180C25DC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60076ED")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60076EE")]
	[Address(RVA = "0xC262C0", Offset = "0xC256C0", VA = "0x180C262C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60076EF")]
	[Address(RVA = "0xC25900", Offset = "0xC24D00", VA = "0x180C25900", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60076F0")]
	[Address(RVA = "0xC25D30", Offset = "0xC25130", VA = "0x180C25D30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SystemMessageDisplayEvent other)
	{
	}

	[Token(Token = "0x60076F1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60076F2")]
	[Address(RVA = "0xC26170", Offset = "0xC25570", VA = "0x180C26170", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
