using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000209")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellPresetResetRequest : IMessage<ForgettableSpellPresetResetRequest>, IMessage, IEquatable<ForgettableSpellPresetResetRequest>, IDeepCloneable<ForgettableSpellPresetResetRequest>, IBufferMessage
{
	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellPresetResetRequest> _parser;

	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006EB")]
	public const int UuidFieldNumber = 1;

	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x18")]
	private string uuid_;

	[Token(Token = "0x1700046E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ForgettableSpellPresetResetRequest> Parser
	{
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0xCDEE30", Offset = "0xCDE230", VA = "0x180CDEE30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700046F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0xCDED80", Offset = "0xCDE180", VA = "0x180CDED80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000470")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0xCDEF40", Offset = "0xCDE340", VA = "0x180CDEF40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000471")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Uuid
	{
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0xCDF020", Offset = "0xCDE420", VA = "0x180CDF020")]
		set
		{
		}
	}

	[Token(Token = "0x60014BC")]
	[Address(RVA = "0xCDED30", Offset = "0xCDE130", VA = "0x180CDED30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetResetRequest()
	{
	}

	[Token(Token = "0x60014BD")]
	[Address(RVA = "0xCDEC90", Offset = "0xCDE090", VA = "0x180CDEC90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetResetRequest(ForgettableSpellPresetResetRequest other)
	{
	}

	[Token(Token = "0x60014BE")]
	[Address(RVA = "0xCDE950", Offset = "0xCDDD50", VA = "0x180CDE950", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetResetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60014C1")]
	[Address(RVA = "0xCDEA20", Offset = "0xCDDE20", VA = "0x180CDEA20", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60014C2")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ForgettableSpellPresetResetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60014C3")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60014C4")]
	[Address(RVA = "0xCDEB30", Offset = "0xCDDF30", VA = "0x180CDEB30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60014C5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60014C7")]
	[Address(RVA = "0xCDE8C0", Offset = "0xCDDCC0", VA = "0x180CDE8C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60014C8")]
	[Address(RVA = "0xCDEAD0", Offset = "0xCDDED0", VA = "0x180CDEAD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ForgettableSpellPresetResetRequest other)
	{
	}

	[Token(Token = "0x60014C9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60014CA")]
	[Address(RVA = "0xCDEE80", Offset = "0xCDE280", VA = "0x180CDEE80", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
