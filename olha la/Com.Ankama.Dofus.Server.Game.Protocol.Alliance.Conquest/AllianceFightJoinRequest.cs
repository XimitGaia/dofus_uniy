using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CD9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightJoinRequest : IMessage<AllianceFightJoinRequest>, IMessage, IEquatable<AllianceFightJoinRequest>, IDeepCloneable<AllianceFightJoinRequest>, IBufferMessage
{
	[Token(Token = "0x4002F4E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightJoinRequest> _parser;

	[Token(Token = "0x4002F4F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F50")]
	public const int FightInformationFieldNumber = 1;

	[Token(Token = "0x4002F51")]
	[FieldOffset(Offset = "0x18")]
	private SocialFightInformation fightInformation_;

	[Token(Token = "0x17001D99")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceFightJoinRequest> Parser
	{
		[Token(Token = "0x6008760")]
		[Address(RVA = "0xCAB9C0", Offset = "0xCAADC0", VA = "0x180CAB9C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D9A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008761")]
		[Address(RVA = "0xCAB910", Offset = "0xCAAD10", VA = "0x180CAB910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D9B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008762")]
		[Address(RVA = "0xCABB10", Offset = "0xCAAF10", VA = "0x180CABB10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D9C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialFightInformation FightInformation
	{
		[Token(Token = "0x6008766")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008767")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6008763")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightJoinRequest()
	{
	}

	[Token(Token = "0x6008764")]
	[Address(RVA = "0xCAB1B0", Offset = "0xCAA5B0", VA = "0x180CAB1B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightJoinRequest(AllianceFightJoinRequest other)
	{
	}

	[Token(Token = "0x6008765")]
	[Address(RVA = "0xCAB590", Offset = "0xCAA990", VA = "0x180CAB590", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightJoinRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008768")]
	[Address(RVA = "0xCAB630", Offset = "0xCAAA30", VA = "0x180CAB630", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008769")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceFightJoinRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600876A")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600876B")]
	[Address(RVA = "0xCAB7B0", Offset = "0xCAABB0", VA = "0x180CAB7B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600876C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600876D")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600876E")]
	[Address(RVA = "0xCAB500", Offset = "0xCAA900", VA = "0x180CAB500", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600876F")]
	[Address(RVA = "0xCAB6E0", Offset = "0xCAAAE0", VA = "0x180CAB6E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceFightJoinRequest other)
	{
	}

	[Token(Token = "0x6008770")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008771")]
	[Address(RVA = "0xCABA10", Offset = "0xCAAE10", VA = "0x180CABA10", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
