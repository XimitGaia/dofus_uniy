using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x2000407")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseAccountEvent : IMessage<HouseAccountEvent>, IMessage, IEquatable<HouseAccountEvent>, IDeepCloneable<HouseAccountEvent>, IBufferMessage
{
	[Token(Token = "0x4000DE6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseAccountEvent> _parser;

	[Token(Token = "0x4000DE7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DE8")]
	public const int HousesFieldNumber = 1;

	[Token(Token = "0x4000DE9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.House> _repeated_houses_codec;

	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.House> houses_;

	[Token(Token = "0x1700090C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HouseAccountEvent> Parser
	{
		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x99AAC0", Offset = "0x999EC0", VA = "0x18099AAC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700090D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002A56")]
		[Address(RVA = "0x99AA10", Offset = "0x999E10", VA = "0x18099AA10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700090E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002A57")]
		[Address(RVA = "0x99ACD0", Offset = "0x99A0D0", VA = "0x18099ACD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700090F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.House> Houses
	{
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002A58")]
	[Address(RVA = "0x99A990", Offset = "0x999D90", VA = "0x18099A990")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseAccountEvent()
	{
	}

	[Token(Token = "0x6002A59")]
	[Address(RVA = "0x99A900", Offset = "0x999D00", VA = "0x18099A900")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseAccountEvent(HouseAccountEvent other)
	{
	}

	[Token(Token = "0x6002A5A")]
	[Address(RVA = "0x99A450", Offset = "0x999850", VA = "0x18099A450", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseAccountEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002A5C")]
	[Address(RVA = "0x99A5A0", Offset = "0x9999A0", VA = "0x18099A5A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A5D")]
	[Address(RVA = "0x99A510", Offset = "0x999910", VA = "0x18099A510", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HouseAccountEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A5E")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002A5F")]
	[Address(RVA = "0x99A700", Offset = "0x999B00", VA = "0x18099A700", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002A60")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002A61")]
	[Address(RVA = "0x99AC20", Offset = "0x99A020", VA = "0x18099AC20", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002A62")]
	[Address(RVA = "0x99A3B0", Offset = "0x9997B0", VA = "0x18099A3B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002A63")]
	[Address(RVA = "0x99A680", Offset = "0x999A80", VA = "0x18099A680", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HouseAccountEvent other)
	{
	}

	[Token(Token = "0x6002A64")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002A65")]
	[Address(RVA = "0x99AB10", Offset = "0x999F10", VA = "0x18099AB10", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
