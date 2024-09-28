using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Finish.Move;

[Token(Token = "0x20005D5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishMovesRequest : IMessage<FinishMovesRequest>, IMessage, IEquatable<FinishMovesRequest>, IDeepCloneable<FinishMovesRequest>, IBufferMessage
{
	[Token(Token = "0x400145B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FinishMovesRequest> _parser;

	[Token(Token = "0x400145C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000D58")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FinishMovesRequest> Parser
	{
		[Token(Token = "0x6003E39")]
		[Address(RVA = "0xA50C60", Offset = "0xA50060", VA = "0x180A50C60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D59")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003E3A")]
		[Address(RVA = "0xA50BB0", Offset = "0xA4FFB0", VA = "0x180A50BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D5A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003E3B")]
		[Address(RVA = "0xA50CB0", Offset = "0xA500B0", VA = "0x180A50CB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E3C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishMovesRequest()
	{
	}

	[Token(Token = "0x6003E3D")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishMovesRequest(FinishMovesRequest other)
	{
	}

	[Token(Token = "0x6003E3E")]
	[Address(RVA = "0xA50950", Offset = "0xA4FD50", VA = "0x180A50950", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishMovesRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003E3F")]
	[Address(RVA = "0xA509D0", Offset = "0xA4FDD0", VA = "0x180A509D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E40")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishMovesRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E41")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003E42")]
	[Address(RVA = "0xA50A50", Offset = "0xA4FE50", VA = "0x180A50A50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003E43")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003E44")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003E45")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003E46")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishMovesRequest other)
	{
	}

	[Token(Token = "0x6003E47")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003E48")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
