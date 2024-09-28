using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x20002A6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyGuest : IMessage<PartyGuest>, IMessage, IEquatable<PartyGuest>, IDeepCloneable<PartyGuest>, IBufferMessage
{
	[Token(Token = "0x400094A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyGuest> _parser;

	[Token(Token = "0x400094B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400094C")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x400094D")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x400094E")]
	public const int HostIdFieldNumber = 2;

	[Token(Token = "0x400094F")]
	[FieldOffset(Offset = "0x20")]
	private long hostId_;

	[Token(Token = "0x4000950")]
	public const int NameFieldNumber = 3;

	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0x28")]
	private string name_;

	[Token(Token = "0x4000952")]
	public const int LookFieldNumber = 4;

	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x30")]
	private EntityLook look_;

	[Token(Token = "0x4000954")]
	public const int BreedFieldNumber = 5;

	[Token(Token = "0x4000955")]
	[FieldOffset(Offset = "0x38")]
	private int breed_;

	[Token(Token = "0x4000956")]
	public const int GenderFieldNumber = 6;

	[Token(Token = "0x4000957")]
	[FieldOffset(Offset = "0x3C")]
	private Gender gender_;

	[Token(Token = "0x4000958")]
	public const int StatusFieldNumber = 7;

	[Token(Token = "0x4000959")]
	[FieldOffset(Offset = "0x40")]
	private CharacterStatus status_;

	[Token(Token = "0x400095A")]
	public const int EntitiesFieldNumber = 8;

	[Token(Token = "0x400095B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<PartyEntity> _repeated_entities_codec;

	[Token(Token = "0x400095C")]
	[FieldOffset(Offset = "0x48")]
	private readonly RepeatedField<PartyEntity> entities_;

	[Token(Token = "0x170005EB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyGuest> Parser
	{
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0xD10640", Offset = "0xD0FA40", VA = "0x180D10640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0xD10590", Offset = "0xD0F990", VA = "0x180D10590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005ED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001B80")]
		[Address(RVA = "0xD10AD0", Offset = "0xD0FED0", VA = "0x180D10AD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005EE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170005EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long HostId
	{
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170005F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0xD10BB0", Offset = "0xD0FFB0", VA = "0x180D10BB0")]
		set
		{
		}
	}

	[Token(Token = "0x170005F1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityLook Look
	{
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
		set
		{
		}
	}

	[Token(Token = "0x170005F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Breed
	{
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
		set
		{
		}
	}

	[Token(Token = "0x170005F3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Gender Gender
	{
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x946B90", Offset = "0x945F90", VA = "0x180946B90")]
		get
		{
			return default(Gender);
		}
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x9470F0", Offset = "0x9464F0", VA = "0x1809470F0")]
		set
		{
		}
	}

	[Token(Token = "0x170005F4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterStatus Status
	{
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x7D6D20", Offset = "0x7D6120", VA = "0x1807D6D20")]
		set
		{
		}
	}

	[Token(Token = "0x170005F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PartyEntity> Entities
	{
		[Token(Token = "0x6001B92")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001B81")]
	[Address(RVA = "0xD103E0", Offset = "0xD0F7E0", VA = "0x180D103E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyGuest()
	{
	}

	[Token(Token = "0x6001B82")]
	[Address(RVA = "0xD10480", Offset = "0xD0F880", VA = "0x180D10480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyGuest(PartyGuest other)
	{
	}

	[Token(Token = "0x6001B83")]
	[Address(RVA = "0xD0FB70", Offset = "0xD0EF70", VA = "0x180D0FB70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyGuest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001B93")]
	[Address(RVA = "0xD0FCB0", Offset = "0xD0F0B0", VA = "0x180D0FCB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B94")]
	[Address(RVA = "0xD0FE00", Offset = "0xD0F200", VA = "0x180D0FE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyGuest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B95")]
	[Address(RVA = "0xD0FF00", Offset = "0xD0F300", VA = "0x180D0FF00", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001B96")]
	[Address(RVA = "0xD101E0", Offset = "0xD0F5E0", VA = "0x180D101E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001B97")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001B98")]
	[Address(RVA = "0xD10920", Offset = "0xD0FD20", VA = "0x180D10920", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001B99")]
	[Address(RVA = "0xD0F980", Offset = "0xD0ED80", VA = "0x180D0F980", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001B9A")]
	[Address(RVA = "0xD10040", Offset = "0xD0F440", VA = "0x180D10040", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyGuest other)
	{
	}

	[Token(Token = "0x6001B9B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001B9C")]
	[Address(RVA = "0xD10690", Offset = "0xD0FA90", VA = "0x180D10690", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
