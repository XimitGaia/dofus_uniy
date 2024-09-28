using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification;

[Token(Token = "0x200082C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ServerVerificationEvent : IMessage<ServerVerificationEvent>, IMessage, IEquatable<ServerVerificationEvent>, IDeepCloneable<ServerVerificationEvent>, IBufferMessage
{
	[Token(Token = "0x4001C2D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ServerVerificationEvent> _parser;

	[Token(Token = "0x4001C2E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001277")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ServerVerificationEvent> Parser
	{
		[Token(Token = "0x60056CA")]
		[Address(RVA = "0xB11600", Offset = "0xB10A00", VA = "0x180B11600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001278")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60056CB")]
		[Address(RVA = "0xB11550", Offset = "0xB10950", VA = "0x180B11550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001279")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60056CC")]
		[Address(RVA = "0xB11650", Offset = "0xB10A50", VA = "0x180B11650", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60056CD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerVerificationEvent()
	{
	}

	[Token(Token = "0x60056CE")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerVerificationEvent(ServerVerificationEvent other)
	{
	}

	[Token(Token = "0x60056CF")]
	[Address(RVA = "0xB112F0", Offset = "0xB106F0", VA = "0x180B112F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerVerificationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60056D0")]
	[Address(RVA = "0xB11370", Offset = "0xB10770", VA = "0x180B11370", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60056D1")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerVerificationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60056D2")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60056D3")]
	[Address(RVA = "0xB113F0", Offset = "0xB107F0", VA = "0x180B113F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60056D4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60056D5")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60056D6")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60056D7")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ServerVerificationEvent other)
	{
	}

	[Token(Token = "0x60056D8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60056D9")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
