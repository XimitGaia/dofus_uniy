using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alteration;

[Token(Token = "0x2000C49")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Alteration : IMessage<Alteration>, IMessage, IEquatable<Alteration>, IDeepCloneable<Alteration>, IBufferMessage
{
	[Token(Token = "0x2000C4A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000C4B")]
		public enum AlterationExpirationType
		{
			[Token(Token = "0x4002D98")]
			[OriginalName("UNKNOWN")]
			Unknown,
			[Token(Token = "0x4002D99")]
			[OriginalName("INFINITE")]
			Infinite,
			[Token(Token = "0x4002D9A")]
			[OriginalName("DATE")]
			Date,
			[Token(Token = "0x4002D9B")]
			[OriginalName("FIGHT_COUNT")]
			FightCount,
			[Token(Token = "0x4002D9C")]
			[OriginalName("FIGHTS_WON_COUNT")]
			FightsWonCount,
			[Token(Token = "0x4002D9D")]
			[OriginalName("FIGHTS_LOST_COUNT")]
			FightsLostCount
		}
	}

	[Token(Token = "0x4002D8A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Alteration> _parser;

	[Token(Token = "0x4002D8B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D8C")]
	public const int AlterationIdFieldNumber = 1;

	[Token(Token = "0x4002D8D")]
	[FieldOffset(Offset = "0x18")]
	private long alterationId_;

	[Token(Token = "0x4002D8E")]
	public const int CreationTimeFieldNumber = 2;

	[Token(Token = "0x4002D8F")]
	[FieldOffset(Offset = "0x20")]
	private long creationTime_;

	[Token(Token = "0x4002D90")]
	public const int ExpirationTypeFieldNumber = 3;

	[Token(Token = "0x4002D91")]
	[FieldOffset(Offset = "0x28")]
	private Types.AlterationExpirationType expirationType_;

	[Token(Token = "0x4002D92")]
	public const int ExpirationValueFieldNumber = 4;

	[Token(Token = "0x4002D93")]
	[FieldOffset(Offset = "0x30")]
	private long expirationValue_;

	[Token(Token = "0x4002D94")]
	public const int EffectsFieldNumber = 5;

	[Token(Token = "0x4002D95")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

	[Token(Token = "0x4002D96")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<ObjectEffect> effects_;

	[Token(Token = "0x17001C5F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<Alteration> Parser
	{
		[Token(Token = "0x600814E")]
		[Address(RVA = "0xC81740", Offset = "0xC80B40", VA = "0x180C81740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600814F")]
		[Address(RVA = "0xC81690", Offset = "0xC80A90", VA = "0x180C81690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C61")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008150")]
		[Address(RVA = "0xC81A60", Offset = "0xC80E60", VA = "0x180C81A60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C62")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AlterationId
	{
		[Token(Token = "0x6008154")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008155")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001C63")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CreationTime
	{
		[Token(Token = "0x6008156")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008157")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001C64")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.AlterationExpirationType ExpirationType
	{
		[Token(Token = "0x6008158")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(Types.AlterationExpirationType);
		}
		[Token(Token = "0x6008159")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001C65")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ExpirationValue
	{
		[Token(Token = "0x600815A")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600815B")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001C66")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectEffect> Effects
	{
		[Token(Token = "0x600815C")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008151")]
	[Address(RVA = "0xC81610", Offset = "0xC80A10", VA = "0x180C81610")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Alteration()
	{
	}

	[Token(Token = "0x6008152")]
	[Address(RVA = "0xC81560", Offset = "0xC80960", VA = "0x180C81560")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Alteration(Alteration other)
	{
	}

	[Token(Token = "0x6008153")]
	[Address(RVA = "0xC80F30", Offset = "0xC80330", VA = "0x180C80F30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Alteration Clone()
	{
		return null;
	}

	[Token(Token = "0x600815D")]
	[Address(RVA = "0xC81010", Offset = "0xC80410", VA = "0x180C81010", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600815E")]
	[Address(RVA = "0xC81110", Offset = "0xC80510", VA = "0x180C81110", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Alteration other)
	{
		return default(bool);
	}

	[Token(Token = "0x600815F")]
	[Address(RVA = "0xC811D0", Offset = "0xC805D0", VA = "0x180C811D0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008160")]
	[Address(RVA = "0xC81360", Offset = "0xC80760", VA = "0x180C81360", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008161")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008162")]
	[Address(RVA = "0xC81920", Offset = "0xC80D20", VA = "0x180C81920", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008163")]
	[Address(RVA = "0xC80DC0", Offset = "0xC801C0", VA = "0x180C80DC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008164")]
	[Address(RVA = "0xC812B0", Offset = "0xC806B0", VA = "0x180C812B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Alteration other)
	{
	}

	[Token(Token = "0x6008165")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008166")]
	[Address(RVA = "0xC81790", Offset = "0xC80B90", VA = "0x180C81790", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
