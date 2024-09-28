using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C68")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationDeletedEvent : IMessage<AllianceApplicationDeletedEvent>, IMessage, IEquatable<AllianceApplicationDeletedEvent>, IDeepCloneable<AllianceApplicationDeletedEvent>, IBufferMessage
{
	[Token(Token = "0x4002DDF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationDeletedEvent> _parser;

	[Token(Token = "0x4002DE0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DE1")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002DE2")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001C9B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationDeletedEvent> Parser
	{
		[Token(Token = "0x6008289")]
		[Address(RVA = "0xC6F2E0", Offset = "0xC6E6E0", VA = "0x180C6F2E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C9C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600828A")]
		[Address(RVA = "0xC6F230", Offset = "0xC6E630", VA = "0x180C6F230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C9D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600828B")]
		[Address(RVA = "0xC6F330", Offset = "0xC6E730", VA = "0x180C6F330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C9E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x600828F")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008290")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x600828C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationDeletedEvent()
	{
	}

	[Token(Token = "0x600828D")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationDeletedEvent(AllianceApplicationDeletedEvent other)
	{
	}

	[Token(Token = "0x600828E")]
	[Address(RVA = "0xC6EF20", Offset = "0xC6E320", VA = "0x180C6EF20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationDeletedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008291")]
	[Address(RVA = "0xC6EFA0", Offset = "0xC6E3A0", VA = "0x180C6EFA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008292")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceApplicationDeletedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008293")]
	[Address(RVA = "0xC6F030", Offset = "0xC6E430", VA = "0x180C6F030", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008294")]
	[Address(RVA = "0xC6F0D0", Offset = "0xC6E4D0", VA = "0x180C6F0D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008295")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008296")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008297")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008298")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceApplicationDeletedEvent other)
	{
	}

	[Token(Token = "0x6008299")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600829A")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
