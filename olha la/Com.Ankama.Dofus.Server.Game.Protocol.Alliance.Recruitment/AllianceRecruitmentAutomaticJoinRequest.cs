using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C54")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRecruitmentAutomaticJoinRequest : IMessage<AllianceRecruitmentAutomaticJoinRequest>, IMessage, IEquatable<AllianceRecruitmentAutomaticJoinRequest>, IDeepCloneable<AllianceRecruitmentAutomaticJoinRequest>, IBufferMessage
{
	[Token(Token = "0x4002DAD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRecruitmentAutomaticJoinRequest> _parser;

	[Token(Token = "0x4002DAE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DAF")]
	public const int AllianceUidFieldNumber = 1;

	[Token(Token = "0x4002DB0")]
	[FieldOffset(Offset = "0x18")]
	private string allianceUid_;

	[Token(Token = "0x17001C73")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceRecruitmentAutomaticJoinRequest> Parser
	{
		[Token(Token = "0x60081AD")]
		[Address(RVA = "0xC7ADF0", Offset = "0xC7A1F0", VA = "0x180C7ADF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C74")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60081AE")]
		[Address(RVA = "0xC7AD40", Offset = "0xC7A140", VA = "0x180C7AD40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C75")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60081AF")]
		[Address(RVA = "0xC7AF00", Offset = "0xC7A300", VA = "0x180C7AF00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C76")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AllianceUid
	{
		[Token(Token = "0x60081B3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60081B4")]
		[Address(RVA = "0xC7AFE0", Offset = "0xC7A3E0", VA = "0x180C7AFE0")]
		set
		{
		}
	}

	[Token(Token = "0x60081B0")]
	[Address(RVA = "0xC7AC50", Offset = "0xC7A050", VA = "0x180C7AC50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRecruitmentAutomaticJoinRequest()
	{
	}

	[Token(Token = "0x60081B1")]
	[Address(RVA = "0xC7ACA0", Offset = "0xC7A0A0", VA = "0x180C7ACA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRecruitmentAutomaticJoinRequest(AllianceRecruitmentAutomaticJoinRequest other)
	{
	}

	[Token(Token = "0x60081B2")]
	[Address(RVA = "0xC7A910", Offset = "0xC79D10", VA = "0x180C7A910", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRecruitmentAutomaticJoinRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60081B5")]
	[Address(RVA = "0xC7A9E0", Offset = "0xC79DE0", VA = "0x180C7A9E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60081B6")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRecruitmentAutomaticJoinRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60081B7")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60081B8")]
	[Address(RVA = "0xC7AAF0", Offset = "0xC79EF0", VA = "0x180C7AAF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60081B9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60081BA")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60081BB")]
	[Address(RVA = "0xC7A880", Offset = "0xC79C80", VA = "0x180C7A880", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60081BC")]
	[Address(RVA = "0xC7AA90", Offset = "0xC79E90", VA = "0x180C7AA90", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceRecruitmentAutomaticJoinRequest other)
	{
	}

	[Token(Token = "0x60081BD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60081BE")]
	[Address(RVA = "0xC7AE40", Offset = "0xC7A240", VA = "0x180C7AE40", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
