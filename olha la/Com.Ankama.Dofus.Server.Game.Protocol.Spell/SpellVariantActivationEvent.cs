using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x2000108")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpellVariantActivationEvent : IMessage<SpellVariantActivationEvent>, IMessage, IEquatable<SpellVariantActivationEvent>, IDeepCloneable<SpellVariantActivationEvent>, IBufferMessage
{
	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpellVariantActivationEvent> _parser;

	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400037D")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x18")]
	private int spellId_;

	[Token(Token = "0x400037F")]
	public const int EffectiveFieldNumber = 2;

	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x1C")]
	private bool effective_;

	[Token(Token = "0x17000228")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SpellVariantActivationEvent> Parser
	{
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xB71F20", Offset = "0xB71320", VA = "0x180B71F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000229")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xB71E70", Offset = "0xB71270", VA = "0x180B71E70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xB71F70", Offset = "0xB71370", VA = "0x180B71F70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpellId
	{
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700022C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Effective
	{
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6000A34")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellVariantActivationEvent()
	{
	}

	[Token(Token = "0x6000A35")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellVariantActivationEvent(SpellVariantActivationEvent other)
	{
	}

	[Token(Token = "0x6000A36")]
	[Address(RVA = "0xB71B30", Offset = "0xB70F30", VA = "0x180B71B30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellVariantActivationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0xB71BC0", Offset = "0xB70FC0", VA = "0x180B71BC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SpellVariantActivationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0xB71C50", Offset = "0xB71050", VA = "0x180B71C50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000A3E")]
	[Address(RVA = "0xB71D10", Offset = "0xB71110", VA = "0x180B71D10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000A3F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000A40")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000A41")]
	[Address(RVA = "0xB71AA0", Offset = "0xB70EA0", VA = "0x180B71AA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000A42")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SpellVariantActivationEvent other)
	{
	}

	[Token(Token = "0x6000A43")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
