using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004D8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestTabUpdateRequest : IMessage<GuildChestTabUpdateRequest>, IMessage, IEquatable<GuildChestTabUpdateRequest>, IDeepCloneable<GuildChestTabUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestTabUpdateRequest> _parser;

	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001089")]
	public const int TabNumberFieldNumber = 1;

	[Token(Token = "0x400108A")]
	[FieldOffset(Offset = "0x18")]
	private int tabNumber_;

	[Token(Token = "0x400108B")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x400108D")]
	public const int PictoFieldNumber = 3;

	[Token(Token = "0x400108E")]
	[FieldOffset(Offset = "0x28")]
	private int picto_;

	[Token(Token = "0x400108F")]
	public const int DropTypeLimitationFieldNumber = 4;

	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_dropTypeLimitation_codec;

	[Token(Token = "0x4001091")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<int> dropTypeLimitation_;

	[Token(Token = "0x17000ADC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildChestTabUpdateRequest> Parser
	{
		[Token(Token = "0x6003322")]
		[Address(RVA = "0x9F1E60", Offset = "0x9F1260", VA = "0x1809F1E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ADD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003323")]
		[Address(RVA = "0x9F1DB0", Offset = "0x9F11B0", VA = "0x1809F1DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ADE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003324")]
		[Address(RVA = "0x9F2160", Offset = "0x9F1560", VA = "0x1809F2160", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ADF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TabNumber
	{
		[Token(Token = "0x6003328")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003329")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x600332A")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600332B")]
		[Address(RVA = "0x9F2240", Offset = "0x9F1640", VA = "0x1809F2240")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Picto
	{
		[Token(Token = "0x600332C")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600332D")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DropTypeLimitation
	{
		[Token(Token = "0x600332E")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003325")]
	[Address(RVA = "0x9F1C60", Offset = "0x9F1060", VA = "0x1809F1C60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabUpdateRequest()
	{
	}

	[Token(Token = "0x6003326")]
	[Address(RVA = "0x9F1D00", Offset = "0x9F1100", VA = "0x1809F1D00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestTabUpdateRequest(GuildChestTabUpdateRequest other)
	{
	}

	[Token(Token = "0x6003327")]
	[Address(RVA = "0x9F16B0", Offset = "0x9F0AB0", VA = "0x1809F16B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600332F")]
	[Address(RVA = "0x9F1850", Offset = "0x9F0C50", VA = "0x1809F1850", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003330")]
	[Address(RVA = "0x9F1790", Offset = "0x9F0B90", VA = "0x1809F1790", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildChestTabUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003331")]
	[Address(RVA = "0x9F1950", Offset = "0x9F0D50", VA = "0x1809F1950", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003332")]
	[Address(RVA = "0x9F1AD0", Offset = "0x9F0ED0", VA = "0x1809F1AD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003333")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003334")]
	[Address(RVA = "0x9F2040", Offset = "0x9F1440", VA = "0x1809F2040", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003335")]
	[Address(RVA = "0x9F1570", Offset = "0x9F0970", VA = "0x1809F1570", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003336")]
	[Address(RVA = "0x9F1A20", Offset = "0x9F0E20", VA = "0x1809F1A20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestTabUpdateRequest other)
	{
	}

	[Token(Token = "0x6003337")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003338")]
	[Address(RVA = "0x9F1EB0", Offset = "0x9F12B0", VA = "0x1809F1EB0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
