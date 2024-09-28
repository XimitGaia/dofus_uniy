using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CFF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NuggetsListenStopRequest : IMessage<NuggetsListenStopRequest>, IMessage, IEquatable<NuggetsListenStopRequest>, IDeepCloneable<NuggetsListenStopRequest>, IBufferMessage
{
	[Token(Token = "0x4002FCA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NuggetsListenStopRequest> _parser;

	[Token(Token = "0x4002FCB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001DEC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NuggetsListenStopRequest> Parser
	{
		[Token(Token = "0x60088EF")]
		[Address(RVA = "0xCB62B0", Offset = "0xCB56B0", VA = "0x180CB62B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60088F0")]
		[Address(RVA = "0xCB6200", Offset = "0xCB5600", VA = "0x180CB6200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DEE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60088F1")]
		[Address(RVA = "0xCB6300", Offset = "0xCB5700", VA = "0x180CB6300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60088F2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NuggetsListenStopRequest()
	{
	}

	[Token(Token = "0x60088F3")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsListenStopRequest(NuggetsListenStopRequest other)
	{
	}

	[Token(Token = "0x60088F4")]
	[Address(RVA = "0xCB5FA0", Offset = "0xCB53A0", VA = "0x180CB5FA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsListenStopRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60088F5")]
	[Address(RVA = "0xCB6020", Offset = "0xCB5420", VA = "0x180CB6020", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60088F6")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(NuggetsListenStopRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60088F7")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60088F8")]
	[Address(RVA = "0xCB60A0", Offset = "0xCB54A0", VA = "0x180CB60A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60088F9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60088FA")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60088FB")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60088FC")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NuggetsListenStopRequest other)
	{
	}

	[Token(Token = "0x60088FD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60088FE")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
