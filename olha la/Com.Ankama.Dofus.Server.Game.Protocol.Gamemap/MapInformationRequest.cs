using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000528")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapInformationRequest : IMessage<MapInformationRequest>, IMessage, IEquatable<MapInformationRequest>, IDeepCloneable<MapInformationRequest>, IBufferMessage
{
	[Token(Token = "0x400117C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapInformationRequest> _parser;

	[Token(Token = "0x400117D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400117E")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x400117F")]
	[FieldOffset(Offset = "0x18")]
	private int mapId_;

	[Token(Token = "0x17000B8E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapInformationRequest> Parser
	{
		[Token(Token = "0x6003695")]
		[Address(RVA = "0xA08A30", Offset = "0xA07E30", VA = "0x180A08A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B8F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003696")]
		[Address(RVA = "0xA08980", Offset = "0xA07D80", VA = "0x180A08980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003697")]
		[Address(RVA = "0xA08A80", Offset = "0xA07E80", VA = "0x180A08A80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B91")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapId
	{
		[Token(Token = "0x600369B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600369C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6003698")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapInformationRequest()
	{
	}

	[Token(Token = "0x6003699")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapInformationRequest(MapInformationRequest other)
	{
	}

	[Token(Token = "0x600369A")]
	[Address(RVA = "0xA08710", Offset = "0xA07B10", VA = "0x180A08710", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapInformationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600369D")]
	[Address(RVA = "0xA08790", Offset = "0xA07B90", VA = "0x180A08790", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600369E")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapInformationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600369F")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60036A0")]
	[Address(RVA = "0xA08820", Offset = "0xA07C20", VA = "0x180A08820", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60036A1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60036A2")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60036A3")]
	[Address(RVA = "0xA08680", Offset = "0xA07A80", VA = "0x180A08680", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60036A4")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapInformationRequest other)
	{
	}

	[Token(Token = "0x60036A5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60036A6")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
