using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000526")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapRunningFightDetailsRequest : IMessage<MapRunningFightDetailsRequest>, IMessage, IEquatable<MapRunningFightDetailsRequest>, IDeepCloneable<MapRunningFightDetailsRequest>, IBufferMessage
{
	[Token(Token = "0x4001177")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapRunningFightDetailsRequest> _parser;

	[Token(Token = "0x4001178")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001179")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x400117A")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x17000B8A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapRunningFightDetailsRequest> Parser
	{
		[Token(Token = "0x600367F")]
		[Address(RVA = "0xA0DE60", Offset = "0xA0D260", VA = "0x180A0DE60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B8B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003680")]
		[Address(RVA = "0xA0DDB0", Offset = "0xA0D1B0", VA = "0x180A0DDB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B8C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003681")]
		[Address(RVA = "0xA0DEB0", Offset = "0xA0D2B0", VA = "0x180A0DEB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B8D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x6003685")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003686")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6003682")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightDetailsRequest()
	{
	}

	[Token(Token = "0x6003683")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapRunningFightDetailsRequest(MapRunningFightDetailsRequest other)
	{
	}

	[Token(Token = "0x6003684")]
	[Address(RVA = "0xA0DB40", Offset = "0xA0CF40", VA = "0x180A0DB40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightDetailsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003687")]
	[Address(RVA = "0xA0DBC0", Offset = "0xA0CFC0", VA = "0x180A0DBC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003688")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapRunningFightDetailsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003689")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600368A")]
	[Address(RVA = "0xA0DC50", Offset = "0xA0D050", VA = "0x180A0DC50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600368B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600368C")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600368D")]
	[Address(RVA = "0xA0DAB0", Offset = "0xA0CEB0", VA = "0x180A0DAB0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600368E")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MapRunningFightDetailsRequest other)
	{
	}

	[Token(Token = "0x600368F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003690")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
