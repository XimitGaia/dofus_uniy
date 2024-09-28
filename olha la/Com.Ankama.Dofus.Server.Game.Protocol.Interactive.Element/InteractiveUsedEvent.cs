using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element;

[Token(Token = "0x20003E4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class InteractiveUsedEvent : IMessage<InteractiveUsedEvent>, IMessage, IEquatable<InteractiveUsedEvent>, IDeepCloneable<InteractiveUsedEvent>, IBufferMessage
{
	[Token(Token = "0x4000D68")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<InteractiveUsedEvent> _parser;

	[Token(Token = "0x4000D69")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D6A")]
	public const int EntityIdFieldNumber = 1;

	[Token(Token = "0x4000D6B")]
	[FieldOffset(Offset = "0x18")]
	private long entityId_;

	[Token(Token = "0x4000D6C")]
	public const int ElementIdFieldNumber = 2;

	[Token(Token = "0x4000D6D")]
	[FieldOffset(Offset = "0x20")]
	private int elementId_;

	[Token(Token = "0x4000D6E")]
	public const int SkillIdFieldNumber = 3;

	[Token(Token = "0x4000D6F")]
	[FieldOffset(Offset = "0x24")]
	private int skillId_;

	[Token(Token = "0x4000D70")]
	public const int DurationFieldNumber = 4;

	[Token(Token = "0x4000D71")]
	[FieldOffset(Offset = "0x28")]
	private int duration_;

	[Token(Token = "0x4000D72")]
	public const int CanMoveFieldNumber = 5;

	[Token(Token = "0x4000D73")]
	[FieldOffset(Offset = "0x2C")]
	private bool canMove_;

	[Token(Token = "0x170008B4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<InteractiveUsedEvent> Parser
	{
		[Token(Token = "0x60028B9")]
		[Address(RVA = "0x9A7D60", Offset = "0x9A7160", VA = "0x1809A7D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60028BA")]
		[Address(RVA = "0x9A7CB0", Offset = "0x9A70B0", VA = "0x1809A7CB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60028BB")]
		[Address(RVA = "0x9A7FB0", Offset = "0x9A73B0", VA = "0x1809A7FB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long EntityId
	{
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60028C0")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170008B8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ElementId
	{
		[Token(Token = "0x60028C1")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028C2")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170008B9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SkillId
	{
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x170008BA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Duration
	{
		[Token(Token = "0x60028C5")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170008BB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool CanMove
	{
		[Token(Token = "0x60028C7")]
		[Address(RVA = "0x9A7CA0", Offset = "0x9A70A0", VA = "0x1809A7CA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60028C8")]
		[Address(RVA = "0x9A8090", Offset = "0x9A7490", VA = "0x1809A8090")]
		set
		{
		}
	}

	[Token(Token = "0x60028BC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveUsedEvent()
	{
	}

	[Token(Token = "0x60028BD")]
	[Address(RVA = "0x9A7C30", Offset = "0x9A7030", VA = "0x1809A7C30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveUsedEvent(InteractiveUsedEvent other)
	{
	}

	[Token(Token = "0x60028BE")]
	[Address(RVA = "0x9A77A0", Offset = "0x9A6BA0", VA = "0x1809A77A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveUsedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60028C9")]
	[Address(RVA = "0x9A7890", Offset = "0x9A6C90", VA = "0x1809A7890", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60028CA")]
	[Address(RVA = "0x9A7840", Offset = "0x9A6C40", VA = "0x1809A7840", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(InteractiveUsedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60028CB")]
	[Address(RVA = "0x9A7940", Offset = "0x9A6D40", VA = "0x1809A7940", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60028CC")]
	[Address(RVA = "0x9A7AD0", Offset = "0x9A6ED0", VA = "0x1809A7AD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60028CD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60028CE")]
	[Address(RVA = "0x9A7ED0", Offset = "0x9A72D0", VA = "0x1809A7ED0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60028CF")]
	[Address(RVA = "0x9A7680", Offset = "0x9A6A80", VA = "0x1809A7680", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60028D0")]
	[Address(RVA = "0x9A7A50", Offset = "0x9A6E50", VA = "0x1809A7A50", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(InteractiveUsedEvent other)
	{
	}

	[Token(Token = "0x60028D1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60028D2")]
	[Address(RVA = "0x9A7DB0", Offset = "0x9A71B0", VA = "0x1809A7DB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
