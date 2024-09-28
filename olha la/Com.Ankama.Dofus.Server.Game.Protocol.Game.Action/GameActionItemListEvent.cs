using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x2000563")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionItemListEvent : IMessage<GameActionItemListEvent>, IMessage, IEquatable<GameActionItemListEvent>, IDeepCloneable<GameActionItemListEvent>, IBufferMessage
{
	[Token(Token = "0x400127C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionItemListEvent> _parser;

	[Token(Token = "0x400127D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400127E")]
	public const int ActionsFieldNumber = 1;

	[Token(Token = "0x400127F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<GameActionItem> _repeated_actions_codec;

	[Token(Token = "0x4001280")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<GameActionItem> actions_;

	[Token(Token = "0x17000C23")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GameActionItemListEvent> Parser
	{
		[Token(Token = "0x600391B")]
		[Address(RVA = "0xA1CB20", Offset = "0xA1BF20", VA = "0x180A1CB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C24")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600391C")]
		[Address(RVA = "0xA1CA70", Offset = "0xA1BE70", VA = "0x180A1CA70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C25")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600391D")]
		[Address(RVA = "0xA1CD30", Offset = "0xA1C130", VA = "0x180A1CD30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C26")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GameActionItem> Actions
	{
		[Token(Token = "0x6003921")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600391E")]
	[Address(RVA = "0xA1C9F0", Offset = "0xA1BDF0", VA = "0x180A1C9F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemListEvent()
	{
	}

	[Token(Token = "0x600391F")]
	[Address(RVA = "0xA1C960", Offset = "0xA1BD60", VA = "0x180A1C960")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemListEvent(GameActionItemListEvent other)
	{
	}

	[Token(Token = "0x6003920")]
	[Address(RVA = "0xA1C4B0", Offset = "0xA1B8B0", VA = "0x180A1C4B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003922")]
	[Address(RVA = "0xA1C570", Offset = "0xA1B970", VA = "0x180A1C570", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003923")]
	[Address(RVA = "0xA1C650", Offset = "0xA1BA50", VA = "0x180A1C650", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameActionItemListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003924")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003925")]
	[Address(RVA = "0xA1C760", Offset = "0xA1BB60", VA = "0x180A1C760", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003926")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003927")]
	[Address(RVA = "0xA1CC80", Offset = "0xA1C080", VA = "0x180A1CC80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003928")]
	[Address(RVA = "0xA1C410", Offset = "0xA1B810", VA = "0x180A1C410", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003929")]
	[Address(RVA = "0xA1C6E0", Offset = "0xA1BAE0", VA = "0x180A1C6E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameActionItemListEvent other)
	{
	}

	[Token(Token = "0x600392A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600392B")]
	[Address(RVA = "0xA1CB70", Offset = "0xA1BF70", VA = "0x180A1CB70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
