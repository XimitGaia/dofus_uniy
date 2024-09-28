using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x2000561")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionAcknowledgementRequest : IMessage<GameActionAcknowledgementRequest>, IMessage, IEquatable<GameActionAcknowledgementRequest>, IDeepCloneable<GameActionAcknowledgementRequest>, IBufferMessage
{
	[Token(Token = "0x4001275")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionAcknowledgementRequest> _parser;

	[Token(Token = "0x4001276")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001277")]
	public const int ValidFieldNumber = 1;

	[Token(Token = "0x4001278")]
	[FieldOffset(Offset = "0x18")]
	private bool valid_;

	[Token(Token = "0x4001279")]
	public const int ActionIdFieldNumber = 2;

	[Token(Token = "0x400127A")]
	[FieldOffset(Offset = "0x1C")]
	private int actionId_;

	[Token(Token = "0x17000C1E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GameActionAcknowledgementRequest> Parser
	{
		[Token(Token = "0x6003903")]
		[Address(RVA = "0xA12A30", Offset = "0xA11E30", VA = "0x180A12A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C1F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003904")]
		[Address(RVA = "0xA12980", Offset = "0xA11D80", VA = "0x180A12980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003905")]
		[Address(RVA = "0xA12B00", Offset = "0xA11F00", VA = "0x180A12B00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C21")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Valid
	{
		[Token(Token = "0x6003909")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600390A")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000C22")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ActionId
	{
		[Token(Token = "0x600390B")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600390C")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6003906")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionAcknowledgementRequest()
	{
	}

	[Token(Token = "0x6003907")]
	[Address(RVA = "0x940340", Offset = "0x93F740", VA = "0x180940340")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionAcknowledgementRequest(GameActionAcknowledgementRequest other)
	{
	}

	[Token(Token = "0x6003908")]
	[Address(RVA = "0xA12640", Offset = "0xA11A40", VA = "0x180A12640", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionAcknowledgementRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600390D")]
	[Address(RVA = "0xA126D0", Offset = "0xA11AD0", VA = "0x180A126D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600390E")]
	[Address(RVA = "0x940080", Offset = "0x93F480", VA = "0x180940080", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameActionAcknowledgementRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600390F")]
	[Address(RVA = "0xA12760", Offset = "0xA11B60", VA = "0x180A12760", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003910")]
	[Address(RVA = "0xA12820", Offset = "0xA11C20", VA = "0x180A12820", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003911")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003912")]
	[Address(RVA = "0xA12A80", Offset = "0xA11E80", VA = "0x180A12A80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003913")]
	[Address(RVA = "0xA125A0", Offset = "0xA119A0", VA = "0x180A125A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003914")]
	[Address(RVA = "0x940180", Offset = "0x93F580", VA = "0x180940180", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GameActionAcknowledgementRequest other)
	{
	}

	[Token(Token = "0x6003915")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003916")]
	[Address(RVA = "0x9404A0", Offset = "0x93F8A0", VA = "0x1809404A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
