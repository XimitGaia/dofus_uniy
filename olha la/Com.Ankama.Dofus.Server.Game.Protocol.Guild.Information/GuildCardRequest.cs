using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004A4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildCardRequest : IMessage<GuildCardRequest>, IMessage, IEquatable<GuildCardRequest>, IDeepCloneable<GuildCardRequest>, IBufferMessage
{
	[Token(Token = "0x4000FDC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildCardRequest> _parser;

	[Token(Token = "0x4000FDD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FDE")]
	public const int GuildIdFieldNumber = 1;

	[Token(Token = "0x4000FDF")]
	[FieldOffset(Offset = "0x18")]
	private int guildId_;

	[Token(Token = "0x17000A63")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildCardRequest> Parser
	{
		[Token(Token = "0x60030D8")]
		[Address(RVA = "0x9C9FB0", Offset = "0x9C93B0", VA = "0x1809C9FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A64")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60030D9")]
		[Address(RVA = "0x9C9F00", Offset = "0x9C9300", VA = "0x1809C9F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A65")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60030DA")]
		[Address(RVA = "0x9CA000", Offset = "0x9C9400", VA = "0x1809CA000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A66")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildId
	{
		[Token(Token = "0x60030DE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60030DB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCardRequest()
	{
	}

	[Token(Token = "0x60030DC")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCardRequest(GuildCardRequest other)
	{
	}

	[Token(Token = "0x60030DD")]
	[Address(RVA = "0x9C9C90", Offset = "0x9C9090", VA = "0x1809C9C90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCardRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60030E0")]
	[Address(RVA = "0x9C9D10", Offset = "0x9C9110", VA = "0x1809C9D10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60030E1")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildCardRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60030E2")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60030E3")]
	[Address(RVA = "0x9C9DA0", Offset = "0x9C91A0", VA = "0x1809C9DA0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60030E4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60030E5")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60030E6")]
	[Address(RVA = "0x9C9C00", Offset = "0x9C9000", VA = "0x1809C9C00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60030E7")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildCardRequest other)
	{
	}

	[Token(Token = "0x60030E8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60030E9")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
