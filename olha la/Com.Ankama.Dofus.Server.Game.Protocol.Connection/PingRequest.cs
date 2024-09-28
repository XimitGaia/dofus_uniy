using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection;

[Token(Token = "0x2000815")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PingRequest : IMessage<PingRequest>, IMessage, IEquatable<PingRequest>, IDeepCloneable<PingRequest>, IBufferMessage
{
	[Token(Token = "0x4001BF4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PingRequest> _parser;

	[Token(Token = "0x4001BF5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001BF6")]
	public const int QuietFieldNumber = 1;

	[Token(Token = "0x4001BF7")]
	[FieldOffset(Offset = "0x18")]
	private bool quiet_;

	[Token(Token = "0x1700124A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PingRequest> Parser
	{
		[Token(Token = "0x60055D7")]
		[Address(RVA = "0xB0E0E0", Offset = "0xB0D4E0", VA = "0x180B0E0E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700124B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60055D8")]
		[Address(RVA = "0xB0E030", Offset = "0xB0D430", VA = "0x180B0E030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700124C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60055D9")]
		[Address(RVA = "0xB0E130", Offset = "0xB0D530", VA = "0x180B0E130", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700124D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Quiet
	{
		[Token(Token = "0x60055DD")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60055DE")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60055DA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PingRequest()
	{
	}

	[Token(Token = "0x60055DB")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PingRequest(PingRequest other)
	{
	}

	[Token(Token = "0x60055DC")]
	[Address(RVA = "0xB0DD20", Offset = "0xB0D120", VA = "0x180B0DD20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PingRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60055DF")]
	[Address(RVA = "0xB0DDA0", Offset = "0xB0D1A0", VA = "0x180B0DDA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60055E0")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PingRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60055E1")]
	[Address(RVA = "0xB0DE30", Offset = "0xB0D230", VA = "0x180B0DE30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60055E2")]
	[Address(RVA = "0xB0DED0", Offset = "0xB0D2D0", VA = "0x180B0DED0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60055E3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60055E4")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60055E5")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60055E6")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PingRequest other)
	{
	}

	[Token(Token = "0x60055E7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60055E8")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
