using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200051E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapErrorNotFoundRequest : IMessage<MapErrorNotFoundRequest>, IMessage, IEquatable<MapErrorNotFoundRequest>, IDeepCloneable<MapErrorNotFoundRequest>, IBufferMessage
{
	[Token(Token = "0x4001165")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapErrorNotFoundRequest> _parser;

	[Token(Token = "0x4001166")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001167")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x4001168")]
	[FieldOffset(Offset = "0x18")]
	private int mapId_;

	[Token(Token = "0x17000B7B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapErrorNotFoundRequest> Parser
	{
		[Token(Token = "0x6003629")]
		[Address(RVA = "0xA08070", Offset = "0xA07470", VA = "0x180A08070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B7C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600362A")]
		[Address(RVA = "0xA07FC0", Offset = "0xA073C0", VA = "0x180A07FC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B7D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600362B")]
		[Address(RVA = "0xA080C0", Offset = "0xA074C0", VA = "0x180A080C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B7E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapId
	{
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600362C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapErrorNotFoundRequest()
	{
	}

	[Token(Token = "0x600362D")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapErrorNotFoundRequest(MapErrorNotFoundRequest other)
	{
	}

	[Token(Token = "0x600362E")]
	[Address(RVA = "0xA07D50", Offset = "0xA07150", VA = "0x180A07D50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapErrorNotFoundRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003631")]
	[Address(RVA = "0xA07DD0", Offset = "0xA071D0", VA = "0x180A07DD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003632")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapErrorNotFoundRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003633")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003634")]
	[Address(RVA = "0xA07E60", Offset = "0xA07260", VA = "0x180A07E60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003635")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003636")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003637")]
	[Address(RVA = "0xA07CC0", Offset = "0xA070C0", VA = "0x180A07CC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003638")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapErrorNotFoundRequest other)
	{
	}

	[Token(Token = "0x6003639")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600363A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
