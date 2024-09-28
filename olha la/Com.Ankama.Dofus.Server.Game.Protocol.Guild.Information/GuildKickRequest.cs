using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x200049A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildKickRequest : IMessage<GuildKickRequest>, IMessage, IEquatable<GuildKickRequest>, IDeepCloneable<GuildKickRequest>, IBufferMessage
{
	[Token(Token = "0x4000FC3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildKickRequest> _parser;

	[Token(Token = "0x4000FC4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FC5")]
	public const int KickedIdFieldNumber = 1;

	[Token(Token = "0x4000FC6")]
	[FieldOffset(Offset = "0x18")]
	private long kickedId_;

	[Token(Token = "0x17000A4F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildKickRequest> Parser
	{
		[Token(Token = "0x600306A")]
		[Address(RVA = "0x9D28A0", Offset = "0x9D1CA0", VA = "0x1809D28A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600306B")]
		[Address(RVA = "0x9D27F0", Offset = "0x9D1BF0", VA = "0x1809D27F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A51")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600306C")]
		[Address(RVA = "0x9D28F0", Offset = "0x9D1CF0", VA = "0x1809D28F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A52")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long KickedId
	{
		[Token(Token = "0x6003070")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003071")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x600306D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildKickRequest()
	{
	}

	[Token(Token = "0x600306E")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildKickRequest(GuildKickRequest other)
	{
	}

	[Token(Token = "0x600306F")]
	[Address(RVA = "0x9D2580", Offset = "0x9D1980", VA = "0x1809D2580", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildKickRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003072")]
	[Address(RVA = "0x9D2600", Offset = "0x9D1A00", VA = "0x1809D2600", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003073")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildKickRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003074")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003075")]
	[Address(RVA = "0x9D2690", Offset = "0x9D1A90", VA = "0x1809D2690", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003076")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003077")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003078")]
	[Address(RVA = "0x9D24F0", Offset = "0x9D18F0", VA = "0x1809D24F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003079")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildKickRequest other)
	{
	}

	[Token(Token = "0x600307A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600307B")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
