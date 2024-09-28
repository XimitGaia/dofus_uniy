using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004B4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildInvitedEvent : IMessage<GuildInvitedEvent>, IMessage, IEquatable<GuildInvitedEvent>, IDeepCloneable<GuildInvitedEvent>, IBufferMessage
{
	[Token(Token = "0x4001011")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildInvitedEvent> _parser;

	[Token(Token = "0x4001012")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001013")]
	public const int RecruiterNameFieldNumber = 1;

	[Token(Token = "0x4001014")]
	[FieldOffset(Offset = "0x18")]
	private string recruiterName_;

	[Token(Token = "0x4001015")]
	public const int GuildInformationFieldNumber = 2;

	[Token(Token = "0x4001016")]
	[FieldOffset(Offset = "0x20")]
	private GuildInformation guildInformation_;

	[Token(Token = "0x17000A88")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildInvitedEvent> Parser
	{
		[Token(Token = "0x600318F")]
		[Address(RVA = "0x9D14E0", Offset = "0x9D08E0", VA = "0x1809D14E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A89")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003190")]
		[Address(RVA = "0x9D1430", Offset = "0x9D0830", VA = "0x1809D1430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A8A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003191")]
		[Address(RVA = "0x9D1670", Offset = "0x9D0A70", VA = "0x1809D1670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A8B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RecruiterName
	{
		[Token(Token = "0x6003195")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003196")]
		[Address(RVA = "0x9D1750", Offset = "0x9D0B50", VA = "0x1809D1750")]
		set
		{
		}
	}

	[Token(Token = "0x17000A8C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInformation GuildInformation
	{
		[Token(Token = "0x6003197")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003198")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6003192")]
	[Address(RVA = "0x9D13E0", Offset = "0x9D07E0", VA = "0x1809D13E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitedEvent()
	{
	}

	[Token(Token = "0x6003193")]
	[Address(RVA = "0x9D1320", Offset = "0x9D0720", VA = "0x1809D1320")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitedEvent(GuildInvitedEvent other)
	{
	}

	[Token(Token = "0x6003194")]
	[Address(RVA = "0x9D0F20", Offset = "0x9D0320", VA = "0x1809D0F20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003199")]
	[Address(RVA = "0x9D1010", Offset = "0x9D0410", VA = "0x1809D1010", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600319A")]
	[Address(RVA = "0x92F3E0", Offset = "0x92E7E0", VA = "0x18092F3E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildInvitedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600319B")]
	[Address(RVA = "0x92F460", Offset = "0x92E860", VA = "0x18092F460", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600319C")]
	[Address(RVA = "0x9D11C0", Offset = "0x9D05C0", VA = "0x1809D11C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600319D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600319E")]
	[Address(RVA = "0x92FB90", Offset = "0x92EF90", VA = "0x18092FB90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600319F")]
	[Address(RVA = "0x9D0E60", Offset = "0x9D0260", VA = "0x1809D0E60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60031A0")]
	[Address(RVA = "0x9D10D0", Offset = "0x9D04D0", VA = "0x1809D10D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildInvitedEvent other)
	{
	}

	[Token(Token = "0x60031A1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60031A2")]
	[Address(RVA = "0x9D1530", Offset = "0x9D0930", VA = "0x1809D1530", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
