using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007D4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class WarnOnPermanentDeathStateEvent : IMessage<WarnOnPermanentDeathStateEvent>, IMessage, IEquatable<WarnOnPermanentDeathStateEvent>, IDeepCloneable<WarnOnPermanentDeathStateEvent>, IBufferMessage
{
	[Token(Token = "0x4001B1E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<WarnOnPermanentDeathStateEvent> _parser;

	[Token(Token = "0x4001B1F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B20")]
	public const int EnableFieldNumber = 1;

	[Token(Token = "0x4001B21")]
	[FieldOffset(Offset = "0x18")]
	private bool enable_;

	[Token(Token = "0x170011BA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<WarnOnPermanentDeathStateEvent> Parser
	{
		[Token(Token = "0x6005340")]
		[Address(RVA = "0xAFA770", Offset = "0xAF9B70", VA = "0x180AFA770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011BB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005341")]
		[Address(RVA = "0xAFA6C0", Offset = "0xAF9AC0", VA = "0x180AFA6C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011BC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005342")]
		[Address(RVA = "0xAFA7C0", Offset = "0xAF9BC0", VA = "0x180AFA7C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011BD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Enable
	{
		[Token(Token = "0x6005346")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005347")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6005343")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WarnOnPermanentDeathStateEvent()
	{
	}

	[Token(Token = "0x6005344")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WarnOnPermanentDeathStateEvent(WarnOnPermanentDeathStateEvent other)
	{
	}

	[Token(Token = "0x6005345")]
	[Address(RVA = "0xAFA3B0", Offset = "0xAF97B0", VA = "0x180AFA3B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WarnOnPermanentDeathStateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005348")]
	[Address(RVA = "0xAFA430", Offset = "0xAF9830", VA = "0x180AFA430", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005349")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(WarnOnPermanentDeathStateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600534A")]
	[Address(RVA = "0xAFA4C0", Offset = "0xAF98C0", VA = "0x180AFA4C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600534B")]
	[Address(RVA = "0xAFA560", Offset = "0xAF9960", VA = "0x180AFA560", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600534C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600534D")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600534E")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600534F")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(WarnOnPermanentDeathStateEvent other)
	{
	}

	[Token(Token = "0x6005350")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005351")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
