using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A13")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FighterLightInformation : IMessage<FighterLightInformation>, IMessage, IEquatable<FighterLightInformation>, IDeepCloneable<FighterLightInformation>, IBufferMessage
{
	[Token(Token = "0x2000A14")]
	public enum FighterInfoOneofCase
	{
		[Token(Token = "0x4002428")]
		None = 0,
		[Token(Token = "0x4002429")]
		MonsterInformation = 7,
		[Token(Token = "0x400242A")]
		EntityInformation = 8,
		[Token(Token = "0x400242B")]
		TaxCollectorInformation = 9,
		[Token(Token = "0x400242C")]
		NamedInformation = 10
	}

	[Token(Token = "0x4002413")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FighterLightInformation> _parser;

	[Token(Token = "0x4002414")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002415")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4002416")]
	[FieldOffset(Offset = "0x18")]
	private long id_;

	[Token(Token = "0x4002417")]
	public const int WaveFieldNumber = 2;

	[Token(Token = "0x4002418")]
	[FieldOffset(Offset = "0x20")]
	private int wave_;

	[Token(Token = "0x4002419")]
	public const int LevelFieldNumber = 3;

	[Token(Token = "0x400241A")]
	[FieldOffset(Offset = "0x24")]
	private int level_;

	[Token(Token = "0x400241B")]
	public const int BreedIdFieldNumber = 4;

	[Token(Token = "0x400241C")]
	[FieldOffset(Offset = "0x28")]
	private int breedId_;

	[Token(Token = "0x400241D")]
	public const int GenderFieldNumber = 5;

	[Token(Token = "0x400241E")]
	[FieldOffset(Offset = "0x2C")]
	private Gender gender_;

	[Token(Token = "0x400241F")]
	public const int AliveFieldNumber = 6;

	[Token(Token = "0x4002420")]
	[FieldOffset(Offset = "0x30")]
	private bool alive_;

	[Token(Token = "0x4002421")]
	public const int MonsterInformationFieldNumber = 7;

	[Token(Token = "0x4002422")]
	public const int EntityInformationFieldNumber = 8;

	[Token(Token = "0x4002423")]
	public const int TaxCollectorInformationFieldNumber = 9;

	[Token(Token = "0x4002424")]
	public const int NamedInformationFieldNumber = 10;

	[Token(Token = "0x4002425")]
	[FieldOffset(Offset = "0x38")]
	private object fighterInfo_;

	[Token(Token = "0x4002426")]
	[FieldOffset(Offset = "0x40")]
	private FighterInfoOneofCase fighterInfoCase_;

	[Token(Token = "0x170016A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FighterLightInformation> Parser
	{
		[Token(Token = "0x600691A")]
		[Address(RVA = "0xBC3D90", Offset = "0xBC3190", VA = "0x180BC3D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016A4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600691B")]
		[Address(RVA = "0xBC3BC0", Offset = "0xBC2FC0", VA = "0x180BC3BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016A5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600691C")]
		[Address(RVA = "0xBC4520", Offset = "0xBC3920", VA = "0x180BC4520", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016A6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Id
	{
		[Token(Token = "0x6006920")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006921")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170016A7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Wave
	{
		[Token(Token = "0x6006922")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006923")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170016A8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Level
	{
		[Token(Token = "0x6006924")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006925")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x170016A9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BreedId
	{
		[Token(Token = "0x6006926")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006927")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170016AA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Gender Gender
	{
		[Token(Token = "0x6006928")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(Gender);
		}
		[Token(Token = "0x6006929")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x170016AB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Alive
	{
		[Token(Token = "0x600692A")]
		[Address(RVA = "0x9DF090", Offset = "0x9DE490", VA = "0x1809DF090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600692B")]
		[Address(RVA = "0x9DF8C0", Offset = "0x9DECC0", VA = "0x1809DF8C0")]
		set
		{
		}
	}

	[Token(Token = "0x170016AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FighterMonsterLightInformation MonsterInformation
	{
		[Token(Token = "0x600692C")]
		[Address(RVA = "0xBC3CD0", Offset = "0xBC30D0", VA = "0x180BC3CD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600692D")]
		[Address(RVA = "0xB7AE40", Offset = "0xB7A240", VA = "0x180B7AE40")]
		set
		{
		}
	}

	[Token(Token = "0x170016AD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterEntityLightInformation EntityInformation
	{
		[Token(Token = "0x600692E")]
		[Address(RVA = "0xBC3C70", Offset = "0xBC3070", VA = "0x180BC3C70")]
		get
		{
			return null;
		}
		[Token(Token = "0x600692F")]
		[Address(RVA = "0xBC4600", Offset = "0xBC3A00", VA = "0x180BC4600")]
		set
		{
		}
	}

	[Token(Token = "0x170016AE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterTaxCollectorLightInformation TaxCollectorInformation
	{
		[Token(Token = "0x6006930")]
		[Address(RVA = "0xBC3DE0", Offset = "0xBC31E0", VA = "0x180BC3DE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006931")]
		[Address(RVA = "0xBC4680", Offset = "0xBC3A80", VA = "0x180BC4680")]
		set
		{
		}
	}

	[Token(Token = "0x170016AF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FighterNamedLightInformation NamedInformation
	{
		[Token(Token = "0x6006932")]
		[Address(RVA = "0xBC3D30", Offset = "0xBC3130", VA = "0x180BC3D30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006933")]
		[Address(RVA = "0xBC4640", Offset = "0xBC3A40", VA = "0x180BC4640")]
		set
		{
		}
	}

	[Token(Token = "0x170016B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FighterInfoOneofCase FighterInfoCase
	{
		[Token(Token = "0x6006934")]
		[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
		get
		{
			return default(FighterInfoOneofCase);
		}
	}

	[Token(Token = "0x600691D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterLightInformation()
	{
	}

	[Token(Token = "0x600691E")]
	[Address(RVA = "0xBC38A0", Offset = "0xBC2CA0", VA = "0x180BC38A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterLightInformation(FighterLightInformation other)
	{
	}

	[Token(Token = "0x600691F")]
	[Address(RVA = "0xBC2DB0", Offset = "0xBC21B0", VA = "0x180BC2DB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterLightInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6006935")]
	[Address(RVA = "0x95F130", Offset = "0x95E530", VA = "0x18095F130")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFighterInfo()
	{
	}

	[Token(Token = "0x6006936")]
	[Address(RVA = "0xBC2F80", Offset = "0xBC2380", VA = "0x180BC2F80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006937")]
	[Address(RVA = "0xBC2E10", Offset = "0xBC2210", VA = "0x180BC2E10", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FighterLightInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006938")]
	[Address(RVA = "0xBC3120", Offset = "0xBC2520", VA = "0x180BC3120", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006939")]
	[Address(RVA = "0xBC3740", Offset = "0xBC2B40", VA = "0x180BC3740", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600693A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600693B")]
	[Address(RVA = "0xBC4270", Offset = "0xBC3670", VA = "0x180BC4270", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600693C")]
	[Address(RVA = "0xBC2AB0", Offset = "0xBC1EB0", VA = "0x180BC2AB0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600693D")]
	[Address(RVA = "0xBC3400", Offset = "0xBC2800", VA = "0x180BC3400", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FighterLightInformation other)
	{
	}

	[Token(Token = "0x600693E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600693F")]
	[Address(RVA = "0xBC3E40", Offset = "0xBC3240", VA = "0x180BC3E40", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
