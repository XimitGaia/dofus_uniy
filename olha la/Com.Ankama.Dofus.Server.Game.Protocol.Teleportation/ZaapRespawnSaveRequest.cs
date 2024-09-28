using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000069")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ZaapRespawnSaveRequest : IMessage<ZaapRespawnSaveRequest>, IMessage, IEquatable<ZaapRespawnSaveRequest>, IDeepCloneable<ZaapRespawnSaveRequest>, IBufferMessage
{
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ZaapRespawnSaveRequest> _parser;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170000BD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ZaapRespawnSaveRequest> Parser
	{
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x9689D0", Offset = "0x967DD0", VA = "0x1809689D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x968920", Offset = "0x967D20", VA = "0x180968920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x968A20", Offset = "0x967E20", VA = "0x180968A20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ZaapRespawnSaveRequest()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ZaapRespawnSaveRequest(ZaapRespawnSaveRequest other)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x9686C0", Offset = "0x967AC0", VA = "0x1809686C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ZaapRespawnSaveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x968740", Offset = "0x967B40", VA = "0x180968740", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ZaapRespawnSaveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x9687C0", Offset = "0x967BC0", VA = "0x1809687C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ZaapRespawnSaveRequest other)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
