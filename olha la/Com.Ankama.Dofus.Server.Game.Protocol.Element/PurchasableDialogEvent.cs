using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element;

[Token(Token = "0x200074A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PurchasableDialogEvent : IMessage<PurchasableDialogEvent>, IMessage, IEquatable<PurchasableDialogEvent>, IDeepCloneable<PurchasableDialogEvent>, IBufferMessage
{
	[Token(Token = "0x200074B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x200074C")]
		public enum Action
		{
			[Token(Token = "0x40019AD")]
			[OriginalName("BUY")]
			Buy,
			[Token(Token = "0x40019AE")]
			[OriginalName("SELL")]
			Sell
		}
	}

	[Token(Token = "0x40019A0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PurchasableDialogEvent> _parser;

	[Token(Token = "0x40019A1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019A2")]
	public const int ActionFieldNumber = 1;

	[Token(Token = "0x40019A3")]
	[FieldOffset(Offset = "0x18")]
	private Types.Action action_;

	[Token(Token = "0x40019A4")]
	public const int PurchasableIdFieldNumber = 2;

	[Token(Token = "0x40019A5")]
	[FieldOffset(Offset = "0x20")]
	private long purchasableId_;

	[Token(Token = "0x40019A6")]
	public const int PurchasableInstanceIdFieldNumber = 3;

	[Token(Token = "0x40019A7")]
	[FieldOffset(Offset = "0x28")]
	private int purchasableInstanceId_;

	[Token(Token = "0x40019A8")]
	public const int SecondHandFieldNumber = 4;

	[Token(Token = "0x40019A9")]
	[FieldOffset(Offset = "0x2C")]
	private bool secondHand_;

	[Token(Token = "0x40019AA")]
	public const int PriceFieldNumber = 5;

	[Token(Token = "0x40019AB")]
	[FieldOffset(Offset = "0x30")]
	private long price_;

	[Token(Token = "0x170010BF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PurchasableDialogEvent> Parser
	{
		[Token(Token = "0x6004E42")]
		[Address(RVA = "0xAC5170", Offset = "0xAC4570", VA = "0x180AC5170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004E43")]
		[Address(RVA = "0xAC50C0", Offset = "0xAC44C0", VA = "0x180AC50C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004E44")]
		[Address(RVA = "0xAC53C0", Offset = "0xAC47C0", VA = "0x180AC53C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010C2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Action Action
	{
		[Token(Token = "0x6004E48")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.Action);
		}
		[Token(Token = "0x6004E49")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170010C3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PurchasableId
	{
		[Token(Token = "0x6004E4A")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004E4B")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170010C4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PurchasableInstanceId
	{
		[Token(Token = "0x6004E4C")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004E4D")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170010C5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool SecondHand
	{
		[Token(Token = "0x6004E4E")]
		[Address(RVA = "0x9A7CA0", Offset = "0x9A70A0", VA = "0x1809A7CA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004E4F")]
		[Address(RVA = "0x9A8090", Offset = "0x9A7490", VA = "0x1809A8090")]
		set
		{
		}
	}

	[Token(Token = "0x170010C6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Price
	{
		[Token(Token = "0x6004E50")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004E51")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x6004E45")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PurchasableDialogEvent()
	{
	}

	[Token(Token = "0x6004E46")]
	[Address(RVA = "0xAC5050", Offset = "0xAC4450", VA = "0x180AC5050")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PurchasableDialogEvent(PurchasableDialogEvent other)
	{
	}

	[Token(Token = "0x6004E47")]
	[Address(RVA = "0xAC4BB0", Offset = "0xAC3FB0", VA = "0x180AC4BB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PurchasableDialogEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004E52")]
	[Address(RVA = "0xAC4CA0", Offset = "0xAC40A0", VA = "0x180AC4CA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E53")]
	[Address(RVA = "0xAC4C50", Offset = "0xAC4050", VA = "0x180AC4C50", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PurchasableDialogEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E54")]
	[Address(RVA = "0xAC4D50", Offset = "0xAC4150", VA = "0x180AC4D50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004E55")]
	[Address(RVA = "0xAC4EF0", Offset = "0xAC42F0", VA = "0x180AC4EF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004E56")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004E57")]
	[Address(RVA = "0xAC52E0", Offset = "0xAC46E0", VA = "0x180AC52E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004E58")]
	[Address(RVA = "0xAC4A90", Offset = "0xAC3E90", VA = "0x180AC4A90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004E59")]
	[Address(RVA = "0xAC4E70", Offset = "0xAC4270", VA = "0x180AC4E70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PurchasableDialogEvent other)
	{
	}

	[Token(Token = "0x6004E5A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004E5B")]
	[Address(RVA = "0xAC51C0", Offset = "0xAC45C0", VA = "0x180AC51C0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
