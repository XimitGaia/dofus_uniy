using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008E9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachTeleportRequest : IMessage<BreachTeleportRequest>, IMessage, IEquatable<BreachTeleportRequest>, IDeepCloneable<BreachTeleportRequest>, IBufferMessage
{
	[Token(Token = "0x4001E98")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachTeleportRequest> _parser;

	[Token(Token = "0x4001E99")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170013FC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachTeleportRequest> Parser
	{
		[Token(Token = "0x6005E46")]
		[Address(RVA = "0xB57FD0", Offset = "0xB573D0", VA = "0x180B57FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013FD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005E47")]
		[Address(RVA = "0xB57F20", Offset = "0xB57320", VA = "0x180B57F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005E48")]
		[Address(RVA = "0xB58020", Offset = "0xB57420", VA = "0x180B58020", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005E49")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachTeleportRequest()
	{
	}

	[Token(Token = "0x6005E4A")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachTeleportRequest(BreachTeleportRequest other)
	{
	}

	[Token(Token = "0x6005E4B")]
	[Address(RVA = "0xB57CC0", Offset = "0xB570C0", VA = "0x180B57CC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachTeleportRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005E4C")]
	[Address(RVA = "0xB57D40", Offset = "0xB57140", VA = "0x180B57D40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E4D")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachTeleportRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E4E")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005E4F")]
	[Address(RVA = "0xB57DC0", Offset = "0xB571C0", VA = "0x180B57DC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005E50")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005E51")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005E52")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005E53")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BreachTeleportRequest other)
	{
	}

	[Token(Token = "0x6005E54")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005E55")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
