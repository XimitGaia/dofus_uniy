using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x2000565")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionItemConsumedEvent : IMessage<GameActionItemConsumedEvent>, IMessage, IEquatable<GameActionItemConsumedEvent>, IDeepCloneable<GameActionItemConsumedEvent>, IBufferMessage
{
	[Token(Token = "0x4001282")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionItemConsumedEvent> _parser;

	[Token(Token = "0x4001283")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001284")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4001285")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x4001286")]
	public const int ActionIdFieldNumber = 2;

	[Token(Token = "0x4001287")]
	[FieldOffset(Offset = "0x1C")]
	private int actionId_;

	[Token(Token = "0x4001288")]
	public const int AutomaticActionFieldNumber = 3;

	[Token(Token = "0x4001289")]
	[FieldOffset(Offset = "0x20")]
	private bool automaticAction_;

	[Token(Token = "0x17000C27")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GameActionItemConsumedEvent> Parser
	{
		[Token(Token = "0x6003930")]
		[Address(RVA = "0xA1C160", Offset = "0xA1B560", VA = "0x180A1C160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C28")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003931")]
		[Address(RVA = "0xA1C0B0", Offset = "0xA1B4B0", VA = "0x180A1C0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C29")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003932")]
		[Address(RVA = "0xA1C330", Offset = "0xA1B730", VA = "0x180A1C330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C2A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x6003936")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003937")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000C2B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ActionId
	{
		[Token(Token = "0x6003938")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003939")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000C2C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool AutomaticAction
	{
		[Token(Token = "0x600393A")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600393B")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x6003933")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemConsumedEvent()
	{
	}

	[Token(Token = "0x6003934")]
	[Address(RVA = "0xA1C050", Offset = "0xA1B450", VA = "0x180A1C050")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GameActionItemConsumedEvent(GameActionItemConsumedEvent other)
	{
	}

	[Token(Token = "0x6003935")]
	[Address(RVA = "0xA1BC20", Offset = "0xA1B020", VA = "0x180A1BC20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemConsumedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600393C")]
	[Address(RVA = "0xA1BCB0", Offset = "0xA1B0B0", VA = "0x180A1BCB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600393D")]
	[Address(RVA = "0xA1BD50", Offset = "0xA1B150", VA = "0x180A1BD50", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameActionItemConsumedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600393E")]
	[Address(RVA = "0xA1BD90", Offset = "0xA1B190", VA = "0x180A1BD90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600393F")]
	[Address(RVA = "0xA1BEF0", Offset = "0xA1B2F0", VA = "0x180A1BEF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003940")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003941")]
	[Address(RVA = "0xA1C290", Offset = "0xA1B690", VA = "0x180A1C290", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003942")]
	[Address(RVA = "0xA1BB80", Offset = "0xA1AF80", VA = "0x180A1BB80", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003943")]
	[Address(RVA = "0xA1BE80", Offset = "0xA1B280", VA = "0x180A1BE80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameActionItemConsumedEvent other)
	{
	}

	[Token(Token = "0x6003944")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003945")]
	[Address(RVA = "0xA1C1B0", Offset = "0xA1B5B0", VA = "0x180A1C1B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
