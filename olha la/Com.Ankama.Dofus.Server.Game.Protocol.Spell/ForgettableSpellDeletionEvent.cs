using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x200010C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellDeletionEvent : IMessage<ForgettableSpellDeletionEvent>, IMessage, IEquatable<ForgettableSpellDeletionEvent>, IDeepCloneable<ForgettableSpellDeletionEvent>, IBufferMessage
{
	[Token(Token = "0x200010D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x200010E")]
		public enum DeletionReason
		{
			[Token(Token = "0x400038F")]
			[OriginalName("UNKNOWN")]
			Unknown,
			[Token(Token = "0x4000390")]
			[OriginalName("ADMIN_COMMAND_REQUEST")]
			AdminCommandRequest,
			[Token(Token = "0x4000391")]
			[OriginalName("FORGOTTEN")]
			Forgotten,
			[Token(Token = "0x4000392")]
			[OriginalName("DISABLED")]
			Disabled,
			[Token(Token = "0x4000393")]
			[OriginalName("NOT_FOUND")]
			NotFound
		}
	}

	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellDeletionEvent> _parser;

	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000389")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x18")]
	private Types.DeletionReason reason_;

	[Token(Token = "0x400038B")]
	public const int SpellsFieldNumber = 2;

	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_spells_codec;

	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> spells_;

	[Token(Token = "0x17000231")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ForgettableSpellDeletionEvent> Parser
	{
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xB66390", Offset = "0xB65790", VA = "0x180B66390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000232")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xB662E0", Offset = "0xB656E0", VA = "0x180B662E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000233")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xB665E0", Offset = "0xB659E0", VA = "0x180B665E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000234")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.DeletionReason Reason
	{
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.DeletionReason);
		}
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000235")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Spells
	{
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000A62")]
	[Address(RVA = "0xB661D0", Offset = "0xB655D0", VA = "0x180B661D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellDeletionEvent()
	{
	}

	[Token(Token = "0x6000A63")]
	[Address(RVA = "0xB66250", Offset = "0xB65650", VA = "0x180B66250")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellDeletionEvent(ForgettableSpellDeletionEvent other)
	{
	}

	[Token(Token = "0x6000A64")]
	[Address(RVA = "0xB65D70", Offset = "0xB65170", VA = "0x180B65D70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellDeletionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000A68")]
	[Address(RVA = "0xB65E30", Offset = "0xB65230", VA = "0x180B65E30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A69")]
	[Address(RVA = "0xB65F10", Offset = "0xB65310", VA = "0x180B65F10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellDeletionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A6A")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000A6B")]
	[Address(RVA = "0xB66040", Offset = "0xB65440", VA = "0x180B66040", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000A6D")]
	[Address(RVA = "0xB66510", Offset = "0xB65910", VA = "0x180B66510", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0xB65C90", Offset = "0xB65090", VA = "0x180B65C90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000A6F")]
	[Address(RVA = "0xB65FB0", Offset = "0xB653B0", VA = "0x180B65FB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ForgettableSpellDeletionEvent other)
	{
	}

	[Token(Token = "0x6000A70")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000A71")]
	[Address(RVA = "0xB663E0", Offset = "0xB657E0", VA = "0x180B663E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
