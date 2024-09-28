using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CD0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceBulletinSetErrorEvent : IMessage<AllianceBulletinSetErrorEvent>, IMessage, IEquatable<AllianceBulletinSetErrorEvent>, IDeepCloneable<AllianceBulletinSetErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4002F3D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceBulletinSetErrorEvent> _parser;

	[Token(Token = "0x4002F3E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F3F")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4002F40")]
	[FieldOffset(Offset = "0x18")]
	private SocialNoticeError reason_;

	[Token(Token = "0x17001D8A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceBulletinSetErrorEvent> Parser
	{
		[Token(Token = "0x600870A")]
		[Address(RVA = "0xC88830", Offset = "0xC87C30", VA = "0x180C88830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D8B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600870B")]
		[Address(RVA = "0xC88780", Offset = "0xC87B80", VA = "0x180C88780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D8C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600870C")]
		[Address(RVA = "0xC88880", Offset = "0xC87C80", VA = "0x180C88880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D8D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialNoticeError Reason
	{
		[Token(Token = "0x6008710")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SocialNoticeError);
		}
		[Token(Token = "0x6008711")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600870D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceBulletinSetErrorEvent()
	{
	}

	[Token(Token = "0x600870E")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceBulletinSetErrorEvent(AllianceBulletinSetErrorEvent other)
	{
	}

	[Token(Token = "0x600870F")]
	[Address(RVA = "0xC88510", Offset = "0xC87910", VA = "0x180C88510", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceBulletinSetErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008712")]
	[Address(RVA = "0xC88590", Offset = "0xC87990", VA = "0x180C88590", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008713")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceBulletinSetErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008714")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008715")]
	[Address(RVA = "0xC88620", Offset = "0xC87A20", VA = "0x180C88620", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008716")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008717")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008718")]
	[Address(RVA = "0xC88480", Offset = "0xC87880", VA = "0x180C88480", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008719")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceBulletinSetErrorEvent other)
	{
	}

	[Token(Token = "0x600871A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600871B")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
