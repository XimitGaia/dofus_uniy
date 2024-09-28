using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member;

[Token(Token = "0x200046F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMemberParametersChangeRequest : IMessage<GuildMemberParametersChangeRequest>, IMessage, IEquatable<GuildMemberParametersChangeRequest>, IDeepCloneable<GuildMemberParametersChangeRequest>, IBufferMessage
{
	[Token(Token = "0x4000F2C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMemberParametersChangeRequest> _parser;

	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F2E")]
	public const int MemberIdFieldNumber = 1;

	[Token(Token = "0x4000F2F")]
	[FieldOffset(Offset = "0x18")]
	private long memberId_;

	[Token(Token = "0x4000F30")]
	public const int RankIdFieldNumber = 2;

	[Token(Token = "0x4000F31")]
	[FieldOffset(Offset = "0x20")]
	private int rankId_;

	[Token(Token = "0x4000F32")]
	public const int ExperienceGivenPercentFieldNumber = 3;

	[Token(Token = "0x4000F33")]
	[FieldOffset(Offset = "0x24")]
	private int experienceGivenPercent_;

	[Token(Token = "0x170009EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildMemberParametersChangeRequest> Parser
	{
		[Token(Token = "0x6002EA2")]
		[Address(RVA = "0x9D5460", Offset = "0x9D4860", VA = "0x1809D5460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002EA3")]
		[Address(RVA = "0x9D53B0", Offset = "0x9D47B0", VA = "0x1809D53B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009F1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002EA4")]
		[Address(RVA = "0x9D5620", Offset = "0x9D4A20", VA = "0x1809D5620", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MemberId
	{
		[Token(Token = "0x6002EA8")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002EA9")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170009F3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RankId
	{
		[Token(Token = "0x6002EAA")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002EAB")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170009F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ExperienceGivenPercent
	{
		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002EAD")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x6002EA5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberParametersChangeRequest()
	{
	}

	[Token(Token = "0x6002EA6")]
	[Address(RVA = "0x9D5350", Offset = "0x9D4750", VA = "0x1809D5350")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberParametersChangeRequest(GuildMemberParametersChangeRequest other)
	{
	}

	[Token(Token = "0x6002EA7")]
	[Address(RVA = "0x9D4F60", Offset = "0x9D4360", VA = "0x1809D4F60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMemberParametersChangeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002EAE")]
	[Address(RVA = "0x9D5030", Offset = "0x9D4430", VA = "0x1809D5030", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EAF")]
	[Address(RVA = "0x9D4FF0", Offset = "0x9D43F0", VA = "0x1809D4FF0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildMemberParametersChangeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EB0")]
	[Address(RVA = "0x9D50D0", Offset = "0x9D44D0", VA = "0x1809D50D0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002EB1")]
	[Address(RVA = "0x9D51F0", Offset = "0x9D45F0", VA = "0x1809D51F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002EB2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002EB3")]
	[Address(RVA = "0x9D5580", Offset = "0x9D4980", VA = "0x1809D5580", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002EB4")]
	[Address(RVA = "0x9D4E80", Offset = "0x9D4280", VA = "0x1809D4E80", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002EB5")]
	[Address(RVA = "0x9D5180", Offset = "0x9D4580", VA = "0x1809D5180", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildMemberParametersChangeRequest other)
	{
	}

	[Token(Token = "0x6002EB6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002EB7")]
	[Address(RVA = "0x9D54B0", Offset = "0x9D48B0", VA = "0x1809D54B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
