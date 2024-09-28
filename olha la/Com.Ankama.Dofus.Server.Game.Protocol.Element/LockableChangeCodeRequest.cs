using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element;

[Token(Token = "0x2000748")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class LockableChangeCodeRequest : IMessage<LockableChangeCodeRequest>, IMessage, IEquatable<LockableChangeCodeRequest>, IDeepCloneable<LockableChangeCodeRequest>, IBufferMessage
{
	[Token(Token = "0x400199B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<LockableChangeCodeRequest> _parser;

	[Token(Token = "0x400199C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400199D")]
	public const int CodeFieldNumber = 1;

	[Token(Token = "0x400199E")]
	[FieldOffset(Offset = "0x18")]
	private string code_;

	[Token(Token = "0x170010BB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<LockableChangeCodeRequest> Parser
	{
		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0xAC1AB0", Offset = "0xAC0EB0", VA = "0x180AC1AB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010BC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0xAC1A00", Offset = "0xAC0E00", VA = "0x180AC1A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010BD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004E2E")]
		[Address(RVA = "0xAC1BC0", Offset = "0xAC0FC0", VA = "0x180AC1BC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010BE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Code
	{
		[Token(Token = "0x6004E32")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004E33")]
		[Address(RVA = "0xAC1CA0", Offset = "0xAC10A0", VA = "0x180AC1CA0")]
		set
		{
		}
	}

	[Token(Token = "0x6004E2F")]
	[Address(RVA = "0xAC19B0", Offset = "0xAC0DB0", VA = "0x180AC19B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockableChangeCodeRequest()
	{
	}

	[Token(Token = "0x6004E30")]
	[Address(RVA = "0xAC1910", Offset = "0xAC0D10", VA = "0x180AC1910")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockableChangeCodeRequest(LockableChangeCodeRequest other)
	{
	}

	[Token(Token = "0x6004E31")]
	[Address(RVA = "0xAC15D0", Offset = "0xAC09D0", VA = "0x180AC15D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LockableChangeCodeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004E34")]
	[Address(RVA = "0xAC16A0", Offset = "0xAC0AA0", VA = "0x180AC16A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E35")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(LockableChangeCodeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E36")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004E37")]
	[Address(RVA = "0xAC17B0", Offset = "0xAC0BB0", VA = "0x180AC17B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004E38")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004E39")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004E3A")]
	[Address(RVA = "0xAC1540", Offset = "0xAC0940", VA = "0x180AC1540", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004E3B")]
	[Address(RVA = "0xAC1750", Offset = "0xAC0B50", VA = "0x180AC1750", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(LockableChangeCodeRequest other)
	{
	}

	[Token(Token = "0x6004E3C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004E3D")]
	[Address(RVA = "0xAC1B00", Offset = "0xAC0F00", VA = "0x180AC1B00", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
