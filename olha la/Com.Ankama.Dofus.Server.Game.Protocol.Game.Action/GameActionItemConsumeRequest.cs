using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x2000559")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionItemConsumeRequest : IMessage<GameActionItemConsumeRequest>, IMessage, IEquatable<GameActionItemConsumeRequest>, IDeepCloneable<GameActionItemConsumeRequest>, IBufferMessage
{
	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionItemConsumeRequest> _parser;

	[Token(Token = "0x400125C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400125D")]
	public const int ActionIdFieldNumber = 1;

	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0x18")]
	private int actionId_;

	[Token(Token = "0x400125F")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x17000C0B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GameActionItemConsumeRequest> Parser
	{
		[Token(Token = "0x60038A5")]
		[Address(RVA = "0xA1BA50", Offset = "0xA1AE50", VA = "0x180A1BA50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C0C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60038A6")]
		[Address(RVA = "0xA1B9A0", Offset = "0xA1ADA0", VA = "0x180A1B9A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C0D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60038A7")]
		[Address(RVA = "0xA1BAA0", Offset = "0xA1AEA0", VA = "0x180A1BAA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C0E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ActionId
	{
		[Token(Token = "0x60038AB")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60038AC")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000C0F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x60038AD")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60038AE")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60038A8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemConsumeRequest()
	{
	}

	[Token(Token = "0x60038A9")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemConsumeRequest(GameActionItemConsumeRequest other)
	{
	}

	[Token(Token = "0x60038AA")]
	[Address(RVA = "0xA1B710", Offset = "0xA1AB10", VA = "0x180A1B710", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemConsumeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60038AF")]
	[Address(RVA = "0xA1B7A0", Offset = "0xA1ABA0", VA = "0x180A1B7A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60038B0")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameActionItemConsumeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60038B1")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60038B2")]
	[Address(RVA = "0xA1B840", Offset = "0xA1AC40", VA = "0x180A1B840", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60038B3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60038B4")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60038B5")]
	[Address(RVA = "0xA1B650", Offset = "0xA1AA50", VA = "0x180A1B650", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60038B6")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameActionItemConsumeRequest other)
	{
	}

	[Token(Token = "0x60038B7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60038B8")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
