using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000138")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PvpEnableSetRequest : IMessage<PvpEnableSetRequest>, IMessage, IEquatable<PvpEnableSetRequest>, IDeepCloneable<PvpEnableSetRequest>, IBufferMessage
{
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PvpEnableSetRequest> _parser;

	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400042D")]
	public const int EnableFieldNumber = 1;

	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x18")]
	private bool enable_;

	[Token(Token = "0x17000296")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpEnableSetRequest> Parser
	{
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0xB69C20", Offset = "0xB69020", VA = "0x180B69C20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000297")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0xB69B70", Offset = "0xB68F70", VA = "0x180B69B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000298")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0xB69C70", Offset = "0xB69070", VA = "0x180B69C70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000299")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Enable
	{
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpEnableSetRequest()
	{
	}

	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpEnableSetRequest(PvpEnableSetRequest other)
	{
	}

	[Token(Token = "0x6000C25")]
	[Address(RVA = "0xB69860", Offset = "0xB68C60", VA = "0x180B69860", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpEnableSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000C28")]
	[Address(RVA = "0xB698E0", Offset = "0xB68CE0", VA = "0x180B698E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PvpEnableSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0xB69970", Offset = "0xB68D70", VA = "0x180B69970", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0xB69A10", Offset = "0xB68E10", VA = "0x180B69A10", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PvpEnableSetRequest other)
	{
	}

	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000C31")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
