using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A1C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FighterNamedLightInformation : IMessage<FighterNamedLightInformation>, IMessage, IEquatable<FighterNamedLightInformation>, IDeepCloneable<FighterNamedLightInformation>, IBufferMessage
{
	[Token(Token = "0x4002441")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FighterNamedLightInformation> _parser;

	[Token(Token = "0x4002442")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002443")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x4002444")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x170016BF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FighterNamedLightInformation> Parser
	{
		[Token(Token = "0x600698A")]
		[Address(RVA = "0xBC5110", Offset = "0xBC4510", VA = "0x180BC5110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600698B")]
		[Address(RVA = "0xBC5060", Offset = "0xBC4460", VA = "0x180BC5060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600698C")]
		[Address(RVA = "0xBC5220", Offset = "0xBC4620", VA = "0x180BC5220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6006990")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006991")]
		[Address(RVA = "0xBC5300", Offset = "0xBC4700", VA = "0x180BC5300")]
		set
		{
		}
	}

	[Token(Token = "0x600698D")]
	[Address(RVA = "0xBC5010", Offset = "0xBC4410", VA = "0x180BC5010")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterNamedLightInformation()
	{
	}

	[Token(Token = "0x600698E")]
	[Address(RVA = "0xBC4F70", Offset = "0xBC4370", VA = "0x180BC4F70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterNamedLightInformation(FighterNamedLightInformation other)
	{
	}

	[Token(Token = "0x600698F")]
	[Address(RVA = "0xBC4C30", Offset = "0xBC4030", VA = "0x180BC4C30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FighterNamedLightInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6006992")]
	[Address(RVA = "0xBC4D00", Offset = "0xBC4100", VA = "0x180BC4D00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006993")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FighterNamedLightInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006994")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006995")]
	[Address(RVA = "0xBC4E10", Offset = "0xBC4210", VA = "0x180BC4E10", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006996")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006997")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006998")]
	[Address(RVA = "0xBC4BA0", Offset = "0xBC3FA0", VA = "0x180BC4BA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006999")]
	[Address(RVA = "0xBC4DB0", Offset = "0xBC41B0", VA = "0x180BC4DB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FighterNamedLightInformation other)
	{
	}

	[Token(Token = "0x600699A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600699B")]
	[Address(RVA = "0xBC5160", Offset = "0xBC4560", VA = "0x180BC5160", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
