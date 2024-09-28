using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Recruitment;

[Token(Token = "0x2000459")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRecruitmentUpdateRequest : IMessage<GuildRecruitmentUpdateRequest>, IMessage, IEquatable<GuildRecruitmentUpdateRequest>, IDeepCloneable<GuildRecruitmentUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4000EF1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRecruitmentUpdateRequest> _parser;

	[Token(Token = "0x4000EF2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000EF3")]
	public const int RecruitmentFieldNumber = 1;

	[Token(Token = "0x4000EF4")]
	[FieldOffset(Offset = "0x18")]
	private GuildRecruitmentInformation recruitment_;

	[Token(Token = "0x170009C3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRecruitmentUpdateRequest> Parser
	{
		[Token(Token = "0x6002DC1")]
		[Address(RVA = "0x9B5890", Offset = "0x9B4C90", VA = "0x1809B5890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002DC2")]
		[Address(RVA = "0x9B57E0", Offset = "0x9B4BE0", VA = "0x1809B57E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002DC3")]
		[Address(RVA = "0x9B59E0", Offset = "0x9B4DE0", VA = "0x1809B59E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecruitmentInformation Recruitment
	{
		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002DC4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecruitmentUpdateRequest()
	{
	}

	[Token(Token = "0x6002DC5")]
	[Address(RVA = "0x9B44F0", Offset = "0x9B38F0", VA = "0x1809B44F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecruitmentUpdateRequest(GuildRecruitmentUpdateRequest other)
	{
	}

	[Token(Token = "0x6002DC6")]
	[Address(RVA = "0x9B5460", Offset = "0x9B4860", VA = "0x1809B5460", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecruitmentUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002DC9")]
	[Address(RVA = "0x9B5500", Offset = "0x9B4900", VA = "0x1809B5500", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DCA")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRecruitmentUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DCB")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002DCC")]
	[Address(RVA = "0x9B5680", Offset = "0x9B4A80", VA = "0x1809B5680", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002DCD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002DCE")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002DCF")]
	[Address(RVA = "0x9B53D0", Offset = "0x9B47D0", VA = "0x1809B53D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002DD0")]
	[Address(RVA = "0x9B55B0", Offset = "0x9B49B0", VA = "0x1809B55B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildRecruitmentUpdateRequest other)
	{
	}

	[Token(Token = "0x6002DD1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002DD2")]
	[Address(RVA = "0x9B58E0", Offset = "0x9B4CE0", VA = "0x1809B58E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
