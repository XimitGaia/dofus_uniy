using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000871")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterExperienceGainEvent : IMessage<CharacterExperienceGainEvent>, IMessage, IEquatable<CharacterExperienceGainEvent>, IDeepCloneable<CharacterExperienceGainEvent>, IBufferMessage
{
	[Token(Token = "0x4001D3E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterExperienceGainEvent> _parser;

	[Token(Token = "0x4001D3F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D40")]
	public const int CharacterExperienceFieldNumber = 1;

	[Token(Token = "0x4001D41")]
	[FieldOffset(Offset = "0x18")]
	private long characterExperience_;

	[Token(Token = "0x4001D42")]
	public const int MountExperienceFieldNumber = 2;

	[Token(Token = "0x4001D43")]
	[FieldOffset(Offset = "0x20")]
	private long mountExperience_;

	[Token(Token = "0x4001D44")]
	public const int GuildExperienceFieldNumber = 3;

	[Token(Token = "0x4001D45")]
	[FieldOffset(Offset = "0x28")]
	private long guildExperience_;

	[Token(Token = "0x1700131B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterExperienceGainEvent> Parser
	{
		[Token(Token = "0x60059BF")]
		[Address(RVA = "0xB1A9D0", Offset = "0xB19DD0", VA = "0x180B1A9D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700131C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60059C0")]
		[Address(RVA = "0xB1A920", Offset = "0xB19D20", VA = "0x180B1A920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700131D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60059C1")]
		[Address(RVA = "0xB1AB90", Offset = "0xB19F90", VA = "0x180B1AB90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700131E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterExperience
	{
		[Token(Token = "0x60059C5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60059C6")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700131F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MountExperience
	{
		[Token(Token = "0x60059C7")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60059C8")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001320")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long GuildExperience
	{
		[Token(Token = "0x60059C9")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60059CA")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x60059C2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterExperienceGainEvent()
	{
	}

	[Token(Token = "0x60059C3")]
	[Address(RVA = "0xB1A8C0", Offset = "0xB19CC0", VA = "0x180B1A8C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterExperienceGainEvent(CharacterExperienceGainEvent other)
	{
	}

	[Token(Token = "0x60059C4")]
	[Address(RVA = "0xB1A4D0", Offset = "0xB198D0", VA = "0x180B1A4D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterExperienceGainEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60059CB")]
	[Address(RVA = "0xB1A560", Offset = "0xB19960", VA = "0x180B1A560", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60059CC")]
	[Address(RVA = "0xB1A600", Offset = "0xB19A00", VA = "0x180B1A600", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterExperienceGainEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60059CD")]
	[Address(RVA = "0xB1A640", Offset = "0xB19A40", VA = "0x180B1A640", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60059CE")]
	[Address(RVA = "0xB1A760", Offset = "0xB19B60", VA = "0x180B1A760", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60059CF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60059D0")]
	[Address(RVA = "0xB1AAF0", Offset = "0xB19EF0", VA = "0x180B1AAF0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60059D1")]
	[Address(RVA = "0xB1A3E0", Offset = "0xB197E0", VA = "0x180B1A3E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60059D2")]
	[Address(RVA = "0xB1A6F0", Offset = "0xB19AF0", VA = "0x180B1A6F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterExperienceGainEvent other)
	{
	}

	[Token(Token = "0x60059D3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60059D4")]
	[Address(RVA = "0xB1AA20", Offset = "0xB19E20", VA = "0x180B1AA20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
