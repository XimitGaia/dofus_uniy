using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B1C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountData : IMessage<MountData>, IMessage, IEquatable<MountData>, IDeepCloneable<MountData>, IBufferMessage
{
	[Token(Token = "0x4002945")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountData> _parser;

	[Token(Token = "0x4002946")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002947")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002948")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4002949")]
	[FieldOffset(Offset = "0x20")]
	private long id_;

	[Token(Token = "0x400294A")]
	public const int ModelIdFieldNumber = 2;

	[Token(Token = "0x400294B")]
	[FieldOffset(Offset = "0x28")]
	private int modelId_;

	[Token(Token = "0x400294C")]
	public const int AncestorsFieldNumber = 3;

	[Token(Token = "0x400294D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_ancestors_codec;

	[Token(Token = "0x400294E")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<int> ancestors_;

	[Token(Token = "0x400294F")]
	public const int BehaviorsFieldNumber = 4;

	[Token(Token = "0x4002950")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_behaviors_codec;

	[Token(Token = "0x4002951")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<int> behaviors_;

	[Token(Token = "0x4002952")]
	public const int NameFieldNumber = 5;

	[Token(Token = "0x4002953")]
	[FieldOffset(Offset = "0x40")]
	private string name_;

	[Token(Token = "0x4002954")]
	public const int GenderFieldNumber = 6;

	[Token(Token = "0x4002955")]
	[FieldOffset(Offset = "0x48")]
	private Gender gender_;

	[Token(Token = "0x4002956")]
	public const int OwnerIdFieldNumber = 7;

	[Token(Token = "0x4002957")]
	[FieldOffset(Offset = "0x50")]
	private long ownerId_;

	[Token(Token = "0x4002958")]
	public const int ExperienceFieldNumber = 8;

	[Token(Token = "0x4002959")]
	[FieldOffset(Offset = "0x58")]
	private long experience_;

	[Token(Token = "0x400295A")]
	public const int ExperienceForLevelFieldNumber = 9;

	[Token(Token = "0x400295B")]
	[FieldOffset(Offset = "0x60")]
	private long experienceForLevel_;

	[Token(Token = "0x400295C")]
	public const int ExperienceForNextLevelFieldNumber = 10;

	[Token(Token = "0x400295D")]
	[FieldOffset(Offset = "0x18")]
	private static readonly long ExperienceForNextLevelDefaultValue;

	[Token(Token = "0x400295E")]
	[FieldOffset(Offset = "0x68")]
	private long experienceForNextLevel_;

	[Token(Token = "0x400295F")]
	public const int LevelFieldNumber = 11;

	[Token(Token = "0x4002960")]
	[FieldOffset(Offset = "0x70")]
	private int level_;

	[Token(Token = "0x4002961")]
	public const int IsRideableFieldNumber = 12;

	[Token(Token = "0x4002962")]
	[FieldOffset(Offset = "0x74")]
	private bool isRideable_;

	[Token(Token = "0x4002963")]
	public const int MaxPodsFieldNumber = 13;

	[Token(Token = "0x4002964")]
	[FieldOffset(Offset = "0x78")]
	private int maxPods_;

	[Token(Token = "0x4002965")]
	public const int IsWildFieldNumber = 14;

	[Token(Token = "0x4002966")]
	[FieldOffset(Offset = "0x7C")]
	private bool isWild_;

	[Token(Token = "0x4002967")]
	public const int StaminaFieldNumber = 15;

	[Token(Token = "0x4002968")]
	[FieldOffset(Offset = "0x80")]
	private int stamina_;

	[Token(Token = "0x4002969")]
	public const int StaminaMaxFieldNumber = 16;

	[Token(Token = "0x400296A")]
	[FieldOffset(Offset = "0x84")]
	private int staminaMax_;

	[Token(Token = "0x400296B")]
	public const int MaturityFieldNumber = 17;

	[Token(Token = "0x400296C")]
	[FieldOffset(Offset = "0x88")]
	private int maturity_;

	[Token(Token = "0x400296D")]
	public const int MaturityForAdultFieldNumber = 18;

	[Token(Token = "0x400296E")]
	[FieldOffset(Offset = "0x8C")]
	private int maturityForAdult_;

	[Token(Token = "0x400296F")]
	public const int EnergyFieldNumber = 19;

	[Token(Token = "0x4002970")]
	[FieldOffset(Offset = "0x90")]
	private int energy_;

	[Token(Token = "0x4002971")]
	public const int EnergyMaxFieldNumber = 20;

	[Token(Token = "0x4002972")]
	[FieldOffset(Offset = "0x94")]
	private int energyMax_;

	[Token(Token = "0x4002973")]
	public const int SerenityFieldNumber = 21;

	[Token(Token = "0x4002974")]
	[FieldOffset(Offset = "0x98")]
	private int serenity_;

	[Token(Token = "0x4002975")]
	public const int AggressivenessMaxFieldNumber = 22;

	[Token(Token = "0x4002976")]
	[FieldOffset(Offset = "0x9C")]
	private int aggressivenessMax_;

	[Token(Token = "0x4002977")]
	public const int SerenityMaxFieldNumber = 23;

	[Token(Token = "0x4002978")]
	[FieldOffset(Offset = "0xA0")]
	private int serenityMax_;

	[Token(Token = "0x4002979")]
	public const int LoveFieldNumber = 24;

	[Token(Token = "0x400297A")]
	[FieldOffset(Offset = "0xA4")]
	private int love_;

	[Token(Token = "0x400297B")]
	public const int LoveMaxFieldNumber = 25;

	[Token(Token = "0x400297C")]
	[FieldOffset(Offset = "0xA8")]
	private int loveMax_;

	[Token(Token = "0x400297D")]
	public const int FertilizationTimeFieldNumber = 26;

	[Token(Token = "0x400297E")]
	[FieldOffset(Offset = "0xAC")]
	private int fertilizationTime_;

	[Token(Token = "0x400297F")]
	public const int IsFertilizationReadyFieldNumber = 27;

	[Token(Token = "0x4002980")]
	[FieldOffset(Offset = "0xB0")]
	private bool isFertilizationReady_;

	[Token(Token = "0x4002981")]
	public const int BoostLimiterFieldNumber = 28;

	[Token(Token = "0x4002982")]
	[FieldOffset(Offset = "0xB4")]
	private int boostLimiter_;

	[Token(Token = "0x4002983")]
	public const int BoostMaxFieldNumber = 29;

	[Token(Token = "0x4002984")]
	[FieldOffset(Offset = "0xB8")]
	private long boostMax_;

	[Token(Token = "0x4002985")]
	public const int ReproductionCountFieldNumber = 30;

	[Token(Token = "0x4002986")]
	[FieldOffset(Offset = "0xC0")]
	private int reproductionCount_;

	[Token(Token = "0x4002987")]
	public const int ReproductionCountMaxFieldNumber = 31;

	[Token(Token = "0x4002988")]
	[FieldOffset(Offset = "0xC8")]
	private long reproductionCountMax_;

	[Token(Token = "0x4002989")]
	public const int HarnessGidFieldNumber = 32;

	[Token(Token = "0x400298A")]
	[FieldOffset(Offset = "0xD0")]
	private int harnessGid_;

	[Token(Token = "0x400298B")]
	public const int UseHarnessColorsFieldNumber = 33;

	[Token(Token = "0x400298C")]
	[FieldOffset(Offset = "0xD4")]
	private bool useHarnessColors_;

	[Token(Token = "0x400298D")]
	public const int EffectsFieldNumber = 34;

	[Token(Token = "0x400298E")]
	[FieldOffset(Offset = "0x20")]
	private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

	[Token(Token = "0x400298F")]
	[FieldOffset(Offset = "0xD8")]
	private readonly RepeatedField<ObjectEffect> effects_;

	[Token(Token = "0x170019AE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MountData> Parser
	{
		[Token(Token = "0x60074E5")]
		[Address(RVA = "0xC04C10", Offset = "0xC04010", VA = "0x180C04C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019AF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60074E6")]
		[Address(RVA = "0xC04A40", Offset = "0xC03E40", VA = "0x180C04A40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60074E7")]
		[Address(RVA = "0xC059B0", Offset = "0xC04DB0", VA = "0x180C059B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019B1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Id
	{
		[Token(Token = "0x60074EB")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60074EC")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170019B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ModelId
	{
		[Token(Token = "0x60074ED")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60074EE")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170019B3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Ancestors
	{
		[Token(Token = "0x60074EF")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019B4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Behaviors
	{
		[Token(Token = "0x60074F0")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019B5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x60074F1")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x60074F2")]
		[Address(RVA = "0xC05BA0", Offset = "0xC04FA0", VA = "0x180C05BA0")]
		set
		{
		}
	}

	[Token(Token = "0x170019B6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Gender Gender
	{
		[Token(Token = "0x60074F3")]
		[Address(RVA = "0x7D9E50", Offset = "0x7D9250", VA = "0x1807D9E50")]
		get
		{
			return default(Gender);
		}
		[Token(Token = "0x60074F4")]
		[Address(RVA = "0xBA6350", Offset = "0xBA5750", VA = "0x180BA6350")]
		set
		{
		}
	}

	[Token(Token = "0x170019B7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long OwnerId
	{
		[Token(Token = "0x60074F5")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60074F6")]
		[Address(RVA = "0xBD54C0", Offset = "0xBD48C0", VA = "0x180BD54C0")]
		set
		{
		}
	}

	[Token(Token = "0x170019B8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Experience
	{
		[Token(Token = "0x60074F7")]
		[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60074F8")]
		[Address(RVA = "0xBC8B10", Offset = "0xBC7F10", VA = "0x180BC8B10")]
		set
		{
		}
	}

	[Token(Token = "0x170019B9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ExperienceForLevel
	{
		[Token(Token = "0x60074F9")]
		[Address(RVA = "0x7D7250", Offset = "0x7D6650", VA = "0x1807D7250")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60074FA")]
		[Address(RVA = "0xBA6360", Offset = "0xBA5760", VA = "0x180BA6360")]
		set
		{
		}
	}

	[Token(Token = "0x170019BA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ExperienceForNextLevel
	{
		[Token(Token = "0x60074FB")]
		[Address(RVA = "0xC04B10", Offset = "0xC03F10", VA = "0x180C04B10")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60074FC")]
		[Address(RVA = "0xC05AE0", Offset = "0xC04EE0", VA = "0x180C05AE0")]
		set
		{
		}
	}

	[Token(Token = "0x170019BB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasExperienceForNextLevel
	{
		[Token(Token = "0x60074FD")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019BC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Level
	{
		[Token(Token = "0x60074FF")]
		[Address(RVA = "0xC04BC0", Offset = "0xC03FC0", VA = "0x180C04BC0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007500")]
		[Address(RVA = "0xC05B40", Offset = "0xC04F40", VA = "0x180C05B40")]
		set
		{
		}
	}

	[Token(Token = "0x170019BD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsRideable
	{
		[Token(Token = "0x6007501")]
		[Address(RVA = "0xC04BA0", Offset = "0xC03FA0", VA = "0x180C04BA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007502")]
		[Address(RVA = "0xC05B20", Offset = "0xC04F20", VA = "0x180C05B20")]
		set
		{
		}
	}

	[Token(Token = "0x170019BE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxPods
	{
		[Token(Token = "0x6007503")]
		[Address(RVA = "0xC04C00", Offset = "0xC04000", VA = "0x180C04C00")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007504")]
		[Address(RVA = "0xC05B90", Offset = "0xC04F90", VA = "0x180C05B90")]
		set
		{
		}
	}

	[Token(Token = "0x170019BF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWild
	{
		[Token(Token = "0x6007505")]
		[Address(RVA = "0xC04BB0", Offset = "0xC03FB0", VA = "0x180C04BB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007506")]
		[Address(RVA = "0xC05B30", Offset = "0xC04F30", VA = "0x180C05B30")]
		set
		{
		}
	}

	[Token(Token = "0x170019C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Stamina
	{
		[Token(Token = "0x6007507")]
		[Address(RVA = "0xC04CB0", Offset = "0xC040B0", VA = "0x180C04CB0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007508")]
		[Address(RVA = "0xC05C60", Offset = "0xC05060", VA = "0x180C05C60")]
		set
		{
		}
	}

	[Token(Token = "0x170019C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StaminaMax
	{
		[Token(Token = "0x6007509")]
		[Address(RVA = "0xC04CA0", Offset = "0xC040A0", VA = "0x180C04CA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600750A")]
		[Address(RVA = "0xC05C50", Offset = "0xC05050", VA = "0x180C05C50")]
		set
		{
		}
	}

	[Token(Token = "0x170019C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Maturity
	{
		[Token(Token = "0x600750B")]
		[Address(RVA = "0xC04BF0", Offset = "0xC03FF0", VA = "0x180C04BF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600750C")]
		[Address(RVA = "0xC05B80", Offset = "0xC04F80", VA = "0x180C05B80")]
		set
		{
		}
	}

	[Token(Token = "0x170019C3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaturityForAdult
	{
		[Token(Token = "0x600750D")]
		[Address(RVA = "0xC04BE0", Offset = "0xC03FE0", VA = "0x180C04BE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600750E")]
		[Address(RVA = "0xC05B70", Offset = "0xC04F70", VA = "0x180C05B70")]
		set
		{
		}
	}

	[Token(Token = "0x170019C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Energy
	{
		[Token(Token = "0x600750F")]
		[Address(RVA = "0xC04B00", Offset = "0xC03F00", VA = "0x180C04B00")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007510")]
		[Address(RVA = "0xC05AD0", Offset = "0xC04ED0", VA = "0x180C05AD0")]
		set
		{
		}
	}

	[Token(Token = "0x170019C5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EnergyMax
	{
		[Token(Token = "0x6007511")]
		[Address(RVA = "0xC04AF0", Offset = "0xC03EF0", VA = "0x180C04AF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007512")]
		[Address(RVA = "0xC05AC0", Offset = "0xC04EC0", VA = "0x180C05AC0")]
		set
		{
		}
	}

	[Token(Token = "0x170019C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Serenity
	{
		[Token(Token = "0x6007513")]
		[Address(RVA = "0xC04C90", Offset = "0xC04090", VA = "0x180C04C90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007514")]
		[Address(RVA = "0xC05C40", Offset = "0xC05040", VA = "0x180C05C40")]
		set
		{
		}
	}

	[Token(Token = "0x170019C7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AggressivenessMax
	{
		[Token(Token = "0x6007515")]
		[Address(RVA = "0xC04A10", Offset = "0xC03E10", VA = "0x180C04A10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007516")]
		[Address(RVA = "0xC05A90", Offset = "0xC04E90", VA = "0x180C05A90")]
		set
		{
		}
	}

	[Token(Token = "0x170019C8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SerenityMax
	{
		[Token(Token = "0x6007517")]
		[Address(RVA = "0xC04C80", Offset = "0xC04080", VA = "0x180C04C80")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007518")]
		[Address(RVA = "0xC05C30", Offset = "0xC05030", VA = "0x180C05C30")]
		set
		{
		}
	}

	[Token(Token = "0x170019C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Love
	{
		[Token(Token = "0x6007519")]
		[Address(RVA = "0xC04BD0", Offset = "0xC03FD0", VA = "0x180C04BD0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600751A")]
		[Address(RVA = "0xC05B60", Offset = "0xC04F60", VA = "0x180C05B60")]
		set
		{
		}
	}

	[Token(Token = "0x170019CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LoveMax
	{
		[Token(Token = "0x600751B")]
		[Address(RVA = "0x7D9540", Offset = "0x7D8940", VA = "0x1807D9540")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600751C")]
		[Address(RVA = "0xC05B50", Offset = "0xC04F50", VA = "0x180C05B50")]
		set
		{
		}
	}

	[Token(Token = "0x170019CB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FertilizationTime
	{
		[Token(Token = "0x600751D")]
		[Address(RVA = "0xC04B80", Offset = "0xC03F80", VA = "0x180C04B80")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600751E")]
		[Address(RVA = "0xC05AF0", Offset = "0xC04EF0", VA = "0x180C05AF0")]
		set
		{
		}
	}

	[Token(Token = "0x170019CC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsFertilizationReady
	{
		[Token(Token = "0x600751F")]
		[Address(RVA = "0x8725D0", Offset = "0x8719D0", VA = "0x1808725D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007520")]
		[Address(RVA = "0xC05B10", Offset = "0xC04F10", VA = "0x180C05B10")]
		set
		{
		}
	}

	[Token(Token = "0x170019CD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BoostLimiter
	{
		[Token(Token = "0x6007521")]
		[Address(RVA = "0xC04A20", Offset = "0xC03E20", VA = "0x180C04A20")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007522")]
		[Address(RVA = "0xC05AA0", Offset = "0xC04EA0", VA = "0x180C05AA0")]
		set
		{
		}
	}

	[Token(Token = "0x170019CE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long BoostMax
	{
		[Token(Token = "0x6007523")]
		[Address(RVA = "0xC04A30", Offset = "0xC03E30", VA = "0x180C04A30")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007524")]
		[Address(RVA = "0xC05AB0", Offset = "0xC04EB0", VA = "0x180C05AB0")]
		set
		{
		}
	}

	[Token(Token = "0x170019CF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ReproductionCount
	{
		[Token(Token = "0x6007525")]
		[Address(RVA = "0xC04C70", Offset = "0xC04070", VA = "0x180C04C70")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007526")]
		[Address(RVA = "0xC05C20", Offset = "0xC05020", VA = "0x180C05C20")]
		set
		{
		}
	}

	[Token(Token = "0x170019D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ReproductionCountMax
	{
		[Token(Token = "0x6007527")]
		[Address(RVA = "0xC04C60", Offset = "0xC04060", VA = "0x180C04C60")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007528")]
		[Address(RVA = "0xC05C10", Offset = "0xC05010", VA = "0x180C05C10")]
		set
		{
		}
	}

	[Token(Token = "0x170019D1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HarnessGid
	{
		[Token(Token = "0x6007529")]
		[Address(RVA = "0xC04B90", Offset = "0xC03F90", VA = "0x180C04B90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600752A")]
		[Address(RVA = "0xC05B00", Offset = "0xC04F00", VA = "0x180C05B00")]
		set
		{
		}
	}

	[Token(Token = "0x170019D2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool UseHarnessColors
	{
		[Token(Token = "0x600752B")]
		[Address(RVA = "0xC04CC0", Offset = "0xC040C0", VA = "0x180C04CC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600752C")]
		[Address(RVA = "0xC05C70", Offset = "0xC05070", VA = "0x180C05C70")]
		set
		{
		}
	}

	[Token(Token = "0x170019D3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectEffect> Effects
	{
		[Token(Token = "0x600752D")]
		[Address(RVA = "0x877AC0", Offset = "0x876EC0", VA = "0x180877AC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074E8")]
	[Address(RVA = "0xC048F0", Offset = "0xC03CF0", VA = "0x180C048F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountData()
	{
	}

	[Token(Token = "0x60074E9")]
	[Address(RVA = "0xC046B0", Offset = "0xC03AB0", VA = "0x180C046B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountData(MountData other)
	{
	}

	[Token(Token = "0x60074EA")]
	[Address(RVA = "0xC038F0", Offset = "0xC02CF0", VA = "0x180C038F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountData Clone()
	{
		return null;
	}

	[Token(Token = "0x60074FE")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearExperienceForNextLevel()
	{
	}

	[Token(Token = "0x600752E")]
	[Address(RVA = "0xC03C60", Offset = "0xC03060", VA = "0x180C03C60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600752F")]
	[Address(RVA = "0xC03950", Offset = "0xC02D50", VA = "0x180C03950", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007530")]
	[Address(RVA = "0xC03CC0", Offset = "0xC030C0", VA = "0x180C03CC0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007531")]
	[Address(RVA = "0xC04430", Offset = "0xC03830", VA = "0x180C04430", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007532")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007533")]
	[Address(RVA = "0xC05360", Offset = "0xC04760", VA = "0x180C05360", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007534")]
	[Address(RVA = "0xC03270", Offset = "0xC02670", VA = "0x180C03270", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007535")]
	[Address(RVA = "0xC04180", Offset = "0xC03580", VA = "0x180C04180", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountData other)
	{
	}

	[Token(Token = "0x6007536")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007537")]
	[Address(RVA = "0xC04CD0", Offset = "0xC040D0", VA = "0x180C04CD0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
