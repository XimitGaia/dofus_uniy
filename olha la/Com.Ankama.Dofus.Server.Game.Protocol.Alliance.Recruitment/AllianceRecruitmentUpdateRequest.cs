using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C50")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRecruitmentUpdateRequest : IMessage<AllianceRecruitmentUpdateRequest>, IMessage, IEquatable<AllianceRecruitmentUpdateRequest>, IDeepCloneable<AllianceRecruitmentUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4002DA3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRecruitmentUpdateRequest> _parser;

	[Token(Token = "0x4002DA4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DA5")]
	public const int InformationFieldNumber = 1;

	[Token(Token = "0x4002DA6")]
	[FieldOffset(Offset = "0x18")]
	private AllianceRecruitmentInformation information_;

	[Token(Token = "0x17001C6B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceRecruitmentUpdateRequest> Parser
	{
		[Token(Token = "0x6008181")]
		[Address(RVA = "0xC7E640", Offset = "0xC7DA40", VA = "0x180C7E640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C6C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008182")]
		[Address(RVA = "0xC7E590", Offset = "0xC7D990", VA = "0x180C7E590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C6D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008183")]
		[Address(RVA = "0xC7E790", Offset = "0xC7DB90", VA = "0x180C7E790", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C6E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRecruitmentInformation Information
	{
		[Token(Token = "0x6008187")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008188")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6008184")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRecruitmentUpdateRequest()
	{
	}

	[Token(Token = "0x6008185")]
	[Address(RVA = "0xC7B460", Offset = "0xC7A860", VA = "0x180C7B460")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRecruitmentUpdateRequest(AllianceRecruitmentUpdateRequest other)
	{
	}

	[Token(Token = "0x6008186")]
	[Address(RVA = "0xC7E210", Offset = "0xC7D610", VA = "0x180C7E210", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRecruitmentUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008189")]
	[Address(RVA = "0xC7E2B0", Offset = "0xC7D6B0", VA = "0x180C7E2B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600818A")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRecruitmentUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600818B")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600818C")]
	[Address(RVA = "0xC7E430", Offset = "0xC7D830", VA = "0x180C7E430", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600818D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600818E")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600818F")]
	[Address(RVA = "0xC7E180", Offset = "0xC7D580", VA = "0x180C7E180", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008190")]
	[Address(RVA = "0xC7E360", Offset = "0xC7D760", VA = "0x180C7E360", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceRecruitmentUpdateRequest other)
	{
	}

	[Token(Token = "0x6008191")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008192")]
	[Address(RVA = "0xC7E690", Offset = "0xC7DA90", VA = "0x180C7E690", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
