using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007C4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContactWarnOnAchievementCompleteStateEvent : IMessage<ContactWarnOnAchievementCompleteStateEvent>, IMessage, IEquatable<ContactWarnOnAchievementCompleteStateEvent>, IDeepCloneable<ContactWarnOnAchievementCompleteStateEvent>, IBufferMessage
{
	[Token(Token = "0x4001AEE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContactWarnOnAchievementCompleteStateEvent> _parser;

	[Token(Token = "0x4001AEF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001AF0")]
	public const int EnableFieldNumber = 1;

	[Token(Token = "0x4001AF1")]
	[FieldOffset(Offset = "0x18")]
	private bool enable_;

	[Token(Token = "0x17001196")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContactWarnOnAchievementCompleteStateEvent> Parser
	{
		[Token(Token = "0x6005288")]
		[Address(RVA = "0xAEB860", Offset = "0xAEAC60", VA = "0x180AEB860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001197")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005289")]
		[Address(RVA = "0xAEB7B0", Offset = "0xAEABB0", VA = "0x180AEB7B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001198")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600528A")]
		[Address(RVA = "0xAEB8B0", Offset = "0xAEACB0", VA = "0x180AEB8B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001199")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Enable
	{
		[Token(Token = "0x600528E")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600528F")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x600528B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactWarnOnAchievementCompleteStateEvent()
	{
	}

	[Token(Token = "0x600528C")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactWarnOnAchievementCompleteStateEvent(ContactWarnOnAchievementCompleteStateEvent other)
	{
	}

	[Token(Token = "0x600528D")]
	[Address(RVA = "0xAEB4A0", Offset = "0xAEA8A0", VA = "0x180AEB4A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContactWarnOnAchievementCompleteStateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005290")]
	[Address(RVA = "0xAEB520", Offset = "0xAEA920", VA = "0x180AEB520", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005291")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContactWarnOnAchievementCompleteStateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005292")]
	[Address(RVA = "0xAEB5B0", Offset = "0xAEA9B0", VA = "0x180AEB5B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005293")]
	[Address(RVA = "0xAEB650", Offset = "0xAEAA50", VA = "0x180AEB650", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005294")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005295")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005296")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005297")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ContactWarnOnAchievementCompleteStateEvent other)
	{
	}

	[Token(Token = "0x6005298")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005299")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
