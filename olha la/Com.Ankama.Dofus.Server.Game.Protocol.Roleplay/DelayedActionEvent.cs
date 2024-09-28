using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x200017E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DelayedActionEvent : IMessage<DelayedActionEvent>, IMessage, IEquatable<DelayedActionEvent>, IDeepCloneable<DelayedActionEvent>, IBufferMessage
{
	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DelayedActionEvent> _parser;

	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4000519")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x20")]
	private long characterId_;

	[Token(Token = "0x400051B")]
	public const int DelayedActionTypeFieldNumber = 2;

	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x28")]
	private DelayedActionType delayedActionType_;

	[Token(Token = "0x400051D")]
	public const int DelayedEndTimeFieldNumber = 3;

	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0x30")]
	private long delayedEndTime_;

	[Token(Token = "0x400051F")]
	public const int ObjectGidFieldNumber = 4;

	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int ObjectGidDefaultValue;

	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x38")]
	private int objectGid_;

	[Token(Token = "0x17000336")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DelayedActionEvent> Parser
	{
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0xC43960", Offset = "0xC42D60", VA = "0x180C43960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000337")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0xC43840", Offset = "0xC42C40", VA = "0x180C43840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000338")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0xC43BC0", Offset = "0xC42FC0", VA = "0x180C43BC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000339")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700033A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelayedActionType DelayedActionType
	{
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(DelayedActionType);
		}
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x1700033B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DelayedEndTime
	{
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700033C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectGid
	{
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0xC438F0", Offset = "0xC42CF0", VA = "0x180C438F0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0xA3DA40", Offset = "0xA3CE40", VA = "0x180A3DA40")]
		set
		{
		}
	}

	[Token(Token = "0x1700033D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasObjectGid
	{
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000F04")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DelayedActionEvent()
	{
	}

	[Token(Token = "0x6000F05")]
	[Address(RVA = "0xA816F0", Offset = "0xA80AF0", VA = "0x180A816F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DelayedActionEvent(DelayedActionEvent other)
	{
	}

	[Token(Token = "0x6000F06")]
	[Address(RVA = "0xC43330", Offset = "0xC42730", VA = "0x180C43330", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelayedActionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000F10")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearObjectGid()
	{
	}

	[Token(Token = "0x6000F11")]
	[Address(RVA = "0xC433D0", Offset = "0xC427D0", VA = "0x180C433D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F12")]
	[Address(RVA = "0xC434A0", Offset = "0xC428A0", VA = "0x180C434A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DelayedActionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F13")]
	[Address(RVA = "0xC43530", Offset = "0xC42930", VA = "0x180C43530", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000F14")]
	[Address(RVA = "0xC436D0", Offset = "0xC42AD0", VA = "0x180C436D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000F15")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000F16")]
	[Address(RVA = "0xC43AB0", Offset = "0xC42EB0", VA = "0x180C43AB0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000F17")]
	[Address(RVA = "0xC431D0", Offset = "0xC425D0", VA = "0x180C431D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000F18")]
	[Address(RVA = "0xC43650", Offset = "0xC42A50", VA = "0x180C43650", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DelayedActionEvent other)
	{
	}

	[Token(Token = "0x6000F19")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000F1A")]
	[Address(RVA = "0xC439B0", Offset = "0xC42DB0", VA = "0x180C439B0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
