using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x20003FB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseLockFromInsideRequest : IMessage<HouseLockFromInsideRequest>, IMessage, IEquatable<HouseLockFromInsideRequest>, IDeepCloneable<HouseLockFromInsideRequest>, IBufferMessage
{
	[Token(Token = "0x4000DB4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseLockFromInsideRequest> _parser;

	[Token(Token = "0x4000DB5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DB6")]
	public const int CodeFieldNumber = 1;

	[Token(Token = "0x4000DB7")]
	[FieldOffset(Offset = "0x18")]
	private string code_;

	[Token(Token = "0x170008EA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HouseLockFromInsideRequest> Parser
	{
		[Token(Token = "0x60029BD")]
		[Address(RVA = "0x99DEF0", Offset = "0x99D2F0", VA = "0x18099DEF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008EB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60029BE")]
		[Address(RVA = "0x99DE40", Offset = "0x99D240", VA = "0x18099DE40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008EC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60029BF")]
		[Address(RVA = "0x99E000", Offset = "0x99D400", VA = "0x18099E000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008ED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Code
	{
		[Token(Token = "0x60029C3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60029C4")]
		[Address(RVA = "0x99E0E0", Offset = "0x99D4E0", VA = "0x18099E0E0")]
		set
		{
		}
	}

	[Token(Token = "0x60029C0")]
	[Address(RVA = "0x99DD50", Offset = "0x99D150", VA = "0x18099DD50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseLockFromInsideRequest()
	{
	}

	[Token(Token = "0x60029C1")]
	[Address(RVA = "0x99DDA0", Offset = "0x99D1A0", VA = "0x18099DDA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseLockFromInsideRequest(HouseLockFromInsideRequest other)
	{
	}

	[Token(Token = "0x60029C2")]
	[Address(RVA = "0x99DA10", Offset = "0x99CE10", VA = "0x18099DA10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseLockFromInsideRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60029C5")]
	[Address(RVA = "0x99DAE0", Offset = "0x99CEE0", VA = "0x18099DAE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60029C6")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseLockFromInsideRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60029C7")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60029C8")]
	[Address(RVA = "0x99DBF0", Offset = "0x99CFF0", VA = "0x18099DBF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60029C9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60029CA")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60029CB")]
	[Address(RVA = "0x99D980", Offset = "0x99CD80", VA = "0x18099D980", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60029CC")]
	[Address(RVA = "0x99DB90", Offset = "0x99CF90", VA = "0x18099DB90", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HouseLockFromInsideRequest other)
	{
	}

	[Token(Token = "0x60029CD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60029CE")]
	[Address(RVA = "0x99DF40", Offset = "0x99D340", VA = "0x18099DF40", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
