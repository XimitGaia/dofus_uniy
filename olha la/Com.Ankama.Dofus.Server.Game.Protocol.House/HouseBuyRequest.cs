using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x20003F9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseBuyRequest : IMessage<HouseBuyRequest>, IMessage, IEquatable<HouseBuyRequest>, IDeepCloneable<HouseBuyRequest>, IBufferMessage
{
	[Token(Token = "0x4000DAF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseBuyRequest> _parser;

	[Token(Token = "0x4000DB0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DB1")]
	public const int ProposedPriceFieldNumber = 1;

	[Token(Token = "0x4000DB2")]
	[FieldOffset(Offset = "0x18")]
	private long proposedPrice_;

	[Token(Token = "0x170008E6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HouseBuyRequest> Parser
	{
		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x99B160", Offset = "0x99A560", VA = "0x18099B160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008E7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x99B0B0", Offset = "0x99A4B0", VA = "0x18099B0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008E8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60029A9")]
		[Address(RVA = "0x99B1B0", Offset = "0x99A5B0", VA = "0x18099B1B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008E9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ProposedPrice
	{
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x60029AA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseBuyRequest()
	{
	}

	[Token(Token = "0x60029AB")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseBuyRequest(HouseBuyRequest other)
	{
	}

	[Token(Token = "0x60029AC")]
	[Address(RVA = "0x99AE40", Offset = "0x99A240", VA = "0x18099AE40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseBuyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60029AF")]
	[Address(RVA = "0x99AEC0", Offset = "0x99A2C0", VA = "0x18099AEC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60029B0")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseBuyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60029B1")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60029B2")]
	[Address(RVA = "0x99AF50", Offset = "0x99A350", VA = "0x18099AF50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60029B3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60029B4")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60029B5")]
	[Address(RVA = "0x99ADB0", Offset = "0x99A1B0", VA = "0x18099ADB0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60029B6")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HouseBuyRequest other)
	{
	}

	[Token(Token = "0x60029B7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60029B8")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
