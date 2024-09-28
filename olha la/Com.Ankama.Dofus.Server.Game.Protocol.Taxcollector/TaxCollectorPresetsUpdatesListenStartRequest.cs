using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x200009A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorPresetsUpdatesListenStartRequest : IMessage<TaxCollectorPresetsUpdatesListenStartRequest>, IMessage, IEquatable<TaxCollectorPresetsUpdatesListenStartRequest>, IDeepCloneable<TaxCollectorPresetsUpdatesListenStartRequest>, IBufferMessage
{
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorPresetsUpdatesListenStartRequest> _parser;

	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000136")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorPresetsUpdatesListenStartRequest> Parser
	{
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x957550", Offset = "0x956950", VA = "0x180957550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000137")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x9574A0", Offset = "0x9568A0", VA = "0x1809574A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000138")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x9575A0", Offset = "0x9569A0", VA = "0x1809575A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPresetsUpdatesListenStartRequest()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetsUpdatesListenStartRequest(TaxCollectorPresetsUpdatesListenStartRequest other)
	{
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x957240", Offset = "0x956640", VA = "0x180957240", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPresetsUpdatesListenStartRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x9572C0", Offset = "0x9566C0", VA = "0x1809572C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorPresetsUpdatesListenStartRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x957340", Offset = "0x956740", VA = "0x180957340", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorPresetsUpdatesListenStartRequest other)
	{
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
