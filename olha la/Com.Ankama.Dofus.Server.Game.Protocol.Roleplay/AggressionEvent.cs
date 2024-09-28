using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x200016E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AggressionEvent : IMessage<AggressionEvent>, IMessage, IEquatable<AggressionEvent>, IDeepCloneable<AggressionEvent>, IBufferMessage
{
	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AggressionEvent> _parser;

	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004D4")]
	public const int AttackerIdFieldNumber = 1;

	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x18")]
	private long attackerId_;

	[Token(Token = "0x40004D6")]
	public const int DefenderIdFieldNumber = 2;

	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x20")]
	private long defenderId_;

	[Token(Token = "0x17000308")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AggressionEvent> Parser
	{
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0xC422A0", Offset = "0xC416A0", VA = "0x180C422A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000309")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0xC421F0", Offset = "0xC415F0", VA = "0x180C421F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700030A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0xC422F0", Offset = "0xC416F0", VA = "0x180C422F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700030B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long AttackerId
	{
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700030C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long DefenderId
	{
		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AggressionEvent()
	{
	}

	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x951C30", Offset = "0x951030", VA = "0x180951C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AggressionEvent(AggressionEvent other)
	{
	}

	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0xC41F60", Offset = "0xC41360", VA = "0x180C41F60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AggressionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0xC41FF0", Offset = "0xC413F0", VA = "0x180C41FF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x951900", Offset = "0x950D00", VA = "0x180951900", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AggressionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x9519E0", Offset = "0x950DE0", VA = "0x1809519E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000E42")]
	[Address(RVA = "0xC42090", Offset = "0xC41490", VA = "0x180C42090", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x951E40", Offset = "0x951240", VA = "0x180951E40", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000E45")]
	[Address(RVA = "0xC41EA0", Offset = "0xC412A0", VA = "0x180C41EA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x951A70", Offset = "0x950E70", VA = "0x180951A70", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AggressionEvent other)
	{
	}

	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x951D90", Offset = "0x951190", VA = "0x180951D90", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
