using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haapi;

[Token(Token = "0x2000454")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HaapiAuthenticationErrorEvent : IMessage<HaapiAuthenticationErrorEvent>, IMessage, IEquatable<HaapiAuthenticationErrorEvent>, IDeepCloneable<HaapiAuthenticationErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4000EE8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HaapiAuthenticationErrorEvent> _parser;

	[Token(Token = "0x4000EE9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170009BB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HaapiAuthenticationErrorEvent> Parser
	{
		[Token(Token = "0x6002D95")]
		[Address(RVA = "0x9B68E0", Offset = "0x9B5CE0", VA = "0x1809B68E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009BC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002D96")]
		[Address(RVA = "0x9B6830", Offset = "0x9B5C30", VA = "0x1809B6830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009BD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002D97")]
		[Address(RVA = "0x9B6930", Offset = "0x9B5D30", VA = "0x1809B6930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002D98")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HaapiAuthenticationErrorEvent()
	{
	}

	[Token(Token = "0x6002D99")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HaapiAuthenticationErrorEvent(HaapiAuthenticationErrorEvent other)
	{
	}

	[Token(Token = "0x6002D9A")]
	[Address(RVA = "0x9B65D0", Offset = "0x9B59D0", VA = "0x1809B65D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HaapiAuthenticationErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002D9B")]
	[Address(RVA = "0x9B6650", Offset = "0x9B5A50", VA = "0x1809B6650", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D9C")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HaapiAuthenticationErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D9D")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002D9E")]
	[Address(RVA = "0x9B66D0", Offset = "0x9B5AD0", VA = "0x1809B66D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002D9F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002DA0")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002DA1")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002DA2")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HaapiAuthenticationErrorEvent other)
	{
	}

	[Token(Token = "0x6002DA3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002DA4")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
