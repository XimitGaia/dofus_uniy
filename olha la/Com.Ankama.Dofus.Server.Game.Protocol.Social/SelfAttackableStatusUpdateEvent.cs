using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x200013F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SelfAttackableStatusUpdateEvent : IMessage<SelfAttackableStatusUpdateEvent>, IMessage, IEquatable<SelfAttackableStatusUpdateEvent>, IDeepCloneable<SelfAttackableStatusUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SelfAttackableStatusUpdateEvent> _parser;

	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000445")]
	public const int StatusFieldNumber = 1;

	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x18")]
	private AttackableStatus status_;

	[Token(Token = "0x4000447")]
	public const int ProbationTimeFieldNumber = 2;

	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x20")]
	private long probationTime_;

	[Token(Token = "0x4000449")]
	public const int KothRoleFieldNumber = 3;

	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x28")]
	private int kothRole_;

	[Token(Token = "0x400044B")]
	public const int PictoScoreFieldNumber = 4;

	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x2C")]
	private int pictoScore_;

	[Token(Token = "0x170002A6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SelfAttackableStatusUpdateEvent> Parser
	{
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0xB6ACD0", Offset = "0xB6A0D0", VA = "0x180B6ACD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0xB6AC20", Offset = "0xB6A020", VA = "0x180B6AC20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0xB6AEE0", Offset = "0xB6A2E0", VA = "0x180B6AEE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttackableStatus Status
	{
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(AttackableStatus);
		}
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170002AA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ProbationTime
	{
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170002AB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int KothRole
	{
		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170002AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PictoScore
	{
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SelfAttackableStatusUpdateEvent()
	{
	}

	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0xB6ABC0", Offset = "0xB69FC0", VA = "0x180B6ABC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SelfAttackableStatusUpdateEvent(SelfAttackableStatusUpdateEvent other)
	{
	}

	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0xB6A7A0", Offset = "0xB69BA0", VA = "0x180B6A7A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelfAttackableStatusUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000C77")]
	[Address(RVA = "0xB6A830", Offset = "0xB69C30", VA = "0x180B6A830", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C78")]
	[Address(RVA = "0xB6A8E0", Offset = "0xB69CE0", VA = "0x180B6A8E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SelfAttackableStatusUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C79")]
	[Address(RVA = "0xB6A930", Offset = "0xB69D30", VA = "0x180B6A930", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0xB6AA60", Offset = "0xB69E60", VA = "0x180B6AA60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0xB6AE20", Offset = "0xB6A220", VA = "0x180B6AE20", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0xB6A690", Offset = "0xB69A90", VA = "0x180B6A690", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0xB6A9F0", Offset = "0xB69DF0", VA = "0x180B6A9F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SelfAttackableStatusUpdateEvent other)
	{
	}

	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000C80")]
	[Address(RVA = "0xB6AD20", Offset = "0xB6A120", VA = "0x180B6AD20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
