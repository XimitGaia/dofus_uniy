using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CCE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceBulletinEvent : IMessage<AllianceBulletinEvent>, IMessage, IEquatable<AllianceBulletinEvent>, IDeepCloneable<AllianceBulletinEvent>, IBufferMessage
{
	[Token(Token = "0x4002F38")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceBulletinEvent> _parser;

	[Token(Token = "0x4002F39")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F3A")]
	public const int BulletinInfoFieldNumber = 1;

	[Token(Token = "0x4002F3B")]
	[FieldOffset(Offset = "0x18")]
	private SocialNoticeInformation bulletinInfo_;

	[Token(Token = "0x17001D86")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceBulletinEvent> Parser
	{
		[Token(Token = "0x60086F4")]
		[Address(RVA = "0xC88250", Offset = "0xC87650", VA = "0x180C88250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D87")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60086F5")]
		[Address(RVA = "0xC881A0", Offset = "0xC875A0", VA = "0x180C881A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D88")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60086F6")]
		[Address(RVA = "0xC883A0", Offset = "0xC877A0", VA = "0x180C883A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D89")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialNoticeInformation BulletinInfo
	{
		[Token(Token = "0x60086FA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086FB")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60086F7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceBulletinEvent()
	{
	}

	[Token(Token = "0x60086F8")]
	[Address(RVA = "0x9E9A90", Offset = "0x9E8E90", VA = "0x1809E9A90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceBulletinEvent(AllianceBulletinEvent other)
	{
	}

	[Token(Token = "0x60086F9")]
	[Address(RVA = "0xC87E20", Offset = "0xC87220", VA = "0x180C87E20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceBulletinEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60086FC")]
	[Address(RVA = "0xC87EC0", Offset = "0xC872C0", VA = "0x180C87EC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60086FD")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceBulletinEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60086FE")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60086FF")]
	[Address(RVA = "0xC88040", Offset = "0xC87440", VA = "0x180C88040", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008700")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008701")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008702")]
	[Address(RVA = "0xC87D90", Offset = "0xC87190", VA = "0x180C87D90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008703")]
	[Address(RVA = "0xC87F70", Offset = "0xC87370", VA = "0x180C87F70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceBulletinEvent other)
	{
	}

	[Token(Token = "0x6008704")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008705")]
	[Address(RVA = "0xC882A0", Offset = "0xC876A0", VA = "0x180C882A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
