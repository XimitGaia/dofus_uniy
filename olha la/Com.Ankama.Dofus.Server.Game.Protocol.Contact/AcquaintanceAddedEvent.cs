using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007CC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AcquaintanceAddedEvent : IMessage<AcquaintanceAddedEvent>, IMessage, IEquatable<AcquaintanceAddedEvent>, IDeepCloneable<AcquaintanceAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4001B08")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AcquaintanceAddedEvent> _parser;

	[Token(Token = "0x4001B09")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B0A")]
	public const int AcquaintanceFieldNumber = 1;

	[Token(Token = "0x4001B0B")]
	[FieldOffset(Offset = "0x18")]
	private AcquaintanceInformation acquaintance_;

	[Token(Token = "0x170011A9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AcquaintanceAddedEvent> Parser
	{
		[Token(Token = "0x60052E6")]
		[Address(RVA = "0xAE3CD0", Offset = "0xAE30D0", VA = "0x180AE3CD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011AA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60052E7")]
		[Address(RVA = "0xAE3C20", Offset = "0xAE3020", VA = "0x180AE3C20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011AB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60052E8")]
		[Address(RVA = "0xAE3E20", Offset = "0xAE3220", VA = "0x180AE3E20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AcquaintanceInformation Acquaintance
	{
		[Token(Token = "0x60052EC")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60052ED")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60052E9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AcquaintanceAddedEvent()
	{
	}

	[Token(Token = "0x60052EA")]
	[Address(RVA = "0xAE3BB0", Offset = "0xAE2FB0", VA = "0x180AE3BB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcquaintanceAddedEvent(AcquaintanceAddedEvent other)
	{
	}

	[Token(Token = "0x60052EB")]
	[Address(RVA = "0xAE3830", Offset = "0xAE2C30", VA = "0x180AE3830", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcquaintanceAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60052EE")]
	[Address(RVA = "0xAE38D0", Offset = "0xAE2CD0", VA = "0x180AE38D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60052EF")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AcquaintanceAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60052F0")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60052F1")]
	[Address(RVA = "0xAE3A50", Offset = "0xAE2E50", VA = "0x180AE3A50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60052F2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60052F3")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60052F4")]
	[Address(RVA = "0xAE37A0", Offset = "0xAE2BA0", VA = "0x180AE37A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60052F5")]
	[Address(RVA = "0xAE3980", Offset = "0xAE2D80", VA = "0x180AE3980", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AcquaintanceAddedEvent other)
	{
	}

	[Token(Token = "0x60052F6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60052F7")]
	[Address(RVA = "0xAE3D20", Offset = "0xAE3120", VA = "0x180AE3D20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
