using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D1B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementDetailsEvent : IMessage<AchievementDetailsEvent>, IMessage, IEquatable<AchievementDetailsEvent>, IDeepCloneable<AchievementDetailsEvent>, IBufferMessage
{
	[Token(Token = "0x4003012")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementDetailsEvent> _parser;

	[Token(Token = "0x4003013")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4003014")]
	public const int AchievementFieldNumber = 1;

	[Token(Token = "0x4003015")]
	[FieldOffset(Offset = "0x18")]
	private Achievement achievement_;

	[Token(Token = "0x17001E20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AchievementDetailsEvent> Parser
	{
		[Token(Token = "0x60089FD")]
		[Address(RVA = "0xCA0B70", Offset = "0xC9FF70", VA = "0x180CA0B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E21")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60089FE")]
		[Address(RVA = "0xCA0AC0", Offset = "0xC9FEC0", VA = "0x180CA0AC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E22")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60089FF")]
		[Address(RVA = "0xCA0CC0", Offset = "0xCA00C0", VA = "0x180CA0CC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E23")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Achievement Achievement
	{
		[Token(Token = "0x6008A03")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A04")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6008A00")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementDetailsEvent()
	{
	}

	[Token(Token = "0x6008A01")]
	[Address(RVA = "0xCA09A0", Offset = "0xC9FDA0", VA = "0x180CA09A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementDetailsEvent(AchievementDetailsEvent other)
	{
	}

	[Token(Token = "0x6008A02")]
	[Address(RVA = "0xCA0510", Offset = "0xC9F910", VA = "0x180CA0510", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementDetailsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008A05")]
	[Address(RVA = "0xCA0660", Offset = "0xC9FA60", VA = "0x180CA0660", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A06")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievementDetailsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A07")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008A08")]
	[Address(RVA = "0xCA0840", Offset = "0xC9FC40", VA = "0x180CA0840", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008A09")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008A0A")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008A0B")]
	[Address(RVA = "0xCA0480", Offset = "0xC9F880", VA = "0x180CA0480", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008A0C")]
	[Address(RVA = "0xCA0710", Offset = "0xC9FB10", VA = "0x180CA0710", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AchievementDetailsEvent other)
	{
	}

	[Token(Token = "0x6008A0D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008A0E")]
	[Address(RVA = "0xCA0BC0", Offset = "0xC9FFC0", VA = "0x180CA0BC0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
