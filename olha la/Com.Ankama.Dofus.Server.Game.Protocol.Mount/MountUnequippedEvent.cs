using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000325")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountUnequippedEvent : IMessage<MountUnequippedEvent>, IMessage, IEquatable<MountUnequippedEvent>, IDeepCloneable<MountUnequippedEvent>, IBufferMessage
{
	[Token(Token = "0x4000AE7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountUnequippedEvent> _parser;

	[Token(Token = "0x4000AE8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170006FD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MountUnequippedEvent> Parser
	{
		[Token(Token = "0x6002095")]
		[Address(RVA = "0x97C1D0", Offset = "0x97B5D0", VA = "0x18097C1D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002096")]
		[Address(RVA = "0x97C120", Offset = "0x97B520", VA = "0x18097C120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002097")]
		[Address(RVA = "0x97C220", Offset = "0x97B620", VA = "0x18097C220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002098")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountUnequippedEvent()
	{
	}

	[Token(Token = "0x6002099")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountUnequippedEvent(MountUnequippedEvent other)
	{
	}

	[Token(Token = "0x600209A")]
	[Address(RVA = "0x97BEC0", Offset = "0x97B2C0", VA = "0x18097BEC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountUnequippedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600209B")]
	[Address(RVA = "0x97BF40", Offset = "0x97B340", VA = "0x18097BF40", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600209C")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountUnequippedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600209D")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600209E")]
	[Address(RVA = "0x97BFC0", Offset = "0x97B3C0", VA = "0x18097BFC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600209F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60020A0")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60020A1")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountUnequippedEvent other)
	{
	}

	[Token(Token = "0x60020A3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60020A4")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
