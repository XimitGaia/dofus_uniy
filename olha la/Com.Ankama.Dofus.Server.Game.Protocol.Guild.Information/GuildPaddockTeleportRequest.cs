using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x200049E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildPaddockTeleportRequest : IMessage<GuildPaddockTeleportRequest>, IMessage, IEquatable<GuildPaddockTeleportRequest>, IDeepCloneable<GuildPaddockTeleportRequest>, IBufferMessage
{
	[Token(Token = "0x4000FCD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildPaddockTeleportRequest> _parser;

	[Token(Token = "0x4000FCE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FCF")]
	public const int PaddockIdFieldNumber = 1;

	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x18")]
	private long paddockId_;

	[Token(Token = "0x17000A57")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildPaddockTeleportRequest> Parser
	{
		[Token(Token = "0x6003096")]
		[Address(RVA = "0x9DC1E0", Offset = "0x9DB5E0", VA = "0x1809DC1E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A58")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003097")]
		[Address(RVA = "0x9DC130", Offset = "0x9DB530", VA = "0x1809DC130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A59")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003098")]
		[Address(RVA = "0x9DC230", Offset = "0x9DB630", VA = "0x1809DC230", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A5A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PaddockId
	{
		[Token(Token = "0x600309C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600309D")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6003099")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildPaddockTeleportRequest()
	{
	}

	[Token(Token = "0x600309A")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildPaddockTeleportRequest(GuildPaddockTeleportRequest other)
	{
	}

	[Token(Token = "0x600309B")]
	[Address(RVA = "0x9DBEC0", Offset = "0x9DB2C0", VA = "0x1809DBEC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildPaddockTeleportRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600309E")]
	[Address(RVA = "0x9DBF40", Offset = "0x9DB340", VA = "0x1809DBF40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600309F")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildPaddockTeleportRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60030A0")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60030A1")]
	[Address(RVA = "0x9DBFD0", Offset = "0x9DB3D0", VA = "0x1809DBFD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60030A2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60030A3")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60030A4")]
	[Address(RVA = "0x9DBE30", Offset = "0x9DB230", VA = "0x1809DBE30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60030A5")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildPaddockTeleportRequest other)
	{
	}

	[Token(Token = "0x60030A6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60030A7")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
