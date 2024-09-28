using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Recruitment;

[Token(Token = "0x200045D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRecruitmentInvalidateEvent : IMessage<GuildRecruitmentInvalidateEvent>, IMessage, IEquatable<GuildRecruitmentInvalidateEvent>, IDeepCloneable<GuildRecruitmentInvalidateEvent>, IBufferMessage
{
	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRecruitmentInvalidateEvent> _parser;

	[Token(Token = "0x4000EFC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170009CB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRecruitmentInvalidateEvent> Parser
	{
		[Token(Token = "0x6002DED")]
		[Address(RVA = "0x9B4B50", Offset = "0x9B3F50", VA = "0x1809B4B50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009CC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002DEE")]
		[Address(RVA = "0x9B4AA0", Offset = "0x9B3EA0", VA = "0x1809B4AA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009CD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002DEF")]
		[Address(RVA = "0x9B4BA0", Offset = "0x9B3FA0", VA = "0x1809B4BA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002DF0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRecruitmentInvalidateEvent()
	{
	}

	[Token(Token = "0x6002DF1")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRecruitmentInvalidateEvent(GuildRecruitmentInvalidateEvent other)
	{
	}

	[Token(Token = "0x6002DF2")]
	[Address(RVA = "0x9B4840", Offset = "0x9B3C40", VA = "0x1809B4840", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecruitmentInvalidateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0x9B48C0", Offset = "0x9B3CC0", VA = "0x1809B48C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRecruitmentInvalidateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002DF6")]
	[Address(RVA = "0x9B4940", Offset = "0x9B3D40", VA = "0x1809B4940", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002DF8")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002DF9")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002DFA")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRecruitmentInvalidateEvent other)
	{
	}

	[Token(Token = "0x6002DFB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002DFC")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
