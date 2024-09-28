using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004D6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestTabSelectRequest : IMessage<GuildChestTabSelectRequest>, IMessage, IEquatable<GuildChestTabSelectRequest>, IDeepCloneable<GuildChestTabSelectRequest>, IBufferMessage
{
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestTabSelectRequest> _parser;

	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001084")]
	public const int TabNumberFieldNumber = 1;

	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x18")]
	private int tabNumber_;

	[Token(Token = "0x17000AD8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildChestTabSelectRequest> Parser
	{
		[Token(Token = "0x600330C")]
		[Address(RVA = "0x9F1440", Offset = "0x9F0840", VA = "0x1809F1440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AD9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600330D")]
		[Address(RVA = "0x9F1390", Offset = "0x9F0790", VA = "0x1809F1390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ADA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600330E")]
		[Address(RVA = "0x9F1490", Offset = "0x9F0890", VA = "0x1809F1490", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ADB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TabNumber
	{
		[Token(Token = "0x6003312")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003313")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600330F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabSelectRequest()
	{
	}

	[Token(Token = "0x6003310")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabSelectRequest(GuildChestTabSelectRequest other)
	{
	}

	[Token(Token = "0x6003311")]
	[Address(RVA = "0x9F1120", Offset = "0x9F0520", VA = "0x1809F1120", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabSelectRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003314")]
	[Address(RVA = "0x9F11A0", Offset = "0x9F05A0", VA = "0x1809F11A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003315")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildChestTabSelectRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003316")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003317")]
	[Address(RVA = "0x9F1230", Offset = "0x9F0630", VA = "0x1809F1230", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003318")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003319")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600331A")]
	[Address(RVA = "0x9F1090", Offset = "0x9F0490", VA = "0x1809F1090", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600331B")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestTabSelectRequest other)
	{
	}

	[Token(Token = "0x600331C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600331D")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
