using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007C2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContactWarnOnPermanentDeathSetRequest : IMessage<ContactWarnOnPermanentDeathSetRequest>, IMessage, IEquatable<ContactWarnOnPermanentDeathSetRequest>, IDeepCloneable<ContactWarnOnPermanentDeathSetRequest>, IBufferMessage
{
	[Token(Token = "0x4001AE9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContactWarnOnPermanentDeathSetRequest> _parser;

	[Token(Token = "0x4001AEA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001AEB")]
	public const int EnableFieldNumber = 1;

	[Token(Token = "0x4001AEC")]
	[FieldOffset(Offset = "0x18")]
	private bool enable_;

	[Token(Token = "0x17001192")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContactWarnOnPermanentDeathSetRequest> Parser
	{
		[Token(Token = "0x6005272")]
		[Address(RVA = "0xAEBD50", Offset = "0xAEB150", VA = "0x180AEBD50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001193")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005273")]
		[Address(RVA = "0xAEBCA0", Offset = "0xAEB0A0", VA = "0x180AEBCA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001194")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005274")]
		[Address(RVA = "0xAEBDA0", Offset = "0xAEB1A0", VA = "0x180AEBDA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001195")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Enable
	{
		[Token(Token = "0x6005278")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005279")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6005275")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactWarnOnPermanentDeathSetRequest()
	{
	}

	[Token(Token = "0x6005276")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactWarnOnPermanentDeathSetRequest(ContactWarnOnPermanentDeathSetRequest other)
	{
	}

	[Token(Token = "0x6005277")]
	[Address(RVA = "0xAEB990", Offset = "0xAEAD90", VA = "0x180AEB990", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactWarnOnPermanentDeathSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600527A")]
	[Address(RVA = "0xAEBA10", Offset = "0xAEAE10", VA = "0x180AEBA10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600527B")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContactWarnOnPermanentDeathSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600527C")]
	[Address(RVA = "0xAEBAA0", Offset = "0xAEAEA0", VA = "0x180AEBAA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600527D")]
	[Address(RVA = "0xAEBB40", Offset = "0xAEAF40", VA = "0x180AEBB40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600527E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600527F")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005280")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005281")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContactWarnOnPermanentDeathSetRequest other)
	{
	}

	[Token(Token = "0x6005282")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005283")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
