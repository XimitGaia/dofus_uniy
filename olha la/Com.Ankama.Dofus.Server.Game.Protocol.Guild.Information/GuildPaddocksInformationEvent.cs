using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004BC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildPaddocksInformationEvent : IMessage<GuildPaddocksInformationEvent>, IMessage, IEquatable<GuildPaddocksInformationEvent>, IDeepCloneable<GuildPaddocksInformationEvent>, IBufferMessage
{
	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildPaddocksInformationEvent> _parser;

	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001039")]
	public const int MaxPaddockNumberFieldNumber = 1;

	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0x18")]
	private int maxPaddockNumber_;

	[Token(Token = "0x400103B")]
	public const int PaddockInformationFieldNumber = 2;

	[Token(Token = "0x400103C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<PaddockInformation> _repeated_paddockInformation_codec;

	[Token(Token = "0x400103D")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<PaddockInformation> paddockInformation_;

	[Token(Token = "0x17000AA1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildPaddocksInformationEvent> Parser
	{
		[Token(Token = "0x60031F9")]
		[Address(RVA = "0x9F6FD0", Offset = "0x9F63D0", VA = "0x1809F6FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AA2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60031FA")]
		[Address(RVA = "0x9F6F20", Offset = "0x9F6320", VA = "0x1809F6F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AA3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60031FB")]
		[Address(RVA = "0x9F7220", Offset = "0x9F6620", VA = "0x1809F7220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AA4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxPaddockNumber
	{
		[Token(Token = "0x60031FF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003200")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000AA5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PaddockInformation> PaddockInformation
	{
		[Token(Token = "0x6003201")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60031FC")]
	[Address(RVA = "0x9F6E10", Offset = "0x9F6210", VA = "0x1809F6E10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildPaddocksInformationEvent()
	{
	}

	[Token(Token = "0x60031FD")]
	[Address(RVA = "0x9F6E90", Offset = "0x9F6290", VA = "0x1809F6E90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildPaddocksInformationEvent(GuildPaddocksInformationEvent other)
	{
	}

	[Token(Token = "0x60031FE")]
	[Address(RVA = "0x9F6940", Offset = "0x9F5D40", VA = "0x1809F6940", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildPaddocksInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003202")]
	[Address(RVA = "0x9F6AA0", Offset = "0x9F5EA0", VA = "0x1809F6AA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003203")]
	[Address(RVA = "0x9F6A00", Offset = "0x9F5E00", VA = "0x1809F6A00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildPaddocksInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003204")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003205")]
	[Address(RVA = "0x9F6C10", Offset = "0x9F6010", VA = "0x1809F6C10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003206")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003207")]
	[Address(RVA = "0x9F7150", Offset = "0x9F6550", VA = "0x1809F7150", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003208")]
	[Address(RVA = "0x9F6860", Offset = "0x9F5C60", VA = "0x1809F6860", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003209")]
	[Address(RVA = "0x9F6B80", Offset = "0x9F5F80", VA = "0x1809F6B80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildPaddocksInformationEvent other)
	{
	}

	[Token(Token = "0x600320A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600320B")]
	[Address(RVA = "0x9F7020", Offset = "0x9F6420", VA = "0x1809F7020", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
