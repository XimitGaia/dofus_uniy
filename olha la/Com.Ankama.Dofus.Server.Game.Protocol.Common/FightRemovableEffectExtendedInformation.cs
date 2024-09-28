using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A3C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightRemovableEffectExtendedInformation : IMessage<FightRemovableEffectExtendedInformation>, IMessage, IEquatable<FightRemovableEffectExtendedInformation>, IDeepCloneable<FightRemovableEffectExtendedInformation>, IBufferMessage
{
	[Token(Token = "0x40024E0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightRemovableEffectExtendedInformation> _parser;

	[Token(Token = "0x40024E1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40024E2")]
	public const int ActionIdFieldNumber = 1;

	[Token(Token = "0x40024E3")]
	[FieldOffset(Offset = "0x18")]
	private int actionId_;

	[Token(Token = "0x40024E4")]
	public const int SourceIdFieldNumber = 2;

	[Token(Token = "0x40024E5")]
	[FieldOffset(Offset = "0x20")]
	private long sourceId_;

	[Token(Token = "0x40024E6")]
	public const int EffectFieldNumber = 3;

	[Token(Token = "0x40024E7")]
	[FieldOffset(Offset = "0x28")]
	private FightRemovableEffect effect_;

	[Token(Token = "0x1700171E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightRemovableEffectExtendedInformation> Parser
	{
		[Token(Token = "0x6006B05")]
		[Address(RVA = "0xBB77F0", Offset = "0xBB6BF0", VA = "0x180BB77F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006B06")]
		[Address(RVA = "0xBB7740", Offset = "0xBB6B40", VA = "0x180BB7740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001720")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006B07")]
		[Address(RVA = "0xBB7980", Offset = "0xBB6D80", VA = "0x180BB7980", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001721")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ActionId
	{
		[Token(Token = "0x6006B0B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B0C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001722")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SourceId
	{
		[Token(Token = "0x6006B0D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006B0E")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001723")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightRemovableEffect Effect
	{
		[Token(Token = "0x6006B0F")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006B10")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6006B08")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightRemovableEffectExtendedInformation()
	{
	}

	[Token(Token = "0x6006B09")]
	[Address(RVA = "0xBB7670", Offset = "0xBB6A70", VA = "0x180BB7670")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightRemovableEffectExtendedInformation(FightRemovableEffectExtendedInformation other)
	{
	}

	[Token(Token = "0x6006B0A")]
	[Address(RVA = "0xBB7280", Offset = "0xBB6680", VA = "0x180BB7280", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightRemovableEffectExtendedInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6006B11")]
	[Address(RVA = "0xBB7370", Offset = "0xBB6770", VA = "0x180BB7370", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B12")]
	[Address(RVA = "0xAA4160", Offset = "0xAA3560", VA = "0x180AA4160", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightRemovableEffectExtendedInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B13")]
	[Address(RVA = "0xAA41E0", Offset = "0xAA35E0", VA = "0x180AA41E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006B14")]
	[Address(RVA = "0xBB7510", Offset = "0xBB6910", VA = "0x180BB7510", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006B15")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006B16")]
	[Address(RVA = "0xAA48B0", Offset = "0xAA3CB0", VA = "0x180AA48B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006B17")]
	[Address(RVA = "0xBB7190", Offset = "0xBB6590", VA = "0x180BB7190", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006B18")]
	[Address(RVA = "0xBB7430", Offset = "0xBB6830", VA = "0x180BB7430", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightRemovableEffectExtendedInformation other)
	{
	}

	[Token(Token = "0x6006B19")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006B1A")]
	[Address(RVA = "0xBB7840", Offset = "0xBB6C40", VA = "0x180BB7840", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
