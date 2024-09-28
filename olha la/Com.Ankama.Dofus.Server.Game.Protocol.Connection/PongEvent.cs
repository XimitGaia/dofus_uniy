using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection;

[Token(Token = "0x2000817")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PongEvent : IMessage<PongEvent>, IMessage, IEquatable<PongEvent>, IDeepCloneable<PongEvent>, IBufferMessage
{
	[Token(Token = "0x4001BF9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PongEvent> _parser;

	[Token(Token = "0x4001BFA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001BFB")]
	public const int QuietFieldNumber = 1;

	[Token(Token = "0x4001BFC")]
	[FieldOffset(Offset = "0x18")]
	private bool quiet_;

	[Token(Token = "0x1700124E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PongEvent> Parser
	{
		[Token(Token = "0x60055ED")]
		[Address(RVA = "0xB0E5D0", Offset = "0xB0D9D0", VA = "0x180B0E5D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700124F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60055EE")]
		[Address(RVA = "0xB0E520", Offset = "0xB0D920", VA = "0x180B0E520")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001250")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60055EF")]
		[Address(RVA = "0xB0E620", Offset = "0xB0DA20", VA = "0x180B0E620", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001251")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Quiet
	{
		[Token(Token = "0x60055F3")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60055F4")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60055F0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PongEvent()
	{
	}

	[Token(Token = "0x60055F1")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PongEvent(PongEvent other)
	{
	}

	[Token(Token = "0x60055F2")]
	[Address(RVA = "0xB0E210", Offset = "0xB0D610", VA = "0x180B0E210", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PongEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60055F5")]
	[Address(RVA = "0xB0E290", Offset = "0xB0D690", VA = "0x180B0E290", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60055F6")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PongEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60055F7")]
	[Address(RVA = "0xB0E320", Offset = "0xB0D720", VA = "0x180B0E320", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60055F8")]
	[Address(RVA = "0xB0E3C0", Offset = "0xB0D7C0", VA = "0x180B0E3C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60055F9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60055FA")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60055FB")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60055FC")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PongEvent other)
	{
	}

	[Token(Token = "0x60055FD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60055FE")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
