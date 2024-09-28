using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B38")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class WhoIsRequest : IMessage<WhoIsRequest>, IMessage, IEquatable<WhoIsRequest>, IDeepCloneable<WhoIsRequest>, IBufferMessage
{
	[Token(Token = "0x40029EC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<WhoIsRequest> _parser;

	[Token(Token = "0x40029ED")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40029EE")]
	public const int VerboseFieldNumber = 1;

	[Token(Token = "0x40029EF")]
	[FieldOffset(Offset = "0x18")]
	private bool verbose_;

	[Token(Token = "0x40029F0")]
	public const int TargetFieldNumber = 2;

	[Token(Token = "0x40029F1")]
	[FieldOffset(Offset = "0x20")]
	private PlayerSearch target_;

	[Token(Token = "0x17001A0F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<WhoIsRequest> Parser
	{
		[Token(Token = "0x600763C")]
		[Address(RVA = "0xC2C030", Offset = "0xC2B430", VA = "0x180C2C030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600763D")]
		[Address(RVA = "0xC2BF80", Offset = "0xC2B380", VA = "0x180C2BF80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600763E")]
		[Address(RVA = "0xC2C1B0", Offset = "0xC2B5B0", VA = "0x180C2C1B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Verbose
	{
		[Token(Token = "0x6007642")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007643")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001A13")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerSearch Target
	{
		[Token(Token = "0x6007644")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007645")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x600763F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoIsRequest()
	{
	}

	[Token(Token = "0x6007640")]
	[Address(RVA = "0xC2BF10", Offset = "0xC2B310", VA = "0x180C2BF10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoIsRequest(WhoIsRequest other)
	{
	}

	[Token(Token = "0x6007641")]
	[Address(RVA = "0xC2BAC0", Offset = "0xC2AEC0", VA = "0x180C2BAC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WhoIsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007646")]
	[Address(RVA = "0xC2BB60", Offset = "0xC2AF60", VA = "0x180C2BB60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007647")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(WhoIsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007648")]
	[Address(RVA = "0xC2BC10", Offset = "0xC2B010", VA = "0x180C2BC10", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007649")]
	[Address(RVA = "0xC2BDB0", Offset = "0xC2B1B0", VA = "0x180C2BDB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600764A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600764B")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600764C")]
	[Address(RVA = "0xC2BA20", Offset = "0xC2AE20", VA = "0x180C2BA20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600764D")]
	[Address(RVA = "0xC2BCD0", Offset = "0xC2B0D0", VA = "0x180C2BCD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(WhoIsRequest other)
	{
	}

	[Token(Token = "0x600764E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600764F")]
	[Address(RVA = "0xC2C080", Offset = "0xC2B480", VA = "0x180C2C080", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
