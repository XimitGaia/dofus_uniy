using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x20004F6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationUpdateRequest : IMessage<GuildApplicationUpdateRequest>, IMessage, IEquatable<GuildApplicationUpdateRequest>, IDeepCloneable<GuildApplicationUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x40010F1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationUpdateRequest> _parser;

	[Token(Token = "0x40010F2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40010F3")]
	public const int ApplyTextFieldNumber = 1;

	[Token(Token = "0x40010F4")]
	[FieldOffset(Offset = "0x18")]
	private string applyText_;

	[Token(Token = "0x40010F5")]
	public const int GuildIdFieldNumber = 2;

	[Token(Token = "0x40010F6")]
	[FieldOffset(Offset = "0x20")]
	private int guildId_;

	[Token(Token = "0x17000B25")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildApplicationUpdateRequest> Parser
	{
		[Token(Token = "0x6003475")]
		[Address(RVA = "0x9E8E60", Offset = "0x9E8260", VA = "0x1809E8E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B26")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003476")]
		[Address(RVA = "0x9E8DB0", Offset = "0x9E81B0", VA = "0x1809E8DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B27")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003477")]
		[Address(RVA = "0x9E8F80", Offset = "0x9E8380", VA = "0x1809E8F80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B28")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ApplyText
	{
		[Token(Token = "0x600347B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600347C")]
		[Address(RVA = "0x9E9060", Offset = "0x9E8460", VA = "0x1809E9060")]
		set
		{
		}
	}

	[Token(Token = "0x17000B29")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuildId
	{
		[Token(Token = "0x600347D")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600347E")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6003478")]
	[Address(RVA = "0x9E8D60", Offset = "0x9E8160", VA = "0x1809E8D60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationUpdateRequest()
	{
	}

	[Token(Token = "0x6003479")]
	[Address(RVA = "0x9E8CB0", Offset = "0x9E80B0", VA = "0x1809E8CB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationUpdateRequest(GuildApplicationUpdateRequest other)
	{
	}

	[Token(Token = "0x600347A")]
	[Address(RVA = "0x9E8960", Offset = "0x9E7D60", VA = "0x1809E8960", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600347F")]
	[Address(RVA = "0x9E8A30", Offset = "0x9E7E30", VA = "0x1809E8A30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003480")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003481")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003482")]
	[Address(RVA = "0x9E8B50", Offset = "0x9E7F50", VA = "0x1809E8B50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003483")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003484")]
	[Address(RVA = "0x955630", Offset = "0x954A30", VA = "0x180955630", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003485")]
	[Address(RVA = "0x9E88A0", Offset = "0x9E7CA0", VA = "0x1809E88A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003486")]
	[Address(RVA = "0x9E8AE0", Offset = "0x9E7EE0", VA = "0x1809E8AE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationUpdateRequest other)
	{
	}

	[Token(Token = "0x6003487")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003488")]
	[Address(RVA = "0x9E8EB0", Offset = "0x9E82B0", VA = "0x1809E8EB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
