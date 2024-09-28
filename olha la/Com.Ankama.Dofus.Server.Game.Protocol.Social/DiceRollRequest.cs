using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000136")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DiceRollRequest : IMessage<DiceRollRequest>, IMessage, IEquatable<DiceRollRequest>, IDeepCloneable<DiceRollRequest>, IBufferMessage
{
	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DiceRollRequest> _parser;

	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000426")]
	public const int DiceFieldNumber = 1;

	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x18")]
	private int dice_;

	[Token(Token = "0x4000428")]
	public const int FacesFieldNumber = 2;

	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x1C")]
	private int faces_;

	[Token(Token = "0x17000291")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DiceRollRequest> Parser
	{
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0xB65640", Offset = "0xB64A40", VA = "0x180B65640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000292")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0xB65590", Offset = "0xB64990", VA = "0x180B65590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000293")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0xB65690", Offset = "0xB64A90", VA = "0x180B65690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000294")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Dice
	{
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000295")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Faces
	{
		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DiceRollRequest()
	{
	}

	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceRollRequest(DiceRollRequest other)
	{
	}

	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0xB65310", Offset = "0xB64710", VA = "0x180B65310", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceRollRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000C12")]
	[Address(RVA = "0xB653A0", Offset = "0xB647A0", VA = "0x180B653A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DiceRollRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000C15")]
	[Address(RVA = "0xB65430", Offset = "0xB64830", VA = "0x180B65430", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000C18")]
	[Address(RVA = "0xB65250", Offset = "0xB64650", VA = "0x180B65250", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DiceRollRequest other)
	{
	}

	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
