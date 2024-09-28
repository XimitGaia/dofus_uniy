using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x2000180")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DelayedActionFinishedEvent : IMessage<DelayedActionFinishedEvent>, IMessage, IEquatable<DelayedActionFinishedEvent>, IDeepCloneable<DelayedActionFinishedEvent>, IBufferMessage
{
	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DelayedActionFinishedEvent> _parser;

	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000525")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x4000527")]
	public const int DelayedActionTypeFieldNumber = 2;

	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x20")]
	private DelayedActionType delayedActionType_;

	[Token(Token = "0x1700033E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<DelayedActionFinishedEvent> Parser
	{
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0xC440A0", Offset = "0xC434A0", VA = "0x180C440A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700033F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0xC43FF0", Offset = "0xC433F0", VA = "0x180C43FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000340")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0xC440F0", Offset = "0xC434F0", VA = "0x180C440F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000341")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000342")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelayedActionType DelayedActionType
	{
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(DelayedActionType);
		}
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelayedActionFinishedEvent()
	{
	}

	[Token(Token = "0x6000F23")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelayedActionFinishedEvent(DelayedActionFinishedEvent other)
	{
	}

	[Token(Token = "0x6000F24")]
	[Address(RVA = "0xC43D60", Offset = "0xC43160", VA = "0x180C43D60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DelayedActionFinishedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000F29")]
	[Address(RVA = "0xC43DF0", Offset = "0xC431F0", VA = "0x180C43DF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F2A")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(DelayedActionFinishedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F2B")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000F2C")]
	[Address(RVA = "0xC43E90", Offset = "0xC43290", VA = "0x180C43E90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000F2D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0x948ED0", Offset = "0x9482D0", VA = "0x180948ED0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0xC43CA0", Offset = "0xC430A0", VA = "0x180C43CA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000F30")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(DelayedActionFinishedEvent other)
	{
	}

	[Token(Token = "0x6000F31")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000F32")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
