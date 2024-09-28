using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002BF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockTransactionDialogEvent : IMessage<PaddockTransactionDialogEvent>, IMessage, IEquatable<PaddockTransactionDialogEvent>, IDeepCloneable<PaddockTransactionDialogEvent>, IBufferMessage
{
	[Token(Token = "0x20002C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20002C1")]
		public enum Transaction
		{
			[Token(Token = "0x40009B0")]
			[OriginalName("BUY")]
			Buy,
			[Token(Token = "0x40009B1")]
			[OriginalName("SELL")]
			Sell
		}
	}

	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockTransactionDialogEvent> _parser;

	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40009A9")]
	public const int TransactionFieldNumber = 1;

	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x18")]
	private Types.Transaction transaction_;

	[Token(Token = "0x40009AB")]
	public const int OwnerIdFieldNumber = 2;

	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x1C")]
	private int ownerId_;

	[Token(Token = "0x40009AD")]
	public const int PriceFieldNumber = 3;

	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x20")]
	private long price_;

	[Token(Token = "0x1700062B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PaddockTransactionDialogEvent> Parser
	{
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0xD0CF20", Offset = "0xD0C320", VA = "0x180D0CF20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700062C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0xD0CE70", Offset = "0xD0C270", VA = "0x180D0CE70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700062D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0xD0D010", Offset = "0xD0C410", VA = "0x180D0D010", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700062E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Transaction Transaction
	{
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.Transaction);
		}
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700062F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OwnerId
	{
		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000630")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Price
	{
		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001CA7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockTransactionDialogEvent()
	{
	}

	[Token(Token = "0x6001CA8")]
	[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockTransactionDialogEvent(PaddockTransactionDialogEvent other)
	{
	}

	[Token(Token = "0x6001CA9")]
	[Address(RVA = "0xD0CBE0", Offset = "0xD0BFE0", VA = "0x180D0CBE0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockTransactionDialogEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0xD0CC70", Offset = "0xD0C070", VA = "0x180D0CC70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PaddockTransactionDialogEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CB2")]
	[Address(RVA = "0xA846F0", Offset = "0xA83AF0", VA = "0x180A846F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0xD0CD10", Offset = "0xD0C110", VA = "0x180D0CD10", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0xD0CF70", Offset = "0xD0C370", VA = "0x180D0CF70", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0xD0CB00", Offset = "0xD0BF00", VA = "0x180D0CB00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001CB7")]
	[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PaddockTransactionDialogEvent other)
	{
	}

	[Token(Token = "0x6001CB8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
