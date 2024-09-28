using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x200009C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorPresetsUpdatesListenStopRequest : IMessage<TaxCollectorPresetsUpdatesListenStopRequest>, IMessage, IEquatable<TaxCollectorPresetsUpdatesListenStopRequest>, IDeepCloneable<TaxCollectorPresetsUpdatesListenStopRequest>, IBufferMessage
{
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorPresetsUpdatesListenStopRequest> _parser;

	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000139")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorPresetsUpdatesListenStopRequest> Parser
	{
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x957990", Offset = "0x956D90", VA = "0x180957990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700013A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x9578E0", Offset = "0x956CE0", VA = "0x1809578E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700013B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x9579E0", Offset = "0x956DE0", VA = "0x1809579E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetsUpdatesListenStopRequest()
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetsUpdatesListenStopRequest(TaxCollectorPresetsUpdatesListenStopRequest other)
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x957680", Offset = "0x956A80", VA = "0x180957680", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetsUpdatesListenStopRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x957700", Offset = "0x956B00", VA = "0x180957700", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorPresetsUpdatesListenStopRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x957780", Offset = "0x956B80", VA = "0x180957780", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorPresetsUpdatesListenStopRequest other)
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
