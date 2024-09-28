using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A2A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTeamMembersInformation : IMessage<FightTeamMembersInformation>, IMessage, IEquatable<FightTeamMembersInformation>, IDeepCloneable<FightTeamMembersInformation>, IBufferMessage
{
	[Token(Token = "0x4002491")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTeamMembersInformation> _parser;

	[Token(Token = "0x4002492")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002493")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002494")]
	public const int TeamMembersFieldNumber = 1;

	[Token(Token = "0x4002495")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<FightTeamMemberInformation> _repeated_teamMembers_codec;

	[Token(Token = "0x4002496")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<FightTeamMemberInformation> teamMembers_;

	[Token(Token = "0x4002497")]
	public const int AllianceRelationFieldNumber = 2;

	[Token(Token = "0x4002498")]
	[FieldOffset(Offset = "0x10")]
	private static readonly AllianceRelation AllianceRelationDefaultValue;

	[Token(Token = "0x4002499")]
	[FieldOffset(Offset = "0x28")]
	private AllianceRelation allianceRelation_;

	[Token(Token = "0x170016ED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTeamMembersInformation> Parser
	{
		[Token(Token = "0x6006A36")]
		[Address(RVA = "0xBC0290", Offset = "0xBBF690", VA = "0x180BC0290")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016EE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006A37")]
		[Address(RVA = "0xBC01E0", Offset = "0xBBF5E0", VA = "0x180BC01E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016EF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006A38")]
		[Address(RVA = "0xBC0530", Offset = "0xBBF930", VA = "0x180BC0530", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FightTeamMemberInformation> TeamMembers
	{
		[Token(Token = "0x6006A3C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016F1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRelation AllianceRelation
	{
		[Token(Token = "0x6006A3D")]
		[Address(RVA = "0xBC0170", Offset = "0xBBF570", VA = "0x180BC0170")]
		get
		{
			return default(AllianceRelation);
		}
		[Token(Token = "0x6006A3E")]
		[Address(RVA = "0xA0A2B0", Offset = "0xA096B0", VA = "0x180A0A2B0")]
		set
		{
		}
	}

	[Token(Token = "0x170016F2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasAllianceRelation
	{
		[Token(Token = "0x6006A3F")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006A39")]
	[Address(RVA = "0xBC00F0", Offset = "0xBBF4F0", VA = "0x180BC00F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMembersInformation()
	{
	}

	[Token(Token = "0x6006A3A")]
	[Address(RVA = "0xBC0050", Offset = "0xBBF450", VA = "0x180BC0050")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamMembersInformation(FightTeamMembersInformation other)
	{
	}

	[Token(Token = "0x6006A3B")]
	[Address(RVA = "0xBBFA30", Offset = "0xBBEE30", VA = "0x180BBFA30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMembersInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6006A40")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAllianceRelation()
	{
	}

	[Token(Token = "0x6006A41")]
	[Address(RVA = "0xBBFBC0", Offset = "0xBBEFC0", VA = "0x180BBFBC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006A42")]
	[Address(RVA = "0xBBFB00", Offset = "0xBBEF00", VA = "0x180BBFB00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightTeamMembersInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006A43")]
	[Address(RVA = "0xBBFCB0", Offset = "0xBBF0B0", VA = "0x180BBFCB0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006A44")]
	[Address(RVA = "0xBBFE30", Offset = "0xBBF230", VA = "0x180BBFE30", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006A45")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006A46")]
	[Address(RVA = "0xBC0410", Offset = "0xBBF810", VA = "0x180BC0410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006A47")]
	[Address(RVA = "0xBBF900", Offset = "0xBBED00", VA = "0x180BBF900", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006A48")]
	[Address(RVA = "0xBBFD90", Offset = "0xBBF190", VA = "0x180BBFD90", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightTeamMembersInformation other)
	{
	}

	[Token(Token = "0x6006A49")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006A4A")]
	[Address(RVA = "0xBC02E0", Offset = "0xBBF6E0", VA = "0x180BC02E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
