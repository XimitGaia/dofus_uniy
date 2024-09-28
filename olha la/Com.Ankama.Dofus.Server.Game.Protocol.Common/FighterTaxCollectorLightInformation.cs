using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A1A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FighterTaxCollectorLightInformation : IMessage<FighterTaxCollectorLightInformation>, IMessage, IEquatable<FighterTaxCollectorLightInformation>, IDeepCloneable<FighterTaxCollectorLightInformation>, IBufferMessage
{
	[Token(Token = "0x400243A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FighterTaxCollectorLightInformation> _parser;

	[Token(Token = "0x400243B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400243C")]
	public const int FirstNameIdFieldNumber = 1;

	[Token(Token = "0x400243D")]
	[FieldOffset(Offset = "0x18")]
	private int firstNameId_;

	[Token(Token = "0x400243E")]
	public const int LastNameIdFieldNumber = 2;

	[Token(Token = "0x400243F")]
	[FieldOffset(Offset = "0x1C")]
	private int lastNameId_;

	[Token(Token = "0x170016BA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FighterTaxCollectorLightInformation> Parser
	{
		[Token(Token = "0x6006972")]
		[Address(RVA = "0xBC5760", Offset = "0xBC4B60", VA = "0x180BC5760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016BB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006973")]
		[Address(RVA = "0xBC56B0", Offset = "0xBC4AB0", VA = "0x180BC56B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016BC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006974")]
		[Address(RVA = "0xBC57B0", Offset = "0xBC4BB0", VA = "0x180BC57B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016BD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FirstNameId
	{
		[Token(Token = "0x6006978")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006979")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170016BE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastNameId
	{
		[Token(Token = "0x600697A")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600697B")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6006975")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FighterTaxCollectorLightInformation()
	{
	}

	[Token(Token = "0x6006976")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FighterTaxCollectorLightInformation(FighterTaxCollectorLightInformation other)
	{
	}

	[Token(Token = "0x6006977")]
	[Address(RVA = "0xBC5430", Offset = "0xBC4830", VA = "0x180BC5430", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterTaxCollectorLightInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600697C")]
	[Address(RVA = "0xBC54C0", Offset = "0xBC48C0", VA = "0x180BC54C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600697D")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FighterTaxCollectorLightInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600697E")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600697F")]
	[Address(RVA = "0xBC5550", Offset = "0xBC4950", VA = "0x180BC5550", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006980")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006981")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006982")]
	[Address(RVA = "0xBC5370", Offset = "0xBC4770", VA = "0x180BC5370", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006983")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FighterTaxCollectorLightInformation other)
	{
	}

	[Token(Token = "0x6006984")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006985")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
