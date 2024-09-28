using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002EB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlaySpellScriptOnNpcEvent : IMessage<PlaySpellScriptOnNpcEvent>, IMessage, IEquatable<PlaySpellScriptOnNpcEvent>, IDeepCloneable<PlaySpellScriptOnNpcEvent>, IBufferMessage
{
	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlaySpellScriptOnNpcEvent> _parser;

	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A4C")]
	public const int NpcIdFieldNumber = 1;

	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0x18")]
	private int npcId_;

	[Token(Token = "0x4000A4E")]
	public const int ScriptIdFieldNumber = 2;

	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0x1C")]
	private int scriptId_;

	[Token(Token = "0x1700068D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlaySpellScriptOnNpcEvent> Parser
	{
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0xD2D2B0", Offset = "0xD2C6B0", VA = "0x180D2D2B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700068E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0xD2D200", Offset = "0xD2C600", VA = "0x180D2D200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700068F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0xD2D300", Offset = "0xD2C700", VA = "0x180D2D300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000690")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NpcId
	{
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000691")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ScriptId
	{
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6001E4F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlaySpellScriptOnNpcEvent()
	{
	}

	[Token(Token = "0x6001E50")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlaySpellScriptOnNpcEvent(PlaySpellScriptOnNpcEvent other)
	{
	}

	[Token(Token = "0x6001E51")]
	[Address(RVA = "0xD2CF80", Offset = "0xD2C380", VA = "0x180D2CF80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlaySpellScriptOnNpcEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001E56")]
	[Address(RVA = "0xD2D010", Offset = "0xD2C410", VA = "0x180D2D010", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E57")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PlaySpellScriptOnNpcEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E58")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001E59")]
	[Address(RVA = "0xD2D0A0", Offset = "0xD2C4A0", VA = "0x180D2D0A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001E5A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001E5B")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001E5C")]
	[Address(RVA = "0xD2CEC0", Offset = "0xD2C2C0", VA = "0x180D2CEC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001E5D")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PlaySpellScriptOnNpcEvent other)
	{
	}

	[Token(Token = "0x6001E5E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001E5F")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
