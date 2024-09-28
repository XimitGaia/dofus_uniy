using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C74")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationReceivedEvent : IMessage<AllianceApplicationReceivedEvent>, IMessage, IEquatable<AllianceApplicationReceivedEvent>, IDeepCloneable<AllianceApplicationReceivedEvent>, IBufferMessage
{
	[Token(Token = "0x4002E0A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationReceivedEvent> _parser;

	[Token(Token = "0x4002E0B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E0C")]
	public const int PlayerNameFieldNumber = 1;

	[Token(Token = "0x4002E0D")]
	[FieldOffset(Offset = "0x18")]
	private string playerName_;

	[Token(Token = "0x4002E0E")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4002E0F")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x17001CB9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceApplicationReceivedEvent> Parser
	{
		[Token(Token = "0x6008318")]
		[Address(RVA = "0xC73220", Offset = "0xC72620", VA = "0x180C73220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CBA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008319")]
		[Address(RVA = "0xC73170", Offset = "0xC72570", VA = "0x180C73170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CBB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600831A")]
		[Address(RVA = "0xC73350", Offset = "0xC72750", VA = "0x180C73350", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CBC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PlayerName
	{
		[Token(Token = "0x600831E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600831F")]
		[Address(RVA = "0xC73430", Offset = "0xC72830", VA = "0x180C73430")]
		set
		{
		}
	}

	[Token(Token = "0x17001CBD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x6008320")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008321")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x600831B")]
	[Address(RVA = "0xC73070", Offset = "0xC72470", VA = "0x180C73070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationReceivedEvent()
	{
	}

	[Token(Token = "0x600831C")]
	[Address(RVA = "0xC730C0", Offset = "0xC724C0", VA = "0x180C730C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationReceivedEvent(AllianceApplicationReceivedEvent other)
	{
	}

	[Token(Token = "0x600831D")]
	[Address(RVA = "0xC72D10", Offset = "0xC72110", VA = "0x180C72D10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationReceivedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008322")]
	[Address(RVA = "0xC72DE0", Offset = "0xC721E0", VA = "0x180C72DE0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008323")]
	[Address(RVA = "0xA00460", Offset = "0x9FF860", VA = "0x180A00460", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceApplicationReceivedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008324")]
	[Address(RVA = "0xA004D0", Offset = "0x9FF8D0", VA = "0x180A004D0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008325")]
	[Address(RVA = "0xC72F10", Offset = "0xC72310", VA = "0x180C72F10", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008326")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008327")]
	[Address(RVA = "0xA00A10", Offset = "0x9FFE10", VA = "0x180A00A10", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008328")]
	[Address(RVA = "0xC72C50", Offset = "0xC72050", VA = "0x180C72C50", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008329")]
	[Address(RVA = "0xC72EA0", Offset = "0xC722A0", VA = "0x180C72EA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceApplicationReceivedEvent other)
	{
	}

	[Token(Token = "0x600832A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600832B")]
	[Address(RVA = "0xC73270", Offset = "0xC72670", VA = "0x180C73270", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
