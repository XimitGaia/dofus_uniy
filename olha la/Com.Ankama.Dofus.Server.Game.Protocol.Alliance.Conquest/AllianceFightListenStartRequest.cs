using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CD5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightListenStartRequest : IMessage<AllianceFightListenStartRequest>, IMessage, IEquatable<AllianceFightListenStartRequest>, IDeepCloneable<AllianceFightListenStartRequest>, IBufferMessage
{
	[Token(Token = "0x4002F48")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightListenStartRequest> _parser;

	[Token(Token = "0x4002F49")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001D93")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceFightListenStartRequest> Parser
	{
		[Token(Token = "0x6008738")]
		[Address(RVA = "0xCAC5F0", Offset = "0xCAB9F0", VA = "0x180CAC5F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D94")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008739")]
		[Address(RVA = "0xCAC540", Offset = "0xCAB940", VA = "0x180CAC540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D95")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600873A")]
		[Address(RVA = "0xCAC640", Offset = "0xCABA40", VA = "0x180CAC640", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600873B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightListenStartRequest()
	{
	}

	[Token(Token = "0x600873C")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightListenStartRequest(AllianceFightListenStartRequest other)
	{
	}

	[Token(Token = "0x600873D")]
	[Address(RVA = "0xCAC2E0", Offset = "0xCAB6E0", VA = "0x180CAC2E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightListenStartRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600873E")]
	[Address(RVA = "0xCAC360", Offset = "0xCAB760", VA = "0x180CAC360", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600873F")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceFightListenStartRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008740")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008741")]
	[Address(RVA = "0xCAC3E0", Offset = "0xCAB7E0", VA = "0x180CAC3E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008742")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008743")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008744")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008745")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceFightListenStartRequest other)
	{
	}

	[Token(Token = "0x6008746")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008747")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
