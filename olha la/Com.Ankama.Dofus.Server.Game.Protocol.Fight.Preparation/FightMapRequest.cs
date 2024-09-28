using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x200063D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightMapRequest : IMessage<FightMapRequest>, IMessage, IEquatable<FightMapRequest>, IDeepCloneable<FightMapRequest>, IBufferMessage
{
	[Token(Token = "0x40015FA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightMapRequest> _parser;

	[Token(Token = "0x40015FB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000E5D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightMapRequest> Parser
	{
		[Token(Token = "0x60042E0")]
		[Address(RVA = "0xA7D7B0", Offset = "0xA7CBB0", VA = "0x180A7D7B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E5E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60042E1")]
		[Address(RVA = "0xA7D700", Offset = "0xA7CB00", VA = "0x180A7D700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E5F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60042E2")]
		[Address(RVA = "0xA7D800", Offset = "0xA7CC00", VA = "0x180A7D800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60042E3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightMapRequest()
	{
	}

	[Token(Token = "0x60042E4")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightMapRequest(FightMapRequest other)
	{
	}

	[Token(Token = "0x60042E5")]
	[Address(RVA = "0xA7D4A0", Offset = "0xA7C8A0", VA = "0x180A7D4A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightMapRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60042E6")]
	[Address(RVA = "0xA7D520", Offset = "0xA7C920", VA = "0x180A7D520", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60042E7")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightMapRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60042E8")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60042E9")]
	[Address(RVA = "0xA7D5A0", Offset = "0xA7C9A0", VA = "0x180A7D5A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60042EA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60042EB")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60042EC")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60042ED")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightMapRequest other)
	{
	}

	[Token(Token = "0x60042EE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60042EF")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
