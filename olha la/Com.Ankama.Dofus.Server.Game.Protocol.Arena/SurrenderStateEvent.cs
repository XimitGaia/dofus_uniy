using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BAE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SurrenderStateEvent : IMessage<SurrenderStateEvent>, IMessage, IEquatable<SurrenderStateEvent>, IDeepCloneable<SurrenderStateEvent>, IBufferMessage
{
	[Token(Token = "0x4002B97")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SurrenderStateEvent> _parser;

	[Token(Token = "0x4002B98")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B99")]
	public const int PermitSurrenderFieldNumber = 1;

	[Token(Token = "0x4002B9A")]
	[FieldOffset(Offset = "0x18")]
	private bool permitSurrender_;

	[Token(Token = "0x4002B9B")]
	public const int PermitVoteFieldNumber = 2;

	[Token(Token = "0x4002B9C")]
	[FieldOffset(Offset = "0x19")]
	private bool permitVote_;

	[Token(Token = "0x17001B0E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SurrenderStateEvent> Parser
	{
		[Token(Token = "0x6007AE0")]
		[Address(RVA = "0xC3B7B0", Offset = "0xC3ABB0", VA = "0x180C3B7B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B0F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007AE1")]
		[Address(RVA = "0xC3B700", Offset = "0xC3AB00", VA = "0x180C3B700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007AE2")]
		[Address(RVA = "0xC3B800", Offset = "0xC3AC00", VA = "0x180C3B800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PermitSurrender
	{
		[Token(Token = "0x6007AE6")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007AE7")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001B12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool PermitVote
	{
		[Token(Token = "0x6007AE8")]
		[Address(RVA = "0x87EAB0", Offset = "0x87DEB0", VA = "0x18087EAB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007AE9")]
		[Address(RVA = "0x87EAF0", Offset = "0x87DEF0", VA = "0x18087EAF0")]
		set
		{
		}
	}

	[Token(Token = "0x6007AE3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderStateEvent()
	{
	}

	[Token(Token = "0x6007AE4")]
	[Address(RVA = "0x9DA130", Offset = "0x9D9530", VA = "0x1809DA130")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderStateEvent(SurrenderStateEvent other)
	{
	}

	[Token(Token = "0x6007AE5")]
	[Address(RVA = "0xC3B3A0", Offset = "0xC3A7A0", VA = "0x180C3B3A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderStateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007AEA")]
	[Address(RVA = "0xC3B430", Offset = "0xC3A830", VA = "0x180C3B430", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007AEB")]
	[Address(RVA = "0x9D9DC0", Offset = "0x9D91C0", VA = "0x1809D9DC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SurrenderStateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007AEC")]
	[Address(RVA = "0xC3B4D0", Offset = "0xC3A8D0", VA = "0x180C3B4D0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007AED")]
	[Address(RVA = "0xC3B5A0", Offset = "0xC3A9A0", VA = "0x180C3B5A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007AEE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007AEF")]
	[Address(RVA = "0x9DA350", Offset = "0x9D9750", VA = "0x1809DA350", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007AF0")]
	[Address(RVA = "0x9D9CF0", Offset = "0x9D90F0", VA = "0x1809D9CF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007AF1")]
	[Address(RVA = "0x9D9F70", Offset = "0x9D9370", VA = "0x1809D9F70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SurrenderStateEvent other)
	{
	}

	[Token(Token = "0x6007AF2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007AF3")]
	[Address(RVA = "0x9DA290", Offset = "0x9D9690", VA = "0x1809DA290", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
