using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x200048A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildInformationRequest : IMessage<GuildInformationRequest>, IMessage, IEquatable<GuildInformationRequest>, IDeepCloneable<GuildInformationRequest>, IBufferMessage
{
	[Token(Token = "0x200048B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x200048C")]
		public enum InformationType
		{
			[Token(Token = "0x4000F99")]
			[OriginalName("INFO_GENERAL")]
			InfoGeneral,
			[Token(Token = "0x4000F9A")]
			[OriginalName("INFO_MEMBERS")]
			InfoMembers,
			[Token(Token = "0x4000F9B")]
			[OriginalName("INFO_BOOSTS")]
			InfoBoosts,
			[Token(Token = "0x4000F9C")]
			[OriginalName("INFO_PADDOCKS")]
			InfoPaddocks,
			[Token(Token = "0x4000F9D")]
			[OriginalName("INFO_HOUSES")]
			InfoHouses,
			[Token(Token = "0x4000F9E")]
			[OriginalName("INFO_RECRUITMENT")]
			InfoRecruitment,
			[Token(Token = "0x4000F9F")]
			[OriginalName("INFO_LOGBOOK")]
			InfoLogbook
		}
	}

	[Token(Token = "0x4000F94")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildInformationRequest> _parser;

	[Token(Token = "0x4000F95")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F96")]
	public const int InformationTypeFieldNumber = 1;

	[Token(Token = "0x4000F97")]
	[FieldOffset(Offset = "0x18")]
	private Types.InformationType informationType_;

	[Token(Token = "0x17000A31")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildInformationRequest> Parser
	{
		[Token(Token = "0x6002FCC")]
		[Address(RVA = "0x9CF650", Offset = "0x9CEA50", VA = "0x1809CF650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A32")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002FCD")]
		[Address(RVA = "0x9CF5A0", Offset = "0x9CE9A0", VA = "0x1809CF5A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A33")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0x9CF6A0", Offset = "0x9CEAA0", VA = "0x1809CF6A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A34")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.InformationType InformationType
	{
		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.InformationType);
		}
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6002FCF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInformationRequest()
	{
	}

	[Token(Token = "0x6002FD0")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInformationRequest(GuildInformationRequest other)
	{
	}

	[Token(Token = "0x6002FD1")]
	[Address(RVA = "0x9CF330", Offset = "0x9CE730", VA = "0x1809CF330", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInformationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002FD4")]
	[Address(RVA = "0x9CF3B0", Offset = "0x9CE7B0", VA = "0x1809CF3B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FD5")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildInformationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FD6")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002FD7")]
	[Address(RVA = "0x9CF440", Offset = "0x9CE840", VA = "0x1809CF440", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002FD8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002FD9")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002FDA")]
	[Address(RVA = "0x9CF2A0", Offset = "0x9CE6A0", VA = "0x1809CF2A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002FDB")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildInformationRequest other)
	{
	}

	[Token(Token = "0x6002FDC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002FDD")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
