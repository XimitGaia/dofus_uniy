using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BB0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SurrenderInfoRequest : IMessage<SurrenderInfoRequest>, IMessage, IEquatable<SurrenderInfoRequest>, IDeepCloneable<SurrenderInfoRequest>, IBufferMessage
{
	[Token(Token = "0x4002B9E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SurrenderInfoRequest> _parser;

	[Token(Token = "0x4002B9F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001B13")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SurrenderInfoRequest> Parser
	{
		[Token(Token = "0x6007AF8")]
		[Address(RVA = "0xC38EA0", Offset = "0xC382A0", VA = "0x180C38EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B14")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007AF9")]
		[Address(RVA = "0xC38DF0", Offset = "0xC381F0", VA = "0x180C38DF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B15")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007AFA")]
		[Address(RVA = "0xC38EF0", Offset = "0xC382F0", VA = "0x180C38EF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007AFB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderInfoRequest()
	{
	}

	[Token(Token = "0x6007AFC")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderInfoRequest(SurrenderInfoRequest other)
	{
	}

	[Token(Token = "0x6007AFD")]
	[Address(RVA = "0xC38B90", Offset = "0xC37F90", VA = "0x180C38B90", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SurrenderInfoRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007AFE")]
	[Address(RVA = "0xC38C10", Offset = "0xC38010", VA = "0x180C38C10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007AFF")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SurrenderInfoRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007B00")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007B01")]
	[Address(RVA = "0xC38C90", Offset = "0xC38090", VA = "0x180C38C90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007B02")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007B03")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007B04")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007B05")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SurrenderInfoRequest other)
	{
	}

	[Token(Token = "0x6007B06")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007B07")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
