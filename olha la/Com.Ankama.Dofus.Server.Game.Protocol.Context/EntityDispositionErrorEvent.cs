using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x2000799")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EntityDispositionErrorEvent : IMessage<EntityDispositionErrorEvent>, IMessage, IEquatable<EntityDispositionErrorEvent>, IDeepCloneable<EntityDispositionErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4001A72")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EntityDispositionErrorEvent> _parser;

	[Token(Token = "0x4001A73")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001143")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EntityDispositionErrorEvent> Parser
	{
		[Token(Token = "0x60050DA")]
		[Address(RVA = "0xADD1E0", Offset = "0xADC5E0", VA = "0x180ADD1E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001144")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60050DB")]
		[Address(RVA = "0xADD130", Offset = "0xADC530", VA = "0x180ADD130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001145")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60050DC")]
		[Address(RVA = "0xADD230", Offset = "0xADC630", VA = "0x180ADD230", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60050DD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityDispositionErrorEvent()
	{
	}

	[Token(Token = "0x60050DE")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityDispositionErrorEvent(EntityDispositionErrorEvent other)
	{
	}

	[Token(Token = "0x60050DF")]
	[Address(RVA = "0xADCED0", Offset = "0xADC2D0", VA = "0x180ADCED0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityDispositionErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60050E0")]
	[Address(RVA = "0xADCF50", Offset = "0xADC350", VA = "0x180ADCF50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60050E1")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EntityDispositionErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60050E2")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60050E3")]
	[Address(RVA = "0xADCFD0", Offset = "0xADC3D0", VA = "0x180ADCFD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60050E4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60050E5")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60050E6")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60050E7")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EntityDispositionErrorEvent other)
	{
	}

	[Token(Token = "0x60050E8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60050E9")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
