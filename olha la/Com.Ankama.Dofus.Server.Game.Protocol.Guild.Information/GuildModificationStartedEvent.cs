using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004AE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildModificationStartedEvent : IMessage<GuildModificationStartedEvent>, IMessage, IEquatable<GuildModificationStartedEvent>, IDeepCloneable<GuildModificationStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4001000")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildModificationStartedEvent> _parser;

	[Token(Token = "0x4001001")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001002")]
	public const int CanChangeNameFieldNumber = 1;

	[Token(Token = "0x4001003")]
	[FieldOffset(Offset = "0x18")]
	private bool canChangeName_;

	[Token(Token = "0x4001004")]
	public const int CanChangeEmblemFieldNumber = 2;

	[Token(Token = "0x4001005")]
	[FieldOffset(Offset = "0x19")]
	private bool canChangeEmblem_;

	[Token(Token = "0x17000A7B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildModificationStartedEvent> Parser
	{
		[Token(Token = "0x600314B")]
		[Address(RVA = "0x9DA240", Offset = "0x9D9640", VA = "0x1809DA240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A7C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600314C")]
		[Address(RVA = "0x9DA190", Offset = "0x9D9590", VA = "0x1809DA190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A7D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600314D")]
		[Address(RVA = "0x9DA3D0", Offset = "0x9D97D0", VA = "0x1809DA3D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A7E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CanChangeName
	{
		[Token(Token = "0x6003151")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003152")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000A7F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CanChangeEmblem
	{
		[Token(Token = "0x6003153")]
		[Address(RVA = "0x87EAB0", Offset = "0x87DEB0", VA = "0x18087EAB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003154")]
		[Address(RVA = "0x87EAF0", Offset = "0x87DEF0", VA = "0x18087EAF0")]
		set
		{
		}
	}

	[Token(Token = "0x600314E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildModificationStartedEvent()
	{
	}

	[Token(Token = "0x600314F")]
	[Address(RVA = "0x9DA130", Offset = "0x9D9530", VA = "0x1809DA130")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildModificationStartedEvent(GuildModificationStartedEvent other)
	{
	}

	[Token(Token = "0x6003150")]
	[Address(RVA = "0x9D9D30", Offset = "0x9D9130", VA = "0x1809D9D30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildModificationStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003155")]
	[Address(RVA = "0x9D9E00", Offset = "0x9D9200", VA = "0x1809D9E00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003156")]
	[Address(RVA = "0x9D9DC0", Offset = "0x9D91C0", VA = "0x1809D9DC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildModificationStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003157")]
	[Address(RVA = "0x9D9EA0", Offset = "0x9D92A0", VA = "0x1809D9EA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003158")]
	[Address(RVA = "0x9D9FD0", Offset = "0x9D93D0", VA = "0x1809D9FD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003159")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600315A")]
	[Address(RVA = "0x9DA350", Offset = "0x9D9750", VA = "0x1809DA350", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600315B")]
	[Address(RVA = "0x9D9CF0", Offset = "0x9D90F0", VA = "0x1809D9CF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600315C")]
	[Address(RVA = "0x9D9F70", Offset = "0x9D9370", VA = "0x1809D9F70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildModificationStartedEvent other)
	{
	}

	[Token(Token = "0x600315D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600315E")]
	[Address(RVA = "0x9DA290", Offset = "0x9D9690", VA = "0x1809DA290", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
