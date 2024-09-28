using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007A3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContactWarnOnAchievementCompleteSetRequest : IMessage<ContactWarnOnAchievementCompleteSetRequest>, IMessage, IEquatable<ContactWarnOnAchievementCompleteSetRequest>, IDeepCloneable<ContactWarnOnAchievementCompleteSetRequest>, IBufferMessage
{
	[Token(Token = "0x4001A96")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContactWarnOnAchievementCompleteSetRequest> _parser;

	[Token(Token = "0x4001A97")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A98")]
	public const int EnableFieldNumber = 1;

	[Token(Token = "0x4001A99")]
	[FieldOffset(Offset = "0x18")]
	private bool enable_;

	[Token(Token = "0x17001157")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContactWarnOnAchievementCompleteSetRequest> Parser
	{
		[Token(Token = "0x6005138")]
		[Address(RVA = "0xAD08C0", Offset = "0xACFCC0", VA = "0x180AD08C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001158")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005139")]
		[Address(RVA = "0xAD0810", Offset = "0xACFC10", VA = "0x180AD0810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001159")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600513A")]
		[Address(RVA = "0xAD0910", Offset = "0xACFD10", VA = "0x180AD0910", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700115A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Enable
	{
		[Token(Token = "0x600513E")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600513F")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x600513B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactWarnOnAchievementCompleteSetRequest()
	{
	}

	[Token(Token = "0x600513C")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactWarnOnAchievementCompleteSetRequest(ContactWarnOnAchievementCompleteSetRequest other)
	{
	}

	[Token(Token = "0x600513D")]
	[Address(RVA = "0xAD0500", Offset = "0xACF900", VA = "0x180AD0500", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContactWarnOnAchievementCompleteSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005140")]
	[Address(RVA = "0xAD0580", Offset = "0xACF980", VA = "0x180AD0580", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005141")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContactWarnOnAchievementCompleteSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005142")]
	[Address(RVA = "0xAD0610", Offset = "0xACFA10", VA = "0x180AD0610", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005143")]
	[Address(RVA = "0xAD06B0", Offset = "0xACFAB0", VA = "0x180AD06B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005144")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005145")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005146")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005147")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ContactWarnOnAchievementCompleteSetRequest other)
	{
	}

	[Token(Token = "0x6005148")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005149")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
