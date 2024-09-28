using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haapi;

[Token(Token = "0x2000450")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HaapiTokenRequest : IMessage<HaapiTokenRequest>, IMessage, IEquatable<HaapiTokenRequest>, IDeepCloneable<HaapiTokenRequest>, IBufferMessage
{
	[Token(Token = "0x4000EE0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HaapiTokenRequest> _parser;

	[Token(Token = "0x4000EE1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170009B4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HaapiTokenRequest> Parser
	{
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x9B83A0", Offset = "0x9B77A0", VA = "0x1809B83A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009B5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x9B82F0", Offset = "0x9B76F0", VA = "0x1809B82F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009B6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x9B83F0", Offset = "0x9B77F0", VA = "0x1809B83F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002D6E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HaapiTokenRequest()
	{
	}

	[Token(Token = "0x6002D6F")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HaapiTokenRequest(HaapiTokenRequest other)
	{
	}

	[Token(Token = "0x6002D70")]
	[Address(RVA = "0x9B8090", Offset = "0x9B7490", VA = "0x1809B8090", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HaapiTokenRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002D71")]
	[Address(RVA = "0x9B8110", Offset = "0x9B7510", VA = "0x1809B8110", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D72")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HaapiTokenRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D73")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002D74")]
	[Address(RVA = "0x9B8190", Offset = "0x9B7590", VA = "0x1809B8190", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002D75")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002D76")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002D77")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002D78")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HaapiTokenRequest other)
	{
	}

	[Token(Token = "0x6002D79")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002D7A")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
