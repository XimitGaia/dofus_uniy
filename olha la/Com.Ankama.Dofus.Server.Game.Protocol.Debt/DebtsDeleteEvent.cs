using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debt;

[Token(Token = "0x200077C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DebtsDeleteEvent : IMessage<DebtsDeleteEvent>, IMessage, IEquatable<DebtsDeleteEvent>, IDeepCloneable<DebtsDeleteEvent>, IBufferMessage
{
	[Token(Token = "0x200077D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x200077E")]
		public enum DebtsDeletionReason
		{
			[Token(Token = "0x4001A34")]
			[OriginalName("UNKNOWN")]
			Unknown,
			[Token(Token = "0x4001A35")]
			[OriginalName("ADMIN_COMMAND_REQUEST")]
			AdminCommandRequest,
			[Token(Token = "0x4001A36")]
			[OriginalName("PAYED")]
			Payed,
			[Token(Token = "0x4001A37")]
			[OriginalName("CANCELED")]
			Canceled
		}
	}

	[Token(Token = "0x4001A2C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DebtsDeleteEvent> _parser;

	[Token(Token = "0x4001A2D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A2E")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4001A2F")]
	[FieldOffset(Offset = "0x18")]
	private Types.DebtsDeletionReason reason_;

	[Token(Token = "0x4001A30")]
	public const int DebtsFieldNumber = 2;

	[Token(Token = "0x4001A31")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_debts_codec;

	[Token(Token = "0x4001A32")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<long> debts_;

	[Token(Token = "0x17001113")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<DebtsDeleteEvent> Parser
	{
		[Token(Token = "0x6004FD5")]
		[Address(RVA = "0xAD6E50", Offset = "0xAD6250", VA = "0x180AD6E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001114")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004FD6")]
		[Address(RVA = "0xAD6DA0", Offset = "0xAD61A0", VA = "0x180AD6DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001115")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004FD7")]
		[Address(RVA = "0xAD70A0", Offset = "0xAD64A0", VA = "0x180AD70A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001116")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.DebtsDeletionReason Reason
	{
		[Token(Token = "0x6004FDB")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.DebtsDeletionReason);
		}
		[Token(Token = "0x6004FDC")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001117")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> Debts
	{
		[Token(Token = "0x6004FDD")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004FD8")]
	[Address(RVA = "0xAD6D20", Offset = "0xAD6120", VA = "0x180AD6D20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DebtsDeleteEvent()
	{
	}

	[Token(Token = "0x6004FD9")]
	[Address(RVA = "0xAD6C90", Offset = "0xAD6090", VA = "0x180AD6C90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DebtsDeleteEvent(DebtsDeleteEvent other)
	{
	}

	[Token(Token = "0x6004FDA")]
	[Address(RVA = "0xAD6830", Offset = "0xAD5C30", VA = "0x180AD6830", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DebtsDeleteEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004FDE")]
	[Address(RVA = "0xAD6990", Offset = "0xAD5D90", VA = "0x180AD6990", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004FDF")]
	[Address(RVA = "0xAD68F0", Offset = "0xAD5CF0", VA = "0x180AD68F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DebtsDeleteEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004FE0")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004FE1")]
	[Address(RVA = "0xAD6B00", Offset = "0xAD5F00", VA = "0x180AD6B00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004FE2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004FE3")]
	[Address(RVA = "0xAD6FD0", Offset = "0xAD63D0", VA = "0x180AD6FD0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004FE4")]
	[Address(RVA = "0xAD6750", Offset = "0xAD5B50", VA = "0x180AD6750", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004FE5")]
	[Address(RVA = "0xAD6A70", Offset = "0xAD5E70", VA = "0x180AD6A70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DebtsDeleteEvent other)
	{
	}

	[Token(Token = "0x6004FE6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004FE7")]
	[Address(RVA = "0xAD6EA0", Offset = "0xAD62A0", VA = "0x180AD6EA0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
